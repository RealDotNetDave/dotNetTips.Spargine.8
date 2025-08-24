## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacterMinMax()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edx,0FFFF
       xor       ecx,ecx
       call      qword ptr [7FFE242F6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M00_L00
       mov       rcx,[rbx+18]
       mov       [rcx+48],ax
       add       rsp,20
       pop       rbx
       ret
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 48
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243335A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE242F7408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE247360E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EAF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileNameWithPath()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+128]
       mov       edi,0A
       mov       rcx,2A1394B5AC0
       cmp       [rcx],ecx
       call      qword ptr [7FFE23EC7318]; System.String.Trim()
       mov       rbp,rax
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FFE240C5CF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,edi
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFE242E7B10]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       cmp       byte ptr [rsp+44],0
       jne       near ptr M00_L02
       test      rdx,rdx
       je        near ptr M00_L02
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M00_L03
       mov       rcx,[rsp+48]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+50]
       sub       eax,r8d
       mov       edi,[rdx+8]
       cmp       edi,eax
       ja        near ptr M00_L02
       add       rdx,0C
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE23F75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       edi,[rsp+40]
       mov       [rsp+40],edi
M00_L00:
       lea       rcx,[rsp+30]
       mov       edx,2E
       call      qword ptr [7FFE246DE868]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+44],0
       jne       near ptr M00_L04
       test      rbp,rbp
       je        near ptr M00_L04
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M00_L03
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       mov       edi,[rbp+8]
       cmp       edi,edx
       ja        short M00_L04
       lea       rdx,[rbp+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE23F75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       edi,[rsp+40]
       mov       [rsp+40],edi
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE240C5D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE241C72E8]; System.IO.Path.Combine(System.String, System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE240C5E90]
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FFE241757E8]
       int       3
M00_L04:
       lea       rcx,[rsp+30]
       mov       rdx,rbp
       call      qword ptr [7FFE240C5E90]
       jmp       short M00_L01
; Total bytes of code 405
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE24775C98]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE24775C98]
       test      eax,eax
       jne       short M01_L04
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE23EC73F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       ecx,ecx
       mov       [rbx],rcx
       mov       rcx,260A7401DE8
       mov       rcx,[rcx]
       imul      eax,r8d,0B
       add       edx,eax
       mov       eax,100
       cmp       edx,100
       cmovle    edx,eax
       call      qword ptr [7FFE24192BB8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       test      rsi,rsi
       je        short M02_L01
       lea       rax,[rsi+10]
       mov       ecx,[rsi+8]
M02_L00:
       mov       [rbx+18],rax
       mov       [rbx+20],ecx
       xor       eax,eax
       mov       [rbx+10],eax
       mov       byte ptr [rbx+14],0
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L01:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M02_L00
; Total bytes of code 109
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M03_L17
M03_L00:
       test      eax,eax
       je        near ptr M03_L18
M03_L01:
       mov       rcx,260A7404E00
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M03_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M03_L20
M03_L02:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r15,r15
       je        near ptr M03_L22
M03_L03:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE2403D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFE2403D050]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M03_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M03_L10
M03_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        short M03_L08
M03_L05:
       mov       ecx,r12d
       call      qword ptr [7FFE243262F8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M03_L10
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M03_L09
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M03_L06:
       add       r13d,1
       jo        short M03_L10
       cmp       r13d,ebx
       jl        short M03_L04
M03_L07:
       mov       rcx,r15
       call      qword ptr [7FFE240532D8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M03_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M03_L12
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L13
M03_L08:
       mov       edx,eax
       jmp       short M03_L05
M03_L09:
       mov       rcx,r15
       call      qword ptr [7FFE2403D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M03_L06
M03_L10:
       call      CORINFO_HELP_OVERFLOW
M03_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE23EC73F0]
       jmp       short M03_L16
M03_L12:
       call      qword ptr [7FFE24775C98]
       test      eax,eax
       jne       short M03_L11
M03_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L14
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L15
M03_L14:
       call      qword ptr [7FFE24775C98]
       test      eax,eax
       jne       short M03_L11
M03_L15:
       mov       rax,r14
M03_L16:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M03_L23
       nop
       mov       rax,[rbp-58]
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
M03_L17:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F747B0]
       mov       ebx,eax
       jmp       near ptr M03_L01
M03_L18:
       call      qword ptr [7FFE243278E8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M03_L19
       call      qword ptr [7FFE24327708]
       mov       rsi,rax
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2A1394A9BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F7D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE24615638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M03_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M03_L02
M03_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r15,r15
       jne       near ptr M03_L03
M03_L22:
       call      qword ptr [7FFE24327900]
       mov       ecx,9E8
       mov       rdx,7FFE242F0BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24196EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EC6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242F0BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EC6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE243276F0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE23FF6718]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M03_L23:
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
       mov       rcx,260A7404E00
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M03_L24
       mov       r14,[rbp-50]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M03_L28
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE2403D0F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M03_L25
M03_L24:
       mov       rdx,[rbp-50]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r14,[rbp-50]
       je        short M03_L28
M03_L25:
       cmp       qword ptr [rsi+20],0
       jne       short M03_L26
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M03_L28
M03_L26:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M03_L27
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE24615608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M03_L28
M03_L27:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M03_L28:
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
; Total bytes of code 985
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M04_L02
       test      r8b,18
       jne       short M04_L01
       test      r8b,4
       je        short M04_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L05
M04_L00:
       test      r8,r8
       je        short M04_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L05
M04_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M04_L05
M04_L02:
       cmp       r8,40
       ja        short M04_L06
M04_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L10
M04_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M04_L05:
       ret
M04_L06:
       cmp       r8,800
       ja        short M04_L09
       mov       r9,r8
       shr       r9,6
M04_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L07
       and       r8,3F
       cmp       r8,10
       ja        short M04_L03
       jmp       short M04_L04
M04_L08:
       cmp       rcx,rdx
       je        short M04_L05
M04_L09:
       jmp       qword ptr [7FFE23F75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L04
; Total bytes of code 248
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       cmp       byte ptr [rbx+14],0
       jne       short M05_L03
M05_L00:
       movzx     ecx,si
       lea       rax,[rbx+18]
       mov       edx,[rbx+10]
       mov       r8d,[rax+8]
       cmp       edx,r8d
       ja        short M05_L02
       mov       rax,[rax]
       mov       r10d,edx
       lea       rax,[rax+r10*2]
       sub       r8d,edx
       je        short M05_L01
       mov       [rax],cx
       mov       ecx,1
       add       [rbx+10],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       mov       rcx,rbx
       call      qword ptr [7FFE240C5F80]
       jmp       short M05_L00
M05_L02:
       call      qword ptr [7FFE241757E8]
       int       3
M05_L03:
       movzx     edx,si
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE24775F98]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 110
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       lea       rcx,[rbx+18]
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        short M06_L01
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       [rsp+30],eax
       lea       rcx,[rsp+28]
       call      00007FFE23EC2520
       mov       rsi,rax
       mov       rdx,[rbx+8]
       xor       ecx,ecx
       mov       [rbx],rcx
       mov       [rbx+8],rcx
       mov       [rbx+10],rcx
       mov       [rbx+18],rcx
       mov       [rbx+20],rcx
       test      rdx,rdx
       je        short M06_L00
       mov       rcx,260A7401DE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE24192BC0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M06_L00:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M06_L01:
       call      qword ptr [7FFE241757E8]
       int       3
; Total bytes of code 122
```
```assembly
; System.IO.Path.Combine(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M07_L00
       test      rdx,rdx
       je        short M07_L01
       add       rsp,28
       jmp       qword ptr [7FFE241C7420]; System.IO.Path.CombineInternal(System.String, System.String)
M07_L00:
       mov       ecx,1B5FB
       mov       rdx,7FFE23D74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE23FF6790]
       int       3
M07_L01:
       mov       ecx,1B607
       mov       rdx,7FFE23D74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE23FF6790]
       int       3
; Total bytes of code 84
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWordMinMaxChar()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       xor       edx,edx
       mov       r8d,0FFFF
       call      qword ptr [7FFE242EC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L17
M01_L00:
       test      eax,eax
       je        near ptr M01_L18
M01_L01:
       mov       rcx,1685A004E00
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L20
M01_L02:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r15,r15
       je        near ptr M01_L22
M01_L03:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE240FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFE240FC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M01_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M01_L10
M01_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        short M01_L08
M01_L05:
       mov       ecx,r12d
       call      qword ptr [7FFE24316988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M01_L10
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M01_L09
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M01_L06:
       add       r13d,1
       jo        short M01_L10
       cmp       r13d,ebx
       jl        short M01_L04
M01_L07:
       mov       rcx,r15
       call      qword ptr [7FFE24109518]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L14
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L11
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L15
       jmp       short M01_L12
M01_L08:
       mov       edx,eax
       jmp       short M01_L05
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFE240FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      qword ptr [7FFE247545D0]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L15
M01_L12:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L13
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L15
       jmp       short M01_L14
M01_L13:
       call      qword ptr [7FFE247545D0]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L15
M01_L14:
       mov       rax,rsi
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE23EC73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M01_L16:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M01_L23
       nop
       mov       rax,[rbp-58]
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
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F747B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L18:
       call      qword ptr [7FFE2431C318]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L19
       call      qword ptr [7FFE2431C138]
       mov       rsi,rax
M01_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,1A8EC009BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F7D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE24615638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L02
M01_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r15,r15
       jne       near ptr M01_L03
M01_L22:
       call      qword ptr [7FFE2431C330]
       mov       ecx,9E8
       mov       rdx,7FFE242F0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24186310
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EC6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242F0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EC6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE2431C120]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE24086670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
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
       mov       rcx,1685A004E00
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M01_L24
       mov       r15,[rbp-50]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L28
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE240FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L25
M01_L24:
       mov       r15,[rbp-50]
       mov       rdx,r15
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M01_L28
M01_L25:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L26
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L28
M01_L26:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L27
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE24615608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L28
M01_L27:
       add       rsi,2C
       lock dec  dword ptr [rsi]
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
; Total bytes of code 980
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWordMinMaxLengthChar()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       esi,0A
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       ecx,64
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        short M00_L03
M00_L00:
       test      eax,eax
       je        short M00_L04
M00_L01:
       mov       edx,esi
       add       edx,1
       jo        short M00_L02
       cmp       ecx,edx
       cmovge    edx,ecx
       mov       ecx,esi
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       xor       edx,edx
       mov       r8d,0FFFF
       call      qword ptr [7FFE242DC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       call      CORINFO_HELP_OVERFLOW
M00_L03:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE23F647B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFE2430C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFE2430C138]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1ADC3051080
       mov       r8,rbx
       call      qword ptr [7FFE23F6D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 245
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243435A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE24307408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE24746910]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EBF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L17
M02_L00:
       test      eax,eax
       je        near ptr M02_L18
M02_L01:
       mov       rcx,16D31004E00
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M02_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M02_L20
M02_L02:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r15,r15
       je        near ptr M02_L22
M02_L03:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE240EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFE240EC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M02_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M02_L10
M02_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        short M02_L08
M02_L05:
       mov       ecx,r12d
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M02_L10
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M02_L09
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M02_L06:
       add       r13d,1
       jo        short M02_L10
       cmp       r13d,ebx
       jl        short M02_L04
M02_L07:
       mov       rcx,r15
       call      qword ptr [7FFE240F9518]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L14
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M02_L11
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L15
       jmp       short M02_L12
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFE240EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       call      qword ptr [7FFE24744660]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M02_L15
M02_L12:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L13
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L15
       jmp       short M02_L14
M02_L13:
       call      qword ptr [7FFE24744660]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M02_L15
M02_L14:
       mov       rax,rsi
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE23EB73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M02_L16:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M02_L23
       nop
       mov       rax,[rbp-58]
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
M02_L17:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F647B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFE2430C318]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFE2430C138]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,1ADC3049BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F6D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE24605BC0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M02_L02
M02_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r15,r15
       jne       near ptr M02_L03
M02_L22:
       call      qword ptr [7FFE2430C330]
       mov       ecx,9E8
       mov       rdx,7FFE242E0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24176308
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242E0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE2430C120]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE24076670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M02_L23:
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
       mov       rcx,16D31004E00
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M02_L24
       mov       r15,[rbp-50]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L28
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE240EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L25
M02_L24:
       mov       r15,[rbp-50]
       mov       rdx,r15
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M02_L28
M02_L25:
       cmp       qword ptr [rsi+20],0
       jne       short M02_L26
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L28
M02_L26:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M02_L27
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE24605B90]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L28
M02_L27:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M02_L28:
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
; Total bytes of code 982
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWordMinMaxLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       mov       esi,0A
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       mov       edi,64
       mov       ecx,1
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L07
M00_L00:
       test      eax,eax
       je        near ptr M00_L08
M00_L01:
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       r8d,ecx
       test      ecx,ecx
       je        near ptr M00_L10
M00_L02:
       test      r8d,r8d
       je        near ptr M00_L11
M00_L03:
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      edi,edi
       setg      cl
       mov       r10d,ecx
       test      ecx,ecx
       je        near ptr M00_L13
M00_L04:
       test      r10d,r10d
       je        near ptr M00_L14
M00_L05:
       mov       edx,esi
       add       edx,1
       jo        short M00_L06
       cmp       edi,edx
       cmovge    edx,edi
       mov       ecx,esi
       call      qword ptr [7FFE242E6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242BC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L06:
       call      CORINFO_HELP_OVERFLOW
M00_L07:
       movzx     ecx,byte ptr [rsp+38]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE23F447B0]
       mov       edi,eax
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FFE242EC318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L09
       call      qword ptr [7FFE242EC138]
       mov       rbx,rax
M00_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22277D91080
       mov       r8,rbx
       call      qword ptr [7FFE23F4D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L10:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L02
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE23F447B0]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFE242EC318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FFE242EC138]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22277D91058
       mov       r8,rbx
       call      qword ptr [7FFE23F4D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L13:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L04
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE23F447B0]
       mov       edi,eax
       jmp       near ptr M00_L05
M00_L14:
       call      qword ptr [7FFE242EC318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L15
       call      qword ptr [7FFE242EC138]
       mov       rbx,rax
M00_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22277D91080
       mov       r8,rbx
       call      qword ptr [7FFE23F4D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 554
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243235A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE242E7408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE247264A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23E9F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L17
M02_L00:
       test      eax,eax
       je        near ptr M02_L18
M02_L01:
       mov       rcx,1E1E5C04E00
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M02_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M02_L20
M02_L02:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r15,r15
       je        near ptr M02_L22
M02_L03:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE240CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFE240CC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M02_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M02_L10
M02_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        short M02_L08
M02_L05:
       mov       ecx,r12d
       call      qword ptr [7FFE242E6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M02_L10
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M02_L09
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M02_L06:
       add       r13d,1
       jo        short M02_L10
       cmp       r13d,ebx
       jl        short M02_L04
M02_L07:
       mov       rcx,r15
       call      qword ptr [7FFE240D9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFE240CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE23E973F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFE24745F38]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFE24745F38]
       test      eax,eax
       jne       short M02_L11
M02_L15:
       mov       rax,r14
M02_L16:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M02_L23
       nop
       mov       rax,[rbp-58]
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
M02_L17:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F447B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFE242EC318]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFE242EC138]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,22277D89BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F4D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE245E5638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M02_L02
M02_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r15,r15
       jne       near ptr M02_L03
M02_L22:
       call      qword ptr [7FFE242EC330]
       mov       ecx,9E8
       mov       rdx,7FFE242C0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24156308
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23E96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242C0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23E96B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE242EC120]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE24056670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M02_L23:
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
       mov       rcx,1E1E5C04E00
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M02_L24
       mov       r14,[rbp-50]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L28
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE240CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L25
M02_L24:
       mov       rdx,[rbp-50]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r14,[rbp-50]
       je        short M02_L28
M02_L25:
       cmp       qword ptr [rsi+20],0
       jne       short M02_L26
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L28
M02_L26:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M02_L27
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE245E5608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L28
M02_L27:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M02_L28:
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
; Total bytes of code 987
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateByteArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       vzeroupper
       vmovaps   [rsp+50],xmm6
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,1F72C800428
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE24386418]; DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rdi+8],1
       mov       [rsp+48],rdi
       lea       rcx,[rsp+48]
       vmovsd    xmm6,qword ptr [7FFE2465E280]
       mov       [rsp+30],rcx
       mov       dword ptr [rsp+38],1
       mov       rcx,rsi
       lea       r8,[rsp+30]
       call      qword ptr [7FFE23EB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       vmulsd    xmm0,xmm6,qword ptr [7FFE2465E288]
       vroundsd  xmm0,xmm0,xmm0,4
       vmovups   xmm1,[7FFE2465E290]
       vmaxsd    xmm0,xmm1,xmm0
       call      CORINFO_HELP_DBL2INT_OVF
       cmp       eax,800
       jl        short M00_L03
       mov       edx,eax
       mov       rcx,offset MT_System.Byte[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rsi,rax
M00_L00:
       test      rsi,rsi
       jne       short M00_L01
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M00_L02
M00_L01:
       lea       rcx,[rsi+10]
       mov       eax,[rsi+8]
M00_L02:
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE2433E6A0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       mov       [rsp+40],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+40]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       vmovaps   xmm6,[rsp+50]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L00
; Total bytes of code 302
```
```assembly
; DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
;                 return ResourceManager.GetString("SizeMustBeEpsilon", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFE24386250]; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,1F734802E18
       mov       r8,[r8]
       mov       rdx,237BE795B38
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,0ADB18DFDF752
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rsi,rsi
       je        near ptr M02_L03
       test      [rsp],esp
       sub       rsp,200
       lea       rdx,[rsp+20]
       xor       ecx,ecx
       mov       [rbp+8],rcx
       mov       [rbp+18],rdx
       mov       dword ptr [rbp+20],100
       mov       [rbp+10],ecx
       mov       edx,[rsi+8]
       mov       ecx,[rbx+8]
       lea       edx,[rdx+rcx*8]
       cmp       edx,[rbp+20]
       ja        short M02_L02
M02_L00:
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [7FFE240F70D8]; System.Text.ValueStringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       lea       rcx,[rbp+8]
       call      qword ptr [7FFE240F71E0]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0ADB18DFDF752
       cmp       [rbp],rcx
       je        short M02_L01
       call      CORINFO_HELP_FAIL_FAST
M02_L01:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L02:
       sub       edx,[rbp+10]
       lea       rcx,[rbp+8]
       call      qword ptr [7FFE240F7318]
       jmp       short M02_L00
M02_L03:
       mov       ecx,2F1
       mov       rdx,7FFE23D64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE240766E8]
       int       3
; Total bytes of code 218
```
```assembly
; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       rbx,rcx
       lea       rcx,[rbp-80]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-60],rdx
       mov       rdx,rbp
       mov       [rbp-50],rdx
       mov       rdx,[rbx]
       mov       r8d,[rbx+8]
       test      r8d,r8d
       jle       short M03_L02
       mov       [rbp-40],rdx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE24372330
       mov       [rbp-70],rax
       lea       rax,[M03_L00]
       mov       [rbp-58],rax
       lea       rax,[rbp-80]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M03_L00:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M03_L01
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M03_L01:
       mov       rcx,[rbp-78]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       short M03_L03
       xor       eax,eax
       mov       [rbp-40],rax
M03_L02:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       ecx,eax
       call      qword ptr [7FFE2433EC88]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 206
```
**Extern method**
System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edx,7A
       mov       ecx,61
       call      qword ptr [7FFE24316988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M00_L00
       mov       rcx,[rbx+18]
       mov       [rcx+48],ax
       add       rsp,20
       pop       rbx
       ret
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 51
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243535A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE24317408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE24756418]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23ECF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCoordinate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       edi,eax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       [rsp+20],esi
       mov       [rsp+24],edi
       mov       [rsp+28],eax
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE247444F8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 100
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243435A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE24307408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE24746448]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EBF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDecimal()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C0
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B8],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+0B8],1
       xor       eax,eax
       mov       [rsp+0BC],eax
       mov       eax,2
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2sd xmm1,xmm1,eax
       vmovsd    xmm0,qword ptr [7FFE246432E0]
       call      00007FFE83A14FC0
       vxorps    xmm1,xmm1,xmm1
       vmovups   [rsp+0A8],xmm1
       lea       rdx,[rsp+0A8]
       call      qword ptr [7FFE24744810]; System.Decimal+DecCalc.VarDecFromR8(Double, DecCalc ByRef)
       mov       esi,[rsp+0A8]
       mov       edi,[rsp+0AC]
       mov       rbp,[rsp+0B0]
       xor       ecx,ecx
       mov       [rsp+98],ecx
       mov       [rsp+9C],ecx
       mov       [rsp+0A0],rcx
       mov       [rsp+88],esi
       mov       [rsp+8C],edi
       mov       [rsp+90],rbp
       lea       rcx,[rsp+98]
       lea       rdx,[rsp+88]
       call      qword ptr [7FFE247447E0]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+98]
       vmovups   [rsp+28],xmm0
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE23FD4738]; System.Decimal.ToInt32(System.Decimal)
       mov       r14d,eax
       xor       ecx,ecx
       mov       [rsp+78],ecx
       mov       [rsp+7C],ecx
       mov       qword ptr [rsp+80],3E8
       mov       [rsp+68],esi
       mov       [rsp+6C],edi
       mov       [rsp+70],rbp
       lea       rcx,[rsp+78]
       lea       rdx,[rsp+68]
       call      qword ptr [7FFE247447E0]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+78]
       vmovups   [rsp+28],xmm0
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE23FD4738]; System.Decimal.ToInt32(System.Decimal)
       mov       edx,r14d
       add       edx,1
       jo        short M00_L01
       cmp       eax,edx
       cmovge    edx,eax
       mov       ecx,r14d
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       test      eax,eax
       jl        short M00_L02
       xor       r14d,r14d
M00_L00:
       mov       ecx,eax
       mov       [rsp+58],r14d
       xor       edx,edx
       mov       [rsp+5C],edx
       mov       [rsp+60],rcx
       mov       [rsp+48],esi
       mov       [rsp+4C],edi
       mov       [rsp+50],rbp
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+48]
       call      qword ptr [7FFE24744870]; System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+58]
       vmovups   [rsp+38],xmm0
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE24744A08]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       nop
       add       rsp,0C0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       mov       r14d,80000000
       neg       eax
       jmp       short M00_L00
; Total bytes of code 427
```
```assembly
; System.Decimal+DecCalc.VarDecFromR8(Double, DecCalc ByRef)
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rdx
       vxorps    xmm1,xmm1,xmm1
       vmovdqu   xmmword ptr [rbx],xmm1
       vmovq     r8,xmm0
       shr       r8,34
       and       r8d,7FF
       add       r8d,0FFFFFC02
       cmp       r8d,0FFFFFFA2
       jl        near ptr M01_L12
       cmp       r8d,60
       jg        near ptr M01_L13
       xor       esi,esi
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm1,xmm0
       ja        near ptr M01_L14
M01_L00:
       imul      eax,r8d,4D10
       sar       eax,10
       mov       ecx,eax
       neg       ecx
       add       ecx,0E
       js        near ptr M01_L15
       mov       eax,1C
       cmp       ecx,1C
       cmovg     ecx,eax
       cmp       ecx,51
       jae       near ptr M01_L20
       mov       eax,ecx
       mov       rdx,7FFE30C99F08
       vmulsd    xmm0,xmm0,qword ptr [rdx+rax*8]
M01_L01:
       vmovsd    xmm1,qword ptr [7FFE246438B0]
       vucomisd  xmm1,xmm0
       ja        near ptr M01_L18
M01_L02:
       vroundsd  xmm0,xmm0,xmm0,4
       vcvttsd2si r10,xmm0
       test      r10,r10
       je        near ptr M01_L19
       test      ecx,ecx
       jl        near ptr M01_L08
       mov       r8d,ecx
       mov       eax,0E
       cmp       r8d,0E
       cmovg     r8d,eax
       test      r10b,r10b
       jne       short M01_L03
       cmp       r8d,8
       jl        short M01_L03
       mov       rdx,0ABCC77118461CEFD
       mov       rax,r10
       mul       rdx
       shr       rdx,1A
       imul      eax,edx,5F5E100
       cmp       r10d,eax
       jne       short M01_L03
       mov       r10,rdx
       add       ecx,0FFFFFFF8
       add       r8d,0FFFFFFF8
M01_L03:
       test      r10b,0F
       jne       short M01_L04
       cmp       r8d,4
       jl        short M01_L04
       mov       rdx,346DC5D63886594B
       mov       rax,r10
       mul       rdx
       shr       rdx,0B
       imul      eax,edx,2710
       cmp       r10d,eax
       jne       short M01_L04
       mov       r10,rdx
       add       ecx,0FFFFFFFC
       add       r8d,0FFFFFFFC
M01_L04:
       test      r10b,3
       jne       short M01_L05
       cmp       r8d,2
       jge       near ptr M01_L10
M01_L05:
       test      r10b,1
       jne       short M01_L06
       test      r8d,r8d
       jg        near ptr M01_L11
M01_L06:
       shl       ecx,10
       or        esi,ecx
       mov       [rbx+8],r10
M01_L07:
       mov       [rbx],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L08:
       neg       ecx
       cmp       ecx,0A
       jge       short M01_L09
       cmp       ecx,0A
       jae       near ptr M01_L20
       mov       rax,7FFE30C9E1A8
       mov       eax,[rax+rcx*4]
       mov       edx,r10d
       imul      rdx,rax
       shr       r10,20
       mov       ecx,r10d
       imul      rax,rcx
       mov       [rbx+8],edx
       shr       rdx,20
       add       rax,rdx
       mov       [rbx+0C],eax
       shr       rax,20
       mov       [rbx+4],eax
       jmp       short M01_L07
M01_L09:
       lea       edx,[rcx-1]
       cmp       edx,13
       jae       near ptr M01_L20
       lea       edx,[rcx-1]
       mov       rcx,7FFE30CA5C88
       mov       rdx,[rcx+rdx*8]
       mov       rcx,r10
       mov       r8,rbx
       call      qword ptr [7FFE24744648]
       jmp       short M01_L07
M01_L10:
       mov       rdx,28F5C28F5C28F5C3
       mov       rax,r10
       shr       rax,2
       mul       rdx
       shr       rdx,2
       imul      eax,edx,64
       cmp       r10d,eax
       jne       near ptr M01_L05
       mov       r10,rdx
       add       ecx,0FFFFFFFE
       add       r8d,0FFFFFFFE
       jmp       near ptr M01_L05
M01_L11:
       mov       rdx,0CCCCCCCCCCCCCCCD
       mov       rax,r10
       mul       rdx
       shr       rdx,3
       lea       eax,[rdx+rdx*4]
       add       eax,eax
       cmp       r10d,eax
       jne       near ptr M01_L06
       mov       r10,rdx
       dec       ecx
       jmp       near ptr M01_L06
M01_L12:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L13:
       mov       ecx,0FB09
       mov       rdx,7FFE23D64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE243D4C18]
       mov       rcx,rax
       call      qword ptr [7FFE24024798]
       int       3
M01_L14:
       vxorps    xmm0,xmm0,[7FFE246438C0]
       mov       esi,80000000
       jmp       near ptr M01_L00
M01_L15:
       cmp       ecx,0FFFFFFFF
       jne       short M01_L16
       vucomisd  xmm0,qword ptr [7FFE246438D0]
       jb        short M01_L17
M01_L16:
       mov       edx,ecx
       neg       edx
       cmp       edx,51
       jae       short M01_L20
       mov       r8,7FFE30C99F08
       vdivsd    xmm0,xmm0,[r8+rdx*8]
       jmp       near ptr M01_L01
M01_L17:
       xor       ecx,ecx
       vmovsd    xmm1,qword ptr [7FFE246438B0]
       vucomisd  xmm1,xmm0
       jbe       near ptr M01_L02
M01_L18:
       cmp       ecx,1C
       jge       near ptr M01_L02
       vmulsd    xmm0,xmm0,qword ptr [7FFE246438D8]
       inc       ecx
       jmp       near ptr M01_L02
M01_L19:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 728
```
```assembly
; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       mov       eax,[rbx]
       add       eax,[rsi]
       shr       eax,10
       movzx     r8d,al
       mov       eax,[rbx+4]
       or        eax,[rbx+0C]
       jne       near ptr M02_L04
       mov       eax,[rsi+4]
       or        eax,[rsi+0C]
       jne       short M02_L01
       mov       ecx,[rbx+8]
       mov       r10d,[rsi+8]
       imul      rcx,r10
       cmp       r8d,1C
       jg        near ptr M02_L16
M02_L00:
       mov       [rbx+8],rcx
       mov       eax,[rsi]
       xor       eax,[rbx]
       and       eax,80000000
       shl       r8d,10
       or        eax,r8d
       mov       [rbx],eax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L01:
       mov       eax,[rbx+8]
       mov       ecx,[rsi+8]
       imul      rax,rcx
       mov       [rsp+20],eax
       mov       ecx,[rbx+8]
       mov       edx,[rsi+0C]
       imul      rcx,rdx
       shr       rax,20
       add       rax,rcx
       mov       [rsp+24],eax
       shr       rax,20
       cmp       dword ptr [rsi+4],0
       je        short M02_L03
       mov       ecx,[rbx+8]
       mov       edx,[rsi+4]
       imul      rcx,rdx
       add       rcx,rax
       mov       rax,rcx
       mov       ecx,0FFFFFFFF
       cmp       rax,rcx
       jbe       short M02_L03
M02_L02:
       mov       [rsp+28],rax
       mov       edx,3
       jmp       near ptr M02_L12
M02_L03:
       mov       [rsp+28],eax
       mov       edx,2
       jmp       near ptr M02_L09
M02_L04:
       mov       eax,[rsi+4]
       or        eax,[rsi+0C]
       jne       short M02_L05
       mov       eax,[rsi+8]
       mov       edx,[rbx+8]
       imul      rax,rdx
       mov       [rsp+20],eax
       mov       ecx,[rsi+8]
       mov       edx,[rbx+0C]
       imul      rcx,rdx
       shr       rax,20
       add       rax,rcx
       mov       [rsp+24],eax
       shr       rax,20
       cmp       dword ptr [rbx+4],0
       je        short M02_L03
       mov       ecx,[rsi+8]
       mov       edx,[rbx+4]
       imul      rcx,rdx
       add       rcx,rax
       mov       rax,rcx
       mov       ecx,0FFFFFFFF
       cmp       rax,rcx
       jbe       short M02_L03
       jmp       short M02_L02
M02_L05:
       mov       eax,[rbx+8]
       mov       ecx,[rsi+8]
       imul      rax,rcx
       mov       [rsp+20],eax
       mov       ecx,[rbx+8]
       mov       edx,[rsi+0C]
       imul      rcx,rdx
       shr       rax,20
       add       rax,rcx
       mov       ecx,[rbx+0C]
       mov       edx,[rsi+8]
       imul      rcx,rdx
       add       rcx,rax
       mov       [rsp+24],ecx
       cmp       rcx,rax
       jae       short M02_L06
       mov       rax,rcx
       shr       rax,20
       mov       rcx,100000000
       or        rax,rcx
       jmp       short M02_L07
M02_L06:
       mov       rax,rcx
       shr       rax,20
M02_L07:
       mov       ecx,[rbx+0C]
       mov       edx,[rsi+0C]
       imul      rdx,rcx
       lea       rcx,[rdx+rax]
       mov       eax,[rbx+4]
       or        eax,[rsi+4]
       je        near ptr M02_L08
       mov       eax,[rbx+8]
       mov       edx,[rsi+4]
       imul      rax,rdx
       add       rcx,rax
       xor       edx,edx
       mov       r10d,1
       cmp       rcx,rax
       cmovb     edx,r10d
       mov       eax,[rbx+4]
       mov       r10d,[rsi+8]
       imul      rax,r10
       add       rcx,rax
       mov       [rsp+28],ecx
       lea       r10d,[rdx+1]
       cmp       rcx,rax
       cmovb     edx,r10d
       mov       eax,edx
       shl       rax,20
       shr       rcx,20
       or        rax,rcx
       mov       ecx,[rbx+0C]
       mov       edx,[rsi+4]
       imul      rcx,rdx
       add       rcx,rax
       xor       edx,edx
       mov       r10d,1
       cmp       rcx,rax
       cmovb     edx,r10d
       mov       eax,[rbx+4]
       mov       r10d,[rsi+0C]
       imul      rax,r10
       add       rcx,rax
       mov       [rsp+2C],ecx
       lea       r10d,[rdx+1]
       cmp       rcx,rax
       cmovb     edx,r10d
       mov       eax,[rbx+4]
       mov       r10d,[rsi+4]
       imul      rax,r10
       shl       rdx,20
       shr       rcx,20
       or        rcx,rdx
       add       rcx,rax
       mov       [rsp+30],rcx
       mov       edx,5
       jmp       short M02_L09
M02_L08:
       mov       [rsp+28],rcx
       mov       edx,3
M02_L09:
       lea       rcx,[rsp+20]
       jmp       short M02_L11
M02_L10:
       test      edx,edx
       je        short M02_L15
       dec       edx
M02_L11:
       movsxd    rax,edx
       cmp       dword ptr [rcx+rax*4],0
       je        short M02_L10
M02_L12:
       cmp       edx,2
       ja        short M02_L13
       cmp       r8d,1C
       jle       short M02_L14
M02_L13:
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE24744708]
       mov       r8d,eax
M02_L14:
       mov       rax,[rsp+20]
       mov       [rbx+8],rax
       mov       eax,[rsp+28]
       mov       [rbx+4],eax
       mov       eax,[rsi]
       xor       eax,[rbx]
       and       eax,80000000
       mov       ecx,r8d
       shl       ecx,10
       or        eax,ecx
       mov       [rbx],eax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L15:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbx],xmm0
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L16:
       cmp       r8d,2F
       jg        short M02_L15
       add       r8d,0FFFFFFE3
       cmp       r8d,13
       jae       short M02_L19
       mov       eax,r8d
       mov       rdx,7FFE30CA5C88
       mov       r8,[rdx+rax*8]
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       rdx,rax
       imul      rdx,r8
       sub       rcx,rdx
       shr       r8,1
       cmp       rcx,r8
       jb        short M02_L18
       ja        short M02_L17
       test      al,1
       je        short M02_L18
M02_L17:
       inc       rax
M02_L18:
       mov       r8d,1C
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 751
```
```assembly
; System.Decimal.ToInt32(System.Decimal)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edx,[rbx]
       test      edx,0FF0000
       je        short M03_L00
       sar       edx,10
       movzx     edx,dl
       mov       rcx,rbx
       mov       r8d,2
       call      qword ptr [7FFE247448B8]
M03_L00:
       mov       eax,[rbx+4]
       mov       rcx,[rbx+8]
       shr       rcx,20
       or        eax,ecx
       jne       short M03_L02
       mov       eax,[rbx+8]
       mov       ecx,[rbx]
       test      ecx,ecx
       jl        short M03_L01
       test      eax,eax
       jl        short M03_L02
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       neg       eax
       test      eax,eax
       jg        short M03_L02
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,offset MT_System.OverflowException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE243DE478]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE24607150]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 130
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
       jge       near ptr M04_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M04_L06
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
M04_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243435A0
       mov       [rbp-80],rax
       lea       rax,[M04_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M04_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M04_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M04_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M04_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M04_L00
       add       eax,ebx
M04_L03:
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
M04_L04:
       call      qword ptr [7FFE24307408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M04_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE24746628]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EBF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L06:
       mov       eax,ebx
       jmp       short M04_L03
; Total bytes of code 366
```
```assembly
; System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       rbx,rcx
       mov       rsi,rdx
       mov       eax,[rbx]
       sub       eax,[rsi]
       shr       eax,10
       movsx     rdi,al
       xor       ebp,ebp
       mov       eax,[rsi+4]
       or        eax,[rsi+0C]
       jne       near ptr M05_L24
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M05_L20
       mov       rax,[rbx+8]
       mov       [rsp+48],rax
       mov       eax,[rbx+4]
       mov       [rsp+50],eax
       cmp       dword ptr [rsp+50],0
       je        short M05_L02
       mov       rcx,[rsp+4C]
       mov       r8d,r14d
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       [rsp+4C],rax
       imul      eax,r14d
       sub       rcx,rax
       shl       rcx,20
       mov       eax,[rsp+48]
       or        rcx,rax
       jne       short M05_L01
M05_L00:
       xor       r15d,r15d
       jmp       short M05_L03
M05_L01:
       mov       r8d,r14d
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       [rsp+48],eax
       imul      eax,r14d
       mov       r15d,ecx
       sub       r15d,eax
       jmp       short M05_L03
M05_L02:
       mov       rcx,[rsp+48]
       test      rcx,rcx
       je        short M05_L00
       mov       r8d,r14d
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       [rsp+48],rax
       mov       edx,r14d
       imul      edx,eax
       mov       r15d,ecx
       sub       r15d,edx
M05_L03:
       test      r15d,r15d
       jne       near ptr M05_L14
       test      edi,edi
       jl        near ptr M05_L15
M05_L04:
       test      ebp,ebp
       je        near ptr M05_L09
       mov       ecx,[rsp+48]
       mov       r8,[rsp+4C]
M05_L05:
       test      cl,cl
       je        short M05_L08
M05_L06:
       test      cl,0F
       jne       short M05_L07
       cmp       edi,4
       jl        short M05_L07
       mov       rdx,346DC5D63886594B
       mov       rax,r8
       mul       rdx
       mov       r10,rdx
       shr       r10,0B
       imul      rax,r10,2710
       mov       rdx,r8
       sub       rdx,rax
       shl       rdx,20
       mov       eax,ecx
       add       rdx,rax
       mov       r9,346DC5D63886594B
       mov       rax,rdx
       mul       r9
       shr       rdx,0B
       imul      eax,edx,2710
       cmp       ecx,eax
       jne       short M05_L07
       mov       r8,r10
       mov       ecx,edx
       add       edi,0FFFFFFFC
M05_L07:
       test      cl,3
       jne       near ptr M05_L12
       jmp       near ptr M05_L17
M05_L08:
       cmp       edi,8
       jl        short M05_L06
       mov       rdx,0ABCC77118461CEFD
       mov       rax,r8
       mul       rdx
       mov       r10,rdx
       shr       r10,1A
       imul      rax,r10,5F5E100
       mov       rdx,r8
       sub       rdx,rax
       shl       rdx,20
       mov       eax,ecx
       add       rdx,rax
       mov       r9,0ABCC77118461CEFD
       mov       rax,rdx
       mul       r9
       shr       rdx,1A
       imul      eax,edx,5F5E100
       cmp       ecx,eax
       jne       near ptr M05_L06
       mov       r8,r10
       mov       ecx,edx
       add       edi,0FFFFFFF8
       jmp       near ptr M05_L05
M05_L09:
       mov       rax,[rsp+48]
       mov       [rbx+8],rax
       mov       eax,[rsp+50]
       mov       [rbx+4],eax
M05_L10:
       mov       eax,[rbx]
       xor       eax,[rsi]
       and       eax,80000000
       mov       edx,edi
       shl       edx,10
       or        eax,edx
       mov       [rbx],eax
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L11:
       add       edi,0FFFFFFFE
M05_L12:
       test      cl,1
       jne       short M05_L13
       test      edi,edi
       jle       short M05_L13
       mov       rdx,0CCCCCCCCCCCCCCCD
       mov       rax,r8
       mul       rdx
       mov       r10,rdx
       shr       r10,3
       lea       rax,[r10+r10*4]
       add       rax,rax
       mov       rdx,r8
       sub       rdx,rax
       shl       rdx,20
       mov       eax,ecx
       add       rdx,rax
       mov       r9,0CCCCCCCCCCCCCCCD
       mov       rax,rdx
       mul       r9
       shr       rdx,3
       lea       eax,[rdx+rdx*4]
       add       eax,eax
       cmp       ecx,eax
       jne       short M05_L13
       mov       r8,r10
       mov       ecx,edx
       dec       edi
M05_L13:
       mov       [rbx+8],ecx
       mov       [rbx+0C],r8d
       shr       r8,20
       mov       [rbx+4],r8d
       jmp       near ptr M05_L10
M05_L14:
       mov       ebp,1
       cmp       edi,1C
       je        near ptr M05_L22
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFE24744750]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M05_L22
       jmp       short M05_L16
M05_L15:
       mov       r13d,edi
       neg       r13d
       cmp       r13d,9
       jl        near ptr M05_L21
       mov       r12d,9
M05_L16:
       cmp       r12d,0A
       jae       near ptr M05_L39
       mov       eax,r12d
       mov       rdx,7FFE30C9E1A8
       mov       r13d,[rdx+rax*4]
       add       edi,r12d
       mov       eax,[rsp+48]
       mov       ecx,r13d
       imul      rax,rcx
       mov       [rsp+48],eax
       mov       edx,[rsp+4C]
       imul      rdx,rcx
       shr       rax,20
       add       rax,rdx
       mov       [rsp+4C],eax
       mov       edx,[rsp+50]
       imul      rdx,rcx
       shr       rax,20
       add       rax,rdx
       mov       [rsp+50],eax
       shr       rax,20
       test      eax,eax
       jne       near ptr M05_L19
       mov       r15d,r15d
       imul      r15,rcx
       mov       ecx,r14d
       mov       rax,r15
       xor       edx,edx
       div       rcx
       mov       edx,eax
       imul      edx,r14d
       sub       r15d,edx
       mov       edx,eax
       add       rdx,[rsp+48]
       mov       [rsp+48],rdx
       mov       eax,eax
       cmp       rdx,rax
       jae       near ptr M05_L03
       mov       eax,[rsp+50]
       inc       eax
       mov       [rsp+50],eax
       test      eax,eax
       je        near ptr M05_L23
       jmp       near ptr M05_L03
M05_L17:
       cmp       edi,2
       jl        near ptr M05_L12
       mov       rdx,28F5C28F5C28F5C3
       mov       rax,r8
       shr       rax,2
       mul       rdx
       mov       r10,rdx
       shr       r10,2
       imul      rax,r10,64
       mov       rdx,r8
       sub       rdx,rax
       shl       rdx,20
       mov       eax,ecx
       add       rax,rdx
       mov       rdx,28F5C28F5C28F5C3
       shr       rax,2
       mul       rdx
       shr       rdx,2
       imul      eax,edx,64
       cmp       ecx,eax
       jne       near ptr M05_L12
       mov       r8,r10
       mov       ecx,edx
       jmp       near ptr M05_L11
M05_L18:
       mov       rcx,[rsp+48]
       inc       rcx
       mov       [rsp+48],rcx
       test      rcx,rcx
       jne       near ptr M05_L04
       mov       ecx,[rsp+50]
       inc       ecx
       mov       [rsp+50],ecx
       test      ecx,ecx
       jne       near ptr M05_L04
       lea       rcx,[rsp+48]
       mov       edx,edi
       mov       r8d,1
       call      qword ptr [7FFE24744738]
       mov       edi,eax
       jmp       near ptr M05_L04
M05_L19:
       mov       ecx,0FB09
       mov       rdx,7FFE23D64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE243D4C18]
       mov       rcx,rax
       call      qword ptr [7FFE24024798]
       int       3
M05_L20:
       mov       rcx,offset MT_System.DivideByZeroException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFE24744900]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M05_L21:
       mov       r12d,r13d
       jmp       near ptr M05_L16
M05_L22:
       lea       r13d,[r15+r15]
       cmp       r13d,r15d
       jb        near ptr M05_L18
       cmp       r13d,r14d
       jb        near ptr M05_L04
       ja        near ptr M05_L18
       test      byte ptr [rsp+48],1
       je        near ptr M05_L04
       jmp       near ptr M05_L18
M05_L23:
       xor       r8d,r8d
       test      r15d,r15d
       setne     r8b
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFE24744738]
       mov       edi,eax
       jmp       near ptr M05_L04
M05_L24:
       mov       r13d,[rsi+4]
       test      r13d,r13d
       jne       short M05_L25
       mov       r13d,[rsi+0C]
M05_L25:
       xor       r12d,r12d
       lzcnt     r12d,r13d
       mov       rcx,[rbx+8]
       shlx      rcx,rcx,r12
       mov       [rsp+38],rcx
       mov       ecx,[rbx+0C]
       mov       edx,[rbx+4]
       shl       rdx,20
       add       rcx,rdx
       mov       edx,r12d
       neg       edx
       add       edx,20
       shrx      rcx,rcx,rdx
       mov       [rsp+40],rcx
       mov       rcx,[rsi+8]
       shlx      r13,rcx,r12
       cmp       dword ptr [rsi+4],0
       jne       near ptr M05_L32
       xor       ecx,ecx
       mov       [rsp+50],ecx
       lea       rcx,[rsp+3C]
       mov       rdx,r13
       call      qword ptr [7FFE247446A8]
       mov       [rsp+4C],eax
       lea       rcx,[rsp+38]
       mov       rdx,r13
       call      qword ptr [7FFE247446A8]
       mov       [rsp+48],eax
M05_L26:
       cmp       qword ptr [rsp+38],0
       jne       short M05_L29
       test      edi,edi
       jge       near ptr M05_L04
       mov       r12d,edi
       neg       r12d
       cmp       r12d,9
       jge       short M05_L27
       jmp       short M05_L28
M05_L27:
       mov       r12d,9
M05_L28:
       jmp       short M05_L31
M05_L29:
       mov       ebp,1
       cmp       edi,1C
       je        short M05_L30
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFE24744750]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       r12d,eax
       test      r12d,r12d
       jne       short M05_L31
M05_L30:
       mov       rcx,[rsp+38]
       test      rcx,rcx
       jl        near ptr M05_L18
       add       rcx,rcx
       cmp       rcx,r13
       ja        near ptr M05_L18
       jne       near ptr M05_L04
       test      byte ptr [rsp+48],1
       je        near ptr M05_L04
       jmp       near ptr M05_L18
M05_L31:
       cmp       r12d,0A
       jae       near ptr M05_L39
       mov       ecx,r12d
       mov       rdx,7FFE30C9E1A8
       mov       ecx,[rdx+rcx*4]
       mov       r14d,ecx
       add       edi,r12d
       lea       rcx,[rsp+48]
       mov       edx,r14d
       call      qword ptr [7FFE247446D8]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M05_L19
       lea       rcx,[rsp+38]
       mov       edx,r14d
       call      qword ptr [7FFE247446F0]
       lea       rcx,[rsp+38]
       mov       rdx,r13
       call      qword ptr [7FFE247446A8]
       mov       edx,eax
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE24744768]; System.Decimal+DecCalc.Add32To96(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M05_L26
       xor       r8d,r8d
       cmp       qword ptr [rsp+38],0
       setne     r8b
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFE24744738]
       mov       edi,eax
       jmp       near ptr M05_L04
M05_L32:
       mov       [rsp+28],r13
       mov       ecx,[rsi+0C]
       mov       edx,[rsi+4]
       shl       rdx,20
       add       rcx,rdx
       mov       edx,r12d
       neg       edx
       add       edx,20
       shrx      rcx,rcx,rdx
       mov       [rsp+30],ecx
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE247446C0]
       mov       ecx,eax
       mov       [rsp+48],rcx
       xor       ecx,ecx
       mov       [rsp+50],ecx
M05_L33:
       mov       ecx,[rsp+40]
       or        rcx,[rsp+38]
       jne       short M05_L36
       test      edi,edi
       jge       near ptr M05_L04
       mov       r12d,edi
       neg       r12d
       cmp       r12d,9
       jge       short M05_L34
       jmp       short M05_L35
M05_L34:
       mov       r12d,9
M05_L35:
       jmp       near ptr M05_L38
M05_L36:
       mov       ebp,1
       cmp       edi,1C
       je        short M05_L37
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFE24744750]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       r12d,eax
       test      r12d,r12d
       jne       short M05_L38
M05_L37:
       cmp       dword ptr [rsp+40],0
       jl        near ptr M05_L18
       mov       r13d,[rsp+3C]
       shr       r13d,1F
       mov       rcx,[rsp+38]
       add       rcx,rcx
       mov       [rsp+38],rcx
       mov       ecx,[rsp+40]
       lea       ecx,[r13+rcx*2]
       mov       [rsp+40],ecx
       mov       ecx,[rsp+40]
       cmp       ecx,[rsp+30]
       ja        near ptr M05_L18
       mov       ecx,[rsp+40]
       cmp       ecx,[rsp+30]
       jne       near ptr M05_L04
       mov       rcx,[rsp+38]
       cmp       rcx,[rsp+28]
       ja        near ptr M05_L18
       mov       rcx,[rsp+38]
       cmp       rcx,[rsp+28]
       jne       near ptr M05_L04
       test      byte ptr [rsp+48],1
       je        near ptr M05_L04
       jmp       near ptr M05_L18
M05_L38:
       cmp       r12d,0A
       jae       near ptr M05_L39
       mov       ecx,r12d
       mov       rdx,7FFE30C9E1A8
       mov       r14d,[rdx+rcx*4]
       add       edi,r12d
       lea       rcx,[rsp+48]
       mov       edx,r14d
       call      qword ptr [7FFE247446D8]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M05_L19
       lea       rcx,[rsp+38]
       mov       edx,r14d
       call      qword ptr [7FFE247446D8]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       mov       [rsp+44],eax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE247446C0]
       mov       edx,eax
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE24744768]; System.Decimal+DecCalc.Add32To96(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M05_L33
       mov       r8,[rsp+38]
       or        r8,[rsp+40]
       setne     r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFE24744738]
       mov       edi,eax
       jmp       near ptr M05_L04
M05_L39:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1942
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,1A02AC02DE8
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L02
       mov       rsi,[rcx+18]
M00_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FFE242E6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       short M00_L03
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      qword ptr [7FFE24247B88]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 139
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243235A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE242E7408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE247264A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23E9F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M02_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M02_L01
       mov       edi,[rsi+10]
       cmp       edi,8
       jne       short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE31703C98]
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       mov       rax,[rbx+18]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M02_L03:
       cmp       edi,8
       ja        short M02_L04
       mov       ecx,edi
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE31703C90]
       jmp       short M02_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFE31703C98]
       jmp       short M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M02_L01
M02_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE316FB0E8]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFE31703C88]
       jmp       near ptr M02_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFE316E6918]
       mov       rcx,rax
       call      qword ptr [7FFE317095D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE31703CB0]
       jmp       near ptr M02_L01
; Total bytes of code 263
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateEmailAddress()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       mov       edi,5
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       mov       ecx,19
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        near ptr M00_L06
M00_L00:
       test      eax,eax
       je        near ptr M00_L07
M00_L01:
       mov       edx,edi
       add       edx,1
       jo        near ptr M00_L05
       cmp       ecx,edx
       cmovge    edx,ecx
       mov       ecx,edi
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242DC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,205C7B81010
       mov       [rsi+18],rcx
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       ebp,5
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       ecx,0F
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        near ptr M00_L09
M00_L02:
       test      eax,eax
       je        near ptr M00_L10
M00_L03:
       mov       edx,ebp
       add       edx,1
       jo        near ptr M00_L05
       cmp       ecx,edx
       cmovge    edx,ecx
       mov       ecx,ebp
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242DC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,205C7B70C48
       mov       [rsi+28],rdx
       mov       rdx,1C535C02DE8
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L12
       mov       r14,[rcx+18]
M00_L04:
       mov       edx,[r14+8]
       sub       edx,1
       jo        short M00_L05
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[r14+8]
       jae       near ptr M00_L13
       mov       ecx,eax
       mov       rdx,[r14+rcx*8+10]
       lea       rcx,[rsi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      qword ptr [7FFE23EB6BB0]; System.String.Concat(System.String[])
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       call      CORINFO_HELP_OVERFLOW
M00_L06:
       movzx     edx,byte ptr [rsp+38]
       test      dl,dl
       je        near ptr M00_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE23F647B0]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L07:
       call      qword ptr [7FFE2430C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFE2430C138]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,205C7B81080
       mov       r8,rbx
       call      qword ptr [7FFE23F6D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L09:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        near ptr M00_L02
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE23F647B0]
       mov       ecx,eax
       jmp       near ptr M00_L03
M00_L10:
       call      qword ptr [7FFE2430C318]
       mov       r14,rax
       test      r14,r14
       jne       short M00_L11
       call      qword ptr [7FFE2430C138]
       mov       r14,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,205C7B81080
       mov       r8,r14
       call      qword ptr [7FFE23F6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       call      qword ptr [7FFE24267B88]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 668
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243435A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE24307408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE24746178]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EBF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L17
M02_L00:
       test      eax,eax
       je        near ptr M02_L18
M02_L01:
       mov       rcx,1C535C02E08
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M02_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M02_L20
M02_L02:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r15,r15
       je        near ptr M02_L22
M02_L03:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE240EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFE240EC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M02_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M02_L10
M02_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        short M02_L08
M02_L05:
       mov       ecx,r12d
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M02_L10
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M02_L09
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M02_L06:
       add       r13d,1
       jo        short M02_L10
       cmp       r13d,ebx
       jl        short M02_L04
M02_L07:
       mov       rcx,r15
       call      qword ptr [7FFE240F9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFE240EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE23EB73F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFE24766208]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFE24766208]
       test      eax,eax
       jne       short M02_L11
M02_L15:
       mov       rax,r14
M02_L16:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M02_L23
       nop
       mov       rax,[rbp-58]
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
M02_L17:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F647B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFE2430C318]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFE2430C138]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,205C7B79BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F6D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE24605638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M02_L02
M02_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r15,r15
       jne       near ptr M02_L03
M02_L22:
       call      qword ptr [7FFE2430C330]
       mov       ecx,9E8
       mov       rdx,7FFE242E0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24176308
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242E0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE2430C120]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE24076670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M02_L23:
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
       mov       rcx,1C535C02E08
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M02_L24
       mov       r14,[rbp-50]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L28
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE240EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L25
M02_L24:
       mov       rdx,[rbp-50]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r14,[rbp-50]
       je        short M02_L28
M02_L25:
       cmp       qword ptr [rsi+20],0
       jne       short M02_L26
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L28
M02_L26:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M02_L27
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE24605608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L28
M02_L27:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M02_L28:
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
; Total bytes of code 985
```
```assembly
; System.String.Concat(System.String[])
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M03_L11
M03_L00:
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M03_L12
       xor       ecx,ecx
       xor       eax,eax
       test      esi,esi
       jle       short M03_L03
       xchg      ax,ax
M03_L01:
       mov       edx,eax
       mov       rdx,[rbx+rdx*8+10]
       test      rdx,rdx
       je        short M03_L02
       mov       edx,[rdx+8]
       add       rcx,rdx
M03_L02:
       inc       eax
       cmp       esi,eax
       jg        short M03_L01
M03_L03:
       cmp       rcx,7FFFFFFF
       jg        near ptr M03_L16
       mov       edi,ecx
       test      edi,edi
       je        near ptr M03_L13
       mov       ecx,edi
       call      00007FFE23EB1E60
       mov       rbp,rax
       xor       r14d,r14d
       xor       r15d,r15d
       test      esi,esi
       jle       short M03_L06
M03_L04:
       mov       r8d,r15d
       mov       r8,[rbx+r8*8+10]
       test      r8,r8
       je        short M03_L05
       cmp       dword ptr [r8+8],0
       je        short M03_L05
       mov       r13d,[r8+8]
       mov       ecx,edi
       sub       ecx,r14d
       cmp       ecx,r13d
       jl        short M03_L09
       cmp       [rbp],bpl
       movsxd    rcx,r14d
       lea       rcx,[rbp+rcx*2+0C]
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8,r8
       call      qword ptr [7FFE23F65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
M03_L05:
       inc       r15d
       cmp       esi,r15d
       jg        short M03_L04
M03_L06:
       cmp       r14d,edi
       jne       short M03_L10
M03_L07:
       mov       rax,rbp
M03_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L09:
       mov       r14d,0FFFFFFFF
       cmp       r14d,edi
       je        short M03_L07
M03_L10:
       mov       rcx,rbx
       call      qword ptr [7FFE23E04018]; System.Object.MemberwiseClone()
       mov       rbx,rax
       test      rbx,rbx
       jne       near ptr M03_L00
M03_L11:
       mov       ecx,1771
       mov       rdx,7FFE23D64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE240766E8]
       int       3
M03_L12:
       test      esi,esi
       je        short M03_L14
       test      esi,esi
       je        short M03_L17
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M03_L15
M03_L13:
       mov       rax,205C7B70008
       jmp       short M03_L08
M03_L14:
       mov       rax,205C7B70008
M03_L15:
       jmp       short M03_L08
M03_L16:
       call      qword ptr [7FFE2404EF40]
       int       3
M03_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 328
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M04_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M04_L01
       mov       edi,[rsi+10]
       cmp       edi,8
       jne       short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE31703C98]
M04_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M04_L02
       mov       rax,[rbx+18]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L03:
       cmp       edi,8
       ja        short M04_L04
       mov       ecx,edi
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M04_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE31703C90]
       jmp       short M04_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFE31703C98]
       jmp       short M04_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M04_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M04_L01
M04_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE316FB0E8]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFE31703C88]
       jmp       near ptr M04_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFE316E6918]
       mov       rcx,rax
       call      qword ptr [7FFE317095D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M04_L01
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE31703CB0]
       jmp       near ptr M04_L01
; Total bytes of code 263
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFile()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+128]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L05
       mov       rbp,2756A7D5ACC
       mov       rcx,rbp
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],0D
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE241B7C48]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M00_L05
       add       rsi,0C
       lea       ecx,[rdi-1]
       cmp       ecx,edi
       jae       near ptr M00_L06
       movzx     ecx,word ptr [rsi+rcx*2]
       cmp       ecx,5C
       je        short M00_L00
       cmp       ecx,2F
       je        short M00_L00
       xor       ecx,ecx
       jmp       short M00_L01
M00_L00:
       mov       ecx,1
M00_L01:
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,2756A7C87F4
       mov       [rsp+40],rsi
       mov       [rsp+48],edi
       mov       [rsp+30],rcx
       mov       dword ptr [rsp+38],1
       mov       [rsp+20],rbp
       mov       dword ptr [rsp+28],0D
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       call      qword ptr [7FFE23EC6B68]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
       jmp       short M00_L03
M00_L02:
       mov       [rsp+40],rsi
       mov       [rsp+48],edi
       mov       [rsp+30],rbp
       mov       dword ptr [rsp+38],0D
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       call      qword ptr [7FFE23EC6B50]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
M00_L03:
       mov       edx,400
       call      qword ptr [7FFE242EC1B0]; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       mov       [rsp+50],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,1B5FB
       mov       rdx,7FFE23D74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE240866E8]
       int       3
M00_L05:
       mov       rcx,2756A7D5AC0
       jmp       short M00_L03
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 366
```
```assembly
; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       mov       rax,[rcx]
       mov       ecx,[rcx+8]
       mov       edx,ecx
       test      edx,edx
       jle       short M01_L00
       movzx     edx,word ptr [rax]
       cmp       edx,5C
       je        short M01_L02
       cmp       edx,2F
       je        short M01_L02
M01_L00:
       cmp       ecx,2
       jl        short M01_L01
       movzx     ecx,word ptr [rax]
       or        ecx,20
       add       ecx,0FFFFFF9F
       cmp       ecx,19
       ja        short M01_L01
       cmp       word ptr [rax+2],3A
       sete      al
       movzx     eax,al
       ret
M01_L01:
       xor       eax,eax
       ret
M01_L02:
       mov       eax,1
       ret
; Total bytes of code 65
```
```assembly
; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[r8]
       mov       esi,[r8+8]
       mov       rdi,[rdx]
       mov       ebp,[rdx+8]
       mov       r14,[rcx]
       mov       r15d,[rcx+8]
       mov       ecx,r15d
       add       ecx,ebp
       jo        near ptr M02_L00
       add       ecx,esi
       jo        near ptr M02_L00
       test      ecx,ecx
       je        near ptr M02_L01
       call      00007FFE23EC1E60
       mov       r13,rax
       lea       r12,[r13+0C]
       mov       eax,[r13+8]
       mov       [rsp+24],eax
       cmp       r15d,eax
       ja        near ptr M02_L02
       mov       r8d,r15d
       add       r8,r8
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFE23F75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,r15d
       lea       r12,[r12+r8*2]
       mov       r14d,[rsp+24]
       sub       r14d,r15d
       cmp       ebp,r14d
       ja        short M02_L02
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,r12
       mov       rdx,rdi
       call      qword ptr [7FFE23F75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,ebp
       lea       rcx,[r12+r8*2]
       mov       r8d,r14d
       sub       r8d,ebp
       cmp       esi,r8d
       ja        short M02_L02
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFE23F75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
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
       call      CORINFO_HELP_OVERFLOW
M02_L01:
       mov       rax,2756A7C0008
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
M02_L02:
       call      qword ptr [7FFE2405E9E8]
       int       3
; Total bytes of code 240
```
```assembly
; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx]
       mov       ebp,[rcx+8]
       mov       ecx,ebp
       add       ecx,esi
       jo        short M03_L00
       test      ecx,ecx
       je        short M03_L01
       call      qword ptr [7FFE316F3170]
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       ebp,r13d
       ja        short M03_L02
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFE316F1D58]; Precode of System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,ebp
       lea       rcx,[r15+r8*2]
       sub       r13d,ebp
       cmp       esi,r13d
       ja        short M03_L02
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFE316F1D58]; Precode of System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       call      qword ptr [7FFE316E3D18]; CORINFO_HELP_OVERFLOW
M03_L01:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L02:
       call      qword ptr [7FFE316F6818]
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
; 		fileName = fileName.ArgumentNotNullOrEmpty(trim: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		fileLength = fileLength.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		CreateFile(fileName, fileLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return fileName;
; 		^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M04_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M04_L01
       jmp       short M04_L01
M04_L00:
       xor       edx,edx
M04_L01:
       test      edx,edx
       je        short M04_L04
       cmp       [rcx],ecx
       call      qword ptr [7FFE23EC7318]; System.String.Trim()
       mov       rbx,rax
       mov       byte ptr [rsp+20],1
       mov       dword ptr [rsp+24],1
       mov       edx,esi
       xor       ecx,ecx
       test      edx,edx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        short M04_L06
M04_L02:
       test      eax,eax
       je        short M04_L07
M04_L03:
       mov       rcx,rbx
       call      qword ptr [7FFE242EC078]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       call      qword ptr [7FFE2431C3D8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M04_L05
       call      qword ptr [7FFE2431C120]
       mov       rbx,rax
M04_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2756A7D5AF0
       mov       r8,rbx
       call      qword ptr [7FFE24086670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L06:
       movzx     ecx,byte ptr [rsp+20]
       test      cl,cl
       je        short M04_L02
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE23F747B0]
       mov       edx,eax
       jmp       short M04_L03
M04_L07:
       call      qword ptr [7FFE2431C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M04_L08
       call      qword ptr [7FFE2431C138]
       mov       rbx,rax
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2756A7D5B18
       mov       r8,rbx
       call      qword ptr [7FFE23F7D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 285
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFiles()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       mov       edx,2
       mov       r8d,400
       call      qword ptr [7FFE242EC1E0]; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
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
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
; 		path = path.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		fileLength = fileLength.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = Directory.CreateDirectory(path);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var files = new List<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var fileCount = 0; fileCount < count; fileCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var fileName = GenerateRandomFileName(path);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			CreateFile(fileName, fileLength);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			files.Add(fileName);
; 			^^^^^^^^^^^^^^^^^^^^
; 		return files.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       vzeroupper
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       mov       [rsp+90],rax
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       test      rbx,rbx
       je        short M01_L00
       xor       ecx,ecx
       cmp       dword ptr [rbx+8],0
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       dword ptr [rbx+8],0
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L28
       cmp       dword ptr [rbx+8],0
       je        short M01_L05
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L30
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE2477DE60]
       test      eax,eax
       jne       near ptr M01_L30
M01_L03:
       mov       ecx,[rbx+8]
       dec       ecx
       cmp       ecx,[rbx+8]
       jae       near ptr M01_L48
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L30
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE2477DE60]
       test      eax,eax
       jne       near ptr M01_L30
M01_L05:
       mov       byte ptr [rsp+90],1
       mov       dword ptr [rsp+94],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L31
M01_L06:
       test      eax,eax
       je        near ptr M01_L32
M01_L07:
       mov       byte ptr [rsp+90],1
       mov       dword ptr [rsp+94],1
       xor       ecx,ecx
       test      edi,edi
       setg      cl
       mov       edx,ecx
       test      ecx,ecx
       je        near ptr M01_L34
M01_L08:
       test      edx,edx
       je        near ptr M01_L35
M01_L09:
       test      rbx,rbx
       je        near ptr M01_L38
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L38
       mov       rcx,rbx
       call      qword ptr [7FFE241B7B88]; System.IO.Path.GetFullPath(System.String)
       mov       rbp,rax
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFE2421E9B8]; System.IO.FileSystem.CreateDirectory(System.String, Byte[])
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+28],0FFFFFFFF
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbp,rbp
       cmove     rbp,rbx
       xor       ecx,ecx
       mov       [r14+18],rcx
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+54],1
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      esi,esi
       jl        near ptr M01_L37
       test      esi,esi
       je        near ptr M01_L39
       movsxd    rdx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L10:
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M01_L16
M01_L11:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+68],ymm0
       vmovdqu   xmmword ptr [rsp+80],xmm0
       mov       r15d,0A
       mov       r13,2CA1B5F5AF0
       lea       rcx,[rsp+68]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FFE23FE56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,r15d
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFE242EC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r15,rax
       cmp       byte ptr [rsp+7C],0
       jne       near ptr M01_L40
       test      r15,r15
       je        near ptr M01_L40
       mov       r8d,[rsp+78]
       cmp       r8d,[rsp+88]
       ja        near ptr M01_L46
       mov       rcx,[rsp+80]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+88]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M01_L40
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFE23F75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+78]
       add       ecx,[r15+8]
       mov       [rsp+78],ecx
M01_L12:
       lea       rcx,[rsp+68]
       mov       edx,2E
       call      qword ptr [7FFE246DE868]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+7C],0
       jne       near ptr M01_L41
       test      r13,r13
       je        near ptr M01_L41
       mov       r8d,[rsp+78]
       cmp       r8d,[rsp+88]
       ja        near ptr M01_L46
       mov       rcx,[rsp+80]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+88]
       sub       edx,r8d
       cmp       [r13+8],edx
       ja        near ptr M01_L41
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFE23F75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+78]
       add       ecx,[r13+8]
       mov       [rsp+78],ecx
M01_L13:
       lea       rcx,[rsp+68]
       call      qword ptr [7FFE23FE5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       test      rax,rax
       je        near ptr M01_L45
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L42
       mov       r15d,[rax+8]
       test      r15d,r15d
       jne       near ptr M01_L17
       mov       r12,rbx
M01_L14:
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FFE242EC078]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L44
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       cmp       edx,[rcx+8]
       jae       near ptr M01_L48
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M01_L15:
       add       r14d,1
       jo        near ptr M01_L27
       cmp       r14d,esi
       jl        near ptr M01_L11
M01_L16:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L17:
       lea       rcx,[rax+0C]
       mov       edx,r15d
       test      edx,edx
       jle       short M01_L18
       movzx     r8d,word ptr [rcx]
       cmp       r8d,5C
       je        near ptr M01_L42
       cmp       r8d,2F
       je        near ptr M01_L42
M01_L18:
       cmp       edx,2
       jl        short M01_L19
       test      edx,edx
       je        near ptr M01_L48
       movzx     r8d,word ptr [rcx]
       or        r8d,20
       add       r8d,0FFFFFF9F
       cmp       r8d,19
       ja        short M01_L19
       cmp       edx,1
       jbe       near ptr M01_L48
       cmp       word ptr [rcx+2],3A
       je        near ptr M01_L42
M01_L19:
       lea       r12,[rbx+0C]
       mov       r13d,[rbx+8]
       add       rax,0C
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M01_L48
       movzx     ecx,word ptr [r12+rcx*2]
       cmp       ecx,5C
       je        short M01_L23
       cmp       ecx,2F
       je        short M01_L23
       test      r15d,r15d
       je        near ptr M01_L48
       movzx     ecx,word ptr [rax]
       cmp       ecx,5C
       je        short M01_L22
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M01_L20:
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L25
       mov       rdx,2CA1B5E87F4
       mov       [rsp+48],rdx
       mov       [rsp+40],rax
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L27
       add       ecx,r15d
       jo        near ptr M01_L27
       test      ecx,ecx
       jne       short M01_L24
       mov       r12,2CA1B5E0008
M01_L21:
       jmp       near ptr M01_L14
M01_L22:
       mov       ecx,1
       jmp       short M01_L20
M01_L23:
       mov       ecx,1
       jmp       short M01_L20
M01_L24:
       call      00007FFE23EC1E60
       mov       [rsp+58],rax
       lea       r10,[rax+0C]
       mov       r9d,[rax+8]
       mov       rcx,r10
       mov       r10d,r9d
       mov       [rsp+64],r10d
       cmp       r13d,r10d
       ja        near ptr M01_L47
       mov       r8d,r13d
       add       r8,r8
       mov       [rsp+38],rcx
       mov       rdx,r12
       call      qword ptr [7FFE23F75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,r13d
       mov       r12,[rsp+38]
       lea       r12,[r12+r8*2]
       mov       r10d,[rsp+64]
       sub       r10d,r13d
       mov       r13d,r10d
       cmp       r13d,1
       jb        near ptr M01_L47
       mov       rcx,[rsp+48]
       movzx     r8d,word ptr [rcx]
       mov       [r12],r8w
       add       r12,2
       mov       r8d,r13d
       sub       r8d,1
       mov       rcx,r12
       cmp       r15d,r8d
       ja        near ptr M01_L47
       mov       r8d,r15d
       add       r8,r8
       mov       rdx,[rsp+40]
       call      qword ptr [7FFE23F75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r12,[rsp+58]
       jmp       near ptr M01_L21
M01_L25:
       mov       [rsp+30],rax
       mov       ecx,r13d
       add       ecx,r15d
       jo        short M01_L27
       test      ecx,ecx
       je        near ptr M01_L43
       call      00007FFE23EC1E60
       mov       [rsp+50],rax
       lea       r10,[rax+0C]
       mov       r9d,[rax+8]
       mov       [rsp+28],r10
       mov       [rsp+60],r9d
       cmp       r13d,r9d
       ja        near ptr M01_L47
       mov       r8d,r13d
       add       r8,r8
       mov       rcx,r10
       mov       rdx,r12
       call      qword ptr [7FFE23F75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,r13d
       mov       r12,[rsp+28]
       lea       rcx,[r12+r8*2]
       mov       r12d,[rsp+60]
       sub       r12d,r13d
       cmp       r15d,r12d
       ja        near ptr M01_L47
       mov       r8d,r15d
       add       r8,r8
       mov       rdx,[rsp+30]
       call      qword ptr [7FFE23F75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r12,[rsp+50]
M01_L26:
       jmp       near ptr M01_L21
M01_L27:
       call      CORINFO_HELP_OVERFLOW
M01_L28:
       call      qword ptr [7FFE2431C3D8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L29
       call      qword ptr [7FFE2431C120]
       mov       rbx,rax
M01_L29:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2CA1B5E97F0
       mov       r8,rbx
       call      qword ptr [7FFE24086670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE23EC73F0]
       mov       rbx,rax
       jmp       near ptr M01_L05
M01_L31:
       movzx     ecx,byte ptr [rsp+90]
       test      cl,cl
       je        near ptr M01_L06
       lea       rcx,[rsp+90]
       call      qword ptr [7FFE23F747B0]
       mov       esi,eax
       jmp       near ptr M01_L07
M01_L32:
       call      qword ptr [7FFE2431C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L33
       call      qword ptr [7FFE2431C138]
       mov       rbx,rax
M01_L33:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,2CA1B5E4368
       mov       r8,rbx
       call      qword ptr [7FFE23F7D470]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L34:
       movzx     ecx,byte ptr [rsp+90]
       test      cl,cl
       je        near ptr M01_L08
       lea       rcx,[rsp+90]
       call      qword ptr [7FFE23F747B0]
       mov       edi,eax
       jmp       near ptr M01_L09
M01_L35:
       call      qword ptr [7FFE2431C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L36
       call      qword ptr [7FFE2431C138]
       mov       rbx,rax
M01_L36:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2CA1B5F5AC0
       mov       r8,rbx
       call      qword ptr [7FFE23F7D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE2405ED48]
       int       3
M01_L38:
       mov       ecx,19D8D
       mov       rdx,7FFE23D74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23ECF810]
       int       3
M01_L39:
       mov       rcx,28989801D90
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L40:
       lea       rcx,[rsp+68]
       mov       rdx,r15
       call      qword ptr [7FFE23FE5848]
       jmp       near ptr M01_L12
M01_L41:
       lea       rcx,[rsp+68]
       mov       rdx,r13
       call      qword ptr [7FFE23FE5848]
       jmp       near ptr M01_L13
M01_L42:
       mov       r12,rax
       jmp       near ptr M01_L14
M01_L43:
       mov       r12,2CA1B5E0008
       jmp       near ptr M01_L26
M01_L44:
       mov       rcx,rbp
       mov       rdx,r12
       call      qword ptr [7FFE23F7E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L15
M01_L45:
       mov       ecx,1B607
       mov       rdx,7FFE23D74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE240866E8]
       int       3
M01_L46:
       call      qword ptr [7FFE2405E9D0]
       int       3
M01_L47:
       call      qword ptr [7FFE2405E9E8]
       int       3
M01_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2012
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateInteger()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFE242F6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 37
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243335A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE242F7408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE24736418]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EAF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE2460CC78]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
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
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
; 	public static string GenerateKey() => Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture);
; 	                                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE23F67360]; System.Guid.NewGuid()
       mov       r8,21BB2800428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,25C445250B8
       call      qword ptr [7FFE23F67180]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateNumber()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       call      qword ptr [7FFE242DC258]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
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
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var numberIndex = 0; numberIndex < length; numberIndex++)
; 			     ^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(RandomNumberGenerator.GetInt32(0, 10));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       mov       rdx,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rdx-40],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-30],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-20],xmm4
       add       rdx,30
       jne       short M01_L00
       mov       [rbp-40],rdx
       mov       [rbp-0F8],rsp
       mov       ebx,ecx
       lea       rcx,[rbp-0E8]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0C8],rcx
       mov       rcx,rbp
       mov       [rbp-0B8],rcx
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L34
M01_L01:
       test      eax,eax
       je        near ptr M01_L35
M01_L02:
       mov       rcx,2F790804E00
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L37
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L37
M01_L03:
       mov       r14,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r14,r14
       je        near ptr M01_L39
M01_L04:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE2415C678]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFE2415C5D0]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-98],r14
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L17
M01_L05:
       xor       edx,edx
       mov       [rbp-4C],edx
       lea       rdi,[rbp-4C]
       mov       [rbp-0A8],rdi
M01_L06:
       mov       rdx,rdi
       mov       [rbp-58],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243435A0
       mov       [rbp-0D8],rax
       lea       rax,[M01_L07]
       mov       [rbp-0C0],rax
       lea       rax,[rbp-0E8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L07:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L08
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L08:
       mov       rcx,[rbp-0E0]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L29
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-58],rax
       mov       eax,[rbp-4C]
       and       eax,0F
       cmp       eax,9
       mov       rdi,[rbp-0A8]
       ja        near ptr M01_L06
       mov       [rbp-5C],eax
       lea       rax,[rbp-5C]
       mov       r14,[rbp-98]
       mov       rcx,[r14+8]
       mov       rdx,rcx
       mov       r8d,[r14+18]
       mov       r10d,r8d
       mov       edi,[rcx+8]
       sub       edi,r8d
       mov       ecx,r10d
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rdx+8]
       cmp       rcx,r8
       ja        near ptr M01_L30
       mov       ecx,r10d
       lea       r13,[rdx+rcx*2+10]
       mov       r12d,[rax]
       test      r12d,r12d
       jl        near ptr M01_L25
       mov       eax,r12d
       mov       ecx,r12d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFE30C987F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,edi
       jg        near ptr M01_L13
       mov       [rbp-68],eax
       mov       [rbp-70],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,r12d
       cmp       eax,0A
       jb        short M01_L11
       cmp       eax,64
       jb        short M01_L10
       mov       rdx,2F790800290
       mov       rdx,[rdx]
M01_L09:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,eax
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       eax,r10d
       mov       r10,rdx
       shl       eax,2
       mov       eax,[r10+rax+10]
       mov       [rcx],eax
       cmp       r8d,64
       mov       eax,r8d
       jae       short M01_L09
M01_L10:
       cmp       eax,0A
       jb        short M01_L11
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,2F790800290
       mov       rdx,[rdx]
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M01_L12
M01_L11:
       add       eax,30
       mov       [rcx-2],ax
M01_L12:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       eax,1
       jmp       short M01_L14
M01_L13:
       xor       eax,eax
       mov       [rbp-68],eax
M01_L14:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       test      eax,eax
       je        near ptr M01_L28
M01_L15:
       mov       ecx,[rbp-68]
       add       [r14+18],ecx
M01_L16:
       add       r15d,1
       jo        near ptr M01_L22
       cmp       r15d,ebx
       jl        near ptr M01_L05
M01_L17:
       mov       r14,[rbp-98]
       mov       rcx,r14
       call      qword ptr [7FFE24170E98]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L19
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L23
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L21
M01_L18:
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       short M01_L20
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L24
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L21
M01_L19:
       mov       [rbp-0A0],rsi
       jmp       near ptr M01_L31
M01_L20:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L21:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE23EB73F0]
       mov       rsi,rax
       jmp       short M01_L19
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       call      qword ptr [7FFE24765F38]
       test      eax,eax
       jne       short M01_L21
       jmp       short M01_L18
M01_L24:
       call      qword ptr [7FFE24765F38]
       test      eax,eax
       jne       short M01_L21
       jmp       short M01_L19
M01_L25:
       call      qword ptr [7FFE23FDF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L26
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L27
M01_L26:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L27:
       mov       ecx,r12d
       mov       [rbp-80],r8
       mov       [rbp-78],r9d
       mov       [rbp-90],r13
       mov       [rbp-88],edi
       lea       r8,[rbp-68]
       mov       [rsp+20],r8
       lea       r8,[rbp-80]
       lea       r9,[rbp-90]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE2474D1D0]
       test      eax,eax
       jne       near ptr M01_L15
M01_L28:
       mov       ecx,[rbp-5C]
       call      qword ptr [7FFE23FFFC90]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE2415C720]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L16
M01_L29:
       mov       r14,[rbp-98]
       mov       ecx,eax
       call      qword ptr [7FFE24307408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L30:
       call      qword ptr [7FFE2404E9D0]
       int       3
M01_L31:
       mov       rcx,rsp
       call      M01_L40
       jmp       short M01_L33
M01_L32:
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       mov       rsi,[rbp-0A0]
       mov       rax,rsi
       jmp       short M01_L32
M01_L34:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L01
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F647B0]
       mov       ebx,eax
       jmp       near ptr M01_L02
M01_L35:
       call      qword ptr [7FFE2430C318]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L36
       call      qword ptr [7FFE2430C138]
       mov       rsi,rax
M01_L36:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,33822879BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F6D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L37:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE24605638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L38
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L03
M01_L38:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r14,r14
       jne       near ptr M01_L04
M01_L39:
       call      qword ptr [7FFE2430C330]
       mov       ecx,9E8
       mov       rdx,7FFE242BFB00
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE240F0280
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242BFB00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2430C120]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rbx
       call      qword ptr [7FFE24076670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L40:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rcx,2F790804E00
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M01_L41
       mov       rcx,[rbp-98]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rdi+8]
       cmp       edx,[rax+0C]
       jg        short M01_L45
       xor       edx,edx
       call      qword ptr [7FFE2415C678]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L42
M01_L41:
       mov       r14,[rbp-98]
       mov       rdx,r14
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M01_L45
M01_L42:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L43
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-98]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L45
M01_L43:
       mov       r14,[rbp-98]
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L44
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE24605608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L45
M01_L44:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L45:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1615
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePhoneNumber()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,offset MT_DotNetTips.Spargine.Core.Data.CountryName
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],0EB
       mov       rdx,rax
       mov       rcx,27F894C5AF0
       cmp       [rcx],ecx
       call      qword ptr [7FFE23DFA770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M00_L00
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryRepository+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],0EB
       mov       rcx,rax
       call      qword ptr [7FFE24317480]; DotNetTips.Spargine.Core.Extensions.GetDescription(System.Enum)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Data.Models.Country, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2431E1A8]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       mov       rbp,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Core.Data.CountryRepository+<>c__DisplayClass5_0.<GetCountry>b__0(DotNetTips.Spargine.Core.Data.Models.Country)
       mov       [rsi+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rsi
       mov       rcx,7FFE24734148
       call      qword ptr [7FFE246C4D68]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       ecx,[rax+0B8]
       call      qword ptr [7FFE242D78D0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE243177B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFE24317708]
       mov       rbx,rax
M00_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,27F894C5AC0
       mov       r8,rbx
       call      qword ptr [7FFE23F6D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 333
```
```assembly
; System.RuntimeType.IsEnumDefined(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
M01_L00:
       test      rsi,rsi
       je        near ptr M01_L23
       mov       rcx,[rbx+18]
       mov       rax,rcx
       test      cl,2
       jne       short M01_L01
       mov       rcx,[rax+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
       jmp       short M01_L02
M01_L01:
       xor       ecx,ecx
M01_L02:
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L25
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdi,rax
       mov       rcx,[rdi+18]
       mov       rax,rcx
       test      cl,2
       jne       short M01_L03
       mov       rcx,[rax+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
M01_L04:
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L08
       cmp       rbx,rdi
       jne       near ptr M01_L24
M01_L05:
       mov       rcx,[rdi+18]
       mov       rax,rcx
       mov       rdx,rax
       test      al,2
       jne       short M01_L06
       mov       rax,[rdx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rax,rdx
       sete      al
       movzx     eax,al
       jmp       short M01_L07
M01_L06:
       xor       eax,eax
M01_L07:
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L25
       mov       rax,23EF74000A0
       mov       rbp,[rax]
       call      System.Enum.InternalGetCorElementType(System.Runtime.CompilerServices.MethodTable*)
       cmp       eax,1A
       jae       near ptr M01_L59
       mov       ecx,eax
       mov       rcx,[rbp+rcx*8+10]
       mov       rdi,rcx
M01_L08:
       mov       rcx,27F894B0020
       cmp       rdi,rcx
       je        near ptr M01_L26
       mov       rcx,rdi
       call      qword ptr [7FFE23E06070]; System.Type.IsIntegerType(System.Type)
       test      eax,eax
       je        near ptr M01_L28
       mov       rcx,23EF74000A0
       mov       rbp,[rcx]
       mov       rcx,[rbx+18]
       call      System.Enum.InternalGetCorElementType(System.Runtime.CompilerServices.MethodTable*)
       cmp       eax,1A
       jae       near ptr M01_L59
       mov       ecx,eax
       mov       rbp,[rbp+rcx*8+10]
       cmp       rbp,rdi
       jne       near ptr M01_L29
       test      rbp,rbp
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L18
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L18
M01_L09:
       mov       edi,[rax+90]
       test      edi,edi
       je        near ptr M01_L39
M01_L10:
       add       edi,0FFFFFFFC
       cmp       edi,5
       jne       near ptr M01_L20
       mov       rdx,offset MT_System.Int32
       cmp       [rsi],rdx
       je        short M01_L11
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int32
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
M01_L11:
       mov       r14d,[rsi+8]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L19
       mov       rcx,[rcx]
M01_L12:
       test      rcx,rcx
       je        short M01_L15
       mov       rax,[rcx+78]
M01_L13:
       test      rax,rax
       je        short M01_L14
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rax],rcx
       je        short M01_L16
M01_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE241BC900]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|7_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       short M01_L16
M01_L15:
       xor       eax,eax
       jmp       short M01_L13
M01_L16:
       mov       r15,[rax+8]
       cmp       byte ptr [rax+19],0
       je        near ptr M01_L30
       mov       eax,r14d
       mov       edx,[r15+8]
       cmp       rdx,rax
       seta      al
       movzx     eax,al
M01_L17:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rcx,rbp
       call      qword ptr [7FFE23E06658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L09
M01_L19:
       xor       ecx,ecx
       jmp       short M01_L12
M01_L20:
       cmp       edi,0A
       ja        near ptr M01_L35
       mov       edx,edi
       lea       rcx,[7FFE24647138]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M01_L00]
       add       rcx,rax
       jmp       rcx
       mov       rcx,offset MT_System.Char
       cmp       [rsi],rcx
       je        short M01_L21
       mov       rdx,rsi
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
M01_L21:
       movzx     edx,word ptr [rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FFE2476E298]
       jmp       short M01_L17
M01_L22:
       xor       edi,edi
       jmp       near ptr M01_L10
       mov       rdx,rsi
       mov       rcx,offset MT_System.SByte
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2476E280]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.Byte
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2476E280]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int16
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2476E268]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt16
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2476E268]
       jmp       near ptr M01_L17
M01_L23:
       mov       ecx,2E5
       mov       rdx,7FFE23D64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE23FE6790]
       int       3
M01_L24:
       mov       rcx,rdi
       mov       rdx,rbx
       call      00007FFE83970900
       test      eax,eax
       jne       near ptr M01_L05
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE243D4D98]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFE243D4768]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EBF708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       call      qword ptr [7FFE23E07138]
       int       3
M01_L26:
       mov       rcx,rbx
       call      qword ptr [7FFE23E04918]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       mov       r8,rsi
       mov       rcx,offset MT_System.String
       cmp       [r8],rcx
       je        short M01_L27
       mov       rdx,rsi
       call      qword ptr [7FFE23EB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L27:
       mov       rdx,rax
       mov       rcx,7FFE24732B68
       call      qword ptr [7FFE24744528]
       not       eax
       shr       eax,1F
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L28:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE243DD170]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE24005F68]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L29:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE243D4DF8]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [7FFE243D4768]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EBF708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       test      r15,r15
       jne       short M01_L31
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       short M01_L32
M01_L31:
       lea       rcx,[r15+10]
       mov       r8d,[r15+8]
M01_L32:
       cmp       dword ptr [r15+8],20
       jle       short M01_L33
       mov       edx,r8d
       mov       r8d,r14d
       call      qword ptr [7FFE241BDEF0]; System.SpanHelpers.BinarySearch[[System.UInt32, System.Private.CoreLib],[System.UInt32, System.Private.CoreLib]](UInt32 ByRef, Int32, UInt32)
       jmp       short M01_L34
M01_L33:
       mov       edx,r14d
       call      qword ptr [7FFE241BE028]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M01_L34:
       not       eax
       shr       eax,1F
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt32
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       edx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFE241B7720]; System.Enum.IsDefinedPrimitive[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, UInt32)
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int64
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2476E190]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2476E190]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.Single
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovss    xmm1,dword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2476DA88]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.Double
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovsd    xmm1,qword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2476DA70]
       jmp       near ptr M01_L17
M01_L35:
       mov       rcx,27F894B3408
       cmp       rbp,rcx
       je        short M01_L37
       mov       rcx,27F894B5958
       cmp       rbp,rcx
       je        short M01_L36
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE243DD170]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE24005F68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rdx,rsi
       mov       rcx,offset MT_System.UIntPtr
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2476D368]
       jmp       short M01_L38
M01_L37:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IntPtr
       call      qword ptr [7FFE23EB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2476D368]
M01_L38:
       movzx     eax,al
       jmp       near ptr M01_L17
M01_L39:
       mov       r15,rbp
       mov       rcx,r15
       call      qword ptr [7FFE23E06AA8]; System.RuntimeType.get_IsActualEnum()
       test      eax,eax
       je        short M01_L40
       mov       rcx,rbp
       call      qword ptr [7FFE23DFA728]; Precode of System.RuntimeType.GetEnumUnderlyingType()
       mov       r15,rax
       test      r15,r15
       je        short M01_L40
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       je        short M01_L40
       mov       rdx,rax
       call      qword ptr [7FFE23EB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L40:
       mov       rcx,27F894B5890
       cmp       r15,rcx
       jne       short M01_L41
       mov       edi,5
       jmp       near ptr M01_L56
M01_L41:
       mov       rcx,27F894B3590
       cmp       r15,rcx
       jne       short M01_L42
       mov       edi,6
       jmp       near ptr M01_L56
M01_L42:
       mov       rcx,27F894B58B8
       cmp       r15,rcx
       jne       short M01_L43
       mov       edi,7
       jmp       near ptr M01_L56
M01_L43:
       mov       rcx,27F894B3430
       cmp       r15,rcx
       jne       short M01_L44
       mov       edi,8
       jmp       near ptr M01_L56
M01_L44:
       mov       rcx,27F894B3640
       cmp       r15,rcx
       jne       short M01_L45
       mov       edi,9
       jmp       near ptr M01_L56
M01_L45:
       mov       rcx,27F894B3340
       cmp       r15,rcx
       jne       short M01_L46
       mov       edi,0A
       jmp       near ptr M01_L56
M01_L46:
       mov       rcx,27F894B58E0
       cmp       r15,rcx
       jne       short M01_L47
       mov       edi,0B
       jmp       near ptr M01_L56
M01_L47:
       mov       rcx,27F894B3188
       cmp       r15,rcx
       jne       short M01_L48
       mov       edi,0C
       jmp       near ptr M01_L56
M01_L48:
       mov       rcx,27F894B5840
       cmp       r15,rcx
       jne       short M01_L49
       mov       edi,3
       jmp       near ptr M01_L56
M01_L49:
       mov       rcx,27F894B5868
       cmp       r15,rcx
       jne       short M01_L50
       mov       edi,4
       jmp       near ptr M01_L56
M01_L50:
       mov       rcx,27F894B5908
       cmp       r15,rcx
       jne       short M01_L51
       mov       edi,0D
       jmp       short M01_L56
M01_L51:
       mov       rcx,27F894B5930
       cmp       r15,rcx
       jne       short M01_L52
       mov       edi,0E
       jmp       short M01_L56
M01_L52:
       mov       rcx,27F894B67C0
       cmp       r15,rcx
       jne       short M01_L53
       mov       edi,0F
       jmp       short M01_L56
M01_L53:
       mov       rcx,27F894B3000
       cmp       r15,rcx
       jne       short M01_L54
       mov       edi,10
       jmp       short M01_L56
M01_L54:
       mov       rcx,27F894B0020
       cmp       r15,rcx
       jne       short M01_L55
       mov       edi,12
       jmp       short M01_L56
M01_L55:
       mov       rcx,27F894C5B80
       mov       edi,1
       mov       eax,2
       cmp       r15,rcx
       cmove     edi,eax
M01_L56:
       cmp       qword ptr [rbp+10],0
       je        short M01_L57
       mov       rcx,[rbp+10]
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L57
       jmp       short M01_L58
M01_L57:
       mov       rcx,rbp
       call      qword ptr [7FFE23E06658]; System.RuntimeType.InitializeCache()
M01_L58:
       mov       [rax+90],edi
       jmp       near ptr M01_L10
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1928
```
```assembly
; DotNetTips.Spargine.Core.Extensions.GetDescription(System.Enum)
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
       je        near ptr M02_L04
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M02_L05
       mov       rcx,rax
       mov       rdx,rbx
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M02_L06
       mov       rcx,23EF3403880
       mov       rsi,[rcx]
       mov       rcx,23EF3403678
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M02_L08
       test      rsi,rsi
       je        near ptr M02_L09
M02_L00:
       mov       r14,[rdi+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [rdi+15],0
       je        short M02_L03
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M02_L01:
       lea       rdx,[rbp-30]
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rbx
       mov       r9d,r15d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Enum, System.String>
       call      qword ptr [7FFE242969E8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M02_L10
M02_L02:
       mov       rax,[rbp-30]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L03:
       mov       rdx,rbx
       mov       r11,7FFE23D709C8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M02_L01
M02_L04:
       call      qword ptr [7FFE24317900]
       mov       ecx,1BA3
       mov       rdx,7FFE24186EC8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1C09
       mov       rdx,7FFE24186EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE24186EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE243176F0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFE23FE6718]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M02_L05:
       mov       ecx,2BD
       mov       rdx,7FFE23D64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE23FE6790]
       int       3
M02_L06:
       call      qword ptr [7FFE243177B0]
       mov       r14,rax
       test      r14,r14
       jne       short M02_L07
       call      qword ptr [7FFE24317708]
       mov       r14,rax
M02_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,27F894B9658
       mov       r8,r14
       call      qword ptr [7FFE23F6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       mov       rcx,offset MT_System.Func<System.Enum, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,23EF3403868
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.Extensions+<>c.<GetDescription>b__15_0(System.Enum)
       call      qword ptr [7FFE23EB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,23EF3403880
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M02_L00
M02_L09:
       mov       ecx,0BB4
       mov       rdx,7FFE242A1020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE244CDE48]
       int       3
M02_L10:
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
       call      qword ptr [7FFE24296AD8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M02_L02
; Total bytes of code 667
```
```assembly
; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
; 		_countries ??= DeserializeCountries();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _countries;
; 		^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       xor       edx,edx
       mov       [rbp-10],rdx
       lea       rdx,[rbp-10]
       mov       rcx,27F8E4D30A8
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,23EF3403778
       cmp       qword ptr [rbx],0
       je        short M03_L01
M03_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,27F8E4D30A8
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M03_L02
M03_L01:
       call      qword ptr [7FFE2431E190]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L00
M03_L02:
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       lea       rdx,[rbp-10]
       mov       rcx,27F8E4D30A8
       call      CORINFO_HELP_MON_EXIT_STATIC
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Core.Data.CountryRepository+<>c__DisplayClass5_0.<GetCountry>b__0(DotNetTips.Spargine.Core.Data.Models.Country)
; 		return GetCountries().FirstOrDefault(p => string.Equals(p.Name, countryNameDescription, StringComparison.Ordinal));
; 		                                          ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r8,rcx
       mov       rcx,[rdx+68]
       mov       rdx,[r8+8]
       mov       r8d,4
       jmp       qword ptr [7FFE23EB61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
; Total bytes of code 23
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-38],rcx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        near ptr M05_L19
       test      rsi,rsi
       je        near ptr M05_L20
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L16
M05_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-40],rdi
       mov       r14,[rsi+18]
       mov       rcx,offset DotNetTips.Spargine.Core.Data.CountryRepository+<>c__DisplayClass5_0.<GetCountry>b__0(DotNetTips.Spargine.Core.Data.Models.Country)
       cmp       r14,rcx
       jne       near ptr M05_L10
       jmp       short M05_L03
M05_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M05_L05
M05_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+8]
       mov       rcx,[r15+68]
       mov       r8d,4
       call      qword ptr [7FFE23EB61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       near ptr M05_L14
M05_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.Country>
       cmp       [rdi],rcx
       jne       short M05_L06
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r14d,[rax+0C]
       cmp       r8d,r14d
       jae       short M05_L04
       mov       [rax+8],r8d
       jmp       short M05_L01
M05_L04:
       mov       [rax+8],r14d
       jmp       near ptr M05_L21
M05_L05:
       mov       rcx,rbx
       mov       rdx,7FFE2477D780
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M05_L02
M05_L06:
       mov       rcx,rdi
       mov       r11,7FFE23D709D0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M05_L21
       jmp       near ptr M05_L01
M05_L07:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M05_L12
M05_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       rdx,offset DotNetTips.Spargine.Core.Data.CountryRepository+<>c__DisplayClass5_0.<GetCountry>b__0(DotNetTips.Spargine.Core.Data.Models.Country)
       cmp       r14,rdx
       jne       near ptr M05_L15
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+8]
       mov       rcx,[r15+68]
       mov       r8d,4
       call      qword ptr [7FFE23EB61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
M05_L09:
       test      eax,eax
       jne       short M05_L14
M05_L10:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.Country>
       cmp       [rdi],rcx
       jne       short M05_L13
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r13d,[rax+0C]
       cmp       r8d,r13d
       jae       short M05_L11
       mov       [rax+8],r8d
       jmp       short M05_L07
M05_L11:
       mov       [rax+8],r13d
       jmp       near ptr M05_L21
M05_L12:
       mov       rcx,rbx
       mov       rdx,7FFE2477D780
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M05_L08
M05_L13:
       mov       rcx,rdi
       mov       r11,7FFE23D709D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L21
       jmp       near ptr M05_L07
M05_L14:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       jmp       short M05_L17
M05_L15:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M05_L09
M05_L16:
       mov       rcx,rbx
       mov       rdx,7FFE2477D6A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L17:
       mov       rax,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.Country>
       cmp       [rdi],rax
       jne       short M05_L22
M05_L18:
       mov       rax,r15
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L19:
       mov       ecx,10
       call      qword ptr [7FFE24167A38]
       int       3
M05_L20:
       mov       ecx,0C
       call      qword ptr [7FFE24167A38]
       int       3
M05_L21:
       mov       rcx,rsp
       call      M05_L24
       jmp       short M05_L23
M05_L22:
       mov       rcx,rdi
       mov       r11,7FFE23D709D8
       call      qword ptr [r11]
       jmp       short M05_L18
M05_L23:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],0
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L24:
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
       cmp       qword ptr [rbp-40],0
       je        short M05_L25
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.Country>
       mov       rdi,[rbp-40]
       cmp       [rdi],rcx
       je        short M05_L25
       mov       rcx,rdi
       mov       r11,7FFE23D709D8
       call      qword ptr [r11]
M05_L25:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 677
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var numberIndex = 0; numberIndex < length; numberIndex++)
; 			     ^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(RandomNumberGenerator.GetInt32(0, 10));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       mov       rdx,0FFFFFFFFFFFFFFA0
M06_L00:
       vmovdqa   xmmword ptr [rbp+rdx-40],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-30],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-20],xmm4
       add       rdx,30
       jne       short M06_L00
       mov       [rbp-40],rdx
       mov       [rbp-0F8],rsp
       mov       ebx,ecx
       lea       rcx,[rbp-0E8]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0C8],rcx
       mov       rcx,rbp
       mov       [rbp-0B8],rcx
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M06_L34
M06_L01:
       test      eax,eax
       je        near ptr M06_L35
M06_L02:
       mov       rcx,23EF3402E08
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M06_L37
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M06_L37
M06_L03:
       mov       r14,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r14,r14
       je        near ptr M06_L39
M06_L04:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE2402D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFE2402D050]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-98],r14
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M06_L17
M06_L05:
       xor       edx,edx
       mov       [rbp-4C],edx
       lea       rdi,[rbp-4C]
       mov       [rbp-0A8],rdi
M06_L06:
       mov       rdx,rdi
       mov       [rbp-58],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243437A0
       mov       [rbp-0D8],rax
       lea       rax,[M06_L07]
       mov       [rbp-0C0],rax
       lea       rax,[rbp-0E8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M06_L07:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M06_L08
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M06_L08:
       mov       rcx,[rbp-0E0]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M06_L29
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-58],rax
       mov       eax,[rbp-4C]
       and       eax,0F
       cmp       eax,9
       mov       rdi,[rbp-0A8]
       ja        near ptr M06_L06
       mov       [rbp-5C],eax
       lea       rax,[rbp-5C]
       mov       r14,[rbp-98]
       mov       rcx,[r14+8]
       mov       rdx,rcx
       mov       r8d,[r14+18]
       mov       r10d,r8d
       mov       edi,[rcx+8]
       sub       edi,r8d
       mov       ecx,r10d
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rdx+8]
       cmp       rcx,r8
       ja        near ptr M06_L30
       mov       ecx,r10d
       lea       r13,[rdx+rcx*2+10]
       mov       r12d,[rax]
       test      r12d,r12d
       jl        near ptr M06_L18
       mov       eax,r12d
       mov       ecx,r12d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFE30C987F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,edi
       jg        near ptr M06_L13
       mov       [rbp-68],eax
       mov       [rbp-70],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,r12d
       cmp       eax,0A
       jb        short M06_L11
       cmp       eax,64
       jb        short M06_L10
       mov       rdx,23EF7400290
       mov       rdx,[rdx]
M06_L09:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,eax
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       eax,r10d
       mov       r10,rdx
       shl       eax,2
       mov       eax,[r10+rax+10]
       mov       [rcx],eax
       cmp       r8d,64
       mov       eax,r8d
       jae       short M06_L09
M06_L10:
       cmp       eax,0A
       jb        short M06_L11
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,23EF7400290
       mov       rdx,[rdx]
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M06_L12
M06_L11:
       add       eax,30
       mov       [rcx-2],ax
M06_L12:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       eax,1
       jmp       short M06_L14
M06_L13:
       xor       eax,eax
       mov       [rbp-68],eax
M06_L14:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M06_L15:
       test      eax,eax
       je        near ptr M06_L28
       mov       ecx,[rbp-68]
       add       [r14+18],ecx
M06_L16:
       add       r15d,1
       jo        near ptr M06_L23
       cmp       r15d,ebx
       jl        near ptr M06_L05
M06_L17:
       mov       r14,[rbp-98]
       mov       rcx,r14
       call      qword ptr [7FFE240432D8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        near ptr M06_L22
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       near ptr M06_L24
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M06_L26
       jmp       near ptr M06_L25
M06_L18:
       call      qword ptr [7FFE240BE370]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M06_L19
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M06_L20
M06_L19:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M06_L20:
       mov       ecx,r12d
       mov       [rbp-80],r8
       mov       [rbp-78],r9d
       mov       [rbp-90],r13
       mov       [rbp-88],edi
       lea       r8,[rbp-68]
       mov       [rsp+20],r8
       lea       r8,[rbp-80]
       lea       r9,[rbp-90]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE2474D1D0]
       jmp       near ptr M06_L15
M06_L21:
       call      qword ptr [7FFE2476EA00]
       test      eax,eax
       jne       short M06_L26
M06_L22:
       mov       [rbp-0A0],rsi
       jmp       near ptr M06_L31
M06_L23:
       call      CORINFO_HELP_OVERFLOW
M06_L24:
       call      qword ptr [7FFE2476EA00]
       test      eax,eax
       jne       short M06_L26
M06_L25:
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       short M06_L27
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M06_L21
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       je        short M06_L22
M06_L26:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE23EB73F0]
       mov       rsi,rax
       jmp       short M06_L22
M06_L27:
       call      CORINFO_HELP_RNGCHKFAIL
M06_L28:
       mov       ecx,[rbp-5C]
       call      qword ptr [7FFE23FE4300]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE2402D1A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M06_L16
M06_L29:
       mov       r14,[rbp-98]
       mov       ecx,eax
       call      qword ptr [7FFE24316D78]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M06_L30:
       call      qword ptr [7FFE241657E8]
       int       3
M06_L31:
       mov       rcx,rsp
       call      M06_L40
       jmp       short M06_L33
M06_L32:
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L33:
       mov       rsi,[rbp-0A0]
       mov       rax,rsi
       jmp       short M06_L32
M06_L34:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M06_L01
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F647B0]
       mov       ebx,eax
       jmp       near ptr M06_L02
M06_L35:
       call      qword ptr [7FFE243178E8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M06_L36
       call      qword ptr [7FFE24317708]
       mov       rsi,rax
M06_L36:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,27F894B9BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F6D470]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M06_L37:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE24605638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M06_L38
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M06_L03
M06_L38:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r14,r14
       jne       near ptr M06_L04
M06_L39:
       call      qword ptr [7FFE24317900]
       mov       ecx,9E8
       mov       rdx,7FFE242E0BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24186EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242E0BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE243176F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE23FE6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L40:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rcx,23EF3402E08
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M06_L41
       mov       rcx,[rbp-98]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rdi+8]
       cmp       edx,[rax+0C]
       jg        short M06_L45
       xor       edx,edx
       call      qword ptr [7FFE2402D0F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M06_L42
M06_L41:
       mov       r14,[rbp-98]
       mov       rdx,r14
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M06_L45
M06_L42:
       cmp       qword ptr [rsi+20],0
       jne       short M06_L43
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-98]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M06_L45
M06_L43:
       mov       r14,[rbp-98]
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M06_L44
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE24605608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M06_L45
M06_L44:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M06_L45:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1625
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileName()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       esi,0A
       mov       rcx,2D94BA65AC0
       cmp       [rcx],ecx
       call      qword ptr [7FFE23EA7318]; System.String.Trim()
       mov       rdi,rax
       lea       rcx,[rsp+28]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FFE240A5CF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,esi
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFE242C7B10]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       cmp       byte ptr [rsp+3C],0
       jne       near ptr M00_L02
       test      rdx,rdx
       je        near ptr M00_L02
       mov       r8d,[rsp+38]
       cmp       r8d,[rsp+48]
       ja        near ptr M00_L03
       mov       rcx,[rsp+40]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,r8d
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        near ptr M00_L02
       add       rdx,0C
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       esi,[rsp+38]
       mov       [rsp+38],esi
M00_L00:
       lea       rcx,[rsp+28]
       mov       edx,2E
       call      qword ptr [7FFE246BE868]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+3C],0
       jne       near ptr M00_L04
       test      rdi,rdi
       je        near ptr M00_L04
       mov       r8d,[rsp+38]
       cmp       r8d,[rsp+48]
       ja        near ptr M00_L03
       mov       rcx,[rsp+40]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,r8d
       mov       esi,[rdi+8]
       cmp       esi,edx
       ja        short M00_L04
       lea       rdx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       esi,[rsp+38]
       mov       [rsp+38],esi
M00_L01:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE240A5D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       call      qword ptr [7FFE241A7600]; System.IO.Path.GetTempPath()
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE241A72E8]; System.IO.Path.Combine(System.String, System.String)
       mov       [rsp+20],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,7FFE24722A90
       cmp       [rcx],ecx
       call      qword ptr [7FFE247344E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE240A5E90]
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FFE241557E8]
       int       3
M00_L04:
       lea       rcx,[rsp+28]
       mov       rdx,rdi
       call      qword ptr [7FFE240A5E90]
       jmp       short M00_L01
; Total bytes of code 403
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE247574E0]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE247574E0]
       test      eax,eax
       jne       short M01_L04
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE23EA73F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       ecx,ecx
       mov       [rbx],rcx
       mov       rcx,298B9C01DE8
       mov       rcx,[rcx]
       imul      eax,r8d,0B
       add       edx,eax
       mov       eax,100
       cmp       edx,100
       cmovle    edx,eax
       call      qword ptr [7FFE24172BB8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       test      rsi,rsi
       je        short M02_L01
       lea       rax,[rsi+10]
       mov       ecx,[rsi+8]
M02_L00:
       mov       [rbx+18],rax
       mov       [rbx+20],ecx
       xor       eax,eax
       mov       [rbx+10],eax
       mov       byte ptr [rbx+14],0
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L01:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M02_L00
; Total bytes of code 109
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M03_L17
M03_L00:
       test      eax,eax
       je        near ptr M03_L18
M03_L01:
       mov       rcx,298B9C04E00
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M03_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M03_L20
M03_L02:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r15,r15
       je        near ptr M03_L22
M03_L03:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE2401D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFE2401D050]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M03_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M03_L10
M03_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        short M03_L08
M03_L05:
       mov       ecx,r12d
       call      qword ptr [7FFE243062F8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M03_L10
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M03_L09
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M03_L06:
       add       r13d,1
       jo        short M03_L10
       cmp       r13d,ebx
       jl        short M03_L04
M03_L07:
       mov       rcx,r15
       call      qword ptr [7FFE240332D8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M03_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M03_L12
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L13
M03_L08:
       mov       edx,eax
       jmp       short M03_L05
M03_L09:
       mov       rcx,r15
       call      qword ptr [7FFE2401D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M03_L06
M03_L10:
       call      CORINFO_HELP_OVERFLOW
M03_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE23EA73F0]
       jmp       short M03_L16
M03_L12:
       call      qword ptr [7FFE247574E0]
       test      eax,eax
       jne       short M03_L11
M03_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L14
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L15
M03_L14:
       call      qword ptr [7FFE247574E0]
       test      eax,eax
       jne       short M03_L11
M03_L15:
       mov       rax,r14
M03_L16:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M03_L23
       nop
       mov       rax,[rbp-58]
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
M03_L17:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F547B0]
       mov       ebx,eax
       jmp       near ptr M03_L01
M03_L18:
       call      qword ptr [7FFE243078E8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M03_L19
       call      qword ptr [7FFE24307708]
       mov       rsi,rax
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2D94BA59BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F5D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE245F5638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M03_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M03_L02
M03_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r15,r15
       jne       near ptr M03_L03
M03_L22:
       call      qword ptr [7FFE24307900]
       mov       ecx,9E8
       mov       rdx,7FFE242D0BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24176EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242D0BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE243076F0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE23FD6718]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M03_L23:
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
       mov       rcx,298B9C04E00
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M03_L24
       mov       r14,[rbp-50]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M03_L28
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE2401D0F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M03_L25
M03_L24:
       mov       rdx,[rbp-50]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r14,[rbp-50]
       je        short M03_L28
M03_L25:
       cmp       qword ptr [rsi+20],0
       jne       short M03_L26
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M03_L28
M03_L26:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M03_L27
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE245F5608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M03_L28
M03_L27:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M03_L28:
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
; Total bytes of code 985
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M04_L03
       test      r8b,18
       jne       short M04_L01
       test      r8b,4
       je        short M04_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M04_L00:
       ret
M04_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M04_L00
M04_L02:
       test      r8,r8
       je        short M04_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M04_L06
       jmp       short M04_L00
M04_L03:
       cmp       r8,40
       ja        short M04_L07
M04_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L11
M04_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M04_L00
M04_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M04_L00
M04_L07:
       cmp       r8,800
       ja        short M04_L10
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
       ja        short M04_L04
       jmp       short M04_L05
M04_L09:
       cmp       rcx,rdx
       je        near ptr M04_L00
M04_L10:
       jmp       qword ptr [7FFE23F55B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L05
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       cmp       byte ptr [rbx+14],0
       jne       short M05_L03
M05_L00:
       movzx     ecx,si
       lea       rax,[rbx+18]
       mov       edx,[rbx+10]
       mov       r8d,[rax+8]
       cmp       edx,r8d
       ja        short M05_L02
       mov       rax,[rax]
       mov       r10d,edx
       lea       rax,[rax+r10*2]
       sub       r8d,edx
       je        short M05_L01
       mov       [rax],cx
       mov       ecx,1
       add       [rbx+10],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       mov       rcx,rbx
       call      qword ptr [7FFE240A5F80]
       jmp       short M05_L00
M05_L02:
       call      qword ptr [7FFE241557E8]
       int       3
M05_L03:
       movzx     edx,si
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE247577E0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 110
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       lea       rcx,[rbx+18]
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        short M06_L01
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       [rsp+30],eax
       lea       rcx,[rsp+28]
       call      00007FFE23EA2520
       mov       rsi,rax
       mov       rdx,[rbx+8]
       xor       ecx,ecx
       mov       [rbx],rcx
       mov       [rbx+8],rcx
       mov       [rbx+10],rcx
       mov       [rbx+18],rcx
       mov       [rbx+20],rcx
       test      rdx,rdx
       je        short M06_L00
       mov       rcx,298B9C01DE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE24172BC0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M06_L00:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M06_L01:
       call      qword ptr [7FFE241557E8]
       int       3
; Total bytes of code 122
```
```assembly
; System.IO.Path.GetTempPath()
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,0E25B3D99A902
       mov       [rbp],rax
       test      [rsp],esp
       sub       rsp,210
       lea       rcx,[rsp+20]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],104
       xor       ecx,ecx
       mov       [rbp+10],ecx
       lea       rcx,[rbp+8]
       call      qword ptr [7FFE241A7630]; System.IO.Path.GetTempPath(System.Text.ValueStringBuilder ByRef)
       lea       rcx,[rbp+8]
       call      qword ptr [7FFE241FCA98]; System.IO.PathHelper.Normalize(System.Text.ValueStringBuilder ByRef)
       mov       rbx,rax
       mov       rdx,[rbp+8]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+8],ymm0
       test      rdx,rdx
       jne       short M07_L02
M07_L00:
       mov       rax,rbx
       mov       rcx,0E25B3D99A902
       cmp       [rbp],rcx
       je        short M07_L01
       call      CORINFO_HELP_FAIL_FAST
M07_L01:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rbp
       ret
M07_L02:
       mov       rcx,298B9C01DE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE24172BC0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       short M07_L00
; Total bytes of code 175
```
```assembly
; System.IO.Path.Combine(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M08_L00
       test      rdx,rdx
       je        short M08_L01
       add       rsp,28
       jmp       qword ptr [7FFE241A7420]; System.IO.Path.CombineInternal(System.String, System.String)
M08_L00:
       mov       ecx,1B5FB
       mov       rdx,7FFE23D54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE23FD6790]
       int       3
M08_L01:
       mov       ecx,1B607
       mov       rdx,7FFE23D54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE23FD6790]
       int       3
; Total bytes of code 84
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomLocationData()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rdx,1E155802DE0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L21
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M00_L22
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L23
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Core.Data.Models.Country>
       cmp       [rax],rcx
       jne       short M00_L01
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60BF8
       call      qword ptr [r11]
       jmp       short M00_L02
M00_L01:
       mov       rcx,rax
       mov       r11,7FFE23D60BF0
       call      qword ptr [r11]
M00_L02:
       test      eax,eax
       jle       near ptr M00_L27
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE243073F0]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L28
       mov       rcx,1E1498025E0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L30
M00_L04:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable<DotNetTips.Spargine.Core.Data.Models.Country, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L49
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E145801E30
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition<DotNetTips.Spargine.Core.Data.Models.Country>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [rsi+10],r8d
       mov       [rsi+14],r8d
       mov       rdx,rsi
       lea       r8,[rsp+50]
       mov       rcx,7FFE24603E00
       call      qword ptr [7FFE2415DD10]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rsi,rax
M00_L05:
       xor       edi,edi
       xor       ebp,ebp
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE2430C9C0]; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
       test      rax,rax
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Core.Data.Models.City>
       cmp       [rax],rcx
       jne       short M00_L06
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60C10
       call      qword ptr [r11]
       jmp       short M00_L07
M00_L06:
       mov       rcx,rax
       mov       r11,7FFE23D60C08
       call      qword ptr [r11]
M00_L07:
       test      eax,eax
       jle       near ptr M00_L19
       mov       rcx,rsi
       call      qword ptr [7FFE2430C9C0]; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L31
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L32
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Core.Data.Models.Country>
       cmp       [rax],rcx
       jne       short M00_L08
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60C38
       call      qword ptr [r11]
       jmp       short M00_L09
M00_L08:
       mov       rcx,rax
       mov       r11,7FFE23D60C30
       call      qword ptr [r11]
M00_L09:
       test      eax,eax
       jle       near ptr M00_L36
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFE243073F0]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L37
       mov       rcx,1E1498025F0
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M00_L39
M00_L11:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable<DotNetTips.Spargine.Core.Data.Models.State, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r15,r15
       je        near ptr M00_L49
       xor       ecx,ecx
       mov       [rdi+10],rcx
       lea       rcx,[rdi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E145801E30
       mov       rdx,[rcx]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition<DotNetTips.Spargine.Core.Data.Models.State>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+10],r8d
       mov       [r14+14],r8d
       mov       rdx,r14
       lea       r8,[rsp+48]
       mov       rcx,7FFE24605210
       call      qword ptr [7FFE2415DD10]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rdi,rax
M00_L12:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE2430D170]; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
       test      rax,rax
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Core.Data.Models.City>
       cmp       [rax],rcx
       jne       short M00_L13
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60C50
       call      qword ptr [r11]
       jmp       short M00_L14
M00_L13:
       mov       rcx,rax
       mov       r11,7FFE23D60C48
       call      qword ptr [r11]
M00_L14:
       test      eax,eax
       jle       near ptr M00_L19
       mov       rcx,rdi
       call      qword ptr [7FFE2430D170]; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L40
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L41
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Core.Data.Models.Country>
       cmp       [rax],rcx
       jne       short M00_L15
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60C78
       call      qword ptr [r11]
       jmp       short M00_L16
M00_L15:
       mov       rcx,rax
       mov       r11,7FFE23D60C70
       call      qword ptr [r11]
M00_L16:
       test      eax,eax
       jle       near ptr M00_L45
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFE243073F0]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L46
       mov       rcx,1E149802610
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M00_L48
M00_L18:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable<DotNetTips.Spargine.Core.Data.Models.City, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r15,r15
       je        near ptr M00_L49
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E145801E30
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       r8d,1
       mov       rdx,rbp
       mov       rcx,7FFE246A1948
       call      qword ptr [7FFE245F6040]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+40]
       mov       rcx,7FFE246A1AC0
       call      qword ptr [7FFE2415DD10]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rbp,rax
M00_L19:
       mov       [rsp+28],rsi
       mov       [rsp+30],rdi
       mov       [rsp+38],rbp
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,7FFE24723278
       cmp       [rcx],ecx
       call      qword ptr [7FFE247344E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`3<System.__Canon,System.__Canon,System.__Canon> ByRef)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L20:
       call      CORINFO_HELP_OVERFLOW
M00_L21:
       call      qword ptr [7FFE24257678]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L00
M00_L22:
       call      qword ptr [7FFE24307900]
       mov       ecx,43
       mov       rdx,7FFE242D0BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24176EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,1
       mov       rdx,7FFE242D0BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE243076F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE23FD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L23:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L24
       mov       rcx,rax
       mov       r11,7FFE23D60BE8
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L24:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFE23D60BD8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M00_L26
M00_L25:
       add       edi,1
       jo        near ptr M00_L20
M00_L26:
       mov       rcx,rbp
       mov       r11,7FFE23D60BE0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L25
       mov       eax,edi
       test      eax,eax
       jg        near ptr M00_L03
M00_L27:
       xor       esi,esi
       jmp       near ptr M00_L05
M00_L28:
       call      qword ptr [7FFE24307720]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L29
       call      qword ptr [7FFE243076F0]
       mov       rbx,rax
M00_L29:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,221D7840838
       mov       r8,rbx
       call      qword ptr [7FFE23FD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L30:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Data.Models.Country, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1E1498025D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFE23EA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E1498025E0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L04
M00_L31:
       call      qword ptr [7FFE24307900]
       mov       ecx,43
       mov       rdx,7FFE242D0BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24176EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE242D0BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE243076F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE23FD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L32:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L33
       mov       rcx,rax
       mov       r11,7FFE23D60C28
       call      qword ptr [r11]
       jmp       near ptr M00_L09
M00_L33:
       xor       edi,edi
       mov       rcx,r14
       mov       r11,7FFE23D60C18
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M00_L35
M00_L34:
       add       edi,1
       jo        near ptr M00_L20
M00_L35:
       mov       rcx,r15
       mov       r11,7FFE23D60C20
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L34
       mov       eax,edi
       test      eax,eax
       jg        near ptr M00_L10
M00_L36:
       xor       edi,edi
       jmp       near ptr M00_L12
M00_L37:
       call      qword ptr [7FFE24307720]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L38
       call      qword ptr [7FFE243076F0]
       mov       rbx,rax
M00_L38:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,221D7840838
       mov       r8,rbx
       call      qword ptr [7FFE23FD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L39:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Data.Models.State, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,1E1498025E8
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFE23EA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E1498025F0
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L11
M00_L40:
       call      qword ptr [7FFE24307900]
       mov       ecx,43
       mov       rdx,7FFE242D0BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24176EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242D0BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE243076F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE23FD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L41:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L42
       mov       rcx,rax
       mov       r11,7FFE23D60C68
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L42:
       xor       ebp,ebp
       mov       rcx,r14
       mov       r11,7FFE23D60C58
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M00_L44
M00_L43:
       add       ebp,1
       jo        near ptr M00_L20
M00_L44:
       mov       rcx,r15
       mov       r11,7FFE23D60C60
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L43
       mov       eax,ebp
       test      eax,eax
       jg        near ptr M00_L17
M00_L45:
       xor       ebp,ebp
       jmp       near ptr M00_L19
M00_L46:
       call      qword ptr [7FFE24307720]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L47
       call      qword ptr [7FFE243076F0]
       mov       rbx,rax
M00_L47:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,221D7840838
       mov       r8,rbx
       call      qword ptr [7FFE23FD6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L48:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Data.Models.City, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,1E149802608
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFE23EA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E149802610
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L18
M00_L49:
       mov       ecx,9
       call      qword ptr [7FFE24157A38]
       int       3
; Total bytes of code 2427
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       r8,[rdx]
       movzx     r10d,word ptr [r8+0E]
       test      r10,r10
       je        short M01_L05
       mov       r9,[r8+38]
       cmp       r10,4
       jl        short M01_L04
M01_L00:
       cmp       [r9],rcx
       je        short M01_L01
       cmp       [r9+8],rcx
       je        short M01_L01
       cmp       [r9+10],rcx
       je        short M01_L01
       cmp       [r9+18],rcx
       je        short M01_L01
       add       r9,20
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jl        short M01_L03
       jmp       short M01_L00
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       jmp       qword ptr [7FFE23EA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L03:
       test      r10,r10
       je        short M01_L05
M01_L04:
       cmp       [r9],rcx
       je        short M01_L01
       add       r9,8
       dec       r10
       test      r10,r10
       jg        short M01_L04
M01_L05:
       test      dword ptr [r8],406C0000
       jne       short M01_L02
       xor       edx,edx
       jmp       short M01_L01
; Total bytes of code 112
```
```assembly
; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
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
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Core.Data.Models.Country>
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60B98
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFE23D60B90
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFE23D60B88
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFE23D60B78
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFE23D60B80
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
       je        near ptr M03_L19
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbx
       mov       rdx,7FFE24760000
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M03_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M03_L02
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rbx
       mov       rdx,7FFE247605D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L03:
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
M03_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFE247601F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rsi
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M03_L07
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rbx
       mov       rdx,offset DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M03_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M03_L09
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rbx
       mov       rdx,7FFE247604B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L10:
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
M03_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rbx
       mov       rdx,offset System.Linq.CachingComparer`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].Compare(System.__Canon, Boolean)
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFE23D60A30
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L16
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L14
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rbx
       mov       rdx,7FFE247603C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M03_L20
       jmp       short M03_L18
M03_L16:
       mov       rcx,rsp
       call      M03_L20
       nop
M03_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L18:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L19:
       mov       ecx,10
       call      qword ptr [7FFE24157A38]
       int       3
M03_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M03_L21
       mov       rcx,[rbp-28]
       mov       r11,7FFE23D60A38
       call      qword ptr [r11]
M03_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 596
```
```assembly
; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
; 		get => this._states ??= [];
; 		       ^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rax,[rbx+8]
       test      rax,rax
       je        short M04_L01
M04_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L01:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Core.Data.Models.State>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2430CE40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M04_L00
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
; 		get => this._cities ??= [];
; 		       ^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rax,[rbx+8]
       test      rax,rax
       je        short M05_L01
M05_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Core.Data.Models.City>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2430CE40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M05_L00
; Total bytes of code 69
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M06_L00
       jmp       short M06_L01
M06_L00:
       mov       rcx,rbx
       mov       rdx,7FFE24765138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M06_L04
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M06_L02
       jmp       short M06_L03
M06_L02:
       mov       rcx,rbx
       mov       rdx,7FFE24765328
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L03:
       mov       rcx,rbp
       mov       edx,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M06_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M06_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M06_L05
       jmp       short M06_L06
M06_L05:
       mov       rcx,rbx
       mov       rdx,7FFE247653C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L06:
       mov       rdx,rsi
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       short M06_L09
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M06_L07
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M06_L07
       jmp       short M06_L08
M06_L07:
       mov       rcx,rbx
       mov       rdx,7FFE24766238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2415DB48]
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L09:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M06_L10
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M06_L10
       jmp       short M06_L11
M06_L10:
       mov       rcx,rbx
       mov       rdx,7FFE24766180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFE247561A8]
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 351
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`3<System.__Canon,System.__Canon,System.__Canon> ByRef)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rbx,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rcx,rdx
       mov       rdx,7FFE24715120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rbx
       call      qword ptr [7FFE24734540]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`3<System.__Canon,System.__Canon,System.__Canon> ByRef)
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 65
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M08_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M08_L01
       mov       edi,[rsi+10]
       cmp       edi,8
       jne       short M08_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE31703C98]
M08_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M08_L02
       mov       rax,[rbx+18]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M08_L03:
       cmp       edi,8
       ja        short M08_L04
       mov       ecx,edi
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M08_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE31703C90]
       jmp       short M08_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFE31703C98]
       jmp       short M08_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M08_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M08_L01
M08_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE316FB0E8]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFE31703C88]
       jmp       near ptr M08_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFE316E6918]
       mov       rcx,rax
       call      qword ptr [7FFE317095D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M08_L01
M08_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE31703CB0]
       jmp       near ptr M08_L01
; Total bytes of code 263
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
       je        near ptr M09_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M09_L02
       test      rbx,rbx
       je        short M09_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M09_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M09_L01
       call      00007FFE23EA1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L01:
       call      qword ptr [7FFE24155D58]
       int       3
M09_L02:
       test      rbx,rbx
       je        short M09_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M09_L04
M09_L03:
       mov       rax,221D7830008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L04:
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
; 		.OrderBy(_ => GenerateRandomNumber());
; 		              ^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       edx,7FFFFFFF
       jmp       qword ptr [7FFE243062F8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
; Total bytes of code 13
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M11_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L00:
       call      qword ptr [7FFE23EA41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomPersonData()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,80
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       rbx,rcx
       mov       rdx,1D07FC02DE0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L41
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M00_L42
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L43
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       cmp       [rax],rcx
       jne       short M00_L01
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60DA0
       call      qword ptr [r11]
       jmp       short M00_L02
M00_L01:
       mov       rcx,rax
       mov       r11,7FFE23D60D98
       call      qword ptr [r11]
M00_L02:
       test      eax,eax
       jle       near ptr M00_L47
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE242F7A80]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L48
       mov       rcx,1D083C045D8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L50
M00_L04:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable<DotNetTips.Spargine.Core.Data.Models.Country, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L32
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1D083C01E30
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition<DotNetTips.Spargine.Core.Data.Models.Country>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [rsi+10],r8d
       mov       [rsi+14],r8d
       mov       rdx,rsi
       lea       r8,[rsp+50]
       mov       rcx,7FFE24603E00
       call      qword ptr [7FFE24155FE0]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rsi,rax
M00_L05:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE242FD380]; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
       test      rax,rax
       je        near ptr M00_L14
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Core.Data.Models.State>
       cmp       [rax],rcx
       jne       near ptr M00_L19
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60DB8
       call      qword ptr [r11]
M00_L06:
       test      eax,eax
       jle       near ptr M00_L14
       mov       rcx,rsi
       call      qword ptr [7FFE242FD380]; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L51
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       cmp       [rax],rcx
       jne       near ptr M00_L21
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60DE0
       call      qword ptr [r11]
M00_L07:
       test      eax,eax
       jle       near ptr M00_L56
M00_L08:
       mov       rcx,rdi
       call      qword ptr [7FFE242F7A80]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L57
       mov       rcx,1D083C045F8
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L59
M00_L09:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable<DotNetTips.Spargine.Core.Data.Models.State, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbp,rbp
       je        near ptr M00_L32
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1D083C01E30
       mov       rdx,[rcx]
       lea       rcx,[r14+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+28],0
       mov       r8d,1
       mov       rdx,r14
       mov       rcx,7FFE246A0600
       call      qword ptr [7FFE245F6040]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,7FFE246A0778
       call      qword ptr [7FFE24155FE0]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rdi,rax
M00_L10:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE242FDB30]; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
       test      rax,rax
       je        near ptr M00_L14
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Core.Data.Models.State>
       cmp       [rax],rcx
       jne       near ptr M00_L23
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60DF0
       call      qword ptr [r11]
M00_L11:
       test      eax,eax
       jle       near ptr M00_L14
       mov       rcx,rdi
       call      qword ptr [7FFE242FDB30]; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L24
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L25
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       cmp       [rax],rcx
       jne       near ptr M00_L22
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60E18
       call      qword ptr [r11]
M00_L12:
       test      eax,eax
       jle       near ptr M00_L14
       mov       rcx,rdi
       call      qword ptr [7FFE242F7A80]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L29
       mov       rcx,1D083C04608
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L31
M00_L13:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable<DotNetTips.Spargine.Core.Data.Models.City, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbp,rbp
       je        near ptr M00_L32
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1D083C01E30
       mov       rdx,[rcx]
       lea       rcx,[r14+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+28],0
       mov       r8d,1
       mov       rdx,r14
       mov       rcx,7FFE246A13E0
       call      qword ptr [7FFE245F6040]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+40]
       mov       rcx,7FFE246A1558
       call      qword ptr [7FFE24155FE0]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
M00_L14:
       mov       rdx,1D07FC02DF0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L33
       mov       rbp,[rcx+18]
M00_L15:
       test      rbp,rbp
       je        near ptr M00_L34
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L35
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       cmp       [rax],rcx
       jne       near ptr M00_L20
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60E40
       call      qword ptr [r11]
M00_L16:
       test      eax,eax
       jle       near ptr M00_L39
M00_L17:
       mov       rdx,rbp
       mov       rcx,7FFE246047C8
       mov       r8d,1
       call      qword ptr [7FFE245F5C20]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,7FFE24147138
       call      qword ptr [7FFE24155FE0]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L18:
       mov       rcx,1D07FC02DF8
       mov       rcx,[rcx]
       call      qword ptr [7FFE24257C18]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdx,rax
       mov       rcx,7FFE24604750
       call      qword ptr [7FFE242FE9A0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonData
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE242FC9D8]; DotNetTips.Spargine.Tester.PersonData..ctor()
       call      qword ptr [7FFE240D5B90]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+70]
       mov       r8d,1
       call      qword ptr [7FFE2415DF38]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+68],rcx
       mov       ecx,1
       mov       edx,5A
       call      qword ptr [7FFE242CC210]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       jo        near ptr M00_L40
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+68]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE2415E310]; System.TimeSpan..ctor(Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+70]
       lea       rdx,[rsp+58]
       mov       r8,[rsp+68]
       call      qword ptr [7FFE2415DEA8]; System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovups   xmm0,[rsp+58]
       vmovups   [rbp+38],xmm0
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FFE242CC258]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFE242CC030]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddressWithName(System.String, System.String)
       lea       rcx,[rbp+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FFE242CC258]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[rbp+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rbp
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,7FFE24723278
       cmp       [rcx],ecx
       call      qword ptr [7FFE247344E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,80
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L19:
       mov       rcx,rax
       mov       r11,7FFE23D60DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L20:
       mov       rcx,rax
       mov       r11,7FFE23D60E38
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L21:
       mov       rcx,rax
       mov       r11,7FFE23D60DD8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L22:
       mov       rcx,rax
       mov       r11,7FFE23D60E10
       call      qword ptr [r11]
       jmp       near ptr M00_L12
M00_L23:
       mov       rcx,rax
       mov       r11,7FFE23D60DE8
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L24:
       call      qword ptr [7FFE242FC330]
       mov       ecx,43
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24166390
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE242FC120]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE24066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L26
       mov       rcx,rax
       mov       r11,7FFE23D60E08
       call      qword ptr [r11]
       jmp       near ptr M00_L12
M00_L26:
       xor       ebp,ebp
       mov       rcx,rdi
       mov       r11,7FFE23D60DF8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L28
M00_L27:
       add       ebp,1
       jo        near ptr M00_L40
M00_L28:
       mov       rcx,r14
       mov       r11,7FFE23D60E00
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L27
       mov       eax,ebp
       jmp       near ptr M00_L12
M00_L29:
       call      qword ptr [7FFE242FC150]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L30
       call      qword ptr [7FFE242FC120]
       mov       rbx,rax
M00_L30:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21115C10838
       mov       r8,rbx
       call      qword ptr [7FFE24066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L31:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Data.Models.City, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1D083C04600
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFE23EA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D083C04608
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,9
       call      qword ptr [7FFE24064F30]
       int       3
M00_L33:
       call      qword ptr [7FFE24257B88]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbp,rax
       jmp       near ptr M00_L15
M00_L34:
       call      qword ptr [7FFE242FC330]
       mov       ecx,43
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24166390
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE242FC120]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE24066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L35:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L36
       mov       rcx,rax
       mov       r11,7FFE23D60E30
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L36:
       xor       edi,edi
       mov       rcx,rbp
       mov       r11,7FFE23D60E20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L38
M00_L37:
       add       edi,1
       jo        short M00_L40
M00_L38:
       mov       rcx,r14
       mov       r11,7FFE23D60E28
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L37
       mov       eax,edi
       test      eax,eax
       jg        near ptr M00_L17
M00_L39:
       xor       r14d,r14d
       jmp       near ptr M00_L18
M00_L40:
       call      CORINFO_HELP_OVERFLOW
M00_L41:
       call      qword ptr [7FFE24257B88]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L00
M00_L42:
       call      qword ptr [7FFE242FC330]
       mov       ecx,43
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24166390
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE242FC120]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE24066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L43:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L44
       mov       rcx,rax
       mov       r11,7FFE23D60D90
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L44:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFE23D60D80
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M00_L46
M00_L45:
       add       edi,1
       jo        near ptr M00_L40
M00_L46:
       mov       rcx,rbp
       mov       r11,7FFE23D60D88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L45
       mov       eax,edi
       test      eax,eax
       jg        near ptr M00_L03
M00_L47:
       xor       esi,esi
       jmp       near ptr M00_L05
M00_L48:
       call      qword ptr [7FFE242FC150]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L49
       call      qword ptr [7FFE242FC120]
       mov       rbx,rax
M00_L49:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21115C10838
       mov       r8,rbx
       call      qword ptr [7FFE24066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L50:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Data.Models.Country, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D083C045D0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFE23EA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D083C045D8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L04
M00_L51:
       call      qword ptr [7FFE242FC330]
       mov       ecx,43
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24166390
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE242FC120]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE24066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L52:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L53
       mov       rcx,rax
       mov       r11,7FFE23D60DD0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L53:
       xor       ebp,ebp
       mov       rcx,rdi
       mov       r11,7FFE23D60DC0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L55
M00_L54:
       add       ebp,1
       jo        near ptr M00_L40
M00_L55:
       mov       rcx,r14
       mov       r11,7FFE23D60DC8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L54
       mov       eax,ebp
       test      eax,eax
       jg        near ptr M00_L08
M00_L56:
       xor       edi,edi
       jmp       near ptr M00_L10
M00_L57:
       call      qword ptr [7FFE242FC150]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L58
       call      qword ptr [7FFE242FC120]
       mov       rbx,rax
M00_L58:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21115C10838
       mov       r8,rbx
       call      qword ptr [7FFE24066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L59:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Data.Models.State, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1D083C045F0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFE23EA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D083C045F8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
; Total bytes of code 3170
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       r8,[rdx]
       movzx     r10d,word ptr [r8+0E]
       test      r10,r10
       je        short M01_L05
       mov       r9,[r8+38]
       cmp       r10,4
       jl        short M01_L04
M01_L00:
       cmp       [r9],rcx
       je        short M01_L01
       cmp       [r9+8],rcx
       je        short M01_L01
       cmp       [r9+10],rcx
       je        short M01_L01
       cmp       [r9+18],rcx
       je        short M01_L01
       add       r9,20
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jl        short M01_L03
       jmp       short M01_L00
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       jmp       qword ptr [7FFE23EA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L03:
       test      r10,r10
       je        short M01_L05
M01_L04:
       cmp       [r9],rcx
       je        short M01_L01
       add       r9,8
       dec       r10
       test      r10,r10
       jg        short M01_L04
M01_L05:
       test      dword ptr [r8],406C0000
       jne       short M01_L02
       xor       edx,edx
       jmp       short M01_L01
; Total bytes of code 112
```
```assembly
; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
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
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       cmp       [rax],rcx
       je        short M02_L00
       mov       rcx,rax
       mov       r11,7FFE23D60B10
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60B18
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFE23D60B08
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFE23D60AF8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFE23D60B00
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
       je        near ptr M03_L19
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbx
       mov       rdx,7FFE2471FFD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M03_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M03_L02
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rbx
       mov       rdx,7FFE247605C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L03:
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
M03_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFE247601E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rsi
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M03_L07
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rbx
       mov       rdx,7FFE24760488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M03_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M03_L09
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rbx
       mov       rdx,7FFE247604A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L10:
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
M03_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rbx
       mov       rdx,7FFE24760398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFE23D60A60
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L16
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L14
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rbx
       mov       rdx,7FFE247603B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M03_L20
       jmp       short M03_L18
M03_L16:
       mov       rcx,rsp
       call      M03_L20
       nop
M03_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L18:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L19:
       mov       ecx,10
       call      qword ptr [7FFE24064F30]
       int       3
M03_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M03_L21
       mov       rcx,[rbp-28]
       mov       r11,7FFE23D60A68
       call      qword ptr [r11]
M03_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 596
```
```assembly
; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
; 		get => this._states ??= [];
; 		       ^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rax,[rbx+8]
       test      rax,rax
       je        short M04_L01
M04_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L01:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Core.Data.Models.State>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE242FD800]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M04_L00
; Total bytes of code 69
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rcx,rbx
       mov       rdx,7FFE24765E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M05_L04
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M05_L02
       jmp       short M05_L03
M05_L02:
       mov       rcx,rbx
       mov       rdx,7FFE24766070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M05_L03:
       mov       rcx,rbp
       mov       edx,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M05_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M05_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M05_L05
       jmp       short M05_L06
M05_L05:
       mov       rcx,rbx
       mov       rdx,7FFE24766110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L06:
       mov       rdx,rsi
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       short M05_L09
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M05_L07
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M05_L07
       jmp       short M05_L08
M05_L07:
       mov       rcx,rbx
       mov       rdx,7FFE24766F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE241556F8]
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L09:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M05_L10
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M05_L10
       jmp       short M05_L11
M05_L10:
       mov       rcx,rbx
       mov       rdx,7FFE24766EC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFE24756370]
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 351
```
```assembly
; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
; 		get => this._cities ??= [];
; 		       ^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rax,[rbx+8]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L01:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Core.Data.Models.City>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE242FD800]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M06_L00
; Total bytes of code 69
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
       je        short M07_L04
       mov       edi,1
       test      r8d,r8d
       cmovg     edi,r8d
       mov       rcx,[rbx+10]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rcx,rbx
       mov       rdx,7FFE245ECFE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M07_L01:
       mov       rcx,[rbx+10]
       mov       r14,[rcx+20]
       test      r14,r14
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rbx
       mov       rdx,7FFE245ED098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M07_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE245F5CF8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFE245F5D40]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M07_L04:
       call      qword ptr [7FFE242FC330]
       mov       ecx,43
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24166390
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE242FC120]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE24066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 294
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       cmp       qword ptr [rcx+8],0
       jne       short M08_L00
       mov       rax,[rcx+18]
       ret
M08_L00:
       jmp       qword ptr [7FFE24257B88]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
; Total bytes of code 18
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
       je        near ptr M09_L08
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M09_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       cmp       [rax],rcx
       je        short M09_L01
       mov       rcx,rax
       mov       r11,7FFE23D60A98
       call      qword ptr [r11]
M09_L00:
       test      eax,eax
       jle       near ptr M09_L06
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M09_L02
       jmp       short M09_L03
M09_L01:
       mov       rcx,[rax+8]
       mov       r11,7FFE23D60AA0
       call      qword ptr [r11]
       jmp       short M09_L00
M09_L02:
       mov       rcx,rsi
       mov       rdx,7FFE245ECBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M09_L03:
       mov       rcx,[rsi+10]
       mov       rbp,[rcx+20]
       test      rbp,rbp
       je        short M09_L04
       jmp       short M09_L05
M09_L04:
       mov       rcx,rsi
       mov       rdx,7FFE245ECC10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M09_L05:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFE245F5C20]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE23FC7900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L07:
       call      CORINFO_HELP_OVERFLOW
M09_L08:
       call      qword ptr [7FFE242FC330]
       mov       ecx,43
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24166390
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE242FC120]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE24066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M09_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23EA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M09_L10
       mov       rcx,rax
       mov       r11,7FFE23D60A90
       call      qword ptr [r11]
       jmp       near ptr M09_L00
M09_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFE23D60A80
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M09_L12
M09_L11:
       add       edi,1
       jo        near ptr M09_L07
M09_L12:
       mov       rcx,rbp
       mov       r11,7FFE23D60A88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M09_L11
       mov       eax,edi
       jmp       near ptr M09_L00
; Total bytes of code 492
```
```assembly
; DotNetTips.Spargine.Tester.PersonData..ctor()
; 	public string CellPhone { get; init; } = string.Empty;
; 	                                         ^^^^^^^^^^^^
; 	public string Email { get; init; } = string.Empty;
; 	                                     ^^^^^^^^^^^^
; 	public string FirstName { get; init; } = string.Empty;
; 	                                         ^^^^^^^^^^^^
; 	public string LastName { get; init; } = string.Empty;
; 	                                        ^^^^^^^^^^^^
; 	public string Phone { get; init; } = string.Empty;
; 	                                     ^^^^^^^^^^^^
; 	public PersonData()
; 	^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       mov       rbx,rcx
       lea       rcx,[rbx+8]
       mov       rsi,21115C00008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; System.DateTime.get_UtcNow()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       lea       rcx,[rbp-18]
       mov       rax,7FFEBF035380
       call      rax
       mov       rbx,[rbp-18]
       mov       rax,1D083C001C8
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFE83D5E0EC],0
       jne       short M11_L02
M11_L00:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       short M11_L01
       mov       rax,rbx
       add       rax,[rsi+10]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M11_L01:
       call      qword ptr [7FFE240D5C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M11_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M11_L00
; Total bytes of code 105
```
```assembly
; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,1D083C00350
       mov       rbp,[rcx]
       mov       r14,[rbp+8]
       test      r14,r14
       je        near ptr M12_L04
M12_L00:
       mov       rcx,rbx
       cmp       [r14],r14b
       mov       rdx,0C000000000000000
       and       rcx,rdx
       mov       rdx,rcx
       test      rdx,rdx
       je        near ptr M12_L05
       mov       rax,4000000000000000
       cmp       rdx,rax
       je        near ptr M12_L05
       mov       rcx,1D083C00348
       cmp       r14,[rcx]
       je        near ptr M12_L13
       cmp       r14,[rbp+8]
       jne       near ptr M12_L13
M12_L01:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FFE245F6C58]
M12_L02:
       mov       rcx,rax
       mov       r8,3FFFFFFFFFFFFFFF
       and       r8,rbx
       add       r8,rcx
       js        near ptr M12_L07
       mov       rax,2BCA2875F4373FFF
       cmp       r8,rax
       jg        near ptr M12_L07
M12_L03:
       mov       rdx,1CA213D840BAF7D5
       mov       rax,rdx
       imul      rcx
       mov       rax,rdx
       shr       rax,3F
       sar       rdx,1A
       add       rax,rdx
       imul      rdx,rax,23C34600
       mov       r10,rcx
       sub       r10,rdx
       jne       near ptr M12_L09
       mov       rdx,0FFFFFF8AA7425000
       cmp       rcx,rdx
       jl        near ptr M12_L10
       mov       rdx,7558BDB000
       cmp       rcx,rdx
       jg        near ptr M12_L10
       cwde
       mov       rdx,2BCA2875F4373FFF
       cmp       r8,rdx
       ja        near ptr M12_L12
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r8
       sub       rdx,rcx
       js        near ptr M12_L11
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       jg        near ptr M12_L11
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M12_L12
       cwde
       mov       [rsi],ax
       mov       [rsi+8],rdx
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M12_L04:
       mov       rcx,rbp
       call      qword ptr [7FFE245F6FE8]; System.TimeZoneInfo+CachedData.CreateLocal()
       mov       r14,rax
       jmp       near ptr M12_L00
M12_L05:
       test      rcx,rcx
       je        near ptr M12_L01
       mov       rdx,4000000000000000
       cmp       rcx,rdx
       jne       near ptr M12_L01
       mov       rax,1D083C00348
       cmp       r14,[rax]
       jne       short M12_L06
       mov       rax,[r14+40]
       jmp       near ptr M12_L02
M12_L06:
       lea       r8,[rsp+38]
       lea       r9,[rsp+30]
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FFE245F6CA0]; System.TimeZoneInfo.GetUtcOffsetFromUtc(System.DateTime, System.TimeZoneInfo, Boolean ByRef, Boolean ByRef)
       jmp       near ptr M12_L02
M12_L07:
       test      dil,dil
       je        short M12_L08
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE243C4F00]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EAF708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M12_L08:
       xor       eax,eax
       mov       rdx,2BCA2875F4373FFF
       test      r8,r8
       cmovge    rax,rdx
       mov       r8,rax
       jmp       near ptr M12_L03
M12_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE243C72D0]
       mov       rsi,rax
       mov       ecx,1D85
       mov       rdx,7FFE23D54000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE23EAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M12_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1D85
       mov       rdx,7FFE23D54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE243C72B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE23F5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M12_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1D85
       mov       rdx,7FFE23D54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE243C7678]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE23F5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M12_L12:
       call      qword ptr [7FFE240D4AB0]
       int       3
M12_L13:
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       short M12_L14
       mov       rcx,rbp
       call      qword ptr [7FFE245F6FE8]; System.TimeZoneInfo+CachedData.CreateLocal()
       mov       rdx,rax
M12_L14:
       mov       r8,1D083C00350
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,1D083C00348
       mov       r8,[r8]
       mov       rcx,rbx
       mov       r9d,2
       call      qword ptr [7FFE245F6850]
       mov       rcx,rax
       lea       r8,[rsp+48]
       lea       r9,[rsp+40]
       mov       rdx,r14
       call      qword ptr [7FFE245F6CA0]; System.TimeZoneInfo.GetUtcOffsetFromUtc(System.DateTime, System.TimeZoneInfo, Boolean ByRef, Boolean ByRef)
       jmp       near ptr M12_L02
; Total bytes of code 852
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
; 		max = max.EnsureMinimum(min + 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return RandomNumberGenerator.GetInt32(min, max);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       eax,ecx
       add       eax,1
       jo        short M13_L00
       cmp       edx,eax
       cmovl     edx,eax
       add       rsp,28
       jmp       qword ptr [7FFE242F6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
M13_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 32
```
```assembly
; System.TimeSpan..ctor(Int32, Int32, Int32, Int32)
       sub       rsp,28
       movsxd    rax,edx
       imul      rax,15180
       movsxd    rdx,r8d
       imul      rdx,0E10
       add       rax,rdx
       movsxd    rdx,r9d
       imul      rdx,3C
       add       rax,rdx
       movsxd    rdx,dword ptr [rsp+50]
       add       rax,rdx
       imul      rax,0F4240
       mov       rdx,0CCCCCCCCCCCCCCC
       cmp       rax,rdx
       jg        short M14_L00
       mov       rdx,0F333333333333334
       cmp       rax,rdx
       jl        short M14_L00
       lea       rax,[rax+rax*4]
       add       rax,rax
       mov       [rcx],rax
       add       rsp,28
       ret
M14_L00:
       call      qword ptr [7FFE2403EBB0]
       int       3
; Total bytes of code 104
```
```assembly
; System.DateTimeOffset.Subtract(System.TimeSpan)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rbx
       call      qword ptr [7FFE2415D920]; System.DateTimeOffset.get_ClockDateTime()
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rdi
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        short M15_L00
       mov       rcx,0C000000000000000
       and       rcx,rax
       or        rdx,rcx
       movsx     rcx,word ptr [rbx]
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        short M15_L01
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        short M15_L01
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE2415D800]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovups   xmm0,[rsp+20]
       vmovups   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M15_L00:
       xor       ecx,ecx
       call      qword ptr [7FFE240D4B10]
       int       3
M15_L01:
       call      qword ptr [7FFE2403EBB0]
       int       3
; Total bytes of code 178
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var numberIndex = 0; numberIndex < length; numberIndex++)
; 			     ^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(RandomNumberGenerator.GetInt32(0, 10));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       mov       rdx,0FFFFFFFFFFFFFFA0
M16_L00:
       vmovdqa   xmmword ptr [rbp+rdx-40],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-30],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-20],xmm4
       add       rdx,30
       jne       short M16_L00
       mov       [rbp-40],rdx
       mov       [rbp-0F8],rsp
       mov       ebx,ecx
       lea       rcx,[rbp-0E8]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0C8],rcx
       mov       rcx,rbp
       mov       [rbp-0B8],rcx
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M16_L33
M16_L01:
       test      eax,eax
       je        near ptr M16_L34
M16_L02:
       mov       rcx,1D07FC02E08
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M16_L36
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M16_L36
M16_L03:
       mov       r14,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r14,r14
       je        near ptr M16_L38
M16_L04:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE240DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFE240DC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-98],r14
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M16_L17
M16_L05:
       xor       edx,edx
       mov       [rbp-4C],edx
       lea       rdi,[rbp-4C]
       mov       [rbp-0A8],rdi
M16_L06:
       mov       rdx,rdi
       mov       [rbp-58],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243335A0
       mov       [rbp-0D8],rax
       lea       rax,[M16_L07]
       mov       [rbp-0C0],rax
       lea       rax,[rbp-0E8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M16_L07:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M16_L08
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M16_L08:
       mov       rcx,[rbp-0E0]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M16_L25
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-58],rax
       mov       eax,[rbp-4C]
       and       eax,0F
       cmp       eax,9
       mov       rdi,[rbp-0A8]
       ja        near ptr M16_L06
       mov       [rbp-5C],eax
       lea       rax,[rbp-5C]
       mov       r14,[rbp-98]
       mov       rcx,[r14+8]
       mov       rdx,rcx
       mov       r8d,[r14+18]
       mov       r10d,r8d
       mov       edi,[rcx+8]
       sub       edi,r8d
       mov       ecx,r10d
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rdx+8]
       cmp       rcx,r8
       ja        near ptr M16_L26
       mov       ecx,r10d
       lea       r13,[rdx+rcx*2+10]
       mov       r12d,[rax]
       test      r12d,r12d
       jl        near ptr M16_L18
       mov       eax,r12d
       mov       ecx,r12d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFE30C987F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,edi
       jg        near ptr M16_L13
       mov       [rbp-68],eax
       mov       [rbp-70],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,r12d
       cmp       eax,0A
       jb        short M16_L11
       cmp       eax,64
       jb        short M16_L10
       mov       rdx,1D083C00290
       mov       rdx,[rdx]
M16_L09:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,eax
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       eax,r10d
       mov       r10,rdx
       shl       eax,2
       mov       eax,[r10+rax+10]
       mov       [rcx],eax
       cmp       r8d,64
       mov       eax,r8d
       jae       short M16_L09
M16_L10:
       cmp       eax,0A
       jb        short M16_L11
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,1D083C00290
       mov       rdx,[rdx]
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M16_L12
M16_L11:
       add       eax,30
       mov       [rcx-2],ax
M16_L12:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       eax,1
       jmp       short M16_L14
M16_L13:
       xor       eax,eax
       mov       [rbp-68],eax
M16_L14:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M16_L15:
       test      eax,eax
       je        near ptr M16_L24
       mov       ecx,[rbp-68]
       add       [r14+18],ecx
M16_L16:
       add       r15d,1
       jo        near ptr M16_L27
       cmp       r15d,ebx
       jl        near ptr M16_L05
M16_L17:
       mov       r14,[rbp-98]
       mov       rcx,r14
       call      qword ptr [7FFE240E9518]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        near ptr M16_L30
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M16_L21
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M16_L28
       jmp       short M16_L22
M16_L18:
       call      qword ptr [7FFE23FCF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M16_L19
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M16_L20
M16_L19:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M16_L20:
       mov       ecx,r12d
       mov       [rbp-80],r8
       mov       [rbp-78],r9d
       mov       [rbp-90],r13
       mov       [rbp-88],edi
       lea       r8,[rbp-68]
       mov       [rsp+20],r8
       lea       r8,[rbp-80]
       lea       r9,[rbp-90]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE2473CB40]
       jmp       near ptr M16_L15
M16_L21:
       call      qword ptr [7FFE24757378]
       test      eax,eax
       jne       short M16_L28
M16_L22:
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       short M16_L23
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M16_L29
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M16_L28
       jmp       short M16_L30
M16_L23:
       call      CORINFO_HELP_RNGCHKFAIL
M16_L24:
       mov       ecx,[rbp-5C]
       call      qword ptr [7FFE23FEFC90]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE240DC2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M16_L16
M16_L25:
       mov       r14,[rbp-98]
       mov       ecx,eax
       call      qword ptr [7FFE242F7408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M16_L26:
       call      qword ptr [7FFE2403E9D0]
       int       3
M16_L27:
       call      CORINFO_HELP_OVERFLOW
M16_L28:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE23EA73F0]
       mov       rsi,rax
       jmp       short M16_L30
M16_L29:
       call      qword ptr [7FFE24757378]
       test      eax,eax
       jne       short M16_L28
M16_L30:
       mov       [rbp-0A0],rsi
       mov       rcx,rsp
       call      M16_L39
       jmp       short M16_L32
M16_L31:
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M16_L32:
       mov       rsi,[rbp-0A0]
       mov       rax,rsi
       jmp       short M16_L31
M16_L33:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M16_L01
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F547B0]
       mov       ebx,eax
       jmp       near ptr M16_L02
M16_L34:
       call      qword ptr [7FFE242FC318]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M16_L35
       call      qword ptr [7FFE242FC138]
       mov       rsi,rax
M16_L35:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,21115C09BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F5D470]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M16_L36:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE245F5638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M16_L37
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M16_L03
M16_L37:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r14,r14
       jne       near ptr M16_L04
M16_L38:
       call      qword ptr [7FFE242FC330]
       mov       ecx,9E8
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24166390
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE242FC120]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE24066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M16_L39:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rcx,1D07FC02E08
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M16_L40
       mov       rcx,[rbp-98]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rdi+8]
       cmp       edx,[rax+0C]
       jg        short M16_L44
       xor       edx,edx
       call      qword ptr [7FFE240DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M16_L41
M16_L40:
       mov       r14,[rbp-98]
       mov       rdx,r14
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M16_L44
M16_L41:
       cmp       qword ptr [rsi+20],0
       jne       short M16_L42
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-98]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M16_L44
M16_L42:
       mov       r14,[rbp-98]
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M16_L43
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE245F5608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M16_L44
M16_L43:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M16_L44:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1615
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddressWithName(System.String, System.String)
; 	private static string GenerateEmailAddressWithName(string firstName, string lastName) => $"{firstName.DefaultIfNullOrEmpty("FIRSTNAME")}.{lastName.DefaultIfNullOrEmpty("LASTNAME")}@{GenerateWord(5, 15, 'a', 'z')}.{GenerateDomainExtension()}";
; 	                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rsp+30]
       mov       edx,3
       mov       r8d,4
       call      qword ptr [7FFE23FC56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       test      rbx,rbx
       je        near ptr M17_L14
       cmp       dword ptr [rbx+8],0
       je        near ptr M17_L14
       cmp       byte ptr [rsp+44],0
       jne       near ptr M17_L15
M17_L00:
       test      rbx,rbx
       je        near ptr M17_L15
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L25
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rbx+8],edx
       ja        near ptr M17_L15
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rsp+40]
       add       r8d,[rbx+8]
       mov       [rsp+40],r8d
M17_L01:
       mov       r8d,[rsp+40]
       mov       ecx,[rsp+50]
       cmp       r8d,ecx
       ja        near ptr M17_L25
       mov       rdx,[rsp+48]
       mov       eax,r8d
       lea       rdx,[rdx+rax*2]
       sub       ecx,r8d
       cmp       ecx,1
       jb        near ptr M17_L16
       mov       r8,21115C00C54
       movzx     ecx,word ptr [r8]
       mov       [rdx],cx
       mov       r8d,[rsp+40]
       inc       r8d
       mov       [rsp+40],r8d
M17_L02:
       test      rsi,rsi
       je        near ptr M17_L17
       cmp       dword ptr [rsi+8],0
       je        near ptr M17_L17
       cmp       byte ptr [rsp+44],0
       jne       near ptr M17_L18
M17_L03:
       test      rsi,rsi
       je        near ptr M17_L18
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L25
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M17_L18
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[rsi+8]
       mov       [rsp+40],ecx
M17_L04:
       mov       ecx,[rsp+40]
       mov       edx,[rsp+50]
       cmp       ecx,edx
       ja        near ptr M17_L25
       mov       rax,[rsp+48]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M17_L19
       mov       rcx,21115C1101C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M17_L05:
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       edi,5
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ecx,0F
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        near ptr M17_L13
M17_L06:
       test      eax,eax
       je        near ptr M17_L20
M17_L07:
       mov       edx,edi
       add       edx,1
       jo        near ptr M17_L12
       cmp       ecx,edx
       cmovge    edx,ecx
       mov       ecx,edi
       call      qword ptr [7FFE242F6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242CC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbp,rax
       cmp       byte ptr [rsp+44],0
       jne       near ptr M17_L22
       test      rbp,rbp
       je        near ptr M17_L22
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L25
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rbp+8],edx
       ja        near ptr M17_L22
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+40]
       add       edx,[rbp+8]
       mov       [rsp+40],edx
M17_L08:
       mov       edx,[rsp+40]
       mov       ecx,[rsp+50]
       cmp       edx,ecx
       ja        near ptr M17_L25
       mov       rax,[rsp+48]
       mov       r8d,edx
       lea       rax,[rax+r8*2]
       sub       ecx,edx
       cmp       ecx,1
       jb        near ptr M17_L23
       mov       rdx,21115C00C54
       movzx     ecx,word ptr [rdx]
       mov       [rax],cx
       mov       edx,[rsp+40]
       inc       edx
       mov       [rsp+40],edx
M17_L09:
       mov       rdx,1D07FC02DE8
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M17_L24
       mov       r14,[rcx+18]
M17_L10:
       mov       edx,[r14+8]
       sub       edx,1
       jo        near ptr M17_L12
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FFE242F6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[r14+8]
       jae       near ptr M17_L27
       mov       r8d,eax
       mov       r15,[r14+r8*8+10]
       cmp       byte ptr [rsp+44],0
       jne       near ptr M17_L26
       test      r15,r15
       je        near ptr M17_L26
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L25
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M17_L26
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[r15+8]
       mov       [rsp+40],ecx
M17_L11:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE23FC5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L12:
       call      CORINFO_HELP_OVERFLOW
M17_L13:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M17_L06
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE23F547B0]
       mov       ecx,eax
       jmp       near ptr M17_L07
M17_L14:
       mov       rbx,21115C10FC0
       cmp       byte ptr [rsp+44],0
       je        near ptr M17_L00
M17_L15:
       lea       rcx,[rsp+30]
       mov       rdx,rbx
       call      qword ptr [7FFE23FC5848]
       jmp       near ptr M17_L01
M17_L16:
       lea       rcx,[rsp+30]
       mov       rdx,21115C00C48
       call      qword ptr [7FFE23FC58F0]
       jmp       near ptr M17_L02
M17_L17:
       mov       rsi,21115C10FE8
       cmp       byte ptr [rsp+44],0
       je        near ptr M17_L03
M17_L18:
       lea       rcx,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FFE23FC5848]
       jmp       near ptr M17_L04
M17_L19:
       lea       rcx,[rsp+30]
       mov       rdx,21115C11010
       call      qword ptr [7FFE23FC58F0]
       jmp       near ptr M17_L05
M17_L20:
       call      qword ptr [7FFE242FC318]
       mov       rbp,rax
       test      rbp,rbp
       jne       short M17_L21
       call      qword ptr [7FFE242FC138]
       mov       rbp,rax
M17_L21:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,21115C11080
       mov       r8,rbp
       call      qword ptr [7FFE23F5D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M17_L22:
       lea       rcx,[rsp+30]
       mov       rdx,rbp
       call      qword ptr [7FFE23FC5848]
       jmp       near ptr M17_L08
M17_L23:
       lea       rcx,[rsp+30]
       mov       rdx,21115C00C48
       call      qword ptr [7FFE23FC58F0]
       jmp       near ptr M17_L09
M17_L24:
       call      qword ptr [7FFE24257B88]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M17_L10
M17_L25:
       call      qword ptr [7FFE2403E9D0]
       int       3
M17_L26:
       lea       rcx,[rsp+30]
       mov       rdx,r15
       call      qword ptr [7FFE23FC5848]
       jmp       near ptr M17_L11
M17_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1218
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
       je        near ptr M19_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M19_L02
       test      rbx,rbx
       je        short M19_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M19_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M19_L01
       call      00007FFE23EA1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M19_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M19_L01:
       call      qword ptr [7FFE2403EF40]
       int       3
M19_L02:
       test      rbx,rbx
       je        short M19_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M19_L04
M19_L03:
       mov       rax,21115C00008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M19_L04:
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
; 		.OrderBy(_ => GenerateRandomNumber());
; 		              ^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       edx,7FFFFFFF
       jmp       qword ptr [7FFE242F6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
; Total bytes of code 13
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M21_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M21_L00:
       call      qword ptr [7FFE23EA41F8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M22_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M22_L01
       mov       edi,[rsi+10]
       cmp       edi,8
       jne       short M22_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE31703C98]
M22_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M22_L02
       mov       rax,[rbx+18]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M22_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M22_L03:
       cmp       edi,8
       ja        short M22_L04
       mov       ecx,edi
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M22_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE31703C90]
       jmp       short M22_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFE31703C98]
       jmp       short M22_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M22_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M22_L01
M22_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE316FB0E8]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFE31703C88]
       jmp       near ptr M22_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFE316E6918]
       mov       rcx,rax
       call      qword ptr [7FFE317095D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M22_L01
M22_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE31703CB0]
       jmp       near ptr M22_L01
; Total bytes of code 263
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomPersonName()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rdx,19DF8C04DE8
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L06
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M00_L07
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE23E94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       cmp       [rax],rcx
       jne       near ptr M00_L08
       mov       rcx,[rax+8]
       mov       r11,7FFE23D50B10
       call      qword ptr [r11]
M00_L01:
       test      eax,eax
       jle       near ptr M00_L13
M00_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE242F73F0]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L14
       mov       rcx,19DF8C085E0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L16
M00_L03:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable<System.String, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE2427D740]; System.Linq.OrderedEnumerable`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rdi,rdi
       je        near ptr M00_L17
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,19DF8C01E30
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       r8d,1
       mov       rdx,rbp
       mov       rcx,7FFE245F6478
       call      qword ptr [7FFE245E5D40]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+30]
       mov       rcx,7FFE241399E0
       call      qword ptr [7FFE24146AD8]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rsi,rax
M00_L04:
       call      qword ptr [7FFE242B78B8]; DotNetTips.Spargine.Tester.RandomData.GenerateLastName()
       mov       r9,rax
       lea       rcx,[rsp+38]
       mov       r8,rsi
       mov       rdx,offset MT_System.ValueTuple<System.String, System.String>
       call      qword ptr [7FFE242FD6B0]; System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       vmovdqu   xmm0,xmmword ptr [rsp+38]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,7FFE24712EC0
       cmp       [rcx],ecx
       call      qword ptr [7FFE24724810]; BenchmarkDotNet.Engines.Consumer.Consume[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`2<System.__Canon,System.__Canon> ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      CORINFO_HELP_OVERFLOW
M00_L06:
       call      qword ptr [7FFE24247678]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L00
M00_L07:
       call      qword ptr [7FFE242F7900]
       mov       ecx,43
       mov       rdx,7FFE242C0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24156310
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23E96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE242C0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23E96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE242F76F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE24056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L08:
       mov       rcx,rax
       mov       r11,7FFE23D50B08
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L09:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23E94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L10
       mov       rcx,rax
       mov       r11,7FFE23D50B00
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L10:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFE23D50AF0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M00_L12
M00_L11:
       add       edi,1
       jo        near ptr M00_L05
M00_L12:
       mov       rcx,rbp
       mov       r11,7FFE23D50AF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L11
       mov       eax,edi
       test      eax,eax
       jg        near ptr M00_L02
M00_L13:
       xor       esi,esi
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFE242F7720]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L15
       call      qword ptr [7FFE242F76F0]
       mov       rbx,rax
M00_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1DE8AB20838
       mov       r8,rbx
       call      qword ptr [7FFE24056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L16:
       mov       rcx,offset MT_System.Func<System.String, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,19DF8C085D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFE23E94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19DF8C085E0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L17:
       mov       ecx,9
       call      qword ptr [7FFE24054F30]
       int       3
; Total bytes of code 872
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       r8,[rdx]
       movzx     r10d,word ptr [r8+0E]
       test      r10,r10
       je        short M01_L05
       mov       r9,[r8+38]
       cmp       r10,4
       jl        short M01_L04
M01_L00:
       cmp       [r9],rcx
       je        short M01_L01
       cmp       [r9+8],rcx
       je        short M01_L01
       cmp       [r9+10],rcx
       je        short M01_L01
       cmp       [r9+18],rcx
       je        short M01_L01
       add       r9,20
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jl        short M01_L03
       jmp       short M01_L00
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       jmp       qword ptr [7FFE23E94378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L03:
       test      r10,r10
       je        short M01_L05
M01_L04:
       cmp       [r9],rcx
       je        short M01_L01
       add       r9,8
       dec       r10
       test      r10,r10
       jg        short M01_L04
M01_L05:
       test      dword ptr [r8],406C0000
       jne       short M01_L02
       xor       edx,edx
       jmp       short M01_L01
; Total bytes of code 112
```
```assembly
; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
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
       call      qword ptr [7FFE23E94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFE23D50A90
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFE23D50A88
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23E94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFE23D50A80
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFE23D50A70
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFE23D50A78
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
; System.Linq.OrderedEnumerable`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 11
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        short M04_L05
       test      esi,esi
       jle       short M04_L02
       mov       rdx,[rcx+10]
       mov       rax,[rdx+20]
       test      rax,rax
       je        short M04_L00
       mov       rcx,rax
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FFE24755300
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rbx
       mov       r8d,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE245E6040]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M04_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FFE247552B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M04_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE2427C2E8]; System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M04_L05:
       mov       ecx,10
       call      qword ptr [7FFE24054F30]
       int       3
; Total bytes of code 140
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
       je        near ptr M05_L19
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rcx,rbx
       mov       rdx,7FFE247506A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE23E94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M05_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M05_L02
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M05_L02
       jmp       short M05_L03
M05_L02:
       mov       rcx,rbx
       mov       rdx,7FFE24750C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M05_L03:
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
M05_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M05_L05
       jmp       short M05_L06
M05_L05:
       mov       rcx,rbx
       mov       rdx,7FFE24750898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L06:
       mov       rdx,rsi
       call      qword ptr [7FFE23E94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M05_L07
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M05_L07
       jmp       short M05_L08
M05_L07:
       mov       rcx,rbx
       mov       rdx,7FFE24750B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M05_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M05_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M05_L09
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M05_L09
       jmp       short M05_L10
M05_L09:
       mov       rcx,rbx
       mov       rdx,7FFE24750B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M05_L10:
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
M05_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M05_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M05_L12
       jmp       short M05_L13
M05_L12:
       mov       rcx,rbx
       mov       rdx,7FFE24750A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M05_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFE23D509D8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L16
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M05_L14
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M05_L14
       jmp       short M05_L15
M05_L14:
       mov       rcx,rbx
       mov       rdx,7FFE24750A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M05_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M05_L20
       jmp       short M05_L18
M05_L16:
       mov       rcx,rsp
       call      M05_L20
       nop
M05_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M05_L18:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M05_L19:
       mov       ecx,10
       call      qword ptr [7FFE24054F30]
       int       3
M05_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M05_L21
       mov       rcx,[rbp-28]
       mov       r11,7FFE23D509E0
       call      qword ptr [r11]
M05_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 596
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateLastName()
; 	public static string GenerateLastName() => _lastNames.Value.PickRandom();
; 	                                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdx,19DF8C04DF0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M06_L06
       mov       rbx,[rcx+18]
       test      rbx,rbx
       je        near ptr M06_L07
M06_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE23E94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M06_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       cmp       [rax],rcx
       jne       near ptr M06_L08
       mov       rcx,[rax+8]
       mov       r11,7FFE23D50AE0
       call      qword ptr [r11]
M06_L01:
       test      eax,eax
       jle       near ptr M06_L13
M06_L02:
       mov       rcx,rbx
       call      qword ptr [7FFE242F73F0]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M06_L14
       mov       rcx,19DF8C085E0
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M06_L16
M06_L03:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable<System.String, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M06_L17
       xor       ecx,ecx
       mov       [rdi+10],rcx
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,19DF8C01E30
       mov       rdx,[rcx]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [rbx+10],r8d
       mov       [rbx+14],r8d
       mov       rdx,rbx
       lea       r8,[rsp+28]
       mov       rcx,7FFE241399E0
       call      qword ptr [7FFE24146AD8]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
M06_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L05:
       call      CORINFO_HELP_OVERFLOW
M06_L06:
       call      qword ptr [7FFE24247678]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       test      rbx,rbx
       jne       near ptr M06_L00
M06_L07:
       call      qword ptr [7FFE242F7900]
       mov       ecx,43
       mov       rdx,7FFE242C0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24156310
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23E96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE242C0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23E96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE242F76F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE24056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L08:
       mov       rcx,rax
       mov       r11,7FFE23D50AD8
       call      qword ptr [r11]
       jmp       near ptr M06_L01
M06_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FFE23E94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M06_L10
       mov       rcx,rax
       mov       r11,7FFE23D50AD0
       call      qword ptr [r11]
       jmp       near ptr M06_L01
M06_L10:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFE23D50AC0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M06_L12
M06_L11:
       add       esi,1
       jo        near ptr M06_L05
M06_L12:
       mov       rcx,rdi
       mov       r11,7FFE23D50AC8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M06_L11
       mov       eax,esi
       test      eax,eax
       jg        near ptr M06_L02
M06_L13:
       xor       eax,eax
       jmp       near ptr M06_L04
M06_L14:
       call      qword ptr [7FFE242F7720]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L15
       call      qword ptr [7FFE242F76F0]
       mov       rbx,rax
M06_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1DE8AB20838
       mov       r8,rbx
       call      qword ptr [7FFE24056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L16:
       mov       rcx,offset MT_System.Func<System.String, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,19DF8C085D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFE23E94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19DF8C085E0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L03
M06_L17:
       mov       ecx,9
       call      qword ptr [7FFE24054F30]
       int       3
; Total bytes of code 782
```
```assembly
; System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r9
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 35
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`2<System.__Canon,System.__Canon> ByRef)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rbx,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M08_L00
       jmp       short M08_L01
M08_L00:
       mov       rcx,rdx
       mov       rdx,7FFE24705808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M08_L01:
       mov       rdx,rbx
       call      qword ptr [7FFE24724870]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`2<System.__Canon,System.__Canon> ByRef)
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 65
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M09_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M09_L01
       mov       edi,[rsi+10]
       cmp       edi,8
       jne       short M09_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE31703C98]
M09_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M09_L02
       mov       rax,[rbx+18]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M09_L03:
       cmp       edi,8
       ja        short M09_L04
       mov       ecx,edi
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M09_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE31703C90]
       jmp       short M09_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFE31703C98]
       jmp       short M09_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M09_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M09_L01
M09_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE316FB0E8]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFE31703C88]
       jmp       near ptr M09_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFE316E6918]
       mov       rcx,rax
       call      qword ptr [7FFE317095D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M09_L01
M09_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE31703CB0]
       jmp       near ptr M09_L01
; Total bytes of code 263
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
       je        near ptr M10_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M10_L02
       test      rbx,rbx
       je        short M10_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M10_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M10_L01
       call      00007FFE23E91E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE23F45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE23F45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L01:
       call      qword ptr [7FFE2402EF40]
       int       3
M10_L02:
       test      rbx,rbx
       je        short M10_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M10_L04
M10_L03:
       mov       rax,1DE8AB10008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L04:
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
; 		.OrderBy(_ => GenerateRandomNumber());
; 		              ^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       edx,7FFFFFFF
       jmp       qword ptr [7FFE242F62F8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
; Total bytes of code 13
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M12_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       call      qword ptr [7FFE23E941F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRelativeUrl()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE242BC3C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
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
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
; 		var sb = _stringBuilderPool.Get().Clear();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var length = GenerateInteger(1, 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var lengthIndex = 0; lengthIndex < length; lengthIndex++)
; 			     ^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateUrlFragment());
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = sb.Append('/');
; 			^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-0C0],rsp
       lea       rcx,[rbp-0A8]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-88],rcx
       mov       rcx,rbp
       mov       [rbp-78],rcx
       mov       rcx,25658804E00
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L24
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L24
M01_L00:
       mov       rsi,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       cmp       [rsi],sil
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE240CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-58],rsi
       xor       edx,edx
       mov       [rbp-44],edx
       lea       r14,[rbp-44]
       mov       [rbp-68],r14
M01_L02:
       mov       rdx,r14
       mov       [rbp-50],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243235A0
       mov       [rbp-98],rax
       lea       rax,[M01_L03]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A8]
       mov       [rbx+10],rax
       mov       byte ptr [rbx+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L03:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L04
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L04:
       mov       rcx,[rbp-0A0]
       mov       [rbx+10],rcx
       test      eax,eax
       jne       near ptr M01_L19
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       esi,[rbp-44]
       and       esi,0F
       cmp       esi,8
       mov       r14,[rbp-68]
       ja        near ptr M01_L02
       mov       r14d,esi
       inc       r14d
       xor       r15d,r15d
       test      r14d,r14d
       jle       near ptr M01_L12
M01_L05:
       mov       edx,19
       mov       ecx,1
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L17
       test      eax,eax
       je        near ptr M01_L20
       cmp       edx,2
       jl        near ptr M01_L18
M01_L06:
       mov       ecx,1
       call      qword ptr [7FFE242E6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242BC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L16
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M01_L16
       lea       ecx,[rbx+1]
       test      ecx,ecx
       jl        near ptr M01_L15
       call      00007FFE23E91E60
       mov       r13,rax
       cmp       [r13],r13b
       lea       r8,[r13+0C]
       mov       rcx,296EA55662C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r13+0E]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFE23F45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L07:
       test      r13,r13
       je        short M01_L11
       lea       rdx,[r13+0C]
       mov       r13d,[r13+8]
       test      r13d,r13d
       je        short M01_L11
       mov       rsi,[rbp-58]
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M01_L10
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M01_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE23F45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M01_L11
M01_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M01_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L08
M01_L10:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE240CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L11:
       add       r15d,1
       jo        short M01_L14
       cmp       r15d,r14d
       jl        near ptr M01_L05
M01_L12:
       mov       rsi,[rbp-58]
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M01_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],2F
       inc       ecx
       mov       [rsi+18],ecx
M01_L13:
       mov       rcx,rsi
       call      qword ptr [7FFE240D9518]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       near ptr M01_L23
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       call      qword ptr [7FFE2402EF40]
       int       3
M01_L16:
       mov       r13,296EA556620
       jmp       near ptr M01_L07
M01_L17:
       mov       edx,1
       cmp       edx,2
       jge       near ptr M01_L06
M01_L18:
       mov       edx,2
       jmp       near ptr M01_L06
M01_L19:
       mov       ecx,eax
       call      qword ptr [7FFE242E7408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L20:
       call      qword ptr [7FFE242EC318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L21
       call      qword ptr [7FFE242EC138]
       mov       rbx,rax
M01_L21:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,296EA561080
       mov       r8,rbx
       call      qword ptr [7FFE23F4D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rsi
       mov       edx,2F
       call      qword ptr [7FFE240CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L13
M01_L23:
       mov       rcx,rsp
       call      M01_L29
       nop
       mov       rax,[rbp-60]
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
M01_L24:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE245E5B30]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L27
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L26:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L27:
       cmp       qword ptr [r14+10],0
       jne       short M01_L28
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L26
M01_L28:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFE245E5650]
       test      eax,eax
       je        short M01_L26
       jmp       short M01_L25
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
       lea       rbp,[rbp+0E0]
       mov       rcx,25658804E00
       mov       rsi,[rcx]
       mov       r13,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r13+18],rcx
       jne       short M01_L30
       mov       r14,[rbp-58]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r13+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L34
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE240CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L31
M01_L30:
       mov       rdx,[rbp-58]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       mov       r14,[rbp-58]
       je        short M01_L34
M01_L31:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L32
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L34
M01_L32:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L33
       mov       r12,[rsi+18]
       mov       rcx,[r12+10]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE245E5B60]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L34
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFE245E5620]
       jmp       short M01_L34
M01_L33:
       add       rsi,2C
       lock dec  dword ptr [rsi]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateTempFile()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,400
       call      qword ptr [7FFE242DC3D8]; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
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
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
; 		fileLength = fileLength.ArgumentInRange(lower: 1, defaultValue: DefaultFileLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var fileName = GenerateRandomFileName();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var fakeText = GenerateWord(fileLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		File.WriteAllText(fileName, fakeText);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return fileName;
; 		^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       ebx,ecx
       mov       byte ptr [rsp+58],1
       mov       dword ptr [rsp+5C],400
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L06
M01_L00:
       test      eax,eax
       je        near ptr M01_L07
M01_L01:
       mov       esi,0A
       mov       rcx,234981A5AF0
       cmp       [rcx],ecx
       call      qword ptr [7FFE23EB7318]; System.String.Trim()
       mov       rdi,rax
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FFE23FD56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,esi
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFE242DC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       cmp       byte ptr [rsp+44],0
       jne       near ptr M01_L09
       test      rdx,rdx
       je        near ptr M01_L09
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M01_L10
       mov       rcx,[rsp+48]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+50]
       sub       eax,r8d
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        near ptr M01_L09
       add       rdx,0C
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFE23F65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       esi,[rsp+40]
       mov       [rsp+40],esi
M01_L02:
       lea       rcx,[rsp+30]
       mov       edx,2E
       call      qword ptr [7FFE246CE868]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+44],0
       jne       near ptr M01_L11
       test      rdi,rdi
       je        near ptr M01_L11
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M01_L10
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr M01_L11
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [7FFE23F65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[rdi+8]
       mov       [rsp+40],ecx
M01_L03:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE23FD5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       call      qword ptr [7FFE241A7BD0]; System.IO.Path.GetTempPath()
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE241A78B8]; System.IO.Path.Combine(System.String, System.String)
       mov       rsi,rax
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ecx,ebx
       xor       edx,edx
       test      ecx,ecx
       setg      dl
       mov       eax,edx
       test      edx,edx
       je        near ptr M01_L12
M01_L04:
       test      eax,eax
       je        near ptr M01_L13
M01_L05:
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242DC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbx,rax
       call      qword ptr [7FFE2420C000]; System.IO.File.get_UTF8NoBOM()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE2420C978]; System.IO.File.Validate(System.String, System.Text.Encoding)
       mov       rcx,rsi
       mov       r9,rdi
       mov       r8,rbx
       mov       edx,2
       call      qword ptr [7FFE2420C9A8]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.String, System.Text.Encoding)
       mov       rax,rsi
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       movzx     ecx,byte ptr [rsp+58]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rsp+58]
       call      qword ptr [7FFE23F647B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L07:
       call      qword ptr [7FFE2430C318]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L08
       call      qword ptr [7FFE2430C138]
       mov       rsi,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,234981A5AC0
       mov       r8,rsi
       call      qword ptr [7FFE23F6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE23FD5848]
       jmp       near ptr M01_L02
M01_L10:
       call      qword ptr [7FFE2404E9D0]
       int       3
M01_L11:
       lea       rcx,[rsp+30]
       mov       rdx,rdi
       call      qword ptr [7FFE23FD5848]
       jmp       near ptr M01_L03
M01_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M01_L04
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE23F647B0]
       mov       ecx,eax
       jmp       near ptr M01_L05
M01_L13:
       call      qword ptr [7FFE2430C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L14
       call      qword ptr [7FFE2430C138]
       mov       rbx,rax
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23498199BB8
       mov       r8,rbx
       call      qword ptr [7FFE23F6D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 735
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrl()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       esi,1
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ecx,19
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        near ptr M00_L04
M00_L00:
       test      eax,eax
       je        near ptr M00_L05
M00_L01:
       mov       edx,esi
       add       edx,1
       jo        near ptr M00_L03
       cmp       ecx,edx
       cmovge    edx,ecx
       mov       ecx,esi
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242DC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rdx,26C87404DE0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L07
       mov       rdi,[rcx+18]
M00_L02:
       mov       edx,[rdi+8]
       sub       edx,1
       jo        near ptr M00_L03
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L08
       mov       r9d,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       rcx,2AD19165AE8
       mov       r8,2AD19150C48
       call      qword ptr [7FFE23EB6B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,2AD19165AC0
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       call      qword ptr [7FFE242DC3C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       [rsp+20],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,7FFE24733628
       cmp       [rcx],ecx
       call      qword ptr [7FFE247444E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M00_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE23F647B0]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFE2430C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFE2430C138]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2AD19161080
       mov       r8,rbx
       call      qword ptr [7FFE23F6D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFE24267B88]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 439
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243435A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE24307408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE24746178]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EBF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L20
M02_L00:
       test      eax,eax
       je        near ptr M02_L21
M02_L01:
       mov       rcx,26C87404E00
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        short M02_L04
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       short M02_L04
M02_L02:
       mov       r14,[rbp-48]
M02_L03:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r14,r14
       je        near ptr M02_L23
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE240EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFE240EC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r14
       jmp       short M02_L06
M02_L04:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-48]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE24605B30]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M02_L24
M02_L05:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       short M02_L02
M02_L06:
       xor       r12d,r12d
       test      ebx,ebx
       jle       short M02_L10
       movzx     r15d,di
       mov       r13d,r15d
       add       r13d,1
       jo        near ptr M02_L13
M02_L07:
       movzx     edx,si
       mov       eax,r13d
       cmp       edx,eax
       jl        short M02_L11
M02_L08:
       mov       ecx,r15d
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M02_L13
       mov       edx,eax
       mov       ecx,[r14+18]
       mov       eax,ecx
       mov       r8,[r14+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M02_L12
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r14+18],ecx
M02_L09:
       add       r12d,1
       jo        short M02_L13
       cmp       r12d,ebx
       jl        short M02_L07
M02_L10:
       mov       rcx,r14
       call      qword ptr [7FFE240F9518]; System.Text.StringBuilder.ToString()
       mov       r15,rax
       mov       esi,[r15+8]
       test      esi,esi
       je        short M02_L18
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M02_L15
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L14
       jmp       short M02_L16
M02_L11:
       mov       edx,eax
       jmp       short M02_L08
M02_L12:
       mov       rcx,r14
       call      qword ptr [7FFE240EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L09
M02_L13:
       call      CORINFO_HELP_OVERFLOW
M02_L14:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE23EB73F0]
       jmp       short M02_L19
M02_L15:
       call      qword ptr [7FFE24765B00]
       test      eax,eax
       jne       short M02_L14
M02_L16:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L17
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L14
       jmp       short M02_L18
M02_L17:
       call      qword ptr [7FFE24765B00]
       test      eax,eax
       jne       short M02_L14
M02_L18:
       mov       rax,r15
M02_L19:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M02_L27
       nop
       mov       rax,[rbp-58]
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
M02_L20:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F647B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L21:
       call      qword ptr [7FFE2430C318]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L22
       call      qword ptr [7FFE2430C138]
       mov       rsi,rax
M02_L22:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2AD19159BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F6D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L23:
       call      qword ptr [7FFE2430C330]
       mov       ecx,9E8
       mov       rdx,7FFE242E0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24176308
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242E0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EB6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2430C120]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE24076670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       qword ptr [r13+10],0
       jne       short M02_L25
       xor       edx,edx
       mov       [rbp-48],rdx
       jmp       short M02_L26
M02_L25:
       lea       rdx,[rbp-48]
       mov       rcx,r15
       call      qword ptr [7FFE24605650]
       test      eax,eax
       jne       near ptr M02_L05
M02_L26:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M02_L03
M02_L27:
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
       mov       rcx,26C87404E00
       mov       rsi,[rcx]
       mov       r14,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r14+18],rcx
       jne       short M02_L28
       mov       r15,[rbp-50]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[r14+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M02_L32
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE240EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L29
M02_L28:
       mov       rdx,[rbp-50]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       r15,[rbp-50]
       je        short M02_L32
M02_L29:
       cmp       qword ptr [rsi+20],0
       jne       short M02_L30
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L32
M02_L30:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M02_L31
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE24605B60]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M02_L32
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFE24605620]
       jmp       short M02_L32
M02_L31:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M02_L32:
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
; Total bytes of code 1038
```
```assembly
; System.String.Concat(System.String, System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       test      rbx,rbx
       je        near ptr M03_L00
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M03_L00
       test      rsi,rsi
       je        near ptr M03_L01
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M03_L01
       test      rdi,rdi
       je        near ptr M03_L02
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M03_L02
       test      rbp,rbp
       je        near ptr M03_L03
       mov       r12d,[rbp+8]
       test      r12d,r12d
       je        near ptr M03_L03
       mov       eax,r14d
       mov       [rsp+30],rax
       mov       ecx,r15d
       add       rcx,rax
       mov       edx,r13d
       add       rcx,rdx
       mov       edx,r12d
       add       rcx,rdx
       cmp       rcx,7FFFFFFF
       jg        near ptr M03_L04
       call      00007FFE23EB1E60
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       r10,[rax+0C]
       mov       [rsp+20],r10
       mov       rcx,r10
       lea       rdx,[rbx+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE23F65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       mov       r8,[rsp+30]
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE23F65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    r8,r14d
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFE23F65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
       movsxd    r8,r14d
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rbp+0C]
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FFE23F65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,[rsp+28]
       mov       rax,rsi
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
M03_L00:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE23EB6B20]; System.String.Concat(System.String, System.String, System.String)
M03_L01:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE23EB6B20]; System.String.Concat(System.String, System.String, System.String)
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE23EB6B20]; System.String.Concat(System.String, System.String, System.String)
M03_L03:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE23EB6B20]; System.String.Concat(System.String, System.String, System.String)
M03_L04:
       call      qword ptr [7FFE2404EF40]
       int       3
; Total bytes of code 433
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      00007FFE23EB1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE23F65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE23F65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FFE2404EF40]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,2AD19150008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
; 		var sb = _stringBuilderPool.Get().Clear();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var length = GenerateInteger(1, 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var lengthIndex = 0; lengthIndex < length; lengthIndex++)
; 			     ^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateUrlFragment());
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = sb.Append('/');
; 			^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-0C0],rsp
       lea       rcx,[rbp-0A8]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-88],rcx
       mov       rcx,rbp
       mov       [rbp-78],rcx
       mov       rcx,26C87404E00
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M05_L24
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M05_L24
M05_L00:
       mov       rsi,[rbp-40]
M05_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       cmp       [rsi],sil
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE240EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-58],rsi
       xor       edx,edx
       mov       [rbp-44],edx
       lea       r14,[rbp-44]
       mov       [rbp-68],r14
M05_L02:
       mov       rdx,r14
       mov       [rbp-50],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243435A0
       mov       [rbp-98],rax
       lea       rax,[M05_L03]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A8]
       mov       [rbx+10],rax
       mov       byte ptr [rbx+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M05_L03:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M05_L04
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M05_L04:
       mov       rcx,[rbp-0A0]
       mov       [rbx+10],rcx
       test      eax,eax
       jne       near ptr M05_L19
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       esi,[rbp-44]
       and       esi,0F
       cmp       esi,8
       mov       r14,[rbp-68]
       ja        near ptr M05_L02
       mov       r14d,esi
       inc       r14d
       xor       r15d,r15d
       test      r14d,r14d
       jle       near ptr M05_L12
M05_L05:
       mov       edx,19
       mov       ecx,1
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M05_L17
       test      eax,eax
       je        near ptr M05_L20
       cmp       edx,2
       jl        near ptr M05_L18
M05_L06:
       mov       ecx,1
       call      qword ptr [7FFE24306988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242DC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L16
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M05_L16
       lea       ecx,[rbx+1]
       test      ecx,ecx
       jl        near ptr M05_L15
       call      00007FFE23EB1E60
       mov       r13,rax
       cmp       [r13],r13b
       lea       r8,[r13+0C]
       mov       rcx,2AD1915662C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r13+0E]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFE23F65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L07:
       test      r13,r13
       je        short M05_L11
       lea       rdx,[r13+0C]
       mov       r13d,[r13+8]
       test      r13d,r13d
       je        short M05_L11
       mov       rsi,[rbp-58]
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M05_L10
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M05_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE23F65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M05_L11
M05_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M05_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L08
M05_L10:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE240ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M05_L11:
       add       r15d,1
       jo        short M05_L14
       cmp       r15d,r14d
       jl        near ptr M05_L05
M05_L12:
       mov       rsi,[rbp-58]
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M05_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],2F
       inc       ecx
       mov       [rsi+18],ecx
M05_L13:
       mov       rcx,rsi
       call      qword ptr [7FFE240F9518]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       near ptr M05_L23
M05_L14:
       call      CORINFO_HELP_OVERFLOW
M05_L15:
       call      qword ptr [7FFE2404EF40]
       int       3
M05_L16:
       mov       r13,2AD19156620
       jmp       near ptr M05_L07
M05_L17:
       mov       edx,1
       cmp       edx,2
       jge       near ptr M05_L06
M05_L18:
       mov       edx,2
       jmp       near ptr M05_L06
M05_L19:
       mov       ecx,eax
       call      qword ptr [7FFE24307408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M05_L20:
       call      qword ptr [7FFE2430C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L21
       call      qword ptr [7FFE2430C138]
       mov       rbx,rax
M05_L21:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2AD19161080
       mov       r8,rbx
       call      qword ptr [7FFE23F6D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M05_L22:
       mov       rcx,rsi
       mov       edx,2F
       call      qword ptr [7FFE240EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L13
M05_L23:
       mov       rcx,rsp
       call      M05_L29
       nop
       mov       rax,[rbp-60]
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
M05_L24:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE24605B30]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M05_L27
M05_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M05_L00
M05_L26:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M05_L01
M05_L27:
       cmp       qword ptr [r14+10],0
       jne       short M05_L28
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M05_L26
M05_L28:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFE24605650]
       test      eax,eax
       je        short M05_L26
       jmp       short M05_L25
M05_L29:
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
       lea       rbp,[rbp+0E0]
       mov       rcx,26C87404E00
       mov       rsi,[rcx]
       mov       r13,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r13+18],rcx
       jne       short M05_L30
       mov       r14,[rbp-58]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r13+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M05_L34
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE240EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M05_L31
M05_L30:
       mov       rdx,[rbp-58]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       mov       r14,[rbp-58]
       je        short M05_L34
M05_L31:
       cmp       qword ptr [rsi+20],0
       jne       short M05_L32
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M05_L34
M05_L32:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M05_L33
       mov       r12,[rsi+18]
       mov       rcx,[r12+10]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE24605B60]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M05_L34
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFE24605620]
       jmp       short M05_L34
M05_L33:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M05_L34:
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
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M07_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M07_L01
       mov       edi,[rsi+10]
       cmp       edi,8
       jne       short M07_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE31703C98]
M07_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M07_L02
       mov       rax,[rbx+18]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M07_L03:
       cmp       edi,8
       ja        short M07_L04
       mov       ecx,edi
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M07_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE31703C90]
       jmp       short M07_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFE31703C98]
       jmp       short M07_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M07_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M07_L01
M07_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE316FB0E8]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFE31703C88]
       jmp       near ptr M07_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFE316E6918]
       mov       rcx,rax
       call      qword ptr [7FFE317095D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M07_L01
M07_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE31703CB0]
       jmp       near ptr M07_L01
; Total bytes of code 263
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlFragment()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       esi,1
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       ecx,19
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        short M00_L03
M00_L00:
       test      eax,eax
       je        short M00_L04
M00_L01:
       mov       edx,esi
       add       edx,1
       jo        short M00_L02
       cmp       ecx,edx
       cmovge    edx,ecx
       mov       ecx,esi
       call      qword ptr [7FFE242F6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242CC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       mov       rcx,22165AB6620
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
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
       call      CORINFO_HELP_OVERFLOW
M00_L03:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        short M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE23F547B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFE242FC318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFE242FC138]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22165AC1080
       mov       r8,rbx
       call      qword ptr [7FFE23F5D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 267
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243335A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE242F7408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE24736178]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EAF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L17
M02_L00:
       test      eax,eax
       je        near ptr M02_L18
M02_L01:
       mov       rcx,1E0D3C04E00
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M02_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M02_L20
M02_L02:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r15,r15
       je        near ptr M02_L22
M02_L03:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE240DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFE240DC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M02_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M02_L10
M02_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        short M02_L08
M02_L05:
       mov       ecx,r12d
       call      qword ptr [7FFE242F6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M02_L10
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M02_L09
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M02_L06:
       add       r13d,1
       jo        short M02_L10
       cmp       r13d,ebx
       jl        short M02_L04
M02_L07:
       mov       rcx,r15
       call      qword ptr [7FFE240E9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFE240DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE23EA73F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFE24755B00]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFE24755B00]
       test      eax,eax
       jne       short M02_L11
M02_L15:
       mov       rax,r14
M02_L16:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M02_L23
       nop
       mov       rax,[rbp-58]
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
M02_L17:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F547B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFE242FC318]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFE242FC138]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,22165AB9BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F5D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE245F5638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M02_L02
M02_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r15,r15
       jne       near ptr M02_L03
M02_L22:
       call      qword ptr [7FFE242FC330]
       mov       ecx,9E8
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24166308
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE242FC120]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE24066670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M02_L23:
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
       mov       rcx,1E0D3C04E00
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M02_L24
       mov       r14,[rbp-50]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L28
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE240DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L25
M02_L24:
       mov       rdx,[rbp-50]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r14,[rbp-50]
       je        short M02_L28
M02_L25:
       cmp       qword ptr [rsi+20],0
       jne       short M02_L26
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L28
M02_L26:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M02_L27
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE245F5608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L28
M02_L27:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M02_L28:
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
; Total bytes of code 985
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
       call      00007FFE23EA1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE2403EF40]
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
       mov       rax,22165AB0008
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
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostName()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       esi,1
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ecx,19
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        near ptr M00_L04
M00_L00:
       test      eax,eax
       je        near ptr M00_L05
M00_L01:
       mov       edx,esi
       add       edx,1
       jo        near ptr M00_L03
       cmp       ecx,edx
       cmovge    edx,ecx
       mov       ecx,esi
       call      qword ptr [7FFE243062F8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242C7B10]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rdx,1DE47C02DE8
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L07
       mov       rdi,[rcx+18]
M00_L02:
       mov       edx,[rdi+8]
       sub       edx,1
       jo        short M00_L03
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FFE243062F8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L08
       mov       r9d,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       rcx,21ED9BF5AE8
       mov       r8,21ED9BE0C48
       call      qword ptr [7FFE23EA6B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,21ED9BF5AC0
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M00_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE23F547B0]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFE243078E8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M00_L06
       call      qword ptr [7FFE24307708]
       mov       rdi,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,21ED9BF1080
       mov       r8,rdi
       call      qword ptr [7FFE23F5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFE24257678]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 410
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243335A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE24306D78]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE247364A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EAF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L17
M02_L00:
       test      eax,eax
       je        near ptr M02_L18
M02_L01:
       mov       rcx,1DE47C02E08
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M02_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M02_L20
M02_L02:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r15,r15
       je        near ptr M02_L22
M02_L03:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE240DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFE240DC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M02_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M02_L10
M02_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        short M02_L08
M02_L05:
       mov       ecx,r12d
       call      qword ptr [7FFE243062F8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M02_L10
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M02_L09
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M02_L06:
       add       r13d,1
       jo        short M02_L10
       cmp       r13d,ebx
       jl        short M02_L04
M02_L07:
       mov       rcx,r15
       call      qword ptr [7FFE240E9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFE240DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE23EA73F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFE24755F38]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFE24755F38]
       test      eax,eax
       jne       short M02_L11
M02_L15:
       mov       rax,r14
M02_L16:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M02_L23
       nop
       mov       rax,[rbp-58]
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
M02_L17:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F547B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFE243078E8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFE24307708]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,21ED9BE9BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F5D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE245F5638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M02_L02
M02_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r15,r15
       jne       near ptr M02_L03
M02_L22:
       call      qword ptr [7FFE24307900]
       mov       ecx,9E8
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24166620
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE243076F0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE24066670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M02_L23:
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
       mov       rcx,1DE47C02E08
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M02_L24
       mov       r14,[rbp-50]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L28
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE240DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L25
M02_L24:
       mov       rdx,[rbp-50]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r14,[rbp-50]
       je        short M02_L28
M02_L25:
       cmp       qword ptr [rsi+20],0
       jne       short M02_L26
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L28
M02_L26:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M02_L27
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE245F5608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L28
M02_L27:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M02_L28:
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
; Total bytes of code 985
```
```assembly
; System.String.Concat(System.String, System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       test      rbx,rbx
       je        near ptr M03_L00
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M03_L00
       test      rsi,rsi
       je        near ptr M03_L01
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M03_L01
       test      rdi,rdi
       je        near ptr M03_L02
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M03_L02
       test      rbp,rbp
       je        near ptr M03_L03
       mov       r12d,[rbp+8]
       test      r12d,r12d
       je        near ptr M03_L03
       mov       eax,r14d
       mov       [rsp+30],rax
       mov       ecx,r15d
       add       rcx,rax
       mov       edx,r13d
       add       rcx,rdx
       mov       edx,r12d
       add       rcx,rdx
       cmp       rcx,7FFFFFFF
       jg        near ptr M03_L04
       call      00007FFE23EA1E60
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       r10,[rax+0C]
       mov       [rsp+20],r10
       mov       rcx,r10
       lea       rdx,[rbx+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       mov       r8,[rsp+30]
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    r8,r14d
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
       movsxd    r8,r14d
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rbp+0C]
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,[rsp+28]
       mov       rax,rsi
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
M03_L00:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE23EA6B20]; System.String.Concat(System.String, System.String, System.String)
M03_L01:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE23EA6B20]; System.String.Concat(System.String, System.String, System.String)
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE23EA6B20]; System.String.Concat(System.String, System.String, System.String)
M03_L03:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE23EA6B20]; System.String.Concat(System.String, System.String, System.String)
M03_L04:
       call      qword ptr [7FFE2403EF40]
       int       3
; Total bytes of code 433
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      00007FFE23EA1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FFE2403EF40]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,21ED9BE0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M05_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M05_L01
       mov       edi,[rsi+10]
       cmp       edi,8
       jne       short M05_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE31703C98]
M05_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M05_L02
       mov       rax,[rbx+18]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L03:
       cmp       edi,8
       ja        short M05_L04
       mov       ecx,edi
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M05_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE31703C90]
       jmp       short M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFE31703C98]
       jmp       short M05_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M05_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M05_L01
M05_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE316FB0E8]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFE31703C88]
       jmp       near ptr M05_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFE316E6918]
       mov       rcx,rax
       call      qword ptr [7FFE317095D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M05_L01
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE31703CB0]
       jmp       near ptr M05_L01
; Total bytes of code 263
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoProtocol()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       esi,1
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ecx,19
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        near ptr M00_L04
M00_L00:
       test      eax,eax
       je        near ptr M00_L05
M00_L01:
       mov       edx,esi
       add       edx,1
       jo        near ptr M00_L03
       cmp       ecx,edx
       cmovge    edx,ecx
       mov       ecx,esi
       call      qword ptr [7FFE242F6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242CC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rdx,17A74404DE0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L07
       mov       rdi,[rcx+18]
M00_L02:
       mov       edx,[rdi+8]
       sub       edx,1
       jo        short M00_L03
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FFE242F6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L08
       mov       r9d,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       rcx,1BB062E5AC0
       mov       r8,1BB062D0C48
       call      qword ptr [7FFE23EA6B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M00_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE23F547B0]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFE242FC318]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M00_L06
       call      qword ptr [7FFE242FC138]
       mov       rdi,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1BB062E1080
       mov       r8,rdi
       call      qword ptr [7FFE23F5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFE24257B88]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 391
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243335A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE242F7408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE24736178]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EAF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L17
M02_L00:
       test      eax,eax
       je        near ptr M02_L18
M02_L01:
       mov       rcx,17A74404E00
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M02_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M02_L20
M02_L02:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r15,r15
       je        near ptr M02_L22
M02_L03:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE240DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFE240DC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M02_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M02_L10
M02_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        short M02_L08
M02_L05:
       mov       ecx,r12d
       call      qword ptr [7FFE242F6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M02_L10
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M02_L09
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M02_L06:
       add       r13d,1
       jo        short M02_L10
       cmp       r13d,ebx
       jl        short M02_L04
M02_L07:
       mov       rcx,r15
       call      qword ptr [7FFE240E9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFE240DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE23EA73F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFE24755B00]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFE24755B00]
       test      eax,eax
       jne       short M02_L11
M02_L15:
       mov       rax,r14
M02_L16:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M02_L23
       nop
       mov       rax,[rbp-58]
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
M02_L17:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F547B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFE242FC318]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFE242FC138]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,1BB062D9BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F5D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE245F5638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M02_L02
M02_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r15,r15
       jne       near ptr M02_L03
M02_L22:
       call      qword ptr [7FFE242FC330]
       mov       ecx,9E8
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24166308
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE242FC120]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE24066670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M02_L23:
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
       mov       rcx,17A74404E00
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M02_L24
       mov       r14,[rbp-50]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L28
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE240DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L25
M02_L24:
       mov       rdx,[rbp-50]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r14,[rbp-50]
       je        short M02_L28
M02_L25:
       cmp       qword ptr [rsi+20],0
       jne       short M02_L26
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L28
M02_L26:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M02_L27
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE245F5608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L28
M02_L27:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M02_L28:
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
; Total bytes of code 985
```
```assembly
; System.String.Concat(System.String, System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       test      rbx,rbx
       je        near ptr M03_L00
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M03_L00
       test      rsi,rsi
       je        near ptr M03_L01
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M03_L01
       test      rdi,rdi
       je        near ptr M03_L02
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M03_L02
       test      rbp,rbp
       je        near ptr M03_L03
       mov       r12d,[rbp+8]
       test      r12d,r12d
       je        near ptr M03_L03
       mov       eax,r14d
       mov       [rsp+30],rax
       mov       ecx,r15d
       add       rcx,rax
       mov       edx,r13d
       add       rcx,rdx
       mov       edx,r12d
       add       rcx,rdx
       cmp       rcx,7FFFFFFF
       jg        near ptr M03_L04
       call      00007FFE23EA1E60
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       r10,[rax+0C]
       mov       [rsp+20],r10
       mov       rcx,r10
       lea       rdx,[rbx+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       mov       r8,[rsp+30]
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    r8,r14d
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
       movsxd    r8,r14d
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rbp+0C]
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FFE23F55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,[rsp+28]
       mov       rax,rsi
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
M03_L00:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE23EA6B20]; System.String.Concat(System.String, System.String, System.String)
M03_L01:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE23EA6B20]; System.String.Concat(System.String, System.String, System.String)
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE23EA6B20]; System.String.Concat(System.String, System.String, System.String)
M03_L03:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE23EA6B20]; System.String.Concat(System.String, System.String, System.String)
M03_L04:
       call      qword ptr [7FFE2403EF40]
       int       3
; Total bytes of code 433
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M04_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M04_L01
       mov       edi,[rsi+10]
       cmp       edi,8
       jne       short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE31703C98]
M04_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M04_L02
       mov       rax,[rbx+18]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L03:
       cmp       edi,8
       ja        short M04_L04
       mov       ecx,edi
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M04_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE31703C90]
       jmp       short M04_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFE31703C98]
       jmp       short M04_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M04_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M04_L01
M04_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE316FB0E8]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFE31703C88]
       jmp       near ptr M04_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFE316E6918]
       mov       rcx,rax
       call      qword ptr [7FFE317095D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M04_L01
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE31703CB0]
       jmp       near ptr M04_L01
; Total bytes of code 263
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,1DF20C04DE0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L02
       mov       rsi,[rcx+18]
M00_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FFE243062F8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       short M00_L03
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      qword ptr [7FFE24257678]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 139
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
       jge       near ptr M01_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L06
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
M01_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243335A0
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M01_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       call      qword ptr [7FFE24306D78]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE247364A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EAF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M02_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M02_L01
       mov       edi,[rsi+10]
       cmp       edi,8
       jne       short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE31703C98]
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       mov       rax,[rbx+18]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M02_L03:
       cmp       edi,8
       ja        short M02_L04
       mov       ecx,edi
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE31703C90]
       jmp       short M02_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFE31703C98]
       jmp       short M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M02_L01
M02_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE316FB0E8]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFE31703C88]
       jmp       near ptr M02_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFE316E6918]
       mov       rcx,rax
       call      qword ptr [7FFE317095D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE31703CA0]
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE31703CB0]
       jmp       near ptr M02_L01
; Total bytes of code 263
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWord()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ecx,0A
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242CC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 90
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L17
M01_L00:
       test      eax,eax
       je        near ptr M01_L18
M01_L01:
       mov       rcx,1DBAB404E00
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L20
M01_L02:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r15,r15
       je        near ptr M01_L22
M01_L03:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE240DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFE240DC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M01_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M01_L10
M01_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        short M01_L08
M01_L05:
       mov       ecx,r12d
       call      qword ptr [7FFE242F6988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M01_L10
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M01_L09
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M01_L06:
       add       r13d,1
       jo        short M01_L10
       cmp       r13d,ebx
       jl        short M01_L04
M01_L07:
       mov       rcx,r15
       call      qword ptr [7FFE240E9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M01_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L11
       jmp       short M01_L13
M01_L08:
       mov       edx,eax
       jmp       short M01_L05
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFE240DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE23EA73F0]
       jmp       short M01_L16
M01_L12:
       call      qword ptr [7FFE24755F38]
       test      eax,eax
       jne       short M01_L11
M01_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L11
       jmp       short M01_L15
M01_L14:
       call      qword ptr [7FFE24755F38]
       test      eax,eax
       jne       short M01_L11
M01_L15:
       mov       rax,r14
M01_L16:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M01_L23
       nop
       mov       rax,[rbp-58]
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
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F547B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L18:
       call      qword ptr [7FFE242FC318]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L19
       call      qword ptr [7FFE242FC138]
       mov       rsi,rax
M01_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,21C3D479BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F5D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE245F5638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L02
M01_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r15,r15
       jne       near ptr M01_L03
M01_L22:
       call      qword ptr [7FFE242FC330]
       mov       ecx,9E8
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24166308
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242D0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EA6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE242FC120]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE24066670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
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
       mov       rcx,1DBAB404E00
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L24
       mov       r14,[rbp-50]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L28
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE240DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L25
M01_L24:
       mov       rdx,[rbp-50]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r14,[rbp-50]
       je        short M01_L28
M01_L25:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L26
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L28
M01_L26:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L27
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE245F5608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L28
M01_L27:
       add       rsi,2C
       lock dec  dword ptr [rsi]
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
; Total bytes of code 985
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWords()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       esi,0A
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       edi,5
       mov       ecx,1
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L16
M00_L00:
       test      eax,eax
       je        near ptr M00_L17
M00_L01:
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ebp,0A
       mov       ecx,1
       mov       edx,ecx
       test      ecx,ecx
       je        near ptr M00_L19
M00_L02:
       test      edx,edx
       je        near ptr M00_L20
M00_L03:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,esi
       call      qword ptr [7FFE23F7DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r15d,r15d
       test      esi,esi
       jle       near ptr M00_L14
M00_L04:
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M00_L22
       mov       eax,1
       mov       r8d,eax
       test      eax,eax
       je        near ptr M00_L23
M00_L05:
       test      r8d,r8d
       je        near ptr M00_L32
M00_L06:
       mov       edx,ebp
       test      edx,edx
       jle       near ptr M00_L24
       mov       r10d,1
       mov       r9d,r10d
       test      r10d,r10d
       je        near ptr M00_L25
M00_L07:
       test      r9d,r9d
       je        near ptr M00_L34
M00_L08:
       test      ecx,ecx
       jle       near ptr M00_L26
       mov       r11d,1
       mov       eax,r11d
       test      r11d,r11d
       je        near ptr M00_L27
M00_L09:
       test      eax,eax
       je        near ptr M00_L36
M00_L10:
       test      edx,edx
       jle       near ptr M00_L28
       mov       eax,1
       mov       r8d,eax
       test      eax,eax
       je        near ptr M00_L29
M00_L11:
       test      r8d,r8d
       je        near ptr M00_L38
       mov       r13d,ecx
       add       r13d,1
       jo        near ptr M00_L15
       cmp       edx,r13d
       jl        near ptr M00_L30
M00_L12:
       call      qword ptr [7FFE24316988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE242EC498]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L31
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       add       r15d,1
       jo        short M00_L15
       cmp       r15d,esi
       jl        near ptr M00_L04
M00_L14:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L15:
       call      CORINFO_HELP_OVERFLOW
M00_L16:
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE23F747B0]
       mov       edi,eax
       jmp       near ptr M00_L01
M00_L17:
       call      qword ptr [7FFE2431C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L18
       call      qword ptr [7FFE2431C138]
       mov       rbx,rax
M00_L18:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2A2890F1058
       mov       r8,rbx
       call      qword ptr [7FFE23F7D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L19:
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        near ptr M00_L02
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE23F747B0]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L20:
       call      qword ptr [7FFE2431C318]
       mov       r13,rax
       test      r13,r13
       jne       short M00_L21
       call      qword ptr [7FFE2431C138]
       mov       r13,rax
M00_L21:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2A2890F1080
       mov       r8,r13
       call      qword ptr [7FFE23F7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L22:
       xor       eax,eax
       mov       r8d,eax
       test      eax,eax
       jne       near ptr M00_L05
M00_L23:
       mov       ecx,1
       jmp       near ptr M00_L06
M00_L24:
       xor       r10d,r10d
       mov       r9d,r10d
       test      r10d,r10d
       jne       near ptr M00_L07
M00_L25:
       mov       edx,1
       jmp       near ptr M00_L08
M00_L26:
       xor       r11d,r11d
       mov       eax,r11d
       test      r11d,r11d
       jne       near ptr M00_L09
M00_L27:
       mov       ecx,1
       jmp       near ptr M00_L10
M00_L28:
       xor       eax,eax
       mov       r8d,eax
       test      eax,eax
       jne       near ptr M00_L11
M00_L29:
       mov       edx,1
       mov       r13d,ecx
       add       r13d,1
       jo        near ptr M00_L15
       cmp       edx,r13d
       jge       near ptr M00_L12
M00_L30:
       mov       edx,r13d
       jmp       near ptr M00_L12
M00_L31:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FFE23F7E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L13
M00_L32:
       call      qword ptr [7FFE2431C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L33
       call      qword ptr [7FFE2431C138]
       mov       rbx,rax
M00_L33:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2A2890F1058
       mov       r8,rbx
       call      qword ptr [7FFE23F7D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L34:
       call      qword ptr [7FFE2431C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L35
       call      qword ptr [7FFE2431C138]
       mov       rbx,rax
M00_L35:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2A2890F1080
       mov       r8,rbx
       call      qword ptr [7FFE23F7D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L36:
       call      qword ptr [7FFE2431C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L37
       call      qword ptr [7FFE2431C138]
       mov       rbx,rax
M00_L37:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2A2890F1058
       mov       r8,rbx
       call      qword ptr [7FFE23F7D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L38:
       call      qword ptr [7FFE2431C318]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L39
       call      qword ptr [7FFE2431C138]
       mov       rbx,rax
M00_L39:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2A2890F1080
       mov       r8,rbx
       call      qword ptr [7FFE23F7D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1120
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
       mov       rdx,7FFE24600C40
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
       call      qword ptr [7FFE2405ED48]
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
       mov       rdx,7FFE24600C30
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
       jge       near ptr M02_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M02_L06
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
M02_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE243535A0
       mov       [rbp-80],rax
       lea       rax,[M02_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFEBDAE3670
       call      rax
M02_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFE83D5E0EC],0
       je        short M02_L02
       call      qword ptr [7FFE83D4E3B8]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M02_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M02_L00
       add       eax,ebx
M02_L03:
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
M02_L04:
       call      qword ptr [7FFE24317408]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE24756C10]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23ECF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L06:
       mov       eax,ebx
       jmp       short M02_L03
; Total bytes of code 366
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M03_L17
M03_L00:
       test      eax,eax
       je        near ptr M03_L18
M03_L01:
       mov       rcx,261F7404E00
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M03_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M03_L20
M03_L02:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r15,r15
       je        near ptr M03_L22
M03_L03:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE240FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFE240FC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M03_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M03_L10
M03_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        short M03_L08
M03_L05:
       mov       ecx,r12d
       call      qword ptr [7FFE24316988]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M03_L10
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M03_L09
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M03_L06:
       add       r13d,1
       jo        short M03_L10
       cmp       r13d,ebx
       jl        short M03_L04
M03_L07:
       mov       rcx,r15
       call      qword ptr [7FFE24109518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M03_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M03_L12
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L13
M03_L08:
       mov       edx,eax
       jmp       short M03_L05
M03_L09:
       mov       rcx,r15
       call      qword ptr [7FFE240FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M03_L06
M03_L10:
       call      CORINFO_HELP_OVERFLOW
M03_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE23EC73F0]
       jmp       short M03_L16
M03_L12:
       call      qword ptr [7FFE24776388]
       test      eax,eax
       jne       short M03_L11
M03_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L14
       mov       rax,7FFE30C92E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L15
M03_L14:
       call      qword ptr [7FFE24776388]
       test      eax,eax
       jne       short M03_L11
M03_L15:
       mov       rax,r14
M03_L16:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M03_L23
       nop
       mov       rax,[rbp-58]
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
M03_L17:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE23F747B0]
       mov       ebx,eax
       jmp       near ptr M03_L01
M03_L18:
       call      qword ptr [7FFE2431C318]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M03_L19
       call      qword ptr [7FFE2431C138]
       mov       rsi,rax
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2A2890E9BB8
       mov       r8,rsi
       call      qword ptr [7FFE23F7D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE24615638]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M03_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M03_L02
M03_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r15,r15
       jne       near ptr M03_L03
M03_L22:
       call      qword ptr [7FFE2431C330]
       mov       ecx,9E8
       mov       rdx,7FFE242F0500
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE24186308
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE23EC6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE242F0500
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE23EC6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE2431C120]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE24086670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M03_L23:
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
       mov       rcx,261F7404E00
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M03_L24
       mov       r14,[rbp-50]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M03_L28
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE240FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M03_L25
M03_L24:
       mov       rdx,[rbp-50]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r14,[rbp-50]
       je        short M03_L28
M03_L25:
       cmp       qword ptr [rsi+20],0
       jne       short M03_L26
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M03_L28
M03_L26:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M03_L27
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE24615608]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M03_L28
M03_L27:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M03_L28:
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
; Total bytes of code 985
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
       mov       edx,ebp
       mov       rcx,rbx
       call      qword ptr [7FFE31704F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFE316E3D48]; CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 60
```

