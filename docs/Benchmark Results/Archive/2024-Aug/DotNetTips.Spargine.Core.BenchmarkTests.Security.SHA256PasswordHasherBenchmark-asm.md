## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.FixedTimeEquals()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,22CEF0009F0
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,26D7CE2AAF0
       call      qword ptr [7FFF3A5850C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,26D7CE2AAF0
       call      qword ptr [7FFF3A5850C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF3AAFEC10]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.FixedTimeEquals(Byte[], Byte[])
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
       mov       rax,0D89CD48F42D5
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
       call      qword ptr [7FFF3A507F30]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
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
       call      qword ptr [7FFF3A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L01:
       mov       rcx,0D89CD48F42D5
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
       mov       rax,26D7CE17178
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
       call      qword ptr [7FFF3A35C918]
       mov       r15d,eax
       jmp       near ptr M01_L00
; Total bytes of code 281
```
```assembly
; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.FixedTimeEquals(Byte[], Byte[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+10]
       mov       rdx,26D7CE2AB10
       mov       r8,26D7CE2AB10
       call      qword ptr [7FFF3AAFECD0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       [rbp+10],rax
       mov       rcx,[rbp+18]
       mov       rdx,26D7CE2AB30
       mov       r8,26D7CE2AB30
       call      qword ptr [7FFF3AAFECD0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       [rbp+18],rax
       mov       r8,26D7CE10008
       mov       [rsp+20],r8
       mov       r8,[rbp+10]
       mov       r8d,[r8+8]
       mov       rdx,[rbp+18]
       cmp       r8d,[rdx+8]
       setne     r8b
       movzx     r8d,r8b
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.CheckIsCondition[[System.Byte[], System.Private.CoreLib]](Byte[], Boolean, Boolean, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFF3AAFECE8]; DotNetTips.Spargine.Core.Validator.CheckIsCondition[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, Boolean, System.String)
       test      eax,eax
       je        short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M02_L00:
       xor       eax,eax
       mov       [rbp-4],eax
       xor       eax,eax
       mov       [rbp-8],eax
       jmp       short M02_L02
M02_L01:
       mov       rax,[rbp+10]
       mov       ecx,[rbp-8]
       cmp       ecx,[rax+8]
       jae       short M02_L03
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       movzx     eax,byte ptr [rax]
       mov       rcx,[rbp+18]
       mov       edx,[rbp-8]
       cmp       edx,[rcx+8]
       jae       short M02_L03
       mov       r8d,edx
       lea       rcx,[rcx+r8+10]
       movzx     ecx,byte ptr [rcx]
       sub       eax,ecx
       jo        short M02_L04
       or        eax,[rbp-4]
       mov       [rbp-4],eax
       mov       eax,[rbp-8]
       add       eax,1
       jo        short M02_L04
       mov       [rbp-8],eax
M02_L02:
       mov       eax,[rbp-8]
       mov       rcx,[rbp+10]
       cmp       eax,[rcx+8]
       jl        short M02_L01
       xor       eax,eax
       cmp       dword ptr [rbp-4],0
       sete      al
       add       rsp,30
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 284
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.HashPassword()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,2C3A957AAF0
       call      qword ptr [7FFF3AADE8F8]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
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
; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
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
       je        near ptr M01_L03
       cmp       [rcx],ecx
       call      qword ptr [7FFF3A337318]; System.String.Trim()
       mov       rbx,rax
       mov       ecx,10
       call      qword ptr [7FFF3A875398]; System.Security.Cryptography.RandomNumberGenerator.GetBytes(Int32)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFF3AADE8C8]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String, Byte[])
       mov       rbx,rax
       mov       edi,[rbx+8]
       mov       edx,edi
       add       edx,11
       jo        short M01_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       cmp       dword ptr [rbp+8],0
       jbe       near ptr M01_L05
       mov       byte ptr [rbp+10],1
       mov       dword ptr [rsp+20],10
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFF3A3E5AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],edi
       mov       rcx,rbx
       mov       r8,rbp
       xor       edx,edx
       mov       r9d,11
       call      qword ptr [7FFF3A3E5AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF3A6055D8]; System.Convert.ToBase64String(Byte[])
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       call      qword ptr [7FFF3A87DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFF3A87DC20]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C3A957AB20
       mov       r8,rbx
       call      qword ptr [7FFF3A516670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 290
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.VerifyHashedPassword()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,23CD3B5AAF0
       mov       rcx,rsi
       call      qword ptr [7FFF3AAEE1D8]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFF3AAEE1F0]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.VerifyHashedPassword(System.String, System.String)
       mov       [rsp+20],eax
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFF3AB25068]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
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
       je        near ptr M01_L03
       cmp       [rcx],ecx
       call      qword ptr [7FFF3A347318]; System.String.Trim()
       mov       rbx,rax
       mov       ecx,10
       call      qword ptr [7FFF3A885398]; System.Security.Cryptography.RandomNumberGenerator.GetBytes(Int32)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFF3AAEE1A8]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String, Byte[])
       mov       rbx,rax
       mov       edi,[rbx+8]
       mov       edx,edi
       add       edx,11
       jo        short M01_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       cmp       dword ptr [rbp+8],0
       jbe       near ptr M01_L05
       mov       byte ptr [rbp+10],1
       mov       dword ptr [rsp+20],10
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFF3A3F5AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],edi
       mov       rcx,rbx
       mov       r8,rbp
       xor       edx,edx
       mov       r9d,11
       call      qword ptr [7FFF3A3F5AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF3A615DD0]; System.Convert.ToBase64String(Byte[])
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       call      qword ptr [7FFF3A88DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFF3A88DC20]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23CD3B5AB20
       mov       r8,rbx
       call      qword ptr [7FFF3A526670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 290
```
```assembly
; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.VerifyHashedPassword(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+90],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rsp+90],rax
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M02_L64
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L64
       lea       rdx,[rbx+0C]
       mov       [rsp+90],rdx
       mov       rbp,[rsp+90]
       mov       r14d,edi
       test      r14d,r14d
       jle       short M02_L03
M02_L01:
       lea       edx,[r14-1]
       movsxd    rdx,edx
       movzx     edx,word ptr [rbp+rdx*2]
       cmp       edx,20
       je        short M02_L02
       cmp       edx,0A
       je        short M02_L02
       cmp       edx,0D
       je        short M02_L02
       cmp       edx,9
       jne       short M02_L03
M02_L02:
       dec       r14d
       test      r14d,r14d
       jg        short M02_L01
M02_L03:
       mov       rdx,rbp
       movsxd    rcx,r14d
       lea       r15,[rdx+rcx*2]
       mov       ecx,r14d
       xor       r13d,r13d
       cmp       rbp,r15
       jae       short M02_L06
M02_L04:
       movzx     eax,word ptr [rdx]
       add       rdx,2
       cmp       eax,20
       jbe       near ptr M02_L43
       cmp       eax,3D
       je        short M02_L07
M02_L05:
       cmp       rdx,r15
       jb        short M02_L04
M02_L06:
       test      r13d,r13d
       je        near ptr M02_L41
       cmp       r13d,1
       je        near ptr M02_L44
       cmp       r13d,2
       jne       near ptr M02_L45
       mov       r13d,1
       jmp       near ptr M02_L41
M02_L07:
       dec       ecx
       inc       r13d
       jmp       short M02_L05
M02_L08:
       xor       edx,edx
       mov       [rsp+90],rdx
       cmp       dword ptr [r15+8],11
       jl        near ptr M02_L64
       lea       rdx,[rbx+0C]
       mov       [rsp+80],rdx
       mov       r13,[rsp+80]
       mov       ebp,edi
       test      ebp,ebp
       jle       short M02_L11
M02_L09:
       lea       edx,[rbp-1]
       movsxd    rdx,edx
       movzx     edx,word ptr [r13+rdx*2]
       cmp       edx,20
       je        short M02_L10
       cmp       edx,0A
       je        short M02_L10
       cmp       edx,0D
       je        short M02_L10
       cmp       edx,9
       jne       short M02_L11
M02_L10:
       dec       ebp
       test      ebp,ebp
       jg        short M02_L09
M02_L11:
       mov       rdx,r13
       movsxd    rcx,ebp
       lea       r15,[rdx+rcx*2]
       mov       ecx,ebp
       xor       eax,eax
       cmp       r13,r15
       jae       short M02_L14
M02_L12:
       movzx     r8d,word ptr [rdx]
       add       rdx,2
       cmp       r8d,20
       jbe       near ptr M02_L47
       cmp       r8d,3D
       je        near ptr M02_L40
M02_L13:
       cmp       rdx,r15
       jb        short M02_L12
M02_L14:
       test      eax,eax
       je        short M02_L15
       cmp       eax,1
       je        near ptr M02_L48
       cmp       eax,2
       jne       near ptr M02_L49
       mov       eax,1
M02_L15:
       mov       edx,ecx
       sar       edx,1F
       and       edx,3
       add       edx,ecx
       sar       edx,2
       lea       edx,[rdx+rdx*2]
       add       edx,eax
       movsxd    rdx,edx
       mov       rcx,r12
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       test      ebp,ebp
       jl        near ptr M02_L62
       mov       ecx,ebp
       lea       rdx,[r14+10]
       mov       r8d,[r14+8]
       mov       [rsp+38],r13
       mov       [rsp+40],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+78]
       call      qword ptr [7FFF3A615F08]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L50
       xor       ecx,ecx
       mov       [rsp+80],rcx
       cmp       dword ptr [r14+8],0
       jbe       near ptr M02_L65
       movzx     ecx,byte ptr [r14+10]
       cmp       ecx,1
       jg        near ptr M02_L64
       mov       rcx,r12
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rdx,[rbx+0C]
       mov       [rsp+70],rdx
       mov       r15,[rsp+70]
       mov       ebp,edi
       test      ebp,ebp
       jle       short M02_L18
M02_L16:
       lea       edx,[rbp-1]
       movsxd    rdx,edx
       movzx     edx,word ptr [r15+rdx*2]
       cmp       edx,20
       je        short M02_L17
       cmp       edx,0A
       je        short M02_L17
       cmp       edx,0D
       je        short M02_L17
       cmp       edx,9
       jne       short M02_L18
M02_L17:
       dec       ebp
       test      ebp,ebp
       jg        short M02_L16
M02_L18:
       mov       rdx,r15
       movsxd    rcx,ebp
       lea       r13,[rdx+rcx*2]
       mov       ecx,ebp
       xor       eax,eax
       cmp       r15,r13
       jae       short M02_L21
M02_L19:
       movzx     r8d,word ptr [rdx]
       add       rdx,2
       cmp       r8d,20
       jbe       near ptr M02_L51
       cmp       r8d,3D
       je        near ptr M02_L39
M02_L20:
       cmp       rdx,r13
       jb        short M02_L19
M02_L21:
       test      eax,eax
       je        short M02_L22
       cmp       eax,1
       je        near ptr M02_L52
       cmp       eax,2
       jne       near ptr M02_L53
       mov       eax,1
M02_L22:
       mov       edx,ecx
       sar       edx,1F
       and       edx,3
       add       edx,ecx
       sar       edx,2
       lea       edx,[rdx+rdx*2]
       add       edx,eax
       movsxd    rdx,edx
       mov       rcx,r12
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       test      ebp,ebp
       jl        near ptr M02_L62
       mov       ecx,ebp
       lea       rdx,[r13+10]
       mov       r8d,[r13+8]
       mov       [rsp+38],r15
       mov       [rsp+40],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+68]
       call      qword ptr [7FFF3A615F08]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L54
       xor       ecx,ecx
       mov       [rsp+70],rcx
       mov       dword ptr [rsp+20],10
       mov       rcx,r13
       mov       r8,r14
       mov       edx,1
       xor       r9d,r9d
       call      qword ptr [7FFF3A3F5AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rdx,[rbx+0C]
       mov       [rsp+60],rdx
       mov       rbp,[rsp+60]
       mov       r15d,edi
       test      r15d,r15d
       jle       short M02_L25
M02_L23:
       lea       edx,[r15-1]
       movsxd    rdx,edx
       movzx     edx,word ptr [rbp+rdx*2]
       cmp       edx,20
       je        short M02_L24
       cmp       edx,0A
       je        short M02_L24
       cmp       edx,0D
       je        short M02_L24
       cmp       edx,9
       jne       short M02_L25
M02_L24:
       dec       r15d
       test      r15d,r15d
       jg        short M02_L23
M02_L25:
       mov       rdx,rbp
       movsxd    rcx,r15d
       lea       r13,[rdx+rcx*2]
       mov       ecx,r15d
       xor       eax,eax
       cmp       rbp,r13
       jae       short M02_L28
M02_L26:
       movzx     r8d,word ptr [rdx]
       add       rdx,2
       cmp       r8d,20
       jbe       near ptr M02_L55
       cmp       r8d,3D
       je        near ptr M02_L38
M02_L27:
       cmp       rdx,r13
       jb        short M02_L26
M02_L28:
       test      eax,eax
       je        short M02_L29
       cmp       eax,1
       je        near ptr M02_L56
       cmp       eax,2
       jne       near ptr M02_L57
       mov       eax,1
M02_L29:
       mov       edx,ecx
       sar       edx,1F
       and       edx,3
       add       edx,ecx
       sar       edx,2
       lea       edx,[rdx+rdx*2]
       add       edx,eax
       movsxd    rdx,edx
       mov       rcx,r12
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       test      r15d,r15d
       jl        near ptr M02_L62
       mov       ecx,r15d
       lea       rdx,[r13+10]
       mov       r8d,[r13+8]
       mov       [rsp+38],rbp
       mov       [rsp+40],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+58]
       call      qword ptr [7FFF3A615F08]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L58
       xor       edx,edx
       mov       [rsp+60],rdx
       mov       edx,[r13+8]
       sub       edx,1
       jo        near ptr M02_L42
       sub       edx,10
       jo        near ptr M02_L42
       movsxd    rdx,edx
       mov       rcx,r12
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       add       rbx,0C
       mov       [rsp+50],rbx
       mov       r15,[rsp+50]
       test      edi,edi
       jle       short M02_L32
M02_L30:
       lea       edx,[rdi-1]
       movsxd    rdx,edx
       movzx     edx,word ptr [r15+rdx*2]
       cmp       edx,20
       je        short M02_L31
       cmp       edx,0A
       je        short M02_L31
       cmp       edx,0D
       je        short M02_L31
       cmp       edx,9
       jne       short M02_L32
M02_L31:
       dec       edi
       test      edi,edi
       jg        short M02_L30
M02_L32:
       mov       rdx,r15
       movsxd    rcx,edi
       lea       rbx,[rdx+rcx*2]
       mov       ecx,edi
       xor       r13d,r13d
       cmp       r15,rbx
       jae       short M02_L35
       nop       dword ptr [rax+rax]
M02_L33:
       movzx     eax,word ptr [rdx]
       add       rdx,2
       cmp       eax,20
       jbe       near ptr M02_L59
       cmp       eax,3D
       je        near ptr M02_L37
M02_L34:
       cmp       rdx,rbx
       jb        short M02_L33
M02_L35:
       test      r13d,r13d
       je        short M02_L36
       cmp       r13d,1
       je        near ptr M02_L60
       cmp       r13d,2
       jne       near ptr M02_L61
       mov       r13d,1
M02_L36:
       mov       edx,ecx
       sar       edx,1F
       and       edx,3
       add       edx,ecx
       sar       edx,2
       lea       edx,[rdx+rdx*2]
       add       edx,r13d
       movsxd    rdx,edx
       mov       rcx,r12
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       test      edi,edi
       jl        near ptr M02_L62
       mov       ecx,edi
       lea       rdx,[r12+10]
       mov       r8d,[r12+8]
       mov       [rsp+38],r15
       mov       [rsp+40],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+48]
       call      qword ptr [7FFF3A615F08]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L63
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       ecx,[rbp+8]
       mov       [rsp+20],ecx
       mov       rcx,r12
       mov       r8,rbp
       mov       edx,11
       xor       r9d,r9d
       call      qword ptr [7FFF3A3F5AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFF3AAEE1A8]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String, Byte[])
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FFF3AAEE1C0]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.FixedTimeEquals(Byte[], Byte[])
       test      eax,eax
       je        near ptr M02_L64
       mov       eax,1
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L37:
       dec       ecx
       inc       r13d
       jmp       near ptr M02_L34
M02_L38:
       dec       ecx
       inc       eax
       jmp       near ptr M02_L27
M02_L39:
       dec       ecx
       inc       eax
       jmp       near ptr M02_L20
M02_L40:
       dec       ecx
       inc       eax
       jmp       near ptr M02_L13
M02_L41:
       mov       edx,ecx
       sar       edx,1F
       and       edx,3
       add       edx,ecx
       sar       edx,2
       lea       edx,[rdx+rdx*2]
       add       edx,r13d
       movsxd    rdx,edx
       mov       r12,offset MT_System.Byte[]
       mov       rcx,r12
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       test      r14d,r14d
       jl        near ptr M02_L62
       lea       rcx,[r15+10]
       mov       edx,[r15+8]
       mov       [rsp+38],rbp
       mov       [rsp+40],r14d
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+88]
       call      qword ptr [7FFF3A615F08]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M02_L46
       jmp       near ptr M02_L08
M02_L42:
       call      CORINFO_HELP_OVERFLOW
M02_L43:
       dec       ecx
       jmp       near ptr M02_L05
M02_L44:
       mov       r13d,2
       jmp       near ptr M02_L41
M02_L45:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF3A84FC78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF3A577450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L46:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF3A84FC78]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF3A577450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L47:
       dec       ecx
       jmp       near ptr M02_L13
M02_L48:
       mov       eax,2
       jmp       near ptr M02_L15
M02_L49:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF3A84FC78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF3A577450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L50:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF3A84FC78]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF3A577450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L51:
       dec       ecx
       jmp       near ptr M02_L20
M02_L52:
       mov       eax,2
       jmp       near ptr M02_L22
M02_L53:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF3A84FC78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF3A577450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L54:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF3A84FC78]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF3A577450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L55:
       dec       ecx
       jmp       near ptr M02_L27
M02_L56:
       mov       eax,2
       jmp       near ptr M02_L29
M02_L57:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF3A84FC78]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF3A577450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L58:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFF3A84FC78]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF3A577450]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M02_L59:
       dec       ecx
       jmp       near ptr M02_L34
M02_L60:
       mov       r13d,2
       jmp       near ptr M02_L36
M02_L61:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF3A84FC78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF3A577450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L62:
       call      qword ptr [7FFF3A4FE9A0]
       int       3
M02_L63:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF3A84FC78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF3A577450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L64:
       xor       eax,eax
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L65:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2185
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       ret
; Total bytes of code 1
```

