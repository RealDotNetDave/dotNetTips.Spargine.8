## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6674750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE667F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE667F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2191F9C7658
       mov       r8,rbx
       call      qword ptr [7FFBE6356718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE693E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D5EFB8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE615F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6654750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE665F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE665F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24B33BC7678
       mov       r8,rbx
       call      qword ptr [7FFBE6336718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE691E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D3F8E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE613F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6644750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE664F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE664F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1E4AEF07678
       mov       r8,rbx
       call      qword ptr [7FFBE6326718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE690E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D2F8E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE612F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6674750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE667F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE667F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,27407817678
       mov       r8,rbx
       call      qword ptr [7FFBE6356718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE693E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D5F918]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE615F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6654750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE665F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE665F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C5CA3C7678
       mov       r8,rbx
       call      qword ptr [7FFBE6336718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE691E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D3F8E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE613F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6674750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE667F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE667F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,249153E7678
       mov       r8,rbx
       call      qword ptr [7FFBE6356718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE693E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D5F7C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE615F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6674750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE667F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE667F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,157CB987678
       mov       r8,rbx
       call      qword ptr [7FFBE6356718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE694E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D6EFB8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE615F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6674750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE667F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE667F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29166B776A0
       mov       r8,rbx
       call      qword ptr [7FFBE6356718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE693E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6CFC228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE615F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRef()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+298]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6654750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE665F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE665F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2285CE87658
       mov       r8,rbx
       call      qword ptr [7FFBE6336718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE691E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D3F000]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE613F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRef()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+298]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6664750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE666F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE666F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2B285ED7678
       mov       r8,rbx
       call      qword ptr [7FFBE6346718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE692E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D4F918]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE614F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRef()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+298]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6664750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE666F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE666F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,18A76637678
       mov       r8,rbx
       call      qword ptr [7FFBE6346718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE692E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D4F8E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE614F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRef()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+298]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6664750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE666F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE666F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21CA3027678
       mov       r8,rbx
       call      qword ptr [7FFBE6346718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE692E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D4F8E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE614F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRef()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+298]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6664750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE666F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE666F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C393BB7678
       mov       r8,rbx
       call      qword ptr [7FFBE6346718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE692E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D4F8E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE614F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRef()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+298]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6674750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE667F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE667F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,300068B7678
       mov       r8,rbx
       call      qword ptr [7FFBE6356718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE693E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D5F7C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE615F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRef()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+298]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6684750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE668F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE668F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C01D6D7678
       mov       r8,rbx
       call      qword ptr [7FFBE6366718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE694E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D6EFB8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE616F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomRef()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+298]
       test      rdx,rdx
       je        short M00_L02
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       xor       edx,edx
       test      edi,edi
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6674750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L05
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE667F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE667F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24EFC0B76A0
       mov       r8,rbx
       call      qword ptr [7FFBE6356718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE693E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6CEC528]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE615F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomVal()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rdx,[rbx+290]
       test      rdx,rdx
       je        short M00_L02
       lea       rbp,[rdx+10]
       mov       r14d,[rdx+8]
M00_L00:
       xor       edx,edx
       test      r14d,r14d
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,r14d
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6664750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,r14d
       jae       near ptr M00_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*8]
       lea       rsi,[rbp+rcx*8]
       lea       rdi,[rsp+28]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBE6C04A68]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       nop
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE666F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE666F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C83EA37658
       mov       r8,rbx
       call      qword ptr [7FFBE6346718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 248
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE692E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D3F000]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE614F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomVal()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rdx,[rbx+290]
       test      rdx,rdx
       je        short M00_L02
       lea       rbp,[rdx+10]
       mov       r14d,[rdx+8]
M00_L00:
       xor       edx,edx
       test      r14d,r14d
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,r14d
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6684750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,r14d
       jae       near ptr M00_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*8]
       lea       rsi,[rbp+rcx*8]
       lea       rdi,[rsp+28]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBE6C257D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       nop
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE668F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE668F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1CA6A427678
       mov       r8,rbx
       call      qword ptr [7FFBE6366718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 248
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE694E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D6F918]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE616F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomVal()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rdx,[rbx+290]
       test      rdx,rdx
       je        short M00_L02
       lea       rbp,[rdx+10]
       mov       r14d,[rdx+8]
M00_L00:
       xor       edx,edx
       test      r14d,r14d
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,r14d
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6654750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,r14d
       jae       near ptr M00_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*8]
       lea       rsi,[rbp+rcx*8]
       lea       rdi,[rsp+28]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBE6BF5ED8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       nop
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE665F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE665F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1D055DF7678
       mov       r8,rbx
       call      qword ptr [7FFBE6336718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 248
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE691E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D3F570]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE613F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomVal()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rdx,[rbx+290]
       test      rdx,rdx
       je        short M00_L02
       lea       rbp,[rdx+10]
       mov       r14d,[rdx+8]
M00_L00:
       xor       edx,edx
       test      r14d,r14d
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,r14d
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6664750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,r14d
       jae       near ptr M00_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*8]
       lea       rsi,[rbp+rcx*8]
       lea       rdi,[rsp+28]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBE6C05ED8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       nop
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE666F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE666F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1D2C3DD7678
       mov       r8,rbx
       call      qword ptr [7FFBE6346718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 248
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE692E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D4F8E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE614F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomVal()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rdx,[rbx+290]
       test      rdx,rdx
       je        short M00_L02
       lea       rbp,[rdx+10]
       mov       r14d,[rdx+8]
M00_L00:
       xor       edx,edx
       test      r14d,r14d
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,r14d
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6654750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,r14d
       jae       near ptr M00_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*8]
       lea       rsi,[rbp+rcx*8]
       lea       rdi,[rsp+28]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBE6BF5ED8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       nop
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE665F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE665F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,27A5D257678
       mov       r8,rbx
       call      qword ptr [7FFBE6336718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 248
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE691E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D3F8E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE613F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomVal()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rdx,[rbx+290]
       test      rdx,rdx
       je        short M00_L02
       lea       rbp,[rdx+10]
       mov       r14d,[rdx+8]
M00_L00:
       xor       edx,edx
       test      r14d,r14d
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,r14d
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6644750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,r14d
       jae       near ptr M00_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*8]
       lea       rsi,[rbp+rcx*8]
       lea       rdi,[rsp+28]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBE6BE5ED8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       nop
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE664F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE664F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,203A0857678
       mov       r8,rbx
       call      qword ptr [7FFBE6326718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 248
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE691E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D2F420]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE612F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomVal()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rdx,[rbx+290]
       test      rdx,rdx
       je        short M00_L02
       lea       rbp,[rdx+10]
       mov       r14d,[rdx+8]
M00_L00:
       xor       edx,edx
       test      r14d,r14d
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,r14d
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6674750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,r14d
       jae       near ptr M00_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*8]
       lea       rsi,[rbp+rcx*8]
       lea       rdi,[rsp+28]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBE6D557D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       nop
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE667F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE667F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C6A7FC76A0
       mov       r8,rbx
       call      qword ptr [7FFBE6356718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 248
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE693E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6D5E5F8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE615F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.PickRandomVal()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rdx,[rbx+290]
       test      rdx,rdx
       je        short M00_L02
       lea       rbp,[rdx+10]
       mov       r14d,[rdx+8]
M00_L00:
       xor       edx,edx
       test      r14d,r14d
       setne     dl
       test      edx,edx
       je        short M00_L03
       mov       edx,r14d
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFBE6654750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,r14d
       jae       near ptr M00_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*8]
       lea       rsi,[rbp+rcx*8]
       lea       rdi,[rsp+28]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBE6DB57D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       nop
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFBE665F5D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBE665F378]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2121ADE76A0
       mov       r8,rbx
       call      qword ptr [7FFBE6336718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 248
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCA4653670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFC45FFA0DC],0
       je        short M01_L02
       call      qword ptr [7FFC45FEA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       call      qword ptr [7FFBE691E880]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBE6CCC228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE613F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       ret
; Total bytes of code 1
```

