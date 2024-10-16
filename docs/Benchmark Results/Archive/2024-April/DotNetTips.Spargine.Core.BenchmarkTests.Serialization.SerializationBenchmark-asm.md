## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_JsonSerializer_Generator_Person_List()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+128]
       mov       rcx,21CA4C03508
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L03
       mov       rcx,rdi
       call      qword ptr [7FFE94CF7EB8]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       cmp       [rbp],bpl
       mov       rcx,25D36A8C560
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,0F
       je        near ptr M00_L06
       mov       rcx,25D36A8C560
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,10
       je        near ptr M00_L06
       mov       rcx,25D36A8C560
       call      System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L06
       mov       rcx,25D36A8C560
       call      qword ptr [7FFE946960B8]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L04
       test      rcx,rcx
       je        near ptr M00_L05
M00_L00:
       call      System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L06
       mov       rcx,rbp
       mov       byte ptr [rsp+48],0
       mov       byte ptr [rsp+49],0
       mov       dword ptr [rsp+20],1
       xor       edx,edx
       mov       [rsp+28],edx
       mov       rdx,25D36A8C560
       movzx     r9d,word ptr [rsp+48]
       mov       r8d,1
       call      qword ptr [7FFE94BE4048]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L07
       cmp       byte ptr [rbp+105],2
       jne       short M00_L02
M00_L01:
       mov       rdx,rbp
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       mov       [rsp+38],rcx
       mov       [rsp+40],eax
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE94BED320]; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFE94744360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rsp+50],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       call      qword ptr [7FFE94C94AE0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M00_L01
M00_L03:
       mov       ecx,3174
       mov       rdx,7FFE94BC1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94CFC300]
       int       3
M00_L04:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L00
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94C1EAD8]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE94926670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,352A
       mov       rdx,7FFE94BC1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,25D36A8C560
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE94CFCB58]
       int       3
M00_L07:
       mov       rcx,25D36A8C560
       mov       rdx,rdi
       call      qword ptr [7FFE94CFD1E8]
       int       3
; Total bytes of code 550
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
       call      qword ptr [7FFE94BE4180]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE94BE4210]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE94BE4630]
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
       cmp       byte ptr [rsi+8C],0
       je        near ptr M03_L12
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M03_L10
M03_L00:
       mov       r14,[r15+8]
       mov       rcx,21CA4C051E0
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M03_L14
M03_L01:
       cmp       [r14],r14b
       test      rbx,rbx
       je        near ptr M03_L17
       test      r13,r13
       je        near ptr M03_L11
       mov       r12,[r14+8]
       mov       rcx,[r12+8]
       cmp       byte ptr [r14+15],0
       je        near ptr M03_L08
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
M03_L02:
       mov       [rbp-3C],eax
       lea       rdx,[rbp-48]
       mov       [rsp+20],rdx
       mov       rdx,r12
       mov       r8,rbx
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      qword ptr [7FFE94AFF948]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M03_L03
       mov       edx,[rbp-3C]
       mov       byte ptr [rbp-50],1
       mov       [rbp-4C],edx
       mov       rdx,rbx
       mov       r8,r15
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-48]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,r12
       mov       r8,rbx
       mov       r9,[rbp-50]
       mov       rcx,r14
       call      qword ptr [7FFE94AFFA38]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M03_L03:
       mov       r8,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       byte ptr [rbp+38],0
       jne       near ptr M03_L15
M03_L04:
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M03_L16
       mov       r14,[r8+8]
M03_L05:
       test      dil,dil
       je        short M03_L06
       test      r14,r14
       je        short M03_L06
       cmp       byte ptr [r14+105],2
       jne       short M03_L09
M03_L06:
       test      r14,r14
       je        near ptr M03_L13
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
       mov       r11,7FFE94600BD8
       call      qword ptr [r11]
       jmp       near ptr M03_L02
M03_L09:
       mov       rcx,r14
       call      qword ptr [7FFE94C94AE0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M03_L06
M03_L10:
       mov       rcx,rsi
       call      qword ptr [7FFE94C94B10]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r15,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L11:
       mov       ecx,0BB4
       mov       rdx,7FFE94B1B2D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94CF7D08]
       int       3
M03_L12:
       cmp       byte ptr [rbp+30],0
       je        short M03_L06
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE94BE4678]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r14,rax
       jmp       near ptr M03_L06
M03_L13:
       movzx     edx,byte ptr [rbp+28]
       movzx     ecx,byte ptr [rbp+29]
       cmp       cl,1
       sete      cl
       movzx     ecx,cl
       test      edx,ecx
       je        near ptr M03_L07
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FFE94CFD1A0]
       int       3
M03_L14:
       mov       rcx,offset MT_System.Func`3[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFE945FD0E0
       call      qword ptr [7FFE94744258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,21CA4C051E0
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L01
M03_L15:
       cmp       byte ptr [r8+20],0
       jne       near ptr M03_L04
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFE94C94C30]
       mov       r14,rax
       jmp       near ptr M03_L05
M03_L16:
       call      qword ptr [7FFE9515D3B0]
       int       3
M03_L17:
       mov       ecx,1
       mov       rdx,7FFE94B1B2D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94CF7D08]
       int       3
; Total bytes of code 646
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
       sub       rsp,238
       vzeroupper
       lea       rbp,[rsp+270]
       xor       eax,eax
       mov       [rbp-228],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M04_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp-40],rax
       mov       [rbp-240],rsp
       mov       rbx,rdx
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       xor       ecx,ecx
       mov       [rbp-220],rcx
       cmp       edi,55555
       ja        short M04_L03
       mov       rdx,21CA8C01E48
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFE94C43578]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-220],rax
M04_L01:
       test      rax,rax
       je        near ptr M04_L10
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M04_L02:
       mov       [rbp-238],r14
       mov       [rbp-1E4],r15d
       jmp       short M04_L04
M04_L03:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       lea       rcx,[rbp-1F8]
       call      qword ptr [7FFE94C143C0]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M04_L01
M04_L04:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       mov       rcx,[rbp-238]
       mov       [rbp-208],rcx
       mov       ecx,[rbp-1E4]
       mov       [rbp-200],ecx
       lea       rcx,[rbp-1F8]
       lea       rdx,[rbp-208]
       call      qword ptr [7FFE94C143D8]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp-1E4]
       ja        near ptr M04_L07
       mov       rdx,[rbp-238]
       mov       [rbp-238],rdx
       mov       [rbp-1E4],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+85]
       movzx     r8d,byte ptr [rcx+84]
       cmp       r8d,2
       jg        near ptr M04_L06
       mov       ecx,[rcx+7C]
       test      ecx,ecx
       jl        near ptr M04_L05
       xor       r10d,r10d
       mov       [rbp-70],r10
       mov       [rbp-68],r10
       mov       byte ptr [rbp-60],0
       mov       byte ptr [rbp-5F],0
       mov       byte ptr [rbp-5E],0
       mov       byte ptr [rbp-5D],0
       mov       byte ptr [rbp-5C],0
       mov       byte ptr [rbp-5B],0
       mov       [rbp-58],ecx
       mov       [rbp-54],r8b
       mov       [rbp-53],r9b
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       [rbp-218],rdx
       mov       [rbp-210],eax
       lea       rdx,[rbp-218]
       lea       rcx,[rbp-130]
       lea       r9,[rbp-70]
       mov       r8d,1
       call      qword ptr [7FFE94D66328]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1D0],ymm0
       vmovdqu   ymmword ptr [rbp-1B0],ymm0
       vmovdqu   ymmword ptr [rbp-190],ymm0
       vmovdqu   ymmword ptr [rbp-170],ymm0
       vmovdqu   ymmword ptr [rbp-150],ymm0
       lea       rcx,[rbp-1D0]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE94D673F0]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       cmp       [rbx],rcx
       jne       short M04_L08
       mov       rcx,[rbx+138]
       mov       r8,[rbx+0B0]
       lea       rdx,[rbp-130]
       lea       r9,[rbp-1D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE94C5E838]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       jmp       short M04_L09
M04_L05:
       mov       ecx,318C
       mov       rdx,7FFE94BC1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94CFC318]
       int       3
M04_L06:
       mov       ecx,318C
       mov       rdx,7FFE94BC1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94CFC348]
       int       3
M04_L07:
       call      qword ptr [7FFE948FE9A0]
       int       3
M04_L08:
       lea       r8,[rbp-1D0]
       lea       rdx,[rbp-130]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
M04_L09:
       mov       [rbp-228],rax
       mov       rcx,rsp
       call      M04_L11
       nop
       mov       rax,[rbp-228]
       add       rsp,238
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
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M04_L02
M04_L11:
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
       lea       rbp,[rbp+270]
       cmp       qword ptr [rbp-220],0
       je        near ptr M04_L33
       mov       rcx,[rbp-238]
       mov       edx,[rbp-1E4]
       mov       [rbp-1D8],rdx
       test      rdx,rdx
       je        short M04_L13
       cmp       rdx,300
       ja        short M04_L12
       xor       edx,edx
       mov       r8d,[rbp-1D8]
       call      CORINFO_HELP_MEMSET
       jmp       short M04_L13
M04_L12:
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FFE947F5BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M04_L13:
       mov       rcx,21CA8C01E48
       mov       r13,[rcx]
       mov       rcx,[rbp-220]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFE94685120
       mov       edx,30
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M04_L14
       mov       rcx,r13
       call      qword ptr [7FFE94C55980]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M04_L14:
       xor       ebx,ebx
       mov       esi,1
       mov       edx,[rcx+8]
       cmp       edx,r12d
       jbe       near ptr M04_L28
       mov       ebx,1
       mov       rdx,[rbp-220]
       mov       eax,10
       shlx      eax,eax,r12d
       cmp       [rdx+8],eax
       je        short M04_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFE94C352D8]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE945F4000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r13
       call      qword ptr [7FFE9474F750]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M04_L15:
       mov       edx,r12d
       shl       rdx,4
       lea       r14,[rcx+rdx+10]
       mov       rdi,[r14]
       mov       rdx,[rbp-220]
       mov       rcx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],eax
       test      rdi,rdi
       je        near ptr M04_L28
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       short M04_L17
       mov       edx,r12d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M04_L16
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FFE94C55908]
M04_L16:
       mov       rsi,[rax+8]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14d,[rax+0A3C]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[r14-1]
       mov       [rax+0A3C],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M04_L18
       call      qword ptr [7FFE94EBDD10]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M04_L19
M04_L17:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L18:
       mov       eax,r14d
       sar       eax,10
M04_L19:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       r15d,r15d
       jmp       near ptr M04_L26
M04_L20:
       cmp       r14d,[rsi+8]
       jae       short M04_L17
       mov       ecx,r14d
       mov       rax,[rsi+rcx*8+10]
       mov       [rbp-230],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-1DC],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-230]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-1E0],r10d
       cmp       [rcx+8],r10d
       jbe       short M04_L22
       test      r10d,r10d
       jne       short M04_L23
       xor       edx,edx
       mov       [rax+14],edx
M04_L21:
       movsxd    rdx,r10d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-1E0]
       inc       ecx
       mov       rax,[rbp-230]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-1DC],1
M04_L22:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-1DC]
       test      ecx,ecx
       je        short M04_L24
       mov       ecx,1
       jmp       short M04_L27
M04_L23:
       jmp       short M04_L21
M04_L24:
       inc       r14d
       cmp       [rsi+8],r14d
       jne       short M04_L25
       xor       r14d,r14d
M04_L25:
       inc       r15d
M04_L26:
       cmp       [rsi+8],r15d
       jg        near ptr M04_L20
       xor       ecx,ecx
M04_L27:
       mov       esi,ecx
M04_L28:
       mov       rax,21CA8C005D0
       mov       r14,[rax]
       cmp       byte ptr [r14+9D],0
       je        near ptr M04_L33
       mov       rcx,[rbp-220]
       cmp       dword ptr [rcx+8],0
       je        near ptr M04_L33
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,[rbp-220]
       mov       r15d,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,edi
       mov       r9d,r15d
       mov       edx,3
       call      qword ptr [7FFE947F7678]
       test      esi,ebx
       jne       short M04_L33
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp-220]
       mov       edi,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      ebx,ebx
       jne       short M04_L29
       mov       ecx,0FFFFFFFF
       jmp       short M04_L30
M04_L29:
       mov       ecx,r12d
M04_L30:
       mov       edx,esi
       mov       r8d,edi
       mov       r9d,eax
       test      ebx,ebx
       jne       short M04_L31
       mov       eax,1
       jmp       short M04_L32
M04_L31:
       xor       eax,eax
M04_L32:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFE94A1F360]
M04_L33:
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
; Total bytes of code 1595
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B0]
       cmp       qword ptr [rax+20],0
       je        near ptr M06_L06
       mov       byte ptr [rax+8C],1
       mov       byte ptr [rcx+100],1
       mov       rbx,[rcx+0D8]
       test      rbx,rbx
       jne       near ptr M06_L07
       mov       rbx,[rcx+0B0]
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M06_L05
M06_L00:
       mov       [rbp-20],rax
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M06_L02
       lea       rdx,[rbp-18]
       mov       rcx,rax
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+105],0
       jne       short M06_L03
       mov       rbx,[rcx+0D8]
       test      rbx,rbx
       jne       short M06_L01
       mov       rcx,7FFE951788A0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+105],1
       call      qword ptr [7FFE94C947C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+105],2
       jmp       short M06_L03
M06_L01:
       mov       rcx,7FFE9517889C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE9515D3B0]
       int       3
M06_L02:
       call      qword ptr [7FFE9474E040]
       int       3
M06_L03:
       cmp       byte ptr [rbp-18],0
       je        short M06_L04
       mov       rcx,7FFE951788A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L04:
       mov       rcx,7FFE951788A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE951788AC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE94C94B10]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rax,rcx
       jmp       near ptr M06_L00
M06_L06:
       call      qword ptr [7FFE94CFCBD0]
       int       3
M06_L07:
       mov       rcx,7FFE95178898
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE9515D3B0]
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,rdx
       call      qword ptr [7FFE9515D380]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0D8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+105],0
       call      CORINFO_HELP_RETHROW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M06_L08
       mov       rcx,7FFE951788A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L08:
       mov       rcx,7FFE951788A8
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 492
```
**Extern method**
System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_JsonSerializer_Generator_Person()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+120]
       mov       rcx,1C127805500
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rcx,rdi
       call      qword ptr [7FFE94D17EB8]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       cmp       [rbp],bpl
       mov       rcx,201B96C2928
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,0F
       je        near ptr M00_L08
       mov       rcx,201B96C2928
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,10
       je        near ptr M00_L08
       mov       rcx,201B96C2928
       call      System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L08
       mov       rcx,201B96C2928
       call      qword ptr [7FFE946B60B8]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L06
       test      rcx,rcx
       je        near ptr M00_L07
M00_L00:
       call      System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L08
       mov       rcx,rbp
       mov       byte ptr [rsp+48],0
       mov       byte ptr [rsp+49],0
       mov       dword ptr [rsp+20],1
       xor       edx,edx
       mov       [rsp+28],edx
       mov       rdx,201B96C2928
       movzx     r9d,word ptr [rsp+48]
       mov       r8d,1
       call      qword ptr [7FFE94C04048]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L09
       cmp       byte ptr [rbp+105],2
       jne       short M00_L04
M00_L01:
       mov       rdx,rbp
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       mov       [rsp+38],rcx
       mov       [rsp+40],eax
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE94C0D320]; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       [rsp+50],rax
       test      rax,rax
       jne       short M00_L03
M00_L02:
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       xor       edx,edx
       cmp       [rax],rcx
       cmove     rdx,[rsp+50]
       mov       [rsp+50],rdx
       jmp       short M00_L02
M00_L04:
       mov       rcx,rbp
       call      qword ptr [7FFE94CB4AE0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M00_L01
M00_L05:
       mov       ecx,3174
       mov       rdx,7FFE94BE1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D1C300]
       int       3
M00_L06:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L00
M00_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94C3EAD8]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE94946670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L08:
       mov       ecx,352A
       mov       rdx,7FFE94BE1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,201B96C2928
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE94D1CB58]
       int       3
M00_L09:
       mov       rcx,201B96C2928
       mov       rdx,rdi
       call      qword ptr [7FFE94D1D1E8]
       int       3
; Total bytes of code 564
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
       call      qword ptr [7FFE94C04180]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE94C04210]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE94C04630]
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
       cmp       byte ptr [rsi+8C],0
       je        near ptr M03_L12
       mov       r13,[rsi+8]
       test      r13,r13
       je        near ptr M03_L10
M03_L00:
       mov       r15,[r13+8]
       mov       rcx,1C12B801208
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M03_L14
M03_L01:
       cmp       [r15],r15b
       test      rbx,rbx
       je        near ptr M03_L17
       test      r12,r12
       je        near ptr M03_L11
       mov       rax,[r15+8]
       mov       [rbp-58],rax
       mov       rcx,[rax+8]
       cmp       byte ptr [r15+15],0
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
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      qword ptr [7FFE94B1F948]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M03_L03
       mov       edx,[rbp-3C]
       mov       rax,[rbp-58]
       mov       [rbp-60],rax
       mov       byte ptr [rbp-50],1
       mov       [rbp-4C],edx
       mov       rdx,rbx
       mov       r8,r13
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-48]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,[rbp-60]
       mov       r8,rbx
       mov       r9,[rbp-50]
       mov       rcx,r15
       call      qword ptr [7FFE94B1FA38]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M03_L03:
       mov       r8,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r14b,r14b
       jne       near ptr M03_L15
M03_L04:
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M03_L16
       mov       r15,[r8+8]
M03_L05:
       test      dil,dil
       je        short M03_L06
       test      r15,r15
       je        short M03_L06
       cmp       byte ptr [r15+105],2
       jne       short M03_L09
M03_L06:
       test      r15,r15
       je        near ptr M03_L13
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
       mov       r11,7FFE94620BD8
       call      qword ptr [r11]
       jmp       near ptr M03_L02
M03_L09:
       mov       rcx,r15
       call      qword ptr [7FFE94CB4AE0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M03_L06
M03_L10:
       mov       rcx,rsi
       call      qword ptr [7FFE94CB4B10]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r13,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L11:
       mov       ecx,0BB4
       mov       rdx,7FFE94B3B2D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D17D08]
       int       3
M03_L12:
       cmp       byte ptr [rbp+30],0
       je        short M03_L06
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE94C04678]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r15,rax
       jmp       near ptr M03_L06
M03_L13:
       movzx     edx,byte ptr [rbp+28]
       movzx     ecx,byte ptr [rbp+29]
       cmp       cl,1
       sete      cl
       movzx     ecx,cl
       test      edx,ecx
       je        near ptr M03_L07
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FFE94D1D1A0]
       int       3
M03_L14:
       mov       rcx,offset MT_System.Func`3[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFE9461D0E0
       call      qword ptr [7FFE94764258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1C12B801208
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L01
M03_L15:
       cmp       byte ptr [r8+20],0
       jne       near ptr M03_L04
       mov       rcx,r13
       mov       rdx,rbx
       call      qword ptr [7FFE94CB4C30]
       mov       r15,rax
       jmp       near ptr M03_L05
M03_L16:
       call      qword ptr [7FFE9518C4E0]
       int       3
M03_L17:
       mov       ecx,1
       mov       rdx,7FFE94B3B2D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D17D08]
       int       3
; Total bytes of code 664
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
       sub       rsp,238
       vzeroupper
       lea       rbp,[rsp+270]
       xor       eax,eax
       mov       [rbp-228],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M04_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp-40],rax
       mov       [rbp-240],rsp
       mov       rbx,rdx
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       xor       ecx,ecx
       mov       [rbp-220],rcx
       cmp       edi,55555
       ja        short M04_L03
       mov       rdx,1C127801E48
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFE94C63578]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-220],rax
M04_L01:
       test      rax,rax
       je        near ptr M04_L10
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M04_L02:
       mov       [rbp-238],r14
       mov       [rbp-1E4],r15d
       jmp       short M04_L04
M04_L03:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       lea       rcx,[rbp-1F8]
       call      qword ptr [7FFE94C343C0]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M04_L01
M04_L04:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       mov       rcx,[rbp-238]
       mov       [rbp-208],rcx
       mov       ecx,[rbp-1E4]
       mov       [rbp-200],ecx
       lea       rcx,[rbp-1F8]
       lea       rdx,[rbp-208]
       call      qword ptr [7FFE94C343D8]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp-1E4]
       ja        near ptr M04_L07
       mov       rdx,[rbp-238]
       mov       [rbp-238],rdx
       mov       [rbp-1E4],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+85]
       movzx     r8d,byte ptr [rcx+84]
       cmp       r8d,2
       jg        near ptr M04_L06
       mov       ecx,[rcx+7C]
       test      ecx,ecx
       jl        near ptr M04_L05
       xor       r10d,r10d
       mov       [rbp-70],r10
       mov       [rbp-68],r10
       mov       byte ptr [rbp-60],0
       mov       byte ptr [rbp-5F],0
       mov       byte ptr [rbp-5E],0
       mov       byte ptr [rbp-5D],0
       mov       byte ptr [rbp-5C],0
       mov       byte ptr [rbp-5B],0
       mov       [rbp-58],ecx
       mov       [rbp-54],r8b
       mov       [rbp-53],r9b
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       [rbp-218],rdx
       mov       [rbp-210],eax
       lea       rdx,[rbp-218]
       lea       rcx,[rbp-130]
       lea       r9,[rbp-70]
       mov       r8d,1
       call      qword ptr [7FFE94D86328]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1D0],ymm0
       vmovdqu   ymmword ptr [rbp-1B0],ymm0
       vmovdqu   ymmword ptr [rbp-190],ymm0
       vmovdqu   ymmword ptr [rbp-170],ymm0
       vmovdqu   ymmword ptr [rbp-150],ymm0
       lea       rcx,[rbp-1D0]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE94D873F0]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rbx],rcx
       jne       short M04_L08
       mov       rcx,[rbx+138]
       mov       r8,[rbx+0B0]
       lea       rdx,[rbp-130]
       lea       r9,[rbp-1D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE94C7E838]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       jmp       short M04_L09
M04_L05:
       mov       ecx,318C
       mov       rdx,7FFE94BE1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D1C318]
       int       3
M04_L06:
       mov       ecx,318C
       mov       rdx,7FFE94BE1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D1C348]
       int       3
M04_L07:
       call      qword ptr [7FFE9491E9A0]
       int       3
M04_L08:
       lea       r8,[rbp-1D0]
       lea       rdx,[rbp-130]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
M04_L09:
       mov       [rbp-228],rax
       mov       rcx,rsp
       call      M04_L11
       nop
       mov       rax,[rbp-228]
       add       rsp,238
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
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M04_L02
M04_L11:
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
       lea       rbp,[rbp+270]
       cmp       qword ptr [rbp-220],0
       je        near ptr M04_L33
       mov       rcx,[rbp-238]
       mov       edx,[rbp-1E4]
       mov       [rbp-1D8],rdx
       test      rdx,rdx
       je        short M04_L13
       cmp       rdx,300
       ja        short M04_L12
       xor       edx,edx
       mov       r8d,[rbp-1D8]
       call      CORINFO_HELP_MEMSET
       jmp       short M04_L13
M04_L12:
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FFE94815BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M04_L13:
       mov       rcx,1C127801E48
       mov       r13,[rcx]
       mov       rcx,[rbp-220]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFE946A5120
       mov       edx,30
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M04_L14
       mov       rcx,r13
       call      qword ptr [7FFE94C75980]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M04_L14:
       xor       ebx,ebx
       mov       esi,1
       mov       edx,[rcx+8]
       cmp       edx,r12d
       jbe       near ptr M04_L28
       mov       ebx,1
       mov       rdx,[rbp-220]
       mov       eax,10
       shlx      eax,eax,r12d
       cmp       [rdx+8],eax
       je        short M04_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFE94C552D8]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE94614000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r13
       call      qword ptr [7FFE9476F750]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M04_L15:
       mov       edx,r12d
       shl       rdx,4
       lea       r14,[rcx+rdx+10]
       mov       rdi,[r14]
       mov       rdx,[rbp-220]
       mov       rcx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],eax
       test      rdi,rdi
       je        near ptr M04_L28
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       short M04_L17
       mov       edx,r12d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M04_L16
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FFE94C75908]
M04_L16:
       mov       rsi,[rax+8]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14d,[rax+0A3C]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[r14-1]
       mov       [rax+0A3C],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M04_L18
       call      qword ptr [7FFE94EDDD10]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M04_L19
M04_L17:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L18:
       mov       eax,r14d
       sar       eax,10
M04_L19:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       r15d,r15d
       jmp       near ptr M04_L26
M04_L20:
       cmp       r14d,[rsi+8]
       jae       short M04_L17
       mov       ecx,r14d
       mov       rax,[rsi+rcx*8+10]
       mov       [rbp-230],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-1DC],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-230]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-1E0],r10d
       cmp       [rcx+8],r10d
       jbe       short M04_L22
       test      r10d,r10d
       jne       short M04_L23
       xor       edx,edx
       mov       [rax+14],edx
M04_L21:
       movsxd    rdx,r10d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-1E0]
       inc       ecx
       mov       rax,[rbp-230]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-1DC],1
M04_L22:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-1DC]
       test      ecx,ecx
       je        short M04_L24
       mov       ecx,1
       jmp       short M04_L27
M04_L23:
       jmp       short M04_L21
M04_L24:
       inc       r14d
       cmp       [rsi+8],r14d
       jne       short M04_L25
       xor       r14d,r14d
M04_L25:
       inc       r15d
M04_L26:
       cmp       [rsi+8],r15d
       jg        near ptr M04_L20
       xor       ecx,ecx
M04_L27:
       mov       esi,ecx
M04_L28:
       mov       rax,1C1278005D0
       mov       r14,[rax]
       cmp       byte ptr [r14+9D],0
       je        near ptr M04_L33
       mov       rcx,[rbp-220]
       cmp       dword ptr [rcx+8],0
       je        near ptr M04_L33
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,[rbp-220]
       mov       r15d,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,edi
       mov       r9d,r15d
       mov       edx,3
       call      qword ptr [7FFE94817678]
       test      esi,ebx
       jne       short M04_L33
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp-220]
       mov       edi,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      ebx,ebx
       jne       short M04_L29
       mov       ecx,0FFFFFFFF
       jmp       short M04_L30
M04_L29:
       mov       ecx,r12d
M04_L30:
       mov       edx,esi
       mov       r8d,edi
       mov       r9d,eax
       test      ebx,ebx
       jne       short M04_L31
       mov       eax,1
       jmp       short M04_L32
M04_L31:
       xor       eax,eax
M04_L32:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFE94A3F360]
M04_L33:
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
; Total bytes of code 1595
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B0]
       cmp       qword ptr [rax+20],0
       je        near ptr M05_L06
       mov       byte ptr [rax+8C],1
       mov       byte ptr [rcx+100],1
       mov       rbx,[rcx+0D8]
       test      rbx,rbx
       jne       near ptr M05_L07
       mov       rbx,[rcx+0B0]
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M05_L05
M05_L00:
       mov       [rbp-20],rax
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M05_L02
       lea       rdx,[rbp-18]
       mov       rcx,rax
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+105],0
       jne       short M05_L03
       mov       rbx,[rcx+0D8]
       test      rbx,rbx
       jne       short M05_L01
       mov       rcx,7FFE95193A78
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+105],1
       call      qword ptr [7FFE94CB47C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+105],2
       jmp       short M05_L03
M05_L01:
       mov       rcx,7FFE95193A74
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE9518C4E0]
       int       3
M05_L02:
       call      qword ptr [7FFE9476E040]
       int       3
M05_L03:
       cmp       byte ptr [rbp-18],0
       je        short M05_L04
       mov       rcx,7FFE95193A7C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M05_L04:
       mov       rcx,7FFE95193A80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE95193A84
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE94CB4B10]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rax,rcx
       jmp       near ptr M05_L00
M05_L06:
       call      qword ptr [7FFE94D1CBD0]
       int       3
M05_L07:
       mov       rcx,7FFE95193A70
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE9518C4E0]
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,rdx
       call      qword ptr [7FFE9518C4B0]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0D8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+105],0
       call      CORINFO_HELP_RETHROW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M05_L08
       mov       rcx,7FFE95193A7C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M05_L08:
       mov       rcx,7FFE95193A80
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 492
```
**Extern method**
System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_PersonRecord()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+118]
       mov       rcx,24596005788
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L06
       cmp       byte ptr [rdi+8D],0
       je        short M00_L01
M00_L00:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        short M00_L02
       mov       rcx,[rbp+0B8]
       mov       r9,286280B3BB8
       cmp       rcx,r9
       je        short M00_L03
       jmp       short M00_L02
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFE94C14660]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       short M00_L00
M00_L02:
       mov       rcx,rdi
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,286280B3BB8
       mov       r8d,1
       call      qword ptr [7FFE94C14048]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       mov       rdx,rbp
       mov       r8,rdx
       test      r8,r8
       jne       short M00_L05
M00_L04:
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>)
       call      qword ptr [7FFE94FED458]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+50],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [r8],rcx
       je        short M00_L04
       call      qword ptr [7FFE947743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L06:
       mov       ecx,3174
       mov       rdx,7FFE94BF1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D2C300]
       int       3
; Total bytes of code 322
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFF47735068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M01_L03
       call      qword ptr [7FFF47739F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M01_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
M01_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      qword ptr [7FFF477369F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L00
       call      qword ptr [7FFF47735060]
       cmp       byte ptr [rax+18E],0
       je        short M01_L00
       mov       ecx,2
       call      qword ptr [7FFF47736948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF47739FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L00
       cmp       [rsi+10],rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M01_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF47739198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M01_L00
M01_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFF47734820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       call      qword ptr [7FFF47736A08]
       test      rax,rax
       je        near ptr M01_L00
M01_L04:
       call      qword ptr [7FFF477384A0]
       int       3
; Total bytes of code 272
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       [rsp+68],r9
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+8C],0
       je        near ptr M02_L08
       mov       r14,[rbx+8]
       test      r14,r14
       je        near ptr M02_L07
M02_L00:
       cmp       [r14],r14b
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFE94CC4C00]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       cmp       byte ptr [rsp+78],0
       jne       near ptr M02_L12
M02_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M02_L13
       mov       rbp,[rax+8]
M02_L02:
       test      dil,dil
       je        short M02_L03
       test      rbp,rbp
       je        short M02_L06
       mov       rcx,7FFE95172C90
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+105],2
       jne       short M02_L05
M02_L03:
       test      rbp,rbp
       je        near ptr M02_L09
M02_L04:
       mov       rcx,7FFE95172CA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L05:
       mov       rcx,rbp
       call      qword ptr [7FFE94CC4AE0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M02_L03
M02_L06:
       mov       rcx,7FFE95172C94
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M02_L03
M02_L07:
       mov       rcx,rbx
       call      qword ptr [7FFE94CC4B10]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r14,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L00
M02_L08:
       cmp       byte ptr [rsp+70],0
       je        short M02_L11
       mov       rcx,7FFE95172C98
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE94C14678]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       near ptr M02_L03
M02_L09:
       movzx     ecx,byte ptr [rsp+68]
       movzx     eax,byte ptr [rsp+69]
       cmp       al,1
       sete      al
       movzx     eax,al
       test      ecx,eax
       je        short M02_L10
       mov       rcx,7FFE95172C9C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFE94D2D1A0]
       int       3
M02_L10:
       mov       rcx,7FFE95172CA4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L04
M02_L11:
       mov       rcx,7FFE95172CA8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L03
M02_L12:
       cmp       byte ptr [rax+20],0
       jne       near ptr M02_L01
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FFE94CC4C30]
       mov       rbp,rax
       jmp       near ptr M02_L02
M02_L13:
       call      qword ptr [7FFE9516FE88]
       int       3
; Total bytes of code 397
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,238
       vzeroupper
       lea       rbp,[rsp+270]
       xor       eax,eax
       mov       [rbp-228],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M03_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-40],rax
       mov       [rbp-240],rsp
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp-220],rcx
       cmp       edi,55555
       ja        short M03_L03
       mov       rdx,24596001E48
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFE94C73578]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-220],rax
M03_L01:
       test      rax,rax
       je        near ptr M03_L09
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M03_L02:
       mov       [rbp-238],r14
       mov       [rbp-1E4],r15d
       jmp       short M03_L04
M03_L03:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       lea       rcx,[rbp-1F8]
       call      qword ptr [7FFE94C443C0]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M03_L01
M03_L04:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       mov       rcx,[rbp-238]
       mov       [rbp-208],rcx
       mov       ecx,[rbp-1E4]
       mov       [rbp-200],ecx
       lea       rcx,[rbp-1F8]
       lea       rdx,[rbp-208]
       call      qword ptr [7FFE94C443D8]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp-1E4]
       ja        short M03_L07
       mov       rdx,[rbp-238]
       mov       [rbp-238],rdx
       mov       [rbp-1E4],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+85]
       movzx     r8d,byte ptr [rcx+84]
       cmp       r8d,2
       jg        short M03_L06
       mov       ecx,[rcx+7C]
       test      ecx,ecx
       jl        short M03_L05
       jmp       short M03_L08
M03_L05:
       mov       ecx,318C
       mov       rdx,7FFE94BF1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D2C318]
       int       3
M03_L06:
       mov       ecx,318C
       mov       rdx,7FFE94BF1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D2C348]
       int       3
M03_L07:
       call      qword ptr [7FFE9492E9A0]
       int       3
M03_L08:
       xor       r10d,r10d
       mov       [rbp-70],r10
       mov       [rbp-68],r10
       mov       byte ptr [rbp-60],0
       mov       byte ptr [rbp-5F],0
       mov       byte ptr [rbp-5E],0
       mov       byte ptr [rbp-5D],0
       mov       byte ptr [rbp-5C],0
       mov       byte ptr [rbp-5B],0
       mov       [rbp-58],ecx
       mov       [rbp-54],r8b
       mov       [rbp-53],r9b
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       [rbp-218],rdx
       mov       [rbp-210],eax
       lea       rdx,[rbp-218]
       lea       rcx,[rbp-130]
       lea       r9,[rbp-70]
       mov       r8d,1
       call      qword ptr [7FFE94D96328]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1D0],ymm0
       vmovdqu   ymmword ptr [rbp-1B0],ymm0
       vmovdqu   ymmword ptr [rbp-190],ymm0
       vmovdqu   ymmword ptr [rbp-170],ymm0
       vmovdqu   ymmword ptr [rbp-150],ymm0
       lea       rcx,[rbp-1D0]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE94D973F0]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,[rbx+138]
       mov       r8,[rbx+0B0]
       lea       rdx,[rbp-130]
       lea       r9,[rbp-1D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE94C8E838]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       [rbp-228],rax
       mov       rcx,rsp
       call      M03_L10
       nop
       mov       rax,[rbp-228]
       add       rsp,238
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L09:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M03_L02
M03_L10:
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
       lea       rbp,[rbp+270]
       cmp       qword ptr [rbp-220],0
       je        near ptr M03_L32
       mov       rcx,[rbp-238]
       mov       edx,[rbp-1E4]
       mov       [rbp-1D8],rdx
       test      rdx,rdx
       je        short M03_L12
       cmp       rdx,300
       ja        short M03_L11
       xor       edx,edx
       mov       r8d,[rbp-1D8]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L12
M03_L11:
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FFE94825BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L12:
       mov       rcx,24596001E48
       mov       r13,[rcx]
       mov       rcx,[rbp-220]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFE946B5120
       mov       edx,30
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M03_L13
       mov       rcx,r13
       call      qword ptr [7FFE94C85980]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M03_L13:
       xor       ebx,ebx
       mov       esi,1
       mov       edx,[rcx+8]
       cmp       edx,r12d
       jbe       near ptr M03_L27
       mov       ebx,1
       mov       rdx,[rbp-220]
       mov       eax,10
       shlx      eax,eax,r12d
       cmp       [rdx+8],eax
       je        short M03_L14
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFE94C652D8]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE94624000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r13
       call      qword ptr [7FFE9477F750]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M03_L14:
       mov       edx,r12d
       shl       rdx,4
       lea       r14,[rcx+rdx+10]
       mov       rdi,[r14]
       mov       rdx,[rbp-220]
       mov       rcx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],eax
       test      rdi,rdi
       je        near ptr M03_L27
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       short M03_L16
       mov       edx,r12d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M03_L15
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FFE94C85908]
M03_L15:
       mov       rsi,[rax+8]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14d,[rax+0A3C]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[r14-1]
       mov       [rax+0A3C],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M03_L17
       call      qword ptr [7FFE94EEDD10]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M03_L18
M03_L16:
       call      CORINFO_HELP_RNGCHKFAIL
M03_L17:
       mov       eax,r14d
       sar       eax,10
M03_L18:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       r15d,r15d
       jmp       near ptr M03_L25
M03_L19:
       cmp       r14d,[rsi+8]
       jae       short M03_L16
       mov       ecx,r14d
       mov       rax,[rsi+rcx*8+10]
       mov       [rbp-230],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-1DC],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-230]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-1E0],r10d
       cmp       [rcx+8],r10d
       jbe       short M03_L21
       test      r10d,r10d
       jne       short M03_L22
       xor       edx,edx
       mov       [rax+14],edx
M03_L20:
       movsxd    rdx,r10d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-1E0]
       inc       ecx
       mov       rax,[rbp-230]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-1DC],1
M03_L21:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-1DC]
       test      ecx,ecx
       je        short M03_L23
       mov       ecx,1
       jmp       short M03_L26
M03_L22:
       jmp       short M03_L20
M03_L23:
       inc       r14d
       cmp       [rsi+8],r14d
       jne       short M03_L24
       xor       r14d,r14d
M03_L24:
       inc       r15d
M03_L25:
       cmp       [rsi+8],r15d
       jg        near ptr M03_L19
       xor       ecx,ecx
M03_L26:
       mov       esi,ecx
M03_L27:
       mov       rax,245960005D0
       mov       r14,[rax]
       cmp       byte ptr [r14+9D],0
       je        near ptr M03_L32
       mov       rcx,[rbp-220]
       cmp       dword ptr [rcx+8],0
       je        near ptr M03_L32
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,[rbp-220]
       mov       r15d,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,edi
       mov       r9d,r15d
       mov       edx,3
       call      qword ptr [7FFE94827678]
       test      esi,ebx
       jne       short M03_L32
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp-220]
       mov       edi,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      ebx,ebx
       jne       short M03_L28
       mov       ecx,0FFFFFFFF
       jmp       short M03_L29
M03_L28:
       mov       ecx,r12d
M03_L29:
       mov       edx,esi
       mov       r8d,edi
       mov       r9d,eax
       test      ebx,ebx
       jne       short M03_L30
       mov       eax,1
       jmp       short M03_L31
M03_L30:
       xor       eax,eax
M03_L31:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFE94A4F360]
M03_L32:
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
; Total bytes of code 1541
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rbx]
M04_L00:
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       jne       short M04_L02
M04_L01:
       mov       rcx,7FFE9505E1CC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       test      rdi,rdi
       je        near ptr M04_L08
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       jne       short M04_L03
       mov       rcx,7FFE9505E1C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L01
M04_L03:
       test      rdi,rdi
       je        short M04_L04
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       jne       short M04_L05
       mov       rcx,7FFE9505E1C0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L01
M04_L04:
       mov       rcx,7FFE9505E1C4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L08
M04_L05:
       test      rdi,rdi
       je        short M04_L07
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       je        short M04_L06
       test      rdi,rdi
       je        short M04_L09
       mov       rcx,7FFE9505E1B4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L00
M04_L06:
       mov       rcx,7FFE9505E1B8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L01
M04_L07:
       mov       rcx,7FFE9505E1BC
       call      CORINFO_HELP_COUNTPROFILE32
M04_L08:
       mov       rcx,7FFE9505E1D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE947743A8]
M04_L09:
       mov       rcx,7FFE9505E1B0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L08
; Total bytes of code 259
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_Person_List()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+128]
       mov       rcx,1DCB9403790
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L06
       cmp       byte ptr [rdi+8D],0
       je        short M00_L01
M00_L00:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        short M00_L02
       mov       rcx,[rbp+0B8]
       mov       r9,21D4B47C560
       cmp       rcx,r9
       je        short M00_L03
       jmp       short M00_L02
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFE94C04660]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       short M00_L00
M00_L02:
       mov       rcx,rdi
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,21D4B47C560
       mov       r8d,1
       call      qword ptr [7FFE94C04048]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       mov       rdx,rbp
       mov       r8,rdx
       test      r8,r8
       jne       short M00_L05
M00_L04:
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>)
       call      qword ptr [7FFE94FDD500]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+50],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M00_L04
       call      qword ptr [7FFE947643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L06:
       mov       ecx,3174
       mov       rdx,7FFE94BE1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D1C300]
       int       3
; Total bytes of code 322
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFF47735068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M01_L03
       call      qword ptr [7FFF47739F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M01_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
M01_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      qword ptr [7FFF477369F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L00
       call      qword ptr [7FFF47735060]
       cmp       byte ptr [rax+18E],0
       je        short M01_L00
       mov       ecx,2
       call      qword ptr [7FFF47736948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF47739FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L00
       cmp       [rsi+10],rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M01_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF47739198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M01_L00
M01_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFF47734820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       call      qword ptr [7FFF47736A08]
       test      rax,rax
       je        near ptr M01_L00
M01_L04:
       call      qword ptr [7FFF477384A0]
       int       3
; Total bytes of code 272
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       [rsp+68],r9
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+8C],0
       je        near ptr M02_L08
       mov       r14,[rbx+8]
       test      r14,r14
       je        near ptr M02_L07
M02_L00:
       cmp       [r14],r14b
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFE94CB4C00]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       cmp       byte ptr [rsp+78],0
       jne       near ptr M02_L12
M02_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M02_L13
       mov       rbp,[rax+8]
M02_L02:
       test      dil,dil
       je        short M02_L03
       test      rbp,rbp
       je        short M02_L06
       mov       rcx,7FFE95164A38
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+105],2
       jne       short M02_L05
M02_L03:
       test      rbp,rbp
       je        near ptr M02_L09
M02_L04:
       mov       rcx,7FFE95164A48
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L05:
       mov       rcx,rbp
       call      qword ptr [7FFE94CB4AE0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M02_L03
M02_L06:
       mov       rcx,7FFE95164A3C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M02_L03
M02_L07:
       mov       rcx,rbx
       call      qword ptr [7FFE94CB4B10]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r14,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L00
M02_L08:
       cmp       byte ptr [rsp+70],0
       je        short M02_L11
       mov       rcx,7FFE95164A40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE94C04678]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       near ptr M02_L03
M02_L09:
       movzx     ecx,byte ptr [rsp+68]
       movzx     eax,byte ptr [rsp+69]
       cmp       al,1
       sete      al
       movzx     eax,al
       test      ecx,eax
       je        short M02_L10
       mov       rcx,7FFE95164A44
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFE94D1D1A0]
       int       3
M02_L10:
       mov       rcx,7FFE95164A4C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L04
M02_L11:
       mov       rcx,7FFE95164A50
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L03
M02_L12:
       cmp       byte ptr [rax+20],0
       jne       near ptr M02_L01
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FFE94CB4C30]
       mov       rbp,rax
       jmp       near ptr M02_L02
M02_L13:
       call      qword ptr [7FFE9515FE88]
       int       3
; Total bytes of code 397
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,238
       vzeroupper
       lea       rbp,[rsp+270]
       xor       eax,eax
       mov       [rbp-228],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M03_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-40],rax
       mov       [rbp-240],rsp
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp-220],rcx
       cmp       edi,55555
       ja        short M03_L03
       mov       rdx,1DCBD401E48
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFE94C63578]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-220],rax
M03_L01:
       test      rax,rax
       je        near ptr M03_L09
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M03_L02:
       mov       [rbp-238],r14
       mov       [rbp-1E4],r15d
       jmp       short M03_L04
M03_L03:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       lea       rcx,[rbp-1F8]
       call      qword ptr [7FFE94C343C0]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M03_L01
M03_L04:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       mov       rcx,[rbp-238]
       mov       [rbp-208],rcx
       mov       ecx,[rbp-1E4]
       mov       [rbp-200],ecx
       lea       rcx,[rbp-1F8]
       lea       rdx,[rbp-208]
       call      qword ptr [7FFE94C343D8]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp-1E4]
       ja        short M03_L07
       mov       rdx,[rbp-238]
       mov       [rbp-238],rdx
       mov       [rbp-1E4],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+85]
       movzx     r8d,byte ptr [rcx+84]
       cmp       r8d,2
       jg        short M03_L06
       mov       ecx,[rcx+7C]
       test      ecx,ecx
       jl        short M03_L05
       jmp       short M03_L08
M03_L05:
       mov       ecx,318C
       mov       rdx,7FFE94BE1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D1C318]
       int       3
M03_L06:
       mov       ecx,318C
       mov       rdx,7FFE94BE1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D1C348]
       int       3
M03_L07:
       call      qword ptr [7FFE9491E9A0]
       int       3
M03_L08:
       xor       r10d,r10d
       mov       [rbp-70],r10
       mov       [rbp-68],r10
       mov       byte ptr [rbp-60],0
       mov       byte ptr [rbp-5F],0
       mov       byte ptr [rbp-5E],0
       mov       byte ptr [rbp-5D],0
       mov       byte ptr [rbp-5C],0
       mov       byte ptr [rbp-5B],0
       mov       [rbp-58],ecx
       mov       [rbp-54],r8b
       mov       [rbp-53],r9b
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       [rbp-218],rdx
       mov       [rbp-210],eax
       lea       rdx,[rbp-218]
       lea       rcx,[rbp-130]
       lea       r9,[rbp-70]
       mov       r8d,1
       call      qword ptr [7FFE94D86328]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1D0],ymm0
       vmovdqu   ymmword ptr [rbp-1B0],ymm0
       vmovdqu   ymmword ptr [rbp-190],ymm0
       vmovdqu   ymmword ptr [rbp-170],ymm0
       vmovdqu   ymmword ptr [rbp-150],ymm0
       lea       rcx,[rbp-1D0]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE94D873F0]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,[rbx+138]
       mov       r8,[rbx+0B0]
       lea       rdx,[rbp-130]
       lea       r9,[rbp-1D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE94C7E838]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       [rbp-228],rax
       mov       rcx,rsp
       call      M03_L10
       nop
       mov       rax,[rbp-228]
       add       rsp,238
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L09:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M03_L02
M03_L10:
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
       lea       rbp,[rbp+270]
       cmp       qword ptr [rbp-220],0
       je        near ptr M03_L32
       mov       rcx,[rbp-238]
       mov       edx,[rbp-1E4]
       mov       [rbp-1D8],rdx
       test      rdx,rdx
       je        short M03_L12
       cmp       rdx,300
       ja        short M03_L11
       xor       edx,edx
       mov       r8d,[rbp-1D8]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L12
M03_L11:
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FFE94815BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L12:
       mov       rcx,1DCBD401E48
       mov       r13,[rcx]
       mov       rcx,[rbp-220]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFE946A5120
       mov       edx,30
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M03_L13
       mov       rcx,r13
       call      qword ptr [7FFE94C75980]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M03_L13:
       xor       ebx,ebx
       mov       esi,1
       mov       edx,[rcx+8]
       cmp       edx,r12d
       jbe       near ptr M03_L27
       mov       ebx,1
       mov       rdx,[rbp-220]
       mov       eax,10
       shlx      eax,eax,r12d
       cmp       [rdx+8],eax
       je        short M03_L14
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFE94C552D8]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE94614000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r13
       call      qword ptr [7FFE9476F750]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M03_L14:
       mov       edx,r12d
       shl       rdx,4
       lea       r14,[rcx+rdx+10]
       mov       rdi,[r14]
       mov       rdx,[rbp-220]
       mov       rcx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],eax
       test      rdi,rdi
       je        near ptr M03_L27
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       short M03_L16
       mov       edx,r12d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M03_L15
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FFE94C75908]
M03_L15:
       mov       rsi,[rax+8]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14d,[rax+0A3C]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[r14-1]
       mov       [rax+0A3C],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M03_L17
       call      qword ptr [7FFE94EDDD10]; System.Threading.ProcessorIdCache.RefreshCurrentProcessorId()
       jmp       short M03_L18
M03_L16:
       call      CORINFO_HELP_RNGCHKFAIL
M03_L17:
       mov       eax,r14d
       sar       eax,10
M03_L18:
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       r15d,r15d
       jmp       near ptr M03_L25
M03_L19:
       cmp       r14d,[rsi+8]
       jae       short M03_L16
       mov       ecx,r14d
       mov       rax,[rsi+rcx*8+10]
       mov       [rbp-230],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-1DC],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-230]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-1E0],r10d
       cmp       [rcx+8],r10d
       jbe       short M03_L21
       test      r10d,r10d
       jne       short M03_L22
       xor       edx,edx
       mov       [rax+14],edx
M03_L20:
       movsxd    rdx,r10d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-1E0]
       inc       ecx
       mov       rax,[rbp-230]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-1DC],1
M03_L21:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-1DC]
       test      ecx,ecx
       je        short M03_L23
       mov       ecx,1
       jmp       short M03_L26
M03_L22:
       jmp       short M03_L20
M03_L23:
       inc       r14d
       cmp       [rsi+8],r14d
       jne       short M03_L24
       xor       r14d,r14d
M03_L24:
       inc       r15d
M03_L25:
       cmp       [rsi+8],r15d
       jg        near ptr M03_L19
       xor       ecx,ecx
M03_L26:
       mov       esi,ecx
M03_L27:
       mov       rax,1DCBD4005D0
       mov       r14,[rax]
       cmp       byte ptr [r14+9D],0
       je        near ptr M03_L32
       mov       rcx,[rbp-220]
       cmp       dword ptr [rcx+8],0
       je        near ptr M03_L32
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,[rbp-220]
       mov       r15d,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,edi
       mov       r9d,r15d
       mov       edx,3
       call      qword ptr [7FFE94817678]
       test      esi,ebx
       jne       short M03_L32
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp-220]
       mov       edi,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      ebx,ebx
       jne       short M03_L28
       mov       ecx,0FFFFFFFF
       jmp       short M03_L29
M03_L28:
       mov       ecx,r12d
M03_L29:
       mov       edx,esi
       mov       r8d,edi
       mov       r9d,eax
       test      ebx,ebx
       jne       short M03_L30
       mov       eax,1
       jmp       short M03_L31
M03_L30:
       xor       eax,eax
M03_L31:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFE94A3F360]
M03_L32:
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
; Total bytes of code 1541
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rbx]
M04_L00:
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       jne       short M04_L02
M04_L01:
       mov       rcx,7FFE9504EBAC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       test      rdi,rdi
       je        near ptr M04_L08
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       jne       short M04_L03
       mov       rcx,7FFE9504EBA8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L01
M04_L03:
       test      rdi,rdi
       je        short M04_L04
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       jne       short M04_L05
       mov       rcx,7FFE9504EBA0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L01
M04_L04:
       mov       rcx,7FFE9504EBA4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L08
M04_L05:
       test      rdi,rdi
       je        short M04_L07
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       je        short M04_L06
       test      rdi,rdi
       je        short M04_L09
       mov       rcx,7FFE9504EB94
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L00
M04_L06:
       mov       rcx,7FFE9504EB98
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L01
M04_L07:
       mov       rcx,7FFE9504EB9C
       call      CORINFO_HELP_COUNTPROFILE32
M04_L08:
       mov       rcx,7FFE9504EBB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE947643A8]
M04_L09:
       mov       rcx,7FFE9504EB90
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L08
; Total bytes of code 259
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_Ref_Person()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+140]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FFE94FDD380]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       mov       rbx,rcx
       test      rdx,rdx
       je        short M01_L00
       mov       ecx,[rdx+8]
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
       je        near ptr M01_L08
       mov       ecx,[rdx+8]
       test      ecx,ecx
       je        near ptr M01_L05
       movzx     eax,word ptr [rdx+0C]
       cmp       eax,100
       jae       short M01_L02
       mov       r8,7FFEF36A2C00
       test      byte ptr [rax+r8],80
       jne       near ptr M01_L09
       jmp       short M01_L03
M01_L02:
       mov       r8d,eax
       shr       r8d,9
       mov       r10,7FFEF36B1A60
       movzx     r8d,byte ptr [r8+r10]
       shl       r8d,6
       mov       r10d,eax
       shr       r10d,3
       and       r10d,3E
       add       r8d,r10d
       mov       r10,7FFEF36AAA78
       movzx     r8d,word ptr [r8+r10]
       shl       r8d,4
       and       eax,0F
       add       eax,r8d
       mov       r8,7FFEF36AE5A0
       movzx     eax,byte ptr [rax+r8]
       mov       r8,7FFEF36A2F00
       cmp       byte ptr [rax+r8],0
       jl        near ptr M01_L09
M01_L03:
       lea       eax,[rcx-1]
       cmp       eax,ecx
       jae       near ptr M01_L11
       mov       ecx,eax
       movzx     ecx,word ptr [rdx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFEF36A2C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L05
M01_L04:
       mov       eax,ecx
       shr       eax,9
       mov       r8,7FFEF36B1A60
       movzx     eax,byte ptr [rax+r8]
       shl       eax,6
       mov       r8d,ecx
       shr       r8d,3
       and       r8d,3E
       add       eax,r8d
       mov       r8,7FFEF36AAA78
       movzx     eax,word ptr [rax+r8]
       shl       eax,4
       and       ecx,0F
       add       ecx,eax
       mov       rax,7FFEF36AE5A0
       movzx     ecx,byte ptr [rcx+rax]
       mov       rax,7FFEF36A2F00
       cmp       byte ptr [rcx+rax],0
       jl        near ptr M01_L09
M01_L05:
       mov       rsi,rdx
M01_L06:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        near ptr M01_L10
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-60],rdi
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,2AF35402008
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r9,2EFBB230008
       call      qword ptr [7FFE94FDD848]; System.Xml.XmlTextReaderImpl..ctor(System.IO.TextReader, System.Xml.XmlReaderSettings, System.String, System.Xml.XmlParserContext)
       mov       [rbp-68],rsi
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FFE94EAEAD8]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rcx,r14
       mov       rdx,rsi
       vmovdqu   ymm0,ymmword ptr [rcx+38]
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       r9,[rcx+58]
       mov       [rbp-38],r9
       lea       r9,[rbp-58]
       xor       r8d,r8d
       call      qword ptr [7FFE94EAECD0]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       mov       r8,rax
       test      r8,r8
       je        short M01_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M01_L07
       mov       rdx,rax
       call      qword ptr [7FFE94764390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M01_L07:
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
       call      qword ptr [7FFE9489DA58]; System.IO.TextReader.Dispose(Boolean)
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
M01_L08:
       call      qword ptr [7FFE94C0C468]
       mov       rsi,rax
       mov       ecx,10A2
       mov       rdx,7FFE94A47DB0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE94A47DB0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A47DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94C07A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94C0C060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE94C0C5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE94946670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFE947673F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L10:
       mov       ecx,11
       call      qword ptr [7FFE9491ECD0]
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
       mov       rsi,[rbp-68]
       cmp       dword ptr [rsi+160],4
       je        near ptr M01_L24
       movzx     edi,byte ptr [rsi+17D]
       cmp       dword ptr [rsi+108],0C
       jne       short M01_L14
       jmp       near ptr M01_L24
M01_L13:
       mov       rcx,rsi
       call      qword ptr [7FFE94FDEDF0]
M01_L14:
       cmp       dword ptr [rsi+13C],0
       jge       short M01_L13
       lea       rbx,[rsi+188]
       test      edi,edi
       je        near ptr M01_L22
       mov       rcx,[rbx+10]
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
       mov       rbx,[r15]
       mov       rcx,offset MT_System.IO.Strategies.SyncWindowsFileStreamStrategy
       cmp       rbx,rcx
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
       call      qword ptr [7FFE953210B8]; Precode of System.Threading.ThreadPoolBoundHandle.Dispose()
M01_L15:
       mov       rbx,[r15+18]
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFE9476E3E8]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,rbx
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M01_L17
M01_L16:
       mov       rcx,r15
       mov       edx,1
       mov       rax,[rbx+50]
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
       mov       rdi,[rbx+28]
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
       call      qword ptr [7FFE9489DA58]; System.IO.TextReader.Dispose(Boolean)
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
       call      qword ptr [7FFE95014858]; System.Xml.XmlTextReaderImpl+NodeData.get_None()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+108],0C
       xor       ecx,ecx
       mov       [rsi+68],rcx
       mov       rcx,2EFBB230008
       mov       [rsi+60],rcx
       mov       dword ptr [rsi+160],4
       mov       byte ptr [rsi+176],0
       cmp       byte ptr [rsi+176],0
       je        short M01_L23
       mov       rcx,rsi
       call      qword ptr [7FFE94FDECB8]
M01_L23:
       mov       dword ptr [rsi+118],0FFFFFFFF
       xor       ecx,ecx
       mov       [rsi+11C],ecx
       mov       [rsi+120],ecx
       mov       [rsi+124],ecx
       mov       [rsi+8],rcx
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
       call      qword ptr [7FFE9489DA58]; System.IO.TextReader.Dispose(Boolean)
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
; Total bytes of code 1435
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_PersonRecord()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+138]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FFE94FED380]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L00
       xor       ecx,ecx
       cmp       dword ptr [rsi+8],0
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       dword ptr [rsi+8],0
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L07
       cmp       dword ptr [rsi+8],0
       je        short M01_L05
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEF36A2C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L08
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE94EBD7A0]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M01_L08
M01_L03:
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       near ptr M01_L10
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFEF36A2C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L08
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE94EBD7A0]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        near ptr M01_L09
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-68],rdi
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,286FF407FD8
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r9,2C7911C0008
       call      qword ptr [7FFE94FED848]; System.Xml.XmlTextReaderImpl..ctor(System.IO.TextReader, System.Xml.XmlReaderSettings, System.String, System.Xml.XmlParserContext)
       mov       [rbp-70],rsi
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FFE94EBEAD8]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rcx,r14
       mov       rdx,rsi
       vmovdqu   ymm0,ymmword ptr [rcx+38]
       vmovdqu   ymmword ptr [rbp-60],ymm0
       mov       r9,[rcx+58]
       mov       [rbp-40],r9
       lea       r9,[rbp-60]
       xor       r8d,r8d
       call      qword ptr [7FFE94EBECD0]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       mov       r8,rax
       test      r8,r8
       je        short M01_L06
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M01_L06
       mov       rdx,rax
       call      qword ptr [7FFE94774390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M01_L06:
       mov       rax,r8
       mov       [rbp-78],rax
       mov       rcx,rsp
       call      M01_L11
       nop
       xor       ecx,ecx
       mov       rdx,[rbp-68]
       mov       [rdx+8],rcx
       mov       [rdx+10],ecx
       mov       rcx,rdx
       mov       edx,1
       call      qword ptr [7FFE948ADA58]; System.IO.TextReader.Dispose(Boolean)
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
       call      qword ptr [7FFE94C1C468]
       mov       rsi,rax
       mov       ecx,10A2
       mov       rdx,7FFE94A57D28
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE94A57D28
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A57D28
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94C17A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94C1C060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE94C1C5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE94956670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE947773F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L09:
       mov       ecx,11
       call      qword ptr [7FFE9492ECD0]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L11:
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
       mov       rsi,[rbp-70]
       cmp       dword ptr [rsi+160],4
       je        near ptr M01_L30
       movzx     edi,byte ptr [rsi+17D]
       cmp       dword ptr [rsi+108],0C
       jne       short M01_L13
       jmp       near ptr M01_L30
M01_L12:
       mov       rcx,rsi
       call      qword ptr [7FFE94FEEDF0]
M01_L13:
       cmp       dword ptr [rsi+13C],0
       jge       short M01_L12
       lea       rbx,[rsi+188]
       test      edi,edi
       je        near ptr M01_L27
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        near ptr M01_L24
       mov       r14,rcx
       mov       rcx,offset MT_System.IO.FileStream
       cmp       [r14],rcx
       jne       near ptr M01_L23
       mov       rcx,[r14+10]
       mov       r15,rcx
       test      r15,r15
       je        near ptr M01_L22
       mov       rbx,[r15]
       mov       rcx,offset MT_System.IO.Strategies.SyncWindowsFileStreamStrategy
       cmp       rbx,rcx
       jne       near ptr M01_L21
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        near ptr M01_L22
       test      byte ptr [rcx+10],1
       jne       near ptr M01_L22
       mov       rcx,[r15+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       call      qword ptr [7FFE95287B00]; Precode of System.Threading.ThreadPoolBoundHandle.Dispose()
M01_L14:
       mov       r13,[r15+18]
       cmp       [r13],r13b
M01_L15:
       mov       ebx,[r13+10]
       test      bl,2
       jne       short M01_L19
       mov       edi,ebx
       and       edi,0FFFFFFFC
       je        short M01_L20
       mov       ecx,ebx
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M01_L16
       cmp       byte ptr [r13+14],0
       je        short M01_L16
       mov       rcx,r13
       call      qword ptr [7FFE948AE2D0]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M01_L17
M01_L16:
       xor       eax,eax
M01_L17:
       movzx     ecx,al
       lea       eax,[rbx-4]
       cmp       edi,4
       jne       short M01_L18
       or        eax,1
M01_L18:
       lea       rdx,[r13+10]
       mov       r8d,eax
       or        r8d,2
       mov       eax,ebx
       lock cmpxchg [rdx],r8d
       cmp       eax,ebx
       jne       short M01_L15
       test      ecx,ecx
       je        short M01_L19
       call      System.Runtime.InteropServices.Marshal.GetLastPInvokeError()
       mov       r15d,eax
       mov       rcx,r13
       call      qword ptr [7FFE948AE6D8]; Precode of Microsoft.Win32.SafeHandles.SafeFileHandle.ReleaseHandle()
       mov       ecx,r15d
       call      System.Runtime.InteropServices.Marshal.SetLastPInvokeError(Int32)
M01_L19:
       mov       rcx,r13
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M01_L22
M01_L20:
       mov       rcx,r13
       call      qword ptr [7FFE9492EE50]
       int       3
M01_L21:
       mov       rcx,r15
       mov       edx,1
       mov       rax,[rbx+50]
       call      qword ptr [rax+20]
M01_L22:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M01_L27
M01_L23:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       jmp       short M01_L27
M01_L24:
       mov       r13,[rbx+28]
       test      r13,r13
       je        short M01_L27
       mov       rcx,offset MT_System.IO.StringReader
       cmp       [r13],rcx
       jne       short M01_L25
       xor       ecx,ecx
       mov       [r13+8],rcx
       mov       [r13+10],ecx
       mov       rcx,r13
       mov       edx,1
       call      qword ptr [7FFE948ADA58]; System.IO.TextReader.Dispose(Boolean)
       jmp       short M01_L26
M01_L25:
       mov       rcx,r13
       mov       edx,1
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M01_L26:
       mov       rcx,r13
       call      System.GC._SuppressFinalize(System.Object)
M01_L27:
       mov       rcx,286FF407FE8
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M01_L28
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+NodeData
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE95024870]
       mov       rcx,286FF407FE8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M01_L28:
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+108],0C
       xor       ecx,ecx
       mov       [rsi+68],rcx
       mov       rcx,2C7911C0008
       mov       [rsi+60],rcx
       mov       dword ptr [rsi+160],4
       mov       byte ptr [rsi+176],0
       cmp       byte ptr [rsi+176],0
       je        short M01_L29
       mov       rcx,rsi
       call      qword ptr [7FFE94FEECB8]
M01_L29:
       mov       dword ptr [rsi+118],0FFFFFFFF
       xor       ecx,ecx
       mov       [rsi+11C],ecx
       mov       [rsi+120],ecx
       mov       [rsi+124],ecx
       mov       [rsi+8],rcx
M01_L30:
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
       call      qword ptr [7FFE948ADA58]; System.IO.TextReader.Dispose(Boolean)
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
; Total bytes of code 1488
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_JsonSerializer_Generator_Person_List()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+130]
       mov       rcx,2084AC05500
       mov       rdi,[rcx]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdx,rax
       mov       rcx,248DC9EC560
       cmp       [rcx],ecx
       call      qword ptr [7FFE946BA7B0]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       je        near ptr M00_L04
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FFE94D27EB8]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       cmp       [rbp],bpl
       mov       rcx,248DC9EC560
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,0F
       je        near ptr M00_L07
       mov       rcx,248DC9EC560
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,10
       je        near ptr M00_L07
       mov       rcx,248DC9EC560
       call      System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L07
       mov       rcx,248DC9EC560
       call      qword ptr [7FFE946C60B8]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L05
       test      rcx,rcx
       je        near ptr M00_L06
M00_L01:
       call      System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L07
       mov       rcx,rbp
       mov       byte ptr [rsp+38],0
       mov       byte ptr [rsp+39],0
       mov       dword ptr [rsp+20],1
       xor       edx,edx
       mov       [rsp+28],edx
       mov       rdx,248DC9EC560
       movzx     r9d,word ptr [rsp+38]
       mov       r8d,1
       call      qword ptr [7FFE94C14048]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L08
       cmp       byte ptr [rbp+105],2
       jne       short M00_L03
M00_L02:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFE94C1D668]; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       [rsp+40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFE94CC4AE0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M00_L02
M00_L04:
       mov       rcx,248DC9EC560
       mov       rdx,rsi
       call      qword ptr [7FFE94D2C990]
       int       3
M00_L05:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L01
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94C4EAD8]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE94956670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L07:
       mov       ecx,352A
       mov       rdx,7FFE94BF1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,248DC9EC560
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE94D2CB58]
       int       3
M00_L08:
       mov       rcx,248DC9EC560
       mov       rdx,rdi
       call      qword ptr [7FFE94D2D1E8]
       int       3
; Total bytes of code 521
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
       call      qword ptr [7FFE94774360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE94774360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE946C4E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L04
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE946C6148]
M01_L04:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        near ptr M01_L01
       mov       rcx,rsi
       call      qword ptr [7FFE946BA5A0]; Precode of System.RuntimeType.GetGenericParameterConstraints()
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
       call      qword ptr [7FFE94C14180]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE94C14210]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE94C14630]
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
       cmp       byte ptr [rsi+8C],0
       je        near ptr M04_L12
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M04_L10
M04_L00:
       mov       r14,[r15+8]
       mov       rcx,20846C01208
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M04_L14
M04_L01:
       cmp       [r14],r14b
       test      rbx,rbx
       je        near ptr M04_L17
       test      r13,r13
       je        near ptr M04_L11
       mov       r12,[r14+8]
       mov       rcx,[r12+8]
       cmp       byte ptr [r14+15],0
       je        near ptr M04_L08
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
M04_L02:
       mov       [rbp-3C],eax
       lea       rdx,[rbp-48]
       mov       [rsp+20],rdx
       mov       rdx,r12
       mov       r8,rbx
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      qword ptr [7FFE94B2F948]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M04_L03
       mov       edx,[rbp-3C]
       mov       byte ptr [rbp-50],1
       mov       [rbp-4C],edx
       mov       rdx,rbx
       mov       r8,r15
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-48]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,r12
       mov       r8,rbx
       mov       r9,[rbp-50]
       mov       rcx,r14
       call      qword ptr [7FFE94B2FA38]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M04_L03:
       mov       r8,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       byte ptr [rbp+38],0
       jne       near ptr M04_L15
M04_L04:
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M04_L16
       mov       r14,[r8+8]
M04_L05:
       test      dil,dil
       je        short M04_L06
       test      r14,r14
       je        short M04_L06
       cmp       byte ptr [r14+105],2
       jne       short M04_L09
M04_L06:
       test      r14,r14
       je        near ptr M04_L13
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
       mov       r11,7FFE94630B58
       call      qword ptr [r11]
       jmp       near ptr M04_L02
M04_L09:
       mov       rcx,r14
       call      qword ptr [7FFE94CC4AE0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M04_L06
M04_L10:
       mov       rcx,rsi
       call      qword ptr [7FFE94CC4B10]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r15,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L00
M04_L11:
       mov       ecx,0BB4
       mov       rdx,7FFE94B4B2D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D27D08]
       int       3
M04_L12:
       cmp       byte ptr [rbp+30],0
       je        short M04_L06
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE94C14678]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r14,rax
       jmp       near ptr M04_L06
M04_L13:
       movzx     edx,byte ptr [rbp+28]
       movzx     ecx,byte ptr [rbp+29]
       cmp       cl,1
       sete      cl
       movzx     ecx,cl
       test      edx,ecx
       je        near ptr M04_L07
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FFE94D2D1A0]
       int       3
M04_L14:
       mov       rcx,offset MT_System.Func`3[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFE9462D0E0
       call      qword ptr [7FFE94774258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,20846C01208
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L01
M04_L15:
       cmp       byte ptr [r8+20],0
       jne       near ptr M04_L04
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFE94CC4C30]
       mov       r14,rax
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFE95187E88]
       int       3
M04_L17:
       mov       ecx,1
       mov       rdx,7FFE94B4B2D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D27D08]
       int       3
; Total bytes of code 646
```
```assembly
; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-70],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rsi+0B0]
       lea       rdx,[rbp-20]
       call      qword ptr [7FFE94E36988]; System.Text.Json.Utf8JsonWriterCache.RentWriterAndBuffer(System.Text.Json.JsonSerializerOptions, System.Text.Json.PooledByteBufferWriter ByRef)
       mov       [rbp-58],rax
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       short M05_L01
       mov       rcx,rbx
       test      rcx,rcx
       je        short M05_L00
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       je        short M05_L00
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE947743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
M05_L00:
       mov       [rbp-28],rbx
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       mov       r9,rbx
       call      qword ptr [7FFE94CC56E0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       edx,edx
       mov       [rbp-28],rdx
       jmp       short M05_L02
M05_L01:
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       mov       r8,rbx
       mov       r10,[rsi]
       mov       r10,[r10+40]
       call      qword ptr [r10+38]
M05_L02:
       mov       rdx,[rbp-20]
       mov       rcx,[rdx+8]
       mov       esi,[rdx+10]
       test      rcx,rcx
       je        short M05_L07
       cmp       [rcx+8],esi
       jb        short M05_L06
M05_L03:
       xor       ebx,ebx
       xor       edi,edi
       test      rcx,rcx
       je        short M05_L05
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M05_L08
       lea       rbx,[rcx+10]
       mov       edi,[rcx+8]
M05_L04:
       cmp       esi,edi
       ja        short M05_L06
       mov       edi,esi
M05_L05:
       mov       rcx,rbx
       jmp       short M05_L09
M05_L06:
       call      qword ptr [7FFE9492E9A0]
       int       3
M05_L07:
       test      esi,esi
       jne       short M05_L06
       xor       ecx,ecx
       xor       esi,esi
       jmp       short M05_L03
M05_L08:
       lea       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rbx,[rbp-38]
       mov       edi,[rbp-30]
       jmp       short M05_L04
M05_L09:
       mov       [rbp-50],rcx
       mov       [rbp-48],edi
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE94C44378]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-60],rax
       mov       rcx,rsp
       call      M05_L10
       nop
       mov       rax,[rbp-60]
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M05_L10:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       mov       rbx,[rbp-20]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],4
       jl        short M05_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       jne       short M05_L12
M05_L11:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M05_L13
M05_L12:
       mov       rax,[rcx]
       add       rax,10
M05_L13:
       mov       rsi,[rax]
       xor       ecx,ecx
       mov       rdx,[rbp-58]
       mov       [rdx+2C],ecx
       mov       [rdx+20],rcx
       mov       [rdx+38],rcx
       mov       [rdx+40],rcx
       mov       byte ptr [rdx+30],0
       mov       byte ptr [rdx+32],0
       mov       byte ptr [rdx+31],0
       mov       [rdx+28],ecx
       mov       [rdx+48],rcx
       mov       [rdx+50],rcx
       mov       [rdx+58],rcx
       mov       [rdx+10],rcx
       mov       [rdx+18],rcx
       mov       [rdx+8],rcx
       mov       rcx,[rbx+8]
       mov       edi,[rbx+10]
       test      rcx,rcx
       jne       short M05_L14
       test      edi,edi
       jne       short M05_L15
       xor       ecx,ecx
       xor       edi,edi
       jmp       short M05_L17
M05_L14:
       cmp       [rcx+8],edi
       jae       short M05_L16
M05_L15:
       call      qword ptr [7FFE9492E9A0]
       int       3
M05_L16:
       add       rcx,10
M05_L17:
       mov       edx,edi
       mov       [rbp-40],rdx
       test      rdx,rdx
       je        short M05_L19
       cmp       rdx,300
       ja        short M05_L18
       xor       edx,edx
       mov       r8d,[rbp-40]
       call      CORINFO_HELP_MEMSET
       jmp       short M05_L19
M05_L18:
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE94825BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M05_L19:
       xor       ecx,ecx
       mov       [rbx+10],ecx
       mov       rdx,[rbx+8]
       mov       [rbx+8],rcx
       mov       rcx,2084AC01E48
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE94C73580]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 598
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B0]
       cmp       qword ptr [rax+20],0
       je        near ptr M06_L06
       mov       byte ptr [rax+8C],1
       mov       byte ptr [rcx+100],1
       mov       rbx,[rcx+0D8]
       test      rbx,rbx
       jne       near ptr M06_L07
       mov       rbx,[rcx+0B0]
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M06_L05
M06_L00:
       mov       [rbp-20],rax
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M06_L02
       lea       rdx,[rbp-18]
       mov       rcx,rax
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+105],0
       jne       short M06_L03
       mov       rbx,[rcx+0D8]
       test      rbx,rbx
       jne       short M06_L01
       mov       rcx,7FFE9517ED00
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+105],1
       call      qword ptr [7FFE94CC47C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+105],2
       jmp       short M06_L03
M06_L01:
       mov       rcx,7FFE9517ECFC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE95187E88]
       int       3
M06_L02:
       call      qword ptr [7FFE9477E040]
       int       3
M06_L03:
       cmp       byte ptr [rbp-18],0
       je        short M06_L04
       mov       rcx,7FFE9517ED04
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L04:
       mov       rcx,7FFE9517ED08
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE9517ED0C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE94CC4B10]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rax,rcx
       jmp       near ptr M06_L00
M06_L06:
       call      qword ptr [7FFE94D2CBD0]
       int       3
M06_L07:
       mov       rcx,7FFE9517ECF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE95187E88]
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,rdx
       call      qword ptr [7FFE95187E58]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0D8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+105],0
       call      CORINFO_HELP_RETHROW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M06_L08
       mov       rcx,7FFE9517ED04
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L08:
       mov       rcx,7FFE9517ED08
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 492
```
**Extern method**
System.Object.GetType()
System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_JsonSerializer_Generator_Person()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+40]
       mov       rcx,1C267805500
       mov       rdi,[rcx]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdx,rax
       mov       rcx,202F9692928
       cmp       [rcx],ecx
       call      qword ptr [7FFE9469A7B0]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       je        near ptr M00_L04
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FFE94D07EB8]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       cmp       [rbp],bpl
       mov       rcx,202F9692928
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,0F
       je        near ptr M00_L07
       mov       rcx,202F9692928
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,10
       je        near ptr M00_L07
       mov       rcx,202F9692928
       call      System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L07
       mov       rcx,202F9692928
       call      qword ptr [7FFE946A60B8]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L05
       test      rcx,rcx
       je        near ptr M00_L06
M00_L01:
       call      System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)
       test      eax,eax
       jne       near ptr M00_L07
       mov       rcx,rbp
       mov       byte ptr [rsp+38],0
       mov       byte ptr [rsp+39],0
       mov       dword ptr [rsp+20],1
       xor       edx,edx
       mov       [rsp+28],edx
       mov       rdx,202F9692928
       movzx     r9d,word ptr [rsp+38]
       mov       r8d,1
       call      qword ptr [7FFE94BF4048]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L08
       cmp       byte ptr [rbp+105],2
       jne       short M00_L03
M00_L02:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFE94BFD668]; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       [rsp+40],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFE94CA4AE0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M00_L02
M00_L04:
       mov       rcx,202F9692928
       mov       rdx,rsi
       call      qword ptr [7FFE94D0C990]
       int       3
M00_L05:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L01
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94C2EAD8]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE94936670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L07:
       mov       ecx,352A
       mov       rdx,7FFE94BD1910
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,202F9692928
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE94D0CB58]
       int       3
M00_L08:
       mov       rcx,202F9692928
       mov       rdx,rdi
       call      qword ptr [7FFE94D0D1E8]
       int       3
; Total bytes of code 518
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
       call      qword ptr [7FFE94754360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE94754360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE946A4E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L04
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE946A6148]
M01_L04:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        near ptr M01_L01
       mov       rcx,rsi
       call      qword ptr [7FFE9469A5A0]; Precode of System.RuntimeType.GetGenericParameterConstraints()
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
       call      qword ptr [7FFE94BF4180]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE94BF4210]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE94BF4630]
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
       cmp       byte ptr [rsi+8C],0
       je        near ptr M04_L12
       mov       r13,[rsi+8]
       test      r13,r13
       je        near ptr M04_L10
M04_L00:
       mov       r15,[r13+8]
       mov       rcx,1C26F801208
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M04_L14
M04_L01:
       cmp       [r15],r15b
       test      rbx,rbx
       je        near ptr M04_L17
       test      r12,r12
       je        near ptr M04_L11
       mov       rax,[r15+8]
       mov       [rbp-58],rax
       mov       rcx,[rax+8]
       cmp       byte ptr [r15+15],0
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
       call      qword ptr [7FFE94B0F948]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M04_L03
       mov       edx,[rbp-3C]
       mov       rax,[rbp-58]
       mov       [rbp-60],rax
       mov       byte ptr [rbp-50],1
       mov       [rbp-4C],edx
       mov       rdx,rbx
       mov       r8,r13
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-48]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,[rbp-60]
       mov       r8,rbx
       mov       r9,[rbp-50]
       mov       rcx,r15
       call      qword ptr [7FFE94B0FA38]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M04_L03:
       mov       r8,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r14b,r14b
       jne       near ptr M04_L15
M04_L04:
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M04_L16
       mov       r15,[r8+8]
M04_L05:
       test      dil,dil
       je        short M04_L06
       test      r15,r15
       je        short M04_L06
       cmp       byte ptr [r15+105],2
       jne       short M04_L09
M04_L06:
       test      r15,r15
       je        near ptr M04_L13
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
       mov       r11,7FFE94610C18
       call      qword ptr [r11]
       jmp       near ptr M04_L02
M04_L09:
       mov       rcx,r15
       call      qword ptr [7FFE94CA4AE0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M04_L06
M04_L10:
       mov       rcx,rsi
       call      qword ptr [7FFE94CA4B10]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r13,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L00
M04_L11:
       mov       ecx,0BB4
       mov       rdx,7FFE94B2B2D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D07D08]
       int       3
M04_L12:
       cmp       byte ptr [rbp+30],0
       je        short M04_L06
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE94BF4678]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r15,rax
       jmp       near ptr M04_L06
M04_L13:
       movzx     edx,byte ptr [rbp+28]
       movzx     ecx,byte ptr [rbp+29]
       cmp       cl,1
       sete      cl
       movzx     ecx,cl
       test      edx,ecx
       je        near ptr M04_L07
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FFE94D0D1A0]
       int       3
M04_L14:
       mov       rcx,offset MT_System.Func`3[[System.Type, System.Private.CoreLib],[System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json],[System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry, System.Text.Json]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFE9460D0E0
       call      qword ptr [7FFE94754258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1C26F801208
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L01
M04_L15:
       cmp       byte ptr [r8+20],0
       jne       near ptr M04_L04
       mov       rcx,r13
       mov       rdx,rbx
       call      qword ptr [7FFE94CA4C30]
       mov       r15,rax
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFE95157390]
       int       3
M04_L17:
       mov       ecx,1
       mov       rdx,7FFE94B2B2D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE94D07D08]
       int       3
; Total bytes of code 664
```
```assembly
; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-70],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rsi+0B0]
       lea       rdx,[rbp-20]
       call      qword ptr [7FFE94E16988]; System.Text.Json.Utf8JsonWriterCache.RentWriterAndBuffer(System.Text.Json.JsonSerializerOptions, System.Text.Json.PooledByteBufferWriter ByRef)
       mov       rdx,rax
       mov       [rbp-58],rdx
       mov       r8,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],r8
       jne       short M05_L01
       mov       rcx,rsi
       mov       r8,rbx
       test      r8,r8
       je        short M05_L00
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [r8],rax
       jne       short M05_L08
M05_L00:
       mov       [rbp-28],rbx
       lea       r8,[rbp-28]
       mov       r9,rbx
       call      qword ptr [7FFE94CA56E0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       edx,edx
       mov       [rbp-28],rdx
       jmp       short M05_L02
M05_L01:
       mov       rcx,rsi
       mov       r8,rbx
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M05_L02:
       mov       rdx,[rbp-20]
       mov       rcx,[rdx+8]
       mov       edi,[rdx+10]
       test      rcx,rcx
       je        short M05_L07
       cmp       [rcx+8],edi
       jb        short M05_L06
M05_L03:
       xor       ebx,ebx
       xor       esi,esi
       test      rcx,rcx
       je        short M05_L05
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M05_L09
       lea       rbx,[rcx+10]
       mov       esi,[rcx+8]
M05_L04:
       cmp       edi,esi
       ja        short M05_L06
       mov       esi,edi
M05_L05:
       mov       rcx,rbx
       jmp       short M05_L10
M05_L06:
       call      qword ptr [7FFE9490E9A0]
       int       3
M05_L07:
       test      edi,edi
       jne       short M05_L06
       xor       ecx,ecx
       xor       edi,edi
       jmp       short M05_L03
M05_L08:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE947543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M05_L09:
       lea       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rbx,[rbp-38]
       mov       esi,[rbp-30]
       jmp       short M05_L04
M05_L10:
       mov       [rbp-50],rcx
       mov       [rbp-48],esi
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE94C24378]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-60],rax
       mov       rcx,rsp
       call      M05_L11
       nop
       mov       rax,[rbp-60]
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M05_L11:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       mov       rbx,[rbp-20]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],4
       jl        short M05_L12
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       jne       short M05_L13
M05_L12:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M05_L14
M05_L13:
       mov       rax,[rcx]
       add       rax,10
M05_L14:
       mov       rsi,[rax]
       xor       ecx,ecx
       mov       rdx,[rbp-58]
       mov       [rdx+2C],ecx
       mov       [rdx+20],rcx
       mov       [rdx+38],rcx
       mov       [rdx+40],rcx
       mov       byte ptr [rdx+30],0
       mov       byte ptr [rdx+32],0
       mov       byte ptr [rdx+31],0
       mov       [rdx+28],ecx
       mov       [rdx+48],rcx
       mov       [rdx+50],rcx
       mov       [rdx+58],rcx
       mov       [rdx+10],rcx
       mov       [rdx+18],rcx
       mov       [rdx+8],rcx
       mov       rcx,[rbx+8]
       mov       edi,[rbx+10]
       test      rcx,rcx
       jne       short M05_L15
       test      edi,edi
       jne       short M05_L16
       xor       ecx,ecx
       xor       edi,edi
       jmp       short M05_L18
M05_L15:
       cmp       [rcx+8],edi
       jae       short M05_L17
M05_L16:
       call      qword ptr [7FFE9490E9A0]
       int       3
M05_L17:
       add       rcx,10
M05_L18:
       mov       edx,edi
       mov       [rbp-40],rdx
       test      rdx,rdx
       je        short M05_L20
       cmp       rdx,300
       ja        short M05_L19
       xor       edx,edx
       mov       r8d,[rbp-40]
       call      CORINFO_HELP_MEMSET
       jmp       short M05_L20
M05_L19:
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE94805BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M05_L20:
       xor       ecx,ecx
       mov       [rbx+10],ecx
       mov       rdx,[rbx+8]
       mov       [rbx+8],rcx
       mov       rcx,1C267801E48
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE94C53580]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 593
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B0]
       cmp       qword ptr [rax+20],0
       je        near ptr M06_L06
       mov       byte ptr [rax+8C],1
       mov       byte ptr [rcx+100],1
       mov       rbx,[rcx+0D8]
       test      rbx,rbx
       jne       near ptr M06_L07
       mov       rbx,[rcx+0B0]
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M06_L05
M06_L00:
       mov       [rbp-20],rax
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M06_L02
       lea       rdx,[rbp-18]
       mov       rcx,rax
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+105],0
       jne       short M06_L03
       mov       rbx,[rcx+0D8]
       test      rbx,rbx
       jne       short M06_L01
       mov       rcx,7FFE9516AF80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+105],1
       call      qword ptr [7FFE94CA47C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+105],2
       jmp       short M06_L03
M06_L01:
       mov       rcx,7FFE9516AF7C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE95157390]
       int       3
M06_L02:
       call      qword ptr [7FFE9475E040]
       int       3
M06_L03:
       cmp       byte ptr [rbp-18],0
       je        short M06_L04
       mov       rcx,7FFE9516AF84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L04:
       mov       rcx,7FFE9516AF88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE9516AF8C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE94CA4B10]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rax,rcx
       jmp       near ptr M06_L00
M06_L06:
       call      qword ptr [7FFE94D0CBD0]
       int       3
M06_L07:
       mov       rcx,7FFE9516AF78
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE95157390]
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,rdx
       call      qword ptr [7FFE95157360]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0D8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+105],0
       call      CORINFO_HELP_RETHROW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M06_L08
       mov       rcx,7FFE9516AF84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L08:
       mov       rcx,7FFE9516AF88
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 492
```
**Extern method**
System.Object.GetType()
System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
System.RuntimeTypeHandle.IsByRefLike(System.RuntimeType)
System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Ref_Person()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rax,[rbx+40]
       test      rax,rax
       je        near ptr M00_L03
       mov       [rsp+38],rax
       call      qword ptr [7FFE94C04168]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rsi,rax
       cmp       byte ptr [rsi+8D],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE94C04660]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE94C040A8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE94E1CD68]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+30],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M00_L01
       mov       rdx,rax
       call      qword ptr [7FFE947643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FFE94C0C348]
       mov       rcx,24791F02730
       mov       rdx,24791F00210
       call      qword ptr [7FFE94766B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24791F00008
       call      qword ptr [7FFE94766B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L05
M00_L04:
       mov       ecx,1
M00_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L06
       call      qword ptr [7FFE94C0C468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE94A47DB0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A47DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94C07A68]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94C0C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE94C0C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE94946670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE94767318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94C0C060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE94946670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 456
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       sub       rsp,28
       mov       rax,207000051D8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFE94C04708]; System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
       jmp       short M01_L00
; Total bytes of code 35
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFF47735068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M02_L03
       call      qword ptr [7FFF47739F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M02_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
M02_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       call      qword ptr [7FFF477369F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M02_L00
       call      qword ptr [7FFF47735060]
       cmp       byte ptr [rax+18E],0
       je        short M02_L00
       mov       ecx,2
       call      qword ptr [7FFF47736948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF47739FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M02_L00
       cmp       [rsi+10],rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M02_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF47739198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M02_L00
M02_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFF47734820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M02_L00
M02_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L04
       call      qword ptr [7FFF47736A08]
       test      rax,rax
       je        near ptr M02_L00
M02_L04:
       call      qword ptr [7FFF477384A0]
       int       3
; Total bytes of code 272
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
       mov       rdx,24791F02D10
       mov       r8d,1
       call      qword ptr [7FFE94C04048]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rax
       mov       [rbp-60],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,[rbx+0B0]
       lea       rdx,[rbp-20]
       call      qword ptr [7FFE94E1CD98]; System.Text.Json.Utf8JsonWriterCache.RentWriterAndBuffer(System.Text.Json.JsonSerializerOptions, System.Text.Json.PooledByteBufferWriter ByRef)
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE94CB56E0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rdx,[rbp-20]
       mov       rcx,[rdx+8]
       mov       ebx,[rdx+10]
       test      rcx,rcx
       je        short M04_L04
       cmp       [rcx+8],ebx
       jb        short M04_L03
M04_L00:
       xor       esi,esi
       xor       edi,edi
       test      rcx,rcx
       je        short M04_L02
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M04_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
M04_L01:
       cmp       ebx,edi
       ja        short M04_L03
       mov       edi,ebx
M04_L02:
       mov       rcx,rsi
       jmp       short M04_L06
M04_L03:
       call      qword ptr [7FFE9491E9A0]
       int       3
M04_L04:
       test      ebx,ebx
       jne       short M04_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M04_L00
M04_L05:
       lea       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,[rbp-30]
       mov       edi,[rbp-28]
       jmp       short M04_L01
M04_L06:
       mov       [rbp-48],rcx
       mov       [rbp-40],edi
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE94C34378]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M04_L07
       nop
       mov       rax,[rbp-58]
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L07:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-20]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],4
       jl        short M04_L08
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       jne       short M04_L09
M04_L08:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M04_L10
M04_L09:
       mov       rax,[rcx]
       add       rax,10
M04_L10:
       mov       rsi,[rax]
       xor       ecx,ecx
       mov       rdx,[rbp-50]
       mov       [rdx+2C],ecx
       mov       [rdx+20],rcx
       mov       [rdx+38],rcx
       mov       [rdx+40],rcx
       mov       byte ptr [rdx+30],0
       mov       byte ptr [rdx+32],0
       mov       byte ptr [rdx+31],0
       mov       [rdx+28],ecx
       mov       [rdx+48],rcx
       mov       [rdx+50],rcx
       mov       [rdx+58],rcx
       mov       [rdx+10],rcx
       mov       [rdx+18],rcx
       mov       [rdx+8],rcx
       mov       rcx,[rbx+8]
       mov       edi,[rbx+10]
       test      rcx,rcx
       jne       short M04_L11
       test      edi,edi
       jne       short M04_L12
       xor       ecx,ecx
       xor       edi,edi
       jmp       short M04_L14
M04_L11:
       cmp       [rcx+8],edi
       jae       short M04_L13
M04_L12:
       call      qword ptr [7FFE9491E9A0]
       int       3
M04_L13:
       add       rcx,10
M04_L14:
       mov       edx,edi
       mov       [rbp-38],rdx
       test      rdx,rdx
       je        short M04_L16
       cmp       rdx,300
       ja        short M04_L15
       xor       edx,edx
       mov       r8d,[rbp-38]
       call      CORINFO_HELP_MEMSET
       jmp       short M04_L16
M04_L15:
       mov       rdx,[rbp-38]
       call      qword ptr [7FFE94815BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M04_L16:
       xor       ecx,ecx
       mov       [rbx+10],ecx
       mov       rdx,[rbx+8]
       mov       [rbx+8],rcx
       mov       rcx,20704001E48
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE94C63580]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 512
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
       jne       short M05_L03
M05_L01:
       mov       rax,rdx
       ret
M05_L02:
       jmp       qword ptr [7FFE947643A8]
M05_L03:
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
       call      qword ptr [7FFE94815B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE94815B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE9491EF10]
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
       mov       rax,24791F00008
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
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M07_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M07_L00
       mov       rax,[7FFEF411E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M07_L04
       jmp       short M07_L01
M07_L00:
       call      qword ptr [7FFEF4105318]; Precode of System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M07_L04
M07_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M07_L02
       mov       rax,[7FFEF411E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M07_L04
       jmp       short M07_L03
M07_L02:
       call      qword ptr [7FFEF4105318]; Precode of System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M07_L04
M07_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFEF4101480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_PersonRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rax,[rbx+38]
       test      rax,rax
       je        near ptr M00_L03
       mov       [rsp+38],rax
       call      qword ptr [7FFE94BE4168]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rsi,rax
       cmp       byte ptr [rsi+8D],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE94BE4660]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE94BE40A8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE94E06958]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+30],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M00_L01
       mov       rdx,rax
       call      qword ptr [7FFE947443F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FFE94BEC348]
       mov       rcx,223C5F12730
       mov       rdx,223C5F10210
       call      qword ptr [7FFE94746B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,223C5F10008
       call      qword ptr [7FFE94746B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L05
M00_L04:
       mov       ecx,1
M00_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L06
       call      qword ptr [7FFE94BEC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE94A27DB0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A27DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94BE7A68]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94BEC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE94BEC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE94926670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE94747318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94BEC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE94926670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 456
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       sub       rsp,28
       mov       rax,1E3340071D0
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFE94BE4708]; System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
       jmp       short M01_L00
; Total bytes of code 35
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFF47735068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M02_L03
       call      qword ptr [7FFF47739F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M02_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
M02_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       call      qword ptr [7FFF477369F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M02_L00
       call      qword ptr [7FFF47735060]
       cmp       byte ptr [rax+18E],0
       je        short M02_L00
       mov       ecx,2
       call      qword ptr [7FFF47736948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF47739FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFF47734FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M02_L00
       cmp       [rsi+10],rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M02_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF47739198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M02_L00
M02_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFF47734820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M02_L00
M02_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L04
       call      qword ptr [7FFF47736A08]
       test      rax,rax
       je        near ptr M02_L00
M02_L04:
       call      qword ptr [7FFF477384A0]
       int       3
; Total bytes of code 272
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
       mov       rdx,223C5F12D10
       mov       r8d,1
       call      qword ptr [7FFE94BE4048]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rax
       mov       [rbp-60],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,[rbx+0B0]
       lea       rdx,[rbp-20]
       call      qword ptr [7FFE94E06988]; System.Text.Json.Utf8JsonWriterCache.RentWriterAndBuffer(System.Text.Json.JsonSerializerOptions, System.Text.Json.PooledByteBufferWriter ByRef)
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE94C956E0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rdx,[rbp-20]
       mov       rcx,[rdx+8]
       mov       ebx,[rdx+10]
       test      rcx,rcx
       je        short M04_L04
       cmp       [rcx+8],ebx
       jb        short M04_L03
M04_L00:
       xor       esi,esi
       xor       edi,edi
       test      rcx,rcx
       je        short M04_L02
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M04_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
M04_L01:
       cmp       ebx,edi
       ja        short M04_L03
       mov       edi,ebx
M04_L02:
       mov       rcx,rsi
       jmp       short M04_L06
M04_L03:
       call      qword ptr [7FFE948FE9A0]
       int       3
M04_L04:
       test      ebx,ebx
       jne       short M04_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M04_L00
M04_L05:
       lea       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,[rbp-30]
       mov       edi,[rbp-28]
       jmp       short M04_L01
M04_L06:
       mov       [rbp-48],rcx
       mov       [rbp-40],edi
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE94C14378]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M04_L07
       nop
       mov       rax,[rbp-58]
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L07:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-20]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],4
       jl        short M04_L08
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       jne       short M04_L09
M04_L08:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M04_L10
M04_L09:
       mov       rax,[rcx]
       add       rax,10
M04_L10:
       mov       rsi,[rax]
       xor       ecx,ecx
       mov       rdx,[rbp-50]
       mov       [rdx+2C],ecx
       mov       [rdx+20],rcx
       mov       [rdx+38],rcx
       mov       [rdx+40],rcx
       mov       byte ptr [rdx+30],0
       mov       byte ptr [rdx+32],0
       mov       byte ptr [rdx+31],0
       mov       [rdx+28],ecx
       mov       [rdx+48],rcx
       mov       [rdx+50],rcx
       mov       [rdx+58],rcx
       mov       [rdx+10],rcx
       mov       [rdx+18],rcx
       mov       [rdx+8],rcx
       mov       rcx,[rbx+8]
       mov       edi,[rbx+10]
       test      rcx,rcx
       jne       short M04_L11
       test      edi,edi
       jne       short M04_L12
       xor       ecx,ecx
       xor       edi,edi
       jmp       short M04_L14
M04_L11:
       cmp       [rcx+8],edi
       jae       short M04_L13
M04_L12:
       call      qword ptr [7FFE948FE9A0]
       int       3
M04_L13:
       add       rcx,10
M04_L14:
       mov       edx,edi
       mov       [rbp-38],rdx
       test      rdx,rdx
       je        short M04_L16
       cmp       rdx,300
       ja        short M04_L15
       xor       edx,edx
       mov       r8d,[rbp-38]
       call      CORINFO_HELP_MEMSET
       jmp       short M04_L16
M04_L15:
       mov       rdx,[rbp-38]
       call      qword ptr [7FFE947F5BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M04_L16:
       xor       ecx,ecx
       mov       [rbx+10],ecx
       mov       rdx,[rbx+8]
       mov       [rbx+8],rcx
       mov       rcx,1E334001E48
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE94C43580]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 512
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
       jne       short M05_L03
M05_L01:
       mov       rax,rdx
       ret
M05_L02:
       jmp       qword ptr [7FFE947443A8]
M05_L03:
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
       call      qword ptr [7FFE947F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE947F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE948FEF10]
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
       mov       rax,223C5F10008
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
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M07_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M07_L00
       mov       rax,[7FFEF411E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M07_L04
       jmp       short M07_L01
M07_L00:
       call      qword ptr [7FFEF4105318]; Precode of System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M07_L04
M07_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M07_L02
       mov       rax,[7FFEF411E6E0]
       test      byte ptr [rax+rcx],80
       jne       short M07_L04
       jmp       short M07_L03
M07_L02:
       call      qword ptr [7FFEF4105318]; Precode of System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M07_L04
M07_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFEF4101480]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Person_List()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FFE94B5FD68]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       je        short M01_L02
       mov       [rsp+28],rcx
       call      qword ptr [7FFE94C04168]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rbx,rax
       cmp       byte ptr [rbx+8D],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FFE94C04660]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFE94C040A8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L06
M01_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE94E26958]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FFE94C0C348]
       mov       rcx,253FFFD2730
       mov       rdx,253FFFD0210
       call      qword ptr [7FFE94766B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,253FFFD0008
       call      qword ptr [7FFE94766B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L04
M01_L03:
       mov       ecx,1
M01_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L05
       call      qword ptr [7FFE94C0C468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE94A47DB0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A47DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94C07A68]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94C0C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE94C0C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE94946670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE94767318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94C0C060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE94946670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rdx,rax
       call      qword ptr [7FFE947643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 415
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_XML_Ref_Person()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       call      qword ptr [7FFE94BA43F0]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
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
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L16
       mov       rax,[rcx]
       add       rax,10
M01_L00:
       mov       r14,[rax+8]
       test      r14,r14
       jne       short M01_L01
       mov       rcx,1E937C00438
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L01
       mov       rcx,1E937C00418
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L17
M01_L01:
       mov       rcx,1E937C014E0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,229C5A31C08
       mov       [rsi+10],rcx
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+28],1
       mov       [rbp-30],rsi
       mov       rcx,1E933C06138
       mov       r14,[rcx]
       mov       rcx,offset MT_System.Xml.XmlEncodedRawTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFE94EBF648]; System.Xml.XmlEncodedRawTextWriter..ctor(System.Xml.XmlWriterSettings)
       lea       rcx,[r15+48]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E937C014A0
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
       call      qword ptr [7FFE94EE40F0]; System.Xml.XmlWellFormedWriter..ctor(System.Xml.XmlWriter, System.Xml.XmlWriterSettings)
       mov       [rbp-38],rdi
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [7FFE94EBEAD8]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,r14
       mov       rdx,[rbp-38]
       mov       r8,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE94EBEC10]; System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE949CB060]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       rdx,[rbp-38]
       mov       rcx,rdx
       mov       eax,[rcx+78]
       cmp       eax,10
       jg        near ptr M01_L10
       mov       rdx,1E933C060C8
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
       call      qword ptr [7FFE94ED85E0]; System.Xml.XmlEncodedRawTextWriter.WriteXmlDeclaration(System.Xml.XmlStandalone)
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
       call      qword ptr [7FFE94C1ED60]
       mov       rcx,1E937C014A0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       jmp       near ptr M01_L02
M01_L09:
       cmp       edi,5
       je        short M01_L11
M01_L10:
       call      qword ptr [7FFE94ED9588]; System.Xml.XmlWellFormedWriter.Close()
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
       call      qword ptr [7FFE94C1C348]
       mov       rcx,229C5A32730
       mov       rdx,229C5A30210
       call      qword ptr [7FFE94776B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,229C5A30008
       call      qword ptr [7FFE94776B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FFE94C1C468]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFE94A57D58
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A57D58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94C17A68]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94C1C060]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE94C1C5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE94956670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE94777318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94C1C060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE94956670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L00
M01_L17:
       call      qword ptr [7FFE948E4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       jg        short M01_L20
       mov       rax,1E933C060C8
       mov       rax,[rax]
       mov       edx,[rcx+78]
       cmp       edx,11
       jae       short M01_L18
       mov       edi,[rax+rdx*4+10]
       jmp       short M01_L19
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L19:
       cmp       edi,5
       je        short M01_L21
M01_L20:
       call      qword ptr [7FFE94ED9588]; System.Xml.XmlWellFormedWriter.Close()
M01_L21:
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
; Total bytes of code 1207
```

