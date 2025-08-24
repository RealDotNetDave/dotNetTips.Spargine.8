## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
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
       mov       rcx,21CF9B94A00
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+74],80131501
       mov       dword ptr [rsi+74],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rcx,21CF9B94A28
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
       mov       dword ptr [rdi+74],80004003
       mov       rcx,rdi
       call      qword ptr [7FF9B3774600]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptionMessages(System.Exception)
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
       call      qword ptr [7FF9B3774618]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       rbx,rax
       mov       r8,1DC67C08E78
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M01_L03
M01_L00:
       mov       rdx,rbx
       mov       rcx,7FF9B3761DC0
       call      qword ptr [7FF9B32B5008]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider<System.String>
       call      qword ptr [7FF9B2E74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
       mov       r11,7FF9B2D30A68
       call      qword ptr [r11]
       mov       rbx,rax
M01_L01:
       cmp       [rbx],bl
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
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
       call      qword ptr [7FF9B333F990]
       mov       ecx,1B8F
       mov       rdx,7FF9B318BC10
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9B318BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF9B318BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9B333F780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9B2FF6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Func<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1DC67C08E60
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<RetrieveAllExceptionMessages>b__18_0(System.Exception)
       call      qword ptr [7FF9B2E74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DC67C08E78
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,10
       call      qword ptr [7FF9B3167A38]
       int       3
M01_L05:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9B2F2DFC8]
       jmp       near ptr M01_L01
; Total bytes of code 435
```

## .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
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
       mov       rcx,197C9444A00
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+74],80131501
       mov       dword ptr [rsi+74],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rcx,197C9444A28
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
       mov       dword ptr [rdi+74],80004003
       mov       rcx,rdi
       call      qword ptr [7FF9B3754618]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
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
       mov       rcx,offset MT_System.Collections.Generic.List<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1573B401FA0
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
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
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
       call      qword ptr [7FF9B331F990]
       mov       ecx,1B8F
       mov       rdx,7FF9B316BC10
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1C09
       mov       rdx,7FF9B316BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF9B316BC10
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9B331F780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9B2FD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9B2F0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L01
; Total bytes of code 308
```

