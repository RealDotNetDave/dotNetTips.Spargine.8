## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetDescription()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rbx+128]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      qword ptr [7FFBE6A5DB90]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
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
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
; 		input = input.ArgumentDefined();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _descriptionCache.GetOrAdd(input, key =>
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		{
; 		 
; 			var field = key.GetType().GetField(key.ToString());
; 			                                                   
; 			var attributes = (EnumMemberAttribute[])field.GetCustomAttributes(typeof(EnumMemberAttribute), false);
; 			                                                                                                      
; 			return attributes.Length > 0 ? attributes[0].Value : key.ToString();
; 			                                                                    
; 		});
; 		   
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       rcx,rbx
       xor       eax,eax
       test      rcx,rcx
       setne     al
       test      eax,eax
       je        near ptr M01_L04
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
       mov       rdx,rbx
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M01_L06
       mov       rcx,262B880F308
       mov       rsi,[rcx]
       mov       rcx,262B880F220
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
M01_L00:
       mov       r14,[rdi+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [rdi+15],0
       je        short M01_L03
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M01_L01:
       lea       rdx,[rbp-30]
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rbx
       mov       r9d,r15d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFBE65E4FD8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L10
M01_L02:
       mov       rax,[rbp-30]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rdx,rbx
       mov       r11,7FFBE6000A30
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FFBE66C44C8]
       mov       ecx,1A5C
       mov       rdx,7FFBE64D5A58
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1ADC
       mov       rdx,7FFBE64D5A58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBE6146B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEA
       mov       rdx,7FFBE64D5A58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBE6146B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFBE66C42B8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFBE63D6670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L05:
       mov       ecx,2BD
       mov       rdx,7FFBE5FF4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBE63D66E8]
       int       3
M01_L06:
       call      qword ptr [7FFBE66C4378]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L07
       call      qword ptr [7FFBE66C42D0]
       mov       r14,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2A34A658180
       mov       r8,r14
       call      qword ptr [7FFBE61FD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,262B880F300
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFBE6A59C80
       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,262B880F308
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L09:
       mov       ecx,0BB4
       mov       rdx,7FFBE65DA640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBE6826190]
       int       3
M01_L10:
       mov       byte ptr [rbp-38],1
       mov       [rbp-34],r15d
       mov       rdx,rbx
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-30]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,[rbp-38]
       mov       rcx,rdi
       call      qword ptr [7FFBE65E50C8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M01_L02
; Total bytes of code 667
```

