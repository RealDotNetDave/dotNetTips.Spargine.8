## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.FixedTimeEquals()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,2AAC80009F0
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,2EB59F5AB58
       call      qword ptr [7FFBF97950C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,2EB59F5AB58
       call      qword ptr [7FFBF97950C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBF9D0D440]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.FixedTimeEquals(Byte[], Byte[])
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
       mov       rax,4B2737315396
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
       call      qword ptr [7FFBF9727F30]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
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
       call      qword ptr [7FFBF9615B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L01:
       mov       rcx,4B2737315396
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
       mov       rax,2EB59F47178
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
       call      qword ptr [7FFBF956C918]
       mov       r15d,eax
       jmp       near ptr M01_L00
; Total bytes of code 281
```
```assembly
; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.FixedTimeEquals(Byte[], Byte[])
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-14],xmm4
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+10]
       mov       rdx,2EB59F5AB78
       mov       r8,2EB59F5AB78
       call      qword ptr [7FFBF9D0D500]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       [rbp+10],rax
       mov       rcx,[rbp+18]
       mov       rdx,2EB59F5AB98
       mov       r8,2EB59F5AB98
       call      qword ptr [7FFBF9D0D500]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,[rbp+10]
       mov       eax,[rax+8]
       cdqe
       mov       rcx,[rbp+18]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       cmp       rax,rcx
       je        short M02_L00
       xor       eax,eax
       add       rsp,40
       pop       rbp
       ret
M02_L00:
       xor       eax,eax
       mov       [rbp-4],eax
       mov       rax,[rbp+10]
       mov       eax,[rax+8]
       cdqe
       mov       [rbp-10],rax
       xor       eax,eax
       mov       [rbp-14],eax
       jmp       short M02_L02
M02_L01:
       mov       rax,[rbp+10]
       mov       ecx,[rbp-14]
       cmp       ecx,[rax+8]
       jae       short M02_L03
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       movzx     eax,byte ptr [rax]
       mov       rcx,[rbp+18]
       mov       edx,[rbp-14]
       cmp       edx,[rcx+8]
       jae       short M02_L03
       mov       r8d,edx
       lea       rcx,[rcx+r8+10]
       movzx     ecx,byte ptr [rcx]
       sub       eax,ecx
       jo        short M02_L04
       or        eax,[rbp-4]
       mov       [rbp-4],eax
       mov       eax,[rbp-14]
       add       eax,1
       jo        short M02_L04
       mov       [rbp-14],eax
M02_L02:
       mov       eax,[rbp-14]
       cdqe
       cmp       rax,[rbp-10]
       jl        short M02_L01
       xor       eax,eax
       cmp       dword ptr [rbp-4],0
       sete      al
       add       rsp,40
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 260
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.HashPassword()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,272FDD3AB58
       call      qword ptr [7FFBF9D0C708]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
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
       call      qword ptr [7FFBF9567318]; System.String.Trim()
       mov       rbx,rax
       mov       ecx,10
       call      qword ptr [7FFBF9AB4468]; System.Security.Cryptography.RandomNumberGenerator.GetBytes(Int32)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9D0C6D8]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String, Byte[])
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
       call      qword ptr [7FFBF9615AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],edi
       mov       rcx,rbx
       mov       r8,rbp
       xor       edx,edx
       mov       r9d,11
       call      qword ptr [7FFBF9615AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rbp
       call      qword ptr [7FFBF98345E8]; System.Convert.ToBase64String(Byte[])
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       call      qword ptr [7FFBF9ABCD68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFBF9ABCAC8]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,272FDD3AB88
       mov       r8,rbx
       call      qword ptr [7FFBF9756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 292
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.VerifyHashedPassword()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,2111507AB58
       mov       rcx,rsi
       call      qword ptr [7FFBF9CDCD08]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFBF9CDCD20]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.VerifyHashedPassword(System.String, System.String)
       mov       [rsp+20],eax
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFBF9CDD590]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
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
       call      qword ptr [7FFBF9537318]; System.String.Trim()
       mov       rbx,rax
       mov       ecx,10
       call      qword ptr [7FFBF9A84468]; System.Security.Cryptography.RandomNumberGenerator.GetBytes(Int32)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9CDCCD8]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String, Byte[])
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
       call      qword ptr [7FFBF95E5AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],edi
       mov       rcx,rbx
       mov       r8,rbp
       xor       edx,edx
       mov       r9d,11
       call      qword ptr [7FFBF95E5AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rbp
       call      qword ptr [7FFBF98045E8]; System.Convert.ToBase64String(Byte[])
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       call      qword ptr [7FFBF9A8CD68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFBF9A8CAC8]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2111507AB88
       mov       r8,rbx
       call      qword ptr [7FFBF9726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 292
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
       sub       rsp,0C8
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rsp+0C0],rax
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M02_L67
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L67
       lea       rdx,[rbx+0C]
       mov       [rsp+0C0],rdx
       mov       rbp,[rsp+0C0]
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
       nop       dword ptr [rax]
M02_L04:
       movzx     eax,word ptr [rdx]
       add       rdx,2
       cmp       eax,20
       jbe       near ptr M02_L45
       cmp       eax,3D
       je        short M02_L07
M02_L05:
       cmp       rdx,r15
       jb        short M02_L04
M02_L06:
       test      r13d,r13d
       je        near ptr M02_L42
       cmp       r13d,1
       je        near ptr M02_L46
       cmp       r13d,2
       jne       near ptr M02_L47
       mov       r13d,1
       jmp       near ptr M02_L42
M02_L07:
       dec       ecx
       inc       r13d
       jmp       short M02_L05
M02_L08:
       xor       edx,edx
       mov       [rsp+0C0],rdx
       cmp       dword ptr [r15+8],11
       jb        near ptr M02_L67
       lea       rdx,[rbx+0C]
       mov       [rsp+0B0],rdx
       mov       r13,[rsp+0B0]
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
       jbe       near ptr M02_L49
       cmp       r8d,3D
       je        near ptr M02_L41
M02_L13:
       cmp       rdx,r15
       jb        short M02_L12
M02_L14:
       test      eax,eax
       je        short M02_L15
       cmp       eax,1
       je        near ptr M02_L50
       cmp       eax,2
       jne       near ptr M02_L51
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
       jl        near ptr M02_L64
       mov       ecx,ebp
       lea       rdx,[r14+10]
       mov       r8d,[r14+8]
       mov       [rsp+60],r13
       mov       [rsp+68],ecx
       mov       [rsp+50],rdx
       mov       [rsp+58],r8d
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+0A8]
       call      qword ptr [7FFBF9804720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L52
       xor       ecx,ecx
       mov       [rsp+0B0],rcx
       cmp       dword ptr [r14+8],0
       jbe       near ptr M02_L68
       movzx     ecx,byte ptr [r14+10]
       cmp       ecx,1
       jg        near ptr M02_L67
       mov       rcx,r12
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rdx,[rbx+0C]
       mov       [rsp+0A0],rdx
       mov       r15,[rsp+0A0]
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
       jbe       near ptr M02_L53
       cmp       r8d,3D
       je        near ptr M02_L40
M02_L20:
       cmp       rdx,r13
       jb        short M02_L19
M02_L21:
       test      eax,eax
       je        short M02_L22
       cmp       eax,1
       je        near ptr M02_L54
       cmp       eax,2
       jne       near ptr M02_L55
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
       jl        near ptr M02_L64
       mov       ecx,ebp
       lea       rdx,[r13+10]
       mov       r8d,[r13+8]
       mov       [rsp+60],r15
       mov       [rsp+68],ecx
       mov       [rsp+50],rdx
       mov       [rsp+58],r8d
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+98]
       call      qword ptr [7FFBF9804720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L56
       xor       ecx,ecx
       mov       [rsp+0A0],rcx
       mov       dword ptr [rsp+20],10
       mov       rcx,r13
       mov       r8,r14
       mov       edx,1
       xor       r9d,r9d
       call      qword ptr [7FFBF95E5AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rdx,[rbx+0C]
       mov       [rsp+90],rdx
       mov       rbp,[rsp+90]
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
       jbe       near ptr M02_L57
       cmp       r8d,3D
       je        near ptr M02_L39
M02_L27:
       cmp       rdx,r13
       jb        short M02_L26
M02_L28:
       test      eax,eax
       je        short M02_L29
       cmp       eax,1
       je        near ptr M02_L58
       cmp       eax,2
       jne       near ptr M02_L59
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
       jl        near ptr M02_L64
       mov       ecx,r15d
       lea       rdx,[r13+10]
       mov       r8d,[r13+8]
       mov       [rsp+60],rbp
       mov       [rsp+68],ecx
       mov       [rsp+50],rdx
       mov       [rsp+58],r8d
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+88]
       call      qword ptr [7FFBF9804720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L60
       xor       edx,edx
       mov       [rsp+90],rdx
       mov       edx,[r13+8]
       sub       edx,1
       jo        near ptr M02_L44
       sub       edx,10
       jo        near ptr M02_L44
       movsxd    rdx,edx
       mov       rcx,r12
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       add       rbx,0C
       mov       [rsp+80],rbx
       mov       r15,[rsp+80]
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
       jbe       near ptr M02_L61
       cmp       eax,3D
       je        near ptr M02_L38
M02_L34:
       cmp       rdx,rbx
       jb        short M02_L33
M02_L35:
       test      r13d,r13d
       je        short M02_L36
       cmp       r13d,1
       je        near ptr M02_L62
       cmp       r13d,2
       jne       near ptr M02_L63
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
       mov       rbx,rax
       test      edi,edi
       jl        near ptr M02_L64
       mov       ecx,edi
       lea       rdx,[rbx+10]
       mov       r8d,[rbx+8]
       mov       [rsp+60],r15
       mov       [rsp+68],ecx
       mov       [rsp+50],rdx
       mov       [rsp+58],r8d
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+78]
       call      qword ptr [7FFBF9804720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L65
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       ecx,[rbp+8]
       mov       [rsp+20],ecx
       mov       rcx,rbx
       mov       r8,rbp
       mov       edx,11
       xor       r9d,r9d
       call      qword ptr [7FFBF95E5AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,1D0870009F0
       mov       rcx,[rcx]
       test      rsi,rsi
       je        near ptr M02_L43
       cmp       dword ptr [rsi+8],20
       jg        near ptr M02_L43
       mov       rdx,rsi
       call      qword ptr [7FFBF97650C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       r13,rax
M02_L37:
       mov       edx,[r13+8]
       add       edx,10
       jo        near ptr M02_L44
       movsxd    rdx,edx
       mov       rcx,r12
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFBF95E5AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r9d,[r13+8]
       mov       [rsp+20],r9d
       mov       r9d,10
       mov       rcx,r13
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FFBF95E5AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       r14,[rsi+10]
       mov       edi,[rsi+8]
       mov       rcx,r12
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rdx,[r12+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M02_L66
       xor       ecx,ecx
       mov       [rsp+40],r14
       mov       [rsp+48],edi
       mov       [rsp+30],rcx
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       [rsp+50],rdx
       mov       [rsp+58],r8d
       lea       rdx,[rsp+70]
       mov       [rsp+28],rdx
       lea       rdx,[rsp+50]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       mov       rcx,21115069070
       xor       r9d,r9d
       call      qword ptr [7FFBF9CDD1B8]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       mov       rcx,r12
       mov       rdx,rbp
       call      qword ptr [7FFBF9CDCCF0]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.FixedTimeEquals(Byte[], Byte[])
       test      eax,eax
       je        near ptr M02_L67
       mov       eax,1
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L38:
       dec       ecx
       inc       r13d
       jmp       near ptr M02_L34
M02_L39:
       dec       ecx
       inc       eax
       jmp       near ptr M02_L27
M02_L40:
       dec       ecx
       inc       eax
       jmp       near ptr M02_L20
M02_L41:
       dec       ecx
       inc       eax
       jmp       near ptr M02_L13
M02_L42:
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
       jl        near ptr M02_L64
       lea       rcx,[r15+10]
       mov       edx,[r15+8]
       mov       [rsp+60],rbp
       mov       [rsp+68],r14d
       mov       [rsp+50],rcx
       mov       [rsp+58],edx
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+0B8]
       call      qword ptr [7FFBF9804720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M02_L48
       jmp       near ptr M02_L08
M02_L43:
       mov       rdx,rsi
       call      qword ptr [7FFBF95C0180]; Precode of System.Text.Encoding.GetBytes(System.String)
       mov       r13,rax
       jmp       near ptr M02_L37
M02_L44:
       call      CORINFO_HELP_OVERFLOW
M02_L45:
       dec       ecx
       jmp       near ptr M02_L05
M02_L46:
       mov       r13d,2
       jmp       near ptr M02_L42
M02_L47:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9A3FC78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9767450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L48:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9A3FC78]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9767450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L49:
       dec       ecx
       jmp       near ptr M02_L13
M02_L50:
       mov       eax,2
       jmp       near ptr M02_L15
M02_L51:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9A3FC78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9767450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L52:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9A3FC78]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9767450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L53:
       dec       ecx
       jmp       near ptr M02_L20
M02_L54:
       mov       eax,2
       jmp       near ptr M02_L22
M02_L55:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9A3FC78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9767450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L56:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9A3FC78]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9767450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L57:
       dec       ecx
       jmp       near ptr M02_L27
M02_L58:
       mov       eax,2
       jmp       near ptr M02_L29
M02_L59:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9A3FC78]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9767450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L60:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFBF9A3FC78]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBF9767450]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M02_L61:
       dec       ecx
       jmp       near ptr M02_L34
M02_L62:
       mov       r13d,2
       jmp       near ptr M02_L36
M02_L63:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9A3FC78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9767450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L64:
       call      qword ptr [7FFBF96FE9D0]
       int       3
M02_L65:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9A3FC78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9767450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L66:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9D844E0]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FFBF9A7B6E0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBF953F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L67:
       xor       eax,eax
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L68:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2543
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       ret
; Total bytes of code 1
```

