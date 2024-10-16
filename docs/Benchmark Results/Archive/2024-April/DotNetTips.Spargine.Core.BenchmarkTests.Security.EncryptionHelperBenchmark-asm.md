## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesDecrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       mov       rdx,[rbx+128]
       mov       r8,[rbx+120]
       call      qword ptr [7FFE94B4F180]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0F0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0F8],rsp
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rdi+8],0
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       dword ptr [rdi+8],0
       jne       short M01_L02
       jmp       short M01_L02
M01_L01:
       xor       ecx,ecx
M01_L02:
       test      ecx,ecx
       je        near ptr M01_L67
       cmp       dword ptr [rdi+8],0
       je        short M01_L06
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jae       short M01_L03
       mov       rax,7FFEF36A2C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L68
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFE94F74168]
       test      eax,eax
       jne       near ptr M01_L68
M01_L04:
       mov       ecx,[rdi+8]
       dec       ecx
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L77
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFEF36A2C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L68
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE94F74168]
       test      eax,eax
       jne       near ptr M01_L68
M01_L06:
       test      rbx,rbx
       je        near ptr M01_L69
M01_L07:
       test      rsi,rsi
       je        near ptr M01_L73
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       rax,24D2AC671D8
       mov       [rcx+10],rax
       xor       eax,eax
       mov       [rcx+24],eax
       mov       byte ptr [rcx+28],1
       mov       byte ptr [rcx+29],1
       mov       byte ptr [rcx+2A],1
       mov       byte ptr [rcx+2B],1
       mov       [rbp-68],rcx
       mov       rcx,offset MT_System.Security.Cryptography.AesCng
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+28],1
       mov       dword ptr [r14+2C],2
       mov       rcx,20CA8C00AF0
       mov       r15,[rcx]
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r13,rax
       mov       rcx,[r13]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L08
       mov       r8d,[r13+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L08:
       mov       r8,rdx
       lea       rdx,[r15+8]
       lea       rcx,[r13+8]
       mov       rax,[r13]
       test      dword ptr [rax],1000000
       je        short M01_L10
       cmp       r8,4000
       ja        short M01_L09
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L09:
       call      qword ptr [7FFE94805BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L10:
       call      qword ptr [7FFE94805B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rdx,r13
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20CA8C00AF8
       mov       r15,[rcx]
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r13,rax
       mov       rcx,[r13]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L12
       mov       r8d,[r13+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L12:
       mov       r8,rdx
       lea       rdx,[r15+8]
       lea       rcx,[r13+8]
       mov       rax,[r13]
       test      dword ptr [rax],1000000
       je        short M01_L14
       cmp       r8,4000
       ja        short M01_L13
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L13:
       call      qword ptr [7FFE94805BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L14:
       call      qword ptr [7FFE94805B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L15:
       mov       rdx,r13
       lea       rcx,[r14+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+30],80
       mov       dword ptr [r14+34],8
       mov       dword ptr [r14+38],100
       mov       dword ptr [r14+28],1
       mov       rcx,r14
       lea       rcx,[rcx+40]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+48],rcx
       mov       [r14+50],rcx
       mov       [r14+58],ecx
       mov       rcx,r14
       mov       [rbp-70],rcx
       lea       r14,[rcx+40]
       mov       rcx,[r14]
       mov       r11,7FFE94610A18
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[r14]
       mov       r11,7FFE94610A20
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rcx,[r14]
       mov       r11,7FFE94610A28
       call      qword ptr [r11]
       mov       r12d,eax
       cmp       r13d,4
       je        near ptr M01_L18
M01_L16:
       lea       rax,[rbx+10]
       mov       ebx,[rbx+8]
       mov       [rbp-0C8],rax
       movsxd    rdx,ebx
       shl       rdx,3
       mov       [rbp-40],rdx
       cmp       rdx,7FFFFFFF
       jg        near ptr M01_L31
       mov       rcx,[r14]
       mov       r8,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],r8
       jne       near ptr M01_L33
       mov       r8,[rcx+20]
       mov       [rbp-88],r8
       cmp       [r8],r8b
       mov       rcx,r8
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r10,rax
       mov       [rbp-90],r10
       mov       rcx,[r10]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L17
       mov       r8d,[r10+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L17:
       mov       r8,rdx
       mov       rdx,[rbp-88]
       add       rdx,8
       lea       rcx,[r10+8]
       mov       rax,[r10]
       test      dword ptr [rax],1000000
       je        near ptr M01_L36
       cmp       r8,4000
       ja        near ptr M01_L35
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L37
M01_L18:
       cmp       qword ptr [r14+8],0
       jne       near ptr M01_L19
       mov       rcx,[r14]
       mov       edx,r12d
       mov       r11,7FFE94610A38
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE94E1DD28]
       mov       rsi,rax
       mov       [rbx+8],r12d
       mov       rcx,offset MT_System.Security.Cryptography.CipherMode
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],4
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r8,r12
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE94E1D710]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE9475CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       cmp       r12d,8
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94E1DD28]
       mov       rdi,rax
       mov       [rsi+8],r12d
       mov       rcx,offset MT_System.Security.Cryptography.CipherMode
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],4
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r8,r14
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE94E1D710]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE9475CED0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L20:
       call      qword ptr [7FFE9490E9A0]
       int       3
M01_L21:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L60
M01_L22:
       call      qword ptr [7FFE9490E9B8]
       int       3
M01_L23:
       mov       ecx,1D75
       mov       rdx,7FFE94604000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE949366E8]
       int       3
M01_L24:
       mov       rbx,24D2AC671D8
       jmp       near ptr M01_L61
M01_L25:
       xor       esi,esi
       jmp       near ptr M01_L49
M01_L26:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94E1E358]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE9475CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94E1E190]
       mov       r14,rax
       mov       ecx,4503
       mov       rdx,7FFE94B9D300
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFE9475F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rdx,rbx
       mov       r11,7FFE94610A50
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L44
M01_L29:
       call      qword ptr [7FFE94E1E1C0]
       mov       rsi,rax
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[r14]
       mov       r11,7FFE94610A58
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE94E1D6F8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE9475CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rbx,24D2AC671D8
       jmp       near ptr M01_L42
M01_L31:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94E1E1D8]
       mov       rdi,rax
       mov       ecx,44F5
       mov       rdx,7FFE94B9D300
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE9475F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L32:
       mov       edx,[r11+8]
       cmp       edx,eax
       jne       short M01_L40
       jmp       short M01_L41
M01_L33:
       mov       r11,7FFE94610A40
       call      qword ptr [r11]
       mov       r8,rax
       jmp       short M01_L38
M01_L34:
       xor       edx,edx
       jmp       near ptr M01_L51
M01_L35:
       call      qword ptr [7FFE94805BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L37
M01_L36:
       call      qword ptr [7FFE94805B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L37:
       mov       r8,[rbp-90]
M01_L38:
       xor       ecx,ecx
       mov       r10d,[r8+8]
       test      r10d,r10d
       jle       near ptr M01_L31
M01_L39:
       mov       r9,[rbp-40]
       mov       eax,r9d
       mov       edx,ecx
       mov       r11,[r8+rdx*8+10]
       mov       edx,[r11+10]
       test      edx,edx
       je        short M01_L32
       mov       r9d,[r11+8]
       cmp       eax,r9d
       jl        short M01_L40
       cmp       eax,[r11+0C]
       jg        short M01_L40
       sub       eax,r9d
       mov       r9d,edx
       cdq
       idiv      r9d
       test      edx,edx
       je        short M01_L41
M01_L40:
       inc       ecx
       cmp       r10d,ecx
       jg        short M01_L39
       jmp       near ptr M01_L31
M01_L41:
       test      ebx,ebx
       je        near ptr M01_L30
       mov       edx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-98],rax
       lea       rcx,[rax+10]
       mov       r8d,ebx
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFE94805B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rbp-98]
M01_L42:
       mov       rcx,[r14]
       mov       rdx,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],rdx
       je        short M01_L43
       mov       rdx,rbx
       mov       r11,7FFE94610A48
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L43:
       mov       rcx,[r14]
       mov       r11,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],r11
       jne       near ptr M01_L28
M01_L44:
       mov       eax,[rsi+8]
       mov       [rbp-0E4],eax
       mov       rcx,[r14]
       mov       r11,7FFE94610A30
       call      qword ptr [r11]
       add       eax,7
       mov       ecx,eax
       sar       ecx,1F
       and       ecx,7
       add       ecx,eax
       sar       ecx,3
       cmp       [rbp-0E4],ecx
       jne       near ptr M01_L27
       xor       eax,eax
       cmp       r13d,2
       cmove     rsi,rax
       test      rsi,rsi
       je        near ptr M01_L25
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       [rbp-0A0],rax
       mov       rcx,[rax]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L45
       mov       r8d,[rax+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L45:
       mov       r8,rdx
       cmp       [rsi],sil
       lea       rdx,[rsi+8]
       lea       rcx,[rax+8]
       mov       r10,[rax]
       test      dword ptr [r10],1000000
       je        short M01_L47
       cmp       r8,4000
       ja        short M01_L46
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L48
M01_L46:
       call      qword ptr [7FFE94805BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L48
M01_L47:
       call      qword ptr [7FFE94805B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L48:
       mov       rsi,[rbp-0A0]
M01_L49:
       mov       rcx,[r14]
       mov       r11,7FFE94610A60
       call      qword ptr [r11]
       add       eax,7
       mov       r10d,eax
       sar       r10d,1F
       and       r10d,7
       add       eax,r10d
       sar       eax,3
       mov       [rbp-44],eax
       mov       rcx,[r14]
       mov       r8d,r12d
       mov       edx,r13d
       mov       r11,7FFE94610A68
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
       mov       rcx,[r14]
       mov       r8d,r12d
       mov       edx,r13d
       mov       r11,7FFE94610A70
       call      qword ptr [r11]
       mov       r12d,eax
       test      rbx,rbx
       je        near ptr M01_L56
       lea       r14,[rbx+10]
       mov       ebx,[rbx+8]
M01_L50:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       cmp       r13d,2
       je        near ptr M01_L34
       test      rsi,rsi
       je        near ptr M01_L26
       mov       rdx,rsi
M01_L51:
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0B0]
       mov       r13d,[rbp-44]
       mov       [rsi+10],r13d
       test      r12d,r12d
       jg        near ptr M01_L57
       mov       ecx,r13d
M01_L52:
       mov       [rsi+14],ecx
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M01_L55
       lea       rax,[rcx+10]
       mov       [rbp-0D0],rax
       mov       edx,[rcx+8]
       mov       [rbp-48],edx
M01_L53:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherLiteBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B8],rax
       mov       r8,[rbp-0D0]
       mov       [rbp-0D8],r8
       mov       r10d,[rbp-48]
       mov       [rbp-4C],r10d
       test      r10d,r10d
       je        short M01_L54
       movsxd    rdx,r10d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,rax
       mov       [rbp-0C0],rdx
       lea       rcx,[rdx+10]
       mov       r8d,[rbp-4C]
       mov       rdx,[rbp-0D8]
       call      qword ptr [7FFE94805B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbp-0C0]
       mov       rax,[rbp-0B8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L54:
       mov       rax,[rbp-0B8]
       mov       [rax+18],r13d
       mov       [rax+1C],r12d
       mov       byte ptr [rax+20],1
       lea       rcx,[rax+10]
       mov       [rbp-0F0],rcx
       mov       r13,[rbp-0A8]
       mov       [rbp-60],r14
       mov       [rbp-58],ebx
       mov       rcx,r13
       lea       rdx,[rbp-60]
       call      qword ptr [7FFE94DE7C18]; Interop+BCrypt.BCryptImportKey(Internal.NativeCrypto.SafeAlgorithmHandle, System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rbp-0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Security.Cryptography.UniversalCryptoEncryptor
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],r15d
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L58
M01_L55:
       xor       eax,eax
       xor       edx,edx
       mov       [rbp-0D0],rax
       mov       [rbp-48],edx
       jmp       near ptr M01_L53
M01_L56:
       xor       r14d,r14d
       xor       ebx,ebx
       jmp       near ptr M01_L50
M01_L57:
       mov       ecx,r12d
       jmp       near ptr M01_L52
M01_L58:
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r15
       mov       rdx,[rbp-68]
       mov       r8,rbx
       mov       r9d,1
       call      qword ptr [7FFE94E1CBA0]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-78],r15
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,20C98C013B8
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,r15
       mov       r9d,400
       call      qword ptr [7FFE9489DB60]; System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,rsi
       mov       [rbp-80],rcx
       mov       rdx,rdi
       call      qword ptr [7FFE9488D668]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFE9488D5D0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rcx,r15
       mov       edx,1
       call      qword ptr [7FFE94E0C100]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,r15
       call      System.GC._SuppressFinalize(System.Object)
       mov       rdx,[rbp-68]
       mov       r15d,[rdx+20]
       sub       r15d,[rdx+18]
       je        near ptr M01_L24
       cmp       r15d,800
       jl        near ptr M01_L62
       mov       edx,r15d
       mov       rcx,offset MT_System.Byte[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
M01_L59:
       mov       rdx,[rbp-68]
       mov       rcx,[rdx+10]
       mov       r8d,[rdx+18]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       eax,r8d
       mov       r10d,r15d
       add       rax,r10
       mov       r10d,[rcx+8]
       cmp       rax,r10
       ja        near ptr M01_L20
       cmp       [rcx],cl
       lea       rcx,[rcx+r8+10]
       mov       [rbp-0E0],rcx
       test      rbx,rbx
       je        near ptr M01_L21
       lea       rsi,[rbx+10]
       mov       edi,[rbx+8]
M01_L60:
       cmp       r15d,edi
       ja        near ptr M01_L22
       mov       r8d,r15d
       mov       rcx,rsi
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFE94805B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L61:
       test      rbx,rbx
       je        near ptr M01_L23
       lea       rcx,[rbx+10]
       mov       edx,[rbx+8]
       mov       [rbp-60],rcx
       mov       [rbp-58],edx
       lea       rcx,[rbp-60]
       xor       edx,edx
       call      qword ptr [7FFE94A24648]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
       mov       rsi,rax
       jmp       short M01_L64
M01_L62:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       jmp       near ptr M01_L59
M01_L63:
       mov       rcx,[rcx+8]
       call      qword ptr [7FFE946A74B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+8],rcx
       mov       rcx,rax
       jmp       short M01_L65
M01_L64:
       mov       rcx,[rbp-70]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L63
M01_L65:
       cmp       qword ptr [rcx+10],0
       je        short M01_L66
       mov       rcx,[rcx+10]
       call      qword ptr [7FFE946A74B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+10],rcx
       mov       rcx,rax
M01_L66:
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rdx,[rbp-68]
       mov       byte ptr [rdx+2B],0
       mov       byte ptr [rdx+29],0
       mov       byte ptr [rdx+28],0
       xor       ecx,ecx
       mov       [rdx+30],rcx
       mov       rcx,rdx
       call      System.GC._SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L67:
       call      qword ptr [7FFE94BFC468]
       mov       r14,rax
       mov       ecx,10CE
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       r12,rax
       mov       ecx,770
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,r12
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94BF7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE94BFC060]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE94BFC5E8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFE94936670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L68:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE947573F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       test      rbx,rbx
       jne       near ptr M01_L07
M01_L69:
       call      qword ptr [7FFE94BFC348]
       mov       rcx,24D2AC69A40
       mov       rdx,24D2AC60210
       call      qword ptr [7FFE94756B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24D2AC60008
       call      qword ptr [7FFE94756B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L70
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L71
M01_L70:
       mov       ecx,1
M01_L71:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L72
       call      qword ptr [7FFE94BFC468]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94BF7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94BFC060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE94BFC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE94936670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L72:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE94757318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94BFC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE94936670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L73:
       call      qword ptr [7FFE94BFC348]
       mov       rcx,24D2AC60B20
       mov       rdx,24D2AC60210
       call      qword ptr [7FFE94756B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24D2AC60008
       call      qword ptr [7FFE94756B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L74
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L75
M01_L74:
       mov       ecx,1
M01_L75:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L76
       call      qword ptr [7FFE94BFC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94BF7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94BFC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE94BFC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE94936670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L76:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE94757318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94BFC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE94936670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L77:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFE9488D5D0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rcx,[rbp-78]
       mov       edx,1
       call      qword ptr [7FFE94E0C100]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,[rbp-78]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rax,[rbp-70]
       cmp       qword ptr [rax+8],0
       je        short M01_L78
       mov       rcx,[rax+8]
       call      qword ptr [7FFE946A74B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+8],rcx
M01_L78:
       cmp       qword ptr [rax+10],0
       je        short M01_L79
       mov       rcx,[rax+10]
       call      qword ptr [7FFE946A74B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+10],rcx
M01_L79:
       mov       rcx,rax
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rdx,[rbp-68]
       mov       byte ptr [rdx+2B],0
       mov       byte ptr [rdx+29],0
       mov       byte ptr [rdx+28],0
       xor       ecx,ecx
       mov       [rdx+30],rcx
       mov       rcx,rdx
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 4141
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesEncrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,[rbx+128]
       mov       r8,[rbx+120]
       call      qword ptr [7FFE94B3F180]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0F0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0F8],rsp
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rdi+8],0
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       dword ptr [rdi+8],0
       jne       short M01_L02
       jmp       short M01_L02
M01_L01:
       xor       ecx,ecx
M01_L02:
       test      ecx,ecx
       je        near ptr M01_L67
       cmp       dword ptr [rdi+8],0
       je        short M01_L06
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jae       short M01_L03
       mov       rax,7FFEF36A2C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L68
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFE94F2D5C0]
       test      eax,eax
       jne       near ptr M01_L68
M01_L04:
       mov       ecx,[rdi+8]
       dec       ecx
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L77
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFEF36A2C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L68
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE94F2D5C0]
       test      eax,eax
       jne       near ptr M01_L68
M01_L06:
       test      rbx,rbx
       je        near ptr M01_L69
M01_L07:
       test      rsi,rsi
       je        near ptr M01_L73
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       rax,257F86D71D8
       mov       [rcx+10],rax
       xor       eax,eax
       mov       [rcx+24],eax
       mov       byte ptr [rcx+28],1
       mov       byte ptr [rcx+29],1
       mov       byte ptr [rcx+2A],1
       mov       byte ptr [rcx+2B],1
       mov       [rbp-68],rcx
       mov       rcx,offset MT_System.Security.Cryptography.AesCng
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+28],1
       mov       dword ptr [r14+2C],2
       mov       rcx,21762802AE8
       mov       r15,[rcx]
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r13,rax
       mov       rcx,[r13]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L08
       mov       r8d,[r13+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L08:
       mov       r8,rdx
       lea       rdx,[r15+8]
       lea       rcx,[r13+8]
       mov       rax,[r13]
       test      dword ptr [rax],1000000
       je        short M01_L10
       cmp       r8,4000
       ja        short M01_L09
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L09:
       call      qword ptr [7FFE947F5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L10:
       call      qword ptr [7FFE947F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rdx,r13
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,21762802AF0
       mov       r15,[rcx]
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r13,rax
       mov       rcx,[r13]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L12
       mov       r8d,[r13+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L12:
       mov       r8,rdx
       lea       rdx,[r15+8]
       lea       rcx,[r13+8]
       mov       rax,[r13]
       test      dword ptr [rax],1000000
       je        short M01_L14
       cmp       r8,4000
       ja        short M01_L13
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L13:
       call      qword ptr [7FFE947F5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L14:
       call      qword ptr [7FFE947F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L15:
       mov       rdx,r13
       lea       rcx,[r14+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+30],80
       mov       dword ptr [r14+34],8
       mov       dword ptr [r14+38],100
       mov       dword ptr [r14+28],1
       mov       rcx,r14
       lea       rcx,[rcx+40]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+48],rcx
       mov       [r14+50],rcx
       mov       [r14+58],ecx
       mov       rcx,r14
       mov       [rbp-70],rcx
       lea       r14,[rcx+40]
       mov       rcx,[r14]
       mov       r11,7FFE946009C8
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[r14]
       mov       r11,7FFE946009D0
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rcx,[r14]
       mov       r11,7FFE946009D8
       call      qword ptr [r11]
       mov       r12d,eax
       cmp       r13d,4
       je        near ptr M01_L18
M01_L16:
       lea       rax,[rbx+10]
       mov       ebx,[rbx+8]
       mov       [rbp-0C8],rax
       movsxd    rdx,ebx
       shl       rdx,3
       mov       [rbp-40],rdx
       cmp       rdx,7FFFFFFF
       jg        near ptr M01_L31
       mov       rcx,[r14]
       mov       r8,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],r8
       jne       near ptr M01_L33
       mov       r8,[rcx+20]
       mov       [rbp-88],r8
       cmp       [r8],r8b
       mov       rcx,r8
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r10,rax
       mov       [rbp-90],r10
       mov       rcx,[r10]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L17
       mov       r8d,[r10+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L17:
       mov       r8,rdx
       mov       rdx,[rbp-88]
       add       rdx,8
       lea       rcx,[r10+8]
       mov       rax,[r10]
       test      dword ptr [rax],1000000
       je        near ptr M01_L36
       cmp       r8,4000
       ja        near ptr M01_L35
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L37
M01_L18:
       cmp       qword ptr [r14+8],0
       jne       near ptr M01_L19
       mov       rcx,[r14]
       mov       edx,r12d
       mov       r11,7FFE946009E8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE94E0C660]
       mov       rsi,rax
       mov       [rbx+8],r12d
       mov       rcx,offset MT_System.Security.Cryptography.CipherMode
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],4
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r8,r12
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE94E0C048]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE9474CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       cmp       r12d,8
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94E0C660]
       mov       rdi,rax
       mov       [rsi+8],r12d
       mov       rcx,offset MT_System.Security.Cryptography.CipherMode
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],4
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r8,r14
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE94E0C048]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE9474CED0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L20:
       call      qword ptr [7FFE948FE9A0]
       int       3
M01_L21:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L60
M01_L22:
       call      qword ptr [7FFE948FE9B8]
       int       3
M01_L23:
       mov       ecx,1D75
       mov       rdx,7FFE945F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE949266E8]
       int       3
M01_L24:
       mov       rbx,257F86D71D8
       jmp       near ptr M01_L61
M01_L25:
       xor       esi,esi
       jmp       near ptr M01_L49
M01_L26:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94E0CC90]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE9474CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94E0CAC8]
       mov       r14,rax
       mov       ecx,4503
       mov       rdx,7FFE94B8D300
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFE9474F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rdx,rbx
       mov       r11,7FFE94600A00
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L44
M01_L29:
       call      qword ptr [7FFE94E0CAF8]
       mov       rsi,rax
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[r14]
       mov       r11,7FFE94600A08
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE94E0C030]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE9474CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rbx,257F86D71D8
       jmp       near ptr M01_L42
M01_L31:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94E0CB10]
       mov       rdi,rax
       mov       ecx,44F5
       mov       rdx,7FFE94B8D300
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE9474F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L32:
       mov       edx,[r11+8]
       cmp       edx,eax
       jne       short M01_L40
       jmp       short M01_L41
M01_L33:
       mov       r11,7FFE946009F0
       call      qword ptr [r11]
       mov       r8,rax
       jmp       short M01_L38
M01_L34:
       xor       edx,edx
       jmp       near ptr M01_L51
M01_L35:
       call      qword ptr [7FFE947F5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L37
M01_L36:
       call      qword ptr [7FFE947F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L37:
       mov       r8,[rbp-90]
M01_L38:
       xor       ecx,ecx
       mov       r10d,[r8+8]
       test      r10d,r10d
       jle       near ptr M01_L31
M01_L39:
       mov       r9,[rbp-40]
       mov       eax,r9d
       mov       edx,ecx
       mov       r11,[r8+rdx*8+10]
       mov       edx,[r11+10]
       test      edx,edx
       je        short M01_L32
       mov       r9d,[r11+8]
       cmp       eax,r9d
       jl        short M01_L40
       cmp       eax,[r11+0C]
       jg        short M01_L40
       sub       eax,r9d
       mov       r9d,edx
       cdq
       idiv      r9d
       test      edx,edx
       je        short M01_L41
M01_L40:
       inc       ecx
       cmp       r10d,ecx
       jg        short M01_L39
       jmp       near ptr M01_L31
M01_L41:
       test      ebx,ebx
       je        near ptr M01_L30
       mov       edx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-98],rax
       lea       rcx,[rax+10]
       mov       r8d,ebx
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFE947F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rbp-98]
M01_L42:
       mov       rcx,[r14]
       mov       rdx,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],rdx
       je        short M01_L43
       mov       rdx,rbx
       mov       r11,7FFE946009F8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L43:
       mov       rcx,[r14]
       mov       r11,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],r11
       jne       near ptr M01_L28
M01_L44:
       mov       eax,[rsi+8]
       mov       [rbp-0E4],eax
       mov       rcx,[r14]
       mov       r11,7FFE946009E0
       call      qword ptr [r11]
       add       eax,7
       mov       ecx,eax
       sar       ecx,1F
       and       ecx,7
       add       ecx,eax
       sar       ecx,3
       cmp       [rbp-0E4],ecx
       jne       near ptr M01_L27
       xor       eax,eax
       cmp       r13d,2
       cmove     rsi,rax
       test      rsi,rsi
       je        near ptr M01_L25
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       [rbp-0A0],rax
       mov       rcx,[rax]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L45
       mov       r8d,[rax+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L45:
       mov       r8,rdx
       cmp       [rsi],sil
       lea       rdx,[rsi+8]
       lea       rcx,[rax+8]
       mov       r10,[rax]
       test      dword ptr [r10],1000000
       je        short M01_L47
       cmp       r8,4000
       ja        short M01_L46
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L48
M01_L46:
       call      qword ptr [7FFE947F5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L48
M01_L47:
       call      qword ptr [7FFE947F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L48:
       mov       rsi,[rbp-0A0]
M01_L49:
       mov       rcx,[r14]
       mov       r11,7FFE94600A10
       call      qword ptr [r11]
       add       eax,7
       mov       r10d,eax
       sar       r10d,1F
       and       r10d,7
       add       eax,r10d
       sar       eax,3
       mov       [rbp-44],eax
       mov       rcx,[r14]
       mov       r8d,r12d
       mov       edx,r13d
       mov       r11,7FFE94600A18
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
       mov       rcx,[r14]
       mov       r8d,r12d
       mov       edx,r13d
       mov       r11,7FFE94600A20
       call      qword ptr [r11]
       mov       r12d,eax
       test      rbx,rbx
       je        near ptr M01_L56
       lea       r14,[rbx+10]
       mov       ebx,[rbx+8]
M01_L50:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       cmp       r13d,2
       je        near ptr M01_L34
       test      rsi,rsi
       je        near ptr M01_L26
       mov       rdx,rsi
M01_L51:
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0B0]
       mov       r13d,[rbp-44]
       mov       [rsi+10],r13d
       test      r12d,r12d
       jg        near ptr M01_L57
       mov       ecx,r13d
M01_L52:
       mov       [rsi+14],ecx
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M01_L55
       lea       rax,[rcx+10]
       mov       [rbp-0D0],rax
       mov       edx,[rcx+8]
       mov       [rbp-48],edx
M01_L53:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherLiteBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B8],rax
       mov       r8,[rbp-0D0]
       mov       [rbp-0D8],r8
       mov       r10d,[rbp-48]
       mov       [rbp-4C],r10d
       test      r10d,r10d
       je        short M01_L54
       movsxd    rdx,r10d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,rax
       mov       [rbp-0C0],rdx
       lea       rcx,[rdx+10]
       mov       r8d,[rbp-4C]
       mov       rdx,[rbp-0D8]
       call      qword ptr [7FFE947F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbp-0C0]
       mov       rax,[rbp-0B8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L54:
       mov       rax,[rbp-0B8]
       mov       [rax+18],r13d
       mov       [rax+1C],r12d
       mov       byte ptr [rax+20],1
       lea       rcx,[rax+10]
       mov       [rbp-0F0],rcx
       mov       r13,[rbp-0A8]
       mov       [rbp-60],r14
       mov       [rbp-58],ebx
       mov       rcx,r13
       lea       rdx,[rbp-60]
       call      qword ptr [7FFE94DC5FB0]; Interop+BCrypt.BCryptImportKey(Internal.NativeCrypto.SafeAlgorithmHandle, System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rbp-0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Security.Cryptography.UniversalCryptoEncryptor
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],r15d
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L58
M01_L55:
       xor       eax,eax
       xor       edx,edx
       mov       [rbp-0D0],rax
       mov       [rbp-48],edx
       jmp       near ptr M01_L53
M01_L56:
       xor       r14d,r14d
       xor       ebx,ebx
       jmp       near ptr M01_L50
M01_L57:
       mov       ecx,r12d
       jmp       near ptr M01_L52
M01_L58:
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r15
       mov       rdx,[rbp-68]
       mov       r8,rbx
       mov       r9d,1
       call      qword ptr [7FFE94E06EE0]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-78],r15
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,217668013B8
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,r15
       mov       r9d,400
       call      qword ptr [7FFE9488DB60]; System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,rsi
       mov       [rbp-80],rcx
       mov       rdx,rdi
       call      qword ptr [7FFE9487D668]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFE9487D5D0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rcx,r15
       mov       edx,1
       call      qword ptr [7FFE94DF7C98]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,r15
       call      System.GC._SuppressFinalize(System.Object)
       mov       rdx,[rbp-68]
       mov       r15d,[rdx+20]
       sub       r15d,[rdx+18]
       je        near ptr M01_L24
       cmp       r15d,800
       jl        near ptr M01_L62
       mov       edx,r15d
       mov       rcx,offset MT_System.Byte[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
M01_L59:
       mov       rdx,[rbp-68]
       mov       rcx,[rdx+10]
       mov       r8d,[rdx+18]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       eax,r8d
       mov       r10d,r15d
       add       rax,r10
       mov       r10d,[rcx+8]
       cmp       rax,r10
       ja        near ptr M01_L20
       cmp       [rcx],cl
       lea       rcx,[rcx+r8+10]
       mov       [rbp-0E0],rcx
       test      rbx,rbx
       je        near ptr M01_L21
       lea       rsi,[rbx+10]
       mov       edi,[rbx+8]
M01_L60:
       cmp       r15d,edi
       ja        near ptr M01_L22
       mov       r8d,r15d
       mov       rcx,rsi
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFE947F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L61:
       test      rbx,rbx
       je        near ptr M01_L23
       lea       rcx,[rbx+10]
       mov       edx,[rbx+8]
       mov       [rbp-60],rcx
       mov       [rbp-58],edx
       lea       rcx,[rbp-60]
       xor       edx,edx
       call      qword ptr [7FFE94A14648]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
       mov       rsi,rax
       jmp       short M01_L64
M01_L62:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       jmp       near ptr M01_L59
M01_L63:
       mov       rcx,[rcx+8]
       call      qword ptr [7FFE946974B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+8],rcx
       mov       rcx,rax
       jmp       short M01_L65
M01_L64:
       mov       rcx,[rbp-70]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L63
M01_L65:
       cmp       qword ptr [rcx+10],0
       je        short M01_L66
       mov       rcx,[rcx+10]
       call      qword ptr [7FFE946974B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+10],rcx
       mov       rcx,rax
M01_L66:
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rdx,[rbp-68]
       mov       byte ptr [rdx+2B],0
       mov       byte ptr [rdx+29],0
       mov       byte ptr [rdx+28],0
       xor       ecx,ecx
       mov       [rdx+30],rcx
       mov       rcx,rdx
       call      System.GC._SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L67:
       call      qword ptr [7FFE94BEC468]
       mov       r14,rax
       mov       ecx,10CE
       mov       rdx,7FFE94A27DB0
       call      CORINFO_HELP_STRCNS
       mov       r12,rax
       mov       ecx,770
       mov       rdx,7FFE94A27DB0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A27DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,r12
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94BE7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE94BEC060]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE94BEC5E8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFE94926670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L68:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE947473F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       test      rbx,rbx
       jne       near ptr M01_L07
M01_L69:
       call      qword ptr [7FFE94BEC348]
       mov       rcx,257F86D9A40
       mov       rdx,257F86D0210
       call      qword ptr [7FFE94746B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,257F86D0008
       call      qword ptr [7FFE94746B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L70
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L71
M01_L70:
       mov       ecx,1
M01_L71:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L72
       call      qword ptr [7FFE94BEC468]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE94A27DB0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A27DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94BE7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94BEC060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE94BEC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE94926670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L72:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE94747318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94BEC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE94926670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L73:
       call      qword ptr [7FFE94BEC348]
       mov       rcx,257F86D0B20
       mov       rdx,257F86D0210
       call      qword ptr [7FFE94746B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,257F86D0008
       call      qword ptr [7FFE94746B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L74
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L75
M01_L74:
       mov       ecx,1
M01_L75:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L76
       call      qword ptr [7FFE94BEC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE94A27DB0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A27DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94BE7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94BEC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE94BEC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE94926670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L76:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE94747318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE94BEC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE94926670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L77:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFE9487D5D0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rcx,[rbp-78]
       mov       edx,1
       call      qword ptr [7FFE94DF7C98]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,[rbp-78]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rax,[rbp-70]
       cmp       qword ptr [rax+8],0
       je        short M01_L78
       mov       rcx,[rax+8]
       call      qword ptr [7FFE946974B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+8],rcx
M01_L78:
       cmp       qword ptr [rax+10],0
       je        short M01_L79
       mov       rcx,[rax+10]
       call      qword ptr [7FFE946974B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+10],rcx
M01_L79:
       mov       rcx,rax
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rdx,[rbp-68]
       mov       byte ptr [rdx+2B],0
       mov       byte ptr [rdx+29],0
       mov       byte ptr [rdx+28],0
       xor       ecx,ecx
       mov       [rdx+30],rcx
       mov       rcx,rdx
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 4141
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,21C9B76B038
       call      qword ptr [7FFE94B4F1E0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
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
       je        short M01_L04
       cmp       [rcx],ecx
       call      qword ptr [7FFE94757318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,rsi
       test      rcx,rcx
       je        short M01_L02
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L03
M01_L02:
       xor       edx,edx
M01_L03:
       test      edx,edx
       je        near ptr M01_L05
       cmp       [rcx],ecx
       call      qword ptr [7FFE94757318]; System.String.Trim()
       mov       rdx,rax
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE94B4F150]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rbx
       mov       rdx,[rsp+30]
       mov       r8,[rsp+38]
       call      qword ptr [7FFE94B4F168]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      qword ptr [7FFE94BFC468]
       mov       rbx,rax
       mov       ecx,10AA
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94BF7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94BFC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE94BFC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE94936670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE94BFC468]
       mov       rbx,rax
       mov       ecx,10C0
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A37DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94BF7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94BFC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE94BFC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE94936670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 491
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleEncrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,2BF7CACB038
       call      qword ptr [7FFE94B6F1F8]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
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
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
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
       je        short M01_L04
       cmp       [rcx],ecx
       call      qword ptr [7FFE94777318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,rsi
       test      rcx,rcx
       je        short M01_L02
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L03
M01_L02:
       xor       edx,edx
M01_L03:
       test      edx,edx
       je        near ptr M01_L05
       cmp       [rcx],ecx
       call      qword ptr [7FFE94777318]; System.String.Trim()
       mov       rdx,rax
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE94B6F150]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rbx
       mov       rdx,[rsp+30]
       mov       r8,[rsp+38]
       call      qword ptr [7FFE94B6F180]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      qword ptr [7FFE94C1C468]
       mov       rbx,rax
       mov       ecx,10CE
       mov       rdx,7FFE94A57DB0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE94A57DB0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A57DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94C17A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94C1C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE94C1C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE94956670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE94C1C468]
       mov       rbx,rax
       mov       ecx,10C0
       mov       rdx,7FFE94A57DB0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE94A57DB0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE94A57DB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE94C17A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE94C1C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE94C1C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE94956670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 491
```

