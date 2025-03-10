## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L17
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF54BDC0F0]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF54BDC0F0]
       test      eax,eax
       jne       near ptr M00_L20
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L21
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L12:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L16
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L15
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L14
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFF54332A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54BA5218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       call      qword ptr [7FFF54674570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFF546742B8]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1FA152C9CB0
       mov       r8,rbx
       call      qword ptr [7FFF542D6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF540E73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 718
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
M01_L07:
       cmp       r8,800
       ja        short M01_L10
       mov       r9,r8
       shr       r9,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L08
       and       r8,3F
       cmp       r8,10
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFF54195B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,esi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,esi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       esi,ebp
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFF5432DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       esi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      qword ptr [7FFF546AEFB8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF544557E8]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       esi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF54455800]
       int       3
; Total bytes of code 319
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546AEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1FA152C0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFFB3A9A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M05_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FFFB3A83D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L17
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF54BCEDF0]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF54BCEDF0]
       test      eax,eax
       jne       near ptr M00_L20
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF5431D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L21
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L12:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L16
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L15
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L14
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5431D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFF54322A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54B95920]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       call      qword ptr [7FFF54664570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFF546642B8]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2CDE9019CB0
       mov       r8,rbx
       call      qword ptr [7FFF542C6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF540D73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5431D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M01_L02
       test      r8b,18
       je        short M01_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M01_L00:
       ret
M01_L01:
       test      r8b,4
       je        short M01_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L00
M01_L02:
       cmp       r8,40
       ja        short M01_L07
M01_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L05:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M01_L00
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L04
M01_L07:
       cmp       r8,800
       ja        short M01_L10
       mov       r9,r8
       shr       r9,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L03
       jmp       near ptr M01_L04
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFF54185B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,esi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,esi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       esi,ebp
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFF5431DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       esi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      qword ptr [7FFF5469EFB8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF5418D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF544457E8]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       esi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF54445800]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF5469EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5418D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2CDE9010008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFFB3A9A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M05_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FFFB3A83D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L17
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF54A0ECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF54A0ECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF5433D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L21
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L12:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L16
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L15
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L14
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5433D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFF54342A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54BA5B90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       call      qword ptr [7FFF54684570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFF546842B8]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2133DE59CB0
       mov       r8,rbx
       call      qword ptr [7FFF542E6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF540F73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5433D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFFB3A97370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFFB3AB0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       cmp       r8,40
       ja        short M02_L06
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L10
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L05:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L00
M02_L06:
       cmp       r8,800
       ja        short M02_L09
       mov       r9,r8
       shr       r9,6
M02_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L07
       and       r8,3F
       cmp       r8,10
       ja        short M02_L03
       jmp       short M02_L04
M02_L08:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L09:
       jmp       qword ptr [7FFF541A5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M02_L04
; Total bytes of code 259
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5433DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546BEFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF544657E8]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF54465800]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M04_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L02
       cmp       [rdx+8],r8d
       jb        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546BEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,2133DE50008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFFB3A9A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFFB3A83D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L17
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF54A1ECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF54A1ECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF5434D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L21
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L12:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L16
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L15
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L14
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5434D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFF54352A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54BB5E30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       call      qword ptr [7FFF54694570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFF546942B8]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21C24769CB0
       mov       r8,rbx
       call      qword ptr [7FFF542F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF541073F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5434D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFFB3A97370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFFB3AB0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       je        short M02_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M02_L00:
       ret
M02_L01:
       test      r8b,4
       je        short M02_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L00
M02_L02:
       cmp       r8,40
       ja        short M02_L07
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L06
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L05:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L00
M02_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L04
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L03
       jmp       near ptr M02_L04
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FFF541B5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5434DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53FB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546CEFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF544757E8]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF54475800]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M04_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L02
       cmp       [rdx+8],r8d
       jb        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53FB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546CEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,21C24760008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFFB3A9A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFFB3A83D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L17
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF54A1ECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF54A1ECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF5434D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L21
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L12:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L16
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L15
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L14
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5434D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFF54352A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54BC7438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       call      qword ptr [7FFF54694570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFF546942B8]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,297D0489CB0
       mov       r8,rbx
       call      qword ptr [7FFF542F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF541073F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5434D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFFB3A97370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFFB3AB0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FFF541B5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
; Total bytes of code 254
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5434DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53FB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546CEFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF544757E8]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF54475800]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M04_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L02
       cmp       [rdx+8],r8d
       jb        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53FB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546CEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,297D0480008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFFB3A9A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFFB3A83D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L17
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF54A0ECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF54A0ECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF5433D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L21
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L12:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L16
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L15
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L14
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5433D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFF54342A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54BB7090]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       call      qword ptr [7FFF54684570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFF546842B8]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2AA1E019CB0
       mov       r8,rbx
       call      qword ptr [7FFF542E6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF540F73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5433D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 718
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFFB3A97370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFFB3AB0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       je        short M02_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M02_L00:
       ret
M02_L01:
       test      r8b,4
       je        short M02_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L00
M02_L02:
       cmp       r8,40
       ja        short M02_L07
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L06
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L05:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L00
M02_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L04
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L03
       jmp       near ptr M02_L04
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FFF541A5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5433DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546BEFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF544657E8]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF54465800]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M04_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L02
       cmp       [rdx+8],r8d
       jb        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546BEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,2AA1E010008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFFB3A9A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFFB3A83D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L17
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       ecx,ecx
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF549FECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       ecx,ecx
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF549FECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M00_L21
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L12:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L16
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L15
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L14
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFF54332A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54BA73C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       call      qword ptr [7FFF54674570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFF546742B8]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1A28A969CB0
       mov       r8,rbx
       call      qword ptr [7FFF542D6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF540E73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 720
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFFB3A97370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFFB3AB0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       je        short M02_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M02_L00:
       ret
M02_L01:
       test      r8b,4
       je        short M02_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L00
M02_L02:
       cmp       r8,40
       ja        short M02_L07
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L06
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L05:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L00
M02_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L04
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L03
       jmp       near ptr M02_L04
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FFF54195B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5432DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546AEFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF544557E8]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF54455800]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M04_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L02
       cmp       [rdx+8],r8d
       jb        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546AEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,1A28A960008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFFB3A9A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFFB3A83D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L18
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
M00_L01:
       test      ecx,ecx
       je        near ptr M00_L19
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L07
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L04
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L21
       jmp       short M00_L05
M00_L02:
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       test      r12,r12
       je        short M00_L09
       jmp       near ptr M00_L13
M00_L04:
       call      qword ptr [7FFF549EECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L21
M00_L05:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L25
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L06
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L21
       jmp       short M00_L07
M00_L06:
       call      qword ptr [7FFF549EECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L21
M00_L07:
       mov       r12,r15
       jmp       short M00_L03
M00_L08:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF5431D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L09:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L23
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L10:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        near ptr M00_L16
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L15
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L12
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L11:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L12:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       je        near ptr M00_L24
       jmp       short M00_L11
M00_L13:
       lea       rdx,[r12+0C]
       mov       r12d,[r12+8]
       test      r12d,r12d
       je        near ptr M00_L09
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L08
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L17
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L14:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       near ptr M00_L09
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5431D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
       jmp       short M00_L18
M00_L17:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       je        near ptr M00_L22
       jmp       short M00_L14
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFF54322A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54B97438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L19:
       call      qword ptr [7FFF54664570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L20
       call      qword ptr [7FFF546642B8]
       mov       rbx,rax
M00_L20:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1C68DF19CB0
       mov       r8,rbx
       call      qword ptr [7FFF542C6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L21:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF540D73F0]
       mov       r12,rax
       jmp       near ptr M00_L03
M00_L22:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L14
M00_L23:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5431D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L10
M00_L24:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L11
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 759
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFFB3A97370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFFB3AB0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5431DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF5469EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5418D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF544457E8]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF54445800]
       int       3
; Total bytes of code 315
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       jne       short M03_L01
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M03_L00:
       ret
M03_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M03_L06
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L11
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L07:
       cmp       r8,800
       ja        short M03_L10
       mov       r9,r8
       shr       r9,6
M03_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L08
       and       r8,3F
       cmp       r8,10
       ja        short M03_L04
       jmp       short M03_L05
M03_L09:
       cmp       rcx,rdx
       je        near ptr M03_L00
M03_L10:
       jmp       qword ptr [7FFF54185B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
; Total bytes of code 254
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M04_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L02
       cmp       [rdx+8],r8d
       jb        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF5469EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5418D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,1C68DF10008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFFB3A9A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFFB3A83D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       mov       ecx,ebp
       mov       r14,[rdi+rcx*8+10]
       test      r14,r14
       je        short M00_L01
       mov       r15d,[r14+8]
       xor       ecx,ecx
       test      r15d,r15d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r15d,r15d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF54BCC180]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF54BCC180]
       test      eax,eax
       jne       near ptr M00_L27
M00_L06:
       mov       r8,r14
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5431D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M00_L19
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,1927C010E58
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFF54C96478]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5431D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,1D30A079084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFF54322A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54B95920]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5431D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF5431D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5431D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5431D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFF54664570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFF546642B8]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1D30A079CB0
       mov       r8,rbx
       call      qword ptr [7FFF542C6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF54445B60]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF540D73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5431D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFF5431D2D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFF5431D2D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1026
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M01_L02
       test      r8b,18
       je        short M01_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M01_L00:
       ret
M01_L01:
       test      r8b,4
       je        short M01_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L00
M01_L02:
       cmp       r8,40
       ja        short M01_L07
M01_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L05:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M01_L00
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L04
M01_L07:
       cmp       r8,800
       ja        short M01_L10
       mov       r9,r8
       shr       r9,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L03
       jmp       near ptr M01_L04
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFF54185B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5431DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF5469EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5418D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF544457E8]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF54445800]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M03_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M03_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M03_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M03_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFF5444D380]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M03_L02:
       cmp       ebx,5
       ja        near ptr M03_L08
       mov       edx,ebx
       lea       r8,[7FFF54C2B028]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M03_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFF5431DE00]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFF5449E730]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFF54D36388]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFF5451C2A0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFF54C97C48]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D36BF8]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D37558]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFF544F7A38]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
; Total bytes of code 424
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M04_L04
       test      ebx,ebx
       jl        near ptr M04_L05
       test      rdx,rdx
       je        near ptr M04_L06
       test      ebx,ebx
       je        short M04_L03
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M04_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L01
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rsi+18],edi
       jmp       short M04_L03
M04_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M04_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M04_L00
M04_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF5431D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M04_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       ecx,172D
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF54B97CD8]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF54B97CD8]
       int       3
M04_L06:
       or        ebx,edi
       jne       short M04_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       ecx,2E5
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF542C6790]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF5469EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5418D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF5469EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5418D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,1D30A070008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF5431DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M08_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M08_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF5431D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       mov       ecx,ebp
       mov       r14,[rdi+rcx*8+10]
       test      r14,r14
       je        short M00_L01
       mov       r15d,[r14+8]
       xor       ecx,ecx
       test      r15d,r15d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r15d,r15d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L04
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
M00_L03:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L04:
       call      qword ptr [7FFF54BEF1B0]
       test      eax,eax
       jne       near ptr M00_L27
       jmp       short M00_L03
M00_L05:
       call      qword ptr [7FFF54BEF1B0]
       test      eax,eax
       jne       near ptr M00_L27
M00_L06:
       mov       r8,r14
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5433D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,12975C10E58
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFF54CBD4E8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5433D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,16A03A39084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFF54342A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54BB5920]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5433D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF5433D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5433D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5433D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFF54684570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFF546842B8]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,16A03A39CB0
       mov       r8,rbx
       call      qword ptr [7FFF542E6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF54465B60]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF540F73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5433D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFF5433D2D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFF5433D2D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1030
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M01_L02
       test      r8b,18
       je        short M01_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M01_L00:
       ret
M01_L01:
       test      r8b,4
       je        short M01_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L00
M01_L02:
       cmp       r8,40
       ja        short M01_L07
M01_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L05:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M01_L00
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L04
M01_L07:
       cmp       r8,800
       ja        short M01_L10
       mov       r9,r8
       shr       r9,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L03
       jmp       near ptr M01_L04
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFF541A5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5433DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546BEFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF544657E8]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF54465800]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M03_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M03_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M03_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M03_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFF5446D380]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M03_L02:
       cmp       ebx,5
       ja        near ptr M03_L08
       mov       edx,ebx
       lea       r8,[7FFF54C4AC88]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M03_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFF5433DE00]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFF544BE730]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFF54D467F0]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFF5453C2A0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFF54CBECB8]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D47060]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D479C0]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFF54517A38]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
; Total bytes of code 424
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M04_L04
       test      ebx,ebx
       jl        near ptr M04_L05
       test      rdx,rdx
       je        near ptr M04_L06
       test      ebx,ebx
       je        short M04_L01
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M04_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L03
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rsi+18],edi
M04_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF5433D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M04_L01
M04_L03:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M04_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M04_L00
M04_L04:
       mov       ecx,172D
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF54BB7CD8]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF54BB7CD8]
       int       3
M04_L06:
       or        ebx,edi
       jne       short M04_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       ecx,2E5
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF542E6790]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546BEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546BEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,16A03A30008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF5433DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M08_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M08_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF5433D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       mov       ecx,ebp
       mov       r14,[rdi+rcx*8+10]
       test      r14,r14
       je        short M00_L01
       mov       r15d,[r14+8]
       xor       ecx,ecx
       test      r15d,r15d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r15d,r15d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF549FECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF549FECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
M00_L06:
       mov       r8,r14
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,1988A010E58
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFF54CAD4E8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5432D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,1D91BD59084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFF54332A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54B95E30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFF54674570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFF546742B8]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1D91BD59CB0
       mov       r8,rbx
       call      qword ptr [7FFF542D6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF54455B60]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF540E73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5432D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFF5432D2D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFF5432D2D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1030
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFFB3A97370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFFB3AB0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       je        short M02_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M02_L00:
       ret
M02_L01:
       test      r8b,4
       je        short M02_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L00
M02_L02:
       cmp       r8,40
       ja        short M02_L07
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L06
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L05:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L00
M02_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L04
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L03
       jmp       near ptr M02_L04
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FFF54195B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5432DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546AEFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF544557E8]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF54455800]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M04_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M04_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M04_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M04_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFF5445D380]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M04_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M04_L02:
       cmp       ebx,5
       ja        near ptr M04_L08
       mov       edx,ebx
       lea       r8,[7FFF54C3CD68]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M04_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M04_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFF5432DE00]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M04_L04
M04_L03:
       call      qword ptr [7FFF544AE730]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M04_L04:
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFF54D368B0]
       jmp       short M04_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M04_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M04_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M04_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFF5452C2A0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M04_L07
M04_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFF54CAECB8]
M04_L07:
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D37120]
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D37A80]
       jmp       near ptr M04_L01
M04_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFF54507A38]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M04_L01
; Total bytes of code 424
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M05_L04
       test      ebx,ebx
       jl        near ptr M05_L05
       test      rdx,rdx
       je        near ptr M05_L06
       test      ebx,ebx
       je        short M05_L01
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M05_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L03
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       mov       [rsi+18],edi
M05_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M05_L01
M05_L03:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L04:
       mov       ecx,172D
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF54B9C1F8]
       int       3
M05_L05:
       mov       ecx,1C7
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF54B9C1F8]
       int       3
M05_L06:
       or        ebx,edi
       jne       short M05_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L07:
       mov       ecx,2E5
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF542D6790]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546AEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M06_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L02
       cmp       [rdx+8],r8d
       jb        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546AEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,1D91BD50008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF5432DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M09_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M09_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M09_L00
; Total bytes of code 62
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L21
M00_L00:
       mov       ecx,ebp
       mov       r14,[rdi+rcx*8+10]
       test      r14,r14
       je        short M00_L01
       mov       r15d,[r14+8]
       xor       ecx,ecx
       test      r15d,r15d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r15d,r15d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L25
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       ecx,ecx
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L29
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF54A1ECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L29
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L31
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       ecx,ecx
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L29
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF54A1ECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L29
M00_L06:
       mov       r8,r14
M00_L07:
       test      r8,r8
       je        near ptr M00_L13
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        near ptr M00_L13
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L12
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L13
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5434D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L11:
       mov       rdx,216CA279084
       mov       r14,[rsi+8]
       mov       r13d,[rsi+18]
       lea       ecx,[r13+2]
       cmp       [r14+8],ecx
       jb        near ptr M00_L22
       jmp       near ptr M00_L19
M00_L12:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5434D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L13:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L18
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L14:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L23
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       xor       r13d,r13d
M00_L16:
       mov       rcx,1D638410E58
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L27
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFF54CCD4E8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L30
       mov       r12d,eax
M00_L17:
       test      r12d,r12d
       jge       near ptr M00_L24
       sub       r15d,r13d
       jo        near ptr M00_L28
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5434D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L10
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       near ptr M00_L11
M00_L18:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5434D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L14
M00_L19:
       movsxd    rcx,r13d
       lea       rcx,[r14+rcx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r13d,2
       mov       [rsi+18],r13d
M00_L20:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L21:
       mov       rcx,rsi
       call      qword ptr [7FFF54352A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54BB5E30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L22:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF5434D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L20
M00_L23:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5434D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L24:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        near ptr M00_L28
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5434D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFF5434D2D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       near ptr M00_L31
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFF5434D2D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L28
       jmp       near ptr M00_L16
M00_L25:
       call      qword ptr [7FFF54694570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L26
       call      qword ptr [7FFF546942B8]
       mov       rbx,rax
M00_L26:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,216CA279CB0
       mov       r8,rbx
       call      qword ptr [7FFF542F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L27:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF54475B60]
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
M00_L29:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF541073F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L30:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1060
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFFB3A97370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFFB3AB0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       je        short M02_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M02_L00:
       ret
M02_L01:
       test      r8b,4
       je        short M02_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L00
M02_L02:
       cmp       r8,40
       ja        short M02_L07
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L06
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L05:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L00
M02_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L04
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L03
       jmp       near ptr M02_L04
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FFF541B5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF5434DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M03_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M04_L03
       cmp       r8d,edi
       jl        near ptr M04_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M04_L01
       test      r8,r8
       je        near ptr M04_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M04_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M04_L00:
       cmp       ebp,r10d
       ja        near ptr M04_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5434DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M04_L07
M04_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53FB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546CEFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFF544757E8]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFF54475800]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M05_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M05_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M05_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M05_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFF5447D380]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M05_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M05_L02:
       cmp       ebx,5
       ja        near ptr M05_L08
       mov       edx,ebx
       lea       r8,[7FFF54C5D4B8]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M05_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M05_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFF5434DE00]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M05_L04
M05_L03:
       call      qword ptr [7FFF544CE730]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M05_L04:
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFF54D56790]
       jmp       short M05_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M05_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M05_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M05_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFF5454C2A0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M05_L07
M05_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFF54CCECB8]
M05_L07:
       jmp       near ptr M05_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D57000]
       jmp       near ptr M05_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D57960]
       jmp       near ptr M05_L01
M05_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFF54527A38]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M05_L01
; Total bytes of code 424
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M06_L04
       test      ebx,ebx
       jl        near ptr M06_L05
       test      rdx,rdx
       je        near ptr M06_L06
       test      ebx,ebx
       je        short M06_L01
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M06_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M06_L03
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L00:
       mov       [rsi+18],edi
M06_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF5434D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M06_L01
M06_L03:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M06_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M06_L00
M06_L04:
       mov       ecx,172D
       mov       rdx,7FFF53FB4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF54BBC1F8]
       int       3
M06_L05:
       mov       ecx,1C7
       mov       rdx,7FFF53FB4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF54BBC1F8]
       int       3
M06_L06:
       or        ebx,edi
       jne       short M06_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L07:
       mov       ecx,2E5
       mov       rdx,7FFF53FB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF542F6790]
       int       3
M06_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF53FB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546CEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M07_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M07_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M07_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M07_L02
       cmp       [rdx+8],r8d
       jb        short M07_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF541B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M07_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53FB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546CEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L03:
       mov       rax,216CA270008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M09_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M09_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF5434D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M09_L00
; Total bytes of code 62
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       mov       ecx,ebp
       mov       r14,[rdi+rcx*8+10]
       test      r14,r14
       je        short M00_L01
       mov       r15d,[r14+8]
       xor       ecx,ecx
       test      r15d,r15d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r15d,r15d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L04
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
M00_L03:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L04:
       call      qword ptr [7FFF549EECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
       jmp       short M00_L03
M00_L05:
       call      qword ptr [7FFF549EECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
M00_L06:
       mov       r8,r14
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5431D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,270E6C0EE60
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFF54C9D9C8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5431D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,2B178979084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFF54322A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54B97090]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5431D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF5431D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5431D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5431D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFF54664570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFF546642B8]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2B178979CB0
       mov       r8,rbx
       call      qword ptr [7FFF542C6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF54445B60]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF540D73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5431D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFF5431D2D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFF5431D2D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1030
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFFB3A97370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFFB3AB0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FFF54185B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
; Total bytes of code 254
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5431DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF5469EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5418D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF544457E8]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF54445800]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M04_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M04_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M04_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M04_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFF5444D380]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M04_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M04_L02:
       cmp       ebx,5
       ja        near ptr M04_L08
       mov       edx,ebx
       lea       r8,[7FFF54C2D868]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M04_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M04_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFF5431DE00]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M04_L04
M04_L03:
       call      qword ptr [7FFF5449E730]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M04_L04:
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFF54D270C0]
       jmp       short M04_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M04_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M04_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M04_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFF5451C2A0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M04_L07
M04_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFF54C9F198]
M04_L07:
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D27930]
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D2C2A0]
       jmp       near ptr M04_L01
M04_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFF544F7A38]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M04_L01
; Total bytes of code 424
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M05_L04
       test      ebx,ebx
       jl        near ptr M05_L05
       test      rdx,rdx
       je        near ptr M05_L06
       test      ebx,ebx
       je        short M05_L03
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M05_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L01
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       mov       [rsi+18],edi
       jmp       short M05_L03
M05_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF5431D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M05_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L04:
       mov       ecx,172D
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF54B9D788]
       int       3
M05_L05:
       mov       ecx,1C7
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF54B9D788]
       int       3
M05_L06:
       or        ebx,edi
       jne       short M05_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L07:
       mov       ecx,2E5
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF542C6790]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF5469EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5418D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M06_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L02
       cmp       [rdx+8],r8d
       jb        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF54185B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53F84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF5469EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5418D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,2B178970008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF5431DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M09_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M09_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF5431D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M09_L00
; Total bytes of code 62
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L21
M00_L00:
       mov       ecx,ebp
       mov       r14,[rdi+rcx*8+10]
       test      r14,r14
       je        short M00_L01
       mov       r15d,[r14+8]
       xor       ecx,ecx
       test      r15d,r15d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r15d,r15d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L25
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L29
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF549FECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L29
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L31
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L29
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF549FECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L29
M00_L06:
       mov       r8,r14
M00_L07:
       test      r8,r8
       je        near ptr M00_L13
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        near ptr M00_L13
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L12
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L13
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L11:
       mov       rdx,26872B49084
       mov       r14,[rsi+8]
       mov       r13d,[rsi+18]
       lea       ecx,[r13+2]
       cmp       [r14+8],ecx
       jb        near ptr M00_L22
       jmp       near ptr M00_L19
M00_L12:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L13:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L18
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L14:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L23
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       xor       r13d,r13d
M00_L16:
       mov       rcx,227E0C0EE60
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L27
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFF54CAD9C8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L30
       mov       r12d,eax
M00_L17:
       test      r12d,r12d
       jge       near ptr M00_L24
       sub       r15d,r13d
       jo        near ptr M00_L28
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5432D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L10
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       near ptr M00_L11
M00_L18:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L14
M00_L19:
       movsxd    rcx,r13d
       lea       rcx,[r14+rcx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r13d,2
       mov       [rsi+18],r13d
M00_L20:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L21:
       mov       rcx,rsi
       call      qword ptr [7FFF54332A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54BA7090]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L22:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L20
M00_L23:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L24:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        near ptr M00_L28
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5432D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFF5432D2D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       near ptr M00_L31
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFF5432D2D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L28
       jmp       near ptr M00_L16
M00_L25:
       call      qword ptr [7FFF54674570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L26
       call      qword ptr [7FFF546742B8]
       mov       rbx,rax
M00_L26:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,26872B49CB0
       mov       r8,rbx
       call      qword ptr [7FFF542D6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L27:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF54455B60]
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
M00_L29:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF540E73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L30:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1056
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFFB3A97370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFFB3AB0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       je        short M02_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M02_L00:
       ret
M02_L01:
       test      r8b,4
       je        short M02_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L00
M02_L02:
       cmp       r8,40
       ja        short M02_L07
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L06
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L05:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L00
M02_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L04
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L03
       jmp       near ptr M02_L04
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FFF54195B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF5432DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M03_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M04_L03
       cmp       r8d,edi
       jl        near ptr M04_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M04_L01
       test      r8,r8
       je        near ptr M04_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M04_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M04_L00:
       cmp       ebp,r10d
       ja        near ptr M04_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5432DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M04_L07
M04_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546AEFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFF544557E8]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFF54455800]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M05_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M05_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M05_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M05_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFF5445D380]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M05_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M05_L02:
       cmp       ebx,5
       ja        near ptr M05_L08
       mov       edx,ebx
       lea       r8,[7FFF54C3DDF8]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M05_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M05_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFF5432DE00]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M05_L04
M05_L03:
       call      qword ptr [7FFF544AE730]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M05_L04:
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFF54D370C0]
       jmp       short M05_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M05_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M05_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M05_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFF5452C2A0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M05_L07
M05_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFF54CAF198]
M05_L07:
       jmp       near ptr M05_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D37930]
       jmp       near ptr M05_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D3C2A0]
       jmp       near ptr M05_L01
M05_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFF54507A38]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M05_L01
; Total bytes of code 424
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M06_L04
       test      ebx,ebx
       jl        near ptr M06_L05
       test      rdx,rdx
       je        near ptr M06_L06
       test      ebx,ebx
       je        short M06_L03
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M06_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M06_L01
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L00:
       mov       [rsi+18],edi
       jmp       short M06_L03
M06_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M06_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M06_L00
M06_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M06_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L04:
       mov       ecx,172D
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF54BAD788]
       int       3
M06_L05:
       mov       ecx,1C7
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF54BAD788]
       int       3
M06_L06:
       or        ebx,edi
       jne       short M06_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L07:
       mov       ecx,2E5
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF542D6790]
       int       3
M06_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546AEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M07_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M07_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M07_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M07_L02
       cmp       [rdx+8],r8d
       jb        short M07_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M07_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546AEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L03:
       mov       rax,26872B40008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M09_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M09_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M09_L00
; Total bytes of code 62
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       mov       ecx,ebp
       mov       r14,[rdi+rcx*8+10]
       test      r14,r14
       je        short M00_L01
       mov       r15d,[r14+8]
       xor       ecx,ecx
       test      r15d,r15d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r15d,r15d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF54A0ECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF54A0ECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
M00_L06:
       mov       r8,r14
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5433D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,1E949403D48
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFF54CBD9C8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5433D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,229D31A9084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFF54342A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54BB7438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5433D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF5433D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5433D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5433D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFF54684570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFF546842B8]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,229D31A9CB0
       mov       r8,rbx
       call      qword ptr [7FFF542E6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF54465B60]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF540F73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5433D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFF5433D2D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFF5433D2D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1030
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFFB3A97370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFFB3AB0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       je        short M02_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M02_L00:
       ret
M02_L01:
       test      r8b,4
       je        short M02_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L00
M02_L02:
       cmp       r8,40
       ja        short M02_L07
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L06
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L05:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L00
M02_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L04
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L03
       jmp       near ptr M02_L04
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FFF541A5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5433DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546BEFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF544657E8]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF54465800]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M04_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M04_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M04_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M04_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFF5446D380]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M04_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M04_L02:
       cmp       ebx,5
       ja        near ptr M04_L08
       mov       edx,ebx
       lea       r8,[7FFF54C4A948]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M04_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M04_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFF5433DE00]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M04_L04
M04_L03:
       call      qword ptr [7FFF544BE730]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M04_L04:
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFF54D470C0]
       jmp       short M04_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M04_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M04_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M04_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFF5453C2A0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M04_L07
M04_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFF54CBF198]
M04_L07:
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D47930]
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D4C2A0]
       jmp       near ptr M04_L01
M04_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFF54517A38]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M04_L01
; Total bytes of code 424
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M05_L04
       test      ebx,ebx
       jl        near ptr M05_L05
       test      rdx,rdx
       je        near ptr M05_L06
       test      ebx,ebx
       je        short M05_L01
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M05_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M05_L03
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       mov       [rsi+18],edi
M05_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF5433D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M05_L01
M05_L04:
       mov       ecx,172D
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF54BBD800]
       int       3
M05_L05:
       mov       ecx,1C7
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF54BBD800]
       int       3
M05_L06:
       or        ebx,edi
       jne       short M05_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L07:
       mov       ecx,2E5
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF542E6790]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546BEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M06_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L02
       cmp       [rdx+8],r8d
       jb        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF541A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53FA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546BEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF541AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,229D31A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF5433DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M09_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M09_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF5433D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M09_L00
; Total bytes of code 62
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       mov       ecx,ebp
       mov       r14,[rdi+rcx*8+10]
       test      r14,r14
       je        short M00_L01
       mov       r15d,[r14+8]
       xor       ecx,ecx
       test      r15d,r15d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r15d,r15d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF549FECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFB3032E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF549FECE8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
M00_L06:
       mov       r8,r14
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,1FEFBC03D48
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFF54CAD9C8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5432D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,23F85C79084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFF54332A28]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF54BA7438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFF54674570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFF546742B8]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23F85C79CB0
       mov       r8,rbx
       call      qword ptr [7FFF542D6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF54455B60]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF540E73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF5432D1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFF5432D2D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFF5432D2D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1030
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFFB3A97370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFFB3AB0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FFF54195B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
; Total bytes of code 254
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF5432DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546AEFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF544557E8]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF54455800]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M04_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M04_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M04_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M04_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFF5445D380]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M04_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M04_L02:
       cmp       ebx,5
       ja        near ptr M04_L08
       mov       edx,ebx
       lea       r8,[7FFF54C39148]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M04_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M04_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFF5432DE00]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M04_L04
M04_L03:
       call      qword ptr [7FFF544AE730]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M04_L04:
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFF54D370C0]
       jmp       short M04_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M04_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M04_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M04_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFF5452C2A0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M04_L07
M04_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFF54CAF198]
M04_L07:
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D37930]
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF54D3C2A0]
       jmp       near ptr M04_L01
M04_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFF54507A38]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M04_L01
; Total bytes of code 424
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M05_L04
       test      ebx,ebx
       jl        near ptr M05_L05
       test      rdx,rdx
       je        near ptr M05_L06
       test      ebx,ebx
       je        short M05_L01
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M05_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M05_L03
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       mov       [rsi+18],edi
M05_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF5432D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M05_L01
M05_L04:
       mov       ecx,172D
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF54BAD800]
       int       3
M05_L05:
       mov       ecx,1C7
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF54BAD800]
       int       3
M05_L06:
       or        ebx,edi
       jne       short M05_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L07:
       mov       ecx,2E5
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF542D6790]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546AEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M06_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L02
       cmp       [rdx+8],r8d
       jb        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF54195B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFF53F94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF546AEEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF5419D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,23F85C70008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF5432DA58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M09_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M09_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF5432D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M09_L00
; Total bytes of code 62
```

