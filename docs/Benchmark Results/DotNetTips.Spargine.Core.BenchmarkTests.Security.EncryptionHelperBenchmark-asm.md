## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesDecrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       mov       rdx,[rbx+138]
       mov       r8,[rbx+130]
       call      qword ptr [7FF9832D4B70]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
       sub       rsp,0F8
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-100],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-60],xmm4
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-60],rax
       mov       [rbp-108],rsp
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        near ptr M01_L62
       test      rbx,rbx
       je        near ptr M01_L63
       test      rsi,rsi
       je        near ptr M01_L64
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1C5A69C7178
       mov       [r14+10],rcx
       xor       ecx,ecx
       mov       [r14+24],ecx
       mov       byte ptr [r14+28],1
       mov       byte ptr [r14+29],1
       mov       byte ptr [r14+2A],1
       mov       byte ptr [r14+2B],1
       mov       [rbp-70],r14
       mov       rcx,offset MT_System.Security.Cryptography.AesCng
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+28],1
       mov       dword ptr [r15+2C],2
       mov       rcx,18514C07FB0
       mov       r13,[rcx]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r12,rax
       mov       rcx,[r12]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L01
       mov       r8d,[r12+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L01:
       mov       r8,rdx
       lea       rdx,[r13+8]
       lea       rcx,[r12+8]
       mov       rax,[r12]
       test      dword ptr [rax],1000000
       je        short M01_L03
       cmp       r8,4000
       ja        short M01_L02
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L02:
       call      qword ptr [7FF982F25BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       mov       rdx,r12
       lea       rcx,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,18514C07FB8
       mov       r13,[rcx]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r12,rax
       mov       rcx,[r12]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L05
       mov       r8d,[r12+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L05:
       mov       r8,rdx
       lea       rdx,[r13+8]
       lea       rcx,[r12+8]
       mov       rax,[r12]
       test      dword ptr [rax],1000000
       je        short M01_L07
       cmp       r8,4000
       ja        short M01_L06
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L08
M01_L06:
       call      qword ptr [7FF982F25BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L08
M01_L07:
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L08:
       mov       rdx,r12
       lea       rcx,[r15+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r15+30],80
       mov       dword ptr [r15+34],8
       mov       dword ptr [r15+38],100
       mov       dword ptr [r15+28],1
       mov       rcx,r15
       lea       rcx,[rcx+40]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+48],rcx
       mov       [r15+50],rcx
       mov       [r15+58],ecx
       mov       rcx,r15
       mov       [rbp-78],rcx
       lea       r15,[rcx+40]
       mov       rcx,[r15]
       mov       r11,7FF982D30B80
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rcx,[r15]
       mov       r11,7FF982D30B88
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rcx,[r15]
       mov       r11,7FF982D30B90
       call      qword ptr [r11]
       mov       [rbp-3C],eax
       cmp       r12d,4
       je        near ptr M01_L11
M01_L09:
       lea       rdx,[rbx+10]
       mov       ebx,[rbx+8]
       mov       [rbp-0D0],rdx
       movsxd    r8,ebx
       shl       r8,3
       mov       [rbp-48],r8
       cmp       r8,7FFFFFFF
       jg        near ptr M01_L24
       mov       rcx,[r15]
       mov       r10,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],r10
       jne       near ptr M01_L26
       mov       r10,[rcx+20]
       mov       [rbp-90],r10
       cmp       [r10],r10b
       mov       rcx,r10
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r10,rax
       mov       [rbp-98],r10
       mov       rcx,[r10]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L10
       mov       r8d,[r10+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L10:
       mov       r8,rdx
       mov       rdx,[rbp-90]
       add       rdx,8
       lea       rcx,[r10+8]
       mov       rax,[r10]
       test      dword ptr [rax],1000000
       je        near ptr M01_L29
       cmp       r8,4000
       ja        near ptr M01_L28
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L30
M01_L11:
       mov       eax,[rbp-3C]
       cmp       qword ptr [r15+8],0
       jne       near ptr M01_L12
       mov       rcx,[r15]
       mov       edx,eax
       mov       r11,7FF982D30BA0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L09
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9836D5488]
       mov       rsi,rax
       mov       edi,[rbp-3C]
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.Security.Cryptography.CipherMode
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],4
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r8,rdi
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9836D4E70]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF982E7CED0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L12:
       cmp       eax,8
       je        near ptr M01_L09
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9836D5488]
       mov       rdi,rax
       mov       ebx,[rbp-3C]
       mov       [rsi+8],ebx
       mov       rcx,offset MT_System.Security.Cryptography.CipherMode
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+8],4
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r8,rbx
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9836D4E70]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF982E7CED0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L13:
       call      qword ptr [7FF98306E9D0]
       int       3
M01_L14:
       xor       ecx,ecx
       xor       esi,esi
       jmp       near ptr M01_L55
M01_L15:
       call      qword ptr [7FF98306E9E8]
       int       3
M01_L16:
       mov       ecx,1D75
       mov       rdx,7FF982D24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9830966E8]
       int       3
M01_L17:
       mov       rbx,1C5A69C7178
       jmp       near ptr M01_L56
M01_L18:
       xor       esi,esi
       jmp       near ptr M01_L42
M01_L19:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9836D5AB8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF982E7CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9836D58F0]
       mov       r15,rax
       mov       ecx,4503
       mov       rdx,7FF983322FC8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FF982E7F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rdx,rbx
       mov       r11,7FF982D30BB8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L37
M01_L22:
       call      qword ptr [7FF9836D5920]
       mov       rsi,rax
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[r15]
       mov       r11,7FF982D30BC0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9836D4E58]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF982E7CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rbx,1C5A69C7178
       jmp       near ptr M01_L35
M01_L24:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9836D5938]
       mov       rdi,rax
       mov       ecx,44F5
       mov       rdx,7FF983322FC8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982E7F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       edx,[r11+8]
       cmp       edx,eax
       jne       short M01_L33
       jmp       short M01_L34
M01_L26:
       mov       r11,7FF982D30BA8
       call      qword ptr [r11]
       mov       r8,rax
       jmp       short M01_L31
M01_L27:
       xor       edx,edx
       jmp       near ptr M01_L44
M01_L28:
       call      qword ptr [7FF982F25BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L30
M01_L29:
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L30:
       mov       r8,[rbp-98]
M01_L31:
       xor       ecx,ecx
       mov       r10d,[r8+8]
       test      r10d,r10d
       jle       near ptr M01_L24
M01_L32:
       mov       r9,[rbp-48]
       mov       eax,r9d
       mov       edx,ecx
       mov       r11,[r8+rdx*8+10]
       mov       edx,[r11+10]
       test      edx,edx
       je        short M01_L25
       mov       r9d,[r11+8]
       cmp       eax,r9d
       jl        short M01_L33
       cmp       eax,[r11+0C]
       jg        short M01_L33
       sub       eax,r9d
       mov       r9d,edx
       cdq
       idiv      r9d
       test      edx,edx
       je        short M01_L34
M01_L33:
       inc       ecx
       cmp       r10d,ecx
       jg        short M01_L32
       jmp       near ptr M01_L24
M01_L34:
       test      ebx,ebx
       je        near ptr M01_L23
       mov       edx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       lea       rcx,[rax+10]
       mov       r8d,ebx
       mov       rdx,[rbp-0D0]
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rbp-0A0]
M01_L35:
       mov       rcx,[r15]
       mov       rdx,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],rdx
       je        short M01_L36
       mov       rdx,rbx
       mov       r11,7FF982D30BB0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L22
M01_L36:
       mov       rcx,[r15]
       mov       r11,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],r11
       jne       near ptr M01_L21
M01_L37:
       mov       eax,[rsi+8]
       mov       [rbp-0F4],eax
       mov       rcx,[r15]
       mov       r11,7FF982D30B98
       call      qword ptr [r11]
       add       eax,7
       mov       ecx,eax
       sar       ecx,1F
       and       ecx,7
       add       ecx,eax
       sar       ecx,3
       cmp       [rbp-0F4],ecx
       jne       near ptr M01_L20
       xor       eax,eax
       cmp       r12d,2
       cmove     rsi,rax
       test      rsi,rsi
       je        near ptr M01_L18
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       [rbp-0A8],rax
       mov       rcx,[rax]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L38
       mov       r8d,[rax+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L38:
       mov       r8,rdx
       lea       rdx,[rsi+8]
       lea       rcx,[rax+8]
       mov       r10,[rax]
       test      dword ptr [r10],1000000
       je        short M01_L40
       cmp       r8,4000
       ja        short M01_L39
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L41
M01_L39:
       call      qword ptr [7FF982F25BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L41
M01_L40:
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L41:
       mov       rsi,[rbp-0A8]
M01_L42:
       mov       rcx,[r15]
       mov       r11,7FF982D30BC8
       call      qword ptr [r11]
       add       eax,7
       mov       r10d,eax
       sar       r10d,1F
       and       r10d,7
       add       eax,r10d
       sar       eax,3
       mov       [rbp-4C],eax
       mov       rcx,[r15]
       mov       r8d,[rbp-3C]
       mov       edx,r12d
       mov       r11,7FF982D30BD0
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
       mov       rcx,[r15]
       mov       r8d,[rbp-3C]
       mov       edx,r12d
       mov       r11,7FF982D30BD8
       call      qword ptr [r11]
       mov       r15d,eax
       test      rbx,rbx
       je        near ptr M01_L49
       lea       rax,[rbx+10]
       mov       [rbp-0E0],rax
       mov       ecx,[rbx+8]
       mov       ebx,ecx
M01_L43:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B8],rax
       mov       r8,[rbp-0E0]
       mov       [rbp-0D8],r8
       cmp       r12d,2
       je        near ptr M01_L27
       test      rsi,rsi
       je        near ptr M01_L19
       mov       rdx,rsi
M01_L44:
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0B8]
       mov       r12d,[rbp-4C]
       mov       [rsi+10],r12d
       test      r15d,r15d
       jg        near ptr M01_L50
       mov       ecx,r12d
M01_L45:
       mov       [rsi+14],ecx
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M01_L48
       lea       rax,[rcx+10]
       mov       [rbp-0E8],rax
       mov       edx,[rcx+8]
       mov       [rbp-50],edx
M01_L46:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherLiteBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C0],rax
       mov       r8,[rbp-0E8]
       mov       [rbp-0F0],r8
       mov       r10d,[rbp-50]
       mov       [rbp-54],r10d
       test      r10d,r10d
       je        short M01_L47
       movsxd    rdx,r10d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,rax
       mov       [rbp-0C8],rdx
       lea       rcx,[rdx+10]
       mov       r8d,[rbp-54]
       mov       rdx,[rbp-0F0]
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbp-0C8]
       mov       rax,[rbp-0C0]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L47:
       mov       rax,[rbp-0C0]
       mov       [rax+18],r12d
       mov       [rax+1C],r15d
       mov       byte ptr [rax+20],1
       lea       rcx,[rax+10]
       mov       [rbp-100],rcx
       mov       r15,[rbp-0B0]
       mov       r12,[rbp-0D8]
       mov       [rbp-68],r12
       mov       [rbp-60],ebx
       mov       rcx,r15
       lea       rdx,[rbp-68]
       call      qword ptr [7FF983614360]; Interop+BCrypt.BCryptImportKey(Internal.NativeCrypto.SafeAlgorithmHandle, System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rbp-100]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Security.Cryptography.UniversalCryptoEncryptor
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],r13d
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L51
M01_L48:
       xor       eax,eax
       xor       edx,edx
       mov       [rbp-0E8],rax
       mov       [rbp-50],edx
       jmp       near ptr M01_L46
M01_L49:
       xor       ebx,ebx
       xor       eax,eax
       mov       [rbp-0E0],rbx
       mov       ebx,eax
       jmp       near ptr M01_L43
M01_L50:
       mov       ecx,r15d
       jmp       near ptr M01_L45
M01_L51:
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r13
       mov       rdx,r14
       mov       r8,rbx
       mov       r9d,1
       call      qword ptr [7FF9836D4300]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-80],r13
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,18518C013C0
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,r13
       mov       r9d,400
       call      qword ptr [7FF982FEDB78]; System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,rsi
       mov       [rbp-88],rcx
       mov       rdx,rdi
       call      qword ptr [7FF9830011C0]; System.IO.StreamWriter.Write(System.String)
       mov       rcx,[rbp-88]
       mov       rdx,[rcx+48]
       test      dword ptr [rdx+34],1600000
       je        short M01_L52
       mov       edx,1
       mov       r8d,1
       call      qword ptr [7FF982FEDCE0]; System.IO.StreamWriter.Flush(Boolean, Boolean)
       jmp       short M01_L53
M01_L52:
       call      qword ptr [7FF982FEDB00]
       int       3
M01_L53:
       mov       rcx,[rbp-88]
       mov       edx,1
       call      qword ptr [7FF983001128]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-88]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rcx,r13
       mov       edx,1
       call      qword ptr [7FF9836B9E60]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,r13
       call      System.GC._SuppressFinalize(System.Object)
       mov       r13d,[r14+20]
       sub       r13d,[r14+18]
       je        near ptr M01_L17
       cmp       r13d,800
       jl        near ptr M01_L57
       mov       edx,r13d
       mov       rcx,offset MT_System.Byte[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
M01_L54:
       mov       rcx,[r14+10]
       mov       edx,[r14+18]
       test      rcx,rcx
       je        near ptr M01_L13
       mov       r8d,edx
       mov       eax,r13d
       add       r8,rax
       mov       eax,[rcx+8]
       cmp       r8,rax
       ja        near ptr M01_L13
       cmp       [rcx],cl
       lea       rdx,[rcx+rdx+10]
       test      rbx,rbx
       je        near ptr M01_L14
       lea       rcx,[rbx+10]
       mov       esi,[rbx+8]
M01_L55:
       cmp       r13d,esi
       ja        near ptr M01_L15
       mov       r8d,r13d
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L56:
       test      rbx,rbx
       je        near ptr M01_L16
       lea       rcx,[rbx+10]
       mov       edx,[rbx+8]
       mov       [rbp-68],rcx
       mov       [rbp-60],edx
       lea       rcx,[rbp-68]
       xor       edx,edx
       call      qword ptr [7FF983174648]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
       mov       r15,rax
       jmp       short M01_L59
M01_L57:
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       jmp       near ptr M01_L54
M01_L58:
       mov       rcx,[rcx+8]
       call      qword ptr [7FF982DC74B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-78]
       mov       [rax+8],rcx
       mov       rcx,rax
       jmp       short M01_L60
M01_L59:
       mov       rcx,[rbp-78]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L58
M01_L60:
       cmp       qword ptr [rcx+10],0
       je        short M01_L61
       mov       rcx,[rcx+10]
       call      qword ptr [7FF982DC74B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-78]
       mov       [rax+10],rcx
       mov       rcx,rax
M01_L61:
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       byte ptr [r14+2B],0
       mov       byte ptr [r14+29],0
       mov       byte ptr [r14+28],0
       xor       ecx,ecx
       mov       [r14+30],rcx
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rax,r15
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L62:
       call      qword ptr [7FF9833844C8]
       mov       ecx,1AEE
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1446
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF982E76B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       ecx,0CCA
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF982E76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9833842B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF983096670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L63:
       call      qword ptr [7FF9833844C8]
       mov       ecx,1AE0
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1446
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF982E76B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,0CCA
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF982E76B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9833842B8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FF983096670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L64:
       call      qword ptr [7FF9833844C8]
       mov       ecx,1AE8
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF982E76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF982E76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9833842B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF983096670]
       mov       rcx,rsi
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+130]
       mov       rcx,[rbp-88]
       mov       edx,1
       call      qword ptr [7FF983001128]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-88]
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
       lea       rbp,[rbp+130]
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FF9836B9E60]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
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
       lea       rbp,[rbp+130]
       mov       rax,[rbp-78]
       cmp       qword ptr [rax+8],0
       je        short M01_L65
       mov       rcx,[rax+8]
       call      qword ptr [7FF982DC74B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-78]
       mov       [rax+8],rcx
M01_L65:
       cmp       qword ptr [rax+10],0
       je        short M01_L66
       mov       rcx,[rax+10]
       call      qword ptr [7FF982DC74B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-78]
       mov       [rax+10],rcx
M01_L66:
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
       lea       rbp,[rbp+130]
       mov       r14,[rbp-70]
       mov       byte ptr [r14+2B],0
       mov       byte ptr [r14+29],0
       mov       byte ptr [r14+28],0
       xor       ecx,ecx
       mov       [r14+30],rcx
       mov       rcx,r14
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
       lea       rbp,[rbp+130]
       mov       rbx,rdx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF983384210]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF983096730]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 3830
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesEncrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,[rbx+138]
       mov       r8,[rbx+130]
       call      qword ptr [7FF9832D4B70]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
       sub       rsp,0F8
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-100],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-60],xmm4
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-60],rax
       mov       [rbp-108],rsp
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        near ptr M01_L62
       test      rbx,rbx
       je        near ptr M01_L63
       test      rsi,rsi
       je        near ptr M01_L64
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1E9ED107178
       mov       [r14+10],rcx
       xor       ecx,ecx
       mov       [r14+24],ecx
       mov       byte ptr [r14+28],1
       mov       byte ptr [r14+29],1
       mov       byte ptr [r14+2A],1
       mov       byte ptr [r14+2B],1
       mov       [rbp-70],r14
       mov       rcx,offset MT_System.Security.Cryptography.AesCng
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+28],1
       mov       dword ptr [r15+2C],2
       mov       rcx,1A95B409FA8
       mov       r13,[rcx]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r12,rax
       mov       rcx,[r12]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L01
       mov       r8d,[r12+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L01:
       mov       r8,rdx
       lea       rdx,[r13+8]
       lea       rcx,[r12+8]
       mov       rax,[r12]
       test      dword ptr [rax],1000000
       je        short M01_L03
       cmp       r8,4000
       ja        short M01_L02
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L02:
       call      qword ptr [7FF982F25BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       mov       rdx,r12
       lea       rcx,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1A95B409FB0
       mov       r13,[rcx]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r12,rax
       mov       rcx,[r12]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L05
       mov       r8d,[r12+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L05:
       mov       r8,rdx
       lea       rdx,[r13+8]
       lea       rcx,[r12+8]
       mov       rax,[r12]
       test      dword ptr [rax],1000000
       je        short M01_L07
       cmp       r8,4000
       ja        short M01_L06
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L08
M01_L06:
       call      qword ptr [7FF982F25BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L08
M01_L07:
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L08:
       mov       rdx,r12
       lea       rcx,[r15+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r15+30],80
       mov       dword ptr [r15+34],8
       mov       dword ptr [r15+38],100
       mov       dword ptr [r15+28],1
       mov       rcx,r15
       lea       rcx,[rcx+40]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+48],rcx
       mov       [r15+50],rcx
       mov       [r15+58],ecx
       mov       rcx,r15
       mov       [rbp-78],rcx
       lea       r15,[rcx+40]
       mov       rcx,[r15]
       mov       r11,7FF982D30B30
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rcx,[r15]
       mov       r11,7FF982D30B38
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rcx,[r15]
       mov       r11,7FF982D30B40
       call      qword ptr [r11]
       mov       [rbp-3C],eax
       cmp       r12d,4
       je        near ptr M01_L11
M01_L09:
       lea       rdx,[rbx+10]
       mov       ebx,[rbx+8]
       mov       [rbp-0D0],rdx
       movsxd    r8,ebx
       shl       r8,3
       mov       [rbp-48],r8
       cmp       r8,7FFFFFFF
       jg        near ptr M01_L24
       mov       rcx,[r15]
       mov       r10,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],r10
       jne       near ptr M01_L26
       mov       r10,[rcx+20]
       mov       [rbp-90],r10
       cmp       [r10],r10b
       mov       rcx,r10
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r10,rax
       mov       [rbp-98],r10
       mov       rcx,[r10]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L10
       mov       r8d,[r10+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L10:
       mov       r8,rdx
       mov       rdx,[rbp-90]
       add       rdx,8
       lea       rcx,[r10+8]
       mov       rax,[r10]
       test      dword ptr [rax],1000000
       je        near ptr M01_L29
       cmp       r8,4000
       ja        near ptr M01_L28
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L30
M01_L11:
       mov       eax,[rbp-3C]
       cmp       qword ptr [r15+8],0
       jne       near ptr M01_L12
       mov       rcx,[r15]
       mov       edx,eax
       mov       r11,7FF982D30B50
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L09
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9836D5488]
       mov       rsi,rax
       mov       edi,[rbp-3C]
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.Security.Cryptography.CipherMode
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],4
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r8,rdi
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9836D4E70]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF982E7CED0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L12:
       cmp       eax,8
       je        near ptr M01_L09
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9836D5488]
       mov       rdi,rax
       mov       ebx,[rbp-3C]
       mov       [rsi+8],ebx
       mov       rcx,offset MT_System.Security.Cryptography.CipherMode
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+8],4
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r8,rbx
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9836D4E70]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF982E7CED0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L13:
       call      qword ptr [7FF98306E9D0]
       int       3
M01_L14:
       xor       ecx,ecx
       xor       esi,esi
       jmp       near ptr M01_L55
M01_L15:
       call      qword ptr [7FF98306E9E8]
       int       3
M01_L16:
       mov       ecx,1D75
       mov       rdx,7FF982D24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9830966E8]
       int       3
M01_L17:
       mov       rbx,1E9ED107178
       jmp       near ptr M01_L56
M01_L18:
       xor       esi,esi
       jmp       near ptr M01_L42
M01_L19:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9836D5AB8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF982E7CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9836D58F0]
       mov       r15,rax
       mov       ecx,4503
       mov       rdx,7FF983322FC8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FF982E7F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rdx,rbx
       mov       r11,7FF982D30B68
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L37
M01_L22:
       call      qword ptr [7FF9836D5920]
       mov       rsi,rax
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[r15]
       mov       r11,7FF982D30B70
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9836D4E58]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF982E7CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rbx,1E9ED107178
       jmp       near ptr M01_L35
M01_L24:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9836D5938]
       mov       rdi,rax
       mov       ecx,44F5
       mov       rdx,7FF983322FC8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982E7F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       edx,[r11+8]
       cmp       edx,eax
       jne       short M01_L33
       jmp       short M01_L34
M01_L26:
       mov       r11,7FF982D30B58
       call      qword ptr [r11]
       mov       r8,rax
       jmp       short M01_L31
M01_L27:
       xor       edx,edx
       jmp       near ptr M01_L44
M01_L28:
       call      qword ptr [7FF982F25BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L30
M01_L29:
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L30:
       mov       r8,[rbp-98]
M01_L31:
       xor       ecx,ecx
       mov       r10d,[r8+8]
       test      r10d,r10d
       jle       near ptr M01_L24
M01_L32:
       mov       r9,[rbp-48]
       mov       eax,r9d
       mov       edx,ecx
       mov       r11,[r8+rdx*8+10]
       mov       edx,[r11+10]
       test      edx,edx
       je        short M01_L25
       mov       r9d,[r11+8]
       cmp       eax,r9d
       jl        short M01_L33
       cmp       eax,[r11+0C]
       jg        short M01_L33
       sub       eax,r9d
       mov       r9d,edx
       cdq
       idiv      r9d
       test      edx,edx
       je        short M01_L34
M01_L33:
       inc       ecx
       cmp       r10d,ecx
       jg        short M01_L32
       jmp       near ptr M01_L24
M01_L34:
       test      ebx,ebx
       je        near ptr M01_L23
       mov       edx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       lea       rcx,[rax+10]
       mov       r8d,ebx
       mov       rdx,[rbp-0D0]
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rbp-0A0]
M01_L35:
       mov       rcx,[r15]
       mov       rdx,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],rdx
       je        short M01_L36
       mov       rdx,rbx
       mov       r11,7FF982D30B60
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L22
M01_L36:
       mov       rcx,[r15]
       mov       r11,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],r11
       jne       near ptr M01_L21
M01_L37:
       mov       eax,[rsi+8]
       mov       [rbp-0F4],eax
       mov       rcx,[r15]
       mov       r11,7FF982D30B48
       call      qword ptr [r11]
       add       eax,7
       mov       ecx,eax
       sar       ecx,1F
       and       ecx,7
       add       ecx,eax
       sar       ecx,3
       cmp       [rbp-0F4],ecx
       jne       near ptr M01_L20
       xor       eax,eax
       cmp       r12d,2
       cmove     rsi,rax
       test      rsi,rsi
       je        near ptr M01_L18
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       [rbp-0A8],rax
       mov       rcx,[rax]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L38
       mov       r8d,[rax+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L38:
       mov       r8,rdx
       lea       rdx,[rsi+8]
       lea       rcx,[rax+8]
       mov       r10,[rax]
       test      dword ptr [r10],1000000
       je        short M01_L40
       cmp       r8,4000
       ja        short M01_L39
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L41
M01_L39:
       call      qword ptr [7FF982F25BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L41
M01_L40:
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L41:
       mov       rsi,[rbp-0A8]
M01_L42:
       mov       rcx,[r15]
       mov       r11,7FF982D30B78
       call      qword ptr [r11]
       add       eax,7
       mov       r10d,eax
       sar       r10d,1F
       and       r10d,7
       add       eax,r10d
       sar       eax,3
       mov       [rbp-4C],eax
       mov       rcx,[r15]
       mov       r8d,[rbp-3C]
       mov       edx,r12d
       mov       r11,7FF982D30B80
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
       mov       rcx,[r15]
       mov       r8d,[rbp-3C]
       mov       edx,r12d
       mov       r11,7FF982D30B88
       call      qword ptr [r11]
       mov       r15d,eax
       test      rbx,rbx
       je        near ptr M01_L49
       lea       rax,[rbx+10]
       mov       [rbp-0E0],rax
       mov       ecx,[rbx+8]
       mov       ebx,ecx
M01_L43:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B8],rax
       mov       r8,[rbp-0E0]
       mov       [rbp-0D8],r8
       cmp       r12d,2
       je        near ptr M01_L27
       test      rsi,rsi
       je        near ptr M01_L19
       mov       rdx,rsi
M01_L44:
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0B8]
       mov       r12d,[rbp-4C]
       mov       [rsi+10],r12d
       test      r15d,r15d
       jg        near ptr M01_L50
       mov       ecx,r12d
M01_L45:
       mov       [rsi+14],ecx
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M01_L48
       lea       rax,[rcx+10]
       mov       [rbp-0E8],rax
       mov       edx,[rcx+8]
       mov       [rbp-50],edx
M01_L46:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherLiteBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C0],rax
       mov       r8,[rbp-0E8]
       mov       [rbp-0F0],r8
       mov       r10d,[rbp-50]
       mov       [rbp-54],r10d
       test      r10d,r10d
       je        short M01_L47
       movsxd    rdx,r10d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,rax
       mov       [rbp-0C8],rdx
       lea       rcx,[rdx+10]
       mov       r8d,[rbp-54]
       mov       rdx,[rbp-0F0]
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbp-0C8]
       mov       rax,[rbp-0C0]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L47:
       mov       rax,[rbp-0C0]
       mov       [rax+18],r12d
       mov       [rax+1C],r15d
       mov       byte ptr [rax+20],1
       lea       rcx,[rax+10]
       mov       [rbp-100],rcx
       mov       r15,[rbp-0B0]
       mov       r12,[rbp-0D8]
       mov       [rbp-68],r12
       mov       [rbp-60],ebx
       mov       rcx,r15
       lea       rdx,[rbp-68]
       call      qword ptr [7FF983614360]; Interop+BCrypt.BCryptImportKey(Internal.NativeCrypto.SafeAlgorithmHandle, System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rbp-100]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Security.Cryptography.UniversalCryptoEncryptor
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],r13d
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L51
M01_L48:
       xor       eax,eax
       xor       edx,edx
       mov       [rbp-0E8],rax
       mov       [rbp-50],edx
       jmp       near ptr M01_L46
M01_L49:
       xor       ebx,ebx
       xor       eax,eax
       mov       [rbp-0E0],rbx
       mov       ebx,eax
       jmp       near ptr M01_L43
M01_L50:
       mov       ecx,r15d
       jmp       near ptr M01_L45
M01_L51:
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r13
       mov       rdx,r14
       mov       r8,rbx
       mov       r9d,1
       call      qword ptr [7FF9836D4300]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-80],r13
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,1A95B4013C0
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,r13
       mov       r9d,400
       call      qword ptr [7FF982FEDB78]; System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,rsi
       mov       [rbp-88],rcx
       mov       rdx,rdi
       call      qword ptr [7FF9830011C0]; System.IO.StreamWriter.Write(System.String)
       mov       rcx,[rbp-88]
       mov       rdx,[rcx+48]
       test      dword ptr [rdx+34],1600000
       je        short M01_L52
       mov       edx,1
       mov       r8d,1
       call      qword ptr [7FF982FEDCE0]; System.IO.StreamWriter.Flush(Boolean, Boolean)
       jmp       short M01_L53
M01_L52:
       call      qword ptr [7FF982FEDB00]
       int       3
M01_L53:
       mov       rcx,[rbp-88]
       mov       edx,1
       call      qword ptr [7FF983001128]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-88]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rcx,r13
       mov       edx,1
       call      qword ptr [7FF9836B9C38]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,r13
       call      System.GC._SuppressFinalize(System.Object)
       mov       r13d,[r14+20]
       sub       r13d,[r14+18]
       je        near ptr M01_L17
       cmp       r13d,800
       jl        near ptr M01_L57
       mov       edx,r13d
       mov       rcx,offset MT_System.Byte[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
M01_L54:
       mov       rcx,[r14+10]
       mov       edx,[r14+18]
       test      rcx,rcx
       je        near ptr M01_L13
       mov       r8d,edx
       mov       eax,r13d
       add       r8,rax
       mov       eax,[rcx+8]
       cmp       r8,rax
       ja        near ptr M01_L13
       cmp       [rcx],cl
       lea       rdx,[rcx+rdx+10]
       test      rbx,rbx
       je        near ptr M01_L14
       lea       rcx,[rbx+10]
       mov       esi,[rbx+8]
M01_L55:
       cmp       r13d,esi
       ja        near ptr M01_L15
       mov       r8d,r13d
       call      qword ptr [7FF982F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L56:
       test      rbx,rbx
       je        near ptr M01_L16
       lea       rcx,[rbx+10]
       mov       edx,[rbx+8]
       mov       [rbp-68],rcx
       mov       [rbp-60],edx
       lea       rcx,[rbp-68]
       xor       edx,edx
       call      qword ptr [7FF983174648]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
       mov       r15,rax
       jmp       short M01_L59
M01_L57:
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       jmp       near ptr M01_L54
M01_L58:
       mov       rcx,[rcx+8]
       call      qword ptr [7FF982DC74B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-78]
       mov       [rax+8],rcx
       mov       rcx,rax
       jmp       short M01_L60
M01_L59:
       mov       rcx,[rbp-78]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L58
M01_L60:
       cmp       qword ptr [rcx+10],0
       je        short M01_L61
       mov       rcx,[rcx+10]
       call      qword ptr [7FF982DC74B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-78]
       mov       [rax+10],rcx
       mov       rcx,rax
M01_L61:
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       byte ptr [r14+2B],0
       mov       byte ptr [r14+29],0
       mov       byte ptr [r14+28],0
       xor       ecx,ecx
       mov       [r14+30],rcx
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rax,r15
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L62:
       call      qword ptr [7FF9833844C8]
       mov       ecx,1AEE
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1446
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF982E76B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       ecx,0CCA
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF982E76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9833842B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF983096670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L63:
       call      qword ptr [7FF9833844C8]
       mov       ecx,1AE0
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1446
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF982E76B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,0CCA
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF982E76B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9833842B8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FF983096670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L64:
       call      qword ptr [7FF9833844C8]
       mov       ecx,1AE8
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF982E76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FF98318BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF982E76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9833842B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF983096670]
       mov       rcx,rsi
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+130]
       mov       rcx,[rbp-88]
       mov       edx,1
       call      qword ptr [7FF983001128]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-88]
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
       lea       rbp,[rbp+130]
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FF9836B9C38]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
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
       lea       rbp,[rbp+130]
       mov       rax,[rbp-78]
       cmp       qword ptr [rax+8],0
       je        short M01_L65
       mov       rcx,[rax+8]
       call      qword ptr [7FF982DC74B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-78]
       mov       [rax+8],rcx
M01_L65:
       cmp       qword ptr [rax+10],0
       je        short M01_L66
       mov       rcx,[rax+10]
       call      qword ptr [7FF982DC74B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-78]
       mov       [rax+10],rcx
M01_L66:
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
       lea       rbp,[rbp+130]
       mov       r14,[rbp-70]
       mov       byte ptr [r14+2B],0
       mov       byte ptr [r14+29],0
       mov       byte ptr [r14+28],0
       xor       ecx,ecx
       mov       [r14+30],rcx
       mov       rcx,r14
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
       lea       rbp,[rbp+130]
       mov       rbx,rdx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF983384210]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF983096730]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 3830
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateAesIV()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF983294B88]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateAesIV()
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
       mov       rcx,1F35AC07FB0
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
       call      qword ptr [7FF982EE5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF982EE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F35AC07FB8
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
       call      qword ptr [7FF982EE5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L07
M01_L06:
       call      qword ptr [7FF982EE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,7FFA6B0F3670
       call      rax
M01_L08:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FF9E2D0A0DC],0
       je        short M01_L09
       call      qword ptr [7FF9E2CFA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF982EE5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L12
M01_L14:
       call      qword ptr [7FF982EE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L12
M01_L15:
       xor       edi,edi
       jmp       near ptr M01_L24
M01_L16:
       mov       rcx,rbx
       call      qword ptr [7FF9836A39D0]; System.Security.Cryptography.AesImplementation.GenerateIV()
       jmp       short M01_L20
M01_L17:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9836958F0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF982E3CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       ecx,eax
       call      qword ptr [7FF9835D4510]
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
       call      qword ptr [7FF982EE5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       call      qword ptr [7FF982EE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L24:
       jmp       short M01_L25
M01_L25:
       cmp       qword ptr [rsi+8],0
       jne       short M01_L28
M01_L26:
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        short M01_L27
       call      qword ptr [7FF982D874B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [rsi+10],rcx
M01_L27:
       mov       rcx,rsi
       call      qword ptr [7FF98307C2E8]; System.GC.SuppressFinalize(System.Object)
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
       call      qword ptr [7FF982D874B0]; System.Array.Clear(System.Array)
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
       call      qword ptr [7FF982D874B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [rsi+8],rcx
M01_L29:
       cmp       qword ptr [rsi+10],0
       je        short M01_L30
       mov       rcx,[rsi+10]
       call      qword ptr [7FF982D874B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [rsi+10],rcx
M01_L30:
       mov       rcx,rsi
       call      qword ptr [7FF98307C2E8]; System.GC.SuppressFinalize(System.Object)
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateAesKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF9832B4BA0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateAesKey()
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
       mov       rcx,14A74009FA8
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
       call      qword ptr [7FF982F05BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF982F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,14A74009FB0
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
       call      qword ptr [7FF982F05BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L07
M01_L06:
       call      qword ptr [7FF982F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,7FFA6B0F3670
       call      rax
M01_L08:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FF9E2D0A0DC],0
       je        short M01_L09
       call      qword ptr [7FF9E2CFA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF982DA4018]; System.Object.MemberwiseClone()
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
       call      qword ptr [7FF982DA4018]; System.Object.MemberwiseClone()
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
       call      qword ptr [7FF982E54C00]; System.Runtime.CompilerServices.RuntimeHelpers.GetRawObjectDataSize(System.Object)
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
       call      qword ptr [7FF9836B5938]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF982E5CED0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       xor       ecx,ecx
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9836B5938]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF982E5CED0]
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
       call      qword ptr [7FF982F05BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L26:
       mov       r8,rax
       call      qword ptr [7FF982F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L27:
       mov       r12d,[r13+8]
       cmp       r12d,eax
       jne       short M01_L23
       jmp       near ptr M01_L12
M01_L28:
       mov       ecx,eax
       call      qword ptr [7FF9835F4510]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L29:
       jmp       short M01_L30
M01_L30:
       mov       rcx,rsi
       call      qword ptr [7FF983698A20]; System.Security.Cryptography.SymmetricAlgorithm.get_Key()
       mov       rbx,rax
       mov       rcx,rsi
       call      qword ptr [7FF983698A90]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
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
       call      qword ptr [7FF983698A90]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateRandomKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF9832C4BB8]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateRandomKey()
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
; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateRandomKey()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF982F17360]; System.Guid.NewGuid()
       mov       r8,219E2800428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,25A70813CA0
       call      qword ptr [7FF982F17180]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       mov       rdx,2125156AF90
       call      qword ptr [7FF9832C4BD0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
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
       call      qword ptr [7FF982E67318]; System.String.Trim()
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
       call      qword ptr [7FF982E67318]; System.String.Trim()
       mov       rdx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9832C4B40]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rbx
       mov       rdx,[rsp+28]
       mov       r8,[rsp+30]
       call      qword ptr [7FF9832C4B58]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      qword ptr [7FF983374570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FF9833742B8]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21251574B88
       mov       r8,rbx
       call      qword ptr [7FF983086670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      qword ptr [7FF983374570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FF9833742B8]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,212515699C8
       mov       r8,rbx
       call      qword ptr [7FF983086670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 303
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Encrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,1EEB035AF90
       call      qword ptr [7FF9832B4BE8]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
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
       call      qword ptr [7FF982E57318]; System.String.Trim()
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
       call      qword ptr [7FF982E57318]; System.String.Trim()
       mov       rdx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9832B4B40]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rbx
       mov       rdx,[rsp+28]
       mov       r8,[rsp+30]
       call      qword ptr [7FF9832B4B70]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      qword ptr [7FF983364570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FF9833642B8]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1EEB0363FB8
       mov       r8,rbx
       call      qword ptr [7FF983076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      qword ptr [7FF983364570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FF9833642B8]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1EEB03599C8
       mov       r8,rbx
       call      qword ptr [7FF983076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 303
```

