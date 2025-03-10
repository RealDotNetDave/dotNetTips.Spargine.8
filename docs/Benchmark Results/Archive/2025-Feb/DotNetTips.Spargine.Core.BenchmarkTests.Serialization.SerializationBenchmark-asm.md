## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_JsonSerializer_Generator_Person_List()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+128]
       mov       rcx,27897C063D0
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L02
       mov       rcx,rdi
       call      qword ptr [7FFE5C9664D8]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       cmp       [rbp],bpl
       mov       rcx,2B925BAD828
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,0F
       je        near ptr M00_L05
       mov       rcx,2B925BAD828
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,10
       je        near ptr M00_L05
       mov       rcx,2B925BAD828
       call      System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L05
       mov       rcx,2B925BAD828
       call      qword ptr [7FFE5C4160B8]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L03
       test      rcx,rcx
       je        near ptr M00_L04
M00_L00:
       call      System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L05
       mov       rcx,rbp
       mov       byte ptr [rsp+40],0
       mov       byte ptr [rsp+41],0
       mov       dword ptr [rsp+20],1
       xor       edx,edx
       mov       [rsp+28],edx
       mov       rdx,2B925BAD828
       movzx     r9d,word ptr [rsp+40]
       mov       r8d,1
       call      qword ptr [7FFE5C965C98]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L06
       cmp       byte ptr [r14+115],2
       jne       near ptr M00_L07
M00_L01:
       mov       rdx,r14
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       mov       [rsp+30],rcx
       mov       [rsp+38],eax
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE5C967630]; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFE5C4C4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rsp+48],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,389E
       mov       rdx,7FFE5C976348
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C96C018]
       int       3
M00_L03:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L00
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE5CA0D098]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,3C04
       mov       rdx,7FFE5C976348
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,2B925BAD828
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE5C96C8E8]
       int       3
M00_L06:
       mov       rcx,2B925BAD828
       mov       rdx,rdi
       call      qword ptr [7FFE5C96CFA8]
       int       3
M00_L07:
       mov       rcx,r14
       call      qword ptr [7FFE5C9DCAC8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       near ptr M00_L01
; Total bytes of code 556
```
```assembly
; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L01
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C965DE8]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5C965E78]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE5C9663B8]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
; Total bytes of code 90
```
```assembly
; System.Type.GetRootElementType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       short M02_L04
M02_L00:
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,14
       je        short M02_L01
       cmp       eax,1D
       je        short M02_L01
       cmp       eax,0F
       je        short M02_L01
       xor       edx,edx
       cmp       eax,10
       sete      dl
       jmp       short M02_L02
M02_L01:
       mov       edx,1
M02_L02:
       test      edx,edx
       jne       short M02_L03
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       je        short M02_L00
M02_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edx,eax
       jmp       short M02_L02
; Total bytes of code 121
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp+28],r9
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       xor       r14d,r14d
       cmp       byte ptr [rsi+9D],0
       je        near ptr M03_L10
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M03_L12
M03_L00:
       mov       r13,[r15+8]
       mov       rcx,27897C08728
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M03_L13
       cmp       [r13],r13b
       test      rbx,rbx
       je        near ptr M03_L14
M03_L01:
       test      r12,r12
       je        near ptr M03_L15
       mov       r14,[r13+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [r13+15],0
       je        near ptr M03_L08
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
M03_L02:
       mov       [rbp-3C],eax
       lea       rdx,[rbp-48]
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rbx
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      qword ptr [7FFE5C8E4FD8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L16
M03_L03:
       mov       r8,[rbp-48]
       xor       eax,eax
       mov       [rbp-48],rax
       cmp       byte ptr [rbp+38],0
       jne       near ptr M03_L17
M03_L04:
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M03_L18
       mov       r14,[r8+8]
M03_L05:
       test      dil,dil
       je        short M03_L06
       test      r14,r14
       je        short M03_L06
       cmp       byte ptr [r14+115],2
       jne       short M03_L09
M03_L06:
       test      r14,r14
       je        short M03_L11
M03_L07:
       mov       rax,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L08:
       mov       rdx,rbx
       mov       r11,7FFE5C380E30
       call      qword ptr [r11]
       jmp       near ptr M03_L02
M03_L09:
       mov       rcx,r14
       call      qword ptr [7FFE5C9DCAC8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M03_L06
M03_L10:
       cmp       byte ptr [rbp+30],0
       je        short M03_L06
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5C966400]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r14,rax
       jmp       short M03_L06
M03_L11:
       cmp       byte ptr [rbp+29],0
       je        short M03_L07
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FFE5C96CF60]
       int       3
M03_L12:
       mov       rcx,rsi
       call      qword ptr [7FFE5C9664C0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r15,rax
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,offset MT_System.Func`3[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFE5C37D0E0
       call      qword ptr [7FFE5C4C4258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,27897C08728
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [r13],r13b
       test      rbx,rbx
       jne       near ptr M03_L01
M03_L14:
       mov       ecx,1
       mov       rdx,7FFE5C8F02D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5CB26190]
       int       3
M03_L15:
       mov       ecx,0BB4
       mov       rdx,7FFE5C8F02D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5CB26190]
       int       3
M03_L16:
       mov       edx,[rbp-3C]
       mov       byte ptr [rbp-50],1
       mov       [rbp-4C],edx
       mov       rdx,rbx
       mov       r8,r15
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-48]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,[rbp-50]
       mov       rcx,r13
       call      qword ptr [7FFE5C8E50C8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M03_L03
M03_L17:
       cmp       byte ptr [r8+20],0
       jne       near ptr M03_L04
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFE5C9DD800]
       mov       r14,rax
       jmp       near ptr M03_L05
M03_L18:
       call      qword ptr [7FFE5CA864A8]
       int       3
; Total bytes of code 627
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,248
       vzeroupper
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M04_L00:
       vmovdqa   xmmword ptr [rbp+rax+210],xmm4
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp+210],rax
       mov       [rbp],rsp
       mov       rax,405522E91A08
       mov       [rbp+8],rax
       mov       rbx,rdx
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       xor       edx,edx
       mov       [rbp+28],rdx
       cmp       edi,55
       jle       near ptr M04_L10
       cmp       edi,15555555
       ja        near ptr M04_L11
       mov       rdx,27897C03570
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFE5CC465F8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+28],rax
       test      rax,rax
       je        near ptr M04_L12
M04_L01:
       lea       r15,[rax+10]
       mov       r14d,[rax+8]
M04_L02:
       mov       rax,r15
M04_L03:
       mov       [rbp+10],rax
       mov       [rbp+64],r14d
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       mov       rcx,[rbp+10]
       mov       [rbp+40],rcx
       mov       ecx,[rbp+64]
       mov       [rbp+48],ecx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFE5C9DE3D0]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp+64]
       ja        near ptr M04_L06
       mov       rdx,[rbp+10]
       mov       [rbp+10],rdx
       mov       [rbp+64],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+94]
       movzx     r8d,byte ptr [rcx+92]
       cmp       r8d,2
       jg        near ptr M04_L05
       mov       ecx,[rcx+88]
       test      ecx,ecx
       jl        near ptr M04_L04
       xor       r10d,r10d
       mov       [rbp+1E0],r10
       mov       [rbp+1E8],r10
       mov       byte ptr [rbp+1F0],0
       mov       byte ptr [rbp+1F1],0
       mov       byte ptr [rbp+1F2],0
       mov       byte ptr [rbp+1F3],0
       mov       byte ptr [rbp+1F4],0
       mov       byte ptr [rbp+1F5],0
       mov       [rbp+1F8],ecx
       mov       [rbp+1FC],r8b
       mov       [rbp+1FD],r9b
       mov       byte ptr [rbp+1FE],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+200],xmm0
       vmovdqu   xmmword ptr [rbp+208],xmm0
       mov       [rbp+30],rdx
       mov       [rbp+38],eax
       lea       rdx,[rbp+30]
       lea       rcx,[rbp+120]
       lea       r9,[rbp+1E0]
       mov       r8d,1
       call      qword ptr [7FFE5CBB4210]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+80],ymm0
       vmovdqu   ymmword ptr [rbp+0A0],ymm0
       vmovdqu   ymmword ptr [rbp+0C0],ymm0
       vmovdqu   ymmword ptr [rbp+0E0],ymm0
       vmovdqu   ymmword ptr [rbp+100],ymm0
       lea       rcx,[rbp+80]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE5CBB52C0]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       cmp       [rbx],rcx
       jne       near ptr M04_L07
       lea       rcx,[rbp+80]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+150]
       mov       r9,[rbx+0B0]
       lea       r8,[rbp+78]
       lea       rdx,[rbp+120]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CA86508]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+78]
       xor       ecx,ecx
       mov       [rbp+78],rcx
       jmp       short M04_L08
M04_L04:
       mov       ecx,347F
       mov       rdx,7FFE5C976348
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C96C078]
       int       3
M04_L05:
       mov       ecx,347F
       mov       rdx,7FFE5C976348
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C96C0C0]
       int       3
M04_L06:
       call      qword ptr [7FFE5C6BE9D0]
       int       3
M04_L07:
       lea       r8,[rbp+80]
       lea       rdx,[rbp+120]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
M04_L08:
       mov       [rbp+20],rax
       mov       rcx,[rbp]
       call      M04_L13
       nop
       mov       rax,[rbp+20]
       mov       rcx,405522E91A08
       cmp       [rbp+8],rcx
       je        short M04_L09
       call      CORINFO_HELP_FAIL_FAST
M04_L09:
       nop
       lea       rsp,[rbp+218]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L10:
       test      [rsp],esp
       sub       rsp,100
       lea       rax,[rsp+30]
       mov       r14d,100
       jmp       near ptr M04_L03
M04_L11:
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       lea       rcx,[rbp+50]
       call      qword ptr [7FFE5C9DE3B8]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       test      rax,rax
       jne       near ptr M04_L01
M04_L12:
       xor       r15d,r15d
       xor       r14d,r14d
       jmp       near ptr M04_L02
M04_L13:
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
       lea       rbp,[rbp+30]
       cmp       qword ptr [rbp+28],0
       je        near ptr M04_L35
       mov       rcx,[rbp+10]
       mov       edx,[rbp+64]
       mov       [rbp+70],rdx
       test      rdx,rdx
       je        short M04_L15
       cmp       rdx,300
       ja        short M04_L14
       xor       edx,edx
       mov       r8d,[rbp+70]
       call      CORINFO_HELP_MEMSET
       jmp       short M04_L15
M04_L14:
       mov       rdx,[rbp+70]
       call      qword ptr [7FFE5C575BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M04_L15:
       mov       rcx,27897C03570
       mov       r14,[rcx]
       mov       rcx,[rbp+28]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,7FFE5C405120
       mov       edx,4B
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M04_L16
       mov       rcx,r14
       call      qword ptr [7FFE5CC2C768]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M04_L16:
       xor       r12d,r12d
       mov       ebx,1
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M04_L30
       mov       r12d,1
       mov       rdx,[rbp+28]
       mov       eax,10
       shlx      eax,eax,r13d
       cmp       [rdx+8],eax
       je        short M04_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE5CA0F1C8]
       mov       r13,rax
       mov       ecx,1D3
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [7FFE5C4CF750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M04_L17:
       mov       edx,r13d
       shl       rdx,4
       lea       rsi,[rcx+rdx+10]
       mov       r15,[rsi]
       mov       rdx,[rbp+28]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],eax
       test      r15,r15
       je        near ptr M04_L30
       mov       rcx,[r14+10]
       cmp       r13d,[rcx+8]
       jae       short M04_L19
       mov       edx,r13d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M04_L18
       mov       rcx,r14
       mov       edx,r13d
       call      qword ptr [7FFE5CC2C6F0]
M04_L18:
       mov       rbx,[rax+8]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       esi,[rax+0A3C]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[rsi-1]
       mov       [rax+0A3C],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M04_L20
       call      qword ptr [7FFE5CDEDD10]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M04_L21
M04_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L20:
       mov       eax,esi
       sar       eax,10
M04_L21:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       esi,eax
       sub       esi,ecx
       xor       edi,edi
       jmp       near ptr M04_L28
M04_L22:
       cmp       esi,[rbx+8]
       jae       short M04_L19
       mov       ecx,esi
       mov       rax,[rbx+rcx*8+10]
       mov       [rbp+18],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+6C],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+18]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp+68],r10d
       cmp       [rcx+8],r10d
       jbe       short M04_L24
       test      r10d,r10d
       jne       short M04_L25
       xor       edx,edx
       mov       [rax+14],edx
M04_L23:
       movsxd    rdx,r10d
       mov       r8,r15
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp+68]
       inc       ecx
       mov       rax,[rbp+18]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+6C],1
M04_L24:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp+6C]
       test      ecx,ecx
       je        short M04_L26
       mov       ecx,1
       jmp       short M04_L29
M04_L25:
       jmp       short M04_L23
M04_L26:
       inc       esi
       cmp       [rbx+8],esi
       jne       short M04_L27
       xor       esi,esi
M04_L27:
       inc       edi
M04_L28:
       cmp       [rbx+8],edi
       jg        near ptr M04_L22
       xor       ecx,ecx
M04_L29:
       mov       ebx,ecx
M04_L30:
       mov       rax,27893C005D0
       mov       rsi,[rax]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M04_L35
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+8],0
       je        near ptr M04_L35
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,[rbp+28]
       mov       r15d,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,r15d
       mov       edx,3
       call      qword ptr [7FFE5C577678]
       test      ebx,r12d
       jne       short M04_L35
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,[rbp+28]
       mov       edi,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      r12d,r12d
       jne       short M04_L31
       mov       ecx,0FFFFFFFF
       jmp       short M04_L32
M04_L31:
       mov       ecx,r13d
M04_L32:
       mov       edx,ebx
       mov       r8d,edi
       mov       r9d,eax
       test      r12d,r12d
       jne       short M04_L33
       mov       eax,1
       jmp       short M04_L34
M04_L33:
       xor       eax,eax
M04_L34:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,rsi
       call      qword ptr [7FFE5C7CF360]
M04_L35:
       nop
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
; Total bytes of code 1604
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M05_L00
       cmp       [rax],rcx
       jne       short M05_L01
M05_L00:
       ret
M05_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M05_L02:
       cmp       rdx,rcx
       je        short M05_L04
       test      rdx,rdx
       je        short M05_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M05_L04
       test      rdx,rdx
       je        short M05_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M05_L04
       test      rdx,rdx
       je        short M05_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M05_L04
       test      rdx,rdx
       je        short M05_L03
       mov       rdx,[rdx+10]
       jmp       short M05_L02
M05_L03:
       xor       eax,eax
M05_L04:
       ret
; Total bytes of code 82
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-50],rsp
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5C9DC528]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C9663B8]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5C9DC318]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.MakeReadOnly()
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+0E8]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-20],0
       jne       short M06_L00
       jmp       short M06_L01
M06_L00:
       mov       rcx,7FFE5D00E7A0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-28]
       call      qword ptr [7FFE5CA864A8]
M06_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5C9DC528]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C965C50]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-8],rax
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFE5C4CE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       movzx     ecx,byte ptr [rcx+115]
       test      ecx,ecx
       je        short M06_L02
       jmp       short M06_L05
M06_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+0E8]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-30],0
       jne       short M06_L03
       jmp       short M06_L04
M06_L03:
       mov       rcx,7FFE5D00E7A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE5CA864A8]
M06_L04:
       nop
       mov       rcx,7FFE5D00E7A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+115],1
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5C9DC768]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+115],2
       jmp       short M06_L06
M06_L05:
       mov       rcx,rsp
       call      M06_L08
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsp
       call      M06_L08
       nop
M06_L07:
       mov       rcx,7FFE5D00E7B4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,70
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       [rbp-40],rdx
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE5CA86478]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0E8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       byte ptr [rax+115],0
       call      CORINFO_HELP_RETHROW
       int       3
M06_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M06_L09
       mov       rcx,7FFE5D00E7AC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L09:
       mov       rcx,7FFE5D00E7B0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 489
```
**Extern method**
System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_JsonSerializer_Generator_Person()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+120]
       mov       rcx,214C88083C8
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,rdi
       call      qword ptr [7FFE5C975AE8]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       cmp       [rbp],bpl
       mov       rcx,2555A563DA0
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,0F
       je        near ptr M00_L07
       mov       rcx,2555A563DA0
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,10
       je        near ptr M00_L07
       mov       rcx,2555A563DA0
       call      System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L07
       mov       rcx,2555A563DA0
       call      qword ptr [7FFE5C4160B8]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L05
       test      rcx,rcx
       je        near ptr M00_L06
M00_L00:
       call      System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L07
       mov       rcx,rbp
       mov       byte ptr [rsp+40],0
       mov       byte ptr [rsp+41],0
       mov       dword ptr [rsp+20],1
       xor       edx,edx
       mov       [rsp+28],edx
       mov       rdx,2555A563DA0
       movzx     r9d,word ptr [rsp+40]
       mov       r8d,1
       call      qword ptr [7FFE5C9752A8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L08
       cmp       byte ptr [r14+115],2
       jne       near ptr M00_L09
M00_L01:
       mov       rdx,r14
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       mov       [rsp+30],rcx
       mov       [rsp+38],eax
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE5C976C40]; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       [rsp+48],rax
       test      rax,rax
       jne       short M00_L03
M00_L02:
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       xor       edx,edx
       cmp       [rax],rcx
       cmove     rdx,[rsp+48]
       mov       [rsp+48],rdx
       jmp       short M00_L02
M00_L04:
       mov       ecx,389E
       mov       rdx,7FFE5C965EE0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C977138]
       int       3
M00_L05:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L00
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE5CA0C990]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L07:
       mov       ecx,3C04
       mov       rdx,7FFE5C965EE0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,2555A563DA0
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE5C97C0F0]
       int       3
M00_L08:
       mov       rcx,2555A563DA0
       mov       rdx,rdi
       call      qword ptr [7FFE5C97C7B0]
       int       3
M00_L09:
       mov       rcx,r14
       call      qword ptr [7FFE5C9D7F90]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       near ptr M00_L01
; Total bytes of code 570
```
```assembly
; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L01
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C9753F8]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5C975488]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE5C9759C8]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
; Total bytes of code 90
```
```assembly
; System.Type.GetRootElementType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       short M02_L04
M02_L00:
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,14
       je        short M02_L01
       cmp       eax,1D
       je        short M02_L01
       cmp       eax,0F
       je        short M02_L01
       xor       edx,edx
       cmp       eax,10
       sete      dl
       jmp       short M02_L02
M02_L01:
       mov       edx,1
M02_L02:
       test      edx,edx
       jne       short M02_L03
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       je        short M02_L00
M02_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edx,eax
       jmp       short M02_L02
; Total bytes of code 121
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp+28],r9
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       xor       r14d,r14d
       cmp       byte ptr [rsi+9D],0
       je        near ptr M03_L10
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M03_L12
M03_L00:
       mov       r13,[r15+8]
       mov       rcx,214C880A720
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M03_L13
       cmp       [r13],r13b
       test      rbx,rbx
       je        near ptr M03_L14
M03_L01:
       test      r12,r12
       je        near ptr M03_L15
       mov       r14,[r13+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [r13+15],0
       je        near ptr M03_L08
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
M03_L02:
       mov       [rbp-3C],eax
       lea       rdx,[rbp-48]
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rbx
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      qword ptr [7FFE5C8F4990]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L16
M03_L03:
       mov       r8,[rbp-48]
       xor       eax,eax
       mov       [rbp-48],rax
       cmp       byte ptr [rbp+38],0
       jne       near ptr M03_L17
M03_L04:
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M03_L18
       mov       r14,[r8+8]
M03_L05:
       test      dil,dil
       je        short M03_L06
       test      r14,r14
       je        short M03_L06
       cmp       byte ptr [r14+115],2
       jne       short M03_L09
M03_L06:
       test      r14,r14
       je        short M03_L11
M03_L07:
       mov       rax,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L08:
       mov       rdx,rbx
       mov       r11,7FFE5C380E30
       call      qword ptr [r11]
       jmp       near ptr M03_L02
M03_L09:
       mov       rcx,r14
       call      qword ptr [7FFE5C9D7F90]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M03_L06
M03_L10:
       cmp       byte ptr [rbp+30],0
       je        short M03_L06
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5C975A10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r14,rax
       jmp       short M03_L06
M03_L11:
       cmp       byte ptr [rbp+29],0
       je        short M03_L07
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FFE5C97C768]
       int       3
M03_L12:
       mov       rcx,rsi
       call      qword ptr [7FFE5C975AD0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r15,rax
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,offset MT_System.Func`3[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFE5C37D0E0
       call      qword ptr [7FFE5C4C4258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,214C880A720
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [r13],r13b
       test      rbx,rbx
       jne       near ptr M03_L01
M03_L14:
       mov       ecx,1
       mov       rdx,7FFE5C8E0000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5CB26190]
       int       3
M03_L15:
       mov       ecx,0BB4
       mov       rdx,7FFE5C8E0000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5CB26190]
       int       3
M03_L16:
       mov       edx,[rbp-3C]
       mov       byte ptr [rbp-50],1
       mov       [rbp-4C],edx
       mov       rdx,rbx
       mov       r8,r15
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-48]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,[rbp-50]
       mov       rcx,r13
       call      qword ptr [7FFE5C8F4A80]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M03_L03
M03_L17:
       cmp       byte ptr [r8+20],0
       jne       near ptr M03_L04
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFE5C9DCD08]
       mov       r14,rax
       jmp       near ptr M03_L05
M03_L18:
       call      qword ptr [7FFE5CA85CB0]
       int       3
; Total bytes of code 627
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,248
       vzeroupper
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M04_L00:
       vmovdqa   xmmword ptr [rbp+rax+210],xmm4
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp+210],rax
       mov       [rbp],rsp
       mov       rax,0DEFF45EACCF2
       mov       [rbp+8],rax
       mov       rbx,rdx
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       xor       edx,edx
       mov       [rbp+28],rdx
       cmp       edi,55
       jle       near ptr M04_L10
       cmp       edi,15555555
       ja        near ptr M04_L11
       mov       rdx,214C8805568
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFE5CC45F00]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+28],rax
       test      rax,rax
       je        near ptr M04_L12
M04_L01:
       lea       r15,[rax+10]
       mov       r14d,[rax+8]
M04_L02:
       mov       rax,r15
M04_L03:
       mov       [rbp+10],rax
       mov       [rbp+64],r14d
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       mov       rcx,[rbp+10]
       mov       [rbp+40],rcx
       mov       ecx,[rbp+64]
       mov       [rbp+48],ecx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFE5C9DD8D8]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp+64]
       ja        near ptr M04_L06
       mov       rdx,[rbp+10]
       mov       [rbp+10],rdx
       mov       [rbp+64],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+94]
       movzx     r8d,byte ptr [rcx+92]
       cmp       r8d,2
       jg        near ptr M04_L05
       mov       ecx,[rcx+88]
       test      ecx,ecx
       jl        near ptr M04_L04
       xor       r10d,r10d
       mov       [rbp+1E0],r10
       mov       [rbp+1E8],r10
       mov       byte ptr [rbp+1F0],0
       mov       byte ptr [rbp+1F1],0
       mov       byte ptr [rbp+1F2],0
       mov       byte ptr [rbp+1F3],0
       mov       byte ptr [rbp+1F4],0
       mov       byte ptr [rbp+1F5],0
       mov       [rbp+1F8],ecx
       mov       [rbp+1FC],r8b
       mov       [rbp+1FD],r9b
       mov       byte ptr [rbp+1FE],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+200],xmm0
       vmovdqu   xmmword ptr [rbp+208],xmm0
       mov       [rbp+30],rdx
       mov       [rbp+38],eax
       lea       rdx,[rbp+30]
       lea       rcx,[rbp+120]
       lea       r9,[rbp+1E0]
       mov       r8d,1
       call      qword ptr [7FFE5CBB4210]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+80],ymm0
       vmovdqu   ymmword ptr [rbp+0A0],ymm0
       vmovdqu   ymmword ptr [rbp+0C0],ymm0
       vmovdqu   ymmword ptr [rbp+0E0],ymm0
       vmovdqu   ymmword ptr [rbp+100],ymm0
       lea       rcx,[rbp+80]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE5CBB52C0]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbx],rcx
       jne       near ptr M04_L07
       lea       rcx,[rbp+80]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+150]
       mov       r9,[rbx+0B0]
       lea       r8,[rbp+78]
       lea       rdx,[rbp+120]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CA85D10]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+78]
       xor       ecx,ecx
       mov       [rbp+78],rcx
       jmp       short M04_L08
M04_L04:
       mov       ecx,347F
       mov       rdx,7FFE5C965EE0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C977198]
       int       3
M04_L05:
       mov       ecx,347F
       mov       rdx,7FFE5C965EE0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C9771E0]
       int       3
M04_L06:
       call      qword ptr [7FFE5C6BE9D0]
       int       3
M04_L07:
       lea       r8,[rbp+80]
       lea       rdx,[rbp+120]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
M04_L08:
       mov       [rbp+20],rax
       mov       rcx,[rbp]
       call      M04_L13
       nop
       mov       rax,[rbp+20]
       mov       rcx,0DEFF45EACCF2
       cmp       [rbp+8],rcx
       je        short M04_L09
       call      CORINFO_HELP_FAIL_FAST
M04_L09:
       nop
       lea       rsp,[rbp+218]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L10:
       test      [rsp],esp
       sub       rsp,100
       lea       rax,[rsp+30]
       mov       r14d,100
       jmp       near ptr M04_L03
M04_L11:
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       lea       rcx,[rbp+50]
       call      qword ptr [7FFE5C9DD8C0]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       test      rax,rax
       jne       near ptr M04_L01
M04_L12:
       xor       r15d,r15d
       xor       r14d,r14d
       jmp       near ptr M04_L02
M04_L13:
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
       lea       rbp,[rbp+30]
       cmp       qword ptr [rbp+28],0
       je        near ptr M04_L35
       mov       rcx,[rbp+10]
       mov       edx,[rbp+64]
       mov       [rbp+70],rdx
       test      rdx,rdx
       je        short M04_L15
       cmp       rdx,300
       ja        short M04_L14
       xor       edx,edx
       mov       r8d,[rbp+70]
       call      CORINFO_HELP_MEMSET
       jmp       short M04_L15
M04_L14:
       mov       rdx,[rbp+70]
       call      qword ptr [7FFE5C575BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M04_L15:
       mov       rcx,214C8805568
       mov       r14,[rcx]
       mov       rcx,[rbp+28]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,7FFE5C405120
       mov       edx,4B
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M04_L16
       mov       rcx,r14
       call      qword ptr [7FFE5CC2C6F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M04_L16:
       xor       r12d,r12d
       mov       ebx,1
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M04_L30
       mov       r12d,1
       mov       rdx,[rbp+28]
       mov       eax,10
       shlx      eax,eax,r13d
       cmp       [rdx+8],eax
       je        short M04_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE5CA0EAC0]
       mov       r13,rax
       mov       ecx,1D3
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [7FFE5C4CF750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M04_L17:
       mov       edx,r13d
       shl       rdx,4
       lea       rsi,[rcx+rdx+10]
       mov       r15,[rsi]
       mov       rdx,[rbp+28]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],eax
       test      r15,r15
       je        near ptr M04_L30
       mov       rcx,[r14+10]
       cmp       r13d,[rcx+8]
       jae       short M04_L19
       mov       edx,r13d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M04_L18
       mov       rcx,r14
       mov       edx,r13d
       call      qword ptr [7FFE5CC2C678]
M04_L18:
       mov       rbx,[rax+8]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       esi,[rax+0A3C]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[rsi-1]
       mov       [rax+0A3C],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M04_L20
       call      qword ptr [7FFE5CDEDD10]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M04_L21
M04_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L20:
       mov       eax,esi
       sar       eax,10
M04_L21:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       esi,eax
       sub       esi,ecx
       xor       edi,edi
       jmp       near ptr M04_L28
M04_L22:
       cmp       esi,[rbx+8]
       jae       short M04_L19
       mov       ecx,esi
       mov       rax,[rbx+rcx*8+10]
       mov       [rbp+18],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+6C],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+18]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp+68],r10d
       cmp       [rcx+8],r10d
       jbe       short M04_L24
       test      r10d,r10d
       jne       short M04_L25
       xor       edx,edx
       mov       [rax+14],edx
M04_L23:
       movsxd    rdx,r10d
       mov       r8,r15
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp+68]
       inc       ecx
       mov       rax,[rbp+18]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+6C],1
M04_L24:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp+6C]
       test      ecx,ecx
       je        short M04_L26
       mov       ecx,1
       jmp       short M04_L29
M04_L25:
       jmp       short M04_L23
M04_L26:
       inc       esi
       cmp       [rbx+8],esi
       jne       short M04_L27
       xor       esi,esi
M04_L27:
       inc       edi
M04_L28:
       cmp       [rbx+8],edi
       jg        near ptr M04_L22
       xor       ecx,ecx
M04_L29:
       mov       ebx,ecx
M04_L30:
       mov       rax,214C88005D0
       mov       rsi,[rax]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M04_L35
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+8],0
       je        near ptr M04_L35
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,[rbp+28]
       mov       r15d,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,r15d
       mov       edx,3
       call      qword ptr [7FFE5C577678]
       test      ebx,r12d
       jne       short M04_L35
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,[rbp+28]
       mov       edi,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      r12d,r12d
       jne       short M04_L31
       mov       ecx,0FFFFFFFF
       jmp       short M04_L32
M04_L31:
       mov       ecx,r13d
M04_L32:
       mov       edx,ebx
       mov       r8d,edi
       mov       r9d,eax
       test      r12d,r12d
       jne       short M04_L33
       mov       eax,1
       jmp       short M04_L34
M04_L33:
       xor       eax,eax
M04_L34:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,rsi
       call      qword ptr [7FFE5C77EFB8]
M04_L35:
       nop
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
; Total bytes of code 1604
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-50],rsp
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5C9D79F0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C9759C8]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5C9D77E0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.MakeReadOnly()
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+0E8]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-20],0
       jne       short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rcx,7FFE5D00CC20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-28]
       call      qword ptr [7FFE5CA85CB0]
M05_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5C9D79F0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C975260]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-8],rax
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFE5C4CE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       movzx     ecx,byte ptr [rcx+115]
       test      ecx,ecx
       je        short M05_L02
       jmp       short M05_L05
M05_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+0E8]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-30],0
       jne       short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rcx,7FFE5D00CC24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE5CA85CB0]
M05_L04:
       nop
       mov       rcx,7FFE5D00CC28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+115],1
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5C9D7C30]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+115],2
       jmp       short M05_L06
M05_L05:
       mov       rcx,rsp
       call      M05_L08
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsp
       call      M05_L08
       nop
M05_L07:
       mov       rcx,7FFE5D00CC34
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,70
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       [rbp-40],rdx
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE5CA85C80]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0E8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       byte ptr [rax+115],0
       call      CORINFO_HELP_RETHROW
       int       3
M05_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M05_L09
       mov       rcx,7FFE5D00CC2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
M05_L09:
       mov       rcx,7FFE5D00CC30
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 489
```
**Extern method**
System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_PersonRecord()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FFE5CF170F0]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       test      edx,edx
       je        near ptr M01_L10
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C4F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L02:
       mov       r8,1F457808B48
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FFE5CF17150]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M01_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFE5CF23428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rsp+28]
       mov       rdx,234E961E378
       call      qword ptr [7FFE5C6658F0]
M01_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FFE5C8C4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M01_L07
M01_L06:
       call      qword ptr [7FFE5C6EE9D0]
       int       3
M01_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M01_L08
       mov       rdx,234E9600C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M01_L09
M01_L08:
       lea       rcx,[rsp+28]
       mov       rdx,234E9600C48
       call      qword ptr [7FFE5C6658F0]
M01_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5C665740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C716718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       call      qword ptr [7FFE5CA04D98]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L11
       call      qword ptr [7FFE5CA04AE0]
       mov       rsi,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,234E961E280
       mov       r8,rsi
       call      qword ptr [7FFE5C716670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE5C6656B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+38]
       cmp       ecx,[rsp+48]
       ja        near ptr M01_L06
       mov       rdx,[rsp+40]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,ecx
       cmp       eax,29
       jb        near ptr M01_L04
       mov       rcx,234E961E384
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymm1,ymmword ptr [rcx+20]
       vmovdqu   ymm2,ymmword ptr [rcx+32]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymmword ptr [rdx+20],ymm1
       vmovdqu   ymmword ptr [rdx+32],ymm2
       mov       ecx,[rsp+38]
       add       ecx,29
       mov       [rsp+38],ecx
       jmp       near ptr M01_L05
; Total bytes of code 551
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_Person_List()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+128]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE5CEE7A80]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       test      edx,edx
       je        near ptr M01_L10
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C4C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L02:
       mov       r8,23F5BC08B48
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FFE5CEE7AE0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M01_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFE5CEF3398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rsp+28]
       mov       rdx,27FED8DE418
       call      qword ptr [7FFE5C6358F0]
M01_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FFE5C894B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M01_L07
M01_L06:
       call      qword ptr [7FFE5C6BE9D0]
       int       3
M01_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M01_L08
       mov       rdx,27FED8C0C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M01_L09
M01_L08:
       lea       rcx,[rsp+28]
       mov       rdx,27FED8C0C48
       call      qword ptr [7FFE5C6358F0]
M01_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5C635740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C6E6718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       call      qword ptr [7FFE5C9D4D98]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L11
       call      qword ptr [7FFE5C9D4AE0]
       mov       rsi,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,27FED8DE280
       mov       r8,rsi
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE5C6356B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+38]
       cmp       ecx,[rsp+48]
       ja        near ptr M01_L06
       mov       rdx,[rsp+40]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,ecx
       cmp       eax,29
       jb        near ptr M01_L04
       mov       rcx,27FED8DE424
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymm1,ymmword ptr [rcx+20]
       vmovdqu   ymm2,ymmword ptr [rcx+32]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymmword ptr [rdx+20],ymm1
       vmovdqu   ymmword ptr [rdx+32],ymm2
       mov       ecx,[rsp+38]
       add       ecx,29
       mov       [rsp+38],ecx
       jmp       near ptr M01_L05
; Total bytes of code 551
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_Ref_Person()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+140]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FFE5CEF70F0]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-78],rsp
       mov       [rbp-30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       je        near ptr M01_L07
       mov       ecx,[rbx+8]
       test      ecx,ecx
       je        near ptr M01_L05
       movzx     eax,word ptr [rbx+0C]
       cmp       eax,100
       jae       short M01_L02
       mov       rdx,7FFE78C52E50
       test      byte ptr [rax+rdx],80
       jne       near ptr M01_L09
       jmp       short M01_L03
M01_L02:
       mov       edx,eax
       shr       edx,9
       mov       r8,7FFE78C61CB0
       movzx     edx,byte ptr [rdx+r8]
       shl       edx,6
       mov       r8d,eax
       shr       r8d,3
       and       r8d,3E
       add       edx,r8d
       mov       r8,7FFE78C5ACC8
       movzx     edx,word ptr [rdx+r8]
       shl       edx,4
       and       eax,0F
       add       eax,edx
       mov       rdx,7FFE78C5E7F0
       movzx     eax,byte ptr [rax+rdx]
       mov       rdx,7FFE78C53150
       cmp       byte ptr [rax+rdx],0
       jl        near ptr M01_L09
M01_L03:
       lea       eax,[rcx-1]
       cmp       eax,ecx
       jae       near ptr M01_L11
       mov       ecx,eax
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L05
M01_L04:
       mov       eax,ecx
       shr       eax,9
       mov       rdx,7FFE78C61CB0
       movzx     eax,byte ptr [rax+rdx]
       shl       eax,6
       mov       edx,ecx
       shr       edx,3
       and       edx,3E
       add       eax,edx
       mov       rdx,7FFE78C5ACC8
       movzx     eax,word ptr [rax+rdx]
       shl       eax,4
       and       ecx,0F
       add       ecx,eax
       mov       rax,7FFE78C5E7F0
       movzx     ecx,byte ptr [rcx+rax]
       mov       rax,7FFE78C53150
       cmp       byte ptr [rcx+rax],0
       jl        near ptr M01_L09
M01_L05:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rbx,rbx
       je        near ptr M01_L10
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-60],rdi
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,22A0F00B500
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r9,26A9D000008
       call      qword ptr [7FFE5CEF75B8]; System.Xml.XmlTextReaderImpl..ctor(System.IO.TextReader, System.Xml.XmlReaderSettings, System.String, System.Xml.XmlParserContext)
       mov       [rbp-68],rbx
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FFE5CDCDAE8]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rcx,r14
       mov       rdx,rbx
       vmovdqu   ymm0,ymmword ptr [rcx+38]
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       r9,[rcx+58]
       mov       [rbp-38],r9
       lea       r9,[rbp-58]
       xor       r8d,r8d
       call      qword ptr [7FFE5CDCDCE0]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       mov       r8,rax
       test      r8,r8
       je        short M01_L06
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M01_L06
       mov       rdx,rax
       call      qword ptr [7FFE5C4D4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M01_L06:
       mov       rax,r8
       mov       [rbp-70],rax
       mov       rcx,rsp
       call      M01_L12
       nop
       xor       ecx,ecx
       mov       rdx,[rbp-60]
       mov       [rdx+8],rcx
       mov       [rdx+10],ecx
       mov       rcx,rdx
       mov       edx,1
       call      qword ptr [7FFE5C660A48]; System.IO.TextReader.Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      System.GC._SuppressFinalize(System.Object)
       mov       rax,[rbp-70]
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      qword ptr [7FFE5C9E4D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L08
       call      qword ptr [7FFE5C9E4AE0]
       mov       rbx,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,26A9D015C80
       mov       r8,rbx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE5C4D73F0]
       mov       rbx,rax
       jmp       near ptr M01_L05
M01_L10:
       mov       ecx,11
       call      qword ptr [7FFE5C6CED00]
       int       3
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L12:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       rbx,[rbp-68]
       cmp       dword ptr [rbx+160],4
       je        near ptr M01_L24
       movzx     edi,byte ptr [rbx+17D]
       cmp       dword ptr [rbx+108],0C
       jne       short M01_L14
       jmp       near ptr M01_L24
M01_L13:
       mov       rcx,rbx
       call      qword ptr [7FFE5CEFCE58]
M01_L14:
       cmp       dword ptr [rbx+13C],0
       jge       short M01_L13
       lea       rsi,[rbx+188]
       test      edi,edi
       je        near ptr M01_L22
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        near ptr M01_L19
       mov       r14,rcx
       mov       rcx,offset MT_System.IO.FileStream
       cmp       [r14],rcx
       jne       short M01_L18
       mov       rcx,[r14+10]
       mov       r15,rcx
       test      r15,r15
       je        short M01_L17
       mov       rsi,[r15]
       mov       rcx,offset MT_System.IO.Strategies.SyncWindowsFileStreamStrategy
       cmp       rsi,rcx
       jne       short M01_L16
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L17
       test      byte ptr [rcx+10],1
       jne       short M01_L17
       mov       rcx,[r15+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L15
       call      qword ptr [7FFE5D1436E8]; Precode of System.Threading.ThreadPoolBoundHandle.Dispose()
M01_L15:
       mov       rsi,[r15+18]
       cmp       [rsi],sil
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE5C4DE3E8]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,rsi
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M01_L17
M01_L16:
       mov       rcx,r15
       mov       edx,1
       mov       rax,[rsi+50]
       call      qword ptr [rax+20]
M01_L17:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M01_L22
M01_L18:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       jmp       short M01_L22
M01_L19:
       mov       rdi,[rsi+28]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,offset MT_System.IO.StringReader
       cmp       [rdi],rcx
       jne       short M01_L20
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       [rdi+10],ecx
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFE5C660A48]; System.IO.TextReader.Dispose(Boolean)
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       edx,1
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M01_L21:
       mov       rcx,rdi
       call      System.GC._SuppressFinalize(System.Object)
M01_L22:
       call      qword ptr [7FFE5CEFE670]; System.Xml.XmlTextReaderImpl+NodeData.get_None()
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+108],0C
       xor       ecx,ecx
       mov       [rbx+68],rcx
       mov       rcx,26A9D000008
       mov       [rbx+60],rcx
       mov       dword ptr [rbx+160],4
       mov       byte ptr [rbx+176],0
       cmp       byte ptr [rbx+176],0
       je        short M01_L23
       mov       rcx,rbx
       call      qword ptr [7FFE5CEFCD20]
M01_L23:
       mov       dword ptr [rbx+118],0FFFFFFFF
       xor       ecx,ecx
       mov       [rbx+11C],ecx
       mov       [rbx+120],ecx
       mov       [rbx+124],ecx
       mov       [rbx+8],rcx
M01_L24:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       xor       ecx,ecx
       mov       rax,[rbp-60]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFE5C660A48]; System.IO.TextReader.Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1331
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_PersonRecord()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+138]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FFE5CEF7A80]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-88],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L00
       mov       edi,[rbx+8]
       xor       ecx,ecx
       test      edi,edi
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      edi,edi
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L07
       mov       edi,[rbx+8]
       test      edi,edi
       je        short M01_L05
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE5CDCD080]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M01_L09
M01_L03:
       lea       ecx,[rdi-1]
       cmp       ecx,edi
       jae       near ptr M01_L11
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE5CDCD080]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M01_L09
M01_L05:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rbx,rbx
       je        near ptr M01_L10
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-68],rdi
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,1D87A40B500
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r9,21908430008
       call      qword ptr [7FFE5CEFC1F8]; System.Xml.XmlTextReaderImpl..ctor(System.IO.TextReader, System.Xml.XmlReaderSettings, System.String, System.Xml.XmlParserContext)
       mov       [rbp-70],rbx
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FFE5CDCE6B8]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rcx,r14
       mov       rdx,rbx
       vmovdqu   ymm0,ymmword ptr [rcx+38]
       vmovdqu   ymmword ptr [rbp-60],ymm0
       mov       r9,[rcx+58]
       mov       [rbp-40],r9
       lea       r9,[rbp-60]
       xor       r8d,r8d
       call      qword ptr [7FFE5CDCE8B0]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       mov       r8,rax
       test      r8,r8
       je        short M01_L06
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M01_L06
       mov       rdx,rax
       call      qword ptr [7FFE5C4D4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M01_L06:
       mov       rax,r8
       mov       [rbp-78],rax
       mov       rcx,rsp
       call      M01_L12
       nop
       xor       ecx,ecx
       mov       rdx,[rbp-68]
       mov       [rdx+8],rcx
       mov       [rdx+10],ecx
       mov       rcx,rdx
       mov       edx,1
       call      qword ptr [7FFE5C660A48]; System.IO.TextReader.Dispose(Boolean)
       mov       rcx,[rbp-68]
       call      System.GC._SuppressFinalize(System.Object)
       mov       rax,[rbp-78]
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      qword ptr [7FFE5C9E4570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L08
       call      qword ptr [7FFE5C9E42B8]
       mov       rbx,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21908445CA8
       mov       r8,rbx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE5C4D73F0]
       mov       rbx,rax
       jmp       near ptr M01_L05
M01_L10:
       mov       ecx,11
       call      qword ptr [7FFE5C6CED00]
       int       3
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L12:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0B0]
       mov       rbx,[rbp-70]
       cmp       dword ptr [rbx+160],4
       je        near ptr M01_L31
       movzx     edi,byte ptr [rbx+17D]
       cmp       dword ptr [rbx+108],0C
       jne       short M01_L14
       jmp       near ptr M01_L31
M01_L13:
       mov       rcx,rbx
       call      qword ptr [7FFE5CEFD7A0]
M01_L14:
       cmp       dword ptr [rbx+13C],0
       jge       short M01_L13
       lea       rsi,[rbx+188]
       test      edi,edi
       je        near ptr M01_L28
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        near ptr M01_L25
       mov       r14,rcx
       mov       rcx,offset MT_System.IO.FileStream
       cmp       [r14],rcx
       jne       near ptr M01_L24
       mov       rcx,[r14+10]
       mov       r15,rcx
       test      r15,r15
       je        near ptr M01_L23
       mov       rsi,[r15]
       mov       rcx,offset MT_System.IO.Strategies.SyncWindowsFileStreamStrategy
       cmp       rsi,rcx
       jne       near ptr M01_L22
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        near ptr M01_L23
       test      byte ptr [rcx+10],1
       jne       near ptr M01_L23
       mov       rcx,[r15+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L15
       call      qword ptr [7FFE5D125F90]; Precode of System.Threading.ThreadPoolBoundHandle.Dispose()
M01_L15:
       mov       r13,[r15+18]
       cmp       [r13],r13b
M01_L16:
       mov       esi,[r13+10]
       test      sil,2
       jne       short M01_L20
       mov       edi,esi
       and       edi,0FFFFFFFC
       je        short M01_L21
       mov       ecx,esi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M01_L17
       cmp       byte ptr [r13+14],0
       je        short M01_L17
       mov       rcx,r13
       call      qword ptr [7FFE5C6612C0]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M01_L18
M01_L17:
       xor       eax,eax
M01_L18:
       movzx     ecx,al
       lea       eax,[rsi-4]
       cmp       edi,4
       jne       short M01_L19
       or        eax,1
M01_L19:
       lea       rdx,[r13+10]
       mov       r8d,eax
       or        r8d,2
       mov       eax,esi
       lock cmpxchg [rdx],r8d
       cmp       eax,esi
       jne       short M01_L16
       test      ecx,ecx
       je        short M01_L20
       call      System.Runtime.InteropServices.Marshal.GetLastPInvokeError()
       mov       r15d,eax
       mov       rcx,r13
       call      qword ptr [7FFE5C6616C8]; Precode of Microsoft.Win32.SafeHandles.SafeFileHandle.ReleaseHandle()
       mov       ecx,r15d
       call      System.Runtime.InteropServices.Marshal.SetLastPInvokeError(Int32)
M01_L20:
       mov       rcx,r13
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M01_L23
M01_L21:
       mov       rcx,r13
       call      qword ptr [7FFE5C6CEE80]
       int       3
M01_L22:
       mov       rcx,r15
       mov       edx,1
       mov       rax,[rsi+50]
       call      qword ptr [rax+20]
M01_L23:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M01_L28
M01_L24:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       jmp       short M01_L28
M01_L25:
       mov       r13,[rsi+28]
       test      r13,r13
       je        short M01_L28
       mov       rcx,offset MT_System.IO.StringReader
       cmp       [r13],rcx
       jne       short M01_L26
       xor       ecx,ecx
       mov       [r13+8],rcx
       mov       [r13+10],ecx
       mov       rcx,r13
       mov       edx,1
       call      qword ptr [7FFE5C660A48]; System.IO.TextReader.Dispose(Boolean)
       jmp       short M01_L27
M01_L26:
       mov       rcx,r13
       mov       edx,1
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M01_L27:
       mov       rcx,r13
       call      System.GC._SuppressFinalize(System.Object)
M01_L28:
       mov       rcx,1D87A40B510
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M01_L29
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+NodeData
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5CEFEFD0]
       mov       rcx,1D87A40B510
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
M01_L29:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+108],0C
       xor       ecx,ecx
       mov       [rbx+68],rcx
       mov       rcx,21908430008
       mov       [rbx+60],rcx
       mov       dword ptr [rbx+160],4
       mov       byte ptr [rbx+176],0
       cmp       byte ptr [rbx+176],0
       je        short M01_L30
       mov       rcx,rbx
       call      qword ptr [7FFE5CEFD668]
M01_L30:
       mov       dword ptr [rbx+118],0FFFFFFFF
       xor       ecx,ecx
       mov       [rbx+11C],ecx
       mov       [rbx+120],ecx
       mov       [rbx+124],ecx
       mov       [rbx+8],rcx
M01_L31:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0B0]
       xor       ecx,ecx
       mov       rax,[rbp-68]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFE5C660A48]; System.IO.TextReader.Dispose(Boolean)
       mov       rcx,[rbp-68]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1395
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.LoadCollectionFromJson_People_SerializerContext()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+128]
       mov       rcx,273984083C8
       mov       rcx,[rcx]
       call      qword ptr [7FFE5CEF7B70]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonJsonSerializerContext.get_Person()
       mov       r9,rax
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.LoadCollectionFromJson[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String, Int32, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       r8d,64
       call      qword ptr [7FFE5CEF7ED0]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.LoadCollectionFromJson[[System.__Canon, System.Private.CoreLib]](System.String, Int32, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       [rsp+20],rax
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
; Total bytes of code 106
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonJsonSerializerContext.get_Person()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rax,[rbx+20]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rcx,rbx
       call      qword ptr [7FFE5C9764D8]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rcx,rax
       mov       rdx,2B42A133DA0
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C975C68]; System.Text.Json.JsonSerializerOptions.GetTypeInfo(System.Type)
       mov       rsi,rax
       test      rsi,rsi
       je        short M01_L02
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       je        short M01_L02
       mov       rdx,rax
       call      qword ptr [7FFE5C4D43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L02:
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M01_L00
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.LoadCollectionFromJson[[System.__Canon, System.Private.CoreLib]](System.String, Int32, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,2F8
       vzeroupper
       lea       rbp,[rsp+330]
       xor       eax,eax
       mov       [rbp-2B8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFD90
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-300],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       r14,rdx
       mov       esi,r8d
       mov       rbx,r9
       test      r14,r14
       je        short M02_L01
       xor       ecx,ecx
       cmp       dword ptr [r14+8],0
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       dword ptr [r14+8],0
       jne       short M02_L02
       jmp       short M02_L02
M02_L01:
       xor       ecx,ecx
M02_L02:
       test      ecx,ecx
       je        near ptr M02_L27
       cmp       dword ptr [r14+8],0
       je        short M02_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L03
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M02_L29
       jmp       short M02_L04
M02_L03:
       call      qword ptr [7FFE5CDCD080]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M02_L29
M02_L04:
       mov       ecx,[r14+8]
       dec       ecx
       cmp       ecx,[r14+8]
       jae       near ptr M02_L36
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M02_L29
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFE5CDCD080]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M02_L29
M02_L06:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      esi,esi
       jle       near ptr M02_L30
       xor       r15d,r15d
       cmp       esi,7FFFFFFF
       setle     r15b
       mov       eax,r15d
       test      r15d,r15d
       je        near ptr M02_L31
M02_L07:
       test      eax,eax
       je        near ptr M02_L32
M02_L08:
       test      rbx,rbx
       je        near ptr M02_L34
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L10
M02_L09:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-2B8],rax
       test      r14,r14
       je        near ptr M02_L35
       mov       ecx,[r14+8]
       mov       rdx,r14
       mov       [rbp-258],rdx
       xor       edx,edx
       mov       [rbp-250],edx
       mov       [rbp-24C],ecx
       mov       [rbp-260],edx
       mov       byte ptr [rbp-25C],0
       mov       byte ptr [rbp-25B],0
       lea       rcx,[rbp-258]
       mov       rdx,[rbp-260]
       call      qword ptr [7FFE5CAB59B0]; System.Text.Json.JsonDocument.Parse(System.ReadOnlyMemory`1<Char>, System.Text.Json.JsonDocumentOptions)
       mov       [rbp-2C0],rax
       jmp       short M02_L12
M02_L10:
       mov       rcx,rdi
       mov       rdx,7FFE5CF0AE88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L09
M02_L11:
       mov       rcx,rsp
       call      M02_L37
       nop
       mov       rax,[rbp-2B8]
       add       rsp,2F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L12:
       cmp       [rax],al
       mov       r13,rax
       xor       r12d,r12d
       test      esi,esi
       jle       short M02_L11
M02_L13:
       lea       rdx,[rbp-58]
       mov       rcx,r13
       xor       r8d,r8d
       mov       r9d,r12d
       call      qword ptr [7FFE5CAB5518]; System.Text.Json.JsonDocument.GetArrayIndexElement(Int32, Int32)
       mov       r14,[rbp-58]
       mov       r15d,[rbp-50]
       cmp       byte ptr [rbx+115],2
       jne       near ptr M02_L19
M02_L14:
       test      r14,r14
       je        near ptr M02_L22
       lea       rdx,[rbp-68]
       mov       rcx,r14
       mov       r8d,r15d
       mov       r9d,1
       call      qword ptr [7FFE5CAB5560]; System.Text.Json.JsonDocument.GetRawValue(Int32, Boolean)
       xor       edx,edx
       xor       r9d,r9d
       mov       rcx,[rbp-68]
       test      rcx,rcx
       je        short M02_L16
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        near ptr M02_L20
       lea       rdx,[rcx+10]
       mov       r9d,[rcx+8]
M02_L15:
       mov       ecx,[rbp-60]
       and       ecx,7FFFFFFF
       mov       r8d,[rbp-5C]
       mov       eax,r8d
       add       rax,rcx
       mov       r9d,r9d
       cmp       rax,r9
       ja        near ptr M02_L23
       add       rdx,rcx
       mov       r9d,r8d
M02_L16:
       mov       rcx,[rbx+0B0]
       movzx     r8d,byte ptr [rcx+94]
       movzx     eax,byte ptr [rcx+92]
       cmp       eax,2
       jg        near ptr M02_L24
       mov       ecx,[rcx+88]
       test      ecx,ecx
       jl        near ptr M02_L25
       mov       [rbp-98],ecx
       mov       [rbp-94],al
       mov       [rbp-93],r8b
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-90],xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       mov       [rbp-270],rdx
       mov       [rbp-268],r9d
       vmovdqu   ymm0,ymmword ptr [rbp-0B0]
       vmovdqu   ymmword ptr [rbp-2A8],ymm0
       vmovdqu   ymm0,ymmword ptr [rbp-98]
       vmovdqu   ymmword ptr [rbp-290],ymm0
       lea       rdx,[rbp-270]
       lea       r9,[rbp-2A8]
       lea       rcx,[rbp-170]
       mov       r8d,1
       call      qword ptr [7FFE5CBC4210]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-210],ymm0
       vmovdqu   ymmword ptr [rbp-1F0],ymm0
       vmovdqu   ymmword ptr [rbp-1D0],ymm0
       vmovdqu   ymmword ptr [rbp-1B0],ymm0
       vmovdqu   ymmword ptr [rbp-190],ymm0
       lea       rcx,[rbp-210]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE5CBC52C0]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbx],rcx
       jne       near ptr M02_L21
       lea       rcx,[rbp-210]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+150]
       mov       r9,[rbx+0B0]
       lea       r8,[rbp-218]
       lea       rdx,[rbp-170]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CA96508]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rdx,[rbp-218]
       xor       ecx,ecx
       mov       [rbp-218],rcx
M02_L17:
       mov       r8,rdx
       test      r8,r8
       je        short M02_L18
       mov       rcx,[rdi+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L18
       call      qword ptr [7FFE5C4D4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M02_L18:
       movsxd    rdx,r12d
       mov       rcx,[rbp-2B8]
       call      CORINFO_HELP_ARRADDR_ST
       add       r12d,1
       jo        near ptr M02_L26
       cmp       r12d,esi
       jl        near ptr M02_L13
       jmp       near ptr M02_L11
M02_L19:
       mov       rcx,rbx
       call      qword ptr [7FFE5C9ECAC8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       near ptr M02_L14
M02_L20:
       lea       rdx,[rbp-78]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdx,[rbp-78]
       mov       r9d,[rbp-70]
       jmp       near ptr M02_L15
M02_L21:
       lea       r8,[rbp-210]
       lea       rdx,[rbp-170]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M02_L17
M02_L22:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C6F6700]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L23:
       call      qword ptr [7FFE5C6CE9D0]
       int       3
M02_L24:
       mov       ecx,347F
       mov       rdx,7FFE5C986348
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C97C0C0]
       int       3
M02_L25:
       mov       ecx,347F
       mov       rdx,7FFE5C986348
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C97C078]
       int       3
M02_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L27:
       call      qword ptr [7FFE5C9E4D98]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L28
       call      qword ptr [7FFE5C9E4AE0]
       mov       rsi,rax
M02_L28:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2B42A13E690
       mov       r8,rsi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE5C4D73F0]
       mov       r14,rax
       jmp       near ptr M02_L06
M02_L30:
       xor       r15d,r15d
       mov       eax,r15d
       test      r15d,r15d
       jne       near ptr M02_L07
M02_L31:
       movzx     ecx,byte ptr [rbp-48]
       test      cl,cl
       je        near ptr M02_L07
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE5C5847B0]
       mov       esi,eax
       jmp       near ptr M02_L08
M02_L32:
       call      qword ptr [7FFE5C9E4CD8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L33
       call      qword ptr [7FFE5C9E4AF8]
       mov       rbx,rax
M02_L33:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2B42A124368
       mov       r8,rbx
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L34:
       call      qword ptr [7FFE5C9E4CF0]
       mov       ecx,1ACE
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       r12,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9E4AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L35:
       mov       ecx,389E
       mov       rdx,7FFE5C986348
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C97C018]
       int       3
M02_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L37:
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
       lea       rbp,[rbp+330]
       mov       rax,[rbp-2C0]
       test      rax,rax
       je        near ptr M02_L83
       mov       esi,[rax+2C]
       test      esi,esi
       je        near ptr M02_L83
       cmp       byte ptr [rax+18],0
       je        near ptr M02_L83
       lea       r13,[rax+30]
       xor       ecx,ecx
       mov       r12,rcx
       xchg      r12,[r13]
       test      r12,r12
       je        near ptr M02_L59
       mov       rcx,27398405568
       mov       r14,[rcx]
       mov       ecx,[r12+8]
       dec       ecx
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,7FFE5C415120
       mov       edx,4B
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M02_L38
       mov       rcx,r14
       call      qword ptr [7FFE5CC3CA98]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M02_L38:
       xor       ebx,ebx
       mov       edi,1
       mov       edx,[rcx+8]
       cmp       edx,r15d
       jbe       near ptr M02_L53
       mov       ebx,1
       mov       edx,10
       shlx      edx,edx,r15d
       cmp       [r12+8],edx
       je        short M02_L39
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE5CA1F1C8]
       mov       r15,rax
       mov       ecx,1D3
       mov       rdx,7FFE5C384000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      qword ptr [7FFE5C4DF750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M02_L39:
       mov       edx,r15d
       shl       rdx,4
       lea       rax,[rcx+rdx+10]
       mov       [rbp-2D8],rax
       mov       r8,[rax]
       mov       [rbp-2E0],r8
       mov       rcx,rax
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-2D8]
       mov       [rdx+8],ecx
       cmp       qword ptr [rbp-2E0],0
       je        near ptr M02_L53
       mov       rcx,[r14+10]
       cmp       r15d,[rcx+8]
       jae       short M02_L42
       mov       edx,r15d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       jne       short M02_L40
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFE5CC3CA20]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       mov       r10,rax
M02_L40:
       mov       rdi,[r10+8]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+180],3
       jl        short M02_L41
       mov       rcx,[rcx+188]
       mov       r10,[rcx+18]
       test      r10,r10
       jne       short M02_L43
M02_L41:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       jmp       short M02_L43
M02_L42:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L43:
       mov       r9d,[r10+0A3C]
       lea       ecx,[r9-1]
       mov       [r10+0A3C],ecx
       movzx     ecx,r9w
       test      ecx,ecx
       jne       short M02_L44
       call      qword ptr [7FFE5CDFDD10]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M02_L45
M02_L44:
       sar       r9d,10
       mov       eax,r9d
M02_L45:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       mov       [rbp-228],edx
       mov       r8d,[rdi+8]
       mov       [rbp-2AC],r8d
       test      r8d,r8d
       jle       near ptr M02_L50
M02_L46:
       cmp       eax,r8d
       jae       short M02_L42
       mov       [rbp-224],eax
       mov       ecx,eax
       mov       r10,[rdi+rcx*8+10]
       mov       [rbp-2E8],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-22C],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-2E8]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-230],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L48
       test      r10d,r10d
       jne       short M02_L51
       xor       edx,edx
       mov       [rax+14],edx
M02_L47:
       movsxd    rdx,r10d
       mov       r8,[rbp-2E0]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-230]
       inc       ecx
       mov       rax,[rbp-2E8]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-22C],1
M02_L48:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-22C]
       test      ecx,ecx
       jne       short M02_L52
       mov       eax,[rbp-224]
       inc       eax
       mov       ecx,eax
       mov       r8d,[rbp-2AC]
       cmp       r8d,ecx
       jne       short M02_L49
       xor       ecx,ecx
M02_L49:
       mov       edx,[rbp-228]
       inc       edx
       cmp       r8d,edx
       mov       [rbp-228],edx
       mov       eax,ecx
       jg        near ptr M02_L46
M02_L50:
       xor       edi,edi
       jmp       short M02_L53
M02_L51:
       jmp       short M02_L47
M02_L52:
       mov       edi,1
M02_L53:
       mov       rcx,273984005D0
       mov       r11,[rcx]
       mov       [rbp-2C8],r11
       cmp       byte ptr [r11+9D],0
       je        near ptr M02_L58
       cmp       dword ptr [r12+8],0
       je        near ptr M02_L58
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-21C],eax
       mov       edx,[r12+8]
       mov       [rbp-220],edx
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-2C8]
       mov       r8d,[rbp-21C]
       mov       r9d,[rbp-220]
       mov       edx,3
       call      qword ptr [7FFE5C587678]
       test      edi,ebx
       jne       short M02_L58
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       r12d,[r12+8]
       mov       rax,[rbp-2C8]
       mov       [rbp-2D0],rax
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      ebx,ebx
       jne       short M02_L54
       mov       r14,[rbp-2D0]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L55
M02_L54:
       mov       r14,[rbp-2D0]
       mov       ecx,r15d
M02_L55:
       mov       edx,edi
       mov       r8d,r12d
       mov       r9d,eax
       test      ebx,ebx
       jne       short M02_L56
       mov       eax,1
       jmp       short M02_L57
M02_L56:
       xor       eax,eax
M02_L57:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFE5C7DF360]
M02_L58:
       xor       ecx,ecx
       mov       [r13+8],ecx
M02_L59:
       xor       ecx,ecx
       mov       rax,[rbp-2C0]
       mov       [rax+20],rcx
       mov       [rax+28],rcx
       cmp       qword ptr [rax+8],0
       je        near ptr M02_L82
       add       rax,8
       xor       ecx,ecx
       mov       rbx,rcx
       xchg      rbx,[rax]
       test      rbx,rbx
       je        near ptr M02_L83
       cmp       [rbx+8],esi
       jae       short M02_L60
       call      qword ptr [7FFE5C6CE9D0]
       int       3
M02_L60:
       cmp       [rbx],bl
       lea       rcx,[rbx+10]
       mov       edx,esi
       mov       [rbp-238],rdx
       test      rdx,rdx
       je        short M02_L62
       cmp       rdx,300
       ja        short M02_L61
       xor       edx,edx
       mov       r8d,[rbp-238]
       call      CORINFO_HELP_MEMSET
       jmp       short M02_L62
M02_L61:
       mov       rdx,[rbp-238]
       call      qword ptr [7FFE5C585BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M02_L62:
       mov       rcx,27398405568
       mov       rsi,[rcx]
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rcx,7FFE5C415120
       mov       edx,4B
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M02_L63
       mov       rcx,rsi
       call      qword ptr [7FFE5CC3CA98]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M02_L63:
       xor       r15d,r15d
       mov       r13d,1
       mov       edx,[rcx+8]
       cmp       edx,edi
       jbe       near ptr M02_L77
       mov       r15d,1
       mov       eax,10
       shlx      eax,eax,edi
       cmp       [rbx+8],eax
       je        short M02_L64
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA1F1C8]
       mov       rdi,rax
       mov       ecx,1D3
       mov       rdx,7FFE5C384000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE5C4DF750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L64:
       cmp       edi,edx
       jae       near ptr M02_L42
       mov       edx,edi
       shl       rdx,4
       lea       r14,[rcx+rdx+10]
       mov       r12,[r14]
       mov       rcx,r14
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],eax
       test      r12,r12
       je        near ptr M02_L77
       mov       rax,[rsi+10]
       cmp       edi,[rax+8]
       jae       near ptr M02_L42
       mov       ecx,edi
       mov       rcx,[rax+rcx*8+10]
       test      rcx,rcx
       jne       short M02_L65
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE5CC3CA20]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       mov       rcx,rax
M02_L65:
       mov       r13,[rcx+8]
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+180],3
       jl        short M02_L66
       mov       rax,[rax+188]
       mov       r10,[rax+18]
       test      r10,r10
       jne       short M02_L67
M02_L66:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
M02_L67:
       mov       edx,[r10+0A3C]
       lea       eax,[rdx-1]
       mov       [r10+0A3C],eax
       movzx     eax,dx
       test      eax,eax
       jne       short M02_L68
       call      qword ptr [7FFE5CDFDD10]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M02_L69
M02_L68:
       mov       eax,edx
       sar       eax,10
M02_L69:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       eax,eax
       mov       [rbp-240],eax
       mov       edx,[r13+8]
       mov       [rbp-2B0],edx
       test      edx,edx
       jle       near ptr M02_L74
M02_L70:
       cmp       r14d,edx
       jae       near ptr M02_L42
       mov       ecx,r14d
       mov       r8,[r13+rcx*8+10]
       mov       [rbp-2F0],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-244],r10d
       mov       rcx,r8
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-2F0]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-248],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L72
       test      r10d,r10d
       jne       short M02_L75
       xor       edx,edx
       mov       [rax+14],edx
M02_L71:
       movsxd    rdx,r10d
       mov       r8,r12
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-248]
       inc       ecx
       mov       rax,[rbp-2F0]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-244],1
M02_L72:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-244]
       test      ecx,ecx
       jne       short M02_L76
       inc       r14d
       mov       ecx,[rbp-2B0]
       cmp       ecx,r14d
       jne       short M02_L73
       xor       r14d,r14d
M02_L73:
       mov       eax,[rbp-240]
       inc       eax
       cmp       ecx,eax
       mov       [rbp-240],eax
       mov       edx,ecx
       jg        near ptr M02_L70
M02_L74:
       xor       r13d,r13d
       jmp       short M02_L77
M02_L75:
       jmp       short M02_L71
M02_L76:
       mov       r13d,1
M02_L77:
       mov       rax,273984005D0
       mov       r14,[rax]
       cmp       byte ptr [r14+9D],0
       je        near ptr M02_L83
       cmp       dword ptr [rbx+8],0
       je        near ptr M02_L83
       cmp       [rbx],bl
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       eax,[rbx+8]
       mov       [rbp-23C],eax
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,r12d
       mov       r9d,[rbp-23C]
       mov       edx,3
       call      qword ptr [7FFE5C587678]
       test      r13d,r15d
       jne       short M02_L83
       cmp       [rbx],bl
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      r15d,r15d
       jne       short M02_L78
       mov       ecx,0FFFFFFFF
       jmp       short M02_L79
M02_L78:
       mov       ecx,edi
M02_L79:
       mov       edx,r13d
       mov       r8d,ebx
       mov       r9d,eax
       test      r15d,r15d
       jne       short M02_L80
       mov       eax,1
       jmp       short M02_L81
M02_L80:
       xor       eax,eax
M02_L81:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFE5C7DF360]
       jmp       short M02_L83
M02_L82:
       cmp       qword ptr [rax+10],0
       je        short M02_L83
       lea       rcx,[rax+10]
       xor       eax,eax
       xchg      rax,[rcx]
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L83
       call      qword ptr [7FFE5CD1CF70]; Precode of System.Text.Json.PooledByteBufferWriter.Dispose()
M02_L83:
       nop
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
; Total bytes of code 3527
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.LoadCollectionFromJson_People()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+128]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.LoadCollectionFromJson[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String, Int32)
       mov       r8d,64
       call      qword ptr [7FFE5CF07A80]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.LoadCollectionFromJson[[System.__Canon, System.Private.CoreLib]](System.String, Int32)
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
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.LoadCollectionFromJson[[System.__Canon, System.Private.CoreLib]](System.String, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0C0],xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-100],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       test      rdi,rdi
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rdi+8],0
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       dword ptr [rdi+8],0
       jne       short M01_L02
       jmp       short M01_L02
M01_L01:
       xor       ecx,ecx
M01_L02:
       test      ecx,ecx
       je        near ptr M01_L17
       cmp       dword ptr [rdi+8],0
       je        short M01_L06
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jae       short M01_L03
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L19
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFE5CDDD080]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M01_L19
M01_L04:
       mov       ecx,[rdi+8]
       dec       ecx
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L24
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L19
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE5CDDD080]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M01_L19
M01_L06:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       xor       edx,edx
       cmp       esi,7FFFFFFF
       setle     dl
       test      esi,esi
       cmovg     ecx,edx
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L20
M01_L07:
       test      eax,eax
       je        near ptr M01_L21
M01_L08:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L10
M01_L09:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-0C0],rax
       test      rdi,rdi
       je        near ptr M01_L23
       mov       ecx,[rdi+8]
       mov       rdx,rdi
       mov       [rbp-98],rdx
       xor       edx,edx
       mov       [rbp-90],edx
       mov       [rbp-8C],ecx
       mov       [rbp-0A0],edx
       mov       byte ptr [rbp-9C],0
       mov       byte ptr [rbp-9B],0
       lea       rcx,[rbp-98]
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFE5CAC59B0]; System.Text.Json.JsonDocument.Parse(System.ReadOnlyMemory`1<Char>, System.Text.Json.JsonDocumentOptions)
       mov       [rbp-0C8],rax
       jmp       short M01_L12
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FFE5CF13390
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L09
M01_L11:
       mov       rcx,rsp
       call      M01_L25
       nop
       mov       rax,[rbp-0C0]
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       cmp       [rax],al
       mov       rdi,rax
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L11
M01_L13:
       mov       rcx,[rbx+10]
       mov       r15,[rcx+18]
       test      r15,r15
       je        short M01_L15
M01_L14:
       lea       rdx,[rbp-58]
       mov       rcx,rdi
       xor       r8d,r8d
       mov       r9d,r14d
       call      qword ptr [7FFE5CAC5518]; System.Text.Json.JsonDocument.GetArrayIndexElement(Int32, Int32)
       mov       rax,[rbp-0C0]
       mov       r13,rax
       movsxd    r12,r14d
       mov       rcx,r15
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       lea       rdx,[rbp-0B0]
       mov       r8,227E8002B78
       mov       r8,[r8]
       call      qword ptr [7FFE5CF07B88]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.Text.Json.JsonElement, System.Text.Json.JsonSerializerOptions)
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r13
       call      CORINFO_HELP_ARRADDR_ST
       add       r14d,1
       jo        short M01_L16
       cmp       r14d,esi
       jl        short M01_L13
       jmp       near ptr M01_L11
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FFE5CF13428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r15,rax
       jmp       short M01_L14
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L17:
       call      qword ptr [7FFE5C9F4D98]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L18
       call      qword ptr [7FFE5C9F4AE0]
       mov       rdi,rax
M01_L18:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,26875E2E280
       mov       r8,rdi
       call      qword ptr [7FFE5C706670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE5C4E73F0]
       mov       rdi,rax
       jmp       near ptr M01_L06
M01_L20:
       movzx     ecx,byte ptr [rbp-48]
       test      cl,cl
       je        near ptr M01_L07
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE5C5947B0]
       mov       esi,eax
       jmp       near ptr M01_L08
M01_L21:
       call      qword ptr [7FFE5C9F4CD8]
       mov       r12,rax
       test      r12,r12
       jne       short M01_L22
       call      qword ptr [7FFE5C9F4AF8]
       mov       r12,rax
M01_L22:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,26875E14368
       mov       r8,r12
       call      qword ptr [7FFE5C59D470]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L23:
       mov       ecx,389E
       mov       rdx,7FFE5C996348
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C98C018]
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L25:
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
       lea       rbp,[rbp+130]
       mov       rax,[rbp-0C8]
       test      rax,rax
       je        near ptr M01_L71
       mov       edi,[rax+2C]
       test      edi,edi
       je        near ptr M01_L71
       cmp       byte ptr [rax+18],0
       je        near ptr M01_L71
       lea       r14,[rax+30]
       xor       ecx,ecx
       mov       r15,rcx
       xchg      r15,[r14]
       test      r15,r15
       je        near ptr M01_L47
       mov       rcx,227E4005568
       mov       r13,[rcx]
       mov       ecx,[r15+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFE5C425120
       mov       edx,4B
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M01_L26
       mov       rcx,r13
       call      qword ptr [7FFE5CC4C768]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M01_L26:
       xor       ebx,ebx
       mov       esi,1
       cmp       [rcx+8],r12d
       jbe       near ptr M01_L41
       mov       ebx,1
       mov       edx,10
       shlx      edx,edx,r12d
       cmp       [r15+8],edx
       je        short M01_L27
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFE5CA2F1C8]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE5C394000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r13
       call      qword ptr [7FFE5C4EF750]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L27:
       mov       edx,r12d
       shl       rdx,4
       lea       rax,[rcx+rdx+10]
       mov       [rbp-0E0],rax
       mov       r8,[rax]
       mov       [rbp-0E8],r8
       mov       rcx,rax
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-0E0]
       mov       [rdx+8],ecx
       cmp       qword ptr [rbp-0E8],0
       je        near ptr M01_L41
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       short M01_L30
       mov       edx,r12d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       jne       short M01_L28
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FFE5CC4C6F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       mov       r10,rax
M01_L28:
       mov       rsi,[r10+8]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+180],3
       jl        short M01_L29
       mov       rcx,[rcx+188]
       mov       r10,[rcx+18]
       test      r10,r10
       jne       short M01_L31
M01_L29:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       jmp       short M01_L31
M01_L30:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L31:
       mov       r9d,[r10+0A3C]
       lea       ecx,[r9-1]
       mov       [r10+0A3C],ecx
       movzx     ecx,r9w
       test      ecx,ecx
       jne       short M01_L32
       call      qword ptr [7FFE5CE0DD10]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M01_L33
M01_L32:
       sar       r9d,10
       mov       eax,r9d
M01_L33:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       mov       [rbp-68],edx
       mov       r8d,[rsi+8]
       mov       [rbp-0B4],r8d
       test      r8d,r8d
       jle       near ptr M01_L38
M01_L34:
       cmp       eax,r8d
       jae       short M01_L30
       mov       [rbp-64],eax
       mov       ecx,eax
       mov       r10,[rsi+rcx*8+10]
       mov       [rbp-0F0],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-6C],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-0F0]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-70],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L36
       test      r10d,r10d
       jne       short M01_L39
       xor       edx,edx
       mov       [rax+14],edx
M01_L35:
       movsxd    rdx,r10d
       mov       r8,[rbp-0E8]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-70]
       inc       ecx
       mov       rax,[rbp-0F0]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-6C],1
M01_L36:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-6C]
       test      ecx,ecx
       jne       short M01_L40
       mov       eax,[rbp-64]
       inc       eax
       mov       ecx,eax
       mov       r8d,[rbp-0B4]
       cmp       r8d,ecx
       jne       short M01_L37
       xor       ecx,ecx
M01_L37:
       mov       edx,[rbp-68]
       inc       edx
       cmp       r8d,edx
       mov       [rbp-68],edx
       mov       eax,ecx
       jg        near ptr M01_L34
M01_L38:
       xor       esi,esi
       jmp       short M01_L41
M01_L39:
       jmp       short M01_L35
M01_L40:
       mov       esi,1
M01_L41:
       mov       rcx,227E40005D0
       mov       r11,[rcx]
       mov       [rbp-0D0],r11
       cmp       byte ptr [r11+9D],0
       je        near ptr M01_L46
       cmp       dword ptr [r15+8],0
       je        near ptr M01_L46
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-5C],eax
       mov       edx,[r15+8]
       mov       [rbp-60],edx
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-0D0]
       mov       r8d,[rbp-5C]
       mov       r9d,[rbp-60]
       mov       edx,3
       call      qword ptr [7FFE5C597678]
       test      esi,ebx
       jne       short M01_L46
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       r15d,[r15+8]
       mov       rax,[rbp-0D0]
       mov       [rbp-0D8],rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      ebx,ebx
       jne       short M01_L42
       mov       r13,[rbp-0D8]
       mov       ecx,0FFFFFFFF
       jmp       short M01_L43
M01_L42:
       mov       r13,[rbp-0D8]
       mov       ecx,r12d
M01_L43:
       mov       edx,esi
       mov       r8d,r15d
       mov       r9d,eax
       test      ebx,ebx
       jne       short M01_L44
       mov       eax,1
       jmp       short M01_L45
M01_L44:
       xor       eax,eax
M01_L45:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r13
       call      qword ptr [7FFE5C7EF360]
M01_L46:
       xor       ecx,ecx
       mov       [r14+8],ecx
M01_L47:
       xor       ecx,ecx
       mov       rax,[rbp-0C8]
       mov       [rax+20],rcx
       mov       [rax+28],rcx
       cmp       qword ptr [rax+8],0
       je        near ptr M01_L70
       add       rax,8
       xor       ecx,ecx
       mov       rbx,rcx
       xchg      rbx,[rax]
       test      rbx,rbx
       je        near ptr M01_L71
       cmp       [rbx+8],edi
       jae       short M01_L48
       call      qword ptr [7FFE5C6DE9D0]
       int       3
M01_L48:
       cmp       [rbx],bl
       lea       rcx,[rbx+10]
       mov       edx,edi
       mov       [rbp-78],rdx
       test      rdx,rdx
       je        short M01_L50
       cmp       rdx,300
       ja        short M01_L49
       xor       edx,edx
       mov       r8d,[rbp-78]
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L50
M01_L49:
       mov       rdx,[rbp-78]
       call      qword ptr [7FFE5C595BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M01_L50:
       mov       rcx,227E4005568
       mov       rdi,[rcx]
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rcx,7FFE5C425120
       mov       edx,4B
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M01_L51
       mov       rcx,rdi
       call      qword ptr [7FFE5CC4C768]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M01_L51:
       xor       r14d,r14d
       mov       r15d,1
       cmp       [rcx+8],esi
       jbe       near ptr M01_L65
       mov       r14d,1
       mov       edx,10
       shlx      edx,edx,esi
       cmp       [rbx+8],edx
       je        short M01_L52
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE5CA2F1C8]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFE5C394000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE5C4EF750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L52:
       cmp       esi,[rcx+8]
       jae       near ptr M01_L30
       mov       edx,esi
       shl       rdx,4
       lea       r13,[rcx+rdx+10]
       mov       r12,[r13]
       mov       rcx,r13
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r13+8],eax
       test      r12,r12
       je        near ptr M01_L65
       mov       rax,[rdi+10]
       cmp       esi,[rax+8]
       jae       near ptr M01_L30
       mov       ecx,esi
       mov       rcx,[rax+rcx*8+10]
       test      rcx,rcx
       jne       short M01_L53
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFE5CC4C6F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       mov       rcx,rax
M01_L53:
       mov       r15,[rcx+8]
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+180],3
       jl        short M01_L54
       mov       rax,[rax+188]
       mov       r10,[rax+18]
       test      r10,r10
       jne       short M01_L55
M01_L54:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
M01_L55:
       mov       edx,[r10+0A3C]
       lea       eax,[rdx-1]
       mov       [r10+0A3C],eax
       movzx     eax,dx
       test      eax,eax
       jne       short M01_L56
       call      qword ptr [7FFE5CE0DD10]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M01_L57
M01_L56:
       mov       eax,edx
       sar       eax,10
M01_L57:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r13d,eax
       sub       r13d,ecx
       xor       eax,eax
       mov       [rbp-80],eax
       mov       edx,[r15+8]
       mov       [rbp-0B8],edx
       test      edx,edx
       jle       near ptr M01_L62
M01_L58:
       cmp       r13d,edx
       jae       near ptr M01_L30
       mov       ecx,r13d
       mov       r8,[r15+rcx*8+10]
       mov       [rbp-0F8],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-84],r10d
       mov       rcx,r8
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-0F8]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-88],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L60
       test      r10d,r10d
       jne       short M01_L63
       xor       edx,edx
       mov       [rax+14],edx
M01_L59:
       movsxd    rdx,r10d
       mov       r8,r12
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-88]
       inc       ecx
       mov       rax,[rbp-0F8]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-84],1
M01_L60:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-84]
       test      ecx,ecx
       jne       short M01_L64
       inc       r13d
       mov       ecx,[rbp-0B8]
       cmp       ecx,r13d
       jne       short M01_L61
       xor       r13d,r13d
M01_L61:
       mov       eax,[rbp-80]
       inc       eax
       cmp       ecx,eax
       mov       [rbp-80],eax
       mov       edx,ecx
       jg        near ptr M01_L58
M01_L62:
       xor       r15d,r15d
       jmp       short M01_L65
M01_L63:
       jmp       short M01_L59
M01_L64:
       mov       r15d,1
M01_L65:
       mov       rax,227E40005D0
       mov       r13,[rax]
       cmp       byte ptr [r13+9D],0
       je        near ptr M01_L71
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L71
       cmp       [rbx],bl
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       eax,[rbx+8]
       mov       [rbp-7C],eax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rbp-7C]
       mov       edx,3
       call      qword ptr [7FFE5C597678]
       test      r15d,r14d
       jne       short M01_L71
       cmp       [rbx],bl
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      r14d,r14d
       jne       short M01_L66
       mov       ecx,0FFFFFFFF
       jmp       short M01_L67
M01_L66:
       mov       ecx,esi
M01_L67:
       mov       edx,r15d
       mov       r8d,ebx
       mov       r9d,eax
       test      r14d,r14d
       jne       short M01_L68
       mov       eax,1
       jmp       short M01_L69
M01_L68:
       xor       eax,eax
M01_L69:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r13
       call      qword ptr [7FFE5C7EF360]
       jmp       short M01_L71
M01_L70:
       cmp       qword ptr [rax+10],0
       je        short M01_L71
       lea       rcx,[rax+10]
       xor       eax,eax
       xchg      rax,[rcx]
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L71
       call      qword ptr [7FFE5CD2D058]; Precode of System.Text.Json.PooledByteBufferWriter.Dispose()
M01_L71:
       nop
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
; Total bytes of code 2712
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_JsonSerializer_Generator_Person_List()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+130]
       mov       rcx,1D7830083C8
       mov       rdi,[rcx]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdx,rax
       mov       rcx,218150FD850
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C43A7B0]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FFE5C9964D8]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       cmp       [rbp],bpl
       mov       rcx,218150FD850
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,0F
       je        near ptr M00_L06
       mov       rcx,218150FD850
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,10
       je        near ptr M00_L06
       mov       rcx,218150FD850
       call      System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L06
       mov       rcx,218150FD850
       call      qword ptr [7FFE5C4460B8]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L04
       test      rcx,rcx
       je        near ptr M00_L05
M00_L01:
       call      System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L06
       mov       rcx,rbp
       mov       byte ptr [rsp+30],0
       mov       byte ptr [rsp+31],0
       mov       dword ptr [rsp+20],1
       xor       edx,edx
       mov       [rsp+28],edx
       mov       rdx,218150FD850
       movzx     r9d,word ptr [rsp+30]
       mov       r8d,1
       call      qword ptr [7FFE5C995C98]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L07
       cmp       byte ptr [r14+115],2
       jne       near ptr M00_L08
M00_L02:
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFE5C997978]; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       [rsp+38],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,218150FD850
       mov       rdx,rsi
       call      qword ptr [7FFE5C99C6D8]
       int       3
M00_L04:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L01
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE5CA3D098]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE5C716670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,3C04
       mov       rdx,7FFE5C9A6348
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,218150FD850
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE5C99C8E8]
       int       3
M00_L07:
       mov       rcx,218150FD850
       mov       rdx,rdi
       call      qword ptr [7FFE5C99CFA8]
       int       3
M00_L08:
       mov       rcx,r14
       call      qword ptr [7FFE5CA0CAC8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       near ptr M00_L02
; Total bytes of code 533
```
```assembly
; System.RuntimeType.IsAssignableFrom(System.Type)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L01
       cmp       rbx,rsi
       jne       short M01_L02
M01_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movzx     eax,al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFE5C4F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M01_L03:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FFE5C4F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M01_L00
       mov       rcx,rsi
       call      qword ptr [7FFE5C444E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L04
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE5C446148]
M01_L04:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        near ptr M01_L01
       mov       rcx,rsi
       call      qword ptr [7FFE5C43A5A0]; Precode of System.RuntimeType.GetGenericParameterConstraints()
       mov       rsi,rax
       xor       edi,edi
       jmp       short M01_L06
M01_L05:
       mov       ecx,edi
       mov       rcx,[rsi+rcx*8+10]
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M01_L01
       inc       edi
M01_L06:
       cmp       [rsi+8],edi
       jg        short M01_L05
       jmp       near ptr M01_L00
; Total bytes of code 272
```
```assembly
; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M02_L01
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L01:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C995DE8]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5C995E78]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE5C9963B8]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L00
; Total bytes of code 90
```
```assembly
; System.Type.GetRootElementType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       short M03_L04
M03_L00:
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,14
       je        short M03_L01
       cmp       eax,1D
       je        short M03_L01
       cmp       eax,0F
       je        short M03_L01
       xor       edx,edx
       cmp       eax,10
       sete      dl
       jmp       short M03_L02
M03_L01:
       mov       edx,1
M03_L02:
       test      edx,edx
       jne       short M03_L03
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       je        short M03_L00
M03_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edx,eax
       jmp       short M03_L02
; Total bytes of code 121
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp+28],r9
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,[rbp+38]
       xor       r15d,r15d
       cmp       byte ptr [rsi+9D],0
       je        near ptr M04_L10
       mov       r13,[rsi+8]
       test      r13,r13
       je        near ptr M04_L12
M04_L00:
       mov       r12,[r13+8]
       mov       rcx,1D78300A720
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M04_L13
       cmp       [r12],r12b
       test      rbx,rbx
       je        near ptr M04_L14
M04_L01:
       test      r15,r15
       je        near ptr M04_L15
       mov       rax,[r12+8]
       mov       [rbp-58],rax
       mov       rcx,[rax+8]
       cmp       byte ptr [r12+15],0
       je        near ptr M04_L08
       mov       rcx,rbx
       mov       rdx,[rbx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
M04_L02:
       mov       [rbp-3C],eax
       lea       rdx,[rbp-48]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-58]
       mov       r8,rbx
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      qword ptr [7FFE5C914FD8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M04_L16
M04_L03:
       mov       r8,[rbp-48]
       xor       eax,eax
       mov       [rbp-48],rax
       test      r14b,r14b
       jne       near ptr M04_L17
M04_L04:
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M04_L18
       mov       r15,[r8+8]
M04_L05:
       test      dil,dil
       je        short M04_L06
       test      r15,r15
       je        short M04_L06
       cmp       byte ptr [r15+115],2
       jne       short M04_L09
M04_L06:
       test      r15,r15
       je        short M04_L11
M04_L07:
       mov       rax,r15
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L08:
       mov       rdx,rbx
       mov       r11,7FFE5C3B0DC8
       call      qword ptr [r11]
       jmp       near ptr M04_L02
M04_L09:
       mov       rcx,r15
       call      qword ptr [7FFE5CA0CAC8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M04_L06
M04_L10:
       cmp       byte ptr [rbp+30],0
       je        short M04_L06
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5C996400]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r15,rax
       jmp       short M04_L06
M04_L11:
       cmp       byte ptr [rbp+29],0
       je        short M04_L07
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FFE5C99CF60]
       int       3
M04_L12:
       mov       rcx,rsi
       call      qword ptr [7FFE5C9964C0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r13,rax
       jmp       near ptr M04_L00
M04_L13:
       mov       rcx,offset MT_System.Func`3[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFE5C3AD0E0
       call      qword ptr [7FFE5C4F4258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1D78300A720
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [r12],r12b
       test      rbx,rbx
       jne       near ptr M04_L01
M04_L14:
       mov       ecx,1
       mov       rdx,7FFE5C9202D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5CB56190]
       int       3
M04_L15:
       mov       ecx,0BB4
       mov       rdx,7FFE5C9202D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5CB56190]
       int       3
M04_L16:
       mov       edx,[rbp-3C]
       mov       rax,[rbp-58]
       mov       [rbp-60],rax
       mov       byte ptr [rbp-50],1
       mov       [rbp-4C],edx
       mov       rdx,rbx
       mov       r8,r13
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-48]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,[rbp-60]
       mov       r8,rbx
       mov       r9,[rbp-50]
       mov       rcx,r12
       call      qword ptr [7FFE5C9150C8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M04_L03
M04_L17:
       cmp       byte ptr [r8+20],0
       jne       near ptr M04_L04
       mov       rcx,r13
       mov       rdx,rbx
       call      qword ptr [7FFE5CA0D800]
       mov       r15,rax
       jmp       near ptr M04_L05
M04_L18:
       call      qword ptr [7FFE5CAB64A8]
       int       3
; Total bytes of code 644
```
```assembly
; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M05_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M05_L00
       mov       [rbp-40],rax
       mov       [rbp-0B0],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rsi+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C996460]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M05_L15
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M05_L15
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M05_L16
M05_L01:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M05_L19
       mov       rcx,[r14+8]
       mov       [rbp-98],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-98]
       cmp       [rcx],cl
       mov       rcx,1D783005568
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE5CC765F8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-98]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-98]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M05_L02
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M05_L03
M05_L02:
       mov       edx,2
M05_L03:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M05_L17
       mov       rdi,218150E1C08
M05_L04:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M05_L18
M05_L05:
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       short M05_L10
       mov       rcx,rbx
       test      rcx,rcx
       je        short M05_L06
       mov       rdx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdx
       je        short M05_L06
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFE5C4F43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
M05_L06:
       mov       [rbp-50],rbx
       lea       r8,[rbp-50]
       mov       rcx,rsi
       mov       rdx,r14
       mov       r9,rbx
       call      qword ptr [7FFE5CA0CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       ecx,ecx
       mov       [rbp-50],rcx
       jmp       short M05_L11
M05_L07:
       call      qword ptr [7FFE5C6EE9D0]
       int       3
M05_L08:
       test      esi,esi
       jne       short M05_L07
       xor       ecx,ecx
       xor       esi,esi
       jmp       short M05_L12
M05_L09:
       lea       rdx,[rbp-60]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r15,[rbp-60]
       mov       r13d,[rbp-58]
       jmp       short M05_L13
M05_L10:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rbx
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M05_L11:
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-98]
       mov       esi,[rax+20]
       test      rcx,rcx
       je        short M05_L08
       cmp       [rcx+8],esi
       jb        short M05_L07
M05_L12:
       xor       r15d,r15d
       xor       r13d,r13d
       test      rcx,rcx
       je        short M05_L14
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M05_L09
       lea       r15,[rcx+10]
       mov       r13d,[rcx+8]
M05_L13:
       cmp       esi,r13d
       ja        short M05_L07
       mov       r13d,esi
M05_L14:
       mov       rcx,r15
       mov       [rbp-88],rcx
       mov       [rbp-80],r13d
       lea       rcx,[rbp-88]
       call      qword ptr [7FFE5CA0E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-0A0],rax
       mov       rcx,rsp
       call      M05_L20
       nop
       mov       rax,[rbp-0A0]
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M05_L01
M05_L16:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE5CD569E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L17:
       mov       rcx,7FFE5C9A7E58
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D78300A750
       mov       rdi,[rcx]
       jmp       near ptr M05_L04
M05_L18:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE5CC9F960]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M05_L05
M05_L19:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE5CD564F0]
       mov       [rbp-98],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rcx,r13
       lea       r8,[rbp-78]
       call      qword ptr [7FFE5CD540D8]
       mov       r14,r13
       jmp       near ptr M05_L05
M05_L20:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0D0]
       mov       rsi,[rbp-98]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        short M05_L21
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M05_L22
M05_L21:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M05_L23
M05_L22:
       mov       rax,[rcx]
       add       rax,10
M05_L23:
       mov       r14,[rax]
       xor       ecx,ecx
       mov       r13,[rbp-90]
       mov       [r13+34],ecx
       mov       [r13+20],rcx
       mov       [r13+40],rcx
       mov       [r13+48],rcx
       mov       byte ptr [r13+38],0
       mov       byte ptr [r13+3A],0
       mov       byte ptr [r13+39],0
       mov       [r13+28],ecx
       mov       [r13+50],rcx
       mov       [r13+58],rcx
       mov       [r13+60],rcx
       mov       [r13+10],rcx
       mov       [r13+18],rcx
       mov       [r13+8],rcx
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-98]
       mov       r12d,[rdx+20]
       test      rcx,rcx
       jne       short M05_L24
       test      r12d,r12d
       jne       short M05_L25
       xor       ecx,ecx
       xor       r12d,r12d
       jmp       short M05_L27
M05_L24:
       cmp       [rcx+8],r12d
       jae       short M05_L26
M05_L25:
       call      qword ptr [7FFE5C6EE9D0]
       int       3
M05_L26:
       add       rcx,10
M05_L27:
       mov       edx,r12d
       mov       [rbp-68],rdx
       test      rdx,rdx
       je        short M05_L29
       cmp       rdx,300
       ja        short M05_L28
       xor       edx,edx
       mov       r8d,[rbp-68]
       call      CORINFO_HELP_MEMSET
       jmp       short M05_L29
M05_L28:
       mov       rdx,[rbp-68]
       call      qword ptr [7FFE5C5A5BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M05_L29:
       xor       ecx,ecx
       mov       [rsi+20],ecx
       mov       rdx,[rsi+10]
       mov       [rsi+10],rcx
       mov       rcx,1D783005568
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE5CC76600]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r14+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1242
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-50],rsp
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5CA0C528]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C9963B8]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5CA0C318]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.MakeReadOnly()
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+0E8]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-20],0
       jne       short M06_L00
       jmp       short M06_L01
M06_L00:
       mov       rcx,7FFE5D042C18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-28]
       call      qword ptr [7FFE5CAB64A8]
M06_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5CA0C528]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C995C50]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-8],rax
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFE5C4FE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       movzx     ecx,byte ptr [rcx+115]
       test      ecx,ecx
       je        short M06_L02
       jmp       short M06_L05
M06_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+0E8]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-30],0
       jne       short M06_L03
       jmp       short M06_L04
M06_L03:
       mov       rcx,7FFE5D042C1C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE5CAB64A8]
M06_L04:
       nop
       mov       rcx,7FFE5D042C20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+115],1
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5CA0C768]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+115],2
       jmp       short M06_L06
M06_L05:
       mov       rcx,rsp
       call      M06_L08
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsp
       call      M06_L08
       nop
M06_L07:
       mov       rcx,7FFE5D042C2C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,70
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       [rbp-40],rdx
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE5CAB6478]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0E8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       byte ptr [rax+115],0
       call      CORINFO_HELP_RETHROW
       int       3
M06_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M06_L09
       mov       rcx,7FFE5D042C24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L09:
       mov       rcx,7FFE5D042C28
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 489
```
**Extern method**
System.Object.GetType()
System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_JsonSerializer_Generator_Person()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+40]
       mov       rcx,210888083C8
       mov       rdi,[rcx]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdx,rax
       mov       rcx,2511A5E3DA0
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C41A7B0]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FFE5C9764D8]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       cmp       [rbp],bpl
       mov       rcx,2511A5E3DA0
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,0F
       je        near ptr M00_L06
       mov       rcx,2511A5E3DA0
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,10
       je        near ptr M00_L06
       mov       rcx,2511A5E3DA0
       call      System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L06
       mov       rcx,2511A5E3DA0
       call      qword ptr [7FFE5C4260B8]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L04
       test      rcx,rcx
       je        near ptr M00_L05
M00_L01:
       call      System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L06
       mov       rcx,rbp
       mov       byte ptr [rsp+30],0
       mov       byte ptr [rsp+31],0
       mov       dword ptr [rsp+20],1
       xor       edx,edx
       mov       [rsp+28],edx
       mov       rdx,2511A5E3DA0
       movzx     r9d,word ptr [rsp+30]
       mov       r8d,1
       call      qword ptr [7FFE5C975C98]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L07
       cmp       byte ptr [r14+115],2
       jne       near ptr M00_L08
M00_L02:
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFE5C977978]; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       [rsp+38],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,2511A5E3DA0
       mov       rdx,rsi
       call      qword ptr [7FFE5C97C6D8]
       int       3
M00_L04:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L01
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE5CA1D098]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,3C04
       mov       rdx,7FFE5C986348
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,2511A5E3DA0
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE5C97C8E8]
       int       3
M00_L07:
       mov       rcx,2511A5E3DA0
       mov       rdx,rdi
       call      qword ptr [7FFE5C97CFA8]
       int       3
M00_L08:
       mov       rcx,r14
       call      qword ptr [7FFE5C9ECAC8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       near ptr M00_L02
; Total bytes of code 530
```
```assembly
; System.RuntimeType.IsAssignableFrom(System.Type)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L01
       cmp       rbx,rsi
       jne       short M01_L02
M01_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movzx     eax,al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFE5C4D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M01_L03:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FFE5C4D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M01_L00
       mov       rcx,rsi
       call      qword ptr [7FFE5C424E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L04
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE5C426148]
M01_L04:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        near ptr M01_L01
       mov       rcx,rsi
       call      qword ptr [7FFE5C41A5A0]; Precode of System.RuntimeType.GetGenericParameterConstraints()
       mov       rsi,rax
       xor       edi,edi
       jmp       short M01_L06
M01_L05:
       mov       ecx,edi
       mov       rcx,[rsi+rcx*8+10]
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M01_L01
       inc       edi
M01_L06:
       cmp       [rsi+8],edi
       jg        short M01_L05
       jmp       near ptr M01_L00
; Total bytes of code 272
```
```assembly
; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M02_L01
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L01:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C975DE8]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5C975E78]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE5C9763B8]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L00
; Total bytes of code 90
```
```assembly
; System.Type.GetRootElementType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       short M03_L04
M03_L00:
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,14
       je        short M03_L01
       cmp       eax,1D
       je        short M03_L01
       cmp       eax,0F
       je        short M03_L01
       xor       edx,edx
       cmp       eax,10
       sete      dl
       jmp       short M03_L02
M03_L01:
       mov       edx,1
M03_L02:
       test      edx,edx
       jne       short M03_L03
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       je        short M03_L00
M03_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edx,eax
       jmp       short M03_L02
; Total bytes of code 121
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp+28],r9
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       xor       r14d,r14d
       cmp       byte ptr [rsi+9D],0
       je        near ptr M04_L10
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M04_L12
M04_L00:
       mov       r13,[r15+8]
       mov       rcx,2108880A720
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M04_L13
       cmp       [r13],r13b
       test      rbx,rbx
       je        near ptr M04_L14
M04_L01:
       test      r12,r12
       je        near ptr M04_L15
       mov       r14,[r13+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [r13+15],0
       je        near ptr M04_L08
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
M04_L02:
       mov       [rbp-3C],eax
       lea       rdx,[rbp-48]
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rbx
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      qword ptr [7FFE5C8F4FD8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M04_L16
M04_L03:
       mov       r8,[rbp-48]
       xor       eax,eax
       mov       [rbp-48],rax
       cmp       byte ptr [rbp+38],0
       jne       near ptr M04_L17
M04_L04:
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M04_L18
       mov       r14,[r8+8]
M04_L05:
       test      dil,dil
       je        short M04_L06
       test      r14,r14
       je        short M04_L06
       cmp       byte ptr [r14+115],2
       jne       short M04_L09
M04_L06:
       test      r14,r14
       je        short M04_L11
M04_L07:
       mov       rax,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L08:
       mov       rdx,rbx
       mov       r11,7FFE5C390DC8
       call      qword ptr [r11]
       jmp       near ptr M04_L02
M04_L09:
       mov       rcx,r14
       call      qword ptr [7FFE5C9ECAC8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M04_L06
M04_L10:
       cmp       byte ptr [rbp+30],0
       je        short M04_L06
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5C976400]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r14,rax
       jmp       short M04_L06
M04_L11:
       cmp       byte ptr [rbp+29],0
       je        short M04_L07
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FFE5C97CF60]
       int       3
M04_L12:
       mov       rcx,rsi
       call      qword ptr [7FFE5C9764C0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r15,rax
       jmp       near ptr M04_L00
M04_L13:
       mov       rcx,offset MT_System.Func`3[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFE5C38D0E0
       call      qword ptr [7FFE5C4D4258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,2108880A720
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [r13],r13b
       test      rbx,rbx
       jne       near ptr M04_L01
M04_L14:
       mov       ecx,1
       mov       rdx,7FFE5C9002D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5CB36190]
       int       3
M04_L15:
       mov       ecx,0BB4
       mov       rdx,7FFE5C9002D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5CB36190]
       int       3
M04_L16:
       mov       edx,[rbp-3C]
       mov       byte ptr [rbp-50],1
       mov       [rbp-4C],edx
       mov       rdx,rbx
       mov       r8,r15
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-48]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,[rbp-50]
       mov       rcx,r13
       call      qword ptr [7FFE5C8F50C8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M04_L03
M04_L17:
       cmp       byte ptr [r8+20],0
       jne       near ptr M04_L04
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFE5C9ED800]
       mov       r14,rax
       jmp       near ptr M04_L05
M04_L18:
       call      qword ptr [7FFE5CA964A8]
       int       3
; Total bytes of code 627
```
```assembly
; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M05_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M05_L00
       mov       [rbp-40],rax
       mov       [rbp-0B0],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rsi+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C976460]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M05_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M05_L16
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M05_L17
M05_L01:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M05_L20
       mov       rcx,[r14+8]
       mov       [rbp-98],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-98]
       cmp       [rcx],cl
       mov       rcx,21088805568
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE5CC565F8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-98]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-98]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rbp-40]
       mov       [r14+70],r8d
       mov       r8d,[rbp-3C]
       mov       [r14+74],r8d
       mov       r8d,9
       mov       ecx,20
       test      byte ptr [r14+74],8
       cmove     r8d,ecx
       mov       [r14+3B],r8b
       mov       r8d,edi
       and       r8d,7F0
       sar       r8d,4
       je        short M05_L02
       xor       ecx,ecx
       cmp       r8d,2
       cmovne    ecx,r8d
       jmp       short M05_L03
M05_L02:
       mov       ecx,2
M05_L03:
       mov       [r14+2C],ecx
       test      dil,4
       jne       near ptr M05_L18
       mov       rdi,2511A5D1C08
M05_L04:
       mov       r8d,[rdi+8]
       mov       [r14+30],r8d
       cmp       dword ptr [r14+70],0
       je        near ptr M05_L19
M05_L05:
       mov       [rbp-90],r14
       mov       r8,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],r8
       jne       short M05_L11
       mov       rcx,rsi
       mov       r8,rbx
       test      r8,r8
       je        short M05_L06
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [r8],rax
       jne       short M05_L09
M05_L06:
       mov       [rbp-50],rbx
       lea       r8,[rbp-50]
       mov       rdx,r14
       mov       r9,rbx
       call      qword ptr [7FFE5C9ECE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       ecx,ecx
       mov       [rbp-50],rcx
       jmp       short M05_L12
M05_L07:
       call      qword ptr [7FFE5C6CE9D0]
       int       3
M05_L08:
       test      r15d,r15d
       jne       short M05_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M05_L13
M05_L09:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE5C4D43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M05_L10:
       lea       rdx,[rbp-60]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-60]
       mov       r12d,[rbp-58]
       jmp       short M05_L14
M05_L11:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rbx
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M05_L12:
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-98]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M05_L08
       cmp       [rcx+8],r15d
       jb        short M05_L07
M05_L13:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M05_L15
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M05_L10
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M05_L14:
       cmp       r15d,r12d
       ja        near ptr M05_L07
       mov       r12d,r15d
M05_L15:
       mov       rcx,r13
       mov       [rbp-88],rcx
       mov       [rbp-80],r12d
       lea       rcx,[rbp-88]
       call      qword ptr [7FFE5C9EE370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-0A0],rax
       mov       rcx,rsp
       call      M05_L21
       nop
       mov       rax,[rbp-0A0]
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L16:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M05_L01
M05_L17:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE5CD369E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L18:
       mov       rcx,7FFE5C987E58
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2108880A750
       mov       rdi,[rcx]
       jmp       near ptr M05_L04
M05_L19:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE5CC7F9C0]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M05_L05
M05_L20:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE5CD364F0]
       mov       [rbp-98],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rcx,r12
       lea       r8,[rbp-78]
       call      qword ptr [7FFE5CD340D8]
       mov       r14,r12
       jmp       near ptr M05_L05
M05_L21:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0D0]
       mov       r14,[rbp-98]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        short M05_L22
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M05_L23
M05_L22:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M05_L24
M05_L23:
       mov       rax,[rcx]
       add       rax,10
M05_L24:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-90]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-98]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M05_L25
       test      r10d,r10d
       jne       short M05_L26
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M05_L28
M05_L25:
       cmp       [rcx+8],r10d
       jae       short M05_L27
M05_L26:
       call      qword ptr [7FFE5C6CE9D0]
       int       3
M05_L27:
       add       rcx,10
M05_L28:
       mov       edx,r10d
       mov       [rbp-68],rdx
       test      rdx,rdx
       je        short M05_L30
       cmp       rdx,300
       ja        short M05_L29
       xor       edx,edx
       mov       r8d,[rbp-68]
       call      CORINFO_HELP_MEMSET
       jmp       short M05_L30
M05_L29:
       mov       rdx,[rbp-68]
       call      qword ptr [7FFE5C585BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M05_L30:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,21088805568
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE5CC56600]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1276
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-50],rsp
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5C9EC528]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C9763B8]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5C9EC318]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.MakeReadOnly()
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+0E8]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-20],0
       jne       short M06_L00
       jmp       short M06_L01
M06_L00:
       mov       rcx,7FFE5D010A08
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-28]
       call      qword ptr [7FFE5CA964A8]
M06_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5C9EC528]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C975C50]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-8],rax
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFE5C4DE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       movzx     ecx,byte ptr [rcx+115]
       test      ecx,ecx
       je        short M06_L02
       jmp       short M06_L05
M06_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+0E8]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-30],0
       jne       short M06_L03
       jmp       short M06_L04
M06_L03:
       mov       rcx,7FFE5D010A0C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE5CA964A8]
M06_L04:
       nop
       mov       rcx,7FFE5D010A10
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+115],1
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5C9EC768]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+115],2
       jmp       short M06_L06
M06_L05:
       mov       rcx,rsp
       call      M06_L08
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsp
       call      M06_L08
       nop
M06_L07:
       mov       rcx,7FFE5D010A1C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,70
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       [rbp-40],rdx
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE5CA96478]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0E8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       byte ptr [rax+115],0
       call      CORINFO_HELP_RETHROW
       int       3
M06_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M06_L09
       mov       rcx,7FFE5D010A14
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L09:
       mov       rcx,7FFE5D010A18
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 489
```
**Extern method**
System.Object.GetType()
System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Ref_Person()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rax,[rbx+40]
       test      rax,rax
       je        near ptr M00_L03
       mov       [rsp+30],rax
       call      qword ptr [7FFE5C995DB8]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE5C9963E8]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE5C995CF8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE5CC9EC88]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M00_L01
       mov       rdx,rax
       call      qword ptr [7FFE5C4F43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FFE5CA04CF0]
       mov       ecx,11A4
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 312
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,1E31F00A710
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,1E31F00A710
       xor       edx,edx
       jmp       qword ptr [7FFE5C996490]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M02_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFE5C997120]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M02_L05
       call      qword ptr [7FFE5CA0D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFE5C4F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M02_L03
       jmp       near ptr M02_L09
M02_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L09
M02_L03:
       call      qword ptr [7FFE5C996B20]
       test      eax,eax
       je        near ptr M02_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFE5CA0D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFE5CA0D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFE5CA0D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE5CA0D920]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M02_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CA0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M02_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CA0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M02_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CA0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C9963E8]
       jmp       short M02_L09
M02_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CA0D7B8]
       jmp       short M02_L09
M02_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M02_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFE5C4F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L07
M02_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M02_L08
M02_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M02_L08:
       cmp       dword ptr [rbp-34],0
       je        short M02_L09
       call      qword ptr [7FFE5C99C978]
M02_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M03_L01:
       mov       byte ptr [rsp+30],1
       mov       byte ptr [rsp+31],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       movzx     r9d,word ptr [rsp+30]
       mov       rdx,223B0DC2D10
       mov       r8d,1
       call      qword ptr [7FFE5C995C98]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M03_L00
; Total bytes of code 96
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C996460]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M04_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M04_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M04_L12
M04_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M04_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,1E31F005568
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE5CC765F8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M04_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M04_L02
M04_L01:
       mov       edx,2
M04_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M04_L13
       mov       rdi,223B0DC1C08
M04_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M04_L14
M04_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE5CA0CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M04_L08
       cmp       [rcx+8],r15d
       jb        short M04_L07
M04_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M04_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M04_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M04_L06:
       cmp       r15d,r12d
       ja        short M04_L07
       mov       r12d,r15d
       jmp       short M04_L10
M04_L07:
       call      qword ptr [7FFE5C6EE9D0]
       int       3
M04_L08:
       test      r15d,r15d
       jne       short M04_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M04_L05
M04_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M04_L06
M04_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFE5CA0E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M04_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L11:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M04_L00
M04_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE5CD569E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L00
M04_L13:
       mov       rcx,7FFE5C9A7E58
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E31F00A750
       mov       rdi,[rcx]
       jmp       near ptr M04_L03
M04_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE5CC9F9C0]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M04_L04
M04_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE5CD564F0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFE5CD540D8]
       mov       r14,r13
       jmp       near ptr M04_L04
M04_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        short M04_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M04_L18
M04_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M04_L19
M04_L18:
       mov       rax,[rcx]
       add       rax,10
M04_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M04_L20
       test      r10d,r10d
       jne       short M04_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M04_L23
M04_L20:
       cmp       [rcx+8],r10d
       jae       short M04_L22
M04_L21:
       call      qword ptr [7FFE5C6EE9D0]
       int       3
M04_L22:
       add       rcx,10
M04_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M04_L25
       cmp       rdx,300
       ja        short M04_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M04_L25
M04_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFE5C5A5BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M04_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,1E31F005568
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE5CC76600]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1178
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
       je        short M05_L01
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
       je        short M05_L02
       jmp       short M05_L00
M05_L01:
       mov       rax,rdx
       ret
M05_L02:
       jmp       qword ptr [7FFE5C4F43A8]
; Total bytes of code 71
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M06_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M06_L02
       test      rbx,rbx
       je        short M06_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M06_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L01:
       call      qword ptr [7FFE5C6EEF40]
       int       3
M06_L02:
       test      rbx,rbx
       je        short M06_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M06_L04
M06_L03:
       mov       rax,223B0DC0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_PersonRecord()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rax,[rbx+38]
       test      rax,rax
       je        near ptr M00_L03
       mov       [rsp+30],rax
       call      qword ptr [7FFE5C985DB8]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE5C9863E8]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE5C985CF8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE5CC8E6E8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M00_L01
       mov       rdx,rax
       call      qword ptr [7FFE5C4E43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FFE5C9F4CF0]
       mov       ecx,11A4
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9F4AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 312
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,20610808718
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,20610808718
       xor       edx,edx
       jmp       qword ptr [7FFE5C986490]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M02_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFE5C987120]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M02_L05
       call      qword ptr [7FFE5C9FD698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFE5C4E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M02_L03
       jmp       near ptr M02_L09
M02_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L09
M02_L03:
       call      qword ptr [7FFE5C986B20]
       test      eax,eax
       je        near ptr M02_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFE5C9FD8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFE5C9FD8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFE5C9FD8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE5C9FD920]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M02_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C9FD740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M02_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C9FD740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M02_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C9FD740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C9863E8]
       jmp       short M02_L09
M02_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C9FD7B8]
       jmp       short M02_L09
M02_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M02_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFE5C4E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L07
M02_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M02_L08
M02_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M02_L08:
       cmp       dword ptr [rbp-34],0
       je        short M02_L09
       call      qword ptr [7FFE5C98C978]
M02_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M03_L01:
       mov       byte ptr [rsp+30],1
       mov       byte ptr [rsp+31],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       movzx     r9d,word ptr [rsp+30]
       mov       rdx,246A25C2D10
       mov       r8d,1
       call      qword ptr [7FFE5C985C98]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M03_L00
; Total bytes of code 96
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C986460]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M04_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M04_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M04_L12
M04_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M04_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,20610803570
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE5CC665F8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M04_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M04_L02
M04_L01:
       mov       edx,2
M04_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M04_L13
       mov       rdi,246A25C1C08
M04_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M04_L14
M04_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE5C9FCE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M04_L08
       cmp       [rcx+8],r15d
       jb        short M04_L07
M04_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M04_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M04_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M04_L06:
       cmp       r15d,r12d
       ja        short M04_L07
       mov       r12d,r15d
       jmp       short M04_L10
M04_L07:
       call      qword ptr [7FFE5C6DE9D0]
       int       3
M04_L08:
       test      r15d,r15d
       jne       short M04_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M04_L05
M04_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M04_L06
M04_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFE5C9FE370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M04_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L11:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M04_L00
M04_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE5CD461D8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L00
M04_L13:
       mov       rcx,7FFE5C997E58
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20610808758
       mov       rdi,[rcx]
       jmp       near ptr M04_L03
M04_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE5CC8F420]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M04_L04
M04_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE5CD45CE0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFE5CC8F5A0]
       mov       r14,r13
       jmp       near ptr M04_L04
M04_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        short M04_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M04_L18
M04_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M04_L19
M04_L18:
       mov       rax,[rcx]
       add       rax,10
M04_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M04_L20
       test      r10d,r10d
       jne       short M04_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M04_L23
M04_L20:
       cmp       [rcx+8],r10d
       jae       short M04_L22
M04_L21:
       call      qword ptr [7FFE5C6DE9D0]
       int       3
M04_L22:
       add       rcx,10
M04_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M04_L25
       cmp       rdx,300
       ja        short M04_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M04_L25
M04_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFE5C595BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M04_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,20610803570
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE5CC66600]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1178
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
       je        short M05_L01
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
       je        short M05_L02
       jmp       short M05_L00
M05_L01:
       mov       rax,rdx
       ret
M05_L02:
       jmp       qword ptr [7FFE5C4E43A8]
; Total bytes of code 71
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M06_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M06_L02
       test      rbx,rbx
       je        short M06_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M06_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE5C595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE5C595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L01:
       call      qword ptr [7FFE5C6DEF40]
       int       3
M06_L02:
       test      rbx,rbx
       je        short M06_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M06_L04
M06_L03:
       mov       rax,246A25C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Person_List()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FFE5C935788]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       test      rcx,rcx
       je        short M01_L02
       mov       [rsp+20],rcx
       call      qword ptr [7FFE5C975DB8]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rbx,rax
       cmp       byte ptr [rbx+9E],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FFE5C9763E8]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFE5C975CF8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L03
M01_L01:
       lea       rdx,[rsp+20]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE5CC7E6E8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       call      qword ptr [7FFE5C9E4CF0]
       mov       ecx,11A4
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9E4AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rdx,rax
       call      qword ptr [7FFE5C4D43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 271
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_XML_Ref_Person()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       call      qword ptr [7FFE5C935C08]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
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
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-40],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M01_L13
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M01_L13
       mov       rax,[rcx]
       add       rax,10
M01_L00:
       mov       r14,[rax+8]
       test      r14,r14
       jne       short M01_L01
       mov       rcx,139DB000438
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L01
       mov       rcx,139DB000418
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L14
M01_L01:
       mov       rcx,139DB0014E8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,17A69031C08
       mov       [rsi+10],rcx
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+28],1
       mov       [rbp-30],rsi
       mov       rcx,139D7009660
       mov       r14,[rcx]
       mov       rcx,offset MT_System.Xml.XmlEncodedRawTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFE5CDCF228]; System.Xml.XmlEncodedRawTextWriter..ctor(System.Xml.XmlWriterSettings)
       lea       rcx,[r15+48]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,139DB0014A8
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M01_L08
M01_L02:
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [r14+58],0
       jne       near ptr M01_L07
M01_L03:
       mov       edx,[r15+7C]
       add       edx,20
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r15+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [r14+60],0
       jne       near ptr M01_L06
M01_L04:
       mov       rcx,offset MT_System.Xml.XmlWellFormedWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8,r14
       call      qword ptr [7FFE5CDF4000]; System.Xml.XmlWellFormedWriter..ctor(System.Xml.XmlWriter, System.Xml.XmlWriterSettings)
       mov       [rbp-38],rdi
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rdx,rax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFE5CDCE6B8]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,r15
       mov       rdx,[rbp-38]
       mov       r8,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE5CDCE7F0]; System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C75E3F0]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       rdx,[rbp-38]
       mov       rcx,rdx
       mov       eax,[rcx+78]
       cmp       eax,10
       jg        near ptr M01_L10
       mov       rdx,139D70095F0
       mov       rdx,[rdx]
       cmp       eax,11
       jae       short M01_L05
       mov       eax,eax
       mov       edi,[rdx+rax*4+10]
       jmp       short M01_L09
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       edx,[r15+8C]
       mov       rcx,r15
       call      qword ptr [7FFE5CDEB0B8]; System.Xml.XmlEncodedRawTextWriter.WriteXmlDeclaration(System.Xml.XmlStandalone)
       mov       byte ptr [r15+9D],1
       jmp       near ptr M01_L04
M01_L07:
       mov       dword ptr [r15+7C],10000
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,offset MT_System.Text.UnicodeEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE5C9E6580]
       mov       rcx,139DB0014A8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       jmp       near ptr M01_L02
M01_L09:
       cmp       edi,5
       je        short M01_L11
M01_L10:
       call      qword ptr [7FFE5CDEC060]; System.Xml.XmlWellFormedWriter.Close()
       nop
M01_L11:
       mov       byte ptr [rsi+28],0
       mov       rcx,rsi
       call      System.GC._SuppressFinalize(System.Object)
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       call      qword ptr [7FFE5C9E4CF0]
       mov       ecx,11A4
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5C9E4AE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFE5C674030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r14,rax
       jmp       near ptr M01_L01
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+70]
       mov       rdx,[rbp-38]
       mov       rcx,rdx
       cmp       dword ptr [rcx+78],10
       jg        short M01_L17
       mov       rax,139D70095F0
       mov       rax,[rax]
       mov       edx,[rcx+78]
       cmp       edx,11
       jae       short M01_L15
       mov       edi,[rax+rdx*4+10]
       jmp       short M01_L16
M01_L15:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L16:
       cmp       edi,5
       je        short M01_L18
M01_L17:
       call      qword ptr [7FFE5CDEC060]; System.Xml.XmlWellFormedWriter.Close()
M01_L18:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+70]
       mov       rsi,[rbp-30]
       mov       byte ptr [rsi+28],0
       mov       rcx,rsi
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.JsonEqual()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rdx,29A575BE280
       mov       [rsp+28],rdx
       lea       rdx,[rsp+28]
       mov       rcx,29A575BE2C8
       call      qword ptr [7FFE5C925398]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.JsonEqual(System.String, System.String ByRef)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.JsonEqual(System.String, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,108
       lea       rbp,[rsp+140]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0C0],xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-110],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rbx+8],0
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       dword ptr [rbx+8],0
       jne       short M01_L02
       jmp       short M01_L02
M01_L01:
       xor       ecx,ecx
M01_L02:
       test      ecx,ecx
       je        near ptr M01_L09
       cmp       dword ptr [rbx+8],0
       je        short M01_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L03
       mov       ecx,ecx
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L11
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFE5CDBC4B0]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M01_L11
M01_L04:
       mov       ecx,[rbx+8]
       dec       ecx
       cmp       ecx,[rbx+8]
       jae       near ptr M01_L13
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       ecx,ecx
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L11
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE5CDBC4B0]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M01_L11
M01_L06:
       mov       rcx,[rsi]
       test      rcx,rcx
       je        near ptr M01_L12
       mov       edx,[rcx+8]
       mov       [rbp-0B0],rcx
       xor       ecx,ecx
       mov       [rbp-0A8],ecx
       mov       [rbp-0A4],edx
       mov       [rbp-0B8],ecx
       mov       byte ptr [rbp-0B4],0
       mov       byte ptr [rbp-0B3],0
       lea       rcx,[rbp-0B0]
       mov       rdx,[rbp-0B8]
       call      qword ptr [7FFE5CAA4F30]; System.Text.Json.JsonDocument.Parse(System.ReadOnlyMemory`1<Char>, System.Text.Json.JsonDocumentOptions)
       mov       [rbp-0C8],rax
       test      rbx,rbx
       je        short M01_L07
       mov       ecx,[rbx+8]
       mov       rdx,rbx
       mov       [rbp-0B0],rdx
       xor       edx,edx
       mov       [rbp-0A8],edx
       mov       [rbp-0A4],ecx
       lea       rcx,[rbp-0B0]
       mov       rdx,[rbp-0B8]
       call      qword ptr [7FFE5CAA4F30]; System.Text.Json.JsonDocument.Parse(System.ReadOnlyMemory`1<Char>, System.Text.Json.JsonDocumentOptions)
       mov       [rbp-0D0],rax
       mov       rsi,[rbp-0C8]
       cmp       [rsi],sil
       mov       rcx,rsi
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       [rax],al
       mov       rcx,rax
       mov       [rbp-58],rcx
       xor       ecx,ecx
       mov       [rbp-50],ecx
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFE5C925350]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.JsonEqual(System.Text.Json.JsonElement ByRef, System.Text.Json.JsonElement ByRef)
       mov       [rbp-5C],eax
       mov       rcx,rsp
       call      M01_L14
       jmp       short M01_L08
M01_L07:
       mov       ecx,389E
       mov       rdx,7FFE5C966348
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C977138]
       int       3
M01_L08:
       mov       rcx,rsp
       call      M01_L61
       nop
       mov       eax,[rbp-5C]
       add       rsp,108
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      qword ptr [7FFE5C9D4570]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L10
       call      qword ptr [7FFE5C9D42B8]
       mov       r15,rax
M01_L10:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,29A575BE310
       mov       r8,r15
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE5C4C73F0]
       mov       rbx,rax
       jmp       near ptr M01_L06
M01_L12:
       mov       ecx,389E
       mov       rdx,7FFE5C966348
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C977138]
       int       3
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L14:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+140]
       mov       rax,[rbp-0D0]
       test      rax,rax
       je        near ptr M01_L60
       mov       ebx,[rax+2C]
       test      ebx,ebx
       je        near ptr M01_L60
       cmp       byte ptr [rax+18],0
       je        near ptr M01_L60
       lea       rsi,[rax+30]
       xor       ecx,ecx
       mov       rdi,rcx
       xchg      rdi,[rsi]
       test      rdi,rdi
       je        near ptr M01_L36
       mov       rcx,259C5405568
       mov       r14,[rcx]
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,7FFE5C405120
       mov       edx,4B
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M01_L15
       mov       rcx,r14
       call      qword ptr [7FFE5CC2C6F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M01_L15:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [rcx+8],r15d
       jbe       near ptr M01_L30
       mov       r13d,1
       mov       edx,10
       shlx      edx,edx,r15d
       cmp       [rdi+8],edx
       je        short M01_L16
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE5CA0EAC0]
       mov       r15,rax
       mov       ecx,1D3
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      qword ptr [7FFE5C4CF750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L16:
       mov       edx,r15d
       shl       rdx,4
       lea       rax,[rcx+rdx+10]
       mov       [rbp-0E8],rax
       mov       r8,[rax]
       mov       [rbp-0F0],r8
       mov       rcx,rax
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-0E8]
       mov       [rdx+8],ecx
       cmp       qword ptr [rbp-0F0],0
       je        near ptr M01_L30
       mov       rcx,[r14+10]
       cmp       r15d,[rcx+8]
       jae       short M01_L19
       mov       edx,r15d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       jne       short M01_L17
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFE5CC2C678]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       mov       r10,rax
M01_L17:
       mov       r12,[r10+8]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+180],3
       jl        short M01_L18
       mov       rcx,[rcx+188]
       mov       r10,[rcx+18]
       test      r10,r10
       jne       short M01_L20
M01_L18:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       jmp       short M01_L20
M01_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L20:
       mov       r9d,[r10+0A3C]
       lea       ecx,[r9-1]
       mov       [r10+0A3C],ecx
       movzx     ecx,r9w
       test      ecx,ecx
       jne       short M01_L21
       call      qword ptr [7FFE5CDED110]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M01_L22
M01_L21:
       sar       r9d,10
       mov       eax,r9d
M01_L22:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       mov       [rbp-6C],edx
       mov       r8d,[r12+8]
       mov       [rbp-0BC],r8d
       test      r8d,r8d
       jle       near ptr M01_L27
M01_L23:
       cmp       eax,r8d
       jae       short M01_L19
       mov       [rbp-68],eax
       mov       ecx,eax
       mov       r10,[r12+rcx*8+10]
       mov       [rbp-0F8],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-70],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-0F8]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-74],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L25
       test      r10d,r10d
       jne       short M01_L28
       xor       edx,edx
       mov       [rax+14],edx
M01_L24:
       movsxd    rdx,r10d
       mov       r8,[rbp-0F0]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-74]
       inc       ecx
       mov       rax,[rbp-0F8]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-70],1
M01_L25:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-70]
       test      ecx,ecx
       jne       short M01_L29
       mov       eax,[rbp-68]
       inc       eax
       mov       ecx,eax
       mov       r8d,[rbp-0BC]
       cmp       r8d,ecx
       jne       short M01_L26
       xor       ecx,ecx
M01_L26:
       mov       edx,[rbp-6C]
       inc       edx
       cmp       r8d,edx
       mov       [rbp-6C],edx
       mov       eax,ecx
       jg        near ptr M01_L23
M01_L27:
       xor       r12d,r12d
       jmp       short M01_L30
M01_L28:
       jmp       short M01_L24
M01_L29:
       mov       r12d,1
M01_L30:
       mov       rcx,259C54005D0
       mov       r11,[rcx]
       mov       [rbp-0D8],r11
       cmp       byte ptr [r11+9D],0
       je        near ptr M01_L35
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L35
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-60],eax
       mov       edx,[rdi+8]
       mov       [rbp-64],edx
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-0D8]
       mov       r8d,[rbp-60]
       mov       r9d,[rbp-64]
       mov       edx,3
       call      qword ptr [7FFE5C577678]
       test      r12d,r13d
       jne       short M01_L35
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       edi,[rdi+8]
       mov       rax,[rbp-0D8]
       mov       [rbp-0E0],rax
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      r13d,r13d
       jne       short M01_L31
       mov       r14,[rbp-0E0]
       mov       ecx,0FFFFFFFF
       jmp       short M01_L32
M01_L31:
       mov       r14,[rbp-0E0]
       mov       ecx,r15d
M01_L32:
       mov       edx,r12d
       mov       r8d,edi
       mov       r9d,eax
       test      r13d,r13d
       jne       short M01_L33
       mov       eax,1
       jmp       short M01_L34
M01_L33:
       xor       eax,eax
M01_L34:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFE5C7CD098]
M01_L35:
       xor       ecx,ecx
       mov       [rsi+8],ecx
M01_L36:
       xor       ecx,ecx
       mov       rax,[rbp-0D0]
       mov       [rax+20],rcx
       mov       [rax+28],rcx
       cmp       qword ptr [rax+8],0
       je        near ptr M01_L59
       add       rax,8
       xor       ecx,ecx
       mov       r13,rcx
       xchg      r13,[rax]
       test      r13,r13
       je        near ptr M01_L60
       cmp       [r13+8],ebx
       jae       short M01_L37
       call      qword ptr [7FFE5C6BE9D0]
       int       3
M01_L37:
       cmp       [r13],r13b
       lea       rcx,[r13+10]
       mov       edx,ebx
       mov       [rbp-80],rdx
       test      rdx,rdx
       je        short M01_L39
       cmp       rdx,300
       ja        short M01_L38
       xor       edx,edx
       mov       r8d,[rbp-80]
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L39
M01_L38:
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE5C575BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M01_L39:
       mov       rcx,259C5405568
       mov       rbx,[rcx]
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFE5C405120
       mov       edx,4B
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M01_L40
       mov       rcx,rbx
       call      qword ptr [7FFE5CC2C6F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M01_L40:
       xor       esi,esi
       mov       edi,1
       cmp       [rcx+8],r12d
       jbe       near ptr M01_L54
       mov       esi,1
       mov       edx,10
       shlx      edx,edx,r12d
       cmp       [r13+8],edx
       je        short M01_L41
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA0EAC0]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE5C4CF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L41:
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L19
       mov       edx,r12d
       shl       rdx,4
       lea       r14,[rcx+rdx+10]
       mov       r15,[r14]
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],ecx
       test      r15,r15
       je        near ptr M01_L54
       mov       rcx,[rbx+10]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L19
       mov       edx,r12d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M01_L42
       mov       rcx,rbx
       mov       edx,r12d
       call      qword ptr [7FFE5CC2C678]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
M01_L42:
       mov       rdi,[rax+8]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+180],3
       jl        short M01_L43
       mov       rcx,[rcx+188]
       mov       r10,[rcx+18]
       test      r10,r10
       jne       short M01_L44
M01_L43:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
M01_L44:
       mov       r9d,[r10+0A3C]
       lea       ecx,[r9-1]
       mov       [r10+0A3C],ecx
       movzx     ecx,r9w
       test      ecx,ecx
       jne       short M01_L45
       call      qword ptr [7FFE5CDED110]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M01_L46
M01_L45:
       mov       eax,r9d
       sar       eax,10
M01_L46:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       eax,eax
       mov       [rbp-88],eax
       mov       edx,[rdi+8]
       mov       [rbp-0C0],edx
       test      edx,edx
       jle       near ptr M01_L51
M01_L47:
       cmp       r14d,edx
       jae       near ptr M01_L19
       mov       ecx,r14d
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-100],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-8C],r10d
       mov       rcx,r8
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-100]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-90],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L49
       test      r10d,r10d
       jne       short M01_L52
       xor       edx,edx
       mov       [rax+14],edx
M01_L48:
       movsxd    rdx,r10d
       mov       r8,r15
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-90]
       inc       ecx
       mov       rax,[rbp-100]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-8C],1
M01_L49:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-8C]
       test      ecx,ecx
       jne       short M01_L53
       inc       r14d
       mov       ecx,[rbp-0C0]
       cmp       ecx,r14d
       jne       short M01_L50
       xor       r14d,r14d
M01_L50:
       mov       eax,[rbp-88]
       inc       eax
       cmp       ecx,eax
       mov       [rbp-88],eax
       mov       edx,ecx
       jg        near ptr M01_L47
M01_L51:
       xor       edi,edi
       jmp       short M01_L54
M01_L52:
       jmp       short M01_L48
M01_L53:
       mov       edi,1
M01_L54:
       mov       rcx,259C54005D0
       mov       r14,[rcx]
       cmp       byte ptr [r14+9D],0
       je        near ptr M01_L60
       cmp       dword ptr [r13+8],0
       je        near ptr M01_L60
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       eax,[r13+8]
       mov       [rbp-84],eax
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,r15d
       mov       r9d,[rbp-84]
       mov       edx,3
       call      qword ptr [7FFE5C577678]
       test      edi,esi
       jne       short M01_L60
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       r15d,[r13+8]
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      esi,esi
       jne       short M01_L55
       mov       ecx,0FFFFFFFF
       jmp       short M01_L56
M01_L55:
       mov       ecx,r12d
M01_L56:
       mov       edx,edi
       mov       r8d,r15d
       mov       r9d,eax
       test      esi,esi
       jne       short M01_L57
       mov       eax,1
       jmp       short M01_L58
M01_L57:
       xor       eax,eax
M01_L58:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFE5C7CD098]
       jmp       short M01_L60
M01_L59:
       cmp       qword ptr [rax+10],0
       je        short M01_L60
       lea       rcx,[rax+10]
       xor       eax,eax
       xchg      rax,[rcx]
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L60
       call      qword ptr [7FFE5CD0CF70]; Precode of System.Text.Json.PooledByteBufferWriter.Dispose()
M01_L60:
       nop
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
M01_L61:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+140]
       mov       rsi,[rbp-0C8]
       test      rsi,rsi
       je        near ptr M01_L65
       mov       ebx,[rsi+2C]
       test      ebx,ebx
       je        near ptr M01_L65
       cmp       byte ptr [rsi+18],0
       je        near ptr M01_L65
       lea       r13,[rsi+30]
       xor       ecx,ecx
       mov       rdx,rcx
       xchg      rdx,[r13]
       test      rdx,rdx
       je        short M01_L62
       mov       rcx,259C5405568
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE5CC46600]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       xor       ecx,ecx
       mov       [r13+8],ecx
M01_L62:
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       [rsi+28],rcx
       cmp       qword ptr [rsi+8],0
       je        short M01_L64
       add       rsi,8
       xor       ecx,ecx
       mov       r12,rcx
       xchg      r12,[rsi]
       test      r12,r12
       je        short M01_L65
       cmp       [r12+8],ebx
       jae       short M01_L63
       call      qword ptr [7FFE5C6BE9D0]
       int       3
M01_L63:
       cmp       [r12],r12b
       lea       rcx,[r12+10]
       mov       [rbp-0A0],rcx
       mov       [rbp-98],ebx
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFE5C66EB38]; System.Span`1[[System.Byte, System.Private.CoreLib]].Clear()
       mov       rcx,259C5405568
       mov       rcx,[rcx]
       mov       rdx,r12
       xor       r8d,r8d
       call      qword ptr [7FFE5CC46600]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       jmp       short M01_L65
M01_L64:
       cmp       qword ptr [rsi+10],0
       je        short M01_L65
       mov       rsi,[rbp-0C8]
       lea       rcx,[rsi+10]
       xor       eax,eax
       xchg      rax,[rcx]
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L65
       call      qword ptr [7FFE5CD0CF70]; Precode of System.Text.Json.PooledByteBufferWriter.Dispose()
M01_L65:
       nop
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
; Total bytes of code 2824
```

