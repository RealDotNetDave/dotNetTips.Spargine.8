## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       cmp       qword ptr [rbx+188],0
       je        near ptr M00_L02
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+188]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFF2021C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,2A8A8D752C4
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M00_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rsi+18],r8d
M00_L00:
       xor       edi,edi
       mov       rcx,[rbx+188]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L06
M00_L01:
       mov       rcx,[rbx+188]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,2681AC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2A8A8D752D8
       call      qword ptr [7FFF20134810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L05
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L03
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L04
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L04
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L03:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       mov       [rsi+18],ebp
M00_L05:
       inc       edi
       mov       rcx,[rbx+188]
       mov       ecx,[rcx+8]
       movsxd    rax,edi
       cmp       rcx,rax
       jg        near ptr M00_L01
M00_L06:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M00_L10
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFF2020B060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF2021CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF2021CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L05
M00_L10:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFF2021C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L07
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 500
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M01_L02
       cmp       esi,[rbx+20]
       jg        near ptr M01_L03
       mov       edx,[rbx+1C]
       mov       ecx,edx
       add       ecx,[rbx+18]
       cmp       ecx,esi
       jg        near ptr M01_L04
       mov       rcx,[rbx+8]
       mov       r8d,edx
       add       r8d,[rcx+8]
       cmp       r8d,esi
       je        short M01_L01
       sub       esi,edx
       mov       edx,esi
       cmp       edx,400
       jl        near ptr M01_L05
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rsi,rax
M01_L00:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFF1FEF7738]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,2E5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFF207FFC18]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF202A6CE8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF202A7180]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M01_L00
; Total bytes of code 331
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E0
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0B0],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rax,6CFCD29E590D
       mov       [rbp+0A8],rax
       mov       rbx,r8
       mov       esi,ecx
       test      rdx,rdx
       jne       short M02_L01
       xor       edi,edi
       xor       r14d,r14d
       jmp       short M02_L02
M02_L01:
       lea       rdi,[rdx+0C]
       mov       r14d,[rdx+8]
M02_L02:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+90]
       call      qword ptr [7FFF20134228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r13d,r15d
       and       r13d,0FFDF
       cmp       r13d,47
       je        short M02_L03
       cmp       r13d,44
       jne       short M02_L04
       jmp       near ptr M02_L27
M02_L03:
       cmp       dword ptr [rbp+90],0
       jle       near ptr M02_L27
M02_L04:
       cmp       r13d,58
       jne       near ptr M02_L12
       mov       r13d,[rbp+90]
       mov       ecx,1
       test      r13d,r13d
       cmovle    r13d,ecx
       mov       ecx,esi
       or        rcx,1
       lzcnt     rcx,rcx
       xor       ecx,3F
       sar       ecx,2
       inc       ecx
       cmp       r13d,ecx
       mov       ebx,ecx
       cmovge    ebx,r13d
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       test      rax,rax
       je        near ptr M02_L11
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M02_L05:
       movsxd    rdx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,r13d
       dec       edx
       js        short M02_L08
M02_L06:
       mov       r8d,esi
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M02_L10
       mov       r10d,30
M02_L07:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       esi,4
       dec       edx
       jns       short M02_L06
M02_L08:
       test      esi,esi
       jne       short M02_L06
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       rcx,6CFCD29E590D
       cmp       [rbp+0A8],rcx
       je        short M02_L09
       call      CORINFO_HELP_FAIL_FAST
M02_L09:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L10:
       lea       r10d,[r15-21]
       movzx     r10d,r10w
       jmp       short M02_L07
M02_L11:
       xor       ecx,ecx
       jmp       short M02_L05
M02_L12:
       cmp       r13d,42
       jne       short M02_L14
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF2011FD20]
       mov       rcx,6CFCD29E590D
       cmp       [rbp+0A8],rcx
       je        short M02_L13
       call      CORINFO_HELP_FAIL_FAST
M02_L13:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L14:
       test      rbx,rbx
       je        short M02_L15
       mov       rcx,rbx
       call      qword ptr [7FFF200EF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFF200EF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFF207CE880]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       mov       rdx,[rbp+80]
       lea       rcx,[rdx+0A]
       mov       eax,esi
       xor       r8d,r8d
       cmp       eax,64
       jb        short M02_L18
M02_L17:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,eax
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       eax,r9d
       mov       r9,2681AC00298
       mov       r9,[r9]
       add       eax,eax
       mov       ax,[r9+rax+10]
       mov       [rcx],ax
       cmp       r10d,64
       mov       eax,r10d
       jae       short M02_L17
M02_L18:
       test      eax,eax
       je        short M02_L20
M02_L19:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,eax
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,eax
       sub       r11d,r9d
       mov       eax,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       test      eax,eax
       jne       short M02_L19
M02_L20:
       test      r8d,r8d
       jg        short M02_L19
       add       rdx,0A
       sub       rdx,rcx
       mov       [rbp+70],edx
       mov       [rbp+74],edx
       mov       rax,[rbp+80]
       jmp       short M02_L22
M02_L21:
       lea       r8,[rax+1]
       lea       r10,[rcx+1]
       movzx     ecx,byte ptr [rcx]
       mov       [rax],cl
       mov       rax,r8
       mov       rcx,r10
M02_L22:
       dec       edx
       jns       short M02_L21
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+8],rdx
       mov       dword ptr [rbp+10],20
       lea       rdx,[rbp+8]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFF2074F8B8]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFF2074D6B0]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFF207C4330]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFF2074F9C0]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFF2005C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,2681AC01DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFF20293A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,6CFCD29E590D
       cmp       [rbp+0A8],rcx
       je        short M02_L26
       call      CORINFO_HELP_FAIL_FAST
M02_L26:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L27:
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF2011FE40]
       mov       rcx,6CFCD29E590D
       cmp       [rbp+0A8],rcx
       je        short M02_L28
       call      CORINFO_HELP_FAIL_FAST
M02_L28:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 996
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L01
       test      r8b,18
       jne       short M03_L05
       test      r8b,4
       je        short M03_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L04
M03_L00:
       test      r8,r8
       je        short M03_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L04
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L04
M03_L01:
       cmp       r8,40
       ja        short M03_L07
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L06
M03_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L04:
       ret
M03_L05:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M03_L04
M03_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L03
M03_L07:
       cmp       r8,800
       ja        short M03_L09
       mov       r9,r8
       shr       r9,6
M03_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L08
       and       r8,3F
       cmp       r8,10
       ja        short M03_L02
       jmp       short M03_L03
M03_L09:
       jmp       qword ptr [7FFF20055B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L10:
       cmp       rcx,rdx
       je        short M03_L04
       jmp       short M03_L09
; Total bytes of code 250
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M04_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L02
       cmp       [rdx+8],r8d
       jb        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF202A6EE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,2A8A8D60008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M05_L03
       cmp       r8d,edi
       jl        near ptr M05_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M05_L01
       test      r8,r8
       je        near ptr M05_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M05_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M05_L00:
       cmp       ebp,r10d
       ja        near ptr M05_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2021CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M05_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M05_L07
M05_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF202A6FB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFF2015E9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFF2015E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF7F4585A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFF7F441D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       cmp       qword ptr [rbx+188],0
       je        near ptr M00_L02
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+188]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFF201DC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,272937A52C4
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M00_L10
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rsi+18],r8d
M00_L00:
       xor       edi,edi
       mov       rcx,[rbx+188]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L04
M00_L01:
       mov       rcx,[rbx+188]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,23201800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,272937A52D8
       call      qword ptr [7FFF20104810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L03
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M00_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L07
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L07
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       edi
       mov       rcx,[rbx+188]
       mov       ecx,[rcx+8]
       movsxd    rax,edi
       cmp       rcx,rax
       jg        near ptr M00_L01
M00_L04:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M00_L09
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L07:
       mov       [rsi+18],ebp
       jmp       short M00_L03
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFF201DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L05
M00_L10:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 510
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M01_L02
       cmp       esi,[rbx+20]
       jg        near ptr M01_L03
       mov       edx,[rbx+1C]
       mov       ecx,edx
       add       ecx,[rbx+18]
       cmp       ecx,esi
       jg        near ptr M01_L04
       mov       rcx,[rbx+8]
       mov       r8d,edx
       add       r8d,[rcx+8]
       cmp       r8d,esi
       je        short M01_L01
       sub       esi,edx
       mov       edx,esi
       cmp       edx,400
       jl        near ptr M01_L05
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rsi,rax
M01_L00:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFF1FEC7738]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,2E5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFF207AEEC8]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20466190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M01_L00
; Total bytes of code 331
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E0
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0B0],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rax,8ADD6F72A7F6
       mov       [rbp+0A8],rax
       mov       rbx,r8
       mov       esi,ecx
       test      rdx,rdx
       jne       short M02_L01
       xor       edi,edi
       xor       r14d,r14d
       jmp       short M02_L02
M02_L01:
       lea       rdi,[rdx+0C]
       mov       r14d,[rdx+8]
M02_L02:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+90]
       call      qword ptr [7FFF20104228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r13d,r15d
       and       r13d,0FFDF
       cmp       r13d,47
       je        short M02_L03
       cmp       r13d,44
       jne       short M02_L04
       jmp       near ptr M02_L27
M02_L03:
       cmp       dword ptr [rbp+90],0
       jle       near ptr M02_L27
M02_L04:
       cmp       r13d,58
       jne       near ptr M02_L12
       mov       r13d,[rbp+90]
       mov       ecx,1
       test      r13d,r13d
       cmovle    r13d,ecx
       mov       ecx,esi
       or        rcx,1
       lzcnt     rcx,rcx
       xor       ecx,3F
       sar       ecx,2
       inc       ecx
       cmp       r13d,ecx
       mov       ebx,ecx
       cmovge    ebx,r13d
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       test      rax,rax
       je        near ptr M02_L11
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M02_L05:
       movsxd    rdx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,r13d
       dec       edx
       js        short M02_L08
M02_L06:
       mov       r8d,esi
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M02_L10
       mov       r10d,30
M02_L07:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       esi,4
       dec       edx
       jns       short M02_L06
M02_L08:
       test      esi,esi
       jne       short M02_L06
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       rcx,8ADD6F72A7F6
       cmp       [rbp+0A8],rcx
       je        short M02_L09
       call      CORINFO_HELP_FAIL_FAST
M02_L09:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L10:
       lea       r10d,[r15-21]
       movzx     r10d,r10w
       jmp       short M02_L07
M02_L11:
       xor       ecx,ecx
       jmp       short M02_L05
M02_L12:
       cmp       r13d,42
       jne       short M02_L14
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF200EFD20]
       mov       rcx,8ADD6F72A7F6
       cmp       [rbp+0A8],rcx
       je        short M02_L13
       call      CORINFO_HELP_FAIL_FAST
M02_L13:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L14:
       test      rbx,rbx
       je        short M02_L15
       mov       rcx,rbx
       call      qword ptr [7FFF200BF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFF200BF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFF207A58A8]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       mov       rdx,[rbp+80]
       lea       rcx,[rdx+0A]
       mov       eax,esi
       xor       r8d,r8d
       cmp       eax,64
       jb        short M02_L18
M02_L17:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,eax
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       eax,r9d
       mov       r9,23201800298
       mov       r9,[r9]
       add       eax,eax
       mov       ax,[r9+rax+10]
       mov       [rcx],ax
       cmp       r10d,64
       mov       eax,r10d
       jae       short M02_L17
M02_L18:
       test      eax,eax
       je        short M02_L20
M02_L19:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,eax
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,eax
       sub       r11d,r9d
       mov       eax,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       test      eax,eax
       jne       short M02_L19
M02_L20:
       test      r8d,r8d
       jg        short M02_L19
       add       rdx,0A
       sub       rdx,rcx
       mov       [rbp+70],edx
       mov       [rbp+74],edx
       mov       rax,[rbp+80]
       jmp       short M02_L22
M02_L21:
       lea       r8,[rax+1]
       lea       r10,[rcx+1]
       movzx     ecx,byte ptr [rcx]
       mov       [rax],cl
       mov       rax,r8
       mov       rcx,r10
M02_L22:
       dec       edx
       jns       short M02_L21
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+8],rdx
       mov       dword ptr [rbp+10],20
       lea       rdx,[rbp+8]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFF20737198]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFF20734F90]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFF207674F8]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFF207372A0]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFF2002C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,23201801DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFF20253A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,8ADD6F72A7F6
       cmp       [rbp+0A8],rcx
       je        short M02_L26
       call      CORINFO_HELP_FAIL_FAST
M02_L26:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L27:
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF200EFE40]
       mov       rcx,8ADD6F72A7F6
       cmp       [rbp+0A8],rcx
       je        short M02_L28
       call      CORINFO_HELP_FAIL_FAST
M02_L28:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 996
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,27293790008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L10
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        short M04_L01
       test      r8b,18
       jne       short M04_L03
       test      r8b,4
       jne       short M04_L04
       test      r8,r8
       je        short M04_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L00
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
M04_L00:
       pop       rbx
       pop       rsi
       ret
M04_L01:
       cmp       r8,40
       jbe       short M04_L05
       cmp       r8,800
       jbe       short M04_L08
M04_L02:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF20025B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M04_L00
M04_L04:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M04_L00
M04_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L07
M04_L06:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M04_L00
M04_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L06
M04_L08:
       mov       rax,r8
       shr       rax,6
M04_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M04_L09
       and       r8,3F
       cmp       r8,10
       ja        short M04_L05
       jmp       short M04_L06
M04_L10:
       cmp       rcx,rdx
       je        near ptr M04_L00
       jmp       near ptr M04_L02
; Total bytes of code 261
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M05_L03
       cmp       r8d,edi
       jl        near ptr M05_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M05_L01
       test      r8,r8
       je        near ptr M05_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M05_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M05_L00:
       cmp       ebp,r10d
       ja        near ptr M05_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M05_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M05_L07
M05_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFF2012E9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFF2012E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF7F4585A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFF7F441D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       cmp       qword ptr [rbx+188],0
       je        near ptr M00_L02
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+188]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFF2021C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,29DE54452C4
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M00_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rsi+18],r8d
M00_L00:
       xor       edi,edi
       mov       rcx,[rbx+188]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L06
M00_L01:
       mov       rcx,[rbx+188]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,25D57400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,29DE54452D8
       call      qword ptr [7FFF20144810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L05
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L03
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L04
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L04
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L03:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       mov       [rsi+18],ebp
M00_L05:
       inc       edi
       mov       rcx,[rbx+188]
       mov       ecx,[rcx+8]
       movsxd    rax,edi
       cmp       rcx,rax
       jg        near ptr M00_L01
M00_L06:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M00_L10
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFF2020B060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF2021CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF2021CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L05
M00_L10:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFF2021C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L07
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 500
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M01_L02
       cmp       esi,[rbx+20]
       jg        near ptr M01_L03
       mov       edx,[rbx+1C]
       mov       ecx,edx
       add       ecx,[rbx+18]
       cmp       ecx,esi
       jg        near ptr M01_L04
       mov       rcx,[rbx+8]
       mov       r8d,edx
       add       r8d,[rcx+8]
       cmp       r8d,esi
       je        short M01_L01
       sub       esi,edx
       mov       edx,esi
       cmp       edx,400
       jl        near ptr M01_L05
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rsi,rax
M01_L00:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFF1FF07738]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,2E5
       mov       rdx,7FFF1FE64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFF207EF048]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF204A5CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2006D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF204A6190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2006D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M01_L00
; Total bytes of code 331
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E0
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0B0],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rax,51E24816B2A4
       mov       [rbp+0A8],rax
       mov       rbx,r8
       mov       esi,ecx
       test      rdx,rdx
       jne       short M02_L01
       xor       edi,edi
       xor       r14d,r14d
       jmp       short M02_L02
M02_L01:
       lea       rdi,[rdx+0C]
       mov       r14d,[rdx+8]
M02_L02:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+90]
       call      qword ptr [7FFF20144228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r13d,r15d
       and       r13d,0FFDF
       cmp       r13d,47
       je        short M02_L03
       cmp       r13d,44
       jne       short M02_L04
       jmp       near ptr M02_L27
M02_L03:
       cmp       dword ptr [rbp+90],0
       jle       near ptr M02_L27
M02_L04:
       cmp       r13d,58
       jne       near ptr M02_L12
       mov       r13d,[rbp+90]
       mov       ecx,1
       test      r13d,r13d
       cmovle    r13d,ecx
       mov       ecx,esi
       or        rcx,1
       lzcnt     rcx,rcx
       xor       ecx,3F
       sar       ecx,2
       inc       ecx
       cmp       r13d,ecx
       mov       ebx,ecx
       cmovge    ebx,r13d
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       test      rax,rax
       je        near ptr M02_L11
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M02_L05:
       movsxd    rdx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,r13d
       dec       edx
       js        short M02_L08
M02_L06:
       mov       r8d,esi
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M02_L10
       mov       r10d,30
M02_L07:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       esi,4
       dec       edx
       jns       short M02_L06
M02_L08:
       test      esi,esi
       jne       short M02_L06
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       rcx,51E24816B2A4
       cmp       [rbp+0A8],rcx
       je        short M02_L09
       call      CORINFO_HELP_FAIL_FAST
M02_L09:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L10:
       lea       r10d,[r15-21]
       movzx     r10d,r10w
       jmp       short M02_L07
M02_L11:
       xor       ecx,ecx
       jmp       short M02_L05
M02_L12:
       cmp       r13d,42
       jne       short M02_L14
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF2012FD20]
       mov       rcx,51E24816B2A4
       cmp       [rbp+0A8],rcx
       je        short M02_L13
       call      CORINFO_HELP_FAIL_FAST
M02_L13:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L14:
       test      rbx,rbx
       je        short M02_L15
       mov       rcx,rbx
       call      qword ptr [7FFF200FF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFF200FF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFF207E53E0]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       mov       rdx,[rbp+80]
       lea       rcx,[rdx+0A]
       mov       eax,esi
       xor       r8d,r8d
       cmp       eax,64
       jb        short M02_L18
M02_L17:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,eax
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       eax,r9d
       mov       r9,25D57400298
       mov       r9,[r9]
       add       eax,eax
       mov       ax,[r9+rax+10]
       mov       [rcx],ax
       cmp       r10d,64
       mov       eax,r10d
       jae       short M02_L17
M02_L18:
       test      eax,eax
       je        short M02_L20
M02_L19:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,eax
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,eax
       sub       r11d,r9d
       mov       eax,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       test      eax,eax
       jne       short M02_L19
M02_L20:
       test      r8d,r8d
       jg        short M02_L19
       add       rdx,0A
       sub       rdx,rcx
       mov       [rbp+70],edx
       mov       [rbp+74],edx
       mov       rax,[rbp+80]
       jmp       short M02_L22
M02_L21:
       lea       r8,[rax+1]
       lea       r10,[rcx+1]
       movzx     ecx,byte ptr [rcx]
       mov       [rax],cl
       mov       rax,r8
       mov       rcx,r10
M02_L22:
       dec       edx
       jns       short M02_L21
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+8],rdx
       mov       dword ptr [rbp+10],20
       lea       rdx,[rbp+8]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFF207761F0]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFF2072FFC0]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFF207A6DD8]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFF207762F8]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFF2006C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,25D57401DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFF20293A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,51E24816B2A4
       cmp       [rbp+0A8],rcx
       je        short M02_L26
       call      CORINFO_HELP_FAIL_FAST
M02_L26:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L27:
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF2012FE40]
       mov       rcx,51E24816B2A4
       cmp       [rbp+0A8],rcx
       je        short M02_L28
       call      CORINFO_HELP_FAIL_FAST
M02_L28:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 996
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L09
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        short M03_L01
       test      r8b,18
       je        short M03_L04
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
M03_L00:
       pop       rbx
       pop       rsi
       ret
M03_L01:
       cmp       r8,40
       ja        short M03_L05
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M03_L03:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M03_L00
M03_L04:
       test      r8b,4
       jne       short M03_L06
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       short M03_L00
M03_L05:
       cmp       r8,800
       ja        short M03_L10
       jmp       short M03_L07
M03_L06:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M03_L00
M03_L07:
       mov       rax,r8
       shr       rax,6
M03_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M03_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L02
       jmp       short M03_L03
M03_L09:
       cmp       rcx,rdx
       je        near ptr M03_L00
M03_L10:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF20065B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 260
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M04_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L02
       cmp       [rdx+8],r8d
       jb        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF204A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2006D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,29DE5430008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M05_L03
       cmp       r8d,edi
       jl        near ptr M05_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M05_L01
       test      r8,r8
       je        near ptr M05_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M05_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M05_L00:
       cmp       ebp,r10d
       ja        near ptr M05_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2021CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M05_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M05_L07
M05_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF204A5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2006D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFF2016E9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFF2016E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF7F4585A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFF7F441D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       cmp       qword ptr [rbx+188],0
       je        near ptr M00_L02
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+188]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFF201DC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,207CF845314
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M00_L10
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rsi+18],r8d
M00_L00:
       xor       edi,edi
       mov       rcx,[rbx+188]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L04
M00_L01:
       mov       rcx,[rbx+188]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,1C73D800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,207CF845328
       call      qword ptr [7FFF20104810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L03
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M00_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L07
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L07
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       edi
       mov       rcx,[rbx+188]
       mov       ecx,[rcx+8]
       movsxd    rax,edi
       cmp       rcx,rax
       jg        near ptr M00_L01
M00_L04:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M00_L09
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L07:
       mov       [rsi+18],ebp
       jmp       short M00_L03
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFF201DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L05
M00_L10:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 510
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,esi
       mov       rdx,207CF830390
       call      qword ptr [7FFF202D40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       cmp       esi,[rbx+20]
       jg        short M01_L02
       mov       edx,[rbx+1C]
       mov       ecx,edx
       add       ecx,[rbx+18]
       cmp       ecx,esi
       jg        near ptr M01_L03
       mov       rcx,[rbx+8]
       mov       r8d,edx
       add       r8d,[rcx+8]
       cmp       r8d,esi
       je        short M01_L01
       sub       esi,edx
       mov       edx,esi
       cmp       edx,400
       jl        near ptr M01_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rsi,rax
M01_L00:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFF1FEC7738]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20466190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M01_L00
; Total bytes of code 309
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E0
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0B0],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rax,0EAFD08A00A6
       mov       [rbp+0A8],rax
       mov       rbx,r8
       mov       esi,ecx
       test      rdx,rdx
       jne       short M02_L01
       xor       edi,edi
       xor       r14d,r14d
       jmp       short M02_L02
M02_L01:
       lea       rdi,[rdx+0C]
       mov       r14d,[rdx+8]
M02_L02:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+90]
       call      qword ptr [7FFF20104228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r13d,r15d
       and       r13d,0FFDF
       cmp       r13d,47
       je        short M02_L03
       cmp       r13d,44
       jne       short M02_L04
       jmp       near ptr M02_L27
M02_L03:
       cmp       dword ptr [rbp+90],0
       jle       near ptr M02_L27
M02_L04:
       cmp       r13d,58
       jne       near ptr M02_L12
       mov       r13d,[rbp+90]
       mov       ecx,1
       test      r13d,r13d
       cmovle    r13d,ecx
       mov       ecx,esi
       or        rcx,1
       lzcnt     rcx,rcx
       xor       ecx,3F
       sar       ecx,2
       inc       ecx
       cmp       r13d,ecx
       mov       ebx,ecx
       cmovge    ebx,r13d
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       test      rax,rax
       je        near ptr M02_L11
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M02_L05:
       movsxd    rdx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,r13d
       dec       edx
       js        short M02_L08
M02_L06:
       mov       r8d,esi
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M02_L10
       mov       r10d,30
M02_L07:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       esi,4
       dec       edx
       jns       short M02_L06
M02_L08:
       test      esi,esi
       jne       short M02_L06
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       rcx,0EAFD08A00A6
       cmp       [rbp+0A8],rcx
       je        short M02_L09
       call      CORINFO_HELP_FAIL_FAST
M02_L09:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L10:
       lea       r10d,[r15-21]
       movzx     r10d,r10w
       jmp       short M02_L07
M02_L11:
       xor       ecx,ecx
       jmp       short M02_L05
M02_L12:
       cmp       r13d,42
       jne       short M02_L14
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF200EFD20]
       mov       rcx,0EAFD08A00A6
       cmp       [rbp+0A8],rcx
       je        short M02_L13
       call      CORINFO_HELP_FAIL_FAST
M02_L13:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L14:
       test      rbx,rbx
       je        short M02_L15
       mov       rcx,rbx
       call      qword ptr [7FFF200BF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFF200BF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFF207CC1F8]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       mov       rdx,[rbp+80]
       lea       rcx,[rdx+0A]
       mov       eax,esi
       xor       r8d,r8d
       cmp       eax,64
       jb        short M02_L18
M02_L17:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,eax
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       eax,r9d
       mov       r9,1C73D800298
       mov       r9,[r9]
       add       eax,eax
       mov       ax,[r9+rax+10]
       mov       [rcx],ax
       cmp       r10d,64
       mov       eax,r10d
       jae       short M02_L17
M02_L18:
       test      eax,eax
       je        short M02_L20
M02_L19:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,eax
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,eax
       sub       r11d,r9d
       mov       eax,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       test      eax,eax
       jne       short M02_L19
M02_L20:
       test      r8d,r8d
       jg        short M02_L19
       add       rdx,0A
       sub       rdx,rcx
       mov       [rbp+70],edx
       mov       [rbp+74],edx
       mov       rax,[rbp+80]
       jmp       short M02_L22
M02_L21:
       lea       r8,[rax+1]
       lea       r10,[rcx+1]
       movzx     ecx,byte ptr [rcx]
       mov       [rax],cl
       mov       rax,r8
       mov       rcx,r10
M02_L22:
       dec       edx
       jns       short M02_L21
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+8],rdx
       mov       dword ptr [rbp+10],20
       lea       rdx,[rbp+8]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFF2074D758]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFF20747540]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFF2077DDB8]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFF2074D860]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFF2002C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,1C73D801DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFF20253A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0EAFD08A00A6
       cmp       [rbp+0A8],rcx
       je        short M02_L26
       call      CORINFO_HELP_FAIL_FAST
M02_L26:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L27:
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF200EFE40]
       mov       rcx,0EAFD08A00A6
       cmp       [rbp+0A8],rcx
       je        short M02_L28
       call      CORINFO_HELP_FAIL_FAST
M02_L28:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 996
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,207CF830008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L10
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        short M04_L01
       test      r8b,18
       jne       short M04_L03
       test      r8b,4
       jne       short M04_L04
       test      r8,r8
       je        short M04_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L00
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
M04_L00:
       pop       rbx
       pop       rsi
       ret
M04_L01:
       cmp       r8,40
       jbe       short M04_L05
       cmp       r8,800
       jbe       short M04_L08
M04_L02:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF20025B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M04_L00
M04_L04:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M04_L00
M04_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L07
M04_L06:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M04_L00
M04_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M04_L11
       jmp       short M04_L06
M04_L08:
       mov       rax,r8
       shr       rax,6
M04_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M04_L09
       and       r8,3F
       cmp       r8,10
       ja        short M04_L05
       jmp       short M04_L06
M04_L10:
       cmp       rcx,rdx
       je        near ptr M04_L00
       jmp       near ptr M04_L02
M04_L11:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L06
; Total bytes of code 263
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M05_L03
       cmp       r8d,edi
       jl        near ptr M05_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M05_L01
       test      r8,r8
       je        near ptr M05_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M05_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M05_L00:
       cmp       ebp,r10d
       ja        near ptr M05_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M05_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M05_L07
M05_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFF2012E9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFF2012E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF7F4585A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFF7F441D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       cmp       qword ptr [rbx+188],0
       je        near ptr M00_L03
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+188]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFF201FC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,20772825314
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M00_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rsi+18],r8d
M00_L00:
       xor       edi,edi
       mov       rcx,[rbx+188]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L05
M00_L01:
       mov       rcx,[rbx+188]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L12
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,1C6E0800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,20772825328
       call      qword ptr [7FFF20124810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L04
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M00_L09
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L07
M00_L02:
       mov       [rsi+18],ebp
       jmp       short M00_L04
M00_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       inc       edi
       mov       rcx,[rbx+188]
       mov       ecx,[rcx+8]
       movsxd    rax,edi
       cmp       rcx,rax
       jg        near ptr M00_L01
M00_L05:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L11
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L02
M00_L08:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,rsi
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFF201FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L06
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 521
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,esi
       mov       rdx,20772810390
       call      qword ptr [7FFF202F40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       cmp       esi,[rbx+20]
       jg        short M01_L02
       mov       edx,[rbx+1C]
       mov       ecx,edx
       add       ecx,[rbx+18]
       cmp       ecx,esi
       jg        near ptr M01_L03
       mov       rcx,[rbx+8]
       mov       r8d,edx
       add       r8d,[rcx+8]
       cmp       r8d,esi
       je        short M01_L01
       sub       esi,edx
       mov       edx,esi
       cmp       edx,400
       jl        near ptr M01_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rsi,rax
M01_L00:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFF1FEE7738]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20486190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M01_L00
; Total bytes of code 309
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E0
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0B0],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rax,0B0E1361A853E
       mov       [rbp+0A8],rax
       mov       rbx,r8
       mov       esi,ecx
       test      rdx,rdx
       jne       short M02_L01
       xor       edi,edi
       xor       r14d,r14d
       jmp       short M02_L02
M02_L01:
       lea       rdi,[rdx+0C]
       mov       r14d,[rdx+8]
M02_L02:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+90]
       call      qword ptr [7FFF20124228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r13d,r15d
       and       r13d,0FFDF
       cmp       r13d,47
       je        short M02_L03
       cmp       r13d,44
       jne       short M02_L04
       jmp       near ptr M02_L27
M02_L03:
       cmp       dword ptr [rbp+90],0
       jle       near ptr M02_L27
M02_L04:
       cmp       r13d,58
       jne       near ptr M02_L12
       mov       r13d,[rbp+90]
       mov       ecx,1
       test      r13d,r13d
       cmovle    r13d,ecx
       mov       ecx,esi
       or        rcx,1
       lzcnt     rcx,rcx
       xor       ecx,3F
       sar       ecx,2
       inc       ecx
       cmp       r13d,ecx
       mov       ebx,ecx
       cmovge    ebx,r13d
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       test      rax,rax
       je        near ptr M02_L11
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M02_L05:
       movsxd    rdx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,r13d
       dec       edx
       js        short M02_L08
M02_L06:
       mov       r8d,esi
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M02_L10
       mov       r10d,30
M02_L07:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       esi,4
       dec       edx
       jns       short M02_L06
M02_L08:
       test      esi,esi
       jne       short M02_L06
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       rcx,0B0E1361A853E
       cmp       [rbp+0A8],rcx
       je        short M02_L09
       call      CORINFO_HELP_FAIL_FAST
M02_L09:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L10:
       lea       r10d,[r15-21]
       movzx     r10d,r10w
       jmp       short M02_L07
M02_L11:
       xor       ecx,ecx
       jmp       short M02_L05
M02_L12:
       cmp       r13d,42
       jne       short M02_L14
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF2010FD20]
       mov       rcx,0B0E1361A853E
       cmp       [rbp+0A8],rcx
       je        short M02_L13
       call      CORINFO_HELP_FAIL_FAST
M02_L13:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L14:
       test      rbx,rbx
       je        short M02_L15
       mov       rcx,rbx
       call      qword ptr [7FFF200DF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFF200DF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFF208C71F8]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       mov       rdx,[rbp+80]
       lea       rcx,[rdx+0A]
       mov       eax,esi
       xor       r8d,r8d
       cmp       eax,64
       jb        short M02_L18
M02_L17:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,eax
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       eax,r9d
       mov       r9,1C6E0800298
       mov       r9,[r9]
       add       eax,eax
       mov       ax,[r9+rax+10]
       mov       [rcx],ax
       cmp       r10d,64
       mov       eax,r10d
       jae       short M02_L17
M02_L18:
       test      eax,eax
       je        short M02_L20
M02_L19:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,eax
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,eax
       sub       r11d,r9d
       mov       eax,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       test      eax,eax
       jne       short M02_L19
M02_L20:
       test      r8d,r8d
       jg        short M02_L19
       add       rdx,0A
       sub       rdx,rcx
       mov       [rbp+70],edx
       mov       [rbp+74],edx
       mov       rax,[rbp+80]
       jmp       short M02_L22
M02_L21:
       lea       r8,[rax+1]
       lea       r10,[rcx+1]
       movzx     ecx,byte ptr [rcx]
       mov       [rax],cl
       mov       rax,r8
       mov       rcx,r10
M02_L22:
       dec       edx
       jns       short M02_L21
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+8],rdx
       mov       dword ptr [rbp+10],20
       lea       rdx,[rbp+8]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFF207DC678]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFF207D6328]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFF2089D050]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFF207DC780]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFF2004C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,1C6E0801DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFF20273A48]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0B0E1361A853E
       cmp       [rbp+0A8],rcx
       je        short M02_L26
       call      CORINFO_HELP_FAIL_FAST
M02_L26:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L27:
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF2010FE40]
       mov       rcx,0B0E1361A853E
       cmp       [rbp+0A8],rcx
       je        short M02_L28
       call      CORINFO_HELP_FAIL_FAST
M02_L28:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 996
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,20772810008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M04_L03
       cmp       r8d,edi
       jl        near ptr M04_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M04_L01
       test      r8,r8
       je        near ptr M04_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M04_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M04_L00:
       cmp       ebp,r10d
       ja        near ptr M04_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M04_L07
M04_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFF2014E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFF2014E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M05_L01
       test      r8b,18
       je        short M05_L04
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M05_L00:
       ret
M05_L01:
       cmp       r8,40
       ja        short M05_L06
M05_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M05_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M05_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M05_L00
M05_L04:
       test      r8b,4
       jne       short M05_L05
       test      r8,r8
       je        short M05_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M05_L00
M05_L05:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M05_L00
M05_L06:
       cmp       r8,800
       ja        short M05_L09
       mov       r9,r8
       shr       r9,6
M05_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M05_L07
       and       r8,3F
       cmp       r8,10
       ja        near ptr M05_L02
       jmp       short M05_L03
M05_L08:
       cmp       rcx,rdx
       je        near ptr M05_L00
M05_L09:
       jmp       qword ptr [7FFF20045B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 254
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF7F4585A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFF7F441D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       cmp       qword ptr [rbx+188],0
       je        near ptr M00_L03
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+188]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFF201EC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,24A40F1533C
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M00_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rsi+18],r8d
M00_L00:
       xor       edi,edi
       mov       rcx,[rbx+188]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L05
M00_L01:
       mov       rcx,[rbx+188]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L12
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,209AF000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,24A40F15350
       call      qword ptr [7FFF20114810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L04
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M00_L09
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L07
M00_L02:
       mov       [rsi+18],ebp
       jmp       short M00_L04
M00_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       inc       edi
       mov       rcx,[rbx+188]
       mov       ecx,[rcx+8]
       movsxd    rax,edi
       cmp       rcx,rax
       jg        near ptr M00_L01
M00_L05:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L11
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L02
M00_L08:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,rsi
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFF201EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L06
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 521
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,esi
       mov       rdx,24A40F00390
       call      qword ptr [7FFF202E40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       cmp       esi,[rbx+20]
       jg        short M01_L02
       mov       edx,[rbx+1C]
       mov       ecx,edx
       add       ecx,[rbx+18]
       cmp       ecx,esi
       jg        near ptr M01_L03
       mov       rcx,[rbx+8]
       mov       r8d,edx
       add       r8d,[rcx+8]
       cmp       r8d,esi
       je        short M01_L01
       sub       esi,edx
       mov       edx,esi
       cmp       edx,400
       jl        near ptr M01_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rsi,rax
M01_L00:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFF1FED7738]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20476190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M01_L00
; Total bytes of code 309
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E0
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0B0],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rax,0FE3D6CAC5211
       mov       [rbp+0A8],rax
       mov       rbx,r8
       mov       esi,ecx
       test      rdx,rdx
       jne       short M02_L01
       xor       edi,edi
       xor       r14d,r14d
       jmp       short M02_L02
M02_L01:
       lea       rdi,[rdx+0C]
       mov       r14d,[rdx+8]
M02_L02:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+90]
       call      qword ptr [7FFF20114228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r13d,r15d
       and       r13d,0FFDF
       cmp       r13d,47
       je        short M02_L03
       cmp       r13d,44
       jne       short M02_L04
       jmp       near ptr M02_L27
M02_L03:
       cmp       dword ptr [rbp+90],0
       jle       near ptr M02_L27
M02_L04:
       cmp       r13d,58
       jne       near ptr M02_L12
       mov       r13d,[rbp+90]
       mov       ecx,1
       test      r13d,r13d
       cmovle    r13d,ecx
       mov       ecx,esi
       or        rcx,1
       lzcnt     rcx,rcx
       xor       ecx,3F
       sar       ecx,2
       inc       ecx
       cmp       r13d,ecx
       mov       ebx,ecx
       cmovge    ebx,r13d
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       test      rax,rax
       je        near ptr M02_L11
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M02_L05:
       movsxd    rdx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,r13d
       dec       edx
       js        short M02_L08
M02_L06:
       mov       r8d,esi
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M02_L10
       mov       r10d,30
M02_L07:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       esi,4
       dec       edx
       jns       short M02_L06
M02_L08:
       test      esi,esi
       jne       short M02_L06
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       rcx,0FE3D6CAC5211
       cmp       [rbp+0A8],rcx
       je        short M02_L09
       call      CORINFO_HELP_FAIL_FAST
M02_L09:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L10:
       lea       r10d,[r15-21]
       movzx     r10d,r10w
       jmp       short M02_L07
M02_L11:
       xor       ecx,ecx
       jmp       short M02_L05
M02_L12:
       cmp       r13d,42
       jne       short M02_L14
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF200FFD20]
       mov       rcx,0FE3D6CAC5211
       cmp       [rbp+0A8],rcx
       je        short M02_L13
       call      CORINFO_HELP_FAIL_FAST
M02_L13:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L14:
       test      rbx,rbx
       je        short M02_L15
       mov       rcx,rbx
       call      qword ptr [7FFF200CF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFF200CF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFF208CC1E0]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       mov       rdx,[rbp+80]
       lea       rcx,[rdx+0A]
       mov       eax,esi
       xor       r8d,r8d
       cmp       eax,64
       jb        short M02_L18
M02_L17:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,eax
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       eax,r9d
       mov       r9,209AF000298
       mov       r9,[r9]
       add       eax,eax
       mov       ax,[r9+rax+10]
       mov       [rcx],ax
       cmp       r10d,64
       mov       eax,r10d
       jae       short M02_L17
M02_L18:
       test      eax,eax
       je        short M02_L20
M02_L19:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,eax
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,eax
       sub       r11d,r9d
       mov       eax,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       test      eax,eax
       jne       short M02_L19
M02_L20:
       test      r8d,r8d
       jg        short M02_L19
       add       rdx,0A
       sub       rdx,rcx
       mov       [rbp+70],edx
       mov       [rbp+74],edx
       mov       rax,[rbp+80]
       jmp       short M02_L22
M02_L21:
       lea       r8,[rax+1]
       lea       r10,[rcx+1]
       movzx     ecx,byte ptr [rcx]
       mov       [rax],cl
       mov       rax,r8
       mov       rcx,r10
M02_L22:
       dec       edx
       jns       short M02_L21
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+8],rdx
       mov       dword ptr [rbp+10],20
       lea       rdx,[rbp+8]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFF2085D1D0]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFF20856D30]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFF2089DD70]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFF2085D2D8]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFF2003C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,209AF001DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFF20263A48]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0FE3D6CAC5211
       cmp       [rbp+0A8],rcx
       je        short M02_L26
       call      CORINFO_HELP_FAIL_FAST
M02_L26:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L27:
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF200FFE40]
       mov       rcx,0FE3D6CAC5211
       cmp       [rbp+0A8],rcx
       je        short M02_L28
       call      CORINFO_HELP_FAIL_FAST
M02_L28:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 996
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,24A40F00008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M04_L03
       cmp       r8d,edi
       jl        near ptr M04_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M04_L01
       test      r8,r8
       je        near ptr M04_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M04_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M04_L00:
       cmp       ebp,r10d
       ja        near ptr M04_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201ECB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M04_L07
M04_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFF2013E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFF2013E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L02
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L02
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M05_L04
       test      r8b,18
       jne       near ptr M05_L08
       test      r8b,4
       jne       near ptr M05_L09
       test      r8,r8
       je        near ptr M05_L07
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M05_L07
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M05_L07
M05_L00:
       cmp       r8,800
       ja        short M05_L03
       mov       r9,r8
       shr       r9,6
M05_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M05_L01
       and       r8,3F
       cmp       r8,10
       ja        short M05_L05
       jmp       short M05_L06
M05_L02:
       cmp       rcx,rdx
       je        short M05_L07
M05_L03:
       jmp       qword ptr [7FFF20035B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L04:
       cmp       r8,40
       ja        short M05_L00
M05_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M05_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M05_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L07:
       ret
M05_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M05_L07
M05_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M05_L07
; Total bytes of code 269
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF7F4585A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFF7F441D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       cmp       qword ptr [rbx+188],0
       je        near ptr M00_L03
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+188]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFF2020C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,225342A533C
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M00_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rsi+18],r8d
M00_L00:
       xor       edi,edi
       mov       rcx,[rbx+188]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L05
M00_L01:
       mov       rcx,[rbx+188]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L12
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,1E4A2400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,225342A5350
       call      qword ptr [7FFF20134810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L04
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M00_L09
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L07
M00_L02:
       mov       [rsi+18],ebp
       jmp       short M00_L04
M00_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       inc       edi
       mov       rcx,[rbx+188]
       mov       ecx,[rcx+8]
       movsxd    rax,edi
       cmp       rcx,rax
       jg        near ptr M00_L01
M00_L05:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L11
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L02
M00_L08:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,rsi
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFF2020C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L06
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 521
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M01_L02
       cmp       esi,[rbx+20]
       jg        near ptr M01_L03
       mov       edx,[rbx+1C]
       mov       ecx,edx
       add       ecx,[rbx+18]
       cmp       ecx,esi
       jg        near ptr M01_L04
       mov       rcx,[rbx+8]
       mov       r8d,edx
       add       r8d,[rcx+8]
       cmp       r8d,esi
       je        short M01_L01
       sub       esi,edx
       mov       edx,esi
       cmp       edx,400
       jl        near ptr M01_L05
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rsi,rax
M01_L00:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFF1FEF7738]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,2E5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFF206A5188]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20496190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M01_L00
; Total bytes of code 331
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E0
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0B0],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rax,0D08D8F16FD4E
       mov       [rbp+0A8],rax
       mov       rbx,r8
       mov       esi,ecx
       test      rdx,rdx
       jne       short M02_L01
       xor       edi,edi
       xor       r14d,r14d
       jmp       short M02_L02
M02_L01:
       lea       rdi,[rdx+0C]
       mov       r14d,[rdx+8]
M02_L02:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+90]
       call      qword ptr [7FFF20134228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r13d,r15d
       and       r13d,0FFDF
       cmp       r13d,47
       je        short M02_L03
       cmp       r13d,44
       jne       short M02_L04
       jmp       near ptr M02_L27
M02_L03:
       cmp       dword ptr [rbp+90],0
       jle       near ptr M02_L27
M02_L04:
       cmp       r13d,58
       jne       near ptr M02_L12
       mov       r13d,[rbp+90]
       mov       ecx,1
       test      r13d,r13d
       cmovle    r13d,ecx
       mov       ecx,esi
       or        rcx,1
       lzcnt     rcx,rcx
       xor       ecx,3F
       sar       ecx,2
       inc       ecx
       cmp       r13d,ecx
       mov       ebx,ecx
       cmovge    ebx,r13d
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       test      rax,rax
       je        near ptr M02_L11
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M02_L05:
       movsxd    rdx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,r13d
       dec       edx
       js        short M02_L08
M02_L06:
       mov       r8d,esi
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M02_L10
       mov       r10d,30
M02_L07:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       esi,4
       dec       edx
       jns       short M02_L06
M02_L08:
       test      esi,esi
       jne       short M02_L06
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       rcx,0D08D8F16FD4E
       cmp       [rbp+0A8],rcx
       je        short M02_L09
       call      CORINFO_HELP_FAIL_FAST
M02_L09:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L10:
       lea       r10d,[r15-21]
       movzx     r10d,r10w
       jmp       short M02_L07
M02_L11:
       xor       ecx,ecx
       jmp       short M02_L05
M02_L12:
       cmp       r13d,42
       jne       short M02_L14
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF2011FD20]
       mov       rcx,0D08D8F16FD4E
       cmp       [rbp+0A8],rcx
       je        short M02_L13
       call      CORINFO_HELP_FAIL_FAST
M02_L13:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L14:
       test      rbx,rbx
       je        short M02_L15
       mov       rcx,rbx
       call      qword ptr [7FFF200EF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFF200EF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFF208E7528]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       mov       rdx,[rbp+80]
       lea       rcx,[rdx+0A]
       mov       eax,esi
       xor       r8d,r8d
       cmp       eax,64
       jb        short M02_L18
M02_L17:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,eax
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       eax,r9d
       mov       r9,1E4A2400298
       mov       r9,[r9]
       add       eax,eax
       mov       ax,[r9+rax+10]
       mov       [rcx],ax
       cmp       r10d,64
       mov       eax,r10d
       jae       short M02_L17
M02_L18:
       test      eax,eax
       je        short M02_L20
M02_L19:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,eax
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,eax
       sub       r11d,r9d
       mov       eax,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       test      eax,eax
       jne       short M02_L19
M02_L20:
       test      r8d,r8d
       jg        short M02_L19
       add       rdx,0A
       sub       rdx,rcx
       mov       [rbp+70],edx
       mov       [rbp+74],edx
       mov       rax,[rbp+80]
       jmp       short M02_L22
M02_L21:
       lea       r8,[rax+1]
       lea       r10,[rcx+1]
       movzx     ecx,byte ptr [rcx]
       mov       [rax],cl
       mov       rax,r8
       mov       rcx,r10
M02_L22:
       dec       edx
       jns       short M02_L21
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+8],rdx
       mov       dword ptr [rbp+10],20
       lea       rdx,[rbp+8]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFF2087CCF0]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFF20876AD8]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFF208BD158]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFF2087CDF8]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFF2005C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,1E4A2401DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFF20283A48]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0D08D8F16FD4E
       cmp       [rbp+0A8],rcx
       je        short M02_L26
       call      CORINFO_HELP_FAIL_FAST
M02_L26:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L27:
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF2011FE40]
       mov       rcx,0D08D8F16FD4E
       cmp       [rbp+0A8],rcx
       je        short M02_L28
       call      CORINFO_HELP_FAIL_FAST
M02_L28:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 996
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,22534290008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M04_L03
       cmp       r8d,edi
       jl        near ptr M04_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M04_L01
       test      r8,r8
       je        near ptr M04_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M04_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M04_L00:
       cmp       ebp,r10d
       ja        near ptr M04_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2020CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M04_L07
M04_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFF2015E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFF2015E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L02
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L02
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M05_L04
       test      r8b,18
       jne       near ptr M05_L08
       test      r8b,4
       jne       near ptr M05_L09
       test      r8,r8
       je        near ptr M05_L07
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M05_L07
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M05_L07
M05_L00:
       cmp       r8,800
       ja        short M05_L03
       mov       r9,r8
       shr       r9,6
M05_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M05_L01
       and       r8,3F
       cmp       r8,10
       ja        short M05_L05
       jmp       short M05_L06
M05_L02:
       cmp       rcx,rdx
       je        short M05_L07
M05_L03:
       jmp       qword ptr [7FFF20055B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L04:
       cmp       r8,40
       ja        short M05_L00
M05_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M05_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M05_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L07:
       ret
M05_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M05_L07
M05_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M05_L07
; Total bytes of code 269
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF7F4585A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFF7F441D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       cmp       qword ptr [rbx+188],0
       je        near ptr M00_L03
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+188]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFF201DC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,26DAFC8533C
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M00_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rsi+18],r8d
M00_L00:
       xor       edi,edi
       mov       rcx,[rbx+188]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L05
M00_L01:
       mov       rcx,[rbx+188]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L12
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,22D1DC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,26DAFC85350
       call      qword ptr [7FFF20104810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L04
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M00_L09
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L07
M00_L02:
       mov       [rsi+18],ebp
       jmp       short M00_L04
M00_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       inc       edi
       mov       rcx,[rbx+188]
       mov       ecx,[rcx+8]
       movsxd    rax,edi
       cmp       rcx,rax
       jg        near ptr M00_L01
M00_L05:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L11
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L02
M00_L08:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,rsi
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFF201DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L06
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 521
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M01_L02
       cmp       esi,[rbx+20]
       jg        near ptr M01_L03
       mov       edx,[rbx+1C]
       mov       ecx,edx
       add       ecx,[rbx+18]
       cmp       ecx,esi
       jg        near ptr M01_L04
       mov       rcx,[rbx+8]
       mov       r8d,edx
       add       r8d,[rcx+8]
       cmp       r8d,esi
       je        short M01_L01
       sub       esi,edx
       mov       edx,esi
       cmp       edx,400
       jl        near ptr M01_L05
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rsi,rax
M01_L00:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFF1FEC7738]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       ecx,2E5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFF20675080]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20466190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M01_L00
; Total bytes of code 331
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E0
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0B0],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rax,1479BFD4DD60
       mov       [rbp+0A8],rax
       mov       rbx,r8
       mov       esi,ecx
       test      rdx,rdx
       jne       short M02_L01
       xor       edi,edi
       xor       r14d,r14d
       jmp       short M02_L02
M02_L01:
       lea       rdi,[rdx+0C]
       mov       r14d,[rdx+8]
M02_L02:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+90]
       call      qword ptr [7FFF20104228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r13d,r15d
       and       r13d,0FFDF
       cmp       r13d,47
       je        short M02_L03
       cmp       r13d,44
       jne       short M02_L04
       jmp       near ptr M02_L27
M02_L03:
       cmp       dword ptr [rbp+90],0
       jle       near ptr M02_L27
M02_L04:
       cmp       r13d,58
       jne       near ptr M02_L12
       mov       r13d,[rbp+90]
       mov       ecx,1
       test      r13d,r13d
       cmovle    r13d,ecx
       mov       ecx,esi
       or        rcx,1
       lzcnt     rcx,rcx
       xor       ecx,3F
       sar       ecx,2
       inc       ecx
       cmp       r13d,ecx
       mov       ebx,ecx
       cmovge    ebx,r13d
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       test      rax,rax
       je        near ptr M02_L11
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M02_L05:
       movsxd    rdx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,r13d
       dec       edx
       js        short M02_L08
M02_L06:
       mov       r8d,esi
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M02_L10
       mov       r10d,30
M02_L07:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       esi,4
       dec       edx
       jns       short M02_L06
M02_L08:
       test      esi,esi
       jne       short M02_L06
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       rcx,1479BFD4DD60
       cmp       [rbp+0A8],rcx
       je        short M02_L09
       call      CORINFO_HELP_FAIL_FAST
M02_L09:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L10:
       lea       r10d,[r15-21]
       movzx     r10d,r10w
       jmp       short M02_L07
M02_L11:
       xor       ecx,ecx
       jmp       short M02_L05
M02_L12:
       cmp       r13d,42
       jne       short M02_L14
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF200EFD20]
       mov       rcx,1479BFD4DD60
       cmp       [rbp+0A8],rcx
       je        short M02_L13
       call      CORINFO_HELP_FAIL_FAST
M02_L13:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L14:
       test      rbx,rbx
       je        short M02_L15
       mov       rcx,rbx
       call      qword ptr [7FFF200BF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFF200BF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFF208B7618]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       mov       rdx,[rbp+80]
       lea       rcx,[rdx+0A]
       mov       eax,esi
       xor       r8d,r8d
       cmp       eax,64
       jb        short M02_L18
M02_L17:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,eax
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       eax,r9d
       mov       r9,22D1DC00298
       mov       r9,[r9]
       add       eax,eax
       mov       ax,[r9+rax+10]
       mov       [rcx],ax
       cmp       r10d,64
       mov       eax,r10d
       jae       short M02_L17
M02_L18:
       test      eax,eax
       je        short M02_L20
M02_L19:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,eax
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,eax
       sub       r11d,r9d
       mov       eax,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       test      eax,eax
       jne       short M02_L19
M02_L20:
       test      r8d,r8d
       jg        short M02_L19
       add       rdx,0A
       sub       rdx,rcx
       mov       [rbp+70],edx
       mov       [rbp+74],edx
       mov       rax,[rbp+80]
       jmp       short M02_L22
M02_L21:
       lea       r8,[rax+1]
       lea       r10,[rcx+1]
       movzx     ecx,byte ptr [rcx]
       mov       [rax],cl
       mov       rax,r8
       mov       rcx,r10
M02_L22:
       dec       edx
       jns       short M02_L21
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+8],rdx
       mov       dword ptr [rbp+10],20
       lea       rdx,[rbp+8]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFF2084CCF0]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFF20846AD8]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFF2088D488]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFF2084CDF8]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFF2002C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,22D1DC01DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFF20253A48]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,1479BFD4DD60
       cmp       [rbp+0A8],rcx
       je        short M02_L26
       call      CORINFO_HELP_FAIL_FAST
M02_L26:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L27:
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFF200EFE40]
       mov       rcx,1479BFD4DD60
       cmp       [rbp+0A8],rcx
       je        short M02_L28
       call      CORINFO_HELP_FAIL_FAST
M02_L28:
       nop
       lea       rsp,[rbp+0B0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 996
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,26DAFC70008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M04_L03
       cmp       r8d,edi
       jl        near ptr M04_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M04_L01
       test      r8,r8
       je        near ptr M04_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M04_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M04_L00:
       cmp       ebp,r10d
       ja        near ptr M04_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M04_L07
M04_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFF2012E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFF2012E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M05_L02
       test      r8b,18
       jne       near ptr M05_L06
       test      r8b,4
       jne       near ptr M05_L07
       test      r8,r8
       je        near ptr M05_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M05_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M05_L05
M05_L00:
       cmp       r8,800
       ja        near ptr M05_L09
       mov       r9,r8
       shr       r9,6
M05_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M05_L01
       and       r8,3F
       cmp       r8,10
       ja        short M05_L03
       jmp       short M05_L04
M05_L02:
       cmp       r8,40
       ja        short M05_L00
M05_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M05_L04
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M05_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L05:
       ret
M05_L06:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M05_L05
M05_L07:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M05_L05
M05_L08:
       cmp       rcx,rdx
       je        short M05_L05
M05_L09:
       jmp       qword ptr [7FFF20025B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 266
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF7F4585A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFF7F441D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+1A0]
       mov       rcx,234643E0008
       mov       edx,1
       call      qword ptr [7FFF207D41E0]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-60],rax
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       rdi,rcx
       mov       esi,edx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L18
M01_L00:
       mov       rcx,1F3D24055F8
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L19
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L19
M01_L01:
       mov       r15,[rbp-40]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-50],r15
       test      rbx,rbx
       je        near ptr M01_L13
       mov       r13d,[rbx+8]
       test      r13d,r13d
       je        near ptr M01_L13
       mov       rdx,234643F52A4
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r8d,[rax+3]
       cmp       [rcx+8],r8d
       jb        near ptr M01_L08
       movsxd    r8,eax
       lea       rcx,[rcx+r8*2+10]
       mov       r8d,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],r8d
       mov       [rcx+2],r10d
       add       eax,3
       mov       [r15+18],eax
M01_L03:
       xor       r12d,r12d
       test      r13d,r13d
       jle       near ptr M01_L13
       mov       r14d,r13d
       sub       r14d,1
       jo        near ptr M01_L14
M01_L04:
       mov       ecx,r12d
       mov       rax,[rbx+rcx*8+10]
       cmp       r14d,r12d
       jle       short M01_L05
       cmp       dword ptr [rdi+8],0
       jg        short M01_L07
M01_L05:
       test      sil,sil
       je        short M01_L06
       test      rax,rax
       je        near ptr M01_L11
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L11
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r10d,[rax+r8]
       mov       [rbp-44],r10d
       cmp       r10d,[rcx+8]
       ja        near ptr M01_L16
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M01_L09
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L10
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L10
M01_L06:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF201FC2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L12
M01_L07:
       mov       [rbp-58],rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-68],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       xor       ecx,ecx
       call      qword ptr [7FFF207D41B0]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       mov       r10d,[rbp-44]
       mov       [r15+18],r10d
M01_L11:
       mov       rdx,234643E1C14
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        short M01_L15
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],r8d
M01_L12:
       add       r12d,1
       jo        short M01_L14
       cmp       r13d,r12d
       jg        near ptr M01_L04
M01_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       short M01_L17
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L16:
       mov       rcx,r15
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L11
M01_L17:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rax,[rbp-60]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       word ptr [rdi+0C],2C
       jmp       near ptr M01_L00
M01_L19:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20614D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L20
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L01
M01_L20:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       mov       rcx,1F3D24055F8
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L22
       mov       rbx,[rbp-50]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L26
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L23
M01_L22:
       mov       rdx,[rbp-50]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-50]
       je        short M01_L26
M01_L23:
       cmp       qword ptr [r15+20],0
       jne       short M01_L24
       lea       rcx,[r15+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L26
M01_L24:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L25
       mov       rcx,[r15+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF20614D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L26
M01_L25:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L26:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 926
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+1A0]
       mov       rcx,1EE37740008
       mov       edx,1
       call      qword ptr [7FFF207A5B90]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-60],rax
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       rdi,rcx
       mov       esi,edx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L21
M01_L00:
       mov       rcx,1ADA5803600
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L22
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L22
M01_L01:
       mov       r15,[rbp-40]
M01_L02:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-50],r15
       test      rbx,rbx
       je        near ptr M01_L11
       mov       r13d,[rbx+8]
       test      r13d,r13d
       je        near ptr M01_L11
       mov       rdx,1EE377552C4
       mov       r8,[r15+8]
       mov       ecx,[r15+18]
       lea       eax,[rcx+3]
       cmp       [r8+8],eax
       jb        near ptr M01_L14
       movsxd    rax,ecx
       lea       r8,[r8+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [r8],eax
       mov       [r8+2],r10d
       add       ecx,3
       mov       [r15+18],ecx
M01_L03:
       xor       r12d,r12d
       test      r13d,r13d
       jle       near ptr M01_L11
       mov       r14d,r13d
       sub       r14d,1
       jo        near ptr M01_L18
M01_L04:
       mov       r8d,r12d
       mov       rax,[rbx+r8*8+10]
       cmp       r14d,r12d
       jle       short M01_L05
       cmp       dword ptr [rdi+8],0
       jg        near ptr M01_L13
M01_L05:
       test      sil,sil
       je        near ptr M01_L12
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r10d,[rax+r8]
       mov       [rbp-44],r10d
       cmp       r10d,[rcx+8]
       ja        short M01_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L07
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L07:
       mov       r10d,[rbp-44]
       mov       [r15+18],r10d
       jmp       short M01_L09
M01_L08:
       mov       rcx,r15
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       mov       rdx,1EE37741C14
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        near ptr M01_L19
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],r8d
M01_L10:
       add       r12d,1
       jo        near ptr M01_L18
       cmp       r13d,r12d
       jg        near ptr M01_L04
M01_L11:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       near ptr M01_L20
M01_L12:
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r10d,[rax+r8]
       mov       [rbp-44],r10d
       cmp       r10d,[rcx+8]
       ja        near ptr M01_L17
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M01_L15
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L16
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L16
M01_L13:
       mov       [rbp-58],rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-68],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       xor       ecx,ecx
       call      qword ptr [7FFF207A5B60]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L15:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L16:
       mov       r10d,[rbp-44]
       mov       [r15+18],r10d
       jmp       near ptr M01_L10
M01_L17:
       mov       rcx,r15
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L10
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L10
M01_L20:
       mov       rcx,rsp
       call      M01_L24
       nop
       mov       rax,[rbp-60]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       word ptr [rdi+0C],2C
       jmp       near ptr M01_L00
M01_L22:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L23
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L01
M01_L23:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L24:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       mov       rcx,1ADA5803600
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L25
       mov       rbx,[rbp-50]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L29
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L26
M01_L25:
       mov       rdx,[rbp-50]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-50]
       je        short M01_L29
M01_L26:
       cmp       qword ptr [r15+20],0
       jne       short M01_L27
       lea       rcx,[r15+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L29
M01_L27:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L28
       mov       rcx,[r15+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L29
M01_L28:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L29:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1035
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+1A0]
       mov       rcx,24B07F80008
       mov       edx,1
       call      qword ptr [7FFF207B5890]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-60],rax
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       rdi,rcx
       mov       esi,edx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L18
M01_L00:
       mov       rcx,20A760055F8
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L19
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L19
M01_L01:
       mov       r15,[rbp-40]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-50],r15
       test      rbx,rbx
       je        near ptr M01_L13
       mov       r13d,[rbx+8]
       test      r13d,r13d
       je        near ptr M01_L13
       mov       rdx,24B07F952C4
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r8d,[rax+3]
       cmp       [rcx+8],r8d
       jb        near ptr M01_L08
       movsxd    r8,eax
       lea       rcx,[rcx+r8*2+10]
       mov       r8d,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],r8d
       mov       [rcx+2],r10d
       add       eax,3
       mov       [r15+18],eax
M01_L03:
       xor       r12d,r12d
       test      r13d,r13d
       jle       near ptr M01_L13
       mov       r14d,r13d
       sub       r14d,1
       jo        near ptr M01_L14
M01_L04:
       mov       ecx,r12d
       mov       rax,[rbx+rcx*8+10]
       cmp       r14d,r12d
       jle       short M01_L05
       cmp       dword ptr [rdi+8],0
       jg        short M01_L07
M01_L05:
       test      sil,sil
       je        short M01_L06
       test      rax,rax
       je        near ptr M01_L11
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L11
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r10d,[rax+r8]
       mov       [rbp-44],r10d
       cmp       r10d,[rcx+8]
       ja        near ptr M01_L16
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M01_L09
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L10
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L10
M01_L06:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF201EC2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L12
M01_L07:
       mov       [rbp-58],rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-68],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       xor       ecx,ecx
       call      qword ptr [7FFF207B5860]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       mov       r10d,[rbp-44]
       mov       [r15+18],r10d
M01_L11:
       mov       rdx,24B07F81C14
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        short M01_L15
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],r8d
M01_L12:
       add       r12d,1
       jo        short M01_L14
       cmp       r13d,r12d
       jg        near ptr M01_L04
M01_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       short M01_L17
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L16:
       mov       rcx,r15
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L11
M01_L17:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rax,[rbp-60]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       word ptr [rdi+0C],2C
       jmp       near ptr M01_L00
M01_L19:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L20
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L01
M01_L20:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       mov       rcx,20A760055F8
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L22
       mov       rbx,[rbp-50]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L26
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L23
M01_L22:
       mov       rdx,[rbp-50]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-50]
       je        short M01_L26
M01_L23:
       cmp       qword ptr [r15+20],0
       jne       short M01_L24
       lea       rcx,[r15+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L26
M01_L24:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L25
       mov       rcx,[r15+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L26
M01_L25:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L26:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 926
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+1A0]
       mov       rcx,18C43C60008
       mov       edx,1
       call      qword ptr [7FFF207DC1E0]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-60],rax
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       rdi,rcx
       mov       esi,edx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L18
M01_L00:
       mov       rcx,14BB1C03600
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L19
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L19
M01_L01:
       mov       r15,[rbp-40]
M01_L02:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-50],r15
       test      rbx,rbx
       je        near ptr M01_L13
       mov       r13d,[rbx+8]
       test      r13d,r13d
       je        near ptr M01_L13
       mov       rdx,18C43C75314
       mov       r8,[r15+8]
       mov       ecx,[r15+18]
       lea       eax,[rcx+3]
       cmp       [r8+8],eax
       jb        near ptr M01_L08
       movsxd    rax,ecx
       lea       r8,[r8+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [r8],eax
       mov       [r8+2],r10d
       add       ecx,3
       mov       [r15+18],ecx
M01_L03:
       xor       r12d,r12d
       test      r13d,r13d
       jle       near ptr M01_L13
       mov       r14d,r13d
       sub       r14d,1
       jo        near ptr M01_L14
M01_L04:
       mov       r8d,r12d
       mov       rax,[rbx+r8*8+10]
       mov       rdx,rax
       cmp       r14d,r12d
       jle       short M01_L05
       cmp       dword ptr [rdi+8],0
       jg        near ptr M01_L07
M01_L05:
       test      sil,sil
       je        short M01_L06
       test      rdx,rdx
       je        near ptr M01_L11
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        near ptr M01_L11
       mov       rcx,[r15+8]
       mov       edx,[r15+18]
       lea       r10d,[rdx+r8]
       mov       [rbp-44],r10d
       cmp       r10d,[rcx+8]
       ja        near ptr M01_L16
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jg        near ptr M01_L09
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       near ptr M01_L10
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L10
M01_L06:
       test      rdx,rdx
       je        near ptr M01_L12
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r15
       call      qword ptr [7FFF201ECA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M01_L12
M01_L07:
       mov       [rbp-58],rdx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-68],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       xor       ecx,ecx
       call      qword ptr [7FFF207DC1B0]
       mov       rcx,rax
       mov       rdx,rcx
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L09:
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       mov       r10d,[rbp-44]
       mov       [r15+18],r10d
M01_L11:
       mov       rdx,18C43C61C14
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        short M01_L15
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],r8d
M01_L12:
       add       r12d,1
       jo        short M01_L14
       cmp       r13d,r12d
       jg        near ptr M01_L04
M01_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       short M01_L17
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L11
M01_L17:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rax,[rbp-60]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       word ptr [rdi+0C],2C
       jmp       near ptr M01_L00
M01_L19:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L20
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L01
M01_L20:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       mov       rcx,14BB1C03600
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L22
       mov       rbx,[rbp-50]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L26
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L23
M01_L22:
       mov       rdx,[rbp-50]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-50]
       je        short M01_L26
M01_L23:
       cmp       qword ptr [r15+20],0
       jne       short M01_L24
       lea       rcx,[r15+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L26
M01_L24:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L25
       mov       rcx,[r15+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L26
M01_L25:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L26:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 953
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+1A0]
       mov       rcx,2926D450008
       mov       edx,1
       call      qword ptr [7FFF20815470]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-60],rax
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       rdi,rcx
       mov       esi,edx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L21
M01_L00:
       mov       rcx,251DB403600
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L22
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L22
M01_L01:
       mov       r15,[rbp-40]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-50],r15
       test      rbx,rbx
       je        near ptr M01_L11
       mov       r13d,[rbx+8]
       test      r13d,r13d
       je        near ptr M01_L11
       mov       rdx,2926D465314
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L14
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [r15+18],r8d
M01_L03:
       xor       r12d,r12d
       test      r13d,r13d
       jle       near ptr M01_L11
       mov       r14d,r13d
       sub       r14d,1
       jo        near ptr M01_L19
M01_L04:
       mov       r8d,r12d
       mov       rax,[rbx+r8*8+10]
       cmp       r14d,r12d
       jle       short M01_L05
       cmp       dword ptr [rdi+8],0
       jg        near ptr M01_L13
M01_L05:
       test      sil,sil
       je        near ptr M01_L12
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r10d,[rax+r8]
       mov       [rbp-44],r10d
       cmp       r10d,[rcx+8]
       ja        short M01_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L07
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L07:
       mov       r10d,[rbp-44]
       mov       [r15+18],r10d
       jmp       short M01_L09
M01_L08:
       mov       rcx,r15
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       mov       rdx,2926D451C14
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        near ptr M01_L17
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],eax
M01_L10:
       add       r12d,1
       jo        near ptr M01_L19
       cmp       r13d,r12d
       jg        near ptr M01_L04
M01_L11:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       near ptr M01_L20
M01_L12:
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r10d,[rax+r8]
       mov       [rbp-44],r10d
       cmp       r10d,[rcx+8]
       ja        near ptr M01_L18
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M01_L15
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L16
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L16
M01_L13:
       mov       [rbp-58],rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-68],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       xor       ecx,ecx
       call      qword ptr [7FFF20815440]
       mov       rdx,rax
       mov       rax,rdx
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L15:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L16:
       mov       r10d,[rbp-44]
       mov       [r15+18],r10d
       jmp       near ptr M01_L10
M01_L17:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L10
M01_L18:
       mov       rcx,r15
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L10
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       mov       rcx,rsp
       call      M01_L24
       nop
       mov       rax,[rbp-60]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       word ptr [rdi+0C],2C
       jmp       near ptr M01_L00
M01_L22:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20614D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L23
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L01
M01_L23:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L24:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       mov       rcx,251DB403600
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L25
       mov       rbx,[rbp-50]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L29
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L26
M01_L25:
       mov       rdx,[rbp-50]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-50]
       je        short M01_L29
M01_L26:
       cmp       qword ptr [r15+20],0
       jne       short M01_L27
       lea       rcx,[r15+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L29
M01_L27:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L28
       mov       rcx,[r15+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF20614D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L29
M01_L28:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L29:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1035
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+1A0]
       mov       rcx,205A9710008
       mov       edx,1
       call      qword ptr [7FFF208E7618]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-60],rax
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       test      rsi,rsi
       je        near ptr M01_L25
M01_L00:
       mov       rcx,1C5178055F8
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L22
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L22
M01_L01:
       mov       r14,[rbp-40]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-50],r14
       test      rbx,rbx
       je        near ptr M01_L12
       mov       r12d,[rbx+8]
       test      r12d,r12d
       je        near ptr M01_L12
       mov       rdx,205A972533C
       mov       rcx,[r14+8]
       mov       r8d,[r14+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L17
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [r14+18],r8d
M01_L03:
       xor       r13d,r13d
       test      r12d,r12d
       jle       near ptr M01_L12
       mov       r15d,r12d
       sub       r15d,1
       jo        near ptr M01_L13
M01_L04:
       mov       ecx,r13d
       mov       rax,[rbx+rcx*8+10]
       cmp       r15d,r13d
       jle       short M01_L05
       cmp       dword ptr [rsi+8],0
       jg        near ptr M01_L16
M01_L05:
       test      dil,dil
       je        near ptr M01_L19
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r10d,[rax+r8]
       cmp       r10d,[rcx+8]
       ja        short M01_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L08
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L07
M01_L06:
       mov       [r14+18],r10d
       jmp       short M01_L10
M01_L07:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L06
M01_L08:
       mov       [rbp-44],r10d
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rbp-44]
       jmp       short M01_L06
M01_L09:
       mov       rcx,r14
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       mov       rdx,205A9711C14
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        short M01_L15
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r14+18],r8d
M01_L11:
       add       r13d,1
       jo        short M01_L13
       cmp       r12d,r13d
       jg        near ptr M01_L04
M01_L12:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       near ptr M01_L24
M01_L13:
       call      CORINFO_HELP_OVERFLOW
M01_L14:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L20
M01_L15:
       mov       rcx,r14
       mov       r8d,2
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L11
M01_L16:
       mov       [rbp-58],rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-68],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
       lea       rcx,[rax+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       xor       ecx,ecx
       call      qword ptr [7FFF208E75E8]
       mov       r8,rax
       mov       rax,r8
       jmp       near ptr M01_L05
M01_L17:
       mov       rcx,r14
       mov       r8d,3
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L18:
       mov       [rbp-44],r10d
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rbp-44]
       jmp       short M01_L20
M01_L19:
       test      rax,rax
       je        near ptr M01_L11
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L11
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r10d,[rax+r8]
       cmp       r10d,[rcx+8]
       ja        short M01_L21
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L18
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        near ptr M01_L14
M01_L20:
       mov       [r14+18],r10d
       jmp       near ptr M01_L11
M01_L21:
       mov       rcx,r14
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L11
M01_L22:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-40]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFF20625290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L26
M01_L23:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L01
M01_L24:
       mov       rcx,rsp
       call      M01_L29
       nop
       mov       rax,[rbp-60]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       mov       word ptr [rsi+0C],2C
       jmp       near ptr M01_L00
M01_L26:
       cmp       qword ptr [r13+10],0
       jne       short M01_L27
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L28
M01_L27:
       lea       rdx,[rbp-40]
       mov       rcx,r15
       call      qword ptr [7FFF20624DB0]
       test      eax,eax
       jne       short M01_L23
M01_L28:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L29:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       mov       rcx,1C5178055F8
       mov       r14,[rcx]
       mov       rax,[r14+10]
       mov       rcx,7FFF20621350
       cmp       [rax+18],rcx
       jne       short M01_L30
       mov       rbx,[rbp-50]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L34
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF2020C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L31
M01_L30:
       mov       rdx,[rbp-50]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-50]
       je        short M01_L34
M01_L31:
       cmp       qword ptr [r14+20],0
       jne       short M01_L32
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L34
M01_L32:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L33
       mov       r14,[r14+18]
       mov       rcx,[r14+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF206252C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L34
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFF20624D80]
       jmp       short M01_L34
M01_L33:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L34:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1093
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+1A0]
       mov       rcx,225038A0008
       mov       edx,1
       call      qword ptr [7FFF208B7528]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-60],rax
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       rdi,rcx
       mov       esi,edx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L25
M01_L00:
       mov       rcx,1E4718055F8
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L22
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L22
M01_L01:
       mov       r14,[rbp-40]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-50],r14
       test      rbx,rbx
       je        near ptr M01_L12
       mov       r12d,[rbx+8]
       test      r12d,r12d
       je        near ptr M01_L12
       mov       rdx,225038B533C
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r8d,[rax+3]
       cmp       [rcx+8],r8d
       jb        near ptr M01_L19
       movsxd    r8,eax
       lea       rcx,[rcx+r8*2+10]
       mov       r8d,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],r8d
       mov       [rcx+2],r10d
       add       eax,3
       mov       [r14+18],eax
M01_L03:
       xor       r13d,r13d
       test      r12d,r12d
       jle       near ptr M01_L12
       mov       r15d,r12d
       sub       r15d,1
       jo        near ptr M01_L21
M01_L04:
       mov       ecx,r13d
       mov       rax,[rbx+rcx*8+10]
       cmp       r15d,r13d
       jle       short M01_L05
       cmp       dword ptr [rdi+8],0
       jg        near ptr M01_L18
M01_L05:
       test      sil,sil
       je        near ptr M01_L13
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r10d,[rax+r8]
       cmp       r10d,[rcx+8]
       ja        short M01_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L08
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L07
M01_L06:
       mov       [r14+18],r10d
       jmp       short M01_L10
M01_L07:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L06
M01_L08:
       mov       [rbp-44],r10d
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rbp-44]
       jmp       short M01_L06
M01_L09:
       mov       rcx,r14
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       mov       rdx,225038A1C14
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        near ptr M01_L17
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r14+18],r8d
M01_L11:
       add       r13d,1
       jo        near ptr M01_L21
       cmp       r12d,r13d
       jg        near ptr M01_L04
M01_L12:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       near ptr M01_L24
M01_L13:
       test      rax,rax
       je        short M01_L11
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L11
       mov       rax,[r14+8]
       mov       ecx,[r14+18]
       lea       r10d,[rcx+r8]
       cmp       r10d,[rax+8]
       ja        short M01_L15
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2+10]
       cmp       r8d,2
       jg        near ptr M01_L20
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L16
M01_L14:
       mov       [r14+18],r10d
       jmp       short M01_L11
M01_L15:
       mov       rcx,r14
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L11
M01_L16:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L14
M01_L17:
       mov       rcx,r14
       mov       r8d,2
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L11
M01_L18:
       mov       [rbp-58],rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-68],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       xor       ecx,ecx
       call      qword ptr [7FFF208B74F8]
       mov       r8,rax
       mov       rax,r8
       jmp       near ptr M01_L05
M01_L19:
       mov       rcx,r14
       mov       r8d,3
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L20:
       mov       [rbp-44],r10d
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rbp-44]
       jmp       near ptr M01_L14
M01_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L22:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-40]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L26
M01_L23:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L01
M01_L24:
       mov       rcx,rsp
       call      M01_L29
       nop
       mov       rax,[rbp-60]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       word ptr [rdi+0C],2C
       jmp       near ptr M01_L00
M01_L26:
       cmp       qword ptr [r13+10],0
       jne       short M01_L27
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L28
M01_L27:
       lea       rdx,[rbp-40]
       mov       rcx,r15
       call      qword ptr [7FFF205F4DB0]
       test      eax,eax
       jne       short M01_L23
M01_L28:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L29:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       mov       rcx,1E4718055F8
       mov       r14,[rcx]
       mov       rax,[r14+10]
       mov       rcx,7FFF205F1350
       cmp       [rax+18],rcx
       jne       short M01_L30
       mov       rbx,[rbp-50]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L34
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L31
M01_L30:
       mov       rdx,[rbp-50]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-50]
       je        short M01_L34
M01_L31:
       cmp       qword ptr [r14+20],0
       jne       short M01_L32
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L34
M01_L32:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L33
       mov       r14,[r14+18]
       mov       rcx,[r14+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F52C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L34
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFF205F4D80]
       jmp       short M01_L34
M01_L33:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L34:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1094
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+1A0]
       mov       rcx,238DA880008
       mov       edx,1
       call      qword ptr [7FFF208C7E58]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-60],rax
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       test      rsi,rsi
       je        near ptr M01_L25
M01_L00:
       mov       rcx,1F848803600
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L22
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L22
M01_L01:
       mov       r14,[rbp-40]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-50],r14
       test      rbx,rbx
       je        near ptr M01_L12
       mov       r12d,[rbx+8]
       test      r12d,r12d
       je        near ptr M01_L12
       mov       rdx,238DA89533C
       mov       rcx,[r14+8]
       mov       r8d,[r14+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L20
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [r14+18],r8d
M01_L03:
       xor       r13d,r13d
       test      r12d,r12d
       jle       near ptr M01_L12
       mov       r15d,r12d
       sub       r15d,1
       jo        near ptr M01_L16
M01_L04:
       mov       ecx,r13d
       mov       rax,[rbx+rcx*8+10]
       cmp       r15d,r13d
       jle       short M01_L05
       cmp       dword ptr [rsi+8],0
       jg        near ptr M01_L19
M01_L05:
       test      dil,dil
       je        near ptr M01_L13
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r10d,[rax+r8]
       cmp       r10d,[rcx+8]
       ja        short M01_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L08
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L07
M01_L06:
       mov       [r14+18],r10d
       jmp       short M01_L10
M01_L07:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L06
M01_L08:
       mov       [rbp-44],r10d
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rbp-44]
       jmp       short M01_L06
M01_L09:
       mov       rcx,r14
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       mov       rdx,238DA881C14
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        near ptr M01_L18
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r14+18],r8d
M01_L11:
       add       r13d,1
       jo        short M01_L16
       cmp       r12d,r13d
       jg        near ptr M01_L04
M01_L12:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       near ptr M01_L24
M01_L13:
       test      rax,rax
       je        short M01_L11
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L11
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r10d,[rax+r8]
       cmp       r10d,[rcx+8]
       ja        short M01_L15
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M01_L21
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L17
M01_L14:
       mov       [r14+18],r10d
       jmp       short M01_L11
M01_L15:
       mov       rcx,r14
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L11
M01_L16:
       call      CORINFO_HELP_OVERFLOW
M01_L17:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L14
M01_L18:
       mov       rcx,r14
       mov       r8d,2
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L11
M01_L19:
       mov       [rbp-58],rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-68],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
       lea       rcx,[rax+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       xor       ecx,ecx
       call      qword ptr [7FFF208C7E28]
       mov       r8,rax
       mov       rax,r8
       jmp       near ptr M01_L05
M01_L20:
       mov       rcx,r14
       mov       r8d,3
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L21:
       mov       [rbp-44],r10d
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rbp-44]
       jmp       near ptr M01_L14
M01_L22:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-40]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFF20605290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L26
M01_L23:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L01
M01_L24:
       mov       rcx,rsp
       call      M01_L29
       nop
       mov       rax,[rbp-60]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       mov       word ptr [rsi+0C],2C
       jmp       near ptr M01_L00
M01_L26:
       cmp       qword ptr [r13+10],0
       jne       short M01_L27
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L28
M01_L27:
       lea       rdx,[rbp-40]
       mov       rcx,r15
       call      qword ptr [7FFF20604DB0]
       test      eax,eax
       jne       short M01_L23
M01_L28:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L29:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       mov       rcx,1F848803600
       mov       r14,[rcx]
       mov       rax,[r14+10]
       mov       rcx,7FFF20601350
       cmp       [rax+18],rcx
       jne       short M01_L30
       mov       rbx,[rbp-50]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L34
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L31
M01_L30:
       mov       rdx,[rbp-50]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-50]
       je        short M01_L34
M01_L31:
       cmp       qword ptr [r14+20],0
       jne       short M01_L32
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L34
M01_L32:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L33
       mov       r14,[r14+18]
       mov       rcx,[r14+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF206052C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L34
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFF20604D80]
       jmp       short M01_L34
M01_L33:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L34:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1086
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+1A0]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L06
M00_L00:
       mov       r8d,ebp
       mov       rax,[rdi+r8*8+10]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L05
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M00_L04
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L03
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L02:
       mov       [rsi+18],r15d
       jmp       short M00_L05
M00_L03:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       mov       rax,2FDE7CE0008
       jmp       near ptr M00_L01
; Total bytes of code 286
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L03
       cmp       r8,40
       ja        short M01_L06
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L05
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       test      r8b,18
       je        short M01_L04
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L02
M01_L04:
       test      r8b,4
       je        short M01_L08
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L05:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L06:
       cmp       r8,800
       ja        short M01_L10
       mov       r9,r8
       shr       r9,6
M01_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L07
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L00
       jmp       near ptr M01_L01
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF20035B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201ECB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF2013E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF2013E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2FDE7CE0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+1A0]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L06
M00_L00:
       mov       r8d,ebp
       mov       rax,[rdi+r8*8+10]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L05
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M00_L04
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L03
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L02:
       mov       [rsi+18],r15d
       jmp       short M00_L05
M00_L03:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       mov       rax,2CA73580008
       jmp       near ptr M00_L01
; Total bytes of code 286
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L03
       cmp       r8,40
       ja        short M01_L04
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L07
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       test      r8b,18
       je        short M01_L06
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L02
M01_L04:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       r9,r8
       shr       r9,6
M01_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L05
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L06:
       test      r8b,4
       je        short M01_L08
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF20045B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF2014E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF2014E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2CA73580008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+1A0]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L06
M00_L00:
       mov       r8d,ebp
       mov       rax,[rdi+r8*8+10]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L05
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M00_L04
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L03
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L02:
       mov       [rsi+18],r15d
       jmp       short M00_L05
M00_L03:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L08
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       r15,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       mov       rax,26085850008
       jmp       near ptr M00_L01
M00_L08:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L02
; Total bytes of code 286
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L07
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       r9,r8
       shr       r9,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L04
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L05:
       test      r8b,18
       je        short M01_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L02
M01_L06:
       test      r8b,4
       je        short M01_L08
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF20055B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2020CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF2015E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF2015E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,26085850008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+1A0]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L06
M00_L00:
       mov       r8d,ebp
       mov       rax,[rdi+r8*8+10]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L05
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M00_L04
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L03
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L02:
       mov       [rsi+18],r15d
       jmp       short M00_L05
M00_L03:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L08
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       r15,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       mov       rax,1EE82600008
       jmp       near ptr M00_L01
M00_L08:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L02
; Total bytes of code 286
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L07
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       r9,r8
       shr       r9,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L04
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L05:
       test      r8b,18
       je        short M01_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L02
M01_L06:
       test      r8b,4
       je        short M01_L08
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF20025B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF2012E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF2012E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1EE82600008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+1A0]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L04
M00_L00:
       mov       ecx,ebp
       mov       rax,[rdi+rcx*8+10]
       test      rax,rax
       je        near ptr M00_L05
M00_L01:
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L03
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M00_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L06
M00_L02:
       mov       [rsi+18],r15d
M00_L03:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       r15,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r15+8],r8
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       rax,23FBAC20008
       jmp       near ptr M00_L01
M00_L06:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L02
M00_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L03
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,23FBAC20008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L11
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       jbe       short M02_L05
       cmp       r8,40
       ja        short M02_L03
M02_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M02_L07
M02_L01:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M02_L02:
       pop       rbx
       pop       rsi
       ret
M02_L03:
       cmp       r8,800
       ja        near ptr M02_L10
       mov       rax,r8
       shr       rax,6
M02_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M02_L04
       and       r8,3F
       cmp       r8,10
       ja        short M02_L00
       jmp       short M02_L01
M02_L05:
       test      r8b,18
       je        short M02_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
       jmp       short M02_L02
M02_L06:
       test      r8b,4
       jne       short M02_L08
       test      r8,r8
       je        short M02_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L02
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       short M02_L02
M02_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M02_L01
       jmp       short M02_L09
M02_L08:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rbx-4]
       mov       [rsi-4],ecx
       jmp       near ptr M02_L02
M02_L09:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M02_L01
M02_L10:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF20045B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       cmp       rcx,rdx
       je        near ptr M02_L02
       jmp       short M02_L10
; Total bytes of code 276
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2014E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2014E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+1A0]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L04
M00_L00:
       mov       ecx,ebp
       mov       rax,[rdi+rcx*8+10]
       test      rax,rax
       je        near ptr M00_L05
M00_L01:
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L03
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M00_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L06
M00_L02:
       mov       [rsi+18],r15d
M00_L03:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       r15,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r15+8],r8
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       rax,1C4C2550008
       jmp       near ptr M00_L01
M00_L06:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L02
M00_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L03
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,1C4C2550008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L02
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L02
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M02_L04
       test      r8b,18
       jne       near ptr M02_L08
       test      r8b,4
       jne       near ptr M02_L09
       test      r8,r8
       je        near ptr M02_L07
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L07
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M02_L07
M02_L00:
       cmp       r8,800
       ja        short M02_L03
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L05
       jmp       short M02_L06
M02_L02:
       cmp       rcx,rdx
       je        short M02_L07
M02_L03:
       jmp       qword ptr [7FFF20055B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L04:
       cmp       r8,40
       ja        short M02_L00
M02_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L07:
       ret
M02_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L07
M02_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L07
; Total bytes of code 269
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2020CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2015E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2015E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+1A0]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L04
M00_L00:
       mov       ecx,ebp
       mov       rax,[rdi+rcx*8+10]
       test      rax,rax
       je        near ptr M00_L05
M00_L01:
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L03
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M00_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L06
M00_L02:
       mov       [rsi+18],r15d
M00_L03:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       r15,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r15+8],r8
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       rax,1A9EAD20008
       jmp       near ptr M00_L01
M00_L06:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L02
M00_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L03
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,1A9EAD20008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L02
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L02
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M02_L04
       test      r8b,18
       jne       near ptr M02_L08
       test      r8b,4
       jne       near ptr M02_L09
       test      r8,r8
       je        near ptr M02_L07
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L07
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M02_L07
M02_L00:
       cmp       r8,800
       ja        short M02_L03
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L05
       jmp       short M02_L06
M02_L02:
       cmp       rcx,rdx
       je        short M02_L07
M02_L03:
       jmp       qword ptr [7FFF20025B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L04:
       cmp       r8,40
       ja        short M02_L00
M02_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L07:
       ret
M02_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L07
M02_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L07
; Total bytes of code 269
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2012E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2012E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+1A0]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L04
M00_L00:
       mov       ecx,ebp
       mov       rax,[rdi+rcx*8+10]
       test      rax,rax
       je        near ptr M00_L05
M00_L01:
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L03
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M00_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L06
M00_L02:
       mov       [rsi+18],r15d
M00_L03:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       r15,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r15+8],r8
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       rax,15C832E0008
       jmp       near ptr M00_L01
M00_L06:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L02
M00_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L03
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF204956F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,15C832E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       jne       near ptr M02_L06
       test      r8b,4
       jne       near ptr M02_L07
       test      r8,r8
       je        near ptr M02_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L05
M02_L00:
       cmp       r8,800
       ja        near ptr M02_L09
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L03
       jmp       short M02_L04
M02_L02:
       cmp       r8,40
       ja        short M02_L00
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L04
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L05:
       ret
M02_L06:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L05
M02_L07:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L05
M02_L08:
       cmp       rcx,rdx
       je        short M02_L05
M02_L09:
       jmp       qword ptr [7FFF20055B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 266
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2020CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF204957D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2015E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2015E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r8,[rbx+1A0]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L07
M00_L00:
       mov       r8,[rbx+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M00_L10
       mov       ecx,edi
       mov       rax,[r8+rcx*8+10]
       test      rax,rax
       je        near ptr M00_L09
M00_L01:
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       ebp,[rax+8]
       test      ebp,ebp
       je        short M00_L05
       mov       r8,[rsi+8]
       mov       r14d,[rsi+18]
       lea       ecx,[r14+rbp]
       cmp       ecx,[r8+8]
       ja        short M00_L04
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       ebp,2
       jg        short M00_L03
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebp,2
       jne       short M00_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L02:
       add       ebp,r14d
       mov       [rsi+18],ebp
       jmp       short M00_L05
M00_L03:
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,27508BA1C14
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L08
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       add       r8d,2
       mov       [rsi+18],r8d
M00_L06:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,27508BA0008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 393
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L10
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L03
       cmp       r8,40
       ja        short M01_L04
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L07
M01_L01:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M01_L02:
       pop       rbx
       pop       rsi
       ret
M01_L03:
       test      r8b,18
       je        short M01_L06
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M01_L02
M01_L04:
       cmp       r8,800
       ja        near ptr M01_L09
       mov       rax,r8
       shr       rax,6
M01_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M01_L05
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L06:
       test      r8b,4
       je        short M01_L08
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rbx-4]
       mov       [rsi-4],ecx
       jmp       short M01_L02
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF20045B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       cmp       rcx,rdx
       je        near ptr M01_L02
       jmp       short M01_L09
; Total bytes of code 278
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF2014E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF2014E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,27508BA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r8,[rbx+1A0]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L07
M00_L00:
       mov       r8,[rbx+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M00_L10
       mov       ecx,edi
       mov       rax,[r8+rcx*8+10]
       test      rax,rax
       je        near ptr M00_L09
M00_L01:
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L05
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M00_L04
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L02
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L03
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L03
M00_L02:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L03:
       mov       [rsi+18],ebp
       jmp       short M00_L05
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,206DDDD1C14
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L08
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       add       r8d,2
       mov       [rsi+18],r8d
M00_L06:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,206DDDD0008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 382
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L03
       cmp       r8,40
       ja        short M01_L04
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L07
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       test      r8b,18
       je        short M01_L06
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L02
M01_L04:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       r9,r8
       shr       r9,6
M01_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L05
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L06:
       test      r8b,4
       je        short M01_L08
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF20045B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF2014E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF2014E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,206DDDD0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r8,[rbx+1A0]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M00_L10
       mov       ecx,edi
       mov       rax,[r8+rcx*8+10]
       test      rax,rax
       je        near ptr M00_L09
M00_L01:
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L03
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L07
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M00_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L02:
       mov       [rsi+18],ebp
M00_L03:
       mov       rdx,24F03D61C14
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L08
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [rsi+18],eax
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFF2020B060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFF2021CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF2021CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L04
M00_L09:
       mov       rax,24F03D60008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 391
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF204A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2006D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,24F03D60008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M02_L05
       cmp       r8,40
       ja        short M02_L03
M02_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L07
M02_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L02:
       ret
M02_L03:
       cmp       r8,800
       ja        near ptr M02_L10
       mov       r9,r8
       shr       r9,6
M02_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L04
       and       r8,3F
       cmp       r8,10
       ja        short M02_L00
       jmp       short M02_L01
M02_L05:
       test      r8b,18
       je        short M02_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M02_L02
M02_L06:
       test      r8b,4
       je        short M02_L08
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M02_L02
M02_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M02_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M02_L01
M02_L08:
       test      r8,r8
       je        near ptr M02_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M02_L02
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L02
M02_L10:
       jmp       qword ptr [7FFF20065B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2021CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF204A5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2006D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2016E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2016E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r8,[rbx+1A0]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L07
M00_L00:
       mov       r8,[rbx+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M00_L10
       mov       ecx,edi
       mov       rax,[r8+rcx*8+10]
       test      rax,rax
       je        near ptr M00_L09
M00_L01:
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       ebp,[rax+8]
       test      ebp,ebp
       je        short M00_L05
       mov       r8,[rsi+8]
       mov       r14d,[rsi+18]
       lea       ecx,[r14+rbp]
       cmp       ecx,[r8+8]
       ja        short M00_L04
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       ebp,2
       jg        short M00_L03
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebp,2
       jne       short M00_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L02:
       add       ebp,r14d
       mov       [rsi+18],ebp
       jmp       short M00_L05
M00_L03:
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,22485931C14
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L08
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [rsi+18],eax
M00_L06:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,22485930008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 388
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L07
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       r9,r8
       shr       r9,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L04
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L05:
       test      r8b,18
       je        short M01_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L02
M01_L06:
       test      r8b,4
       je        short M01_L08
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF20055B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2020CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF2015E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF2015E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,22485930008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,[rbx+1A0]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       rcx,[rbx+1A0]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L10
       mov       eax,edi
       mov       rax,[rcx+rax*8+10]
       test      rax,rax
       je        near ptr M00_L06
M00_L01:
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L03
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M00_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L02
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
M00_L02:
       mov       [rsi+18],ebp
M00_L03:
       mov       rdx,2991DCC1C14
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        near ptr M00_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [rsi+18],r8d
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [rbp+8],r8
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       mov       rax,2991DCC0008
       jmp       near ptr M00_L01
M00_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 395
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,2991DCC0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L10
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       jbe       short M02_L05
       cmp       r8,40
       ja        short M02_L03
M02_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L08
M02_L01:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M02_L02:
       pop       rbx
       pop       rsi
       ret
M02_L03:
       cmp       r8,800
       ja        near ptr M02_L11
       mov       rax,r8
       shr       rax,6
M02_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M02_L04
       and       r8,3F
       cmp       r8,10
       ja        short M02_L00
       jmp       short M02_L01
M02_L05:
       test      r8b,18
       je        short M02_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
       jmp       short M02_L02
M02_L06:
       test      r8b,4
       je        short M02_L07
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rbx-4]
       mov       [rsi-4],ecx
       jmp       short M02_L02
M02_L07:
       test      r8,r8
       je        short M02_L02
       jmp       short M02_L09
M02_L08:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M02_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M02_L01
M02_L09:
       movzx     eax,byte ptr [rdx]
       mov       [rcx],al
       test      r8b,2
       je        near ptr M02_L02
       movsx     rax,word ptr [rbx-2]
       mov       [rsi-2],ax
       jmp       near ptr M02_L02
M02_L10:
       cmp       rcx,rdx
       je        near ptr M02_L02
M02_L11:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF20025B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 273
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2012E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2012E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,[rbx+1A0]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       rcx,[rbx+1A0]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       eax,edi
       mov       rax,[rcx+rax*8+10]
       test      rax,rax
       je        near ptr M00_L06
M00_L01:
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+0C]
       mov       ebp,[rax+8]
       test      ebp,ebp
       je        short M00_L03
       mov       rcx,[rsi+8]
       mov       r14d,[rsi+18]
       lea       eax,[r14+rbp]
       cmp       eax,[rcx+8]
       ja        near ptr M00_L09
       movsxd    rax,r14d
       lea       rcx,[rcx+rax*2+10]
       cmp       ebp,2
       jg        near ptr M00_L08
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       ebp,2
       je        near ptr M00_L07
M00_L02:
       add       ebp,r14d
       mov       [rsi+18],ebp
M00_L03:
       mov       rdx,25E62BA1C14
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        near ptr M00_L10
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [rsi+18],r8d
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       r14,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+8],r8
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rax,25E62BA0008
       jmp       near ptr M00_L01
M00_L07:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L02
M00_L08:
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 414
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,25E62BA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L02
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L02
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M02_L04
       test      r8b,18
       jne       near ptr M02_L08
       test      r8b,4
       jne       near ptr M02_L09
       test      r8,r8
       je        near ptr M02_L07
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L07
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M02_L07
M02_L00:
       cmp       r8,800
       ja        short M02_L03
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L05
       jmp       short M02_L06
M02_L02:
       cmp       rcx,rdx
       je        short M02_L07
M02_L03:
       jmp       qword ptr [7FFF20035B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L04:
       cmp       r8,40
       ja        short M02_L00
M02_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L07:
       ret
M02_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L07
M02_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L07
; Total bytes of code 269
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201ECB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2013E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2013E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,[rbx+1A0]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       rcx,[rbx+1A0]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       eax,edi
       mov       rax,[rcx+rax*8+10]
       test      rax,rax
       je        near ptr M00_L06
M00_L01:
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+0C]
       mov       ebp,[rax+8]
       test      ebp,ebp
       je        short M00_L03
       mov       rcx,[rsi+8]
       mov       r14d,[rsi+18]
       lea       eax,[r14+rbp]
       cmp       eax,[rcx+8]
       ja        near ptr M00_L09
       movsxd    rax,r14d
       lea       rcx,[rcx+rax*2+10]
       cmp       ebp,2
       jg        near ptr M00_L08
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       ebp,2
       je        near ptr M00_L07
M00_L02:
       add       ebp,r14d
       mov       [rsi+18],ebp
M00_L03:
       mov       rdx,2AD42531C14
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        near ptr M00_L10
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [rsi+18],r8d
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       r14,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+8],r8
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rax,2AD42530008
       jmp       near ptr M00_L01
M00_L07:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L02
M00_L08:
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 414
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,2AD42530008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L02
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L02
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M02_L04
       test      r8b,18
       jne       near ptr M02_L08
       test      r8b,4
       jne       near ptr M02_L09
       test      r8,r8
       je        near ptr M02_L07
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L07
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M02_L07
M02_L00:
       cmp       r8,800
       ja        short M02_L03
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L05
       jmp       short M02_L06
M02_L02:
       cmp       rcx,rdx
       je        short M02_L07
M02_L03:
       jmp       qword ptr [7FFF20025B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L04:
       cmp       r8,40
       ja        short M02_L00
M02_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L07:
       ret
M02_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L07
M02_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L07
; Total bytes of code 269
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2012E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2012E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,[rbx+1A0]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       rcx,[rbx+1A0]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       eax,edi
       mov       rax,[rcx+rax*8+10]
       test      rax,rax
       je        near ptr M00_L06
M00_L01:
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+0C]
       mov       ebp,[rax+8]
       test      ebp,ebp
       je        short M00_L03
       mov       rcx,[rsi+8]
       mov       r14d,[rsi+18]
       lea       eax,[r14+rbp]
       cmp       eax,[rcx+8]
       ja        near ptr M00_L09
       movsxd    rax,r14d
       lea       rcx,[rcx+rax*2+10]
       cmp       ebp,2
       jg        near ptr M00_L08
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       ebp,2
       je        near ptr M00_L07
M00_L02:
       add       ebp,r14d
       mov       [rsi+18],ebp
M00_L03:
       mov       rdx,21195D61C14
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        near ptr M00_L10
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [rsi+18],r8d
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       r14,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+8],r8
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rax,21195D60008
       jmp       near ptr M00_L01
M00_L07:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L02
M00_L08:
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 414
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,21195D60008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L02
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L02
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M02_L04
       test      r8b,18
       jne       near ptr M02_L08
       test      r8b,4
       jne       near ptr M02_L09
       test      r8,r8
       je        near ptr M02_L07
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L07
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M02_L07
M02_L00:
       cmp       r8,800
       ja        short M02_L03
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L05
       jmp       short M02_L06
M02_L02:
       cmp       rcx,rdx
       je        short M02_L07
M02_L03:
       jmp       qword ptr [7FFF20025B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L04:
       cmp       r8,40
       ja        short M02_L00
M02_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L07:
       ret
M02_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L07
M02_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L07
; Total bytes of code 269
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2012E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2012E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+198]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       near ptr M00_L13
M00_L00:
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M00_L02
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       short M00_L01
       mov       ecx,ecx
       mov       word ptr [rax+rcx*2+10],2C
       inc       edx
       mov       [rsi+18],edx
       jmp       short M00_L02
M00_L01:
       mov       rcx,rsi
       mov       edx,2C
       call      qword ptr [7FFF2020C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,21D5A130210
       call      qword ptr [7FFF1FFA6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M00_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M00_L16
       mov       rax,[rcx]
       add       rax,10
M00_L03:
       cmp       qword ptr [rax+8],0
       jne       short M00_L04
       mov       rcx,1DCC8400438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,1DCC8400418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L17
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L06
       mov       r12,21D5A130A40
M00_L05:
       test      r12,r12
       je        near ptr M00_L13
       jmp       near ptr M00_L09
M00_L06:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L14
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    rcx,r12d
       mov       r12,[rsp+28]
       lea       rcx,[r12+rcx*2+0C]
       mov       rax,21D5A130A4C
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       jmp       short M00_L05
M00_L07:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L08
       mov       rcx,rsi
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       r12,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r12+8],r8
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       mov       rcx,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L19
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L07
       mov       r15,[rcx]
       mov       r13,[rcx+8]
       jmp       near ptr M00_L00
M00_L09:
       lea       rdx,[r12+0C]
       mov       r13d,[r12+8]
       test      r13d,r13d
       je        short M00_L13
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L12
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L11
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L10:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L13
M00_L11:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       je        short M00_L18
       jmp       short M00_L10
M00_L12:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L13:
       cmp       ebp,[rdi+44]
       je        near ptr M00_L07
       jmp       short M00_L15
M00_L14:
       call      qword ptr [7FFF2015EF10]
       int       3
M00_L15:
       call      qword ptr [7FFF2015EFB8]
       int       3
M00_L16:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L17:
       call      qword ptr [7FFF20114030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L18:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L10
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 670
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF2020CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M01_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L02
       test      rsi,rsi
       je        near ptr M02_L03
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M02_L03
       test      rdi,rdi
       je        near ptr M02_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M02_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M02_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FFA6B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFF2015EF10]
       int       3
M02_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FFA6B08]; System.String.Concat(System.String, System.String)
M02_L03:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FFA6B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       jbe       short M03_L05
       cmp       r8,40
       ja        short M03_L03
M03_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L06
M03_L01:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M03_L02:
       pop       rbx
       pop       rsi
       ret
M03_L03:
       cmp       r8,800
       ja        near ptr M03_L09
       mov       rax,r8
       shr       rax,6
M03_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M03_L04
       and       r8,3F
       cmp       r8,10
       ja        short M03_L00
       jmp       short M03_L01
M03_L05:
       test      r8b,18
       jne       short M03_L08
       test      r8b,4
       je        short M03_L07
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rbx-4]
       mov       [rsi-4],ecx
       jmp       short M03_L02
M03_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L01
M03_L07:
       test      r8,r8
       je        short M03_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L02
       movsx     rcx,word ptr [rbx-2]
       mov       [rsi-2],cx
       jmp       near ptr M03_L02
M03_L08:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
       jmp       near ptr M03_L02
M03_L09:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF20055B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L10:
       cmp       rcx,rdx
       je        near ptr M03_L02
       jmp       short M03_L09
; Total bytes of code 274
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M04_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L02
       cmp       [rdx+8],r8d
       jb        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,21D5A130008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M05_L03
       cmp       r8d,edi
       jl        near ptr M05_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M05_L01
       test      r8,r8
       je        near ptr M05_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M05_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M05_L00:
       cmp       ebp,r10d
       ja        near ptr M05_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2020CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M05_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M05_L07
M05_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFF2015E9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFF2015E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF7F4421F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFF7F455B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF7F456B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+198]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       near ptr M00_L10
M00_L00:
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M00_L02
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       short M00_L01
       mov       ecx,ecx
       mov       word ptr [rax+rcx*2+10],2C
       inc       edx
       mov       [rsi+18],edx
       jmp       short M00_L02
M00_L01:
       mov       rcx,rsi
       mov       edx,2C
       call      qword ptr [7FFF201EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,32C81220210
       call      qword ptr [7FFF1FF86B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M00_L15
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M00_L15
       mov       rax,[rcx]
       add       rax,10
M00_L03:
       cmp       qword ptr [rax+8],0
       jne       short M00_L04
       mov       rcx,2EBF3400438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,2EBF3400418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,32C81220A40
       jmp       short M00_L06
M00_L05:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L13
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+28]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,32C81220A4C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
M00_L06:
       test      r12,r12
       je        short M00_L10
       lea       rdx,[r12+0C]
       mov       r15d,[r12+8]
       test      r15d,r15d
       je        short M00_L10
       mov       r8,[rsi+8]
       mov       r13d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L09
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       r15d,2
       jle       short M00_L08
       movsxd    r8,r15d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L07:
       add       r15d,r13d
       mov       [rsi+18],r15d
       jmp       short M00_L10
M00_L08:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r15d,2
       jne       short M00_L07
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L07
M00_L09:
       mov       rcx,rsi
       mov       r8d,r15d
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L12:
       mov       rcx,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[rcx+8]
       jae       short M00_L17
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L11
       mov       r15,[rcx]
       mov       r13,[rcx+8]
       jmp       near ptr M00_L00
M00_L13:
       call      qword ptr [7FFF2013EF10]
       int       3
M00_L14:
       call      qword ptr [7FFF2013EFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFF200F4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 649
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF201ECB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M01_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L02
       test      rsi,rsi
       je        near ptr M02_L03
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M02_L03
       test      rdi,rdi
       je        near ptr M02_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M02_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M02_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FF86B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFF2013EF10]
       int       3
M02_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FF86B08]; System.String.Concat(System.String, System.String)
M02_L03:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FF86B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M03_L05
       cmp       r8,40
       ja        short M03_L03
M03_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L06
M03_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L02:
       ret
M03_L03:
       cmp       r8,800
       ja        near ptr M03_L10
       mov       r9,r8
       shr       r9,6
M03_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L04
       and       r8,3F
       cmp       r8,10
       ja        short M03_L00
       jmp       short M03_L01
M03_L05:
       test      r8b,18
       jne       short M03_L08
       test      r8b,4
       je        short M03_L07
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L02
M03_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L01
M03_L07:
       test      r8,r8
       je        short M03_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M03_L02
M03_L08:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       near ptr M03_L02
M03_L09:
       cmp       rcx,rdx
       je        near ptr M03_L02
M03_L10:
       jmp       qword ptr [7FFF20035B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 269
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M04_L03
       cmp       r8d,edi
       jl        near ptr M04_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M04_L01
       test      r8,r8
       je        near ptr M04_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M04_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M04_L00:
       cmp       ebp,r10d
       ja        near ptr M04_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201ECB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M04_L07
M04_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFF2013E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFF2013E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,32C81220008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF7F4421F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFF7F455B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF7F456B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+198]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       near ptr M00_L10
M00_L00:
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M00_L02
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       short M00_L01
       mov       ecx,ecx
       mov       word ptr [rax+rcx*2+10],2C
       inc       edx
       mov       [rsi+18],edx
       jmp       short M00_L02
M00_L01:
       mov       rcx,rsi
       mov       edx,2C
       call      qword ptr [7FFF201FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,20C26320210
       call      qword ptr [7FFF1FF96B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M00_L15
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M00_L15
       mov       rax,[rcx]
       add       rax,10
M00_L03:
       cmp       qword ptr [rax+8],0
       jne       short M00_L04
       mov       rcx,1CB94400438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,1CB94400418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,20C26320A40
       jmp       short M00_L06
M00_L05:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L13
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+28]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,20C26320A4C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
M00_L06:
       test      r12,r12
       je        short M00_L10
       lea       rdx,[r12+0C]
       mov       r13d,[r12+8]
       test      r13d,r13d
       je        short M00_L10
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L09
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L08
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L07:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L10
M00_L08:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       je        near ptr M00_L17
       jmp       short M00_L07
M00_L09:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       r13,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L12:
       mov       rcx,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[rcx+8]
       jae       short M00_L18
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L11
       mov       r15,[rcx]
       mov       r13,[rcx+8]
       jmp       near ptr M00_L00
M00_L13:
       call      qword ptr [7FFF2014EF10]
       int       3
M00_L14:
       call      qword ptr [7FFF2014EFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFF20104030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L17:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 656
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF201FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M01_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L02
       test      rsi,rsi
       je        near ptr M02_L03
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M02_L03
       test      rdi,rdi
       je        near ptr M02_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M02_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M02_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FF96B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFF2014EF10]
       int       3
M02_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FF96B08]; System.String.Concat(System.String, System.String)
M02_L03:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FF96B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L08
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       jbe       short M03_L05
       cmp       r8,40
       ja        short M03_L03
M03_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L06
M03_L01:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M03_L02:
       pop       rbx
       pop       rsi
       ret
M03_L03:
       cmp       r8,800
       ja        near ptr M03_L09
       mov       rax,r8
       shr       rax,6
M03_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M03_L04
       and       r8,3F
       cmp       r8,10
       ja        short M03_L00
       jmp       short M03_L01
M03_L05:
       test      r8b,18
       jne       short M03_L10
       test      r8b,4
       je        short M03_L07
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M03_L02
M03_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L01
M03_L07:
       test      r8,r8
       je        short M03_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L02
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       near ptr M03_L02
M03_L08:
       cmp       rcx,rdx
       je        near ptr M03_L02
M03_L09:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF20045B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L10:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
       jmp       near ptr M03_L02
; Total bytes of code 273
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M04_L03
       cmp       r8d,edi
       jl        near ptr M04_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M04_L01
       test      r8,r8
       je        near ptr M04_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M04_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M04_L00:
       cmp       ebp,r10d
       ja        near ptr M04_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M04_L07
M04_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFF2014E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFF2014E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,20C26320008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF7F4421F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFF7F455B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF7F456B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+198]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       near ptr M00_L10
M00_L00:
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M00_L02
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       short M00_L01
       mov       ecx,ecx
       mov       word ptr [rax+rcx*2+10],2C
       inc       edx
       mov       [rsi+18],edx
       jmp       short M00_L02
M00_L01:
       mov       rcx,rsi
       mov       edx,2C
       call      qword ptr [7FFF2021C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,23F78150210
       call      qword ptr [7FFF1FFB6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M00_L15
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M00_L15
       mov       rax,[rcx]
       add       rax,10
M00_L03:
       cmp       qword ptr [rax+8],0
       jne       short M00_L04
       mov       rcx,1FEE6000438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,1FEE6000418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,23F78150A40
       jmp       short M00_L06
M00_L05:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L13
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+28]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,23F78150A4C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
M00_L06:
       test      r12,r12
       je        short M00_L10
       lea       rdx,[r12+0C]
       mov       r13d,[r12+8]
       test      r13d,r13d
       je        short M00_L10
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L09
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L08
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L07:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L10
M00_L08:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       je        near ptr M00_L17
       jmp       short M00_L07
M00_L09:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF2021CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFF2020B060]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       r13,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L12:
       mov       rcx,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[rcx+8]
       jae       short M00_L18
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L11
       mov       r15,[rcx]
       mov       r13,[rcx+8]
       jmp       near ptr M00_L00
M00_L13:
       call      qword ptr [7FFF2016EF10]
       int       3
M00_L14:
       call      qword ptr [7FFF2016EFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFF20124030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L17:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 656
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF2021CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M01_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L02
       test      rsi,rsi
       je        near ptr M02_L03
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M02_L03
       test      rdi,rdi
       je        near ptr M02_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M02_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M02_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FFB6B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFF2016EF10]
       int       3
M02_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FFB6B08]; System.String.Concat(System.String, System.String)
M02_L03:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FFB6B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L08
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       jbe       short M03_L05
       cmp       r8,40
       ja        short M03_L03
M03_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L06
M03_L01:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M03_L02:
       pop       rbx
       pop       rsi
       ret
M03_L03:
       cmp       r8,800
       ja        near ptr M03_L09
       mov       rax,r8
       shr       rax,6
M03_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M03_L04
       and       r8,3F
       cmp       r8,10
       ja        short M03_L00
       jmp       short M03_L01
M03_L05:
       test      r8b,18
       jne       short M03_L10
       test      r8b,4
       je        short M03_L07
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M03_L02
M03_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L01
M03_L07:
       test      r8,r8
       je        short M03_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L02
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       near ptr M03_L02
M03_L08:
       cmp       rcx,rdx
       je        near ptr M03_L02
M03_L09:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF20065B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L10:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
       jmp       near ptr M03_L02
; Total bytes of code 273
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M04_L03
       cmp       r8d,edi
       jl        near ptr M04_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M04_L01
       test      r8,r8
       je        near ptr M04_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M04_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M04_L00:
       cmp       ebp,r10d
       ja        near ptr M04_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2021CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M04_L07
M04_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF204A5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2006D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFF2016E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFF2016E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF204A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2006D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,23F78150008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF7F4421F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFF7F455B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF7F456B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+198]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       near ptr M00_L10
M00_L00:
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M00_L02
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       short M00_L01
       mov       ecx,ecx
       mov       word ptr [rax+rcx*2+10],2C
       inc       edx
       mov       [rsi+18],edx
       jmp       short M00_L02
M00_L01:
       mov       rcx,rsi
       mov       edx,2C
       call      qword ptr [7FFF2020C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,2163A460210
       call      qword ptr [7FFF1FFA6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M00_L15
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M00_L15
       mov       rax,[rcx]
       add       rax,10
M00_L03:
       cmp       qword ptr [rax+8],0
       jne       short M00_L04
       mov       rcx,1D5AC400438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,1D5AC400418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,2163A460A40
       jmp       short M00_L06
M00_L05:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L13
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+28]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,2163A460A4C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
M00_L06:
       test      r12,r12
       je        short M00_L10
       lea       rdx,[r12+0C]
       mov       r15d,[r12+8]
       test      r15d,r15d
       je        short M00_L10
       mov       r8,[rsi+8]
       mov       r13d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L09
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       r15d,2
       jle       short M00_L08
       movsxd    r8,r15d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L07:
       add       r15d,r13d
       mov       [rsi+18],r15d
       jmp       short M00_L10
M00_L08:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r15d,2
       jne       short M00_L07
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L07
M00_L09:
       mov       rcx,rsi
       mov       r8d,r15d
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L12:
       mov       rcx,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[rcx+8]
       jae       short M00_L17
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L11
       mov       r15,[rcx]
       mov       r13,[rcx+8]
       jmp       near ptr M00_L00
M00_L13:
       call      qword ptr [7FFF2015EF10]
       int       3
M00_L14:
       call      qword ptr [7FFF2015EFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFF20114030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 649
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF2020CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M01_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L02
       test      rsi,rsi
       je        near ptr M02_L03
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M02_L03
       test      rdi,rdi
       je        near ptr M02_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M02_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M02_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FFA6B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFF2015EF10]
       int       3
M02_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FFA6B08]; System.String.Concat(System.String, System.String)
M02_L03:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FFA6B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L09
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       jbe       short M03_L05
       cmp       r8,40
       ja        short M03_L03
M03_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L06
M03_L01:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M03_L02:
       pop       rbx
       pop       rsi
       ret
M03_L03:
       cmp       r8,800
       ja        near ptr M03_L10
       mov       rax,r8
       shr       rax,6
M03_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M03_L04
       and       r8,3F
       cmp       r8,10
       ja        short M03_L00
       jmp       short M03_L01
M03_L05:
       test      r8b,18
       jne       short M03_L08
       test      r8b,4
       je        short M03_L07
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rbx-4]
       mov       [rsi-4],ecx
       jmp       short M03_L02
M03_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L01
M03_L07:
       test      r8,r8
       je        short M03_L02
       movzx     eax,byte ptr [rdx]
       mov       [rcx],al
       test      r8b,2
       je        near ptr M03_L02
       movsx     rax,word ptr [rbx-2]
       mov       [rsi-2],ax
       jmp       near ptr M03_L02
M03_L08:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
       jmp       near ptr M03_L02
M03_L09:
       cmp       rcx,rdx
       je        near ptr M03_L02
M03_L10:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF20055B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M04_L03
       cmp       r8d,edi
       jl        near ptr M04_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M04_L01
       test      r8,r8
       je        near ptr M04_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M04_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M04_L00:
       cmp       ebp,r10d
       ja        near ptr M04_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2020CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M04_L07
M04_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFF2015E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFF2015E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,2163A460008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF7F4421F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFF7F455B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF7F456B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+198]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       near ptr M00_L07
M00_L00:
       mov       ecx,[rsi+1C]
       mov       r8d,[rsi+18]
       add       ecx,r8d
       test      ecx,ecx
       jle       short M00_L01
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L12
       mov       word ptr [rdx+rcx*2+10],2C
       inc       r8d
       mov       [rsi+18],r8d
M00_L01:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,26DC49D0210
       call      qword ptr [7FFF1FF76B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M00_L13
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M00_L13
       mov       rax,[rcx]
       add       rax,10
M00_L02:
       cmp       qword ptr [rax+8],0
       jne       short M00_L03
       mov       rcx,22D32C00438
       cmp       qword ptr [rcx],0
       jne       short M00_L03
       mov       rcx,22D32C00418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L14
M00_L03:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L04
       mov       r12,26DC49D0A40
       jmp       short M00_L05
M00_L04:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L10
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    rcx,r12d
       mov       r12,[rsp+28]
       lea       rcx,[r12+rcx*2+0C]
       mov       rax,26DC49D0A4C
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
M00_L05:
       test      r12,r12
       je        short M00_L07
       lea       rdx,[r12+0C]
       mov       r13d,[r12+8]
       test      r13d,r13d
       je        short M00_L07
       mov       rcx,[rsi+8]
       mov       r12d,[rsi+18]
       lea       eax,[r12+r13]
       cmp       eax,[rcx+8]
       ja        near ptr M00_L17
       movsxd    rax,r12d
       lea       rcx,[rcx+rax*2+10]
       cmp       r13d,2
       jg        near ptr M00_L16
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r13d,2
       je        near ptr M00_L15
M00_L06:
       add       r13d,r12d
       mov       [rsi+18],r13d
M00_L07:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L11
M00_L08:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L09
       mov       rcx,rsi
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L09:
       mov       rcx,[rdi+10]
       lea       r8d,[r14+1]
       mov       r15d,r8d
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L18
       mov       r8d,r14d
       lea       r8,[r8+r8*2]
       lea       rcx,[rcx+r8*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L08
       mov       r15,[rcx]
       mov       r13,[rcx+8]
       jmp       near ptr M00_L00
M00_L10:
       call      qword ptr [7FFF2012EF10]
       int       3
M00_L11:
       call      qword ptr [7FFF2012EFB8]
       int       3
M00_L12:
       mov       rcx,rsi
       mov       edx,2C
       call      qword ptr [7FFF201DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L01
M00_L13:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L02
M00_L14:
       call      qword ptr [7FFF200E4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L03
M00_L15:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L06
M00_L16:
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       cmp       ebp,[rdi+44]
       je        near ptr M00_L08
       jmp       short M00_L11
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 694
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M01_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L02
       test      rsi,rsi
       je        near ptr M01_L03
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M01_L03
       test      rdi,rdi
       je        near ptr M01_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M01_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M01_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FF76B08]; System.String.Concat(System.String, System.String)
M01_L01:
       call      qword ptr [7FFF2012EF10]
       int       3
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FF76B08]; System.String.Concat(System.String, System.String)
M01_L03:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FF76B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       jne       near ptr M02_L06
       test      r8b,4
       jne       near ptr M02_L07
       test      r8,r8
       je        near ptr M02_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L05
M02_L00:
       cmp       r8,800
       ja        near ptr M02_L09
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L03
       jmp       short M02_L04
M02_L02:
       cmp       r8,40
       ja        short M02_L00
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L04
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L05:
       ret
M02_L06:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L05
M02_L07:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L05
M02_L08:
       cmp       rcx,rdx
       je        short M02_L05
M02_L09:
       jmp       qword ptr [7FFF20025B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 266
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,26DC49D0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF201DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M04_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF7F4421F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFF7F455B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF7F456B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M06_L03
       cmp       r8d,edi
       jl        near ptr M06_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M06_L01
       test      r8,r8
       je        near ptr M06_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M06_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M06_L00:
       cmp       ebp,r10d
       ja        near ptr M06_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M06_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M06_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M06_L07
M06_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L04:
       test      eax,eax
       jne       short M06_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M06_L00
M06_L05:
       call      qword ptr [7FFF2012E9A0]
       int       3
M06_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M06_L02
M06_L07:
       call      qword ptr [7FFF2012E9B8]
       int       3
; Total bytes of code 315
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+198]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       near ptr M00_L07
M00_L00:
       mov       ecx,[rsi+1C]
       mov       r8d,[rsi+18]
       add       ecx,r8d
       test      ecx,ecx
       jle       short M00_L01
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L12
       mov       word ptr [rdx+rcx*2+10],2C
       inc       r8d
       mov       [rsi+18],r8d
M00_L01:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,2C833C90210
       call      qword ptr [7FFF1FF96B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M00_L13
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M00_L13
       mov       rax,[rcx]
       add       rax,10
M00_L02:
       cmp       qword ptr [rax+8],0
       jne       short M00_L03
       mov       rcx,287A1C00438
       cmp       qword ptr [rcx],0
       jne       short M00_L03
       mov       rcx,287A1C00418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L14
M00_L03:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L04
       mov       r12,2C833C90A40
       jmp       short M00_L05
M00_L04:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L10
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    rcx,r12d
       mov       r12,[rsp+28]
       lea       rcx,[r12+rcx*2+0C]
       mov       rax,2C833C90A4C
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
M00_L05:
       test      r12,r12
       je        short M00_L07
       lea       rdx,[r12+0C]
       mov       r13d,[r12+8]
       test      r13d,r13d
       je        short M00_L07
       mov       rcx,[rsi+8]
       mov       r12d,[rsi+18]
       lea       eax,[r12+r13]
       cmp       eax,[rcx+8]
       ja        near ptr M00_L17
       movsxd    rax,r12d
       lea       rcx,[rcx+rax*2+10]
       cmp       r13d,2
       jg        near ptr M00_L16
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r13d,2
       je        near ptr M00_L15
M00_L06:
       add       r13d,r12d
       mov       [rsi+18],r13d
M00_L07:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L11
M00_L08:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L09
       mov       rcx,rsi
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L09:
       mov       rcx,[rdi+10]
       lea       r8d,[r14+1]
       mov       r15d,r8d
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L18
       mov       r8d,r14d
       lea       r8,[r8+r8*2]
       lea       rcx,[rcx+r8*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L08
       mov       r15,[rcx]
       mov       r13,[rcx+8]
       jmp       near ptr M00_L00
M00_L10:
       call      qword ptr [7FFF2014EF10]
       int       3
M00_L11:
       call      qword ptr [7FFF2014EFB8]
       int       3
M00_L12:
       mov       rcx,rsi
       mov       edx,2C
       call      qword ptr [7FFF201FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L01
M00_L13:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L02
M00_L14:
       call      qword ptr [7FFF20104030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L03
M00_L15:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L06
M00_L16:
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       cmp       ebp,[rdi+44]
       je        near ptr M00_L08
       jmp       short M00_L11
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 694
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M01_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L02
       test      rsi,rsi
       je        near ptr M01_L03
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M01_L03
       test      rdi,rdi
       je        near ptr M01_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M01_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M01_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FF96B08]; System.String.Concat(System.String, System.String)
M01_L01:
       call      qword ptr [7FFF2014EF10]
       int       3
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FF96B08]; System.String.Concat(System.String, System.String)
M01_L03:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FF96B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       jne       near ptr M02_L06
       test      r8b,4
       jne       near ptr M02_L07
       test      r8,r8
       je        near ptr M02_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L05
M02_L00:
       cmp       r8,800
       ja        near ptr M02_L09
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L03
       jmp       short M02_L04
M02_L02:
       cmp       r8,40
       ja        short M02_L00
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L04
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L05:
       ret
M02_L06:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L05
M02_L07:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L05
M02_L08:
       cmp       rcx,rdx
       je        short M02_L05
M02_L09:
       jmp       qword ptr [7FFF20045B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 266
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2C833C90008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF201FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M04_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF7F4421F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFF7F455B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF7F456B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M06_L03
       cmp       r8d,edi
       jl        near ptr M06_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M06_L01
       test      r8,r8
       je        near ptr M06_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M06_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M06_L00:
       cmp       ebp,r10d
       ja        near ptr M06_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M06_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M06_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M06_L07
M06_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L04:
       test      eax,eax
       jne       short M06_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M06_L00
M06_L05:
       call      qword ptr [7FFF2014E9A0]
       int       3
M06_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M06_L02
M06_L07:
       call      qword ptr [7FFF2014E9B8]
       int       3
; Total bytes of code 315
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+198]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       near ptr M00_L07
M00_L00:
       mov       ecx,[rsi+1C]
       mov       r8d,[rsi+18]
       add       ecx,r8d
       test      ecx,ecx
       jle       short M00_L01
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L12
       mov       word ptr [rdx+rcx*2+10],2C
       inc       r8d
       mov       [rsi+18],r8d
M00_L01:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,26B10780210
       call      qword ptr [7FFF1FFB6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M00_L13
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M00_L13
       mov       rax,[rcx]
       add       rax,10
M00_L02:
       cmp       qword ptr [rax+8],0
       jne       short M00_L03
       mov       rcx,22A7E800438
       cmp       qword ptr [rcx],0
       jne       short M00_L03
       mov       rcx,22A7E800418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L14
M00_L03:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L04
       mov       r12,26B10780A40
       jmp       short M00_L05
M00_L04:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L10
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    rcx,r12d
       mov       r12,[rsp+28]
       lea       rcx,[r12+rcx*2+0C]
       mov       rax,26B10780A4C
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
M00_L05:
       test      r12,r12
       je        short M00_L07
       lea       rdx,[r12+0C]
       mov       r13d,[r12+8]
       test      r13d,r13d
       je        short M00_L07
       mov       rcx,[rsi+8]
       mov       r12d,[rsi+18]
       lea       eax,[r12+r13]
       cmp       eax,[rcx+8]
       ja        near ptr M00_L17
       movsxd    rax,r12d
       lea       rcx,[rcx+rax*2+10]
       cmp       r13d,2
       jg        near ptr M00_L16
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r13d,2
       je        near ptr M00_L15
M00_L06:
       add       r13d,r12d
       mov       [rsi+18],r13d
M00_L07:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L11
M00_L08:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L09
       mov       rcx,rsi
       call      qword ptr [7FFF2020B060]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L09:
       mov       rcx,[rdi+10]
       lea       r8d,[r14+1]
       mov       r15d,r8d
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L18
       mov       r8d,r14d
       lea       r8,[r8+r8*2]
       lea       rcx,[rcx+r8*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L08
       mov       r15,[rcx]
       mov       r13,[rcx+8]
       jmp       near ptr M00_L00
M00_L10:
       call      qword ptr [7FFF2016EF10]
       int       3
M00_L11:
       call      qword ptr [7FFF2016EFB8]
       int       3
M00_L12:
       mov       rcx,rsi
       mov       edx,2C
       call      qword ptr [7FFF2021C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L01
M00_L13:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L02
M00_L14:
       call      qword ptr [7FFF20124030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L03
M00_L15:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L06
M00_L16:
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF2021CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       cmp       ebp,[rdi+44]
       je        near ptr M00_L08
       jmp       short M00_L11
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 694
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M01_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L02
       test      rsi,rsi
       je        near ptr M01_L03
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M01_L03
       test      rdi,rdi
       je        near ptr M01_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M01_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M01_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FFB6B08]; System.String.Concat(System.String, System.String)
M01_L01:
       call      qword ptr [7FFF2016EF10]
       int       3
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FFB6B08]; System.String.Concat(System.String, System.String)
M01_L03:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF1FFB6B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L02
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L02
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M02_L04
       test      r8b,18
       jne       near ptr M02_L08
       test      r8b,4
       jne       near ptr M02_L09
       test      r8,r8
       je        near ptr M02_L07
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L07
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M02_L07
M02_L00:
       cmp       r8,800
       ja        short M02_L03
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L05
       jmp       short M02_L06
M02_L02:
       cmp       rcx,rdx
       je        short M02_L07
M02_L03:
       jmp       qword ptr [7FFF20065B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L04:
       cmp       r8,40
       ja        short M02_L00
M02_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L07:
       ret
M02_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L07
M02_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L07
; Total bytes of code 269
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF204A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2006D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,26B10780008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF2021CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M04_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF7F4421F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFF7F455B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF7F456B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M06_L03
       cmp       r8d,edi
       jl        near ptr M06_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M06_L01
       test      r8,r8
       je        near ptr M06_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M06_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M06_L00:
       cmp       ebp,r10d
       ja        near ptr M06_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M06_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2021CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M06_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M06_L07
M06_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF204A5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2006D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L04:
       test      eax,eax
       jne       short M06_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M06_L00
M06_L05:
       call      qword ptr [7FFF2016E9A0]
       int       3
M06_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M06_L02
M06_L07:
       call      qword ptr [7FFF2016E9B8]
       int       3
; Total bytes of code 315
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFF207D4240]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-0A0],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      rsi,rsi
       je        near ptr M01_L18
       mov       r8,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],r8
       jne       near ptr M01_L19
       mov       r8d,[rsi+38]
       sub       r8d,[rsi+40]
M01_L00:
       xor       edi,edi
       test      r8d,r8d
       setg      dil
M01_L01:
       movzx     r8d,dil
       test      r8d,r8d
       je        near ptr M01_L20
       mov       r8,215C64055F8
       mov       r14,[r8]
       mov       r8,[r14+20]
       mov       [rbp-88],r8
       cmp       qword ptr [rbp-88],0
       je        near ptr M01_L21
       lea       r8,[r14+20]
       mov       rdx,[rbp-88]
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       jne       near ptr M01_L21
M01_L02:
       mov       r15,[rbp-88]
M01_L03:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r15
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF1FF9EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+20]
       test      r13,r13
       je        short M01_L05
M01_L04:
       jmp       near ptr M01_L15
M01_L05:
       mov       rdx,7FFF207B7250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r13,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L04
M01_L06:
       mov       rdx,7FFF207B90A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L14
M01_L07:
       mov       r12,[rbp-50]
       mov       r14,[rbp-48]
       mov       ecx,[r15+1C]
       mov       edx,[r15+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L09
       mov       ecx,edx
       mov       rax,[r15+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L08
       mov       [rax+rcx*2+10],bx
       inc       edx
       mov       [r15+18],edx
       jmp       short M01_L09
M01_L08:
       movzx     edx,bx
       mov       rcx,r15
       call      qword ptr [7FFF201FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L09:
       mov       rcx,r15
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       byte ptr [rbp-70],0
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L11
M01_L10:
       lea       rcx,[rbp-80]
       mov       r8,r12
       call      qword ptr [7FFF207D4C48]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,256583A0A4C
       mov       rax,[rcx+8]
       mov       r8d,[rcx+18]
       lea       r10d,[r8+1]
       cmp       [rax+8],r10d
       jb        short M01_L12
       movsxd    rdx,r8d
       mov       word ptr [rax+rdx*2+10],3A
       mov       [rcx+18],r10d
       jmp       short M01_L13
M01_L11:
       mov       rdx,7FFF207B8FE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L10
M01_L12:
       mov       r8d,1
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       near ptr M01_L06
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M01_L06
M01_L14:
       lea       rcx,[rbp-80]
       mov       r8,r14
       call      qword ptr [7FFF207D4C48]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L15:
       mov       rdx,r13
       lea       rcx,[rbp-68]
       call      qword ptr [7FFF20377978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L16
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFF207B90D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L17:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L26
       jmp       short M01_L23
       call      CORINFO_HELP_OVERFLOW
M01_L18:
       xor       edi,edi
       jmp       near ptr M01_L01
M01_L19:
       mov       rcx,rsi
       mov       r11,7FFF1FE50CE0
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M01_L00
M01_L20:
       mov       rax,256583A0008
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
M01_L21:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20614D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L22
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L02
M01_L22:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L23:
       mov       rax,[rbp-98]
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
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L24
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L24
       jmp       short M01_L25
M01_L24:
       mov       rdx,7FFF207B90D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L25:
       lea       rcx,[rbp-68]
       call      rax
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,215C64055F8
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L27
       mov       r14,[rbp-90]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L31
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFF201FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L28
M01_L27:
       mov       rdx,[rbp-90]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-90]
       je        short M01_L31
M01_L28:
       cmp       qword ptr [r15+20],0
       jne       short M01_L29
       lea       rcx,[r15+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L31
M01_L29:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L30
       mov       rcx,[r15+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20614D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L31
M01_L30:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L31:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1125
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFF207B5BF0]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-0A0],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      rsi,rsi
       je        near ptr M01_L18
       mov       r8,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],r8
       jne       near ptr M01_L19
       mov       r8d,[rsi+38]
       sub       r8d,[rsi+40]
M01_L00:
       xor       edi,edi
       test      r8d,r8d
       setg      dil
M01_L01:
       movzx     r8d,dil
       test      r8d,r8d
       je        near ptr M01_L20
       mov       r8,231A9C03600
       mov       r14,[r8]
       mov       r8,[r14+20]
       mov       [rbp-88],r8
       cmp       qword ptr [rbp-88],0
       je        near ptr M01_L21
       lea       r8,[r14+20]
       mov       rdx,[rbp-88]
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       jne       near ptr M01_L21
M01_L02:
       mov       r15,[rbp-88]
M01_L03:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r15
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF1FF8EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+20]
       test      r13,r13
       je        short M01_L05
M01_L04:
       jmp       near ptr M01_L15
M01_L05:
       mov       rdx,7FFF207AAD28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r13,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L04
M01_L06:
       mov       rdx,7FFF207AAEA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L14
M01_L07:
       mov       r12,[rbp-50]
       mov       r14,[rbp-48]
       mov       ecx,[r15+1C]
       mov       edx,[r15+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L09
       mov       ecx,edx
       mov       rax,[r15+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L08
       mov       [rax+rcx*2+10],bx
       inc       edx
       mov       [r15+18],edx
       jmp       short M01_L09
M01_L08:
       movzx     edx,bx
       mov       rcx,r15
       call      qword ptr [7FFF201EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L09:
       mov       rcx,r15
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       byte ptr [rbp-70],0
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L11
M01_L10:
       lea       rcx,[rbp-80]
       mov       r8,r12
       call      qword ptr [7FFF207B65F8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,2723B9D0A4C
       mov       rax,[rcx+8]
       mov       r8d,[rcx+18]
       lea       r10d,[r8+1]
       cmp       [rax+8],r10d
       jb        short M01_L12
       movsxd    rdx,r8d
       mov       word ptr [rax+rdx*2+10],3A
       mov       [rcx+18],r10d
       jmp       short M01_L13
M01_L11:
       mov       rdx,7FFF207AADE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L10
M01_L12:
       mov       r8d,1
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       near ptr M01_L06
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M01_L06
M01_L14:
       lea       rcx,[rbp-80]
       mov       r8,r14
       call      qword ptr [7FFF207B65F8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L15:
       mov       rdx,r13
       lea       rcx,[rbp-68]
       call      qword ptr [7FFF20367978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L16
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFF207AAEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L17:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L26
       jmp       short M01_L23
       call      CORINFO_HELP_OVERFLOW
M01_L18:
       xor       edi,edi
       jmp       near ptr M01_L01
M01_L19:
       mov       rcx,rsi
       mov       r11,7FFF1FE40CE0
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M01_L00
M01_L20:
       mov       rax,2723B9D0008
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
M01_L21:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L22
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L02
M01_L22:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L23:
       mov       rax,[rbp-98]
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
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L24
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L24
       jmp       short M01_L25
M01_L24:
       mov       rdx,7FFF207AAEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L25:
       lea       rcx,[rbp-68]
       call      rax
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,231A9C03600
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L27
       mov       r14,[rbp-90]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L31
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFF201EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L28
M01_L27:
       mov       rdx,[rbp-90]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-90]
       je        short M01_L31
M01_L28:
       cmp       qword ptr [r15+20],0
       jne       short M01_L29
       lea       rcx,[r15+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L31
M01_L29:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L30
       mov       rcx,[r15+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L31
M01_L30:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L31:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1125
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFF207B5BF0]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-0A0],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      rsi,rsi
       je        near ptr M01_L18
       mov       r8,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],r8
       jne       near ptr M01_L19
       mov       r8d,[rsi+38]
       sub       r8d,[rsi+40]
M01_L00:
       xor       edi,edi
       test      r8d,r8d
       setg      dil
M01_L01:
       movzx     r8d,dil
       test      r8d,r8d
       je        near ptr M01_L20
       mov       r8,187FCC055F8
       mov       r14,[r8]
       mov       r8,[r14+20]
       mov       [rbp-88],r8
       cmp       qword ptr [rbp-88],0
       je        near ptr M01_L21
       lea       r8,[r14+20]
       mov       rdx,[rbp-88]
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       jne       near ptr M01_L21
M01_L02:
       mov       r15,[rbp-88]
M01_L03:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r15
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF1FF8EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+20]
       test      r13,r13
       je        short M01_L05
M01_L04:
       jmp       near ptr M01_L15
M01_L05:
       mov       rdx,7FFF207AAD28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r13,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L04
M01_L06:
       mov       rdx,7FFF207AAEA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L14
M01_L07:
       mov       r12,[rbp-50]
       mov       r14,[rbp-48]
       mov       ecx,[r15+1C]
       mov       edx,[r15+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L09
       mov       ecx,edx
       mov       rax,[r15+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L08
       mov       [rax+rcx*2+10],bx
       inc       edx
       mov       [r15+18],edx
       jmp       short M01_L09
M01_L08:
       movzx     edx,bx
       mov       rcx,r15
       call      qword ptr [7FFF201EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L09:
       mov       rcx,r15
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       byte ptr [rbp-70],0
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L11
M01_L10:
       lea       rcx,[rbp-80]
       mov       r8,r12
       call      qword ptr [7FFF207B65F8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,1C88E940A4C
       mov       rax,[rcx+8]
       mov       r8d,[rcx+18]
       lea       r10d,[r8+1]
       cmp       [rax+8],r10d
       jb        short M01_L12
       movsxd    rdx,r8d
       mov       word ptr [rax+rdx*2+10],3A
       mov       [rcx+18],r10d
       jmp       short M01_L13
M01_L11:
       mov       rdx,7FFF207AADE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L10
M01_L12:
       mov       r8d,1
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       near ptr M01_L06
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M01_L06
M01_L14:
       lea       rcx,[rbp-80]
       mov       r8,r14
       call      qword ptr [7FFF207B65F8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L15:
       mov       rdx,r13
       lea       rcx,[rbp-68]
       call      qword ptr [7FFF20367978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L16
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFF207AAEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L17:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L26
       jmp       short M01_L23
       call      CORINFO_HELP_OVERFLOW
M01_L18:
       xor       edi,edi
       jmp       near ptr M01_L01
M01_L19:
       mov       rcx,rsi
       mov       r11,7FFF1FE40C20
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M01_L00
M01_L20:
       mov       rax,1C88E940008
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
M01_L21:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L22
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L02
M01_L22:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L23:
       mov       rax,[rbp-98]
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
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L24
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L24
       jmp       short M01_L25
M01_L24:
       mov       rdx,7FFF207AAEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L25:
       lea       rcx,[rbp-68]
       call      rax
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,187FCC055F8
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L27
       mov       r14,[rbp-90]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L31
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFF201EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L28
M01_L27:
       mov       rdx,[rbp-90]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-90]
       je        short M01_L31
M01_L28:
       cmp       qword ptr [r15+20],0
       jne       short M01_L29
       lea       rcx,[r15+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L31
M01_L29:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L30
       mov       rcx,[r15+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L31
M01_L30:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L31:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1125
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFF207A58F0]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-0A0],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      rsi,rsi
       je        near ptr M01_L20
       mov       rdx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rdx
       jne       near ptr M01_L21
       mov       edx,[rsi+38]
       sub       edx,[rsi+40]
M01_L00:
       xor       edi,edi
       test      edx,edx
       setg      dil
M01_L01:
       movzx     edx,dil
       test      edx,edx
       je        near ptr M01_L22
       mov       rdx,21B63C03600
       mov       r14,[rdx]
       mov       rdx,[r14+20]
       mov       [rbp-88],rdx
       cmp       qword ptr [rbp-88],0
       jne       near ptr M01_L23
M01_L02:
       mov       r15,[r14+18]
       mov       rdi,[r15+18]
       lea       rdx,[rbp-88]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L25
       cmp       qword ptr [rdi+10],0
       jne       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-88],rcx
M01_L03:
       mov       rdi,[r14+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [rdi+18],rcx
       jne       near ptr M01_L27
       mov       r14,[rdi+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       edi,[r14+8]
       mov       ecx,edi
       mov       rdx,25BF5CB9CB0
       call      qword ptr [7FFF202D40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       edx,10
       test      edi,edi
       cmove     edi,edx
       mov       dword ptr [r13+20],7FFFFFFF
       cmp       edi,400
       jl        near ptr M01_L26
       mov       edx,edi
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L04:
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L05:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r13
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF1FF7EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+20]
       test      r14,r14
       je        short M01_L07
M01_L06:
       jmp       near ptr M01_L17
M01_L07:
       mov       rdx,7FFF2079AD28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L06
M01_L08:
       mov       rdx,7FFF2079AEA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L16
M01_L09:
       mov       r12,[rbp-50]
       mov       rdi,[rbp-48]
       mov       ecx,[r13+1C]
       mov       edx,[r13+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L11
       mov       ecx,edx
       mov       rax,[r13+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L10
       mov       [rax+rcx*2+10],bx
       inc       edx
       mov       [r13+18],edx
       jmp       short M01_L11
M01_L10:
       movzx     edx,bx
       mov       rcx,r13
       call      qword ptr [7FFF201DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L11:
       mov       rcx,r13
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       byte ptr [rbp-70],0
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L13
M01_L12:
       lea       rcx,[rbp-80]
       mov       r8,r12
       call      qword ptr [7FFF207A62F8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,25BF5CB0A4C
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+1]
       cmp       [r8+8],r10d
       jb        short M01_L14
       movsxd    rdx,eax
       mov       word ptr [r8+rdx*2+10],3A
       mov       [rcx+18],r10d
       jmp       short M01_L15
M01_L13:
       mov       rdx,7FFF2079ADE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L12
M01_L14:
       mov       r8d,1
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       near ptr M01_L08
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M01_L08
M01_L16:
       lea       rcx,[rbp-80]
       mov       r8,rdi
       call      qword ptr [7FFF207A62F8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L17:
       mov       rdx,r14
       lea       rcx,[rbp-68]
       call      qword ptr [7FFF20357978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L09
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L18
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rdx,7FFF2079AEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L19:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L29
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       xor       edi,edi
       jmp       near ptr M01_L01
M01_L21:
       mov       rcx,rsi
       mov       r11,7FFF1FE30C20
       call      qword ptr [r11]
       mov       edx,eax
       jmp       near ptr M01_L00
M01_L22:
       mov       rax,25BF5CB0008
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
M01_L23:
       lea       r8,[r14+20]
       mov       rdx,[rbp-88]
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       je        short M01_L28
       jmp       near ptr M01_L02
M01_L24:
       lea       rdx,[rbp-88]
       mov       rcx,r15
       call      qword ptr [7FFF205F4DB0]
       test      eax,eax
       je        near ptr M01_L03
M01_L25:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       short M01_L28
M01_L26:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L04
M01_L27:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r13,rax
       jmp       near ptr M01_L05
M01_L28:
       mov       r13,[rbp-88]
       jmp       near ptr M01_L05
M01_L29:
       mov       rax,[rbp-98]
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
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L30
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rdx,7FFF2079AEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L31:
       lea       rcx,[rbp-68]
       call      rax
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,21B63C03600
       mov       r13,[rcx]
       mov       rsi,[r13+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L33
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L37
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFF201DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       rdi,[rbp-90]
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L37
M01_L34:
       cmp       qword ptr [r13+20],0
       jne       short M01_L35
       lea       rcx,[r13+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L37
M01_L35:
       lea       rcx,[r13+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r13+28]
       jg        short M01_L36
       mov       rcx,[r13+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       r13,2C
       lock dec  dword ptr [r13]
M01_L37:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1329
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFF208B7318]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-0A0],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      rsi,rsi
       je        near ptr M01_L21
       mov       r8,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],r8
       jne       near ptr M01_L22
       mov       r8d,[rsi+38]
       sub       r8d,[rsi+40]
M01_L00:
       xor       edi,edi
       test      r8d,r8d
       setg      dil
M01_L01:
       movzx     r8d,dil
       test      r8d,r8d
       je        near ptr M01_L23
       mov       r8,1FBFF003600
       mov       r14,[r8]
       mov       r8,[r14+20]
       mov       [rbp-88],r8
       cmp       qword ptr [rbp-88],0
       je        short M01_L02
       lea       r8,[r14+20]
       mov       rdx,[rbp-88]
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       je        short M01_L05
M01_L02:
       mov       r15,[r14+18]
       mov       rdi,[r15+18]
       lea       rdx,[rbp-88]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF20605290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L25
       cmp       qword ptr [rdi+10],0
       jne       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-88],rcx
M01_L03:
       mov       rdi,[r14+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [rdi+18],rcx
       jne       near ptr M01_L26
       mov       r15,[rdi+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       edx,[r15+8]
       mov       rcx,r13
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFF201EC0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
M01_L04:
       jmp       short M01_L06
M01_L05:
       mov       r13,[rbp-88]
M01_L06:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r13
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF1FF8EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+20]
       test      r15,r15
       je        short M01_L08
M01_L07:
       jmp       near ptr M01_L18
M01_L08:
       mov       rdx,7FFF20897E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r15,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L07
M01_L09:
       mov       rdx,7FFF20897FE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L17
M01_L10:
       mov       r12,[rbp-50]
       mov       rdi,[rbp-48]
       mov       ecx,[r13+1C]
       mov       edx,[r13+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L12
       mov       ecx,edx
       mov       rax,[r13+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L11
       mov       [rax+rcx*2+10],bx
       inc       edx
       mov       [r13+18],edx
       jmp       short M01_L12
M01_L11:
       movzx     edx,bx
       mov       rcx,r13
       call      qword ptr [7FFF201EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L12:
       mov       rcx,r13
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       byte ptr [rbp-70],0
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L14
M01_L13:
       lea       rcx,[rbp-80]
       mov       r8,r12
       call      qword ptr [7FFF208B7D20]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,23C90E50A4C
       mov       rax,[rcx+8]
       mov       r8d,[rcx+18]
       lea       r10d,[r8+1]
       cmp       [rax+8],r10d
       jb        short M01_L15
       movsxd    rdx,r8d
       mov       word ptr [rax+rdx*2+10],3A
       mov       [rcx+18],r10d
       jmp       short M01_L16
M01_L14:
       mov       rdx,7FFF20897F28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L13
M01_L15:
       mov       r8d,1
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L16:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       near ptr M01_L09
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M01_L09
M01_L17:
       lea       rcx,[rbp-80]
       mov       r8,rdi
       call      qword ptr [7FFF208B7D20]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L18:
       mov       rdx,r15
       lea       rcx,[rbp-68]
       call      qword ptr [7FFF20367978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L10
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L19
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FFF20898020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L30
       jmp       short M01_L27
       call      CORINFO_HELP_OVERFLOW
M01_L21:
       xor       edi,edi
       jmp       near ptr M01_L01
M01_L22:
       mov       rcx,rsi
       mov       r11,7FFF1FE40F60
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M01_L00
M01_L23:
       mov       rax,23C90E50008
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
M01_L24:
       lea       rdx,[rbp-88]
       mov       rcx,r15
       call      qword ptr [7FFF20604DB0]
       test      eax,eax
       je        near ptr M01_L03
M01_L25:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L05
M01_L26:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r13,rax
       jmp       near ptr M01_L04
M01_L27:
       mov       rax,[rbp-98]
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
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L28
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L28
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FFF20898020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L29:
       lea       rcx,[rbp-68]
       call      rax
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,1FBFF003600
       mov       r13,[rcx]
       mov       rsi,[r13+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L31
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L35
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFF201EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L32
M01_L31:
       mov       rdi,[rbp-90]
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L35
M01_L32:
       cmp       qword ptr [r13+20],0
       jne       short M01_L33
       lea       rcx,[r13+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L35
M01_L33:
       lea       rcx,[r13+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r13+28]
       jg        short M01_L34
       mov       rbx,[r13+18]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF206052C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L35
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF20604D80]
       jmp       short M01_L35
M01_L34:
       add       r13,2C
       lock dec  dword ptr [r13]
M01_L35:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1255
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFF208BC240]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-0A0],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      rsi,rsi
       je        near ptr M01_L23
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Data.State[]
       cmp       [rsi],r11
       jne       short M01_L00
       mov       r11d,[rsi+8]
       test      r11d,r11d
       jl        near ptr M01_L22
       mov       edi,r11d
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       r11,7FFF1FE31150
       call      qword ptr [r11]
       mov       edi,eax
M01_L01:
       test      edi,edi
       setg      dil
       movzx     edi,dil
       movzx     r14d,dil
       test      r14d,r14d
       je        near ptr M01_L24
M01_L02:
       mov       rcx,1E6980055F8
       mov       r15,[rcx]
       mov       rcx,[r15+20]
       mov       [rbp-88],rcx
       cmp       qword ptr [rbp-88],0
       je        near ptr M01_L19
       lea       rcx,[r15+20]
       mov       r8,[rbp-88]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       jne       near ptr M01_L19
M01_L03:
       mov       r15,[rbp-88]
M01_L04:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r15
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF1FF7EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+20]
       test      r13,r13
       je        short M01_L06
M01_L05:
       jmp       near ptr M01_L16
M01_L06:
       mov       rdx,7FFF208A6640
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r13,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L05
M01_L07:
       mov       rdx,7FFF208A67C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L15
M01_L08:
       mov       r12,[rbp-50]
       mov       rsi,[rbp-48]
       mov       ecx,[r15+1C]
       mov       edx,[r15+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L10
       mov       ecx,edx
       mov       rax,[r15+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L09
       mov       [rax+rcx*2+10],bx
       inc       edx
       mov       [r15+18],edx
       jmp       short M01_L10
M01_L09:
       movzx     edx,bx
       mov       rcx,r15
       call      qword ptr [7FFF201DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L10:
       mov       rcx,r15
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       byte ptr [rbp-70],0
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L12
M01_L11:
       lea       rcx,[rbp-80]
       mov       r8,r12
       call      qword ptr [7FFF208BCC48]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,22729F10A4C
       mov       rax,[rcx+8]
       mov       r8d,[rcx+18]
       lea       r10d,[r8+1]
       cmp       [rax+8],r10d
       jb        short M01_L13
       movsxd    rdx,r8d
       mov       word ptr [rax+rdx*2+10],3A
       mov       [rcx+18],r10d
       jmp       short M01_L14
M01_L12:
       mov       rdx,7FFF208A6700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L11
M01_L13:
       mov       r8d,1
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L14:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       near ptr M01_L07
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M01_L07
M01_L15:
       lea       rcx,[rbp-80]
       mov       r8,rsi
       call      qword ptr [7FFF208BCC48]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L16:
       mov       rdx,r13
       lea       rcx,[rbp-68]
       call      qword ptr [7FFF20357978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L08
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L17
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFF208A67F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L18:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L29
       nop
       mov       rax,[rbp-98]
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
M01_L19:
       mov       r13,[r15+18]
       mov       r12,[r13+18]
       lea       rdx,[rbp-88]
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L25
M01_L20:
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       near ptr M01_L03
M01_L21:
       mov       rax,[r15+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L04
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       xor       edi,edi
       movzx     r14d,dil
       test      r14d,r14d
       jne       near ptr M01_L02
M01_L24:
       mov       rax,22729F10008
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
M01_L25:
       cmp       qword ptr [r12+10],0
       jne       short M01_L26
       xor       edx,edx
       mov       [rbp-88],rdx
       jmp       short M01_L21
M01_L26:
       lea       rdx,[rbp-88]
       mov       rcx,r13
       call      qword ptr [7FFF205F4DB0]
       test      eax,eax
       je        short M01_L21
       jmp       short M01_L20
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L27
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rdx,7FFF208A67F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L28:
       lea       rcx,[rbp-68]
       call      rax
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L29:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,1E6980055F8
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,7FFF205F1350
       cmp       [rax+18],rcx
       jne       short M01_L30
       mov       rsi,[rbp-90]
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rsi+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L34
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF201DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L31
M01_L30:
       mov       rdx,[rbp-90]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rsi,[rbp-90]
       je        short M01_L34
M01_L31:
       cmp       qword ptr [r15+20],0
       jne       short M01_L32
       lea       rcx,[r15+20]
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L34
M01_L32:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L33
       mov       r15,[r15+18]
       mov       rcx,[r15+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F52C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L34
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFF205F4D80]
       jmp       short M01_L34
M01_L33:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L34:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1198
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFF208CC240]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-0A0],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      rsi,rsi
       je        near ptr M01_L23
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Data.City[]
       cmp       [rsi],r11
       je        near ptr M01_L18
       mov       rcx,rsi
       mov       r11,7FFF1FE411C0
       call      qword ptr [r11]
       mov       edi,eax
M01_L00:
       test      edi,edi
       setg      dil
       movzx     edi,dil
       movzx     r14d,dil
       test      r14d,r14d
       je        near ptr M01_L24
M01_L01:
       mov       rcx,149164055F8
       mov       r15,[rcx]
       mov       rcx,[r15+20]
       mov       [rbp-88],rcx
       cmp       qword ptr [rbp-88],0
       je        near ptr M01_L19
       lea       rcx,[r15+20]
       mov       r8,[rbp-88]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       jne       near ptr M01_L19
M01_L02:
       mov       r15,[rbp-88]
M01_L03:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r15
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF1FF8EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+20]
       test      r13,r13
       je        short M01_L05
M01_L04:
       jmp       near ptr M01_L15
M01_L05:
       mov       rdx,7FFF208B6718
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r13,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L04
M01_L06:
       mov       rdx,7FFF208B6898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L14
M01_L07:
       mov       r12,[rbp-50]
       mov       rsi,[rbp-48]
       mov       ecx,[r15+1C]
       mov       edx,[r15+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L09
       mov       ecx,edx
       mov       rax,[r15+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L08
       mov       [rax+rcx*2+10],bx
       inc       edx
       mov       [r15+18],edx
       jmp       short M01_L09
M01_L08:
       movzx     edx,bx
       mov       rcx,r15
       call      qword ptr [7FFF201EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L09:
       mov       rcx,r15
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       byte ptr [rbp-70],0
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L11
M01_L10:
       lea       rcx,[rbp-80]
       mov       r8,r12
       call      qword ptr [7FFF208CCC48]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,189A43A0A4C
       mov       rax,[rcx+8]
       mov       r8d,[rcx+18]
       lea       r10d,[r8+1]
       cmp       [rax+8],r10d
       jb        short M01_L12
       movsxd    rdx,r8d
       mov       word ptr [rax+rdx*2+10],3A
       mov       [rcx+18],r10d
       jmp       short M01_L13
M01_L11:
       mov       rdx,7FFF208B67D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L10
M01_L12:
       mov       r8d,1
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       near ptr M01_L06
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M01_L06
M01_L14:
       lea       rcx,[rbp-80]
       mov       r8,rsi
       call      qword ptr [7FFF208CCC48]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L15:
       mov       rdx,r13
       lea       rcx,[rbp-68]
       call      qword ptr [7FFF20367978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L16
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFF208B68D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L17:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L29
       nop
       mov       rax,[rbp-98]
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
M01_L18:
       mov       r11d,[rsi+8]
       test      r11d,r11d
       jl        short M01_L22
       mov       edi,r11d
       jmp       near ptr M01_L00
M01_L19:
       mov       r13,[r15+18]
       mov       r12,[r13+18]
       lea       rdx,[rbp-88]
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF20605290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L25
M01_L20:
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       near ptr M01_L02
M01_L21:
       mov       rax,[r15+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       xor       edi,edi
       movzx     r14d,dil
       test      r14d,r14d
       jne       near ptr M01_L01
M01_L24:
       mov       rax,189A43A0008
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
M01_L25:
       cmp       qword ptr [r12+10],0
       jne       short M01_L26
       xor       edx,edx
       mov       [rbp-88],rdx
       jmp       short M01_L21
M01_L26:
       lea       rdx,[rbp-88]
       mov       rcx,r13
       call      qword ptr [7FFF20604DB0]
       test      eax,eax
       je        short M01_L21
       jmp       short M01_L20
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L27
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rdx,7FFF208B68D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L28:
       lea       rcx,[rbp-68]
       call      rax
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L29:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,149164055F8
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,7FFF20601350
       cmp       [rax+18],rcx
       jne       short M01_L30
       mov       rsi,[rbp-90]
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rsi+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L34
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF201EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L31
M01_L30:
       mov       rdx,[rbp-90]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rsi,[rbp-90]
       je        short M01_L34
M01_L31:
       cmp       qword ptr [r15+20],0
       jne       short M01_L32
       lea       rcx,[r15+20]
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L34
M01_L32:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L33
       mov       r15,[r15+18]
       mov       rcx,[r15+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF206052C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L34
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFF20604D80]
       jmp       short M01_L34
M01_L33:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L34:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1201
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFF208B7588]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-0A0],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      rsi,rsi
       je        near ptr M01_L23
       mov       r11,offset MT_System.String[]
       cmp       [rsi],r11
       je        near ptr M01_L18
       mov       rcx,rsi
       mov       r11,7FFF1FE31288
       call      qword ptr [r11]
       mov       edi,eax
M01_L00:
       test      edi,edi
       setg      dil
       movzx     edi,dil
       movzx     r14d,dil
       test      r14d,r14d
       je        near ptr M01_L24
M01_L01:
       mov       rcx,202A4003600
       mov       r15,[rcx]
       mov       rcx,[r15+20]
       mov       [rbp-88],rcx
       cmp       qword ptr [rbp-88],0
       je        near ptr M01_L19
       lea       rcx,[r15+20]
       mov       r8,[rbp-88]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       jne       near ptr M01_L19
M01_L02:
       mov       r15,[rbp-88]
M01_L03:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r15
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF1FF7EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+20]
       test      r13,r13
       je        short M01_L05
M01_L04:
       jmp       near ptr M01_L15
M01_L05:
       mov       rdx,7FFF208A6668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r13,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L04
M01_L06:
       mov       rdx,7FFF208A67E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L14
M01_L07:
       mov       r12,[rbp-50]
       mov       rsi,[rbp-48]
       mov       ecx,[r15+1C]
       mov       edx,[r15+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L09
       mov       ecx,edx
       mov       rax,[r15+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L08
       mov       [rax+rcx*2+10],bx
       inc       edx
       mov       [r15+18],edx
       jmp       short M01_L09
M01_L08:
       movzx     edx,bx
       mov       rcx,r15
       call      qword ptr [7FFF201DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L09:
       mov       rcx,r15
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       byte ptr [rbp-70],0
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L11
M01_L10:
       lea       rcx,[rbp-80]
       mov       r8,r12
       call      qword ptr [7FFF208B7F90]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,24335E50A4C
       mov       rax,[rcx+8]
       mov       r8d,[rcx+18]
       lea       r10d,[r8+1]
       cmp       [rax+8],r10d
       jb        short M01_L12
       movsxd    rdx,r8d
       mov       word ptr [rax+rdx*2+10],3A
       mov       [rcx+18],r10d
       jmp       short M01_L13
M01_L11:
       mov       rdx,7FFF208A6728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L10
M01_L12:
       mov       r8d,1
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       near ptr M01_L06
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M01_L06
M01_L14:
       lea       rcx,[rbp-80]
       mov       r8,rsi
       call      qword ptr [7FFF208B7F90]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L15:
       mov       rdx,r13
       lea       rcx,[rbp-68]
       call      qword ptr [7FFF20357978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L16
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFF208A6820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L17:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L29
       nop
       mov       rax,[rbp-98]
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
M01_L18:
       mov       r11d,[rsi+8]
       test      r11d,r11d
       jl        short M01_L22
       mov       edi,r11d
       jmp       near ptr M01_L00
M01_L19:
       mov       r13,[r15+18]
       mov       r12,[r13+18]
       lea       rdx,[rbp-88]
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L25
M01_L20:
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       near ptr M01_L02
M01_L21:
       mov       rax,[r15+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       xor       edi,edi
       movzx     r14d,dil
       test      r14d,r14d
       jne       near ptr M01_L01
M01_L24:
       mov       rax,24335E50008
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
M01_L25:
       cmp       qword ptr [r12+10],0
       jne       short M01_L26
       xor       edx,edx
       mov       [rbp-88],rdx
       jmp       short M01_L21
M01_L26:
       lea       rdx,[rbp-88]
       mov       rcx,r13
       call      qword ptr [7FFF205F4DB0]
       test      eax,eax
       je        short M01_L21
       jmp       short M01_L20
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L27
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rdx,7FFF208A6820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L28:
       lea       rcx,[rbp-68]
       call      rax
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L29:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       rcx,202A4003600
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,7FFF205F1350
       cmp       [rax+18],rcx
       jne       short M01_L30
       mov       rsi,[rbp-90]
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rsi+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L34
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF201DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L31
M01_L30:
       mov       rdx,[rbp-90]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rsi,[rbp-90]
       je        short M01_L34
M01_L31:
       cmp       qword ptr [r15+20],0
       jne       short M01_L32
       lea       rcx,[r15+20]
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L34
M01_L32:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L33
       mov       r15,[r15+18]
       mov       rcx,[r15+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F52C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L34
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFF205F4D80]
       jmp       short M01_L34
M01_L33:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L34:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1201
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r8,[rbx+1A0]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M00_L06
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       test      r8,r8
       je        short M00_L04
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M00_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L02
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L01:
       mov       [rsi+18],ebp
       jmp       short M00_L04
M00_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L01
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 287
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L03
       cmp       r8,40
       ja        short M01_L05
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       test      r8b,18
       je        short M01_L04
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L02
M01_L04:
       test      r8b,4
       je        short M01_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L05:
       cmp       r8,800
       ja        near ptr M01_L11
       jmp       short M01_L07
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L07:
       mov       r9,r8
       shr       r9,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L00
       jmp       near ptr M01_L01
M01_L09:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L10:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L11:
       jmp       qword ptr [7FFF20055B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 276
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2020CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF2015E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF2015E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2384E510008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r8,[rbx+1A0]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M00_L07
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       test      r8,r8
       je        short M00_L04
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M00_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L02
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L01:
       mov       [rsi+18],ebp
       jmp       short M00_L04
M00_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L06
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 283
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L03
       cmp       r8,40
       ja        short M01_L04
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L07
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       test      r8b,18
       je        short M01_L06
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L02
M01_L04:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       r9,r8
       shr       r9,6
M01_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L05
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L06:
       test      r8b,4
       je        short M01_L08
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF20025B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF2012E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF2012E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1EC04060008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r8,[rbx+1A0]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M00_L07
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       test      r8,r8
       je        short M00_L04
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M00_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L02
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L01:
       mov       [rsi+18],ebp
       jmp       short M00_L04
M00_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L06
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 283
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L07
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       r9,r8
       shr       r9,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L04
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L05:
       test      r8b,18
       je        short M01_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L02
M01_L06:
       test      r8b,4
       je        short M01_L08
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF20055B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2020CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF2015E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF2015E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,228FC170008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r8,[rbx+1A0]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M00_L07
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       test      r8,r8
       je        short M00_L04
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M00_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L02
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L01:
       mov       [rsi+18],ebp
       jmp       short M00_L04
M00_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L06
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 283
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L07
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       r9,r8
       shr       r9,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L04
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L05:
       test      r8b,18
       je        short M01_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L02
M01_L06:
       test      r8b,4
       je        short M01_L08
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF20055B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF2020CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF2015E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF2015E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20495EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2005D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,254811F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,[rbx+1A0]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L03
M00_L00:
       mov       rcx,[rbx+1A0]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L07
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        short M00_L02
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M00_L02
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M00_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L05
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L04
M00_L01:
       mov       [rsi+18],ebp
M00_L02:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [rbp+8],r8
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L01
M00_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L02
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 280
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,2763A5D0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       jbe       short M02_L05
       cmp       r8,40
       ja        short M02_L03
M02_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L07
M02_L01:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M02_L02:
       pop       rbx
       pop       rsi
       ret
M02_L03:
       cmp       r8,800
       ja        near ptr M02_L10
       mov       rax,r8
       shr       rax,6
M02_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M02_L04
       and       r8,3F
       cmp       r8,10
       ja        short M02_L00
       jmp       short M02_L01
M02_L05:
       test      r8b,18
       je        short M02_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
       jmp       short M02_L02
M02_L06:
       test      r8b,4
       je        short M02_L08
       mov       eax,[rdx]
       mov       [rcx],eax
       mov       eax,[rbx-4]
       mov       [rsi-4],eax
       jmp       short M02_L02
M02_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M02_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M02_L01
M02_L08:
       test      r8,r8
       je        near ptr M02_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L02
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       near ptr M02_L02
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L02
M02_L10:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF20045B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 276
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20485FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2004D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2014E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2014E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,[rbx+1A0]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L03
M00_L00:
       mov       rcx,[rbx+1A0]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L07
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        short M00_L02
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M00_L02
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M00_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L05
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L04
M00_L01:
       mov       [rsi+18],ebp
M00_L02:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [rbp+8],r8
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L01
M00_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L02
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 280
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,2AB74740008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       jne       near ptr M02_L06
       test      r8b,4
       jne       near ptr M02_L07
       test      r8,r8
       je        near ptr M02_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L05
M02_L00:
       cmp       r8,800
       ja        near ptr M02_L09
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L03
       jmp       short M02_L04
M02_L02:
       cmp       r8,40
       ja        short M02_L00
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L04
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L05:
       ret
M02_L06:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L05
M02_L07:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L05
M02_L08:
       cmp       rcx,rdx
       je        short M02_L05
M02_L09:
       jmp       qword ptr [7FFF20025B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 266
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20465FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2002D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2012E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2012E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,[rbx+1A0]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L03
M00_L00:
       mov       rcx,[rbx+1A0]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L07
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        short M00_L02
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M00_L02
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M00_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L05
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L04
M00_L01:
       mov       [rsi+18],ebp
M00_L02:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [rbp+8],r8
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L01
M00_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L02
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 280
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,23E5D4C0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L02
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L02
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M02_L04
       test      r8b,18
       jne       near ptr M02_L08
       test      r8b,4
       jne       near ptr M02_L09
       test      r8,r8
       je        near ptr M02_L07
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L07
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M02_L07
M02_L00:
       cmp       r8,800
       ja        short M02_L03
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L05
       jmp       short M02_L06
M02_L02:
       cmp       rcx,rdx
       je        short M02_L07
M02_L03:
       jmp       qword ptr [7FFF20035B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L04:
       cmp       r8,40
       ja        short M02_L00
M02_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L07:
       ret
M02_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L07
M02_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L07
; Total bytes of code 269
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201ECB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2013E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2013E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,[rbx+1A0]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L03
M00_L00:
       mov       rcx,[rbx+1A0]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L07
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        short M00_L02
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M00_L02
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M00_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L05
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L04
M00_L01:
       mov       [rsi+18],ebp
M00_L02:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [rbp+8],r8
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L01
M00_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L02
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 280
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M01_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L02
       cmp       [rdx+8],r8d
       jb        short M01_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,22A56330008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       jne       near ptr M02_L06
       test      r8b,4
       jne       near ptr M02_L07
       test      r8,r8
       je        near ptr M02_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L05
M02_L00:
       cmp       r8,800
       ja        near ptr M02_L09
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L03
       jmp       short M02_L04
M02_L02:
       cmp       r8,40
       ja        short M02_L00
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L04
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L05:
       ret
M02_L06:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L05
M02_L07:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L05
M02_L08:
       cmp       rcx,rdx
       je        short M02_L05
M02_L09:
       jmp       qword ptr [7FFF20035B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 266
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF201ECB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF1FE34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF20475FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2003D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFF2013E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFF2013E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+188]
       call      qword ptr [7FFF207D5848]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-30],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,199408055F8
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L18
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20625290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L20
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L19
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L23
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L21
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L22
       mov       edx,r14d
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       mov       [rbp-38],r15
       jmp       short M01_L05
M01_L04:
       mov       rax,1D9D26D0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdx,1D9D26E52C4
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [r15+18],r8d
M01_L06:
       xor       edi,edi
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       near ptr M01_L13
M01_L07:
       mov       ecx,edi
       lea       rcx,[rbx+rcx+10]
       mov       r8,19940800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1D9D26E52D8
       call      qword ptr [7FFF20134810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M01_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L11
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L12
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L12
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       add       edi,1
       jo        short M01_L15
       cmp       r14d,edi
       jg        near ptr M01_L07
       jmp       short M01_L13
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       [r15+18],esi
       jmp       short M01_L10
M01_L13:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L16
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
M01_L14:
       mov       rcx,r15
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L17
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFF2020C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L14
M01_L17:
       mov       rcx,rsp
       call      M01_L25
       nop
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L24
       jmp       near ptr M01_L00
M01_L19:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFF20624DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L20:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L24
M01_L21:
       mov       ecx,13C20
       mov       rdx,7FFF1FE54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF207DEBF8]
       int       3
M01_L22:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L23:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L24:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L25:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,199408055F8
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L26
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rbx+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L30
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFF2020C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L27
M01_L26:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L30
M01_L27:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L28
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L30
M01_L28:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L29
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF20624D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L30
M01_L29:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L30:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 962
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+188]
       call      qword ptr [7FFF207A5B48]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-30],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,24A868055F8
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L18
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L20
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L19
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L23
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L21
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L22
       mov       edx,r14d
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       mov       [rbp-38],r15
       jmp       short M01_L05
M01_L04:
       mov       rax,28B18880008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdx,28B188952C4
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [r15+18],r8d
M01_L06:
       xor       edi,edi
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       near ptr M01_L13
M01_L07:
       mov       ecx,edi
       lea       rcx,[rbx+rcx+10]
       mov       r8,24A86800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,28B188952D8
       call      qword ptr [7FFF20104810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M01_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L11
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L12
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L12
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       add       edi,1
       jo        short M01_L15
       cmp       r14d,edi
       jg        near ptr M01_L07
       jmp       short M01_L13
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       [r15+18],esi
       jmp       short M01_L10
M01_L13:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L16
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
M01_L14:
       mov       rcx,r15
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L17
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFF201DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L14
M01_L17:
       mov       rcx,rsp
       call      M01_L25
       nop
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L24
       jmp       near ptr M01_L00
M01_L19:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFF205F4DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L20:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L24
M01_L21:
       mov       ecx,13C20
       mov       rdx,7FFF1FE24000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFF207AF240]
       int       3
M01_L22:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L23:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L24:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L25:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,24A868055F8
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L26
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rbx+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L30
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFF201DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L27
M01_L26:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L30
M01_L27:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L28
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L30
M01_L28:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L29
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L30
M01_L29:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L30:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 962
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+188]
       call      qword ptr [7FFF207B5848]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-30],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,1C1750055F8
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L18
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20605290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L20
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L19
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L22
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       mov       ecx,r14d
       mov       rdx,20207009CB0
       call      qword ptr [7FFF202E40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L21
       mov       edx,r14d
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       mov       [rbp-38],r15
       jmp       short M01_L05
M01_L04:
       mov       rax,20207000008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdx,202070152C4
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [r15+18],r8d
M01_L06:
       xor       edi,edi
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       near ptr M01_L13
M01_L07:
       mov       ecx,edi
       lea       rcx,[rbx+rcx+10]
       mov       r8,1C175000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,202070152D8
       call      qword ptr [7FFF20114810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M01_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L11
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L12
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L12
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       add       edi,1
       jo        short M01_L15
       cmp       r14d,edi
       jg        near ptr M01_L07
       jmp       short M01_L13
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       [r15+18],esi
       jmp       short M01_L10
M01_L13:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L16
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
M01_L14:
       mov       rcx,r15
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L17
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFF201EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L14
M01_L17:
       mov       rcx,rsp
       call      M01_L24
       nop
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L23
       jmp       near ptr M01_L00
M01_L19:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFF20604DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L20:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L23
M01_L21:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L22:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L23:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L24:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,1C1750055F8
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L25
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rbx+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L29
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFF201EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L26
M01_L25:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L29
M01_L26:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L27
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L29
M01_L27:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L28
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L29
M01_L28:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L29:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 939
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+188]
       call      qword ptr [7FFF207E5B48]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-30],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L04
       mov       rdx,14D840055F8
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L18
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20635290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L20
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L19
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L22
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       mov       ecx,r14d
       mov       rdx,18E15F29CB0
       call      qword ptr [7FFF203140D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L21
       mov       edx,r14d
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       mov       [rbp-38],r15
       jmp       short M01_L05
M01_L04:
       mov       rax,18E15F20008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdx,18E15F352C4
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [r15+18],r8d
M01_L06:
       xor       edi,edi
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       near ptr M01_L13
M01_L07:
       mov       ecx,edi
       lea       rcx,[rbx+rcx+10]
       mov       r8,14D84000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,18E15F352D8
       call      qword ptr [7FFF20144810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M01_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L11
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L12
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L12
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFF2021CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFF2021CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       add       edi,1
       jo        short M01_L15
       cmp       r14d,edi
       jg        near ptr M01_L07
       jmp       short M01_L13
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       [r15+18],esi
       jmp       short M01_L10
M01_L13:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L16
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
M01_L14:
       mov       rcx,r15
       call      qword ptr [7FFF2020B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L17
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFF2021C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L14
M01_L17:
       mov       rcx,rsp
       call      M01_L24
       nop
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L23
       jmp       near ptr M01_L00
M01_L19:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFF20634DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L20:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L23
M01_L21:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L22:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L23:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L24:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,14D840055F8
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L25
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rbx+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L29
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFF2021C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L26
M01_L25:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L29
M01_L26:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L27
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L29
M01_L27:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L28
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF20634D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L29
M01_L28:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L29:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 939
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+188]
       call      qword ptr [7FFF208C7270]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L15
       mov       rcx,2E8200055F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L20
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L20
M01_L00:
       mov       r15,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],r15
       mov       rdx,328B1CC5314
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L06
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [r15+18],r8d
M01_L02:
       xor       edi,edi
       mov       r13d,[rbx+8]
       test      r13d,r13d
       jle       near ptr M01_L10
M01_L03:
       mov       ecx,edi
       lea       rcx,[rbx+rcx+10]
       mov       r8,2E820000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,328B1CC5328
       call      qword ptr [7FFF20124810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        short M01_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L05
M01_L04:
       mov       [r15+18],r12d
       jmp       short M01_L09
M01_L05:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L04
M01_L06:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L02
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L08:
       mov       rcx,r15
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       add       edi,1
       jo        short M01_L12
       cmp       r13d,edi
       jg        near ptr M01_L03
M01_L10:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L13
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
M01_L11:
       mov       rcx,r15
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L14
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFF201FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L11
M01_L14:
       mov       rcx,rsp
       call      M01_L22
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       mov       rax,328B1CB0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L16:
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L17:
       mov       r14,[rsi+8]
       mov       rcx,7FFF20611338
       cmp       [r14+18],rcx
       je        short M01_L18
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       short M01_L19
M01_L18:
       mov       rdi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       edx,[rdi+8]
       mov       rcx,r15
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFF201FC0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
M01_L19:
       jmp       near ptr M01_L01
M01_L20:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20615290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M01_L21
       cmp       qword ptr [r14+10],0
       je        short M01_L16
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFF20614DB0]
       test      eax,eax
       je        near ptr M01_L17
M01_L21:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,2E8200055F8
       mov       r15,[rcx]
       mov       rsi,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L23
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L27
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L24
M01_L23:
       mov       rbx,[rbp-48]
       mov       rdx,rbx
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L27
M01_L24:
       cmp       qword ptr [r15+20],0
       jne       short M01_L25
       lea       rcx,[r15+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L27
M01_L25:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L26
       mov       r14,[r15+18]
       mov       rcx,[r14+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF206152C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L27
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFF20614D80]
       jmp       short M01_L27
M01_L26:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L27:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 879
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+188]
       call      qword ptr [7FFF208CC198]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L15
       mov       rcx,2A8458055F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L17
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L17
M01_L00:
       mov       rsi,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rsi
       mov       rdx,2E8D364533C
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L06
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rsi+18],r8d
M01_L02:
       xor       r15d,r15d
       mov       r13d,[rbx+8]
       test      r13d,r13d
       jle       near ptr M01_L10
M01_L03:
       mov       ecx,r15d
       lea       rcx,[rbx+rcx+10]
       mov       r8,2A845800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2E8D3645350
       call      qword ptr [7FFF20114810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        short M01_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L05
M01_L04:
       mov       [rsi+18],r12d
       jmp       short M01_L09
M01_L05:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L04
M01_L06:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L02
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L08:
       mov       rcx,rsi
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       add       r15d,1
       jo        short M01_L12
       cmp       r13d,r15d
       jg        near ptr M01_L03
M01_L10:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L13
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M01_L11:
       mov       rcx,rsi
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L14
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFF201EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L11
M01_L14:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       mov       rax,2E8D3630008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L16:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L17:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20605290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L19
       jmp       short M01_L16
M01_L18:
       mov       rdx,[rsi+8]
       mov       rcx,[rdx+8]
       call      qword ptr [rdx+18]
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L19:
       cmp       qword ptr [r14+10],0
       jne       short M01_L20
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L18
M01_L20:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFF20604DB0]
       test      eax,eax
       je        short M01_L18
       jmp       short M01_L16
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,2A8458055F8
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,7FFF20601350
       cmp       [rax+18],rcx
       jne       short M01_L22
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L26
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L23
M01_L22:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L26
M01_L23:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L24
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L26
M01_L24:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L25
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF206052C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L26
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF20604D80]
       jmp       short M01_L26
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L26:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 817
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+188]
       call      qword ptr [7FFF208D75D0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L15
       mov       rcx,2614C4055F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L17
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L17
M01_L00:
       mov       rsi,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rsi
       mov       rdx,2A1DE0B533C
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L06
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rsi+18],r8d
M01_L02:
       xor       r15d,r15d
       mov       r13d,[rbx+8]
       test      r13d,r13d
       jle       near ptr M01_L10
M01_L03:
       mov       ecx,r15d
       lea       rcx,[rbx+rcx+10]
       mov       r8,2614C400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2A1DE0B5350
       call      qword ptr [7FFF20124810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        short M01_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L05
M01_L04:
       mov       [rsi+18],r12d
       jmp       short M01_L09
M01_L05:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L04
M01_L06:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L02
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L08:
       mov       rcx,rsi
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       add       r15d,1
       jo        short M01_L12
       cmp       r13d,r15d
       jg        near ptr M01_L03
M01_L10:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L13
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M01_L11:
       mov       rcx,rsi
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L14
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFF201FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L11
M01_L14:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       mov       rax,2A1DE0A0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L16:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L17:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20615290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L19
       jmp       short M01_L16
M01_L18:
       mov       rdx,[rsi+8]
       mov       rcx,[rdx+8]
       call      qword ptr [rdx+18]
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L19:
       cmp       qword ptr [r14+10],0
       jne       short M01_L20
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L18
M01_L20:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFF20614DB0]
       test      eax,eax
       je        short M01_L18
       jmp       short M01_L16
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,2614C4055F8
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,7FFF20611350
       cmp       [rax+18],rcx
       jne       short M01_L22
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L26
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L23
M01_L22:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L26
M01_L23:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L24
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L26
M01_L24:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L25
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF206152C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L26
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF20614D80]
       jmp       short M01_L26
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L26:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 817
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+188]
       call      qword ptr [7FFF208B75D0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L15
       mov       rcx,263A64055F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L17
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L17
M01_L00:
       mov       rsi,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rsi
       mov       rdx,2A43846533C
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L06
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rsi+18],r8d
M01_L02:
       xor       r15d,r15d
       mov       r13d,[rbx+8]
       test      r13d,r13d
       jle       near ptr M01_L10
M01_L03:
       mov       ecx,r15d
       lea       rcx,[rbx+rcx+10]
       mov       r8,263A6400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2A438465350
       call      qword ptr [7FFF20104810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        short M01_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L05
M01_L04:
       mov       [rsi+18],r12d
       jmp       short M01_L09
M01_L05:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L04
M01_L06:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L02
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L08:
       mov       rcx,rsi
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       add       r15d,1
       jo        short M01_L12
       cmp       r13d,r15d
       jg        near ptr M01_L03
M01_L10:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L13
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M01_L11:
       mov       rcx,rsi
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L14
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFF201DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L11
M01_L14:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       mov       rax,2A438450008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L16:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L17:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L19
       jmp       short M01_L16
M01_L18:
       mov       rdx,[rsi+8]
       mov       rcx,[rdx+8]
       call      qword ptr [rdx+18]
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L19:
       cmp       qword ptr [r14+10],0
       jne       short M01_L20
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L18
M01_L20:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFF205F4DB0]
       test      eax,eax
       je        short M01_L18
       jmp       short M01_L16
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,263A64055F8
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,7FFF205F1350
       cmp       [rax+18],rcx
       jne       short M01_L22
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L26
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L23
M01_L22:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L26
M01_L23:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L24
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L26
M01_L24:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L25
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F52C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L26
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF205F4D80]
       jmp       short M01_L26
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L26:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 817
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+1A0]
       xor       ecx,ecx
       call      qword ptr [7FFF207B5860]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       esi,ecx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L12
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L12
       mov       rcx,2CDEA4055F8
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L13
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L13
M01_L00:
       mov       r15,[rbp-40]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],r15
       xor       r13d,r13d
       test      edi,edi
       jle       short M01_L05
M01_L02:
       mov       r8d,r13d
       mov       rdx,[rbx+r8*8+10]
       test      sil,sil
       jne       near ptr M01_L08
       cmp       [r15],r15b
       test      rdx,rdx
       je        short M01_L04
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L04
       mov       rcx,[r15+8]
       mov       edx,[r15+18]
       lea       r12d,[rdx+r8]
       cmp       r12d,[rcx+8]
       ja        short M01_L07
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M01_L10
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       [r15+18],r12d
M01_L04:
       add       r13d,1
       jo        short M01_L09
       cmp       edi,r13d
       jg        short M01_L02
M01_L05:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L11
M01_L06:
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M01_L03
M01_L07:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L04
M01_L08:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201EC330]
       jmp       short M01_L04
M01_L09:
       call      CORINFO_HELP_OVERFLOW
M01_L10:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L06
       jmp       short M01_L03
M01_L11:
       mov       rcx,rsp
       call      M01_L15
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rax,30E78290008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L14
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L14:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L15:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,2CDEA4055F8
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L16
       mov       r14,[rbp-48]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L20
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFF201EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L17
M01_L16:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-48]
       je        short M01_L20
M01_L17:
       cmp       qword ptr [r15+20],0
       jne       short M01_L18
       lea       rcx,[r15+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L20
M01_L18:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L19
       mov       rcx,[r15+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L20
M01_L19:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L20:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 635
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+1A0]
       xor       ecx,ecx
       call      qword ptr [7FFF207D5860]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       esi,ecx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L12
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L12
       mov       rcx,1A1D34055F8
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L13
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L13
M01_L00:
       mov       r15,[rbp-40]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],r15
       xor       r13d,r13d
       test      edi,edi
       jle       near ptr M01_L09
M01_L02:
       mov       r8d,r13d
       mov       rdx,[rbx+r8*8+10]
       test      sil,sil
       jne       short M01_L06
       cmp       [r15],r15b
       test      rdx,rdx
       je        short M01_L08
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[r15+8]
       mov       edx,[r15+18]
       lea       r12d,[rdx+r8]
       cmp       r12d,[rcx+8]
       ja        short M01_L05
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M01_L07
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       [r15+18],r12d
       jmp       short M01_L08
M01_L04:
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M01_L03
M01_L05:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L06:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF2020C330]
       jmp       short M01_L08
M01_L07:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L04
       jmp       short M01_L03
M01_L08:
       add       r13d,1
       jo        short M01_L10
       cmp       edi,r13d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L11
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L11:
       mov       rcx,rsp
       call      M01_L15
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rax,1E265340008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20624D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L14
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L14:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L15:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,1A1D34055F8
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L16
       mov       r14,[rbp-48]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L20
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFF2020C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L17
M01_L16:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-48]
       je        short M01_L20
M01_L17:
       cmp       qword ptr [r15+20],0
       jne       short M01_L18
       lea       rcx,[r15+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L20
M01_L18:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L19
       mov       rcx,[r15+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20624D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L20
M01_L19:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L20:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 642
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+1A0]
       xor       ecx,ecx
       call      qword ptr [7FFF207D5B60]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       esi,ecx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L12
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L12
       mov       rcx,1ED6FC055F8
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L13
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L13
M01_L00:
       mov       r15,[rbp-40]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],r15
       xor       r13d,r13d
       test      edi,edi
       jle       near ptr M01_L09
M01_L02:
       mov       r8d,r13d
       mov       rdx,[rbx+r8*8+10]
       test      sil,sil
       jne       short M01_L06
       cmp       [r15],r15b
       test      rdx,rdx
       je        short M01_L08
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[r15+8]
       mov       edx,[r15+18]
       lea       r12d,[rdx+r8]
       cmp       r12d,[rcx+8]
       ja        short M01_L05
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M01_L07
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       [r15+18],r12d
       jmp       short M01_L08
M01_L04:
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M01_L03
M01_L05:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L06:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF2020C330]
       jmp       short M01_L08
M01_L07:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L04
       jmp       short M01_L03
M01_L08:
       add       r13d,1
       jo        short M01_L10
       cmp       edi,r13d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L11
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L11:
       mov       rcx,rsp
       call      M01_L15
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rax,22E01A10008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20624D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L14
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L14:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L15:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,1ED6FC055F8
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L16
       mov       r14,[rbp-48]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L20
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFF2020C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L17
M01_L16:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-48]
       je        short M01_L20
M01_L17:
       cmp       qword ptr [r15+20],0
       jne       short M01_L18
       lea       rcx,[r15+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L20
M01_L18:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L19
       mov       rcx,[r15+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20624D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L20
M01_L19:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L20:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 642
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+1A0]
       xor       ecx,ecx
       call      qword ptr [7FFF207DC1B0]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       esi,ecx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L11
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L11
       mov       rcx,22112803600
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M01_L12
       lea       rcx,[r14+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       jne       near ptr M01_L12
M01_L00:
       mov       r15,[rbp-38]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-38],r8
       mov       [rbp-40],r15
       xor       r13d,r13d
       test      edi,edi
       jle       near ptr M01_L06
M01_L02:
       mov       r8d,r13d
       mov       rdx,[rbx+r8*8+10]
       test      sil,sil
       jne       near ptr M01_L09
       cmp       [r15],r15b
       test      rdx,rdx
       je        short M01_L05
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L05
       mov       rcx,[r15+8]
       mov       edx,[r15+18]
       lea       r14d,[rdx+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L08
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M01_L04
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFF20035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       [r15+18],r14d
       jmp       short M01_L05
M01_L04:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M01_L03
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       short M01_L03
M01_L05:
       add       r13d,1
       jo        short M01_L07
       cmp       edi,r13d
       jg        short M01_L02
M01_L06:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201DB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M01_L10
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF201ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L05
M01_L09:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201EC330]
       jmp       short M01_L05
M01_L10:
       mov       rcx,rsp
       call      M01_L14
       nop
       mov       rax,[rbp-48]
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
       mov       rax,261A4570008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L13
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L13:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L14:
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
       mov       rcx,22112803600
       mov       r14,[rcx]
       mov       r15,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L15
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L19
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L16
M01_L15:
       mov       rdx,[rbp-40]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       rbx,[rbp-40]
       je        short M01_L19
M01_L16:
       cmp       qword ptr [r14+20],0
       jne       short M01_L17
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L19
M01_L17:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L18
       mov       rcx,[r14+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF20604D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L19
M01_L18:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L19:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 625
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+1A0]
       xor       ecx,ecx
       call      qword ptr [7FFF20825440]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       esi,ecx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L11
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L11
       mov       rcx,1310E0055F8
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M01_L12
       lea       rcx,[r14+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       jne       near ptr M01_L12
M01_L00:
       mov       r15,[rbp-38]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-38],r8
       mov       [rbp-40],r15
       xor       r13d,r13d
       test      edi,edi
       jle       near ptr M01_L06
M01_L02:
       mov       r8d,r13d
       mov       rdx,[rbx+r8*8+10]
       test      sil,sil
       jne       near ptr M01_L09
       cmp       [r15],r15b
       test      rdx,rdx
       je        short M01_L05
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L05
       mov       rcx,[r15+8]
       mov       edx,[r15+18]
       lea       r14d,[rdx+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L08
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M01_L04
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       [r15+18],r14d
       jmp       short M01_L05
M01_L04:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M01_L03
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       short M01_L03
M01_L05:
       add       r13d,1
       jo        short M01_L07
       cmp       edi,r13d
       jg        short M01_L02
M01_L06:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M01_L10
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L05
M01_L09:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF2020C330]
       jmp       short M01_L05
M01_L10:
       mov       rcx,rsp
       call      M01_L14
       nop
       mov       rax,[rbp-48]
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
       mov       rax,1719FCF0008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20624D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L13
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L13:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L14:
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
       mov       rcx,1310E0055F8
       mov       r14,[rcx]
       mov       r15,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L15
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L19
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF2020C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L16
M01_L15:
       mov       rdx,[rbp-40]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       rbx,[rbp-40]
       je        short M01_L19
M01_L16:
       cmp       qword ptr [r14+20],0
       jne       short M01_L17
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L19
M01_L17:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L18
       mov       rcx,[r14+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF20624D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L19
M01_L18:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L19:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 625
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+1A0]
       xor       ecx,ecx
       call      qword ptr [7FFF208B7E28]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       esi,ecx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L14
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L14
       mov       rcx,1E97C8055F8
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L11
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L11
M01_L00:
       mov       r14,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],r14
       xor       r12d,r12d
       mov       edi,[rbx+8]
       test      edi,edi
       jle       near ptr M01_L09
M01_L02:
       mov       ecx,r12d
       mov       rdx,[rbx+rcx*8+10]
       test      sil,sil
       jne       short M01_L07
       cmp       [r14],r14b
       test      rdx,rdx
       je        short M01_L08
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[r14+8]
       mov       edx,[r14+18]
       lea       r15d,[rdx+r8]
       cmp       r15d,[rcx+8]
       ja        short M01_L06
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jg        short M01_L05
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L04
M01_L03:
       mov       [r14+18],r15d
       jmp       short M01_L08
M01_L04:
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       short M01_L03
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L06:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF201DC330]
M01_L08:
       add       r12d,1
       jo        short M01_L10
       cmp       edi,r12d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L13
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L11:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-40]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L15
M01_L12:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,rsp
       call      M01_L18
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rax,22A0E590008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       cmp       qword ptr [r13+10],0
       jne       short M01_L16
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L17
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,r15
       call      qword ptr [7FFF205F4DB0]
       test      eax,eax
       jne       short M01_L12
M01_L17:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L18:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,1E97C8055F8
       mov       r14,[rcx]
       mov       rax,[r14+10]
       mov       rcx,7FFF205F1350
       cmp       [rax+18],rcx
       jne       short M01_L19
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L23
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L20
M01_L19:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L23
M01_L20:
       cmp       qword ptr [r14+20],0
       jne       short M01_L21
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L23
M01_L21:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L22
       mov       r14,[r14+18]
       mov       rcx,[r14+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F52C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L23
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFF205F4D80]
       jmp       short M01_L23
M01_L22:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L23:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 706
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+1A0]
       xor       ecx,ecx
       call      qword ptr [7FFF208E74F8]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       esi,ecx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L14
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L14
       mov       rcx,16B55403600
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L11
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L11
M01_L00:
       mov       r14,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],r14
       xor       r12d,r12d
       mov       edi,[rbx+8]
       test      edi,edi
       jle       near ptr M01_L09
M01_L02:
       mov       ecx,r12d
       mov       rdx,[rbx+rcx*8+10]
       test      sil,sil
       jne       short M01_L07
       cmp       [r14],r14b
       test      rdx,rdx
       je        short M01_L08
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[r14+8]
       mov       edx,[r14+18]
       lea       r15d,[rdx+r8]
       cmp       r15d,[rcx+8]
       ja        short M01_L06
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jg        short M01_L05
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L04
M01_L03:
       mov       [r14+18],r15d
       jmp       short M01_L08
M01_L04:
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       short M01_L03
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L06:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF2020C330]
M01_L08:
       add       r12d,1
       jo        short M01_L10
       cmp       edi,r12d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L13
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L11:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-40]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFF20625290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L15
M01_L12:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,rsp
       call      M01_L18
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rax,1ABE72B0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       cmp       qword ptr [r13+10],0
       jne       short M01_L16
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L17
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,r15
       call      qword ptr [7FFF20624DB0]
       test      eax,eax
       jne       short M01_L12
M01_L17:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L18:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,16B55403600
       mov       r14,[rcx]
       mov       rax,[r14+10]
       mov       rcx,7FFF20621350
       cmp       [rax+18],rcx
       jne       short M01_L19
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L23
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF2020C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L20
M01_L19:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L23
M01_L20:
       cmp       qword ptr [r14+20],0
       jne       short M01_L21
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L23
M01_L21:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L22
       mov       r14,[r14+18]
       mov       rcx,[r14+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF206252C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L23
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFF20624D80]
       jmp       short M01_L23
M01_L22:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L23:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 706
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+1A0]
       xor       ecx,ecx
       call      qword ptr [7FFF208E75E8]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       esi,ecx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L14
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L14
       mov       rcx,1C69B003600
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L11
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L11
M01_L00:
       mov       r14,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],r14
       xor       r12d,r12d
       mov       edi,[rbx+8]
       test      edi,edi
       jle       near ptr M01_L09
M01_L02:
       mov       ecx,r12d
       mov       rdx,[rbx+rcx*8+10]
       test      sil,sil
       jne       short M01_L07
       cmp       [r14],r14b
       test      rdx,rdx
       je        short M01_L08
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[r14+8]
       mov       edx,[r14+18]
       lea       r15d,[rdx+r8]
       cmp       r15d,[rcx+8]
       ja        short M01_L06
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jg        short M01_L05
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L04
M01_L03:
       mov       [r14+18],r15d
       jmp       short M01_L08
M01_L04:
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       short M01_L03
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L06:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF2020C330]
M01_L08:
       add       r12d,1
       jo        short M01_L10
       cmp       edi,r12d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L13
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L11:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-40]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFF20625290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L15
M01_L12:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,rsp
       call      M01_L18
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rax,2072D1B0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       cmp       qword ptr [r13+10],0
       jne       short M01_L16
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L17
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,r15
       call      qword ptr [7FFF20624DB0]
       test      eax,eax
       jne       short M01_L12
M01_L17:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L18:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,1C69B003600
       mov       r14,[rcx]
       mov       rax,[r14+10]
       mov       rcx,7FFF20621350
       cmp       [rax+18],rcx
       jne       short M01_L19
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L23
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF2020C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L20
M01_L19:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L23
M01_L20:
       cmp       qword ptr [r14+20],0
       jne       short M01_L21
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L23
M01_L21:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L22
       mov       r14,[r14+18]
       mov       rcx,[r14+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF206252C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L23
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFF20624D80]
       jmp       short M01_L23
M01_L22:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L23:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 706
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rbx,rbx
       je        short M00_L00
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFF207A5BA8]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFF1FF741F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       mov       r8,[rsi+1A0]
       cmp       dword ptr [r8+8],0
       jle       short M01_L03
M01_L00:
       mov       r8,[rsi+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M01_L06
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       cmp       [rbx],bl
       test      r8,r8
       je        short M01_L02
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L02
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M01_L05
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L04
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       [rbx+18],ebp
M01_L02:
       inc       edi
       mov       rax,[rsi+1A0]
       cmp       [rax+8],edi
       jg        short M01_L00
M01_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L04:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L01
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 182
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-28],rax
       mov       [rbp-40],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L10
       mov       rcx,2C5824055F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-28],0
       je        near ptr M02_L11
       lea       rcx,[rsi+20]
       mov       r8,[rbp-28]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-28]
       jne       near ptr M02_L11
M02_L00:
       mov       rdi,[rbp-28]
M02_L01:
       xor       r8d,r8d
       mov       [rbp-28],r8
       mov       [rbp-30],rdi
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       cmp       [rbx+18],r8
       jne       near ptr M02_L08
       mov       rsi,[rbx+8]
       xor       ebx,ebx
       mov       r8,[rsi+1A0]
       cmp       dword ptr [r8+8],0
       jle       near ptr M02_L09
M02_L02:
       mov       r8,[rsi+1A0]
       cmp       ebx,[r8+8]
       jae       short M02_L05
       mov       ecx,ebx
       mov       r8,[r8+rcx*8+10]
       cmp       [rdi],dil
       test      r8,r8
       je        short M02_L04
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M02_L04
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M02_L07
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M02_L06
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       [rdi+18],r14d
M02_L04:
       inc       ebx
       mov       rcx,[rsi+1A0]
       cmp       [rcx+8],ebx
       jg        short M02_L02
       jmp       short M02_L09
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L06:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M02_L03
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L03
M02_L07:
       mov       rcx,rdi
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L04
M02_L08:
       mov       rdx,rdi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
M02_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-38],rax
       mov       rcx,rsp
       call      M02_L13
       nop
       mov       rax,[rbp-38]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L10:
       mov       rax,306141C0008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L11:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L12
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M02_L00
M02_L12:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L13:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,2C5824055F8
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M02_L14
       mov       rdi,[rbp-30]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L18
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFF201DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L15
M02_L14:
       mov       rdi,[rbp-30]
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M02_L18
M02_L15:
       cmp       qword ptr [rbx+20],0
       jne       short M02_L16
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L18
M02_L16:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M02_L17
       mov       rcx,[rbx+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L18
M02_L17:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M02_L18:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 613
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rbx,rbx
       je        short M00_L00
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFF207C58A8]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFF1FF941F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       mov       r8,[rsi+1A0]
       cmp       dword ptr [r8+8],0
       jle       short M01_L03
M01_L00:
       mov       r8,[rsi+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M01_L06
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       cmp       [rbx],bl
       test      r8,r8
       je        short M01_L02
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L02
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M01_L05
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L04
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       [rbx+18],ebp
M01_L02:
       inc       edi
       mov       rcx,[rsi+1A0]
       cmp       [rcx+8],edi
       jg        short M01_L00
M01_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L04:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L01
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L11
       mov       rcx,236AD0055F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M02_L12
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M02_L12
M02_L00:
       mov       rdi,[rbp-40]
M02_L01:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],rdi
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       cmp       [rbx+18],r8
       jne       near ptr M02_L09
       mov       r14,[rbx+8]
       xor       r15d,r15d
       mov       r8,[r14+1A0]
       cmp       dword ptr [r8+8],0
       jle       near ptr M02_L10
M02_L02:
       mov       r8,[r14+1A0]
       cmp       r15d,[r8+8]
       jae       short M02_L05
       mov       ecx,r15d
       mov       r8,[r8+rcx*8+10]
       cmp       [rdi],dil
       test      r8,r8
       je        short M02_L04
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M02_L04
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        short M02_L07
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M02_L08
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       [rdi+18],r13d
M02_L04:
       inc       r15d
       mov       rcx,[r14+1A0]
       cmp       [rcx+8],r15d
       jg        short M02_L02
       jmp       short M02_L10
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L06:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M02_L03
M02_L07:
       mov       rcx,rdi
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L04
M02_L08:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M02_L06
       jmp       short M02_L03
M02_L09:
       mov       rdx,rdi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
M02_L10:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M02_L14
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rax,2773F140008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L12:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20614D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L13
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M02_L00
M02_L13:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L14:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,236AD0055F8
       mov       rdi,[rcx]
       mov       r12,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M02_L15
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L19
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L16
M02_L15:
       mov       rdx,[rbp-48]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M02_L19
M02_L16:
       cmp       qword ptr [rdi+20],0
       jne       short M02_L17
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L19
M02_L17:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M02_L18
       mov       rcx,[rdi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF20614D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L19
M02_L18:
       add       rdi,2C
       lock dec  dword ptr [rdi]
M02_L19:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 659
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rbx,rbx
       je        short M00_L00
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFF207A5BA8]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFF1FF741F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       mov       r8,[rsi+1A0]
       cmp       dword ptr [r8+8],0
       jle       short M01_L04
M01_L00:
       mov       r8,[rsi+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M01_L07
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       cmp       [rbx],bl
       test      r8,r8
       je        short M01_L03
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M01_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L02
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       [rbx+18],ebp
       jmp       short M01_L03
M01_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L05
       jmp       short M01_L01
M01_L03:
       inc       edi
       mov       rcx,[rsi+1A0]
       cmp       [rcx+8],edi
       jg        short M01_L00
M01_L04:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M01_L01
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L11
       mov       rcx,2B5FDC055F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M02_L12
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M02_L12
M02_L00:
       mov       rdi,[rbp-40]
M02_L01:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],rdi
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       cmp       [rbx+18],r8
       jne       near ptr M02_L09
       mov       r14,[rbx+8]
       xor       r15d,r15d
       mov       r8,[r14+1A0]
       cmp       dword ptr [r8+8],0
       jle       near ptr M02_L10
M02_L02:
       mov       r8,[r14+1A0]
       cmp       r15d,[r8+8]
       jae       short M02_L04
       mov       ecx,r15d
       mov       r8,[r8+rcx*8+10]
       cmp       [rdi],dil
       test      r8,r8
       je        short M02_L08
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M02_L08
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        short M02_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M02_L07
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       [rdi+18],r13d
       jmp       short M02_L08
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L05:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M02_L03
M02_L06:
       mov       rcx,rdi
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L08
M02_L07:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M02_L05
       jmp       short M02_L03
M02_L08:
       inc       r15d
       mov       rcx,[r14+1A0]
       cmp       [rcx+8],r15d
       jg        near ptr M02_L02
       jmp       short M02_L10
M02_L09:
       mov       rdx,rdi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
M02_L10:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M02_L14
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rax,2F68F920008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L12:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L13
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M02_L00
M02_L13:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L14:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,2B5FDC055F8
       mov       rdi,[rcx]
       mov       r12,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M02_L15
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L19
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF201DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L16
M02_L15:
       mov       rdx,[rbp-48]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M02_L19
M02_L16:
       cmp       qword ptr [rdi+20],0
       jne       short M02_L17
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L19
M02_L17:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M02_L18
       mov       rcx,[rdi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L19
M02_L18:
       add       rdi,2C
       lock dec  dword ptr [rdi]
M02_L19:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 665
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rbx,rbx
       je        short M00_L00
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFF207E6880]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFF1FFA41F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       mov       r8,[rsi+1A0]
       cmp       dword ptr [r8+8],0
       jle       short M01_L03
M01_L00:
       mov       r8,[rsi+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M01_L06
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       cmp       [rbx],bl
       test      r8,r8
       je        short M01_L02
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L02
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M01_L05
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L04
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       [rbx+18],ebp
M01_L02:
       inc       edi
       mov       rcx,[rsi+1A0]
       cmp       [rcx+8],edi
       jg        short M01_L00
M01_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L04:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L01
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L10
       mov       rcx,181550055F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M02_L11
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M02_L11
M02_L00:
       mov       rdi,[rbp-40]
M02_L01:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],rdi
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       cmp       [rbx+18],r8
       jne       near ptr M02_L08
       mov       r14,[rbx+8]
       xor       r15d,r15d
       mov       r8,[r14+1A0]
       cmp       dword ptr [r8+8],0
       jle       near ptr M02_L09
M02_L02:
       mov       r8,[r14+1A0]
       cmp       r15d,[r8+8]
       jae       short M02_L04
       mov       ecx,r15d
       mov       r8,[r8+rcx*8+10]
       cmp       [rdi],dil
       test      r8,r8
       je        short M02_L07
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M02_L07
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        short M02_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M02_L05
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       [rdi+18],r13d
       jmp       short M02_L07
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L05:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M02_L03
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M02_L03
M02_L06:
       mov       rcx,rdi
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L07:
       inc       r15d
       mov       rcx,[r14+1A0]
       cmp       [rcx+8],r15d
       jg        near ptr M02_L02
       jmp       short M02_L09
M02_L08:
       mov       rdx,rdi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
M02_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M02_L13
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L10:
       mov       rax,1C1E6E80008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF20624D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L12
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M02_L00
M02_L12:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L13:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,181550055F8
       mov       rdi,[rcx]
       mov       r12,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M02_L14
       mov       r14,[rbp-48]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L18
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFF2020C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L15
M02_L14:
       mov       rdx,[rbp-48]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       test      eax,eax
       mov       r14,[rbp-48]
       je        short M02_L18
M02_L15:
       cmp       qword ptr [rdi+20],0
       jne       short M02_L16
       lea       rcx,[rdi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L18
M02_L16:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M02_L17
       mov       rcx,[rdi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20624D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L18
M02_L17:
       add       rdi,2C
       lock dec  dword ptr [rdi]
M02_L18:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 662
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rbx,rbx
       je        short M00_L00
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFF208A7210]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFF1FF741F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       mov       r8,[rsi+1A0]
       cmp       dword ptr [r8+8],0
       jle       short M01_L03
M01_L00:
       mov       r8,[rsi+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M01_L07
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       cmp       [rbx],bl
       test      r8,r8
       je        short M01_L02
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L02
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M01_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L05
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L04
M01_L01:
       mov       [rbx+18],ebp
M01_L02:
       inc       edi
       mov       rdx,[rsi+1A0]
       cmp       [rdx+8],edi
       jg        short M01_L00
M01_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L01
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rcx,22BC90055F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M02_L11
       lea       rcx,[rsi+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       jne       near ptr M02_L11
M02_L00:
       mov       rdi,[rbp-38]
M02_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-40],rdi
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       near ptr M02_L09
       mov       rsi,[rbx+8]
       xor       r14d,r14d
       mov       rcx,[rsi+1A0]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M02_L10
M02_L02:
       mov       rcx,[rsi+1A0]
       cmp       r14d,[rcx+8]
       jae       short M02_L04
       mov       eax,r14d
       mov       rcx,[rcx+rax*8+10]
       cmp       [rdi],dil
       test      rcx,rcx
       je        short M02_L08
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M02_L08
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M02_L07
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M02_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M02_L05
M02_L03:
       mov       [rdi+18],r15d
       jmp       short M02_L08
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L05:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L03
M02_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L03
M02_L07:
       mov       rcx,rdi
       call      qword ptr [7FFF201DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L08:
       inc       r14d
       mov       rcx,[rsi+1A0]
       cmp       [rcx+8],r14d
       jg        near ptr M02_L02
       jmp       short M02_L10
M02_L09:
       mov       rdx,rdi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
M02_L10:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF201CB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       mov       rcx,rsp
       call      M02_L18
       nop
       mov       rax,[rbp-48]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-38]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L13
       cmp       qword ptr [r14+10],0
       jne       short M02_L12
       xor       edx,edx
       mov       [rbp-38],rdx
       jmp       short M02_L14
M02_L12:
       lea       rdx,[rbp-38]
       mov       rcx,rdi
       call      qword ptr [7FFF205F4DB0]
       test      eax,eax
       je        short M02_L14
M02_L13:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M02_L00
M02_L14:
       mov       rsi,[rsi+8]
       mov       rcx,7FFF205F1338
       cmp       [rsi+18],rcx
       je        short M02_L16
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdi,rax
M02_L15:
       jmp       near ptr M02_L01
M02_L16:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFF201DC0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
       jmp       short M02_L15
M02_L17:
       mov       rax,26C5AE30008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
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
       mov       rcx,22BC90055F8
       mov       rdi,[rcx]
       mov       r13,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r13+18],rcx
       jne       short M02_L19
       mov       rsi,[rbp-40]
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rsi+1C]
       mov       rdx,[r13+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M02_L23
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF201DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L20
M02_L19:
       mov       rdx,[rbp-40]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       mov       rsi,[rbp-40]
       je        short M02_L23
M02_L20:
       cmp       qword ptr [rdi+20],0
       jne       short M02_L21
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L23
M02_L21:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M02_L22
       mov       rbx,[rdi+18]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF205F52C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M02_L23
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFF205F4D80]
       jmp       short M02_L23
M02_L22:
       add       rdi,2C
       lock dec  dword ptr [rdi]
M02_L23:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 764
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rbx,rbx
       je        short M00_L00
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFF208DC1F8]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFF1FF941F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       mov       r8,[rsi+1A0]
       cmp       dword ptr [r8+8],0
       jle       short M01_L03
M01_L00:
       mov       r8,[rsi+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M01_L07
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       cmp       [rbx],bl
       test      r8,r8
       je        short M01_L02
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L02
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M01_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L05
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L04
M01_L01:
       mov       [rbx+18],ebp
M01_L02:
       inc       edi
       mov       rdx,[rsi+1A0]
       cmp       [rdx+8],edi
       jg        short M01_L00
M01_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L01
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L14
       mov       rcx,245120055F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M02_L11
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M02_L11
M02_L00:
       mov       rsi,[rbp-40]
M02_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rsi
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       near ptr M02_L09
       mov       r15,[rbx+8]
       xor       r13d,r13d
       mov       rcx,[r15+1A0]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M02_L10
M02_L02:
       mov       rcx,[r15+1A0]
       cmp       r13d,[rcx+8]
       jae       short M02_L04
       mov       eax,r13d
       mov       rcx,[rcx+rax*8+10]
       cmp       [rsi],sil
       test      rcx,rcx
       je        short M02_L08
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M02_L08
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        short M02_L07
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M02_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M02_L05
M02_L03:
       mov       [rsi+18],r12d
       jmp       short M02_L08
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L05:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L03
M02_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L03
M02_L07:
       mov       rcx,rsi
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L08:
       inc       r13d
       mov       rcx,[r15+1A0]
       cmp       [rcx+8],r13d
       jg        near ptr M02_L02
       jmp       short M02_L10
M02_L09:
       mov       rdx,rsi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
M02_L10:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M02_L17
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20615290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L15
M02_L12:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M02_L00
M02_L13:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L14:
       mov       rax,285A3E30008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L15:
       cmp       qword ptr [r14+10],0
       jne       short M02_L16
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M02_L13
M02_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFF20614DB0]
       test      eax,eax
       je        short M02_L13
       jmp       short M02_L12
M02_L17:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,245120055F8
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,7FFF20611350
       cmp       [rax+18],rcx
       jne       short M02_L18
       mov       r15,[rbp-48]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L22
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFF201FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L19
M02_L18:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r15,[rbp-48]
       je        short M02_L22
M02_L19:
       cmp       qword ptr [rsi+20],0
       jne       short M02_L20
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L22
M02_L20:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M02_L21
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF206152C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M02_L22
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFF20614D80]
       jmp       short M02_L22
M02_L21:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M02_L22:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 720
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rbx,rbx
       je        short M00_L00
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFF208DC1F8]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFF1FF941F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       mov       r8,[rsi+1A0]
       cmp       dword ptr [r8+8],0
       jle       short M01_L03
M01_L00:
       mov       r8,[rsi+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M01_L07
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       cmp       [rbx],bl
       test      r8,r8
       je        short M01_L02
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L02
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M01_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L05
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L04
M01_L01:
       mov       [rbx+18],ebp
M01_L02:
       inc       edi
       mov       rdx,[rsi+1A0]
       cmp       [rdx+8],edi
       jg        short M01_L00
M01_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L01
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L14
       mov       rcx,2991D0055F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M02_L11
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M02_L11
M02_L00:
       mov       rsi,[rbp-40]
M02_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rsi
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       near ptr M02_L09
       mov       r15,[rbx+8]
       xor       r13d,r13d
       mov       rcx,[r15+1A0]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M02_L10
M02_L02:
       mov       rcx,[r15+1A0]
       cmp       r13d,[rcx+8]
       jae       short M02_L04
       mov       eax,r13d
       mov       rcx,[rcx+rax*8+10]
       cmp       [rsi],sil
       test      rcx,rcx
       je        short M02_L08
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M02_L08
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        short M02_L07
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M02_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M02_L05
M02_L03:
       mov       [rsi+18],r12d
       jmp       short M02_L08
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L05:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L03
M02_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L03
M02_L07:
       mov       rcx,rsi
       call      qword ptr [7FFF201FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L08:
       inc       r13d
       mov       rcx,[r15+1A0]
       cmp       [rcx+8],r13d
       jg        near ptr M02_L02
       jmp       short M02_L10
M02_L09:
       mov       rdx,rsi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
M02_L10:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF201EB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M02_L17
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20615290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L15
M02_L12:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M02_L00
M02_L13:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L14:
       mov       rax,2D9AEE50008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L15:
       cmp       qword ptr [r14+10],0
       jne       short M02_L16
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M02_L13
M02_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFF20614DB0]
       test      eax,eax
       je        short M02_L13
       jmp       short M02_L12
M02_L17:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,2991D0055F8
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,7FFF20611350
       cmp       [rax+18],rcx
       jne       short M02_L18
       mov       r15,[rbp-48]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L22
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFF201FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L19
M02_L18:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r15,[rbp-48]
       je        short M02_L22
M02_L19:
       cmp       qword ptr [rsi+20],0
       jne       short M02_L20
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L22
M02_L20:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M02_L21
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF206152C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M02_L22
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFF20614D80]
       jmp       short M02_L22
M02_L21:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M02_L22:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 720
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rbx,rbx
       je        short M00_L00
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFF208E7630]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFF1FFA41F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       mov       r8,[rsi+1A0]
       cmp       dword ptr [r8+8],0
       jle       short M01_L03
M01_L00:
       mov       r8,[rsi+1A0]
       cmp       edi,[r8+8]
       jae       near ptr M01_L07
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       cmp       [rbx],bl
       test      r8,r8
       je        short M01_L02
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L02
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M01_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L05
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L04
M01_L01:
       mov       [rbx+18],ebp
M01_L02:
       inc       edi
       mov       rdx,[rsi+1A0]
       cmp       [rdx+8],edi
       jg        short M01_L00
M01_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L01
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L14
       mov       rcx,16F0DC055F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M02_L11
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M02_L11
M02_L00:
       mov       rsi,[rbp-40]
M02_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rsi
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       near ptr M02_L09
       mov       r15,[rbx+8]
       xor       r13d,r13d
       mov       rcx,[r15+1A0]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M02_L10
M02_L02:
       mov       rcx,[r15+1A0]
       cmp       r13d,[rcx+8]
       jae       short M02_L04
       mov       eax,r13d
       mov       rcx,[rcx+rax*8+10]
       cmp       [rsi],sil
       test      rcx,rcx
       je        short M02_L08
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M02_L08
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        short M02_L07
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M02_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M02_L05
M02_L03:
       mov       [rsi+18],r12d
       jmp       short M02_L08
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L05:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L03
M02_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF20055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L03
M02_L07:
       mov       rcx,rsi
       call      qword ptr [7FFF2020CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L08:
       inc       r13d
       mov       rcx,[r15+1A0]
       cmp       [rcx+8],r13d
       jg        near ptr M02_L02
       jmp       short M02_L10
M02_L09:
       mov       rdx,rsi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
M02_L10:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF201FB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M02_L17
       nop
       mov       rax,[rbp-50]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF20625290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L15
M02_L12:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M02_L00
M02_L13:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M02_L01
M02_L14:
       mov       rax,1AF9FA10008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L15:
       cmp       qword ptr [r14+10],0
       jne       short M02_L16
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M02_L13
M02_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFF20624DB0]
       test      eax,eax
       je        short M02_L13
       jmp       short M02_L12
M02_L17:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,16F0DC055F8
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,7FFF20621350
       cmp       [rax+18],rcx
       jne       short M02_L18
       mov       r15,[rbp-48]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L22
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFF2020C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L19
M02_L18:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r15,[rbp-48]
       je        short M02_L22
M02_L19:
       cmp       qword ptr [rsi+20],0
       jne       short M02_L20
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L22
M02_L20:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M02_L21
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF206252C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M02_L22
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFF20624D80]
       jmp       short M02_L22
M02_L21:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M02_L22:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 720
```

