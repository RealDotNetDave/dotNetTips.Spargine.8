## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PBKDF2PasswordHasherBenchmark.FixedTimeEquals()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,2BD608009F0
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,2FDEE5346E8
       call      qword ptr [7FFE5C7550C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,2FDEE5346E8
       call      qword ptr [7FFE5C7550C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C9549A8]; DotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.FixedTimeEquals(Byte[], Byte[])
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+40]
       mov       rax,6F775357F3C7
       mov       [rbp+8],rax
       mov       rbx,rcx
       test      [rsp],esp
       sub       rsp,60
       lea       rsi,[rsp+40]
       mov       edi,[rdx+8]
       add       rdx,0C
       mov       [rbp+20],rdx
       mov       r14,[rbp+20]
       cmp       [rbx],bl
       lea       rcx,[rbp+18]
       mov       [rsp+20],rcx
       lea       rcx,[rbp+10]
       mov       [rsp+28],rcx
       mov       rcx,r14
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,60
       call      qword ptr [7FFE5C6E7F30]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rax,[rbp+18]
       sub       rax,r14
       mov       r8,rax
       shr       r8,3F
       add       rax,r8
       sar       rax,1
       mov       r15,[rbp+10]
       sub       r15,rsi
       cmp       eax,edi
       jne       short M01_L04
M01_L00:
       xor       edx,edx
       mov       [rbp+20],rdx
       test      r15d,r15d
       je        short M01_L03
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,r15d
       mov       rdx,rsi
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L01:
       mov       rcx,6F775357F3C7
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rax,2FDEE527178
       jmp       short M01_L01
M01_L04:
       mov       dword ptr [rsp+20],60
       mov       [rsp+28],eax
       mov       [rsp+30],r15d
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8d,edi
       mov       r9,rsi
       call      qword ptr [7FFE5C4FC918]
       mov       r15d,eax
       jmp       near ptr M01_L00
; Total bytes of code 281
```
```assembly
; DotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.FixedTimeEquals(Byte[], Byte[])
       push      rbp
       sub       rsp,60
       vzeroupper
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+10]
       mov       rdx,2FDEE534708
       mov       r8,2FDEE534708
       call      qword ptr [7FFE5CD9FAB0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       [rbp+10],rax
       mov       rcx,[rbp+18]
       mov       rdx,2FDEE534728
       mov       r8,2FDEE534728
       call      qword ptr [7FFE5CD9FAB0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,[rbp+10]
       mov       eax,[rax+8]
       mov       rcx,[rbp+18]
       cmp       eax,[rcx+8]
       je        short M02_L00
       xor       eax,eax
       add       rsp,60
       pop       rbp
       ret
M02_L00:
       lea       rcx,[rbp-10]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE5C5AC750]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Byte[])
       lea       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE5C5AC750]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-10]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-20]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       lea       rcx,[rbp-30]
       lea       rdx,[rbp-40]
       call      qword ptr [7FFE5CD540D8]; System.Security.Cryptography.CryptographicOperations.FixedTimeEquals(System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 206
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PBKDF2PasswordHasherBenchmark.HashPassword()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,203678AAF90
       call      qword ptr [7FFE5C9249C0]; DotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.HashPassword(System.String)
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
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.HashPassword(System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       vzeroupper
       lea       rbp,[rsp+100]
       xor       edx,edx
       mov       [rbp-88],rdx
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rdx
       mov       [rbp-0E0],rsp
       mov       rbx,rcx
       lea       rcx,[rbp-0C8]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0A8],rcx
       mov       rcx,rbp
       mov       [rbp-98],rcx
       test      rbx,rbx
       je        near ptr M01_L14
       mov       [rbp+10],rbx
       mov       rcx,offset MT_System.Byte[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       [rbp-80],rdi
       lea       rdx,[rdi+10]
       mov       r8d,10
       test      r8d,r8d
       jle       short M01_L02
       mov       [rbp-40],rdx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0B8],rax
       lea       rax,[M01_L00]
       mov       [rbp-0A0],rax
       lea       rax,[rbp-0C8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFEEBA43670
       call      rax
M01_L00:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFEBC3940DC],0
       je        short M01_L01
       call      qword ptr [7FFEBC3843A8]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rcx,[rbp-0C0]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L15
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L02:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rdi,[rbp-80]
       mov       [rbp-68],rdi
       mov       rcx,offset MT_System.Security.Cryptography.Rfc2898DeriveBytes
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1C2D9C009F0
       mov       rcx,[rcx]
       mov       rbx,[rbp+10]
       mov       rdx,rbx
       mov       rax,offset MT_System.Text.UTF8Encoding+UTF8EncodingSealed
       cmp       [rcx],rax
       jne       near ptr M01_L16
       cmp       dword ptr [rdx+8],20
       jg        short M01_L03
       call      qword ptr [7FFE5C7250C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rbx,rax
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFE5C550180]; Precode of System.Text.Encoding.GetBytes(System.String)
       mov       rbx,rax
M01_L04:
       mov       rax,rbx
       test      rax,rax
       je        near ptr M01_L17
M01_L05:
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
       mov       r13,rdi
       add       r13,10
       mov       r12d,10
       lea       edx,[r12+4]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       lea       rdx,[rcx+10]
       mov       ecx,[rcx+8]
       cmp       r12d,ecx
       ja        near ptr M01_L18
       mov       r8d,r12d
       mov       rcx,rdx
       mov       rdx,r13
       call      qword ptr [7FFE5C575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       dword ptr [rsi+20],0C350
       mov       rcx,203678A9070
       mov       [rsi+38],rcx
       lea       rcx,[rsi+10]
       mov       [rbp-88],rcx
       mov       [rbp-50],r14
       mov       [rbp-48],r15d
       mov       rcx,rsi
       lea       rdx,[rbp-50]
       call      qword ptr [7FFE5CC7D428]; System.Security.Cryptography.Rfc2898DeriveBytes.OpenHmac(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rbp-88]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+10]
       mov       edx,[rdx+18]
       mov       [rsi+24],edx
       cmp       qword ptr [rsi+18],0
       jne       near ptr M01_L19
M01_L06:
       movsxd    rdx,dword ptr [rsi+24]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+28],ecx
       mov       [rsi+30],ecx
       mov       [rsi+2C],ecx
       lea       rcx,[rbx+10]
       mov       eax,[rbx+8]
       mov       [rbp-60],rcx
       mov       [rbp-58],eax
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE5CC7FDB0]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       [rbp-78],rsi
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       edx,20
       mov       rax,rsi
       mov       [rbp-60],rcx
       mov       [rbp-58],edx
       mov       rcx,rax
       lea       rdx,[rbp-60]
       call      qword ptr [7FFE5CC7D3E0]; System.Security.Cryptography.Rfc2898DeriveBytes.GetBytes(System.Span`1<Byte>)
       mov       [rbp-70],rbx
       mov       rcx,rsp
       call      M01_L20
       jmp       near ptr M01_L10
M01_L07:
       mov       r8d,[rax+8]
M01_L08:
       cmp       rbx,10
       jb        near ptr M01_L11
       cmp       r8,11
       jb        near ptr M01_L11
       lea       rcx,[rax+10]
       inc       rcx
       add       rdi,10
       vmovdqu   xmm0,xmmword ptr [rdi]
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rbx,[rbp-70]
       test      rbx,rbx
       je        near ptr M01_L12
       mov       ecx,[rbx+8]
       mov       rdx,rcx
       cmp       rbx,rax
       je        short M01_L09
       mov       edx,[rax+8]
M01_L09:
       cmp       rcx,20
       jb        near ptr M01_L13
       cmp       rdx,31
       jb        near ptr M01_L13
       lea       rcx,[rax+10]
       add       rcx,11
       add       rbx,10
       vmovdqu   ymm0,ymmword ptr [rbx]
       vmovdqu   ymmword ptr [rcx],ymm0
       add       rax,10
       mov       ecx,31
       mov       [rbp-50],rax
       mov       [rbp-48],ecx
       lea       rcx,[rbp-50]
       xor       edx,edx
       call      qword ptr [7FFE5C7C5E30]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
       nop
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       mov       rcx,offset MT_System.Byte[]
       mov       edx,31
       call      CORINFO_HELP_NEWARR_1_VC
       mov       byte ptr [rax+10],1
       mov       rdi,[rbp-68]
       mov       ebx,[rdi+8]
       mov       r8,rbx
       cmp       rdi,rax
       je        near ptr M01_L08
       jmp       near ptr M01_L07
M01_L11:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE5CA0D200]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C4CF708]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       ecx,18F
       mov       rdx,7FFE5C374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C6E66E8]
       int       3
M01_L13:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA0D200]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4CF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       call      qword ptr [7FFE5C99FB58]
       mov       ecx,1B36
       mov       rdx,7FFE5C7DB178
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7DB178
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7DB178
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C99F948]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFE5CC2E340]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       mov       rbx,rax
       mov       rax,rbx
       test      rax,rax
       jne       near ptr M01_L05
M01_L17:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7D9B
       mov       rdx,7FFE5C91EC20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C6E6640]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       call      qword ptr [7FFE5C6BE9E8]
       int       3
M01_L19:
       mov       rcx,[rsi+18]
       call      qword ptr [7FFE5C4174B0]; System.Array.Clear(System.Array)
       jmp       near ptr M01_L06
M01_L20:
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
       lea       rbp,[rbp+100]
       mov       rsi,[rbp-78]
       mov       rbx,[rsi+10]
       test      rbx,rbx
       je        near ptr M01_L28
       mov       byte ptr [rbx+1C],1
       cmp       qword ptr [rbx+8],0
       je        short M01_L21
       mov       rdi,[rbx+8]
       mov       rcx,rdi
       mov       edx,1
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rdi
       call      qword ptr [7FFE5C70C2E8]; System.GC.SuppressFinalize(System.Object)
       xor       edx,edx
       mov       [rbx+8],rdx
M01_L21:
       mov       rdi,[rbx+10]
       test      rdi,rdi
       je        near ptr M01_L27
       mov       r14,[rdi+18]
       test      r14,r14
       je        near ptr M01_L26
       mov       rcx,offset MT_System.Security.Cryptography.HashProviderCng
       cmp       [r14],rcx
       jne       short M01_L25
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L22
       xor       eax,eax
       mov       [r14+10],rax
       call      qword ptr [7FFE5C552AE0]; System.Runtime.InteropServices.SafeHandle.Dispose()
M01_L22:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L26
       xor       edx,edx
       mov       [r14+18],rdx
       mov       rdx,[rcx]
       movzx     r8d,word ptr [rdx]
       mov       eax,[rcx+8]
       imul      rax,r8
       add       rcx,10
       test      dword ptr [rdx],1000000
       jne       short M01_L24
       test      rax,rax
       je        short M01_L26
       cmp       rax,300
       ja        short M01_L23
       xor       edx,edx
       mov       r8d,eax
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L26
M01_L23:
       mov       rdx,rax
       call      qword ptr [7FFE5C575BA8]
       jmp       short M01_L26
M01_L24:
       mov       rdx,rax
       shr       rdx,3
       call      qword ptr [7FFE5C575290]
       jmp       short M01_L26
M01_L25:
       mov       rcx,r14
       mov       edx,1
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
M01_L26:
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rbx+10],rcx
M01_L27:
       xor       ecx,ecx
       mov       [rsi+10],rcx
M01_L28:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M01_L31
       mov       rdx,[rcx]
       movzx     r8d,word ptr [rdx]
       mov       eax,[rcx+8]
       imul      rax,r8
       add       rcx,10
       test      dword ptr [rdx],1000000
       jne       short M01_L30
       test      rax,rax
       je        short M01_L31
       cmp       rax,300
       ja        short M01_L29
       xor       edx,edx
       mov       r8d,eax
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L31
M01_L29:
       mov       rdx,rax
       call      qword ptr [7FFE5C575BA8]
       jmp       short M01_L31
M01_L30:
       mov       rdx,rax
       shr       rdx,3
       call      qword ptr [7FFE5C575290]
M01_L31:
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M01_L34
       mov       rdx,[rcx]
       movzx     r8d,word ptr [rdx]
       mov       eax,[rcx+8]
       imul      rax,r8
       add       rcx,10
       test      dword ptr [rdx],1000000
       jne       short M01_L33
       test      rax,rax
       je        short M01_L34
       cmp       rax,300
       ja        short M01_L32
       xor       edx,edx
       mov       r8d,eax
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L34
M01_L32:
       mov       rdx,rax
       call      qword ptr [7FFE5C575BA8]
       jmp       short M01_L34
M01_L33:
       mov       rdx,rax
       shr       rdx,3
       call      qword ptr [7FFE5C575290]
M01_L34:
       mov       rcx,rsi
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
; Total bytes of code 1789
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PBKDF2PasswordHasherBenchmark.VerifyHashedPassword()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+118]
       mov       rdx,282F7C4AF90
       mov       [rsp+28],rdx
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE5C9349D8]; DotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.VerifyHashedPassword(System.String ByRef, System.String ByRef)
       mov       [rsp+20],eax
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE5CDA42D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.VerifyHashedPassword(System.String ByRef, System.String ByRef)
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
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-0B0],rsp
       mov       rbx,rdx
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M01_L31
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L31
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M01_L13
       lea       rcx,[rdx+0C]
       mov       [rbp-40],rcx
       mov       rsi,[rbp-40]
       mov       edi,[rdx+8]
       test      edi,edi
       jle       short M01_L03
M01_L01:
       lea       edx,[rdi-1]
       movsxd    rdx,edx
       movzx     edx,word ptr [rsi+rdx*2]
       cmp       edx,20
       je        short M01_L02
       cmp       edx,0A
       je        short M01_L02
       cmp       edx,0D
       je        short M01_L02
       cmp       edx,9
       jne       short M01_L03
M01_L02:
       dec       edi
       test      edi,edi
       jg        short M01_L01
M01_L03:
       mov       rdx,rsi
       movsxd    rcx,edi
       lea       r14,[rdx+rcx*2]
       mov       ecx,edi
       xor       r15d,r15d
       cmp       rsi,r14
       jae       short M01_L06
       nop       dword ptr [rax+rax]
M01_L04:
       movzx     eax,word ptr [rdx]
       add       rdx,2
       cmp       eax,20
       jbe       near ptr M01_L14
       cmp       eax,3D
       je        near ptr M01_L12
M01_L05:
       cmp       rdx,r14
       jb        short M01_L04
M01_L06:
       test      r15d,r15d
       je        short M01_L07
       cmp       r15d,1
       je        near ptr M01_L15
       cmp       r15d,2
       jne       near ptr M01_L16
       mov       r15d,1
M01_L07:
       mov       edx,ecx
       sar       edx,1F
       and       edx,3
       add       edx,ecx
       sar       edx,2
       lea       edx,[rdx+rdx*2]
       add       edx,r15d
       movsxd    rdx,edx
       mov       r13,offset MT_System.Byte[]
       mov       rcx,r13
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       test      edi,edi
       jl        near ptr M01_L17
       mov       ecx,edi
       lea       rdx,[r14+10]
       mov       r8d,[r14+8]
       mov       [rbp-58],rsi
       mov       [rbp-50],ecx
       mov       [rbp-68],rdx
       mov       [rbp-60],r8d
       lea       rcx,[rbp-58]
       lea       rdx,[rbp-68]
       lea       r8,[rbp-48]
       call      qword ptr [7FFE5C7D4720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M01_L18
       xor       ecx,ecx
       mov       [rbp-40],rcx
       cmp       dword ptr [r14+8],31
       jl        near ptr M01_L31
       movzx     ecx,byte ptr [r14+10]
       cmp       ecx,1
       jg        near ptr M01_L31
       mov       rcx,r13
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       ecx,[r14+8]
       mov       rdx,rcx
       cmp       r14,r15
       je        short M01_L08
       mov       edx,[r15+8]
M01_L08:
       cmp       rcx,11
       jb        near ptr M01_L19
       cmp       rdx,10
       jb        near ptr M01_L19
       lea       rcx,[r15+10]
       lea       rdx,[r14+10]
       inc       rdx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,r13
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-90],rax
       mov       ecx,[r14+8]
       mov       rdx,rcx
       cmp       r14,rax
       je        short M01_L09
       mov       edx,[rax+8]
M01_L09:
       cmp       rcx,31
       jb        near ptr M01_L20
       cmp       rdx,20
       jb        near ptr M01_L20
       lea       rcx,[rax+10]
       add       r14,10
       add       r14,11
       vmovdqu   ymm0,ymmword ptr [r14]
       vmovdqu   ymmword ptr [rcx],ymm0
       mov       rbx,[rbx]
       mov       rcx,offset MT_System.Security.Cryptography.Rfc2898DeriveBytes
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,24269C009F0
       mov       rcx,[rcx]
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M01_L21
       mov       rax,offset MT_System.Text.UTF8Encoding+UTF8EncodingSealed
       cmp       [rcx],rax
       jne       near ptr M01_L27
       cmp       dword ptr [rdx+8],20
       jg        near ptr M01_L22
       call      qword ptr [7FFE5C7350C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rbx,rax
M01_L10:
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M01_L28
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       add       r15,10
       mov       r12d,10
       lea       edx,[r12+4]
       movsxd    rdx,edx
       mov       rcx,r13
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       lea       rdx,[rcx+10]
       mov       ecx,[rcx+8]
       cmp       r12d,ecx
       ja        near ptr M01_L29
       mov       r8d,r12d
       mov       rcx,rdx
       mov       rdx,r15
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       dword ptr [rsi+20],0C350
       mov       rcx,282F7C49070
       mov       [rsi+38],rcx
       lea       rcx,[rsi+10]
       mov       [rbp-0A8],rcx
       mov       [rbp-78],rdi
       mov       [rbp-70],r14d
       mov       rcx,rsi
       lea       rdx,[rbp-78]
       call      qword ptr [7FFE5CC8D758]; System.Security.Cryptography.Rfc2898DeriveBytes.OpenHmac(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rbp-0A8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+10]
       mov       edx,[rdx+18]
       mov       [rsi+24],edx
       cmp       qword ptr [rsi+18],0
       jne       near ptr M01_L30
M01_L11:
       movsxd    rdx,dword ptr [rsi+24]
       mov       rcx,r13
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+28],ecx
       mov       [rsi+30],ecx
       mov       [rsi+2C],ecx
       lea       rcx,[rbx+10]
       mov       eax,[rbx+8]
       mov       [rbp-68],rcx
       mov       [rbp-60],eax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE5CD340F0]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       [rbp-0A0],rsi
       jmp       near ptr M01_L23
M01_L12:
       dec       ecx
       inc       r15d
       jmp       near ptr M01_L05
M01_L13:
       mov       ecx,11
       call      qword ptr [7FFE5C6CED00]
       int       3
M01_L14:
       dec       ecx
       jmp       near ptr M01_L05
M01_L15:
       mov       r15d,2
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1EC88]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C7374B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       call      qword ptr [7FFE5C6CE9D0]
       int       3
M01_L18:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1EC88]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C7374B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1D200]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4DF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1D200]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4DF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,7D9B
       mov       rdx,7FFE5C92EC20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C6F6640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L22:
       call      qword ptr [7FFE5C560180]; Precode of System.Text.Encoding.GetBytes(System.String)
       mov       rbx,rax
       jmp       near ptr M01_L10
M01_L23:
       mov       rcx,r13
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       edx,20
       mov       rax,rsi
       mov       [rbp-68],rcx
       mov       [rbp-60],edx
       mov       rcx,rax
       lea       rdx,[rbp-68]
       call      qword ptr [7FFE5CC8D710]; System.Security.Cryptography.Rfc2898DeriveBytes.GetBytes(System.Span`1<Byte>)
       mov       [rbp-98],rbx
       mov       rcx,rsp
       call      M01_L32
       jmp       short M01_L26
M01_L24:
       lea       rdi,[r8+10]
       mov       esi,[r8+8]
M01_L25:
       mov       [rbp-78],rax
       mov       [rbp-70],ebx
       mov       [rbp-88],rdi
       mov       [rbp-80],esi
       lea       rcx,[rbp-78]
       lea       rdx,[rbp-88]
       call      qword ptr [7FFE5CD340D8]; System.Security.Cryptography.CryptographicOperations.FixedTimeEquals(System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>)
       test      eax,eax
       je        near ptr M01_L31
       mov       eax,1
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
M01_L26:
       mov       rax,[rbp-90]
       add       rax,10
       mov       ebx,20
       mov       r8,[rbp-98]
       test      r8,r8
       jne       short M01_L24
       xor       edi,edi
       xor       esi,esi
       jmp       short M01_L25
M01_L27:
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       mov       rbx,rax
       jmp       near ptr M01_L10
M01_L28:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7D9B
       mov       rdx,7FFE5C92EC20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C6F6640]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       call      qword ptr [7FFE5C6CE9E8]
       int       3
M01_L30:
       mov       rcx,[rsi+18]
       call      qword ptr [7FFE5C4274B0]; System.Array.Clear(System.Array)
       jmp       near ptr M01_L11
M01_L31:
       xor       eax,eax
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
M01_L32:
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
       mov       rsi,[rbp-0A0]
       mov       rbx,[rsi+10]
       test      rbx,rbx
       je        near ptr M01_L40
       mov       byte ptr [rbx+1C],1
       cmp       qword ptr [rbx+8],0
       je        short M01_L33
       mov       rdi,[rbx+8]
       mov       rcx,rdi
       mov       edx,1
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rdi
       call      qword ptr [7FFE5C71C2E8]; System.GC.SuppressFinalize(System.Object)
       xor       edx,edx
       mov       [rbx+8],rdx
M01_L33:
       mov       rdi,[rbx+10]
       test      rdi,rdi
       je        near ptr M01_L39
       mov       r13,[rdi+18]
       test      r13,r13
       je        near ptr M01_L38
       mov       rcx,offset MT_System.Security.Cryptography.HashProviderCng
       cmp       [r13],rcx
       jne       short M01_L37
       mov       rcx,[r13+10]
       test      rcx,rcx
       je        short M01_L34
       xor       eax,eax
       mov       [r13+10],rax
       call      qword ptr [7FFE5C562AE0]; System.Runtime.InteropServices.SafeHandle.Dispose()
M01_L34:
       mov       rcx,[r13+18]
       test      rcx,rcx
       je        short M01_L38
       xor       edx,edx
       mov       [r13+18],rdx
       mov       rdx,[rcx]
       movzx     r8d,word ptr [rdx]
       mov       eax,[rcx+8]
       imul      rax,r8
       add       rcx,10
       test      dword ptr [rdx],1000000
       jne       short M01_L36
       test      rax,rax
       je        short M01_L38
       cmp       rax,300
       ja        short M01_L35
       xor       edx,edx
       mov       r8d,eax
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L38
M01_L35:
       mov       rdx,rax
       call      qword ptr [7FFE5C585BA8]
       jmp       short M01_L38
M01_L36:
       mov       rdx,rax
       shr       rdx,3
       call      qword ptr [7FFE5C585290]
       jmp       short M01_L38
M01_L37:
       mov       rcx,r13
       mov       edx,1
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
M01_L38:
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rbx+10],rcx
M01_L39:
       xor       ecx,ecx
       mov       [rsi+10],rcx
M01_L40:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M01_L43
       mov       rdx,[rcx]
       movzx     r8d,word ptr [rdx]
       mov       eax,[rcx+8]
       imul      rax,r8
       add       rcx,10
       test      dword ptr [rdx],1000000
       jne       short M01_L42
       test      rax,rax
       je        short M01_L43
       cmp       rax,300
       ja        short M01_L41
       xor       edx,edx
       mov       r8d,eax
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L43
M01_L41:
       mov       rdx,rax
       call      qword ptr [7FFE5C585BA8]
       jmp       short M01_L43
M01_L42:
       mov       rdx,rax
       shr       rdx,3
       call      qword ptr [7FFE5C585290]
M01_L43:
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M01_L46
       mov       rdx,[rcx]
       movzx     r8d,word ptr [rdx]
       mov       eax,[rcx+8]
       imul      rax,r8
       add       rcx,10
       test      dword ptr [rdx],1000000
       jne       short M01_L45
       test      rax,rax
       je        short M01_L46
       cmp       rax,300
       ja        short M01_L44
       xor       edx,edx
       mov       r8d,eax
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L46
M01_L44:
       mov       rdx,rax
       call      qword ptr [7FFE5C585BA8]
       jmp       short M01_L46
M01_L45:
       mov       rdx,rax
       shr       rdx,3
       call      qword ptr [7FFE5C585290]
M01_L46:
       mov       rcx,rsi
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
; Total bytes of code 1962
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       ret
; Total bytes of code 1
```

