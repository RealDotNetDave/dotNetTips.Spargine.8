## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllInterfaces01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE1866C078]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      qword ptr [7FFE18D97A98]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
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
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE1866C060]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L13
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1A006801E98
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rbx],rcx
       jne       near ptr M02_L14
       mov       rcx,rbx
       call      qword ptr [7FFE18657418]; System.Reflection.Assembly.GetTypes()
       mov       rdi,rax
M02_L00:
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M02_L07
M02_L01:
       mov       ecx,ebp
       mov       rcx,[rdi+rcx*8+10]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M02_L12
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M02_L10
       mov       r15,[rax]
       test      r15,r15
       je        near ptr M02_L10
M02_L02:
       cmp       [r15],r15b
       lea       r13,[r15+50]
       mov       rcx,[r13]
       test      rcx,rcx
       je        near ptr M02_L15
M02_L03:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,5
       cmp       [rcx],ecx
       call      qword ptr [7FFE18755038]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetMemberList(MemberListType, System.String, CacheType)
       test      rax,rax
       je        near ptr M02_L08
       lea       rbx,[rax+10]
       mov       r15d,[rax+8]
M02_L04:
       test      r15d,r15d
       je        near ptr M02_L09
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,rbx
       mov       r8d,r15d
       shl       r8,3
       cmp       r8,4000
       ja        short M02_L11
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M02_L05:
       mov       rdx,r12
M02_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1852E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M02_L01
M02_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
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
M02_L08:
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,1A006801D80
       mov       rdx,[rdx]
       jmp       short M02_L06
M02_L10:
       call      qword ptr [7FFE183C6658]; System.RuntimeType.InitializeCache()
       mov       r15,rax
       jmp       near ptr M02_L02
M02_L11:
       call      qword ptr [7FFE18525BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L05
M02_L12:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M02_L06
M02_L13:
       call      qword ptr [7FFE1899FB58]
       mov       ecx,2D
       mov       rdx,7FFE189493A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,146C
       mov       rdx,7FFE18805138
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE189493A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE1899F948]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FFE18706670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M02_L14:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdi,rax
       jmp       near ptr M02_L00
M02_L15:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.RuntimeType, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L03
       mov       rcx,rbx
       jmp       near ptr M02_L03
; Total bytes of code 652
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllTypes01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE1867C078]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      qword ptr [7FFE18D97AB0]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
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
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE1867C060]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        near ptr M02_L06
       mov       rax,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rcx],rax
       jne       near ptr M02_L07
       call      qword ptr [7FFE18667418]; System.Reflection.Assembly.GetTypes()
       mov       rbx,rax
M02_L00:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+8]
       mov       edx,edi
       test      edx,edx
       je        near ptr M02_L08
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L01:
       xor       ebp,ebp
       test      edi,edi
       jle       short M02_L05
M02_L02:
       mov       ecx,ebp
       mov       r14,[rbx+rcx*8+10]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       near ptr M02_L09
       mov       rcx,r14
       call      System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)
M02_L03:
       test      al,80
       jne       short M02_L04
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M02_L10
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       movsxd    rdx,edx
       mov       r8,r14
       call      CORINFO_HELP_ARRADDR_ST
M02_L04:
       inc       ebp
       cmp       edi,ebp
       jg        short M02_L02
M02_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L06:
       call      qword ptr [7FFE189AFB58]
       mov       ecx,2D
       mov       rdx,7FFE189593A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE189593A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE189AF948]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbp
       call      qword ptr [7FFE18716670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M02_L07:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M02_L00
M02_L08:
       mov       rcx,26BEB001E98
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+70]
       call      qword ptr [rax+18]
       jmp       near ptr M02_L03
M02_L10:
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFE1853E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L04
; Total bytes of code 466
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetInstances01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE1868C078]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2`1[[DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark, DotNetTips.Spargine.Extensions.BenchmarkTests]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+34],eax
       lea       rcx,[rdi+18]
       mov       rdx,rsi
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
; Total bytes of code 108
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE1868C060]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetTypes()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE1866C078]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       mov       rdx,1F61A657398
       call      qword ptr [7FFE18D97AE0]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetTypes(System.Reflection.Assembly, System.Type)
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
; Total bytes of code 75
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE1866C060]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetTypes(System.Reflection.Assembly, System.Type)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       test      rcx,rcx
       je        near ptr M02_L16
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rax,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rcx],rax
       jne       near ptr M02_L18
       call      qword ptr [7FFE18657418]; System.Reflection.Assembly.GetTypes()
       mov       rsi,rax
M02_L00:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebp,[rsi+8]
       mov       edx,ebp
       test      edx,edx
       je        near ptr M02_L19
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L01:
       xor       r14d,r14d
       test      ebp,ebp
       jle       near ptr M02_L10
       mov       r15,offset MT_System.RuntimeType
       cmp       [rbx],r15
       jne       near ptr M02_L08
M02_L02:
       mov       ecx,r14d
       mov       r13,[rsi+rcx*8+10]
       mov       r12,[r13]
       cmp       r12,r15
       jne       near ptr M02_L20
       mov       rcx,r13
       call      System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)
M02_L03:
       test      al,80
       jne       short M02_L06
       cmp       r13,rbx
       je        short M02_L07
       cmp       r12,r15
       jne       near ptr M02_L21
       mov       rcx,r13
       test      rcx,rcx
       je        near ptr M02_L22
M02_L04:
       cmp       [rcx],r15
       jne       near ptr M02_L22
       mov       rdx,rbx
       call      System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M02_L05:
       test      eax,eax
       jne       short M02_L07
M02_L06:
       inc       r14d
       cmp       ebp,r14d
       jg        short M02_L02
       jmp       short M02_L10
M02_L07:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       r12d,[rdi+10]
       cmp       [rcx+8],r12d
       jbe       near ptr M02_L26
       lea       edx,[r12+1]
       mov       [rdi+10],edx
       movsxd    rdx,r12d
       mov       r8,r13
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L06
M02_L08:
       mov       ecx,r14d
       mov       r13,[rsi+rcx*8+10]
       mov       r15,offset MT_System.RuntimeType
       cmp       [r13],r15
       jne       near ptr M02_L27
       mov       rcx,r13
       call      System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)
       jmp       short M02_L11
M02_L09:
       inc       r14d
       cmp       ebp,r14d
       jg        short M02_L08
M02_L10:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
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
M02_L11:
       test      al,80
       jne       short M02_L09
       cmp       [rbx],r15
       jne       near ptr M02_L33
       cmp       r13,rbx
       je        short M02_L14
       cmp       [r13],r15
       jne       near ptr M02_L28
       mov       rcx,r13
       test      rcx,rcx
       je        near ptr M02_L29
M02_L12:
       cmp       [rcx],r15
       jne       near ptr M02_L29
       mov       rdx,rbx
       call      System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M02_L13:
       test      eax,eax
       je        short M02_L09
M02_L14:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       r12d,[rdi+10]
       cmp       [rcx+8],r12d
       jbe       short M02_L15
       lea       edx,[r12+1]
       mov       [rdi+10],edx
       movsxd    rdx,r12d
       mov       r8,r13
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M02_L09
M02_L15:
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FFE1852E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L09
M02_L16:
       call      qword ptr [7FFE1899FB58]
       mov       ecx,2D
       mov       rdx,7FFE189493A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18805150
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE189493A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE1899F948]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rsi
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L17:
       call      qword ptr [7FFE1899FB58]
       mov       ecx,3F
       mov       rdx,7FFE189493A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,146C
       mov       rdx,7FFE18805150
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,1
       mov       rdx,7FFE189493A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE1899F948]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M02_L00
M02_L19:
       mov       rcx,1B588801E98
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L20:
       mov       rcx,r13
       mov       rax,[r12+70]
       call      qword ptr [rax+18]
       jmp       near ptr M02_L03
M02_L21:
       mov       rcx,r13
       mov       rax,[r12+58]
       call      qword ptr [rax]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L04
M02_L22:
       mov       rdx,r13
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FFE18474360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L06
       mov       rcx,r13
       mov       rdx,rbx
       mov       rax,[r12+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M02_L07
       mov       rcx,rbx
       call      qword ptr [7FFE183C4E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M02_L23
       mov       rcx,r13
       mov       rdx,rbx
       call      qword ptr [7FFE183C6148]
       jmp       near ptr M02_L05
M02_L23:
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        near ptr M02_L06
       mov       rcx,rbx
       call      qword ptr [7FFE183BA5A0]; Precode of System.RuntimeType.GetGenericParameterConstraints()
       mov       r12,rax
       xor       eax,eax
       jmp       short M02_L25
M02_L24:
       mov       [rsp+24],eax
       mov       ecx,eax
       mov       rcx,[r12+rcx*8+10]
       mov       rdx,r13
       mov       r8,[rcx]
       mov       r8,[r8+0B0]
       call      qword ptr [r8+20]
       test      eax,eax
       je        near ptr M02_L06
       mov       ecx,[rsp+24]
       inc       ecx
       mov       eax,ecx
M02_L25:
       cmp       [r12+8],eax
       jg        short M02_L24
       jmp       near ptr M02_L07
M02_L26:
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FFE1852E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L06
M02_L27:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+70]
       call      qword ptr [rax+18]
       jmp       near ptr M02_L11
M02_L28:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L12
M02_L29:
       mov       rdx,r13
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FFE18474360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L09
       mov       rcx,r13
       mov       rdx,rbx
       mov       rax,[r13]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M02_L14
       mov       rcx,rbx
       call      qword ptr [7FFE183C4E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M02_L30
       mov       rcx,r13
       mov       rdx,rbx
       call      qword ptr [7FFE183C6148]
       jmp       near ptr M02_L13
M02_L30:
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        near ptr M02_L09
       mov       rcx,rbx
       call      qword ptr [7FFE183BA5A0]; Precode of System.RuntimeType.GetGenericParameterConstraints()
       mov       r12,rax
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M02_L32
M02_L31:
       mov       ecx,r15d
       mov       rcx,[r12+rcx*8+10]
       mov       rdx,r13
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M02_L09
       inc       r15d
M02_L32:
       cmp       [r12+8],r15d
       jg        short M02_L31
       jmp       near ptr M02_L14
M02_L33:
       mov       rcx,rbx
       mov       rdx,r13
       mov       rax,[rbx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L13
; Total bytes of code 1302
```

