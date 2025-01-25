## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.ToWords()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+118]
       call      qword ptr [7FFBF9CFE970]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
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
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
M01_L00:
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
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-0B0],rsp
       mov       ebx,ecx
       test      ebx,ebx
       je        near ptr M01_L77
       test      ebx,ebx
       jl        near ptr M01_L78
       mov       rcx,2097940E600
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L80
       mov       rcx,[rcx+18]
M01_L02:
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L84
       mov       rcx,[rsi+20]
       mov       [rbp-98],rcx
       cmp       qword ptr [rbp-98],0
       je        short M01_L03
       lea       rcx,[rsi+20]
       mov       r8,[rbp-98]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-98]
       je        short M01_L05
M01_L03:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-98]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9CFE2F8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L81
M01_L04:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L05:
       mov       rsi,[rbp-98]
M01_L06:
       xor       eax,eax
       mov       [rbp-98],rax
M01_L07:
       mov       [rbp-0A0],rsi
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       test      eax,eax
       jg        near ptr M01_L16
M01_L08:
       mov       edx,10624DD3
       mov       eax,edx
       imul      ebx
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,6
       add       r15d,edx
       test      r15d,r15d
       jg        short M01_L10
M01_L09:
       mov       edx,51EB851F
       mov       eax,edx
       imul      ebx
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,5
       add       r15d,edx
       test      r15d,r15d
       jle       near ptr M01_L38
       jmp       near ptr M01_L69
M01_L10:
       mov       r13,rsi
       mov       [rbp-78],r13
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       byte ptr [rbp-68],0
       mov       ecx,r15d
       call      qword ptr [7FFBF9CFE970]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L18
       mov       r12,[rbp-78]
       cmp       [r12],r12b
       test      rax,rax
       je        short M01_L12
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L12
       mov       rcx,[r12+8]
       mov       eax,[r12+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M01_L17
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L68
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       [r12+18],edi
M01_L12:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFBF9D8D6B0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFBF9A2D620]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L20
       mov       r14,[rbp-78]
       cmp       [r14],r14b
       test      rax,rax
       je        short M01_L14
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L14
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M01_L19
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L67
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L13:
       mov       [r14+18],edi
M01_L14:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFBF9D8D6B0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [r13],r13b
       imul      eax,r15d,3E8
       sub       ebx,eax
       jmp       near ptr M01_L09
M01_L15:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L11
M01_L16:
       lea       rcx,[rbp-90]
       mov       r9,rsi
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFBF9D8D560]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rax,[rbp-80]
       mov       [rbp-68],rax
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,12
       add       ecx,edx
       call      qword ptr [7FFBF9CFE970]
       mov       rdx,rax
       lea       rcx,[rbp-78]
       call      qword ptr [7FFBF9D8D650]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFBF9D8D6B0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFBF9A2D380]
       mov       rdx,rax
       lea       rcx,[rbp-78]
       call      qword ptr [7FFBF9D8D650]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFBF9D8D6B0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [rsi],sil
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,12
       add       ecx,edx
       imul      ecx,0F4240
       sub       ebx,ecx
       jmp       near ptr M01_L08
M01_L17:
       mov       rcx,r12
       call      qword ptr [7FFBF983CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L12
M01_L18:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFBF9D8D7A0]
       jmp       near ptr M01_L12
M01_L19:
       mov       rcx,r14
       call      qword ptr [7FFBF983CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L14
M01_L20:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFBF9D8D7A0]
       jmp       near ptr M01_L14
M01_L21:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L13
M01_L22:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L60
M01_L23:
       lea       rcx,[rbp-78]
       mov       edx,2D
       xor       r8d,r8d
       call      qword ptr [7FFBF9D8D770]
       jmp       near ptr M01_L63
M01_L24:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L56
M01_L25:
       mov       rcx,rsi
       call      qword ptr [7FFBF983CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L35
M01_L26:
       mov       rcx,rsi
       call      qword ptr [7FFBF983CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L61
M01_L27:
       or        eax,ecx
       jne       short M01_L28
       xor       r8d,r8d
       xor       ecx,ecx
       jmp       near ptr M01_L62
M01_L28:
       call      qword ptr [7FFBF979E9D0]
       int       3
M01_L29:
       call      qword ptr [7FFBF979F168]
       int       3
M01_L30:
       lea       rcx,[rbp-78]
       mov       edx,2D
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFBF9D8D740]
       jmp       near ptr M01_L63
M01_L31:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L64
M01_L32:
       mov       rcx,r15
       call      qword ptr [7FFBF983CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L35
M01_L33:
       lea       rcx,[rbp-78]
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFBF9D8D7A0]
       jmp       short M01_L35
M01_L34:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFBF95473F0]
       mov       rdi,rax
       jmp       near ptr M01_L37
M01_L35:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9846C50]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L37
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jae       near ptr M01_L53
       cmp       ecx,100
       jae       near ptr M01_L44
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       short M01_L34
M01_L36:
       mov       ecx,[rdi+8]
       dec       ecx
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L44
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       near ptr M01_L57
       cmp       ecx,100
       jae       near ptr M01_L44
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L34
M01_L37:
       mov       [rbp-0A8],rdi
       jmp       near ptr M01_L76
M01_L38:
       test      ebx,ebx
       jle       near ptr M01_L35
       mov       eax,[rsi+1C]
       add       eax,[rsi+18]
       test      eax,eax
       jg        near ptr M01_L40
M01_L39:
       mov       rcx,offset MT_System.String[]
       mov       edx,14
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r13,2097940E6F0
       mov       r8,[r13]
       mov       rdx,24A0B2DACD8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DACF8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAD18
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAD38
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAD58
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAD78
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAD98
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DADB8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DADD8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DADF8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAE18
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAE38
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+68]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAE60
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+70]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAE88
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAEB0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+80]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAED8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+88]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAF00
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAF28
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+98]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAF50
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+0A0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAF78
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+0A8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.String[]
       mov       edx,0A
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DACD8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAE18
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAFA0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAFC8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DAFF0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DB010
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DB030
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DB050
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DB078
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBF9A2D0B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r13]
       mov       rdx,24A0B2DB0A0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       ebx,14
       jge       near ptr M01_L59
       jmp       near ptr M01_L55
M01_L40:
       mov       r13,rsi
       mov       [rbp-78],r13
       xor       eax,eax
       mov       [rbp-70],rax
       mov       byte ptr [rbp-68],0
       call      qword ptr [7FFBF9A2D0F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L46
       mov       r12,[rbp-78]
       cmp       [r12],r12b
       test      rax,rax
       je        short M01_L42
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L42
       mov       rcx,[r12+8]
       mov       eax,[r12+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        short M01_L45
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L54
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L41:
       mov       [r12+18],edi
M01_L42:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFBF9D8D6B0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       jmp       near ptr M01_L39
M01_L43:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M01_L41
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L45:
       mov       rcx,r12
       call      qword ptr [7FFBF983CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L42
M01_L46:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFBF9D8D7A0]
       jmp       short M01_L42
M01_L47:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L70
M01_L48:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L72
M01_L49:
       mov       rcx,rdi
       call      qword ptr [7FFBF983CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L71
M01_L50:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFBF9D8D7A0]
       jmp       near ptr M01_L71
M01_L51:
       mov       rcx,rdi
       call      qword ptr [7FFBF983CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L73
M01_L52:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFBF9D8D7A0]
       jmp       near ptr M01_L73
M01_L53:
       call      qword ptr [7FFBF9E05B60]
       test      eax,eax
       jne       near ptr M01_L34
       jmp       near ptr M01_L36
M01_L54:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        near ptr M01_L43
       jmp       near ptr M01_L41
M01_L55:
       cmp       ebx,14
       jae       near ptr M01_L44
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       test      r8,r8
       je        near ptr M01_L35
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L35
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M01_L25
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L58
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L56:
       mov       [rsi+18],edi
       jmp       near ptr M01_L35
M01_L57:
       call      qword ptr [7FFBF9E05B60]
       test      eax,eax
       jne       near ptr M01_L34
       jmp       near ptr M01_L37
M01_L58:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        near ptr M01_L24
       jmp       short M01_L56
M01_L59:
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       r13d,edx
       shr       r13d,1F
       sar       edx,2
       add       r13d,edx
       cmp       r13d,0A
       jae       near ptr M01_L44
       mov       r8d,r13d
       mov       r8,[r15+r8*8+10]
       test      r8,r8
       je        short M01_L61
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L61
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M01_L26
       cmp       [rcx],cl
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L66
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L60:
       mov       [rsi+18],r15d
M01_L61:
       lea       r8d,[r13+r13*4]
       add       r8d,r8d
       mov       r15d,ebx
       sub       r15d,r8d
       test      r15d,r15d
       jle       near ptr M01_L35
       mov       r13,rsi
       mov       [rbp-78],r13
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       byte ptr [rbp-68],0
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L23
       mov       r8,[rbp-78]
       mov       rcx,[r8+8]
       mov       rdx,rcx
       mov       r8d,[r8+18]
       mov       eax,r8d
       mov       ecx,[rcx+8]
       sub       ecx,r8d
       test      rdx,rdx
       je        near ptr M01_L27
       mov       r8d,eax
       mov       r10d,ecx
       add       r8,r10
       mov       r10d,[rdx+8]
       cmp       r8,r10
       ja        near ptr M01_L28
       cmp       [rdx],dl
       mov       r8d,eax
       lea       r8,[rdx+r8*2+10]
M01_L62:
       test      ecx,ecx
       je        near ptr M01_L30
       test      ecx,ecx
       je        near ptr M01_L44
       mov       word ptr [r8],2D
       mov       r8d,1
       cmp       r8d,ecx
       ja        near ptr M01_L29
       mov       rcx,[rbp-78]
       add       [rcx+18],r8d
M01_L63:
       cmp       r15d,14
       jae       near ptr M01_L44
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L33
       mov       r15,[rbp-78]
       cmp       [r15],r15b
       test      r8,r8
       je        near ptr M01_L35
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L35
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M01_L32
       cmp       [rcx],cl
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L65
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L64:
       mov       [r15+18],edi
       jmp       near ptr M01_L35
M01_L65:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        near ptr M01_L31
       jmp       short M01_L64
M01_L66:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        near ptr M01_L22
       jmp       near ptr M01_L60
M01_L67:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        near ptr M01_L21
       jmp       near ptr M01_L13
M01_L68:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        near ptr M01_L15
       jmp       near ptr M01_L11
M01_L69:
       mov       r13,rsi
       mov       [rbp-78],r13
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       byte ptr [rbp-68],0
       mov       ecx,r15d
       call      qword ptr [7FFBF9CFE970]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L50
       mov       rdi,[rbp-78]
       cmp       [rdi],dil
       test      rax,rax
       je        short M01_L71
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L71
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        near ptr M01_L49
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L75
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L70:
       mov       [rdi+18],r12d
M01_L71:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFBF9D8D6B0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFBF9A2D320]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L52
       mov       rdi,[rbp-78]
       cmp       [rdi],dil
       test      rax,rax
       je        short M01_L73
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L73
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        near ptr M01_L51
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L74
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L72:
       mov       [rdi+18],r12d
M01_L73:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFBF9D8D6B0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [r13],r13b
       imul      r8d,r15d,64
       sub       ebx,r8d
       jmp       near ptr M01_L38
M01_L74:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        near ptr M01_L48
       jmp       short M01_L72
M01_L75:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        near ptr M01_L47
       jmp       near ptr M01_L70
M01_L76:
       mov       rcx,rsp
       call      M01_L85
       nop
       mov       rax,[rbp-0A8]
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
M01_L77:
       call      qword ptr [7FFBF9A2D6E0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       nop
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
M01_L78:
       lea       rcx,[rbp-60]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FFBF97256B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       call      qword ptr [7FFBF9A2D398]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBF9725830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       mov       edx,20
       call      qword ptr [7FFBF9A5DB00]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       ecx,ebx
       neg       ecx
       jns       short M01_L79
       call      qword ptr [7FFBF99EE328]
       int       3
M01_L79:
       call      qword ptr [7FFBF9CFE970]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBF9725830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBF9725740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
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
M01_L80:
       call      qword ptr [7FFBF99A4810]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L02
M01_L81:
       cmp       qword ptr [r14+10],0
       jne       short M01_L82
       xor       edx,edx
       mov       [rbp-98],rdx
       jmp       short M01_L83
M01_L82:
       lea       rdx,[rbp-98]
       mov       rcx,rdi
       call      qword ptr [7FFBF9CFDE18]
       test      eax,eax
       jne       near ptr M01_L04
M01_L83:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L84:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L07
M01_L85:
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
       mov       rcx,2097940E600
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L86
       call      qword ptr [7FFBF99A4810]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M01_L87
M01_L86:
       mov       rsi,[rcx+18]
M01_L87:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L92
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M01_L88
       mov       r15,[rbp-0A0]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L93
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFBF983C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L89
M01_L88:
       mov       rdx,[rbp-0A0]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       mov       r15,[rbp-0A0]
       je        near ptr M01_L93
M01_L89:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L90
       cmp       [rsi],sil
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L93
M01_L90:
       cmp       [rsi],sil
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L91
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9CFE328]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L93
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFBF9CFDDE8]
       jmp       short M01_L93
M01_L91:
       cmp       [rsi],sil
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L93
M01_L92:
       mov       r15,[rbp-0A0]
       mov       rcx,rsi
       mov       rdx,r15
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L93:
       nop
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
; Total bytes of code 4525
```

