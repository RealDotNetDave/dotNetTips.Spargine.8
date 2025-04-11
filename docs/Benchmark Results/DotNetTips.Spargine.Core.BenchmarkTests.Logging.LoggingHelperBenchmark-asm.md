## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.RetrieveAllExceptionMessages()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.ArithmeticException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       mov       rcx,277DC6D4840
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+74],80131501
       mov       dword ptr [rsi+74],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rcx,277DC6D4868
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
       mov       dword ptr [rdi+74],80004003
       mov       rcx,rdi
       call      qword ptr [7FFF4CF64948]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptionMessages(System.Exception)
       mov       [rsp+28],rax
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
; Total bytes of code 202
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptionMessages(System.Exception)
; 		exception = exception.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var exceptions = RetrieveAllExceptions(exception);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var messages = exceptions.Select(ex => ex.Message).ToList();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return messages.AsReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        near ptr M01_L02
       call      qword ptr [7FFF4CF64960]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       rbx,rax
       mov       r8,2374A80AE30
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M01_L03
M01_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      qword ptr [7FFF4CAA57E8]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFF4C664348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
       mov       r11,7FFF4C520AE0
       call      qword ptr [r11]
       mov       rbx,rax
M01_L01:
       cmp       [rbx],bl
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       call      qword ptr [7FFF4CB944C8]
       mov       ecx,1A48
       mov       rdx,7FFF4C98B8E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFF4C98B8E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF4C666B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEA
       mov       rdx,7FFF4C98B8E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF4C666B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF4CB942B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF4C7E6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2374A80AE18
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFF4CF60A38
       call      qword ptr [7FFF4C664210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2374A80AE30
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,10
       call      qword ptr [7FFF4C967A38]
       int       3
M01_L05:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFF4C71DFC8]
       jmp       near ptr M01_L01
; Total bytes of code 435
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.RetrieveAllExceptions()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.ArithmeticException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       mov       rcx,1EA4E5B4840
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+74],80131501
       mov       dword ptr [rsi+74],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rcx,1EA4E5B4868
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
       mov       dword ptr [rdi+74],80004003
       mov       rcx,rdi
       call      qword ptr [7FFF4CF54168]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       [rsp+28],rax
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
; Total bytes of code 202
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
; 		exception = exception.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var collection = new List<Exception>();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var currentException = exception; currentException is not null; currentException = currentException.InnerException)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			collection.Add(currentException);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.AsReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L02
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1A9BC401F98
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L00:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L03
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       movsxd    rdx,edx
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
M01_L01:
       mov       rbx,[rbx+20]
       test      rbx,rbx
       jne       short M01_L00
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       call      qword ptr [7FFF4CB844C8]
       mov       ecx,1A48
       mov       rdx,7FFF4C97B8E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1AC2
       mov       rdx,7FFF4C97B8E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF4C656B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEA
       mov       rdx,7FFF4C97B8E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF4C656B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF4CB842B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF4C7D6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF4C70E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L01
; Total bytes of code 308
```

