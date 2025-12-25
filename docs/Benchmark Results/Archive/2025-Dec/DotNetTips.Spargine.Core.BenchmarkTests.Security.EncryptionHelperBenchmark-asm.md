## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateRandomKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF90045FDB0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateRandomKey()
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
; 	public static string GenerateRandomKey() => Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture);
; 	                                            ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9000B7360]; System.Guid.NewGuid()
       mov       r8,27CC0400428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,2BD52423DD8
       call      qword ptr [7FF9000B7180]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       mov       rdx,29BFEB3B0C8
       call      qword ptr [7FF90045FDC8]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
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
; 		cipherText = cipherText.ArgumentNotNullOrEmpty(true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		key = key.ArgumentNotNullOrEmpty(true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var keys = GetSHA256HashKeys(key);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return AesDecrypt(cipherText, keys.key, keys.iv);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FF900007318]; System.String.Trim()
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
       call      qword ptr [7FF900007318]; System.String.Trim()
       mov       rdx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF90045FD38]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rbx
       mov       rdx,[rsp+28]
       mov       r8,[rsp+30]
       call      qword ptr [7FF90045FD50]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      qword ptr [7FF9004F5848]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FF9004F5590]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29BFEB44D48
       mov       r8,rbx
       call      qword ptr [7FF900196718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      qword ptr [7FF9004F5848]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FF9004F5590]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29BFEB39AB0
       mov       r8,rbx
       call      qword ptr [7FF900196718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 303
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Encrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,24452DCB0C8
       call      qword ptr [7FF90046FDE0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
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
; 		plainText = plainText.ArgumentNotNullOrEmpty(true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var keys = GetSHA256HashKeys(key);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return AesEncrypt(plainText, keys.key, keys.iv);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FF900017318]; System.String.Trim()
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
       call      qword ptr [7FF900017318]; System.String.Trim()
       mov       rdx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF90046FD38]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rbx
       mov       rdx,[rsp+28]
       mov       r8,[rsp+30]
       call      qword ptr [7FF90046FD68]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      qword ptr [7FF900505848]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FF900505590]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24452DD40F0
       mov       r8,rbx
       call      qword ptr [7FF9001A6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      qword ptr [7FF900505848]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FF900505590]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24452DC9AB0
       mov       r8,rbx
       call      qword ptr [7FF9001A6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 303
```

