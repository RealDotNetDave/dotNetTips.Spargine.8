## DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark-20250831-053952
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,205444878B8
+       mov       rdx,2A3238778D8
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADF390]
+       call      qword ptr [7FF900B14648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,205444878B8
+       mov       rdx,244899078D8
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADF390]
+       call      qword ptr [7FF900B14978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,205444878B8
+       mov       rdx,266DEAC78D8
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADF390]
+       call      qword ptr [7FF900B14648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,205444878B8
+       mov       rdx,31FA01F78D8
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADF390]
+       call      qword ptr [7FF900AF4648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,205444878B8
+       mov       rdx,1CDCEE178D8
        mov       r8,rbx
        call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADF390]
+       call      qword ptr [7FF900B04978]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,205444878B8
+       mov       rdx,163A27278D8
        mov       r8,rbx
        call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADF390]
+       call      qword ptr [7FF900A674E0]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,205444878B8
+       mov       rdx,2130A517900
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADF390]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2A3238778D8
+       mov       rdx,244899078D8
        mov       r8,rbx
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14648]
+       call      qword ptr [7FF900B14978]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2A3238778D8
+       mov       rdx,266DEAC78D8
        mov       r8,rbx
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900546A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005467C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2A3238778D8
+       mov       rdx,31FA01F78D8
        mov       r8,rbx
-       call      qword ptr [7FF900226718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900570C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900545E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14648]
+       call      qword ptr [7FF900AF4648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90002F708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900546A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005467C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2A3238778D8
+       mov       rdx,1CDCEE178D8
        mov       r8,rbx
-       call      qword ptr [7FF900226718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900570C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900545E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14648]
+       call      qword ptr [7FF900B04978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90002F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900546A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005467C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2A3238778D8
+       mov       rdx,163A27278D8
        mov       r8,rbx
-       call      qword ptr [7FF900226718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900570C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900545E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14648]
+       call      qword ptr [7FF900A674E0]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90002F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2A3238778D8
+       mov       rdx,2130A517900
        mov       r8,rbx
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14648]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,244899078D8
+       mov       rdx,266DEAC78D8
        mov       r8,rbx
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14978]
+       call      qword ptr [7FF900B14648]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900546A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005467C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,244899078D8
+       mov       rdx,31FA01F78D8
        mov       r8,rbx
-       call      qword ptr [7FF900226718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900570C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900545E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14978]
+       call      qword ptr [7FF900AF4648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90002F708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900546A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005467C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,244899078D8
+       mov       rdx,1CDCEE178D8
        mov       r8,rbx
-       call      qword ptr [7FF900226718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900570C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900545E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14978]
+       call      qword ptr [7FF900B04978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90002F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900546A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005467C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,244899078D8
+       mov       rdx,163A27278D8
        mov       r8,rbx
-       call      qword ptr [7FF900226718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900570C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900545E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14978]
+       call      qword ptr [7FF900A674E0]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90002F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,244899078D8
+       mov       rdx,2130A517900
        mov       r8,rbx
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14978]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900546A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005467C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,266DEAC78D8
+       mov       rdx,31FA01F78D8
        mov       r8,rbx
-       call      qword ptr [7FF900226718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900570C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900545E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14648]
+       call      qword ptr [7FF900AF4648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90002F708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900546A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005467C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,266DEAC78D8
+       mov       rdx,1CDCEE178D8
        mov       r8,rbx
-       call      qword ptr [7FF900226718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900570C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900545E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14648]
+       call      qword ptr [7FF900B04978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90002F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900546A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005467C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,266DEAC78D8
+       mov       rdx,163A27278D8
        mov       r8,rbx
-       call      qword ptr [7FF900226718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900570C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900545E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14648]
+       call      qword ptr [7FF900A674E0]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90002F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,266DEAC78D8
+       mov       rdx,2130A517900
        mov       r8,rbx
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14648]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,31FA01F78D8
+       mov       rdx,1CDCEE178D8
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4648]
+       call      qword ptr [7FF900B04978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,31FA01F78D8
+       mov       rdx,163A27278D8
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4648]
+       call      qword ptr [7FF900A674E0]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,31FA01F78D8
+       mov       rdx,2130A517900
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4648]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1CDCEE178D8
+       mov       rdx,163A27278D8
        mov       r8,rbx
        call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B04978]
+       call      qword ptr [7FF900A674E0]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1CDCEE178D8
+       mov       rdx,2130A517900
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B04978]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,163A27278D8
+       mov       rdx,2130A517900
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900A674E0]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EADE8578B8
+       mov       rdx,29459B278D8
        mov       r8,rbx
        call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ACED60]
+       call      qword ptr [7FF900AF4978]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EADE8578B8
+       mov       rdx,23B5D0C78D8
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ACED60]
+       call      qword ptr [7FF900B14978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EADE8578B8
+       mov       rdx,227006E78D8
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ACED60]
+       call      qword ptr [7FF900B04648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900516A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005167C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EADE8578B8
+       mov       rdx,1EAD7DE78D8
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900540C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900515E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ACED60]
+       call      qword ptr [7FF900AE4978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF8FFFFF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EADE8578B8
+       mov       rdx,2291AC578D8
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ACED60]
+       call      qword ptr [7FF900B14648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EADE8578B8
+       mov       rdx,2F31EDC7900
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ACED60]
+       call      qword ptr [7FF900A766E8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EADE8578B8
+       mov       rdx,218D3EA7900
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ACED60]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,29459B278D8
+       mov       rdx,23B5D0C78D8
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4978]
+       call      qword ptr [7FF900B14978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,29459B278D8
+       mov       rdx,227006E78D8
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4978]
+       call      qword ptr [7FF900B04648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900516A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005167C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,29459B278D8
+       mov       rdx,1EAD7DE78D8
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900540C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900515E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4978]
+       call      qword ptr [7FF900AE4978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF8FFFFF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,29459B278D8
+       mov       rdx,2291AC578D8
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4978]
+       call      qword ptr [7FF900B14648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,29459B278D8
+       mov       rdx,2F31EDC7900
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4978]
+       call      qword ptr [7FF900A766E8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,29459B278D8
+       mov       rdx,218D3EA7900
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4978]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900546A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005467C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,23B5D0C78D8
+       mov       rdx,227006E78D8
        mov       r8,rbx
-       call      qword ptr [7FF900226718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900570C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900545E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14978]
+       call      qword ptr [7FF900B04648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90002F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900546A18]
+       call      qword ptr [7FF900516A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005467C0]
+       call      qword ptr [7FF9005167C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,23B5D0C78D8
+       mov       rdx,1EAD7DE78D8
        mov       r8,rbx
-       call      qword ptr [7FF900226718]
+       call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900570C20
+       mov       rax,7FF900540C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900545E48]
+       call      qword ptr [7FF900515E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14978]
+       call      qword ptr [7FF900AE4978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90002F708]
+       call      qword ptr [7FF8FFFFF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,23B5D0C78D8
+       mov       rdx,2291AC578D8
        mov       r8,rbx
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14978]
+       call      qword ptr [7FF900B14648]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,23B5D0C78D8
+       mov       rdx,2F31EDC7900
        mov       r8,rbx
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14978]
+       call      qword ptr [7FF900A766E8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,23B5D0C78D8
+       mov       rdx,218D3EA7900
        mov       r8,rbx
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14978]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900516A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005167C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,227006E78D8
+       mov       rdx,1EAD7DE78D8
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900540C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900515E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B04648]
+       call      qword ptr [7FF900AE4978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF8FFFFF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,227006E78D8
+       mov       rdx,2291AC578D8
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B04648]
+       call      qword ptr [7FF900B14648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,227006E78D8
+       mov       rdx,2F31EDC7900
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B04648]
+       call      qword ptr [7FF900A766E8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,227006E78D8
+       mov       rdx,218D3EA7900
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B04648]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900516A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005167C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EAD7DE78D8
+       mov       rdx,2291AC578D8
        mov       r8,rbx
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900540C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900515E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AE4978]
+       call      qword ptr [7FF900B14648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFFF708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900516A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005167C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EAD7DE78D8
+       mov       rdx,2F31EDC7900
        mov       r8,rbx
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900540C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900515E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AE4978]
+       call      qword ptr [7FF900A766E8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFFF708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900545110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900516A18]
+       call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005167C0]
+       call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EAD7DE78D8
+       mov       rdx,218D3EA7900
        mov       r8,rbx
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 202
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
-       mov       rax,7FF900540C20
+       mov       rax,7FF900570C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900515E48]
+       call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AE4978]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFFF708]
+       call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2291AC578D8
+       mov       rdx,2F31EDC7900
        mov       r8,rbx
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14648]
+       call      qword ptr [7FF900A766E8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2291AC578D8
+       mov       rdx,218D3EA7900
        mov       r8,rbx
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B14648]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRef method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900546A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005467C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2F31EDC7900
+       mov       rdx,218D3EA7900
        mov       r8,rbx
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900545E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900A766E8]
+       call      qword ptr [7FF900A76790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90002F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
        call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900AD72E8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ADD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30372A878B8
+       mov       rdx,1E53B1178D8
        mov       r8,rbx
        call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADE0B8]
+       call      qword ptr [7FF900B048B8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900AD72E8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ABD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900516A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005167C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30372A878B8
+       mov       rdx,214EC5878D8
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900540C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900515E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADE0B8]
+       call      qword ptr [7FF900AE4588]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF8FFFFF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900AD72E8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ABD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900516A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005167C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30372A878B8
+       mov       rdx,1E468E078B0
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900540C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900515E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADE0B8]
+       call      qword ptr [7FF900AE48B8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF8FFFFF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900AD72E8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ACD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30372A878B8
+       mov       rdx,1EFD39F78B0
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADE0B8]
+       call      qword ptr [7FF900AF4588]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900AD72E8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ACD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30372A878B8
+       mov       rdx,22E507B78B0
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADE0B8]
+       call      qword ptr [7FF900AF4588]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900AD72E8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C0E9A0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30372A878B8
+       mov       rdx,22806997900
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADE0B8]
+       call      qword ptr [7FF900A566E8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
        call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900AD72E8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C9D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30372A878B8
+       mov       rdx,24E34D37900
        mov       r8,rbx
        call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900ADE0B8]
+       call      qword ptr [7FF900A66790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ADD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ABD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900516A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005167C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1E53B1178D8
+       mov       rdx,214EC5878D8
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900540C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900515E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B048B8]
+       call      qword ptr [7FF900AE4588]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF8FFFFF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ADD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ABD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900516A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005167C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1E53B1178D8
+       mov       rdx,1E468E078B0
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900540C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900515E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B048B8]
+       call      qword ptr [7FF900AE48B8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF8FFFFF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ADD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ACD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1E53B1178D8
+       mov       rdx,1EFD39F78B0
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B048B8]
+       call      qword ptr [7FF900AF4588]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ADD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ACD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1E53B1178D8
+       mov       rdx,22E507B78B0
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B048B8]
+       call      qword ptr [7FF900AF4588]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ADD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C0E9A0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900536A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005367C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1E53B1178D8
+       mov       rdx,22806997900
        mov       r8,rbx
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900560C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900535E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B048B8]
+       call      qword ptr [7FF900A566E8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90001F708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
        call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ADD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C9D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1E53B1178D8
+       mov       rdx,24E34D37900
        mov       r8,rbx
        call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900B048B8]
+       call      qword ptr [7FF900A66790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
        call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ABD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ABD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      qword ptr [7FF900516A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005167C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,214EC5878D8
+       mov       rdx,1E468E078B0
        mov       r8,rbx
        call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900515E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AE4588]
+       call      qword ptr [7FF900AE48B8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF8FFFFF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ABD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ACD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900516A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005167C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,214EC5878D8
+       mov       rdx,1EFD39F78B0
        mov       r8,rbx
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900540C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900515E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AE4588]
+       call      qword ptr [7FF900AF4588]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFFF708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ABD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ACD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900516A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005167C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,214EC5878D8
+       mov       rdx,22E507B78B0
        mov       r8,rbx
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900540C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900515E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AE4588]
+       call      qword ptr [7FF900AF4588]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFFF708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ABD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C0E9A0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900516A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005167C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,214EC5878D8
+       mov       rdx,22806997900
        mov       r8,rbx
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900540C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900515E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AE4588]
+       call      qword ptr [7FF900A566E8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFFF708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ABD7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C9D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900516A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005167C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,214EC5878D8
+       mov       rdx,24E34D37900
        mov       r8,rbx
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900540C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900515E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AE4588]
+       call      qword ptr [7FF900A66790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFFF708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ABD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ACD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900516A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005167C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1E468E078B0
+       mov       rdx,1EFD39F78B0
        mov       r8,rbx
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900540C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900515E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AE48B8]
+       call      qword ptr [7FF900AF4588]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFFF708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ABD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900ACD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900516A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005167C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1E468E078B0
+       mov       rdx,22E507B78B0
        mov       r8,rbx
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900540C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900515E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AE48B8]
+       call      qword ptr [7FF900AF4588]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFFF708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ABD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C0E9A0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900516A18]
+       call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005167C0]
+       call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1E468E078B0
+       mov       rdx,22806997900
        mov       r8,rbx
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900540C20
+       mov       rax,7FF900550C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900515E48]
+       call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AE48B8]
+       call      qword ptr [7FF900A566E8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFFF708]
+       call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900515110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ABD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C9D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900516A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005167C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1E468E078B0
+       mov       rdx,24E34D37900
        mov       r8,rbx
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900540C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900515E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AE48B8]
+       call      qword ptr [7FF900A66790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFFF708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EFD39F78B0
+       mov       rdx,22E507B78B0
        mov       r8,rbx
        call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
        call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ACD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C0E9A0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EFD39F78B0
+       mov       rdx,22806997900
        mov       r8,rbx
        call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4588]
+       call      qword ptr [7FF900A566E8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ACD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C9D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1EFD39F78B0
+       mov       rdx,24E34D37900
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4588]
+       call      qword ptr [7FF900A66790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
        call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ACD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C0E9A0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      qword ptr [7FF900526A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FF9005267C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,22E507B78B0
+       mov       rdx,22806997900
        mov       r8,rbx
        call      qword ptr [7FF900206718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF900525E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4588]
+       call      qword ptr [7FF900A566E8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF90000F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900ACD608]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C9D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,22E507B78B0
+       mov       rdx,24E34D37900
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900AF4588]
+       call      qword ptr [7FF900A66790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF900525110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FF900535110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FF900C0E9A0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FF900C9D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        xor       ebp,ebp
        xor       r14d,r14d
        jmp       short M00_L00
 M00_L03:
-       call      qword ptr [7FF900526A18]
+       call      qword ptr [7FF900536A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FF9005267C0]
+       call      qword ptr [7FF9005367C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,22806997900
+       mov       rdx,24E34D37900
        mov       r8,rbx
-       call      qword ptr [7FF900206718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 248
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
-       mov       rax,7FF900550C20
+       mov       rax,7FF900560C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FF9A06E3670
        call      rax
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
-       call      qword ptr [7FF900525E48]
+       call      qword ptr [7FF900535E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FF900A566E8]
+       call      qword ptr [7FF900A66790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF90000F708]
+       call      qword ptr [7FF90001F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
