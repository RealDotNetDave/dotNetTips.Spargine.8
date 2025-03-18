## DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark-20250316-235319
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA37EA48]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA43EEE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA40DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5E6E20
+       mov       rdx,7FF9DA5A62E8
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
-       jmp       qword ptr [7FF9DA3AF7E0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA37EAA8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA37EB20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA37E9A0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E5C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D98310A0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA4506E0
+       mov       rdx,7FF9DA420868
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
-       mov       rdx,7FF9DA4506C8
+       mov       rdx,7FF9DA420850
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9E9FB58]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E76B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D05A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E76B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9E9F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C06670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9E9FB58]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E76B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D05A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E76B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9E9F948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C06670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D98310A8
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
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D98310A8
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA43EEE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,[rdx+60]
+       mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5E6E20
+       mov       rdx,7FF9DA5C6430
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
-       jmp       qword ptr [7FF9DA3AF7E0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3D4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D98510A0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
        mov       rcx,rsi
        mov       rdx,7FF9DA4506C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D98510A8
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
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D98510A8
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA43EEE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,[rdx+60]
+       mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5E6E20
+       mov       rdx,7FF9DA5B70D0
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
-       jmp       qword ptr [7FF9DA3AF7E0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3C4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3C4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3C4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E6D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D9840F80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA4506E0
+       mov       rdx,7FF9DA440868
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
-       mov       rdx,7FF9DA4506C8
+       mov       rdx,7FF9DA440850
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D9840F88
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
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D9840F88
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA43EEE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,[rdx+60]
+       mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5E6E20
+       mov       rdx,7FF9DA5C6608
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
-       jmp       qword ptr [7FF9DA3AF7E0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3D4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D9850F80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
        mov       rcx,rsi
        mov       rdx,7FF9DA4506C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D9850F88
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
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D9850F88
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA43EEE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,[rdx+60]
+       mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5E6E20
+       mov       rdx,7FF9DA5B6AC8
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
-       jmp       qword ptr [7FF9DA3AF7E0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3C4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3C4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3C4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E6D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D9840F80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA4506E0
+       mov       rdx,7FF9DA440868
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
-       mov       rdx,7FF9DA4506C8
+       mov       rdx,7FF9DA440850
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D9840F88
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
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D9840F88
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA39EC88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA43EEE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA42DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,[rdx+60]
+       mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5E6E20
+       mov       rdx,7FF9DA5C6F68
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
-       jmp       qword ptr [7FF9DA3AF7E0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA39ECE8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA39ED60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA39EBE0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D9850FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA4506E0
+       mov       rdx,7FF9DA440D20
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
-       mov       rdx,7FF9DA4506C8
+       mov       rdx,7FF9DA440D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D25A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D25A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D9850FA8
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
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D9850FA8
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA43EEE0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA4640F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,[rdx+60]
+       mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5E6E20
+       mov       rdx,7FF9DA5D7AE0
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
-       jmp       qword ptr [7FF9DA3AF7E0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3E51D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D9860FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA4506E0
+       mov       rdx,7FF9DA451228
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
-       mov       rdx,7FF9DA4506C8
+       mov       rdx,7FF9DA451210
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D9860FA8
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
-       mov       r11,7FF9D98710A8
+       mov       r11,7FF9D9860FA8
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
-       call      qword ptr [7FF9DA37EA48]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA40DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,[rdx+60]
+       mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5A62E8
+       mov       rdx,7FF9DA5C6430
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
-       jmp       qword ptr [7FF9DA37EAA8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3D4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA37EB20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA37E9A0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E5C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98310A0
+       mov       r11,7FF9D98510A0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA420868
+       mov       rdx,7FF9DA4506E0
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
-       mov       rdx,7FF9DA420850
+       mov       rdx,7FF9DA4506C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9E9FB58]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D05A50
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9E9F948]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C06670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9E9FB58]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D05A50
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9E9F948]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C06670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98310A8
+       mov       r11,7FF9D98510A8
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
-       mov       r11,7FF9D98310A8
+       mov       r11,7FF9D98510A8
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
-       call      qword ptr [7FF9DA37EA48]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA40DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,[rdx+60]
+       mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5A62E8
+       mov       rdx,7FF9DA5B70D0
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
-       jmp       qword ptr [7FF9DA37EAA8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3C4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA37EB20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3C4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA37E9A0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3C4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E5C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E6D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98310A0
+       mov       r11,7FF9D9840F80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA420868
+       mov       rdx,7FF9DA440868
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
-       mov       rdx,7FF9DA420850
+       mov       rdx,7FF9DA440850
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9E9FB58]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D05A50
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9E9F948]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C06670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9E9FB58]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D05A50
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9E9F948]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C06670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98310A8
+       mov       r11,7FF9D9840F88
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
-       mov       r11,7FF9D98310A8
+       mov       r11,7FF9D9840F88
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
-       call      qword ptr [7FF9DA37EA48]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA40DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,[rdx+60]
+       mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5A62E8
+       mov       rdx,7FF9DA5C6608
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
-       jmp       qword ptr [7FF9DA37EAA8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3D4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA37EB20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA37E9A0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E5C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98310A0
+       mov       r11,7FF9D9850F80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA420868
+       mov       rdx,7FF9DA4506E0
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
-       mov       rdx,7FF9DA420850
+       mov       rdx,7FF9DA4506C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9E9FB58]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D05A50
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9E9F948]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C06670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9E9FB58]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D05A50
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9E9F948]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C06670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98310A8
+       mov       r11,7FF9D9850F88
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
-       mov       r11,7FF9D98310A8
+       mov       r11,7FF9D9850F88
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
-       call      qword ptr [7FF9DA37EA48]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA40DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,[rdx+60]
+       mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5A62E8
+       mov       rdx,7FF9DA5B6AC8
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
-       jmp       qword ptr [7FF9DA37EAA8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3C4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA37EB20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3C4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA37E9A0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3C4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E5C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E6D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98310A0
+       mov       r11,7FF9D9840F80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA420868
+       mov       rdx,7FF9DA440868
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
-       mov       rdx,7FF9DA420850
+       mov       rdx,7FF9DA440850
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9E9FB58]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D05A50
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9E9F948]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C06670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9E9FB58]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D05A50
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9E9F948]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C06670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98310A8
+       mov       r11,7FF9D9840F88
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
-       mov       r11,7FF9D98310A8
+       mov       r11,7FF9D9840F88
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
-       call      qword ptr [7FF9DA37EA48]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA39EC88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA40DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA42DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,[rdx+60]
+       mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5A62E8
+       mov       rdx,7FF9DA5C6F68
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
-       jmp       qword ptr [7FF9DA37EAA8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA39ECE8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA37EB20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA39ED60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA37E9A0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA39EBE0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E5C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98310A0
+       mov       r11,7FF9D9850FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA420868
+       mov       rdx,7FF9DA440D20
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
-       mov       rdx,7FF9DA420850
+       mov       rdx,7FF9DA440D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9E9FB58]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D05A50
+       mov       rdx,7FF9D9D25A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9E9F948]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C06670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9E9FB58]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,93
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D05A50
+       mov       rdx,7FF9D9D25A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9E9F948]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C06670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98310A8
+       mov       r11,7FF9D9850FA8
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
-       mov       r11,7FF9D98310A8
+       mov       r11,7FF9D9850FA8
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
-       call      qword ptr [7FF9DA37EA48]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA40DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA4640F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,[rdx+60]
+       mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FF9DA5A62E8
+       mov       rdx,7FF9DA5D7AE0
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
-       jmp       qword ptr [7FF9DA37EAA8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3E51D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA37EB20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA37E9A0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E5C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98310A0
+       mov       r11,7FF9D9860FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA420868
+       mov       rdx,7FF9DA451228
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
-       mov       rdx,7FF9DA420850
+       mov       rdx,7FF9DA451210
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9E9FB58]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D05A50
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9E9F948]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C06670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9E9FB58]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D05A50
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E76B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9976B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9E9F948]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C06670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98310A8
+       mov       r11,7FF9D9860FA8
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
-       mov       r11,7FF9D98310A8
+       mov       r11,7FF9D9860FA8
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
-       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5C6430
+       mov       rdx,7FF9DA5B70D0
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
-       jmp       qword ptr [7FF9DA3D4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3C4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3C4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3C4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E6D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98510A0
+       mov       r11,7FF9D9840F80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA4506E0
+       mov       rdx,7FF9DA440868
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
-       mov       rdx,7FF9DA4506C8
+       mov       rdx,7FF9DA440850
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D9840F88
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
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D9840F88
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
        call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
        call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5C6430
+       mov       rdx,7FF9DA5C6608
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
        mov       rcx,rbx
        call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98510A0
+       mov       r11,7FF9D9850F80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
        call      qword ptr [7FF9D9F152C0]
        mov       ecx,93
        mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D9850F88
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
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D9850F88
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
-       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5C6430
+       mov       rdx,7FF9DA5B6AC8
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
-       jmp       qword ptr [7FF9DA3D4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3C4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3C4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3C4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E6D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98510A0
+       mov       r11,7FF9D9840F80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA4506E0
+       mov       rdx,7FF9DA440868
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
-       mov       rdx,7FF9DA4506C8
+       mov       rdx,7FF9DA440850
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D9840F88
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
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D9840F88
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
-       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA39EC88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA42DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5C6430
+       mov       rdx,7FF9DA5C6F68
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
-       jmp       qword ptr [7FF9DA3D4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA39ECE8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA39ED60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA39EBE0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98510A0
+       mov       r11,7FF9D9850FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA4506E0
+       mov       rdx,7FF9DA440D20
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
-       mov       rdx,7FF9DA4506C8
+       mov       rdx,7FF9DA440D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,0AD
        mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D25A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
        call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,93
        mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D25A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D9850FA8
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
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D9850FA8
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
-       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA4640F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5C6430
+       mov       rdx,7FF9DA5D7AE0
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
-       jmp       qword ptr [7FF9DA3D4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3E51D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D98510A0
+       mov       r11,7FF9D9860FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA4506E0
+       mov       rdx,7FF9DA451228
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
-       mov       rdx,7FF9DA4506C8
+       mov       rdx,7FF9DA451210
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D9860FA8
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
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D9860FA8
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
-       call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5B70D0
+       mov       rdx,7FF9DA5C6608
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
-       jmp       qword ptr [7FF9DA3C4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3D4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3C4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3C4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E6D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D9840F80
+       mov       r11,7FF9D9850F80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA440868
+       mov       rdx,7FF9DA4506E0
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
-       mov       rdx,7FF9DA440850
+       mov       rdx,7FF9DA4506C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F052C0]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D15A18
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F050B0]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C16670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F052C0]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D15A18
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F050B0]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C16670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D9840F88
+       mov       r11,7FF9D9850F88
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
-       mov       r11,7FF9D9840F88
+       mov       r11,7FF9D9850F88
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
        call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
        call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5B70D0
+       mov       rdx,7FF9DA5B6AC8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L01:
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
-       call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA39EC88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA42DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5B70D0
+       mov       rdx,7FF9DA5C6F68
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
-       jmp       qword ptr [7FF9DA3C4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA39ECE8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3C4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA39ED60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3C4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA39EBE0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E6D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D9840F80
+       mov       r11,7FF9D9850FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA440868
+       mov       rdx,7FF9DA440D20
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
-       mov       rdx,7FF9DA440850
+       mov       rdx,7FF9DA440D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F052C0]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D15A18
+       mov       rdx,7FF9D9D25A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F050B0]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C16670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F052C0]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,93
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D15A18
+       mov       rdx,7FF9D9D25A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F050B0]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C16670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D9840F88
+       mov       r11,7FF9D9850FA8
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
-       mov       r11,7FF9D9840F88
+       mov       r11,7FF9D9850FA8
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
-       call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA4640F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5B70D0
+       mov       rdx,7FF9DA5D7AE0
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
-       jmp       qword ptr [7FF9DA3C4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3E51D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3C4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3C4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E6D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D9840F80
+       mov       r11,7FF9D9860FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA440868
+       mov       rdx,7FF9DA451228
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
-       mov       rdx,7FF9DA440850
+       mov       rdx,7FF9DA451210
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F052C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D15A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F050B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C16670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F052C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D15A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F050B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C16670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D9840F88
+       mov       r11,7FF9D9860FA8
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
-       mov       r11,7FF9D9840F88
+       mov       r11,7FF9D9860FA8
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
-       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5C6608
+       mov       rdx,7FF9DA5B6AC8
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
-       jmp       qword ptr [7FF9DA3D4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3C4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3C4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3C4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E6D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D9850F80
+       mov       r11,7FF9D9840F80
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA4506E0
+       mov       rdx,7FF9DA440868
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
-       mov       rdx,7FF9DA4506C8
+       mov       rdx,7FF9DA440850
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F052C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D15A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9E86B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F050B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C16670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D9850F88
+       mov       r11,7FF9D9840F88
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
-       mov       r11,7FF9D9850F88
+       mov       r11,7FF9D9840F88
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
-       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA39EC88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA42DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5C6608
+       mov       rdx,7FF9DA5C6F68
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
-       jmp       qword ptr [7FF9DA3D4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA39ECE8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA39ED60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA39EBE0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D9850F80
+       mov       r11,7FF9D9850FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA4506E0
+       mov       rdx,7FF9DA440D20
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
-       mov       rdx,7FF9DA4506C8
+       mov       rdx,7FF9DA440D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,0AD
        mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D25A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
        call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,93
        mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D25A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D9850F88
+       mov       r11,7FF9D9850FA8
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
-       mov       r11,7FF9D9850F88
+       mov       r11,7FF9D9850FA8
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
-       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA4640F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5C6608
+       mov       rdx,7FF9DA5D7AE0
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
-       jmp       qword ptr [7FF9DA3D4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3E51D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D9850F80
+       mov       r11,7FF9D9860FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA4506E0
+       mov       rdx,7FF9DA451228
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
-       mov       rdx,7FF9DA4506C8
+       mov       rdx,7FF9DA451210
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D9850F88
+       mov       r11,7FF9D9860FA8
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
-       mov       r11,7FF9D9850F88
+       mov       r11,7FF9D9860FA8
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
-       call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA39EC88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA42DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5B6AC8
+       mov       rdx,7FF9DA5C6F68
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
-       jmp       qword ptr [7FF9DA3C4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA39ECE8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3C4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA39ED60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3C4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA39EBE0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E6D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D9840F80
+       mov       r11,7FF9D9850FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA440868
+       mov       rdx,7FF9DA440D20
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
-       mov       rdx,7FF9DA440850
+       mov       rdx,7FF9DA440D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F052C0]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D15A18
+       mov       rdx,7FF9D9D25A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F050B0]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C16670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F052C0]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,93
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D15A18
+       mov       rdx,7FF9D9D25A50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F050B0]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C16670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D9840F88
+       mov       r11,7FF9D9850FA8
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
-       mov       r11,7FF9D9840F88
+       mov       r11,7FF9D9850FA8
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
-       call      qword ptr [7FF9DA3C4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA434810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA4640F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5B6AC8
+       mov       rdx,7FF9DA5D7AE0
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
-       jmp       qword ptr [7FF9DA3C4F60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3E51D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA3C4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3C4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E6D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D9840F80
+       mov       r11,7FF9D9860FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA440868
+       mov       rdx,7FF9DA451228
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
-       mov       rdx,7FF9DA440850
+       mov       rdx,7FF9DA451210
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9F052C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D15A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F050B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C16670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9F052C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D15A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E86B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9986B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F050B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C16670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D9840F88
+       mov       r11,7FF9D9860FA8
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
-       mov       r11,7FF9D9840F88
+       mov       r11,7FF9D9860FA8
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
-       call      qword ptr [7FF9DA39EC88]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        lea       rcx,[rsi+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       [rbx],bl
        lea       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
-       call      qword ptr [7FF9DA42DFC8]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
+       call      qword ptr [7FF9DA4640F0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
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
-       mov       rdx,7FF9DA5C6F68
+       mov       rdx,7FF9DA5D7AE0
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
-       jmp       qword ptr [7FF9DA39ECE8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
+       jmp       qword ptr [7FF9DA3E51D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Func`1<System.__Canon>, Boolean)
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
-       call      qword ptr [7FF9DA39ED60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
        mov       rcx,rax
        test      rcx,rcx
        je        short M02_L06
 M02_L03:
        lea       r8,[rbx+18]
        mov       rdx,r14
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA39EBE0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M02_L04:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rdi],rcx
        mov       [rax+8],r14d
        jmp       short M02_L09
 M02_L06:
        mov       rcx,rbx
-       call      qword ptr [7FF9D9E7C588]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rcx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rdi
-       mov       r11,7FF9D9850FA0
+       mov       r11,7FF9D9860FA0
        call      qword ptr [r11]
        test      eax,eax
        jne       near ptr M02_L01
        jmp       short M02_L09
 M02_L08:
        mov       rcx,rsi
-       mov       rdx,7FF9DA440D20
+       mov       rdx,7FF9DA451228
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
-       mov       rdx,7FF9DA440D08
+       mov       rdx,7FF9DA451210
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M02_L00
 M02_L12:
-       call      qword ptr [7FF9D9EBFB58]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A50
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9EBF948]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L13:
-       call      qword ptr [7FF9D9EBFB58]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A50
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9EBF948]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L14:
        mov       rcx,rdi
-       mov       r11,7FF9D9850FA8
+       mov       r11,7FF9D9860FA8
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
-       mov       r11,7FF9D9850FA8
+       mov       r11,7FF9D9860FA8
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
-       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA43F450]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C060
+       mov       rdx,7FF9DA619028
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9871080
+       mov       r11,7FF9D9861090
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
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA62C028
+       mov       rdx,7FF9DA618FF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C048
+       mov       rdx,7FF9DA619010
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E66668
+       mov       rdx,7FF9D9E56668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C466E8]
+       call      qword ptr [7FF9D9C366E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D9861098
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
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D9861098
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
-       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA43FDF8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450760
+       mov       rdx,7FF9DA460760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450C68
+       mov       rdx,7FF9DA460C68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA453D20
+       mov       rdx,7FF9DA463D20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450AC0
+       mov       rdx,7FF9DA460AC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
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
-       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E7D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA43F450]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C060
+       mov       rdx,7FF9DA609F50
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9871080
+       mov       r11,7FF9D98510A8
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
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA62C028
+       mov       rdx,7FF9DA609F18
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C048
+       mov       rdx,7FF9DA609F38
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E66668
+       mov       rdx,7FF9D9E46668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C466E8]
+       call      qword ptr [7FF9D9C266E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D98510B0
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
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D98510B0
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
-       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E7D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA43FDF8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA444B88]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450760
+       mov       rdx,7FF9DA4505D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450C68
+       mov       rdx,7FF9DA450AE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA453D20
+       mov       rdx,7FF9DA453B98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450AC0
+       mov       rdx,7FF9DA450938
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C26670]
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
        call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA43F450]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C060
+       mov       rdx,7FF9DA629A28
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9871080
+       mov       r11,7FF9D9871098
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA62C028
+       mov       rdx,7FF9DA6299F0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C048
+       mov       rdx,7FF9DA629A10
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D98710A0
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
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D98710A0
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
-       call      qword ptr [7FF9DA43FDF8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450760
+       mov       rdx,7FF9DA470760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450C68
+       mov       rdx,7FF9DA470C68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA453D20
+       mov       rdx,7FF9DA473D20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450AC0
+       mov       rdx,7FF9DA470AC0
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
        call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA43F450]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464528]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C060
+       mov       rdx,7FF9DA62DEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9871080
+       mov       r11,7FF9D98712D0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA62C028
+       mov       rdx,7FF9DA62DE68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C048
+       mov       rdx,7FF9DA62DE88
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D98712D8
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
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D98712D8
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
-       call      qword ptr [7FF9DA43FDF8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA464ED0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450760
+       mov       rdx,7FF9DA470760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450C68
+       mov       rdx,7FF9DA470C68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA453D20
+       mov       rdx,7FF9DA473D20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450AC0
+       mov       rdx,7FF9DA470AC0
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
-       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA43F450]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C060
+       mov       rdx,7FF9DA6197C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9871080
+       mov       r11,7FF9D98610F0
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
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA62C028
+       mov       rdx,7FF9DA619788
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C048
+       mov       rdx,7FF9DA6197A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E66668
+       mov       rdx,7FF9D9E56668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C466E8]
+       call      qword ptr [7FF9D9C366E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D98610F8
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
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D98610F8
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
-       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA43FDF8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450760
+       mov       rdx,7FF9DA460760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450C68
+       mov       rdx,7FF9DA460C68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA453D20
+       mov       rdx,7FF9DA463D20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450AC0
+       mov       rdx,7FF9DA460AC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
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
-       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA43F450]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5080]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5158]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E4FD8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C060
+       mov       rdx,7FF9DA61A3A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9871080
+       mov       r11,7FF9D9861118
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
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA62C028
+       mov       rdx,7FF9DA61A368
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C048
+       mov       rdx,7FF9DA61A388
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E66668
+       mov       rdx,7FF9D9E56668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C466E8]
+       call      qword ptr [7FF9D9C366E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D9861120
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
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D9861120
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
-       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA43FDF8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450760
+       mov       rdx,7FF9DA460BD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450C68
+       mov       rdx,7FF9DA4610D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA453D20
+       mov       rdx,7FF9DA464190
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450AC0
+       mov       rdx,7FF9DA460F30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
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
        call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA43F450]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3AF780]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3AF858]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3AF6D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C060
+       mov       rdx,7FF9DA62A838
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9871080
+       mov       r11,7FF9D98710A8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA62C028
+       mov       rdx,7FF9DA62A800
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62C048
+       mov       rdx,7FF9DA62A820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D98710B0
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
-       mov       r11,7FF9D9871088
+       mov       r11,7FF9D98710B0
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
-       call      qword ptr [7FF9DA43FDF8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450760
+       mov       rdx,7FF9DA471230
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450C68
+       mov       rdx,7FF9DA471738
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA453D20
+       mov       rdx,7FF9DA4747F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450AC0
+       mov       rdx,7FF9DA471590
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
-       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E7D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3E4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3E4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA619028
+       mov       rdx,7FF9DA609F50
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9861090
+       mov       r11,7FF9D98510A8
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
-       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA618FF0
+       mov       rdx,7FF9DA609F18
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA619010
+       mov       rdx,7FF9DA609F38
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E56668
+       mov       rdx,7FF9D9E46668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C366E8]
+       call      qword ptr [7FF9D9C266E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9861098
+       mov       r11,7FF9D98510B0
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
-       mov       r11,7FF9D9861098
+       mov       r11,7FF9D98510B0
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
-       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E7D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA444B88]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460760
+       mov       rdx,7FF9DA4505D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460C68
+       mov       rdx,7FF9DA450AE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA463D20
+       mov       rdx,7FF9DA453B98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460AC0
+       mov       rdx,7FF9DA450938
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C26670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F152C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D25A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9E96B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F150B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C26670]
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
-       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3E4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3E4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA619028
+       mov       rdx,7FF9DA629A28
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9861090
+       mov       r11,7FF9D9871098
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
-       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA618FF0
+       mov       rdx,7FF9DA6299F0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA619010
+       mov       rdx,7FF9DA629A10
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E56668
+       mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C366E8]
+       call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9861098
+       mov       r11,7FF9D98710A0
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
-       mov       r11,7FF9D9861098
+       mov       r11,7FF9D98710A0
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
-       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460760
+       mov       rdx,7FF9DA470760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460C68
+       mov       rdx,7FF9DA470C68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA463D20
+       mov       rdx,7FF9DA473D20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460AC0
+       mov       rdx,7FF9DA470AC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464528]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3E4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3E4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA619028
+       mov       rdx,7FF9DA62DEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9861090
+       mov       r11,7FF9D98712D0
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
-       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA618FF0
+       mov       rdx,7FF9DA62DE68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA619010
+       mov       rdx,7FF9DA62DE88
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E56668
+       mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C366E8]
+       call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9861098
+       mov       r11,7FF9D98712D8
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
-       mov       r11,7FF9D9861098
+       mov       r11,7FF9D98712D8
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
-       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA464ED0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460760
+       mov       rdx,7FF9DA470760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460C68
+       mov       rdx,7FF9DA470C68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA463D20
+       mov       rdx,7FF9DA473D20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460AC0
+       mov       rdx,7FF9DA470AC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA619028
+       mov       rdx,7FF9DA6197C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9861090
+       mov       r11,7FF9D98610F0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA618FF0
+       mov       rdx,7FF9DA619788
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA619010
+       mov       rdx,7FF9DA6197A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9D9E56668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9D9C366E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9861098
+       mov       r11,7FF9D98610F8
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
-       mov       r11,7FF9D9861098
+       mov       r11,7FF9D98610F8
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
        call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3E4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5080]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5158]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3E4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E4FD8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA619028
+       mov       rdx,7FF9DA61A3A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9861090
+       mov       r11,7FF9D9861118
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA618FF0
+       mov       rdx,7FF9DA61A368
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA619010
+       mov       rdx,7FF9DA61A388
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9D9E56668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9D9C366E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9861098
+       mov       r11,7FF9D9861120
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
-       mov       r11,7FF9D9861098
+       mov       r11,7FF9D9861120
        call      qword ptr [r11]
 M01_L16:
        nop
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
        call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460760
+       mov       rdx,7FF9DA460BD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460C68
+       mov       rdx,7FF9DA4610D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA463D20
+       mov       rdx,7FF9DA464190
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460AC0
+       mov       rdx,7FF9DA460F30
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
-       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3E4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3E4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA619028
+       mov       rdx,7FF9DA62A838
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9861090
+       mov       r11,7FF9D98710A8
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
-       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA618FF0
+       mov       rdx,7FF9DA62A800
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA619010
+       mov       rdx,7FF9DA62A820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E56668
+       mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C366E8]
+       call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9861098
+       mov       r11,7FF9D98710B0
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
-       mov       r11,7FF9D9861098
+       mov       r11,7FF9D98710B0
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
-       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460760
+       mov       rdx,7FF9DA471230
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460C68
+       mov       rdx,7FF9DA471738
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA463D20
+       mov       rdx,7FF9DA4747F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460AC0
+       mov       rdx,7FF9DA471590
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       call      qword ptr [7FF9D9E7D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA609F50
+       mov       rdx,7FF9DA629A28
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D9871098
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
-       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA609F18
+       mov       rdx,7FF9DA6299F0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA609F38
+       mov       rdx,7FF9DA629A10
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E46668
+       mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C266E8]
+       call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98510B0
+       mov       r11,7FF9D98710A0
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
-       mov       r11,7FF9D98510B0
+       mov       r11,7FF9D98710A0
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
-       call      qword ptr [7FF9D9E7D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA444B88]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA4505D8
+       mov       rdx,7FF9DA470760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450AE0
+       mov       rdx,7FF9DA470C68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA453B98
+       mov       rdx,7FF9DA473D20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450938
+       mov       rdx,7FF9DA470AC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C46670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C46670]
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
-       call      qword ptr [7FF9D9E7D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464528]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA609F50
+       mov       rdx,7FF9DA62DEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D98712D0
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
-       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA609F18
+       mov       rdx,7FF9DA62DE68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA609F38
+       mov       rdx,7FF9DA62DE88
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E46668
+       mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C266E8]
+       call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98510B0
+       mov       r11,7FF9D98712D8
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
-       mov       r11,7FF9D98510B0
+       mov       r11,7FF9D98712D8
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
-       call      qword ptr [7FF9D9E7D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA444B88]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA464ED0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA4505D8
+       mov       rdx,7FF9DA470760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450AE0
+       mov       rdx,7FF9DA470C68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA453B98
+       mov       rdx,7FF9DA473D20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450938
+       mov       rdx,7FF9DA470AC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C46670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C46670]
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
-       call      qword ptr [7FF9D9E7D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA609F50
+       mov       rdx,7FF9DA6197C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D98610F0
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
-       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA609F18
+       mov       rdx,7FF9DA619788
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA609F38
+       mov       rdx,7FF9DA6197A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E46668
+       mov       rdx,7FF9D9E56668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C266E8]
+       call      qword ptr [7FF9D9C366E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98510B0
+       mov       r11,7FF9D98610F8
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
-       mov       r11,7FF9D98510B0
+       mov       r11,7FF9D98610F8
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
-       call      qword ptr [7FF9D9E7D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA444B88]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA4505D8
+       mov       rdx,7FF9DA460760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450AE0
+       mov       rdx,7FF9DA460C68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA453B98
+       mov       rdx,7FF9DA463D20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450938
+       mov       rdx,7FF9DA460AC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C36670]
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
-       call      qword ptr [7FF9D9E7D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5080]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5158]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E4FD8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA609F50
+       mov       rdx,7FF9DA61A3A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D9861118
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
-       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA609F18
+       mov       rdx,7FF9DA61A368
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA609F38
+       mov       rdx,7FF9DA61A388
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E46668
+       mov       rdx,7FF9D9E56668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C266E8]
+       call      qword ptr [7FF9D9C366E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98510B0
+       mov       r11,7FF9D9861120
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
-       mov       r11,7FF9D98510B0
+       mov       r11,7FF9D9861120
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
-       call      qword ptr [7FF9D9E7D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA444B88]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA4505D8
+       mov       rdx,7FF9DA460BD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450AE0
+       mov       rdx,7FF9DA4610D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA453B98
+       mov       rdx,7FF9DA464190
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450938
+       mov       rdx,7FF9DA460F30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C36670]
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
-       call      qword ptr [7FF9D9E7D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA4441E0]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3D4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3D4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA609F50
+       mov       rdx,7FF9DA62A838
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D98510A8
+       mov       r11,7FF9D98710A8
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
-       call      qword ptr [7FF9D9E7D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA609F18
+       mov       rdx,7FF9DA62A800
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA609F38
+       mov       rdx,7FF9DA62A820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E46668
+       mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C266E8]
+       call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98510B0
+       mov       r11,7FF9D98710B0
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
-       mov       r11,7FF9D98510B0
+       mov       r11,7FF9D98710B0
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
-       call      qword ptr [7FF9D9E7D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA444B88]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA4505D8
+       mov       rdx,7FF9DA471230
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450AE0
+       mov       rdx,7FF9DA471738
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA453B98
+       mov       rdx,7FF9DA4747F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA450938
+       mov       rdx,7FF9DA471590
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C46670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F152C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,93
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D25A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E96B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F150B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C46670]
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
        call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464528]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA629A28
+       mov       rdx,7FF9DA62DEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9871098
+       mov       r11,7FF9D98712D0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA6299F0
+       mov       rdx,7FF9DA62DE68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA629A10
+       mov       rdx,7FF9DA62DE88
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D98712D8
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
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D98712D8
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
-       call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA464ED0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
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
-       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3F4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3F4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3F4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA629A28
+       mov       rdx,7FF9DA6197C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9871098
+       mov       r11,7FF9D98610F0
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
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA6299F0
+       mov       rdx,7FF9DA619788
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA629A10
+       mov       rdx,7FF9DA6197A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E66668
+       mov       rdx,7FF9D9E56668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C466E8]
+       call      qword ptr [7FF9D9C366E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D98610F8
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
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D98610F8
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
-       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470760
+       mov       rdx,7FF9DA460760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470C68
+       mov       rdx,7FF9DA460C68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA473D20
+       mov       rdx,7FF9DA463D20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470AC0
+       mov       rdx,7FF9DA460AC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
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
-       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3F4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5080]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3F4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5158]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3F4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E4FD8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA629A28
+       mov       rdx,7FF9DA61A3A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9871098
+       mov       r11,7FF9D9861118
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
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA6299F0
+       mov       rdx,7FF9DA61A368
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA629A10
+       mov       rdx,7FF9DA61A388
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E66668
+       mov       rdx,7FF9D9E56668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C466E8]
+       call      qword ptr [7FF9D9C366E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D9861120
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
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D9861120
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
-       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470760
+       mov       rdx,7FF9DA460BD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470C68
+       mov       rdx,7FF9DA4610D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA473D20
+       mov       rdx,7FF9DA464190
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470AC0
+       mov       rdx,7FF9DA460F30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
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
        call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3F4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3F4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3F4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA629A28
+       mov       rdx,7FF9DA62A838
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9871098
+       mov       r11,7FF9D98710A8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA6299F0
+       mov       rdx,7FF9DA62A800
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA629A10
+       mov       rdx,7FF9DA62A820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D98710B0
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
-       mov       r11,7FF9D98710A0
+       mov       r11,7FF9D98710B0
        call      qword ptr [r11]
 M01_L16:
        nop
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
        call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470760
+       mov       rdx,7FF9DA471230
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470C68
+       mov       rdx,7FF9DA471738
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA473D20
+       mov       rdx,7FF9DA4747F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470AC0
+       mov       rdx,7FF9DA471590
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
-       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA464528]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3F4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3F4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3F4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62DEA0
+       mov       rdx,7FF9DA6197C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D98712D0
+       mov       r11,7FF9D98610F0
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
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA62DE68
+       mov       rdx,7FF9DA619788
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62DE88
+       mov       rdx,7FF9DA6197A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E66668
+       mov       rdx,7FF9D9E56668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C466E8]
+       call      qword ptr [7FF9D9C366E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98712D8
+       mov       r11,7FF9D98610F8
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
-       mov       r11,7FF9D98712D8
+       mov       r11,7FF9D98610F8
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
-       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA464ED0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470760
+       mov       rdx,7FF9DA460760
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470C68
+       mov       rdx,7FF9DA460C68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA473D20
+       mov       rdx,7FF9DA463D20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470AC0
+       mov       rdx,7FF9DA460AC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
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
-       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA464528]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3F4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5080]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3F4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5158]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3F4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E4FD8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62DEA0
+       mov       rdx,7FF9DA61A3A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D98712D0
+       mov       r11,7FF9D9861118
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
-       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA62DE68
+       mov       rdx,7FF9DA61A368
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62DE88
+       mov       rdx,7FF9DA61A388
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E66668
+       mov       rdx,7FF9D9E56668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C466E8]
+       call      qword ptr [7FF9D9C366E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98712D8
+       mov       r11,7FF9D9861120
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
-       mov       r11,7FF9D98712D8
+       mov       r11,7FF9D9861120
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
-       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA464ED0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470760
+       mov       rdx,7FF9DA460BD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470C68
+       mov       rdx,7FF9DA4610D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA473D20
+       mov       rdx,7FF9DA464190
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470AC0
+       mov       rdx,7FF9DA460F30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
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
        call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA464528]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3F4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3F4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3F4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62DEA0
+       mov       rdx,7FF9DA62A838
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D98712D0
+       mov       r11,7FF9D98710A8
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA62DE68
+       mov       rdx,7FF9DA62A800
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA62DE88
+       mov       rdx,7FF9DA62A820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98712D8
+       mov       r11,7FF9D98710B0
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
-       mov       r11,7FF9D98712D8
+       mov       r11,7FF9D98710B0
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
-       call      qword ptr [7FF9DA464ED0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470760
+       mov       rdx,7FF9DA471230
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470C68
+       mov       rdx,7FF9DA471738
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA473D20
+       mov       rdx,7FF9DA4747F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA470AC0
+       mov       rdx,7FF9DA471590
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
        call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3E4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3E5080]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3E5158]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3E4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3E4FD8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA6197C0
+       mov       rdx,7FF9DA61A3A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D98610F0
+       mov       r11,7FF9D9861118
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L03
        mov       rcx,[rbp+10]
        call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA619788
+       mov       rdx,7FF9DA61A368
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA6197A8
+       mov       rdx,7FF9DA61A388
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
        mov       ecx,0AD8
        mov       rdx,7FF9D9E56668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FF9D9C366E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98610F8
+       mov       r11,7FF9D9861120
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
-       mov       r11,7FF9D98610F8
+       mov       r11,7FF9D9861120
        call      qword ptr [r11]
 M01_L16:
        nop
        lea       rcx,[rsp+28]
        mov       r8,rsi
        mov       r9,rdi
        call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460760
+       mov       rdx,7FF9DA460BD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460C68
+       mov       rdx,7FF9DA4610D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA463D20
+       mov       rdx,7FF9DA464190
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460AC0
+       mov       rdx,7FF9DA460F30
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
-       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3E4F00]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3E4E58]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA6197C0
+       mov       rdx,7FF9DA62A838
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D98610F0
+       mov       r11,7FF9D98710A8
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
-       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA619788
+       mov       rdx,7FF9DA62A800
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA6197A8
+       mov       rdx,7FF9DA62A820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E56668
+       mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C366E8]
+       call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D98610F8
+       mov       r11,7FF9D98710B0
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
-       mov       r11,7FF9D98610F8
+       mov       r11,7FF9D98710B0
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
-       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460760
+       mov       rdx,7FF9DA471230
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460C68
+       mov       rdx,7FF9DA471738
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA463D20
+       mov       rdx,7FF9DA4747F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460AC0
+       mov       rdx,7FF9DA471590
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       call      qword ptr [7FF9D9E8D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9E9D5C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,[rbx+288]
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Concurrent.ConcurrentBag`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9DA454810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA464810]; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions.RemoveRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.ConcurrentBag`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9DA3E5080]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9DA3F5170]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp+10]
        lea       rcx,[rcx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DA3E5158]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
+       call      qword ptr [7FF9DA3F5248]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
-       call      qword ptr [7FF9DA3E4FD8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
+       call      qword ptr [7FF9DA3F50C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
 M01_L05:
        cmp       r14,r15
        jne       short M01_L08
        mov       [rax+8],r13d
        jmp       short M01_L09
 M01_L07:
        mov       rcx,rsi
-       mov       rdx,7FF9DA61A3A0
+       mov       rdx,7FF9DA62A838
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       short M01_L04
 M01_L08:
        mov       rcx,rbx
-       mov       r11,7FF9D9861118
+       mov       r11,7FF9D98710A8
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
-       call      qword ptr [7FF9D9E8D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
+       call      qword ptr [7FF9D9E9D650]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
        mov       rdi,rax
        jmp       near ptr M01_L01
 M01_L12:
        mov       rcx,rdx
-       mov       rdx,7FF9DA61A368
+       mov       rdx,7FF9DA62A800
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L00
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9DA61A388
+       mov       rdx,7FF9DA62A820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
        jmp       near ptr M01_L02
 M01_L14:
        mov       ecx,0AD8
-       mov       rdx,7FF9D9E56668
+       mov       rdx,7FF9D9E66668
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF9D9C366E8]
+       call      qword ptr [7FF9D9C466E8]
        int       3
 M01_L15:
        mov       rcx,rbx
-       mov       r11,7FF9D9861120
+       mov       r11,7FF9D98710B0
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
-       mov       r11,7FF9D9861120
+       mov       r11,7FF9D98710B0
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
-       call      qword ptr [7FF9D9E8D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9D9E9D5A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
-       call      qword ptr [7FF9DA4551B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
+       call      qword ptr [7FF9DA4651B8]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
        mov       rax,[rbp+10]
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460BD0
+       mov       rdx,7FF9DA471230
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L00
 M02_L05:
        mov       rcx,rbx
-       mov       rdx,7FF9DA4610D8
+       mov       rdx,7FF9DA471738
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L02
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9DA464190
+       mov       rdx,7FF9DA4747F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
        jmp       short M02_L03
 M02_L07:
        mov       rcx,rbx
-       mov       rdx,7FF9DA460F30
+       mov       rdx,7FF9DA471590
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       near ptr M02_L01
 M02_L08:
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M02_L09:
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,93
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA264078]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9EBFB58]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9E95EE0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9C8F048
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9E95EE0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9EBF948]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C26670]
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
-       mov       rdx,7FF9DA5D6E90
+       mov       rdx,7FF9DA5C6400
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D9994348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D6F40
+       mov       rdx,7FF9DA5C64B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A4DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5D6EA0
+       mov       rdx,7FF9DA5C6410
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
-       call      qword ptr [7FF9D9C34F30]
+       call      qword ptr [7FF9D9C24F30]
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
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C0EF40]
+       call      qword ptr [7FF9D9BFEF40]
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
-       mov       rax,3001F980008
+       mov       rax,1B5B49A0008
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
call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
        mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C36670]
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
-       mov       rdx,7FF9DA5D6E90
+       mov       rdx,7FF9DA5D5F00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D6F40
+       mov       rdx,7FF9DA5D5FB0
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
-       mov       rdx,7FF9DA5D6EA0
+       mov       rdx,7FF9DA5D5F10
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
-       mov       rax,3001F980008
+       mov       rax,1DCBA290008
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
-       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5D6E90
+       mov       rdx,7FF9DA5E5E58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D6F40
+       mov       rdx,7FF9DA5E5F08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5D6EA0
+       mov       rdx,7FF9DA5E5E68
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
-       call      qword ptr [7FF9D9C34F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C0EF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,3001F980008
+       mov       rax,193EAE50008
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
-       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5D6E90
+       mov       rdx,7FF9DA5E5D00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D6F40
+       mov       rdx,7FF9DA5E5DB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5D6EA0
+       mov       rdx,7FF9DA5E5D10
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
-       call      qword ptr [7FF9D9C34F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C0EF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,3001F980008
+       mov       rax,2F60DF80008
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
call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
        mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C36670]
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
-       mov       rdx,7FF9DA5D6E90
+       mov       rdx,7FF9DA5D60B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D6F40
+       mov       rdx,7FF9DA5D6160
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
-       mov       rdx,7FF9DA5D6EA0
+       mov       rdx,7FF9DA5D60C0
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
-       mov       rax,3001F980008
+       mov       rax,25C7C010008
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
-       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5D6E90
+       mov       rdx,7FF9DA5E6698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D6F40
+       mov       rdx,7FF9DA5E6748
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5D6EA0
+       mov       rdx,7FF9DA5E66A8
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
-       call      qword ptr [7FF9D9C34F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C0EF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,3001F980008
+       mov       rax,301C0C60008
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
-       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5D6E90
+       mov       rdx,7FF9DA5E6BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D6F40
+       mov       rdx,7FF9DA5E6C90
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5D6EA0
+       mov       rdx,7FF9DA5E6BF0
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
-       call      qword ptr [7FF9D9C34F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C0EF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,3001F980008
+       mov       rax,2B2E67C0008
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
-       call      qword ptr [7FF9DA264078]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9EBFB58]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E95EE0
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9C8F048
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E95EE0
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9EBF948]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C36670]
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
-       mov       rdx,7FF9DA5C6400
+       mov       rdx,7FF9DA5D5F00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D9994348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5C64B0
+       mov       rdx,7FF9DA5D5FB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A4DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5C6410
+       mov       rdx,7FF9DA5D5F10
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
-       call      qword ptr [7FF9D9C24F30]
+       call      qword ptr [7FF9D9C34F30]
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
-       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9BFEF40]
+       call      qword ptr [7FF9D9C0EF40]
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
-       mov       rax,1B5B49A0008
+       mov       rax,1DCBA290008
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
-       call      qword ptr [7FF9DA264078]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9EBFB58]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E95EE0
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9C8F048
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E95EE0
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9EBF948]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5C6400
+       mov       rdx,7FF9DA5E5E58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D9994348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5C64B0
+       mov       rdx,7FF9DA5E5F08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A4DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5C6410
+       mov       rdx,7FF9DA5E5E68
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
-       call      qword ptr [7FF9D9C24F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9BFEF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,1B5B49A0008
+       mov       rax,193EAE50008
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
-       call      qword ptr [7FF9DA264078]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9EBFB58]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E95EE0
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9C8F048
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E95EE0
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9EBF948]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5C6400
+       mov       rdx,7FF9DA5E5D00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D9994348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5C64B0
+       mov       rdx,7FF9DA5E5DB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A4DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5C6410
+       mov       rdx,7FF9DA5E5D10
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
-       call      qword ptr [7FF9D9C24F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9BFEF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,1B5B49A0008
+       mov       rax,2F60DF80008
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
-       call      qword ptr [7FF9DA264078]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9EBFB58]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E95EE0
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9C8F048
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E95EE0
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9EBF948]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C36670]
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
-       mov       rdx,7FF9DA5C6400
+       mov       rdx,7FF9DA5D60B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D9994348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5C64B0
+       mov       rdx,7FF9DA5D6160
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A4DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5C6410
+       mov       rdx,7FF9DA5D60C0
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
-       call      qword ptr [7FF9D9C24F30]
+       call      qword ptr [7FF9D9C34F30]
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
-       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9BFEF40]
+       call      qword ptr [7FF9D9C0EF40]
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
-       mov       rax,1B5B49A0008
+       mov       rax,25C7C010008
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
-       call      qword ptr [7FF9DA264078]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9EBFB58]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E95EE0
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9C8F048
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E95EE0
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9EBF948]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5C6400
+       mov       rdx,7FF9DA5E6698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D9994348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5C64B0
+       mov       rdx,7FF9DA5E6748
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A4DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5C6410
+       mov       rdx,7FF9DA5E66A8
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
-       call      qword ptr [7FF9D9C24F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9BFEF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,1B5B49A0008
+       mov       rax,301C0C60008
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
-       call      qword ptr [7FF9DA264078]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9EBFB58]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9E95EE0
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9C8F048
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9E95EE0
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D9996B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9EBF948]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C26670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5C6400
+       mov       rdx,7FF9DA5E6BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D9994348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5C64B0
+       mov       rdx,7FF9DA5E6C90
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A4DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5C6410
+       mov       rdx,7FF9DA5E6BF0
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
-       call      qword ptr [7FF9D9C24F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9BFEF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,1B5B49A0008
+       mov       rax,2B2E67C0008
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
-       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5D5F00
+       mov       rdx,7FF9DA5E5E58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D5FB0
+       mov       rdx,7FF9DA5E5F08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5D5F10
+       mov       rdx,7FF9DA5E5E68
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
-       call      qword ptr [7FF9D9C34F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C0EF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,1DCBA290008
+       mov       rax,193EAE50008
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
-       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5D5F00
+       mov       rdx,7FF9DA5E5D00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D5FB0
+       mov       rdx,7FF9DA5E5DB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5D5F10
+       mov       rdx,7FF9DA5E5D10
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
-       call      qword ptr [7FF9D9C34F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C0EF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,1DCBA290008
+       mov       rax,2F60DF80008
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
call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
        mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C36670]
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
-       mov       rdx,7FF9DA5D5F00
+       mov       rdx,7FF9DA5D60B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D5FB0
+       mov       rdx,7FF9DA5D6160
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
-       mov       rdx,7FF9DA5D5F10
+       mov       rdx,7FF9DA5D60C0
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
-       mov       rax,1DCBA290008
+       mov       rax,25C7C010008
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
-       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5D5F00
+       mov       rdx,7FF9DA5E6698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D5FB0
+       mov       rdx,7FF9DA5E6748
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5D5F10
+       mov       rdx,7FF9DA5E66A8
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
-       call      qword ptr [7FF9D9C34F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C0EF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,1DCBA290008
+       mov       rax,301C0C60008
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
-       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5D5F00
+       mov       rdx,7FF9DA5E6BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D5FB0
+       mov       rdx,7FF9DA5E6C90
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5D5F10
+       mov       rdx,7FF9DA5E6BF0
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
-       call      qword ptr [7FF9D9C34F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C0EF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,1DCBA290008
+       mov       rax,2B2E67C0008
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
call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
        mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5E5E58
+       mov       rdx,7FF9DA5E5D00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5E5F08
+       mov       rdx,7FF9DA5E5DB0
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
-       mov       rdx,7FF9DA5E5E68
+       mov       rdx,7FF9DA5E5D10
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
-       mov       rax,193EAE50008
+       mov       rax,2F60DF80008
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
-       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
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
-       mov       rdx,7FF9DA5E5E58
+       mov       rdx,7FF9DA5D60B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5E5F08
+       mov       rdx,7FF9DA5D6160
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5E5E68
+       mov       rdx,7FF9DA5D60C0
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
-       call      qword ptr [7FF9D9C44F30]
+       call      qword ptr [7FF9D9C34F30]
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
-       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C1EF40]
+       call      qword ptr [7FF9D9C0EF40]
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
-       mov       rax,193EAE50008
+       mov       rax,25C7C010008
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
call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
        mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5E5E58
+       mov       rdx,7FF9DA5E6698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5E5F08
+       mov       rdx,7FF9DA5E6748
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
-       mov       rdx,7FF9DA5E5E68
+       mov       rdx,7FF9DA5E66A8
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
-       mov       rax,193EAE50008
+       mov       rax,301C0C60008
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
call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
        mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5E5E58
+       mov       rdx,7FF9DA5E6BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5E5F08
+       mov       rdx,7FF9DA5E6C90
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
-       mov       rdx,7FF9DA5E5E68
+       mov       rdx,7FF9DA5E6BF0
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
-       mov       rax,193EAE50008
+       mov       rax,2B2E67C0008
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
-       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F352C0]
+       call      qword ptr [7FF9D9F252C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D45A18
+       mov       rdx,7FF9D9D35A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EB6B00
+       mov       rdx,7FF9D9EA6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F350B0]
+       call      qword ptr [7FF9D9F250B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C46670]
+       call      qword ptr [7FF9D9C36670]
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
-       mov       rdx,7FF9DA5E5D00
+       mov       rdx,7FF9DA5D60B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5E5DB0
+       mov       rdx,7FF9DA5D6160
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5E5D10
+       mov       rdx,7FF9DA5D60C0
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
-       call      qword ptr [7FF9D9C44F30]
+       call      qword ptr [7FF9D9C34F30]
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
-       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C1EF40]
+       call      qword ptr [7FF9D9C0EF40]
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
-       mov       rax,2F60DF80008
+       mov       rax,25C7C010008
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
call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
        mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5E5D00
+       mov       rdx,7FF9DA5E6698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5E5DB0
+       mov       rdx,7FF9DA5E6748
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
-       mov       rdx,7FF9DA5E5D10
+       mov       rdx,7FF9DA5E66A8
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
-       mov       rax,2F60DF80008
+       mov       rax,301C0C60008
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
call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
        mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5E5D00
+       mov       rdx,7FF9DA5E6BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5E5DB0
+       mov       rdx,7FF9DA5E6C90
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
-       mov       rdx,7FF9DA5E5D10
+       mov       rdx,7FF9DA5E6BF0
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
-       mov       rax,2F60DF80008
+       mov       rax,2B2E67C0008
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
-       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5D60B0
+       mov       rdx,7FF9DA5E6698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D6160
+       mov       rdx,7FF9DA5E6748
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5D60C0
+       mov       rdx,7FF9DA5E66A8
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
-       call      qword ptr [7FF9D9C34F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C0EF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,25C7C010008
+       mov       rax,301C0C60008
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
-       call      qword ptr [7FF9DA276070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9DA286070]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF9D9F252C0]
+       call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
-       mov       rdx,7FF9D9D35A18
+       mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9D9EA6B00
+       mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9D99A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9D9F250B0]
+       call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9D9C36670]
+       call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5D60B0
+       mov       rdx,7FF9DA5E6BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9D99A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5D6160
+       mov       rdx,7FF9DA5E6C90
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9D9A5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9D9A6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       mov       rdx,7FF9DA5D60C0
+       mov       rdx,7FF9DA5E6BF0
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
-       call      qword ptr [7FF9D9C34F30]
+       call      qword ptr [7FF9D9C44F30]
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
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9D9A55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9D9A65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF9D9C0EF40]
+       call      qword ptr [7FF9D9C1EF40]
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
-       mov       rax,25C7C010008
+       mov       rax,2B2E67C0008
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
call      qword ptr [7FF9D9F352C0]
        mov       ecx,0AD
        mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1446
        mov       rdx,7FF9D9D45A18
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9D9EB6B00
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9D99B6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9D9F350B0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9D9C46670]
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
-       mov       rdx,7FF9DA5E6698
+       mov       rdx,7FF9DA5E6BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9D99B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF9DA5E6748
+       mov       rdx,7FF9DA5E6C90
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
-       mov       rdx,7FF9DA5E66A8
+       mov       rdx,7FF9DA5E6BF0
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
-       mov       rax,301C0C60008
+       mov       rax,2B2E67C0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
