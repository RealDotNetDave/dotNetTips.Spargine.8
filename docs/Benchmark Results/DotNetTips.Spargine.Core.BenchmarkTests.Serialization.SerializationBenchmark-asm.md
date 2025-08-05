## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+138]
       mov       rcx,24202802438
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L02
       mov       rcx,rdi
       call      qword ptr [7FF9B33257A0]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       cmp       [rbp],bpl
       mov       rcx,2828C7BDA50
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,0F
       je        near ptr M00_L05
       mov       rcx,2828C7BDA50
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,10
       je        near ptr M00_L05
       mov       rcx,2828C7BDA50
       call      System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L05
       mov       rcx,2828C7BDA50
       call      qword ptr [7FF9B2DB60B8]; System.Type.GetRootElementType()
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
       mov       rdx,2828C7BDA50
       movzx     r9d,word ptr [rsp+40]
       mov       r8d,1
       call      qword ptr [7FF9B3324F60]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF9B33268F8]; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF9B3317318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B3326DF0]
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
       call      qword ptr [7FF9B33B7948]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9B2FE6718]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,3C04
       mov       rdx,7FF9B3317318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,2828C7BDA50
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF9B33276C0]
       int       3
M00_L06:
       mov       rcx,2828C7BDA50
       mov       rdx,rdi
       call      qword ptr [7FF9B3327D80]
       int       3
M00_L07:
       mov       rcx,r14
       call      qword ptr [7FF9B3387588]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
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
       call      qword ptr [7FF9B33250B0]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9B3325140]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF9B3325680]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
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
       mov       rcx,24202804960
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
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FF9B32A41B0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
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
       mov       r11,7FF9B2D20DD0
       call      qword ptr [r11]
       jmp       near ptr M03_L02
M03_L09:
       mov       rcx,r14
       call      qword ptr [7FF9B3387588]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M03_L06
M03_L10:
       cmp       byte ptr [rbp+30],0
       je        short M03_L06
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9B33256C8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r14,rax
       jmp       short M03_L06
M03_L11:
       cmp       byte ptr [rbp+29],0
       je        short M03_L07
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FF9B3327D38]
       int       3
M03_L12:
       mov       rcx,rsi
       call      qword ptr [7FF9B3325788]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r15,rax
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF9B2D1D050
       call      qword ptr [7FF9B2E64258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,24202804960
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [r13],r13b
       test      rbx,rbx
       jne       near ptr M03_L01
M03_L14:
       mov       ecx,1
       mov       rdx,7FF9B3290E40
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B34D4AE0]
       int       3
M03_L15:
       mov       ecx,0BB4
       mov       rdx,7FF9B3290E40
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B34D4AE0]
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
       call      qword ptr [7FF9B32A42A0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M03_L03
M03_L17:
       cmp       byte ptr [r8+20],0
       jne       near ptr M03_L04
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FF9B338C480]
       mov       r14,rax
       jmp       near ptr M03_L05
M03_L18:
       call      qword ptr [7FF9B34351E8]
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
       mov       rax,8AF6D918B02D
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
       mov       rdx,241FA801F20
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FF9B35F8088]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF9B338D050]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
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
       call      qword ptr [7FF9B353EC58]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+80],ymm0
       vmovdqu   ymmword ptr [rbp+0A0],ymm0
       vmovdqu   ymmword ptr [rbp+0C0],ymm0
       vmovdqu   ymmword ptr [rbp+0E0],ymm0
       vmovdqu   ymmword ptr [rbp+100],ymm0
       lea       rcx,[rbp+80]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9B353FD08]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>
       cmp       [rbx],rcx
       jne       near ptr M04_L07
       lea       rcx,[rbp+80]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+150]
       mov       r9,[rbx+0B0]
       lea       r8,[rbp+78]
       lea       rdx,[rbp+120]
       cmp       [rcx],ecx
       call      qword ptr [7FF9B3435248]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+78]
       xor       ecx,ecx
       mov       [rbp+78],rcx
       jmp       short M04_L08
M04_L04:
       mov       ecx,347F
       mov       rdx,7FF9B3317318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B3326E50]
       int       3
M04_L05:
       mov       ecx,347F
       mov       rdx,7FF9B3317318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B3326E98]
       int       3
M04_L06:
       call      qword ptr [7FF9B31557E8]
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
       mov       rcx,8AF6D918B02D
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
       call      qword ptr [7FF9B338D038]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FF9B2F15BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M04_L15:
       mov       rcx,241FA801F20
       mov       r14,[rcx]
       mov       rcx,[rbp+28]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,7FF9B2DA5120
       mov       edx,4B
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M04_L16
       mov       rcx,r14
       call      qword ptr [7FF9B35D6910]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       call      qword ptr [7FF9B33BDAD0]
       mov       r13,rax
       mov       ecx,1D3
       mov       rdx,7FF9B2D14000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [7FF9B2E6F750]
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
       call      qword ptr [7FF9B35D6898]
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
       call      qword ptr [7FF9B37BC2D0]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
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
       mov       rax,241FA8005D0
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
       call      qword ptr [7FF9B2F17678]
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
       call      qword ptr [7FF9B315EBF8]
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
       jne       short M05_L05
M05_L03:
       xor       eax,eax
M05_L04:
       ret
M05_L05:
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M05_L04
       test      rdx,rdx
       je        short M05_L03
       mov       rdx,[rdx+10]
       jmp       short M05_L02
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
       call      qword ptr [7FF9B3386FE8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9B3325680]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9B3386DD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.MakeReadOnly()
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+0E8]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-20],0
       jne       short M06_L00
       jmp       short M06_L01
M06_L00:
       mov       rcx,7FF9B39D7768
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9B34351E8]
M06_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9B3386FE8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9B3324F18]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-8],rax
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF9B2E6E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rcx,7FF9B39D776C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9B34351E8]
M06_L04:
       nop
       mov       rcx,7FF9B39D7770
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+115],1
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9B3387228]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
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
       mov       rcx,7FF9B39D777C
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
       call      qword ptr [7FF9B34351B8]
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
       mov       rcx,7FF9B39D7774
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L09:
       mov       rcx,7FF9B39D7778
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

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+130]
       mov       rcx,18D3DC0A400
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,rdi
       call      qword ptr [7FF9B33357A0]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       cmp       [rbp],bpl
       mov       rcx,1CDCFCA4100
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,0F
       je        near ptr M00_L07
       mov       rcx,1CDCFCA4100
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,10
       je        near ptr M00_L07
       mov       rcx,1CDCFCA4100
       call      System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L07
       mov       rcx,1CDCFCA4100
       call      qword ptr [7FF9B2DC60B8]; System.Type.GetRootElementType()
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
       mov       rdx,1CDCFCA4100
       movzx     r9d,word ptr [rsp+40]
       mov       r8d,1
       call      qword ptr [7FF9B3334F60]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF9B33368F8]; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       xor       edx,edx
       cmp       [rax],rcx
       cmove     rdx,[rsp+48]
       mov       [rsp+48],rdx
       jmp       short M00_L02
M00_L04:
       mov       ecx,389E
       mov       rdx,7FF9B3327318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B3336DF0]
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
       call      qword ptr [7FF9B33C7948]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9B2FF6718]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L07:
       mov       ecx,3C04
       mov       rdx,7FF9B3327318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1CDCFCA4100
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF9B33376C0]
       int       3
M00_L08:
       mov       rcx,1CDCFCA4100
       mov       rdx,rdi
       call      qword ptr [7FF9B3337D80]
       int       3
M00_L09:
       mov       rcx,r14
       call      qword ptr [7FF9B3397588]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
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
       call      qword ptr [7FF9B33350B0]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9B3335140]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF9B3335680]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
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
       je        near ptr M03_L10
       mov       r13,[rsi+8]
       test      r13,r13
       je        near ptr M03_L12
M03_L00:
       mov       r12,[r13+8]
       mov       rcx,18D3DC0C928
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M03_L13
       cmp       [r12],r12b
       test      rbx,rbx
       je        near ptr M03_L14
M03_L01:
       test      r15,r15
       je        near ptr M03_L15
       mov       rax,[r12+8]
       mov       [rbp-58],rax
       mov       rcx,[rax+8]
       cmp       byte ptr [r12+15],0
       je        near ptr M03_L08
       mov       rcx,rbx
       mov       rdx,[rbx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
M03_L02:
       mov       [rbp-3C],eax
       lea       rdx,[rbp-48]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-58]
       mov       r8,rbx
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FF9B32B41B0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L16
M03_L03:
       mov       r8,[rbp-48]
       xor       eax,eax
       mov       [rbp-48],rax
       test      r14b,r14b
       jne       near ptr M03_L17
M03_L04:
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M03_L18
       mov       r15,[r8+8]
M03_L05:
       test      dil,dil
       je        short M03_L06
       test      r15,r15
       je        short M03_L06
       cmp       byte ptr [r15+115],2
       jne       short M03_L09
M03_L06:
       test      r15,r15
       je        short M03_L11
M03_L07:
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
M03_L08:
       mov       rdx,rbx
       mov       r11,7FF9B2D30DD0
       call      qword ptr [r11]
       jmp       near ptr M03_L02
M03_L09:
       mov       rcx,r15
       call      qword ptr [7FF9B3397588]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M03_L06
M03_L10:
       cmp       byte ptr [rbp+30],0
       je        short M03_L06
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9B33356C8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r15,rax
       jmp       short M03_L06
M03_L11:
       cmp       byte ptr [rbp+29],0
       je        short M03_L07
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FF9B3337D38]
       int       3
M03_L12:
       mov       rcx,rsi
       call      qword ptr [7FF9B3335788]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r13,rax
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF9B2D2D050
       call      qword ptr [7FF9B2E74258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,18D3DC0C928
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [r12],r12b
       test      rbx,rbx
       jne       near ptr M03_L01
M03_L14:
       mov       ecx,1
       mov       rdx,7FF9B32A0E40
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B34E4AE0]
       int       3
M03_L15:
       mov       ecx,0BB4
       mov       rdx,7FF9B32A0E40
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B34E4AE0]
       int       3
M03_L16:
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
       call      qword ptr [7FF9B32B42A0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M03_L03
M03_L17:
       cmp       byte ptr [r8+20],0
       jne       near ptr M03_L04
       mov       rcx,r13
       mov       rdx,rbx
       call      qword ptr [7FF9B339C480]
       mov       r15,rax
       jmp       near ptr M03_L05
M03_L18:
       call      qword ptr [7FF9B34451E8]
       int       3
; Total bytes of code 644
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
       mov       rax,86D7EF04301
       mov       [rbp+8],rax
       mov       rbx,rdx
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       xor       ecx,ecx
       mov       [rbp+28],rcx
       cmp       edi,55
       jle       near ptr M04_L12
       cmp       edi,15555555
       ja        short M04_L04
       mov       rdx,18D3DC01F20
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FF9B3608088]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+28],rax
M04_L01:
       test      rax,rax
       je        near ptr M04_L13
       lea       r15,[rax+10]
       mov       r14d,[rax+8]
M04_L02:
       mov       rax,r15
M04_L03:
       mov       [rbp+10],rax
       mov       [rbp+64],r14d
       jmp       short M04_L05
M04_L04:
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       lea       rcx,[rbp+50]
       call      qword ptr [7FF9B339D038]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M04_L01
M04_L05:
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       mov       rcx,[rbp+10]
       mov       [rbp+40],rcx
       mov       ecx,[rbp+64]
       mov       [rbp+48],ecx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FF9B339D050]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp+64]
       ja        near ptr M04_L08
       mov       rdx,[rbp+10]
       mov       [rbp+10],rdx
       mov       [rbp+64],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+94]
       movzx     r8d,byte ptr [rcx+92]
       cmp       r8d,2
       jg        near ptr M04_L07
       mov       ecx,[rcx+88]
       test      ecx,ecx
       jl        near ptr M04_L06
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
       call      qword ptr [7FF9B354EC58]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+80],ymm0
       vmovdqu   ymmword ptr [rbp+0A0],ymm0
       vmovdqu   ymmword ptr [rbp+0C0],ymm0
       vmovdqu   ymmword ptr [rbp+0E0],ymm0
       vmovdqu   ymmword ptr [rbp+100],ymm0
       lea       rcx,[rbp+80]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9B354FD08]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rbx],rcx
       jne       near ptr M04_L09
       lea       rcx,[rbp+80]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+150]
       mov       r9,[rbx+0B0]
       lea       r8,[rbp+78]
       lea       rdx,[rbp+120]
       cmp       [rcx],ecx
       call      qword ptr [7FF9B3445248]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+78]
       xor       ecx,ecx
       mov       [rbp+78],rcx
       jmp       short M04_L10
M04_L06:
       mov       ecx,347F
       mov       rdx,7FF9B3327318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B3336E50]
       int       3
M04_L07:
       mov       ecx,347F
       mov       rdx,7FF9B3327318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B3336E98]
       int       3
M04_L08:
       call      qword ptr [7FF9B31657E8]
       int       3
M04_L09:
       lea       r8,[rbp+80]
       lea       rdx,[rbp+120]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
M04_L10:
       mov       [rbp+20],rax
       mov       rcx,[rbp]
       call      M04_L14
       nop
       mov       rax,[rbp+20]
       mov       rcx,86D7EF04301
       cmp       [rbp+8],rcx
       je        short M04_L11
       call      CORINFO_HELP_FAIL_FAST
M04_L11:
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
M04_L12:
       test      [rsp],esp
       sub       rsp,100
       lea       rax,[rsp+30]
       mov       r14d,100
       jmp       near ptr M04_L03
M04_L13:
       xor       r15d,r15d
       xor       r14d,r14d
       jmp       near ptr M04_L02
M04_L14:
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
       je        near ptr M04_L36
       mov       rcx,[rbp+10]
       mov       edx,[rbp+64]
       mov       [rbp+70],rdx
       test      rdx,rdx
       je        short M04_L16
       cmp       rdx,300
       ja        short M04_L15
       xor       edx,edx
       mov       r8d,[rbp+70]
       call      CORINFO_HELP_MEMSET
       jmp       short M04_L16
M04_L15:
       mov       rdx,[rbp+70]
       call      qword ptr [7FF9B2F25BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M04_L16:
       mov       rcx,18D3DC01F20
       mov       r14,[rcx]
       mov       rcx,[rbp+28]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,7FF9B2DB5120
       mov       edx,4B
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M04_L17
       mov       rcx,r14
       call      qword ptr [7FF9B35E6910]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M04_L17:
       xor       r12d,r12d
       mov       ebx,1
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M04_L31
       mov       r12d,1
       mov       rdx,[rbp+28]
       mov       eax,10
       shlx      eax,eax,r13d
       cmp       [rdx+8],eax
       je        short M04_L18
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9B33CDAD0]
       mov       r13,rax
       mov       ecx,1D3
       mov       rdx,7FF9B2D24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [7FF9B2E7F750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M04_L18:
       mov       edx,r13d
       shl       rdx,4
       lea       r15,[rcx+rdx+10]
       mov       rsi,[r15]
       mov       rdx,[rbp+28]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],eax
       test      rsi,rsi
       je        near ptr M04_L31
       mov       rcx,[r14+10]
       cmp       r13d,[rcx+8]
       jae       short M04_L20
       mov       edx,r13d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M04_L19
       mov       rcx,r14
       mov       edx,r13d
       call      qword ptr [7FF9B35E6898]
M04_L19:
       mov       rbx,[rax+8]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       edi,[rax+0A3C]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[rdi-1]
       mov       [rax+0A3C],ecx
       movzx     eax,di
       test      eax,eax
       jne       short M04_L21
       call      qword ptr [7FF9B37CC2D0]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M04_L22
M04_L20:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L21:
       mov       eax,edi
       sar       eax,10
M04_L22:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       edi,eax
       sub       edi,ecx
       xor       r15d,r15d
       jmp       near ptr M04_L29
M04_L23:
       cmp       edi,[rbx+8]
       jae       short M04_L20
       mov       ecx,edi
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
       jbe       short M04_L25
       test      r10d,r10d
       jne       short M04_L26
       xor       edx,edx
       mov       [rax+14],edx
M04_L24:
       movsxd    rdx,r10d
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp+68]
       inc       ecx
       mov       rax,[rbp+18]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+6C],1
M04_L25:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp+6C]
       test      ecx,ecx
       je        short M04_L27
       mov       ecx,1
       jmp       short M04_L30
M04_L26:
       jmp       short M04_L24
M04_L27:
       inc       edi
       cmp       [rbx+8],edi
       jne       short M04_L28
       xor       edi,edi
M04_L28:
       inc       r15d
M04_L29:
       cmp       [rbx+8],r15d
       jg        near ptr M04_L23
       xor       ecx,ecx
M04_L30:
       mov       ebx,ecx
M04_L31:
       mov       rax,18D3DC005D0
       mov       r15,[rax]
       cmp       byte ptr [r15+9D],0
       je        near ptr M04_L36
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+8],0
       je        near ptr M04_L36
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp+28]
       mov       edi,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,esi
       mov       r9d,edi
       mov       edx,3
       call      qword ptr [7FF9B2F27678]
       test      ebx,r12d
       jne       short M04_L36
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,[rbp+28]
       mov       esi,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      r12d,r12d
       jne       short M04_L32
       mov       ecx,0FFFFFFFF
       jmp       short M04_L33
M04_L32:
       mov       ecx,r13d
M04_L33:
       mov       edx,ebx
       mov       r8d,esi
       mov       r9d,eax
       test      r12d,r12d
       jne       short M04_L34
       mov       eax,1
       jmp       short M04_L35
M04_L34:
       xor       eax,eax
M04_L35:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r15
       call      qword ptr [7FF9B316EBF8]
M04_L36:
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
; Total bytes of code 1599
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
       call      qword ptr [7FF9B3396FE8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9B3335680]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9B3396DD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.MakeReadOnly()
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+0E8]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-20],0
       jne       short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rcx,7FF9B39E96C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9B34451E8]
M05_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9B3396FE8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9B3334F18]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-8],rax
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF9B2E7E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rcx,7FF9B39E96C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9B34451E8]
M05_L04:
       nop
       mov       rcx,7FF9B39E96C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+115],1
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9B3397228]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
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
       mov       rcx,7FF9B39E96D4
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
       call      qword ptr [7FF9B34451B8]
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
       mov       rcx,7FF9B39E96CC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
M05_L09:
       mov       rcx,7FF9B39E96D0
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

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_PersonRecord()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+128]
       mov       rcx,7FF9B389FBF8
       call      qword ptr [7FF9B38AC498]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
; 		json = json.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return JsonSerializer.Deserialize<TResult>(json, _options) ??
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				throw new InvalidOperationException($"Failed to deserialize the JSON string to {typeof(TResult)}.");
; 				                                                                                                    
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
       call      qword ptr [7FF9B2E57318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L02:
       mov       r8,11A2740AB90
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FF9B38AC4F8]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M01_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FF9B38864F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rsp+28]
       mov       rdx,15AB944E608
       call      qword ptr [7FF9B30A5F38]
M01_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,7FF9B37B7F00
       call      qword ptr [7FF9B3224138]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M01_L07
M01_L06:
       call      qword ptr [7FF9B31457E8]
       int       3
M01_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M01_L08
       mov       rdx,15AB943076C
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M01_L09
M01_L08:
       lea       rcx,[rsp+28]
       mov       rdx,15AB9430760
       call      qword ptr [7FF9B30A5F38]
M01_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9B30A5D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2FF5F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       call      qword ptr [7FF9B331FA38]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L11
       call      qword ptr [7FF9B331F780]
       mov       rsi,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,15AB944E530
       mov       r8,rsi
       call      qword ptr [7FF9B2FD6718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF9B30A5CF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,15AB944E614
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

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_Person_List()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+138]
       mov       rcx,7FF9B38B01C0
       call      qword ptr [7FF9B38AC498]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
; 		json = json.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return JsonSerializer.Deserialize<TResult>(json, _options) ??
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				throw new InvalidOperationException($"Failed to deserialize the JSON string to {typeof(TResult)}.");
; 				                                                                                                    
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
       call      qword ptr [7FF9B2E57318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L02:
       mov       r8,29785C02BC8
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FF9B38AC4F8]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M01_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FF9B38963B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rsp+28]
       mov       rdx,2D80FB1E6A8
       call      qword ptr [7FF9B30A5F38]
M01_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,7FF9B37C87A8
       call      qword ptr [7FF9B3224138]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M01_L07
M01_L06:
       call      qword ptr [7FF9B31457E8]
       int       3
M01_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M01_L08
       mov       rdx,2D80FB0076C
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M01_L09
M01_L08:
       lea       rcx,[rsp+28]
       mov       rdx,2D80FB00760
       call      qword ptr [7FF9B30A5F38]
M01_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9B30A5D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2FF5F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       call      qword ptr [7FF9B331FA38]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L11
       call      qword ptr [7FF9B331F780]
       mov       rsi,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2D80FB1E530
       mov       r8,rsi
       call      qword ptr [7FF9B2FD6718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF9B30A5CF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,2D80FB1E6B4
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

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+140]
       mov       rcx,1A5D000A400
       mov       rdi,[rcx]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdx,rax
       mov       rcx,1E661EADA50
       cmp       [rcx],ecx
       call      qword ptr [7FF9B2D9A7B0]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FF9B33157A0]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       cmp       [rbp],bpl
       mov       rcx,1E661EADA50
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,0F
       je        near ptr M00_L06
       mov       rcx,1E661EADA50
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,10
       je        near ptr M00_L06
       mov       rcx,1E661EADA50
       call      System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L06
       mov       rcx,1E661EADA50
       call      qword ptr [7FF9B2DA60B8]; System.Type.GetRootElementType()
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
       mov       rdx,1E661EADA50
       movzx     r9d,word ptr [rsp+30]
       mov       r8d,1
       call      qword ptr [7FF9B3314F60]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L07
       cmp       byte ptr [r14+115],2
       jne       near ptr M00_L08
M00_L02:
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF9B3316C40]; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       mov       rcx,1E661EADA50
       mov       rdx,rsi
       call      qword ptr [7FF9B33174B0]
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
       call      qword ptr [7FF9B33A7948]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9B2FD6718]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,3C04
       mov       rdx,7FF9B3307318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1E661EADA50
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF9B33176C0]
       int       3
M00_L07:
       mov       rcx,1E661EADA50
       mov       rdx,rdi
       call      qword ptr [7FF9B3317D80]
       int       3
M00_L08:
       mov       rcx,r14
       call      qword ptr [7FF9B3377588]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
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
       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9B2DA4E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L04
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9B2DA6148]
M01_L04:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        near ptr M01_L01
       mov       rcx,rsi
       call      qword ptr [7FF9B2D9A5A0]
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
       call      qword ptr [7FF9B33150B0]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9B3315140]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF9B3315680]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
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
       mov       rcx,1A5D000C928
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
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FF9B32941B0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
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
       mov       r11,7FF9B2D10D68
       call      qword ptr [r11]
       jmp       near ptr M04_L02
M04_L09:
       mov       rcx,r14
       call      qword ptr [7FF9B3377588]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M04_L06
M04_L10:
       cmp       byte ptr [rbp+30],0
       je        short M04_L06
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9B33156C8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r14,rax
       jmp       short M04_L06
M04_L11:
       cmp       byte ptr [rbp+29],0
       je        short M04_L07
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FF9B3317D38]
       int       3
M04_L12:
       mov       rcx,rsi
       call      qword ptr [7FF9B3315788]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r15,rax
       jmp       near ptr M04_L00
M04_L13:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF9B2D0D050
       call      qword ptr [7FF9B2E54258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1A5D000C928
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [r13],r13b
       test      rbx,rbx
       jne       near ptr M04_L01
M04_L14:
       mov       ecx,1
       mov       rdx,7FF9B3280E40
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B34C4AE0]
       int       3
M04_L15:
       mov       ecx,0BB4
       mov       rdx,7FF9B3280E40
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B34C4AE0]
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
       call      qword ptr [7FF9B32942A0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M04_L03
M04_L17:
       cmp       byte ptr [r8+20],0
       jne       near ptr M04_L04
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FF9B337C480]
       mov       r14,rax
       jmp       near ptr M04_L05
M04_L18:
       call      qword ptr [7FF9B34251E8]
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
       call      qword ptr [7FF9B3315728]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,1A5D0001F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF9B35E8088]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,1E661E91B28
M05_L04:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M05_L18
M05_L05:
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>
       cmp       [rsi],rcx
       jne       short M05_L10
       mov       rcx,rbx
       test      rcx,rcx
       je        short M05_L06
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rcx],rdx
       je        short M05_L06
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF9B2E543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
M05_L06:
       mov       [rbp-50],rbx
       lea       r8,[rbp-50]
       mov       rcx,rsi
       mov       rdx,r14
       mov       r9,rbx
       call      qword ptr [7FF9B3377900]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       ecx,ecx
       mov       [rbp-50],rcx
       jmp       short M05_L11
M05_L07:
       call      qword ptr [7FF9B31457E8]
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
       call      qword ptr [7FF9B337CFF0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF9B36C51E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L17:
       mov       rcx,7FF9B3308E28
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A5D000C958
       mov       rdi,[rcx]
       jmp       near ptr M05_L04
M05_L18:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF9B361E298]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M05_L05
M05_L19:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF9B36C4CF0]
       mov       [rbp-98],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rcx,r13
       lea       r8,[rbp-78]
       call      qword ptr [7FF9B361E418]
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
       call      qword ptr [7FF9B31457E8]
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
       call      qword ptr [7FF9B2F05BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M05_L29:
       xor       ecx,ecx
       mov       [rsi+20],ecx
       mov       rdx,[rsi+10]
       mov       [rsi+10],rcx
       mov       rcx,1A5D0001F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9B35E8090]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       call      qword ptr [7FF9B3376FE8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9B3315680]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9B3376DD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.MakeReadOnly()
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+0E8]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-20],0
       jne       short M06_L00
       jmp       short M06_L01
M06_L00:
       mov       rcx,7FF9B39BCE80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9B34251E8]
M06_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9B3376FE8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9B3314F18]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-8],rax
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF9B2E5E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rcx,7FF9B39BCE84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9B34251E8]
M06_L04:
       nop
       mov       rcx,7FF9B39BCE88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+115],1
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9B3377228]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
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
       mov       rcx,7FF9B39BCE94
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
       call      qword ptr [7FF9B34251B8]
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
       mov       rcx,7FF9B39BCE8C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L09:
       mov       rcx,7FF9B39BCE90
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

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+50]
       mov       rcx,19E1AC0A400
       mov       rdi,[rcx]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdx,rax
       mov       rcx,1DEAC9E4100
       cmp       [rcx],ecx
       call      qword ptr [7FF9B2D9A7B0]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FF9B33157A0]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       cmp       [rbp],bpl
       mov       rcx,1DEAC9E4100
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,0F
       je        near ptr M00_L06
       mov       rcx,1DEAC9E4100
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,10
       je        near ptr M00_L06
       mov       rcx,1DEAC9E4100
       call      System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L06
       mov       rcx,1DEAC9E4100
       call      qword ptr [7FF9B2DA60B8]; System.Type.GetRootElementType()
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
       mov       rdx,1DEAC9E4100
       movzx     r9d,word ptr [rsp+30]
       mov       r8d,1
       call      qword ptr [7FF9B3314F60]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L07
       cmp       byte ptr [r14+115],2
       jne       near ptr M00_L08
M00_L02:
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF9B3316C40]; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       mov       rcx,1DEAC9E4100
       mov       rdx,rsi
       call      qword ptr [7FF9B33174B0]
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
       call      qword ptr [7FF9B33A7948]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9B2FD6718]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,3C04
       mov       rdx,7FF9B3307318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1DEAC9E4100
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF9B33176C0]
       int       3
M00_L07:
       mov       rcx,1DEAC9E4100
       mov       rdx,rdi
       call      qword ptr [7FF9B3317D80]
       int       3
M00_L08:
       mov       rcx,r14
       call      qword ptr [7FF9B3377588]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
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
       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9B2DA4E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L04
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9B2DA6148]
M01_L04:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        near ptr M01_L01
       mov       rcx,rsi
       call      qword ptr [7FF9B2D9A5A0]
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
       call      qword ptr [7FF9B33150B0]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9B3315140]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF9B3315680]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
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
       mov       rcx,19E1AC0C928
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
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FF9B32941B0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
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
       mov       r11,7FF9B2D10D68
       call      qword ptr [r11]
       jmp       near ptr M04_L02
M04_L09:
       mov       rcx,r14
       call      qword ptr [7FF9B3377588]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M04_L06
M04_L10:
       cmp       byte ptr [rbp+30],0
       je        short M04_L06
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9B33156C8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r14,rax
       jmp       short M04_L06
M04_L11:
       cmp       byte ptr [rbp+29],0
       je        short M04_L07
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FF9B3317D38]
       int       3
M04_L12:
       mov       rcx,rsi
       call      qword ptr [7FF9B3315788]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r15,rax
       jmp       near ptr M04_L00
M04_L13:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF9B2D0D050
       call      qword ptr [7FF9B2E54258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,19E1AC0C928
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [r13],r13b
       test      rbx,rbx
       jne       near ptr M04_L01
M04_L14:
       mov       ecx,1
       mov       rdx,7FF9B3280E40
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B34C4AE0]
       int       3
M04_L15:
       mov       ecx,0BB4
       mov       rdx,7FF9B3280E40
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9B34C4AE0]
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
       call      qword ptr [7FF9B32942A0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M04_L03
M04_L17:
       cmp       byte ptr [r8+20],0
       jne       near ptr M04_L04
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FF9B337C480]
       mov       r14,rax
       jmp       near ptr M04_L05
M04_L18:
       call      qword ptr [7FF9B34251E8]
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
       call      qword ptr [7FF9B3315728]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,19E1AC01F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF9B35E8088]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,1DEAC9D1B28
M05_L04:
       mov       r8d,[rdi+8]
       mov       [r14+30],r8d
       cmp       dword ptr [r14+70],0
       je        near ptr M05_L19
M05_L05:
       mov       [rbp-90],r14
       mov       r8,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rsi],r8
       jne       short M05_L11
       mov       rcx,rsi
       mov       r8,rbx
       test      r8,r8
       je        short M05_L06
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [r8],rax
       jne       short M05_L09
M05_L06:
       mov       [rbp-50],rbx
       lea       r8,[rbp-50]
       mov       rdx,r14
       mov       r9,rbx
       call      qword ptr [7FF9B3377900]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       ecx,ecx
       mov       [rbp-50],rcx
       jmp       short M05_L12
M05_L07:
       call      qword ptr [7FF9B31457E8]
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
       call      qword ptr [7FF9B2E543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       call      qword ptr [7FF9B337CFF0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF9B36C51E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L18:
       mov       rcx,7FF9B3308E28
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19E1AC0C958
       mov       rdi,[rcx]
       jmp       near ptr M05_L04
M05_L19:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF9B361E298]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M05_L05
M05_L20:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF9B36C4CF0]
       mov       [rbp-98],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rcx,r12
       lea       r8,[rbp-78]
       call      qword ptr [7FF9B361E418]
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
       call      qword ptr [7FF9B31457E8]
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
       call      qword ptr [7FF9B2F05BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M05_L30:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,19E1AC01F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9B35E8090]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       call      qword ptr [7FF9B3376FE8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9B3315680]; System.Text.Json.JsonSerializerOptions.MakeReadOnly()
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9B3376DD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.MakeReadOnly()
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+0E8]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-20],0
       jne       short M06_L00
       jmp       short M06_L01
M06_L00:
       mov       rcx,7FF9B39AB0C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9B34251E8]
M06_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9B3376FE8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9B3314F18]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-8],rax
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF9B2E5E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rcx,7FF9B39AB0C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9B34251E8]
M06_L04:
       nop
       mov       rcx,7FF9B39AB0C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+115],1
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9B3377228]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
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
       mov       rcx,7FF9B39AB0D4
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
       call      qword ptr [7FF9B34251B8]
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
       mov       rcx,7FF9B39AB0CC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L09:
       mov       rcx,7FF9B39AB0D0
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

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Ref_Person()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rax,[rbx+50]
       test      rax,rax
       je        near ptr M00_L03
       mov       [rsp+30],rax
       call      qword ptr [7FF9B3345080]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9B33456B0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9B3344FC0]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,7FF9B36DC8F0
       call      qword ptr [7FF9B364D560]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r8],rcx
       je        short M00_L01
       mov       rdx,rax
       call      qword ptr [7FF9B2E843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FF9B334F990]
       mov       ecx,1945
       mov       rdx,7FF9B319BC10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9B319BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF9B319BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9B334F780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9B3006718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 312
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,2210400C918
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,2210400C918
       xor       edx,edx
       jmp       qword ptr [7FF9B3345758]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
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
       call      qword ptr [7FF9B33463E8]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M02_L05
       call      qword ptr [7FF9B33AC318]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FF9B2E84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9B3345DE8]
       test      eax,eax
       je        near ptr M02_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,7FF9B339EB10
       xor       r8d,r8d
       call      qword ptr [7FF9B33AC528]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,7FF9B339EB10
       mov       r8d,1
       call      qword ptr [7FF9B33AC528]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,7FF9B339EC18
       mov       r9d,2
       call      qword ptr [7FF9B33AC558]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9B33AC5A0]
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
       call      qword ptr [7FF9B33AC3C0]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M02_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9B33AC3C0]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M02_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9B33AC3C0]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9B33456B0]
       jmp       short M02_L09
M02_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9B33AC438]
       jmp       short M02_L09
M02_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M02_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FF9B2E84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9B3347750]
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
       mov       rdx,22083062008
       mov       r8d,1
       call      qword ptr [7FF9B3344F60]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF9B3345728]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,22104001F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF9B36180C0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,22083061B28
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
       call      qword ptr [7FF9B33A7900]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       mov       ecx,r15d
       mov       eax,r12d
       cmp       rcx,rax
       ja        short M04_L07
       mov       r12d,r15d
       jmp       short M04_L10
M04_L07:
       call      qword ptr [7FF9B31757E8]
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
       call      qword ptr [7FF9B33ACFF0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF9B36F51E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L00
M04_L13:
       mov       rcx,7FF9B3338E28
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2210400C958
       mov       rdi,[rcx]
       jmp       near ptr M04_L03
M04_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF9B364E298]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M04_L04
M04_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF9B36F4CF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FF9B364E418]
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
       call      qword ptr [7FF9B31757E8]
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
       call      qword ptr [7FF9B2F35BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M04_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,22104001F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9B36180C8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
; Total bytes of code 1184
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
       jmp       qword ptr [7FF9B2E843A8]
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
       call      00007FF9B2E81E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9B2F35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9B2F35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9B3175D58]
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
       mov       rax,22083060008
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

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_PersonRecord()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rax,[rbx+48]
       test      rax,rax
       je        near ptr M00_L03
       mov       [rsp+30],rax
       call      qword ptr [7FF9B3335080]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9B33356B0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9B3334FC0]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,7FF9B36CCC88
       call      qword ptr [7FF9B363D560]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r8],rcx
       je        short M00_L01
       mov       rdx,rax
       call      qword ptr [7FF9B2E743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FF9B333F990]
       mov       ecx,1945
       mov       rdx,7FF9B318BC10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9B318BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF9B318BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9B333F780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9B2FF6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 312
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,1A64CC04950
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,1A64CC04950
       xor       edx,edx
       jmp       qword ptr [7FF9B3335758]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
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
       call      qword ptr [7FF9B33363E8]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M02_L05
       call      qword ptr [7FF9B339C318]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FF9B2E74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9B3335DE8]
       test      eax,eax
       je        near ptr M02_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,7FF9B338EB10
       xor       r8d,r8d
       call      qword ptr [7FF9B339C528]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,7FF9B338EB10
       mov       r8d,1
       call      qword ptr [7FF9B339C528]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,7FF9B338EC18
       mov       r9d,2
       call      qword ptr [7FF9B339C558]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9B339C5A0]
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
       call      qword ptr [7FF9B339C3C0]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M02_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9B339C3C0]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M02_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9B339C3C0]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9B33356B0]
       jmp       short M02_L09
M02_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9B339C438]
       jmp       short M02_L09
M02_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M02_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FF9B2E74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9B3337750]
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
       mov       rdx,1E6D69E2008
       mov       r8d,1
       call      qword ptr [7FF9B3334F60]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF9B3335728]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,1A644C01F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF9B3608088]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,1E6D69E1B28
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
       call      qword ptr [7FF9B3397900]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FF9B31657E8]
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
       call      qword ptr [7FF9B339CFF0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF9B36E51E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L00
M04_L13:
       mov       rcx,7FF9B3328E28
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A64CC04990
       mov       rdi,[rcx]
       jmp       near ptr M04_L03
M04_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF9B363E298]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M04_L04
M04_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF9B36E4CF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FF9B363E418]
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
       call      qword ptr [7FF9B31657E8]
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
       call      qword ptr [7FF9B2F25BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M04_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,1A644C01F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9B3608090]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       jmp       qword ptr [7FF9B2E743A8]
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
       call      00007FF9B2E71E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9B3165D58]
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
       mov       rax,1E6D69E0008
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

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Person_List()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       call      qword ptr [7FF9B32C4CD8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
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
; 		obj = obj.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return JsonSerializer.Serialize(obj);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       test      rcx,rcx
       je        short M01_L02
       mov       [rsp+20],rcx
       call      qword ptr [7FF9B3315080]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rbx,rax
       cmp       byte ptr [rbx+9E],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FF9B33156B0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FF9B3314FC0]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r8],rcx
       jne       near ptr M01_L03
M01_L01:
       lea       rdx,[rsp+20]
       mov       rcx,7FF9B36ACC88
       call      qword ptr [7FF9B361D560]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       call      qword ptr [7FF9B331F990]
       mov       ecx,1945
       mov       rdx,7FF9B316BC10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9B316BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF9B316BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9B331F780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9B2FD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rdx,rax
       call      qword ptr [7FF9B2E543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 271
```

