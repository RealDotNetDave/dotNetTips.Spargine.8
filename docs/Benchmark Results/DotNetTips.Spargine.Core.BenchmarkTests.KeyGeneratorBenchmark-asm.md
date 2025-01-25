## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.KeyGeneratorBenchmark.GenerateKeyPrefix()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,1DA414D3B88
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       call      qword ptr [7FF94D3463A0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey(System.String ByRef)
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey(System.String ByRef)
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FF94CC47360]; System.Guid.NewGuid()
       mov       r8,199AF400428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,1DA414D3450
       call      qword ptr [7FF94CC47180]; System.Guid.ToString(System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FF94D03FAC8]
       mov       ecx,1774
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D03F8B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDB6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 238
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.KeyGeneratorBenchmark.GenerateKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF94D315B90]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
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
; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF94CC17360]; System.Guid.NewGuid()
       mov       r8,2D217400428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,312A5393450
       call      qword ptr [7FF94CC17180]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```

