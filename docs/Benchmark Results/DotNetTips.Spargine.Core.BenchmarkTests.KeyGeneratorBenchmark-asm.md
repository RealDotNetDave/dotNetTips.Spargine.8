## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.KeyGeneratorBenchmark.GenerateKeyPrefix()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,1EDF84EAB58
       call      qword ptr [7FFBF9C973D8]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey(System.String)
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
; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey(System.String)
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBF9617360]; System.Guid.NewGuid()
       mov       r8,1AD66800428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,1EDF84DC068
       call      qword ptr [7FFBF9617180]; System.Guid.ToString(System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFBF9ABCCD8]
       mov       ecx,1248
       mov       rdx,7FFBF984ABC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF984ABC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0A14
       mov       rdx,7FFBF984ABC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9ABCAC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF9756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 238
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.KeyGeneratorBenchmark.GenerateKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFBF9C973C0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
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
       call      qword ptr [7FFBF9617360]; System.Guid.NewGuid()
       mov       r8,1BEB0800428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,1FF3E68C068
       call      qword ptr [7FFBF9617180]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```

