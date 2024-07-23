## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE4941F180]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
       mov       rax,7FFE57D52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L69
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFE498A7768]
       test      eax,eax
       jne       near ptr M01_L69
M01_L04:
       mov       ecx,[rdi+8]
       dec       ecx
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L72
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE57D52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L69
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE498A7768]
       test      eax,eax
       jne       near ptr M01_L69
M01_L06:
       test      rbx,rbx
       je        near ptr M01_L70
M01_L07:
       test      rsi,rsi
       je        near ptr M01_L71
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       rax,24509257290
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
       mov       rcx,20477406AD0
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
       call      qword ptr [7FFE490D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L10:
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rdx,r13
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20477406AD8
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
       call      qword ptr [7FFE490D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L14:
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r11,7FFE48EE0A20
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[r14]
       mov       r11,7FFE48EE0A28
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rcx,[r14]
       mov       r11,7FFE48EE0A30
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
       mov       r11,7FFE48EE0A40
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE49784660]
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
       call      qword ptr [7FFE49784048]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE4902CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       cmp       r12d,8
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE49784660]
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
       call      qword ptr [7FFE49784048]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE4902CED0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L20:
       call      qword ptr [7FFE491DE9A0]
       int       3
M01_L21:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L60
M01_L22:
       call      qword ptr [7FFE491DE9B8]
       int       3
M01_L23:
       mov       ecx,1D75
       mov       rdx,7FFE48ED4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE492066E8]
       int       3
M01_L24:
       mov       rbx,24509257290
       jmp       near ptr M01_L61
M01_L25:
       xor       esi,esi
       jmp       near ptr M01_L49
M01_L26:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE49784C90]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE4902CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE49784AC8]
       mov       r14,rax
       mov       ecx,4503
       mov       rdx,7FFE4955B308
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFE4902F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rdx,rbx
       mov       r11,7FFE48EE0A58
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L44
M01_L29:
       call      qword ptr [7FFE49784AF8]
       mov       rsi,rax
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[r14]
       mov       r11,7FFE48EE0A60
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE49784030]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE4902CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rbx,24509257290
       jmp       near ptr M01_L42
M01_L31:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE49784B10]
       mov       rdi,rax
       mov       ecx,44F5
       mov       rdx,7FFE4955B308
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE4902F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L32:
       mov       edx,[r11+8]
       cmp       edx,eax
       jne       short M01_L40
       jmp       short M01_L41
M01_L33:
       mov       r11,7FFE48EE0A48
       call      qword ptr [r11]
       mov       r8,rax
       jmp       short M01_L38
M01_L34:
       xor       edx,edx
       jmp       near ptr M01_L51
M01_L35:
       call      qword ptr [7FFE490D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L37
M01_L36:
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rbp-98]
M01_L42:
       mov       rcx,[r14]
       mov       rdx,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],rdx
       je        short M01_L43
       mov       rdx,rbx
       mov       r11,7FFE48EE0A50
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
       mov       r11,7FFE48EE0A38
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
       call      qword ptr [7FFE490D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L48
M01_L47:
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L48:
       mov       rsi,[rbp-0A0]
M01_L49:
       mov       rcx,[r14]
       mov       r11,7FFE48EE0A68
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
       mov       r11,7FFE48EE0A70
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
       mov       rcx,[r14]
       mov       r8d,r12d
       mov       edx,r13d
       mov       r11,7FFE48EE0A78
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
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE4973ED00]; Interop+BCrypt.BCryptImportKey(Internal.NativeCrypto.SafeAlgorithmHandle, System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FFE4975F1B0]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-78],r15
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,204774013B8
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,r15
       mov       r9d,400
       call      qword ptr [7FFE4916DB60]; System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,rsi
       mov       [rbp-80],rcx
       mov       rdx,rdi
       call      qword ptr [7FFE4915D668]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFE4915D5D0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rcx,r15
       mov       edx,1
       call      qword ptr [7FFE4976BE20]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
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
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L61:
       test      rbx,rbx
       je        near ptr M01_L23
       lea       rcx,[rbx+10]
       mov       edx,[rbx+8]
       mov       [rbp-60],rcx
       mov       [rbp-58],edx
       lea       rcx,[rbp-60]
       xor       edx,edx
       call      qword ptr [7FFE492F5E30]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
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
       call      qword ptr [7FFE48F774B0]; System.Array.Clear(System.Array)
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
       call      qword ptr [7FFE48F774B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+10],rcx
M01_L66:
       mov       rax,[rbp-70]
       mov       rcx,rax
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
       call      qword ptr [7FFE4956DEC0]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L68
       call      qword ptr [7FFE4956DC20]
       mov       r14,rax
M01_L68:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,2450926A588
       mov       r8,r14
       call      qword ptr [7FFE49206670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L69:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE490273F0]
       mov       rdi,rax
       test      rbx,rbx
       jne       near ptr M01_L07
M01_L70:
       call      qword ptr [7FFE4956DE30]
       mov       ecx,15D6
       mov       rdx,7FFE49307EF0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE49307EF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE49026B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,9EA
       mov       rdx,7FFE49307EF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE49026B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE4956DC20]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rbx
       call      qword ptr [7FFE49206670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L71:
       call      qword ptr [7FFE4956DE30]
       mov       ecx,15DE
       mov       rdx,7FFE49307EF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE49307EF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE49026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,9EA
       mov       rdx,7FFE49307EF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE49026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE4956DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE49206670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L72:
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
       call      qword ptr [7FFE4915D5D0]; System.IO.StreamWriter.Dispose(Boolean)
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
       call      qword ptr [7FFE4976BE20]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
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
       je        short M01_L73
       mov       rcx,[rax+8]
       call      qword ptr [7FFE48F774B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+8],rcx
M01_L73:
       cmp       qword ptr [rax+10],0
       je        short M01_L74
       mov       rcx,[rax+10]
       call      qword ptr [7FFE48F774B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+10],rcx
M01_L74:
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
; Total bytes of code 3764
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE4941F180]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
       mov       rax,7FFE57D52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L69
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFE498A43C0]
       test      eax,eax
       jne       near ptr M01_L69
M01_L04:
       mov       ecx,[rdi+8]
       dec       ecx
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L72
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE57D52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L69
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE498A43C0]
       test      eax,eax
       jne       near ptr M01_L69
M01_L06:
       test      rbx,rbx
       je        near ptr M01_L70
M01_L07:
       test      rsi,rsi
       je        near ptr M01_L71
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       rax,2345B5E7178
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
       mov       rcx,1F3CD806AD0
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
       call      qword ptr [7FFE490D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L10:
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rdx,r13
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F3CD806AD8
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
       call      qword ptr [7FFE490D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L14:
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r11,7FFE48EE09D0
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[r14]
       mov       r11,7FFE48EE09D8
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rcx,[r14]
       mov       r11,7FFE48EE09E0
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
       mov       r11,7FFE48EE09F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE49784660]
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
       call      qword ptr [7FFE49784048]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE4902CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       cmp       r12d,8
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE49784660]
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
       call      qword ptr [7FFE49784048]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE4902CED0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L20:
       call      qword ptr [7FFE491DE9A0]
       int       3
M01_L21:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L60
M01_L22:
       call      qword ptr [7FFE491DE9B8]
       int       3
M01_L23:
       mov       ecx,1D75
       mov       rdx,7FFE48ED4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE492066E8]
       int       3
M01_L24:
       mov       rbx,2345B5E7178
       jmp       near ptr M01_L61
M01_L25:
       xor       esi,esi
       jmp       near ptr M01_L49
M01_L26:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE49784C90]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE4902CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE49784AC8]
       mov       r14,rax
       mov       ecx,4503
       mov       rdx,7FFE4955A858
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFE4902F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rdx,rbx
       mov       r11,7FFE48EE0A08
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L44
M01_L29:
       call      qword ptr [7FFE49784AF8]
       mov       rsi,rax
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[r14]
       mov       r11,7FFE48EE0A10
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE49784030]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE4902CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rbx,2345B5E7178
       jmp       near ptr M01_L42
M01_L31:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE49784B10]
       mov       rdi,rax
       mov       ecx,44F5
       mov       rdx,7FFE4955A858
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE4902F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L32:
       mov       edx,[r11+8]
       cmp       edx,eax
       jne       short M01_L40
       jmp       short M01_L41
M01_L33:
       mov       r11,7FFE48EE09F8
       call      qword ptr [r11]
       mov       r8,rax
       jmp       short M01_L38
M01_L34:
       xor       edx,edx
       jmp       near ptr M01_L51
M01_L35:
       call      qword ptr [7FFE490D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L37
M01_L36:
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rbp-98]
M01_L42:
       mov       rcx,[r14]
       mov       rdx,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],rdx
       je        short M01_L43
       mov       rdx,rbx
       mov       r11,7FFE48EE0A00
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
       mov       r11,7FFE48EE09E8
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
       call      qword ptr [7FFE490D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L48
M01_L47:
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L48:
       mov       rsi,[rbp-0A0]
M01_L49:
       mov       rcx,[r14]
       mov       r11,7FFE48EE0A18
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
       mov       r11,7FFE48EE0A20
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
       mov       rcx,[r14]
       mov       r8d,r12d
       mov       edx,r13d
       mov       r11,7FFE48EE0A28
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
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE4973ED00]; Interop+BCrypt.BCryptImportKey(Internal.NativeCrypto.SafeAlgorithmHandle, System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FFE4975F420]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-78],r15
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,1F3CD8013B8
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,r15
       mov       r9d,400
       call      qword ptr [7FFE4916DB60]; System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,rsi
       mov       [rbp-80],rcx
       mov       rdx,rdi
       call      qword ptr [7FFE4915D668]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFE4915D5D0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rcx,r15
       mov       edx,1
       call      qword ptr [7FFE4976BAA8]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
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
       call      qword ptr [7FFE490D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L61:
       test      rbx,rbx
       je        near ptr M01_L23
       lea       rcx,[rbx+10]
       mov       edx,[rbx+8]
       mov       [rbp-60],rcx
       mov       [rbp-58],edx
       lea       rcx,[rbp-60]
       xor       edx,edx
       call      qword ptr [7FFE492F4648]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
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
       call      qword ptr [7FFE48F774B0]; System.Array.Clear(System.Array)
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
       call      qword ptr [7FFE48F774B0]; System.Array.Clear(System.Array)
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
       call      qword ptr [7FFE4956DEC0]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L68
       call      qword ptr [7FFE4956DC20]
       mov       r14,rax
M01_L68:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,2345B5FA588
       mov       r8,r14
       call      qword ptr [7FFE49206670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L69:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE490273F0]
       mov       rdi,rax
       test      rbx,rbx
       jne       near ptr M01_L07
M01_L70:
       call      qword ptr [7FFE4956DE30]
       mov       ecx,15D6
       mov       rdx,7FFE49307DB0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE49307DB0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE49026B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,9EA
       mov       rdx,7FFE49307DB0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE49026B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE4956DC20]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rbx
       call      qword ptr [7FFE49206670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L71:
       call      qword ptr [7FFE4956DE30]
       mov       ecx,15DE
       mov       rdx,7FFE49307DB0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE49307DB0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE49026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,9EA
       mov       rdx,7FFE49307DB0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE49026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE4956DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE49206670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L72:
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
       call      qword ptr [7FFE4915D5D0]; System.IO.StreamWriter.Dispose(Boolean)
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
       call      qword ptr [7FFE4976BAA8]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
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
       je        short M01_L73
       mov       rcx,[rax+8]
       call      qword ptr [7FFE48F774B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+8],rcx
M01_L73:
       cmp       qword ptr [rax+10],0
       je        short M01_L74
       mov       rcx,[rax+10]
       call      qword ptr [7FFE48F774B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+10],rcx
M01_L74:
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
; Total bytes of code 3760
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateAesIV()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE4940F198]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateAesIV()
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
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateAesIV()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-0B0],rsp
       lea       rcx,[rbp-98]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       rcx,offset MT_System.Security.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],1
       mov       dword ptr [rsi+2C],2
       mov       rcx,20505000B00
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r14,rax
       mov       rcx,[r14]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L00
       mov       r8d,[r14+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L00:
       mov       r8,rdx
       lea       rdx,[rdi+8]
       lea       rcx,[r14+8]
       mov       rax,[r14]
       test      dword ptr [rax],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L01:
       call      qword ptr [7FFE490C5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE490C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20505000B08
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r14,rax
       mov       rcx,[r14]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L04
       mov       r8d,[r14+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L04:
       mov       r8,rdx
       lea       rdx,[rdi+8]
       lea       rcx,[r14+8]
       mov       rax,[r14]
       test      dword ptr [rax],1000000
       je        short M01_L06
       cmp       r8,4000
       ja        short M01_L05
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L07
M01_L05:
       call      qword ptr [7FFE490C5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L07
M01_L06:
       call      qword ptr [7FFE490C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L07:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+30],80
       mov       dword ptr [rsi+34],8
       mov       dword ptr [rsi+38],100
       mov       dword ptr [rsi+28],1
       mov       [rbp-48],rsi
       mov       rdi,rsi
       mov       [rbp-50],rdi
       mov       r14d,[rdi+30]
       mov       r15d,r14d
       sar       r15d,1F
       and       r15d,7
       add       r14d,r15d
       sar       r14d,3
       mov       edx,r14d
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       [rbp-58],r15
       lea       rdx,[r15+10]
       mov       r8d,r14d
       test      r8d,r8d
       jle       short M01_L10
       mov       [rbp-40],rdx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-88],rax
       lea       rax,[M01_L08]
       mov       [rbp-70],rax
       lea       rax,[rbp-98]
       mov       [rbx+10],rax
       mov       byte ptr [rbx+0C],0
       mov       rax,7FFEC93A33A0
       call      rax
M01_L08:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFEA8EE1FDC],0
       je        short M01_L09
       call      qword ptr [7FFEA8ED2398]; CORINFO_HELP_STOP_FOR_GC
M01_L09:
       mov       rcx,[rbp-90]
       mov       [rbx+10],rcx
       test      eax,eax
       jne       near ptr M01_L18
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L10:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       r15,[rbp-58]
       mov       rdi,[rbp-50]
       mov       ecx,[rdi+30]
       mov       eax,ecx
       sar       eax,1F
       and       eax,7
       add       ecx,eax
       sar       ecx,3
       cmp       ecx,r14d
       jne       near ptr M01_L17
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       rbx,rax
       mov       rcx,[rbx]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L11
       mov       r8d,[rbx+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L11:
       mov       r8,rdx
       lea       rdx,[r15+8]
       lea       rcx,[rbx+8]
       mov       rax,[rbx]
       test      dword ptr [rax],1000000
       je        short M01_L14
       cmp       r8,4000
       ja        short M01_L13
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       rdx,rbx
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L19
M01_L13:
       call      qword ptr [7FFE490C5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L12
M01_L14:
       call      qword ptr [7FFE490C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L12
M01_L15:
       xor       edi,edi
       jmp       near ptr M01_L24
M01_L16:
       mov       rcx,rbx
       call      qword ptr [7FFE49783EB8]; System.Security.Cryptography.AesImplementation.GenerateIV()
       jmp       short M01_L20
M01_L17:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE49774AC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE4901CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       ecx,eax
       call      qword ptr [7FFE4972EEB0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rsi,[rbp-48]
       mov       rbx,rsi
       cmp       qword ptr [rbx+10],0
       je        short M01_L16
M01_L20:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       je        short M01_L15
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L21
       mov       r8d,[rdi+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L21:
       mov       r8,rdx
       lea       rdx,[rbx+8]
       lea       rcx,[rdi+8]
       mov       rax,[rdi]
       test      dword ptr [rax],1000000
       je        short M01_L23
       cmp       r8,4000
       ja        short M01_L22
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L22:
       call      qword ptr [7FFE490C5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       call      qword ptr [7FFE490C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L24:
       jmp       short M01_L25
M01_L25:
       cmp       qword ptr [rsi+8],0
       jne       short M01_L28
M01_L26:
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        short M01_L27
       call      qword ptr [7FFE48F674B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [rsi+10],rcx
M01_L27:
       mov       rcx,rsi
       call      qword ptr [7FFE4922C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rax,rdi
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
M01_L28:
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE48F674B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [rsi+8],rcx
       jmp       short M01_L26
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
       lea       rbp,[rbp+0D0]
       mov       rsi,[rbp-48]
       cmp       qword ptr [rsi+8],0
       je        short M01_L29
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE48F674B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [rsi+8],rcx
M01_L29:
       cmp       qword ptr [rsi+10],0
       je        short M01_L30
       mov       rcx,[rsi+10]
       call      qword ptr [7FFE48F674B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [rsi+10],rcx
M01_L30:
       mov       rcx,rsi
       call      qword ptr [7FFE4922C2E8]; System.GC.SuppressFinalize(System.Object)
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
; Total bytes of code 1089
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateAesKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE4940F1B0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateAesKey()
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
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateAesKey()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-0B0],rsp
       lea       rcx,[rbp-98]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       rcx,offset MT_System.Security.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],1
       mov       dword ptr [rsi+2C],2
       mov       rcx,105A9C06AD0
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r14,rax
       mov       rcx,[r14]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L00
       mov       r8d,[r14+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L00:
       mov       r8,rdx
       lea       rdx,[rdi+8]
       lea       rcx,[r14+8]
       mov       rax,[r14]
       test      dword ptr [rax],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L01:
       call      qword ptr [7FFE490C5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE490C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,105A9C06AD8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r14,rax
       mov       rcx,[r14]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L04
       mov       r8d,[r14+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L04:
       mov       r8,rdx
       lea       rdx,[rdi+8]
       lea       rcx,[r14+8]
       mov       rax,[r14]
       test      dword ptr [rax],1000000
       je        short M01_L06
       cmp       r8,4000
       ja        short M01_L05
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L07
M01_L05:
       call      qword ptr [7FFE490C5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L07
M01_L06:
       call      qword ptr [7FFE490C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L07:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+30],80
       mov       dword ptr [rsi+34],8
       mov       dword ptr [rsi+38],100
       mov       dword ptr [rsi+28],1
       mov       [rbp-48],rsi
       mov       rdi,rsi
       mov       [rbp-50],rdi
       mov       r14d,[rdi+38]
       mov       r15d,r14d
       sar       r15d,1F
       and       r15d,7
       add       r14d,r15d
       sar       r14d,3
       mov       edx,r14d
       mov       rsi,[rbp-48]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       [rbp-58],r15
       lea       rdx,[r15+10]
       mov       r8d,r14d
       test      r8d,r8d
       jle       short M01_L10
       mov       [rbp-40],rdx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-88],rax
       lea       rax,[M01_L08]
       mov       [rbp-70],rax
       lea       rax,[rbp-98]
       mov       [rbx+10],rax
       mov       byte ptr [rbx+0C],0
       mov       rax,7FFEC93A33A0
       call      rax
M01_L08:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFEA8EE1FDC],0
       je        short M01_L09
       call      qword ptr [7FFEA8ED2398]; CORINFO_HELP_STOP_FOR_GC
M01_L09:
       mov       rcx,[rbp-90]
       mov       [rbx+10],rcx
       test      eax,eax
       jne       near ptr M01_L28
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rsi,[rbp-48]
M01_L10:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       r15,[rbp-58]
       mov       ebx,r14d
       shl       rbx,3
       mov       rdi,[rbp-50]
       mov       rcx,[rdi+20]
       cmp       [rcx],cl
       call      qword ptr [7FFE48F64018]; System.Object.MemberwiseClone()
       mov       r8,rax
       test      r8,r8
       je        near ptr M01_L21
       xor       r14d,r14d
       cmp       dword ptr [r8+8],0
       jle       near ptr M01_L20
M01_L11:
       mov       eax,ebx
       mov       edx,r14d
       mov       r13,[r8+rdx*8+10]
       mov       ecx,[r13+10]
       test      ecx,ecx
       je        near ptr M01_L27
       mov       r12d,[r13+8]
       cmp       eax,r12d
       jl        near ptr M01_L23
       cmp       eax,[r13+0C]
       jg        near ptr M01_L23
       sub       eax,r12d
       cdq
       idiv      ecx
       test      edx,edx
       jne       near ptr M01_L23
M01_L12:
       mov       ecx,1
M01_L13:
       test      ecx,ecx
       je        near ptr M01_L21
       mov       rcx,[rdi+20]
       cmp       [rcx],cl
       call      qword ptr [7FFE48F64018]; System.Object.MemberwiseClone()
       mov       r8,rax
       test      r8,r8
       je        near ptr M01_L19
       xor       ecx,ecx
       cmp       dword ptr [r8+8],0
       jle       near ptr M01_L18
M01_L14:
       mov       eax,ecx
       mov       r10,[r8+rax*8+10]
       mov       r9d,[r10+10]
       test      r9d,r9d
       je        near ptr M01_L22
       mov       r11d,[r10+8]
       cmp       ebx,r11d
       jl        near ptr M01_L24
       cmp       ebx,[r10+0C]
       jg        near ptr M01_L24
       mov       eax,ebx
       sub       eax,r11d
       cdq
       idiv      r9d
       test      edx,edx
       jne       near ptr M01_L24
M01_L15:
       mov       eax,1
M01_L16:
       test      eax,eax
       je        short M01_L19
       mov       [rdi+38],ebx
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE49014C00]; System.Runtime.CompilerServices.RuntimeHelpers.GetRawObjectDataSize(System.Object)
       lea       rdx,[r15+8]
       lea       rcx,[r14+8]
       mov       r8,[r14]
       test      dword ptr [r8],1000000
       je        near ptr M01_L26
       cmp       rax,4000
       ja        near ptr M01_L25
       mov       r8,rax
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M01_L17:
       mov       rdx,r14
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L29
M01_L18:
       xor       eax,eax
       jmp       short M01_L16
M01_L19:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE49774B10]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE4901CED0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       xor       ecx,ecx
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE49774B10]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE4901CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       r11d,[r10+8]
       cmp       r11d,ebx
       jne       short M01_L24
       jmp       near ptr M01_L15
M01_L23:
       inc       r14d
       cmp       [r8+8],r14d
       jle       short M01_L20
       jmp       near ptr M01_L11
M01_L24:
       inc       ecx
       cmp       [r8+8],ecx
       jle       near ptr M01_L18
       jmp       near ptr M01_L14
M01_L25:
       mov       r8,rax
       call      qword ptr [7FFE490C5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L26:
       mov       r8,rax
       call      qword ptr [7FFE490C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L27:
       mov       r12d,[r13+8]
       cmp       r12d,eax
       jne       short M01_L23
       jmp       near ptr M01_L12
M01_L28:
       mov       ecx,eax
       call      qword ptr [7FFE4972EEB0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L29:
       jmp       short M01_L30
M01_L30:
       mov       rcx,rsi
       call      qword ptr [7FFE4975A8A8]; System.Security.Cryptography.SymmetricAlgorithm.get_Key()
       mov       rbx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE4975A918]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
       mov       rax,rbx
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
       lea       rbp,[rbp+0D0]
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE4975A918]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
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
; Total bytes of code 1199
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,21E524AAF90
       call      qword ptr [7FFE4942F1E0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
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
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
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
       call      qword ptr [7FFE49037318]; System.String.Trim()
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
       je        short M01_L06
       cmp       [rcx],ecx
       call      qword ptr [7FFE49037318]; System.String.Trim()
       mov       rdx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE4942F150]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rbx
       mov       rdx,[rsp+28]
       mov       r8,[rsp+30]
       call      qword ptr [7FFE4942F168]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      qword ptr [7FFE4957DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFE4957DC20]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21E524BB0D0
       mov       r8,rbx
       call      qword ptr [7FFE49216670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      qword ptr [7FFE4957DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FFE4957DC20]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21E524A99C8
       mov       r8,rbx
       call      qword ptr [7FFE49216670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 303
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Encrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,2587C10AF90
       call      qword ptr [7FFE4940F1F8]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
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
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
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
       call      qword ptr [7FFE49017318]; System.String.Trim()
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
       je        short M01_L06
       cmp       [rcx],ecx
       call      qword ptr [7FFE49017318]; System.String.Trim()
       mov       rdx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE4940F150]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rbx
       mov       rdx,[rsp+28]
       mov       r8,[rsp+30]
       call      qword ptr [7FFE4940F180]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      qword ptr [7FFE4955DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFE4955DC20]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2587C11A588
       mov       r8,rbx
       call      qword ptr [7FFE491F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      qword ptr [7FFE4955DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FFE4955DC20]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2587C1099C8
       mov       r8,rbx
       call      qword ptr [7FFE491F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 303
```

