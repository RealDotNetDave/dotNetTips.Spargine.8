## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.HashTest()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFE5CD7C048]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
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
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+50],rcx
       mov       rcx,[rsp+50]
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
       call      qword ptr [7FFE5C4D7318]; System.String.Trim()
       mov       [rsp+50],rax
       mov       ecx,10
       call      qword ptr [7FFE5C974F48]; System.Security.Cryptography.RandomNumberGenerator.GetBytes(Int32)
       mov       [rsp+28],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE5CD7C018]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String ByRef, Byte[] ByRef)
       mov       rbx,rax
       mov       esi,[rbx+8]
       mov       edx,esi
       add       edx,11
       jo        short M01_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       cmp       dword ptr [rdi+8],0
       jbe       near ptr M01_L05
       mov       byte ptr [rdi+10],1
       mov       rcx,[rsp+28]
       mov       dword ptr [rsp+20],10
       mov       r8,rdi
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFE5C585AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],esi
       mov       rcx,rbx
       mov       r8,rdi
       xor       edx,edx
       mov       r9d,11
       call      qword ptr [7FFE5C585AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rdi
       call      qword ptr [7FFE5C7D45E8]; System.Convert.ToBase64String(Byte[])
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       call      qword ptr [7FFE5C97FC00]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE5C97F948]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1FE35C84380
       mov       r8,rbx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 311
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.FixedTimeEquals()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,271AE0009F0
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,2B23BCB4380
       call      qword ptr [7FFE5C7650C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,2B23BCB4380
       call      qword ptr [7FFE5C7650C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5CDAC030]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.FixedTimeEquals(Byte[], Byte[])
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
       mov       rax,9561DAACC89
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
       call      qword ptr [7FFE5C6F7F30]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
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
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L01:
       mov       rcx,9561DAACC89
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
       mov       rax,2B23BCA7178
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
       call      qword ptr [7FFE5C50C918]
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
       mov       rdx,2B23BCB43A0
       mov       r8,2B23BCB43A0
       call      qword ptr [7FFE5CDAC0F0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       [rbp+10],rax
       mov       rcx,[rbp+18]
       mov       rdx,2B23BCB43C0
       mov       r8,2B23BCB43C0
       call      qword ptr [7FFE5CDAC0F0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.HashPassword()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,28B61AF4380
       call      qword ptr [7FFE5CD67450]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
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
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+50],rcx
       mov       rcx,[rsp+50]
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       je        near ptr M01_L03
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C4C7318]; System.String.Trim()
       mov       [rsp+50],rax
       mov       ecx,10
       call      qword ptr [7FFE5C964F48]; System.Security.Cryptography.RandomNumberGenerator.GetBytes(Int32)
       mov       [rsp+28],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE5CD67420]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String ByRef, Byte[] ByRef)
       mov       rbx,rax
       mov       esi,[rbx+8]
       mov       edx,esi
       add       edx,11
       jo        short M01_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       cmp       dword ptr [rdi+8],0
       jbe       near ptr M01_L05
       mov       byte ptr [rdi+10],1
       mov       rcx,[rsp+28]
       mov       dword ptr [rsp+20],10
       mov       r8,rdi
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFE5C575AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],esi
       mov       rcx,rbx
       mov       r8,rdi
       xor       edx,edx
       mov       r9d,11
       call      qword ptr [7FFE5C575AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rdi
       call      qword ptr [7FFE5C7C45E8]; System.Convert.ToBase64String(Byte[])
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       call      qword ptr [7FFE5C96FC00]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE5C96F948]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28B61AF43B0
       mov       r8,rbx
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 312
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.SHA256PasswordHasherBenchmark.VerifyHashedPassword()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,2A1AEC24380
       mov       [rsp+38],rcx
       mov       rcx,[rsp+38]
       call      qword ptr [7FFE5CD77CF0]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
       mov       [rsp+30],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+38]
       call      qword ptr [7FFE5CD77D08]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.VerifyHashedPassword(System.String ByRef, System.String ByRef)
       mov       [rsp+28],eax
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5CD7C7C8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       nop
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 90
```
```assembly
; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+50],rcx
       mov       rcx,[rsp+50]
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
       call      qword ptr [7FFE5C4D7318]; System.String.Trim()
       mov       [rsp+50],rax
       mov       ecx,10
       call      qword ptr [7FFE5C974F48]; System.Security.Cryptography.RandomNumberGenerator.GetBytes(Int32)
       mov       [rsp+28],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE5CD77CC0]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String ByRef, Byte[] ByRef)
       mov       rbx,rax
       mov       esi,[rbx+8]
       mov       edx,esi
       add       edx,11
       jo        short M01_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       cmp       dword ptr [rdi+8],0
       jbe       near ptr M01_L05
       mov       byte ptr [rdi+10],1
       mov       rcx,[rsp+28]
       mov       dword ptr [rsp+20],10
       mov       r8,rdi
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFE5C585AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],esi
       mov       rcx,rbx
       mov       r8,rdi
       xor       edx,edx
       mov       r9d,11
       call      qword ptr [7FFE5C585AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rdi
       call      qword ptr [7FFE5C7D45E8]; System.Convert.ToBase64String(Byte[])
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       call      qword ptr [7FFE5C97FC00]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE5C97F948]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2A1AEC243B0
       mov       r8,rbx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 311
```
```assembly
; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.VerifyHashedPassword(System.String ByRef, System.String ByRef)
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
       mov       rdx,[rbx]
       test      rdx,rdx
       je        near ptr M02_L66
       cmp       dword ptr [rdx+8],0
       je        near ptr M02_L66
       mov       rdx,[rbx]
       test      rdx,rdx
       je        near ptr M02_L59
       lea       rcx,[rdx+0C]
       mov       [rsp+0C0],rcx
       mov       rdi,[rsp+0C0]
       mov       ebp,[rdx+8]
       test      ebp,ebp
       jle       short M02_L03
M02_L01:
       lea       edx,[rbp-1]
       movsxd    rdx,edx
       movzx     edx,word ptr [rdi+rdx*2]
       cmp       edx,20
       je        short M02_L02
       cmp       edx,0A
       je        short M02_L02
       cmp       edx,0D
       je        short M02_L02
       cmp       edx,9
       jne       short M02_L03
M02_L02:
       dec       ebp
       test      ebp,ebp
       jg        short M02_L01
M02_L03:
       mov       rdx,rdi
       movsxd    rcx,ebp
       lea       r14,[rdx+rcx*2]
       mov       ecx,ebp
       xor       r15d,r15d
       cmp       rdi,r14
       jae       short M02_L06
M02_L04:
       movzx     eax,word ptr [rdx]
       add       rdx,2
       cmp       eax,20
       jbe       near ptr M02_L43
       cmp       eax,3D
       je        short M02_L07
M02_L05:
       cmp       rdx,r14
       jb        short M02_L04
M02_L06:
       test      r15d,r15d
       je        near ptr M02_L41
       cmp       r15d,1
       je        near ptr M02_L44
       cmp       r15d,2
       jne       near ptr M02_L45
       mov       r15d,1
       jmp       near ptr M02_L41
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M02_L07:
       dec       ecx
       inc       r15d
       jmp       short M02_L05
M02_L08:
       xor       edx,edx
       mov       [rsp+0C0],rdx
       cmp       dword ptr [r14+8],11
       jb        near ptr M02_L66
       mov       rdx,[rbx]
       test      rdx,rdx
       je        near ptr M02_L59
       lea       rcx,[rdx+0C]
       mov       [rsp+0B0],rcx
       mov       r15,[rsp+0B0]
       mov       edi,[rdx+8]
       test      edi,edi
       jle       short M02_L11
M02_L09:
       lea       edx,[rdi-1]
       movsxd    rdx,edx
       movzx     edx,word ptr [r15+rdx*2]
       cmp       edx,20
       je        short M02_L10
       cmp       edx,0A
       je        short M02_L10
       cmp       edx,0D
       je        short M02_L10
       cmp       edx,9
       jne       short M02_L11
M02_L10:
       dec       edi
       test      edi,edi
       jg        short M02_L09
M02_L11:
       mov       rdx,r15
       movsxd    rcx,edi
       lea       r14,[rdx+rcx*2]
       mov       ecx,edi
       xor       r12d,r12d
       cmp       r15,r14
       jae       short M02_L14
M02_L12:
       movzx     eax,word ptr [rdx]
       add       rdx,2
       cmp       eax,20
       jbe       near ptr M02_L47
       cmp       eax,3D
       je        near ptr M02_L40
M02_L13:
       cmp       rdx,r14
       jb        short M02_L12
M02_L14:
       test      r12d,r12d
       je        short M02_L15
       cmp       r12d,1
       je        near ptr M02_L48
       cmp       r12d,2
       jne       near ptr M02_L49
       mov       r12d,1
M02_L15:
       mov       edx,ecx
       sar       edx,1F
       and       edx,3
       add       edx,ecx
       sar       edx,2
       lea       edx,[rdx+rdx*2]
       add       edx,r12d
       movsxd    rdx,edx
       mov       rcx,r13
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       test      edi,edi
       jl        near ptr M02_L63
       mov       ecx,edi
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+60],r15
       mov       [rsp+68],ecx
       mov       [rsp+50],rdx
       mov       [rsp+58],r8d
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+0A8]
       call      qword ptr [7FFE5C7D4720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L50
       xor       ecx,ecx
       mov       [rsp+0B0],rcx
       cmp       dword ptr [rbp+8],0
       jbe       near ptr M02_L67
       movzx     ecx,byte ptr [rbp+10]
       cmp       ecx,1
       jg        near ptr M02_L66
       mov       rcx,r13
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rdx,[rbx]
       test      rdx,rdx
       je        near ptr M02_L59
       lea       rcx,[rdx+0C]
       mov       [rsp+0A0],rcx
       mov       r14,[rsp+0A0]
       mov       r15d,[rdx+8]
       test      r15d,r15d
       jle       short M02_L18
M02_L16:
       lea       edx,[r15-1]
       movsxd    rdx,edx
       movzx     edx,word ptr [r14+rdx*2]
       cmp       edx,20
       je        short M02_L17
       cmp       edx,0A
       je        short M02_L17
       cmp       edx,0D
       je        short M02_L17
       cmp       edx,9
       jne       short M02_L18
M02_L17:
       dec       r15d
       test      r15d,r15d
       jg        short M02_L16
M02_L18:
       mov       rdx,r14
       movsxd    rcx,r15d
       lea       rax,[rdx+rcx*2]
       mov       ecx,r15d
       xor       r8d,r8d
       cmp       r14,rax
       jae       short M02_L21
M02_L19:
       movzx     r10d,word ptr [rdx]
       add       rdx,2
       cmp       r10d,20
       jbe       near ptr M02_L51
       cmp       r10d,3D
       je        near ptr M02_L39
M02_L20:
       cmp       rdx,rax
       jb        short M02_L19
M02_L21:
       test      r8d,r8d
       je        short M02_L22
       cmp       r8d,1
       je        near ptr M02_L52
       cmp       r8d,2
       jne       near ptr M02_L53
       mov       r8d,1
M02_L22:
       mov       edx,ecx
       sar       edx,1F
       and       edx,3
       add       edx,ecx
       sar       edx,2
       lea       edx,[rdx+rdx*2]
       add       edx,r8d
       movsxd    rdx,edx
       mov       rcx,r13
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       test      r15d,r15d
       jl        near ptr M02_L63
       mov       ecx,r15d
       lea       rdx,[r12+10]
       mov       r8d,[r12+8]
       mov       [rsp+60],r14
       mov       [rsp+68],ecx
       mov       [rsp+50],rdx
       mov       [rsp+58],r8d
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+98]
       call      qword ptr [7FFE5C7D4720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L54
       xor       ecx,ecx
       mov       [rsp+0A0],rcx
       mov       dword ptr [rsp+20],10
       mov       rcx,r12
       mov       r8,rbp
       mov       edx,1
       xor       r9d,r9d
       call      qword ptr [7FFE5C585AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rdx,[rbx]
       test      rdx,rdx
       je        near ptr M02_L59
       cmp       [rdx],dl
       lea       rcx,[rdx+0C]
       mov       [rsp+90],rcx
       mov       rdi,[rsp+90]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       jle       short M02_L25
M02_L23:
       lea       edx,[r14-1]
       movsxd    rdx,edx
       movzx     edx,word ptr [rdi+rdx*2]
       cmp       edx,20
       je        short M02_L24
       cmp       edx,0A
       je        short M02_L24
       cmp       edx,0D
       je        short M02_L24
       cmp       edx,9
       jne       short M02_L25
M02_L24:
       dec       r14d
       test      r14d,r14d
       jg        short M02_L23
M02_L25:
       mov       rdx,rdi
       movsxd    rcx,r14d
       lea       r12,[rdx+rcx*2]
       mov       ecx,r14d
       xor       eax,eax
       cmp       rdi,r12
       jae       short M02_L28
M02_L26:
       movzx     r8d,word ptr [rdx]
       add       rdx,2
       cmp       r8d,20
       jbe       near ptr M02_L55
       cmp       r8d,3D
       je        near ptr M02_L38
M02_L27:
       cmp       rdx,r12
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
       mov       rcx,r13
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       test      r14d,r14d
       jl        near ptr M02_L63
       mov       ecx,r14d
       lea       rdx,[r15+10]
       mov       r8d,[r15+8]
       mov       [rsp+60],rdi
       mov       [rsp+68],ecx
       mov       [rsp+50],rdx
       mov       [rsp+58],r8d
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+88]
       call      qword ptr [7FFE5C7D4720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L58
       xor       edx,edx
       mov       [rsp+90],rdx
       mov       edx,[r15+8]
       sub       edx,1
       jo        near ptr M02_L42
       sub       edx,10
       jo        near ptr M02_L42
       movsxd    rdx,edx
       mov       rcx,r13
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rdx,[rbx]
       test      rdx,rdx
       je        near ptr M02_L59
       cmp       [rdx],dl
       lea       rcx,[rdx+0C]
       mov       [rsp+80],rcx
       mov       rbx,[rsp+80]
       mov       r15d,[rdx+8]
       test      r15d,r15d
       jle       short M02_L32
M02_L30:
       lea       edx,[r15-1]
       movsxd    rdx,edx
       movzx     edx,word ptr [rbx+rdx*2]
       cmp       edx,20
       je        short M02_L31
       cmp       edx,0A
       je        short M02_L31
       cmp       edx,0D
       je        short M02_L31
       cmp       edx,9
       jne       short M02_L32
M02_L31:
       dec       r15d
       test      r15d,r15d
       jg        short M02_L30
M02_L32:
       mov       rdx,rbx
       movsxd    rcx,r15d
       lea       rax,[rdx+rcx*2]
       mov       ecx,r15d
       xor       r8d,r8d
       cmp       rbx,rax
       jae       short M02_L35
M02_L33:
       movzx     r10d,word ptr [rdx]
       add       rdx,2
       cmp       r10d,20
       jbe       near ptr M02_L60
       cmp       r10d,3D
       je        near ptr M02_L37
M02_L34:
       cmp       rdx,rax
       jb        short M02_L33
M02_L35:
       test      r8d,r8d
       je        short M02_L36
       cmp       r8d,1
       je        near ptr M02_L61
       cmp       r8d,2
       jne       near ptr M02_L62
       mov       r8d,1
M02_L36:
       mov       edx,ecx
       sar       edx,1F
       and       edx,3
       add       edx,ecx
       sar       edx,2
       lea       edx,[rdx+rdx*2]
       add       edx,r8d
       movsxd    rdx,edx
       mov       rcx,r13
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       test      r15d,r15d
       jl        near ptr M02_L63
       mov       ecx,r15d
       lea       rdx,[r12+10]
       mov       r8d,[r12+8]
       mov       [rsp+60],rbx
       mov       [rsp+68],ecx
       mov       [rsp+50],rdx
       mov       [rsp+58],r8d
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+78]
       call      qword ptr [7FFE5C7D4720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L64
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       ecx,[rdi+8]
       mov       [rsp+20],ecx
       mov       rcx,r12
       mov       r8,rdi
       mov       edx,11
       xor       r9d,r9d
       call      qword ptr [7FFE5C585AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rdx,[rsi]
       imul      edx,[rdx+8],2
       jo        near ptr M02_L42
       add       edx,10
       jo        near ptr M02_L42
       movsxd    rdx,edx
       mov       rcx,r13
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rsp+20],10
       mov       rcx,rbp
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFE5C585AE8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14
       mov       dword ptr [rsp+28],10
       mov       r9,[rsi]
       mov       r9d,[r9+8]
       mov       rdx,[rsi]
       mov       rcx,26120C009F0
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE5C6B0B58]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       lea       rsi,[r14+10]
       mov       ebp,[r14+8]
       mov       rcx,r13
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       lea       rdx,[r13+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M02_L65
       xor       ecx,ecx
       mov       [rsp+40],rsi
       mov       [rsp+48],ebp
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
       mov       rcx,2A1AEC19070
       xor       r9d,r9d
       call      qword ptr [7FFE5CD7C3F0]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       mov       rcx,r13
       mov       rdx,rdi
       call      qword ptr [7FFE5CD77CD8]; DotNetTips.Spargine.Core.Security.SHA256PasswordHasher.FixedTimeEquals(Byte[], Byte[])
       test      eax,eax
       je        near ptr M02_L66
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
M02_L37:
       dec       ecx
       inc       r8d
       jmp       near ptr M02_L34
M02_L38:
       dec       ecx
       inc       eax
       jmp       near ptr M02_L27
M02_L39:
       dec       ecx
       inc       r8d
       jmp       near ptr M02_L20
M02_L40:
       dec       ecx
       inc       r12d
       jmp       near ptr M02_L13
M02_L41:
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
       test      ebp,ebp
       jl        near ptr M02_L63
       mov       ecx,ebp
       lea       rdx,[r14+10]
       mov       r8d,[r14+8]
       mov       [rsp+60],rdi
       mov       [rsp+68],ecx
       mov       [rsp+50],rdx
       mov       [rsp+58],r8d
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+0B8]
       call      qword ptr [7FFE5C7D4720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M02_L46
       jmp       near ptr M02_L08
M02_L42:
       call      CORINFO_HELP_OVERFLOW
M02_L43:
       dec       ecx
       jmp       near ptr M02_L05
M02_L44:
       mov       r15d,2
       jmp       near ptr M02_L41
M02_L45:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1EC88]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C7374B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L46:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA1EC88]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C7374B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L47:
       dec       ecx
       jmp       near ptr M02_L13
M02_L48:
       mov       r12d,2
       jmp       near ptr M02_L15
M02_L49:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1EC88]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C7374B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L50:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA1EC88]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C7374B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L51:
       dec       ecx
       jmp       near ptr M02_L20
M02_L52:
       mov       r8d,2
       jmp       near ptr M02_L22
M02_L53:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1EC88]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C7374B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L54:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA1EC88]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C7374B0]
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
       call      qword ptr [7FFE5CA1EC88]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C7374B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L58:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE5CA1EC88]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5C7374B0]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M02_L59:
       mov       ecx,11
       call      qword ptr [7FFE5C6CED00]
       int       3
M02_L60:
       dec       ecx
       jmp       near ptr M02_L34
M02_L61:
       mov       r8d,2
       jmp       near ptr M02_L36
M02_L62:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1EC88]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C7374B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L63:
       call      qword ptr [7FFE5C6CE9D0]
       int       3
M02_L64:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1EC88]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C7374B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L65:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CDAE520]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FFE5C981DA8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C4DF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L66:
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
M02_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2619
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       ret
; Total bytes of code 1
```

