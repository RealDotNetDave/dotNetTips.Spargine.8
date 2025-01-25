## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9DAD200]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
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
       mov       rcx,2198A80E740
       mov       rsi,[rcx]
       mov       rcx,2198A80E5D8
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
       call      qword ptr [7FFBF99CF948]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
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
       mov       r11,7FFBF9420930
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FFBF9B5CCD8]
       mov       ecx,1088
       mov       rdx,7FFBF98E4148
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0A14
       mov       rdx,7FFBF98E4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFBF9B5CAC8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFBF97E6670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L05:
       mov       ecx,2BD
       mov       rdx,7FFBF9414000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF97E66E8]
       int       3
M01_L06:
       call      qword ptr [7FFBF9B5CB88]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L07
       call      qword ptr [7FFBF9B5CAE0]
       mov       r14,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,25A186E8180
       mov       r8,r14
       call      qword ptr [7FFBF961D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2198A80E738
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFBF9DA92F0
       call      qword ptr [7FFBF9564210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2198A80E740
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L09:
       mov       ecx,0BB4
       mov       rdx,7FFBF99E79E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9C45680]
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
       call      qword ptr [7FFBF99CFA38]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M01_L02
; Total bytes of code 667
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9D8CF60]; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
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
       call      qword ptr [7FFBF9494948]; System.Enum.GetValues(System.Type)
       mov       rbx,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.Enum, System.Private.CoreLib]]
       call      qword ptr [7FFBF9544330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
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
       call      qword ptr [7FFBF9544348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L04
       mov       rdx,rdi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Enum, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Enum>)
       call      qword ptr [7FFBF9D8D500]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
M01_L01:
       mov       rcx,offset MT_System.Converter`2[[System.Enum, System.Private.CoreLib],[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,7FFBF9D88FF0
       mov       [rdi+18],r8
       mov       r8,rdi
       mov       rdx,rbx
       mov       rcx,offset MD_System.Array.ConvertAll[[System.Enum, System.Private.CoreLib],[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](System.Enum[], System.Converter`2<System.Enum,System.ValueTuple`2<System.String,Int32>>)
       call      qword ptr [7FFBF9D8D170]; System.Array.ConvertAll[[System.__Canon, System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](System.__Canon[], System.Converter`2<System.__Canon,System.ValueTuple`2<System.__Canon,Int32>>)
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
       call      qword ptr [7FFBF97C4F30]
       int       3
M01_L04:
       mov       rcx,rax
       mov       r11,7FFBF94009E0
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L01
M01_L05:
       mov       ecx,14
       call      qword ptr [7FFBF979ED00]
       int       3
; Total bytes of code 379
```

