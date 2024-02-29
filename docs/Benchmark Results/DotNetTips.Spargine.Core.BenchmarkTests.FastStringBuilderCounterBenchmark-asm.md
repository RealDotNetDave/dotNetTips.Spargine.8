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
       call      qword ptr [7FFE70C8C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,21D83BF57D4
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
       mov       r8,1DCF1C00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,21D83BF57E8
       call      qword ptr [7FFE70BB4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L03:
       mov       [rdi+18],ebp
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
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rdi
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L10:
       mov       rcx,rdi
       mov       edx,27
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L06
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 495
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
       call      qword ptr [7FFE70997738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE71334558]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70D26CE8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70D27180]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
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
       mov       rax,0A2C7EE77303E
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
       call      qword ptr [7FFE70BB4228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,0A2C7EE77303E
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
       call      qword ptr [7FFE70B8FD20]
       mov       rcx,0A2C7EE77303E
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
       call      qword ptr [7FFE70B6F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFE70B6F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFE7123F3D8]
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
       mov       r9,1DCF1C00298
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
       call      qword ptr [7FFE711F4678]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFE711CE0E8]
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFE71234D38]
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFE711F4780]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFE70AFC210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,1DCF1C01DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE70D114B0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0A2C7EE77303E
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
       call      qword ptr [7FFE70B8FE40]
       mov       rcx,0A2C7EE77303E
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
       jmp       qword ptr [7FFE70AF5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70D26EE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,21D83BE0008
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70D26FB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFE70BDE9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFE70BDE9B8]
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
       call      qword ptr [7FFED04085A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFED03F1D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FFE70C7C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,20C3FA457D4
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
       mov       r8,1CBADC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,20C3FA457E8
       call      qword ptr [7FFE70BB4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L03:
       mov       [rdi+18],ebp
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
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rdi
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L10:
       mov       rcx,rdi
       mov       edx,27
       call      qword ptr [7FFE70C7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L06
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 495
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
       call      qword ptr [7FFE70997738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE7126EA18]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F16190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
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
       mov       rax,95B426CA09C6
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
       call      qword ptr [7FFE70BB4228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,95B426CA09C6
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
       call      qword ptr [7FFE70B8FD20]
       mov       rcx,95B426CA09C6
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
       call      qword ptr [7FFE70B6F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFE70B6F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFE712655C0]
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
       mov       r9,1CBADC00298
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
       call      qword ptr [7FFE711E6D60]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFE711E4B58]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFE712370C0]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFE711E6E68]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFE70AFC210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,1CBADC01DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE70D014B0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,95B426CA09C6
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
       call      qword ptr [7FFE70B8FE40]
       mov       rcx,95B426CA09C6
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
       jmp       qword ptr [7FFE70AF5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,20C3FA30008
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFE70BDE9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFE70BDE9B8]
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
       call      qword ptr [7FFED04085A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFED03F1D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FFE70CAC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,2E3158357D4
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
       mov       r8,2A287800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2E3158357E8
       call      qword ptr [7FFE70BE4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
       call      qword ptr [7FFE70CAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L08
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 490
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
       call      qword ptr [7FFE709C7738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE7129EA18]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F46190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
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
       mov       rax,3928DFEF4A55
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
       call      qword ptr [7FFE70BE4228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,3928DFEF4A55
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
       call      qword ptr [7FFE70BBFD20]
       mov       rcx,3928DFEF4A55
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
       call      qword ptr [7FFE70B9F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFE70B9F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFE71295578]
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
       mov       r9,2A287800298
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
       call      qword ptr [7FFE71216D60]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFE71214B58]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFE712670C0]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFE71216E68]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFE70B2C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,2A287801DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE70D314B0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,3928DFEF4A55
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
       call      qword ptr [7FFE70BBFE40]
       mov       rcx,3928DFEF4A55
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70CACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFE70C0E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFE70C0E9B8]
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
       jmp       qword ptr [7FFE70B25B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,2E315820008
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
       call      qword ptr [7FFED04085A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFED03F1D20]; CORINFO_HELP_RNGCHKFAIL
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
       cmp       qword ptr [rbx+180],0
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
       mov       rdx,[rbx+180]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFE70C8C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1985B2A57D4
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
       je        near ptr M00_L06
M00_L01:
       mov       rcx,[rbx+180]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,157C9400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1985B2A57E8
       call      qword ptr [7FFE70BC4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       mov       [rsi+18],ebp
M00_L05:
       inc       edi
       mov       rcx,[rbx+180]
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
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L05
M00_L10:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFE709A7738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE7127EA90]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F26190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
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
       mov       rax,9A9DCB98CC84
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
       call      qword ptr [7FFE70BC4228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,9A9DCB98CC84
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
       call      qword ptr [7FFE70B9FD20]
       mov       rcx,9A9DCB98CC84
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
       call      qword ptr [7FFE70B7F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFE70B7F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFE71275530]
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
       mov       r9,157C9400298
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
       call      qword ptr [7FFE711F6D60]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFE711F4B58]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFE712473F0]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFE711F6E68]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFE70B0C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,157C9401DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE70D114B0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,9A9DCB98CC84
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
       call      qword ptr [7FFE70B9FE40]
       mov       rcx,9A9DCB98CC84
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
       jbe       short M03_L07
M03_L02:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       ja        short M03_L09
M03_L06:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
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
       ja        short M03_L05
       jmp       short M03_L06
M03_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,1985B290008
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFED04085A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFED03F1D20]; CORINFO_HELP_RNGCHKFAIL
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
       cmp       qword ptr [rbx+180],0
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
       mov       rdx,[rbx+180]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFE70C7C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,28AB1CD57F4
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
       je        near ptr M00_L06
M00_L01:
       mov       rcx,[rbx+180]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,24A1FC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,28AB1CD5808
       call      qword ptr [7FFE70BB4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       mov       [rsi+18],ebp
M00_L05:
       inc       edi
       mov       rcx,[rbx+180]
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
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L05
M00_L10:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFE70C7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFE70997738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE712A4840]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15500]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15998]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
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
       mov       rax,0EDA6FBF58D5F
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
       call      qword ptr [7FFE70BB4228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,0EDA6FBF58D5F
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
       call      qword ptr [7FFE70B8FD20]
       mov       rcx,0EDA6FBF58D5F
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
       call      qword ptr [7FFE70B6F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFE70B6F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFE712672D0]
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
       mov       r9,24A1FC00298
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
       call      qword ptr [7FFE711EC678]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFE711E60E8]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFE7123CD80]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFE711EC780]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFE70AFC210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,24A1FC01DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE70D01580]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,0EDA6FBF58D5F
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
       call      qword ptr [7FFE70B8FE40]
       mov       rcx,0EDA6FBF58D5F
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
       jmp       qword ptr [7FFE70AF5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F156F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,28AB1CC0008
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F157D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFE70BDE9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFE70BDE9B8]
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
       call      qword ptr [7FFED04085A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFED03F1D20]; CORINFO_HELP_RNGCHKFAIL
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
       cmp       qword ptr [rbx+180],0
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
       mov       rdx,[rbx+180]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFE70C9C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,283784557F4
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
       je        near ptr M00_L04
M00_L01:
       mov       rcx,[rbx+180]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,242E6400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,28378455808
       call      qword ptr [7FFE70BD4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       jbe       short M00_L09
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L07:
       mov       [rsi+18],ebp
       jmp       short M00_L03
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFE70C9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L05
M00_L10:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE709B7738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE712C44F8]
       int       3
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F36190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
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
       mov       rax,3ADFA527236C
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
       call      qword ptr [7FFE70BD4228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,3ADFA527236C
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
       call      qword ptr [7FFE70BAFD20]
       mov       rcx,3ADFA527236C
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
       call      qword ptr [7FFE70B8F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFE70B8F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFE71287210]
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
       mov       r9,242E6400298
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
       call      qword ptr [7FFE7120C678]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFE712060E8]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFE7125D0B0]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFE7120C780]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFE70B1C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,242E6401DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE70D214B0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,3ADFA527236C
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
       call      qword ptr [7FFE70BAFE40]
       mov       rcx,3ADFA527236C
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,28378440008
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
       jmp       qword ptr [7FFE70B15B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C9CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFE70BFE9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFE70BFE9B8]
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
       call      qword ptr [7FFED04085A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFED03F1D20]; CORINFO_HELP_RNGCHKFAIL
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
       cmp       qword ptr [rbx+180],0
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
       mov       rdx,[rbx+180]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       rcx,rsi
       call      qword ptr [7FFE70C8C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,2D6EF905844
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
       je        near ptr M00_L06
M00_L01:
       mov       rcx,[rbx+180]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L11
       mov       r8d,edi
       lea       rcx,[rcx+r8+10]
       mov       r8,2965DC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2D6EF905858
       call      qword ptr [7FFE70BC4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       mov       [rsi+18],ebp
M00_L05:
       inc       edi
       mov       rcx,[rbx+180]
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
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L05
M00_L10:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       mov       rdx,2D6EF8F0390
       call      qword ptr [7FFE70D940D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE709A7738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25CF8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F26190]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
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
       mov       rax,0A968A427FDBA
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
       call      qword ptr [7FFE70BC4228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r13d,r15d
       and       r13d,0FFDF
       cmp       r13d,47
       je        short M02_L03
       cmp       r13d,44
       jne       short M02_L04
       jmp       near ptr M02_L26
M02_L03:
       cmp       dword ptr [rbp+90],0
       jle       near ptr M02_L26
M02_L04:
       cmp       r13d,58
       jne       near ptr M02_L11
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
       je        near ptr M02_L28
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       r8,[rbp+38]
M02_L05:
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2]
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
       mov       rcx,0A968A427FDBA
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
       cmp       r13d,42
       jne       short M02_L13
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFE70B9FD20]
       mov       rcx,0A968A427FDBA
       cmp       [rbp+0A8],rcx
       je        short M02_L12
       call      CORINFO_HELP_FAIL_FAST
M02_L12:
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
M02_L13:
       test      rbx,rbx
       je        short M02_L14
       mov       rcx,rbx
       call      qword ptr [7FFE70B7F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFE70B7F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L15:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFE7128C1F8]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       mov       rdx,[rbp+80]
       lea       rcx,[rdx+0A]
       mov       eax,esi
       xor       r8d,r8d
       cmp       eax,64
       jb        short M02_L17
M02_L16:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,eax
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       eax,r9d
       mov       r9,2965DC00298
       mov       r9,[r9]
       add       eax,eax
       mov       ax,[r9+rax+10]
       mov       [rcx],ax
       cmp       r10d,64
       mov       eax,r10d
       jae       short M02_L16
M02_L17:
       test      eax,eax
       je        short M02_L19
M02_L18:
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
       jne       short M02_L18
M02_L19:
       test      r8d,r8d
       jg        short M02_L18
       add       rdx,0A
       sub       rdx,rcx
       mov       [rbp+70],edx
       mov       [rbp+74],edx
       mov       rax,[rbp+80]
       jmp       short M02_L21
M02_L20:
       lea       r8,[rax+1]
       lea       r10,[rcx+1]
       movzx     ecx,byte ptr [rcx]
       mov       [rax],cl
       mov       rax,r8
       mov       rcx,r10
M02_L21:
       dec       edx
       jns       short M02_L20
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+8],rdx
       mov       dword ptr [rbp+10],20
       lea       rdx,[rbp+8]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFE7120D320]
       test      r15d,r15d
       je        short M02_L22
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFE712070C0]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L23
M02_L22:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFE7125DDB8]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L23:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFE7120D428]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFE70B0C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L24
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,2965DC01DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE70D114B0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L24:
       mov       rax,rbx
       mov       rcx,0A968A427FDBA
       cmp       [rbp+0A8],rcx
       je        short M02_L25
       call      CORINFO_HELP_FAIL_FAST
M02_L25:
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
M02_L26:
       mov       ecx,esi
       mov       edx,[rbp+90]
       call      qword ptr [7FFE70B9FE40]
       mov       rcx,0A968A427FDBA
       cmp       [rbp+0A8],rcx
       je        short M02_L27
       call      CORINFO_HELP_FAIL_FAST
M02_L27:
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
M02_L28:
       xor       r8d,r8d
       jmp       near ptr M02_L05
; Total bytes of code 1000
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
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,2D6EF8F0008
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M05_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L04:
       test      eax,eax
       jne       short M05_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M05_L00
M05_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M05_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M05_L02
M05_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFED04085A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFED03F1D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FFE70C7C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,229FF705844
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
       mov       r8,1E96D800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,229FF705858
       call      qword ptr [7FFE70BB4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       jbe       near ptr M00_L11
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L00
M00_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,rsi
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFE70C7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       mov       rdx,229FF6F0390
       call      qword ptr [7FFE70D3FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE70997738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15500]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2E5
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15998]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
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
       mov       rax,6A8601A3B8D3
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
       call      qword ptr [7FFE70BB4228]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       mov       rcx,6A8601A3B8D3
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
       call      qword ptr [7FFE70B8FD20]
       mov       rcx,6A8601A3B8D3
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
       call      qword ptr [7FFE70B6F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       rbx,rax
       jmp       short M02_L16
M02_L15:
       call      qword ptr [7FFE70B6F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rbx,rax
M02_L16:
       lea       r8,[rbp+98]
       mov       [rbp+18],r8
       mov       dword ptr [rbp+20],0B
       lea       r8,[rbp+18]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFE7135D3C8]
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
       mov       r9,1E96D800298
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
       call      qword ptr [7FFE7126E478]
       test      r15d,r15d
       je        short M02_L23
       mov       [rsp+20],rbx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r15d
       mov       r9d,[rbp+90]
       call      qword ptr [7FFE7126C270]; System.Number.NumberToString[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M02_L24
M02_L23:
       mov       [rbp+28],rdi
       mov       [rbp+30],r14d
       lea       r8,[rbp+28]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,rbx
       call      qword ptr [7FFE7132ED60]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M02_L24:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFE7126E580]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFE70AFC210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M02_L25
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,1E96D801DD8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE70D014B0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L25:
       mov       rax,rbx
       mov       rcx,6A8601A3B8D3
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
       call      qword ptr [7FFE70B8FE40]
       mov       rcx,6A8601A3B8D3
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F156F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,229FF6F0008
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F157D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFE70BDE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFE70BDE9B8]
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
       jb        near ptr M05_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L08
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
       ja        short M05_L09
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
       cmp       rcx,rdx
       je        near ptr M05_L00
M05_L09:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE70AF5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFED04085A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFED03F1D20]; CORINFO_HELP_RNGCHKFAIL
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
       mov       r8,[rbx+198]
       mov       rcx,21E6E990008
       mov       edx,1
       call      qword ptr [7FFE71295518]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       mov       [rbp-40],rax
       mov       [rbp-80],rsp
       mov       rdi,rcx
       mov       esi,edx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L18
M01_L00:
       mov       rcx,1DDDCC02C88
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
       mov       [rbp-58],r15
       test      rbx,rbx
       je        near ptr M01_L15
       mov       r13d,[rbx+8]
       test      r13d,r13d
       je        near ptr M01_L15
       mov       rdx,21E6E9A57D4
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
M01_L03:
       xor       r12d,r12d
       xor       r14d,r14d
       test      r13d,r13d
       jle       near ptr M01_L15
       mov       eax,r13d
       sub       eax,1
       jo        near ptr M01_L16
       mov       [rbp-4C],eax
M01_L04:
       mov       ecx,r14d
       mov       r8,[rbx+rcx*8+10]
       cmp       eax,r12d
       jle       short M01_L05
       cmp       dword ptr [rdi+8],0
       jg        near ptr M01_L07
M01_L05:
       test      sil,sil
       je        short M01_L06
       test      r8,r8
       je        near ptr M01_L14
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       mov       [rbp-44],r10d
       test      r10d,r10d
       je        near ptr M01_L14
       mov       r8,[r15+8]
       mov       r9d,[r15+18]
       mov       [rbp-48],r9d
       lea       ecx,[r9+r10]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L13
       movsxd    rcx,r9d
       lea       rcx,[r8+rcx*2+10]
       cmp       r10d,2
       jg        near ptr M01_L11
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r10d,2
       jne       near ptr M01_L12
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L12
M01_L06:
       mov       rcx,r15
       mov       rdx,r8
       call      qword ptr [7FFE70CAC2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L10
M01_L07:
       mov       [rbp-60],r8
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-70]
       xor       ecx,ecx
       call      qword ptr [7FFE712954E8]
       mov       rdx,rax
       mov       r8,rdx
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L09:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       add       r12d,1
       jo        near ptr M01_L16
       inc       r14d
       cmp       r13d,r14d
       mov       eax,[rbp-4C]
       jg        near ptr M01_L04
       jmp       short M01_L15
M01_L11:
       movsxd    r8,r10d
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rbp-44]
M01_L12:
       add       r10d,[rbp-48]
       mov       [r15+18],r10d
       jmp       short M01_L14
M01_L13:
       mov       rcx,r15
       mov       r8d,r10d
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L14:
       mov       rdx,21E6E991C14
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       r10d,[r8+2]
       cmp       [rcx+8],r10d
       jb        short M01_L09
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],r10d
       jmp       short M01_L10
M01_L15:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-68],rax
       jmp       short M01_L17
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L17:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rax,[rbp-68]
       add       rsp,68
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
       call      qword ptr [7FFE710D4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       lea       rbp,[rbp+0A0]
       mov       rcx,1DDDCC02C88
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L22
       mov       rbx,[rbp-58]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L26
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L23
M01_L22:
       mov       rdx,[rbp-58]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-58]
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
       call      qword ptr [7FFE710D4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 958
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,1D6B4C00008
       mov       edx,1
       call      qword ptr [7FFE712971F8]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       mov       [rbp-40],rax
       mov       [rbp-80],rsp
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       test      rsi,rsi
       je        near ptr M01_L18
M01_L00:
       mov       rcx,19622C04C80
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
       mov       [rbp-58],r15
       test      rbx,rbx
       je        near ptr M01_L13
       mov       r13d,[rbx+8]
       test      r13d,r13d
       je        near ptr M01_L13
       mov       rdx,1D6B4C157F4
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
       xor       r14d,r14d
       test      r13d,r13d
       jle       near ptr M01_L13
       mov       eax,r13d
       sub       eax,1
       jo        near ptr M01_L14
       mov       [rbp-4C],eax
M01_L04:
       mov       ecx,r14d
       mov       r8,[rbx+rcx*8+10]
       cmp       eax,r12d
       jle       short M01_L05
       cmp       dword ptr [rsi+8],0
       jg        near ptr M01_L07
M01_L05:
       test      dil,dil
       je        short M01_L06
       test      r8,r8
       je        near ptr M01_L11
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       mov       [rbp-44],r10d
       test      r10d,r10d
       je        near ptr M01_L11
       mov       r8,[r15+8]
       mov       r9d,[r15+18]
       mov       [rbp-48],r9d
       lea       ecx,[r9+r10]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L16
       movsxd    rcx,r9d
       lea       rcx,[r8+rcx*2+10]
       cmp       r10d,2
       jg        near ptr M01_L09
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r10d,2
       jne       near ptr M01_L10
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L10
M01_L06:
       mov       rcx,r15
       mov       rdx,r8
       call      qword ptr [7FFE70CAC2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L12
M01_L07:
       mov       [rbp-60],r8
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       lea       rcx,[rax+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-70]
       xor       ecx,ecx
       call      qword ptr [7FFE712971C8]
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L09:
       movsxd    r8,r10d
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rbp-44]
M01_L10:
       add       r10d,[rbp-48]
       mov       [r15+18],r10d
M01_L11:
       mov       rdx,1D6B4C01C14
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       r10d,[r8+2]
       cmp       [rcx+8],r10d
       jb        short M01_L15
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],r10d
M01_L12:
       add       r12d,1
       jo        short M01_L14
       inc       r14d
       cmp       r13d,r14d
       mov       eax,[rbp-4C]
       jg        near ptr M01_L04
M01_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-68],rax
       jmp       short M01_L17
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L16:
       mov       rcx,r15
       mov       r8d,r10d
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L11
M01_L17:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rax,[rbp-68]
       add       rsp,68
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
       mov       rsi,rax
       mov       word ptr [rsi+0C],2C
       jmp       near ptr M01_L00
M01_L19:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       lea       rbp,[rbp+0A0]
       mov       rcx,19622C04C80
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L22
       mov       rbx,[rbp-58]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L26
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L23
M01_L22:
       mov       rdx,[rbp-58]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-58]
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
       call      qword ptr [7FFE710D4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 956
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,2D07D950008
       mov       edx,1
       call      qword ptr [7FFE71275470]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       mov       [rbp-40],rax
       mov       [rbp-80],rsp
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       test      rsi,rsi
       je        near ptr M01_L18
M01_L00:
       mov       rcx,28FEBC04C80
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
       mov       [rbp-58],r15
       test      rbx,rbx
       je        near ptr M01_L13
       mov       r13d,[rbx+8]
       test      r13d,r13d
       je        near ptr M01_L13
       mov       rdx,2D07D9657D4
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
       xor       r14d,r14d
       test      r13d,r13d
       jle       near ptr M01_L13
       mov       eax,r13d
       sub       eax,1
       jo        near ptr M01_L14
       mov       [rbp-4C],eax
M01_L04:
       mov       ecx,r14d
       mov       r8,[rbx+rcx*8+10]
       cmp       eax,r12d
       jle       short M01_L05
       cmp       dword ptr [rsi+8],0
       jg        near ptr M01_L07
M01_L05:
       test      dil,dil
       je        short M01_L06
       test      r8,r8
       je        near ptr M01_L11
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       mov       [rbp-44],r10d
       test      r10d,r10d
       je        near ptr M01_L11
       mov       r8,[r15+8]
       mov       r9d,[r15+18]
       mov       [rbp-48],r9d
       lea       ecx,[r9+r10]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L16
       movsxd    rcx,r9d
       lea       rcx,[r8+rcx*2+10]
       cmp       r10d,2
       jg        near ptr M01_L09
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r10d,2
       jne       near ptr M01_L10
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L10
M01_L06:
       mov       rcx,r15
       mov       rdx,r8
       call      qword ptr [7FFE70C8C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L12
M01_L07:
       mov       [rbp-60],r8
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       lea       rcx,[rax+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-70]
       xor       ecx,ecx
       call      qword ptr [7FFE71275440]
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L09:
       movsxd    r8,r10d
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rbp-44]
M01_L10:
       add       r10d,[rbp-48]
       mov       [r15+18],r10d
M01_L11:
       mov       rdx,2D07D951C14
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       r10d,[r8+2]
       cmp       [rcx+8],r10d
       jb        short M01_L15
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],r10d
M01_L12:
       add       r12d,1
       jo        short M01_L14
       inc       r14d
       cmp       r13d,r14d
       mov       eax,[rbp-4C]
       jg        near ptr M01_L04
M01_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
       mov       [rbp-68],rax
       jmp       short M01_L17
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L16:
       mov       rcx,r15
       mov       r8d,r10d
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L11
M01_L17:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rax,[rbp-68]
       add       rsp,68
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
       mov       rsi,rax
       mov       word ptr [rsi+0C],2C
       jmp       near ptr M01_L00
M01_L19:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       lea       rbp,[rbp+0A0]
       mov       rcx,28FEBC04C80
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L22
       mov       rbx,[rbp-58]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L26
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L23
M01_L22:
       mov       rdx,[rbp-58]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-58]
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
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 956
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,171B6720008
       mov       edx,1
       call      qword ptr [7FFE712971F8]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
       mov       rcx,13124804C80
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
       mov       rdx,171B67357F4
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
       xor       r14d,r14d
       test      r13d,r13d
       jle       near ptr M01_L13
       mov       eax,r13d
       sub       eax,1
       jo        near ptr M01_L14
       mov       [rbp-44],eax
M01_L04:
       mov       ecx,r14d
       mov       r8,[rbx+rcx*8+10]
       cmp       eax,r12d
       jle       short M01_L05
       cmp       dword ptr [rdi+8],0
       jg        near ptr M01_L07
M01_L05:
       test      sil,sil
       je        short M01_L06
       test      r8,r8
       je        near ptr M01_L11
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L11
       mov       rcx,[r15+8]
       mov       r10d,[r15+18]
       lea       r9d,[r10+r8]
       mov       [rbp-48],r9d
       cmp       r9d,[rcx+8]
       ja        near ptr M01_L16
       movsxd    r10,r10d
       lea       rcx,[rcx+r10*2+10]
       cmp       r8d,2
       jg        near ptr M01_L09
       movzx     r10d,word ptr [rdx]
       mov       [rcx],r10w
       cmp       r8d,2
       jne       near ptr M01_L10
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L10
M01_L06:
       mov       rcx,r15
       mov       rdx,r8
       call      qword ptr [7FFE70CAC2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L12
M01_L07:
       mov       [rbp-58],r8
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
       call      qword ptr [7FFE712971C8]
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       mov       r9d,[rbp-48]
       mov       [r15+18],r9d
M01_L11:
       mov       rdx,171B6721C14
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       r10d,[r8+2]
       cmp       [rcx+8],r10d
       jb        short M01_L15
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],r10d
M01_L12:
       add       r12d,1
       jo        short M01_L14
       inc       r14d
       cmp       r13d,r14d
       mov       eax,[rbp-44]
       jg        near ptr M01_L04
M01_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       short M01_L17
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L16:
       mov       rcx,r15
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE710D4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,13124804C80
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
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710D4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 945
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,2828B4E0008
       mov       edx,1
       call      qword ptr [7FFE712672B8]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
       mov       rcx,241F9804C80
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
       mov       rdx,2828B4F57F4
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
       xor       r14d,r14d
       test      r13d,r13d
       jle       near ptr M01_L13
       mov       eax,r13d
       sub       eax,1
       jo        near ptr M01_L14
       mov       [rbp-44],eax
M01_L04:
       mov       ecx,r14d
       mov       r8,[rbx+rcx*8+10]
       cmp       eax,r12d
       jle       short M01_L05
       cmp       dword ptr [rdi+8],0
       jg        near ptr M01_L07
M01_L05:
       test      sil,sil
       je        short M01_L06
       test      r8,r8
       je        near ptr M01_L11
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L11
       mov       rcx,[r15+8]
       mov       r10d,[r15+18]
       lea       r9d,[r10+r8]
       mov       [rbp-48],r9d
       cmp       r9d,[rcx+8]
       ja        near ptr M01_L16
       movsxd    r10,r10d
       lea       rcx,[rcx+r10*2+10]
       cmp       r8d,2
       jg        near ptr M01_L09
       movzx     r10d,word ptr [rdx]
       mov       [rcx],r10w
       cmp       r8d,2
       jne       near ptr M01_L10
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L10
M01_L06:
       mov       rcx,r15
       mov       rdx,r8
       call      qword ptr [7FFE70C7C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L12
M01_L07:
       mov       [rbp-58],r8
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
       call      qword ptr [7FFE71267288]
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       mov       r9d,[rbp-48]
       mov       [r15+18],r9d
M01_L11:
       mov       rdx,2828B4E1C14
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       r10d,[r8+2]
       cmp       [rcx+8],r10d
       jb        short M01_L15
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],r10d
M01_L12:
       add       r12d,1
       jo        short M01_L14
       inc       r14d
       cmp       r13d,r14d
       mov       eax,[rbp-44]
       jg        near ptr M01_L04
M01_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       short M01_L17
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L16:
       mov       rcx,r15
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE710A4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,241F9804C80
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
       call      qword ptr [7FFE70C7C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710A4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 945
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,1A972DA0008
       mov       edx,1
       call      qword ptr [7FFE712A72B8]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
       mov       rcx,168E1004C80
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
       mov       rdx,1A972DB57F4
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
       xor       r14d,r14d
       test      r13d,r13d
       jle       near ptr M01_L13
       mov       eax,r13d
       sub       eax,1
       jo        near ptr M01_L14
       mov       [rbp-44],eax
M01_L04:
       mov       ecx,r14d
       mov       r8,[rbx+rcx*8+10]
       cmp       eax,r12d
       jle       short M01_L05
       cmp       dword ptr [rdi+8],0
       jg        near ptr M01_L07
M01_L05:
       test      sil,sil
       je        short M01_L06
       test      r8,r8
       je        near ptr M01_L11
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L11
       mov       rcx,[r15+8]
       mov       r10d,[r15+18]
       lea       r9d,[r10+r8]
       mov       [rbp-48],r9d
       cmp       r9d,[rcx+8]
       ja        near ptr M01_L16
       movsxd    r10,r10d
       lea       rcx,[rcx+r10*2+10]
       cmp       r8d,2
       jg        near ptr M01_L09
       movzx     r10d,word ptr [rdx]
       mov       [rcx],r10w
       cmp       r8d,2
       jne       near ptr M01_L10
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L10
M01_L06:
       mov       rcx,r15
       mov       rdx,r8
       call      qword ptr [7FFE70CBC2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L12
M01_L07:
       mov       [rbp-58],r8
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
       call      qword ptr [7FFE712A7288]
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE70CBCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70B35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       mov       r9d,[rbp-48]
       mov       [r15+18],r9d
M01_L11:
       mov       rdx,1A972DA1C14
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       r10d,[r8+2]
       cmp       [rcx+8],r10d
       jb        short M01_L15
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],r10d
M01_L12:
       add       r12d,1
       jo        short M01_L14
       inc       r14d
       cmp       r13d,r14d
       mov       eax,[rbp-44]
       jg        near ptr M01_L04
M01_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CC8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       short M01_L17
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFE70CBCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L16:
       mov       rcx,r15
       call      qword ptr [7FFE70CBCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE710E4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,168E1004C80
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
       call      qword ptr [7FFE70CBC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710E4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 945
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,2DDED1A0008
       mov       edx,1
       call      qword ptr [7FFE7129EF88]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
       mov       rcx,29D5B404C80
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
       mov       rdx,2DDED1B5844
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
       xor       r14d,r14d
       test      r13d,r13d
       jle       near ptr M01_L13
       mov       eax,r13d
       sub       eax,1
       jo        near ptr M01_L14
       mov       [rbp-44],eax
M01_L04:
       mov       r8d,r14d
       mov       r10,[rbx+r8*8+10]
       mov       rdx,r10
       cmp       eax,r12d
       jle       short M01_L05
       cmp       dword ptr [rdi+8],0
       jg        near ptr M01_L07
M01_L05:
       test      sil,sil
       je        short M01_L06
       test      rdx,rdx
       je        near ptr M01_L11
       lea       r10,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        near ptr M01_L11
       mov       rcx,[r15+8]
       mov       edx,[r15+18]
       lea       r9d,[rdx+r8]
       mov       [rbp-48],r9d
       cmp       r9d,[rcx+8]
       ja        near ptr M01_L16
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jg        near ptr M01_L09
       movzx     edx,word ptr [r10]
       mov       [rcx],dx
       cmp       r8d,2
       jne       near ptr M01_L10
       movzx     r8d,word ptr [r10+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L10
M01_L06:
       test      rdx,rdx
       je        near ptr M01_L12
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r15
       call      qword ptr [7FFE70C8CA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFE7129EF58]
       mov       rcx,rax
       mov       rdx,rcx
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L09:
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,r10
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       mov       r9d,[rbp-48]
       mov       [r15+18],r9d
M01_L11:
       mov       rdx,2DDED1A1C14
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       r10d,[r8+2]
       cmp       [rcx+8],r10d
       jb        short M01_L15
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],r10d
M01_L12:
       add       r12d,1
       jo        short M01_L14
       inc       r14d
       cmp       r13d,r14d
       mov       eax,[rbp-44]
       jg        near ptr M01_L04
M01_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       short M01_L17
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L16:
       mov       rcx,r15
       mov       rdx,r10
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE710B4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,29D5B404C80
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
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 966
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ConcatStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       r8,[rbx+198]
       mov       rcx,1F4BE360008
       mov       edx,1
       call      qword ptr [7FFE71375800]; DotNetTips.Spargine.Core.FastStringBuilder.ConcatStrings(System.String, Boolean, System.String[])
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
       je        near ptr M01_L21
M01_L00:
       mov       rcx,1B42C404C80
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
       mov       rdx,1F4BE375844
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
       xor       r14d,r14d
       test      r13d,r13d
       jle       near ptr M01_L11
       mov       eax,r13d
       sub       eax,1
       jo        near ptr M01_L18
       mov       [rbp-44],eax
M01_L04:
       mov       ecx,r14d
       mov       r10,[rbx+rcx*8+10]
       cmp       eax,r12d
       jle       short M01_L05
       cmp       dword ptr [rsi+8],0
       jg        near ptr M01_L13
M01_L05:
       test      dil,dil
       je        near ptr M01_L12
       test      r10,r10
       je        short M01_L09
       lea       rdx,[r10+0C]
       mov       r8d,[r10+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[r15+8]
       mov       r10d,[r15+18]
       lea       r9d,[r10+r8]
       cmp       r9d,[rcx+8]
       ja        short M01_L08
       movsxd    r10,r10d
       lea       rcx,[rcx+r10*2+10]
       cmp       r8d,2
       jg        short M01_L06
       movzx     r10d,word ptr [rdx]
       mov       [rcx],r10w
       cmp       r8d,2
       jne       short M01_L07
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M01_L07
M01_L06:
       mov       [rbp-48],r9d
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r9d,[rbp-48]
M01_L07:
       mov       [r15+18],r9d
       jmp       short M01_L09
M01_L08:
       mov       rcx,r15
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       mov       rdx,1F4BE361C14
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       r10d,[r8+2]
       cmp       [rcx+8],r10d
       jb        near ptr M01_L19
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r15+18],r10d
M01_L10:
       add       r12d,1
       jo        near ptr M01_L18
       inc       r14d
       cmp       r13d,r14d
       mov       eax,[rbp-44]
       jg        near ptr M01_L04
M01_L11:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       near ptr M01_L20
M01_L12:
       test      r10,r10
       je        short M01_L10
       lea       rdx,[r10+0C]
       mov       r8d,[r10+8]
       test      r8d,r8d
       je        short M01_L10
       mov       rcx,[r15+8]
       mov       r10d,[r15+18]
       lea       r9d,[r10+r8]
       cmp       r9d,[rcx+8]
       ja        near ptr M01_L17
       movsxd    r10,r10d
       lea       rcx,[rcx+r10*2+10]
       cmp       r8d,2
       jg        near ptr M01_L15
       movzx     r10d,word ptr [rdx]
       mov       [rcx],r10w
       cmp       r8d,2
       jne       near ptr M01_L16
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M01_L16
M01_L13:
       mov       [rbp-58],r10
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
       call      qword ptr [7FFE713757D0]
       mov       r8,rax
       mov       r10,r8
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L15:
       mov       [rbp-48],r9d
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r9d,[rbp-48]
M01_L16:
       mov       [r15+18],r9d
       jmp       near ptr M01_L10
M01_L17:
       mov       rcx,r15
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L10
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       rcx,r15
       mov       r8d,2
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rsi,rax
       mov       word ptr [rsi+0C],2C
       jmp       near ptr M01_L00
M01_L22:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,1B42C404C80
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
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710D4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 1048
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
       call      qword ptr [7FFE70B35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70CBCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE70CC8140]; System.Text.StringBuilder.ToString()
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
       mov       rax,236671A0008
       jmp       near ptr M00_L01
; Total bytes of code 286
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L11
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
       ja        short M01_L05
M01_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L04:
       test      r8b,4
       je        short M01_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L00
M01_L05:
       cmp       r8,800
       ja        near ptr M01_L12
       jmp       short M01_L07
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L03
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
       jmp       short M01_L10
M01_L09:
       test      r8,r8
       je        near ptr M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L00
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       jmp       near ptr M01_L03
M01_L11:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L12:
       jmp       qword ptr [7FFE70B35B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70CBCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70934000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F55FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70C1E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70C1E9B8]
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
       call      qword ptr [7FFE70B35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70934000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F55EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,236671A0008
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       mov       rax,24B1CE60008
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
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,24B1CE60008
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
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
       mov       rax,294B0AA0008
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
       jmp       qword ptr [7FFE70B25B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70CACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70C0E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70C0E9B8]
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,294B0AA0008
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
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
       mov       rax,266F4F90008
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
       jmp       qword ptr [7FFE70AF5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BDE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BDE9B8]
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,266F4F90008
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
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
       mov       rax,2006BB00008
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
       jmp       qword ptr [7FFE70B15B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C9CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F357D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BFE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BFE9B8]
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F356F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2006BB00008
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
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
       mov       rax,21DB0150008
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
       jmp       qword ptr [7FFE70AF5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BDE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BDE9B8]
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,21DB0150008
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
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
       mov       rax,277FEEE0008
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
       jmp       qword ptr [7FFE70B25B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70CACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70C0E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70C0E9B8]
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,277FEEE0008
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
       mov       rdi,[rbx+198]
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
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
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
       mov       rax,318460D0008
       jmp       near ptr M00_L01
M00_L06:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L02
M00_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,318460D0008
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
       ja        near ptr M02_L09
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
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rbx-4]
       mov       [rsi-4],ecx
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
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE70AF5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L10:
       cmp       rcx,rdx
       je        near ptr M02_L02
       jmp       short M02_L09
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFE70BDE9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFE70BDE9B8]
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,1A63CE41C14
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
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,1A63CE40008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 393
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
       jmp       qword ptr [7FFE70B15B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C9CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BFE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BFE9B8]
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1A63CE40008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,1D599EE1C14
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
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,1D599EE0008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 393
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
       jmp       qword ptr [7FFE70B25B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70CACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70C0E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70C0E9B8]
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1D599EE0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,222E5DB1C14
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
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,222E5DB0008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 393
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
       jmp       qword ptr [7FFE70B25B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70CACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70C0E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70C0E9B8]
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,222E5DB0008
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L03:
       mov       [rsi+18],ebp
       jmp       short M00_L05
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,24A23681C14
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
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,24A23680008
       jmp       near ptr M00_L01
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 377
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
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F257D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F256F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,24A23680008
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L03:
       mov       [rsi+18],ebp
       jmp       short M00_L05
M00_L04:
       mov       rcx,rsi
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,1FA712F1C14
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
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,1FA712F0008
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
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1FA712F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L02
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,2D562DD1C14
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
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,2D562DD0008
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
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F257D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F256F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2D562DD0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L03:
       add       ebp,r14d
       mov       [rsi+18],ebp
       jmp       short M00_L05
M00_L04:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       mov       rdx,1B25D3B1C14
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
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L09:
       mov       rax,1B25D3B0008
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
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1B25D3B0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
       mov       rcx,[rbx+198]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L05
M00_L00:
       mov       rcx,[rbx+198]
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
       mov       ebp,[rax+8]
       test      ebp,ebp
       je        short M00_L03
       mov       rcx,[rsi+8]
       mov       r14d,[rsi+18]
       lea       eax,[r14+rbp]
       cmp       eax,[rcx+8]
       ja        near ptr M00_L08
       movsxd    rax,r14d
       lea       rcx,[rcx+rax*2+10]
       cmp       ebp,2
       jg        near ptr M00_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       ebp,2
       jne       short M00_L02
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
M00_L02:
       add       ebp,r14d
       mov       [rsi+18],ebp
M00_L03:
       mov       rdx,2B4886A1C14
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
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
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
       mov       rax,2B4886A0008
       jmp       near ptr M00_L01
M00_L07:
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L02
M00_L08:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 403
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,2B4886A0008
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
       jmp       qword ptr [7FFE70B25B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70CACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFE70C0E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFE70C0E9B8]
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
       call      qword ptr [7FFE70CAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L01:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,24955040210
       call      qword ptr [7FFE70A76B20]; System.String.Concat(System.String, System.String, System.String)
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
M00_L02:
       cmp       qword ptr [rax+8],0
       jne       short M00_L03
       mov       rcx,208C3000438
       cmp       qword ptr [rcx],0
       jne       short M00_L03
       mov       rcx,208C3000418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L03:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       near ptr M00_L09
       mov       r12,24955040A40
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
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L05:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L14
M00_L06:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L08
       mov       rcx,rsi
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       r15,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],rcx
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
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    rcx,r12d
       mov       r12,[rsp+28]
       lea       rcx,[r12+rcx*2+0C]
       mov       rdx,24955040A4C
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L12:
       add       r15d,r13d
       mov       [rsi+18],r15d
       jmp       near ptr M00_L05
M00_L13:
       call      qword ptr [7FFE70C0EF10]
       int       3
M00_L14:
       call      qword ptr [7FFE70C0EFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L02
M00_L16:
       call      qword ptr [7FFE70BB4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L03
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 677
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
       call      qword ptr [7FFE70CACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFE70C0EF10]
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
       jmp       qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70CACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFE70C0E9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFE70C0E9B8]
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,24955040008
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
       jb        near ptr M05_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M05_L03
       cmp       r8,40
       ja        short M05_L04
M05_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M05_L06
M05_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L02:
       ret
M05_L03:
       test      r8b,18
       jne       near ptr M05_L08
       test      r8b,4
       jne       near ptr M05_L07
       test      r8,r8
       je        short M05_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M05_L02
M05_L04:
       cmp       r8,800
       ja        near ptr M05_L10
       mov       r9,r8
       shr       r9,6
M05_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M05_L05
       and       r8,3F
       cmp       r8,10
       jbe       short M05_L01
       jmp       near ptr M05_L00
M05_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M05_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M05_L01
M05_L07:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       near ptr M05_L02
M05_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       near ptr M05_L02
M05_L09:
       cmp       rcx,rdx
       je        near ptr M05_L02
M05_L10:
       jmp       qword ptr [7FFE70B25B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 284
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFED03F21F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFED0405B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFED0406B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,281B2BA0210
       call      qword ptr [7FFE70A56B20]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rcx,24128C00438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,24128C00418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,281B2BA0A40
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+28]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,281B2BA0A4C
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L07:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L14
M00_L08:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L11
       mov       rcx,rsi
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       r15,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],rcx
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
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L12
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L10
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L10
M00_L13:
       call      qword ptr [7FFE70BEEF10]
       int       3
M00_L14:
       call      qword ptr [7FFE70BEEFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFE70B94030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 655
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
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFE70BEEF10]
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
       jmp       qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F257D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F256F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,281B2BA0008
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
       call      qword ptr [7FFED03F21F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFED0405B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFED0406B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       call      qword ptr [7FFE70C9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,1FFE14F0210
       call      qword ptr [7FFE70A66B20]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rcx,1BF4F800438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,1BF4F800418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,1FFE14F0A40
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+28]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,1FFE14F0A4C
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70BFEF10]
       int       3
M00_L14:
       call      qword ptr [7FFE70BFEFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFE70BA4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFE70C9CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFE70BFEF10]
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
       jmp       qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70B15B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C9CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFE70BFE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFE70BFE9B8]
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,1FFE14F0008
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
       call      qword ptr [7FFED03F21F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFED0405B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFED0406B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       call      qword ptr [7FFE70C9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,2A0DD8A0210
       call      qword ptr [7FFE70A66B20]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rcx,2604B800438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,2604B800418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,2A0DD8A0A40
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+28]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,2A0DD8A0A4C
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70BFEF10]
       int       3
M00_L14:
       call      qword ptr [7FFE70BFEFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFE70BA4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFE70C9CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFE70BFEF10]
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
       jmp       qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70B15B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C9CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFE70BFE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFE70BFE9B8]
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,2A0DD8A0008
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
       call      qword ptr [7FFED03F21F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFED0405B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFED0406B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       call      qword ptr [7FFE70C9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,2A0F1CE0210
       call      qword ptr [7FFE70A66B20]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rcx,26060000438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,26060000418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,2A0F1CE0A40
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+28]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,2A0F1CE0A4C
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70BFEF10]
       int       3
M00_L14:
       call      qword ptr [7FFE70BFEFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFE70BA4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFE70C9CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFE70BFEF10]
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
       jmp       qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70B15B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C9CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFE70BFE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFE70BFE9B8]
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,2A0F1CE0008
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
       call      qword ptr [7FFED03F21F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFED0405B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFED0406B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       call      qword ptr [7FFE70C7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,2842F760210
       call      qword ptr [7FFE70A46B20]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rcx,2439D800438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,2439D800418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,2842F760A40
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+28]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,2842F760A4C
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70BDEF10]
       int       3
M00_L14:
       call      qword ptr [7FFE70BDEFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFE70B84030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFE70C7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFE70BDEF10]
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
       jmp       qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
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
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
       jmp       near ptr M03_L02
M03_L09:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE70AF5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L10:
       cmp       rcx,rdx
       je        near ptr M03_L02
       jmp       short M03_L09
; Total bytes of code 275
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFE70BDE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFE70BDE9B8]
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,2842F760008
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
       call      qword ptr [7FFED03F21F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFED0405B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFED0406B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,28C6B140210
       call      qword ptr [7FFE70A56B20]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rcx,24BD9400438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,24BD9400418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L16
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,28C6B140A40
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r12d
       mov       r12,[rsp+28]
       lea       r8,[r12+r8*2+0C]
       mov       rcx,28C6B140A4C
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L10:
       cmp       ebp,[rdi+44]
       jne       short M00_L14
M00_L11:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L12
       mov       rcx,rsi
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE70BEEF10]
       int       3
M00_L14:
       call      qword ptr [7FFE70BEEFB8]
       int       3
M00_L15:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L16:
       call      qword ptr [7FFE70B94030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFE70BEEF10]
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
       jmp       qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,28C6B140008
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
       call      qword ptr [7FFED03F21F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFED0405B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFED0406B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       mov       rdi,[rbx+190]
       mov       ebp,[rdi+44]
       xor       r14d,r14d
       jmp       near ptr M00_L08
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
       call      qword ptr [7FFE70C7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L02:
       mov       rcx,r15
       mov       r8,r13
       mov       rdx,21EDF7D0210
       call      qword ptr [7FFE70A46B20]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M00_L13
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M00_L13
       mov       rax,[rcx]
       add       rax,10
M00_L03:
       cmp       qword ptr [rax+8],0
       jne       short M00_L04
       mov       rcx,1DE4D800438
       cmp       qword ptr [rcx],0
       jne       short M00_L04
       mov       rcx,1DE4D800418
       cmp       qword ptr [rcx],0
       je        near ptr M00_L14
M00_L04:
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       short M00_L05
       mov       r12,21EDF7D0A40
       jmp       short M00_L06
M00_L05:
       mov       r12d,r13d
       lea       ecx,[r12+1]
       test      ecx,ecx
       jl        near ptr M00_L11
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       lea       rdx,[r15+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    rcx,r12d
       mov       r12,[rsp+28]
       lea       rcx,[r12+rcx*2+0C]
       mov       rax,21EDF7D0A4C
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
M00_L06:
       test      r12,r12
       je        short M00_L08
       lea       rdx,[r12+0C]
       mov       r13d,[r12+8]
       test      r13d,r13d
       je        short M00_L08
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
M00_L07:
       add       r13d,r12d
       mov       [rsi+18],r13d
M00_L08:
       cmp       ebp,[rdi+44]
       jne       near ptr M00_L12
M00_L09:
       mov       ecx,[rdi+38]
       cmp       r14d,ecx
       jb        short M00_L10
       mov       rcx,rsi
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       r15,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],rcx
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
M00_L10:
       mov       rcx,[rdi+10]
       lea       edx,[r14+1]
       mov       r15d,edx
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L18
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       mov       r14d,r15d
       jl        short M00_L09
       mov       r15,[rcx]
       mov       r13,[rcx+8]
       jmp       near ptr M00_L00
M00_L11:
       call      qword ptr [7FFE70BDEF10]
       int       3
M00_L12:
       call      qword ptr [7FFE70BDEFB8]
       int       3
M00_L13:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L14:
       call      qword ptr [7FFE70B84030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L04
M00_L15:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L07
M00_L16:
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       cmp       ebp,[rdi+44]
       je        near ptr M00_L09
       jmp       short M00_L12
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 682
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
       call      qword ptr [7FFE70C7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
M02_L01:
       call      qword ptr [7FFE70BDEF10]
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
       jmp       qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFE70AF5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,21EDF7D0008
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
       call      qword ptr [7FFED03F21F0]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFED0405B50]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFED0406B48]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M06_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L04:
       test      eax,eax
       jne       short M06_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M06_L00
M06_L05:
       call      qword ptr [7FFE70BDE9A0]
       int       3
M06_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M06_L02
M06_L07:
       call      qword ptr [7FFE70BDE9B8]
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
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFE71265578]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        near ptr M01_L04
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L20
       mov       ecx,[rsi+38]
       sub       ecx,[rsi+40]
M01_L00:
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
M01_L01:
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L21
       mov       rcx,19BB6C04C80
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-88],rcx
       cmp       qword ptr [rbp-88],0
       je        near ptr M01_L22
       lea       rcx,[r14+20]
       mov       r8,[rbp-88]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       jne       near ptr M01_L22
M01_L02:
       mov       r15,[rbp-88]
M01_L03:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r15
       jmp       short M01_L05
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L01
M01_L05:
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A4EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbx+10]
       mov       r13,[rcx+20]
       test      r13,r13
       je        short M01_L07
M01_L06:
       jmp       near ptr M01_L17
M01_L07:
       mov       rcx,rbx
       mov       rdx,7FFE7124A050
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r13,rax
       jmp       short M01_L06
M01_L08:
       mov       rcx,rbx
       mov       rdx,7FFE7124A1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L16
M01_L09:
       mov       r12,[rbp-50]
       mov       r14,[rbp-48]
       mov       ecx,[r15+1C]
       mov       edx,[r15+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L11
       mov       ecx,edx
       mov       rax,[r15+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L10
       mov       [rax+rcx*2+10],di
       inc       edx
       mov       [r15+18],edx
       jmp       short M01_L11
M01_L10:
       movzx     edx,di
       mov       rcx,r15
       call      qword ptr [7FFE70C7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L11:
       mov       rcx,r15
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       byte ptr [rbp-70],0
       mov       rcx,[rbx+10]
       mov       rdx,[rcx+30]
       test      rdx,rdx
       je        short M01_L13
M01_L12:
       lea       rcx,[rbp-80]
       mov       r8,r12
       call      qword ptr [7FFE71265F80]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,1DC48B10A4C
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
       mov       rcx,rbx
       mov       rdx,7FFE7124A110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L12
M01_L14:
       mov       r8d,1
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L15:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       near ptr M01_L08
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M01_L08
M01_L16:
       lea       rcx,[rbp-80]
       mov       r8,r14
       call      qword ptr [7FFE71265F80]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L17:
       mov       rdx,r13
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE70E07978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L09
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L18
       mov       rax,[rcx+40]
       test      rax,rax
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rbx
       mov       rdx,7FFE7124A208
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L19:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L27
       jmp       short M01_L24
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       rcx,rsi
       mov       r11,7FFE70900D48
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M01_L00
M01_L21:
       mov       rax,1DC48B10008
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
M01_L22:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710A4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L23
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L02
M01_L23:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L24:
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
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L25
       mov       rax,[rcx+40]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFE7124A208
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L26:
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
M01_L27:
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
       mov       rcx,19BB6C04C80
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L28
       mov       r14,[rbp-90]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L32
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE70C7C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L29
M01_L28:
       mov       rdx,[rbp-90]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-90]
       je        short M01_L32
M01_L29:
       cmp       qword ptr [r15+20],0
       jne       short M01_L30
       lea       rcx,[r15+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L32
M01_L30:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L31
       mov       rcx,[r15+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710A4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L32
M01_L31:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L32:
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
; Total bytes of code 1110
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFE712954D0]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        near ptr M01_L04
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L20
       mov       ecx,[rsi+38]
       sub       ecx,[rsi+40]
M01_L00:
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
M01_L01:
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L21
       mov       rcx,1363C404C80
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-88],rcx
       cmp       qword ptr [rbp-88],0
       je        near ptr M01_L22
       lea       rcx,[r14+20]
       mov       r8,[rbp-88]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       jne       near ptr M01_L22
M01_L02:
       mov       r15,[rbp-88]
M01_L03:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r15
       jmp       short M01_L05
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L01
M01_L05:
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A7EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbx+10]
       mov       r13,[rcx+20]
       test      r13,r13
       je        short M01_L07
M01_L06:
       jmp       near ptr M01_L17
M01_L07:
       mov       rcx,rbx
       mov       rdx,7FFE7127A050
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r13,rax
       jmp       short M01_L06
M01_L08:
       mov       rcx,rbx
       mov       rdx,7FFE7127A1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L16
M01_L09:
       mov       r12,[rbp-50]
       mov       r14,[rbp-48]
       mov       ecx,[r15+1C]
       mov       edx,[r15+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L11
       mov       ecx,edx
       mov       rax,[r15+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L10
       mov       [rax+rcx*2+10],di
       inc       edx
       mov       [r15+18],edx
       jmp       short M01_L11
M01_L10:
       movzx     edx,di
       mov       rcx,r15
       call      qword ptr [7FFE70CAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L11:
       mov       rcx,r15
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       byte ptr [rbp-70],0
       mov       rcx,[rbx+10]
       mov       rdx,[rcx+30]
       test      rdx,rdx
       je        short M01_L13
M01_L12:
       lea       rcx,[rbp-80]
       mov       r8,r12
       call      qword ptr [7FFE71295ED8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,176CE260A4C
       mov       rax,[rcx+8]
       mov       r8d,[rcx+18]
       lea       r10d,[r8+1]
       cmp       [rax+8],r10d
       jb        short M01_L14
       movsxd    rdx,r8d
       mov       word ptr [rax+rdx*2+10],3A
       mov       [rcx+18],r10d
       jmp       short M01_L15
M01_L13:
       mov       rcx,rbx
       mov       rdx,7FFE7127A110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L12
M01_L14:
       mov       r8d,1
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L15:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       near ptr M01_L08
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M01_L08
M01_L16:
       lea       rcx,[rbp-80]
       mov       r8,r14
       call      qword ptr [7FFE71295ED8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L17:
       mov       rdx,r13
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE70E371C8]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L09
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L18
       mov       rax,[rcx+40]
       test      rax,rax
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rbx
       mov       rdx,7FFE7127A208
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L19:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L27
       jmp       short M01_L24
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       rcx,rsi
       mov       r11,7FFE70930D48
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M01_L00
M01_L21:
       mov       rax,176CE260008
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
M01_L22:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L23
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L02
M01_L23:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L24:
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
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L25
       mov       rax,[rcx+40]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFE7127A208
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L26:
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
M01_L27:
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
       mov       rcx,1363C404C80
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L28
       mov       r14,[rbp-90]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L32
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L29
M01_L28:
       mov       rdx,[rbp-90]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-90]
       je        short M01_L32
M01_L29:
       cmp       qword ptr [r15+20],0
       jne       short M01_L30
       lea       rcx,[r15+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L32
M01_L30:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L31
       mov       rcx,[r15+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L32
M01_L31:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L32:
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
; Total bytes of code 1110
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFE71277258]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       je        near ptr M01_L04
       mov       r8,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],r8
       jne       near ptr M01_L20
       mov       r8d,[rsi+38]
       sub       r8d,[rsi+40]
M01_L00:
       test      r8d,r8d
       setg      r8b
       movzx     r8d,r8b
M01_L01:
       movzx     r8d,r8b
       test      r8d,r8d
       je        near ptr M01_L21
       mov       r8,1C560404C80
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-88],r8
       cmp       qword ptr [rbp-88],0
       je        near ptr M01_L22
       lea       r8,[rdi+20]
       mov       rdx,[rbp-88]
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       jne       near ptr M01_L22
M01_L02:
       mov       r14,[rbp-88]
M01_L03:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r14
       jmp       short M01_L05
M01_L04:
       xor       r8d,r8d
       jmp       short M01_L01
M01_L05:
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A5EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+20]
       test      r15,r15
       je        short M01_L07
M01_L06:
       jmp       near ptr M01_L17
M01_L07:
       mov       rdx,7FFE7125BE18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r15,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L06
M01_L08:
       mov       rdx,7FFE7125BF98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L16
M01_L09:
       mov       r13,[rbp-50]
       mov       r12,[rbp-48]
       mov       ecx,[r14+1C]
       mov       edx,[r14+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L11
       mov       ecx,edx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L10
       mov       [rax+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L11
M01_L10:
       movzx     edx,bx
       mov       rcx,r14
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L11:
       mov       rcx,r14
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
       mov       r8,r13
       call      qword ptr [7FFE71277C60]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,205F2310A4C
       mov       rax,[rcx+8]
       mov       r8d,[rcx+18]
       lea       r10d,[r8+1]
       cmp       [rax+8],r10d
       jb        short M01_L14
       movsxd    rdx,r8d
       mov       word ptr [rax+rdx*2+10],3A
       mov       [rcx+18],r10d
       jmp       short M01_L15
M01_L13:
       mov       rdx,7FFE7125BED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L12
M01_L14:
       mov       r8d,1
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       r8,r12
       call      qword ptr [7FFE71277C60]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L17:
       mov       rdx,r15
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE70E17978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE7125BFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L19:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L27
       jmp       short M01_L24
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       rcx,rsi
       mov       r11,7FFE70910D38
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M01_L00
M01_L21:
       mov       rax,205F2310008
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
M01_L22:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L23
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L02
M01_L23:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L03
M01_L24:
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
       jle       short M01_L25
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FFE7125BFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L26:
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
M01_L27:
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
       mov       rcx,1C560404C80
       mov       r14,[rcx]
       mov       rax,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L28
       mov       r15,[rbp-90]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L32
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L29
M01_L28:
       mov       rdx,[rbp-90]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r15,[rbp-90]
       je        short M01_L32
M01_L29:
       cmp       qword ptr [r14+20],0
       jne       short M01_L30
       lea       rcx,[r14+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L32
M01_L30:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L31
       mov       rcx,[r14+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L32
M01_L31:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L32:
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
; Total bytes of code 1126
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFE71277258]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       je        near ptr M01_L04
       mov       r8,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],r8
       jne       near ptr M01_L20
       mov       r8d,[rsi+38]
       sub       r8d,[rsi+40]
M01_L00:
       test      r8d,r8d
       setg      r8b
       movzx     r8d,r8b
M01_L01:
       movzx     r8d,r8b
       test      r8d,r8d
       je        near ptr M01_L21
       mov       r8,15FB5804C80
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-88],r8
       cmp       qword ptr [rbp-88],0
       je        near ptr M01_L22
       lea       r8,[rdi+20]
       mov       rdx,[rbp-88]
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       jne       near ptr M01_L22
M01_L02:
       mov       r14,[rbp-88]
M01_L03:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r14
       jmp       short M01_L05
M01_L04:
       xor       r8d,r8d
       jmp       short M01_L01
M01_L05:
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A5EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+20]
       test      r15,r15
       je        short M01_L07
M01_L06:
       jmp       near ptr M01_L17
M01_L07:
       mov       rdx,7FFE7125BE18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r15,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L06
M01_L08:
       mov       rdx,7FFE7125BF98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L16
M01_L09:
       mov       r13,[rbp-50]
       mov       r12,[rbp-48]
       mov       ecx,[r14+1C]
       mov       edx,[r14+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L11
       mov       ecx,edx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L10
       mov       [rax+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L11
M01_L10:
       movzx     edx,bx
       mov       rcx,r14
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L11:
       mov       rcx,r14
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
       mov       r8,r13
       call      qword ptr [7FFE71277C60]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,1A047970A4C
       mov       rax,[rcx+8]
       mov       r8d,[rcx+18]
       lea       r10d,[r8+1]
       cmp       [rax+8],r10d
       jb        short M01_L14
       movsxd    rdx,r8d
       mov       word ptr [rax+rdx*2+10],3A
       mov       [rcx+18],r10d
       jmp       short M01_L15
M01_L13:
       mov       rdx,7FFE7125BED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L12
M01_L14:
       mov       r8d,1
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       r8,r12
       call      qword ptr [7FFE71277C60]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L17:
       mov       rdx,r15
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE70E17978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE7125BFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L19:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L27
       jmp       short M01_L24
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       rcx,rsi
       mov       r11,7FFE70910D50
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M01_L00
M01_L21:
       mov       rax,1A047970008
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
M01_L22:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L23
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L02
M01_L23:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L03
M01_L24:
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
       jle       short M01_L25
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FFE7125BFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L26:
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
M01_L27:
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
       mov       rcx,15FB5804C80
       mov       r14,[rcx]
       mov       rax,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L28
       mov       r15,[rbp-90]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L32
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L29
M01_L28:
       mov       rdx,[rbp-90]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r15,[rbp-90]
       je        short M01_L32
M01_L29:
       cmp       qword ptr [r14+20],0
       jne       short M01_L30
       lea       rcx,[r14+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L32
M01_L30:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L31
       mov       rcx,[r14+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L32
M01_L31:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L32:
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
; Total bytes of code 1126
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.ToDelimitedString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFE712A7258]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       mov       r8,1C004004C80
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
       call      qword ptr [7FFE70A8EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+20]
       test      r13,r13
       je        short M01_L05
M01_L04:
       jmp       near ptr M01_L15
M01_L05:
       mov       rdx,7FFE7128BE18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r13,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L04
M01_L06:
       mov       rdx,7FFE7128BF98
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
       call      qword ptr [7FFE70CBC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFE712A7C60]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,1BF83290A4C
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
       mov       rdx,7FFE7128BED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L10
M01_L12:
       mov       r8d,1
       call      qword ptr [7FFE70CBCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE712A7C60]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L15:
       mov       rdx,r13
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE70E47978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE7128BFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L17:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CC8140]; System.Text.StringBuilder.ToString()
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
       mov       r11,7FFE70940C78
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M01_L00
M01_L20:
       mov       rax,1BF83290008
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
       call      qword ptr [7FFE710E4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,7FFE7128BFD0
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
       mov       rcx,1C004004C80
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
       call      qword ptr [7FFE70CBC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710E4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFE71277258]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       mov       r8,1FC0E004C80
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
       call      qword ptr [7FFE70A5EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+20]
       test      r13,r13
       je        short M01_L05
M01_L04:
       jmp       near ptr M01_L15
M01_L05:
       mov       rdx,7FFE7125BE18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r13,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L04
M01_L06:
       mov       rdx,7FFE7125BF98
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
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFE71277C60]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,23C9FD00A4C
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
       mov       rdx,7FFE7125BED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L10
M01_L12:
       mov       r8d,1
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE71277C60]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L15:
       mov       rdx,r13
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE70E17978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE7125BFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L17:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       mov       r11,7FFE70910C90
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M01_L00
M01_L20:
       mov       rax,23C9FD00008
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
       call      qword ptr [7FFE710B4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,7FFE7125BFD0
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
       mov       rcx,1FC0E004C80
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
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFE71277258]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       mov       rdx,24D57C04C80
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
       call      qword ptr [7FFE710B5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,28DE9B29CB0
       call      qword ptr [7FFE70D940D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE70A5EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r14,[rdx+20]
       test      r14,r14
       je        short M01_L07
M01_L06:
       jmp       near ptr M01_L17
M01_L07:
       mov       rdx,7FFE7125BE18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L06
M01_L08:
       mov       rdx,7FFE7125BF98
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
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFE71277C60]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,28DE9B20A4C
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
       mov       rdx,7FFE7125BED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L12
M01_L14:
       mov       r8d,1
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE71277C60]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L17:
       mov       rdx,r14
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE70E17978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE7125BFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L19:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       mov       r11,7FFE70910C78
       call      qword ptr [r11]
       mov       edx,eax
       jmp       near ptr M01_L00
M01_L22:
       mov       rax,28DE9B20008
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
       call      qword ptr [7FFE710B4DB0]
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
       mov       rdx,7FFE7125BFD0
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
       mov       rcx,24D57C04C80
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
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rdx,[rbx+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>, Char)
       mov       r8d,3A
       call      qword ptr [7FFE7137D860]; DotNetTips.Spargine.Core.FastStringBuilder.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
       je        near ptr M01_L24
       mov       r8,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],r8
       jne       near ptr M01_L25
       mov       r8d,[rsi+38]
       sub       r8d,[rsi+40]
M01_L00:
       xor       edi,edi
       test      r8d,r8d
       setg      dil
M01_L01:
       movzx     r8d,dil
       test      r8d,r8d
       je        near ptr M01_L26
       mov       r8,1E40CC04C80
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-88],r8
       cmp       qword ptr [rbp-88],0
       je        short M01_L02
       lea       r8,[rdi+20]
       mov       rdx,[rbp-88]
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-88]
       je        near ptr M01_L08
M01_L02:
       mov       r14,[rdi+18]
       mov       r15,[r14+18]
       lea       rdx,[rbp-88]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE710C5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L07
       cmp       qword ptr [r15+10],0
       jne       short M01_L03
       xor       edx,edx
       mov       [rbp-88],rdx
       jmp       short M01_L04
M01_L03:
       lea       rdx,[rbp-88]
       mov       rcx,r14
       call      qword ptr [7FFE710C4DB0]
       test      eax,eax
       jne       near ptr M01_L07
M01_L04:
       mov       rdi,[rdi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [rdi+18],rcx
       jne       near ptr M01_L28
       mov       rdi,[rdi+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edi,[rdi+8]
       mov       ecx,edi
       mov       rdx,2249EC99CB0
       call      qword ptr [7FFE70DA40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       edx,10
       test      edi,edi
       cmove     edi,edx
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edi,400
       jl        near ptr M01_L27
       mov       edx,edi
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L05:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L06:
       xor       edx,edx
       mov       [rbp-88],rdx
       mov       [rbp-90],r14
       jmp       short M01_L09
M01_L07:
       add       rdi,2C
       lock dec  dword ptr [rdi]
M01_L08:
       mov       r14,[rbp-88]
       jmp       short M01_L06
M01_L09:
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A6EE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r15,[rdx+20]
       test      r15,r15
       je        short M01_L11
M01_L10:
       jmp       near ptr M01_L21
M01_L11:
       mov       rdx,7FFE71369748
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r15,rax
       mov       rcx,[rbp+10]
       jmp       short M01_L10
M01_L12:
       mov       rdx,7FFE713698C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M01_L20
M01_L13:
       mov       r13,[rbp-50]
       mov       r12,[rbp-48]
       mov       ecx,[r14+1C]
       mov       edx,[r14+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L15
       mov       ecx,edx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M01_L14
       mov       [rax+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L15
M01_L14:
       movzx     edx,bx
       mov       rcx,r14
       call      qword ptr [7FFE70C9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L15:
       mov       rcx,r14
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       byte ptr [rbp-70],0
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L17
M01_L16:
       lea       rcx,[rbp-80]
       mov       r8,r13
       call      qword ptr [7FFE7137E268]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rbp-80]
       mov       rdx,2249EC90A4C
       mov       rax,[rcx+8]
       mov       r8d,[rcx+18]
       lea       r10d,[r8+1]
       cmp       [rax+8],r10d
       jb        short M01_L18
       movsxd    rdx,r8d
       mov       word ptr [rax+rdx*2+10],3A
       mov       [rcx+18],r10d
       jmp       short M01_L19
M01_L17:
       mov       rdx,7FFE71369808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L16
M01_L18:
       mov       r8d,1
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       near ptr M01_L12
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M01_L12
M01_L20:
       lea       rcx,[rbp-80]
       mov       r8,r12
       call      qword ptr [7FFE7137E268]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M01_L21:
       mov       rdx,r15
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE70E27978]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L13
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],40
       jle       short M01_L22
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFE71369900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp-68]
       call      rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       short M01_L29
       call      CORINFO_HELP_OVERFLOW
M01_L24:
       xor       edi,edi
       jmp       near ptr M01_L01
M01_L25:
       mov       rcx,rsi
       mov       r11,7FFE70920F98
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M01_L00
M01_L26:
       mov       rax,2249EC90008
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
M01_L27:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L05
M01_L28:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14,rax
       jmp       near ptr M01_L06
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
       mov       rdx,7FFE71369900
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
       mov       rcx,1E40CC04C80
       mov       r14,[rcx]
       mov       rsi,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L33
       mov       r15,[rbp-90]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L37
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE70C9C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       r15,[rbp-90]
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L37
M01_L34:
       cmp       qword ptr [r14+20],0
       jne       short M01_L35
       lea       rcx,[r14+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L37
M01_L35:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L36
       mov       rcx,[r14+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE710C4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       r14,2C
       lock dec  dword ptr [r14]
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
; Total bytes of code 1319
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
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
       mov       ebp,[r8+8]
       test      ebp,ebp
       je        short M00_L04
       mov       r8,[rsi+8]
       mov       r14d,[rsi+18]
       lea       ecx,[r14+rbp]
       cmp       ecx,[r8+8]
       ja        short M00_L03
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       ebp,2
       jle       short M00_L02
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L01:
       add       ebp,r14d
       mov       [rsi+18],ebp
       jmp       short M00_L04
M00_L02:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebp,2
       je        short M00_L06
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
M00_L06:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 299
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
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F257D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F256F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2BA81D20008
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
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
       jmp       qword ptr [7FFE70AF5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BDE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BDE9B8]
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,18B3B4B0008
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,279E9AD0008
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
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
       jb        near ptr M01_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L11
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
       ja        short M01_L05
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       test      r8b,18
       je        short M01_L08
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L02
M01_L04:
       cmp       r8,800
       ja        near ptr M01_L12
       jmp       short M01_L06
M01_L05:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L06:
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
       jmp       short M01_L09
M01_L08:
       test      r8b,4
       je        short M01_L10
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L02
M01_L09:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L00
       jmp       near ptr M01_L01
M01_L10:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L11:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L12:
       jmp       qword ptr [7FFE70B15B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C9CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BFE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BFE9B8]
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F35EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,25FB11C0008
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
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
       jmp       qword ptr [7FFE70AF5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BDE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BDE9B8]
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F15EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2D3D8F70008
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F25EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,239791B0008
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        short M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       jmp       qword ptr [7FFE70B05B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70C8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F257D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70BEE9B8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F256F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2F049820008
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
       call      qword ptr [7FFE70B35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70CBCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L04:
       inc       edi
       mov       rcx,[rbx+198]
       cmp       [rcx+8],edi
       jg        near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFE70CC8140]; System.Text.StringBuilder.ToString()
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
       jmp       qword ptr [7FFE70B35B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70B35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE70CBCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE70B35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70934000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F55FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE70C1E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE70C1E9B8]
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
       call      qword ptr [7FFE70B35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE70934000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70F55EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE70B3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,20DA13B0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE712954D0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L14
       mov       rdx,13D71C04C80
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L15
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L17
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L16
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L20
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L18
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L19
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
       mov       rdx,17E039E57D4
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
M01_L04:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
       xor       ebx,ebx
       test      r14d,r14d
       jle       near ptr M01_L11
M01_L05:
       mov       ecx,ebx
       movzx     ecx,byte ptr [rdi+rcx]
       mov       r8,13D71C00428
       mov       r8,[r8]
       mov       rdx,17E039E57E8
       call      qword ptr [7FFE70BE4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L08
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M01_L07
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L09
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L10
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L10
M01_L06:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L04
M01_L07:
       mov       rcx,r15
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L08:
       inc       ebx
       cmp       ebx,r14d
       jl        near ptr M01_L05
       jmp       short M01_L11
M01_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       mov       [r15+18],esi
       jmp       short M01_L08
M01_L11:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L12
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
       jmp       short M01_L13
M01_L12:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFE70CAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L13:
       mov       rcx,r15
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L22
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
M01_L14:
       mov       rax,17E039D0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L21
       jmp       near ptr M01_L00
M01_L16:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE710D4DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L17:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L21
M01_L18:
       mov       ecx,13C20
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE7129EBE0]
       int       3
M01_L19:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L20:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L21:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L22:
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
       mov       rcx,13D71C04C80
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L23
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L27
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L24
M01_L23:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L27
M01_L24:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L25
       lea       rcx,[rbx+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L27
M01_L25:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L26
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L27
M01_L26:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L27:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 950
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE712971B0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L15
       mov       rdx,21D0E804C80
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-28],rdx
       cmp       qword ptr [rbp-28],0
       jne       near ptr M01_L16
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-28]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L18
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L17
       xor       ecx,ecx
       mov       [rbp-28],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L21
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       esi,[rsi+8]
       test      esi,esi
       jl        near ptr M01_L19
       mov       edx,10
       test      esi,esi
       cmove     esi,edx
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       esi,400
       jl        near ptr M01_L20
       mov       edx,esi
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       mov       rdx,r14
M01_L04:
       xor       ecx,ecx
       mov       [rbp-28],rcx
       mov       [rbp-30],rdx
       mov       r8,25DA07057F4
       mov       rcx,[rdx+8]
       mov       eax,[rdx+18]
       lea       r10d,[rax+3]
       cmp       [rcx+8],r10d
       jb        near ptr M01_L07
       movsxd    r10,eax
       lea       rcx,[rcx+r10*2+10]
       mov       r9d,[r8]
       mov       r10d,[r8+2]
       mov       [rcx],r9d
       mov       [rcx+2],r10d
       add       eax,3
       mov       [rdx+18],eax
M01_L05:
       lea       rdi,[rbx+10]
       mov       esi,[rbx+8]
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M01_L12
M01_L06:
       mov       ecx,r14d
       movzx     ecx,byte ptr [rdi+rcx]
       mov       r8,21D0E800428
       mov       r8,[r8]
       mov       rdx,25DA0705808
       call      qword ptr [7FFE70BE4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[rbp-30]
       mov       rax,[rcx+8]
       mov       r10d,[rcx+18]
       lea       ebx,[r10+r8]
       cmp       ebx,[rax+8]
       ja        short M01_L08
       movsxd    r10,r10d
       lea       rax,[rax+r10*2+10]
       cmp       r8d,2
       jg        short M01_L10
       movzx     r10d,word ptr [rdx]
       mov       [rax],r10w
       cmp       r8d,2
       jne       short M01_L11
       movzx     r8d,word ptr [rdx+2]
       mov       [rax+2],r8w
       jmp       short M01_L11
M01_L07:
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8d,3
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       rdx,[rbp-30]
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,[rbp-30]
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       inc       r14d
       cmp       r14d,esi
       jl        near ptr M01_L06
       mov       rdx,[rbp-30]
       jmp       short M01_L12
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rcx,[rbp-30]
       mov       [rcx+18],ebx
       jmp       short M01_L09
M01_L12:
       mov       ecx,[rdx+18]
       mov       eax,ecx
       mov       r8,[rdx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M01_L13
       mov       word ptr [r8+rax*2+10],27
       inc       ecx
       mov       [rdx+18],ecx
       jmp       short M01_L14
M01_L13:
       mov       rcx,rdx
       mov       edx,27
       call      qword ptr [7FFE70CAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rdx,[rbp-30]
M01_L14:
       mov       rcx,rdx
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-38],rax
       mov       rcx,rsp
       call      M01_L23
       nop
       mov       rax,[rbp-38]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L15:
       mov       rax,25DA06F0008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-28]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-28]
       je        short M01_L22
       jmp       near ptr M01_L00
M01_L17:
       lea       rdx,[rbp-28]
       mov       rcx,rdi
       call      qword ptr [7FFE710D4DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L18:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L22
M01_L19:
       mov       ecx,13C20
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE712D4AE0]
       int       3
M01_L20:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L21:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r14,rax
       jmp       near ptr M01_L03
M01_L22:
       mov       rdx,[rbp-28]
       jmp       near ptr M01_L04
M01_L23:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,21D0E804C80
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L24
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rsi+8]
       cmp       edx,[rax+0C]
       jg        short M01_L28
       xor       edx,edx
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L25
M01_L24:
       mov       rdx,[rbp-30]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L28
M01_L25:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L26
       lea       rcx,[rbx+20]
       mov       rdx,[rbp-30]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L28
M01_L26:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L27
       mov       rcx,[rbx+18]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L28
M01_L27:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L28:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 960
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE712854D0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L14
       mov       rdx,2A53FC04C80
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L15
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710C5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L17
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L16
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L20
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L18
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L19
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
       mov       rdx,2E5D1B457D4
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
M01_L04:
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
       xor       ebx,ebx
       test      r14d,r14d
       jle       near ptr M01_L11
M01_L05:
       mov       ecx,ebx
       movzx     ecx,byte ptr [rdi+rcx]
       mov       r8,2A53FC00428
       mov       r8,[r8]
       mov       rdx,2E5D1B457E8
       call      qword ptr [7FFE70BD4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L08
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M01_L07
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L09
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L10
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L10
M01_L06:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L04
M01_L07:
       mov       rcx,r15
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L08:
       inc       ebx
       cmp       ebx,r14d
       jl        near ptr M01_L05
       jmp       short M01_L11
M01_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       mov       [r15+18],esi
       jmp       short M01_L08
M01_L11:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L12
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
       jmp       short M01_L13
M01_L12:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFE70C9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L13:
       mov       rcx,r15
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L22
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
M01_L14:
       mov       rax,2E5D1B30008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L21
       jmp       near ptr M01_L00
M01_L16:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE710C4DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L17:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L21
M01_L18:
       mov       ecx,13C20
       mov       rdx,7FFE70914000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE7128EBE0]
       int       3
M01_L19:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L20:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L21:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L22:
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
       mov       rcx,2A53FC04C80
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L23
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L27
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE70C9C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L24
M01_L23:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L27
M01_L24:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L25
       lea       rcx,[rbx+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L27
M01_L25:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L26
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE710C4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L27
M01_L26:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L27:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 950
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE712654D0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       mov       rdx,12D46804C80
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L16
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710A5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L18
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L17
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L21
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L19
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L20
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
       mov       rax,16DD8980008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdx,16DD89957D4
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
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
       xor       ebx,ebx
       test      r14d,r14d
       jle       near ptr M01_L13
M01_L07:
       mov       ecx,ebx
       movzx     ecx,byte ptr [rdi+rcx]
       mov       r8,12D46800428
       mov       r8,[r8]
       mov       rdx,16DD89957E8
       call      qword ptr [7FFE70BB4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       inc       ebx
       cmp       ebx,r14d
       jl        near ptr M01_L07
       jmp       short M01_L13
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       [r15+18],esi
       jmp       short M01_L10
M01_L13:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L14
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFE70C7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L15:
       mov       rcx,r15
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L23
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
M01_L16:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L22
       jmp       near ptr M01_L00
M01_L17:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE710A4DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L18:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L22
M01_L19:
       mov       ecx,13C20
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE7126EEB0]
       int       3
M01_L20:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L21:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L22:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L23:
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
       mov       rcx,12D46804C80
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L24
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L28
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE70C7C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L25
M01_L24:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L28
M01_L25:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L26
       lea       rcx,[rbx+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L28
M01_L26:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L27
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE710A4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L28
M01_L27:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L28:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 952
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE712A7270]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       mov       rdx,19A16404C80
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L16
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710E5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L18
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L17
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L21
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L19
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L20
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
       mov       rax,1DAA84A0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdx,1DAA84B57F4
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
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
       xor       ebx,ebx
       test      r14d,r14d
       jle       near ptr M01_L13
M01_L07:
       mov       ecx,ebx
       movzx     ecx,byte ptr [rdi+rcx]
       mov       r8,19A16400428
       mov       r8,[r8]
       mov       rdx,1DAA84B5808
       call      qword ptr [7FFE70BF4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE70CBCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFE70CBCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       inc       ebx
       cmp       ebx,r14d
       jl        near ptr M01_L07
       jmp       short M01_L13
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70B35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       [r15+18],esi
       jmp       short M01_L10
M01_L13:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L14
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFE70CBC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L15:
       mov       rcx,r15
       call      qword ptr [7FFE70CC8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L23
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
M01_L16:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L22
       jmp       near ptr M01_L00
M01_L17:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE710E4DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L18:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L22
M01_L19:
       mov       ecx,13C20
       mov       rdx,7FFE70934000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE712E4EE8]
       int       3
M01_L20:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L21:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L22:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L23:
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
       mov       rcx,19A16404C80
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L24
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L28
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE70CBC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L25
M01_L24:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L28
M01_L25:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L26
       lea       rcx,[rbx+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L28
M01_L26:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L27
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE710E4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L28
M01_L27:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L28:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 952
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE71277270]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       mov       rdx,1FDFD804C80
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L16
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L18
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L17
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L21
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L19
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L20
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
       mov       rax,23E8F620008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdx,23E8F6357F4
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
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
       xor       ebx,ebx
       test      r14d,r14d
       jle       near ptr M01_L13
M01_L07:
       mov       ecx,ebx
       movzx     ecx,byte ptr [rdi+rcx]
       mov       r8,1FDFD800428
       mov       r8,[r8]
       mov       rdx,23E8F635808
       call      qword ptr [7FFE70BC4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       inc       ebx
       cmp       ebx,r14d
       jl        near ptr M01_L07
       jmp       short M01_L13
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       [r15+18],esi
       jmp       short M01_L10
M01_L13:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L14
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L15:
       mov       rcx,r15
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L23
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
M01_L16:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L22
       jmp       near ptr M01_L00
M01_L17:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE710B4DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L18:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L22
M01_L19:
       mov       ecx,13C20
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE712B4EE8]
       int       3
M01_L20:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L21:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L22:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L23:
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
       mov       rcx,1FDFD804C80
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L24
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L28
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L25
M01_L24:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L28
M01_L25:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L26
       lea       rcx,[rbx+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L28
M01_L26:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L27
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L28
M01_L27:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L28:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 952
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE71297E10]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       mov       rdx,1FA40004C80
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L16
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710C5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L18
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L17
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L20
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       mov       ecx,r14d
       mov       rdx,23AD2069CB0
       call      qword ptr [7FFE70DA40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L19
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
       mov       rax,23AD2060008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdx,23AD20757F4
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
       lea       rdi,[rbx+10]
       mov       r14d,[rbx+8]
       xor       ebx,ebx
       test      r14d,r14d
       jle       near ptr M01_L13
M01_L07:
       mov       ecx,ebx
       movzx     ecx,byte ptr [rdi+rcx]
       mov       r8,1FA40000428
       mov       r8,[r8]
       mov       rdx,23AD2075808
       call      qword ptr [7FFE70BD4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L10:
       inc       ebx
       cmp       ebx,r14d
       jl        near ptr M01_L07
       jmp       short M01_L13
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       [r15+18],esi
       jmp       short M01_L10
M01_L13:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L14
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFE70C9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L15:
       mov       rcx,r15
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L22
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
M01_L16:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L21
       jmp       near ptr M01_L00
M01_L17:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE710C4DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L18:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L21
M01_L19:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L20:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L21:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L22:
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
       mov       rcx,1FA40004C80
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L23
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L27
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE70C9C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L24
M01_L23:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L27
M01_L24:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L25
       lea       rcx,[rbx+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L27
M01_L25:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L26
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE710C4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L27
M01_L26:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L27:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 929
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE71356F40]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L04
       mov       rdx,24DF8804C80
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-40],rdx
       cmp       qword ptr [rbp-40],0
       jne       near ptr M01_L17
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L18
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L21
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       mov       ecx,r14d
       mov       rdx,28E8A989CB0
       call      qword ptr [7FFE70D940D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L20
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
       mov       [rbp-40],rcx
       mov       [rbp-48],r15
       jmp       short M01_L05
M01_L04:
       mov       rax,28E8A980008
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
M01_L05:
       mov       rdx,28E8A995844
       mov       rcx,[r15+8]
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L10
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [r15+18],r8d
M01_L06:
       lea       rsi,[rbx+10]
       mov       r13d,[rbx+8]
       xor       r12d,r12d
       test      r13d,r13d
       jle       near ptr M01_L15
M01_L07:
       mov       ecx,r12d
       movzx     ecx,byte ptr [rsi+rcx]
       mov       r8,24DF8800428
       mov       r8,[r8]
       mov       rdx,28E8A995858
       call      qword ptr [7FFE70BC4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        near ptr M01_L14
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L14
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       ebx,[rax+r8]
       cmp       ebx,[rcx+8]
       ja        short M01_L13
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L11
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L09
M01_L08:
       mov       [r15+18],ebx
       jmp       short M01_L14
M01_L09:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L08
M01_L10:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L08
M01_L12:
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L16
M01_L13:
       mov       rcx,r15
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L14:
       inc       r12d
       cmp       r12d,r13d
       jl        near ptr M01_L07
M01_L15:
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       rdx,[r15+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L12
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [r15+18],ecx
M01_L16:
       mov       rcx,r15
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L23
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
M01_L17:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       je        short M01_L22
       jmp       near ptr M01_L00
M01_L18:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFE710B4DB0]
       test      eax,eax
       je        near ptr M01_L01
M01_L19:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L22
M01_L20:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L21:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L22:
       mov       r15,[rbp-40]
       jmp       near ptr M01_L03
M01_L23:
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
       mov       rcx,24DF8804C80
       mov       r15,[rcx]
       mov       rdi,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M01_L24
       mov       rsi,[rbp-48]
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rsi+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L28
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L25
M01_L24:
       mov       rsi,[rbp-48]
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M01_L28
M01_L25:
       cmp       qword ptr [r15+20],0
       jne       short M01_L26
       lea       rcx,[r15+20]
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L28
M01_L26:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L27
       mov       rcx,[r15+18]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L28
M01_L27:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L28:
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
; Total bytes of code 963
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFE712954E8]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       je        near ptr M01_L10
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,1C42C804C80
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L06:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CAC330]
       jmp       short M01_L08
M01_L07:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L04
       jmp       short M01_L03
M01_L08:
       inc       r13d
       cmp       edi,r13d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L13
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
       mov       rax,204BE5C0008
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
M01_L11:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L12
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L12:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L13:
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
       mov       rcx,1C42C804C80
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L14
       mov       r14,[rbp-48]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L18
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L15
M01_L14:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-48]
       je        short M01_L18
M01_L15:
       cmp       qword ptr [r15+20],0
       jne       short M01_L16
       lea       rcx,[r15+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L18
M01_L16:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L17
       mov       rcx,[r15+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L18
M01_L17:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L18:
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
; Total bytes of code 631
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFE71297288]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       test      rsi,rsi
       je        near ptr M01_L10
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,17A9DC04C80
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
       mov       rdx,[rsi+r8*8+10]
       test      bl,bl
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L06:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CAC330]
       jmp       short M01_L08
M01_L07:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L04
       jmp       short M01_L03
M01_L08:
       inc       r13d
       cmp       edi,r13d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L13
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
       mov       rax,1BB2FA70008
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
M01_L11:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L12
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L12:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L13:
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
       mov       rcx,17A9DC04C80
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L14
       mov       r14,[rbp-48]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L18
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L15
M01_L14:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-48]
       je        short M01_L18
M01_L15:
       cmp       qword ptr [r15+20],0
       jne       short M01_L16
       lea       rcx,[r15+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L18
M01_L16:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L17
       mov       rcx,[r15+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L18
M01_L17:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L18:
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
; Total bytes of code 630
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFE712854E8]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       test      rsi,rsi
       je        near ptr M01_L10
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,1C7AB804C80
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
       mov       rdx,[rsi+r8*8+10]
       test      bl,bl
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L06:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C9C330]
       jmp       short M01_L08
M01_L07:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L04
       jmp       short M01_L03
M01_L08:
       inc       r13d
       cmp       edi,r13d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L13
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
       mov       rax,2083D6B0008
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
M01_L11:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710C4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L12
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L12:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L13:
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
       mov       rcx,1C7AB804C80
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L14
       mov       r14,[rbp-48]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L18
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE70C9C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L15
M01_L14:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-48]
       je        short M01_L18
M01_L15:
       cmp       qword ptr [r15+20],0
       jne       short M01_L16
       lea       rcx,[r15+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L18
M01_L16:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L17
       mov       rcx,[r15+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710C4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L18
M01_L17:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L18:
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
; Total bytes of code 630
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFE712771C8]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       test      rsi,rsi
       je        near ptr M01_L10
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,1A2FE404C80
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M01_L11
       lea       rcx,[r14+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       jne       near ptr M01_L11
M01_L00:
       mov       r15,[rbp-38]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-38],r8
       mov       [rbp-40],r15
       xor       r13d,r13d
       test      edi,edi
       jle       short M01_L06
M01_L02:
       mov       r8d,r13d
       mov       rdx,[rsi+r8*8+10]
       test      bl,bl
       jne       near ptr M01_L08
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
       ja        short M01_L07
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M01_L04
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       inc       r13d
       cmp       edi,r13d
       jg        short M01_L02
M01_L06:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M01_L09
M01_L07:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L05
M01_L08:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C8C330]
       jmp       short M01_L05
M01_L09:
       mov       rcx,rsp
       call      M01_L13
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
       mov       rax,1E390220008
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
       mov       rcx,[r14+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L12
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L12:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L13:
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
       mov       rcx,1A2FE404C80
       mov       r14,[rcx]
       mov       r15,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L14
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L18
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L15
M01_L14:
       mov       rdx,[rbp-40]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       rbx,[rbp-40]
       je        short M01_L18
M01_L15:
       cmp       qword ptr [r14+20],0
       jne       short M01_L16
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L18
M01_L16:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L17
       mov       rcx,[r14+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L18
M01_L17:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L18:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 612
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFE712771C8]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       test      rsi,rsi
       je        near ptr M01_L10
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,195BE002C88
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M01_L11
       lea       rcx,[r14+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       jne       near ptr M01_L11
M01_L00:
       mov       r15,[rbp-38]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-38],r8
       mov       [rbp-40],r15
       xor       r13d,r13d
       test      edi,edi
       jle       short M01_L06
M01_L02:
       mov       r8d,r13d
       mov       rdx,[rsi+r8*8+10]
       test      bl,bl
       jne       near ptr M01_L08
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
       ja        short M01_L07
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M01_L04
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       inc       r13d
       cmp       edi,r13d
       jg        short M01_L02
M01_L06:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M01_L09
M01_L07:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L05
M01_L08:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C8C330]
       jmp       short M01_L05
M01_L09:
       mov       rcx,rsp
       call      M01_L13
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
       mov       rax,1D63FDD0008
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
       mov       rcx,[r14+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L12
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L12:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L13:
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
       mov       rcx,195BE002C88
       mov       r14,[rcx]
       mov       r15,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L14
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L18
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L15
M01_L14:
       mov       rdx,[rbp-40]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       rbx,[rbp-40]
       je        short M01_L18
M01_L15:
       cmp       qword ptr [r14+20],0
       jne       short M01_L16
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L18
M01_L16:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L17
       mov       rcx,[r14+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L18
M01_L17:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L18:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 612
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFE712671C8]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       test      rsi,rsi
       je        near ptr M01_L10
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,1D159404C80
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M01_L11
       lea       rcx,[r14+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       jne       near ptr M01_L11
M01_L00:
       mov       r15,[rbp-38]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-38],r8
       mov       [rbp-40],r15
       xor       r13d,r13d
       test      edi,edi
       jle       short M01_L06
M01_L02:
       mov       r8d,r13d
       mov       rdx,[rsi+r8*8+10]
       test      bl,bl
       jne       near ptr M01_L08
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
       ja        short M01_L07
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M01_L04
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       inc       r13d
       cmp       edi,r13d
       jg        short M01_L02
M01_L06:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M01_L09
M01_L07:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L05
M01_L08:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C7C330]
       jmp       short M01_L05
M01_L09:
       mov       rcx,rsp
       call      M01_L13
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
       mov       rax,211EB3B0008
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
       mov       rcx,[r14+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710A4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L12
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L12:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L13:
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
       mov       rcx,1D159404C80
       mov       r14,[rcx]
       mov       r15,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L14
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L18
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE70C7C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L15
M01_L14:
       mov       rdx,[rbp-40]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       rbx,[rbp-40]
       je        short M01_L18
M01_L15:
       cmp       qword ptr [r14+20],0
       jne       short M01_L16
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L18
M01_L16:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L17
       mov       rcx,[r14+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE710A4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L18
M01_L17:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L18:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 612
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFE712771C8]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       test      rsi,rsi
       je        near ptr M01_L10
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M01_L10
       mov       rcx,281E1C04C80
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
       mov       rdx,[rsi+r8*8+10]
       test      bl,bl
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L06:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C8C330]
       jmp       short M01_L08
M01_L07:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       je        short M01_L04
       jmp       short M01_L03
M01_L08:
       inc       r13d
       cmp       edi,r13d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L13
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
       mov       rax,2C273A50008
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
M01_L11:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L12
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L12:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L13:
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
       mov       rcx,281E1C04C80
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L14
       mov       r14,[rbp-48]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L18
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L15
M01_L14:
       mov       rdx,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-48]
       je        short M01_L18
M01_L15:
       cmp       qword ptr [r15+20],0
       jne       short M01_L16
       lea       rcx,[r15+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L18
M01_L16:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L17
       mov       rcx,[r15+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L18
M01_L17:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L18:
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
; Total bytes of code 630
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+198]
       xor       ecx,ecx
       call      qword ptr [7FFE7138D7D0]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
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
       test      rsi,rsi
       je        near ptr M01_L15
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M01_L15
       mov       rcx,1E57B004C80
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L10
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L10
M01_L00:
       mov       r15,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],r15
       xor       r14d,r14d
       test      edi,edi
       jle       near ptr M01_L09
M01_L02:
       mov       ecx,r14d
       mov       rdx,[rsi+rcx*8+10]
       test      bl,bl
       jne       short M01_L07
       cmp       [r15],r15b
       test      rdx,rdx
       je        short M01_L08
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L08
       mov       rcx,[r15+8]
       mov       edx,[r15+18]
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
       mov       [r15+18],r13d
       jmp       short M01_L08
M01_L04:
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       short M01_L03
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L06:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L08
M01_L07:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CAC330]
M01_L08:
       inc       r14d
       cmp       edi,r14d
       jg        near ptr M01_L02
M01_L09:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L17
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
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-40]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M01_L12
       cmp       qword ptr [r13+10],0
       jne       short M01_L11
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L13
M01_L11:
       lea       rdx,[rbp-40]
       mov       rcx,r15
       call      qword ptr [7FFE710D4DB0]
       test      eax,eax
       je        short M01_L13
M01_L12:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L13:
       mov       r14,[r14+8]
       mov       rcx,7FFE710D1338
       cmp       [r14+18],rcx
       jne       short M01_L16
       mov       r14,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFE70CAC0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
M01_L14:
       jmp       near ptr M01_L01
M01_L15:
       mov       rax,2260CCD0008
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
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       short M01_L14
M01_L17:
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
       mov       rcx,1E57B004C80
       mov       r15,[rcx]
       mov       r12,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M01_L18
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L22
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L19
M01_L18:
       mov       rdx,[rbp-48]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       test      eax,eax
       mov       rbx,[rbp-48]
       je        short M01_L22
M01_L19:
       cmp       qword ptr [r15+20],0
       jne       short M01_L20
       lea       rcx,[r15+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L22
M01_L20:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L21
       mov       r13,[r15+18]
       mov       rcx,[r13+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE710D52C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L22
       mov       rcx,r13
       mov       rdx,rbx
       call      qword ptr [7FFE710D4D80]
       jmp       short M01_L22
M01_L21:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L22:
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
; Total bytes of code 756
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
       call      qword ptr [7FFE71295488]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFE70A741F8]
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,1EAC6804C80
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
       mov       r8,[r14+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M02_L10
M02_L02:
       mov       r8,[r14+198]
       cmp       r15d,[r8+8]
       jae       short M02_L05
       mov       ecx,r15d
       mov       r8,[r8+rcx*8+10]
       cmp       [rdi],dil
       test      r8,r8
       je        short M02_L04
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        short M02_L04
       mov       r8,[rdi+8]
       mov       r12d,[rdi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M02_L07
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M02_L08
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       add       r13d,r12d
       mov       [rdi+18],r13d
M02_L04:
       inc       r15d
       mov       rcx,[r14+198]
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
       mov       r8d,r13d
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L04
M02_L08:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       je        short M02_L06
       jmp       short M02_L03
M02_L09:
       mov       rdx,rdi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
M02_L10:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
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
       mov       rax,22B588C0008
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
       call      qword ptr [7FFE710D4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,1EAC6804C80
       mov       rdi,[rcx]
       mov       r13,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r13+18],rcx
       jne       short M02_L15
       mov       rbx,[rbp-48]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r13+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L19
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L16
M02_L15:
       mov       rdx,[rbp-48]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
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
       call      qword ptr [7FFE710D4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      qword ptr [7FFE71275530]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFE70A541F8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,24B27402C88
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
       mov       r8,[r14+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M02_L10
M02_L02:
       mov       r8,[r14+198]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       [rdi+18],r13d
M02_L04:
       inc       r15d
       mov       rcx,[r14+198]
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       mov       rax,28BB90B0008
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
       call      qword ptr [7FFE710B4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,24B27402C88
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
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      qword ptr [7FFE71267210]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFE70A441F8]
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,2056BC04C80
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
       mov       r8,[r14+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M02_L10
M02_L02:
       mov       r8,[r14+198]
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L08
M02_L07:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M02_L05
       jmp       short M02_L03
M02_L08:
       inc       r15d
       mov       rcx,[r14+198]
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
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
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
       mov       rax,245FD920008
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
       call      qword ptr [7FFE710A4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,2056BC04C80
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
       call      qword ptr [7FFE70C7C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710A4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      qword ptr [7FFE71287210]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFE70A641F8]
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,1CF11804C80
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
       mov       r8,[rsi+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M02_L09
M02_L02:
       mov       r8,[rsi+198]
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L07:
       inc       ebx
       mov       rcx,[rsi+198]
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
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
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
       mov       rax,20FA3690008
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
       call      qword ptr [7FFE710C4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,1CF11804C80
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
       call      qword ptr [7FFE70C9C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710C4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFE71267210]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFE70A441F8]
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,1C11EC04C80
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
       mov       r8,[rsi+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M02_L09
M02_L02:
       mov       r8,[rsi+198]
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
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L07:
       inc       ebx
       mov       rcx,[rsi+198]
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
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
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
       mov       rax,201B0CB0008
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
       call      qword ptr [7FFE710A4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,1C11EC04C80
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
       call      qword ptr [7FFE70C7C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710A4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__10_0(System.Text.StringBuilder)
       mov       [rsi+18],rcx
       mov       rcx,rsi
       call      qword ptr [7FFE712772D0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFE70A541F8]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,2271A804C80
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
       mov       r8,[r14+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M02_L10
M02_L02:
       mov       r8,[r14+198]
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
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L08
M02_L07:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M02_L05
       jmp       short M02_L03
M02_L08:
       inc       r15d
       mov       rcx,[r14+198]
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
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
       mov       rax,267AC560008
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
       call      qword ptr [7FFE710B4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,2271A804C80
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
       call      qword ptr [7FFE70C8C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      qword ptr [7FFE71297210]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFE70A741F8]
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,1656A004C80
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
       mov       r8,[r14+198]
       cmp       dword ptr [r8+8],0
       jle       near ptr M02_L10
M02_L02:
       mov       r8,[r14+198]
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
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       [rdi+18],r13d
M02_L04:
       inc       r15d
       mov       rcx,[r14+198]
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
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
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
       mov       rax,1A5FBF80008
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
       call      qword ptr [7FFE710D4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,1656A004C80
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
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710D4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      qword ptr [7FFE7137D3E0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
       call      qword ptr [7FFE70A641F8]
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,20050404C80
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
       mov       rcx,[rsi+198]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M02_L10
M02_L02:
       mov       rcx,[rsi+198]
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
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L03
M02_L07:
       mov       rcx,rdi
       call      qword ptr [7FFE70C9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L08:
       inc       r14d
       mov       rcx,[rsi+198]
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
       call      qword ptr [7FFE70CA8140]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFE710C4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L12
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M02_L00
M02_L12:
       mov       rsi,[rsi+8]
       mov       rcx,7FFE710C1338
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
       call      qword ptr [7FFE70C9C0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
       jmp       short M02_L13
M02_L15:
       mov       rax,240E22A0008
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
       mov       rcx,20050404C80
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
       call      qword ptr [7FFE70C9C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE710C52C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M02_L21
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE710C4D80]
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

