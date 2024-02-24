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
       call      qword ptr [7FFC2001C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,197F9F452C4
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
       mov       r8,15768000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,197F9F452D8
       call      qword ptr [7FFC1FF34810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L07:
       mov       [rsi+18],ebp
       jmp       short M00_L03
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFC2001C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L05
M00_L10:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC1FD07738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFC205FFC18]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC200A6CE8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC200A7180]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE6D470]
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
       mov       rax,0F368B7F9D09F
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
       call      qword ptr [7FFC1FF34228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,0F368B7F9D09F
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
       call      qword ptr [7FFC1FF1FD20]
       mov       rcx,0F368B7F9D09F
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
       call      qword ptr [7FFC1FEEF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFC1FEEF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFC205CE880]
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
       mov       r9,15768000298
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
       call      qword ptr [7FFC2054F8B8]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFC2054D6B0]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFC205C4330]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFC2054F9C0]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFC1FE6C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,15768001DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC20093A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0F368B7F9D09F
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
       call      qword ptr [7FFC1FF1FE40]
       mov       rcx,0F368B7F9D09F
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC200A6EE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,197F9F30008
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
       jb        near ptr M04_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M04_L01
       test      r8b,18
       jne       short M04_L05
       test      r8b,4
       je        short M04_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L04
M04_L00:
       test      r8,r8
       je        short M04_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L04
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M04_L04
M04_L01:
       cmp       r8,40
       ja        short M04_L07
M04_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L06
M04_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M04_L04:
       ret
M04_L05:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M04_L04
M04_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L03
M04_L07:
       cmp       r8,800
       ja        short M04_L09
       mov       r9,r8
       shr       r9,6
M04_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L08
       and       r8,3F
       cmp       r8,10
       ja        short M04_L02
       jmp       short M04_L03
M04_L09:
       jmp       qword ptr [7FFC1FE65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L10:
       cmp       rcx,rdx
       je        short M04_L04
       jmp       short M04_L09
; Total bytes of code 250
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2001CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC200A6FB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFC1FF5E9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFC1FF5E9B8]
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
       call      qword ptr [7FFC7F7685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC7F751D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FFC1FFFC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1B86C0552C4
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
       mov       r8,177DA000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1B86C0552D8
       call      qword ptr [7FFC1FF24810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FFEB060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC1FFFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FFC1FFFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L05
M00_L10:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFC1FFFC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFC1FCF7738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFC1FC54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFC205CF240]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC20285500]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC20285998]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE5D470]
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
       mov       rax,0AC3D742CF17A
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
       call      qword ptr [7FFC1FF24228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,0AC3D742CF17A
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
       call      qword ptr [7FFC1FF0FD20]
       mov       rcx,0AC3D742CF17A
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
       call      qword ptr [7FFC1FEDF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFC1FEDF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFC205C5BA8]
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
       mov       r9,177DA000298
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
       call      qword ptr [7FFC20557198]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFC20554F90]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFC20587828]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFC205572A0]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFC1FE5C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,177DA001DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC20072C90]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0AC3D742CF17A
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
       call      qword ptr [7FFC1FF0FE40]
       mov       rcx,0AC3D742CF17A
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
       jb        near ptr M03_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L08
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       jne       short M03_L05
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
       cmp       r8,800
       jbe       short M03_L06
M03_L02:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFC1FE55B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L03:
       cmp       r8,40
       jbe       short M03_L09
       jmp       short M03_L01
M03_L04:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M03_L00
M03_L05:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M03_L00
M03_L06:
       mov       rax,r8
       shr       rax,6
M03_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M03_L07
       and       r8,3F
       cmp       r8,10
       ja        short M03_L09
       jmp       short M03_L10
M03_L08:
       cmp       rcx,rdx
       je        short M03_L00
       jmp       short M03_L02
M03_L09:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L10
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L10
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M03_L10:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       near ptr M03_L00
; Total bytes of code 257
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
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202856F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,1B86C040008
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
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC1FFFCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202857D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFC1FF4E9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFC1FF4E9B8]
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
       call      qword ptr [7FFC7F7685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC7F751D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FFC2003C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,2E75B3552C4
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
       mov       r8,2A6C9400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2E75B3552D8
       call      qword ptr [7FFC1FF64810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2002B060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC2003CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FFC2003CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L05
M00_L10:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFC2003C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFC1FD37738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFC2060EF70]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202C5CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202C6190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE9D470]
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
       mov       rax,4505504F2D37
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
       call      qword ptr [7FFC1FF64228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,4505504F2D37
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
       call      qword ptr [7FFC1FF4FD20]
       mov       rcx,4505504F2D37
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
       call      qword ptr [7FFC1FF1F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFC1FF1F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFC20605BA8]
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
       mov       r9,2A6C9400298
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
       call      qword ptr [7FFC20597198]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFC20594F90]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFC205C7828]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFC205972A0]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFC1FE9C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,2A6C9401DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC200B3A48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,4505504F2D37
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
       call      qword ptr [7FFC1FF4FE40]
       mov       rcx,4505504F2D37
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
       jmp       qword ptr [7FFC1FE95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       ja        short M03_L11
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
M03_L11:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L06
; Total bytes of code 263
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,2E75B340008
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2003CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFC1FF8E9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFC1FF8E9B8]
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
       call      qword ptr [7FFC7F7685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC7F751D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FFC20077108]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,240B90C52C4
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
       mov       r8,2002B400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,240B90C52D8
       call      qword ptr [7FFC1FF44810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2005FB70]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC20077A50]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FFC20077A50]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L05
M00_L10:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFC200773A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       mov       ecx,esi
       mov       rdx,240B90B0390
       call      qword ptr [7FFC200EC6C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFC1FD17738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A6190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
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
       mov       rax,0C76B3FA513E6
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
       call      qword ptr [7FFC1FF44228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,0C76B3FA513E6
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
       call      qword ptr [7FFC1FF2FD20]
       mov       rcx,0C76B3FA513E6
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
       call      qword ptr [7FFC1FEFF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFC1FEFF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFC205E5BA8]
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
       mov       r9,2002B400298
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
       call      qword ptr [7FFC20577198]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFC20574F90]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFC205A7828]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFC205772A0]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFC1FE7C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,2002B401D68
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC1FFB6590]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0C76B3FA513E6
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
       call      qword ptr [7FFC1FF2FE40]
       mov       rcx,0C76B3FA513E6
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
       jmp       qword ptr [7FFC1FE75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       ja        short M03_L11
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
M03_L11:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L06
; Total bytes of code 263
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,240B90B0008
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC20077B10]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFC1FF6E9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFC1FF6E9B8]
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
       call      qword ptr [7FFC7F7685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC7F751D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FFC2002C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,2782DD65314
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
       mov       r8,2379BC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2782DD65328
       call      qword ptr [7FFC1FF54810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,rsi
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFC2002C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       mov       rdx,2782DD50390
       call      qword ptr [7FFC201240D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFC1FD27738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B5CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B6190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
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
       mov       rax,77A0E7D5A72
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
       call      qword ptr [7FFC1FF54228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,77A0E7D5A72
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
       call      qword ptr [7FFC1FF3FD20]
       mov       rcx,77A0E7D5A72
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
       call      qword ptr [7FFC1FF0F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFC1FF0F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFC206F72B8]
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
       mov       r9,2379BC00298
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
       call      qword ptr [7FFC2060C678]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFC20606328]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFC206CCD38]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFC2060C780]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFC1FE8C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,2379BC01DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC200A3A48]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,77A0E7D5A72
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
       call      qword ptr [7FFC1FF3FE40]
       mov       rcx,77A0E7D5A72
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2782DD50008
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2002CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFC1FF7E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFC1FF7E9B8]
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
       jmp       qword ptr [7FFC1FE85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC7F7685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC7F751D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FFC1FFFC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,2168339533C
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
       mov       r8,1D5F1400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,21683395350
       call      qword ptr [7FFC1FF24810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFC1FFEB060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC1FFFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,rsi
       call      qword ptr [7FFC1FFFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFC1FFFC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFC1FCF7738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFC1FC54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFC204951B8]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC20285CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC20286190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE5D470]
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
       mov       rax,41CA008217B4
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
       call      qword ptr [7FFC1FF24228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,41CA008217B4
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
       call      qword ptr [7FFC1FF0FD20]
       mov       rcx,41CA008217B4
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
       call      qword ptr [7FFC1FEDF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFC1FEDF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFC206D7618]
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
       mov       r9,1D5F1400298
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
       call      qword ptr [7FFC2066CCF0]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFC20666AD8]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFC206AD488]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFC2066CDF8]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFC1FE5C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,1D5F1401DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC20073A48]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,41CA008217B4
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
       call      qword ptr [7FFC1FF0FE40]
       mov       rcx,41CA008217B4
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
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC20285EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,21683380008
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
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC1FFFCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC20285FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFC1FF4E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFC1FF4E9B8]
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
       jmp       qword ptr [7FFC1FE55B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC7F7685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC7F751D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FFC2000C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,243E619533C
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
       mov       r8,20354000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,243E6195350
       call      qword ptr [7FFC1FF34810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFC1FFFB060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC2000CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,rsi
       call      qword ptr [7FFC2000CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFC2000C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFC1FD07738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFC204A4AF8]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC20295500]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC20295998]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE6D470]
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
       mov       rax,0B678848F1DC3
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
       call      qword ptr [7FFC1FF34228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,0B678848F1DC3
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
       call      qword ptr [7FFC1FF1FD20]
       mov       rcx,0B678848F1DC3
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
       call      qword ptr [7FFC1FEEF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFC1FEEF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFC206EC870]
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
       mov       r9,20354000298
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
       call      qword ptr [7FFC2067D8F0]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFC206776D8]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFC206BDD40]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFC2067D9F8]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFC1FE6C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,20354001DB8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC20069A40]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0B678848F1DC3
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
       call      qword ptr [7FFC1FF1FE40]
       mov       rcx,0B678848F1DC3
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202956F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,243E6180008
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2000CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202957D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFC1FF5E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFC1FF5E9B8]
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
       jmp       qword ptr [7FFC1FE65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC7F7685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC7F751D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FFC2001C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,19A4F3A533C
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
       mov       r8,159BD400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,19A4F3A5350
       call      qword ptr [7FFC1FF44810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,rsi
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFC2001C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFC1FD17738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFC204B5158]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A6190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
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
       mov       rax,59FE8CDE9482
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
       call      qword ptr [7FFC1FF44228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,59FE8CDE9482
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
       call      qword ptr [7FFC1FF2FD20]
       mov       rcx,59FE8CDE9482
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
       call      qword ptr [7FFC1FEFF8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFC1FEFF348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFC206F7618]
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
       mov       r9,159BD400298
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
       call      qword ptr [7FFC2068CCF0]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFC20686AD8]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFC206CD488]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFC2068CDF8]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFC1FE7C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,159BD401DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC20093A48]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,59FE8CDE9482
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
       call      qword ptr [7FFC1FF2FE40]
       mov       rcx,59FE8CDE9482
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,19A4F390008
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2001CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFC1FF6E9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFC1FF6E9B8]
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
       je        short M05_L04
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
M05_L00:
       pop       rbx
       pop       rsi
       ret
M05_L01:
       cmp       r8,40
       ja        short M05_L05
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
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M05_L00
M05_L04:
       test      r8b,4
       jne       short M05_L06
       test      r8,r8
       je        short M05_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L00
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       short M05_L00
M05_L05:
       cmp       r8,800
       ja        short M05_L09
       jmp       short M05_L07
M05_L06:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
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
       ja        near ptr M05_L02
       jmp       short M05_L03
M05_L09:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFC1FE75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L10:
       cmp       rcx,rdx
       je        near ptr M05_L00
       jmp       short M05_L09
; Total bytes of code 262
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
       call      qword ptr [7FFC7F7685A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC7F751D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
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
       jle       short M00_L05
M00_L00:
       mov       r8d,ebp
       mov       r8,[rdi+r8*8+10]
       test      r8,r8
       je        short M00_L04
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M00_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L02
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L01:
       mov       [rsi+18],r15d
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
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 262
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
       jmp       qword ptr [7FFC1FE85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2002CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFC1FF7E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFC1FF7E9B8]
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1CE199D0008
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
       jle       short M00_L05
M00_L00:
       mov       r8d,ebp
       mov       r8,[rdi+r8*8+10]
       test      r8,r8
       je        short M00_L04
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M00_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L02
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L01:
       mov       [rsi+18],r15d
       jmp       short M00_L04
M00_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L06
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFC2003CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFC2002B060]; System.Text.StringBuilder.ToString()
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
M00_L06:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L01
; Total bytes of code 262
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
       jmp       qword ptr [7FFC1FE95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2003CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFC1FF8E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFC1FF8E9B8]
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,23FAC220008
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
       jle       short M00_L05
M00_L00:
       mov       r8d,ebp
       mov       r8,[rdi+r8*8+10]
       test      r8,r8
       je        short M00_L04
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M00_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L02
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L01:
       mov       [rsi+18],r15d
       jmp       short M00_L04
M00_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L06
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFC2003CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFC2002B060]; System.Text.StringBuilder.ToString()
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
M00_L06:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L01
; Total bytes of code 262
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
       jmp       qword ptr [7FFC1FE95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2003CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFC1FF8E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFC1FF8E9B8]
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,202BD2C0008
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
       jle       short M00_L05
M00_L00:
       mov       r8d,ebp
       mov       r8,[rdi+r8*8+10]
       test      r8,r8
       je        short M00_L04
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M00_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L02
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L01:
       mov       [rsi+18],r15d
       jmp       short M00_L04
M00_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M00_L06
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFC2003CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFC2002B060]; System.Text.StringBuilder.ToString()
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
M00_L06:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L01
; Total bytes of code 262
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
       jmp       qword ptr [7FFC1FE95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2003CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFC1FF8E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFC1FF8E9B8]
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,24EFAE90008
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
       jle       short M00_L03
M00_L00:
       mov       ecx,ebp
       mov       rcx,[rdi+rcx*8+10]
       test      rcx,rcx
       je        short M00_L02
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M00_L02
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
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
       mov       [rsi+18],r15d
M00_L02:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFC1FFFB060]; System.Text.StringBuilder.ToString()
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
M00_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L01
M00_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFC2000CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L02
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC20295EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,1D8B9810008
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
       jmp       qword ptr [7FFC1FE65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2000CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC20295FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFC1FF5E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFC1FF5E9B8]
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
       jle       short M00_L03
M00_L00:
       mov       ecx,ebp
       mov       rcx,[rdi+rcx*8+10]
       test      rcx,rcx
       je        short M00_L02
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M00_L02
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
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
       mov       [rsi+18],r15d
M00_L02:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
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
M00_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L01
M00_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L02
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,296B6C70008
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
       jmp       qword ptr [7FFC1FE75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2001CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFC1FF6E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFC1FF6E9B8]
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
       jle       short M00_L03
M00_L00:
       mov       ecx,ebp
       mov       rcx,[rdi+rcx*8+10]
       test      rcx,rcx
       je        short M00_L02
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M00_L02
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
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
       mov       [rsi+18],r15d
M00_L02:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
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
M00_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L01
M00_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L02
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,27A7B580008
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
       jmp       qword ptr [7FFC1FE75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2001CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFC1FF6E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFC1FF6E9B8]
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
       jle       short M00_L03
M00_L00:
       mov       ecx,ebp
       mov       rcx,[rdi+rcx*8+10]
       test      rcx,rcx
       je        short M00_L02
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M00_L02
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
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
       mov       [rsi+18],r15d
M00_L02:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
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
M00_L04:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L01
M00_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L02
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,3141ED30008
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
       jmp       qword ptr [7FFC1FE75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2001CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFC1FF6E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFC1FF6E9B8]
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2000CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFC1FFFB060]; System.Text.StringBuilder.ToString()
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
       jmp       qword ptr [7FFC1FE65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2000CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC20295FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFC1FF5E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFC1FF5E9B8]
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC20295EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2264AAD0008
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
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
       jmp       qword ptr [7FFC1FE85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2002CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFC1FF7E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFC1FF7E9B8]
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2A9064F0008
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
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
       jmp       qword ptr [7FFC1FE85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2002CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFC1FF7E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFC1FF7E9B8]
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,32B706F0008
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
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
       jmp       qword ptr [7FFC1FE75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2001CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A57D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFC1FF6E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFC1FF6E9B8]
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2E01A620008
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+1A0]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
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
       jmp       qword ptr [7FFC1FE75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2001CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFC1FF6E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFC1FF6E9B8]
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,261124E0008
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
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,2ADE8570008
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
       jmp       qword ptr [7FFC1FE85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2002CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B57D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFC1FF7E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFC1FF7E9B8]
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
       call      qword ptr [7FFC2002B060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFC2003CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,23CA9500008
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
       jmp       qword ptr [7FFC1FE95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2003CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202C5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFC1FF8E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFC1FF8E9B8]
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
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,296DA600008
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
       jmp       qword ptr [7FFC1FE85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC2002CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC1FC84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFC202B5FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC1FE8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFC1FF7E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFC1FF7E9B8]
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
       call      qword ptr [7FFC205F4198]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L04
       mov       rdx,20CE7C052F8
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-38],rdx
       cmp       qword ptr [rbp-38],0
       jne       near ptr M01_L19
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-38]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC20435290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L21
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L20
       xor       ecx,ecx
       mov       [rbp-38],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L24
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L22
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L23
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
       mov       [rbp-38],rcx
       mov       [rbp-40],r15
       jmp       short M01_L05
M01_L04:
       mov       rax,24D759B0008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdx,24D759C52A4
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L09
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
       mov       esi,r14d
       test      rsi,rsi
       jle       near ptr M01_L14
M01_L07:
       cmp       edi,r14d
       jae       short M01_L08
       mov       ecx,edi
       lea       rcx,[rbx+rcx+10]
       mov       r8,20CE7C00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,24D759C52B8
       call      qword ptr [7FFC1FF44810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L11
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L11
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        short M01_L10
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L12
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L13
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L10:
       mov       rcx,r15
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L11:
       add       edi,1
       jo        short M01_L16
       movsxd    rcx,edi
       cmp       rsi,rcx
       jg        near ptr M01_L07
       jmp       short M01_L14
M01_L12:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L13:
       mov       [r15+18],r13d
       jmp       short M01_L11
M01_L14:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       cmp       [rdx+8],eax
       jbe       short M01_L17
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
M01_L15:
       mov       rcx,r15
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M01_L18
M01_L16:
       call      CORINFO_HELP_OVERFLOW
M01_L17:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFC2001C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L15
M01_L18:
       mov       rcx,rsp
       call      M01_L26
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
M01_L19:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       je        short M01_L25
       jmp       near ptr M01_L00
M01_L20:
       lea       rdx,[rbp-38]
       mov       rcx,rdi
       call      qword ptr [7FFC20434DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L21:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L25
M01_L22:
       mov       ecx,13C20
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFC205FD818]
       int       3
M01_L23:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L24:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L25:
       mov       r15,[rbp-38]
       jmp       near ptr M01_L03
M01_L26:
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
       mov       rcx,20CE7C052F8
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L27
       mov       r15,[rbp-40]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rbx+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L31
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC2001C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L28
M01_L27:
       mov       r15,[rbp-40]
       mov       rdx,r15
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L31
M01_L28:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L29
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L31
M01_L29:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L30
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC20434D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L31
M01_L30:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L31:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 985
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
       call      qword ptr [7FFC205AFE10]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L04
       mov       rdx,255268052F8
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-38],rdx
       cmp       qword ptr [rbp-38],0
       jne       near ptr M01_L19
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-38]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC20435290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L21
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L20
       xor       ecx,ecx
       mov       [rbp-38],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L24
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L22
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L23
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
       mov       [rbp-38],rcx
       mov       [rbp-40],r15
       jmp       short M01_L05
M01_L04:
       mov       rax,295B88A0008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdx,295B88B52A4
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L09
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
       mov       esi,r14d
       test      rsi,rsi
       jle       near ptr M01_L14
M01_L07:
       cmp       edi,r14d
       jae       short M01_L08
       mov       ecx,edi
       lea       rcx,[rbx+rcx+10]
       mov       r8,25526800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,295B88B52B8
       call      qword ptr [7FFC1FF44810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L11
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L11
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        short M01_L10
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L12
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L13
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L10:
       mov       rcx,r15
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L11:
       add       edi,1
       jo        short M01_L16
       movsxd    rcx,edi
       cmp       rsi,rcx
       jg        near ptr M01_L07
       jmp       short M01_L14
M01_L12:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L13:
       mov       [r15+18],r13d
       jmp       short M01_L11
M01_L14:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       cmp       [rdx+8],eax
       jbe       short M01_L17
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
M01_L15:
       mov       rcx,r15
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M01_L18
M01_L16:
       call      CORINFO_HELP_OVERFLOW
M01_L17:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFC2001C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L15
M01_L18:
       mov       rcx,rsp
       call      M01_L26
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
M01_L19:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       je        short M01_L25
       jmp       near ptr M01_L00
M01_L20:
       lea       rdx,[rbp-38]
       mov       rcx,rdi
       call      qword ptr [7FFC20434DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L21:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L25
M01_L22:
       mov       ecx,13C20
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFC205FD578]
       int       3
M01_L23:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L24:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L25:
       mov       r15,[rbp-38]
       jmp       near ptr M01_L03
M01_L26:
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
       mov       rcx,255268052F8
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L27
       mov       r15,[rbp-40]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rbx+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L31
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC2001C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L28
M01_L27:
       mov       r15,[rbp-40]
       mov       rdx,r15
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L31
M01_L28:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L29
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L31
M01_L29:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L30
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC20434D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L31
M01_L30:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L31:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 985
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
       call      qword ptr [7FFC205E5848]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L04
       mov       rdx,2CB68C03300
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-38],rdx
       cmp       qword ptr [rbp-38],0
       jne       near ptr M01_L19
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-38]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC20435290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L21
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L20
       xor       ecx,ecx
       mov       [rbp-38],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L24
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L22
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L23
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
       mov       [rbp-38],rcx
       mov       [rbp-40],r15
       jmp       short M01_L05
M01_L04:
       mov       rax,30BFAC60008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdx,30BFAC752C4
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L09
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
       mov       esi,r14d
       test      rsi,rsi
       jle       near ptr M01_L14
M01_L07:
       cmp       edi,r14d
       jae       short M01_L08
       mov       ecx,edi
       lea       rcx,[rbx+rcx+10]
       mov       r8,2CB6CC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,30BFAC752D8
       call      qword ptr [7FFC1FF44810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L11
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L11
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        short M01_L10
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L12
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L13
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L10:
       mov       rcx,r15
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L11:
       add       edi,1
       jo        short M01_L16
       movsxd    rcx,edi
       cmp       rsi,rcx
       jg        near ptr M01_L07
       jmp       short M01_L14
M01_L12:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L13:
       mov       [r15+18],r13d
       jmp       short M01_L11
M01_L14:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       cmp       [rdx+8],eax
       jbe       short M01_L17
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
M01_L15:
       mov       rcx,r15
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M01_L18
M01_L16:
       call      CORINFO_HELP_OVERFLOW
M01_L17:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFC2001C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L15
M01_L18:
       mov       rcx,rsp
       call      M01_L26
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
M01_L19:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       je        short M01_L25
       jmp       near ptr M01_L00
M01_L20:
       lea       rdx,[rbp-38]
       mov       rcx,rdi
       call      qword ptr [7FFC20434DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L21:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L25
M01_L22:
       mov       ecx,13C20
       mov       rdx,7FFC1FC74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFC205EEEC8]
       int       3
M01_L23:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L24:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L25:
       mov       r15,[rbp-38]
       jmp       near ptr M01_L03
M01_L26:
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
       mov       rcx,2CB68C03300
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L27
       mov       r15,[rbp-40]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rbx+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L31
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC2001C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L28
M01_L27:
       mov       r15,[rbp-40]
       mov       rdx,r15
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L31
M01_L28:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L29
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L31
M01_L29:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L30
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC20434D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L31
M01_L30:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L31:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 985
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
       call      qword ptr [7FFC205FC198]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L04
       mov       rdx,1F26EC03300
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-38],rdx
       cmp       qword ptr [rbp-38],0
       jne       near ptr M01_L19
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-38]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC20425290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L21
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L20
       xor       ecx,ecx
       mov       [rbp-38],rcx
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
       mov       ecx,r14d
       mov       rdx,23300A29CB0
       call      qword ptr [7FFC201040D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       mov       [rbp-38],rcx
       mov       [rbp-40],r15
       jmp       short M01_L05
M01_L04:
       mov       rax,23300A20008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdx,23300A35314
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L09
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
       mov       esi,r14d
       test      rsi,rsi
       jle       near ptr M01_L14
M01_L07:
       cmp       edi,r14d
       jae       short M01_L08
       mov       ecx,edi
       lea       rcx,[rbx+rcx+10]
       mov       r8,1F272C00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,23300A35328
       call      qword ptr [7FFC1FF34810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L11
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L11
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        short M01_L10
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L12
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L13
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFC2000CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L10:
       mov       rcx,r15
       call      qword ptr [7FFC2000CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L11:
       add       edi,1
       jo        short M01_L16
       movsxd    rcx,edi
       cmp       rsi,rcx
       jg        near ptr M01_L07
       jmp       short M01_L14
M01_L12:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L13:
       mov       [r15+18],r13d
       jmp       short M01_L11
M01_L14:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       cmp       [rdx+8],eax
       jbe       short M01_L17
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
M01_L15:
       mov       rcx,r15
       call      qword ptr [7FFC1FFFB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M01_L18
M01_L16:
       call      CORINFO_HELP_OVERFLOW
M01_L17:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFC2000C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L15
M01_L18:
       mov       rcx,rsp
       call      M01_L25
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
M01_L19:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       je        short M01_L24
       jmp       near ptr M01_L00
M01_L20:
       lea       rdx,[rbp-38]
       mov       rcx,rdi
       call      qword ptr [7FFC20424DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L21:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L24
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
       mov       r15,[rbp-38]
       jmp       near ptr M01_L03
M01_L25:
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
       mov       rcx,1F26EC03300
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L26
       mov       r15,[rbp-40]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rbx+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L30
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC2000C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L27
M01_L26:
       mov       r15,[rbp-40]
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
       call      qword ptr [7FFC20424D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L30
M01_L29:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L30:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
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
       call      qword ptr [7FFC207075D0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L16
       mov       rcx,1BC53003300
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
       mov       rdi,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rdi
       mov       rdx,1FCE50B5314
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L07
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rdi+18],r8d
M01_L02:
       xor       r14d,r14d
       mov       r15d,[rbx+8]
       mov       r13d,r15d
       test      r13,r13
       jle       near ptr M01_L11
M01_L03:
       cmp       r14d,r15d
       jae       short M01_L05
       mov       ecx,r14d
       lea       rcx,[rbx+rcx+10]
       mov       r8,1BC57000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1FCE50B5328
       call      qword ptr [7FFC1FF64810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        short M01_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L08
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L06
M01_L04:
       mov       [rdi+18],r12d
       jmp       short M01_L10
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L04
M01_L07:
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFC2003CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L02
M01_L08:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L09:
       mov       rcx,rdi
       call      qword ptr [7FFC2003CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       add       r14d,1
       jo        short M01_L13
       movsxd    rcx,r14d
       cmp       r13,rcx
       jg        near ptr M01_L03
M01_L11:
       mov       ecx,[rdi+18]
       mov       eax,ecx
       mov       rdx,[rdi+8]
       cmp       [rdx+8],eax
       jbe       short M01_L14
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
M01_L12:
       mov       rcx,rdi
       call      qword ptr [7FFC2002B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L15
M01_L13:
       call      CORINFO_HELP_OVERFLOW
M01_L14:
       mov       rcx,rdi
       mov       edx,27
       call      qword ptr [7FFC2003C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L12
M01_L15:
       mov       rcx,rsp
       call      M01_L24
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
M01_L16:
       mov       rax,1FCE50A0008
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
M01_L17:
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L18:
       mov       r14,[rsi+8]
       mov       rcx,7FFC20451338
       cmp       [r14+18],rcx
       jne       short M01_L21
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFC2003C0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
M01_L19:
       jmp       near ptr M01_L01
M01_L20:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC20455290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M01_L23
       cmp       qword ptr [r14+10],0
       jne       short M01_L22
       jmp       short M01_L17
M01_L21:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rdi,rax
       jmp       short M01_L19
M01_L22:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFC20454DB0]
       test      eax,eax
       je        near ptr M01_L18
M01_L23:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
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
       lea       rbp,[rbp+80]
       mov       rcx,1BC53003300
       mov       rdi,[rcx]
       mov       rsi,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L25
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L29
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC2003C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L26
M01_L25:
       mov       rbx,[rbp-48]
       mov       rdx,rbx
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L29
M01_L26:
       cmp       qword ptr [rdi+20],0
       jne       short M01_L27
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L29
M01_L27:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M01_L28
       mov       r12,[rdi+18]
       mov       rcx,[r12+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC204552C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L29
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [7FFC20454D80]
       jmp       short M01_L29
M01_L28:
       add       rdi,2C
       lock dec  dword ptr [rdi]
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
; Total bytes of code 888
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
       call      qword ptr [7FFC207074E0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L16
       mov       rcx,22A59C052F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L18
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L18
M01_L00:
       mov       rsi,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rsi
       mov       rdx,26AEBC6533C
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L07
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
       mov       r12d,r13d
       test      r12,r12
       jle       near ptr M01_L11
M01_L03:
       cmp       r15d,r13d
       jae       short M01_L05
       mov       ecx,r15d
       lea       rcx,[rbx+rcx+10]
       mov       r8,22A59C00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,26AEBC65350
       call      qword ptr [7FFC1FF54810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        short M01_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L08
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L06
M01_L04:
       mov       [rsi+18],edi
       jmp       short M01_L10
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L04
M01_L07:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L02
M01_L08:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       add       r15d,1
       jo        short M01_L13
       movsxd    rcx,r15d
       cmp       r12,rcx
       jg        near ptr M01_L03
M01_L11:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       cmp       [rdx+8],eax
       jbe       short M01_L14
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M01_L12:
       mov       rcx,rsi
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L15
M01_L13:
       call      CORINFO_HELP_OVERFLOW
M01_L14:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFC2002C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L12
M01_L15:
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
M01_L16:
       mov       rax,26AEBC50008
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
M01_L17:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L18:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC20445290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L20
       jmp       short M01_L17
M01_L19:
       mov       rdx,[rsi+8]
       mov       rcx,[rdx+8]
       call      qword ptr [rdx+18]
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L20:
       cmp       qword ptr [r14+10],0
       jne       short M01_L21
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L19
M01_L21:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFC20444DB0]
       test      eax,eax
       je        short M01_L19
       jmp       short M01_L17
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
       mov       rcx,22A59C052F8
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,7FFC20441350
       cmp       [rax+18],rcx
       jne       short M01_L23
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L27
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC2002C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L24
M01_L23:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L27
M01_L24:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L27
M01_L25:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L26
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC204452C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L27
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC20444D80]
       jmp       short M01_L27
M01_L26:
       add       rsi,2C
       lock dec  dword ptr [rsi]
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
; Total bytes of code 827
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
       call      qword ptr [7FFC2070C198]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L16
       mov       rcx,2480BC052F8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L18
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L18
M01_L00:
       mov       rsi,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rsi
       mov       rdx,2889DB2533C
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L07
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
       mov       r12d,r13d
       test      r12,r12
       jle       near ptr M01_L11
M01_L03:
       cmp       r15d,r13d
       jae       short M01_L05
       mov       ecx,r15d
       lea       rcx,[rbx+rcx+10]
       mov       r8,2480BC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2889DB25350
       call      qword ptr [7FFC1FF54810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        short M01_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L08
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L06
M01_L04:
       mov       [rsi+18],edi
       jmp       short M01_L10
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L04
M01_L07:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L02
M01_L08:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       add       r15d,1
       jo        short M01_L13
       movsxd    rcx,r15d
       cmp       r12,rcx
       jg        near ptr M01_L03
M01_L11:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       cmp       [rdx+8],eax
       jbe       short M01_L14
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M01_L12:
       mov       rcx,rsi
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L15
M01_L13:
       call      CORINFO_HELP_OVERFLOW
M01_L14:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFC2002C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L12
M01_L15:
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
M01_L16:
       mov       rax,2889DB10008
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
M01_L17:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L18:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC20445290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L20
       jmp       short M01_L17
M01_L19:
       mov       rdx,[rsi+8]
       mov       rcx,[rdx+8]
       call      qword ptr [rdx+18]
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L20:
       cmp       qword ptr [r14+10],0
       jne       short M01_L21
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L19
M01_L21:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFC20444DB0]
       test      eax,eax
       je        short M01_L19
       jmp       short M01_L17
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
       mov       rcx,2480BC052F8
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,7FFC20441350
       cmp       [rax+18],rcx
       jne       short M01_L23
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L27
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC2002C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L24
M01_L23:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L27
M01_L24:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L27
M01_L25:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L26
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC204452C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L27
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC20444D80]
       jmp       short M01_L27
M01_L26:
       add       rsi,2C
       lock dec  dword ptr [rsi]
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
; Total bytes of code 827
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
       call      qword ptr [7FFC207075D0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L16
       mov       rcx,20AE6803300
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L18
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L18
M01_L00:
       mov       rsi,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rsi
       mov       rdx,24B7883533C
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L07
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
       mov       r12d,r13d
       test      r12,r12
       jle       near ptr M01_L11
M01_L03:
       cmp       r15d,r13d
       jae       short M01_L05
       mov       ecx,r15d
       lea       rcx,[rbx+rcx+10]
       mov       r8,20AEE800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,24B78835350
       call      qword ptr [7FFC1FF54810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L10
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        short M01_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L08
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L06
M01_L04:
       mov       [rsi+18],edi
       jmp       short M01_L10
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L04
M01_L07:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L02
M01_L08:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       add       r15d,1
       jo        short M01_L13
       movsxd    rcx,r15d
       cmp       r12,rcx
       jg        near ptr M01_L03
M01_L11:
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       cmp       [rdx+8],eax
       jbe       short M01_L14
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M01_L12:
       mov       rcx,rsi
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M01_L15
M01_L13:
       call      CORINFO_HELP_OVERFLOW
M01_L14:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFC2002C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L12
M01_L15:
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
M01_L16:
       mov       rax,24B78820008
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
M01_L17:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L18:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC20445290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L20
       jmp       short M01_L17
M01_L19:
       mov       rdx,[rsi+8]
       mov       rcx,[rdx+8]
       call      qword ptr [rdx+18]
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L20:
       cmp       qword ptr [r14+10],0
       jne       short M01_L21
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L19
M01_L21:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFC20444DB0]
       test      eax,eax
       je        short M01_L19
       jmp       short M01_L17
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
       mov       rcx,20AE6803300
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,7FFC20441350
       cmp       [rax+18],rcx
       jne       short M01_L23
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L27
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC2002C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L24
M01_L23:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L27
M01_L24:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L27
M01_L25:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L26
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC204452C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L27
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC20444D80]
       jmp       short M01_L27
M01_L26:
       add       rsi,2C
       lock dec  dword ptr [rsi]
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
; Total bytes of code 827
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
       call      qword ptr [7FFC205F5860]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       mov       ebx,ecx
       mov       rsi,rdx
       mov       rcx,265904052F8
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L10
       lea       rcx,[rdi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L10
M01_L00:
       mov       r14,[rbp-40]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],r14
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M01_L09
       xor       r13d,r13d
       test      r15d,r15d
       jle       near ptr M01_L09
M01_L02:
       mov       r8d,r13d
       mov       rdx,[rsi+r8*8+10]
       test      bl,bl
       jne       short M01_L06
       cmp       [r14],r14b
       test      rdx,rdx
       je        short M01_L08
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[r14+8]
       mov       edx,[r14+18]
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       [r14+18],r12d
       jmp       short M01_L08
M01_L04:
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M01_L03
M01_L05:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L06:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC2002C330]
       jmp       short M01_L08
M01_L07:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L04
       jmp       short M01_L03
M01_L08:
       inc       r13d
       cmp       r15d,r13d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L12
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
M01_L10:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFC20444D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L11
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L00
M01_L11:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L12:
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
       mov       rcx,265904052F8
       mov       r14,[rcx]
       mov       rax,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L13
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L17
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC2002C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L14
M01_L13:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L17
M01_L14:
       cmp       qword ptr [r14+20],0
       jne       short M01_L15
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L17
M01_L15:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L16
       mov       rcx,[r14+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC20444D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L17
M01_L16:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L17:
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
; Total bytes of code 604
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
       call      qword ptr [7FFC205E5B60]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       mov       ebx,ecx
       mov       rsi,rdx
       mov       rcx,1CF3B8052F8
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L10
       lea       rcx,[rdi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L10
M01_L00:
       mov       r14,[rbp-40]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],r14
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M01_L09
       xor       r13d,r13d
       test      r15d,r15d
       jle       near ptr M01_L09
M01_L02:
       mov       r8d,r13d
       mov       rdx,[rsi+r8*8+10]
       test      bl,bl
       jne       short M01_L06
       cmp       [r14],r14b
       test      rdx,rdx
       je        short M01_L08
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[r14+8]
       mov       edx,[r14+18]
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       [r14+18],r12d
       jmp       short M01_L08
M01_L04:
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M01_L03
M01_L05:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L06:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC2001C330]
       jmp       short M01_L08
M01_L07:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L04
       jmp       short M01_L03
M01_L08:
       inc       r13d
       cmp       r15d,r13d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L12
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
M01_L10:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFC20434D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L11
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L00
M01_L11:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L12:
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
       mov       rcx,1CF3B8052F8
       mov       r14,[rcx]
       mov       rax,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L13
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L17
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC2001C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L14
M01_L13:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L17
M01_L14:
       cmp       qword ptr [r14+20],0
       jne       short M01_L15
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L17
M01_L15:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L16
       mov       rcx,[r14+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC20434D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L17
M01_L16:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L17:
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
; Total bytes of code 604
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
       call      qword ptr [7FFC205D5860]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       mov       ebx,ecx
       mov       rsi,rdx
       mov       rcx,211CAC052F8
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M01_L10
       lea       rcx,[rdi+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       jne       near ptr M01_L10
M01_L00:
       mov       r14,[rbp-38]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-38],r8
       mov       [rbp-40],r14
       test      rsi,rsi
       je        near ptr M01_L06
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M01_L06
       xor       r13d,r13d
       test      r15d,r15d
       jle       short M01_L06
M01_L02:
       mov       r8d,r13d
       mov       rdx,[rsi+r8*8+10]
       test      bl,bl
       jne       near ptr M01_L08
       cmp       [r14],r14b
       test      rdx,rdx
       je        short M01_L05
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L05
       mov       rcx,[r14+8]
       mov       edx,[r14+18]
       lea       edi,[rdx+r8]
       cmp       edi,[rcx+8]
       ja        short M01_L07
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M01_L04
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       [r14+18],edi
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
       inc       r13d
       cmp       r15d,r13d
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FFFB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M01_L09
M01_L07:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FFC2000CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L05
M01_L08:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC2000C330]
       jmp       short M01_L05
M01_L09:
       mov       rcx,rsp
       call      M01_L12
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
M01_L10:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFC20424D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L11
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L00
M01_L11:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L12:
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
       mov       rcx,211CAC052F8
       mov       rdi,[rcx]
       mov       r14,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r14+18],rcx
       jne       short M01_L13
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r14+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L17
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC2000C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L14
M01_L13:
       mov       rdx,[rbp-40]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       rbx,[rbp-40]
       je        short M01_L17
M01_L14:
       cmp       qword ptr [rdi+20],0
       jne       short M01_L15
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L17
M01_L15:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M01_L16
       mov       rcx,[rdi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC20424D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L17
M01_L16:
       add       rdi,2C
       lock dec  dword ptr [rdi]
M01_L17:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 586
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
       call      qword ptr [7FFC205E5E30]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       mov       ebx,ecx
       mov       rsi,rdx
       mov       rcx,1FB118052F8
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L10
       lea       rcx,[rdi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L10
M01_L00:
       mov       r14,[rbp-40]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],r14
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M01_L09
       xor       r13d,r13d
       test      r15d,r15d
       jle       near ptr M01_L09
M01_L02:
       mov       r8d,r13d
       mov       rdx,[rsi+r8*8+10]
       test      bl,bl
       jne       short M01_L06
       cmp       [r14],r14b
       test      rdx,rdx
       je        short M01_L08
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[r14+8]
       mov       edx,[r14+18]
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
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       [r14+18],r12d
       jmp       short M01_L08
M01_L04:
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M01_L03
M01_L05:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FFC1FFFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L06:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FFFC330]
       jmp       short M01_L08
M01_L07:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L04
       jmp       short M01_L03
M01_L08:
       inc       r13d
       cmp       r15d,r13d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FFEB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L12
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
M01_L10:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFC20414D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L11
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L00
M01_L11:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L12:
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
       mov       rcx,1FB118052F8
       mov       r14,[rcx]
       mov       rax,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L13
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L17
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC1FFFC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L14
M01_L13:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L17
M01_L14:
       cmp       qword ptr [r14+20],0
       jne       short M01_L15
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L17
M01_L15:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L16
       mov       rcx,[r14+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC20414D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L17
M01_L16:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L17:
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
; Total bytes of code 604
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
       call      qword ptr [7FFC206D74F8]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       mov       ebx,ecx
       mov       rsi,rdx
       mov       rcx,25CD2C03300
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L10
       lea       rcx,[rdi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L10
M01_L00:
       mov       r14,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],r14
       test      rsi,rsi
       je        near ptr M01_L09
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M01_L09
       xor       r15d,r15d
       test      edi,edi
       jle       near ptr M01_L09
M01_L02:
       mov       ecx,r15d
       mov       rdx,[rsi+rcx*8+10]
       test      bl,bl
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
       lea       r13d,[rdx+r8]
       cmp       r13d,[rcx+8]
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
       mov       [r14+18],r13d
       jmp       short M01_L08
M01_L04:
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       short M01_L03
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L06:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FFC2000CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC2000C330]
M01_L08:
       inc       r15d
       cmp       edi,r15d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FFFB060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L16
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
M01_L10:
       mov       r14,[rdi+18]
       mov       r15,[r14+18]
       lea       rdx,[rbp-40]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC20425290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M01_L11
       cmp       qword ptr [r15+10],0
       je        short M01_L12
       lea       rdx,[rbp-40]
       mov       rcx,r14
       call      qword ptr [7FFC20424DB0]
       test      eax,eax
       je        short M01_L13
M01_L11:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L00
M01_L12:
       xor       edx,edx
       mov       [rbp-40],rdx
M01_L13:
       mov       rdi,[rdi+8]
       mov       rcx,7FFC20421338
       cmp       [rdi+18],rcx
       jne       short M01_L15
       mov       rdi,[rdi+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,[rdi+8]
       mov       rcx,r14
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFC2000C0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
M01_L14:
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       short M01_L14
M01_L16:
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
       mov       rcx,25CD2C03300
       mov       r14,[rcx]
       mov       r12,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M01_L17
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L21
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC2000C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L18
M01_L17:
       mov       rdx,[rbp-48]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L21
M01_L18:
       cmp       qword ptr [r14+20],0
       jne       short M01_L19
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L21
M01_L19:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L20
       mov       r14,[r14+18]
       mov       rcx,[r14+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC204252C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L21
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFC20424D80]
       jmp       short M01_L21
M01_L20:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L21:
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
; Total bytes of code 724
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
       call      qword ptr [7FFC206F7E28]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       mov       ebx,ecx
       mov       rsi,rdx
       mov       rcx,29EA94052F8
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L10
       lea       rcx,[rdi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L10
M01_L00:
       mov       rdi,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rdi
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r13d,[rsi+8]
       test      r13d,r13d
       je        near ptr M01_L09
       xor       r12d,r12d
       test      r13d,r13d
       jle       near ptr M01_L09
M01_L02:
       mov       ecx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      bl,bl
       jne       short M01_L07
       cmp       [rdi],dil
       test      rdx,rdx
       je        short M01_L08
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[rdi+8]
       mov       edx,[rdi+18]
       lea       r14d,[rdx+r8]
       cmp       r14d,[rcx+8]
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
       mov       [rdi+18],r14d
       jmp       short M01_L08
M01_L04:
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       short M01_L03
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L06:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC2001C330]
M01_L08:
       inc       r12d
       cmp       r13d,r12d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
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
M01_L10:
       mov       r14,[rdi+18]
       mov       r15,[r14+18]
       lea       rdx,[rbp-40]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC20435290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L13
M01_L11:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L00
M01_L12:
       mov       rdx,[rdi+8]
       mov       rcx,[rdx+8]
       call      qword ptr [rdx+18]
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L13:
       cmp       qword ptr [r15+10],0
       jne       short M01_L14
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L12
M01_L14:
       lea       rdx,[rbp-40]
       mov       rcx,r14
       call      qword ptr [7FFC20434DB0]
       test      eax,eax
       je        short M01_L12
       jmp       short M01_L11
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
       mov       rcx,29EA94052F8
       mov       rdi,[rcx]
       mov       rax,[rdi+10]
       mov       rcx,7FFC20431350
       cmp       [rax+18],rcx
       jne       short M01_L16
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L20
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC2001C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L17
M01_L16:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L20
M01_L17:
       cmp       qword ptr [rdi+20],0
       jne       short M01_L18
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L20
M01_L18:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M01_L19
       mov       rdi,[rdi+18]
       mov       rcx,[rdi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC204352C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L20
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFC20434D80]
       jmp       short M01_L20
M01_L19:
       add       rdi,2C
       lock dec  dword ptr [rdi]
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
; Total bytes of code 661
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
       call      qword ptr [7FFC207075E8]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       mov       ebx,ecx
       mov       rsi,rdx
       mov       rcx,111B28052F8
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L10
       lea       rcx,[rdi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L10
M01_L00:
       mov       rdi,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rdi
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r13d,[rsi+8]
       test      r13d,r13d
       je        near ptr M01_L09
       xor       r12d,r12d
       test      r13d,r13d
       jle       near ptr M01_L09
M01_L02:
       mov       ecx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      bl,bl
       jne       short M01_L07
       cmp       [rdi],dil
       test      rdx,rdx
       je        short M01_L08
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[rdi+8]
       mov       edx,[rdi+18]
       lea       r14d,[rdx+r8]
       cmp       r14d,[rcx+8]
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
       mov       [rdi+18],r14d
       jmp       short M01_L08
M01_L04:
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       short M01_L03
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L06:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC2002C330]
M01_L08:
       inc       r12d
       cmp       r13d,r12d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
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
M01_L10:
       mov       r14,[rdi+18]
       mov       r15,[r14+18]
       lea       rdx,[rbp-40]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC20445290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L13
M01_L11:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L00
M01_L12:
       mov       rdx,[rdi+8]
       mov       rcx,[rdx+8]
       call      qword ptr [rdx+18]
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L13:
       cmp       qword ptr [r15+10],0
       jne       short M01_L14
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L12
M01_L14:
       lea       rdx,[rbp-40]
       mov       rcx,r14
       call      qword ptr [7FFC20444DB0]
       test      eax,eax
       je        short M01_L12
       jmp       short M01_L11
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
       mov       rcx,111B28052F8
       mov       rdi,[rcx]
       mov       rax,[rdi+10]
       mov       rcx,7FFC20441350
       cmp       [rax+18],rcx
       jne       short M01_L16
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L20
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC2002C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L17
M01_L16:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L20
M01_L17:
       cmp       qword ptr [rdi+20],0
       jne       short M01_L18
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L20
M01_L18:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M01_L19
       mov       rdi,[rdi+18]
       mov       rcx,[rdi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC204452C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L20
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFC20444D80]
       jmp       short M01_L20
M01_L19:
       add       rdi,2C
       lock dec  dword ptr [rdi]
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
; Total bytes of code 661
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
       call      qword ptr [7FFC207175E8]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       mov       ebx,ecx
       mov       rsi,rdx
       mov       rcx,20DAD8052F8
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L10
       lea       rcx,[rdi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L10
M01_L00:
       mov       rdi,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rdi
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r13d,[rsi+8]
       test      r13d,r13d
       je        near ptr M01_L09
       xor       r12d,r12d
       test      r13d,r13d
       jle       near ptr M01_L09
M01_L02:
       mov       ecx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      bl,bl
       jne       short M01_L07
       cmp       [rdi],dil
       test      rdx,rdx
       je        short M01_L08
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[rdi+8]
       mov       edx,[rdi+18]
       lea       r14d,[rdx+r8]
       cmp       r14d,[rcx+8]
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
       mov       [rdi+18],r14d
       jmp       short M01_L08
M01_L04:
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       short M01_L03
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L06:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC2003CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC2003C330]
M01_L08:
       inc       r12d
       cmp       r13d,r12d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC2002B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
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
M01_L10:
       mov       r14,[rdi+18]
       mov       r15,[r14+18]
       lea       rdx,[rbp-40]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC20455290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L13
M01_L11:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L00
M01_L12:
       mov       rdx,[rdi+8]
       mov       rcx,[rdx+8]
       call      qword ptr [rdx+18]
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L13:
       cmp       qword ptr [r15+10],0
       jne       short M01_L14
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L12
M01_L14:
       lea       rdx,[rbp-40]
       mov       rcx,r14
       call      qword ptr [7FFC20454DB0]
       test      eax,eax
       je        short M01_L12
       jmp       short M01_L11
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
       mov       rcx,20DAD8052F8
       mov       rdi,[rcx]
       mov       rax,[rdi+10]
       mov       rcx,7FFC20451350
       cmp       [rax+18],rcx
       jne       short M01_L16
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L20
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC2003C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L17
M01_L16:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L20
M01_L17:
       cmp       qword ptr [rdi+20],0
       jne       short M01_L18
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L20
M01_L18:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M01_L19
       mov       rdi,[rdi+18]
       mov       rcx,[rdi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC204552C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L20
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFC20454D80]
       jmp       short M01_L20
M01_L19:
       add       rdi,2C
       lock dec  dword ptr [rdi]
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
; Total bytes of code 661
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFC205F5BA8]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFC1FDD41F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,22603C052F8
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
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
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
       mov       rax,26695A80008
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
       call      qword ptr [7FFC20444D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,22603C052F8
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
       call      qword ptr [7FFC2002C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC20444D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFC205CFE70]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFC1FDE41F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2003CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,18B628052F8
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
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2003CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC2002B060]; System.Text.StringBuilder.ToString()
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
       mov       rax,1CBF4570008
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
       call      qword ptr [7FFC20454D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,18B628052F8
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
       call      qword ptr [7FFC2003C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC20454D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFC205C5BA8]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFC1FDA41F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       jle       near ptr M01_L05
M01_L00:
       mov       r8,[rsi+1A0]
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
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC1FFFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L04:
       inc       edi
       mov       rax,[rsi+1A0]
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
       mov       rcx,1E909C052F8
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
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       jae       short M02_L04
       mov       ecx,ebx
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
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M02_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M02_L05
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFC1FE55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       [rdi+18],r14d
       jmp       short M02_L07
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L05:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M02_L03
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L03
M02_L06:
       mov       rcx,rdi
       call      qword ptr [7FFC1FFFCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L07:
       inc       ebx
       mov       rcx,[rsi+1A0]
       cmp       [rcx+8],ebx
       jg        near ptr M02_L02
       jmp       short M02_L09
M02_L08:
       mov       rdx,rdi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
M02_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC1FFEB060]; System.Text.StringBuilder.ToString()
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
       mov       rax,2299BA30008
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
       call      qword ptr [7FFC20414D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,1E909C052F8
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
       call      qword ptr [7FFC1FFFC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC20414D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 617
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFC20617E70]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFC1FDD41F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,1843B8052F8
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
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
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
       mov       rax,1C4CD4C0008
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
       call      qword ptr [7FFC20444D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,1843B8052F8
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
       call      qword ptr [7FFC2002C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC20444D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFC206E7210]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFC1FDC41F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       je        near ptr M02_L15
       mov       rcx,22B2B0052F8
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L03
M02_L07:
       mov       rcx,rdi
       call      qword ptr [7FFC2001CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC2000B060]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       mov       rcx,rsp
       call      M02_L16
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
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFC20434D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L12
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M02_L00
M02_L12:
       mov       rsi,[rsi+8]
       mov       rcx,7FFC20431338
       cmp       [rsi+18],rcx
       je        short M02_L14
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdi,rax
M02_L13:
       jmp       near ptr M02_L01
M02_L14:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFC2001C0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
       jmp       short M02_L13
M02_L15:
       mov       rax,26BBD170008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L16:
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
       mov       rcx,22B2B0052F8
       mov       rdi,[rcx]
       mov       r13,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r13+18],rcx
       jne       short M02_L17
       mov       rsi,[rbp-40]
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rsi+1C]
       mov       rdx,[r13+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M02_L21
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC2001C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L18
M02_L17:
       mov       rdx,[rbp-40]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       mov       rsi,[rbp-40]
       je        short M02_L21
M02_L18:
       cmp       qword ptr [rdi+20],0
       jne       short M02_L19
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L21
M02_L19:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M02_L20
       mov       rbx,[rdi+18]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC204352C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M02_L21
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC20434D80]
       jmp       short M02_L21
M02_L20:
       add       rdi,2C
       lock dec  dword ptr [rdi]
M02_L21:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 725
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFC206E7630]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFC1FDB41F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFC2000CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,22183803300
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L03
M02_L07:
       mov       rcx,rsi
       call      qword ptr [7FFC2000CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC1FFFB060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC20425290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rax,26215770008
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
       call      qword ptr [7FFC20424DB0]
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
       mov       rcx,22183803300
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,7FFC20421350
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
       call      qword ptr [7FFC2000C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC204252C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M02_L22
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFC20424D80]
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFC20707630]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFC1FDD41F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,14876C052F8
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L03
M02_L07:
       mov       rcx,rsi
       call      qword ptr [7FFC2002CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC2001B060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC20445290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rax,18908AB0008
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
       call      qword ptr [7FFC20444DB0]
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
       mov       rcx,14876C052F8
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,7FFC20441350
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
       call      qword ptr [7FFC2002C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC204452C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M02_L22
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFC20444D80]
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFC206E7630]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFC1FDB41F8]
       int       3
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFC2000CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,2554E003300
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
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
       call      qword ptr [7FFC1FE65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L03
M02_L07:
       mov       rcx,rsi
       call      qword ptr [7FFC2000CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC1FFFB060]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFC20425290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rax,295DBF90008
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
       call      qword ptr [7FFC20424DB0]
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
       mov       rcx,2554E003300
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,7FFC20421350
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
       call      qword ptr [7FFC2000C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC204252C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M02_L22
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFC20424D80]
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

