## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,2436022AB58
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,2210BB4AB58
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,1AD3715AB58
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,2278FEEAB58
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,2C28A5AAB58
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetTypeMembersWithAttribute()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.TypeExtensions.GetTypeMembersWithAttribute[[System.Text.Json.Serialization.JsonPropertyNameAttribute, System.Text.Json]](System.Type)
       mov       rdx,25F27F8AB58
       call      qword ptr [7FFBF9DAD2A8]; DotNetTips.Spargine.Extensions.TypeExtensions.GetTypeMembersWithAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)
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
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Extensions.TypeExtensions.GetTypeMembersWithAttribute[[System.__Canon, System.Private.CoreLib]](System.Type)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,138
       vzeroupper
       lea       rbp,[rsp+170]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-140],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L75
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L81
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        near ptr M01_L07
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L07
M01_L01:
       cmp       [rdi],dil
       lea       r14,[rdi+48]
       mov       rcx,[r14]
       test      rcx,rcx
       je        near ptr M01_L76
M01_L02:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L78
       mov       r15,[rcx+8]
M01_L03:
       mov       r13d,[r15+8]
       mov       edx,r13d
       xor       ecx,ecx
       mov       [rbp-0C8],rcx
       mov       [rbp-0C0],rcx
       mov       [rbp-0B8],ecx
       mov       [rbp-0B4],edx
       xor       edi,edi
       test      r13d,r13d
       jle       short M01_L06
M01_L04:
       mov       edx,edi
       mov       r8,[r15+rdx*8+10]
       mov       edx,[r8+18]
       mov       ecx,edx
       and       ecx,1E
       cmp       ecx,edx
       je        near ptr M01_L77
M01_L05:
       inc       edi
       cmp       r13d,edi
       jg        short M01_L04
M01_L06:
       mov       r12,[rbp-0C8]
       mov       rdi,[rbp-0C0]
       mov       r14d,[rbp-0B8]
       test      r14d,r14d
       jne       short M01_L08
       mov       rdx,21E9A001F38
       mov       r15,[rdx]
       jmp       short M01_L10
M01_L07:
       mov       rcx,rsi
       call      qword ptr [7FFBF94B6658]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L08:
       cmp       r14d,1
       je        near ptr M01_L79
       test      r14d,r14d
       jl        near ptr M01_L83
       mov       r15,r12
       test      r15,r15
       je        near ptr M01_L80
       cmp       [r12+8],r14d
       jne       short M01_L11
M01_L09:
       mov       r15,r12
M01_L10:
       jmp       short M01_L12
M01_L11:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       lea       rcx,[r12+10]
       lea       rdx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r14d,r8d
       cmovg     r14d,r8d
       mov       r8d,r14d
       shl       r8,3
       call      qword ptr [7FFBF9615BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L09
M01_L12:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L20
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,rax
       mov       r13,[r14+8]
       test      r13,r13
       je        short M01_L16
M01_L14:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L21
M01_L15:
       mov       rdx,r15
       mov       r8,r13
       call      qword ptr [7FFBF9DAD5C0]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.ValueTuple`5<System.__Canon,System.__Canon,Boolean,Boolean,System.__Canon>>)
       mov       r15,rax
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rsi],rdx
       jne       near ptr M01_L85
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-0E0]
       mov       rcx,rsi
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFBF94B66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-0D0],0
       jne       near ptr M01_L22
       mov       rdx,21E9A001E08
       mov       r13,[rdx]
       jmp       near ptr M01_L24
M01_L16:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L17
       mov       rcx,[rcx+60]
       test      rcx,rcx
       jne       short M01_L19
M01_L17:
       mov       rcx,rbx
       mov       rdx,7FFBF9DB1DB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,[r14]
       test      rdx,rdx
       je        near ptr M01_L73
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.TypeExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<GetTypeMembersWithAttribute>b__14_0(System.Reflection.FieldInfo)
       mov       [r13+18],rcx
       lea       rcx,[r14+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L14
M01_L19:
       jmp       short M01_L18
M01_L20:
       mov       rcx,rbx
       mov       rdx,7FFBF9DB0EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,rbx
       mov       rdx,7FFBF9DB11E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       cmp       dword ptr [rbp-0D0],1
       je        near ptr M01_L82
       mov       r13d,[rbp-0D0]
       test      r13d,r13d
       jl        near ptr M01_L83
       mov       rdi,[rbp-0E0]
       test      rdi,rdi
       je        near ptr M01_L84
       cmp       [rdi+8],r13d
       jne       short M01_L25
M01_L23:
       mov       ecx,[rbp-0D0]
       mov       [rbp-0CC],ecx
       mov       r13,[rbp-0E0]
M01_L24:
       jmp       short M01_L26
M01_L25:
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       lea       rcx,[r12+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       r13d,r8d
       cmovg     r13d,r8d
       mov       r8d,r13d
       shl       r8,3
       call      qword ptr [7FFBF9615BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbp-0E0],r12
       jmp       short M01_L23
M01_L26:
       mov       rsi,[r14+10]
       test      rsi,rsi
       je        near ptr M01_L68
M01_L27:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M01_L59
M01_L28:
       mov       rdx,r13
       mov       r8,rsi
       call      qword ptr [7FFBF9DAD5C0]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.ValueTuple`5<System.__Canon,System.__Canon,Boolean,Boolean,System.__Canon>>)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L60
M01_L29:
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FFBF9DAD920]; System.Linq.Enumerable.Concat[[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.ValueTuple`5<System.__Canon,System.__Canon,Boolean,Boolean,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.ValueTuple`5<System.__Canon,System.__Canon,Boolean,Boolean,System.__Canon>>)
       mov       r15,rax
       mov       rsi,[r14+18]
       test      rsi,rsi
       je        near ptr M01_L65
M01_L30:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M01_L56
       mov       rdi,[rcx+30]
       test      rdi,rdi
       je        near ptr M01_L56
M01_L31:
       mov       r13,rdi
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L57
       mov       r12,[rcx+38]
       test      r12,r12
       je        near ptr M01_L57
M01_L32:
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FFBF9DAD9E0]; System.Linq.Enumerable.Where[[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.ValueTuple`5<System.__Canon,System.__Canon,Boolean,Boolean,System.__Canon>>, System.Func`2<System.ValueTuple`5<System.__Canon,System.__Canon,Boolean,Boolean,System.__Canon>,Boolean>)
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFBF9DADA40]; System.Linq.Enumerable.ToArray[[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.ValueTuple`5<System.__Canon,System.__Canon,Boolean,Boolean,System.__Canon>>)
       mov       r15,rax
       mov       rsi,[r14+20]
       test      rsi,rsi
       je        near ptr M01_L61
M01_L33:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L58
       mov       r14,[rcx+40]
       test      r14,r14
       je        near ptr M01_L58
M01_L34:
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FFBF9DAD9E0]; System.Linq.Enumerable.Where[[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.ValueTuple`5<System.__Canon,System.__Canon,Boolean,Boolean,System.__Canon>>, System.Func`2<System.ValueTuple`5<System.__Canon,System.__Canon,Boolean,Boolean,System.__Canon>,Boolean>)
       mov       rcx,rax
       mov       r11,r14
       call      qword ptr [r14]
       mov       r14,rax
       mov       [rbp-138],r14
       mov       rax,offset MT_System.Linq.Enumerable+WhereArrayIterator`1[[System.ValueTuple`5[[System.String, System.Private.CoreLib],[System.Text.Json.Serialization.JsonPropertyNameAttribute, System.Text.Json],[System.Boolean, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.Type, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [r14],rax
       jne       near ptr M01_L53
       mov       r13,r14
       mov       esi,[r13+0C]
       dec       esi
       mov       rdi,[r13+30]
       mov       r12d,[rdi+8]
       cmp       r12d,esi
       jbe       short M01_L37
M01_L35:
       cmp       esi,r12d
       jae       short M01_L38
       mov       eax,esi
       shl       rax,5
       lea       rax,[rdi+rax+10]
       movzx     esi,byte ptr [rax+18]
       mov       [rbp-10C],esi
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymmword ptr [rbp-108],ymm0
       mov       eax,[r13+0C]
       lea       ecx,[rax+1]
       mov       [r13+0C],ecx
       mov       ecx,eax
       mov       r8,[r13+38]
       mov       rax,offset DotNetTips.Spargine.Extensions.TypeExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<GetTypeMembersWithAttribute>b__14_3(System.ValueTuple`5<System.String,System.__Canon,Boolean,Boolean,System.Type>)
       cmp       [r8+18],rax
       jne       near ptr M01_L51
       mov       eax,[r8+8]
       mov       edx,esi
       test      edx,edx
       jne       near ptr M01_L52
M01_L36:
       cmp       r12d,ecx
       mov       esi,ecx
       ja        short M01_L35
M01_L37:
       xor       eax,eax
       mov       [r13+10],rax
       mov       [r13+18],rax
       mov       [r13+20],rax
       mov       [r13+28],rax
       mov       dword ptr [r13+0C],0FFFFFFFF
       jmp       near ptr M01_L54
M01_L38:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L39:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L40
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L40
       jmp       short M01_L41
M01_L40:
       mov       rcx,rbx
       mov       rdx,7FFBF9DB18E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L41:
       lea       rdx,[rbp-60]
       mov       rcx,r14
       call      qword ptr [r11]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-0B0],ymm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       lea       rcx,[rbp-0B0]
       mov       edx,41
       mov       r8d,2
       call      qword ptr [7FFBF97456B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       vmovdqu   ymm0,ymmword ptr [rbp-0B0]
       vmovdqu   ymmword ptr [rbp-88],ymm0
       mov       rcx,[rbp-90]
       mov       [rbp-68],rcx
       mov       ecx,[rbp-78]
       cmp       ecx,[rbp-68]
       ja        near ptr M01_L46
       mov       rdx,[rbp-70]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-68]
       sub       eax,ecx
       cmp       eax,8
       jb        short M01_L42
       mov       rcx,25F27F8AB8C
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       ecx,[rbp-78]
       add       ecx,8
       mov       [rbp-78],ecx
       jmp       short M01_L43
M01_L42:
       lea       rcx,[rbp-88]
       mov       rdx,25F27F8AB80
       call      qword ptr [7FFBF97458F0]
M01_L43:
       lea       rcx,[rbp-88]
       mov       rdx,[rbp-60]
       call      qword ptr [7FFBF9745830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-78]
       cmp       ecx,[rbp-68]
       ja        near ptr M01_L46
       mov       rdx,[rbp-70]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-68]
       sub       eax,ecx
       cmp       eax,20
       jb        short M01_L44
       mov       rcx,25F27F8ABB4
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymm1,ymmword ptr [rcx+20]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymmword ptr [rdx+20],ymm1
       mov       ecx,[rbp-78]
       add       ecx,20
       mov       [rbp-78],ecx
       jmp       short M01_L45
M01_L44:
       lea       rcx,[rbp-88]
       mov       rdx,25F27F8ABA8
       call      qword ptr [7FFBF97458F0]
M01_L45:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFBF94B6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       lea       rcx,[rbp-88]
       call      qword ptr [7FFBF9745830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ebx,[rbp-78]
       cmp       ebx,[rbp-68]
       jbe       short M01_L47
M01_L46:
       call      qword ptr [7FFBF97BE9D0]
       int       3
M01_L47:
       mov       rcx,[rbp-70]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-68]
       sub       edx,ebx
       cmp       edx,19
       jb        short M01_L48
       mov       rdx,25F27F8AC0C
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymm1,ymmword ptr [rdx+12]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+12],ymm1
       mov       ecx,[rbp-78]
       add       ecx,19
       mov       [rbp-78],ecx
       jmp       short M01_L49
M01_L48:
       lea       rcx,[rbp-88]
       mov       rdx,25F27F8AC00
       call      qword ptr [7FFBF97458F0]
M01_L49:
       lea       rcx,[rbp-88]
       call      qword ptr [7FFBF9745740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L50
       call      qword ptr [7FFBF9B5CAE0]
       mov       rbx,rax
M01_L50:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,25F27F8AC48
       mov       r8,rbx
       call      qword ptr [7FFBF961D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L51:
       mov       [rbp-0E4],ecx
       mov       [rbp-0F0],sil
       vmovdqu   ymm0,ymmword ptr [rbp-108]
       vmovdqu   ymmword ptr [rbp-130],ymm0
       lea       rdx,[rbp-130]
       mov       rcx,[r8+8]
       call      qword ptr [r8+18]
       mov       edx,eax
       test      edx,edx
       mov       ecx,[rbp-0E4]
       je        near ptr M01_L36
M01_L52:
       add       r13,10
       mov       rdi,r13
       lea       rsi,[rbp-108]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       r15d,[rbp-10C]
       mov       [r13+18],r15b
       jmp       near ptr M01_L39
M01_L53:
       mov       rcx,r14
       mov       r11,7FFBF9420A30
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L39
M01_L54:
       mov       rax,offset MT_System.Linq.Enumerable+WhereArrayIterator`1[[System.ValueTuple`5[[System.String, System.Private.CoreLib],[System.Text.Json.Serialization.JsonPropertyNameAttribute, System.Text.Json],[System.Boolean, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.Type, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [r14],rax
       jne       near ptr M01_L74
       xor       eax,eax
       mov       [r14+10],rax
       mov       [r14+18],rax
       mov       [r14+20],rax
       mov       [r14+28],rax
       mov       dword ptr [r14+0C],0FFFFFFFF
M01_L55:
       mov       rax,r15
       vzeroupper
       add       rsp,138
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L56:
       mov       rcx,rbx
       mov       rdx,7FFBF9DB1688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
       jmp       near ptr M01_L31
M01_L57:
       mov       rcx,rbx
       mov       rdx,7FFBF9DB17B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r12,rax
       jmp       near ptr M01_L32
M01_L58:
       mov       rcx,rbx
       mov       rdx,7FFBF9DB17E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
       jmp       near ptr M01_L34
M01_L59:
       mov       rcx,rbx
       mov       rdx,7FFBF9DB1258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L28
M01_L60:
       mov       rcx,rbx
       mov       rdx,7FFBF9DB1388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L29
M01_L61:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L62
       mov       rcx,[rcx+50]
       test      rcx,rcx
       jne       short M01_L64
M01_L62:
       mov       rcx,rbx
       mov       rdx,7FFBF9DB1C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L63:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[r14]
       test      rdx,rdx
       je        near ptr M01_L73
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.TypeExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<GetTypeMembersWithAttribute>b__14_3(System.ValueTuple`5<System.String,System.__Canon,Boolean,Boolean,System.Type>)
       mov       [rsi+18],rcx
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L33
M01_L64:
       jmp       short M01_L63
M01_L65:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L66
       mov       rcx,[rcx+50]
       test      rcx,rcx
       jne       near ptr M01_L72
M01_L66:
       mov       rcx,rbx
       mov       rdx,7FFBF9DB1C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L67:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[r14]
       test      rdx,rdx
       je        near ptr M01_L73
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.TypeExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<GetTypeMembersWithAttribute>b__14_2(System.ValueTuple`5<System.String,System.__Canon,Boolean,Boolean,System.Type>)
       mov       [rsi+18],rcx
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L30
M01_L68:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L69
       mov       rcx,[rcx+58]
       test      rcx,rcx
       jne       short M01_L71
M01_L69:
       mov       rcx,rbx
       mov       rdx,7FFBF9DB1D68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L70:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[r14]
       test      rdx,rdx
       je        short M01_L73
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.TypeExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<GetTypeMembersWithAttribute>b__14_1(System.Reflection.PropertyInfo)
       mov       [rsi+18],rcx
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L27
M01_L71:
       jmp       short M01_L70
M01_L72:
       jmp       near ptr M01_L67
M01_L73:
       call      qword ptr [7FFBF95641F8]
       int       3
M01_L74:
       mov       rcx,r14
       mov       r11,7FFBF9420A38
       call      qword ptr [r11]
       jmp       near ptr M01_L55
M01_L75:
       call      qword ptr [7FFBF9B5CCD8]
       mov       ecx,3F
       mov       rdx,7FFBF9A26FE0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E4940
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFBF9A26FE0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
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
M01_L76:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimeFieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,r12
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,r12
       jmp       near ptr M01_L02
M01_L77:
       lea       rcx,[rbp-0C8]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFBF9834BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M01_L05
M01_L78:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFBF9834E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L79:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L10
M01_L80:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       jmp       near ptr M01_L09
M01_L81:
       mov       rcx,rsi
       mov       edx,1C
       mov       rax,[rsi]
       mov       rax,[rax+80]
       call      qword ptr [rax+28]
       mov       r15,rax
       jmp       near ptr M01_L12
M01_L82:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r13,rax
       mov       rcx,r13
       mov       r8,[rbp-0D8]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L24
M01_L83:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFBF97BED48]
       int       3
M01_L84:
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-0E0],rax
       jmp       near ptr M01_L23
M01_L85:
       mov       rcx,rsi
       mov       edx,1C
       mov       rax,[rsi]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M01_L26
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+170]
       cmp       qword ptr [rbp-138],0
       je        short M01_L87
       mov       rcx,offset MT_System.Linq.Enumerable+WhereArrayIterator`1[[System.ValueTuple`5[[System.String, System.Private.CoreLib],[System.Text.Json.Serialization.JsonPropertyNameAttribute, System.Text.Json],[System.Boolean, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib],[System.Type, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       rax,[rbp-138]
       cmp       [rax],rcx
       jne       short M01_L86
       xor       ecx,ecx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       [rax+20],rcx
       mov       [rax+28],rcx
       mov       dword ptr [rax+0C],0FFFFFFFF
       jmp       short M01_L87
M01_L86:
       mov       rcx,rax
       mov       r11,7FFBF9420A38
       call      qword ptr [r11]
M01_L87:
       nop
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 3085
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetTypeOfType()
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rcx,1D606102F98
       cmp       [rcx],ecx
       call      qword ptr [7FFBF949A5D8]; System.RuntimeType.IsValueTypeImpl()
       test      eax,eax
       jne       near ptr M00_L04
       mov       rcx,1D606102F98
       call      System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)
       test      al,20
       jne       near ptr M00_L08
       mov       rcx,1D606102F98
       cmp       [rcx],ecx
       call      qword ptr [7FFBF949A5D8]; System.RuntimeType.IsValueTypeImpl()
       test      eax,eax
       jne       near ptr M00_L08
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],3
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       rcx,1D606102F98
       mov       rdx,1D60611AB80
       mov       r8d,0FFFFFFFF
       mov       r9d,1C
       call      qword ptr [7FFBF94A6838]; System.RuntimeType.GetMethodImplCommon(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
       test      rax,rax
       je        short M00_L02
       mov       rcx,rax
       mov       rdx,1D606115258
       mov       r8d,1
       call      qword ptr [7FFBF9824168]; System.Attribute.GetCustomAttributes(System.Reflection.MemberInfo, System.Type, Boolean)
       test      rax,rax
       je        short M00_L00
       cmp       dword ptr [rax+8],0
       jne       short M00_L05
M00_L00:
       xor       edx,edx
M00_L01:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M00_L02
       mov       r8,offset MT_System.Runtime.CompilerServices.CompilerGeneratedAttribute
       cmp       [rcx],r8
       jne       short M00_L07
       mov       r10d,3
       jmp       short M00_L03
M00_L02:
       mov       r10d,2
M00_L03:
       mov       [rbp-10],r10d
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rbp-10]
       call      qword ptr [7FFBF9D9D488]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Extensions.TypeExtensions+TypeOfType, DotNetTips.Spargine.8.Extensions]](TypeOfType ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M00_L04:
       mov       r10d,1
       jmp       short M00_L03
M00_L05:
       mov       rcx,[rax+10]
       cmp       dword ptr [rax+8],1
       jne       short M00_L06
       mov       rdx,rcx
       jmp       short M00_L01
M00_L06:
       call      qword ptr [7FFBF97AF1C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L07:
       mov       rcx,r8
       call      qword ptr [7FFBF95543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L08:
       xor       r10d,r10d
       jmp       short M00_L03
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
       mov       rdx,1D606105F60
       call      qword ptr [7FFBF949A7A8]; System.RuntimeType.IsSubclassOf(System.Type)
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
       jne       near ptr M02_L14
       mov       r13d,1
M02_L00:
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M02_L13
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M02_L13
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
       call      qword ptr [7FFBF97FCEA0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       je        short M02_L04
M02_L03:
       mov       r13,rax
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FFBF9824E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       jmp       short M02_L03
M02_L05:
       mov       edi,[r13+8]
       mov       ecx,edi
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],eax
       mov       [rsp+4C],ecx
       xor       r15d,r15d
       test      edi,edi
       jle       short M02_L09
M02_L06:
       mov       ecx,r15d
       mov       r12,[r13+rcx*8+10]
       cmp       ebx,0FFFFFFFF
       je        short M02_L07
       mov       rcx,[r12+50]
       call      System.RuntimeMethodHandle.GetGenericParameterCount(System.RuntimeMethodHandleInternal)
       cmp       eax,ebx
       jne       short M02_L08
M02_L07:
       mov       [rsp+20],rbp
       mov       edx,[r12+58]
       mov       rcx,r12
       mov       r8d,esi
       mov       r9d,r14d
       call      qword ptr [7FFBF94A65B0]; System.RuntimeType.FilterApplyMethodBase(System.Reflection.MethodBase, System.Reflection.BindingFlags, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[])
       test      eax,eax
       je        short M02_L08
       lea       rcx,[rsp+38]
       mov       r8,r12
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.MethodInfo, System.Private.CoreLib]]
       call      qword ptr [7FFBF9824BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L08:
       inc       r15d
       cmp       edi,r15d
       jg        short M02_L06
M02_L09:
       vmovdqu   xmm0,xmmword ptr [rsp+38]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rax,[rsp+48]
       mov       [rsp+60],rax
       cmp       dword ptr [rsp+60],0
       je        near ptr M02_L19
       test      rbp,rbp
       jne       near ptr M02_L20
M02_L10:
       cmp       qword ptr [rsp+50],0
       je        short M02_L12
       mov       rax,[rsp+50]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M02_L31
       mov       rax,[rsp+50]
       mov       rdi,[rax+10]
M02_L11:
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
M02_L12:
       mov       rdi,[rsp+58]
       jmp       short M02_L11
M02_L13:
       mov       rcx,rdi
       call      qword ptr [7FFBF94A6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       near ptr M02_L01
M02_L14:
       mov       rcx,19578000590
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFBF975C1C8]
       mov       r15,rax
       mov       r13d,2
       jmp       near ptr M02_L00
M02_L15:
       lea       rcx,[rdi+28]
       mov       r8,r15
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimeMethodInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFBF97FCEA0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r13,rax
       test      r13,r13
       jne       short M02_L16
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8d,2
       xor       r9d,r9d
       call      qword ptr [7FFBF9824E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
M02_L16:
       jmp       near ptr M02_L05
M02_L17:
       cmp       byte ptr [rdi+18],0
       je        short M02_L18
       mov       r13,[rdi+8]
       jmp       near ptr M02_L05
M02_L18:
       mov       rcx,rdi
       mov       r8d,r13d
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFBF9824E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M02_L05
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
       jmp       near ptr M02_L10
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
       call      qword ptr [7FFBF9A85158]
       test      eax,eax
       jne       short M02_L25
       mov       rcx,rdi
       call      qword ptr [7FFBF97AF1B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M02_L25:
       inc       esi
M02_L26:
       cmp       esi,[rsp+60]
       jl        short M02_L22
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.MethodInfo, System.Private.CoreLib]]
       call      qword ptr [7FFBF9824B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       edx,[rsp+60]
       call      qword ptr [7FFBF9A85188]
       mov       rdx,rax
       mov       rcx,offset MT_System.Reflection.MethodInfo
       call      qword ptr [7FFBF9554360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFBF94A5FC8]; System.Type.get_DefaultBinder()
       mov       rbx,rax
M02_L28:
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.MethodInfo, System.Private.CoreLib]]
       call      qword ptr [7FFBF9824B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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
       call      qword ptr [7FFBF9554360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
; Total bytes of code 1000
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
       mov       rbp,1D606102DB8
       mov       rcx,rbx
       call      qword ptr [7FFBF94A7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        near ptr M03_L12
M03_L00:
       cmp       rax,rbp
       je        short M03_L01
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFBF94A7330]; System.RuntimeType.GetBaseType()
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
       call      qword ptr [7FFBF9826100]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeMethodInfo, System.RuntimeType, Boolean)
M03_L04:
       mov       r8,rax
       test      r8,r8
       je        short M03_L05
       mov       rcx,offset MT_System.Attribute[]
       cmp       [r8],rcx
       je        short M03_L05
       mov       rdx,rax
       call      qword ptr [7FFBF9554390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       call      qword ptr [7FFBF9824000]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       jmp       short M03_L06
M03_L09:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FFBF95543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
       jmp       short M03_L08
M03_L10:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      qword ptr [7FFBF95543D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       movzx     r8d,dil
       mov       rdx,rbx
       call      qword ptr [7FFBF9824048]
       jmp       short M03_L06
M03_L11:
       mov       ecx,0D9
       mov       rdx,7FFBF9404000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF97D66E8]
       int       3
M03_L12:
       mov       rcx,1D606102D10
       cmp       rbp,rcx
       jne       short M03_L14
       mov       rcx,1D606102D10
       cmp       rbx,rcx
       jne       near ptr M03_L01
       jmp       short M03_L14
M03_L13:
       mov       rcx,rbx
       mov       rdx,1D606102DB8
       mov       rax,[rbx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M03_L01
M03_L14:
       mov       rcx,1D606102DB8
       cmp       rbx,rcx
       je        near ptr M03_L01
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B0E4F0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF955F708]
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
       mov       rdx,7FFBF9404000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF97D66E8]
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
       call      qword ptr [7FFBF9B0CE58]
       mov       rbx,rax
       mov       ecx,0E9
       mov       rdx,7FFBF9404000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFBF955F750]
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
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Extensions.TypeExtensions+TypeOfType, DotNetTips.Spargine.8.Extensions]](TypeOfType ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M05_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       je        short M05_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M05_L03
M05_L01:
       mov       rax,rdx
       ret
M05_L02:
       jmp       qword ptr [7FFBF95543A8]
M05_L03:
       test      r8,r8
       je        short M05_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       je        short M05_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       jne       short M05_L00
       jmp       short M05_L02
; Total bytes of code 71
```
**Extern method**
System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)

