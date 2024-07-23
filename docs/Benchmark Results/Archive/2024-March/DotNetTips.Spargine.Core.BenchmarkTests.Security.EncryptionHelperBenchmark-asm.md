## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesDecrypt()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       mov       rdx,[rbx+128]
       mov       r8,[rbx+120]
       call      qword ptr [7FFDF02FF180]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF062FDC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-88],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,2DFC9312958
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2DFC9300008
       call      qword ptr [7FFDF03A7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rdx,[rbp-30]
       mov       [rbp+10],rdx
       mov       rdx,2DFC9309A40
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       mov       r9,2DFC9300008
       call      qword ptr [7FFDF03A7C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rdx,[rbp-38]
       mov       [rbp+18],rdx
       mov       rdx,2DFC9300B20
       mov       [rsp+20],rdx
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       mov       r9,2DFC9300008
       call      qword ptr [7FFDF03A7C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+20],rcx
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       call      qword ptr [7FFDF03ADE30]; System.IO.MemoryStream..ctor()
       mov       rcx,[rbp-48]
       mov       [rbp-8],rcx
       nop
       mov       rcx,offset MT_System.Security.Cryptography.AesCng
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FFDF05C69B8]; System.Security.Cryptography.AesCng..ctor()
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       [rbp-60],rax
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-58]
       mov       r8,[rbp-60]
       mov       r9d,1
       call      qword ptr [7FFDF05C6CA0]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode)
       mov       rcx,[rbp-68]
       mov       [rbp-18],rcx
       nop
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-18]
       call      qword ptr [7FFDF004DB18]; System.IO.StreamWriter..ctor(System.IO.Stream)
       mov       rcx,[rbp-70]
       mov       [rbp-20],rcx
       nop
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+10]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       nop
       nop
       nop
       mov       rcx,rsp
       call      M01_L02
       nop
       nop
       nop
       mov       rcx,rsp
       call      M01_L04
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       call      qword ptr [7FFDF01D45E8]; System.Convert.ToBase64String(Byte[])
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       [rbp-28],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
       mov       rax,[rbp-28]
       add       rsp,0B0
       pop       rbp
       ret
M01_L02:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-20],0
       je        short M01_L03
       mov       rcx,[rbp-20]
       mov       r11,7FFDEFDC05B0
       call      qword ptr [r11]
       nop
M01_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L04:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-18],0
       je        short M01_L05
       mov       rcx,[rbp-18]
       mov       r11,7FFDEFDC05B8
       call      qword ptr [r11]
       nop
M01_L05:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-10],0
       je        short M01_L07
       mov       rcx,[rbp-10]
       mov       r11,7FFDEFDC05C0
       call      qword ptr [r11]
       nop
M01_L07:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-8],0
       je        short M01_L09
       mov       rcx,[rbp-8]
       mov       r11,7FFDEFDC05C8
       call      qword ptr [r11]
       nop
M01_L09:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 813
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF0641C20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF062FDF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesEncrypt()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFDF0204798]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       rdx,[rbx+128]
       mov       r8,[rbx+120]
       call      qword ptr [7FFDF02EF180]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF061FA98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01D68D0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-88],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D7F70],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       mov       rcx,30447C72958
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,30447C60008
       call      qword ptr [7FFDF0397A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rdx,[rbp-30]
       mov       [rbp+10],rdx
       mov       rdx,30447C69A40
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       mov       r9,30447C60008
       call      qword ptr [7FFDF0397C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rdx,[rbp-38]
       mov       [rbp+18],rdx
       mov       rdx,30447C60B20
       mov       [rsp+20],rdx
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       mov       r9,30447C60008
       call      qword ptr [7FFDF0397C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+20],rcx
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       call      qword ptr [7FFDF039DE30]; System.IO.MemoryStream..ctor()
       mov       rcx,[rbp-48]
       mov       [rbp-8],rcx
       nop
       mov       rcx,offset MT_System.Security.Cryptography.AesCng
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FFDF05B69B8]; System.Security.Cryptography.AesCng..ctor()
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       [rbp-60],rax
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-58]
       mov       r8,[rbp-60]
       mov       r9d,1
       call      qword ptr [7FFDF05B6CA0]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode)
       mov       rcx,[rbp-68]
       mov       [rbp-18],rcx
       nop
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-18]
       call      qword ptr [7FFDF003DB18]; System.IO.StreamWriter..ctor(System.IO.Stream)
       mov       rcx,[rbp-70]
       mov       [rbp-20],rcx
       nop
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+10]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       nop
       nop
       nop
       mov       rcx,rsp
       call      M02_L02
       nop
       nop
       nop
       mov       rcx,rsp
       call      M02_L04
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       call      qword ptr [7FFDF01C45E8]; System.Convert.ToBase64String(Byte[])
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       [rbp-28],rcx
       nop
       mov       rcx,rsp
       call      M02_L06
       nop
       mov       rcx,rsp
       call      M02_L08
       nop
       mov       rax,[rbp-28]
       add       rsp,0B0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-20],0
       je        short M02_L03
       mov       rcx,[rbp-20]
       mov       r11,7FFDEFDB05B0
       call      qword ptr [r11]
       nop
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-18],0
       je        short M02_L05
       mov       rcx,[rbp-18]
       mov       r11,7FFDEFDB05B8
       call      qword ptr [r11]
       nop
M02_L05:
       nop
       add       rsp,30
       pop       rbp
       ret
M02_L06:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-10],0
       je        short M02_L07
       mov       rcx,[rbp-10]
       mov       r11,7FFDEFDB05C0
       call      qword ptr [r11]
       nop
M02_L07:
       nop
       add       rsp,30
       pop       rbp
       ret
M02_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-8],0
       je        short M02_L09
       mov       rcx,[rbp-8]
       mov       r11,7FFDEFDB05C8
       call      qword ptr [r11]
       nop
M02_L09:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 813
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D68D0],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF0631C20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF061FAC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,2C04B88B038
       call      qword ptr [7FFDF02CF1E0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF05FFA98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
       push      rbp
       sub       rsp,70
       vzeroupper
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01B7FB8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,2C04B8934C0
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2C04B880008
       call      qword ptr [7FFDF0377A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp+10],rcx
       mov       rcx,2C04B889A40
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2C04B880008
       call      qword ptr [7FFDF0377A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+18],rcx
       lea       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFDF02CF150]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       vmovdqu   xmm0,xmmword ptr [rbp-38]
       vmovdqu   xmmword ptr [rbp-10],xmm0
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-8]
       call      qword ptr [7FFDF02CF168]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 235
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF0612F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0625728]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleEncrypt()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFDF0204D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       rdx,2C62DBEB038
       call      qword ptr [7FFDF02EF1F8]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF061FDC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01D6918],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
       push      rbp
       sub       rsp,70
       vzeroupper
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,2C62DBF2958
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2C62DBE0008
       call      qword ptr [7FFDF0397A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp+10],rcx
       mov       rcx,2C62DBE9A40
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2C62DBE0008
       call      qword ptr [7FFDF0397A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+18],rcx
       lea       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFDF02EF150]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       vmovdqu   xmm0,xmmword ptr [rbp-38]
       vmovdqu   xmmword ptr [rbp-10],xmm0
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-8]
       call      qword ptr [7FFDF02EF180]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 235
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF0631C20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF061FDF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

