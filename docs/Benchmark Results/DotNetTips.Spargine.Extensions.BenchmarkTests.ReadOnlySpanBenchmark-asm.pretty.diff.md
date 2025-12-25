## DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark-20251225-003933
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30AB54778B0
+       mov       rdx,298FFCC78B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE01284978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30AB54778B0
+       mov       rdx,1D9AB3178B0
        mov       r8,rbx
        call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE01274978]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30AB54778B0
+       mov       rdx,1B295B378B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE01294978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30AB54778B0
+       mov       rdx,254FA6C78B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE011E75B8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30AB54778B0
+       mov       rdx,2AB476478D8
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE011E6790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30AB54778B0
+       mov       rdx,23FD6F27968
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00C96A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,30AB54778B0
+       mov       rdx,2979E447968
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00976718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CC0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00C95E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE010DE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0077F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,298FFCC78B0
+       mov       rdx,1D9AB3178B0
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CD0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE01274978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,298FFCC78B0
+       mov       rdx,1B295B378B0
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE01294978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,298FFCC78B0
+       mov       rdx,254FA6C78B0
        mov       r8,rbx
        call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE011E75B8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,298FFCC78B0
+       mov       rdx,2AB476478D8
        mov       r8,rbx
        call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE011E6790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,298FFCC78B0
+       mov       rdx,23FD6F27968
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00C96A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,298FFCC78B0
+       mov       rdx,2979E447968
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00976718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CC0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00C95E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE010DE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE0077F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1D9AB3178B0
+       mov       rdx,1B295B378B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274978]
+       call      qword ptr [7FFE01294978]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1D9AB3178B0
+       mov       rdx,254FA6C78B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274978]
+       call      qword ptr [7FFE011E75B8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1D9AB3178B0
+       mov       rdx,2AB476478D8
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274978]
+       call      qword ptr [7FFE011E6790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1D9AB3178B0
+       mov       rdx,23FD6F27968
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274978]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00C96A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1D9AB3178B0
+       mov       rdx,2979E447968
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00976718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CC0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00C95E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274978]
+       call      qword ptr [7FFE010DE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0077F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1B295B378B0
+       mov       rdx,254FA6C78B0
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01294978]
+       call      qword ptr [7FFE011E75B8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1B295B378B0
+       mov       rdx,2AB476478D8
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01294978]
+       call      qword ptr [7FFE011E6790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1B295B378B0
+       mov       rdx,23FD6F27968
        mov       r8,rbx
        call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01294978]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00C96A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1B295B378B0
+       mov       rdx,2979E447968
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00976718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CC0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00C95E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01294978]
+       call      qword ptr [7FFE010DE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0077F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,254FA6C78B0
+       mov       rdx,2AB476478D8
        mov       r8,rbx
        call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011E75B8]
+       call      qword ptr [7FFE011E6790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,254FA6C78B0
+       mov       rdx,23FD6F27968
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011E75B8]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00C96A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,254FA6C78B0
+       mov       rdx,2979E447968
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00976718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CC0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00C95E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011E75B8]
+       call      qword ptr [7FFE010DE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE0077F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2AB476478D8
+       mov       rdx,23FD6F27968
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011E6790]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00C96A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2AB476478D8
+       mov       rdx,2979E447968
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00976718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CC0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00C95E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011E6790]
+       call      qword ptr [7FFE010DE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE0077F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRecord method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00C96A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,23FD6F27968
+       mov       rdx,2979E447968
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00976718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CC0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00C95E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE0110E4D8]
+       call      qword ptr [7FFE010DE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0077F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,190E2F178B0
+       mov       rdx,2D8ABAC78B0
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CD0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE01274648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,190E2F178B0
+       mov       rdx,1D4757378B0
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CD0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE01274648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,190E2F178B0
+       mov       rdx,26C444678B0
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE01294648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00C96A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,190E2F178B0
+       mov       rdx,191D60C78B0
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00976718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CC0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00C95E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE011C66E8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE0077F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,190E2F178B0
+       mov       rdx,191BDC078D8
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CD0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE011D6790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,190E2F178B0
+       mov       rdx,24BC44D7968
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CD0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE010EE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,190E2F178B0
+       mov       rdx,2698C7879C8
        mov       r8,rbx
        call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01284978]
+       call      qword ptr [7FFE010FDD70]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D8ABAC78B0
+       mov       rdx,1D4757378B0
        mov       r8,rbx
        call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D8ABAC78B0
+       mov       rdx,26C444678B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE01294648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00C96A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D8ABAC78B0
+       mov       rdx,191D60C78B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00976718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CC0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00C95E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE011C66E8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0077F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D8ABAC78B0
+       mov       rdx,191BDC078D8
        mov       r8,rbx
        call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE011D6790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D8ABAC78B0
+       mov       rdx,24BC44D7968
        mov       r8,rbx
        call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE010EE4D8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D8ABAC78B0
+       mov       rdx,2698C7879C8
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE010FDD70]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1D4757378B0
+       mov       rdx,26C444678B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE01294648]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00C96A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1D4757378B0
+       mov       rdx,191D60C78B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00976718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CC0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00C95E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE011C66E8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0077F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1D4757378B0
+       mov       rdx,191BDC078D8
        mov       r8,rbx
        call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE011D6790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1D4757378B0
+       mov       rdx,24BC44D7968
        mov       r8,rbx
        call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE010EE4D8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1D4757378B0
+       mov       rdx,2698C7879C8
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01274648]
+       call      qword ptr [7FFE010FDD70]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00C96A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,26C444678B0
+       mov       rdx,191D60C78B0
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00976718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CC0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00C95E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01294648]
+       call      qword ptr [7FFE011C66E8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0077F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,26C444678B0
+       mov       rdx,191BDC078D8
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CD0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01294648]
+       call      qword ptr [7FFE011D6790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,26C444678B0
+       mov       rdx,24BC44D7968
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CD0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01294648]
+       call      qword ptr [7FFE010EE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,26C444678B0
+       mov       rdx,2698C7879C8
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE01294648]
+       call      qword ptr [7FFE010FDD70]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00C96A18]
+       call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,191D60C78B0
+       mov       rdx,191BDC078D8
        mov       r8,rbx
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rax,7FFE00CC0C20
+       mov       rax,7FFE00CD0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00C95E48]
+       call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011C66E8]
+       call      qword ptr [7FFE011D6790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0077F708]
+       call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00C96A18]
+       call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,191D60C78B0
+       mov       rdx,24BC44D7968
        mov       r8,rbx
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rax,7FFE00CC0C20
+       mov       rax,7FFE00CD0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00C95E48]
+       call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011C66E8]
+       call      qword ptr [7FFE010EE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0077F708]
+       call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00C95110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00C96A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,191D60C78B0
+       mov       rdx,2698C7879C8
        mov       r8,rbx
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CC0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00C95E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011C66E8]
+       call      qword ptr [7FFE010FDD70]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0077F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,191BDC078D8
+       mov       rdx,24BC44D7968
        mov       r8,rbx
        call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011D6790]
+       call      qword ptr [7FFE010EE4D8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,191BDC078D8
+       mov       rdx,2698C7879C8
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011D6790]
+       call      qword ptr [7FFE010FDD70]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomRef method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,24BC44D7968
+       mov       rdx,2698C7879C8
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE010EE4D8]
+       call      qword ptr [7FFE010FDD70]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0124D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0126D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,27DE5B878B0
+       mov       rdx,1BAD99078B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012748B8]
+       call      qword ptr [7FFE012948B8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0124D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0126D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,27DE5B878B0
+       mov       rdx,2D1FAC078B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012748B8]
+       call      qword ptr [7FFE012948B8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,27DE5B878B0
+       mov       rdx,217B69478B0
        mov       r8,rbx
        call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C85110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0124D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0125E3D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00C86A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00C867C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,27DE5B878B0
+       mov       rdx,1C6C94F78B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00966718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CB0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00C85E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012748B8]
+       call      qword ptr [7FFE011B74E0]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0076F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0124D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0142D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,27DE5B878B0
+       mov       rdx,2AFDB6B78D8
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012748B8]
+       call      qword ptr [7FFE011F6790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0124D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE014657D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,27DE5B878B0
+       mov       rdx,1D61D037968
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012748B8]
+       call      qword ptr [7FFE010FE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0124D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE01544540]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,27DE5B878B0
+       mov       rdx,17A31437990
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012748B8]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1BAD99078B0
+       mov       rdx,2D1FAC078B0
        mov       r8,rbx
        call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0126D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0124D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1BAD99078B0
+       mov       rdx,217B69478B0
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CD0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012948B8]
+       call      qword ptr [7FFE012748B8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C85110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0126D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0125E3D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00C86A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00C867C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1BAD99078B0
+       mov       rdx,1C6C94F78B0
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00966718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CB0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00C85E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012948B8]
+       call      qword ptr [7FFE011B74E0]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0076F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
        call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0126D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0142D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1BAD99078B0
+       mov       rdx,2AFDB6B78D8
        mov       r8,rbx
        call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012948B8]
+       call      qword ptr [7FFE011F6790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0126D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE014657D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1BAD99078B0
+       mov       rdx,1D61D037968
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012948B8]
+       call      qword ptr [7FFE010FE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
        call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0126D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE01544540]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1BAD99078B0
+       mov       rdx,17A31437990
        mov       r8,rbx
        call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012948B8]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0126D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0124D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00CA6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D1FAC078B0
+       mov       rdx,217B69478B0
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CD0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00CA5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012948B8]
+       call      qword ptr [7FFE012748B8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0078F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C85110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0126D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0125E3D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00C86A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00C867C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D1FAC078B0
+       mov       rdx,1C6C94F78B0
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00966718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CB0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00C85E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012948B8]
+       call      qword ptr [7FFE011B74E0]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0076F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
        call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0126D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0142D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D1FAC078B0
+       mov       rdx,2AFDB6B78D8
        mov       r8,rbx
        call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012948B8]
+       call      qword ptr [7FFE011F6790]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0126D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE014657D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D1FAC078B0
+       mov       rdx,1D61D037968
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012948B8]
+       call      qword ptr [7FFE010FE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
        call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0126D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE01544540]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D1FAC078B0
+       mov       rdx,17A31437990
        mov       r8,rbx
        call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012948B8]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00C85110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0124D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0125E3D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00C86A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00C867C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,217B69478B0
+       mov       rdx,1C6C94F78B0
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00966718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CB0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00C85E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012748B8]
+       call      qword ptr [7FFE011B74E0]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0076F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0124D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0142D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,217B69478B0
+       mov       rdx,2AFDB6B78D8
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012748B8]
+       call      qword ptr [7FFE011F6790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0124D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE014657D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,217B69478B0
+       mov       rdx,1D61D037968
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012748B8]
+       call      qword ptr [7FFE010FE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CA5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0124D7B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE01544540]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CA6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,217B69478B0
+       mov       rdx,17A31437990
        mov       r8,rbx
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CD0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CA5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE012748B8]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0078F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00C85110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0125E3D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE0142D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00C86A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00C867C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1C6C94F78B0
+       mov       rdx,2AFDB6B78D8
        mov       r8,rbx
-       call      qword ptr [7FFE00966718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CB0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00C85E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011B74E0]
+       call      qword ptr [7FFE011F6790]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0076F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00C85110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0125E3D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE014657D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00C86A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00C867C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1C6C94F78B0
+       mov       rdx,1D61D037968
        mov       r8,rbx
-       call      qword ptr [7FFE00966718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CB0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00C85E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011B74E0]
+       call      qword ptr [7FFE010FE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0076F708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00C85110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0125E3D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE01544540]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00C86A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00C867C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1C6C94F78B0
+       mov       rdx,17A31437990
        mov       r8,rbx
-       call      qword ptr [7FFE00966718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CB0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00C85E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011B74E0]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0076F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0142D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE014657D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CC6A18]
+       call      qword ptr [7FFE00CB6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2AFDB6B78D8
+       mov       rdx,1D61D037968
        mov       r8,rbx
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rax,7FFE00CF0C20
+       mov       rax,7FFE00CE0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CC5E48]
+       call      qword ptr [7FFE00CB5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011F6790]
+       call      qword ptr [7FFE010FE4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007AF708]
+       call      qword ptr [7FFE0079F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
        call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE0142D7D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE01544540]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
        nop
        add       rsp,70
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2AFDB6B78D8
+       mov       rdx,17A31437990
        mov       r8,rbx
        call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE011F6790]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for PickRandomVal method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE00CB5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
-       call      qword ptr [7FFE014657D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
+       call      qword ptr [7FFE01544540]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
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
-       call      qword ptr [7FFE00CB6A18]
+       call      qword ptr [7FFE00CC6A18]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,1D61D037968
+       mov       rdx,17A31437990
        mov       r8,rbx
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE009A6718]
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
-       mov       rax,7FFE00CE0C20
+       mov       rax,7FFE00CF0C20
        mov       [rbp-80],rax
        lea       rax,[M01_L01]
        mov       [rbp-68],rax
        lea       rax,[rbp-90]
        mov       [rdi+10],rax
        mov       byte ptr [rdi+0C],0
        mov       rax,7FFE96623670
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
-       call      qword ptr [7FFE00CB5E48]
+       call      qword ptr [7FFE00CC5E48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE010FE4D8]
+       call      qword ptr [7FFE0110E4D8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE0079F708]
+       call      qword ptr [7FFE007AF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
