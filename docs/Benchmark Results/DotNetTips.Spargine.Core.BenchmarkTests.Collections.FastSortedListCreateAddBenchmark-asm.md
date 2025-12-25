## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,1C0DCC01FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rsi+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rsi+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE621069D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621067C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F45B60]
       int       3
M00_L06:
       mov       rcx,1C0DCC01FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 458
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C41E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F45D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,2016EB90008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       jne       short M02_L01
       mov       edx,4
M02_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61CFDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
M02_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M02_L00
; Total bytes of code 104
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,21F1CC01FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rsi+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rsi+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE621269D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621267C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DF6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F65B60]
       int       3
M00_L06:
       mov       rcx,21F1CC01FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 456
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C61E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61D15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61D15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F65D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,25FAE9C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L00
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M02_L01
M02_L00:
       mov       edx,4
M02_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61D1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 104
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,1B3F9801FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rsi+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rsi+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE620F69D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620F67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DC6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F35B60]
       int       3
M00_L06:
       mov       rcx,1B3F9801FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 456
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C31E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F35D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,1F48B5F0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L01
       mov       edx,[rdx+8]
       add       edx,edx
M02_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61CEDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
M02_L01:
       mov       edx,4
       jmp       short M02_L00
; Total bytes of code 100
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,26ECA001FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rsi+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rsi+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE621269D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621267C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DF6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F65B60]
       int       3
M00_L06:
       mov       rcx,26ECA001FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 456
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C61E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61D15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61D15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F65D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,2AF5BFB0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L00
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M02_L01
M02_L00:
       mov       edx,4
M02_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61D1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 104
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,1B7FB401FF0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rsi+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rsi+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE620F69D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620F67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DC6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F35B60]
       int       3
M00_L06:
       mov       rcx,1B7FB401FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 456
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C31E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F35D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,1F8892F0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L00
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M02_L01
M02_L00:
       mov       edx,4
M02_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61CEDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 104
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,275B680F7E0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rsi+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rsi+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE621269D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621267C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DF6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F65B60]
       int       3
M00_L06:
       mov       rcx,275B6801FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 456
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C61E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61D15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61D15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F65D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,2B644740008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L00
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M02_L01
M02_L00:
       mov       edx,4
M02_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61D1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 104
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,2541B80F7E8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rsi+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rsi+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE620F69D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620F67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DC6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F35B60]
       int       3
M00_L06:
       mov       rcx,2541B801FC0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 458
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C31E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F35D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,294A95D0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L01
       mov       edx,[rdx+8]
       add       edx,edx
M02_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61CEDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
M02_L01:
       mov       edx,4
       jmp       short M02_L00
; Total bytes of code 100
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,20C22C0D7F0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rsi+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rsi+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE620E69D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C26B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C26B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DB6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F25B60]
       int       3
M00_L06:
       mov       rcx,20C26C01FC0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE61CDE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 458
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C21E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CD5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CD5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F25D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,24CB4BA0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L01
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
M02_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61CDDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
M02_L01:
       mov       edx,4
       jmp       short M02_L00
; Total bytes of code 104
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       test      edi,edi
       jl        near ptr M00_L07
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20083401DD0
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       test      r15,r15
       je        near ptr M00_L04
       mov       [rsp+20],r15
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       mov       r9d,[rsi+30]
       mov       rdx,[rsi+8]
       mov       rcx,7FFE626C1530
       xor       r8d,r8d
       call      qword ptr [7FFE626BDD40]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FFE626BDC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
M00_L01:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L06
M00_L02:
       mov       r9d,[rdi+38]
       cmp       r14d,r9d
       jb        short M00_L03
       mov       ecx,[rsi+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r9,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[r9+8]
       jae       near ptr M00_L08
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r9+rdx*8+10]
       cmp       dword ptr [r9+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L02
       mov       r15,[r9]
       mov       r13,[r9+8]
       jmp       near ptr M00_L00
M00_L04:
       mov       ecx,899
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DE6790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623CDB60]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE623CDAA0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C5F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFE61F55E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE626E4C60]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 478
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M01_L04
       test      edi,edi
       jl        near ptr M01_L05
       test      ebp,ebp
       jl        near ptr M01_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE628655E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M01_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M01_L02
       mov       [rsp+20],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE628655F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E9E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M01_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L05:
       call      qword ptr [7FFE61F558C0]
       int       3
M01_L06:
       call      qword ptr [7FFE61F558F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F55AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M02_L02
M02_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M02_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE626BDB18]
       jmp       short M02_L00
; Total bytes of code 153
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       test      edi,edi
       jl        near ptr M00_L07
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,15353C01DD0
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       test      r15,r15
       je        near ptr M00_L04
       mov       [rsp+20],r15
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       mov       r9d,[rsi+30]
       mov       rdx,[rsi+8]
       mov       rcx,7FFE626A1530
       xor       r8d,r8d
       call      qword ptr [7FFE6269DD40]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FFE6269DC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
M00_L01:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L06
M00_L02:
       mov       r9d,[rdi+38]
       cmp       r14d,r9d
       jb        short M00_L03
       mov       ecx,[rsi+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r9,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[r9+8]
       jae       near ptr M00_L08
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r9+rdx*8+10]
       cmp       dword ptr [r9+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L02
       mov       r15,[r9]
       mov       r13,[r9+8]
       jmp       near ptr M00_L00
M00_L04:
       mov       ecx,899
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DC6790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AD860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE623AD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFE61F35E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE626C4C60]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 478
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M01_L04
       test      edi,edi
       jl        near ptr M01_L05
       test      ebp,ebp
       jl        near ptr M01_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE62845660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M01_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M01_L02
       mov       [rsp+20],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE62845670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E7E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M01_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F35B18]
       int       3
M01_L05:
       call      qword ptr [7FFE61F358C0]
       int       3
M01_L06:
       call      qword ptr [7FFE61F358F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F35AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M02_L02
M02_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M02_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE6269DB18]
       jmp       short M02_L00
; Total bytes of code 153
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       test      edi,edi
       jl        near ptr M00_L07
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,21E72001DD0
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       test      r15,r15
       je        near ptr M00_L04
       mov       [rsp+20],r15
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       mov       r9d,[rsi+30]
       mov       rdx,[rsi+8]
       mov       rcx,7FFE626B10D0
       xor       r8d,r8d
       call      qword ptr [7FFE626ADD40]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FFE626ADC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
M00_L01:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L06
M00_L02:
       mov       r9d,[rdi+38]
       cmp       r14d,r9d
       jb        short M00_L03
       mov       ecx,[rsi+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r9,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[r9+8]
       jae       near ptr M00_L08
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r9+rdx*8+10]
       cmp       dword ptr [r9+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L02
       mov       r15,[r9]
       mov       r13,[r9+8]
       jmp       near ptr M00_L00
M00_L04:
       mov       ecx,899
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DD6790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623BD860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE623BD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C4F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFE61F45E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE626D4F90]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 478
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M01_L04
       test      edi,edi
       jl        near ptr M01_L05
       test      ebp,ebp
       jl        near ptr M01_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE62855720
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M01_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M01_L02
       mov       [rsp+20],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE62855730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E8E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M01_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L05:
       call      qword ptr [7FFE61F458C0]
       int       3
M01_L06:
       call      qword ptr [7FFE61F458F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F45AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M02_L02
M02_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M02_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r14d,[rsi+1]
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE626ADB18]
       jmp       short M02_L00
; Total bytes of code 159
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       test      edi,edi
       jl        near ptr M00_L07
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,18588001DD0
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       test      r15,r15
       je        near ptr M00_L04
       mov       [rsp+20],r15
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       mov       r9d,[rsi+30]
       mov       rdx,[rsi+8]
       mov       rcx,7FFE626A18C0
       xor       r8d,r8d
       call      qword ptr [7FFE6269DD40]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FFE6269DC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
M00_L01:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L06
M00_L02:
       mov       r9d,[rdi+38]
       cmp       r14d,r9d
       jb        short M00_L03
       mov       ecx,[rsi+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r9,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[r9+8]
       jae       near ptr M00_L08
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r9+rdx*8+10]
       cmp       dword ptr [r9+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L02
       mov       r15,[r9]
       mov       r13,[r9+8]
       jmp       near ptr M00_L00
M00_L04:
       mov       ecx,899
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DC6790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AD860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE623AD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFE61F35E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE626C4C60]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 478
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M01_L04
       test      edi,edi
       jl        near ptr M01_L05
       test      ebp,ebp
       jl        near ptr M01_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE62845C48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M01_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M01_L02
       mov       [rsp+20],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE62845C58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E7E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M01_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F35B18]
       int       3
M01_L05:
       call      qword ptr [7FFE61F358C0]
       int       3
M01_L06:
       call      qword ptr [7FFE61F358F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F35AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M02_L02
M02_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M02_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r14d,[rsi+1]
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE6269DB18]
       jmp       short M02_L00
; Total bytes of code 159
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       test      edi,edi
       jl        near ptr M00_L07
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,297ADC01DD0
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       test      r15,r15
       je        near ptr M00_L04
       mov       [rsp+20],r15
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       mov       r9d,[rsi+30]
       mov       rdx,[rsi+8]
       mov       rcx,7FFE627D6988
       xor       r8d,r8d
       call      qword ptr [7FFE627CF9A8]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FFE627CF8D0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
M00_L01:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L06
M00_L02:
       mov       r9d,[rdi+38]
       cmp       r14d,r9d
       jb        short M00_L03
       mov       ecx,[rsi+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r9,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[r9+8]
       jae       near ptr M00_L08
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r9+rdx*8+10]
       cmp       dword ptr [r9+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L02
       mov       r15,[r9]
       mov       r13,[r9+8]
       jmp       near ptr M00_L00
M00_L04:
       mov       ecx,899
       mov       rdx,7FFE61F153F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DB6790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE6239D860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE6239D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F153F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C2F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFE61F25E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FFE61F153F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE626063E8]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 478
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M01_L04
       test      edi,edi
       jl        near ptr M01_L05
       test      ebp,ebp
       jl        near ptr M01_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE6289CF08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M01_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M01_L02
       mov       [rsp+20],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE6289CF18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E6E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M01_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F25B18]
       int       3
M01_L05:
       call      qword ptr [7FFE61F258C0]
       int       3
M01_L06:
       call      qword ptr [7FFE61F258F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F25AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M02_L02
M02_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M02_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r14d,[rsi+1]
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE627CF780]
       jmp       short M02_L00
; Total bytes of code 159
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       test      edi,edi
       jl        near ptr M00_L07
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,13B1E401DD0
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       test      r15,r15
       je        near ptr M00_L04
       mov       [rsp+20],r15
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       mov       r9d,[rsi+30]
       mov       rdx,[rsi+8]
       mov       rcx,7FFE62873F88
       xor       r8d,r8d
       call      qword ptr [7FFE6286E8F8]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FFE6286E820]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
M00_L01:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L06
M00_L02:
       mov       r9d,[rdi+38]
       cmp       r14d,r9d
       jb        short M00_L03
       mov       ecx,[rsi+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r9,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[r9+8]
       jae       near ptr M00_L08
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r9+rdx*8+10]
       cmp       dword ptr [r9+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L02
       mov       r15,[r9]
       mov       r13,[r9+8]
       jmp       near ptr M00_L00
M00_L04:
       mov       ecx,899
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DD6790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623BD860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE623BD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C4F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFE61F45E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE62626490]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 478
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M01_L04
       test      edi,edi
       jl        near ptr M01_L05
       test      ebp,ebp
       jl        near ptr M01_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE62964A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M01_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M01_L02
       mov       [rsp+20],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE62964A38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E8E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M01_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L05:
       call      qword ptr [7FFE61F458C0]
       int       3
M01_L06:
       call      qword ptr [7FFE61F458F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F45AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M02_L02
M02_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M02_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r14d,[rsi+1]
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE6286E6D0]
       jmp       short M02_L00
; Total bytes of code 159
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       test      edi,edi
       jl        near ptr M00_L07
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1291D801DD0
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       test      r15,r15
       je        near ptr M00_L04
       mov       [rsp+20],r15
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       mov       r9d,[rsi+30]
       mov       rdx,[rsi+8]
       mov       rcx,7FFE6289ABA0
       xor       r8d,r8d
       call      qword ptr [7FFE6288EF28]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FFE6288EE50]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
M00_L01:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L06
M00_L02:
       mov       r9d,[rdi+38]
       cmp       r14d,r9d
       jb        short M00_L03
       mov       ecx,[rsi+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r9,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[r9+8]
       jae       near ptr M00_L08
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r9+rdx*8+10]
       cmp       dword ptr [r9+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L02
       mov       r15,[r9]
       mov       r13,[r9+8]
       jmp       near ptr M00_L00
M00_L04:
       mov       ecx,899
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DE6790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623CD860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE623CD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C5F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFE61F55E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE6254E1D8]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 478
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M01_L04
       test      edi,edi
       jl        near ptr M01_L05
       test      ebp,ebp
       jl        near ptr M01_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE62981DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M01_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M01_L02
       mov       [rsp+20],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE62981DB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E9E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M01_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L05:
       call      qword ptr [7FFE61F558C0]
       int       3
M01_L06:
       call      qword ptr [7FFE61F558F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F55AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M02_L02
M02_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M02_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r14d,[rsi+1]
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE6288ED00]
       jmp       short M02_L00
; Total bytes of code 159
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       test      edi,edi
       jl        near ptr M00_L07
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1FD4C801DD0
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+288]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       test      r15,r15
       je        near ptr M00_L04
       mov       [rsp+20],r15
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       mov       r9d,[rsi+30]
       mov       rdx,[rsi+8]
       mov       rcx,7FFE6297AF08
       xor       r8d,r8d
       call      qword ptr [7FFE62985D40]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FFE62985C68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
M00_L01:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L06
M00_L02:
       mov       r9d,[rdi+38]
       cmp       r14d,r9d
       jb        short M00_L03
       mov       ecx,[rsi+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L03:
       mov       r9,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[r9+8]
       jae       near ptr M00_L08
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r9+rdx*8+10]
       cmp       dword ptr [r9+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L02
       mov       r15,[r9]
       mov       r13,[r9+8]
       jmp       near ptr M00_L00
M00_L04:
       mov       ecx,899
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DD6790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623BD860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE623BD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C4F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FFE61F45E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE6253E1D8]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 478
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M01_L04
       test      edi,edi
       jl        near ptr M01_L05
       test      ebp,ebp
       jl        near ptr M01_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE6296C9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M01_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M01_L02
       mov       [rsp+20],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE6296CA00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E8E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M01_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L05:
       call      qword ptr [7FFE61F458C0]
       int       3
M01_L06:
       call      qword ptr [7FFE61F458F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F45AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M02_L02
M02_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M02_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r14d,[rsi+1]
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M02_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE62985B18]
       jmp       short M02_L00
; Total bytes of code 159
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList_Comparer()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       eax,[rbp+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rbp+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rbp+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rbp+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE620E69D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C26B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C26B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DB6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F25B60]
       int       3
M00_L06:
       mov       rcx,21C9B401FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FFE61CDE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 461
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C21E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CD5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CD5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F25D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,25D2D3A0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       jne       short M02_L01
       mov       edx,4
M02_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61CDDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
M02_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M02_L00
; Total bytes of code 104
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList_Comparer()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       eax,[rbp+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rbp+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rbp+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rbp+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE621169D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F7BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F7BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F7BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DE6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F55B60]
       int       3
M00_L06:
       mov       rcx,1E956C01FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 461
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C51E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61D05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61D05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F55D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,229E4990008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L01
       mov       edx,[rdx+8]
       add       edx,edx
M02_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61D0DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
M02_L01:
       mov       edx,4
       jmp       short M02_L00
; Total bytes of code 100
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList_Comparer()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       eax,[rbp+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rbp+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rbp+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rbp+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE621169D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F7BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F7BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F7BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DE6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F55B60]
       int       3
M00_L06:
       mov       rcx,24556001FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 461
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C51E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61D05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61D05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F55D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,285E3EA0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L00
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M02_L01
M02_L00:
       mov       edx,4
M02_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61D0DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 104
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList_Comparer()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       eax,[rbp+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rbp+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rbp+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rbp+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE620F69D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620F67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DC6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F35B60]
       int       3
M00_L06:
       mov       rcx,17D00401FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 461
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C31E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F35D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,1BD8E2C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L01
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
M02_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61CEDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
M02_L01:
       mov       edx,4
       jmp       short M02_L00
; Total bytes of code 104
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList_Comparer()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       eax,[rbp+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rbp+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rbp+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rbp+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE621169D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F7BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F7BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F7BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DE6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F55B60]
       int       3
M00_L06:
       mov       rcx,1A2A8001FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 461
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C51E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61D05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61D05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F55D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,1E339D20008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L01
       mov       edx,[rdx+8]
       add       edx,edx
M02_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61D0DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
M02_L01:
       mov       edx,4
       jmp       short M02_L00
; Total bytes of code 100
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList_Comparer()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       eax,[rbp+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rbp+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rbp+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rbp+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE620F69D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620F67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DC6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F35B60]
       int       3
M00_L06:
       mov       rcx,21658C01FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 461
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C31E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F35D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,256E6BE0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L00
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M02_L01
M02_L00:
       mov       edx,4
M02_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61CEDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 104
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList_Comparer()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       eax,[rbp+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rbp+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rbp+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rbp+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE620F69D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620F67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DC6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F35B60]
       int       3
M00_L06:
       mov       rcx,207D1801FC0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 461
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C31E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F35D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,2485B630008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L00
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M02_L01
M02_L00:
       mov       edx,4
M02_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61CEDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 104
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_FastSortedList_Comparer()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       jl        near ptr M00_L05
       test      edi,edi
       je        near ptr M00_L06
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M00_L03
M00_L01:
       mov       ecx,r14d
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       eax,[rbp+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L07
       lea       r8d,[rax+1]
       mov       [rbp+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       byte ptr [rbp+28],0
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L01
M00_L03:
       mov       ecx,[rbp+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFE621069D0]
       mov       ecx,3F34
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621067C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE61F45B60]
       int       3
M00_L06:
       mov       rcx,21279001FC0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 461
```
```assembly
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
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      00007FFE61C41E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFE61F45D58]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,25308D80008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
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
       je        short M02_L01
       mov       edx,[rdx+8]
       add       edx,edx
M02_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE61CFDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
M02_L01:
       mov       edx,4
       jmp       short M02_L00
; Total bytes of code 100
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList_Comparer()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1CC4C801FE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1CC4C801FE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,1CC4C801DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE626AD8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rsi,[rbx+280]
       xor       edi,edi
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       r9d,edi
       mov       r15,[rsi+r9*8+10]
       mov       r13,[r15+28]
       test      r13,r13
       je        short M00_L02
       mov       [rsp+20],r13
       mov       r9,[rbp+18]
       mov       [rsp+28],r9
       mov       r9d,[rbp+30]
       mov       rdx,[rbp+8]
       mov       rcx,7FFE626B17E8
       xor       r8d,r8d
       call      qword ptr [7FFE626ADD88]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFE626ADC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       inc       edi
       cmp       r14d,edi
       jg        short M00_L00
M00_L01:
       mov       ecx,[rbp+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,899
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DD6790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623BD860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FFE623BD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C4F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 397
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       cmp       [rcx+8],esi
       je        near ptr M01_L10
       mov       edi,[rbx+30]
       cmp       esi,edi
       jl        near ptr M01_L11
       test      esi,esi
       jle       near ptr M01_L05
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+68]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62855EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       movsxd    rsi,esi
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62855EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       test      edi,edi
       jg        near ptr M01_L12
M01_L04:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FFE62855CB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FFE6207E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rbp
       mov       rdx,7FFE62855CE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FFE6207E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L10:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,7A7
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE623BD830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FFE61CFD4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFE61B97738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FFE61B97738]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M01_L04
; Total bytes of code 469
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M02_L04
       test      edi,edi
       jl        near ptr M02_L05
       test      ebp,ebp
       jl        near ptr M02_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M02_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FFE62855380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M02_L02
       mov       [rsp+20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FFE62855390
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E8E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M02_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F45B18]
       int       3
M02_L05:
       call      qword ptr [7FFE61F458C0]
       int       3
M02_L06:
       call      qword ptr [7FFE61F458F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F45AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M03_L02
M03_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M03_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M03_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE626ADB18]
       jmp       short M03_L00
; Total bytes of code 153
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList_Comparer()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,181DCC01FE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,181DCC01FE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,181DCC01DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE626CD8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rsi,[rbx+280]
       xor       edi,edi
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       r9d,edi
       mov       r15,[rsi+r9*8+10]
       mov       r13,[r15+28]
       test      r13,r13
       je        short M00_L02
       mov       [rsp+20],r13
       mov       r9,[rbp+18]
       mov       [rsp+28],r9
       mov       r9d,[rbp+30]
       mov       rdx,[rbp+8]
       mov       rcx,7FFE626D17E8
       xor       r8d,r8d
       call      qword ptr [7FFE626CDD88]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFE626CDC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       inc       edi
       cmp       r14d,edi
       jg        short M00_L00
M00_L01:
       mov       ecx,[rbp+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,899
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DF6790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623DD860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FFE623DD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C6F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 397
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       cmp       [rcx+8],esi
       je        near ptr M01_L10
       mov       edi,[rbx+30]
       cmp       esi,edi
       jl        near ptr M01_L11
       test      esi,esi
       jle       near ptr M01_L05
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+68]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62875DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       movsxd    rsi,esi
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62875E00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       test      edi,edi
       jg        near ptr M01_L12
M01_L04:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FFE62875BC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rbp
       mov       rdx,7FFE62875BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L10:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,7A7
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE623DD830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FFE61D1D4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFE61BB7738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FFE61BB7738]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M01_L04
; Total bytes of code 469
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M02_L04
       test      edi,edi
       jl        near ptr M02_L05
       test      ebp,ebp
       jl        near ptr M02_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M02_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FFE628753E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M02_L02
       mov       [rsp+20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FFE628753F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61EAE148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M02_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F65B18]
       int       3
M02_L05:
       call      qword ptr [7FFE61F658C0]
       int       3
M02_L06:
       call      qword ptr [7FFE61F658F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F65AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M03_L02
M03_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M03_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M03_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE626CDB18]
       jmp       short M03_L00
; Total bytes of code 153
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList_Comparer()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1AE84801FE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1AE84801FE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,1AE84801DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE6269D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rsi,[rbx+280]
       xor       edi,edi
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       r9d,edi
       mov       r15,[rsi+r9*8+10]
       mov       r13,[r15+28]
       test      r13,r13
       je        short M00_L02
       mov       [rsp+20],r13
       mov       r9,[rbp+18]
       mov       [rsp+28],r9
       mov       r9d,[rbp+30]
       mov       rdx,[rbp+8]
       mov       rcx,7FFE626A1388
       xor       r8d,r8d
       call      qword ptr [7FFE6269DD88]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFE6269DC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       inc       edi
       cmp       r14d,edi
       jg        short M00_L00
M00_L01:
       mov       ecx,[rbp+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,899
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DC6790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AD860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FFE623AD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 397
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       cmp       [rcx+8],esi
       je        near ptr M01_L10
       mov       edi,[rbx+30]
       cmp       esi,edi
       jl        near ptr M01_L11
       test      esi,esi
       jle       near ptr M01_L05
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+68]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62845E10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       movsxd    rsi,esi
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62845E18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       test      edi,edi
       jg        near ptr M01_L12
M01_L04:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FFE62845BD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rbp
       mov       rdx,7FFE62845C10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L10:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,7A7
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE623AD830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FFE61CED4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFE61B87738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FFE61B87738]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M01_L04
; Total bytes of code 469
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M02_L04
       test      edi,edi
       jl        near ptr M02_L05
       test      ebp,ebp
       jl        near ptr M02_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M02_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FFE628453F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M02_L02
       mov       [rsp+20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FFE62845408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E7E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M02_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F35B18]
       int       3
M02_L05:
       call      qword ptr [7FFE61F358C0]
       int       3
M02_L06:
       call      qword ptr [7FFE61F358F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F35AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M03_L02
M03_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M03_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r14d,[rsi+1]
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M03_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE6269DB18]
       jmp       short M03_L00
; Total bytes of code 159
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList_Comparer()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,28F91801FE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,28F91801FE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,28F91801DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE6269DBF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rsi,[rbx+280]
       xor       edi,edi
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       r9d,edi
       mov       r15,[rsi+r9*8+10]
       mov       r13,[r15+28]
       test      r13,r13
       je        short M00_L02
       mov       [rsp+20],r13
       mov       r9,[rbp+18]
       mov       [rsp+28],r9
       mov       r9d,[rbp+30]
       mov       rdx,[rbp+8]
       mov       rcx,7FFE626A1B78
       xor       r8d,r8d
       call      qword ptr [7FFE6269E0B8]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFE6269DF98]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       inc       edi
       cmp       r14d,edi
       jg        short M00_L00
M00_L01:
       mov       ecx,[rbp+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,899
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DC6790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AD860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FFE623AD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 397
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       cmp       [rcx+8],esi
       je        near ptr M01_L10
       mov       edi,[rbx+30]
       cmp       esi,edi
       jl        near ptr M01_L11
       test      esi,esi
       jle       near ptr M01_L05
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+68]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE628466D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       movsxd    rsi,esi
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE628466E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       test      edi,edi
       jg        near ptr M01_L12
M01_L04:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FFE628464A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rbp
       mov       rdx,7FFE628464D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L10:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,7A7
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE623AD830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FFE61CED4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFE61B87738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FFE61B87738]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M01_L04
; Total bytes of code 469
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M02_L04
       test      edi,edi
       jl        near ptr M02_L05
       test      ebp,ebp
       jl        near ptr M02_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M02_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FFE62845B70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M02_L02
       mov       [rsp+20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FFE62845B80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E7E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M02_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F35B18]
       int       3
M02_L05:
       call      qword ptr [7FFE61F358C0]
       int       3
M02_L06:
       call      qword ptr [7FFE61F358F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F35AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M03_L02
M03_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M03_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r14d,[rsi+1]
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M03_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE6269DE48]
       jmp       short M03_L00
; Total bytes of code 159
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList_Comparer()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,20ADCC01FE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20ADCC01FE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,20ADCC01DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE626FE478]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rsi,[rbx+280]
       xor       edi,edi
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       r9d,edi
       mov       r15,[rsi+r9*8+10]
       mov       r13,[r15+28]
       test      r13,r13
       je        short M00_L02
       mov       [rsp+20],r13
       mov       r9,[rbp+18]
       mov       [rsp+28],r9
       mov       r9d,[rbp+30]
       mov       rdx,[rbp+8]
       mov       rcx,7FFE62706888
       xor       r8d,r8d
       call      qword ptr [7FFE626FE940]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFE626FE820]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       inc       edi
       cmp       r14d,edi
       jg        short M00_L00
M00_L01:
       mov       ecx,[rbp+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,899
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DE6790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623CD860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FFE623CD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C5F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 397
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       cmp       [rcx+8],esi
       je        near ptr M01_L10
       mov       edi,[rbx+30]
       cmp       esi,edi
       jl        near ptr M01_L11
       test      esi,esi
       jle       near ptr M01_L05
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+68]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE628E2640
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       movsxd    rsi,esi
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE628E2648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       test      edi,edi
       jg        near ptr M01_L12
M01_L04:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FFE628E2408
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rbp
       mov       rdx,7FFE628E2440
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L10:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,7A7
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE623CD830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FFE61D0D4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFE61BA7738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FFE61BA7738]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M01_L04
; Total bytes of code 469
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M02_L04
       test      edi,edi
       jl        near ptr M02_L05
       test      ebp,ebp
       jl        near ptr M02_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M02_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FFE628E1C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M02_L02
       mov       [rsp+20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FFE628E1C38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E9E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M02_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F55B18]
       int       3
M02_L05:
       call      qword ptr [7FFE61F558C0]
       int       3
M02_L06:
       call      qword ptr [7FFE61F558F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F55AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M03_L02
M03_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M03_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r14d,[rsi+1]
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M03_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE626FE6D0]
       jmp       short M03_L00
; Total bytes of code 159
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList_Comparer()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,193E5807800
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,193E5807808
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,193DD801DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE6287E478]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rsi,[rbx+280]
       xor       edi,edi
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       r9d,edi
       mov       r15,[rsi+r9*8+10]
       mov       r13,[r15+28]
       test      r13,r13
       je        short M00_L02
       mov       [rsp+20],r13
       mov       r9,[rbp+18]
       mov       [rsp+28],r9
       mov       r9d,[rbp+30]
       mov       rdx,[rbp+8]
       mov       rcx,7FFE62884240
       xor       r8d,r8d
       call      qword ptr [7FFE6287E940]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFE6287E820]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       inc       edi
       cmp       r14d,edi
       jg        short M00_L00
M00_L01:
       mov       ecx,[rbp+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,899
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DE6790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623CD860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FFE623CD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C5F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 397
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       cmp       [rcx+8],esi
       je        near ptr M01_L10
       mov       edi,[rbx+30]
       cmp       esi,edi
       jl        near ptr M01_L11
       test      esi,esi
       jle       near ptr M01_L05
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+68]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62976A48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       movsxd    rsi,esi
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62976A50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       test      edi,edi
       jg        near ptr M01_L12
M01_L04:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FFE62976810
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rbp
       mov       rdx,7FFE62976848
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L10:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,7A7
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE623CD830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FFE61D0D4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFE61BA7738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FFE61BA7738]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M01_L04
; Total bytes of code 469
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M02_L04
       test      edi,edi
       jl        near ptr M02_L05
       test      ebp,ebp
       jl        near ptr M02_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M02_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FFE62974F18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M02_L02
       mov       [rsp+20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FFE62974F28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E9E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M02_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F55B18]
       int       3
M02_L05:
       call      qword ptr [7FFE61F558C0]
       int       3
M02_L06:
       call      qword ptr [7FFE61F558F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F55AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M03_L02
M03_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M03_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r14d,[rsi+1]
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M03_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE6287E6D0]
       jmp       short M03_L00
; Total bytes of code 159
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList_Comparer()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1E6C9801FE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E6C980F7E8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,1E6C9801DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE628EEAA8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rsi,[rbx+280]
       xor       edi,edi
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       r9d,edi
       mov       r15,[rsi+r9*8+10]
       mov       r13,[r15+28]
       test      r13,r13
       je        short M00_L02
       mov       [rsp+20],r13
       mov       r9,[rbp+18]
       mov       [rsp+28],r9
       mov       r9d,[rbp+30]
       mov       rdx,[rbp+8]
       mov       rcx,7FFE628FB550
       xor       r8d,r8d
       call      qword ptr [7FFE628EEF58]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFE628EEE50]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       inc       edi
       cmp       r14d,edi
       jg        short M00_L00
M00_L01:
       mov       ecx,[rbp+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,899
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DC6790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AD860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FFE623AD7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 397
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       cmp       [rcx+8],esi
       je        near ptr M01_L10
       mov       edi,[rbx+30]
       cmp       esi,edi
       jl        near ptr M01_L11
       test      esi,esi
       jle       near ptr M01_L05
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+68]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE6295C010
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       movsxd    rsi,esi
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE6295C018
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       test      edi,edi
       jg        near ptr M01_L12
M01_L04:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FFE6295BDD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rbp
       mov       rdx,7FFE6295BE10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L10:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,7A7
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE623AD830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FFE61CED4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFE61B87738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FFE61B87738]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M01_L04
; Total bytes of code 469
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M02_L04
       test      edi,edi
       jl        near ptr M02_L05
       test      ebp,ebp
       jl        near ptr M02_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M02_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FFE6295B5A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M02_L02
       mov       [rsp+20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FFE6295B5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E7E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M02_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F35B18]
       int       3
M02_L05:
       call      qword ptr [7FFE61F358C0]
       int       3
M02_L06:
       call      qword ptr [7FFE61F358F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F35AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M03_L02
M03_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M03_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r14d,[rsi+1]
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M03_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE628EED00]
       jmp       short M03_L00
; Total bytes of code 159
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Add_SortedList_Comparer()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1D25F401FE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1D25F40F7E8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,1D25F401DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE62995F68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rsi,[rbx+280]
       xor       edi,edi
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       r9d,edi
       mov       r15,[rsi+r9*8+10]
       mov       r13,[r15+28]
       test      r13,r13
       je        short M00_L02
       mov       [rsp+20],r13
       mov       r9,[rbp+18]
       mov       [rsp+28],r9
       mov       r9d,[rbp+30]
       mov       rdx,[rbp+8]
       mov       rcx,7FFE6298BB28
       xor       r8d,r8d
       call      qword ptr [7FFE62996418]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFE62996310]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       inc       edi
       cmp       r14d,edi
       jg        short M00_L00
M00_L01:
       mov       ecx,[rbp+30]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,899
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DE6790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623CC0F0]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FFE623CC030]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE61C5F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 397
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       cmp       [rcx+8],esi
       je        near ptr M01_L10
       mov       edi,[rbx+30]
       cmp       esi,edi
       jl        near ptr M01_L11
       test      esi,esi
       jle       near ptr M01_L05
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+68]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE6297F148
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       movsxd    rsi,esi
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE6297F150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       test      edi,edi
       jg        near ptr M01_L12
M01_L04:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FFE6297EF10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rbp
       mov       rdx,7FFE6297EF48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L10:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,7A7
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE623CC0C0]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FFE61D0D4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFE61BA7738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FFE61BA7738]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M01_L04
; Total bytes of code 469
```
```assembly
; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M02_L04
       test      edi,edi
       jl        near ptr M02_L05
       test      ebp,ebp
       jl        near ptr M02_L06
       mov       ecx,[rsi+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M02_L07
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FFE6297B5F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L01:
       mov       rcx,[rbx+10]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M02_L02
       mov       [rsp+20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FFE6297B600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FFE61E9E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rbx,[rsp+80]
       mov       [rsp+80],rbx
       mov       rbx,[rsp+88]
       mov       [rsp+88],rbx
       mov       r11,[rsp+20]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9d,ebp
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [r11]
M02_L04:
       mov       ecx,2
       call      qword ptr [7FFE61F55B18]
       int       3
M02_L05:
       call      qword ptr [7FFE61F558C0]
       int       3
M02_L06:
       call      qword ptr [7FFE61F558F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FFE61F55AB8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,r8
       mov       rbp,r9
       mov       ecx,[rbx+30]
       mov       r8,[rbx+8]
       cmp       ecx,[r8+8]
       je        short M03_L02
M03_L00:
       mov       ecx,[rbx+30]
       cmp       esi,ecx
       jge       short M03_L01
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+8]
       mov       rcx,r8
       lea       r14d,[rsi+1]
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M03_L01:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbx+10]
       movsxd    rdx,esi
       mov       r8,rbp
       call      CORINFO_HELP_ARRADDR_ST
       inc       dword ptr [rbx+30]
       inc       dword ptr [rbx+34]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       edx,[rbx+30]
       inc       edx
       mov       rcx,rbx
       call      qword ptr [7FFE629961C0]
       jmp       short M03_L00
; Total bytes of code 159
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,20BEB801FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE61CEDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE61CEE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE620F69D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620F67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DC6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 289
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
       mov       rdx,7FFE623C0310
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
       call      qword ptr [7FFE61F35B60]
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
       mov       rdx,7FFE623C0300
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62844F38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C34348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62844F78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE62844F90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE62844F48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62844F60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF1058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F35B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61CEE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF1060
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 544
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C31E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F35D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,24C7D5E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,18AFA401FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE61CFDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE61CFE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE621069D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621067C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 289
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
       mov       rdx,7FFE623D0310
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
       call      qword ptr [7FFE61F45B60]
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
       mov       rdx,7FFE623D0300
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62855618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62855658
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE62855670
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE62855628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62855640
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B01058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61CFE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B01060
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 544
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C41E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F45D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,1CB8C540008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,293D5401FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE61D1DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE61D1E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE621269D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621267C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DF6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 289
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
       mov       rdx,7FFE6238DED8
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
       call      qword ptr [7FFE61F65B60]
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
       mov       rdx,7FFE6238DEC8
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62874ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62874F18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE62874F30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE62874EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62874F00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F65B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61D1E2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21060
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 544
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C61E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61D15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61D15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F65D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,2D463240008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,2B673801FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE61D0DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE61D0E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE621169D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F7BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F7BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F7BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DE6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 289
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
       mov       rdx,7FFE6237DB60
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
       call      qword ptr [7FFE61F55B60]
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
       mov       rdx,7FFE6237DB50
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628BC518
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628BC558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE628BC570
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE628BC528
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628BC540
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B111A0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61D0E2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B111A8
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 547
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C51E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61D05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61D05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F55D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,2F7015D0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,1DCF9C01FF8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE61CDDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE61CDE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE620E69D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C26B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C26B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DB6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 289
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
       mov       rdx,7FFE6234EAE0
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
       call      qword ptr [7FFE61F25B60]
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
       mov       rdx,7FFE6234EAD0
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE6289CD28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C24348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE6289CD68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE6289CD80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE6289CD38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE6289CD50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61CDE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE1260
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F25B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61CDE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE1268
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 547
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C21E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CD5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CD5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F25D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,21D8B9A0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,252CC00F7E0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE61CFDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE61CFE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE621069D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621067C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 289
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
       mov       rdx,7FFE623D0308
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
       call      qword ptr [7FFE61F45B60]
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
       mov       rdx,7FFE623D02F8
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62964028
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62964068
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE62964080
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE62964038
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62964050
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B019D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61CFE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B019E0
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 547
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C41E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F45D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,29359D70008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,24F5880F7E8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE61CEDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE61CEE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE620F69D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620F67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DC6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 289
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
       mov       rdx,7FFE623C0340
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
       call      qword ptr [7FFE61F35B60]
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
       mov       rdx,7FFE623C0330
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE6295A2F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C34348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE6295A338
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE6295A350
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE6295A308
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE6295A320
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF1B98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F35B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61CEE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF1BA0
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 547
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C31E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F35D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,28FEA900008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,110BEC0F7E8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE61CDDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE61CDE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE620E69D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C26B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C26B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DB6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 289
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
       mov       rdx,7FFE623B0340
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
       call      qword ptr [7FFE61F25B60]
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
       mov       rdx,7FFE623B0330
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE6294E560
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C24348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE6294E5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE6294E5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE6294E570
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE6294E588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61CDE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE1D98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F25B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61CDE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE1DA0
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 547
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C21E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CD5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CD5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F25D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,1514CAB0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE61CEDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FFE61CEE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rbp+28],0
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE620F69D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F5BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C36B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620F67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DC6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
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
       mov       rdx,7FFE623C0340
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
       call      qword ptr [7FFE61F35B60]
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
       mov       rdx,7FFE623C0330
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628452C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C34348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62845300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE62845318
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE628452D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628452E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF1058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F35B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61CEE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF1060
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 544
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C31E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F35D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,20DD2780008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE61CFDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FFE61CFE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rbp+28],0
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE621069D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621067C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
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
       mov       rdx,7FFE623D0A10
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
       call      qword ptr [7FFE61F45B60]
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
       mov       rdx,7FFE623D0A00
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62854CE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62854D20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE62854D38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE62854CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62854D08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B01058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61CFE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B01060
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 544
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C41E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F45D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,18A32470008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE61D1DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FFE61D1E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rbp+28],0
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE621269D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621267C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DF6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
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
       mov       rdx,7FFE623F0340
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
       call      qword ptr [7FFE61F65B60]
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
       mov       rdx,7FFE623F0330
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62874D08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62874D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE62874D60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE62874D18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62874D30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F65B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61D1E2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21060
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 544
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C61E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61D15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61D15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F65D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,202D1660008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE61CDDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FFE61CDE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rbp+28],0
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE620E69D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C26B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C26B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DB6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
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
       mov       rdx,7FFE623B0310
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
       call      qword ptr [7FFE61F25B60]
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
       mov       rdx,7FFE623B0300
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62835300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C24348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62835340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE62835358
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE62835310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62835328
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61CDE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE1058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F25B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61CDE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE1060
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 544
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C21E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CD5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CD5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F25D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,2611A770008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE61CFDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FFE61CFE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rbp+28],0
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE621069D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621067C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
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
       mov       rdx,7FFE6236E250
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
       call      qword ptr [7FFE61F45B60]
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
       mov       rdx,7FFE6236E240
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628D2468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628D24A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE628D24C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE628D2478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628D2490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B01268
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61CFE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B01270
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 547
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C41E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F45D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,1B3CBC80008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE61D1DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FFE61D1E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rbp+28],0
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE621269D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F8BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621267C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DF6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
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
       mov       rdx,7FFE6238FEA0
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
       call      qword ptr [7FFE61F65B60]
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
       mov       rdx,7FFE6238FE90
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62983B18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62983B58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE62983B70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE62983B28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62983B40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21AE8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F65B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61D1E2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21AF0
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 547
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C61E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61D15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61D15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F65D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,25FD6DD0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE61CDDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FFE61CDE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rbp+28],0
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE620E69D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C26B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F4BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C26B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE620E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DB6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
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
       mov       rdx,7FFE623B0308
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
       call      qword ptr [7FFE61F25B60]
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
       mov       rdx,7FFE623B02F8
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE629495D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C24348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62949618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE62949630
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE629495E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62949600
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61CDE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE1A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F25B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61CDE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE1AA0
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 547
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C21E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CD5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CD5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F25D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,1C5A45C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.AddRange_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FFE61CFDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FFE61CFE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rbp+28],0
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE621069D0]
       mov       ecx,3F3E
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE61F6BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C46B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE621067C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE61DD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
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
       mov       rdx,7FFE6236CDA0
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
       call      qword ptr [7FFE61F45B60]
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
       mov       rdx,7FFE6236CD90
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFE6296D6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFE6296D6F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       sub       edx,[rcx+10]
       cmp       edx,ebx
       jl        near ptr M02_L18
M02_L04:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFE6296D710
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFE6296D6C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M02_L14
M02_L10:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFE6296D6E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M02_L13
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L14
M02_L13:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B01DC0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L19
       nop
M02_L15:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FFE61CFE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       jmp       near ptr M02_L04
M02_L19:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M02_L20
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B01DC8
       call      qword ptr [r11]
M02_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 547
```
```assembly
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
       je        near ptr M03_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M03_L01
       call      00007FFE61C41E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE61CF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFE61F45D58]
       int       3
M03_L02:
       test      rbx,rbx
       je        short M03_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M03_L04
M03_L03:
       mov       rax,1A5BBDF0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,15536801FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62865D68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62865DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623E0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62865DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623E0D08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62865D78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62865D90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B11058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623E0D08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B11060
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1E4B0001FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CFDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628556A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628556E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623D0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628556F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623D0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628556B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628556C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B01058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623D0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B01060
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,21D8D001FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62866450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62866490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6237FEA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628664A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6237FE98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62866460
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62866478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B11058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6237FE98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B11060
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,23B69001FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CFDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628ACC80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628ACCC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623D0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628ACCD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623D0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628ACC90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628ACCA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B011D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623D0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B011E0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,299BAC01FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628F02D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628F0310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623F0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628F0328
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623F0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628F02E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628F02F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21230
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F65B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623F0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21238
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1CDB080F7E0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE629848A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE629848E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6238E7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE629848F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6238E7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE629848B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE629848C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21AE8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F65B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6238E7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21AF0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2839700D7F0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CEDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE6295A110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C34348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE6295A150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623C0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE6295A168
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623C0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE6295A120
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE6295A138
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF1BA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F35B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623C0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF1BB0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1BA4A80F7E8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE6298E0F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE6298E138
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6238E4F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE6298E150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6238E4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE6298E108
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE6298E120
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21DB8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F65B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6238E4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21DC0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+288]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE626ADB60]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62857088
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62857618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6207E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62857650
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6207E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62857708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E8E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE626ADBF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,offset System.Gen2GcCallback.Finalize()
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE628570C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62857228
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62857240
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628573D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE626AE088]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628573F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623BD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623BD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C4F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DD66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+288]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE626CDB60]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62877370
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62877900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62877938
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE628779F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61EAE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE626CDBF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62877390
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE628773A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62877510
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62877528
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628776C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE626CE088]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628776E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623DC0F0]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623DC030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C6F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DF66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+288]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE6268D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62837990
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62837F20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6205E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62837F58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6205E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62838010
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E6E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE6268D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE628379B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE628379C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62837B30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62837B48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62837CE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6268DD58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62837D00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE6239D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE6239D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C2F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F153F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DB66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+288]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE626AEDF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE628AFC00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE628D0190
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6207E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE628D01C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6207E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE628D0280
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E8E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE626AEE80]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE628AFC20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE628AFC38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE628AFDA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE628AFDB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628AFF50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE626AF318]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628AFF70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623BD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623BD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C4F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DD66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+288]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE626FEDF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE628F3658
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE628F3BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE628F3C20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE628F3CD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61EAE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE626FEE80]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,offset Perfolizer.Metrology.MeasurementUnit.get_BaseUnits()
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE628F3690
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE628F37F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE628F3810
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628F39A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE626FF318]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,offset BenchmarkDotNet.Characteristics.CompositeResolver.Resolve[[Perfolizer.Mathematics.OutlierDetection.OutlierMode, Perfolizer]](BenchmarkDotNet.Characteristics.CharacteristicObject, BenchmarkDotNet.Characteristics.Characteristic`1<Perfolizer.Mathematics.OutlierDetection.OutlierMode>)
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623DD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623DD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C6F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DF66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+288]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE6285D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62954840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62954DD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62954E08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62954EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E7E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE6285D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62954860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62954878
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE629549E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE629549F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62954B90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6285DD58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62954BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623AD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DC66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+288]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE6286EA18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62962E60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE629633F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62963428
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE629634E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E7E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE6286EAA8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62962E80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62962E98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62963000
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,offset Perfolizer.Metrology.MeasurementUnit.get_BaseUnits()
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE629631B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6286EF28]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE629631D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623AD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DC66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+288]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE62975830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE629910C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62991650
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62991688
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62991740
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E7E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE629758C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE629910E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE629910F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62991260
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62991278
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62991410
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE62975D40]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62991430
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623AD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DC66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61CEDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628451D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C34348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62845218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623C0308
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62845230
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623C02F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628451E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62845200
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF1058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F35B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623C02F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF1060
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62865AF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62865B30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623E0360
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62865B48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623E0350
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62865B00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62865B18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B11058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623E0350
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B11060
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61CFDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628553C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62855400
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623D0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62855418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623D0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628553D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628553E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B01058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623D0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B01060
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628B8118
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628B8158
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623E0310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628B8170
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623E0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628B8128
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628B8140
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B11100
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623E0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B11108
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61D1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628F30D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628F3110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623F0EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628F3128
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623F0EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628F30E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628F30F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21268
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F65B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623F0EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21270
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61D1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE629843E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62984428
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623F0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62984440
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623F0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE629843F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62984410
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21AE8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F65B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623F0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B21AF0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61CEDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62969E60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C34348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62969EA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623C0308
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62969EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623C02F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62969E70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62969E88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF1BB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F35B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623C02F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF1BB8
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61CDDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE6294D548
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C24348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE6294D588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623B0310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE6294D5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623B0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE6294D558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE6294D570
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CDE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE1D98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F25B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623B0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE1DA8
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+288]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE626BD830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62866F40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE628674D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62867508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE628675C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E9E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE626BD8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62866F60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62866F78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE628670E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE628670F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62867290
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE626BDD88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628672B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623CD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623CD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C5F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DE66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+288]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE626CD830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62876F90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62877520
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62877558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62877610
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61EAE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE626CD8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62876FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62876FC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62877130
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62877148
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628772E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE626CDD88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62877300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623DD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623DD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C6F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DF66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+288]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE6269D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62846FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62847530
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62847568
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62847620
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E7E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE6269D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62846FC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62846FD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62847140
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62847158
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628472F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6269DD88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62847310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623AD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DC66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+288]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE626CD830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62877A28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62877FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62877FF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE628780A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61EAE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE626CD8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62877A48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62877A60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62877BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62877BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62877D78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE626CDD88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62877D98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623DD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623DD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C6F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DF66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+288]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE627EF498]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE628CF5F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE628CFB80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE628CFBB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE628CFC70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E9E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE627EF528]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE628CF610
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE628CF628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE628CF790
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE628CF7A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628CF940
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE627EF9F0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628CF960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623CD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623CD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C5F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DE66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+288]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE6287D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62978A38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62978F98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62978FD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62979088
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E9E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE6287D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62978A58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62978A70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62978BD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62978BF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62978D88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6287DD70]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62978DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623CD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623CD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C5F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DE66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+288]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE6286EA18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62963668
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62963BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62963C30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62963CE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E7E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE6286EAA8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62963688
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE629636A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62963808
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62963820
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE629639B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6286EF58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE629639D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623ADB30]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623ADA70]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DC66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListCreateAddBenchmark.Create_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+288]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE62995830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+78]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE629B0B70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE629B1100
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE629B1138
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE629B11F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E9E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE629958C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE629B0B90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+88]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE629B0BA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+90]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE629B0D10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+98]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE629B0D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE629B0EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE62995D70]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0A8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,offset System.Buffers.SharedArrayPool`1+Partitions[[System.ValueTuple`5[[System.__Canon, System.Private.CoreLib],[System.Text.Json.JsonReaderState, System.Text.Json],[System.Int64, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Trim(Int32, Int32, MemoryPressure, Int32)
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623CD860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623CD7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C5F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DE66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

