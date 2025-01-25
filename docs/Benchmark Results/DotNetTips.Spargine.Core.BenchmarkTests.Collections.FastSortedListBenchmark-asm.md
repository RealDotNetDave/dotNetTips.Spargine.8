## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,27997805630
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,27997805608
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
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
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rsi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC0E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FF94CC0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D064C60]
       mov       ecx,3233
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D064A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD76670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 389
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M01_L03
       test      esi,esi
       jl        short M01_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M01_L05
       cmp       esi,1
       jle       short M01_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF94D71EAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE0C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FF94CD4EAA8]
       int       3
M01_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD4ED48]
       int       3
M01_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD4ECA0]
       int       3
; Total bytes of code 157
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
       call      qword ptr [7FF94CC0DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD4EF40]
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
       mov       rax,2BA25710008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1A5A6805630
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1A5A6805608
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
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
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rsi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC2E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FF94CC2E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D084C60]
       mov       ecx,3233
       mov       rdx,7FF94CE8B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE8B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE8B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D084A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD96670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 389
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M01_L03
       test      esi,esi
       jl        short M01_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M01_L05
       cmp       esi,1
       jle       short M01_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF94D770BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE2C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FF94CD6EAA8]
       int       3
M01_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD6ED48]
       int       3
M01_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD6ECA0]
       int       3
; Total bytes of code 157
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
       call      qword ptr [7FF94CC2DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD6EF40]
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
       mov       rax,1E638630008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1D474003638
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1D474003610
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
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
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rsi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC1E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D074C60]
       mov       ecx,3233
       mov       rdx,7FF94CE7B490
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B490
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B490
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D074A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 389
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M01_L03
       test      esi,esi
       jl        short M01_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M01_L05
       cmp       esi,1
       jle       short M01_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF94D760600
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE1C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FF94CD5EAA8]
       int       3
M01_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD5ED48]
       int       3
M01_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD5ECA0]
       int       3
; Total bytes of code 157
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
       call      qword ptr [7FF94CC1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD5EF40]
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
       mov       rax,21505DB0008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,15630405630
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,15630405608
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
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
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rsi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC4E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FF94CC4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D0A4C60]
       mov       ecx,3233
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D0A4A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDB6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 389
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M01_L03
       test      esi,esi
       jl        short M01_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M01_L05
       cmp       esi,1
       jle       short M01_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF94D790BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE4C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FF94CD8EAA8]
       int       3
M01_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD8ED48]
       int       3
M01_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD8ECA0]
       int       3
; Total bytes of code 157
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
       call      qword ptr [7FF94CC4DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD8EF40]
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
       mov       rax,196C23B0008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,281FA803638
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,281FA803610
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
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
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rsi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC2E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FF94CC2E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D02F4F8]
       mov       ecx,3233
       mov       rdx,7FF94CE8B3F0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE8B3F0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE8B3F0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D02F2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD96670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 389
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M01_L03
       test      esi,esi
       jl        short M01_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M01_L05
       cmp       esi,1
       jle       short M01_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF94D770D10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE2C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FF94CD6EAA8]
       int       3
M01_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD6ED48]
       int       3
M01_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD6ECA0]
       int       3
; Total bytes of code 157
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
       call      qword ptr [7FF94CC2DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD6EF40]
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
       mov       rax,2C28C6F0008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2D9FC805630
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2D9FC805608
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
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
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rsi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC3E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D094C60]
       mov       ecx,3233
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D094A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDA6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 389
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M01_L03
       test      esi,esi
       jl        short M01_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M01_L05
       cmp       esi,1
       jle       short M01_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+80]
       test      rax,rax
       je        short M01_L00
       mov       rcx,rax
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF94D7C8C18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE3C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      qword ptr [7FF94CD7EAA8]
       int       3
M01_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD7ED48]
       int       3
M01_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD7ECA0]
       int       3
; Total bytes of code 160
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
       call      qword ptr [7FF94CC3DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD7EF40]
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
       mov       rax,31A8E7D0008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,21E4F405650
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,21E4F405618
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        near ptr M00_L05
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L04
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rsi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       ecx,[rsi+10]
       test      ecx,ecx
       jl        near ptr M00_L08
       cmp       ecx,1
       jle       short M00_L03
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M00_L06
       cmp       [rdx+8],ecx
       jl        near ptr M00_L07
       add       rdx,10
       mov       r11,21E4F405658
       mov       r11,[r11]
       mov       [rsp+20],rdx
       mov       [rsp+28],ecx
       mov       rcx,r11
       lea       rdx,[rsp+20]
       mov       r11,7FF94CA41798
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L03:
       inc       dword ptr [rsi+14]
       mov       ecx,[rsi+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FF94D094C60]
       mov       ecx,3233
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D094A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDA6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,2
       call      qword ptr [7FF94CD7ED00]
       int       3
M00_L07:
       mov       ecx,10
       call      qword ptr [7FF94CD7ECA0]
       int       3
M00_L08:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD7ED48]
       int       3
; Total bytes of code 525
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
       je        short M01_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L01
M01_L00:
       mov       edx,4
M01_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF94CC3DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD7EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,25EE1130008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,14DDAC05670
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,14DDAC05638
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
       mov       rdx,[rdi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        near ptr M00_L05
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L04
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rsi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       ecx,[rsi+10]
       test      ecx,ecx
       jl        near ptr M00_L08
       cmp       ecx,1
       jle       short M00_L03
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M00_L06
       cmp       [rdx+8],ecx
       jl        near ptr M00_L07
       add       rdx,10
       mov       r11,14DDAC05678
       mov       r11,[r11]
       mov       [rsp+20],rdx
       mov       [rsp+28],ecx
       mov       rcx,r11
       lea       rdx,[rsp+20]
       mov       r11,7FF94CA51A68
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L03:
       inc       dword ptr [rsi+14]
       mov       ecx,[rsi+10]
       mov       rdx,[rbx+18]
       mov       [rdx+38],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FF94CC4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FF94D0A4C60]
       mov       ecx,3233
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D0A4A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDB6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,2
       call      qword ptr [7FF94CD8ED00]
       int       3
M00_L07:
       mov       ecx,10
       call      qword ptr [7FF94CD8ECA0]
       int       3
M00_L08:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD8ED48]
       int       3
; Total bytes of code 525
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
       je        short M01_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L01
M01_L00:
       mov       edx,4
M01_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF94CC4DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD8EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,18E6CB00008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList_Comparer()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,192F2C05608
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
       mov       rdx,[rsi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rdi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D074C60]
       mov       ecx,3233
       mov       rdx,7FF94CE7B490
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B490
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B490
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D074A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 376
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
       je        short M01_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L01
M01_L00:
       mov       edx,4
M01_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF94CC1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD5EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,1D3848D0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList_Comparer()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,225E8405608
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
       mov       rdx,[rsi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rdi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D074C60]
       mov       ecx,3233
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D074A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 376
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
       je        short M01_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L01
M01_L00:
       mov       edx,4
M01_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF94CC1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD5EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,2667A0E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList_Comparer()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1DA5B005608
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
       mov       rdx,[rsi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rdi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D094C60]
       mov       ecx,3233
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D094A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDA6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 376
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
       je        short M01_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L01
M01_L00:
       mov       edx,4
M01_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF94CC3DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD7EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,21AECD20008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList_Comparer()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1D875003610
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
       mov       rdx,[rsi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rdi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D074C60]
       mov       ecx,3233
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D074A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 376
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
       je        short M01_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L01
M01_L00:
       mov       edx,4
M01_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF94CC1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD5EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,21906F70008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList_Comparer()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,23A8E405608
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
       mov       rdx,[rsi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rdi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D094C60]
       mov       ecx,3233
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D094A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDA6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 376
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
       je        short M01_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L01
M01_L00:
       mov       edx,4
M01_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF94CC3DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD7EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,27B20360008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList_Comparer()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1BFF1C03610
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
       mov       rdx,[rsi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rdi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D01F4F8]
       mov       ecx,3233
       mov       rdx,7FF94CE7B3D0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B3D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B3D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D01F2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 376
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
       je        short M01_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L01
M01_L00:
       mov       edx,4
M01_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF94CC1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD5EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,20083C40008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList_Comparer()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,23832803628
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
       mov       rdx,[rsi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rdi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D074C60]
       mov       ecx,3233
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D074A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 376
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
       je        short M01_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L01
M01_L00:
       mov       edx,4
M01_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF94CC1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD5EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,278C4820008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_FastSortedList_Comparer()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1C3D9805638
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+278]
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       ecx,ebp
       mov       rdx,[rsi+rcx*8+10]
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M00_L04
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L03
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       byte ptr [rdi+28],0
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF94D094C60]
       mov       ecx,3233
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D094A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDA6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 376
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
       je        short M01_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L01
M01_L00:
       mov       edx,4
M01_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF94CC3DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
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
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD7EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,204675C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,24A18005630
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,24A18005638
       mov       rdx,[rcx]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,24A18005420
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
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
       mov       rcx,offset MD_System.Array.BinarySearch[[System.String, System.Private.CoreLib]](System.String[], Int32, Int32, System.String, System.Collections.Generic.IComparer`1<System.String>)
       xor       r8d,r8d
       call      qword ptr [7FF94D5D4BA0]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF94D5D4A98]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       jae       near ptr M00_L07
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
       mov       rdx,7FF94CD6A0F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94CDA66E8]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D2E5428]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF94D2E5368]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF94CD6A0F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CB8F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF94CD7EFE8]
       int       3
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 421
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
       mov       rdx,7FF94D74E8A0
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
       mov       rdx,7FF94D74E8B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF94CE86A30]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94CD7ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD7EAA8]
       int       3
M01_L06:
       call      qword ptr [7FF94CD7EAD8]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF94CD7ECA0]
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
       mov       edx,[rbx+30]
       mov       rcx,[rbx+8]
       cmp       edx,[rcx+8]
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
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF94D5D4948]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
       jmp       short M02_L00
; Total bytes of code 152
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,16268805630
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,16268805638
       mov       rdx,[rcx]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,16268805420
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
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
       mov       rcx,offset MD_System.Array.BinarySearch[[System.String, System.Private.CoreLib]](System.String[], Int32, Int32, System.String, System.Collections.Generic.IComparer`1<System.String>)
       xor       r8d,r8d
       call      qword ptr [7FF94D5C6700]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF94D5C65F8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       jae       near ptr M00_L07
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
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94CD966E8]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D2D53C8]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF94D2D5308]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CB7F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF94CD6EFE8]
       int       3
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 421
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
       mov       rdx,7FF94D73FB98
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
       mov       rdx,7FF94D73FBA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF94CE76A30]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94CD6ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD6EAA8]
       int       3
M01_L06:
       call      qword ptr [7FF94CD6EAD8]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF94CD6ECA0]
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
       mov       edx,[rbx+30]
       mov       rcx,[rbx+8]
       cmp       edx,[rcx+8]
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
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF94D5C64A8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
       jmp       short M02_L00
; Total bytes of code 152
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,28258C05630
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,28258C05638
       mov       rdx,[rcx]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,28258C05428
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
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
       mov       rcx,offset MD_System.Array.BinarySearch[[System.String, System.Private.CoreLib]](System.String[], Int32, Int32, System.String, System.Collections.Generic.IComparer`1<System.String>)
       xor       r8d,r8d
       call      qword ptr [7FF94D5B4C48]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF94D5B4B40]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       jae       near ptr M00_L07
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
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94CD866E8]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D2C4348]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF94D2C4288]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CB6F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF94CD5EFE8]
       int       3
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 421
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
       mov       rdx,7FF94D72F7C0
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
       mov       rdx,7FF94D72F7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF94CE6C480]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94CD5ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD5EAA8]
       int       3
M01_L06:
       call      qword ptr [7FF94CD5EAD8]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF94CD5ECA0]
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
       mov       edx,[rbx+30]
       mov       rcx,[rbx+8]
       cmp       edx,[rcx+8]
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
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF94D5B49F0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
       jmp       short M02_L00
; Total bytes of code 152
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2723D803638
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2723D803640
       mov       rdx,[rcx]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,2723D803430
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
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
       mov       rcx,offset MD_System.Array.BinarySearch[[System.String, System.Private.CoreLib]](System.String[], Int32, Int32, System.String, System.Collections.Generic.IComparer`1<System.String>)
       xor       r8d,r8d
       call      qword ptr [7FF94D5C5D70]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF94D5C5C68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       jae       near ptr M00_L07
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
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94CD966E8]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D2D4348]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF94D2D4288]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CB7F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF94CD6EFE8]
       int       3
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 421
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
       mov       rdx,7FF94D73F820
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
       mov       rdx,7FF94D73F830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF94CE7C300]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94CD6ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD6EAA8]
       int       3
M01_L06:
       call      qword ptr [7FF94CD6EAD8]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF94CD6ECA0]
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
       mov       edx,[rbx+30]
       mov       rcx,[rbx+8]
       cmp       edx,[rcx+8]
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
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       lea       r9d,[rsi+1]
       mov       edx,esi
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF94D5C5B18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
       jmp       short M02_L00
; Total bytes of code 152
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,285C1C05630
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,285C1C05638
       mov       rdx,[rcx]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,285C1C05420
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
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
       mov       rcx,offset MD_System.Array.BinarySearch[[System.String, System.Private.CoreLib]](System.String[], Int32, Int32, System.String, System.Collections.Generic.IComparer`1<System.String>)
       xor       r8d,r8d
       call      qword ptr [7FF94D5B6490]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF94D5B6388]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       jae       near ptr M00_L07
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
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94CD866E8]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D2C53E0]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF94D2C5320]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CB6F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF94CD5EFE8]
       int       3
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 421
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
       mov       rdx,7FF94D760218
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
       mov       rdx,7FF94D760228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF94CE66A30]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94CD5ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD5EAA8]
       int       3
M01_L06:
       call      qword ptr [7FF94CD5EAD8]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF94CD5ECA0]
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
       mov       edx,[rbx+30]
       mov       rcx,[rbx+8]
       cmp       edx,[rcx+8]
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
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF94D5B6238]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
       jmp       short M02_L00
; Total bytes of code 158
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,19C30C03640
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,19C30C03648
       mov       rdx,[rcx]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,19C30C03428
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
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
       mov       rcx,offset MD_System.Array.BinarySearch[[System.String, System.Private.CoreLib]](System.String[], Int32, Int32, System.String, System.Collections.Generic.IComparer`1<System.String>)
       xor       r8d,r8d
       call      qword ptr [7FF94D5ECC48]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF94D5ECB40]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       jae       near ptr M00_L07
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
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94CD866E8]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D2C53C8]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF94D2C5308]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CB6F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF94CD5EFE8]
       int       3
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 421
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
       mov       rdx,7FF94D7C2A78
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
       mov       rdx,7FF94D7C2A88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF94CE66A30]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94CD5ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD5EAA8]
       int       3
M01_L06:
       call      qword ptr [7FF94CD5EAD8]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF94CD5ECA0]
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
       mov       edx,[rbx+30]
       mov       rcx,[rbx+8]
       cmp       edx,[rcx+8]
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
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF94D5EC9F0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
       jmp       short M02_L00
; Total bytes of code 158
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,272F6005658
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,272F6005660
       mov       rdx,[rcx]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,272F6005420
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
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
       mov       rcx,offset MD_System.Array.BinarySearch[[System.String, System.Private.CoreLib]](System.String[], Int32, Int32, System.String, System.Collections.Generic.IComparer`1<System.String>)
       xor       r8d,r8d
       call      qword ptr [7FF94D6D5D70]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF94D6D5C68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       jae       near ptr M00_L07
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
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94CD966E8]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D2D53E0]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF94D2D5320]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CB7F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF94CD6EFE8]
       int       3
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 421
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
       mov       rdx,7FF94D7D9240
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
       mov       rdx,7FF94D7D9250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF94CE76A30]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94CD6ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD6EAA8]
       int       3
M01_L06:
       call      qword ptr [7FF94CD6EAD8]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF94CD6ECA0]
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
       mov       edx,[rbx+30]
       mov       rcx,[rbx+8]
       cmp       edx,[rcx+8]
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
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF94D6D5B18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
       jmp       short M02_L00
; Total bytes of code 158
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Add_SortedList()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,26D71403670
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,26D71403678
       mov       rdx,[rcx]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,26D71403428
       mov       rdx,[rcx]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+280]
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
       mov       rcx,offset MD_System.Array.BinarySearch[[System.String, System.Private.CoreLib]](System.String[], Int32, Int32, System.String, System.Collections.Generic.IComparer`1<System.String>)
       xor       r8d,r8d
       call      qword ptr [7FF94D776490]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       test      eax,eax
       jge       near ptr M00_L05
       mov       edx,eax
       not       edx
       mov       rcx,rsi
       mov       r8,r15
       mov       r9,r13
       call      qword ptr [7FF94D776388]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon, System.__Canon)
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
       jae       near ptr M00_L07
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
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94CD866E8]
       int       3
M00_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF94D2C53C8]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF94D2C5308]
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF94CB6F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF94CD5EFE8]
       int       3
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 421
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
       mov       rdx,7FF94D7CCA20
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
       mov       rdx,7FF94D7CCA30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [7FF94CE66A30]; System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94CD5ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD5EAA8]
       int       3
M01_L06:
       call      qword ptr [7FF94CD5EAD8]
       int       3
M01_L07:
       mov       ecx,10
       call      qword ptr [7FF94CD5ECA0]
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
       mov       edx,[rbx+30]
       mov       rcx,[rbx+8]
       cmp       edx,[rcx+8]
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
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+30]
       sub       ecx,esi
       mov       [rsp+20],ecx
       mov       r8,[rbx+10]
       mov       rcx,r8
       mov       r9d,r14d
       mov       edx,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF94D776238]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
       jmp       short M02_L00
; Total bytes of code 158
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,176CDC05630
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,176CDC05608
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF94CC2E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC2E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D084C60]
       mov       ecx,323D
       mov       rdx,7FF94CE8B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE8B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE8B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D084A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD96670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 310
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
       je        near ptr M01_L19
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D73EA90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L09
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D73EAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,[rdx+8]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       cmp       eax,ebx
       jge       short M01_L05
       add       r8d,ebx
       jo        near ptr M01_L18
       cmp       dword ptr [rdx+8],0
       jne       short M01_L06
       mov       edx,4
M01_L04:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,r8d
       cmovl     edx,r8d
       call      qword ptr [7FF94CC2DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+98]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L04
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF94D73EAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L08:
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
M01_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FF94D73EAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L16
M01_L12:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF94D73EAB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L15
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L16
M01_L15:
       mov       rdx,r8
       call      qword ptr [7FF94CC2E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L16:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA31058
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L12
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L17:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       ecx,17
       call      qword ptr [7FF94CD6ED00]
       int       3
M01_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L21
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA31060
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 586
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D73ED58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE2C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD6EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD6ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD6ECA0]
       int       3
; Total bytes of code 160
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD6EF40]
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
       mov       rax,1B75FC90008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,25B97405630
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,25B97405608
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF94CC4E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC4E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D04F4F8]
       mov       ecx,323D
       mov       rdx,7FF94CEAB280
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB280
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB280
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D04F2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDB6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 310
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
       je        near ptr M01_L19
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D790980
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L09
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D7909C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,[rdx+8]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       cmp       eax,ebx
       jge       short M01_L05
       add       r8d,ebx
       jo        near ptr M01_L18
       cmp       dword ptr [rdx+8],0
       jne       short M01_L06
       mov       edx,4
M01_L04:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,r8d
       cmovl     edx,r8d
       call      qword ptr [7FF94CC4DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+98]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L04
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF94D7909D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L08:
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
M01_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FF94D790990
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L16
M01_L12:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF94D7909A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L15
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L16
M01_L15:
       mov       rdx,r8
       call      qword ptr [7FF94CC4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L16:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA50F38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L12
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L17:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       ecx,17
       call      qword ptr [7FF94CD8ED00]
       int       3
M01_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L21
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA50F40
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 586
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D790C48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE4C2D0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD8EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD8ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD8ECA0]
       int       3
; Total bytes of code 160
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD8EF40]
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
       mov       rax,29C29510008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,13D43C05630
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,13D43C05608
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF94CC4E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC4E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D0A4C60]
       mov       ecx,323D
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D0A4A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDB6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 310
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D790A40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D790A80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L16
       mov       rcx,[rbp+10]
       mov       r14,[rcx+8]
       mov       edx,[r14+8]
       mov       eax,[rcx+10]
       sub       edx,eax
       cmp       edx,ebx
       jge       short M01_L05
       add       eax,ebx
       jo        near ptr M01_L17
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L19
       mov       edx,4
M01_L04:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,eax
       cmovl     edx,eax
       call      qword ptr [7FF94CC4DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+98]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D790A98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L07:
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF94D790A50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-30],rax
       jmp       short M01_L15
M01_L11:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF94D790A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L13:
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L14
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L15
M01_L14:
       mov       rdx,r8
       call      qword ptr [7FF94CC4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L15:
       mov       rcx,[rbp-30]
       mov       r11,7FF94CA50F38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L11
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L16:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       call      CORINFO_HELP_OVERFLOW
M01_L18:
       mov       ecx,17
       call      qword ptr [7FF94CD8ED00]
       int       3
M01_L19:
       mov       edx,[r14+8]
       add       edx,edx
       jmp       near ptr M01_L04
M01_L20:
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
       je        short M01_L21
       mov       rcx,[rbp-30]
       mov       r11,7FF94CA50F40
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 603
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D790D10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE4C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD8EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD8ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD8ECA0]
       int       3
; Total bytes of code 160
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD8EF40]
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
       mov       rax,17DD5B10008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1977C805630
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1977C805608
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF94CC3E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC3E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D03F4F8]
       mov       ecx,323D
       mov       rdx,7FF94CE9B3D0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE9B3D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE9B3D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D03F2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDA6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 310
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D7805A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D7805E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L16
       mov       rcx,[rbp+10]
       mov       r14,[rcx+8]
       mov       edx,[r14+8]
       mov       eax,[rcx+10]
       sub       edx,eax
       cmp       edx,ebx
       jge       short M01_L05
       add       eax,ebx
       jo        near ptr M01_L17
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L19
       mov       edx,4
M01_L04:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,eax
       cmovl     edx,eax
       call      qword ptr [7FF94CC3DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+98]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D7805F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L07:
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF94D7805B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-30],rax
       jmp       short M01_L15
M01_L11:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF94D7805C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L13:
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L14
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L15
M01_L14:
       mov       rdx,r8
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L15:
       mov       rcx,[rbp-30]
       mov       r11,7FF94CA40F38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L11
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L16:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       call      CORINFO_HELP_OVERFLOW
M01_L18:
       mov       ecx,17
       call      qword ptr [7FF94CD7ED00]
       int       3
M01_L19:
       mov       edx,[r14+8]
       add       edx,edx
       jmp       near ptr M01_L04
M01_L20:
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
       je        short M01_L21
       mov       rcx,[rbp-30]
       mov       r11,7FF94CA40F40
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 603
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D780870
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE3C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD7EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD7ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD7ECA0]
       int       3
; Total bytes of code 160
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD7EF40]
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
       mov       rax,1D80E7A0008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,28EB1405630
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,28EB1405608
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF94CC4E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC4E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D0A4C60]
       mov       ecx,323D
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D0A4A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDB6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 310
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
       je        near ptr M01_L19
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D7909C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L09
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D790A08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,[rdx+8]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       cmp       eax,ebx
       jge       short M01_L05
       add       r8d,ebx
       jo        near ptr M01_L18
       cmp       dword ptr [rdx+8],0
       jne       short M01_L06
       mov       edx,4
M01_L04:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,r8d
       cmovl     edx,r8d
       call      qword ptr [7FF94CC4DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+98]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L04
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF94D790A20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L08:
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
M01_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FF94D7909D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L16
M01_L12:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF94D7909F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L15
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L16
M01_L15:
       mov       rdx,r8
       call      qword ptr [7FF94CC4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L16:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA50F38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L12
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L17:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       ecx,17
       call      qword ptr [7FF94CD8ED00]
       int       3
M01_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L21
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA50F40
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 586
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D790C90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE4C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD8EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD8ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD8ECA0]
       int       3
; Total bytes of code 160
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD8EF40]
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
       mov       rax,2CF43420008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,14036C03638
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,14036C03610
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF94CC4E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC4E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D04F4F8]
       mov       ecx,323D
       mov       rdx,7FF94CEAB408
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB408
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB408
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D04F2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDB6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 310
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
       je        near ptr M01_L19
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D78BAB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L09
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D78BAF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,[rdx+8]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       cmp       eax,ebx
       jge       short M01_L05
       add       r8d,ebx
       jo        near ptr M01_L18
       cmp       dword ptr [rdx+8],0
       jne       short M01_L06
       mov       edx,4
M01_L04:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,r8d
       cmovl     edx,r8d
       call      qword ptr [7FF94CC4DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0A0]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L04
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF94D78BB10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L08:
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
M01_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FF94D78BAC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L16
M01_L12:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF94D78BAE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L15
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L16
M01_L15:
       mov       rdx,r8
       call      qword ptr [7FF94CC4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L16:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA51088
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L12
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L17:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       ecx,17
       call      qword ptr [7FF94CD8ED00]
       int       3
M01_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L21
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA51090
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 589
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D78BD80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE4C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD8EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD8ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD8ECA0]
       int       3
; Total bytes of code 160
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD8EF40]
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
       mov       rax,180C8A00008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2603E005658
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2603E005628
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF94CC2E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC2E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D084C60]
       mov       ecx,323D
       mov       rdx,7FF94CE8B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE8B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE8B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D084A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD96670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 310
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D7D8A50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D7D8A90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L16
       mov       rcx,[rbp+10]
       mov       r14,[rcx+8]
       mov       edx,[r14+8]
       mov       eax,[rcx+10]
       sub       edx,eax
       cmp       edx,ebx
       jge       short M01_L05
       add       eax,ebx
       jo        near ptr M01_L17
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L19
       mov       edx,4
M01_L04:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,eax
       cmovl     edx,eax
       call      qword ptr [7FF94CC2DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0A0]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D7D8AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L07:
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF94D7D8A60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-30],rax
       jmp       short M01_L15
M01_L11:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF94D7D8A78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L13:
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L14
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L15
M01_L14:
       mov       rdx,r8
       call      qword ptr [7FF94CC2E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L15:
       mov       rcx,[rbp-30]
       mov       r11,7FF94CA317B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L11
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L16:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       call      CORINFO_HELP_OVERFLOW
M01_L18:
       mov       ecx,17
       call      qword ptr [7FF94CD6ED00]
       int       3
M01_L19:
       mov       edx,[r14+8]
       add       edx,edx
       jmp       near ptr M01_L04
M01_L20:
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
       je        short M01_L21
       mov       rcx,[rbp-30]
       mov       r11,7FF94CA317B8
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 606
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D7D8D20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE2C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD6EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD6ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD6ECA0]
       int       3
; Total bytes of code 160
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD6EF40]
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
       mov       rax,2A0CC060008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRange_FastSortedList()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1D232005668
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1D232005630
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF94CC1E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rsi+28],0
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC1E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D074C60]
       mov       ecx,323D
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D074A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 310
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D7CFAF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D7CFB38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L16
       mov       rcx,[rbp+10]
       mov       r14,[rcx+8]
       mov       edx,[r14+8]
       mov       eax,[rcx+10]
       sub       edx,eax
       cmp       edx,ebx
       jge       short M01_L05
       add       eax,ebx
       jo        near ptr M01_L17
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L19
       mov       edx,4
M01_L04:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,eax
       cmovl     edx,eax
       call      qword ptr [7FF94CC1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0A0]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D7CFB50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L07:
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF94D7CFB08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-30],rax
       jmp       short M01_L15
M01_L11:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF94D7CFB20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L13:
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L14
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L15
M01_L14:
       mov       rdx,r8
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L15:
       mov       rcx,[rbp-30]
       mov       r11,7FF94CA21970
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L11
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L16:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       call      CORINFO_HELP_OVERFLOW
M01_L18:
       mov       ecx,17
       call      qword ptr [7FF94CD5ED00]
       int       3
M01_L19:
       mov       edx,[r14+8]
       add       edx,edx
       jmp       near ptr M01_L04
M01_L20:
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
       je        short M01_L21
       mov       rcx,[rbp-30]
       mov       r11,7FF94CA21978
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 606
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D7CFDC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE1C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD5EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD5ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD5ECA0]
       int       3
; Total bytes of code 160
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF94CD5EF40]
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
       mov       rax,212C3F20008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRangeFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2C4B1805608
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rdi
       call      qword ptr [7FF94CC4E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rdi+28],0
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D0A4C60]
       mov       ecx,323D
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D0A4A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDB6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 297
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
       je        near ptr M01_L19
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
       mov       rdx,7FF94D75DC98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L09
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D75DCD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,[rdx+8]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       cmp       eax,ebx
       jge       short M01_L05
       add       r8d,ebx
       jo        near ptr M01_L18
       cmp       dword ptr [rdx+8],0
       jne       short M01_L06
       mov       edx,4
M01_L04:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,r8d
       cmovl     edx,r8d
       call      qword ptr [7FF94CC4DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L04
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF94D75DCF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L08:
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
M01_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FF94D75DCA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L16
M01_L12:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF94D75DCC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L15
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L16
M01_L15:
       mov       rdx,r8
       call      qword ptr [7FF94CC4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L16:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA51040
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L12
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L17:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       ecx,17
       call      qword ptr [7FF94CD8ED00]
       int       3
M01_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L21
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA51048
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 583
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
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD8EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,30543620008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRangeFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,15EBC003610
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rdi
       call      qword ptr [7FF94CC1E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rdi+28],0
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D074C60]
       mov       ecx,323D
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D074A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 297
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
       je        near ptr M01_L19
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
       mov       rdx,7FF94D72F008
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L09
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D72F048
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,[rdx+8]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       cmp       eax,ebx
       jge       short M01_L05
       add       r8d,ebx
       jo        near ptr M01_L18
       cmp       dword ptr [rdx+8],0
       jne       short M01_L06
       mov       edx,4
M01_L04:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,r8d
       cmovl     edx,r8d
       call      qword ptr [7FF94CC1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L04
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF94D72F060
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L08:
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
M01_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FF94D72F018
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L16
M01_L12:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF94D72F030
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L15
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L16
M01_L15:
       mov       rdx,r8
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L16:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA21038
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L12
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L17:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       ecx,17
       call      qword ptr [7FF94CD5ED00]
       int       3
M01_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L21
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA21040
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 583
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
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD5EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,19F4DE40008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRangeFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F9B8005608
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rdi
       call      qword ptr [7FF94CC0E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rdi+28],0
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D064C60]
       mov       ecx,323D
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE6B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D064A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD76670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 297
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
       je        near ptr M01_L19
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        near ptr M01_L05
M01_L00:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L09
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        near ptr M01_L06
M01_L01:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,[rdx+8]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       cmp       eax,ebx
       jge       short M01_L03
       add       r8d,ebx
       jo        near ptr M01_L18
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L08
       mov       edx,4
M01_L02:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,r8d
       cmovl     edx,r8d
       call      qword ptr [7FF94CC0DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L03:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M01_L07
M01_L04:
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
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FF94D71EB40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D71EB80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF94D71EB98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L04
M01_L08:
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M01_L02
M01_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FF94D71EB50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L16
M01_L12:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF94D71EB68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L15
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L16
M01_L15:
       mov       rdx,r8
       call      qword ptr [7FF94CC0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L16:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA11038
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L12
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L17:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       ecx,17
       call      qword ptr [7FF94CD4ED00]
       int       3
M01_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L21
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA11040
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 604
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
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD4EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,23A45EB0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRangeFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,24DCB003610
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rdi
       call      qword ptr [7FF94CC4E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rdi+28],0
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D0A4C60]
       mov       ecx,323D
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CEAB4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D0A4A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDB6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 297
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
       je        near ptr M01_L19
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
       mov       rdx,7FF94D75EB30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L09
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D75EB70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,[rdx+8]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       cmp       eax,ebx
       jge       short M01_L05
       add       r8d,ebx
       jo        near ptr M01_L18
       cmp       dword ptr [rdx+8],0
       jne       short M01_L06
       mov       edx,4
M01_L04:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,r8d
       cmovl     edx,r8d
       call      qword ptr [7FF94CC4DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L04
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF94D75EB88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L08:
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
M01_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FF94D75EB40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L16
M01_L12:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF94D75EB58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L15
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L16
M01_L15:
       mov       rdx,r8
       call      qword ptr [7FF94CC4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L16:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA51038
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L12
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L17:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       ecx,17
       call      qword ptr [7FF94CD8ED00]
       int       3
M01_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L21
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA51040
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 583
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
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD8EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,28E5D080008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRangeFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,21C69805608
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rdi
       call      qword ptr [7FF94CC1E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rdi+28],0
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D074C60]
       mov       ecx,323D
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D074A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 297
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
       je        near ptr M01_L19
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
       mov       rdx,7FF94D72F6C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L09
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D72F708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,[rdx+8]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       cmp       eax,ebx
       jge       short M01_L05
       add       r8d,ebx
       jo        near ptr M01_L18
       cmp       dword ptr [rdx+8],0
       jne       short M01_L06
       mov       edx,4
M01_L04:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,r8d
       cmovl     edx,r8d
       call      qword ptr [7FF94CC1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L04
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF94D72F720
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L08:
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
M01_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FF94D72F6D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L16
M01_L12:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF94D72F6F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L15
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L16
M01_L15:
       mov       rdx,r8
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L16:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA21038
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L12
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L17:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       ecx,17
       call      qword ptr [7FF94CD5ED00]
       int       3
M01_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L21
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA21040
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 583
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
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD5EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,25CFB780008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRangeFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1A1F1005608
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rdi
       call      qword ptr [7FF94CC3E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rdi+28],0
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D094C60]
       mov       ecx,323D
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE9B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D094A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CDA6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 297
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
       je        near ptr M01_L19
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
       mov       rdx,7FF94D74F1C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L09
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D74F208
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,[rdx+8]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       cmp       eax,ebx
       jge       short M01_L05
       add       r8d,ebx
       jo        near ptr M01_L18
       cmp       dword ptr [rdx+8],0
       jne       short M01_L06
       mov       edx,4
M01_L04:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,r8d
       cmovl     edx,r8d
       call      qword ptr [7FF94CC3DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L04
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF94D74F220
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L08:
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
M01_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FF94D74F1D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L16
M01_L12:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF94D74F1F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L15
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L16
M01_L15:
       mov       rdx,r8
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L16:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA41038
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L12
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L17:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       ecx,17
       call      qword ptr [7FF94CD7ED00]
       int       3
M01_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L21
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA41040
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 583
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
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD7EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,1E282FE0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRangeFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2770E805638
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rdi
       call      qword ptr [7FF94CC1E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rdi+28],0
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D074C60]
       mov       ecx,323D
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D074A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 297
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D7C9C60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D7C9CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L16
       mov       rcx,[rbp+10]
       mov       r14,[rcx+8]
       mov       edx,[r14+8]
       mov       eax,[rcx+10]
       sub       edx,eax
       cmp       edx,ebx
       jge       short M01_L05
       add       eax,ebx
       jo        near ptr M01_L17
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L19
       mov       edx,4
M01_L04:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,eax
       cmovl     edx,eax
       call      qword ptr [7FF94CC1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+98]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D7C9CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L07:
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF94D7C9C70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-30],rax
       jmp       short M01_L15
M01_L11:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF94D7C9C88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L13:
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L14
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L15
M01_L14:
       mov       rdx,r8
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L15:
       mov       rcx,[rbp-30]
       mov       r11,7FF94CA217B8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L11
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L16:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       call      CORINFO_HELP_OVERFLOW
M01_L18:
       mov       ecx,17
       call      qword ptr [7FF94CD5ED00]
       int       3
M01_L19:
       mov       edx,[r14+8]
       add       edx,edx
       jmp       near ptr M01_L04
M01_L20:
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
       je        short M01_L21
       mov       rcx,[rbp-30]
       mov       r11,7FF94CA217C0
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 603
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
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD5EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,2B7A04F0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.AddRangeFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2773B803640
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+278]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,rdi
       call      qword ptr [7FF94CC1E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       byte ptr [rdi+28],0
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF94D074C60]
       mov       ecx,323D
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0C88
       mov       rdx,7FF94CE7B4B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF94D074A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF94CD86670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 297
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D7CE158
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D7CE198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L16
       mov       rcx,[rbp+10]
       mov       r14,[rcx+8]
       mov       edx,[r14+8]
       mov       eax,[rcx+10]
       sub       edx,eax
       cmp       edx,ebx
       jge       short M01_L05
       add       eax,ebx
       jo        near ptr M01_L17
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L19
       mov       edx,4
M01_L04:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,eax
       cmovl     edx,eax
       call      qword ptr [7FF94CC1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rcx,[rbp+10]
M01_L05:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+98]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D7CE1B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rcx,[rbp+10]
M01_L07:
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       add       [rcx+10],ebx
       inc       dword ptr [rcx+14]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF94D7CE168
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-30],rax
       jmp       short M01_L15
M01_L11:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF94D7CE180
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L13:
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L14
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L15
M01_L14:
       mov       rdx,r8
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L15:
       mov       rcx,[rbp-30]
       mov       r11,7FF94CA21A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L11
       mov       rcx,rsp
       call      M01_L20
       nop
M01_L16:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       call      CORINFO_HELP_OVERFLOW
M01_L18:
       mov       ecx,17
       call      qword ptr [7FF94CD5ED00]
       int       3
M01_L19:
       mov       edx,[r14+8]
       add       edx,edx
       jmp       near ptr M01_L04
M01_L20:
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
       je        short M01_L21
       mov       rcx,[rbp-30]
       mov       r11,7FF94CA21A88
       call      qword ptr [r11]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 603
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
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF94CC15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
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
       call      qword ptr [7FF94CD5EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,2B7CD780008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,2D12E005630
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF94CC3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC3E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D74F228
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D74F268
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
       mov       rdx,7FF94D28EF20
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
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D74F280
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
       mov       rdx,7FF94D28EF10
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
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF94D74F238
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF94D74F250
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
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA41058
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
       call      qword ptr [7FF94CD7ED00]
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
       mov       rdx,7FF94D28EF10
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
       mov       r11,7FF94CA41060
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 690
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D74F4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE3C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD7EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD7ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD7ECA0]
       int       3
; Total bytes of code 160
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,198D6405630
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF94CC3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC3E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D780AE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D780B20
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
       mov       rdx,7FF94D28F800
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
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D780B38
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
       mov       rdx,7FF94D28F7F0
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
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF94D780AF0
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF94D780B08
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
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA40F38
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
       call      qword ptr [7FF94CD7ED00]
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
       mov       rdx,7FF94D28F7F0
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
       mov       r11,7FF94CA40F40
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 690
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D780D98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE3C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD7EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD7ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD7ECA0]
       int       3
; Total bytes of code 160
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,24C6A405630
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF94CC1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC1E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D760D50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D760D90
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
       mov       rdx,7FF94D26F860
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
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D760DA8
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
       mov       rdx,7FF94D26F850
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
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF94D760D60
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF94D760D78
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
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA20F38
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
       call      qword ptr [7FF94CD5ED00]
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
       mov       rdx,7FF94D26F850
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
       mov       r11,7FF94CA20F40
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 690
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D761008
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE1C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD5EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD5ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD5ECA0]
       int       3
; Total bytes of code 160
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,260CB803638
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF94CC0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC0E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D740120
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D740160
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
       mov       rdx,7FF94D25EDD8
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
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D740178
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
       mov       rdx,7FF94D25EDC8
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
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF94D740130
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF94D740148
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
       call      qword ptr [7FF94CC0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA10F38
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
       call      qword ptr [7FF94CD4ED00]
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
       mov       rdx,7FF94D25EDC8
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
       mov       r11,7FF94CA10F40
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 690
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D740F20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE0C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD4EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD4ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD4ECA0]
       int       3
; Total bytes of code 160
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,290A5803638
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF94CC0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC0E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D750650
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D750690
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
       mov       rdx,7FF94D25F818
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
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D7506A8
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
       mov       rdx,7FF94D25F808
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
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF94D750660
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF94D750678
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
       call      qword ptr [7FF94CC0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA10F38
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
       call      qword ptr [7FF94CD4ED00]
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
       mov       rdx,7FF94D25F808
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
       mov       r11,7FF94CA10F40
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 690
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D751450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE0C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD4EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD4ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD4ECA0]
       int       3
; Total bytes of code 160
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,2AA5A805630
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF94CC1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC1E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
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
       mov       rax,[rax+80]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D75AEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D75AF20
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
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF94D26D2C0
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
       mov       r11,[rcx+0A0]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D75AF38
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
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF94D26D2C8
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF94D75AEF0
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
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF94D75AF08
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
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA21050
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
       call      qword ptr [7FF94CD5ED00]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FF94D26D2C8
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
       mov       r11,7FF94CA21058
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 693
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D75D038
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE1C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD5EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD5ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD5ECA0]
       int       3
; Total bytes of code 160
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,18CA7405658
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF94CC2DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC2E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
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
       mov       rax,[rax+80]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D7D5CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D7D5CE0
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
       mov       rdx,7FF94D27F2A0
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
       mov       r11,[rcx+0A0]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D7D5CF8
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
       mov       rdx,7FF94D27F290
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF94D7D5CB0
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
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF94D7D5CC8
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
       call      qword ptr [7FF94CC2E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA317B8
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
       call      qword ptr [7FF94CD6ED00]
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
       mov       rdx,7FF94D27F290
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
       mov       r11,7FF94CA317C0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 693
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D7D95D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE2C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD6EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD6ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD6ECA0]
       int       3
; Total bytes of code 160
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,23E25003678
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF94CC3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsi+10]
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF94CC3E610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
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
       mov       rax,[rax+80]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D7ECE70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D7ECEB0
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
       mov       rdx,7FF94D28F868
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
       mov       r11,[rcx+0A0]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D7ECEC8
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
       mov       rdx,7FF94D28F858
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF94D7ECE80
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
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF94D7ECE98
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
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA41A90
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
       call      qword ptr [7FF94CD7ED00]
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
       mov       rdx,7FF94D28F858
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
       mov       r11,7FF94CA41A98
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 693
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       rbp,r9
       test      edi,edi
       jl        short M02_L03
       test      esi,esi
       jl        short M02_L04
       mov       ecx,[rbx+10]
       sub       ecx,edi
       cmp       ecx,esi
       jl        short M02_L05
       cmp       esi,1
       jle       short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FF94D880860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rbp
       mov       rdx,[rbx+8]
       mov       r8d,edi
       mov       r9d,esi
       call      qword ptr [7FF94CE3C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M02_L02:
       inc       dword ptr [rbx+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FF94CD7EAA8]
       int       3
M02_L04:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF94CD7ED48]
       int       3
M02_L05:
       mov       ecx,10
       call      qword ptr [7FF94CD7ECA0]
       int       3
; Total bytes of code 160
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.CreateFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF94CC2DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
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
       mov       rdx,7FF94D73DFB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF94D73DFF0
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
       mov       rdx,7FF94D27EF48
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
       mov       rdx,7FF94D73E008
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
       mov       rdx,7FF94D27EF38
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
       mov       rdx,7FF94D73DFC0
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
       mov       rdx,7FF94D73DFD8
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
       call      qword ptr [7FF94CC2E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA31038
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
       call      qword ptr [7FF94CD6ED00]
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
       mov       rdx,7FF94D27EF38
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
       mov       r11,7FF94CA31040
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.CreateFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF94CC3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
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
       mov       rdx,7FF94D74F458
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF94D74F498
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
       mov       rdx,7FF94D28EDE0
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
       mov       rdx,7FF94D74F4B0
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
       mov       rdx,7FF94D28EDD0
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
       mov       rdx,7FF94D74F468
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
       mov       rdx,7FF94D74F480
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
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA41038
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
       call      qword ptr [7FF94CD7ED00]
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
       mov       rdx,7FF94D28EDD0
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
       mov       r11,7FF94CA41040
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.CreateFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF94CC1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
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
       mov       rdx,7FF94D72F578
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF94D72F5B8
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
       mov       rdx,7FF94D26F868
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
       mov       rdx,7FF94D72F5D0
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
       mov       rdx,7FF94D26F858
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
       mov       rdx,7FF94D72F588
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
       mov       rdx,7FF94D72F5A0
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
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA21038
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
       call      qword ptr [7FF94CD5ED00]
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
       mov       rdx,7FF94D26F858
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
       mov       r11,7FF94CA21040
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.CreateFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF94CC1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
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
       mov       rdx,7FF94D72F2C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF94D72F300
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
       mov       rdx,7FF94D26DBE8
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
       mov       rdx,7FF94D72F318
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
       mov       rdx,7FF94D26DBD8
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
       mov       rdx,7FF94D72F2D0
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
       mov       rdx,7FF94D72F2E8
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
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA21038
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
       call      qword ptr [7FF94CD5ED00]
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
       mov       rdx,7FF94D26DBD8
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
       mov       r11,7FF94CA21040
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.CreateFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF94CC1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
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
       mov       rdx,7FF94D72F788
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF94D72F7C8
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
       mov       rdx,7FF94D26C018
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
       mov       rdx,7FF94D72F7E0
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
       mov       rdx,7FF94D26C008
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
       mov       rdx,7FF94D72F798
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
       mov       rdx,7FF94D72F7B0
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
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA21038
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
       call      qword ptr [7FF94CD5ED00]
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
       mov       rdx,7FF94D26C008
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
       mov       r11,7FF94CA21040
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.CreateFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF94CC4DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D7D7B18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D7D7B58
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
       mov       rdx,7FF94D29F858
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
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D7D7B70
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
       mov       rdx,7FF94D29F848
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
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF94D7D7B28
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF94D7D7B40
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
       call      qword ptr [7FF94CC4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA51220
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
       call      qword ptr [7FF94CD8ED00]
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
       mov       rdx,7FF94D29F848
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
       mov       r11,7FF94CA51228
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 690
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.CreateFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF94CC3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D7E57C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D7E5800
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
       mov       rdx,7FF94D28F868
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
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D7E5818
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
       mov       rdx,7FF94D28F858
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
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF94D7E57D0
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF94D7E57E8
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
       call      qword ptr [7FF94CC3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA41790
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
       call      qword ptr [7FF94CD7ED00]
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
       mov       rdx,7FF94D28F858
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
       mov       r11,7FF94CA41798
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 690
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.CreateFastSortedListComparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF94CC1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rsi
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FF94D7CCA10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF94CB64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF94D7CCA50
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
       mov       rdx,7FF94D26F848
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
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF94D7CCA68
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
       mov       rdx,7FF94D26F838
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
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF94D7CCA20
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF94D7CCA38
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
       call      qword ptr [7FF94CC1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF94CA21950
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
       call      qword ptr [7FF94CD5ED00]
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
       mov       rdx,7FF94D26F838
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
       mov       r11,7FF94CA21958
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 690
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF94D5B4660]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D72FAB8
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
       mov       rdx,7FF94D7600A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF94CF8E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D7600D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF94CF8E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D760190
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF94CE66C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94D5B46F0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF94D72FAD8
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
       mov       rdx,7FF94D72FAF0
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
       mov       rdx,7FF94D72FC58
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
       mov       rdx,7FF94D72FC70
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
       mov       rdx,7FF94D72FE08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF94D5B4B88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D72FE28
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
       call      qword ptr [7FF94D2C53C8]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF94D2C5308]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB6F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF94CD86640]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF94D5C5B60]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D771048
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
       mov       rdx,7FF94D7715D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF94CF9D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D771610
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF94CF9D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D7716C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF94CE77A98]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94D5C5BF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF94D771068
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
       mov       rdx,7FF94D771080
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
       mov       rdx,7FF94D7711E8
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
       mov       rdx,7FF94D771200
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
       mov       rdx,7FF94D771398
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF94D5C6088]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D7713B8
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
       call      qword ptr [7FF94D2D4348]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF94D2D4288]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB7F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF94CD96640]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF94D5A6280]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D751138
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
       mov       rdx,7FF94D7516C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF94CF7E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D751700
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF94CF7E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D7517B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF94CE56C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94D5A6310]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF94D751158
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
       mov       rdx,7FF94D751170
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
       mov       rdx,7FF94D7512D8
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
       mov       rdx,7FF94D7512F0
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
       mov       rdx,7FF94D751488
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF94D5A67A8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D7514A8
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
       call      qword ptr [7FF94D2B53C8]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF94D2B5308]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB5F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF94CD3A0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF94CD76640]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF94D5A5F50]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D751108
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
       mov       rdx,7FF94D751698
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF94CF7D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D7516D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF94CF7D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D751788
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF94CE56C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94D5A5FE0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF94D751128
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
       mov       rdx,7FF94D751140
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
       mov       rdx,7FF94D7512A8
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
       mov       rdx,7FF94D7512C0
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
       mov       rdx,7FF94D751458
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF94D5A6478]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D751478
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
       call      qword ptr [7FF94D2B4348]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF94D2B4288]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB5F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF94CD3A0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF94CD76640]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF94D5C61C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D771B70
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
       mov       rdx,7FF94D772100
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF94CF9E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D772138
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF94CF9E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D7721F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF94CE76C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94D5C6250]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF94D771B90
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
       mov       rdx,7FF94D771BA8
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
       mov       rdx,7FF94D771D10
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
       mov       rdx,7FF94D771D28
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
       mov       rdx,7FF94D771EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF94D5C66E8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D771EE0
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
       call      qword ptr [7FF94D2D53C8]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF94D2D5308]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB7F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF94CD96640]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF94D5C7A68]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D7B97D8
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
       mov       rdx,7FF94D7B9D68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF94CF9E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D7B9DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF94CF9E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D7B9E58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF94CE76C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94D5C7AF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF94D7B97F8
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
       mov       rdx,7FF94D7B9810
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
       mov       rdx,7FF94D7B9978
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
       mov       rdx,7FF94D7B9990
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
       mov       rdx,7FF94D7B9B28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF94D5C7F90]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D7B9B48
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
       call      qword ptr [7FF94D2D53C8]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF94D2D5308]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB7F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF94CD96640]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF94D69EAF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D7D8F98
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
       mov       rdx,7FF94D7D9528
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF94CF9E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D7D9560
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF94CF9E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D7D9618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF94CE76C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94D69EB80]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,offset System.Collections.Generic.List`1[[BenchmarkDotNet.Reports.Measurement, BenchmarkDotNet]].get_Item(Int32)
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
       mov       rdx,7FF94D7D8FD0
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
       mov       rdx,7FF94D7D9138
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
       mov       rdx,7FF94D7D9150
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
       mov       rdx,7FF94D7D92E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF94D69F000]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D7D9308
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
       call      qword ptr [7FF94D2D6958]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF94D2D6898]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB7F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF94CD96640]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListBenchmark.Create_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF94D786280]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D7DE4B0
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
       mov       rdx,7FF94D7DEA40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FF94CF9E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D7DEA78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FF94CF9E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FF94D7DEB30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FF94CE76C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF94D786310]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FF94D7DE4D0
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
       mov       rdx,7FF94D7DE4E8
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
       mov       rdx,7FF94D7DE650
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
       mov       rdx,7FF94D7DE668
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
       mov       rdx,7FF94D7DE800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FF94D7867A8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF94D7DE820
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
       call      qword ptr [7FF94D2D53C8]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FF94D2D5308]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF94CB7F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF94CD96640]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```

