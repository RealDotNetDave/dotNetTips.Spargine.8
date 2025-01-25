## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordGeneratorBenchmark.GeneratePassword()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0C
       call      qword ptr [7FF94D43C198]; DotNetTips.Spargine.Core.Security.PasswordGenerator.GeneratePassword(Int32)
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
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Core.Security.PasswordGenerator.GeneratePassword(Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       [rbp-0C0],rsp
       mov       ebx,ecx
       lea       rcx,[rbp-0B0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       xor       ecx,ecx
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       cmp       ebx,8
       cmovge    ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L18
M01_L00:
       test      eax,eax
       je        near ptr M01_L19
M01_L01:
       mov       rcx,21A03C08B48
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L20
       mov       rcx,[rcx+18]
M01_L02:
       mov       rdi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       near ptr M01_L23
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L21
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L21
M01_L03:
       mov       r14,[rbp-48]
M01_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r14,r14
       je        near ptr M01_L24
M01_L05:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF94CE2C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FF94CE2C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-58],r14
       mov       rcx,offset MT_System.Byte[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       [rbp-60],r15
       mov       rdx,21A03C0A1D8
       mov       rax,[rdx]
       mov       [rbp-68],rax
       xor       r13d,r13d
       jmp       near ptr M01_L11
M01_L06:
       lea       rdx,[r15+10]
       mov       r8d,4
       test      r8d,r8d
       jle       short M01_L09
       mov       [rbp-50],rdx
       xor       ecx,ecx
       mov       r9d,2
       mov       r10,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0A0],r10
       lea       r10,[M01_L07]
       mov       [rbp-88],r10
       lea       r10,[rbp-0B0]
       mov       [rsi+10],r10
       mov       byte ptr [rsi+0C],0
       mov       rax,7FF9ED5A3670
       call      rax
M01_L07:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FF9ACA240DC],0
       je        short M01_L08
       call      qword ptr [7FF9ACA143A8]; CORINFO_HELP_STOP_FOR_GC
M01_L08:
       mov       rcx,[rbp-0A8]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L14
       xor       ecx,ecx
       mov       [rbp-50],rcx
M01_L09:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       r15,[rbp-60]
       movzx     ecx,byte ptr [r15+10]
       mov       edx,0CF6474A9
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,26
       imul      edx,4F
       sub       ecx,edx
       mov       rdx,25A95A53C0C
       movzx     edx,word ptr [rdx+rcx*2]
       mov       r14,[rbp-58]
       mov       ecx,[r14+18]
       mov       r8d,ecx
       mov       r10,[r14+8]
       mov       r9d,[r10+8]
       cmp       r9d,r8d
       jbe       short M01_L13
       mov       r8d,r8d
       mov       [r10+r8*2+10],dx
       inc       ecx
       mov       [r14+18],ecx
M01_L10:
       add       r13d,1
       jo        short M01_L12
M01_L11:
       cmp       r13d,ebx
       jl        near ptr M01_L06
       mov       r14,[rbp-58]
       jmp       short M01_L15
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,r14
       call      qword ptr [7FF94CE2C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L10
M01_L14:
       mov       ecx,eax
       call      qword ptr [7FF94D30D7B8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L15:
       mov       rax,[rbp-68]
       mov       rcx,rax
       call      System.GC._SuppressFinalize(System.Object)
       mov       rcx,r14
       call      qword ptr [7FF94CE1E3F0]; System.Text.StringBuilder.ToString()
       mov       [rbp-70],rax
       mov       rcx,rsp
       call      M01_L25
       jmp       short M01_L17
M01_L16:
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rax,[rbp-70]
       jmp       short M01_L16
M01_L18:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF94CC447B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L19:
       call      qword ptr [7FF94D03FAB0]
       mov       rdi,25A95A53B88
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,25A95A486E0
       mov       r8,rdi
       call      qword ptr [7FF94CC4D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       call      qword ptr [7FF94CF85680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L02
M01_L21:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D30C3D8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L22
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L03
M01_L22:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L04
M01_L23:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L05
M01_L24:
       call      qword ptr [7FF94D03FAC8]
       mov       ecx,13C4
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF94D03F8B8]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r13
       call      qword ptr [7FF94CDB6670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       mov       rax,[rbp-68]
       mov       rcx,rax
       call      System.GC._SuppressFinalize(System.Object)
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
M01_L25:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       mov       rcx,21A03C08B48
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L26
       call      qword ptr [7FF94CF85680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       short M01_L27
M01_L26:
       mov       r14,[rcx+18]
M01_L27:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [r14],rcx
       jne       near ptr M01_L32
       mov       r12,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M01_L28
       mov       rcx,[rbp-58]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[r12+8]
       cmp       edx,[rax+0C]
       jg        short M01_L33
       xor       edx,edx
       call      qword ptr [7FF94CE2C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L29
M01_L28:
       mov       rdx,[rbp-58]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       test      eax,eax
       je        short M01_L33
M01_L29:
       cmp       qword ptr [r14+20],0
       jne       short M01_L30
       lea       rcx,[r14+20]
       mov       rdx,[rbp-58]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L33
M01_L30:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L31
       mov       rcx,[r14+18]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D30C3A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L33
M01_L31:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       short M01_L33
M01_L32:
       mov       rcx,r14
       mov       rdx,[rbp-58]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L33:
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
; Total bytes of code 1323
```

