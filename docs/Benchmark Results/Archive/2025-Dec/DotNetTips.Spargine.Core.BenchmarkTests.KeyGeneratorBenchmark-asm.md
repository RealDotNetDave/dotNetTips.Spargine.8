## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.KeyGeneratorBenchmark.GenerateKeyPrefix()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,28A6F194768
       call      qword ptr [7FF9007C63B8]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey(System.String)
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
; 	public static string GenerateKey([NotNull] string prefix) => $"{prefix.ArgumentNotNull()}{Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture)}";
; 	                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FF9000C7360]; System.Guid.NewGuid()
       mov       r8,249DD400428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,28A6F193DA8
       call      qword ptr [7FF9000C7180]; System.Guid.ToString(System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FF9004F57A0]
       mov       ecx,1F17
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004F5590]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001A6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 238
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.KeyGeneratorBenchmark.GenerateKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF9007C6448]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
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
; 	public static string GenerateKey() => Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture);
; 	                                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9000C7360]; System.Guid.NewGuid()
       mov       r8,27BBF800428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,2BC4D563DA8
       call      qword ptr [7FF9000C7180]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```

