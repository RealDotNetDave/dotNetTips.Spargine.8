## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+8]
       add       edx,edx
       mov       rcx,rdi
       call      qword ptr [7FFDF017C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1BA5F1D581C
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M00_L02
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rdi+18],r8d
M00_L00:
       xor       esi,esi
       mov       rcx,[rbx+180]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L07
M00_L01:
       mov       rcx,[rbx+180]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,esi
       lea       rcx,[rcx+r8+10]
       mov       r8,179CD400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1BA5F1D5830
       call      qword ptr [7FFDF0094810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L04
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M00_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L05
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L06
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L06
M00_L02:
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       esi
       mov       rcx,[rbx+180]
       mov       ecx,[rcx+8]
       movsxd    rax,esi
       cmp       rcx,rax
       jg        near ptr M00_L01
       jmp       short M00_L07
M00_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L06:
       mov       [rdi+18],ebp
       jmp       short M00_L04
M00_L07:
       mov       ecx,[rdi+18]
       mov       eax,ecx
       mov       rdx,[rdi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M00_L10
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
M00_L08:
       mov       rcx,rdi
       call      qword ptr [7FFDF016B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF073FE10]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L09:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L10:
       mov       rcx,rdi
       mov       edx,27
       call      qword ptr [7FFDF017C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L08
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 475
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
       call      qword ptr [7FFDEFE57738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFDF0824F90]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0206CE8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0207180]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
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
       mov       rax,96628C27141F
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
       call      qword ptr [7FFDF0094228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,96628C27141F
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
       call      qword ptr [7FFDF007FD20]
       mov       rcx,96628C27141F
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
       call      qword ptr [7FFDF004F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFDF004F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFDF073FF78]
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
       mov       r9,179CD400298
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
       call      qword ptr [7FFDF06F51D0]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFDF06AEBF8]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFDF0735A58]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFDF06F52D8]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFDEFFBC210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,179CD401DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFDF01F3A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,96628C27141F
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
       call      qword ptr [7FFDF007FE40]
       mov       rcx,96628C27141F
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF017CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0206FB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFDF00BE9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFDF00BE9B8]
       int       3
; Total bytes of code 315
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
       ja        short M04_L03
       test      r8b,18
       jne       short M04_L01
       test      r8b,4
       je        short M04_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
M04_L00:
       pop       rbx
       pop       rsi
       ret
M04_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M04_L00
M04_L02:
       test      r8,r8
       je        short M04_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L00
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       short M04_L00
M04_L03:
       cmp       r8,40
       ja        short M04_L07
M04_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L06
M04_L05:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M04_L00
M04_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L05
M04_L07:
       cmp       r8,800
       ja        short M04_L09
       mov       rax,r8
       shr       rax,6
M04_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M04_L08
       and       r8,3F
       cmp       r8,10
       ja        short M04_L04
       jmp       short M04_L05
M04_L09:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDEFFB5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L10:
       cmp       rcx,rdx
       je        near ptr M04_L00
       jmp       short M04_L09
; Total bytes of code 258
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0206EE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,1BA5F1C0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F6918],0
       je        short M06_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M06_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0246CA0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M06_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M06_L02
M06_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF071AA28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M06_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF073FE40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       call      qword ptr [7FFE2EA685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFE2EA51D20]; CORINFO_HELP_RNGCHKFAIL
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
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+8]
       add       edx,edx
       mov       rcx,rdi
       call      qword ptr [7FFDF016C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,19CA30D57FC
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
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
       mov       [rdi+18],r8d
M00_L00:
       xor       esi,esi
       mov       rcx,[rbx+180]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L04
M00_L01:
       mov       rcx,[rbx+180]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,esi
       lea       rcx,[rcx+r8+10]
       mov       r8,15C11400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,19CA30D5810
       call      qword ptr [7FFDF0094810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L03
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L05
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L02:
       mov       [rdi+18],ebp
M00_L03:
       inc       esi
       mov       rcx,[rbx+180]
       mov       ecx,[rcx+8]
       movsxd    rax,esi
       cmp       rcx,rax
       jg        near ptr M00_L01
M00_L04:
       mov       ecx,[rdi+18]
       mov       eax,ecx
       mov       rdx,[rdi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M00_L10
       mov       eax,eax
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L06
M00_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L06:
       mov       rcx,rdi
       call      qword ptr [7FFDF015B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF0744DC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFDF016CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rdi
       call      qword ptr [7FFDF016CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rdi
       mov       edx,27
       call      qword ptr [7FFDF016C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L06
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 484
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
       call      qword ptr [7FFDEFE57738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFDF074E1A8]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F6190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
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
       mov       rax,6D5A484CD982
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
       call      qword ptr [7FFDF0094228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,6D5A484CD982
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
       call      qword ptr [7FFDF007FD20]
       mov       rcx,6D5A484CD982
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
       call      qword ptr [7FFDF004F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFDF004F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFDF0744F60]
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
       mov       r9,15C11400298
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
       call      qword ptr [7FFDF06C6580]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFDF06C4378]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFDF06F6A90]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFDF06C6688]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFDEFFBC210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,15C11401DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFDF01E3A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,6D5A484CD982
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
       call      qword ptr [7FFDF007FE40]
       mov       rcx,6D5A484CD982
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
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        short M03_L01
       test      r8b,18
       jne       short M03_L03
       test      r8b,4
       jne       short M03_L04
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
M03_L00:
       pop       rbx
       pop       rsi
       ret
M03_L01:
       cmp       r8,40
       jbe       short M03_L05
       cmp       r8,800
       jbe       short M03_L08
M03_L02:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDEFFB5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M03_L00
M03_L04:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M03_L00
M03_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L07
M03_L06:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M03_L00
M03_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L06
M03_L08:
       mov       rax,r8
       shr       rax,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        short M03_L05
       jmp       short M03_L06
M03_L10:
       cmp       rcx,rdx
       je        near ptr M03_L00
       jmp       near ptr M03_L02
; Total bytes of code 261
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,19CA30C0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M05_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M05_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M05_L02
M05_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072A990
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M05_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0744DF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M06_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF016CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L04:
       test      eax,eax
       jne       short M06_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M06_L00
M06_L05:
       call      qword ptr [7FFDF00BE9A0]
       int       3
M06_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M06_L02
M06_L07:
       call      qword ptr [7FFDF00BE9B8]
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
       call      qword ptr [7FFE2EA685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFE2EA51D20]; CORINFO_HELP_RNGCHKFAIL
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
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+8]
       add       edx,edx
       mov       rcx,rdi
       call      qword ptr [7FFDF015C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,2840B3657FC
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
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
       mov       [rdi+18],r8d
M00_L00:
       xor       esi,esi
       mov       rcx,[rbx+180]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L05
M00_L01:
       mov       rcx,[rbx+180]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,esi
       lea       rcx,[rcx+r8+10]
       mov       r8,24379400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2840B365810
       call      qword ptr [7FFDF0084810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L04
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
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
       jne       short M00_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L02:
       mov       [rdi+18],ebp
       jmp       short M00_L04
M00_L03:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L04:
       inc       esi
       mov       rcx,[rbx+180]
       mov       ecx,[rcx+8]
       movsxd    rax,esi
       cmp       rcx,rax
       jg        near ptr M00_L01
M00_L05:
       mov       ecx,[rdi+18]
       mov       eax,ecx
       mov       rdx,[rdi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M00_L10
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
M00_L06:
       mov       rcx,rdi
       call      qword ptr [7FFDF014B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF0735428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFDF015CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rdi
       call      qword ptr [7FFDF015CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L10:
       mov       rcx,rdi
       mov       edx,27
       call      qword ptr [7FFDF015C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L06
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 482
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
       call      qword ptr [7FFDEFE47738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFDF073E1D8]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E6190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
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
       mov       rax,75BA97273323
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
       call      qword ptr [7FFDF0084228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,75BA97273323
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
       call      qword ptr [7FFDF006FD20]
       mov       rcx,75BA97273323
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
       call      qword ptr [7FFDF003F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFDF003F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFDF0735578]
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
       mov       r9,24379400298
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
       call      qword ptr [7FFDF06B6D60]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFDF06B4B58]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFDF06E70A8]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFDF06B6E68]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFDEFFAC210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,24379401DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFDF01D3A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,75BA97273323
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
       call      qword ptr [7FFDF006FE40]
       mov       rcx,75BA97273323
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
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        short M03_L01
       test      r8b,18
       jne       short M03_L03
       test      r8b,4
       jne       short M03_L04
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
M03_L00:
       pop       rbx
       pop       rsi
       ret
M03_L01:
       cmp       r8,40
       jbe       short M03_L05
       cmp       r8,800
       jbe       short M03_L08
M03_L02:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDEFFA5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M03_L00
M03_L04:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M03_L00
M03_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L07
M03_L06:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M03_L00
M03_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L06
M03_L08:
       mov       rax,r8
       shr       rax,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        short M03_L05
       jmp       short M03_L06
M03_L10:
       cmp       rcx,rdx
       je        near ptr M03_L00
       jmp       near ptr M03_L02
; Total bytes of code 261
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,2840B350008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M05_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M05_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M05_L02
M05_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF070A9C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M05_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0735458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M06_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L04:
       test      eax,eax
       jne       short M06_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M06_L00
M06_L05:
       call      qword ptr [7FFDF00AE9A0]
       int       3
M06_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M06_L02
M06_L07:
       call      qword ptr [7FFDF00AE9B8]
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
       call      qword ptr [7FFE2EA685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFE2EA51D20]; CORINFO_HELP_RNGCHKFAIL
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
       mov       rbx,rcx
       cmp       qword ptr [rbx+180],0
       je        near ptr M00_L07
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
       mov       rdx,[rbx+180]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFDF013C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,24F19B357FC
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
       mov       rcx,[rbx+180]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L04
M00_L01:
       mov       rcx,[rbx+180]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,20E8BC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,24F19B35810
       call      qword ptr [7FFDF0064810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       ja        near ptr M00_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L02:
       mov       [rsi+18],ebp
M00_L03:
       inc       edi
       mov       rcx,[rbx+180]
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
       jbe       short M00_L10
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFDF012B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF0715380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFDF013C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L05
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 485
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
       call      qword ptr [7FFDEFE27738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFDF071E898]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C6190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
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
       mov       rax,0AD938D2FE71E
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
       call      qword ptr [7FFDF0064228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,0AD938D2FE71E
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
       call      qword ptr [7FFDF004FD20]
       mov       rcx,0AD938D2FE71E
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
       call      qword ptr [7FFDF001F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFDF001F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFDF07153E0]
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
       mov       r9,20E8BC00298
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
       call      qword ptr [7FFDF0696580]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFDF0694378]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFDF06C6DC0]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFDF0696688]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFDEFF8C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,20E8BC01DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFDF01B3A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0AD938D2FE71E
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
       call      qword ptr [7FFDF004FE40]
       mov       rcx,0AD938D2FE71E
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,24F19B20008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06FAC80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0715A40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L10
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        short M05_L01
       test      r8b,18
       jne       short M05_L03
       test      r8b,4
       jne       short M05_L04
       test      r8,r8
       je        short M05_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L00
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
M05_L00:
       pop       rbx
       pop       rsi
       ret
M05_L01:
       cmp       r8,40
       jbe       short M05_L05
       cmp       r8,800
       jbe       short M05_L07
M05_L02:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDEFF85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M05_L00
M05_L04:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M05_L00
M05_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M05_L09
M05_L06:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M05_L00
M05_L07:
       mov       rax,r8
       shr       rax,6
M05_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M05_L08
       and       r8,3F
       cmp       r8,10
       ja        short M05_L05
       jmp       short M05_L06
M05_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M05_L06
M05_L10:
       cmp       rcx,rdx
       je        near ptr M05_L00
       jmp       near ptr M05_L02
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M06_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF013CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L04:
       test      eax,eax
       jne       short M06_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M06_L00
M06_L05:
       call      qword ptr [7FFDF008E9A0]
       int       3
M06_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M06_L02
M06_L07:
       call      qword ptr [7FFDF008E9B8]
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
       call      qword ptr [7FFE2EA685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFE2EA51D20]; CORINFO_HELP_RNGCHKFAIL
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
       mov       rbx,rcx
       cmp       qword ptr [rbx+180],0
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
       mov       rdx,[rbx+180]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFDF016C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1BC422F581C
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
       mov       rcx,[rbx+180]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L05
M00_L01:
       mov       rcx,[rbx+180]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,17BB0400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1BC422F5830
       call      qword ptr [7FFDF0094810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       ja        near ptr M00_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M00_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
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
       mov       rcx,[rbx+180]
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
       jbe       short M00_L09
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFDF015B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF0746B50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFDF016CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L04
M00_L09:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFDF016C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L06
M00_L10:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFDF016CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 488
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
       call      qword ptr [7FFDEFE57738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFDF074FD98]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F6190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
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
       mov       rax,8F4E49F477FD
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
       call      qword ptr [7FFDF0094228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,8F4E49F477FD
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
       call      qword ptr [7FFDF007FD20]
       mov       rcx,8F4E49F477FD
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
       call      qword ptr [7FFDF004F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFDF004F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFDF0746BB0]
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
       mov       r9,17BB0400298
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
       call      qword ptr [7FFDF06C7E10]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFDF06C5C08]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFDF06FC600]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFDF06C7F18]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFDEFFBC210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,17BB0401DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFDF01E3A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,8F4E49F477FD
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
       call      qword ptr [7FFDF007FE40]
       mov       rcx,8F4E49F477FD
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1BC422E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF071CA30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0747210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L10
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        short M05_L01
       test      r8b,18
       jne       short M05_L03
       test      r8b,4
       jne       short M05_L04
       test      r8,r8
       je        short M05_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L00
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
M05_L00:
       pop       rbx
       pop       rsi
       ret
M05_L01:
       cmp       r8,40
       jbe       short M05_L05
       cmp       r8,800
       jbe       short M05_L08
M05_L02:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDEFFB5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M05_L00
M05_L04:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M05_L00
M05_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M05_L07
M05_L06:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M05_L00
M05_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M05_L06
M05_L08:
       mov       rax,r8
       shr       rax,6
M05_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M05_L09
       and       r8,3F
       cmp       r8,10
       ja        short M05_L05
       jmp       short M05_L06
M05_L10:
       cmp       rcx,rdx
       je        near ptr M05_L00
       jmp       near ptr M05_L02
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M06_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF016CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L04:
       test      eax,eax
       jne       short M06_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M06_L00
M06_L05:
       call      qword ptr [7FFDF00BE9A0]
       int       3
M06_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M06_L02
M06_L07:
       call      qword ptr [7FFDF00BE9B8]
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
       call      qword ptr [7FFE2EA685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFE2EA51D20]; CORINFO_HELP_RNGCHKFAIL
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
       mov       rbx,rcx
       cmp       qword ptr [rbx+180],0
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
       mov       rdx,[rbx+180]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFDF017C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,2255CC7581C
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
       mov       rcx,[rbx+180]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L05
M00_L01:
       mov       rcx,[rbx+180]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,1E4CAC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2255CC75830
       call      qword ptr [7FFDF00A4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       ja        near ptr M00_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M00_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
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
       mov       rcx,[rbx+180]
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
       jbe       short M00_L09
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFDF016B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF0756F40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L04
M00_L09:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFDF017C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L06
M00_L10:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 488
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
       call      qword ptr [7FFDEFE67738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFDF08141F8]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0405CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0406190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
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
       mov       rax,8DFC4F8B6667
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
       call      qword ptr [7FFDF00A4228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,8DFC4F8B6667
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
       call      qword ptr [7FFDF008FD20]
       mov       rcx,8DFC4F8B6667
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
       call      qword ptr [7FFDF005F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFDF005F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFDF0756FA0]
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
       mov       r9,1E4CAC00298
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
       call      qword ptr [7FFDF06DC000]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFDF06D5CE0]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFDF070C930]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFDF06DC108]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFDEFFCC210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,1E4CAC01DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFDF01F3A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,8DFC4F8B6667
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
       call      qword ptr [7FFDF008FE40]
       mov       rcx,8DFC4F8B6667
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0405EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2255CC60008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072CA30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0757600]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L10
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        short M05_L01
       test      r8b,18
       jne       short M05_L03
       test      r8b,4
       jne       short M05_L04
       test      r8,r8
       je        short M05_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L00
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
M05_L00:
       pop       rbx
       pop       rsi
       ret
M05_L01:
       cmp       r8,40
       jbe       short M05_L05
       cmp       r8,800
       jbe       short M05_L08
M05_L02:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDEFFC5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M05_L00
M05_L04:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M05_L00
M05_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M05_L07
M05_L06:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M05_L00
M05_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M05_L11
       jmp       short M05_L06
M05_L08:
       mov       rax,r8
       shr       rax,6
M05_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M05_L09
       and       r8,3F
       cmp       r8,10
       ja        short M05_L05
       jmp       short M05_L06
M05_L10:
       cmp       rcx,rdx
       je        near ptr M05_L00
       jmp       near ptr M05_L02
M05_L11:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M05_L06
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M06_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF017CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0405FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L04:
       test      eax,eax
       jne       short M06_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M06_L00
M06_L05:
       call      qword ptr [7FFDF00CE9A0]
       int       3
M06_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M06_L02
M06_L07:
       call      qword ptr [7FFDF00CE9B8]
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
       call      qword ptr [7FFE2EA685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFE2EA51D20]; CORINFO_HELP_RNGCHKFAIL
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
       mov       rbx,rcx
       cmp       qword ptr [rbx+180],0
       je        near ptr M00_L07
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
       mov       rdx,[rbx+180]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFDF014C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1A58316586C
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M00_L09
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
       mov       rcx,[rbx+180]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L04
M00_L01:
       mov       rcx,[rbx+180]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,164F1400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1A583165880
       call      qword ptr [7FFDF0074810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       jg        short M00_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L02:
       mov       [rsi+18],ebp
M00_L03:
       inc       edi
       mov       rcx,[rbx+180]
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
       jbe       short M00_L10
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFDF013B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF07CE820]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFDF014CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L03
M00_L09:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFDF014CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L10:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFDF014C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L05
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 482
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
       call      qword ptr [7FFDEFE37738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFDF05E6208]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D5CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D6190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
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
       mov       rax,0FF36DA46E940
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
       call      qword ptr [7FFDF0074228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,0FF36DA46E940
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
       call      qword ptr [7FFDF005FD20]
       mov       rcx,0FF36DA46E940
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
       call      qword ptr [7FFDF002F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFDF002F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFDF07CE880]
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
       mov       r9,164F1400298
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
       call      qword ptr [7FFDF06BF8B8]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFDF06BD6B0]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFDF07C4330]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFDF06BF9C0]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFDEFF9C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,164F1401DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFDF01C3A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0FF36DA46E940
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
       call      qword ptr [7FFDF005FE40]
       mov       rcx,0FF36DA46E940
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1A583150008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF079C3B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07CE8E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L09
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        short M05_L02
       test      r8b,18
       je        short M05_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
M05_L00:
       pop       rbx
       pop       rsi
       ret
M05_L01:
       test      r8b,4
       jne       short M05_L05
       test      r8,r8
       je        short M05_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L00
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       short M05_L00
M05_L02:
       cmp       r8,40
       ja        short M05_L06
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
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M05_L00
M05_L05:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M05_L00
M05_L06:
       cmp       r8,800
       ja        short M05_L08
       mov       rax,r8
       shr       rax,6
M05_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M05_L07
       and       r8,3F
       cmp       r8,10
       ja        short M05_L03
       jmp       short M05_L04
M05_L08:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDEFF95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L09:
       cmp       rcx,rdx
       je        near ptr M05_L00
       jmp       short M05_L08
; Total bytes of code 256
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M06_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF014CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L04:
       test      eax,eax
       jne       short M06_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M06_L00
M06_L05:
       call      qword ptr [7FFDF009E9A0]
       int       3
M06_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M06_L02
M06_L07:
       call      qword ptr [7FFDF009E9B8]
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
       call      qword ptr [7FFE2EA685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFE2EA51D20]; CORINFO_HELP_RNGCHKFAIL
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
       mov       rbx,rcx
       cmp       qword ptr [rbx+180],0
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
       mov       rdx,[rbx+180]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFDF013C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,18302D0586C
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
       mov       rcx,[rbx+180]
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L05
M00_L01:
       mov       rcx,[rbx+180]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L12
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,14270C00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,18302D05880
       call      qword ptr [7FFDF0064810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       mov       rcx,[rbx+180]
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
       jbe       short M00_L11
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFDF012B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF080D380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L07:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L02
M00_L08:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,rsi
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFDF013C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L06
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 496
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,esi
       mov       rdx,18302CF0390
       call      qword ptr [7FFDF01EFA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFDEFE27738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5500]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5998]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
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
       mov       rax,0B69C8144F9CF
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
       call      qword ptr [7FFDF0064228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,0B69C8144F9CF
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
       call      qword ptr [7FFDF004FD20]
       mov       rcx,0B69C8144F9CF
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
       call      qword ptr [7FFDF001F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFDF001F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFDF080D3C8]
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
       mov       r9,14270C00298
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
       call      qword ptr [7FFDF071E478]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFDF071C270]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFDF07DED60]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFDF071E580]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFDEFF8C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,14270C01DD0
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFDF01B08D0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0B69C8144F9CF
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
       call      qword ptr [7FFDF004FE40]
       mov       rcx,0B69C8144F9CF
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,18302CF0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B69D0],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF07F9860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF080D428]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF013CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C57D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFDF008E9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFDF008E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M06_L02
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L02
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M06_L04
       test      r8b,18
       jne       near ptr M06_L08
       test      r8b,4
       jne       near ptr M06_L09
       test      r8,r8
       je        near ptr M06_L07
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M06_L07
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M06_L07
M06_L00:
       cmp       r8,800
       ja        short M06_L03
       mov       r9,r8
       shr       r9,6
M06_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M06_L01
       and       r8,3F
       cmp       r8,10
       ja        short M06_L05
       jmp       short M06_L06
M06_L02:
       cmp       rcx,rdx
       je        short M06_L07
M06_L03:
       jmp       qword ptr [7FFDEFF85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L04:
       cmp       r8,40
       ja        short M06_L00
M06_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M06_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M06_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M06_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M06_L07:
       ret
M06_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M06_L07
M06_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L07
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
       call      qword ptr [7FFE2EA685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFE2EA51D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,1CD0D770008
       mov       edx,1
       call      qword ptr [7FFDF0744E10]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0744E70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0D0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       dword ptr [rbp-18],2C
       lea       rcx,[rbp-18]
       call      qword ptr [7FFDEFE95A40]; System.Char.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0B0]
       mov       [rbp+10],rcx
       nop
M01_L02:
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18C7B8055F8
       mov       rcx,[rcx]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B8]
       mov       rax,[rbp-0B8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+20],0
       jne       short M01_L03
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+20]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-5C],ecx
M01_L04:
       mov       ecx,[rbp-5C]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M01_L15
       nop
       mov       rcx,[rbp-8]
       mov       rdx,1CD0D7857F0
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-70],rax
       nop
       xor       ecx,ecx
       mov       [rbp-20],ecx
       nop
       mov       rcx,[rbp+20]
       mov       [rbp-28],rcx
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L14
M01_L05:
       mov       rcx,[rbp-28]
       mov       eax,[rbp-2C]
       cmp       eax,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       nop
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+20]
       mov       ecx,[rcx+8]
       sub       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       cmp       [rbp-20],ecx
       jge       short M01_L08
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFF069E8]; System.String.get_Length()
       mov       [rbp-0A4],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-0A4],0
       setg      cl
       mov       [rbp-74],ecx
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       mov       [rbp-74],ecx
M01_L09:
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-44],ecx
       cmp       dword ptr [rbp-44],0
       je        short M01_L10
       nop
       xor       ecx,ecx
       mov       [rbp-8C],ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbp-98]
       mov       r8,[rbp+10]
       mov       edx,1
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-8C]
       mov       rdx,[rbp-98]
       call      qword ptr [7FFDF0744DE0]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-40],rcx
       nop
M01_L10:
       mov       ecx,[rbp+18]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L11
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-88],rax
       nop
       nop
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C330]; System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-80],rax
       nop
M01_L12:
       mov       ecx,[rbp-20]
       add       ecx,1
       jno       short M01_L13
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       [rbp-20],ecx
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L14:
       mov       ecx,[rbp-2C]
       mov       rax,[rbp-28]
       cmp       ecx,[rax+8]
       jl        near ptr M01_L05
       nop
M01_L15:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-50],rcx
       nop
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-50]
       add       rsp,0F0
       pop       rbp
       ret
M01_L16:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       nop
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18C7B8055F8
       mov       rcx,[rcx]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0C0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 804
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072ACB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0744EA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,27E04D80008
       mov       edx,1
       call      qword ptr [7FFDF07353C8]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0735428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0D0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       dword ptr [rbp-18],2C
       lea       rcx,[rbp-18]
       call      qword ptr [7FFDEFE85A40]; System.Char.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0B0]
       mov       [rbp+10],rcx
       nop
M01_L02:
       mov       rcx,7FFDF01D8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23D730055F8
       mov       rcx,[rcx]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B8]
       mov       rax,[rbp-0B8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+20],0
       jne       short M01_L03
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+20]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-5C],ecx
M01_L04:
       mov       ecx,[rbp-5C]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M01_L15
       nop
       mov       rcx,[rbp-8]
       mov       rdx,27E04D957F0
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-70],rax
       nop
       xor       ecx,ecx
       mov       [rbp-20],ecx
       nop
       mov       rcx,[rbp+20]
       mov       [rbp-28],rcx
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L14
M01_L05:
       mov       rcx,[rbp-28]
       mov       eax,[rbp-2C]
       cmp       eax,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       nop
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+20]
       mov       ecx,[rcx+8]
       sub       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       cmp       [rbp-20],ecx
       jge       short M01_L08
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFEF69E8]; System.String.get_Length()
       mov       [rbp-0A4],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-0A4],0
       setg      cl
       mov       [rbp-74],ecx
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       mov       [rbp-74],ecx
M01_L09:
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-44],ecx
       cmp       dword ptr [rbp-44],0
       je        short M01_L10
       nop
       xor       ecx,ecx
       mov       [rbp-8C],ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbp-98]
       mov       r8,[rbp+10]
       mov       edx,1
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-8C]
       mov       rdx,[rbp-98]
       call      qword ptr [7FFDF0735398]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-40],rcx
       nop
M01_L10:
       mov       ecx,[rbp+18]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L11
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-88],rax
       nop
       nop
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C330]; System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-80],rax
       nop
M01_L12:
       mov       ecx,[rbp-20]
       add       ecx,1
       jno       short M01_L13
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       [rbp-20],ecx
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L14:
       mov       ecx,[rbp-2C]
       mov       rax,[rbp-28]
       cmp       ecx,[rax+8]
       jl        near ptr M01_L05
       nop
M01_L15:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-50],rcx
       nop
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-50]
       add       rsp,0F0
       pop       rbp
       ret
M01_L16:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       nop
       mov       rcx,7FFDF01D8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23D730055F8
       mov       rcx,[rcx]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0C0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 804
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF071ACB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0735458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,280351A0008
       mov       edx,1
       call      qword ptr [7FFDF0744E10]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0744E70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0D0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       dword ptr [rbp-18],2C
       lea       rcx,[rbp-18]
       call      qword ptr [7FFDEFE95A40]; System.Char.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0B0]
       mov       [rbp+10],rcx
       nop
M01_L02:
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23FA34055F8
       mov       rcx,[rcx]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B8]
       mov       rax,[rbp-0B8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+20],0
       jne       short M01_L03
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+20]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-5C],ecx
M01_L04:
       mov       ecx,[rbp-5C]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M01_L15
       nop
       mov       rcx,[rbp-8]
       mov       rdx,280351B57F0
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-70],rax
       nop
       xor       ecx,ecx
       mov       [rbp-20],ecx
       nop
       mov       rcx,[rbp+20]
       mov       [rbp-28],rcx
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L14
M01_L05:
       mov       rcx,[rbp-28]
       mov       eax,[rbp-2C]
       cmp       eax,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       nop
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+20]
       mov       ecx,[rcx+8]
       sub       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       cmp       [rbp-20],ecx
       jge       short M01_L08
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFF069E8]; System.String.get_Length()
       mov       [rbp-0A4],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-0A4],0
       setg      cl
       mov       [rbp-74],ecx
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       mov       [rbp-74],ecx
M01_L09:
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-44],ecx
       cmp       dword ptr [rbp-44],0
       je        short M01_L10
       nop
       xor       ecx,ecx
       mov       [rbp-8C],ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbp-98]
       mov       r8,[rbp+10]
       mov       edx,1
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-8C]
       mov       rdx,[rbp-98]
       call      qword ptr [7FFDF0744DE0]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-40],rcx
       nop
M01_L10:
       mov       ecx,[rbp+18]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L11
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-88],rax
       nop
       nop
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C330]; System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-80],rax
       nop
M01_L12:
       mov       ecx,[rbp-20]
       add       ecx,1
       jno       short M01_L13
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       [rbp-20],ecx
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L14:
       mov       ecx,[rbp-2C]
       mov       rax,[rbp-28]
       cmp       ecx,[rax+8]
       jl        near ptr M01_L05
       nop
M01_L15:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-50],rcx
       nop
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-50]
       add       rsp,0F0
       pop       rbp
       ret
M01_L16:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       nop
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23FA34055F8
       mov       rcx,[rcx]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0C0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 804
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072ACB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0744EA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,322AC020008
       mov       edx,1
       call      qword ptr [7FFDF0726868]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF07268C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0D0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       dword ptr [rbp-18],2C
       lea       rcx,[rbp-18]
       call      qword ptr [7FFDEFE75A40]; System.Char.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0B0]
       mov       [rbp+10],rcx
       nop
M01_L02:
       mov       rcx,7FFDF01C8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2E21A0055F8
       mov       rcx,[rcx]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B8]
       mov       rax,[rbp-0B8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+20],0
       jne       short M01_L03
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+20]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-5C],ecx
M01_L04:
       mov       ecx,[rbp-5C]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M01_L15
       nop
       mov       rcx,[rbp-8]
       mov       rdx,322AC035810
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-70],rax
       nop
       xor       ecx,ecx
       mov       [rbp-20],ecx
       nop
       mov       rcx,[rbp+20]
       mov       [rbp-28],rcx
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L14
M01_L05:
       mov       rcx,[rbp-28]
       mov       eax,[rbp-2C]
       cmp       eax,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       nop
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+20]
       mov       ecx,[rcx+8]
       sub       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       cmp       [rbp-20],ecx
       jge       short M01_L08
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFEE69E8]; System.String.get_Length()
       mov       [rbp-0A4],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-0A4],0
       setg      cl
       mov       [rbp-74],ecx
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       mov       [rbp-74],ecx
M01_L09:
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-44],ecx
       cmp       dword ptr [rbp-44],0
       je        short M01_L10
       nop
       xor       ecx,ecx
       mov       [rbp-8C],ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbp-98]
       mov       r8,[rbp+10]
       mov       edx,1
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-8C]
       mov       rdx,[rbp-98]
       call      qword ptr [7FFDF0726838]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-40],rcx
       nop
M01_L10:
       mov       ecx,[rbp+18]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L11
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-88],rax
       nop
       nop
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C330]; System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-80],rax
       nop
M01_L12:
       mov       ecx,[rbp-20]
       add       ecx,1
       jno       short M01_L13
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       [rbp-20],ecx
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L14:
       mov       ecx,[rbp-2C]
       mov       rax,[rbp-28]
       cmp       ecx,[rax+8]
       jl        near ptr M01_L05
       nop
M01_L15:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-50],rcx
       nop
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-50]
       add       rsp,0F0
       pop       rbp
       ret
M01_L16:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       nop
       mov       rcx,7FFDF01C8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2E21A0055F8
       mov       rcx,[rcx]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0C0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 804
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06FCA78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07268F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,2EF2C680008
       mov       edx,1
       call      qword ptr [7FFDF0746F88]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0746FE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0D0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       dword ptr [rbp-18],2C
       lea       rcx,[rbp-18]
       call      qword ptr [7FFDEFE95A40]; System.Char.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0B0]
       mov       [rbp+10],rcx
       nop
M01_L02:
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2AE9A803600
       mov       rcx,[rcx]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B8]
       mov       rax,[rbp-0B8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+20],0
       jne       short M01_L03
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+20]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-5C],ecx
M01_L04:
       mov       ecx,[rbp-5C]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M01_L15
       nop
       mov       rcx,[rbp-8]
       mov       rdx,2EF2C695810
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-70],rax
       nop
       xor       ecx,ecx
       mov       [rbp-20],ecx
       nop
       mov       rcx,[rbp+20]
       mov       [rbp-28],rcx
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L14
M01_L05:
       mov       rcx,[rbp-28]
       mov       eax,[rbp-2C]
       cmp       eax,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       nop
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+20]
       mov       ecx,[rcx+8]
       sub       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       cmp       [rbp-20],ecx
       jge       short M01_L08
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFF069E8]; System.String.get_Length()
       mov       [rbp-0A4],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-0A4],0
       setg      cl
       mov       [rbp-74],ecx
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       mov       [rbp-74],ecx
M01_L09:
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-44],ecx
       cmp       dword ptr [rbp-44],0
       je        short M01_L10
       nop
       xor       ecx,ecx
       mov       [rbp-8C],ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbp-98]
       mov       r8,[rbp+10]
       mov       edx,1
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-8C]
       mov       rdx,[rbp-98]
       call      qword ptr [7FFDF0746F58]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-40],rcx
       nop
M01_L10:
       mov       ecx,[rbp+18]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L11
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-88],rax
       nop
       nop
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C330]; System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-80],rax
       nop
M01_L12:
       mov       ecx,[rbp-20]
       add       ecx,1
       jno       short M01_L13
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       [rbp-20],ecx
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L14:
       mov       ecx,[rbp-2C]
       mov       rax,[rbp-28]
       cmp       ecx,[rax+8]
       jl        near ptr M01_L05
       nop
M01_L15:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-50],rcx
       nop
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-50]
       add       rsp,0F0
       pop       rbp
       ret
M01_L16:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       nop
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2AE9A803600
       mov       rcx,[rcx]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0C0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 804
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF071CA60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0747018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,1AAF1C50008
       mov       edx,1
       call      qword ptr [7FFDF0726F88]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0726FE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0D0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C8010],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       dword ptr [rbp-18],2C
       lea       rcx,[rbp-18]
       call      qword ptr [7FFDEFE75A40]; System.Char.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0B0]
       mov       [rbp+10],rcx
       nop
M01_L02:
       mov       rcx,7FFDF01C8788
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16A5FC03600
       mov       rcx,[rcx]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B8]
       mov       rax,[rbp-0B8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+20],0
       jne       short M01_L03
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+20]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-5C],ecx
M01_L04:
       mov       ecx,[rbp-5C]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M01_L15
       nop
       mov       rcx,[rbp-8]
       mov       rdx,1AAF1C65810
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-70],rax
       nop
       xor       ecx,ecx
       mov       [rbp-20],ecx
       nop
       mov       rcx,[rbp+20]
       mov       [rbp-28],rcx
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L14
M01_L05:
       mov       rcx,[rbp-28]
       mov       eax,[rbp-2C]
       cmp       eax,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       nop
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+20]
       mov       ecx,[rcx+8]
       sub       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       cmp       [rbp-20],ecx
       jge       short M01_L08
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFEE69E8]; System.String.get_Length()
       mov       [rbp-0A4],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-0A4],0
       setg      cl
       mov       [rbp-74],ecx
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       mov       [rbp-74],ecx
M01_L09:
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-44],ecx
       cmp       dword ptr [rbp-44],0
       je        short M01_L10
       nop
       xor       ecx,ecx
       mov       [rbp-8C],ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbp-98]
       mov       r8,[rbp+10]
       mov       edx,1
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-8C]
       mov       rdx,[rbp-98]
       call      qword ptr [7FFDF0726F58]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-40],rcx
       nop
M01_L10:
       mov       ecx,[rbp+18]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L11
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-88],rax
       nop
       nop
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C330]; System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-80],rax
       nop
M01_L12:
       mov       ecx,[rbp-20]
       add       ecx,1
       jno       short M01_L13
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       [rbp-20],ecx
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L14:
       mov       ecx,[rbp-2C]
       mov       rax,[rbp-28]
       cmp       ecx,[rax+8]
       jl        near ptr M01_L05
       nop
M01_L15:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-50],rcx
       nop
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-50]
       add       rsp,0F0
       pop       rbp
       ret
M01_L16:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       nop
       mov       rcx,7FFDF01C8788
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16A5FC03600
       mov       rcx,[rcx]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0C0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 804
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6970],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06FCA60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0727018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,23ECF270008
       mov       edx,1
       call      qword ptr [7FFDF07EE448]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF07EE4A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0D0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       dword ptr [rbp-18],2C
       lea       rcx,[rbp-18]
       call      qword ptr [7FFDEFE95A40]; System.Char.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0B0]
       mov       [rbp+10],rcx
       nop
M01_L02:
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FE3D403600
       mov       rcx,[rcx]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B8]
       mov       rax,[rbp-0B8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+20],0
       jne       short M01_L03
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+20]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-5C],ecx
M01_L04:
       mov       ecx,[rbp-5C]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M01_L15
       nop
       mov       rcx,[rbp-8]
       mov       rdx,23ECF285860
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-70],rax
       nop
       xor       ecx,ecx
       mov       [rbp-20],ecx
       nop
       mov       rcx,[rbp+20]
       mov       [rbp-28],rcx
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L14
M01_L05:
       mov       rcx,[rbp-28]
       mov       eax,[rbp-2C]
       cmp       eax,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       nop
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+20]
       mov       ecx,[rcx+8]
       sub       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       cmp       [rbp-20],ecx
       jge       short M01_L08
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFF069E8]; System.String.get_Length()
       mov       [rbp-0A4],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-0A4],0
       setg      cl
       mov       [rbp-74],ecx
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       mov       [rbp-74],ecx
M01_L09:
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-44],ecx
       cmp       dword ptr [rbp-44],0
       je        short M01_L10
       nop
       xor       ecx,ecx
       mov       [rbp-8C],ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbp-98]
       mov       r8,[rbp+10]
       mov       edx,1
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-8C]
       mov       rdx,[rbp-98]
       call      qword ptr [7FFDF07EE418]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-40],rcx
       nop
M01_L10:
       mov       ecx,[rbp+18]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L11
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-88],rax
       nop
       nop
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C330]; System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-80],rax
       nop
M01_L12:
       mov       ecx,[rbp-20]
       add       ecx,1
       jno       short M01_L13
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       [rbp-20],ecx
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L14:
       mov       ecx,[rbp-2C]
       mov       rax,[rbp-28]
       cmp       ecx,[rax+8]
       jl        near ptr M01_L05
       nop
M01_L15:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-50],rcx
       nop
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-50]
       add       rsp,0F0
       pop       rbp
       ret
M01_L16:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       nop
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FE3D403600
       mov       rcx,[rcx]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0C0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 804
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF075C570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07EE4D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,259E7310008
       mov       edx,1
       call      qword ptr [7FFDF083D3C8]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF083D428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0D0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       dword ptr [rbp-18],2C
       lea       rcx,[rbp-18]
       call      qword ptr [7FFDEFE85A40]; System.Char.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0B0]
       mov       [rbp+10],rcx
       nop
M01_L02:
       mov       rcx,7FFDF01D8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,219554055F8
       mov       rcx,[rcx]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B8]
       mov       rax,[rbp-0B8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+20],0
       jne       short M01_L03
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+20]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-5C],ecx
M01_L04:
       mov       ecx,[rbp-5C]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M01_L15
       nop
       mov       rcx,[rbp-8]
       mov       rdx,259E7325860
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-70],rax
       nop
       xor       ecx,ecx
       mov       [rbp-20],ecx
       nop
       mov       rcx,[rbp+20]
       mov       [rbp-28],rcx
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L14
M01_L05:
       mov       rcx,[rbp-28]
       mov       eax,[rbp-2C]
       cmp       eax,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       nop
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+20]
       mov       ecx,[rcx+8]
       sub       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       cmp       [rbp-20],ecx
       jge       short M01_L08
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFEF69E8]; System.String.get_Length()
       mov       [rbp-0A4],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-0A4],0
       setg      cl
       mov       [rbp-74],ecx
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       mov       [rbp-74],ecx
M01_L09:
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-44],ecx
       cmp       dword ptr [rbp-44],0
       je        short M01_L10
       nop
       xor       ecx,ecx
       mov       [rbp-8C],ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbp-98]
       mov       r8,[rbp+10]
       mov       edx,1
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-8C]
       mov       rdx,[rbp-98]
       call      qword ptr [7FFDF083D398]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-40],rcx
       nop
M01_L10:
       mov       ecx,[rbp+18]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L11
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-88],rax
       nop
       nop
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C330]; System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-80],rax
       nop
M01_L12:
       mov       ecx,[rbp-20]
       add       ecx,1
       jno       short M01_L13
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       [rbp-20],ecx
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L14:
       mov       ecx,[rbp-2C]
       mov       rax,[rbp-28]
       cmp       ecx,[rax+8]
       jl        near ptr M01_L05
       nop
M01_L15:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-50],rcx
       nop
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-50]
       add       rsp,0F0
       pop       rbp
       ret
M01_L16:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       nop
       mov       rcx,7FFDF01D8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,219554055F8
       mov       rcx,[rcx]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0C0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 804
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF0829A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF083D458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF014CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFDF013B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDF0724DC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L07:
       mov       rax,24D6A550008
       jmp       near ptr M00_L01
; Total bytes of code 271
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
       ja        short M01_L01
       test      r8b,18
       je        short M01_L04
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M01_L00:
       ret
M01_L01:
       cmp       r8,40
       ja        short M01_L07
M01_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L05
M01_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L04:
       test      r8b,4
       je        short M01_L06
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       eax,[rax-4]
       mov       [r10-4],eax
       jmp       short M01_L00
M01_L05:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L03
M01_L06:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
M01_L07:
       cmp       r8,800
       ja        short M01_L10
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
       ja        near ptr M01_L02
       jmp       near ptr M01_L03
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFDEFF95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 257
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF014CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF009E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF009E9B8]
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,24D6A550008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF070A9B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0724DF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFDF016B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDF0755380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L07:
       mov       rax,20561B60008
       jmp       near ptr M00_L01
M00_L08:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L02
; Total bytes of code 271
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
       ja        short M01_L00
       test      r8b,18
       je        short M01_L05
       jmp       short M01_L04
M01_L00:
       cmp       r8,40
       ja        short M01_L08
M01_L01:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L02:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L03:
       ret
M01_L04:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L03
M01_L05:
       test      r8b,4
       je        short M01_L07
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       eax,[rax-4]
       mov       [r10-4],eax
       jmp       short M01_L03
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L02
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L02
M01_L07:
       test      r8,r8
       je        short M01_L03
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L03
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L03
M01_L08:
       cmp       r8,800
       ja        short M01_L11
       mov       r9,r8
       shr       r9,6
M01_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L01
       jmp       near ptr M01_L02
M01_L10:
       cmp       rcx,rdx
       je        near ptr M01_L03
M01_L11:
       jmp       qword ptr [7FFDEFFC5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF017CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF04057D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF00CE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF00CE9B8]
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF04056F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,20561B60008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F6BF0],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF073A9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07553B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF016CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFDF015B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDF0745380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L07:
       mov       rax,2037BED0008
       jmp       near ptr M00_L01
M00_L08:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L02
; Total bytes of code 271
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
       ja        near ptr M01_L07
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L04
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L02
M01_L04:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L02
M01_L06:
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L02
M01_L07:
       cmp       r8,800
       ja        short M01_L10
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
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFDEFFB5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF016CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF00BE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF00BE9B8]
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2037BED0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072A9B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07453B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF015CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFDF014B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDF0736F40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L07:
       mov       rax,2E8F5690008
       jmp       near ptr M00_L01
M00_L08:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L02
; Total bytes of code 271
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
       jmp       qword ptr [7FFDEFFA5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF00AE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF00AE9B8]
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2E8F5690008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF070C768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0736F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFDF012B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDF0716F40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L07:
       mov       rax,2E4E9360008
       jmp       near ptr M00_L01
M00_L08:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L02
; Total bytes of code 271
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
       jmp       qword ptr [7FFDEFF85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF013CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C57D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF008E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF008E9B8]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2E4E9360008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B68C0],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06EC768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0716F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF016CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFDF015B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDF0746F40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L07:
       mov       rax,21263E90008
       jmp       near ptr M00_L01
M00_L08:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L02
; Total bytes of code 271
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
       jmp       qword ptr [7FFDEFFB5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF016CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF00BE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF00BE9B8]
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,21263E90008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF071C768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0746F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFDF012B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDF0716B50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L07:
       mov       rax,20B28FA0008
       jmp       near ptr M00_L01
M00_L08:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L02
; Total bytes of code 271
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
       jmp       qword ptr [7FFDEFF85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF013CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF008E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF008E9B8]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,20B28FA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06EC768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0716B80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L04
M00_L00:
       mov       ecx,ebp
       mov       rax,[rdi+rcx*8+10]
       test      rax,rax
       je        short M00_L05
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
       ja        short M00_L08
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
       call      qword ptr [7FFDF015B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDF084D380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L05:
       mov       rax,1AFDB480008
       jmp       short M00_L01
M00_L06:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L02
M00_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFDF016CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L03
; Total bytes of code 265
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,1AFDB480008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF0839780
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF084D3B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L02
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L02
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M03_L04
       test      r8b,18
       jne       near ptr M03_L08
       test      r8b,4
       jne       near ptr M03_L09
       test      r8,r8
       je        near ptr M03_L07
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L07
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M03_L07
M03_L00:
       cmp       r8,800
       ja        short M03_L03
       mov       r9,r8
       shr       r9,6
M03_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L01
       and       r8,3F
       cmp       r8,10
       ja        short M03_L05
       jmp       short M03_L06
M03_L02:
       cmp       rcx,rdx
       je        short M03_L07
M03_L03:
       jmp       qword ptr [7FFDEFFB5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L04:
       cmp       r8,40
       ja        short M03_L00
M03_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M03_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L07:
       ret
M03_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M03_L07
M03_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L07
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF016CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFDF00BE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFDF00BE9B8]
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
       sub       rsp,20
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L07
M00_L00:
       mov       r8,[rbx+198]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,281082F1C14
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
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFDF012B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF0716F40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L08:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,281082F0008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 378
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
       ja        short M01_L01
       test      r8b,18
       je        short M01_L04
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M01_L00:
       ret
M01_L01:
       cmp       r8,40
       ja        short M01_L07
M01_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L05
M01_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L04:
       test      r8b,4
       je        short M01_L06
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       eax,[rax-4]
       mov       [r10-4],eax
       jmp       short M01_L00
M01_L05:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L03
M01_L06:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
M01_L07:
       cmp       r8,800
       ja        short M01_L10
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
       ja        near ptr M01_L02
       jmp       near ptr M01_L03
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFDEFF85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 257
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF013CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF008E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF008E9B8]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,281082F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06EC750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0716F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L07
M00_L00:
       mov       r8,[rbx+198]
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
       jg        short M00_L02
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebp,2
       jne       short M00_L03
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L03
M00_L02:
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L03:
       add       ebp,r14d
       mov       [rsi+18],ebp
       jmp       short M00_L05
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,1A104241C14
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
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFDF012B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF0714DC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L08:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,1A104240008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 378
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
       ja        short M01_L07
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
       je        short M01_L06
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       eax,[rax-4]
       mov       [r10-4],eax
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
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L02
M01_L07:
       cmp       r8,800
       ja        short M01_L10
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
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFDEFF85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 257
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF013CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF008E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF008E9B8]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1A104240008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06FA988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0714DF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L07
M00_L00:
       mov       r8,[rbx+198]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,1FFA8681C14
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
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFDF012B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF0715380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L08:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,1FFA8680008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 378
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
       ja        near ptr M01_L07
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L04
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L02
M01_L04:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L02
M01_L06:
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L02
M01_L07:
       cmp       r8,800
       ja        short M01_L10
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
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFDEFF85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF013CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF008E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF008E9B8]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1FFA8680008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06FA9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07153B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L07
M00_L00:
       mov       r8,[rbx+198]
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFDF016CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,25570A91C14
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
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFDF015B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF0745380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L08:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFDF016CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,25570A90008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 378
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
       jmp       qword ptr [7FFDEFFB5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF016CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F57D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF00BE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF00BE9B8]
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,25570A90008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E68C0],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072A9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07453B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L07
M00_L00:
       mov       r8,[rbx+198]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,278AEA61C14
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
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFDF012B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF0716F40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L08:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,278AEA60008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 378
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
       jmp       qword ptr [7FFDEFF85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF013CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF008E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF008E9B8]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,278AEA60008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06EC750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0716F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+198]
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
       ja        near ptr M00_L08
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
       mov       rdx,1D3354B1C14
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L07
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [rsi+18],eax
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFDF016B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF0756F40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L07:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L04
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L09:
       mov       rax,1D3354B0008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 373
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0405EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,1D3354B0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072C750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0756F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       ja        short M03_L07
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
       je        short M03_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L02
M03_L06:
       test      r8b,4
       je        short M03_L08
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M03_L02
M03_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M03_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L01
M03_L08:
       test      r8,r8
       je        near ptr M03_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M03_L02
M03_L09:
       cmp       rcx,rdx
       je        near ptr M03_L02
M03_L10:
       jmp       qword ptr [7FFDEFFC5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF017CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0405FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFDF00CE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFDF00CE9B8]
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
       sub       rsp,20
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L07
M00_L00:
       mov       r8,[rbx+198]
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFDF01B72E8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,2D7F9391C14
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
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       call      qword ptr [7FFDF018FDE8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF07CE820]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L08:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFDF01B72E8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,2D7F9390008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 373
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
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
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M01_L02:
       pop       rbx
       pop       rsi
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       rax,r8
       shr       rax,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
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
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
       jmp       short M01_L02
M01_L06:
       test      r8b,4
       je        short M01_L08
       mov       eax,[rdx]
       mov       [rcx],eax
       mov       eax,[rbx-4]
       mov       [rsi-4],eax
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
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDEFF95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF01B73A8]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF009E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF009E9B8]
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2D7F9390008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF0118D18],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01673C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF07AC2C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07CE850]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       rcx,[rbx+198]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       rcx,[rbx+198]
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
       mov       rdx,16ECBB91C14
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
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFDF015B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF084D380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L06:
       mov       rax,16ECBB90008
       jmp       near ptr M00_L01
M00_L07:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L02
M00_L08:
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFDF016CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFDF016CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 398
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,16ECBB90008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF0839768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF084D3B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L02
       test      r8b,18
       jne       near ptr M03_L06
       test      r8b,4
       jne       near ptr M03_L07
       test      r8,r8
       je        near ptr M03_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L05
M03_L00:
       cmp       r8,800
       ja        near ptr M03_L09
       mov       r9,r8
       shr       r9,6
M03_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L01
       and       r8,3F
       cmp       r8,10
       ja        short M03_L03
       jmp       short M03_L04
M03_L02:
       cmp       r8,40
       ja        short M03_L00
M03_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L04
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M03_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L05:
       ret
M03_L06:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M03_L05
M03_L07:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L05
M03_L08:
       cmp       rcx,rdx
       je        short M03_L05
M03_L09:
       jmp       qword ptr [7FFDEFFB5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF016CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFDF00BE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFDF00BE9B8]
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
       sub       rsp,28
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
       mov       rdi,[rbx+190]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       near ptr M00_L05
M00_L00:
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       test      ecx,ecx
       jle       short M00_L01
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       ja        near ptr M00_L07
       mov       rcx,rsi
       mov       edx,2C
       call      qword ptr [7FFDF016C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L01:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,2CA42000210
       call      qword ptr [7FFDEFF06B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M00_L15
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M00_L15
       mov       rax,[rcx]
       add       rax,10
M00_L02:
       cmp       qword ptr [rax+8],0
       jne       short M00_L03
       mov       rcx,289B0000438
       cmp       qword ptr [rcx],0
       jne       short M00_L03
       mov       rcx,289B0000418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L03:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       near ptr M00_L09
       mov       r12,2CA42000A40
M00_L04:
       test      r12,r12
       je        short M00_L05
       lea       rdx,[r12+0C]
       mov       r13d,[r12+8]
       test      r13d,r13d
       je        short M00_L05
       mov       r12,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r12+8]
       jbe       near ptr M00_L10
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFDF016CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L14
M00_L06:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L08
       mov       rcx,rsi
       call      qword ptr [7FFDF015B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFDF0746F40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
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
M00_L07:
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],2C
       inc       dword ptr [rsi+18]
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L17
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L06
       mov       r15,[rcx]
       mov       r13,[rcx+8]
       jmp       near ptr M00_L00
M00_L09:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L13
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+20],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    rcx,r12d
       mov       r12,[rsp+20]
       lea       rcx,[r12+rcx*2+0C]
       mov       rdx,2CA42000A4C
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       jmp       near ptr M00_L04
M00_L10:
       movsxd    r8,r15d
       lea       rcx,[r12+r8*2+10]
       cmp       r13d,2
       jg        short M00_L11
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L12
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L12
M00_L11:
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L12:
       add       r15d,r13d
       mov       [rsi+18],r15d
       jmp       near ptr M00_L05
M00_L13:
       call      qword ptr [7FFDF00BEF10]
       int       3
M00_L14:
       call      qword ptr [7FFDF00BEFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L02
M00_L16:
       call      qword ptr [7FFDF0074030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L03
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 664
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
       call      qword ptr [7FFDF016CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFDEFF06B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFDF00BEF10]
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
       jmp       qword ptr [7FFDEFF06B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFF06B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF016CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFDF00BE9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFDF00BE9B8]
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
       call      qword ptr [7FFDEFFB5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDB4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03F5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,2CA42000008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M05_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M05_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M05_L02
M05_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF071C830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M05_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0746F88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M06_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M06_L03
       cmp       r8,40
       ja        short M06_L05
M06_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M06_L04
M06_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M06_L02:
       ret
M06_L03:
       test      r8b,18
       jne       near ptr M06_L08
       test      r8b,4
       jne       short M06_L07
       test      r8,r8
       je        short M06_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M06_L02
M06_L04:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M06_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M06_L01
M06_L05:
       cmp       r8,800
       ja        short M06_L10
       mov       r9,r8
       shr       r9,6
M06_L06:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M06_L06
       and       r8,3F
       cmp       r8,10
       jbe       near ptr M06_L01
       jmp       near ptr M06_L00
M06_L07:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       near ptr M06_L02
M06_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       near ptr M06_L02
M06_L09:
       cmp       rcx,rdx
       je        near ptr M06_L02
M06_L10:
       jmp       qword ptr [7FFDEFFB5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 269
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE2EA521F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFE2EA65B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2EA66B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       sub       rsp,28
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
       mov       rdi,[rbx+190]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       near ptr M00_L07
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
       call      qword ptr [7FFDF015C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,27195BD0210
       call      qword ptr [7FFDEFEF6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M00_L14
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M00_L14
       mov       rax,[rcx]
       add       rax,10
M00_L03:
       cmp       qword ptr [rax+8],0
       jne       short M00_L04
       mov       rcx,23107C00438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,23107C00418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L15
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,27195BD0A40
       jmp       short M00_L06
M00_L05:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L12
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+20],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+20]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,27195BD0A4C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
M00_L06:
       test      r12,r12
       je        short M00_L07
       lea       rdx,[r12+0C]
       mov       r13d,[r12+8]
       test      r13d,r13d
       je        short M00_L07
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       jbe       short M00_L09
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFDF015CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L07:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L13
M00_L08:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L11
       mov       rcx,rsi
       call      qword ptr [7FFDF014B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFDF0735380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
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
M00_L09:
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L16
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L10:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L07
M00_L11:
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
       jl        near ptr M00_L08
       mov       r15,[rcx]
       mov       r13,[rcx+8]
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FFDF00AEF10]
       int       3
M00_L13:
       call      qword ptr [7FFDF00AEFB8]
       int       3
M00_L14:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L15:
       call      qword ptr [7FFDF0064030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L16:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r13d,2
       jne       short M00_L10
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L10
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 640
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
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFDF00AEF10]
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
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
       jbe       short M03_L03
       cmp       r8,40
       ja        short M03_L04
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
       test      r8b,18
       jne       near ptr M03_L08
       test      r8b,4
       je        short M03_L07
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L02
M03_L04:
       cmp       r8,800
       ja        near ptr M03_L10
       mov       r9,r8
       shr       r9,6
M03_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L05
       and       r8,3F
       cmp       r8,10
       jbe       short M03_L01
       jmp       short M03_L00
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
       je        near ptr M03_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M03_L02
M03_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       near ptr M03_L02
M03_L09:
       cmp       rcx,rdx
       je        near ptr M03_L02
M03_L10:
       jmp       qword ptr [7FFDEFFA5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 277
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E57D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFDF00AE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFDF00AE9B8]
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,27195BD0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D68C0],0
       je        short M06_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M06_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M06_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M06_L02
M06_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF071AA68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M06_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07353C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE2EA521F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFE2EA65B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2EA66B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       sub       rsp,28
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
       mov       rdi,[rbx+190]
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
       call      qword ptr [7FFDF015C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,26B8B1C0210
       call      qword ptr [7FFDEFEF6B20]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rcx,22AF9400438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,22AF9400418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,26B8B1C0A40
       jmp       short M00_L06
M00_L05:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L13
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+20],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+20]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,26B8B1C0A4C
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF015CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFDF014B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFDF0734DC8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
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
       call      qword ptr [7FFDF00AEF10]
       int       3
M00_L14:
       call      qword ptr [7FFDF00AEFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFDF0064030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L17:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 643
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
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFDF00AEF10]
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFFA5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFDF00AE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFDF00AE9B8]
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,26B8B1C0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M06_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M06_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M06_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M06_L02
M06_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF071AA68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M06_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0734E10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE2EA521F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFE2EA65B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2EA66B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       sub       rsp,28
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
       mov       rdi,[rbx+190]
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
       call      qword ptr [7FFDF015C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,29415C90210
       call      qword ptr [7FFDEFEF6B20]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rcx,25387C00438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,25387C00418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,29415C90A40
       jmp       short M00_L06
M00_L05:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L13
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+20],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+20]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,29415C90A4C
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF015CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFDF014B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFDF0735380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
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
       call      qword ptr [7FFDF00AEF10]
       int       3
M00_L14:
       call      qword ptr [7FFDF00AEFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFDF0064030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L17:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 643
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
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFDF00AEF10]
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFFA5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFDF00AE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFDF00AE9B8]
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,29415C90008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M06_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M06_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M06_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M06_L02
M06_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF071AA80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M06_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07353C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE2EA521F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFE2EA65B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2EA66B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       sub       rsp,28
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
       mov       rdi,[rbx+190]
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
       call      qword ptr [7FFDF015C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,290A22E0210
       call      qword ptr [7FFDEFEF6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
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
       mov       rcx,25010400438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,25010400418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,290A22E0A40
       jmp       short M00_L06
M00_L05:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L13
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+20],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+20]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,290A22E0A4C
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF015CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFDF014B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFDF0736F40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
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
       call      qword ptr [7FFDF00AEF10]
       int       3
M00_L14:
       call      qword ptr [7FFDF00AEFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFDF0064030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L17:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 643
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
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFDF00AEF10]
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFFA5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E57D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFDF00AE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFDF00AE9B8]
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,290A22E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D68C0],0
       je        short M06_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M06_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M06_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M06_L02
M06_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF070C830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M06_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0736F88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE2EA521F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFE2EA65B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2EA66B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       sub       rsp,28
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
       mov       rdi,[rbx+190]
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
       call      qword ptr [7FFDF015C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,295777E0210
       call      qword ptr [7FFDEFEF6B20]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rcx,254E5800438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,254E5800418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,295777E0A40
       jmp       short M00_L06
M00_L05:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L13
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+20],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+20]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,295777E0A4C
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF015CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFDF014B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFDF0736B50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
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
       call      qword ptr [7FFDF00AEF10]
       int       3
M00_L14:
       call      qword ptr [7FFDF00AEFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFDF0064030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L17:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 643
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
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFDF00AEF10]
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFFA5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFDF00AE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFDF00AE9B8]
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,295777E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M06_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M06_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M06_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M06_L02
M06_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF070C830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M06_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0736B98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE2EA521F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFE2EA65B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2EA66B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       sub       rsp,28
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
       mov       rdi,[rbx+190]
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
       call      qword ptr [7FFDF015C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,2875E490210
       call      qword ptr [7FFDEFEF6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
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
       mov       rcx,246D0400438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,246D0400418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,2875E490A40
       jmp       short M00_L06
M00_L05:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L13
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+20],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+20]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,2875E490A4C
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF015CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFDF014B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFDF07DE820]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
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
       call      qword ptr [7FFDF00AEF10]
       int       3
M00_L14:
       call      qword ptr [7FFDF00AEFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFDF0064030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 636
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
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFDF00AEF10]
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFEF6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFFA5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF015CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFDF00AE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFDF00AE9B8]
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03E5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,2875E490008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M06_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M06_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M06_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M06_L02
M06_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF07AC388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M06_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07DE868]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE2EA521F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFE2EA65B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2EA66B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       sub       rsp,28
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
       mov       rdi,[rbx+190]
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
       mov       rdx,272D0B30210
       call      qword ptr [7FFDEFEE6B20]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rcx,2323EC00438
       cmp       qword ptr [rcx],0
       jne       short M00_L03
       mov       rcx,2323EC00418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L14
M00_L03:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L04
       mov       r12,272D0B30A40
       jmp       short M00_L05
M00_L04:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L10
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+20],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    rcx,r12d
       mov       r12,[rsp+20]
       lea       rcx,[r12+rcx*2+0C]
       mov       rax,272D0B30A4C
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
       jne       short M00_L11
M00_L08:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L09
       mov       rcx,rsi
       call      qword ptr [7FFDF013B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFDF082D380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
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
       call      qword ptr [7FFDF009EF10]
       int       3
M00_L11:
       call      qword ptr [7FFDF009EFB8]
       int       3
M00_L12:
       mov       rcx,rsi
       mov       edx,2C
       call      qword ptr [7FFDF014C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L01
M00_L13:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L02
M00_L14:
       call      qword ptr [7FFDF0054030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L03
M00_L15:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L06
M00_L16:
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFDF014CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       cmp       ebp,[rdi+44]
       je        near ptr M00_L08
       jmp       short M00_L11
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 677
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFDEFEE6B08]; System.String.Concat(System.String, System.String)
M01_L01:
       call      qword ptr [7FFDF009EF10]
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
       jmp       qword ptr [7FFDEFEE6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFEE6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFDEFF95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,272D0B30008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C68B0],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF0819848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF082D3C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
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
       call      qword ptr [7FFDF014CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M05_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE2EA521F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFE2EA65B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2EA66B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       jg        near ptr M07_L03
       cmp       r8d,edi
       jl        near ptr M07_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M07_L01
       test      r8,r8
       je        near ptr M07_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M07_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M07_L00:
       cmp       ebp,r10d
       ja        near ptr M07_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M07_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF014CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M07_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M07_L07
M07_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D57D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L04:
       test      eax,eax
       jne       short M07_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M07_L00
M07_L05:
       call      qword ptr [7FFDF009E9A0]
       int       3
M07_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M07_L02
M07_L07:
       call      qword ptr [7FFDF009E9B8]
       int       3
; Total bytes of code 315
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFDF0724E70]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0724EA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       sub       rsp,1C0
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1A0],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFDF01C8238],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF070ACD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M01_L03:
       mov       rcx,[rbp-88]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1CBAEEC0008
       call      qword ptr [7FFDF0725020]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       mov       [rbp-8C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-8C],0
       sete      cl
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       je        short M01_L04
       nop
       mov       rcx,1CBAEEC0008
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L20
M01_L04:
       mov       rcx,7FFDF01C89B0
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18B1D0055F8
       mov       rcx,[rcx]
       mov       [rbp-180],rcx
       mov       rcx,[rbp-180]
       mov       rax,[rbp-180]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-98],rax
       mov       rdx,[rbp-98]
       mov       [rbp-10],rdx
       nop
       nop
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFEEEE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       vmovdqu   ymm0,ymmword ptr [rbp-0C0]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       rax,[rbp-0A0]
       mov       [rbp-28],rax
       nop
       jmp       near ptr M01_L17
M01_L05:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0D8],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF070B260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L07:
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-0E8]
       mov       r8,[rbp-0D8]
       call      qword ptr [7FFDF02C71F8]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()
       vmovdqu   xmm0,xmmword ptr [rbp-0E8]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C1E0]; System.Text.StringBuilder.get_Length()
       mov       [rbp-0EC],eax
       xor       edx,edx
       cmp       dword ptr [rbp-0EC],0
       setg      dl
       mov       [rbp-5C],edx
       cmp       dword ptr [rbp-5C],0
       je        short M01_L08
       nop
       mov       edx,[rbp+20]
       movzx     edx,dx
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-160],rax
       nop
       nop
M01_L08:
       mov       rcx,[rbp-10]
       mov       [rbp-68],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-108],xmm0
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rcx,[rbp-108]
       mov       r9,[rbp-68]
       mov       edx,1
       mov       r8d,2
       call      qword ptr [7FFDF0724ED0]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       rcx,[rbp-0F8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L09
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-110],rcx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF070B278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-110],rax
M01_L10:
       mov       rcx,[rbp-68]
       mov       [rbp-118],rcx
       lea       rcx,[rbp-80]
       mov       [rbp-120],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-110]
       call      qword ptr [7FFDEFEEF360]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Key()
       mov       [rbp-128],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M01_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-130],rcx
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF070B320
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-130],rax
M01_L12:
       mov       rcx,[rbp-120]
       mov       rdx,[rbp-130]
       mov       r8,[rbp-128]
       call      qword ptr [7FFDF0725878]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rcx,[rbp-80]
       mov       rdx,1CBAEEC0A40
       call      qword ptr [7FFDF0724F00]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-138],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF070B278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-138],rax
M01_L14:
       lea       rcx,[rbp-80]
       mov       [rbp-140],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-138]
       call      qword ptr [7FFDEFEEF378]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-148],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+38],0
       je        short M01_L15
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+38]
       mov       [rbp-150],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF070B3E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-150],rax
M01_L16:
       mov       rcx,[rbp-140]
       mov       rdx,[rbp-150]
       mov       r8,[rbp-148]
       call      qword ptr [7FFDF0725878]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-118]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C588]; System.Text.StringBuilder.Append(AppendInterpolatedStringHandler ByRef)
       mov       [rbp-158],rax
       nop
       nop
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0C8],rcx
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF070B260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0C8],rax
M01_L19:
       lea       rcx,[rbp-48]
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFDF02C71C8]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       mov       [rbp-0CC],eax
       cmp       dword ptr [rbp-0CC],0
       jne       near ptr M01_L05
       nop
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-168],rax
       mov       rcx,[rbp-168]
       mov       [rbp-20],rcx
       nop
       mov       rcx,rsp
       call      M01_L24
       nop
M01_L20:
       mov       rax,[rbp-20]
       add       rsp,1C0
       pop       rbp
       ret
M01_L21:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-198],rcx
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L22
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+40],0
       je        short M01_L22
       mov       rcx,[rbp-198]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF070B418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L23:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       lea       rcx,[rbp-48]
       mov       rax,[rbp-178]
       call      rax
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L24:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       nop
       mov       rcx,7FFDF01C89B0
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18B1D0055F8
       mov       rcx,[rcx]
       mov       [rbp-188],rcx
       mov       rcx,[rbp-188]
       mov       rdx,[rbp-10]
       mov       rax,[rbp-188]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 1521
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6B98],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF070B9D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0725950]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFDF0726FE8]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0727018]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       sub       rsp,1C0
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1A0],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFDF01C7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FCA88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M01_L03:
       mov       rcx,[rbp-88]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,273EAF50008
       call      qword ptr [7FFDF0727198]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       mov       [rbp-8C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-8C],0
       sete      cl
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       je        short M01_L04
       nop
       mov       rcx,273EAF50008
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L20
M01_L04:
       mov       rcx,7FFDF01C8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23359003600
       mov       rcx,[rcx]
       mov       [rbp-180],rcx
       mov       rcx,[rbp-180]
       mov       rax,[rbp-180]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-98],rax
       mov       rdx,[rbp-98]
       mov       [rbp-10],rdx
       nop
       nop
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFEEEE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       vmovdqu   ymm0,ymmword ptr [rbp-0C0]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       rax,[rbp-0A0]
       mov       [rbp-28],rax
       nop
       jmp       near ptr M01_L17
M01_L05:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0D8],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L07:
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-0E8]
       mov       r8,[rbp-0D8]
       call      qword ptr [7FFDF02C79A8]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()
       vmovdqu   xmm0,xmmword ptr [rbp-0E8]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C1E0]; System.Text.StringBuilder.get_Length()
       mov       [rbp-0EC],eax
       xor       edx,edx
       cmp       dword ptr [rbp-0EC],0
       setg      dl
       mov       [rbp-5C],edx
       cmp       dword ptr [rbp-5C],0
       je        short M01_L08
       nop
       mov       edx,[rbp+20]
       movzx     edx,dx
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-160],rax
       nop
       nop
M01_L08:
       mov       rcx,[rbp-10]
       mov       [rbp-68],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-108],xmm0
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rcx,[rbp-108]
       mov       r9,[rbp-68]
       mov       edx,1
       mov       r8d,2
       call      qword ptr [7FFDF0727048]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       rcx,[rbp-0F8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L09
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-110],rcx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-110],rax
M01_L10:
       mov       rcx,[rbp-68]
       mov       [rbp-118],rcx
       lea       rcx,[rbp-80]
       mov       [rbp-120],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-110]
       call      qword ptr [7FFDEFEEF360]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Key()
       mov       [rbp-128],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M01_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-130],rcx
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-130],rax
M01_L12:
       mov       rcx,[rbp-120]
       mov       rdx,[rbp-130]
       mov       r8,[rbp-128]
       call      qword ptr [7FFDF07279F0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rcx,[rbp-80]
       mov       rdx,273EAF50A40
       call      qword ptr [7FFDF0727078]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-138],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-138],rax
M01_L14:
       lea       rcx,[rbp-80]
       mov       [rbp-140],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-138]
       call      qword ptr [7FFDEFEEF378]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-148],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+38],0
       je        short M01_L15
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+38]
       mov       [rbp-150],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-150],rax
M01_L16:
       mov       rcx,[rbp-140]
       mov       rdx,[rbp-150]
       mov       r8,[rbp-148]
       call      qword ptr [7FFDF07279F0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-118]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C588]; System.Text.StringBuilder.Append(AppendInterpolatedStringHandler ByRef)
       mov       [rbp-158],rax
       nop
       nop
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0C8],rcx
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0C8],rax
M01_L19:
       lea       rcx,[rbp-48]
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFDF02C7978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       mov       [rbp-0CC],eax
       cmp       dword ptr [rbp-0CC],0
       jne       near ptr M01_L05
       nop
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-168],rax
       mov       rcx,[rbp-168]
       mov       [rbp-20],rcx
       nop
       mov       rcx,rsp
       call      M01_L24
       nop
M01_L20:
       mov       rax,[rbp-20]
       add       rsp,1C0
       pop       rbp
       ret
M01_L21:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-198],rcx
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L22
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+40],0
       je        short M01_L22
       mov       rcx,[rbp-198]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD1C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L23:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       lea       rcx,[rbp-48]
       mov       rax,[rbp-178]
       call      rax
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L24:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       nop
       mov       rcx,7FFDF01C8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23359003600
       mov       rcx,[rcx]
       mov       [rbp-188],rcx
       mov       rcx,[rbp-188]
       mov       rdx,[rbp-10]
       mov       rax,[rbp-188]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 1521
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06FD788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0727AC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFDF0726BF8]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0726C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       sub       rsp,1C0
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1A0],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFDF01C7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FCA88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M01_L03:
       mov       rcx,[rbp-88]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,21677C40008
       call      qword ptr [7FFDF0726DA8]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       mov       [rbp-8C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-8C],0
       sete      cl
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       je        short M01_L04
       nop
       mov       rcx,21677C40008
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L20
M01_L04:
       mov       rcx,7FFDF01C8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D5E5C055F8
       mov       rcx,[rcx]
       mov       [rbp-180],rcx
       mov       rcx,[rbp-180]
       mov       rax,[rbp-180]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-98],rax
       mov       rdx,[rbp-98]
       mov       [rbp-10],rdx
       nop
       nop
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFEEEE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       vmovdqu   ymm0,ymmword ptr [rbp-0C0]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       rax,[rbp-0A0]
       mov       [rbp-28],rax
       nop
       jmp       near ptr M01_L17
M01_L05:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0D8],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L07:
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-0E8]
       mov       r8,[rbp-0D8]
       call      qword ptr [7FFDF02C79A8]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()
       vmovdqu   xmm0,xmmword ptr [rbp-0E8]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C1E0]; System.Text.StringBuilder.get_Length()
       mov       [rbp-0EC],eax
       xor       edx,edx
       cmp       dword ptr [rbp-0EC],0
       setg      dl
       mov       [rbp-5C],edx
       cmp       dword ptr [rbp-5C],0
       je        short M01_L08
       nop
       mov       edx,[rbp+20]
       movzx     edx,dx
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-160],rax
       nop
       nop
M01_L08:
       mov       rcx,[rbp-10]
       mov       [rbp-68],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-108],xmm0
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rcx,[rbp-108]
       mov       r9,[rbp-68]
       mov       edx,1
       mov       r8d,2
       call      qword ptr [7FFDF0726C58]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       rcx,[rbp-0F8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L09
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-110],rcx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-110],rax
M01_L10:
       mov       rcx,[rbp-68]
       mov       [rbp-118],rcx
       lea       rcx,[rbp-80]
       mov       [rbp-120],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-110]
       call      qword ptr [7FFDEFEEF360]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Key()
       mov       [rbp-128],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M01_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-130],rcx
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-130],rax
M01_L12:
       mov       rcx,[rbp-120]
       mov       rdx,[rbp-130]
       mov       r8,[rbp-128]
       call      qword ptr [7FFDF0727600]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rcx,[rbp-80]
       mov       rdx,21677C40A40
       call      qword ptr [7FFDF0726C88]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-138],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-138],rax
M01_L14:
       lea       rcx,[rbp-80]
       mov       [rbp-140],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-138]
       call      qword ptr [7FFDEFEEF378]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-148],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+38],0
       je        short M01_L15
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+38]
       mov       [rbp-150],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-150],rax
M01_L16:
       mov       rcx,[rbp-140]
       mov       rdx,[rbp-150]
       mov       r8,[rbp-148]
       call      qword ptr [7FFDF0727600]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-118]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C588]; System.Text.StringBuilder.Append(AppendInterpolatedStringHandler ByRef)
       mov       [rbp-158],rax
       nop
       nop
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0C8],rcx
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0C8],rax
M01_L19:
       lea       rcx,[rbp-48]
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFDF02C7978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       mov       [rbp-0CC],eax
       cmp       dword ptr [rbp-0CC],0
       jne       near ptr M01_L05
       nop
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-168],rax
       mov       rcx,[rbp-168]
       mov       [rbp-20],rcx
       nop
       mov       rcx,rsp
       call      M01_L24
       nop
M01_L20:
       mov       rax,[rbp-20]
       add       rsp,1C0
       pop       rbp
       ret
M01_L21:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-198],rcx
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L22
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+40],0
       je        short M01_L22
       mov       rcx,[rbp-198]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06FD1C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L23:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       lea       rcx,[rbp-48]
       mov       rax,[rbp-178]
       call      rax
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L24:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       nop
       mov       rcx,7FFDF01C8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D5E5C055F8
       mov       rcx,[rcx]
       mov       [rbp-188],rcx
       mov       rcx,[rbp-188]
       mov       rdx,[rbp-10]
       mov       rax,[rbp-188]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 1521
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06FD788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07276D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFDF0745428]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0745458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       sub       rsp,1C0
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1A0],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFDF01E7F60],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072ACC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M01_L03:
       mov       rcx,[rbp-88]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2523B790008
       call      qword ptr [7FFDF07455D8]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       mov       [rbp-8C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-8C],0
       sete      cl
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       je        short M01_L04
       nop
       mov       rcx,2523B790008
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L20
M01_L04:
       mov       rcx,7FFDF01E86D8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,211A98055F8
       mov       rcx,[rcx]
       mov       [rbp-180],rcx
       mov       rcx,[rbp-180]
       mov       rax,[rbp-180]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-98],rax
       mov       rdx,[rbp-98]
       mov       [rbp-10],rdx
       nop
       nop
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFF0EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       vmovdqu   ymm0,ymmword ptr [rbp-0C0]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       rax,[rbp-0A0]
       mov       [rbp-28],rax
       nop
       jmp       near ptr M01_L17
M01_L05:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0D8],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072B248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L07:
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-0E8]
       mov       r8,[rbp-0D8]
       call      qword ptr [7FFDF02E79A8]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()
       vmovdqu   xmm0,xmmword ptr [rbp-0E8]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C1E0]; System.Text.StringBuilder.get_Length()
       mov       [rbp-0EC],eax
       xor       edx,edx
       cmp       dword ptr [rbp-0EC],0
       setg      dl
       mov       [rbp-5C],edx
       cmp       dword ptr [rbp-5C],0
       je        short M01_L08
       nop
       mov       edx,[rbp+20]
       movzx     edx,dx
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-160],rax
       nop
       nop
M01_L08:
       mov       rcx,[rbp-10]
       mov       [rbp-68],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-108],xmm0
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rcx,[rbp-108]
       mov       r9,[rbp-68]
       mov       edx,1
       mov       r8d,2
       call      qword ptr [7FFDF0745488]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       rcx,[rbp-0F8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L09
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-110],rcx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072B260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-110],rax
M01_L10:
       mov       rcx,[rbp-68]
       mov       [rbp-118],rcx
       lea       rcx,[rbp-80]
       mov       [rbp-120],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-110]
       call      qword ptr [7FFDEFF0F360]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Key()
       mov       [rbp-128],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M01_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-130],rcx
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072B308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-130],rax
M01_L12:
       mov       rcx,[rbp-120]
       mov       rdx,[rbp-130]
       mov       r8,[rbp-128]
       call      qword ptr [7FFDF0745E30]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rcx,[rbp-80]
       mov       rdx,2523B790A40
       call      qword ptr [7FFDF07454B8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-138],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072B260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-138],rax
M01_L14:
       lea       rcx,[rbp-80]
       mov       [rbp-140],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-138]
       call      qword ptr [7FFDEFF0F378]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-148],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+38],0
       je        short M01_L15
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+38]
       mov       [rbp-150],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072B3C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-150],rax
M01_L16:
       mov       rcx,[rbp-140]
       mov       rdx,[rbp-150]
       mov       r8,[rbp-148]
       call      qword ptr [7FFDF0745E30]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-118]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C588]; System.Text.StringBuilder.Append(AppendInterpolatedStringHandler ByRef)
       mov       [rbp-158],rax
       nop
       nop
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0C8],rcx
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072B248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0C8],rax
M01_L19:
       lea       rcx,[rbp-48]
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFDF02E7978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       mov       [rbp-0CC],eax
       cmp       dword ptr [rbp-0CC],0
       jne       near ptr M01_L05
       nop
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-168],rax
       mov       rcx,[rbp-168]
       mov       [rbp-20],rcx
       nop
       mov       rcx,rsp
       call      M01_L24
       nop
M01_L20:
       mov       rax,[rbp-20]
       add       rsp,1C0
       pop       rbp
       ret
M01_L21:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-198],rcx
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L22
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+40],0
       je        short M01_L22
       mov       rcx,[rbp-198]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072B400
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L23:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       lea       rcx,[rbp-48]
       mov       rax,[rbp-178]
       call      rax
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L24:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       nop
       mov       rcx,7FFDF01E86D8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,211A98055F8
       mov       rcx,[rcx]
       mov       [rbp-188],rcx
       mov       rcx,[rbp-188]
       mov       rdx,[rbp-10]
       mov       rax,[rbp-188]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 1521
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E68C0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072B9C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0745F08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFDF0756FE8]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0757018]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       sub       rsp,1C0
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1A0],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFDF01F7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072CA88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M01_L03:
       mov       rcx,[rbp-88]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2ED5E8C0008
       call      qword ptr [7FFDF0757198]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       mov       [rbp-8C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-8C],0
       sete      cl
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       je        short M01_L04
       nop
       mov       rcx,2ED5E8C0008
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L20
M01_L04:
       mov       rcx,7FFDF01F8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2ACCCC03600
       mov       rcx,[rcx]
       mov       [rbp-180],rcx
       mov       rcx,[rbp-180]
       mov       rax,[rbp-180]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-98],rax
       mov       rdx,[rbp-98]
       mov       [rbp-10],rdx
       nop
       nop
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFF1EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       vmovdqu   ymm0,ymmword ptr [rbp-0C0]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       rax,[rbp-0A0]
       mov       [rbp-28],rax
       nop
       jmp       near ptr M01_L17
M01_L05:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0D8],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072D010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L07:
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-0E8]
       mov       r8,[rbp-0D8]
       call      qword ptr [7FFDF02F79A8]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()
       vmovdqu   xmm0,xmmword ptr [rbp-0E8]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF017C1E0]; System.Text.StringBuilder.get_Length()
       mov       [rbp-0EC],eax
       xor       edx,edx
       cmp       dword ptr [rbp-0EC],0
       setg      dl
       mov       [rbp-5C],edx
       cmp       dword ptr [rbp-5C],0
       je        short M01_L08
       nop
       mov       edx,[rbp+20]
       movzx     edx,dx
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF017C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-160],rax
       nop
       nop
M01_L08:
       mov       rcx,[rbp-10]
       mov       [rbp-68],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-108],xmm0
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rcx,[rbp-108]
       mov       r9,[rbp-68]
       mov       edx,1
       mov       r8d,2
       call      qword ptr [7FFDF0757048]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       rcx,[rbp-0F8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L09
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-110],rcx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072D028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-110],rax
M01_L10:
       mov       rcx,[rbp-68]
       mov       [rbp-118],rcx
       lea       rcx,[rbp-80]
       mov       [rbp-120],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-110]
       call      qword ptr [7FFDEFF1F360]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Key()
       mov       [rbp-128],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M01_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-130],rcx
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072D0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-130],rax
M01_L12:
       mov       rcx,[rbp-120]
       mov       rdx,[rbp-130]
       mov       r8,[rbp-128]
       call      qword ptr [7FFDF07579F0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rcx,[rbp-80]
       mov       rdx,2ED5E8C0A40
       call      qword ptr [7FFDF0757078]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-138],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072D028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-138],rax
M01_L14:
       lea       rcx,[rbp-80]
       mov       [rbp-140],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-138]
       call      qword ptr [7FFDEFF1F378]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-148],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+38],0
       je        short M01_L15
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+38]
       mov       [rbp-150],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072D190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-150],rax
M01_L16:
       mov       rcx,[rbp-140]
       mov       rdx,[rbp-150]
       mov       r8,[rbp-148]
       call      qword ptr [7FFDF07579F0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-118]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF017C588]; System.Text.StringBuilder.Append(AppendInterpolatedStringHandler ByRef)
       mov       [rbp-158],rax
       nop
       nop
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0C8],rcx
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072D010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0C8],rax
M01_L19:
       lea       rcx,[rbp-48]
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFDF02F7978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       mov       [rbp-0CC],eax
       cmp       dword ptr [rbp-0CC],0
       jne       near ptr M01_L05
       nop
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-168],rax
       mov       rcx,[rbp-168]
       mov       [rbp-20],rcx
       nop
       mov       rcx,rsp
       call      M01_L24
       nop
M01_L20:
       mov       rax,[rbp-20]
       add       rsp,1C0
       pop       rbp
       ret
M01_L21:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-198],rcx
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L22
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+40],0
       je        short M01_L22
       mov       rcx,[rbp-198]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072D1C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L23:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       lea       rcx,[rbp-48]
       mov       rax,[rbp-178]
       call      rax
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L24:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       nop
       mov       rcx,7FFDF01F8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2ACCCC03600
       mov       rcx,[rcx]
       mov       [rbp-188],rcx
       mov       rcx,[rbp-188]
       mov       rdx,[rbp-10]
       mov       rax,[rbp-188]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 1521
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072D788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0757AC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFDF0716FE8]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0717018]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       sub       rsp,1C0
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1A0],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFDF01B7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06ECA88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M01_L03:
       mov       rcx,[rbp-88]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,19482D60008
       call      qword ptr [7FFDF0717198]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       mov       [rbp-8C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-8C],0
       sete      cl
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       je        short M01_L04
       nop
       mov       rcx,19482D60008
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L20
M01_L04:
       mov       rcx,7FFDF01B8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,153F0C055F8
       mov       rcx,[rcx]
       mov       [rbp-180],rcx
       mov       rcx,[rbp-180]
       mov       rax,[rbp-180]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-98],rax
       mov       rdx,[rbp-98]
       mov       [rbp-10],rdx
       nop
       nop
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFEDEE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       vmovdqu   ymm0,ymmword ptr [rbp-0C0]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       rax,[rbp-0A0]
       mov       [rbp-28],rax
       nop
       jmp       near ptr M01_L17
M01_L05:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0D8],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06ED010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L07:
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-0E8]
       mov       r8,[rbp-0D8]
       call      qword ptr [7FFDF02B79A8]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()
       vmovdqu   xmm0,xmmword ptr [rbp-0E8]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C1E0]; System.Text.StringBuilder.get_Length()
       mov       [rbp-0EC],eax
       xor       edx,edx
       cmp       dword ptr [rbp-0EC],0
       setg      dl
       mov       [rbp-5C],edx
       cmp       dword ptr [rbp-5C],0
       je        short M01_L08
       nop
       mov       edx,[rbp+20]
       movzx     edx,dx
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-160],rax
       nop
       nop
M01_L08:
       mov       rcx,[rbp-10]
       mov       [rbp-68],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-108],xmm0
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rcx,[rbp-108]
       mov       r9,[rbp-68]
       mov       edx,1
       mov       r8d,2
       call      qword ptr [7FFDF0717048]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       rcx,[rbp-0F8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L09
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-110],rcx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06ED028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-110],rax
M01_L10:
       mov       rcx,[rbp-68]
       mov       [rbp-118],rcx
       lea       rcx,[rbp-80]
       mov       [rbp-120],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-110]
       call      qword ptr [7FFDEFEDF360]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Key()
       mov       [rbp-128],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M01_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-130],rcx
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06ED0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-130],rax
M01_L12:
       mov       rcx,[rbp-120]
       mov       rdx,[rbp-130]
       mov       r8,[rbp-128]
       call      qword ptr [7FFDF07179F0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rcx,[rbp-80]
       mov       rdx,19482D60A40
       call      qword ptr [7FFDF0717078]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-138],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06ED028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-138],rax
M01_L14:
       lea       rcx,[rbp-80]
       mov       [rbp-140],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-138]
       call      qword ptr [7FFDEFEDF378]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-148],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+38],0
       je        short M01_L15
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+38]
       mov       [rbp-150],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06ED190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-150],rax
M01_L16:
       mov       rcx,[rbp-140]
       mov       rdx,[rbp-150]
       mov       r8,[rbp-148]
       call      qword ptr [7FFDF07179F0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-118]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C588]; System.Text.StringBuilder.Append(AppendInterpolatedStringHandler ByRef)
       mov       [rbp-158],rax
       nop
       nop
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0C8],rcx
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06ED010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0C8],rax
M01_L19:
       lea       rcx,[rbp-48]
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFDF02B7978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       mov       [rbp-0CC],eax
       cmp       dword ptr [rbp-0CC],0
       jne       near ptr M01_L05
       nop
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-168],rax
       mov       rcx,[rbp-168]
       mov       [rbp-20],rcx
       nop
       mov       rcx,rsp
       call      M01_L24
       nop
M01_L20:
       mov       rax,[rbp-20]
       add       rsp,1C0
       pop       rbp
       ret
M01_L21:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-198],rcx
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L22
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+40],0
       je        short M01_L22
       mov       rcx,[rbp-198]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF06ED1C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L23:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       lea       rcx,[rbp-48]
       mov       rax,[rbp-178]
       call      rax
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L24:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       nop
       mov       rcx,7FFDF01B8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,153F0C055F8
       mov       rcx,[rcx]
       mov       [rbp-188],rcx
       mov       rcx,[rbp-188]
       mov       rdx,[rbp-10]
       mov       rax,[rbp-188]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 1521
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06ED788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0717AC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFDF073E8C8]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF073E8F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       sub       rsp,1C0
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1A0],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFDF01B8598],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072C598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M01_L03:
       mov       rcx,[rbp-88]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2A457170008
       call      qword ptr [7FFDF073EA78]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       mov       [rbp-8C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-8C],0
       sete      cl
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       je        short M01_L04
       nop
       mov       rcx,2A457170008
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L20
M01_L04:
       mov       rcx,7FFDF01B8D10
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,263C50055F8
       mov       rcx,[rcx]
       mov       [rbp-180],rcx
       mov       rcx,[rbp-180]
       mov       rax,[rbp-180]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-98],rax
       mov       rdx,[rbp-98]
       mov       [rbp-10],rdx
       nop
       nop
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFEDEE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       vmovdqu   ymm0,ymmword ptr [rbp-0C0]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       rax,[rbp-0A0]
       mov       [rbp-28],rax
       nop
       jmp       near ptr M01_L17
M01_L05:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0D8],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072CB20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L07:
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-0E8]
       mov       r8,[rbp-0D8]
       call      qword ptr [7FFDF02B71F8]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()
       vmovdqu   xmm0,xmmword ptr [rbp-0E8]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C1E0]; System.Text.StringBuilder.get_Length()
       mov       [rbp-0EC],eax
       xor       edx,edx
       cmp       dword ptr [rbp-0EC],0
       setg      dl
       mov       [rbp-5C],edx
       cmp       dword ptr [rbp-5C],0
       je        short M01_L08
       nop
       mov       edx,[rbp+20]
       movzx     edx,dx
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-160],rax
       nop
       nop
M01_L08:
       mov       rcx,[rbp-10]
       mov       [rbp-68],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-108],xmm0
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rcx,[rbp-108]
       mov       r9,[rbp-68]
       mov       edx,1
       mov       r8d,2
       call      qword ptr [7FFDF073E928]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       rcx,[rbp-0F8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L09
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-110],rcx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072CB38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-110],rax
M01_L10:
       mov       rcx,[rbp-68]
       mov       [rbp-118],rcx
       lea       rcx,[rbp-80]
       mov       [rbp-120],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-110]
       call      qword ptr [7FFDEFEDF360]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Key()
       mov       [rbp-128],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M01_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-130],rcx
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072CBE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-130],rax
M01_L12:
       mov       rcx,[rbp-120]
       mov       rdx,[rbp-130]
       mov       r8,[rbp-128]
       call      qword ptr [7FFDF073F2D0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rcx,[rbp-80]
       mov       rdx,2A457170A40
       call      qword ptr [7FFDF073E958]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-138],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072CB38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-138],rax
M01_L14:
       lea       rcx,[rbp-80]
       mov       [rbp-140],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-138]
       call      qword ptr [7FFDEFEDF378]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-148],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+38],0
       je        short M01_L15
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+38]
       mov       [rbp-150],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072CCA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-150],rax
M01_L16:
       mov       rcx,[rbp-140]
       mov       rdx,[rbp-150]
       mov       r8,[rbp-148]
       call      qword ptr [7FFDF073F2D0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-118]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C588]; System.Text.StringBuilder.Append(AppendInterpolatedStringHandler ByRef)
       mov       [rbp-158],rax
       nop
       nop
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0C8],rcx
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072CB20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0C8],rax
M01_L19:
       lea       rcx,[rbp-48]
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFDF02B71C8]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       mov       [rbp-0CC],eax
       cmp       dword ptr [rbp-0CC],0
       jne       near ptr M01_L05
       nop
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-168],rax
       mov       rcx,[rbp-168]
       mov       [rbp-20],rcx
       nop
       mov       rcx,rsp
       call      M01_L24
       nop
M01_L20:
       mov       rax,[rbp-20]
       add       rsp,1C0
       pop       rbp
       ret
M01_L21:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-198],rcx
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L22
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+40],0
       je        short M01_L22
       mov       rcx,[rbp-198]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF072CCD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L23:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       lea       rcx,[rbp-48]
       mov       rax,[rbp-178]
       call      rax
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L24:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       nop
       mov       rcx,7FFDF01B8D10
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,263C50055F8
       mov       rcx,[rcx]
       mov       [rbp-188],rcx
       mov       rcx,[rbp-188]
       mov       rdx,[rbp-10]
       mov       rax,[rbp-188]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 1521
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6EF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072D298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF073F3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFDF083D428]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF083D458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       sub       rsp,1C0
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1A0],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-88],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF0829AA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M01_L03:
       mov       rcx,[rbp-88]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,17E8B770008
       call      qword ptr [7FFDF083D5D8]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       mov       [rbp-8C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-8C],0
       sete      cl
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       je        short M01_L04
       nop
       mov       rcx,17E8B770008
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L20
M01_L04:
       mov       rcx,7FFDF01D8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,13DF9803600
       mov       rcx,[rcx]
       mov       [rbp-180],rcx
       mov       rcx,[rbp-180]
       mov       rax,[rbp-180]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-98],rax
       mov       rdx,[rbp-98]
       mov       [rbp-10],rdx
       nop
       nop
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFEFEE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       vmovdqu   ymm0,ymmword ptr [rbp-0C0]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       rax,[rbp-0A0]
       mov       [rbp-28],rax
       nop
       jmp       near ptr M01_L17
M01_L05:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0D8],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF082A028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L07:
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-0E8]
       mov       r8,[rbp-0D8]
       call      qword ptr [7FFDF02D79A8]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()
       vmovdqu   xmm0,xmmword ptr [rbp-0E8]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C1E0]; System.Text.StringBuilder.get_Length()
       mov       [rbp-0EC],eax
       xor       edx,edx
       cmp       dword ptr [rbp-0EC],0
       setg      dl
       mov       [rbp-5C],edx
       cmp       dword ptr [rbp-5C],0
       je        short M01_L08
       nop
       mov       edx,[rbp+20]
       movzx     edx,dx
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-160],rax
       nop
       nop
M01_L08:
       mov       rcx,[rbp-10]
       mov       [rbp-68],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-108],xmm0
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rcx,[rbp-108]
       mov       r9,[rbp-68]
       mov       edx,1
       mov       r8d,2
       call      qword ptr [7FFDF083D488]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       rcx,[rbp-0F8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L09
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-110],rcx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF082A040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-110],rax
M01_L10:
       mov       rcx,[rbp-68]
       mov       [rbp-118],rcx
       lea       rcx,[rbp-80]
       mov       [rbp-120],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-110]
       call      qword ptr [7FFDEFEFF360]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Key()
       mov       [rbp-128],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M01_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-130],rcx
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF082A0E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-130],rax
M01_L12:
       mov       rcx,[rbp-120]
       mov       rdx,[rbp-130]
       mov       r8,[rbp-128]
       call      qword ptr [7FFDF083DE30]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rcx,[rbp-80]
       mov       rdx,17E8B770A40
       call      qword ptr [7FFDF083D4B8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-138],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF082A040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-138],rax
M01_L14:
       lea       rcx,[rbp-80]
       mov       [rbp-140],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-138]
       call      qword ptr [7FFDEFEFF378]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-148],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+38],0
       je        short M01_L15
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+38]
       mov       [rbp-150],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF082A1A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-150],rax
M01_L16:
       mov       rcx,[rbp-140]
       mov       rdx,[rbp-150]
       mov       r8,[rbp-148]
       call      qword ptr [7FFDF083DE30]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-118]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C588]; System.Text.StringBuilder.Append(AppendInterpolatedStringHandler ByRef)
       mov       [rbp-158],rax
       nop
       nop
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-0C8],rcx
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF082A028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0C8],rax
M01_L19:
       lea       rcx,[rbp-48]
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFDF02D7978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       mov       [rbp-0CC],eax
       cmp       dword ptr [rbp-0CC],0
       jne       near ptr M01_L05
       nop
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-168],rax
       mov       rcx,[rbp-168]
       mov       [rbp-20],rcx
       nop
       mov       rcx,rsp
       call      M01_L24
       nop
M01_L20:
       mov       rax,[rbp-20]
       add       rsp,1C0
       pop       rbp
       ret
M01_L21:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-198],rcx
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L22
       mov       rcx,[rbp-198]
       cmp       qword ptr [rcx+40],0
       je        short M01_L22
       mov       rcx,[rbp-198]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF082A1E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L23:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       lea       rcx,[rbp-48]
       mov       rax,[rbp-178]
       call      rax
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L24:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+1C0]
       nop
       mov       rcx,7FFDF01D8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,13DF9803600
       mov       rcx,[rcx]
       mov       [rbp-188],rcx
       mov       rcx,[rbp-188]
       mov       rdx,[rbp-10]
       mov       rax,[rbp-188]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 1521
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF082A7A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF083DF08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+198]
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF014CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFDF013B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF0725380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L06:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 268
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
       ja        short M01_L01
       test      r8b,18
       je        short M01_L04
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M01_L00:
       ret
M01_L01:
       cmp       r8,40
       ja        short M01_L07
M01_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L05
M01_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L04:
       test      r8b,4
       je        short M01_L06
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       eax,[rax-4]
       mov       [r10-4],eax
       jmp       short M01_L00
M01_L05:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L03
M01_L06:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
M01_L07:
       cmp       r8,800
       ja        short M01_L10
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
       ja        near ptr M01_L02
       jmp       near ptr M01_L03
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFDEFF95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 257
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF014CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF009E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF009E9B8]
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,202FEDF0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF070A960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07253B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+198]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFDF012B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF0715380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L06:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 268
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
       ja        short M01_L00
       test      r8b,18
       je        short M01_L05
       jmp       short M01_L04
M01_L00:
       cmp       r8,40
       ja        short M01_L08
M01_L01:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L02:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L03:
       ret
M01_L04:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L03
M01_L05:
       test      r8b,4
       je        short M01_L07
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       eax,[rax-4]
       mov       [r10-4],eax
       jmp       short M01_L03
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L02
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L02
M01_L07:
       test      r8,r8
       je        short M01_L03
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L03
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L03
M01_L08:
       cmp       r8,800
       ja        short M01_L11
       mov       r9,r8
       shr       r9,6
M01_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L01
       jmp       near ptr M01_L02
M01_L10:
       cmp       rcx,rdx
       je        near ptr M01_L03
M01_L11:
       jmp       qword ptr [7FFDEFF85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF013CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF008E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF008E9B8]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,21BE66B0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06FA960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07153B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+198]
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFDF016B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF0755380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L06:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 268
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
       ja        short M01_L07
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
       je        short M01_L06
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       eax,[rax-4]
       mov       [r10-4],eax
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
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L02
M01_L07:
       cmp       r8,800
       ja        short M01_L10
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
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFDEFFC5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 257
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF017CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0405FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF00CE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF00CE9B8]
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0405EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2C98DAA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF073A960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07553B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+198]
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFDF016B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF0756F40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 272
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
       ja        short M01_L04
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
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L05:
       cmp       r8,800
       ja        near ptr M01_L11
       jmp       short M01_L07
M01_L06:
       test      r8b,4
       je        short M01_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L02
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
       jmp       qword ptr [7FFDEFFC5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF017CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF04057D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF00CE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF00CE9B8]
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF04056F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,29B0D530008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F68C0],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072C710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0756F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+198]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFDF012B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF0716B50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L06:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 268
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
       jmp       qword ptr [7FFDEFF85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF013CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF008E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF008E9B8]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,25F9EA20008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06EC710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0716B80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+198]
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFDF016B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF0756F40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L06:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 268
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
       jmp       qword ptr [7FFDEFFC5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF017CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0405FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF00CE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF00CE9B8]
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFDC4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF0405EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFFCD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,24F257C0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072C710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0756F70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       r8,[rbx+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       r8,[rbx+198]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFDF012B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF07BEF40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 272
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
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
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
       cmp       r8,800
       ja        near ptr M01_L09
       mov       rax,r8
       shr       rax,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
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
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
       jmp       short M01_L02
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
       jmp       qword ptr [7FFDEFF85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF013CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFDF008E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFDF008E9B8]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2C9A6E60008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF078C268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07BEF70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       rcx,[rbx+198]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L03
M00_L00:
       mov       rcx,[rbx+198]
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
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFDF013B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDF082CDB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L01
M00_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFDF014CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L02
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 264
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,21B583E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF0819728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF082CDE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L02
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L02
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M03_L04
       test      r8b,18
       jne       near ptr M03_L08
       test      r8b,4
       jne       near ptr M03_L09
       test      r8,r8
       je        near ptr M03_L07
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L07
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M03_L07
M03_L00:
       cmp       r8,800
       ja        short M03_L03
       mov       r9,r8
       shr       r9,6
M03_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L01
       and       r8,3F
       cmp       r8,10
       ja        short M03_L05
       jmp       short M03_L06
M03_L02:
       cmp       rcx,rdx
       je        short M03_L07
M03_L03:
       jmp       qword ptr [7FFDEFF95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L04:
       cmp       r8,40
       ja        short M03_L00
M03_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M03_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L07:
       ret
M03_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M03_L07
M03_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L07
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFDF014CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFDF009E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFDF009E9B8]
       int       3
; Total bytes of code 315
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFDF0734DC8]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0734E70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,28F09430008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFDF01D8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24E774055F8
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,28F094457F0
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFDF0734EA0]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFDF006EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,28F09445810
       mov       [rbp-78],rax
       call      qword ptr [7FFDF0064270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFDEFE8D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDF006EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFDF01D8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24E774055F8
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF071AC50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0734EB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFDF0745380]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0745428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01E7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,2310DC50008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F07BC055F8
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,2310DC657F0
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFDF0745458]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFDF007EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,2310DC65810
       mov       [rbp-78],rax
       call      qword ptr [7FFDF0074270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFDEFE9D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDF007EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F07BC055F8
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072AC38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0745470]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFDF0736F40]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0736FE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01D7F60],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,27E92440008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFDF01D86D8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23E004055F8
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,27E92455810
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFDF0737018]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFDF006EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,27E92455830
       mov       [rbp-78],rax
       call      qword ptr [7FFDF0064270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFDEFE8D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDF006EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFDF01D86D8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23E004055F8
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D68C0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF070CA00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0737030]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFDF0754DC8]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0754E70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01F7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,20F5F490008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFDF01F8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1CECD4055F8
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,20F5F4A57F0
       cmp       [rcx],ecx
       call      qword ptr [7FFDF017C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFDF0754EA0]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFDF008EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,20F5F4A5810
       mov       [rbp-78],rax
       call      qword ptr [7FFDF0084270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFDEFEAD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF017C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDF008EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFDF017C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFDF01F8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1CECD4055F8
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF073AC38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0754EB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFDF0716F40]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0716FE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01B7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1647FDA0008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFDF01B8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,123EE0055F8
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,1647FDB5810
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFDF0717018]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFDF004EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,1647FDB5830
       mov       [rbp-78],rax
       call      qword ptr [7FFDF0044270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFDEFE6D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDF004EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFDF01B8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,123EE0055F8
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06ECA00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0717030]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFDF0736B50]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0736BF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1E924750008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFDF01D8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A8928055F8
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,1E924765810
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFDF0736C28]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFDF006EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,1E924765830
       mov       [rbp-78],rax
       call      qword ptr [7FFDF0064270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFDEFE8D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDF006EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFDF015C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFDF01D8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A8928055F8
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF070CA00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0736C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFDF073E400]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF073E4A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01B7EF0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,25B48520008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFDF01B8668
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21AB68055F8
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,25B48535860
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFDF059EB98]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFDF004EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,25B48535880
       mov       [rbp-78],rax
       call      qword ptr [7FFDF0044270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFDEFE6D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDF004EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFDF01B8668
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21AB68055F8
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6850],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF071A5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF073E4D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFDF081D380]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF081D428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01C7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1C824180008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFDF01C8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18792403600
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,1C824195860
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFDF05AEB98]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFDF005EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,1C824195880
       mov       [rbp-78],rax
       call      qword ptr [7FFDF0054270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFDEFE7D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDF005EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFDF01C8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18792403600
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF0809A18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF081D458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFDF0726F58]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0726FE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01C7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L02
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-34],ecx
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-34],1
M01_L03:
       mov       ecx,[rbp-34]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L04
       nop
       mov       rcx,20A83420008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L10
M01_L04:
       mov       rcx,7FFDF01C8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C9F14055F8
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-20],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L09
M01_L05:
       mov       rcx,[rbp-20]
       mov       edx,[rbp-24]
       cmp       edx,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       nop
       mov       ecx,[rbp+10]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L07
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C330]
       mov       [rbp-48],rax
       nop
M01_L08:
       nop
       mov       ecx,[rbp-24]
       inc       ecx
       mov       [rbp-24],ecx
M01_L09:
       mov       ecx,[rbp-24]
       mov       rdx,[rbp-20]
       cmp       ecx,[rdx+8]
       jl        short M01_L05
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L11
       nop
M01_L10:
       mov       rax,[rbp-18]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FFDF01C8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C9F14055F8
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 490
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06FC9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0727018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFDF0756F58]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0756FE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01F7F60],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L02
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-34],ecx
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-34],1
M01_L03:
       mov       ecx,[rbp-34]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L04
       nop
       mov       rcx,2CF5E100008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L10
M01_L04:
       mov       rcx,7FFDF01F86D8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,28ECC4055F8
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-20],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L09
M01_L05:
       mov       rcx,[rbp-20]
       mov       edx,[rbp-24]
       cmp       edx,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       nop
       mov       ecx,[rbp+10]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L07
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF017C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF017C330]
       mov       [rbp-48],rax
       nop
M01_L08:
       nop
       mov       ecx,[rbp-24]
       inc       ecx
       mov       [rbp-24],ecx
M01_L09:
       mov       ecx,[rbp-24]
       mov       rdx,[rbp-20]
       cmp       ecx,[rdx+8]
       jl        short M01_L05
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L11
       nop
M01_L10:
       mov       rax,[rbp-18]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FFDF01F86D8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,28ECC4055F8
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 490
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F68C0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072C9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0757018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFDF0745398]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0745428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01E7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L02
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-34],ecx
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-34],1
M01_L03:
       mov       ecx,[rbp-34]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L04
       nop
       mov       rcx,29943120008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L10
M01_L04:
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,258B1403600
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-20],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L09
M01_L05:
       mov       rcx,[rbp-20]
       mov       edx,[rbp-24]
       cmp       edx,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       nop
       mov       ecx,[rbp+10]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L07
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C330]
       mov       [rbp-48],rax
       nop
M01_L08:
       nop
       mov       ecx,[rbp-24]
       inc       ecx
       mov       [rbp-24],ecx
M01_L09:
       mov       ecx,[rbp-24]
       mov       rdx,[rbp-20]
       cmp       ecx,[rdx+8]
       jl        short M01_L05
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L11
       nop
M01_L10:
       mov       rax,[rbp-18]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,258B1403600
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 490
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072ABE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0745458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFDF0716B68]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0716BF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01B7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L02
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-34],ecx
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-34],1
M01_L03:
       mov       ecx,[rbp-34]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L04
       nop
       mov       rcx,21DC8940008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L10
M01_L04:
       mov       rcx,7FFDF01B8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DD36C055F8
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-20],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L09
M01_L05:
       mov       rcx,[rbp-20]
       mov       edx,[rbp-24]
       cmp       edx,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       nop
       mov       ecx,[rbp+10]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L07
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF013C330]
       mov       [rbp-48],rax
       nop
M01_L08:
       nop
       mov       ecx,[rbp-24]
       inc       ecx
       mov       [rbp-24],ecx
M01_L09:
       mov       ecx,[rbp-24]
       mov       rdx,[rbp-20]
       cmp       ecx,[rdx+8]
       jl        short M01_L05
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L11
       nop
M01_L10:
       mov       rax,[rbp-18]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FFDF01B8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DD36C055F8
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 490
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06EC9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0716C28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFDF0756F58]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0756FE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01F7F60],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L02
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-34],ecx
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-34],1
M01_L03:
       mov       ecx,[rbp-34]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L04
       nop
       mov       rcx,26422490008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L10
M01_L04:
       mov       rcx,7FFDF01F86D8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,223904055F8
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-20],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L09
M01_L05:
       mov       rcx,[rbp-20]
       mov       edx,[rbp-24]
       cmp       edx,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       nop
       mov       ecx,[rbp+10]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L07
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF017C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF017C330]
       mov       [rbp-48],rax
       nop
M01_L08:
       nop
       mov       ecx,[rbp-24]
       inc       ecx
       mov       [rbp-24],ecx
M01_L09:
       mov       ecx,[rbp-24]
       mov       rdx,[rbp-20]
       cmp       ecx,[rdx+8]
       jl        short M01_L05
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L11
       nop
M01_L10:
       mov       rax,[rbp-18]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FFDF01F86D8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,223904055F8
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 490
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F68C0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072C9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0757018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFDF0756B68]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0756BF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01F7F70],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L02
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-34],ecx
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-34],1
M01_L03:
       mov       ecx,[rbp-34]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L04
       nop
       mov       rcx,25BBC920008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L10
M01_L04:
       mov       rcx,7FFDF01F86E8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21B2AC055F8
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-20],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L09
M01_L05:
       mov       rcx,[rbp-20]
       mov       edx,[rbp-24]
       cmp       edx,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       nop
       mov       ecx,[rbp+10]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L07
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF017C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF017C330]
       mov       [rbp-48],rax
       nop
M01_L08:
       nop
       mov       ecx,[rbp-24]
       inc       ecx
       mov       [rbp-24],ecx
M01_L09:
       mov       ecx,[rbp-24]
       mov       rdx,[rbp-20]
       cmp       ecx,[rdx+8]
       jl        short M01_L05
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L11
       nop
M01_L10:
       mov       rax,[rbp-18]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FFDF01F86E8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21B2AC055F8
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 490
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F68D0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF072C9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0756C28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFDF07EE838]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF07EE8C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01E7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L02
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-34],ecx
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-34],1
M01_L03:
       mov       ecx,[rbp-34]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L04
       nop
       mov       rcx,18A46110008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L10
M01_L04:
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,149B40055F8
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-20],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L09
M01_L05:
       mov       rcx,[rbp-20]
       mov       edx,[rbp-24]
       cmp       edx,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       nop
       mov       ecx,[rbp+10]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L07
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF016C330]
       mov       [rbp-48],rax
       nop
M01_L08:
       nop
       mov       ecx,[rbp-24]
       inc       ecx
       mov       [rbp-24],ecx
M01_L09:
       mov       ecx,[rbp-24]
       mov       rdx,[rbp-20]
       cmp       ecx,[rdx+8]
       jl        short M01_L05
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L11
       nop
M01_L10:
       mov       rax,[rbp-18]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FFDF01E8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,149B40055F8
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 490
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF075C4C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07EE8F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFDF08157D0]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF0815860]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01C8070],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L02
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-34],ecx
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-34],1
M01_L03:
       mov       ecx,[rbp-34]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L04
       nop
       mov       rcx,18567A40008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L10
M01_L04:
       mov       rcx,7FFDF01C87E8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,144D5C055F8
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-20],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L09
M01_L05:
       mov       rcx,[rbp-20]
       mov       edx,[rbp-24]
       cmp       edx,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       nop
       mov       ecx,[rbp+10]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L07
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF014C330]
       mov       [rbp-48],rax
       nop
M01_L08:
       nop
       mov       ecx,[rbp-24]
       inc       ecx
       mov       [rbp-24],ecx
M01_L09:
       mov       ecx,[rbp-24]
       mov       rdx,[rbp-20]
       cmp       ecx,[rdx+8]
       jl        short M01_L05
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L11
       nop
M01_L10:
       mov       rax,[rbp-18]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FFDF01C87E8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,144D5C055F8
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 490
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C69D0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF07FAED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0815890]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFDF0714E28]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDF0714E70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L00:
       call      qword ptr [7FFDEFED41F8]
       int       3
; Total bytes of code 102
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
       mov       r8,[rsi+198]
       cmp       dword ptr [r8+8],0
       jle       short M01_L04
M01_L00:
       mov       r8,[rsi+198]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,[rsi+198]
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
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01B7FB8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,1DEF5180008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FFDF01B8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19E670055F8
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       [rbp-8],rdx
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FFDF01B8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19E670055F8
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 323
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06FAC58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0714EA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFDF07553E0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDF0755428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L00:
       call      qword ptr [7FFDEFF141F8]
       int       3
; Total bytes of code 102
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
       mov       r8,[rsi+198]
       cmp       dword ptr [r8+8],0
       jle       short M01_L03
M01_L00:
       mov       r8,[rsi+198]
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       [rbx+18],ebp
M01_L02:
       inc       edi
       mov       rcx,[rsi+198]
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
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01F7FB8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,28EEF8C0008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FFDF01F8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24E5DC055F8
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       [rbp-8],rdx
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FFDF01F8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24E5DC055F8
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 323
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F6918],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF073AC58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0755458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFDF0754E28]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDF0754E70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L00:
       call      qword ptr [7FFDEFF141F8]
       int       3
; Total bytes of code 102
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
       mov       r8,[rsi+198]
       cmp       dword ptr [r8+8],0
       jle       short M01_L03
M01_L00:
       mov       r8,[rsi+198]
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       [rbx+18],ebp
M01_L02:
       inc       edi
       mov       rcx,[rsi+198]
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
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01F7FB8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,25561260008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FFDF01F8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,214D34055F8
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       [rbp-8],rdx
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FFDF01F8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,214D34055F8
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 323
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F6918],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF073AC58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0754EA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFDF07353E0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDF0735428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L00:
       call      qword ptr [7FFDEFEF41F8]
       int       3
; Total bytes of code 102
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
       mov       r8,[rsi+198]
       cmp       dword ptr [r8+8],0
       jle       short M01_L04
M01_L00:
       mov       r8,[rsi+198]
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
       call      qword ptr [7FFDEFFA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,[rsi+198]
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
       call      qword ptr [7FFDF015CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,1A27B400008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FFDF01D8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,161E94055F8
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       [rbp-8],rdx
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FFDF01D8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,161E94055F8
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 323
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF071AC40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0735458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFDF0726FA0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDF0726FE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L00:
       call      qword ptr [7FFDEFEE41F8]
       int       3
; Total bytes of code 102
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
       mov       r8,[rsi+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M01_L05
M01_L00:
       mov       r8,[rsi+198]
       cmp       edi,[r8+8]
       jae       near ptr M01_L06
       mov       ecx,edi
       mov       r8,[r8+rcx*8+10]
       cmp       [rbx],bl
       test      r8,r8
       je        short M01_L04
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L04
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M01_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L02
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       [rbx+18],ebp
       jmp       short M01_L04
M01_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L01
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L01
M01_L03:
       mov       rcx,rbx
       call      qword ptr [7FFDF014CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L04:
       inc       edi
       mov       rax,[rsi+198]
       cmp       [rax+8],edi
       jg        near ptr M01_L00
M01_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01C7FB8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,21A54800008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FFDF01C8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D9C28055F8
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       [rbp-8],rdx
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FFDF01C8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D9C28055F8
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 323
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6918],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06FCA08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0727018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFDF0726FA0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDF0726FE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L00:
       call      qword ptr [7FFDEFEE41F8]
       int       3
; Total bytes of code 102
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
       mov       r8,[rsi+198]
       cmp       dword ptr [r8+8],0
       jle       short M01_L03
M01_L00:
       mov       r8,[rsi+198]
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
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       [rbx+18],ebp
M01_L02:
       inc       edi
       mov       rax,[rsi+198]
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
       call      qword ptr [7FFDF014CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 182
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01C7EB8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,242F5B50008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FFDF01C8630
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20263C055F8
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       [rbp-8],rdx
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FFDF01C8630
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20263C055F8
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 323
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6818],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06FCA08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0727018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFDF0716FA0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDF0716FE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L00:
       call      qword ptr [7FFDEFED41F8]
       int       3
; Total bytes of code 102
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
       mov       r8,[rsi+198]
       cmp       dword ptr [r8+8],0
       jle       short M01_L03
M01_L00:
       mov       r8,[rsi+198]
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
       call      qword ptr [7FFDEFF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       [rbx+18],ebp
M01_L02:
       inc       edi
       mov       rcx,[rsi+198]
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
       call      qword ptr [7FFDF013CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01B7FB8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,22D62F10008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FFDF01B8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1ECD10055F8
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       [rbp-8],rdx
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FFDF01B8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1ECD10055F8
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 323
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B6918],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF06ECA08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0717018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFDF085D3E0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDF085D428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L00:
       call      qword ptr [7FFDEFF141F8]
       int       3
; Total bytes of code 102
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
       mov       r8,[rsi+198]
       cmp       dword ptr [r8+8],0
       jle       short M01_L03
M01_L00:
       mov       r8,[rsi+198]
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
       mov       rdx,[rsi+198]
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
       call      qword ptr [7FFDEFFC5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFDF017CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01F7FB8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,281ED7F0008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FFDF01F8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2415B8055F8
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       [rbp-8],rdx
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FFDF01F8730
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2415B8055F8
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 323
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F6918],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0224B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF0849A20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF085D458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

