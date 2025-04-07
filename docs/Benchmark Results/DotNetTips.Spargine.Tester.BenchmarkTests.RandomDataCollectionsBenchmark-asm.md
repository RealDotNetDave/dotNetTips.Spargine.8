## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L09
M00_L00:
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFC486EDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFC48766130]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFC48D1E1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r8,[rsp+20]
       mov       rdx,r8
       mov       r14,[rdx]
       mov       r15,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r14,r15
       jne       near ptr M00_L12
       mov       [r8+8],eax
M00_L03:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFC48D1E1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFC48D1E1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L14
       mov       r8,[rsp+20]
       mov       [r8+10],eax
M00_L05:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L15
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L06:
       add       ebp,1
       jo        short M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFC486E47B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFC4893CC30]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFC4893CA50]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1A751353760
       mov       r8,r15
       call      qword ptr [7FFC486ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFC484F0F90
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFC484F0F98
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFC484F0FA0
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFC486EE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L06
; Total bytes of code 569
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M01_L02
       test      ebx,ebx
       je        short M01_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L00
       mov       [rsp+28],rdx
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFC48C1D040
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+28],rax
M01_L01:
       movsxd    rdx,ebx
       mov       rcx,[rsp+28]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFC488E5B60]
       int       3
M01_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFC48C1D030
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 187
```
```assembly
; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       call      qword ptr [7FFC48586E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFC48634390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M02_L00:
       mov       rax,r8
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 75
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
       jge       near ptr M03_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M03_L06
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
M03_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M03_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCED883670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M03_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
M03_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M03_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M03_L00
       add       eax,ebx
M03_L03:
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
M03_L04:
       call      qword ptr [7FFC48D647C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC491B65B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4863F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       mov       eax,ebx
       jmp       short M03_L03
; Total bytes of code 366
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M04_L01
       mov       edx,[rdx+8]
       add       edx,edx
M04_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFC486EDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       edx,4
       jmp       short M04_L00
; Total bytes of code 100
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+278]
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       eax,eax
       test      ecx,ecx
       setg      al
       mov       edx,eax
       test      eax,eax
       je        short M00_L02
M00_L00:
       test      edx,edx
       je        short M00_L03
M00_L01:
       call      qword ptr [7FFC48FF7BD0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       movzx     eax,byte ptr [rsp+30]
       test      al,al
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFC486D47B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFC4892CC30]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFC4892CA50]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1EFC9B83760
       mov       r8,rbx
       call      qword ptr [7FFC486DD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new Stack<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length - 1)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Push(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.ToList().ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       ebx,ecx
       lea       rcx,[rbp-0B0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L11
M01_L00:
       test      eax,eax
       je        near ptr M01_L12
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L14
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rdi
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L09
       mov       rdx,1AF37C04D88
       mov       r15,[rdx]
       mov       [rbp-70],r15
M01_L02:
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-44],edx
       lea       r12,[rbp-44]
       mov       [rbp-68],r12
M01_L03:
       mov       rdx,r12
       mov       [rbp-50],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0A0],rax
       lea       rax,[M01_L04]
       mov       [rbp-88],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFCED883670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L05
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-0A8]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L16
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,30
       mov       r12,[rbp-68]
       ja        near ptr M01_L03
       cmp       ecx,32
       jae       near ptr M01_L17
       mov       ecx,ecx
       shl       rcx,4
       mov       r13,[rbp-60]
       lea       rcx,[r13+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFC48FF7BA0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-58]
       mov       r13d,[rdi+10]
       mov       rcx,[rdi+8]
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M01_L15
       mov       edx,r13d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       inc       r13d
       mov       [rdi+10],r13d
M01_L06:
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,ebx
       mov       r15,[rbp-70]
       jl        short M01_L08
M01_L07:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC486DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       mov       rdi,[rbp-58]
       jmp       short M01_L07
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC486D47B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFC4892CC30]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFC4892CA50]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1EFC9B83760
       mov       r8,rdi
       call      qword ptr [7FFC486DD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFC488C0658
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFC490770F0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC48FF7DC8]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFC48D647C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 731
```

