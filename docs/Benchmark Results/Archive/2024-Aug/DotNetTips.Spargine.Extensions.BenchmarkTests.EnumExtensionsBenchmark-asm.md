## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetDescription()
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
       call      qword ptr [7FFE8C4CE970]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
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
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       rcx,rbx
       xor       eax,eax
       test      rcx,rcx
       setne     al
       test      eax,eax
       je        near ptr M01_L04
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
       mov       rdx,rbx
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M01_L06
       mov       rcx,1E397C05300
       mov       rsi,[rcx]
       mov       rcx,1E397C051A0
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
M01_L00:
       mov       r14,[rdi+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [rdi+15],0
       je        short M01_L03
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M01_L01:
       lea       rdx,[rbp-30]
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rbx
       mov       r9d,r15d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFE8C0FF948]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L10
M01_L02:
       mov       rax,[rbp-30]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rdx,rbx
       mov       r11,7FFE8BB50930
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,0FEA
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,9EA
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFE8BF16670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L05:
       mov       ecx,2BD
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF166E8]
       int       3
M01_L06:
       call      qword ptr [7FFE8C28DCE0]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L07
       call      qword ptr [7FFE8C28DC38]
       mov       r14,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,22429D38180
       mov       r8,r14
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E397C052F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFE8C4CAA60
       call      qword ptr [7FFE8BC94210]
       mov       rcx,1E397C05300
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L09:
       mov       ecx,0BB4
       mov       rdx,7FFE8C115DD0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C3766A0]
       int       3
M01_L10:
       mov       byte ptr [rbp-38],1
       mov       [rbp-34],r15d
       mov       rdx,rbx
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-30]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,[rbp-38]
       mov       rcx,rdi
       call      qword ptr [7FFE8C0FFA38]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M01_L02
; Total bytes of code 667
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetItems()
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
       call      qword ptr [7FFE8C515830]; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumExtensions+<>c__DisplayClass2_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rbx,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFE8BBE4948]; System.Enum.GetValues(System.Type)
       mov       rbx,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.Enum, System.Private.CoreLib]]
       call      qword ptr [7FFE8BC94330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L02
       test      rbx,rbx
       je        near ptr M01_L03
       mov       rcx,offset MT_System.Linq.Enumerable+<CastIterator>d__68`1[[System.Enum, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+2C],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L03
M01_L00:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Enum, System.Private.CoreLib]]
       call      qword ptr [7FFE8BC94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L04
       mov       rdx,rdi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Enum, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Enum>)
       call      qword ptr [7FFE8C515DD0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
M01_L01:
       mov       rcx,offset MT_System.Converter`2[[System.Enum, System.Private.CoreLib],[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,7FFE8C5118C0
       mov       [rdi+18],r8
       mov       r8,rdi
       mov       rdx,rbx
       mov       rcx,offset MD_System.Array.ConvertAll[[System.Enum, System.Private.CoreLib],[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](System.Enum[], System.Converter`2<System.Enum,System.ValueTuple`2<System.String,Int32>>)
       call      qword ptr [7FFE8C515A40]; System.Array.ConvertAll[[System.__Canon, System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](System.__Canon[], System.Converter`2<System.__Canon,System.ValueTuple`2<System.__Canon,Int32>>)
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      rsi,rsi
       je        short M01_L05
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L00
M01_L03:
       mov       ecx,10
       call      qword ptr [7FFE8BF14F30]
       int       3
M01_L04:
       mov       rcx,rax
       mov       r11,7FFE8BB50920
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L01
M01_L05:
       mov       ecx,14
       call      qword ptr [7FFE8BEEECD0]
       int       3
; Total bytes of code 379
```

