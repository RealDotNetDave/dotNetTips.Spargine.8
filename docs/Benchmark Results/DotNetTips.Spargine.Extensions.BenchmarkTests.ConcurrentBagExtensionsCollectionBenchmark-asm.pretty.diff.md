## DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark-20250318-180200
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FA520
+       mov       rdx,7FF9F6A1B6F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6814D80]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F6826130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5CA0FB0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806E0
+       mov       rdx,7FF9F68A18E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806C8
+       mov       rdx,7FF9F68A18D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5CA0FB8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5CA0FB8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FA520
+       mov       rdx,7FF9F69FAE68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6814D80]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F6806130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       rcx,rbx
        call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C80FB0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806E0
+       mov       rdx,7FF9F68819D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806C8
+       mov       rdx,7FF9F68819C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
        call      qword ptr [7FF9F63452C0]
        mov       ecx,93
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C80FB8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C80FB8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FA520
+       mov       rdx,7FF9F69FABF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6814D80]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F6806130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       rcx,rbx
        call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C80FB0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806E0
+       mov       rdx,7FF9F68818E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806C8
+       mov       rdx,7FF9F68818D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
        call      qword ptr [7FF9F63452C0]
        mov       ecx,93
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C80FB8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C80FB8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F67F60D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6865938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FA520
+       mov       rdx,7FF9F69EAE58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6814D80]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F67F6130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F67F61A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F67F6028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C70FB0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806E0
+       mov       rdx,7FF9F6871A08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806C8
+       mov       rdx,7FF9F68719F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C70FB8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C70FB8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F6807C78]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6876EE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FA520
+       mov       rdx,7FF9F6A38A10
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6814D80]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F6807CD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F6807D50]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6807BD0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       rcx,rbx
        call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C80FF0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806E0
+       mov       rdx,7FF9F6892760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806C8
+       mov       rdx,7FF9F6892748
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
        call      qword ptr [7FF9F63452C0]
        mov       ecx,93
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C80FF8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C80FF8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68F5500]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F69E41F8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FA520
+       mov       rdx,7FF9F6AA8268
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6814D80]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F68F5560]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68F55D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F68F5458]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5CA12B8
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806E0
+       mov       rdx,7FF9F69C6970
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806C8
+       mov       rdx,7FF9F69C6958
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5CA12C0
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5CA12C0
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6A66D78]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FA520
+       mov       rdx,7FF9F6B10178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6814D80]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F69FDA88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C71B80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806E0
+       mov       rdx,7FF9F6A818A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68806C8
+       mov       rdx,7FF9F6A81890
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F6A1B6F8
+       mov       rdx,7FF9F69FAE68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6826130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F6806130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB0
+       mov       r11,7FF9F5C80FB0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68A18E8
+       mov       rdx,7FF9F68819D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68A18D0
+       mov       rdx,7FF9F68819C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,93
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB8
+       mov       r11,7FF9F5C80FB8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB8
+       mov       r11,7FF9F5C80FB8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F6A1B6F8
+       mov       rdx,7FF9F69FABF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6826130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F6806130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB0
+       mov       r11,7FF9F5C80FB0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68A18E8
+       mov       rdx,7FF9F68818E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68A18D0
+       mov       rdx,7FF9F68818D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,93
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB8
+       mov       r11,7FF9F5C80FB8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB8
+       mov       r11,7FF9F5C80FB8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F67F60D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6865938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F6A1B6F8
+       mov       rdx,7FF9F69EAE58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6826130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F67F6130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F67F61A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F67F6028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB0
+       mov       r11,7FF9F5C70FB0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68A18E8
+       mov       rdx,7FF9F6871A08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68A18D0
+       mov       rdx,7FF9F68719F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB8
+       mov       r11,7FF9F5C70FB8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB8
+       mov       r11,7FF9F5C70FB8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F6807C78]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6876EE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F6A1B6F8
+       mov       rdx,7FF9F6A38A10
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6826130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F6807CD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F6807D50]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6807BD0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB0
+       mov       r11,7FF9F5C80FF0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68A18E8
+       mov       rdx,7FF9F6892760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68A18D0
+       mov       rdx,7FF9F6892748
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,93
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB8
+       mov       r11,7FF9F5C80FF8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB8
+       mov       r11,7FF9F5C80FF8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68F5500]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F69E41F8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F6A1B6F8
+       mov       rdx,7FF9F6AA8268
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6826130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F68F5560]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68F55D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F68F5458]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB0
+       mov       r11,7FF9F5CA12B8
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68A18E8
+       mov       rdx,7FF9F69C6970
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68A18D0
+       mov       rdx,7FF9F69C6958
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6175450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,93
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6175450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB8
+       mov       r11,7FF9F5CA12C0
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB8
+       mov       r11,7FF9F5CA12C0
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6A66D78]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F6A1B6F8
+       mov       rdx,7FF9F6B10178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6826130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F69FDA88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB0
+       mov       r11,7FF9F5C71B80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68A18E8
+       mov       rdx,7FF9F6A818A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68A18D0
+       mov       rdx,7FF9F6A81890
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB8
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5CA0FB8
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
        call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
        call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FAE68
+       mov       rdx,7FF9F69FABF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdi
        mov       r11,7FF9F5C80FB0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68819D8
+       mov       rdx,7FF9F68818E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68819C0
+       mov       rdx,7FF9F68818D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F67F60D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6865938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FAE68
+       mov       rdx,7FF9F69EAE58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6806130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F67F6130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F67F61A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F67F6028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB0
+       mov       r11,7FF9F5C70FB0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68819D8
+       mov       rdx,7FF9F6871A08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68819C0
+       mov       rdx,7FF9F68719F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5C70FB8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5C70FB8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F6807C78]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6876EE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FAE68
+       mov       rdx,7FF9F6A38A10
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6806130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F6807CD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F6807D50]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6807BD0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       rcx,rbx
        call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB0
+       mov       r11,7FF9F5C80FF0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68819D8
+       mov       rdx,7FF9F6892760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68819C0
+       mov       rdx,7FF9F6892748
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
        call      qword ptr [7FF9F63452C0]
        mov       ecx,93
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5C80FF8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5C80FF8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68F5500]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F69E41F8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FAE68
+       mov       rdx,7FF9F6AA8268
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6806130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F68F5560]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68F55D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F68F5458]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB0
+       mov       r11,7FF9F5CA12B8
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68819D8
+       mov       rdx,7FF9F69C6970
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68819C0
+       mov       rdx,7FF9F69C6958
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5CA12C0
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5CA12C0
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6A66D78]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FAE68
+       mov       rdx,7FF9F6B10178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6806130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F69FDA88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB0
+       mov       r11,7FF9F5C71B80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68819D8
+       mov       rdx,7FF9F6A818A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68819C0
+       mov       rdx,7FF9F6A81890
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F67F60D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6865938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FABF0
+       mov       rdx,7FF9F69EAE58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6806130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F67F6130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F67F61A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F67F6028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB0
+       mov       r11,7FF9F5C70FB0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68818E8
+       mov       rdx,7FF9F6871A08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68818D0
+       mov       rdx,7FF9F68719F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5C70FB8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5C70FB8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F6807C78]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6876EE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FABF0
+       mov       rdx,7FF9F6A38A10
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6806130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F6807CD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F6807D50]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6807BD0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       rcx,rbx
        call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB0
+       mov       r11,7FF9F5C80FF0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68818E8
+       mov       rdx,7FF9F6892760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68818D0
+       mov       rdx,7FF9F6892748
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
        call      qword ptr [7FF9F63452C0]
        mov       ecx,93
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5C80FF8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5C80FF8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68F5500]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F69E41F8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FABF0
+       mov       rdx,7FF9F6AA8268
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6806130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F68F5560]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68F55D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F68F5458]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB0
+       mov       r11,7FF9F5CA12B8
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68818E8
+       mov       rdx,7FF9F69C6970
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68818D0
+       mov       rdx,7FF9F69C6958
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5CA12C0
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5CA12C0
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6A66D78]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69FABF0
+       mov       rdx,7FF9F6B10178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6806130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F69FDA88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB0
+       mov       r11,7FF9F5C71B80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F68818E8
+       mov       rdx,7FF9F6A818A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68818D0
+       mov       rdx,7FF9F6A81890
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FB8
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F67F60D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F6807C78]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6865938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6876EE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69EAE58
+       mov       rdx,7FF9F6A38A10
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F67F6130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F6807CD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F67F61A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F6807D50]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F67F6028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6807BD0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C70FB0
+       mov       r11,7FF9F5C80FF0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F6871A08
+       mov       rdx,7FF9F6892760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68719F0
+       mov       rdx,7FF9F6892748
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,93
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C70FB8
+       mov       r11,7FF9F5C80FF8
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C70FB8
+       mov       r11,7FF9F5C80FF8
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F67F60D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68F5500]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6865938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F69E41F8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69EAE58
+       mov       rdx,7FF9F6AA8268
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F67F6130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F68F5560]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F67F61A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68F55D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F67F6028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F68F5458]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C70FB0
+       mov       r11,7FF9F5CA12B8
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F6871A08
+       mov       rdx,7FF9F69C6970
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68719F0
+       mov       rdx,7FF9F69C6958
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,0AD
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6175450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,93
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6175450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C70FB8
+       mov       r11,7FF9F5CA12C0
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C70FB8
+       mov       r11,7FF9F5CA12C0
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F67F60D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6865938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6A66D78]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F69EAE58
+       mov       rdx,7FF9F6B10178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F67F6130]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F69FDA88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F67F61A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F67F6028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       rcx,rbx
        call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C70FB0
+       mov       r11,7FF9F5C71B80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F6871A08
+       mov       rdx,7FF9F6A818A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F68719F0
+       mov       rdx,7FF9F6A81890
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
        call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
        call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
        call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C70FB8
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C70FB8
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6807C78]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68F5500]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6876EE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F69E41F8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F6A38A10
+       mov       rdx,7FF9F6AA8268
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6807CD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F68F5560]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6807D50]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68F55D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6807BD0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F68F5458]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FF0
+       mov       r11,7FF9F5CA12B8
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F6892760
+       mov       rdx,7FF9F69C6970
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F6892748
+       mov       rdx,7FF9F69C6958
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FF8
+       mov       r11,7FF9F5CA12C0
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FF8
+       mov       r11,7FF9F5CA12C0
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6807C78]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F6876EE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6A66D78]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F6A38A10
+       mov       rdx,7FF9F6B10178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F6807CD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F69FDA88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6807D50]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6807BD0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FF0
+       mov       r11,7FF9F5C71B80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F6892760
+       mov       rdx,7FF9F6A818A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F6892748
+       mov       rdx,7FF9F6A81890
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FF8
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5C80FF8
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for AddRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Concurrent]]
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68F5500]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9F69E41F8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9F6A66D78]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        mov       [rsp+28],rsi
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
 ; Total bytes of code 139
 ; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rcx,[rbx]
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9F6AA8268
+       mov       rdx,7FF9F6B10178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
        call      CORINFO_HELP_NEWSFAST
        xor       ecx,ecx
        mov       [rax+18],rcx
        lea       rcx,[rbx+10]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rbx
        xor       edx,edx
        xor       r8d,r8d
        add       rsp,30
        pop       rbx
-       jmp       qword ptr [7FF9F68F5560]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9F69FDA88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
 ; Total bytes of code 97
 ; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       [rbp-28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,r8
        test      rbx,rbx
        je        near ptr M02_L12
        mov       rcx,[rdi]
        test      rcx,rcx
        je        near ptr M02_L13
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M02_L11
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        near ptr M02_L08
 M02_L02:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       r14,rax
        mov       rcx,[rbx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68F55D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68F5458]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA12B8
+       mov       r11,7FF9F5C71B80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9F69C6970
+       mov       rdx,7FF9F6A818A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L02
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M02_L11:
        mov       rcx,rsi
-       mov       rdx,7FF9F69C6958
+       mov       rdx,7FF9F6A81890
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9F630FB58]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E62A0
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175450
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E62A0
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F630F948]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9F630FB58]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62E62A0
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175450
+       mov       rdx,7FF9F6145450
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E62A0
+       mov       rdx,7FF9F62B62A0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F630F948]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9F5CA12C0
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
        jmp       near ptr M02_L10
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-30],0
        je        short M02_L15
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rdi,[rbp-30]
        cmp       [rdi],rcx
        je        short M02_L15
        mov       rcx,rdi
-       mov       r11,7FF9F5CA12C0
+       mov       r11,7FF9F5C71B88
        call      qword ptr [r11]
 M02_L15:
        nop
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
        call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D528
+       mov       rdx,7FF9F6A3D928
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81158
+       mov       r11,7FF9F5C810D0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D4F0
+       mov       rdx,7FF9F6A3D8F0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D510
+       mov       rdx,7FF9F6A3D910
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9F6276668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9F60566E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5C810D8
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5C810D8
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F6874A98]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68805D8
+       mov       rdx,7FF9F6881978
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880AE0
+       mov       rdx,7FF9F6881E80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6883B98
+       mov       rdx,7FF9F6884F38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880938
+       mov       rdx,7FF9F6881CD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
        call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D528
+       mov       rdx,7FF9F6A3EA30
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81158
+       mov       r11,7FF9F5C81228
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D4F0
+       mov       rdx,7FF9F6A3E9F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D510
+       mov       rdx,7FF9F6A3EA18
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9F6276668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9F60566E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5C81230
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5C81230
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F6874A98]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68805D8
+       mov       rdx,7FF9F68817F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880AE0
+       mov       rdx,7FF9F6881D00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6883B98
+       mov       rdx,7FF9F6884DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880938
+       mov       rdx,7FF9F6881B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
        call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D528
+       mov       rdx,7FF9F6A3DCE0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81158
+       mov       r11,7FF9F5C810C0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D4F0
+       mov       rdx,7FF9F6A3DCA8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D510
+       mov       rdx,7FF9F6A3DCC8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9F6276668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9F60566E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5C810C8
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5C810C8
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F6874A98]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68805D8
+       mov       rdx,7FF9F68817F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880AE0
+       mov       rdx,7FF9F6881D00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6883B98
+       mov       rdx,7FF9F6884DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880938
+       mov       rdx,7FF9F6881B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D528
+       mov       rdx,7FF9F6A5D9F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81158
+       mov       r11,7FF9F5CA10A8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D4F0
+       mov       rdx,7FF9F6A5D9C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D510
+       mov       rdx,7FF9F6A5D9E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5CA10B0
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5CA10B0
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F6874A98]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F68962E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68805D8
+       mov       rdx,7FF9F68A1978
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880AE0
+       mov       rdx,7FF9F68A1E80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6883B98
+       mov       rdx,7FF9F68A4F38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880938
+       mov       rdx,7FF9F68A1CD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CC4F8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68B5218]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
-       mov       rax,[rax+40]
+       mov       rax,[rax+48]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68357D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68358A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+48]
+       mov       r11,[rcx+68]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+50]
+       mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6835728]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D528
+       mov       rdx,7FF9F6AD54A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81158
+       mov       r11,7FF9F5CA1150
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D4F0
+       mov       rdx,7FF9F6AD2478
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D510
+       mov       rdx,7FF9F6AD5488
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5CA1158
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5CA1158
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CC4E0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F6874A98]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F68B5BC0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68805D8
+       mov       rdx,7FF9F68A25C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880AE0
+       mov       rdx,7FF9F68A2AD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6883B98
+       mov       rdx,7FF9F68A5B88
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880938
+       mov       rdx,7FF9F68A2928
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F69E7AC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68FC0D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68FC1B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+48]
+       mov       r11,[rcx+60]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+50]
+       mov       r11,[rcx+68]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F68FC030]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D528
+       mov       rdx,7FF9F6ADC3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81158
+       mov       r11,7FF9F5CA1410
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D4F0
+       mov       rdx,7FF9F6AD06B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D510
+       mov       rdx,7FF9F6ADC3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5CA1418
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5CA1418
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
 M02_L02:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
+       mov       rcx,7FF9F69E3B88
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F6874A98]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F69EC588]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68805D8
+       mov       rdx,7FF9F69C6360
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880AE0
+       mov       rdx,7FF9F69C6868
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6883B98
+       mov       rdx,7FF9F69C9920
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880938
+       mov       rdx,7FF9F69C66C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F629D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68740F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6A66F58]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F6814D20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814DF8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6814C78]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D528
+       mov       rdx,7FF9F6B535F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81158
+       mov       r11,7FF9F5C71C78
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D4F0
+       mov       rdx,7FF9F6B535C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D510
+       mov       rdx,7FF9F6B535E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6266668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C81160
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F629D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F6874A98]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F6A67900]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68805D8
+       mov       rdx,7FF9F6A818D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880AE0
+       mov       rdx,7FF9F6A81DE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6883B98
+       mov       rdx,7FF9F6A84E98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6880938
+       mov       rdx,7FF9F6A81C38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D928
+       mov       rdx,7FF9F6A3EA30
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C81228
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D8F0
+       mov       rdx,7FF9F6A3E9F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D910
+       mov       rdx,7FF9F6A3EA18
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9F6276668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9F60566E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C81230
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C81230
        call      qword ptr [r11]
 M01_L16:
        nop
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
        call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881978
+       mov       rdx,7FF9F68817F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881E80
+       mov       rdx,7FF9F6881D00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884F38
+       mov       rdx,7FF9F6884DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881CD8
+       mov       rdx,7FF9F6881B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D928
+       mov       rdx,7FF9F6A3DCE0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C810C0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D8F0
+       mov       rdx,7FF9F6A3DCA8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D910
+       mov       rdx,7FF9F6A3DCC8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9F6276668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9F60566E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C810C8
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C810C8
        call      qword ptr [r11]
 M01_L16:
        nop
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
        call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881978
+       mov       rdx,7FF9F68817F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881E80
+       mov       rdx,7FF9F6881D00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884F38
+       mov       rdx,7FF9F6884DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881CD8
+       mov       rdx,7FF9F6881B58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D928
+       mov       rdx,7FF9F6A5D9F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5CA10A8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D8F0
+       mov       rdx,7FF9F6A5D9C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D910
+       mov       rdx,7FF9F6A5D9E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5CA10B0
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5CA10B0
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F68962E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881978
+       mov       rdx,7FF9F68A1978
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881E80
+       mov       rdx,7FF9F68A1E80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884F38
+       mov       rdx,7FF9F68A4F38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881CD8
+       mov       rdx,7FF9F68A1CD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CC4F8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68B5218]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
-       mov       rax,[rax+40]
+       mov       rax,[rax+48]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68357D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68358A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+48]
+       mov       r11,[rcx+68]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+50]
+       mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6835728]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D928
+       mov       rdx,7FF9F6AD54A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5CA1150
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D8F0
+       mov       rdx,7FF9F6AD2478
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D910
+       mov       rdx,7FF9F6AD5488
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5CA1158
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5CA1158
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CC4E0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F68B5BC0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881978
+       mov       rdx,7FF9F68A25C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881E80
+       mov       rdx,7FF9F68A2AD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884F38
+       mov       rdx,7FF9F68A5B88
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881CD8
+       mov       rdx,7FF9F68A2928
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F69E7AC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68FC0D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68FC1B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+48]
+       mov       r11,[rcx+60]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+50]
+       mov       r11,[rcx+68]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F68FC030]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D928
+       mov       rdx,7FF9F6ADC3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5CA1410
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D8F0
+       mov       rdx,7FF9F6AD06B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D910
+       mov       rdx,7FF9F6ADC3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5CA1418
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5CA1418
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
 M02_L02:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
+       mov       rcx,7FF9F69E3B88
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F69EC588]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881978
+       mov       rdx,7FF9F69C6360
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881E80
+       mov       rdx,7FF9F69C6868
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884F38
+       mov       rdx,7FF9F69C9920
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881CD8
+       mov       rdx,7FF9F69C66C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F629D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6A66F58]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D928
+       mov       rdx,7FF9F6B535F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C71C78
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3D8F0
+       mov       rdx,7FF9F6B535C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3D910
+       mov       rdx,7FF9F6B535E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6266668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F629D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F6A67900]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881978
+       mov       rdx,7FF9F6A818D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881E80
+       mov       rdx,7FF9F6A81DE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884F38
+       mov       rdx,7FF9F6A84E98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881CD8
+       mov       rdx,7FF9F6A81C38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3EA30
+       mov       rdx,7FF9F6A3DCE0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81228
+       mov       r11,7FF9F5C810C0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3E9F8
+       mov       rdx,7FF9F6A3DCA8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3EA18
+       mov       rdx,7FF9F6A3DCC8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9F6276668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9F60566E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81230
+       mov       r11,7FF9F5C810C8
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C81230
+       mov       r11,7FF9F5C810C8
        call      qword ptr [r11]
 M01_L16:
        nop
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3EA30
+       mov       rdx,7FF9F6A5D9F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81228
+       mov       r11,7FF9F5CA10A8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3E9F8
+       mov       rdx,7FF9F6A5D9C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3EA18
+       mov       rdx,7FF9F6A5D9E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81230
+       mov       r11,7FF9F5CA10B0
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C81230
+       mov       r11,7FF9F5CA10B0
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F68962E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68817F8
+       mov       rdx,7FF9F68A1978
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881D00
+       mov       rdx,7FF9F68A1E80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884DB8
+       mov       rdx,7FF9F68A4F38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881B58
+       mov       rdx,7FF9F68A1CD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CC4F8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68B5218]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
-       mov       rax,[rax+40]
+       mov       rax,[rax+48]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68357D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68358A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+48]
+       mov       r11,[rcx+68]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+50]
+       mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6835728]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3EA30
+       mov       rdx,7FF9F6AD54A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81228
+       mov       r11,7FF9F5CA1150
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3E9F8
+       mov       rdx,7FF9F6AD2478
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3EA18
+       mov       rdx,7FF9F6AD5488
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81230
+       mov       r11,7FF9F5CA1158
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C81230
+       mov       r11,7FF9F5CA1158
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CC4E0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F68B5BC0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68817F8
+       mov       rdx,7FF9F68A25C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881D00
+       mov       rdx,7FF9F68A2AD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884DB8
+       mov       rdx,7FF9F68A5B88
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881B58
+       mov       rdx,7FF9F68A2928
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F69E7AC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68FC0D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68FC1B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+48]
+       mov       r11,[rcx+60]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+50]
+       mov       r11,[rcx+68]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F68FC030]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3EA30
+       mov       rdx,7FF9F6ADC3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81228
+       mov       r11,7FF9F5CA1410
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3E9F8
+       mov       rdx,7FF9F6AD06B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3EA18
+       mov       rdx,7FF9F6ADC3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81230
+       mov       r11,7FF9F5CA1418
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C81230
+       mov       r11,7FF9F5CA1418
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
 M02_L02:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
+       mov       rcx,7FF9F69E3B88
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F69EC588]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68817F8
+       mov       rdx,7FF9F69C6360
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881D00
+       mov       rdx,7FF9F69C6868
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884DB8
+       mov       rdx,7FF9F69C9920
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881B58
+       mov       rdx,7FF9F69C66C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F629D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6A66F58]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3EA30
+       mov       rdx,7FF9F6B535F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81228
+       mov       r11,7FF9F5C71C78
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3E9F8
+       mov       rdx,7FF9F6B535C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3EA18
+       mov       rdx,7FF9F6B535E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6266668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C81230
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C81230
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F629D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F6A67900]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68817F8
+       mov       rdx,7FF9F6A818D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881D00
+       mov       rdx,7FF9F6A81DE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884DB8
+       mov       rdx,7FF9F6A84E98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881B58
+       mov       rdx,7FF9F6A81C38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3DCE0
+       mov       rdx,7FF9F6A5D9F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810C0
+       mov       r11,7FF9F5CA10A8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3DCA8
+       mov       rdx,7FF9F6A5D9C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3DCC8
+       mov       rdx,7FF9F6A5D9E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810C8
+       mov       r11,7FF9F5CA10B0
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C810C8
+       mov       r11,7FF9F5CA10B0
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F68962E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68817F8
+       mov       rdx,7FF9F68A1978
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881D00
+       mov       rdx,7FF9F68A1E80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884DB8
+       mov       rdx,7FF9F68A4F38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881B58
+       mov       rdx,7FF9F68A1CD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CC4F8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68B5218]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
-       mov       rax,[rax+40]
+       mov       rax,[rax+48]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68357D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68358A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+48]
+       mov       r11,[rcx+68]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+50]
+       mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6835728]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3DCE0
+       mov       rdx,7FF9F6AD54A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810C0
+       mov       r11,7FF9F5CA1150
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3DCA8
+       mov       rdx,7FF9F6AD2478
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3DCC8
+       mov       rdx,7FF9F6AD5488
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810C8
+       mov       r11,7FF9F5CA1158
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C810C8
+       mov       r11,7FF9F5CA1158
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CC4E0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F68B5BC0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68817F8
+       mov       rdx,7FF9F68A25C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881D00
+       mov       rdx,7FF9F68A2AD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884DB8
+       mov       rdx,7FF9F68A5B88
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881B58
+       mov       rdx,7FF9F68A2928
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F69E7AC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68FC0D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68FC1B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+48]
+       mov       r11,[rcx+60]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+50]
+       mov       r11,[rcx+68]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F68FC030]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3DCE0
+       mov       rdx,7FF9F6ADC3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810C0
+       mov       r11,7FF9F5CA1410
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3DCA8
+       mov       rdx,7FF9F6AD06B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3DCC8
+       mov       rdx,7FF9F6ADC3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810C8
+       mov       r11,7FF9F5CA1418
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C810C8
+       mov       r11,7FF9F5CA1418
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
 M02_L02:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
+       mov       rcx,7FF9F69E3B88
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F69EC588]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68817F8
+       mov       rdx,7FF9F69C6360
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881D00
+       mov       rdx,7FF9F69C6868
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884DB8
+       mov       rdx,7FF9F69C9920
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881B58
+       mov       rdx,7FF9F69C66C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62AD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F629D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6875938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6A66F58]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68060D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68061A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6806028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3DCE0
+       mov       rdx,7FF9F6B535F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810C0
+       mov       r11,7FF9F5C71C78
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62AD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A3DCA8
+       mov       rdx,7FF9F6B535C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A3DCC8
+       mov       rdx,7FF9F6B535E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6276668
+       mov       rdx,7FF9F6266668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60566E8]
+       call      qword ptr [7FF9F60466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5C810C8
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5C810C8
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62AD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F629D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68762E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F6A67900]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68817F8
+       mov       rdx,7FF9F6A818D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881D00
+       mov       rdx,7FF9F6A81DE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6884DB8
+       mov       rdx,7FF9F6A84E98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F6881B58
+       mov       rdx,7FF9F6A81C38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CC4F8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68B5218]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
-       mov       rax,[rax+40]
+       mov       rax,[rax+48]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68357D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68358A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+48]
+       mov       r11,[rcx+68]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+50]
+       mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F6835728]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A5D9F8
+       mov       rdx,7FF9F6AD54A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5CA10A8
+       mov       r11,7FF9F5CA1150
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A5D9C0
+       mov       rdx,7FF9F6AD2478
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A5D9E0
+       mov       rdx,7FF9F6AD5488
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5CA10B0
+       mov       r11,7FF9F5CA1158
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5CA10B0
+       mov       r11,7FF9F5CA1158
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CC4E0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68962E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F68B5BC0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A1978
+       mov       rdx,7FF9F68A25C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A1E80
+       mov       rdx,7FF9F68A2AD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A4F38
+       mov       rdx,7FF9F68A5B88
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A1CD8
+       mov       rdx,7FF9F68A2928
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,0AD
        mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6175A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F630FB58]
        mov       ecx,93
        mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6175A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F630F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
        call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F69E7AC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68FC0D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68FC1B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+48]
+       mov       r11,[rcx+60]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+50]
+       mov       r11,[rcx+68]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F68FC030]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A5D9F8
+       mov       rdx,7FF9F6ADC3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5CA10A8
+       mov       r11,7FF9F5CA1410
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A5D9C0
+       mov       rdx,7FF9F6AD06B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A5D9E0
+       mov       rdx,7FF9F6ADC3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5CA10B0
+       mov       r11,7FF9F5CA1418
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5CA10B0
+       mov       r11,7FF9F5CA1418
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
        call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
 M02_L02:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
+       mov       rcx,7FF9F69E3B88
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68962E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F69EC588]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A1978
+       mov       rdx,7FF9F69C6360
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A1E80
+       mov       rdx,7FF9F69C6868
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A4F38
+       mov       rdx,7FF9F69C9920
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A1CD8
+       mov       rdx,7FF9F69C66C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F629D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6895938]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6A66F58]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68260D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68261A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6826028]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A5D9F8
+       mov       rdx,7FF9F6B535F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5CA10A8
+       mov       r11,7FF9F5C71C78
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6A5D9C0
+       mov       rdx,7FF9F6B535C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A5D9E0
+       mov       rdx,7FF9F6B535E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6296668
+       mov       rdx,7FF9F6266668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60766E8]
+       call      qword ptr [7FF9F60466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5CA10B0
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5CA10B0
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F629D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68962E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F6A67900]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A1978
+       mov       rdx,7FF9F6A818D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A1E80
+       mov       rdx,7FF9F6A81DE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A4F38
+       mov       rdx,7FF9F6A84E98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A1CD8
+       mov       rdx,7FF9F6A81C38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62CC4F8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68B5218]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F69E7AC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
-       mov       rax,[rax+48]
+       mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68357D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F68FC0D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68358A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F68FC1B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+68]
+       mov       r11,[rcx+60]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+70]
+       mov       r11,[rcx+68]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6835728]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F68FC030]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6AD54A0
+       mov       rdx,7FF9F6ADC3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5CA1150
+       mov       r11,7FF9F5CA1410
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6AD2478
+       mov       rdx,7FF9F6AD06B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6AD5488
+       mov       rdx,7FF9F6ADC3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9F6296668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9F60766E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5CA1158
+       mov       r11,7FF9F5CA1418
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5CA1158
+       mov       r11,7FF9F5CA1418
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62CC4E0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
 M02_L02:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
+       mov       rcx,7FF9F69E3B88
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68B5BC0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F69EC588]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A25C8
+       mov       rdx,7FF9F69C6360
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A2AD0
+       mov       rdx,7FF9F69C6868
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A5B88
+       mov       rdx,7FF9F69C9920
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A2928
+       mov       rdx,7FF9F69C66C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F630FB58]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
        mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A50
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F630F948]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F630FB58]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,93
        mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A50
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F630F948]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62CC4F8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F629D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68B5218]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6A66F58]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
-       mov       rax,[rax+48]
+       mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68357D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68358A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+68]
+       mov       r11,[rcx+48]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+70]
+       mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F6835728]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6AD54A0
+       mov       rdx,7FF9F6B535F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5CA1150
+       mov       r11,7FF9F5C71C78
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62CC588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6AD2478
+       mov       rdx,7FF9F6B535C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6AD5488
+       mov       rdx,7FF9F6B535E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6296668
+       mov       rdx,7FF9F6266668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60766E8]
+       call      qword ptr [7FF9F60466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5CA1158
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5CA1158
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62CC4E0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F629D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F68B5BC0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F6A67900]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A25C8
+       mov       rdx,7FF9F6A818D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A2AD0
+       mov       rdx,7FF9F6A81DE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A5B88
+       mov       rdx,7FF9F6A84E98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F68A2928
+       mov       rdx,7FF9F6A81C38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F630FB58]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A50
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F630F948]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F630FB58]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A50
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F630F948]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for RemoveRange method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+288]
        mov       rcx,rsi
-       call      qword ptr [7FF9F62CD5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F629D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F69E7AC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6A66F58]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 112
 ; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+70]
        mov       [rbp-50],rsp
        mov       [rbp-38],rcx
        mov       [rbp+10],rcx
        mov       rbx,rdx
        test      rbx,rbx
        je        near ptr M01_L14
        mov       rsi,[rcx]
        mov       rdx,rsi
        mov       rax,[rdx+30]
        mov       rax,[rax]
        mov       rax,[rax+40]
        test      rax,rax
        je        near ptr M01_L12
 M01_L00:
        mov       rcx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F68FC0D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F69FDA28]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68FC1B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9F69FDB00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M01_L11
 M01_L01:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+60]
+       mov       r11,[rcx+48]
        test      r11,r11
        je        near ptr M01_L13
 M01_L02:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rbx,rax
        mov       [rbp-40],rbx
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        jmp       short M01_L05
 M01_L03:
        mov       rcx,[rsi+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+68]
+       mov       r11,[rcx+50]
        test      r11,r11
        je        short M01_L07
 M01_L04:
        mov       rcx,rbx
        call      qword ptr [r11]
        mov       rdx,rax
        mov       rcx,[rbp+10]
        lea       r8,[rcx+18]
        mov       rcx,rdi
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F68FC030]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9F69FD980]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9F6ADC3F8
+       mov       rdx,7FF9F6B535F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9F5CA1410
+       mov       r11,7FF9F5C71C78
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L11:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF9F62CD650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9F629D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9F6AD06B0
+       mov       rdx,7FF9F6B535C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6ADC3E0
+       mov       rdx,7FF9F6B535E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9F6296668
+       mov       rdx,7FF9F6266668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9F60766E8]
+       call      qword ptr [7FF9F60466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9F5CA1418
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
        jmp       near ptr M01_L10
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+70]
        cmp       qword ptr [rbp-40],0
        je        short M01_L16
        mov       rbx,[rbp-40]
        mov       r14,[rbx]
        mov       r15,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r14,r15
        je        short M01_L16
        mov       rcx,rbx
-       mov       r11,7FF9F5CA1418
+       mov       r11,7FF9F5C71C80
        call      qword ptr [r11]
 M01_L16:
        nop
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M02_L08
        mov       rdx,[rbp+8]
        test      rdx,rdx
        je        near ptr M02_L09
        lea       rcx,[rbp+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        near ptr M02_L07
 M02_L01:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9F62CD5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9F629D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rbp+10]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L05
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L05
 M02_L02:
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,7FF9F69E3B88
+       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
        mov       [rdi+18],rcx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L06
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L06
 M02_L03:
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
-       call      qword ptr [7FF9F69EC588]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9F6A67900]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F69C6360
+       mov       rdx,7FF9F6A818D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69C6868
+       mov       rdx,7FF9F6A81DE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F69C9920
+       mov       rdx,7FF9F6A84E98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9F69C66C0
+       mov       rdx,7FF9F6A81C38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,93
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 634
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F66B6070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7E8
+       mov       rdx,7FF9F6A1A440
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA898
+       mov       rdx,7FF9F6A1A4F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7F8
+       mov       rdx,7FF9F6A1A450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6044F30]
+       call      qword ptr [7FF9F6074F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F601EF40]
+       call      qword ptr [7FF9F604EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,22998630008
+       mov       rax,19F28300008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7E8
+       mov       rdx,7FF9F69FA4C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA898
+       mov       rdx,7FF9F69FA570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7F8
+       mov       rdx,7FF9F69FA4D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6044F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F601EF40]
+       call      qword ptr [7FF9F602EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,22998630008
+       mov       rax,2348B070008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
        mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7E8
+       mov       rdx,7FF9F69EA668
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA898
+       mov       rdx,7FF9F69EA718
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7F8
+       mov       rdx,7FF9F69EA678
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,22998630008
+       mov       rax,2E7B07A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F66B6070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7E8
+       mov       rdx,7FF9F6A1A620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA898
+       mov       rdx,7FF9F6A1A6D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7F8
+       mov       rdx,7FF9F6A1A630
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6044F30]
+       call      qword ptr [7FF9F6074F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F601EF40]
+       call      qword ptr [7FF9F604EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,22998630008
+       mov       rax,1EBAB270008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7E8
+       mov       rdx,7FF9F69FA6A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA898
+       mov       rdx,7FF9F69FA750
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7F8
+       mov       rdx,7FF9F69FA6B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6044F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F601EF40]
+       call      qword ptr [7FF9F602EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,22998630008
+       mov       rax,21CC7A90008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
        mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7E8
+       mov       rdx,7FF9F6A75428
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA898
+       mov       rdx,7FF9F6A754D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7F8
+       mov       rdx,7FF9F6A75438
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,22998630008
+       mov       rax,24BB05C0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7E8
+       mov       rdx,7FF9F6A9B798
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA898
+       mov       rdx,7FF9F6A9B848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA7F8
+       mov       rdx,7FF9F6A9B7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6044F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F601EF40]
+       call      qword ptr [7FF9F602EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,22998630008
+       mov       rax,24B3A380008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F66B6070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A440
+       mov       rdx,7FF9F69FA4C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A4F0
+       mov       rdx,7FF9F69FA570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A450
+       mov       rdx,7FF9F69FA4D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F604EF40]
+       call      qword ptr [7FF9F602EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,19F28300008
+       mov       rax,2348B070008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F66B6070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A440
+       mov       rdx,7FF9F69EA668
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A4F0
+       mov       rdx,7FF9F69EA718
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A450
+       mov       rdx,7FF9F69EA678
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6044F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F604EF40]
+       call      qword ptr [7FF9F601EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,19F28300008
+       mov       rax,2E7B07A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
        mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A440
+       mov       rdx,7FF9F6A1A620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A4F0
+       mov       rdx,7FF9F6A1A6D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A450
+       mov       rdx,7FF9F6A1A630
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,19F28300008
+       mov       rax,1EBAB270008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F66B6070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A440
+       mov       rdx,7FF9F69FA6A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A4F0
+       mov       rdx,7FF9F69FA750
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A450
+       mov       rdx,7FF9F69FA6B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F604EF40]
+       call      qword ptr [7FF9F602EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,19F28300008
+       mov       rax,21CC7A90008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F66B6070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A440
+       mov       rdx,7FF9F6A75428
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A4F0
+       mov       rdx,7FF9F6A754D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A450
+       mov       rdx,7FF9F6A75438
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6044F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F604EF40]
+       call      qword ptr [7FF9F601EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,19F28300008
+       mov       rax,24BB05C0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F66B6070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A440
+       mov       rdx,7FF9F6A9B798
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A4F0
+       mov       rdx,7FF9F6A9B848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A450
+       mov       rdx,7FF9F6A9B7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F604EF40]
+       call      qword ptr [7FF9F602EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,19F28300008
+       mov       rax,24B3A380008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA4C0
+       mov       rdx,7FF9F69EA668
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA570
+       mov       rdx,7FF9F69EA718
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA4D0
+       mov       rdx,7FF9F69EA678
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6044F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F602EF40]
+       call      qword ptr [7FF9F601EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2348B070008
+       mov       rax,2E7B07A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F66B6070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA4C0
+       mov       rdx,7FF9F6A1A620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA570
+       mov       rdx,7FF9F6A1A6D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA4D0
+       mov       rdx,7FF9F6A1A630
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6074F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F602EF40]
+       call      qword ptr [7FF9F604EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2348B070008
+       mov       rax,1EBAB270008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA4C0
+       mov       rdx,7FF9F69FA6A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA570
+       mov       rdx,7FF9F69FA750
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA4D0
+       mov       rdx,7FF9F69FA6B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2348B070008
+       mov       rax,21CC7A90008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA4C0
+       mov       rdx,7FF9F6A75428
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA570
+       mov       rdx,7FF9F6A754D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA4D0
+       mov       rdx,7FF9F6A75438
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6044F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F602EF40]
+       call      qword ptr [7FF9F601EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2348B070008
+       mov       rax,24BB05C0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA4C0
+       mov       rdx,7FF9F6A9B798
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA570
+       mov       rdx,7FF9F6A9B848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA4D0
+       mov       rdx,7FF9F6A9B7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2348B070008
+       mov       rax,24B3A380008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F66B6070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F63652C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6175A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62E69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F63650B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6076670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA668
+       mov       rdx,7FF9F6A1A620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA718
+       mov       rdx,7FF9F6A1A6D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA678
+       mov       rdx,7FF9F6A1A630
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6044F30]
+       call      qword ptr [7FF9F6074F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F601EF40]
+       call      qword ptr [7FF9F604EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2E7B07A0008
+       mov       rax,1EBAB270008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA668
+       mov       rdx,7FF9F69FA6A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA718
+       mov       rdx,7FF9F69FA750
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA678
+       mov       rdx,7FF9F69FA6B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6044F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F601EF40]
+       call      qword ptr [7FF9F602EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2E7B07A0008
+       mov       rax,21CC7A90008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
        mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA668
+       mov       rdx,7FF9F6A75428
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA718
+       mov       rdx,7FF9F6A754D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA678
+       mov       rdx,7FF9F6A75438
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2E7B07A0008
+       mov       rax,24BB05C0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA668
+       mov       rdx,7FF9F6A9B798
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA718
+       mov       rdx,7FF9F6A9B848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69EA678
+       mov       rdx,7FF9F6A9B7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6044F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F601EF40]
+       call      qword ptr [7FF9F602EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2E7B07A0008
+       mov       rax,24B3A380008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F66B6070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A620
+       mov       rdx,7FF9F69FA6A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A6D0
+       mov       rdx,7FF9F69FA750
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A630
+       mov       rdx,7FF9F69FA6B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F604EF40]
+       call      qword ptr [7FF9F602EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,1EBAB270008
+       mov       rax,21CC7A90008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F66B6070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A620
+       mov       rdx,7FF9F6A75428
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A6D0
+       mov       rdx,7FF9F6A754D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A630
+       mov       rdx,7FF9F6A75438
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6044F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F604EF40]
+       call      qword ptr [7FF9F601EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,1EBAB270008
+       mov       rax,24BB05C0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F66B6070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63652C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6175A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62E69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63650B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6076670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A620
+       mov       rdx,7FF9F6A9B798
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A6D0
+       mov       rdx,7FF9F6A9B848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E9DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1A630
+       mov       rdx,7FF9F6A9B7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F604EF40]
+       call      qword ptr [7FF9F602EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,1EBAB270008
+       mov       rax,24B3A380008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63452C0]
+       call      qword ptr [7FF9F63352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6155A18
+       mov       rdx,7FF9F6145A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62C69B8
+       mov       rdx,7FF9F62B69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63450B0]
+       call      qword ptr [7FF9F63350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6056670]
+       call      qword ptr [7FF9F6046670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA6A0
+       mov       rdx,7FF9F6A75428
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA750
+       mov       rdx,7FF9F6A754D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA6B0
+       mov       rdx,7FF9F6A75438
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6044F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F602EF40]
+       call      qword ptr [7FF9F601EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,21CC7A90008
+       mov       rax,24BB05C0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA6A0
+       mov       rdx,7FF9F6A9B798
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA750
+       mov       rdx,7FF9F6A9B848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FA6B0
+       mov       rdx,7FF9F6A9B7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,21CC7A90008
+       mov       rax,24B3A380008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6686070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6696070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
        mov       rbx,[rbx+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L00:
-       call      qword ptr [7FF9F63352C0]
+       call      qword ptr [7FF9F63452C0]
        mov       ecx,0AD
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9F6145A18
+       mov       rdx,7FF9F6155A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9F62B69B8
+       mov       rdx,7FF9F62C69B8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9F63350B0]
+       call      qword ptr [7FF9F63450B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9F6046670]
+       call      qword ptr [7FF9F6056670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
 ; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        test      rsi,rsi
        je        near ptr M01_L07
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+20]
        test      rcx,rcx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A75428
+       mov       rdx,7FF9F6A9B798
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        jne       short M01_L04
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M01_L02
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M01_L02
        jmp       short M01_L03
 M01_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A754D8
+       mov       rdx,7FF9F6A9B848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9F5E6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F5E7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A75438
+       mov       rdx,7FF9F6A9B7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        mov       rcx,rdi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [r11]
 M01_L07:
        mov       ecx,10
-       call      qword ptr [7FF9F6044F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 ; Total bytes of code 215
 ; System.String.Concat(System.String, System.String)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        mov       rbx,rdx
        test      rsi,rsi
        je        near ptr M02_L02
        mov       edi,[rsi+8]
        test      edi,edi
        je        short M02_L02
        test      rbx,rbx
        je        short M02_L00
        mov       ebp,[rbx+8]
        test      ebp,ebp
        je        short M02_L00
        mov       r14d,edi
        lea       ecx,[r14+rbp]
        test      ecx,ecx
        jl        short M02_L01
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
        mov       rax,rsi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L01:
-       call      qword ptr [7FF9F601EF40]
+       call      qword ptr [7FF9F602EF40]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,24BB05C0008
+       mov       rax,24B3A380008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
