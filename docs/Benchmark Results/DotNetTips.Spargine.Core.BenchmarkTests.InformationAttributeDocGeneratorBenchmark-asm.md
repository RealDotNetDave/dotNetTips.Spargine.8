## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.InformationAttributeDocGeneratorBenchmark.GenerateMarkdownDocumentForAssembly()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,298D83F3B88
       call      qword ptr [7FF94CCDC000]; System.Reflection.Assembly.Load(System.String)
       mov       rcx,rax
       call      qword ptr [7FF94D40C870]; DotNetTips.Spargine.Core.InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(System.Reflection.Assembly)
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
; System.Reflection.Assembly.Load(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       dword ptr [rsp+28],1
       call      qword ptr [7FF94CC162E0]; System.Runtime.Loader.AssemblyLoadContext.get_CurrentContextualReflectionContext()
       mov       rsi,rax
       mov       rcx,offset MT_System.Reflection.AssemblyName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF94CF55908]; System.Reflection.AssemblyName..ctor(System.String)
       mov       dword ptr [rsp+20],1
       lea       rdx,[rsp+28]
       mov       rcx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF94CDADD88]; System.Reflection.RuntimeAssembly.InternalLoad(System.Reflection.AssemblyName, System.Threading.StackCrawlMark ByRef, System.Runtime.Loader.AssemblyLoadContext, System.Reflection.RuntimeAssembly, Boolean)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Core.InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(System.Reflection.Assembly)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       [rbp-0E0],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L67
       mov       rcx,25846408B08
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M02_L68
       mov       rcx,[rcx+18]
M02_L01:
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M02_L71
       mov       rcx,[rsi+20]
       mov       [rbp-88],rcx
       cmp       qword ptr [rbp-88],0
       je        near ptr M02_L69
       lea       rcx,[rsi+20]
       mov       r8,[rbp-88]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       jne       near ptr M02_L69
M02_L02:
       mov       rdi,[rbp-88]
M02_L03:
       xor       ecx,ecx
       mov       [rbp-88],rcx
M02_L04:
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF94CDFC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-0C0],rdi
       mov       r14,rdi
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M02_L08
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L08
       mov       r15,[rcx]
       add       r15,10
M02_L05:
       mov       rcx,[r15+8]
       test      rcx,rcx
       jne       short M02_L06
       mov       rcx,25846400438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M02_L06
       mov       rcx,25846400418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M02_L07
M02_L06:
       mov       [rbp-68],r14
       mov       [rbp-60],rcx
       lea       r13,[rbp-68]
       test      rcx,rcx
       je        near ptr M02_L12
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        near ptr M02_L27
       mov       r11,7FF94CA20B10
       mov       rdx,298D83F49B8
       call      qword ptr [r11]
       test      rax,rax
       setne     al
       movzx     eax,al
       jmp       near ptr M02_L28
M02_L07:
       call      qword ptr [7FF94CD04030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       short M02_L06
M02_L08:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r15,rax
       jmp       near ptr M02_L05
M02_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L56
M02_L10:
       lea       rcx,[rbp-50]
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FF94D40CA50]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       jmp       near ptr M02_L41
M02_L11:
       mov       ecx,0C
       call      qword ptr [7FF94CD84F30]
       int       3
M02_L12:
       xor       eax,eax
       jmp       near ptr M02_L28
M02_L13:
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       r12,rax
       jmp       near ptr M02_L50
M02_L14:
       mov       rcx,7FF94CC9A1C8
       mov       edx,4
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,258464055D0
       mov       r12,[rdx]
       jmp       near ptr M02_L50
M02_L15:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      qword ptr [7FF94CB64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M02_L16
       mov       rcx,offset MT_System.Linq.Enumerable+WhereListIterator`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,r12
       mov       r8,r13
       call      qword ptr [7FF94CF57C90]
       mov       r12,r14
       jmp       near ptr M02_L50
M02_L16:
       mov       rcx,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,r14
       mov       r8,r13
       call      qword ptr [7FF94D4D7C90]
       jmp       near ptr M02_L50
M02_L17:
       mov       ecx,10
       call      qword ptr [7FF94CD84F30]
       int       3
M02_L18:
       mov       rdx,r12
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Type, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type>)
       call      qword ptr [7FF94D4F6070]
       mov       r13,rax
       jmp       near ptr M02_L51
M02_L19:
       call      qword ptr [7FF94CD04030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M02_L53
M02_L20:
       xor       eax,eax
       jmp       near ptr M02_L54
M02_L21:
       call      qword ptr [7FF94CDF5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rsi,rax
       jmp       near ptr M02_L33
M02_L22:
       lea       rcx,[rbp-50]
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF94D40EA30]
       jmp       near ptr M02_L35
M02_L23:
       or        r14d,r15d
       jne       short M02_L24
       xor       r13d,r13d
       xor       r15d,r15d
       jmp       near ptr M02_L34
M02_L24:
       call      qword ptr [7FF94CD5E9D0]
       int       3
M02_L25:
       call      qword ptr [7FF94CD5F168]
       int       3
M02_L26:
       lea       rcx,[rbp-50]
       mov       rdx,rsi
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF94D40EA00]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.DateTime, System.Private.CoreLib]](System.DateTime, Int32, System.String)
       jmp       near ptr M02_L35
M02_L27:
       xor       eax,eax
M02_L28:
       mov       [r13+10],al
       vmovdqu   xmm0,xmmword ptr [rbp-68]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-58]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-50]
       mov       rdx,298D83F3BF4
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2]
       cmp       [r8+8],r10d
       jb        near ptr M02_L32
       movsxd    rdx,eax
       lea       rdx,[r8+rdx*2+10]
       mov       word ptr [rdx],23
       mov       word ptr [rdx+2],20
       add       eax,2
       mov       [rcx+18],eax
M02_L29:
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rbx],rcx
       jne       short M02_L30
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF94CD9BBB0]; System.Reflection.RuntimeAssembly.GetName(Boolean)
       jmp       short M02_L31
M02_L30:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
M02_L31:
       mov       r8,[rax+8]
       cmp       byte ptr [rbp-40],0
       jne       near ptr M02_L10
       mov       rsi,[rbp-50]
       cmp       [rsi],sil
       test      r8,r8
       je        near ptr M02_L41
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        near ptr M02_L41
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M02_L40
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jg        near ptr M02_L38
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       near ptr M02_L39
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M02_L39
M02_L32:
       mov       r8d,2
       call      qword ptr [7FF94CDFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M02_L29
M02_L33:
       cmp       byte ptr [rbp-40],0
       jne       near ptr M02_L22
       mov       rcx,[rbp-50]
       mov       rdx,[rcx+8]
       mov       r9,rdx
       mov       ecx,[rcx+18]
       mov       r14d,ecx
       mov       r15d,[rdx+8]
       sub       r15d,ecx
       test      r9,r9
       je        near ptr M02_L23
       mov       ecx,r14d
       mov       edx,r15d
       add       rcx,rdx
       mov       edx,[r9+8]
       cmp       rcx,rdx
       ja        near ptr M02_L24
       cmp       [r9],r9b
       mov       ecx,r14d
       lea       r13,[r9+rcx*2+10]
M02_L34:
       xor       ecx,ecx
       mov       rdx,[rbp-48]
       mov       [rbp-0A8],r13
       mov       [rbp-0A0],r15d
       mov       [rbp-0B8],rcx
       xor       ecx,ecx
       mov       [rbp-0B0],ecx
       mov       [rsp+20],rdx
       mov       rcx,8000000000000000
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       rdx,[rbp-0A8]
       lea       r9,[rbp-0B8]
       lea       r8,[rbp-98]
       call      qword ptr [7FF94D40EDA8]; System.DateTimeFormat.TryFormat[[System.Char, System.Private.CoreLib]](System.DateTime, System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.TimeSpan)
       test      eax,eax
       je        near ptr M02_L26
       cmp       [rbp-98],r15d
       ja        near ptr M02_L25
       mov       rcx,[rbp-50]
       mov       edx,[rbp-98]
       add       [rcx+18],edx
M02_L35:
       mov       rcx,[rbp-50]
       mov       rdx,298D83F3CC4
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+6]
       cmp       [r8+8],r10d
       jb        near ptr M02_L64
       cmp       [r8],r8b
       movsxd    r10,eax
       lea       r8,[r8+r10*2+10]
       mov       r9,[rdx]
       mov       r10,[rdx+4]
       mov       [r8],r9
       mov       [r8+4],r10
       add       eax,6
       mov       [rcx+18],eax
M02_L36:
       mov       rsi,[rbp-0D8]
       mov       rdx,rsi
       mov       r14,[rbp-0C8]
       mov       rcx,[r14+8]
       mov       r8d,[r14+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        near ptr M02_L65
       cmp       [rcx],cl
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       add       r8d,2
       mov       [r14+18],r8d
M02_L37:
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FF94CDEE3F0]; System.Text.StringBuilder.ToString()
       mov       [rbp-0D0],rax
       jmp       near ptr M02_L66
M02_L38:
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L39:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M02_L41
M02_L40:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FF94CDFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L41:
       mov       rcx,[rbp-50]
       mov       rdx,298D83F3C14
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+3]
       cmp       [r8+8],r10d
       jb        near ptr M02_L60
       movsxd    r10,eax
       lea       r8,[r8+r10*2+10]
       mov       r9d,[rdx]
       mov       r10d,[rdx+2]
       mov       [r8],r9d
       mov       [r8+2],r10d
       add       eax,3
       mov       [rcx+18],eax
M02_L42:
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rbx],rcx
       jne       short M02_L43
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF94CD9BBB0]; System.Reflection.RuntimeAssembly.GetName(Boolean)
       jmp       short M02_L44
M02_L43:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
M02_L44:
       mov       r8,[rax+30]
       lea       rcx,[rbp-50]
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Version, System.Private.CoreLib]](System.Version)
       call      qword ptr [7FF94D40CA50]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rsi,298D83E1C14
       mov       [rbp-0D8],rsi
       mov       rdx,rsi
       mov       rcx,[r14+8]
       mov       r8d,[r14+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        near ptr M02_L61
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       add       r8d,2
       mov       [r14+18],r8d
M02_L45:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        near ptr M02_L62
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       add       r8d,2
       mov       [rdi+18],r8d
M02_L46:
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rbx],rcx
       jne       short M02_L47
       mov       rcx,rbx
       call      qword ptr [7FF94CC9E110]; System.Reflection.Assembly.GetTypes()
       mov       r14,rax
       jmp       short M02_L48
M02_L47:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14,rax
M02_L48:
       mov       rcx,25846408CE0
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M02_L58
M02_L49:
       test      r14,r14
       je        near ptr M02_L17
       test      r13,r13
       je        near ptr M02_L11
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator`1[[System.Type, System.Private.CoreLib]]
       call      qword ptr [7FF94CB64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L13
       mov       rdx,r14
       mov       rcx,offset MT_System.Type[]
       call      qword ptr [7FF94CB64330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M02_L15
       cmp       dword ptr [rbx+8],0
       je        near ptr M02_L14
       mov       rcx,offset MT_System.Linq.Enumerable+WhereArrayIterator`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r12+10],eax
       lea       rcx,[r12+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M02_L50:
       test      r12,r12
       je        near ptr M02_L17
       mov       rdx,r12
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Type, System.Private.CoreLib]]
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L18
       mov       rcx,rax
       mov       r11,7FF94CA20B18
       call      qword ptr [r11]
       mov       r13,rax
M02_L51:
       xor       r12d,r12d
       cmp       dword ptr [r13+8],0
       jg        near ptr M02_L57
M02_L52:
       mov       r14,rdi
       mov       rcx,[r15+8]
       test      rcx,rcx
       jne       short M02_L53
       mov       rcx,25846400438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M02_L53
       mov       rcx,25846400418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M02_L19
M02_L53:
       mov       [rbp-0C8],r14
       mov       [rbp-80],r14
       mov       [rbp-78],rcx
       lea       rbx,[rbp-80]
       test      rcx,rcx
       je        near ptr M02_L20
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        near ptr M02_L59
       mov       r11,7FF94CA20B20
       mov       rdx,298D83F49B8
       call      qword ptr [r11]
       test      rax,rax
       setne     al
       movzx     eax,al
M02_L54:
       mov       [rbx+10],al
       vmovdqu   xmm0,xmmword ptr [rbp-80]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-70]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-50]
       mov       rdx,298D83F3C54
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2C]
       cmp       [r8+8],r10d
       jb        near ptr M02_L63
       cmp       [r8],r8b
       movsxd    r10,eax
       lea       r8,[r8+r10*2+10]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymm1,ymmword ptr [rdx+20]
       vmovdqu   ymm2,ymmword ptr [rdx+38]
       vmovdqu   ymmword ptr [r8],ymm0
       vmovdqu   ymmword ptr [r8+20],ymm1
       vmovdqu   ymmword ptr [r8+38],ymm2
       add       eax,2C
       mov       [rcx+18],eax
M02_L55:
       lea       rcx,[rbp-90]
       mov       rax,7FF9EDF35380
       call      rax
       mov       rsi,[rbp-90]
       mov       rcx,258464001C8
       mov       rdi,[rcx]
       sub       rsi,[rdi+8]
       cmp       dword ptr [7FF9ACA240DC],0
       jne       near ptr M02_L09
M02_L56:
       mov       ecx,0B2D05E00
       cmp       rsi,rcx
       jae       near ptr M02_L21
       add       rsi,[rdi+10]
       jmp       near ptr M02_L33
M02_L57:
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rdx,rdi
       call      qword ptr [7FF94D40C7F8]
       mov       rcx,rdi
       mov       rdx,298D83F3C28
       call      qword ptr [7FF94CDFC330]
       inc       r12d
       cmp       [r13+8],r12d
       jg        short M02_L57
       jmp       near ptr M02_L52
M02_L58:
       mov       rcx,offset MT_System.Func`2[[System.Type, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,25846408CB0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF94D408B28
       mov       [r13+18],rcx
       mov       rcx,25846408CE0
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L49
M02_L59:
       xor       eax,eax
       jmp       near ptr M02_L54
M02_L60:
       mov       r8d,3
       call      qword ptr [7FF94CDFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M02_L42
M02_L61:
       mov       rcx,r14
       mov       r8d,2
       call      qword ptr [7FF94CDFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M02_L45
M02_L62:
       mov       rcx,rdi
       mov       r8d,2
       call      qword ptr [7FF94CDFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M02_L46
M02_L63:
       mov       r8d,2C
       call      qword ptr [7FF94CDFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M02_L55
M02_L64:
       mov       r8d,6
       call      qword ptr [7FF94CDFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M02_L36
M02_L65:
       mov       rcx,r14
       mov       r8d,2
       call      qword ptr [7FF94CDFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M02_L37
M02_L66:
       mov       rcx,rsp
       call      M02_L72
       nop
       mov       rax,[rbp-0D0]
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L67:
       call      qword ptr [7FF94D00FAC8]
       mov       ecx,1694
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D00F8B8]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rbx
       call      qword ptr [7FF94CD86670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L68:
       call      qword ptr [7FF94CF55680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L69:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D2DC3D8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L70
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M02_L02
M02_L70:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M02_L03
M02_L71:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M02_L04
M02_L72:
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
       lea       rbp,[rbp+110]
       mov       rcx,25846408B08
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M02_L73
       call      qword ptr [7FF94CF55680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M02_L74
M02_L73:
       mov       r15,[rcx+18]
M02_L74:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [r15],rcx
       jne       near ptr M02_L79
       mov       r12,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M02_L75
       mov       rdi,[rbp-0C0]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M02_L80
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF94CDFC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L76
M02_L75:
       mov       rdx,[rbp-0C0]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       test      eax,eax
       mov       rdi,[rbp-0C0]
       je        short M02_L80
M02_L76:
       cmp       qword ptr [r15+20],0
       jne       short M02_L77
       cmp       [r15],r15b
       lea       rcx,[r15+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L80
M02_L77:
       cmp       [r15],r15b
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M02_L78
       mov       rcx,[r15+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D2DC3A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L80
M02_L78:
       cmp       [r15],r15b
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       short M02_L80
M02_L79:
       mov       rdi,[rbp-0C0]
       mov       rcx,r15
       mov       rdx,rdi
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M02_L80:
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
; Total bytes of code 3122
```

