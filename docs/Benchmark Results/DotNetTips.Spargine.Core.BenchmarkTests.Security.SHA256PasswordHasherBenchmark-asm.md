## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.HashTest()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       call      qword ptr [7FF9836FDDE8]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
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
       call      qword ptr [7FF982E57318]; System.String.Trim()
       mov       rbx,rax
       mov       ecx,10
       call      qword ptr [7FF9832F57D0]; System.Security.Cryptography.RandomNumberGenerator.GetBytes(Int32)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9836FDDB8]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String, Byte[])
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
       call      qword ptr [7FF982F05AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],edi
       mov       rcx,rbx
       mov       r8,rbp
       xor       edx,edx
       mov       r9d,11
       call      qword ptr [7FF982F05AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9831545E8]; System.Convert.ToBase64String(Byte[])
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       call      qword ptr [7FF983364570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FF9833642B8]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,220102645A8
       mov       r8,rbx
       call      qword ptr [7FF983076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 290
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.FixedTimeEquals()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,2388EC009F0
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,2791CA545A8
       call      qword ptr [7FF9830D50C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,2791CA545A8
       call      qword ptr [7FF9830D50C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF98370DDD0]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.FixedTimeEquals(Byte[], Byte[])
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
       mov       rax,92C7F60493CD
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
       call      qword ptr [7FF983057F30]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
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
       call      qword ptr [7FF982F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L01:
       mov       rcx,92C7F60493CD
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
       mov       rax,2791CA47178
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
       call      qword ptr [7FF982E6C918]
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
       mov       rdx,2791CA545C8
       mov       r8,2791CA545C8
       call      qword ptr [7FF98370DE90]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       [rbp+10],rax
       mov       rcx,[rbp+18]
       mov       rdx,2791CA545E8
       mov       r8,2791CA545E8
       call      qword ptr [7FF98370DE90]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,[rbp+10]
       mov       eax,[rax+8]
       mov       rcx,[rbp+18]
       cmp       eax,[rcx+8]
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
       xor       eax,ecx
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
; Total bytes of code 232
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.HashPassword()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,253917D45A8
       call      qword ptr [7FF9836FDB78]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
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
       call      qword ptr [7FF982E57318]; System.String.Trim()
       mov       rbx,rax
       mov       ecx,10
       call      qword ptr [7FF9832F57D0]; System.Security.Cryptography.RandomNumberGenerator.GetBytes(Int32)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9836FDB48]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String, Byte[])
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
       call      qword ptr [7FF982F05AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],edi
       mov       rcx,rbx
       mov       r8,rbp
       xor       edx,edx
       mov       r9d,11
       call      qword ptr [7FF982F05AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9831545E8]; System.Convert.ToBase64String(Byte[])
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       call      qword ptr [7FF983364570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FF9833642B8]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,253917D45D8
       mov       r8,rbx
       call      qword ptr [7FF983076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 290
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.VerifyHashedPassword()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,28236B845A8
       mov       [rsp+28],rcx
       mov       rcx,[rsp+28]
       call      qword ptr [7FF9836FDDE8]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
       mov       rcx,rax
       lea       rdx,[rsp+28]
       call      qword ptr [7FF9836FDE00]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.VerifyHashedPassword(System.String, System.String ByRef)
       mov       [rsp+20],eax
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9836FE658]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 76
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
       call      qword ptr [7FF982E57318]; System.String.Trim()
       mov       rbx,rax
       mov       ecx,10
       call      qword ptr [7FF9832F57D0]; System.Security.Cryptography.RandomNumberGenerator.GetBytes(Int32)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9836FDDB8]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String, Byte[])
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
       call      qword ptr [7FF982F05AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],edi
       mov       rcx,rbx
       mov       r8,rbp
       xor       edx,edx
       mov       r9d,11
       call      qword ptr [7FF982F05AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9831545E8]; System.Convert.ToBase64String(Byte[])
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       call      qword ptr [7FF983364570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FF9833642B8]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28236B845D8
       mov       r8,rbx
       call      qword ptr [7FF983076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 290
```
```assembly
; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.VerifyHashedPassword(System.String, System.String ByRef)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,80
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M02_L02
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L02
       imul      edx,edi,3
       jo        near ptr M02_L00
       mov       ecx,edx
       sar       ecx,1F
       and       ecx,3
       add       edx,ecx
       sar       edx,2
       movsxd    rdx,edx
       mov       rbp,offset MT_System.Byte[]
       mov       rcx,rbp
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       edx,[r14+8]
       add       rbx,0C
       mov       [rsp+60],rbx
       mov       [rsp+68],edi
       mov       [rsp+50],rcx
       mov       [rsp+58],edx
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+78]
       call      qword ptr [7FF983154720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L02
       mov       ecx,[rsp+78]
       cmp       ecx,11
       jl        near ptr M02_L02
       cmp       dword ptr [r14+8],0
       jbe       near ptr M02_L03
       movzx     ecx,byte ptr [r14+10]
       cmp       ecx,1
       jg        near ptr M02_L02
       mov       rcx,rbp
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       mov       r8,rbx
       mov       edx,1
       xor       r9d,r9d
       call      qword ptr [7FF982F05AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsp+78]
       sub       edx,1
       jo        near ptr M02_L00
       sub       edx,10
       jo        near ptr M02_L00
       movsxd    rdx,edx
       mov       rcx,rbp
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ecx,[rdi+8]
       mov       [rsp+20],ecx
       mov       rcx,r14
       mov       r8,rdi
       mov       edx,11
       xor       r9d,r9d
       call      qword ptr [7FF982F05AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rsi,[rsi]
       imul      edx,[rsi+8],2
       jo        near ptr M02_L00
       add       edx,10
       jo        near ptr M02_L00
       movsxd    rdx,edx
       mov       rcx,rbp
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rsp+20],10
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF982F05AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14
       mov       dword ptr [rsp+28],10
       mov       rcx,241A8C009F0
       mov       rcx,[rcx]
       mov       r9d,[rsi+8]
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF983031688]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       lea       rbx,[r14+10]
       mov       esi,[r14+8]
       mov       rcx,rbp
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       rdx,[rbp+10]
       mov       r8d,20
       cmp       r8d,20
       jl        short M02_L01
       xor       ecx,ecx
       mov       [rsp+40],rbx
       mov       [rsp+48],esi
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
       mov       rcx,28236B79070
       xor       r9d,r9d
       call      qword ptr [7FF9836FE280]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF9836FDDD0]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.FixedTimeEquals(Byte[], Byte[])
       test      eax,eax
       je        short M02_L02
       mov       eax,1
       add       rsp,80
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
M02_L01:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF983754420]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FF983302FC8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF982E5F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       xor       eax,eax
       add       rsp,80
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 679
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       ret
; Total bytes of code 1
```

