## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.ToWords()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+118]
       call      qword ptr [7FFE18C6DAD0]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-0B0],rsp
       mov       ebx,ecx
       test      ebx,ebx
       je        near ptr M01_L70
       test      ebx,ebx
       jl        near ptr M01_L71
       mov       rcx,1AACF40EB48
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L73
       mov       rcx,[rcx+18]
M01_L02:
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L77
       mov       rcx,[rsi+20]
       mov       [rbp-90],rcx
       cmp       qword ptr [rbp-90],0
       je        short M01_L03
       lea       rcx,[rsi+20]
       mov       r8,[rbp-90]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-90]
       je        short M01_L05
M01_L03:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-90]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE18C6D458]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L74
M01_L04:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L05:
       mov       rsi,[rbp-90]
M01_L06:
       xor       ecx,ecx
       mov       [rbp-90],rcx
M01_L07:
       cmp       [rsi],sil
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE1878C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-98],rsi
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       test      eax,eax
       jg        near ptr M01_L68
M01_L08:
       mov       edx,10624DD3
       mov       eax,edx
       imul      ebx
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,6
       add       r15d,edx
       test      r15d,r15d
       jle       near ptr M01_L13
       mov       rax,rsi
       mov       [rbp-70],rax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       byte ptr [rbp-60],0
       mov       ecx,r15d
       call      qword ptr [7FFE18C6DAD0]
       cmp       byte ptr [rbp-60],0
       jne       near ptr M01_L62
       mov       r14,[rbp-70]
       cmp       [r14],r14b
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M01_L33
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L31
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L09:
       mov       [r14+18],edi
M01_L10:
       lea       rcx,[rbp-70]
       mov       edx,20
       call      qword ptr [7FFE18DAC570]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFE18DAC498]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       cmp       byte ptr [rbp-60],0
       jne       near ptr M01_L61
       mov       rdi,[rbp-70]
       cmp       [rdi],dil
       test      rax,rax
       je        short M01_L12
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L12
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M01_L52
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L28
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       [rdi+18],r14d
M01_L12:
       lea       rcx,[rbp-70]
       mov       edx,20
       call      qword ptr [7FFE18DAC570]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       imul      eax,r15d,3E8
       sub       ebx,eax
M01_L13:
       mov       edx,51EB851F
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,5
       add       edi,edx
       test      edi,edi
       jg        short M01_L15
M01_L14:
       test      ebx,ebx
       jle       near ptr M01_L23
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       test      ecx,ecx
       jle       near ptr M01_L21
       jmp       near ptr M01_L43
M01_L15:
       mov       rax,rsi
       mov       [rbp-70],rax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       byte ptr [rbp-60],0
       mov       ecx,edi
       call      qword ptr [7FFE18C6DAD0]
       cmp       byte ptr [rbp-60],0
       jne       near ptr M01_L60
       mov       r15,[rbp-70]
       cmp       [r15],r15b
       test      rax,rax
       je        short M01_L17
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L17
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M01_L53
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L25
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L16:
       mov       [r15+18],r14d
M01_L17:
       lea       rcx,[rbp-70]
       mov       edx,20
       call      qword ptr [7FFE18DAC570]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFE18DAC288]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       cmp       byte ptr [rbp-60],0
       jne       near ptr M01_L59
       mov       r14,[rbp-70]
       cmp       [r14],r14b
       test      rax,rax
       je        short M01_L19
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L19
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M01_L54
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L22
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L18:
       mov       [r14+18],r15d
M01_L19:
       lea       rcx,[rbp-70]
       mov       edx,20
       call      qword ptr [7FFE18DAC570]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       imul      ecx,edi,64
       sub       ebx,ecx
       jmp       near ptr M01_L14
M01_L20:
       lea       rcx,[rbp-70]
       mov       edx,20
       call      qword ptr [7FFE18DAC570]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
M01_L21:
       mov       rcx,offset MT_System.String[]
       mov       edx,14
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdi,1AACF40EBC8
       mov       r8,[rdi]
       mov       rdx,1EB612145F0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214610
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214630
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214650
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214670
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214690
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB612146B0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB612146D0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB612146F0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214710
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214730
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214750
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+68]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214778
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+70]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB612147A0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB612147C8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+80]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB612147F0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+88]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214818
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214840
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+98]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214868
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+0A0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214890
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
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB612145F0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214730
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB612148B8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB612148E0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214908
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214928
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214948
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214968
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB61214990
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18DAC018]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,1EB612149B8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       ebx,14
       jge       near ptr M01_L34
       jmp       near ptr M01_L45
M01_L22:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L18
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L18
M01_L23:
       mov       rcx,rsi
       call      qword ptr [7FFE18797A60]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L30
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L26
       cmp       ecx,100
       jae       short M01_L24
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L67
       jmp       short M01_L27
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L25:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L16
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L16
M01_L26:
       call      qword ptr [7FFE18DED518]
       test      eax,eax
       jne       near ptr M01_L67
M01_L27:
       mov       ecx,[rbx+8]
       dec       ecx
       cmp       ecx,[rbx+8]
       jae       short M01_L24
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L29
       cmp       ecx,100
       jae       short M01_L24
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L67
       jmp       short M01_L30
M01_L28:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L11
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L11
M01_L29:
       call      qword ptr [7FFE18DED518]
       test      eax,eax
       jne       near ptr M01_L67
M01_L30:
       jmp       short M01_L32
M01_L31:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L09
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L09
M01_L32:
       mov       [rbp-0A0],rbx
       jmp       near ptr M01_L69
M01_L33:
       mov       rcx,r14
       call      qword ptr [7FFE1878CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L10
M01_L34:
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,2
       add       edi,edx
       cmp       edi,0A
       jae       near ptr M01_L24
       mov       r8d,edi
       mov       r8,[r15+r8*8+10]
       test      r8,r8
       je        short M01_L36
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L36
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M01_L50
       cmp       [rcx],cl
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L42
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L35:
       mov       [rsi+18],r15d
M01_L36:
       lea       r8d,[rdi+rdi*4]
       add       r8d,r8d
       mov       edi,ebx
       sub       edi,r8d
       test      edi,edi
       jle       near ptr M01_L23
       mov       rax,rsi
       mov       [rbp-70],rax
       xor       r8d,r8d
       mov       [rbp-68],r8
       mov       byte ptr [rbp-60],0
       cmp       byte ptr [rbp-60],0
       jne       near ptr M01_L40
       mov       r8,[rbp-70]
       mov       rcx,[r8+8]
       mov       rdx,rcx
       mov       r8d,[r8+18]
       mov       r15d,r8d
       mov       ecx,[rcx+8]
       sub       ecx,r8d
       test      rdx,rdx
       je        near ptr M01_L57
       mov       r8d,r15d
       mov       eax,ecx
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        near ptr M01_L63
       cmp       [rdx],dl
       mov       r8d,r15d
       lea       r13,[rdx+r8*2+10]
M01_L37:
       test      ecx,ecx
       je        near ptr M01_L65
       test      ecx,ecx
       je        near ptr M01_L24
       mov       word ptr [r13],2D
       mov       r8d,1
       cmp       r8d,ecx
       ja        near ptr M01_L64
       mov       rcx,[rbp-70]
       add       [rcx+18],r8d
M01_L38:
       cmp       edi,14
       jae       near ptr M01_L24
       mov       r8d,edi
       mov       r8,[r14+r8*8+10]
       cmp       byte ptr [rbp-60],0
       jne       near ptr M01_L66
       mov       rbx,[rbp-70]
       cmp       [rbx],bl
       test      r8,r8
       je        near ptr M01_L23
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L23
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M01_L51
       cmp       [rcx],cl
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L41
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L39:
       mov       [rbx+18],r14d
       jmp       near ptr M01_L23
M01_L40:
       lea       rcx,[rbp-70]
       mov       edx,2D
       xor       r8d,r8d
       call      qword ptr [7FFE18DAC618]
       jmp       near ptr M01_L38
M01_L41:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L39
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L39
M01_L42:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L35
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L35
M01_L43:
       mov       rcx,rsi
       mov       [rbp-70],rcx
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       byte ptr [rbp-60],0
       call      qword ptr [7FFE18DAC060]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       cmp       byte ptr [rbp-60],0
       jne       near ptr M01_L58
       mov       r15,[rbp-70]
       cmp       [r15],r15b
       test      rax,rax
       je        near ptr M01_L20
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L20
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M01_L55
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L46
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L44:
       mov       [r15+18],edi
       jmp       near ptr M01_L20
M01_L45:
       cmp       ebx,14
       jae       near ptr M01_L24
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       test      r8,r8
       je        near ptr M01_L23
       jmp       short M01_L47
M01_L46:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L44
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L44
M01_L47:
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L23
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebx,[rax+r8]
       cmp       ebx,[rcx+8]
       ja        near ptr M01_L56
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L49
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L48:
       mov       [rsi+18],ebx
       jmp       near ptr M01_L23
M01_L49:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L48
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L48
M01_L50:
       mov       rcx,rsi
       call      qword ptr [7FFE1878CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L36
M01_L51:
       mov       rcx,rbx
       call      qword ptr [7FFE1878CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L23
M01_L52:
       mov       rcx,rdi
       call      qword ptr [7FFE1878CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L12
M01_L53:
       mov       rcx,r15
       call      qword ptr [7FFE1878CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L17
M01_L54:
       mov       rcx,r14
       call      qword ptr [7FFE1878CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L19
M01_L55:
       mov       rcx,r15
       call      qword ptr [7FFE1878CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L20
M01_L56:
       mov       rcx,rsi
       call      qword ptr [7FFE1878CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L23
M01_L57:
       or        r15d,ecx
       jne       near ptr M01_L63
       xor       r13d,r13d
       xor       ecx,ecx
       jmp       near ptr M01_L37
M01_L58:
       lea       rcx,[rbp-70]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE18DAC648]
       jmp       near ptr M01_L20
M01_L59:
       lea       rcx,[rbp-70]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE18DAC648]
       jmp       near ptr M01_L19
M01_L60:
       lea       rcx,[rbp-70]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE18DAC648]
       jmp       near ptr M01_L17
M01_L61:
       lea       rcx,[rbp-70]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE18DAC648]
       jmp       near ptr M01_L12
M01_L62:
       lea       rcx,[rbp-70]
       mov       r8,rax
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE18DAC648]
       jmp       near ptr M01_L10
M01_L63:
       call      qword ptr [7FFE186EE9D0]
       int       3
M01_L64:
       call      qword ptr [7FFE186EF168]
       int       3
M01_L65:
       lea       rcx,[rbp-70]
       mov       edx,2D
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE18DAC5E8]
       jmp       near ptr M01_L38
M01_L66:
       lea       rcx,[rbp-70]
       mov       rdx,offset MD_System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE18DAC648]
       jmp       near ptr M01_L23
M01_L67:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE184873F0]
       mov       rbx,rax
       jmp       near ptr M01_L32
M01_L68:
       lea       rcx,[rbp-88]
       mov       r9,rsi
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFE18DA7AC8]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-88]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rax,[rbp-78]
       mov       [rbp-60],rax
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,12
       add       ecx,edx
       call      qword ptr [7FFE18C6DAD0]
       mov       rdx,rax
       lea       rcx,[rbp-70]
       call      qword ptr [7FFE18DA7BB8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-70]
       mov       edx,20
       call      qword ptr [7FFE18DAC570]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFE18DAC2E8]
       mov       rdx,rax
       lea       rcx,[rbp-70]
       call      qword ptr [7FFE18DA7BB8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-70]
       mov       edx,20
       call      qword ptr [7FFE18DAC570]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
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
M01_L69:
       mov       rcx,rsp
       call      M01_L78
       nop
       mov       rax,[rbp-0A0]
       add       rsp,0A0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L70:
       call      qword ptr [7FFE18DAC558]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       nop
       add       rsp,0A0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L71:
       lea       rcx,[rbp-58]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FFE186756B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       call      qword ptr [7FFE18DAC300]
       mov       rdx,rax
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE18675830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-58]
       mov       edx,20
       call      qword ptr [7FFE18DAC588]
       mov       ecx,ebx
       neg       ecx
       jns       short M01_L72
       call      qword ptr [7FFE1892F330]
       int       3
M01_L72:
       call      qword ptr [7FFE18C6DAD0]
       mov       rdx,rax
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE18675830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE18675740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,0A0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L73:
       call      qword ptr [7FFE188F5680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L02
M01_L74:
       cmp       qword ptr [r14+10],0
       jne       short M01_L75
       xor       edx,edx
       mov       [rbp-90],rdx
       jmp       short M01_L76
M01_L75:
       lea       rdx,[rbp-90]
       mov       rcx,rdi
       call      qword ptr [7FFE18C6CF78]
       test      eax,eax
       jne       near ptr M01_L04
M01_L76:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L77:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L07
M01_L78:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0D0]
       mov       rcx,1AACF40EB48
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L79
       call      qword ptr [7FFE188F5680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M01_L80
M01_L79:
       mov       rbx,[rcx+18]
M01_L80:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rbx],rcx
       jne       near ptr M01_L85
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L81
       mov       r14,[rbp-98]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L86
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE1878C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L82
M01_L81:
       mov       rdx,[rbp-98]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       mov       r14,[rbp-98]
       je        short M01_L86
M01_L82:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L83
       cmp       [rbx],bl
       lea       rcx,[rbx+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L86
M01_L83:
       cmp       [rbx],bl
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L84
       mov       r13,[rbx+18]
       mov       rcx,[r13+10]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE18C6D488]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L86
       mov       rcx,r13
       mov       rdx,r14
       call      qword ptr [7FFE18C6CF48]
       jmp       short M01_L86
M01_L84:
       cmp       [rbx],bl
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M01_L86
M01_L85:
       mov       r14,[rbp-98]
       mov       rcx,rbx
       mov       rdx,r14
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L86:
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
; Total bytes of code 4426
```

