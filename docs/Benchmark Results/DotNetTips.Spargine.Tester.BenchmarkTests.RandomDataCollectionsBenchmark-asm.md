## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE9877DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFE987F6130]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFE98DAE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFE98DAE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFE98DAE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFE987747B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFE989CCC30]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFE989CCA50]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2E3048A3760
       mov       r8,r15
       call      qword ptr [7FFE9877D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFE98580F90
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFE98580F98
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFE98580FA0
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFE9877E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFE98D000F8
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
       call      qword ptr [7FFE98975B60]
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
       mov       rdx,7FFE98D000E8
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
       call      qword ptr [7FFE98616E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFE986C4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FFF1E7B3670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFEF857A0DC],0
       je        short M03_L02
       call      qword ptr [7FFEF856A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFE98DF47C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE99246250]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE986CF708]
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
       call      qword ptr [7FFE9877DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE9878DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,offset MD_System.Activator.CreateInstance[[DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       call      qword ptr [7FFE98806130]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+20],rax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFE98DBE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFE98DBE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r14,r15
       jne       near ptr M00_L13
       mov       r8,[rsp+20]
       mov       [r8+0C],eax
M00_L04:
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFE98DBE1A8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFE987847B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFE989DCC30]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7FFE989DCA50]
       mov       r15,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,290CBE93760
       mov       r8,r15
       call      qword ptr [7FFE9878D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,r8
       mov       edx,eax
       mov       r11,7FFE98590F90
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFE98590F98
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,[rsp+20]
       mov       edx,eax
       mov       r11,7FFE98590FA0
       call      qword ptr [r11]
       mov       r8,[rsp+20]
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFE9878E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFE98D10010
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
       call      qword ptr [7FFE98985B60]
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
       mov       rdx,7FFE98D10000
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
       call      qword ptr [7FFE98626E20]; System.RuntimeType.CreateInstanceOfT()
       mov       r8,rax
       test      r8,r8
       je        short M02_L00
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       cmp       [r8],rcx
       je        short M02_L00
       mov       rdx,rax
       call      qword ptr [7FFE986D4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rax,7FFF1E7B3670
       call      rax
M03_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFEF857A0DC],0
       je        short M03_L02
       call      qword ptr [7FFEF856A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFE98E047C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE992565B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE986DF708]
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
       call      qword ptr [7FFE9878DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE99087BD0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
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
       call      qword ptr [7FFE987647B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFE989BCC30]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFE989BCA50]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22DA1D63760
       mov       r8,rbx
       call      qword ptr [7FFE9876D470]
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
       mov       rdx,1ED10002D90
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
       mov       rax,7FFF1E7B3670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFEF857A0DC],0
       je        short M01_L05
       call      qword ptr [7FFEF856A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFE99087BA0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFE9876DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFE987647B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFE989BCC30]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFE989BCA50]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22DA1D63760
       mov       r8,rdi
       call      qword ptr [7FFE9876D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFE98950658
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE991070F0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFE99087DC8]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFE98DE47C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 731
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE990A7BD0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
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
       call      qword ptr [7FFE987847B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFE989DCC30]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFE989DCA50]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1E529FD3760
       mov       r8,rbx
       call      qword ptr [7FFE9878D470]
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
       mov       rdx,1A498002D90
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
       mov       rax,7FFF1E7B3670
       call      rax
M01_L04:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFEF857A0DC],0
       je        short M01_L05
       call      qword ptr [7FFEF856A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFE990A7BA0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
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
       call      qword ptr [7FFE9878DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFE987847B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FFE989DCC30]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L13
       call      qword ptr [7FFE989DCA50]
       mov       rdi,rax
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1E529FD3760
       mov       r8,rdi
       call      qword ptr [7FFE9878D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,87B
       mov       rdx,7FFE98970658
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE991270F0]
       int       3
M01_L15:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFE990A7DC8]
       jmp       near ptr M01_L06
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFE98E047C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 731
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+48],1
       mov       dword ptr [rsp+4C],1
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
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFE9875DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,19912004DA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L12
       mov       r14,[rcx+18]
M00_L03:
       test      r14,r14
       je        near ptr M00_L17
       mov       rcx,r14
       call      qword ptr [7FFE98D85FC8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L13
       mov       rdx,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFE98DD53B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFE9895DD10]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L04:
       mov       rcx,19912004DA8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L14
       mov       r15,[rcx+18]
M00_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFE98DD5200]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFE99077A98]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],r13
       lea       r8,[rsp+40]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFE99077C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L15
M00_L06:
       add       ebp,1
       jo        near ptr M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1D99FEFF6A0
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1D99FEF0008
       call      qword ptr [7FFE989AE310]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       test      rax,rax
       je        near ptr M00_L16
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsp+40],rcx
       mov       [rsp+30],rbp
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE99077DC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+48]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE987547B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFE989ACC30]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FFE989ACA50]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,1D99FEF3760
       mov       r8,rbx
       call      qword ptr [7FFE9875D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L12:
       call      qword ptr [7FFE98D1F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L13:
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFE98D1F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L05
M00_L15:
       sub       ebp,1
       jo        near ptr M00_L08
       jmp       near ptr M00_L06
M00_L16:
       mov       ecx,14
       call      qword ptr [7FFE98955B18]
       int       3
M00_L17:
       call      qword ptr [7FFE989ACC48]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,1D99FEFF6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,1D99FEF021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,1D99FEF0008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE989ACA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE987D6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 815
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
       mov       rdx,7FFE98CE0228
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
       call      qword ptr [7FFE98955B60]
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
       mov       rdx,7FFE98CE0218
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
; 		if (collection is null)
; 		^^^^^^^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
; 		if (collection is ICollection col)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return col.Count;
; 			^^^^^^^^^^^^^^^^^
; 		else if (collection is ICollection<object> colT)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return colT.Count;
; 			^^^^^^^^^^^^^^^^^^
; 		var count = 0;
; 		^^^^^^^^^^^^^^
; 		var enumerator = collection.GetEnumerator();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			count++;
; 			^^^^^^^^
; 		while (enumerator.MoveNext())
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return count;
; 		^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L06
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE986A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFE985610E8
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFE985610E0
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE986A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFE985610D8
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFE985610C8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFE985610D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L03
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		count = count.EnsureMinimum(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.Shuffle().Take(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L04
       mov       edi,1
       test      r8d,r8d
       cmovg     edi,r8d
       mov       rcx,[rbx+10]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbx
       mov       rdx,7FFE98DC6AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L01:
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rbx
       mov       rdx,7FFE98DC6B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE98DD5488]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFE98DD54D0]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M03_L04:
       call      qword ptr [7FFE989ACC48]
       mov       ecx,43
       mov       rdx,7FFE98D6EEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFE98976C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE986A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE98D6EEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE986A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE989ACA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE987D6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rsp
       mov       [rbp-20],rcx
       mov       [rbp+20],r8
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M04_L19
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M04_L00
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rbx
       mov       rdx,7FFE990D8CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE986A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],68
       jle       short M04_L02
       mov       r11,[rcx+68]
       test      r11,r11
       je        short M04_L02
       jmp       short M04_L03
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FFE990D91E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L03:
       mov       rcx,rdi
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M04_L05
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rbx
       mov       rdx,7FFE990D8E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFE986A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M04_L07
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rbx
       mov       rdx,7FFE990D91B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M04_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M04_L09
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M04_L09
       jmp       short M04_L10
M04_L09:
       mov       rcx,rbx
       mov       rdx,7FFE990D91D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L10:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M04_L12
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M04_L12
       jmp       short M04_L13
M04_L12:
       mov       rcx,rbx
       mov       rdx,7FFE990D8FC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFE98561048
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L16
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M04_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M04_L14
       jmp       short M04_L15
M04_L14:
       mov       rcx,rbx
       mov       rdx,7FFE990D90E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M04_L20
       jmp       short M04_L18
M04_L16:
       mov       rcx,rsp
       call      M04_L20
       nop
M04_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L18:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L19:
       mov       ecx,10
       call      qword ptr [7FFE98957A38]
       int       3
M04_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M04_L21
       mov       rcx,[rbp-28]
       mov       r11,7FFE98561050
       call      qword ptr [r11]
M04_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 610
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.HasItems() ? collection.Shuffle(1).FirstOrDefault() : default;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L07
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE986A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFE98561098
       call      qword ptr [r11]
M05_L00:
       test      eax,eax
       jle       short M05_L05
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rcx,rsi
       mov       rdx,7FFE98DC4680
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M05_L02:
       mov       rcx,[rsi+10]
       mov       rbp,[rcx+20]
       test      rbp,rbp
       je        short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFE98DC46D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFE98DD53B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE988A7E40]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L06:
       call      CORINFO_HELP_OVERFLOW
M05_L07:
       call      qword ptr [7FFE989ACC48]
       mov       ecx,43
       mov       rdx,7FFE98D6EEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFE98976C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE986A6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE98D6EEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE986A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE989ACA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE987D6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFE98561090
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE986A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFE98561088
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFE98561078
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFE98561080
       call      qword ptr [r11]
       test      eax,eax
       jne       short M05_L11
       mov       eax,edi
       jmp       near ptr M05_L00
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
; 	public PersonName(string firstName, string lastName)
; 	^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M06_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       test      rdx,rdx
       je        short M06_L01
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,31
       mov       rdx,7FFE98975ED0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE987D66E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFE98975ED0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE987D66E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 168
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains<T>(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rdi],0
       je        near ptr M07_L06
       test      rsi,rsi
       je        near ptr M07_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rcx,rbx
       mov       rdx,7FFE99066F60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,1D99FEF0008
       mov       r9,1D99FF07AF0
       call      qword ptr [7FFE99077CA8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFE99067010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFE99077CF0]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFE99067030
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M07_L05:
       mov       rdx,[rdi]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L07:
       call      qword ptr [7FFE989ACC48]
       mov       ecx,43
       mov       rdx,7FFE98D6EEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFE98976C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE986A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE98D6EEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE986A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE989ACA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE987D6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M07_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 388
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
; 		if (isValid is false && defaultValue is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			input = defaultValue;
; 			^^^^^^^^^^^^^^^^^^^^^
; 		else if (isValid is false)
; 		     ^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input!;
; 		^^^^^^^^^^^^^^
; 		var isValid = input is not null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M08_L01
M08_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       test      r8,r8
       je        short M08_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M08_L00
M08_L02:
       call      qword ptr [7FFE989ACC48]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,1D99FEF0210
       call      qword ptr [7FFE986A6B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFE986A6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE986A6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE989ACA38]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE987D6718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
       ret
       ret
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
       lea       rax,[7FFECCD43CC8]
       lea       rax,[7FFECCD43CC8]
       lea       rax,[7FFECCD43CC8]
       lea       rax,[7FFECCD43CC8]
       lea       rax,[7FFECCD43CC8]
       lea       rax,[7FFECCD43CC8]
       lea       rax,[7FFECCD43CC8]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFECCBC4638]
       lea       rdx,[7FFECCBC4638]
       lea       rdx,[7FFECCBC4638]
       lea       rdx,[7FFECCBC4638]
       lea       rdx,[7FFECCBC4638]
       lea       rdx,[7FFECCBC4638]
       lea       rdx,[7FFECCBC4638]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       call      qword ptr [7FFECCD43C90]
       call      qword ptr [7FFECCD43C90]
       call      qword ptr [7FFECCD43C90]
       call      qword ptr [7FFECCD43C90]
       call      qword ptr [7FFECCD43C90]
       call      qword ptr [7FFECCD43C90]
       call      qword ptr [7FFECCD43C90]
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFECCD3B0E8]
       call      qword ptr [7FFECCD3B0E8]
       call      qword ptr [7FFECCD3B0E8]
       call      qword ptr [7FFECCD3B0E8]
       call      qword ptr [7FFECCD3B0E8]
       call      qword ptr [7FFECCD3B0E8]
       call      qword ptr [7FFECCD3B0E8]
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFECCD43C88]
       call      qword ptr [7FFECCD43C88]
       call      qword ptr [7FFECCD43C88]
       call      qword ptr [7FFECCD43C88]
       call      qword ptr [7FFECCD43C88]
       call      qword ptr [7FFECCD43C88]
       call      qword ptr [7FFECCD43C88]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFECCD26918]
       call      qword ptr [7FFECCD26918]
       call      qword ptr [7FFECCD26918]
       call      qword ptr [7FFECCD26918]
       call      qword ptr [7FFECCD26918]
       call      qword ptr [7FFECCD26918]
       call      qword ptr [7FFECCD26918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFECCD495D0]
       call      qword ptr [7FFECCD495D0]
       call      qword ptr [7FFECCD495D0]
       call      qword ptr [7FFECCD495D0]
       call      qword ptr [7FFECCD495D0]
       call      qword ptr [7FFECCD495D0]
       call      qword ptr [7FFECCD495D0]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
       call      qword ptr [7FFECCD43CB0]
       call      qword ptr [7FFECCD43CB0]
       call      qword ptr [7FFECCD43CB0]
       call      qword ptr [7FFECCD43CB0]
       call      qword ptr [7FFECCD43CB0]
       call      qword ptr [7FFECCD43CB0]
       call      qword ptr [7FFECCD43CB0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
; Total bytes of code 1841
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonNames()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       esi,[rbx+278]
       mov       byte ptr [rsp+48],1
       mov       dword ptr [rsp+4C],1
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
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFE9879DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M00_L07
M00_L02:
       mov       rcx,22D0AC02DA8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L12
       mov       r14,[rcx+18]
M00_L03:
       test      r14,r14
       je        near ptr M00_L17
       mov       rcx,r14
       call      qword ptr [7FFE98DC5FC8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       near ptr M00_L13
       mov       rdx,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFE98E153B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFE9899DD10]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L04:
       mov       rcx,22D0AC02DB0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L14
       mov       r15,[rcx+18]
M00_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonName
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFE98E15200]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFE990B7B70]; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
       mov       [rsp+40],r13
       lea       r8,[rsp+40]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.PersonName>, DotNetTips.Spargine.Tester.PersonName ByRef)
       call      qword ptr [7FFE990B7D08]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L15
M00_L06:
       add       ebp,1
       jo        near ptr M00_L08
       cmp       ebp,esi
       jl        near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,26D9CBEF6A0
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.PersonName>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,26D9CBE0008
       call      qword ptr [7FFE989EE310]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       test      rax,rax
       je        near ptr M00_L16
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsp+40],rcx
       mov       [rsp+30],rbp
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.PersonName, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.PersonName> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE990B7EA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       call      CORINFO_HELP_OVERFLOW
M00_L09:
       movzx     ecx,byte ptr [rsp+48]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE987947B0]
       mov       esi,eax
       jmp       near ptr M00_L01
M00_L10:
       call      qword ptr [7FFE989ECC30]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FFE989ECA50]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,26D9CBE3760
       mov       r8,rbx
       call      qword ptr [7FFE9879D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L12:
       call      qword ptr [7FFE98D5F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L13:
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFE98D5F5A0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L05
M00_L15:
       sub       ebp,1
       jo        near ptr M00_L08
       jmp       near ptr M00_L06
M00_L16:
       mov       ecx,14
       call      qword ptr [7FFE98995B18]
       int       3
M00_L17:
       call      qword ptr [7FFE989ECC48]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       rdx,26D9CBEF6AC
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmm1,xmmword ptr [rdx+4]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+4],xmm1
       lea       rcx,[rax+20]
       mov       rdx,26D9CBE021C
       mov       r8d,[rdx]
       mov       [rcx],r8d
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       mov       rdx,26D9CBE0008
       test      ecx,ecx
       mov       rbx,rdx
       cmove     rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE989ECA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE98816718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 815
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
       mov       rdx,7FFE98CCFF28
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
       call      qword ptr [7FFE98995B60]
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
       mov       rdx,7FFE98CCFF18
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
; 		if (collection is null)
; 		^^^^^^^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
; 		if (collection is ICollection col)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return col.Count;
; 			^^^^^^^^^^^^^^^^^
; 		else if (collection is ICollection<object> colT)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return colT.Count;
; 			^^^^^^^^^^^^^^^^^^
; 		var count = 0;
; 		^^^^^^^^^^^^^^
; 		var enumerator = collection.GetEnumerator();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			count++;
; 			^^^^^^^^
; 		while (enumerator.MoveNext())
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return count;
; 		^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L06
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE986E4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFE985A10D8
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFE985A10D0
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE986E4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFE985A10C8
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFE985A10B8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFE985A10C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L03
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		count = count.EnsureMinimum(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.Shuffle().Take(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L04
       mov       edi,1
       test      r8d,r8d
       cmovg     edi,r8d
       mov       rcx,[rbx+10]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbx
       mov       rdx,7FFE98E06AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L01:
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rbx
       mov       rdx,7FFE98E06B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE98E15488]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFE98E154D0]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M03_L04:
       call      qword ptr [7FFE989ECC48]
       mov       ecx,43
       mov       rdx,7FFE98DAEEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFE989B6C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE986E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE98DAEEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE986E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE989ECA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE98816718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rsp
       mov       [rbp-20],rcx
       mov       [rbp+20],r8
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M04_L19
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M04_L00
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rbx
       mov       rdx,7FFE99119C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE986E4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],68
       jle       short M04_L02
       mov       r11,[rcx+68]
       test      r11,r11
       je        short M04_L02
       jmp       short M04_L03
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FFE9911A1A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L03:
       mov       rcx,rdi
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M04_L05
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rbx
       mov       rdx,7FFE99119E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFE986E4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M04_L07
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rbx
       mov       rdx,7FFE9911A178
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M04_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],60
       jle       short M04_L09
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M04_L09
       jmp       short M04_L10
M04_L09:
       mov       rcx,rbx
       mov       rdx,7FFE9911A190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L10:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M04_L12
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M04_L12
       jmp       short M04_L13
M04_L12:
       mov       rcx,rbx
       mov       rdx,7FFE99119F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFE985A1038
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L16
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M04_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M04_L14
       jmp       short M04_L15
M04_L14:
       mov       rcx,rbx
       mov       rdx,7FFE9911A0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M04_L20
       jmp       short M04_L18
M04_L16:
       mov       rcx,rsp
       call      M04_L20
       nop
M04_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L18:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L19:
       mov       ecx,10
       call      qword ptr [7FFE98997A38]
       int       3
M04_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M04_L21
       mov       rcx,[rbp-28]
       mov       r11,7FFE985A1040
       call      qword ptr [r11]
M04_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 610
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.HasItems() ? collection.Shuffle(1).FirstOrDefault() : default;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L07
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE986E4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L08
       mov       rcx,[rax+8]
       mov       r11,7FFE985A1088
       call      qword ptr [r11]
M05_L00:
       test      eax,eax
       jle       short M05_L05
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rcx,rsi
       mov       rdx,7FFE98E04680
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M05_L02:
       mov       rcx,[rsi+10]
       mov       rbp,[rcx+20]
       test      rbp,rbp
       je        short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFE98E046D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M05_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFE98E153B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE988E7E40]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L06:
       call      CORINFO_HELP_OVERFLOW
M05_L07:
       call      qword ptr [7FFE989ECC48]
       mov       ecx,43
       mov       rdx,7FFE98DAEEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFE989B6C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE986E6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE98DAEEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE986E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE989ECA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE98816718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       mov       r11,7FFE985A1080
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE986E4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M05_L10
       mov       rcx,rax
       mov       r11,7FFE985A1078
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFE985A1068
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M05_L12
M05_L11:
       add       edi,1
       jo        near ptr M05_L06
M05_L12:
       mov       rcx,rbp
       mov       r11,7FFE985A1070
       call      qword ptr [r11]
       test      eax,eax
       jne       short M05_L11
       mov       eax,edi
       jmp       near ptr M05_L00
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Tester.PersonName..ctor(System.String, System.String)
; 	public PersonName(string firstName, string lastName)
; 	^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M06_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       test      rdx,rdx
       je        short M06_L01
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,31
       mov       rdx,7FFE989B5ED0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE988166E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,45
       mov       rdx,7FFE989B5ED0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE988166E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 168
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon ByRef)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains<T>(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rdi],0
       je        near ptr M07_L06
       test      rsi,rsi
       je        near ptr M07_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rcx,rbx
       mov       rdx,7FFE990A7090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rsi
       mov       r8,26D9CBE0008
       mov       r9,26D9CBF7AF0
       call      qword ptr [7FFE990B7D80]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFE990A7140
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r8,[rdi]
       mov       rdx,rsi
       call      qword ptr [7FFE990B7DC8]; System.Linq.Enumerable.Contains[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       test      eax,eax
       jne       near ptr M07_L08
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M07_L04
       jmp       short M07_L05
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFE990A7160
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M07_L05:
       mov       rdx,[rdi]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L07:
       call      qword ptr [7FFE989ECC48]
       mov       ecx,43
       mov       rdx,7FFE98DAEEF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1AC2
       mov       rdx,7FFE989B6C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE986E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE98DAEEF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE986E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE989ECA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE98816718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M07_L08:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 388
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
; 		if (isValid is false && defaultValue is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			input = defaultValue;
; 			^^^^^^^^^^^^^^^^^^^^^
; 		else if (isValid is false)
; 		     ^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input!;
; 		^^^^^^^^^^^^^^
; 		var isValid = input is not null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M08_L01
M08_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       test      r8,r8
       je        short M08_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M08_L00
M08_L02:
       call      qword ptr [7FFE989ECC48]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,26D9CBE0210
       call      qword ptr [7FFE986E6B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M08_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFE986E6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M08_L04
M08_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE986E6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M08_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE989ECA38]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE98816718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
M10_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       je        short M10_L01
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       jne       short M10_L03
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
M10_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       jne       short M10_L02
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
       ret
       ret
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
M10_L02:
       mov       rcx,rbx
       lea       rax,[7FFECCD43CC8]
       lea       rax,[7FFECCD43CC8]
       lea       rax,[7FFECCD43CC8]
       lea       rax,[7FFECCD43CC8]
       lea       rax,[7FFECCD43CC8]
       lea       rax,[7FFECCD43CC8]
       lea       rax,[7FFECCD43CC8]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
M10_L03:
       cmp       edi,8
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       ja        short M10_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFECCBC4638]
       lea       rdx,[7FFECCBC4638]
       lea       rdx,[7FFECCBC4638]
       lea       rdx,[7FFECCBC4638]
       lea       rdx,[7FFECCBC4638]
       lea       rdx,[7FFECCBC4638]
       lea       rdx,[7FFECCBC4638]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       lea       rax,[M10_L00]
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       call      qword ptr [7FFECCD43C90]
       call      qword ptr [7FFECCD43C90]
       call      qword ptr [7FFECCD43C90]
       call      qword ptr [7FFECCD43C90]
       call      qword ptr [7FFECCD43C90]
       call      qword ptr [7FFECCD43C90]
       call      qword ptr [7FFECCD43C90]
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       call      qword ptr [7FFECCD43C98]
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       jmp       short M10_L01
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       je        short M10_L05
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
M10_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFECCD3B0E8]
       call      qword ptr [7FFECCD3B0E8]
       call      qword ptr [7FFECCD3B0E8]
       call      qword ptr [7FFECCD3B0E8]
       call      qword ptr [7FFECCD3B0E8]
       call      qword ptr [7FFECCD3B0E8]
       call      qword ptr [7FFECCD3B0E8]
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFECCD43C88]
       call      qword ptr [7FFECCD43C88]
       call      qword ptr [7FFECCD43C88]
       call      qword ptr [7FFECCD43C88]
       call      qword ptr [7FFECCD43C88]
       call      qword ptr [7FFECCD43C88]
       call      qword ptr [7FFECCD43C88]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFECCD26918]
       call      qword ptr [7FFECCD26918]
       call      qword ptr [7FFECCD26918]
       call      qword ptr [7FFECCD26918]
       call      qword ptr [7FFECCD26918]
       call      qword ptr [7FFECCD26918]
       call      qword ptr [7FFECCD26918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFECCD495D0]
       call      qword ptr [7FFECCD495D0]
       call      qword ptr [7FFECCD495D0]
       call      qword ptr [7FFECCD495D0]
       call      qword ptr [7FFECCD495D0]
       call      qword ptr [7FFECCD495D0]
       call      qword ptr [7FFECCD495D0]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       call      qword ptr [7FFECCD43CA0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
M10_L05:
       mov       rcx,rbx
       call      qword ptr [7FFECCD43CB0]
       call      qword ptr [7FFECCD43CB0]
       call      qword ptr [7FFECCD43CB0]
       call      qword ptr [7FFECCD43CB0]
       call      qword ptr [7FFECCD43CB0]
       call      qword ptr [7FFECCD43CB0]
       call      qword ptr [7FFECCD43CB0]
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
       jmp       near ptr M10_L01
; Total bytes of code 1841
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       rcx,22535C02D00
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,22539C01DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22535C02CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE986B4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22535C02D00
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFE98967A38]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFE98967A38]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFE986B41F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,22F98802D10
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L01
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L03
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,22F9C801DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22F98802CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFE986D4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22F98802D10
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L02:
       mov       ecx,10
       call      qword ptr [7FFE98987A38]
       int       3
M00_L03:
       mov       ecx,9
       call      qword ptr [7FFE98987A38]
       int       3
; Total bytes of code 274
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M01_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFE986D41F8]
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__15_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

