## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.ToWords()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+118]
       call      qword ptr [7FF95D2BCF48]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
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
       je        near ptr M01_L71
       test      ebx,ebx
       jl        near ptr M01_L72
       mov       rcx,29DDD80EB20
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L74
       mov       rcx,[rcx+18]
M01_L02:
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L78
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
       call      qword ptr [7FF95D2BC8D0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L75
M01_L04:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L05:
       mov       rsi,[rbp-98]
M01_L06:
       xor       ecx,ecx
       mov       [rbp-98],rcx
M01_L07:
       cmp       [rsi],sil
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF95CDCC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-0A0],rsi
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       test      eax,eax
       jg        near ptr M01_L69
M01_L08:
       mov       edx,10624DD3
       mov       eax,edx
       imul      ebx
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,6
       add       r15d,edx
       test      r15d,r15d
       jle       near ptr M01_L22
       mov       rax,rsi
       mov       [rbp-78],rax
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       byte ptr [rbp-68],0
       mov       ecx,r15d
       call      qword ptr [7FF95D2BCF48]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L17
       mov       r14,[rbp-78]
       cmp       [r14],r14b
       test      rax,rax
       je        near ptr M01_L18
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L18
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M01_L16
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L09:
       mov       [r14+18],edi
       jmp       near ptr M01_L18
M01_L10:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L09
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L09
M01_L11:
       mov       rcx,rsi
       call      qword ptr [7FF95CDD7A60]; System.Text.StringBuilder.ToString()
       mov       r12,rax
       cmp       dword ptr [r12+8],0
       je        short M01_L13
       movzx     ecx,word ptr [r12+0C]
       cmp       ecx,100
       jae       near ptr M01_L30
       cmp       ecx,100
       jae       short M01_L14
       mov       rax,7FF9BB7A2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L68
M01_L12:
       mov       ecx,[r12+8]
       dec       ecx
       cmp       ecx,[r12+8]
       jae       short M01_L14
       movzx     ecx,word ptr [r12+rcx*2+0C]
       cmp       ecx,100
       jae       near ptr M01_L34
       cmp       ecx,100
       jae       short M01_L14
       mov       rax,7FF9BB7A2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L68
M01_L13:
       mov       [rbp-0A8],r12
       jmp       near ptr M01_L70
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FF95D3DCFC0]
       jmp       near ptr M01_L21
M01_L16:
       mov       rcx,r14
       call      qword ptr [7FF95CDCCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L18
M01_L17:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FF95D3DCFC0]
M01_L18:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF95D3DCEE8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FF95D3DCE10]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       cmp       byte ptr [rbp-68],0
       jne       short M01_L15
       mov       rdi,[rbp-78]
       cmp       [rdi],dil
       test      rax,rax
       je        short M01_L21
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L21
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L23
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L20
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L19:
       mov       [rdi+18],r14d
       jmp       short M01_L21
M01_L20:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L19
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L19
M01_L21:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF95D3DCEE8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       imul      eax,r15d,3E8
       sub       ebx,eax
M01_L22:
       mov       edx,51EB851F
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,5
       add       edi,edx
       test      edi,edi
       jle       short M01_L25
       jmp       near ptr M01_L31
M01_L23:
       mov       rcx,rdi
       call      qword ptr [7FF95CDCCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L21
M01_L24:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF95D3DCEE8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       imul      r8d,edi,64
       sub       ebx,r8d
M01_L25:
       test      ebx,ebx
       jle       near ptr M01_L11
       mov       eax,[rsi+1C]
       add       eax,[rsi+18]
       test      eax,eax
       jg        near ptr M01_L27
M01_L26:
       mov       rcx,offset MT_System.String[]
       mov       edx,14
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r14,29DDD80EBA0
       mov       r8,[r14]
       mov       rdx,2DE6F6C3DF8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3E18
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3E38
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3E58
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3E78
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3E98
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3EB8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3ED8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3EF8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3F18
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3F38
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3F58
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+68]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3F80
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+70]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3FA8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3FD0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+80]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3FF8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+88]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C4020
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C4048
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+98]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C4070
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+0A0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C4098
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+0A8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.String[]
       mov       edx,0A
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3DF8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C3F38
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C40C0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C40E8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C4110
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C4130
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C4150
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C4170
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C4198
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95D3DC990]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,2DE6F6C41C0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       ebx,14
       jge       near ptr M01_L38
       jmp       near ptr M01_L54
M01_L27:
       mov       rax,rsi
       mov       [rbp-78],rax
       xor       eax,eax
       mov       [rbp-70],rax
       mov       byte ptr [rbp-68],0
       call      qword ptr [7FF95D3DC9D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L62
       mov       rdi,[rbp-78]
       cmp       [rdi],dil
       test      rax,rax
       je        near ptr M01_L53
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L53
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M01_L52
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L29
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L28:
       mov       [rdi+18],r15d
       jmp       near ptr M01_L53
M01_L29:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L28
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L28
M01_L30:
       call      qword ptr [7FF95D40DCF8]
       test      eax,eax
       jne       near ptr M01_L68
       jmp       near ptr M01_L12
M01_L31:
       mov       rdx,rsi
       mov       [rbp-78],rdx
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       byte ptr [rbp-68],0
       mov       ecx,edi
       call      qword ptr [7FF95D2BCF48]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L51
       mov       r13,[rbp-78]
       cmp       [r13],r13b
       test      rax,rax
       je        short M01_L36
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L36
       mov       rcx,[r13+8]
       mov       eax,[r13+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M01_L35
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L33
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L32:
       mov       [r13+18],r15d
       jmp       short M01_L36
M01_L33:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L32
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L32
M01_L34:
       call      qword ptr [7FF95D40DCF8]
       test      eax,eax
       jne       near ptr M01_L68
       jmp       near ptr M01_L13
M01_L35:
       mov       rcx,r13
       call      qword ptr [7FF95CDCCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L36:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF95D3DCEE8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FF95D3DCC00]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L50
       mov       r12,[rbp-78]
       cmp       [r12],r12b
       test      rax,rax
       je        near ptr M01_L24
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L24
       mov       rcx,[r12+8]
       mov       eax,[r12+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M01_L42
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L39
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L37:
       mov       [r12+18],r14d
       jmp       near ptr M01_L24
M01_L38:
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       r14d,edx
       shr       r14d,1F
       sar       edx,2
       add       r14d,edx
       cmp       r14d,0A
       jae       near ptr M01_L14
       mov       r8d,r14d
       mov       r8,[r15+r8*8+10]
       test      r8,r8
       je        short M01_L41
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L41
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M01_L40
       cmp       [rcx],cl
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M01_L45
       jmp       near ptr M01_L56
M01_L39:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L37
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L37
M01_L40:
       mov       rcx,rsi
       call      qword ptr [7FF95CDCCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L41:
       lea       ecx,[r14+r14*4]
       add       ecx,ecx
       mov       r13d,ebx
       sub       r13d,ecx
       test      r13d,r13d
       jle       near ptr M01_L11
       jmp       near ptr M01_L47
M01_L42:
       mov       rcx,r12
       call      qword ptr [7FF95CDCCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L24
M01_L43:
       cmp       r13d,14
       jae       near ptr M01_L14
       mov       r8d,r13d
       mov       r8,[rdi+r8*8+10]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L67
       mov       rbx,[rbp-78]
       cmp       [rbx],bl
       test      r8,r8
       je        near ptr M01_L11
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L11
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M01_L59
       cmp       [rcx],cl
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L49
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L44:
       mov       [rbx+18],edi
       jmp       near ptr M01_L11
M01_L45:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L46:
       mov       [rsi+18],r15d
       jmp       near ptr M01_L41
M01_L47:
       mov       rdx,rsi
       mov       [rbp-78],rdx
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       byte ptr [rbp-68],0
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L61
       mov       r8,[rbp-78]
       mov       rcx,[r8+8]
       mov       rdx,rcx
       mov       r8d,[r8+18]
       mov       r12d,r8d
       mov       ecx,[rcx+8]
       sub       ecx,r8d
       test      rdx,rdx
       je        near ptr M01_L63
       mov       r8d,r12d
       mov       eax,ecx
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        near ptr M01_L64
       cmp       [rdx],dl
       mov       r8d,r12d
       lea       r8,[rdx+r8*2+10]
M01_L48:
       test      ecx,ecx
       je        near ptr M01_L66
       test      ecx,ecx
       je        near ptr M01_L14
       mov       word ptr [r8],2D
       mov       r8d,1
       cmp       r8d,ecx
       ja        near ptr M01_L65
       mov       rcx,[rbp-78]
       add       [rcx+18],r8d
       jmp       near ptr M01_L43
M01_L49:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L44
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L44
M01_L50:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FF95D3DCFC0]
       jmp       near ptr M01_L24
M01_L51:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FF95D3DCFC0]
       jmp       near ptr M01_L36
M01_L52:
       mov       rcx,rdi
       call      qword ptr [7FF95CDCCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L53:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF95D3DCEE8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       jmp       near ptr M01_L26
M01_L54:
       cmp       ebx,14
       jae       near ptr M01_L14
       mov       r8d,ebx
       mov       r8,[rdi+r8*8+10]
       test      r8,r8
       je        near ptr M01_L11
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L11
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        short M01_L60
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L57
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L55:
       mov       [rsi+18],edi
       jmp       near ptr M01_L11
M01_L56:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L46
       jmp       short M01_L58
M01_L57:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L55
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L55
M01_L58:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M01_L46
M01_L59:
       mov       rcx,rbx
       call      qword ptr [7FF95CDCCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L11
M01_L60:
       mov       rcx,rsi
       call      qword ptr [7FF95CDCCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L11
M01_L61:
       lea       rcx,[rbp-78]
       mov       edx,2D
       xor       r8d,r8d
       call      qword ptr [7FF95D3DCF90]
       jmp       near ptr M01_L43
M01_L62:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FF95D3DCFC0]
       jmp       near ptr M01_L53
M01_L63:
       or        r12d,ecx
       jne       short M01_L64
       xor       r8d,r8d
       xor       ecx,ecx
       jmp       near ptr M01_L48
M01_L64:
       call      qword ptr [7FF95CD2E9D0]
       int       3
M01_L65:
       call      qword ptr [7FF95CD2F168]
       int       3
M01_L66:
       lea       rcx,[rbp-78]
       mov       edx,2D
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF95D3DCF60]
       jmp       near ptr M01_L43
M01_L67:
       lea       rcx,[rbp-78]
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FF95D3DCFC0]
       jmp       near ptr M01_L11
M01_L68:
       mov       rcx,r12
       mov       edx,3
       call      qword ptr [7FF95CAC73F0]
       mov       r12,rax
       jmp       near ptr M01_L13
M01_L69:
       lea       rcx,[rbp-90]
       mov       r9,rsi
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FF95D3DC828]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
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
       call      qword ptr [7FF95D2BCF48]
       mov       rdx,rax
       lea       rcx,[rbp-78]
       call      qword ptr [7FF95D3DC918]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF95D3DCEE8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FF95D3DCC60]
       mov       rdx,rax
       lea       rcx,[rbp-78]
       call      qword ptr [7FF95D3DC918]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF95D3DCEE8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
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
M01_L70:
       mov       rcx,rsp
       call      M01_L79
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
M01_L71:
       call      qword ptr [7FF95D3DCED0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
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
M01_L72:
       lea       rcx,[rbp-60]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FF95CCB56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       call      qword ptr [7FF95D3DCC78]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FF95CCB5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       mov       edx,20
       call      qword ptr [7FF95D3DCF00]
       mov       ecx,ebx
       neg       ecx
       jns       short M01_L73
       call      qword ptr [7FF95CF6F330]
       int       3
M01_L73:
       call      qword ptr [7FF95D2BCF48]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FF95CCB5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF95CCB5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
M01_L74:
       call      qword ptr [7FF95CF35680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L02
M01_L75:
       cmp       qword ptr [r14+10],0
       jne       short M01_L76
       xor       edx,edx
       mov       [rbp-98],rdx
       jmp       short M01_L77
M01_L76:
       lea       rdx,[rbp-98]
       mov       rcx,rdi
       call      qword ptr [7FF95D2BC3F0]
       test      eax,eax
       jne       near ptr M01_L04
M01_L77:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L78:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L07
M01_L79:
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
       mov       rcx,29DDD80EB20
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L80
       call      qword ptr [7FF95CF35680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M01_L81
M01_L80:
       mov       rsi,[rcx+18]
M01_L81:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L86
       mov       r12,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M01_L82
       mov       r14,[rbp-0A0]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L87
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF95CDCC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L83
M01_L82:
       mov       rdx,[rbp-0A0]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       test      eax,eax
       mov       r14,[rbp-0A0]
       je        near ptr M01_L87
M01_L83:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L84
       cmp       [rsi],sil
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L87
M01_L84:
       cmp       [rsi],sil
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L85
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF95D2BC900]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L87
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF95D2BC3C0]
       jmp       short M01_L87
M01_L85:
       cmp       [rsi],sil
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L87
M01_L86:
       mov       r14,[rbp-0A0]
       mov       rcx,rsi
       mov       rdx,r14
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L87:
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
; Total bytes of code 4450
```

