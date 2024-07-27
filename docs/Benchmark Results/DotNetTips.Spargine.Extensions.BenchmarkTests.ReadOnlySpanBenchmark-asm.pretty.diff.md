## DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark-20240727-051519
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C295368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C29DE60]
+       call      qword ptr [7FFE8C28DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C29DC20]
+       call      qword ptr [7FFE8C28DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,26784B0D910
+       mov       rdx,2D7DCB3D910
        mov       r8,rbx
        call      qword ptr [7FFE8BF26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE8C45EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C6130]
+       call      qword ptr [7FFE8C7C55A8]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE8BCAF708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C295368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C29DE60]
+       call      qword ptr [7FFE8C26DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C29DC20]
+       call      qword ptr [7FFE8C26DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,26784B0D910
+       mov       rdx,282D49AD910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF26670]
+       call      qword ptr [7FFE8BEF6670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C45EEB0]
+       call      qword ptr [7FFE8C42EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C6130]
+       call      qword ptr [7FFE8C796520]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BCAF708]
+       call      qword ptr [7FFE8BC7F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C295368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C29DE60]
+       call      qword ptr [7FFE8C26DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C29DC20]
+       call      qword ptr [7FFE8C26DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,26784B0D910
+       mov       rdx,2B2D5F9D910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF26670]
+       call      qword ptr [7FFE8BEF6670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C45EEB0]
+       call      qword ptr [7FFE8C42EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C6130]
+       call      qword ptr [7FFE8C796520]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BCAF708]
+       call      qword ptr [7FFE8BC7F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C295368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C29DE60]
+       call      qword ptr [7FFE8C28DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C29DC20]
+       call      qword ptr [7FFE8C28DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,26784B0D910
+       mov       rdx,2F2193FD910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF26670]
+       call      qword ptr [7FFE8BF16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C45EEB0]
+       call      qword ptr [7FFE8C44EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C6130]
+       call      qword ptr [7FFE8C726CB8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BCAF708]
+       call      qword ptr [7FFE8BC9F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C295368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C29DE60]
+       call      qword ptr [7FFE8C26DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C29DC20]
+       call      qword ptr [7FFE8C26DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,26784B0D910
+       mov       rdx,2001349D910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF26670]
+       call      qword ptr [7FFE8BEF6670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C45EEB0]
+       call      qword ptr [7FFE8C446310]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C6130]
+       call      qword ptr [7FFE8C4F7360]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BCAF708]
+       call      qword ptr [7FFE8BC7F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C295368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C29DE60]
+       call      qword ptr [7FFE8C28DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C29DC20]
+       call      qword ptr [7FFE8C28DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,26784B0D910
+       mov       rdx,2210F9CD8E8
        mov       r8,rbx
-       call      qword ptr [7FFE8BF26670]
+       call      qword ptr [7FFE8BF16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C45EEB0]
+       call      qword ptr [7FFE8C44EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C6130]
+       call      qword ptr [7FFE8C505F80]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BCAF708]
+       call      qword ptr [7FFE8BC9F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C295368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C275368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C29DE60]
+       call      qword ptr [7FFE8C27DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C29DC20]
+       call      qword ptr [7FFE8C27DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,26784B0D910
+       mov       rdx,251D1C2D910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF26670]
+       call      qword ptr [7FFE8BF06670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C45EEB0]
+       call      qword ptr [7FFE8C43EF40]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C6130]
+       call      qword ptr [7FFE8C4F5E90]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BCAF708]
+       call      qword ptr [7FFE8BC8F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C28DE60]
+       call      qword ptr [7FFE8C26DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C28DC20]
+       call      qword ptr [7FFE8C26DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D7DCB3D910
+       mov       rdx,282D49AD910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF26670]
+       call      qword ptr [7FFE8BEF6670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C45EEB0]
+       call      qword ptr [7FFE8C42EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C55A8]
+       call      qword ptr [7FFE8C796520]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BCAF708]
+       call      qword ptr [7FFE8BC7F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C28DE60]
+       call      qword ptr [7FFE8C26DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C28DC20]
+       call      qword ptr [7FFE8C26DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D7DCB3D910
+       mov       rdx,2B2D5F9D910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF26670]
+       call      qword ptr [7FFE8BEF6670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C45EEB0]
+       call      qword ptr [7FFE8C42EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C55A8]
+       call      qword ptr [7FFE8C796520]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BCAF708]
+       call      qword ptr [7FFE8BC7F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE8C28DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE8C28DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D7DCB3D910
+       mov       rdx,2F2193FD910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF26670]
+       call      qword ptr [7FFE8BF16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C45EEB0]
+       call      qword ptr [7FFE8C44EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C55A8]
+       call      qword ptr [7FFE8C726CB8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BCAF708]
+       call      qword ptr [7FFE8BC9F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C28DE60]
+       call      qword ptr [7FFE8C26DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C28DC20]
+       call      qword ptr [7FFE8C26DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D7DCB3D910
+       mov       rdx,2001349D910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF26670]
+       call      qword ptr [7FFE8BEF6670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C45EEB0]
+       call      qword ptr [7FFE8C446310]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C55A8]
+       call      qword ptr [7FFE8C4F7360]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BCAF708]
+       call      qword ptr [7FFE8BC7F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE8C28DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE8C28DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D7DCB3D910
+       mov       rdx,2210F9CD8E8
        mov       r8,rbx
-       call      qword ptr [7FFE8BF26670]
+       call      qword ptr [7FFE8BF16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C45EEB0]
+       call      qword ptr [7FFE8C44EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C55A8]
+       call      qword ptr [7FFE8C505F80]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BCAF708]
+       call      qword ptr [7FFE8BC9F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C275368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C28DE60]
+       call      qword ptr [7FFE8C27DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C28DC20]
+       call      qword ptr [7FFE8C27DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2D7DCB3D910
+       mov       rdx,251D1C2D910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF26670]
+       call      qword ptr [7FFE8BF06670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C45EEB0]
+       call      qword ptr [7FFE8C43EF40]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C7C55A8]
+       call      qword ptr [7FFE8C4F5E90]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BCAF708]
+       call      qword ptr [7FFE8BC8F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE8C26DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE8C26DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,282D49AD910
+       mov       rdx,2B2D5F9D910
        mov       r8,rbx
        call      qword ptr [7FFE8BEF6670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C26DE60]
+       call      qword ptr [7FFE8C28DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C26DC20]
+       call      qword ptr [7FFE8C28DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,282D49AD910
+       mov       rdx,2F2193FD910
        mov       r8,rbx
-       call      qword ptr [7FFE8BEF6670]
+       call      qword ptr [7FFE8BF16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C42EEB0]
+       call      qword ptr [7FFE8C44EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C796520]
+       call      qword ptr [7FFE8C726CB8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BC7F708]
+       call      qword ptr [7FFE8BC9F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE8C26DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE8C26DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,282D49AD910
+       mov       rdx,2001349D910
        mov       r8,rbx
        call      qword ptr [7FFE8BEF6670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C42EEB0]
+       call      qword ptr [7FFE8C446310]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C796520]
+       call      qword ptr [7FFE8C4F7360]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE8BC7F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C26DE60]
+       call      qword ptr [7FFE8C28DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C26DC20]
+       call      qword ptr [7FFE8C28DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,282D49AD910
+       mov       rdx,2210F9CD8E8
        mov       r8,rbx
-       call      qword ptr [7FFE8BEF6670]
+       call      qword ptr [7FFE8BF16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C42EEB0]
+       call      qword ptr [7FFE8C44EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C796520]
+       call      qword ptr [7FFE8C505F80]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BC7F708]
+       call      qword ptr [7FFE8BC9F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C275368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C26DE60]
+       call      qword ptr [7FFE8C27DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C26DC20]
+       call      qword ptr [7FFE8C27DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,282D49AD910
+       mov       rdx,251D1C2D910
        mov       r8,rbx
-       call      qword ptr [7FFE8BEF6670]
+       call      qword ptr [7FFE8BF06670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C42EEB0]
+       call      qword ptr [7FFE8C43EF40]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C796520]
+       call      qword ptr [7FFE8C4F5E90]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BC7F708]
+       call      qword ptr [7FFE8BC8F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C26DE60]
+       call      qword ptr [7FFE8C28DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C26DC20]
+       call      qword ptr [7FFE8C28DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2B2D5F9D910
+       mov       rdx,2F2193FD910
        mov       r8,rbx
-       call      qword ptr [7FFE8BEF6670]
+       call      qword ptr [7FFE8BF16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C42EEB0]
+       call      qword ptr [7FFE8C44EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C796520]
+       call      qword ptr [7FFE8C726CB8]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BC7F708]
+       call      qword ptr [7FFE8BC9F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE8C26DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE8C26DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2B2D5F9D910
+       mov       rdx,2001349D910
        mov       r8,rbx
        call      qword ptr [7FFE8BEF6670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C42EEB0]
+       call      qword ptr [7FFE8C446310]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C796520]
+       call      qword ptr [7FFE8C4F7360]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE8BC7F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C26DE60]
+       call      qword ptr [7FFE8C28DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C26DC20]
+       call      qword ptr [7FFE8C28DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2B2D5F9D910
+       mov       rdx,2210F9CD8E8
        mov       r8,rbx
-       call      qword ptr [7FFE8BEF6670]
+       call      qword ptr [7FFE8BF16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C42EEB0]
+       call      qword ptr [7FFE8C44EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C796520]
+       call      qword ptr [7FFE8C505F80]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BC7F708]
+       call      qword ptr [7FFE8BC9F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C275368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C26DE60]
+       call      qword ptr [7FFE8C27DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C26DC20]
+       call      qword ptr [7FFE8C27DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2B2D5F9D910
+       mov       rdx,251D1C2D910
        mov       r8,rbx
-       call      qword ptr [7FFE8BEF6670]
+       call      qword ptr [7FFE8BF06670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C42EEB0]
+       call      qword ptr [7FFE8C43EF40]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C796520]
+       call      qword ptr [7FFE8C4F5E90]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BC7F708]
+       call      qword ptr [7FFE8BC8F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C28DE60]
+       call      qword ptr [7FFE8C26DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C28DC20]
+       call      qword ptr [7FFE8C26DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2F2193FD910
+       mov       rdx,2001349D910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF16670]
+       call      qword ptr [7FFE8BEF6670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C44EEB0]
+       call      qword ptr [7FFE8C446310]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C726CB8]
+       call      qword ptr [7FFE8C4F7360]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BC9F708]
+       call      qword ptr [7FFE8BC7F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE8C28DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
        call      qword ptr [7FFE8C28DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2F2193FD910
+       mov       rdx,2210F9CD8E8
        mov       r8,rbx
        call      qword ptr [7FFE8BF16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFE8C44EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C726CB8]
+       call      qword ptr [7FFE8C505F80]
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE8BC9F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C275368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C28DE60]
+       call      qword ptr [7FFE8C27DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C28DC20]
+       call      qword ptr [7FFE8C27DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2F2193FD910
+       mov       rdx,251D1C2D910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF16670]
+       call      qword ptr [7FFE8BF06670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C44EEB0]
+       call      qword ptr [7FFE8C43EF40]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C726CB8]
+       call      qword ptr [7FFE8C4F5E90]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BC9F708]
+       call      qword ptr [7FFE8BC8F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C26DE60]
+       call      qword ptr [7FFE8C28DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C26DC20]
+       call      qword ptr [7FFE8C28DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2001349D910
+       mov       rdx,2210F9CD8E8
        mov       r8,rbx
-       call      qword ptr [7FFE8BEF6670]
+       call      qword ptr [7FFE8BF16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C446310]
+       call      qword ptr [7FFE8C44EEB0]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C4F7360]
+       call      qword ptr [7FFE8C505F80]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BC7F708]
+       call      qword ptr [7FFE8BC9F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C265368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C275368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C26DE60]
+       call      qword ptr [7FFE8C27DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C26DC20]
+       call      qword ptr [7FFE8C27DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2001349D910
+       mov       rdx,251D1C2D910
        mov       r8,rbx
-       call      qword ptr [7FFE8BEF6670]
+       call      qword ptr [7FFE8BF06670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C446310]
+       call      qword ptr [7FFE8C43EF40]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C4F7360]
+       call      qword ptr [7FFE8C4F5E90]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BC7F708]
+       call      qword ptr [7FFE8BC8F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
        test      rdx,rdx
        je        short M00_L02
        lea       rsi,[rdx+10]
        mov       edi,[rdx+8]
        test      edi,edi
        je        short M00_L03
 M00_L00:
        mov       edx,edi
        sub       edx,1
        jo        short M00_L01
        xor       ecx,ecx
-       call      qword ptr [7FFE8C285368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
+       call      qword ptr [7FFE8C275368]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
        cmp       eax,edi
        jae       near ptr M00_L05
        mov       ecx,eax
        mov       rcx,[rsi+rcx*8]
        mov       [rsp+28],rcx
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        xor       esi,esi
        xor       edi,edi
        jne       short M00_L00
 M00_L03:
-       call      qword ptr [7FFE8C28DE60]
+       call      qword ptr [7FFE8C27DE60]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M00_L04
-       call      qword ptr [7FFE8C28DC20]
+       call      qword ptr [7FFE8C27DC20]
        mov       rbx,rax
 M00_L04:
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       mov       rdx,2210F9CD8E8
+       mov       rdx,251D1C2D910
        mov       r8,rbx
-       call      qword ptr [7FFE8BF16670]
+       call      qword ptr [7FFE8BF06670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
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
-       call      qword ptr [7FFE8C44EEB0]
+       call      qword ptr [7FFE8C43EF40]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
 M01_L05:
        mov       rcx,offset MT_System.ArgumentException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      qword ptr [7FFE8C505F80]
+       call      qword ptr [7FFE8C4F5E90]
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE8BC9F708]
+       call      qword ptr [7FFE8BC8F708]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
 M01_L06:
```
