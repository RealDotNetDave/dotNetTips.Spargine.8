## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllInterfaces01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF80C06C078]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      qword ptr [7FF80C64D920]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
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
       call      qword ptr [7FF80C06C060]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L15
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,26176A0CD38
       mov       [rsi+8],rcx
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rbx],rcx
       jne       near ptr M02_L19
       mov       rcx,rbx
       call      qword ptr [7FF80C083670]; System.Reflection.Assembly.GetTypes()
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
       jne       near ptr M02_L13
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M02_L10
       mov       rbx,[rax]
       test      rbx,rbx
       je        near ptr M02_L10
M02_L02:
       cmp       [rbx],bl
       lea       r15,[rbx+50]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M02_L11
M02_L03:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,5
       cmp       [rcx],ecx
       call      qword ptr [7FF80C165038]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetMemberList(MemberListType, System.String, CacheType)
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
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,rbx
       mov       r8d,r15d
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M02_L12
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M02_L05:
       mov       rdx,r13
M02_L06:
       mov       rcx,rsi
       call      qword ptr [7FF80BF6E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       add       ebp,1
       jo        near ptr M02_L14
       cmp       r14d,ebp
       jg        near ptr M02_L01
M02_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,26176A030B8
       jmp       short M02_L06
M02_L10:
       call      qword ptr [7FF80BE06658]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       jmp       near ptr M02_L02
M02_L11:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.RuntimeType, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L03
       mov       rcx,r13
       jmp       near ptr M02_L03
M02_L12:
       call      qword ptr [7FF80BF65BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L05
M02_L13:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M02_L06
M02_L14:
       call      CORINFO_HELP_OVERFLOW
M02_L15:
       call      qword ptr [7FF80C3CC348]
       mov       rcx,26176A0B670
       mov       rdx,26176A00210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,26176A00008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M02_L16
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M02_L17
M02_L16:
       mov       ecx,1
M02_L17:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L18
       call      qword ptr [7FF80C3CC468]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C2207C8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C2207C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3C7A68]
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C3CC060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3CC5E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FF80C116670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L18:
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
M02_L19:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdi,rax
       jmp       near ptr M02_L00
; Total bytes of code 795
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllTypes01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF80C05C078]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      qword ptr [7FF80C645EF0]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
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
       call      qword ptr [7FF80C05C060]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        near ptr M02_L05
       mov       rax,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rcx],rax
       jne       near ptr M02_L09
       call      qword ptr [7FF80C073670]; System.Reflection.Assembly.GetTypes()
       mov       rbx,rax
M02_L00:
       mov       rdx,2CFE600BD68
       mov       rsi,[rdx]
       test      rsi,rsi
       je        near ptr M02_L10
M02_L01:
       test      rbx,rbx
       je        near ptr M02_L16
       test      rsi,rsi
       je        near ptr M02_L11
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator`1[[System.Type, System.Private.CoreLib]]
       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L12
       mov       rdx,rbx
       mov       rcx,offset MT_System.Type[]
       call      qword ptr [7FF80BEA4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L14
       cmp       dword ptr [rdi+8],0
       je        near ptr M02_L13
       mov       rcx,offset MT_System.Linq.Enumerable+WhereArrayIterator`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       test      rbp,rbp
       je        near ptr M02_L16
M02_L03:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Type, System.Private.CoreLib]]
       call      qword ptr [7FF80BEA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L17
       mov       rcx,rax
       mov       r11,7FF80BD60860
       call      qword ptr [r11]
       mov       rsi,rax
M02_L04:
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       call      qword ptr [7FF80C3BC348]
       mov       rcx,31077F1B670
       mov       rdx,31077F10210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,31077F10008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M02_L06
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M02_L07
M02_L06:
       mov       ecx,1
M02_L07:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L08
       call      qword ptr [7FF80C3BC468]
       mov       rbp,rax
       mov       ecx,770
       mov       rdx,7FF80C2111B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C2111B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3B7A68]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3BC060]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF80C3BC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L08:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3BC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L09:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M02_L00
M02_L10:
       mov       rcx,offset MT_System.Func`2[[System.Type, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2CFE600BD60
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FF80C641FB0
       call      qword ptr [7FF80BEA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2CFE600BD68
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L11:
       mov       ecx,0C
       call      qword ptr [7FF80C104F30]
       int       3
M02_L12:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rbp,rax
       jmp       near ptr M02_L02
M02_L13:
       mov       rcx,7FF80C01F690
       mov       edx,4
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2CFE6001EF8
       mov       rbp,[rdx]
       jmp       near ptr M02_L02
M02_L14:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M02_L15
       mov       rcx,offset MT_System.Linq.Enumerable+WhereListIterator`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FF80C2D6C88]
       mov       rbp,rbx
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FF80C6C74B0]
       test      rbp,rbp
       jne       near ptr M02_L03
M02_L16:
       mov       ecx,10
       call      qword ptr [7FF80C104F30]
       int       3
M02_L17:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FF80BF5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L04
; Total bytes of code 915
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetInstances01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF80C05C078]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2`1[[DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark, DotNetTips.Spargine.Extensions.BenchmarkTests]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+2C],eax
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
       call      qword ptr [7FF80C05C060]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```

