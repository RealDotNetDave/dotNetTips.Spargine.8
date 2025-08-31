## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1D45DC01FE0
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
       call      qword ptr [7FF9004B69D0]
       mov       ecx,3F34
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004B67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900186718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9002F5B60]
       int       3
M00_L06:
       mov       rcx,1D45DC01FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FF9000AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF8FFFF1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9002F5D58]
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
       mov       rax,214E78E0008
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
       call      qword ptr [7FF9000ADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,2215E001FE0
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
       call      qword ptr [7FF9004C69D0]
       mov       ecx,3F34
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004C67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900196718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF900305B60]
       int       3
M00_L06:
       mov       rcx,2215E001FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FF9000BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF900001E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900305D58]
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
       mov       rax,261EFD90008
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
       call      qword ptr [7FF9000BDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,273CF401FE0
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
       call      qword ptr [7FF9004B69D0]
       mov       ecx,3F34
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004B67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900186718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9002F5B60]
       int       3
M00_L06:
       mov       rcx,273CF401FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FF9000AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF8FFFF1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9002F5D58]
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
       mov       rax,2B4614E0008
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
       call      qword ptr [7FF9000ADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1FADE801FE0
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
       call      qword ptr [7FF9004B69D0]
       mov       ecx,3F34
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004B67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900186718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9002F5B60]
       int       3
M00_L06:
       mov       rcx,1FADE801FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FF9000AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF8FFFF1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9002F5D58]
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
       mov       rax,23B705C0008
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
       call      qword ptr [7FF9000ADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,29E61801FE0
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
       call      qword ptr [7FF9004B69D0]
       mov       ecx,3F34
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004B67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900186718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9002F5B60]
       int       3
M00_L06:
       mov       rcx,29E61801FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FF9000AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF8FFFF1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9002F5D58]
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
       mov       rax,2DEF3790008
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
       call      qword ptr [7FF9000ADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1CBEF801FE0
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
       call      qword ptr [7FF9004E69D0]
       mov       ecx,3F34
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001B6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF900325B60]
       int       3
M00_L06:
       mov       rcx,1CBEF801FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900325D58]
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
       mov       rax,20C81810008
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
       call      qword ptr [7FF9000DDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,231AD801FF0
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
       call      qword ptr [7FF9004E69D0]
       mov       ecx,3F34
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001B6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF900325B60]
       int       3
M00_L06:
       mov       rcx,231AD801FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900325D58]
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
       mov       rax,2723F4E0008
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
       call      qword ptr [7FF9000DDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,2574780F7D8
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
       call      qword ptr [7FF9004E69D0]
       mov       ecx,3F34
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001B6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF900325B60]
       int       3
M00_L06:
       mov       rcx,25747801FB8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900325D58]
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
       mov       rax,297D96A0008
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
       call      qword ptr [7FF9000DDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,2183B001DD0
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
       mov       rcx,7FF900A4DF00
       xor       r8d,r8d
       call      qword ptr [7FF900A57F18]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF900A57E40]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF900186790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90076D860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF90076D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8FFFFF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF9002F5E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF900A5EE38]
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
       mov       rdx,7FF900C04358
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
       mov       rdx,7FF900C04368
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF90023E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF9002F5B18]
       int       3
M01_L05:
       call      qword ptr [7FF9002F58C0]
       int       3
M01_L06:
       call      qword ptr [7FF9002F58F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF9002F5AB8]
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
       call      qword ptr [7FF8FFF47750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FF8FFF47750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900A57CF0]
       jmp       short M02_L00
; Total bytes of code 153
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,16889C01DD0
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
       mov       rcx,7FF900A71530
       xor       r8d,r8d
       call      qword ptr [7FF900A6DD40]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF900A6DC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF900196790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90077D860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF90077D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90000F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF900305E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF900A94C60]
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
       mov       rdx,7FF900C160A8
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
       mov       rdx,7FF900C160B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF90024E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900305B18]
       int       3
M01_L05:
       call      qword ptr [7FF9003058C0]
       int       3
M01_L06:
       call      qword ptr [7FF9003058F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF900305AB8]
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
       call      qword ptr [7FF8FFF57750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FF8FFF57750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900A6DB18]
       jmp       short M02_L00
; Total bytes of code 153
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1E43A401DD0
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
       mov       rcx,7FF900A910D0
       xor       r8d,r8d
       call      qword ptr [7FF900A8D338]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF900A8D260]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9001B6790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90079D860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF90079D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90002F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF900325E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF900AB4588]
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
       mov       rdx,7FF900C35648
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
       mov       rdx,7FF900C35658
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF90026E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900325B18]
       int       3
M01_L05:
       call      qword ptr [7FF9003258C0]
       int       3
M01_L06:
       call      qword ptr [7FF9003258F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF900325AB8]
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
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900A8D110]
       jmp       short M02_L00
; Total bytes of code 153
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1D9FB801DD0
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
       mov       rcx,7FF900A61530
       xor       r8d,r8d
       call      qword ptr [7FF900A5DD40]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF900A5DC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF900186790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90076D860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF90076D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8FFFFF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF9002F5E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF900A84C60]
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
       mov       rdx,7FF900C06210
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
       mov       rdx,7FF900C06220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF90023E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF9002F5B18]
       int       3
M01_L05:
       call      qword ptr [7FF9002F58C0]
       int       3
M01_L06:
       call      qword ptr [7FF9002F58F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF9002F5AB8]
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
       call      qword ptr [7FF8FFF47750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FF8FFF47750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900A5DB18]
       jmp       short M02_L00
; Total bytes of code 153
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1D11FC01DD0
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
       mov       rcx,7FF900A912F0
       xor       r8d,r8d
       call      qword ptr [7FF900A8DD40]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF900A8DC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9001B6790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90079D860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF90079D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90002F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF900325E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF900AB4F90]
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
       mov       rdx,7FF900C36210
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
       mov       rdx,7FF900C36220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF90026E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900325B18]
       int       3
M01_L05:
       call      qword ptr [7FF9003258C0]
       int       3
M01_L06:
       call      qword ptr [7FF9003258F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF900325AB8]
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
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900A8DB18]
       jmp       short M02_L00
; Total bytes of code 159
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,16108001DD0
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
       mov       rcx,7FF900A912F0
       xor       r8d,r8d
       call      qword ptr [7FF900A8D338]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF900A8D260]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9001B6790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90079D860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF90079D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90002F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF900325E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF900AB4588]
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
       mov       rdx,7FF900C35CF8
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
       mov       rdx,7FF900C35D08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF90026E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900325B18]
       int       3
M01_L05:
       call      qword ptr [7FF9003258C0]
       int       3
M01_L06:
       call      qword ptr [7FF9003258F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF900325AB8]
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
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900A8D110]
       jmp       short M02_L00
; Total bytes of code 159
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,18702801DD0
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
       mov       rcx,7FF900B93280
       xor       r8d,r8d
       call      qword ptr [7FF900B8CD08]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF900B8CC30]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9001B6790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90079D860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF90079D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90002F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF900325E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF900A063E8]
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
       mov       rdx,7FF900C9C610
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
       mov       rdx,7FF900C9C620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF90026E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900325B18]
       int       3
M01_L05:
       call      qword ptr [7FF9003258C0]
       int       3
M01_L06:
       call      qword ptr [7FF9003258F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF900325AB8]
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
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900B8CAE0]
       jmp       short M02_L00
; Total bytes of code 159
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,20354401DD0
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
       mov       rcx,7FF900C35050
       xor       r8d,r8d
       call      qword ptr [7FF900C2DD40]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF900C2DC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF900196790]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90077D860]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF90077D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90000F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF900305E00]
       int       3
M00_L07:
       mov       ecx,87B
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF9009E63A0]
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
       mov       rdx,7FF900D24C68
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
       mov       rdx,7FF900D24C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF90024E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900305B18]
       int       3
M01_L05:
       call      qword ptr [7FF9003058C0]
       int       3
M01_L06:
       call      qword ptr [7FF9003058F0]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF900305AB8]
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
       call      qword ptr [7FF8FFF57750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FF8FFF57750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900C2DB18]
       jmp       short M02_L00
; Total bytes of code 159
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       eax,eax
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
       call      qword ptr [7FF9004D69D0]
       mov       ecx,3F34
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004D67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001A6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF900315B60]
       int       3
M00_L06:
       mov       rcx,1ABFA401FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FF9000CE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L02
; Total bytes of code 463
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
       call      00007FF900011E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900315D58]
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
       mov       rax,1EC8C2B0008
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
       call      qword ptr [7FF9000CDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9004D69D0]
       mov       ecx,3F34
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004D67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001A6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF900315B60]
       int       3
M00_L06:
       mov       rcx,18C54801FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FF9000CE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF900011E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900315D58]
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
       mov       rax,1CCE6720008
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
       call      qword ptr [7FF9000CDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9004E69D0]
       mov       ecx,3F34
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001B6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF900325B60]
       int       3
M00_L06:
       mov       rcx,22CA6C01FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900325D58]
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
       mov       rax,26D38A70008
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
       call      qword ptr [7FF9000DDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9004E69D0]
       mov       ecx,3F34
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001B6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF900325B60]
       int       3
M00_L06:
       mov       rcx,21AA1801FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900325D58]
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
       mov       rax,25B33530008
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
       call      qword ptr [7FF9000DDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9004B69D0]
       mov       ecx,3F34
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004B67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900186718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9002F5B60]
       int       3
M00_L06:
       mov       rcx,1F558C01FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FF9000AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF8FFFF1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9002F5D58]
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
       mov       rax,235EA900008
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
       call      qword ptr [7FF9000ADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9004B69D0]
       mov       ecx,3F34
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004B67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900186718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9002F5B60]
       int       3
M00_L06:
       mov       rcx,248DE401FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FF9000AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF8FFFF1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9002F5D58]
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
       mov       rax,28970180008
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
       call      qword ptr [7FF9000ADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9004C69D0]
       mov       ecx,3F34
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004C67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900196718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF900305B60]
       int       3
M00_L06:
       mov       rcx,185E9401FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FF9000BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF900001E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900305D58]
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
       mov       rax,1C67B400008
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
       call      qword ptr [7FF9000BDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9004B69D0]
       mov       ecx,3F34
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004B67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900186718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9002F5B60]
       int       3
M00_L06:
       mov       rcx,19358401FB8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FF9000AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007FF8FFFF1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9002F5D58]
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
       mov       rax,1D3EA210008
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
       call      qword ptr [7FF9000ADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,108C6401FE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,108C6401FE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,108C6401DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FF900A87A98]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rcx,7FF900A7E1B8
       xor       r8d,r8d
       call      qword ptr [7FF900A87F60]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FF900A87E40]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9001B6790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90079D860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FF90079D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90002F750]
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
       mov       rdx,7FF900C34758
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
       mov       rdx,7FF900C34760
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
       mov       rdx,7FF900C34520
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FF90045E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C34558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FF90045E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF90079D830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FF9000DD4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF8FFF77738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FF8FFF77738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF900C33D40
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
       mov       rdx,7FF900C33D50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FF90026E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900325B18]
       int       3
M02_L05:
       call      qword ptr [7FF9003258C0]
       int       3
M02_L06:
       call      qword ptr [7FF9003258F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FF900325AB8]
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
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900A87CF0]
       jmp       short M03_L00
; Total bytes of code 153
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1CA9DC01FD8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1CA9DC01FE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,1CA9DC01DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FF900A6D710]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rcx,7FF900A71318
       xor       r8d,r8d
       call      qword ptr [7FF900A6DBD8]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FF900A6DAB8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF900196790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90077D860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FF90077D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90000F750]
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
       mov       rdx,7FF900C16D98
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
       mov       rdx,7FF900C16DA0
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
       mov       rdx,7FF900C16B60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C16B98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF90077D830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FF9000BD4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF8FFF57738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FF8FFF57738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF900C16380
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
       mov       rdx,7FF900C16390
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FF90024E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900305B18]
       int       3
M02_L05:
       call      qword ptr [7FF9003058C0]
       int       3
M02_L06:
       call      qword ptr [7FF9003058F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FF900305AB8]
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
       call      qword ptr [7FF8FFF57750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FF8FFF57750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900A6D968]
       jmp       short M03_L00
; Total bytes of code 153
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,22AB8C01FE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,22AB8C01FE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,22AB8C01DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FF900A6D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rcx,7FF900A717E8
       xor       r8d,r8d
       call      qword ptr [7FF900A6DD88]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FF900A6DC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF900196790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90077D860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FF90077D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90000F750]
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
       mov       rdx,7FF900C16608
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
       mov       rdx,7FF900C16610
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
       mov       rdx,7FF900C163D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C16408
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF90077D830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FF9000BD4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF8FFF57738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FF8FFF57738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF900C15AA0
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
       mov       rdx,7FF900C15AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FF90024E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900305B18]
       int       3
M02_L05:
       call      qword ptr [7FF9003058C0]
       int       3
M02_L06:
       call      qword ptr [7FF9003058F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FF900305AB8]
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
       call      qword ptr [7FF8FFF57750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FF8FFF57750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900A6DB18]
       jmp       short M03_L00
; Total bytes of code 153
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,19E8C001FE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,19E8C001FE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,19E8C001DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FF900A8D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rcx,7FF900A91388
       xor       r8d,r8d
       call      qword ptr [7FF900A8DD88]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FF900A8DC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9001B6790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90079D860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FF90079D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90002F750]
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
       mov       rdx,7FF900C36820
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
       mov       rdx,7FF900C36828
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
       mov       rdx,7FF900C365E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FF90045E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C36620
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FF90045E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF90079D830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FF9000DD4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF8FFF77738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FF8FFF77738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF900C35E08
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
       mov       rdx,7FF900C35E18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FF90026E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900325B18]
       int       3
M02_L05:
       call      qword ptr [7FF9003258C0]
       int       3
M02_L06:
       call      qword ptr [7FF9003258F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FF900325AB8]
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
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900A8DB18]
       jmp       short M03_L00
; Total bytes of code 153
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1E45E401FE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E45E401FE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,1E45E401DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FF900A6D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rcx,7FF900A71B78
       xor       r8d,r8d
       call      qword ptr [7FF900A6DD88]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FF900A6DC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF900196790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90077D860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FF90077D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90000F750]
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
       mov       rdx,7FF900C16D80
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
       mov       rdx,7FF900C16D88
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
       mov       rdx,7FF900C16B48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C16B80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF90077D830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FF9000BD4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF8FFF57738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FF8FFF57738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF900C16218
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
       mov       rdx,7FF900C16228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FF90024E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900305B18]
       int       3
M02_L05:
       call      qword ptr [7FF9003058C0]
       int       3
M02_L06:
       call      qword ptr [7FF9003058F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FF900305AB8]
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
       call      qword ptr [7FF8FFF57750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FF8FFF57750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900A6DB18]
       jmp       short M03_L00
; Total bytes of code 159
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,28CAE001FE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,28CAE001FE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,28CAE001DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FF900A8D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rcx,7FF900A915A8
       xor       r8d,r8d
       call      qword ptr [7FF900A8DD88]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FF900A8DC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9001B6790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90079D860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FF90079D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90002F750]
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
       mov       rdx,7FF900C369C0
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
       mov       rdx,7FF900C369C8
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
       mov       rdx,7FF900C36788
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FF90045E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C367C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FF90045E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF90079D830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FF9000DD4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF8FFF77738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FF8FFF77738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF900C35FA8
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
       mov       rdx,7FF900C35FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FF90026E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900325B18]
       int       3
M02_L05:
       call      qword ptr [7FF9003258C0]
       int       3
M02_L06:
       call      qword ptr [7FF9003258F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FF900325AB8]
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
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FF8FFF77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900A8DB18]
       jmp       short M03_L00
; Total bytes of code 159
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,286AC401FF0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,286AC401FF8
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,286AC401DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FF900B9FA50]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rcx,7FF900BA5C78
       xor       r8d,r8d
       call      qword ptr [7FF900B9FF18]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FF900B9FDF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF900186790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90076D860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FF90076D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8FFFFF750]
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
       mov       rdx,7FF900C6F1C8
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
       mov       rdx,7FF900C6F1D0
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
       mov       rdx,7FF900C6EF90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FF90042E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C6EFC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FF90042E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF90076D830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FF9000AD4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF8FFF47738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FF8FFF47738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF900C6ED30
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
       mov       rdx,7FF900C6ED40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FF90023E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF9002F5B18]
       int       3
M02_L05:
       call      qword ptr [7FF9002F58C0]
       int       3
M02_L06:
       call      qword ptr [7FF9002F58F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FF9002F5AB8]
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
       call      qword ptr [7FF8FFF47750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FF8FFF47750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900B9FCA8]
       jmp       short M03_L00
; Total bytes of code 159
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1A609001FE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1A60900F7E0
       mov       rdx,[rcx]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+30],ecx
       mov       rcx,1A609001DD0
       mov       rdx,[rcx]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       edx,edi
       call      qword ptr [7FF900C2D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rcx,7FF900C351F0
       xor       r8d,r8d
       call      qword ptr [7FF900C2DD70]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       short M00_L03
       mov       edx,eax
       not       edx
       mov       rcx,rbp
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FF900C2DC68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF900196790]
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF90077D860]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FF90077D7A0]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF90000F750]
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
       mov       rdx,7FF900D26B50
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
       mov       rdx,7FF900D26B58
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
       mov       rdx,7FF900D26918
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L07:
       mov       rcx,rdx
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900D26950
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF90077D830]
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      qword ptr [7FF9000BD4A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF8FFF57738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbx+10]
       mov       r8d,[rbx+30]
       mov       rdx,rsi
       call      qword ptr [7FF8FFF57738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF900D244D0
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
       mov       rdx,7FF900D244E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FF90024E148]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900305B18]
       int       3
M02_L05:
       call      qword ptr [7FF9003058C0]
       int       3
M02_L06:
       call      qword ptr [7FF9003058F0]
       int       3
M02_L07:
       mov       ecx,10
       call      qword ptr [7FF900305AB8]
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
       call      qword ptr [7FF8FFF57750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FF8FFF57750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF900C2DB18]
       jmp       short M03_L00
; Total bytes of code 159
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,17766001FD8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF9000DDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9000DE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004E69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001B6718]
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
       mov       rdx,7FF9007B0360
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
       call      qword ptr [7FF900325B60]
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
       mov       rdx,7FF9007B0350
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
       mov       rdx,7FF900C338A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C338E0
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
       mov       rdx,7FF900C338F8
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
       mov       rdx,7FF900C338B0
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
       mov       rdx,7FF900C338C8
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
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEE1058
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
       call      qword ptr [7FF900325B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000DE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFEE1060
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
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900325D58]
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
       mov       rax,1B7F80E0008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,202F0001FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF9000DDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9000DE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004E69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001B6718]
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
       mov       rdx,7FF9007B0CF0
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
       call      qword ptr [7FF900325B60]
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
       mov       rdx,7FF9007B0CE0
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
       mov       rdx,7FF900C34D30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C34D70
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
       mov       rdx,7FF900C34D88
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
       mov       rdx,7FF900C34D40
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
       mov       rdx,7FF900C34D58
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
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEE1058
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
       call      qword ptr [7FF900325B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000DE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFEE1060
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
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900325D58]
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
       mov       rax,24382020008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,2A1DC801FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF9000ADFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9000AE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004B69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004B67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900186718]
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
       mov       rdx,7FF90071FCE8
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
       call      qword ptr [7FF9002F5B60]
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
       mov       rdx,7FF90071FCD8
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
       mov       rdx,7FF900C056F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C05730
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
       mov       rdx,7FF900C05748
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
       mov       rdx,7FF900C05700
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
       mov       rdx,7FF900C05718
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
       call      qword ptr [7FF9000AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEB1058
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
       call      qword ptr [7FF9002F5B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000AE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFEB1060
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
       call      00007FF8FFFF1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9002F5D58]
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
       mov       rax,2E26E7E0008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,2BB3D001FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF9000CDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9000CE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004D69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004D67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001A6718]
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
       mov       rdx,7FF9007A0318
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
       call      qword ptr [7FF900315B60]
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
       mov       rdx,7FF9007A0308
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
       mov       rdx,7FF900C25A88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C25AC8
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
       mov       rdx,7FF900C25AE0
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
       mov       rdx,7FF900C25A98
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
       mov       rdx,7FF900C25AB0
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
       call      qword ptr [7FF9000CE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFED1058
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
       call      qword ptr [7FF900315B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000CE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFED1060
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
       call      00007FF900011E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900315D58]
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
       mov       rax,2FBCEF10008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1F32A001FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF9000CDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9000CE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004D69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004D67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001A6718]
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
       mov       rdx,7FF9007A0CE8
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
       call      qword ptr [7FF900315B60]
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
       mov       rdx,7FF9007A0CD8
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
       mov       rdx,7FF900C25180
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C251C0
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
       mov       rdx,7FF900C251D8
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
       mov       rdx,7FF900C25190
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
       mov       rdx,7FF900C251A8
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
       call      qword ptr [7FF9000CE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFED1058
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
       call      qword ptr [7FF900315B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000CE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFED1060
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
       call      00007FF900011E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900315D58]
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
       mov       rax,233BBD90008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,29321C01FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF9000DDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9000DE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004E69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001B6718]
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
       mov       rdx,7FF9007B0318
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
       call      qword ptr [7FF900325B60]
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
       mov       rdx,7FF9007B0308
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
       mov       rdx,7FF900C35B60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C35BA0
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
       mov       rdx,7FF900C35BB8
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
       mov       rdx,7FF900C35B70
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
       mov       rdx,7FF900C35B88
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
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEE1058
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
       call      qword ptr [7FF900325B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000DE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFEE1060
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
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900325D58]
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
       mov       rax,2D3B3990008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1FA6B401FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF9000CDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9000CE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004D69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004D67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001A6718]
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
       mov       rdx,7FF9007A0770
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
       call      qword ptr [7FF900315B60]
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
       mov       rdx,7FF9007A0760
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
       mov       rdx,7FF900CA13F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900CA1438
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
       mov       rdx,7FF900CA1450
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
       mov       rdx,7FF900CA1408
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
       mov       rdx,7FF900CA1420
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
       call      qword ptr [7FF9000CE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFED1230
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
       call      qword ptr [7FF900315B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000CE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFED1238
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
       call      00007FF900011E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900315D58]
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
       mov       rax,23AFD1C0008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,14D6540F7E0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF9000CDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9000CE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004D69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90033BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004D67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001A6718]
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
       mov       rdx,7FF90073FCA0
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
       call      qword ptr [7FF900315B60]
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
       mov       rdx,7FF90073FC90
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
       mov       rdx,7FF900D34178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900D341B8
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
       mov       rdx,7FF900D341D0
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
       mov       rdx,7FF900D34188
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
       mov       rdx,7FF900D341A0
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
       call      qword ptr [7FF9000CE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFED1AE8
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
       call      qword ptr [7FF900315B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000CE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFED1AF0
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
       call      00007FF900011E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900315D58]
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
       mov       rax,18DF72F0008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000DDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FF9000DE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004E69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001B6718]
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
       mov       rdx,7FF9007B0A10
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
       call      qword ptr [7FF900325B60]
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
       mov       rdx,7FF9007B0A00
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
       mov       rdx,7FF900C339F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C33A38
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
       mov       rdx,7FF900C33A50
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
       mov       rdx,7FF900C33A08
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
       mov       rdx,7FF900C33A20
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
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEE1060
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
       call      qword ptr [7FF900325B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000DE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFEE1068
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
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900325D58]
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
       mov       rax,2365B9D0008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000ADFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FF9000AE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004B69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004B67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900186718]
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
       mov       rdx,7FF900780B10
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
       call      qword ptr [7FF9002F5B60]
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
       mov       rdx,7FF900780B00
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
       mov       rdx,7FF900C04B28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C04B68
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
       mov       rdx,7FF900C04B80
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
       mov       rdx,7FF900C04B38
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
       mov       rdx,7FF900C04B50
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
       call      qword ptr [7FF9000AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEB1058
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
       call      qword ptr [7FF9002F5B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000AE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFEB1060
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
       call      00007FF8FFFF1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9002F5D58]
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
       mov       rax,32C001D0008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000BDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FF9000BE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004C69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004C67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900196718]
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
       mov       rdx,7FF90072FD60
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
       call      qword ptr [7FF900305B60]
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
       mov       rdx,7FF90072FD50
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
       mov       rdx,7FF900C15778
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C157B8
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
       mov       rdx,7FF900C157D0
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
       mov       rdx,7FF900C15788
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
       mov       rdx,7FF900C157A0
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
       call      qword ptr [7FF9000BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEC1058
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
       call      qword ptr [7FF900305B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000BE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFEC1060
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
       call      00007FF900001E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900305D58]
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
       mov       rax,1AB5D0D0008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000DDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FF9000DE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004E69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90034BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004E67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001B6718]
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
       mov       rdx,7FF9007B0310
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
       call      qword ptr [7FF900325B60]
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
       mov       rdx,7FF9007B0300
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
       mov       rdx,7FF900C35728
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C35768
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
       mov       rdx,7FF900C35780
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
       mov       rdx,7FF900C35738
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
       mov       rdx,7FF900C35750
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
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEE1060
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
       call      qword ptr [7FF900325B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000DE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFEE1068
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
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900325D58]
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
       mov       rax,2B84B320008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000BDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FF9000BE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004C69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004C67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900196718]
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
       mov       rdx,7FF900790318
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
       call      qword ptr [7FF900305B60]
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
       mov       rdx,7FF900790308
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
       mov       rdx,7FF900C155B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C155F0
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
       mov       rdx,7FF900C15608
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
       mov       rdx,7FF900C155C0
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
       mov       rdx,7FF900C155D8
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
       call      qword ptr [7FF9000BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEC1058
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
       call      qword ptr [7FF900305B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000BE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFEC1060
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
       call      00007FF900001E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900305D58]
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
       mov       rax,23577EF0008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000BDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FF9000BE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004C69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004C67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900196718]
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
       mov       rdx,7FF900790310
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
       call      qword ptr [7FF900305B60]
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
       mov       rdx,7FF900790300
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
       mov       rdx,7FF900C15C60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C15CA0
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
       mov       rdx,7FF900C15CB8
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
       mov       rdx,7FF900C15C70
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
       mov       rdx,7FF900C15C88
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
       call      qword ptr [7FF9000BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEC1058
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
       call      qword ptr [7FF900305B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000BE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFEC1060
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
       call      00007FF900001E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900305D58]
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
       mov       rax,221988A0008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000ADFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FF9000AE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004B69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90031BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004B67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900186718]
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
       mov       rdx,7FF90071FD40
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
       call      qword ptr [7FF9002F5B60]
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
       mov       rdx,7FF90071FD30
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
       mov       rdx,7FF900C6CC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C6CC88
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
       mov       rdx,7FF900C6CCA0
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
       mov       rdx,7FF900C6CC58
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
       mov       rdx,7FF900C6CC70
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
       call      qword ptr [7FF9000AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEB1268
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
       call      qword ptr [7FF9002F5B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000AE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFEB1270
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
       call      00007FF8FFFF1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9002F5D58]
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
       mov       rax,2B9F01C0008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000BDFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+280]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rbp
       call      qword ptr [7FF9000BE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9004C69D0]
       mov       ecx,3F3E
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FF90032BA80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9004C67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900196718]
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
       mov       rdx,7FF9007909E0
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
       call      qword ptr [7FF900305B60]
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
       mov       rdx,7FF9007909D0
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
       mov       rdx,7FF900D24348
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900D24388
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
       mov       rdx,7FF900D243A0
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
       mov       rdx,7FF900D24358
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
       mov       rdx,7FF900D24370
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
       call      qword ptr [7FF9000BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L14:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEC1AC0
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
       call      qword ptr [7FF900305B18]
       int       3
M02_L18:
       mov       rcx,[rbp+10]
       mov       edx,ebx
       add       edx,[rcx+10]
       jo        short M02_L16
       call      qword ptr [7FF9000BE2B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       r11,7FF8FFEC1AC8
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
       call      00007FF900001E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF900305D58]
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
       mov       rax,213329C0008
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,25EC4801FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C246A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C246E8
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
       mov       rdx,7FF90073F960
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
       mov       rdx,7FF900C24700
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
       mov       rdx,7FF90073F950
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
       mov       rdx,7FF900C246B8
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
       mov       rdx,7FF900C246D0
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
       call      qword ptr [7FF9000CE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFED1060
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
       call      qword ptr [7FF900315B18]
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
       mov       rdx,7FF90073F950
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
       mov       r11,7FF8FFED1068
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1800AC01FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C354B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C354F0
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
       mov       rdx,7FF90074E7E0
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
       mov       rdx,7FF900C35508
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
       mov       rdx,7FF90074E7D0
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
       mov       rdx,7FF900C354C0
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
       mov       rdx,7FF900C354D8
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
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEE1058
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
       call      qword ptr [7FF900325B18]
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
       mov       rdx,7FF90074E7D0
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
       mov       r11,7FF8FFEE1060
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,25680401FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF9000BDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C15AE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C15B20
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
       mov       rdx,7FF900790CD8
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
       mov       rdx,7FF900C15B38
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
       mov       rdx,7FF900790CC8
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
       mov       rdx,7FF900C15AF0
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
       mov       rdx,7FF900C15B08
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
       call      qword ptr [7FF9000BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEC1058
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
       call      qword ptr [7FF900305B18]
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
       mov       rdx,7FF900790CC8
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
       mov       r11,7FF8FFEC1060
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,2807D801FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C26480
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C264C0
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
       mov       rdx,7FF90073FD40
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
       mov       rdx,7FF900C264D8
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
       mov       rdx,7FF90073FD30
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
       mov       rdx,7FF900C26490
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
       mov       rdx,7FF900C264A8
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
       call      qword ptr [7FF9000CE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFED1058
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
       call      qword ptr [7FF900315B18]
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
       mov       rdx,7FF90073FD30
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
       mov       r11,7FF8FFED1060
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,272DE401FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C35408
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C35448
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
       mov       rdx,7FF9007B0CF0
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
       mov       rdx,7FF900C35460
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
       mov       rdx,7FF9007B0CE0
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
       mov       rdx,7FF900C35418
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
       mov       rdx,7FF900C35430
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
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEE1058
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
       call      qword ptr [7FF900325B18]
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
       mov       rdx,7FF9007B0CE0
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
       mov       r11,7FF8FFEE1060
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1B449001FE0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C35B00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C35B40
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
       mov       rdx,7FF9007B0B10
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
       mov       rdx,7FF900C35B58
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
       mov       rdx,7FF9007B0B00
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
       mov       rdx,7FF900C35B10
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
       mov       rdx,7FF900C35B28
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
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEE1058
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
       call      qword ptr [7FF900325B18]
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
       mov       rdx,7FF9007B0B00
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
       mov       r11,7FF8FFEE1060
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,135D6401FE8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900CA1A88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900CA1AC8
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
       mov       rdx,7FF9007A09E0
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
       mov       rdx,7FF900CA1AE0
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
       mov       rdx,7FF9007A09D0
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
       mov       rdx,7FF900CA1A98
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
       mov       rdx,7FF900CA1AB0
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
       call      qword ptr [7FF9000CE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFED1230
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
       call      qword ptr [7FF900315B18]
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
       mov       rdx,7FF9007A09D0
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
       mov       r11,7FF8FFED1238
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1F8B880F7D8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900D14A48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900D14A88
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
       mov       rdx,7FF90071FEB0
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
       mov       rdx,7FF900D14AA0
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
       mov       rdx,7FF90071FEA0
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
       mov       rdx,7FF900D14A58
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
       mov       rdx,7FF900D14A70
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
       call      qword ptr [7FF9000AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEB1AE8
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
       call      qword ptr [7FF9002F5B18]
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
       mov       rdx,7FF90071FEA0
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
       mov       r11,7FF8FFEB1AF0
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900A779C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C254C0
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
       mov       rdx,7FF900C25A50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C25A88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C25B40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90025E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900A77A50]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C254E0
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
       mov       rdx,7FF900C254F8
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
       mov       rdx,7FF900C25660
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
       mov       rdx,7FF900C25678
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
       mov       rdx,7FF900C25810
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900A77EE8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C25830
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
       call      qword ptr [7FF90078D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90078D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90001F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9003053F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001A66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900A6D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C17BF0
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
       mov       rdx,7FF900C18180
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C181B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C18270
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90024E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900A6D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C17C10
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
       mov       rdx,7FF900C17C28
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
       mov       rdx,7FF900C17D90
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
       mov       rdx,7FF900C17DA8
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
       mov       rdx,7FF900C17F40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900A6DD58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C17F60
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
       call      qword ptr [7FF90077D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90077D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90000F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001966E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900A7D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C27DC0
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
       mov       rdx,7FF900C28350
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C28388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C28440
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90025E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900A7D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C27DE0
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
       mov       rdx,7FF900C27DF8
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
       mov       rdx,7FF900C27F60
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
       mov       rdx,7FF900C27F78
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
       mov       rdx,7FF900C28110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900A7DD58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C28130
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
       call      qword ptr [7FF90078D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90078D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90001F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9003053F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001A66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900A5D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C07970
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
       mov       rdx,7FF900C07F00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90042E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C07F38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90042E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C07FF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90023E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900A5D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C07990
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
       mov       rdx,7FF900C079A8
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
       mov       rdx,7FF900C07B10
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
       mov       rdx,7FF900C07B28
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
       mov       rdx,7FF900C07CC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900A5DD58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C07CE0
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
       call      qword ptr [7FF90076D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90076D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFFF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001866E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900A6D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C17F00
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
       mov       rdx,7FF900C18490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C184C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C18580
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90024E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900A6D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C17F20
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
       mov       rdx,7FF900C17F38
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
       mov       rdx,7FF900C180A0
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
       mov       rdx,7FF900C180B8
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
       mov       rdx,7FF900C18250
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900A6DD58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,offset Perfolizer.Horology.TimeUnit+<>c__DisplayClass10_0.<GetBestTimeUnit>b__1(Perfolizer.Horology.TimeUnit)
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
       call      qword ptr [7FF90077D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90077D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90000F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001966E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900A7EDF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C696E0
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
       mov       rdx,7FF900C69C70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C69CA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C69D60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90025E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900A7EE80]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C69700
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
       mov       rdx,offset BenchmarkDotNet.Engines.EngineActualStage.GetOverhead(BenchmarkDotNet.Engines.IEngine)
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
       mov       rdx,7FF900C69880
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
       mov       rdx,7FF900C69898
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
       mov       rdx,7FF900C69A30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900A7F318]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C69A50
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
       call      qword ptr [7FF90078D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90078D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90001F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9003053F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001A66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900BAF360]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C8DF10
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
       mov       rdx,7FF900C8E4A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C8E4D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C8E590
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90025E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900BAF3F0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C8DF30
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
       mov       rdx,7FF900C8DF48
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
       mov       rdx,7FF900C8E0B0
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
       mov       rdx,7FF900C8E0C8
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
       mov       rdx,7FF900C8E260
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900BAF888]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C8E280
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
       call      qword ptr [7FF90078D8C0]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90078D800]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90001F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9003053F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001A66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900C2D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900D27230
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
       mov       rdx,7FF900D277C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900D277F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90043E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900D278B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90024E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900C2D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900D27250
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
       mov       rdx,7FF900D27268
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
       mov       rdx,7FF900D273D0
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
       mov       rdx,7FF900D273E8
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
       mov       rdx,7FF900D27580
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900C2DD40]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900D275A0
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
       call      qword ptr [7FF90077D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90077D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90000F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9002F53F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001966E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000BDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C14360
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C143A0
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
       mov       rdx,7FF90072E3B8
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
       mov       rdx,7FF900C143B8
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
       mov       rdx,7FF90072E3A8
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
       mov       rdx,7FF900C14370
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
       mov       rdx,7FF900C14388
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
       call      qword ptr [7FF9000BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEC1058
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
       call      qword ptr [7FF900305B18]
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
       mov       rdx,7FF90072E3A8
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
       mov       r11,7FF8FFEC1060
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000BDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C15410
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C15450
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
       mov       rdx,7FF900790D08
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
       mov       rdx,7FF900C15468
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
       mov       rdx,7FF900790CF8
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
       mov       rdx,7FF900C15420
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
       mov       rdx,7FF900C15438
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
       call      qword ptr [7FF9000BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEC1058
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
       call      qword ptr [7FF900305B18]
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
       mov       rdx,7FF900790CF8
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
       mov       r11,7FF8FFEC1060
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C35988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C359C8
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
       mov       rdx,7FF90074FE98
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
       mov       rdx,7FF900C359E0
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
       mov       rdx,7FF90074FE88
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
       mov       rdx,7FF900C35998
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
       mov       rdx,7FF900C359B0
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
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEE1058
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
       call      qword ptr [7FF900325B18]
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
       mov       rdx,7FF90074FE88
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
       mov       r11,7FF8FFEE1060
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C05E48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C05E88
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
       mov       rdx,7FF900780A10
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
       mov       rdx,7FF900C05EA0
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
       mov       rdx,7FF900780A00
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
       mov       rdx,7FF900C05E58
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
       mov       rdx,7FF900C05E70
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
       call      qword ptr [7FF9000AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEB1060
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
       call      qword ptr [7FF9002F5B18]
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
       mov       rdx,7FF900780A00
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
       mov       r11,7FF8FFEB1068
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000BDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C153B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C153F0
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
       mov       rdx,7FF900790868
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
       mov       rdx,7FF900C15408
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
       mov       rdx,7FF900790858
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
       mov       rdx,7FF900C153C0
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
       mov       rdx,7FF900C153D8
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
       call      qword ptr [7FF9000BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEC1058
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
       call      qword ptr [7FF900305B18]
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
       mov       rdx,7FF900790858
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
       mov       r11,7FF8FFEC1060
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C83710
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C83750
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
       mov       rdx,7FF9007B09E0
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
       mov       rdx,7FF900C83768
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
       mov       rdx,7FF9007B09D0
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
       mov       rdx,7FF900C83720
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
       mov       rdx,7FF900C83738
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
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEE10A8
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
       call      qword ptr [7FF900325B18]
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
       mov       rdx,7FF9007B09D0
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
       mov       r11,7FF8FFEE10B0
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900C9BA48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900C9BA88
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
       mov       rdx,7FF90074E2F0
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
       mov       rdx,7FF900C9BAA0
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
       mov       rdx,7FF90074E2E0
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
       mov       rdx,7FF900C9BA58
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
       mov       rdx,7FF900C9BA70
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
       call      qword ptr [7FF9000DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFEE1230
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
       call      qword ptr [7FF900325B18]
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
       mov       rdx,7FF90074E2E0
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
       mov       r11,7FF8FFEE1238
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF900D34A00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF900D34A40
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
       mov       rdx,7FF90073FEA8
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
       mov       rdx,7FF900D34A58
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
       mov       rdx,7FF90073FE98
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
       mov       rdx,7FF900D34A10
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
       mov       rdx,7FF900D34A28
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
       call      qword ptr [7FF9000CE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF8FFED1AE8
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
       call      qword ptr [7FF900315B18]
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
       mov       rdx,7FF90073FE98
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
       mov       r11,7FF8FFED1AF0
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900A77A08]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C25778
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
       mov       rdx,7FF900C25D08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C25D40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C25DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90025E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900A77A98]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C25798
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
       mov       rdx,7FF900C257B0
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
       mov       rdx,7FF900C25918
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
       mov       rdx,7FF900C25930
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
       mov       rdx,7FF900C25AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900A77F60]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C25AE8
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
       call      qword ptr [7FF90078D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90078D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90001F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9003053F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001A66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900A7D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C27468
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
       mov       rdx,7FF900C279F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C27A30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C27AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90025E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900A7D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C27488
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
       mov       rdx,7FF900C274A0
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
       mov       rdx,7FF900C27608
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
       mov       rdx,7FF900C27620
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
       mov       rdx,7FF900C277B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900A7DD88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C277D8
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
       call      qword ptr [7FF90078D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90078D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90001F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9003053F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001A66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900A5D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C07630
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
       mov       rdx,7FF900C07BC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90042E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C07BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90042E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C07CB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90023E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900A5D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C07650
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
       mov       rdx,7FF900C07668
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
       mov       rdx,7FF900C077D0
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
       mov       rdx,7FF900C077E8
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
       mov       rdx,7FF900C07980
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900A5DD88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C079A0
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
       call      qword ptr [7FF90076D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90076D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFFF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001866E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900A5D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C077A8
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
       mov       rdx,7FF900C07D38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90042E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C07D70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90042E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C07E28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90023E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900A5D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C077C8
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
       mov       rdx,7FF900C077E0
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
       mov       rdx,7FF900C07948
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
       mov       rdx,7FF900C07960
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
       mov       rdx,7FF900C07AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900A5DD88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C07B18
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
       call      qword ptr [7FF90076D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90076D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFFF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001866E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900A8D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C37530
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
       mov       rdx,7FF900C37AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90045E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C37AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90045E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C37BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90026E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900A8D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C37550
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
       mov       rdx,7FF900C37568
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
       mov       rdx,7FF900C376D0
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
       mov       rdx,7FF900C376E8
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
       mov       rdx,7FF900C37880
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900A8DD88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C378A0
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
       call      qword ptr [7FF90079D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90079D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90002F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001B66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900A7D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C27330
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
       mov       rdx,7FF900C278C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C278F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90044E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C279B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90025E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900A7D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C27350
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
       mov       rdx,7FF900C27368
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
       mov       rdx,7FF900C274D0
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
       mov       rdx,7FF900C274E8
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
       mov       rdx,7FF900C27680
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900A7DD88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C276A0
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
       call      qword ptr [7FF90078D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90078D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90001F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9003053F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001A66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900B879C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C9F630
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
       mov       rdx,7FF900C9FBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90045E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C9FBF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90045E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900C9FCB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90026E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900B87A50]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900C9F650
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
       mov       rdx,7FF900C9F668
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
       mov       rdx,7FF900C9F7D0
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
       mov       rdx,7FF900C9F7E8
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
       mov       rdx,7FF900C9F980
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900B87F18]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900C9F9A0
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
       call      qword ptr [7FF90079D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90079D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90002F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9003153F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001B66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF900C1D830]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900D18210
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
       mov       rdx,7FF900D187A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF90042E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900D187D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF90042E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF900D18890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF90023E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF900C1D8C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF900D18230
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
       mov       rdx,7FF900D18248
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
       mov       rdx,7FF900D183B0
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
       mov       rdx,7FF900D183C8
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
       mov       rdx,7FF900D18560
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF900C1DD70]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF900D18580
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
       call      qword ptr [7FF90076D860]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF90076D7A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFFF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF9002E53F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9001866E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

