## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacterMinMax()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edx,0FFFF
       xor       ecx,ecx
       call      qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6B4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7FE160]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF7F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileNameWithPath()
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
       mov       rsi,[rbx+128]
       mov       edi,0A
       mov       rcx,260A2115700
       cmp       [rcx],ecx
       call      qword ptr [7FFF2DF77318]; System.String.Trim()
       mov       rbp,rax
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,22010001DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF2E231FF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+38],rax
       test      rax,rax
       je        near ptr M00_L03
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M00_L00:
       mov       [rsp+48],r14
       mov       [rsp+50],r15d
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       byte ptr [rsp+44],0
       mov       ecx,edi
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFF2E39C4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       cmp       byte ptr [rsp+44],0
       jne       near ptr M00_L04
       test      rdx,rdx
       je        near ptr M00_L04
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M00_L05
       mov       rcx,[rsp+48]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+50]
       sub       eax,r8d
       mov       r14d,[rdx+8]
       cmp       r14d,eax
       ja        near ptr M00_L04
       add       rdx,0C
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF2E025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rsp+40]
       mov       [rsp+40],r14d
M00_L01:
       lea       rcx,[rsp+30]
       mov       edx,2E
       call      qword ptr [7FFF2E7AE5C8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+44],0
       jne       near ptr M00_L06
       test      rbp,rbp
       je        near ptr M00_L06
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M00_L05
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       mov       r15d,[rbp+8]
       cmp       r15d,edx
       ja        near ptr M00_L06
       lea       rdx,[rbp+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFF2E025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r15d,[rsp+40]
       mov       [rsp+40],r15d
M00_L02:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E095740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2E267810]; System.IO.Path.Combine(System.String, System.String)
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E7AE5E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L03:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M00_L00
M00_L04:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E095848]
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFF2E10E9D0]
       int       3
M00_L06:
       lea       rcx,[rsp+30]
       mov       rdx,rbp
       call      qword ptr [7FFF2E095848]
       jmp       short M00_L02
; Total bytes of code 495
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
       mov       ecx,ecx
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF2E8240F0]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFF2E8240F0]
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
       call      qword ptr [7FFF2DF773F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 137
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,220100005D0
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,7FFF2DEB5120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
       mov       ecx,[rax+8]
       cmp       ecx,ebp
       jbe       short M02_L01
       mov       ecx,ebp
       shl       rcx,4
       mov       r14,[rax+rcx+10]
       test      r14,r14
       je        short M02_L01
       xor       edx,edx
       mov       [rax+rcx+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M02_L22
M02_L00:
       mov       rax,r14
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
M02_L01:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M02_L14
       mov       edx,ebp
       mov       rcx,[rcx+rdx*8+10]
       test      rcx,rcx
       je        near ptr M02_L13
       mov       r14,[rcx+8]
       mov       rcx,7FFF2DEB5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFF2DEB5C38],0
       je        short M02_L02
       call      qword ptr [7FFF2DF7DC98]
       mov       ebx,eax
       jmp       short M02_L05
M02_L02:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ebx,[rax+0A3C]
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[rbx-1]
       mov       [rax+0A3C],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M02_L03
       call      qword ptr [7FFF2E7FD938]
       jmp       short M02_L04
M02_L03:
       mov       eax,ebx
       sar       eax,10
M02_L04:
       mov       ebx,eax
M02_L05:
       mov       rcx,7FFF2DEB5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFF2DEB5C2C]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M02_L10
M02_L06:
       cmp       ebx,[r14+8]
       jae       near ptr M02_L23
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M02_L07
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M02_L07:
       mov       rcx,r13
       call      System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       je        short M02_L08
       jmp       short M02_L11
M02_L08:
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M02_L09
       xor       ebx,ebx
M02_L09:
       inc       r15d
M02_L10:
       cmp       [r14+8],r15d
       jg        short M02_L06
       xor       r12d,r12d
M02_L11:
       mov       r14,r12
       test      r14,r14
       je        short M02_L13
       cmp       byte ptr [rdi+9D],0
       je        short M02_L12
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFF2E22F2E8]
M02_L12:
       mov       rax,r14
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
M02_L13:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M02_L17
M02_L14:
       test      ebx,ebx
       jne       short M02_L15
       mov       rcx,7FFF2DEB5120
       mov       edx,5C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,22010001F70
       mov       rax,[rax]
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
M02_L15:
       mov       ecx,ebx
       mov       rdx,260A21072C0
       call      qword ptr [7FFF2E347540]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M02_L17
M02_L16:
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M02_L18
M02_L17:
       cmp       ebx,400
       jl        short M02_L16
       mov       edx,ebx
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       r14,rax
M02_L18:
       cmp       byte ptr [rdi+9D],0
       je        short M02_L21
       cmp       [r14],r14b
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFF2E22F2E8]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       mov       r9d,eax
       mov       rax,[rsi+10]
       cmp       [rax+8],ebp
       jle       short M02_L19
       mov       eax,2
       jmp       short M02_L20
M02_L19:
       mov       eax,1
M02_L20:
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],eax
       call      qword ptr [7FFF2E22F300]
M02_L21:
       mov       rax,r14
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
M02_L22:
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFF2E22F2E8]
       jmp       near ptr M02_L00
M02_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 835
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M03_L17
M03_L00:
       test      eax,eax
       je        near ptr M03_L18
M03_L01:
       mov       rcx,22010004DC0
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
       call      qword ptr [7FFF2E1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFF2E1AC150]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E1B9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M03_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M03_L12
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L13
M03_L08:
       mov       edx,eax
       jmp       short M03_L05
M03_L09:
       mov       rcx,r15
       call      qword ptr [7FFF2E1AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M03_L06
M03_L10:
       call      CORINFO_HELP_OVERFLOW
M03_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF2DF773F0]
       jmp       short M03_L16
M03_L12:
       call      qword ptr [7FFF2E8240F0]
       test      eax,eax
       jne       short M03_L11
M03_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L14
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L15
M03_L14:
       call      qword ptr [7FFF2E8240F0]
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
       call      qword ptr [7FFF2E0247B0]
       mov       ebx,eax
       jmp       near ptr M03_L01
M03_L18:
       call      qword ptr [7FFF2E426298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M03_L19
       call      qword ptr [7FFF2E4260B8]
       mov       rsi,rax
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,260A2109A30
       mov       r8,rsi
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E68F9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E4262B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF2E4260A0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFF2E136670]
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
       mov       rcx,22010004DC0
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
       call      qword ptr [7FFF2E1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E68F9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 999
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
       je        short M04_L05
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
       jmp       short M04_L00
M04_L05:
       test      r8,r8
       je        short M04_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L00
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
       je        near ptr M04_L00
M04_L09:
       jmp       qword ptr [7FFF2E025B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M04_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M04_L04
; Total bytes of code 259
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
       call      qword ptr [7FFF2E095938]
       jmp       short M05_L00
M05_L02:
       call      qword ptr [7FFF2E10E9D0]
       int       3
M05_L03:
       movzx     edx,si
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFF2E8243F0]
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
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
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
       mov       rcx,22010001DE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFF2E232000]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M06_L00:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M06_L01:
       call      qword ptr [7FFF2E10E9D0]
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
       jmp       qword ptr [7FFF2E267948]; System.IO.Path.CombineInternal(System.String, System.String)
M07_L00:
       mov       ecx,1B53B
       mov       rdx,7FFF2DE24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF2E1366E8]
       int       3
M07_L01:
       mov       ecx,1B547
       mov       rdx,7FFF2DE24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF2E1366E8]
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF2E3BC4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L17
M01_L00:
       test      eax,eax
       je        near ptr M01_L18
M01_L01:
       mov       rcx,25EA7804DC0
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
       call      qword ptr [7FFF2E1CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFF2E1CC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M01_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M01_L11
M01_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        near ptr M01_L09
M01_L05:
       mov       ecx,r12d
       call      qword ptr [7FFF2E3E7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        near ptr M01_L11
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M01_L10
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M01_L06:
       add       r13d,1
       jo        short M01_L11
       cmp       r13d,ebx
       jl        short M01_L04
M01_L07:
       mov       rcx,r15
       call      qword ptr [7FFF2E1D9518]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L14
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M01_L15
M01_L08:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L13
       mov       ecx,ecx
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M01_L15
       jmp       short M01_L14
M01_L09:
       mov       edx,eax
       jmp       near ptr M01_L05
M01_L10:
       mov       rcx,r15
       call      qword ptr [7FFF2E1CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L06
M01_L11:
       call      CORINFO_HELP_OVERFLOW
M01_L12:
       call      qword ptr [7FFF2E7CE5E0]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L15
       jmp       short M01_L08
M01_L13:
       call      qword ptr [7FFF2E7CE5E0]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L15
M01_L14:
       mov       rax,rsi
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFF2DF973F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF2E0447B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L18:
       call      qword ptr [7FFF2E446298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L19
       call      qword ptr [7FFF2E4460B8]
       mov       rsi,rax
M01_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,29F394F9A30
       mov       r8,rsi
       call      qword ptr [7FFF2E04D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E6AF9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E4462B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E256430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF2E4460A0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFF2E156670]
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
       mov       rcx,25EA7804DC0
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L24
       mov       r14,[rbp-50]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L28
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFF2E1CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L25
M01_L24:
       mov       rdx,[rbp-50]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       r14,[rbp-50]
       je        short M01_L28
M01_L25:
       cmp       qword ptr [r15+20],0
       jne       short M01_L26
       lea       rcx,[r15+20]
       mov       rdx,r14
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
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E6AF9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 1010
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF2E3B7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       xor       edx,edx
       mov       r8d,0FFFF
       call      qword ptr [7FFF2E38C4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       call      qword ptr [7FFF2E0147B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFF2E416298]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFF2E4160B8]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21C3A920F48
       mov       r8,rbx
       call      qword ptr [7FFF2E01D470]
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6A4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7EE208]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF6F708]
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L17
M02_L00:
       test      eax,eax
       je        near ptr M02_L18
M02_L01:
       mov       rcx,1DBA8804DC0
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
       call      qword ptr [7FFF2E19C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFF2E19C150]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFF2E3B7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E1A9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFF2E19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF2DF673F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFF2E79E6B8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFF2E79E6B8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FFF2E0147B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFF2E416298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFF2E4160B8]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,21C3A919A30
       mov       r8,rsi
       call      qword ptr [7FFF2E01D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E67F9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E4162B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E226430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF2E4160A0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFF2E126670]
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
       mov       rcx,1DBA8804DC0
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
       call      qword ptr [7FFF2E19C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E67F9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 999
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWordMinMaxLength()
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
       test      esi,esi
       jle       near ptr M00_L10
       xor       ebp,ebp
       cmp       esi,7FFFFFFF
       setle     bpl
       mov       r8d,ebp
       test      ebp,ebp
       je        near ptr M00_L11
M00_L02:
       test      r8d,r8d
       je        near ptr M00_L12
M00_L03:
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       test      edi,edi
       jle       near ptr M00_L14
       xor       r14d,r14d
       cmp       edi,7FFFFFFF
       setle     r14b
       mov       r10d,r14d
       test      r14d,r14d
       je        near ptr M00_L15
M00_L04:
       test      r10d,r10d
       je        near ptr M00_L16
M00_L05:
       mov       edx,esi
       add       edx,1
       jo        short M00_L06
       cmp       edi,edx
       cmovge    edx,edi
       mov       ecx,esi
       call      qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFF2E39C4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
M00_L06:
       call      CORINFO_HELP_OVERFLOW
M00_L07:
       movzx     ecx,byte ptr [rsp+38]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFF2E0247B0]
       mov       edi,eax
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FFF2E426298]
       mov       rbp,rax
       test      rbp,rbp
       jne       short M00_L09
       call      qword ptr [7FFF2E4260B8]
       mov       rbp,rax
M00_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,224CDEF0F48
       mov       r8,rbp
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L10:
       xor       ebp,ebp
       mov       r8d,ebp
       test      ebp,ebp
       jne       near ptr M00_L02
M00_L11:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L02
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0247B0]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L12:
       call      qword ptr [7FFF2E426298]
       mov       r14,rax
       test      r14,r14
       jne       short M00_L13
       call      qword ptr [7FFF2E4260B8]
       mov       r14,rax
M00_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,224CDEF0F20
       mov       r8,r14
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L14:
       xor       r14d,r14d
       mov       r10d,r14d
       test      r14d,r14d
       jne       near ptr M00_L04
M00_L15:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L04
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0247B0]
       mov       edi,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFF2E426298]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L17
       call      qword ptr [7FFF2E4260B8]
       mov       rbx,rax
M00_L17:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,224CDEF0F48
       mov       r8,rbx
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 616
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6B4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7FE1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF7F708]
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L17
M02_L00:
       test      eax,eax
       je        near ptr M02_L18
M02_L01:
       mov       rcx,1E43C002DC8
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
       call      qword ptr [7FFF2E1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFF2E1AC150]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E1B9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFF2E1AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF2DF773F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFF2E7FF4B0]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFF2E7FF4B0]
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
       call      qword ptr [7FFF2E0247B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFF2E426298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFF2E4260B8]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,224CDEE9A30
       mov       r8,rsi
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E68F9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E4262B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF2E4260A0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFF2E136670]
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
       mov       rcx,1E43C002DC8
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
       call      qword ptr [7FFF2E1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E68F9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 999
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edx,7A
       mov       ecx,61
       call      qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6B4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7FE1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF7F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCoordinate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E3D7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E3D7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       edi,eax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E3D7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       [rsp+20],esi
       mov       [rsp+24],edi
       mov       [rsp+28],eax
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFF2E7BE5E0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate ByRef)
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6C4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E80E160]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF8F708]
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       vmovsd    xmm0,qword ptr [7FFF2E6E55C0]
       call      System.Math.Pow(Double, Double)
       vxorps    xmm1,xmm1,xmm1
       vmovups   [rsp+0A8],xmm1
       lea       rdx,[rsp+0A8]
       call      qword ptr [7FFF2E78E820]; System.Decimal+DecCalc.VarDecFromR8(Double, DecCalc ByRef)
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
       call      qword ptr [7FFF2E78E7F0]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+98]
       vmovups   [rsp+28],xmm0
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF2E074738]; System.Decimal.ToInt32(System.Decimal)
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
       call      qword ptr [7FFF2E78E7F0]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+78]
       vmovups   [rsp+28],xmm0
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF2E074738]; System.Decimal.ToInt32(System.Decimal)
       mov       edx,r14d
       add       edx,1
       jo        short M00_L01
       cmp       eax,edx
       cmovge    edx,eax
       mov       ecx,r14d
       call      qword ptr [7FFF2E3A7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E78E880]; System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+58]
       vmovups   [rsp+38],xmm0
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+38]
       call      qword ptr [7FFF2E78EA18]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
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
       mov       rdx,7FFF8CEC9F00
       vmulsd    xmm0,xmm0,qword ptr [rdx+rax*8]
M01_L01:
       vmovsd    xmm1,qword ptr [7FFF2E6E5CA0]
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
       mov       rax,7FFF8CECE1A0
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
       mov       rcx,7FFF8CED5C80
       mov       rdx,[rcx+rdx*8]
       mov       rcx,r10
       mov       r8,rbx
       call      qword ptr [7FFF2E78E658]
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
       mov       rdx,7FFF2DE04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF2E43DA70]
       mov       rcx,rax
       call      qword ptr [7FFF2E0C4798]
       int       3
M01_L14:
       vxorps    xmm0,xmm0,[7FFF2E6E5CB0]
       mov       esi,80000000
       jmp       near ptr M01_L00
M01_L15:
       cmp       ecx,0FFFFFFFF
       jne       short M01_L16
       vucomisd  xmm0,qword ptr [7FFF2E6E5CC0]
       jb        short M01_L17
M01_L16:
       mov       edx,ecx
       neg       edx
       cmp       edx,51
       jae       short M01_L20
       mov       r8,7FFF8CEC9F00
       vdivsd    xmm0,xmm0,[r8+rdx*8]
       jmp       near ptr M01_L01
M01_L17:
       xor       ecx,ecx
       vmovsd    xmm1,qword ptr [7FFF2E6E5CA0]
       vucomisd  xmm1,xmm0
       jbe       near ptr M01_L02
M01_L18:
       cmp       ecx,1C
       jge       near ptr M01_L02
       vmulsd    xmm0,xmm0,qword ptr [7FFF2E6E5CC8]
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
       call      qword ptr [7FFF2E78E718]
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
       mov       rdx,7FFF8CED5C80
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
       call      qword ptr [7FFF2E78E8C8]
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
       call      qword ptr [7FFF2E467468]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2E697390]
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M04_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M04_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M04_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E694E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M04_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7DE6A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF5F708]
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
       jne       near ptr M05_L26
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M05_L22
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
       jne       near ptr M05_L09
       test      edi,edi
       jl        near ptr M05_L10
M05_L04:
       test      ebp,ebp
       je        near ptr M05_L14
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
       jne       near ptr M05_L17
       jmp       near ptr M05_L19
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
       mov       ebp,1
       cmp       edi,1C
       je        near ptr M05_L24
       jmp       short M05_L12
M05_L10:
       mov       r13d,edi
       neg       r13d
       cmp       r13d,9
       jl        near ptr M05_L23
       mov       r12d,9
M05_L11:
       jmp       short M05_L13
M05_L12:
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFF2E78E760]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M05_L24
M05_L13:
       cmp       r12d,0A
       jae       near ptr M05_L41
       mov       eax,r12d
       mov       rdx,7FFF8CECE1A0
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
       jne       near ptr M05_L21
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
       je        near ptr M05_L25
       jmp       near ptr M05_L03
M05_L14:
       mov       rax,[rsp+48]
       mov       [rbx+8],rax
       mov       eax,[rsp+50]
       mov       [rbx+4],eax
M05_L15:
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
M05_L16:
       add       edi,0FFFFFFFE
M05_L17:
       test      cl,1
       jne       short M05_L18
       test      edi,edi
       jle       short M05_L18
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
       jne       short M05_L18
       mov       r8,r10
       mov       ecx,edx
       dec       edi
M05_L18:
       mov       [rbx+8],ecx
       mov       [rbx+0C],r8d
       shr       r8,20
       mov       [rbx+4],r8d
       jmp       near ptr M05_L15
M05_L19:
       cmp       edi,2
       jl        short M05_L17
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
       jne       near ptr M05_L17
       mov       r8,r10
       mov       ecx,edx
       jmp       near ptr M05_L16
M05_L20:
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
       call      qword ptr [7FFF2E78E748]
       mov       edi,eax
       jmp       near ptr M05_L04
M05_L21:
       mov       ecx,0FB09
       mov       rdx,7FFF2DE04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF2E43DA70]
       mov       rcx,rax
       call      qword ptr [7FFF2E0C4798]
       int       3
M05_L22:
       mov       rcx,offset MT_System.DivideByZeroException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF2E78E910]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M05_L23:
       mov       r12d,r13d
       jmp       near ptr M05_L11
M05_L24:
       lea       r13d,[r15+r15]
       cmp       r13d,r15d
       jb        near ptr M05_L20
       cmp       r13d,r14d
       jb        near ptr M05_L04
       ja        near ptr M05_L20
       test      byte ptr [rsp+48],1
       je        near ptr M05_L04
       jmp       near ptr M05_L20
M05_L25:
       xor       r8d,r8d
       test      r15d,r15d
       setne     r8b
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFF2E78E748]
       mov       edi,eax
       jmp       near ptr M05_L04
M05_L26:
       mov       r13d,[rsi+4]
       test      r13d,r13d
       jne       short M05_L27
       mov       r13d,[rsi+0C]
M05_L27:
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
       jne       near ptr M05_L34
       xor       ecx,ecx
       mov       [rsp+50],ecx
       lea       rcx,[rsp+3C]
       mov       rdx,r13
       call      qword ptr [7FFF2E78E6B8]
       mov       [rsp+4C],eax
       lea       rcx,[rsp+38]
       mov       rdx,r13
       call      qword ptr [7FFF2E78E6B8]
       mov       [rsp+48],eax
M05_L28:
       cmp       qword ptr [rsp+38],0
       jne       short M05_L31
       test      edi,edi
       jge       near ptr M05_L04
       mov       r12d,edi
       neg       r12d
       cmp       r12d,9
       jge       short M05_L29
       jmp       short M05_L30
M05_L29:
       mov       r12d,9
M05_L30:
       jmp       short M05_L33
M05_L31:
       mov       ebp,1
       cmp       edi,1C
       je        short M05_L32
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFF2E78E760]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       r12d,eax
       test      r12d,r12d
       jne       short M05_L33
M05_L32:
       mov       rcx,[rsp+38]
       test      rcx,rcx
       jl        near ptr M05_L20
       add       rcx,rcx
       cmp       rcx,r13
       ja        near ptr M05_L20
       jne       near ptr M05_L04
       test      byte ptr [rsp+48],1
       je        near ptr M05_L04
       jmp       near ptr M05_L20
M05_L33:
       cmp       r12d,0A
       jae       near ptr M05_L41
       mov       ecx,r12d
       mov       rdx,7FFF8CECE1A0
       mov       ecx,[rdx+rcx*4]
       mov       r14d,ecx
       add       edi,r12d
       lea       rcx,[rsp+48]
       mov       edx,r14d
       call      qword ptr [7FFF2E78E6E8]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M05_L21
       lea       rcx,[rsp+38]
       mov       edx,r14d
       call      qword ptr [7FFF2E78E700]
       lea       rcx,[rsp+38]
       mov       rdx,r13
       call      qword ptr [7FFF2E78E6B8]
       mov       edx,eax
       lea       rcx,[rsp+48]
       call      qword ptr [7FFF2E78E778]; System.Decimal+DecCalc.Add32To96(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M05_L28
       xor       r8d,r8d
       cmp       qword ptr [rsp+38],0
       setne     r8b
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFF2E78E748]
       mov       edi,eax
       jmp       near ptr M05_L04
M05_L34:
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
       call      qword ptr [7FFF2E78E6D0]
       mov       ecx,eax
       mov       [rsp+48],rcx
       xor       ecx,ecx
       mov       [rsp+50],ecx
M05_L35:
       mov       ecx,[rsp+40]
       or        rcx,[rsp+38]
       jne       short M05_L38
       test      edi,edi
       jge       near ptr M05_L04
       mov       r12d,edi
       neg       r12d
       cmp       r12d,9
       jge       short M05_L36
       jmp       short M05_L37
M05_L36:
       mov       r12d,9
M05_L37:
       jmp       near ptr M05_L40
M05_L38:
       mov       ebp,1
       cmp       edi,1C
       je        short M05_L39
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFF2E78E760]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       r12d,eax
       test      r12d,r12d
       jne       short M05_L40
M05_L39:
       cmp       dword ptr [rsp+40],0
       jl        near ptr M05_L20
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
       ja        near ptr M05_L20
       mov       ecx,[rsp+40]
       cmp       ecx,[rsp+30]
       jne       near ptr M05_L04
       mov       rcx,[rsp+38]
       cmp       rcx,[rsp+28]
       ja        near ptr M05_L20
       mov       rcx,[rsp+38]
       cmp       rcx,[rsp+28]
       jne       near ptr M05_L04
       test      byte ptr [rsp+48],1
       je        near ptr M05_L04
       jmp       near ptr M05_L20
M05_L40:
       cmp       r12d,0A
       jae       near ptr M05_L41
       mov       ecx,r12d
       mov       rdx,7FFF8CECE1A0
       mov       r14d,[rdx+rcx*4]
       add       edi,r12d
       lea       rcx,[rsp+48]
       mov       edx,r14d
       call      qword ptr [7FFF2E78E6E8]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M05_L21
       lea       rcx,[rsp+38]
       mov       edx,r14d
       call      qword ptr [7FFF2E78E6E8]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       mov       [rsp+44],eax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FFF2E78E6D0]
       mov       edx,eax
       lea       rcx,[rsp+48]
       call      qword ptr [7FFF2E78E778]; System.Decimal+DecCalc.Add32To96(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M05_L35
       mov       r8,[rsp+38]
       or        r8,[rsp+40]
       setne     r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFF2E78E748]
       mov       edi,eax
       jmp       near ptr M05_L04
M05_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1940
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       ret
; Total bytes of code 1
```
**Extern method**
System.Math.Pow(Double, Double)

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,195FB002DA0
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
       call      qword ptr [7FFF2E3B7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E317D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6A4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7EE1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF6F708]
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
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
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
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
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
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
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
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
; Total bytes of code 1841
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF2E3D7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFF2E3AC4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2F747D40ED8
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
       call      qword ptr [7FFF2E3D7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFF2E3AC4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2F747D30C48
       mov       [rsi+28],rdx
       mov       rdx,2B6B5C04D98
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
       call      qword ptr [7FFF2E3D7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[r14+8]
       jae       near ptr M00_L13
       mov       ecx,eax
       mov       rdx,[r14+rcx*8+10]
       lea       rcx,[rsi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      qword ptr [7FFF2DF86BB0]; System.String.Concat(System.String[])
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
       call      qword ptr [7FFF2E0347B0]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L07:
       call      qword ptr [7FFF2E436298]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFF2E4360B8]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2F747D40F48
       mov       r8,rbx
       call      qword ptr [7FFF2E03D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L09:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        near ptr M00_L02
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0347B0]
       mov       ecx,eax
       jmp       near ptr M00_L03
M00_L10:
       call      qword ptr [7FFF2E436298]
       mov       r14,rax
       test      r14,r14
       jne       short M00_L11
       call      qword ptr [7FFF2E4360B8]
       mov       r14,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2F747D40F48
       mov       r8,r14
       call      qword ptr [7FFF2E03D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       call      qword ptr [7FFF2E337D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6C4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E80E1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF8F708]
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L17
M02_L00:
       test      eax,eax
       je        near ptr M02_L18
M02_L01:
       mov       rcx,2B6B5C04DC0
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
       call      qword ptr [7FFF2E1BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFF2E1BC150]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFF2E3D7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E1C9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFF2E1BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF2DF873F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFF2E80F4B0]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFF2E80F4B0]
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
       call      qword ptr [7FFF2E0347B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFF2E436298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFF2E4360B8]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2F747D39A30
       mov       r8,rsi
       call      qword ptr [7FFF2E03D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E69F9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E4362B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E3B0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E246430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E3B0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF2E4360A0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFF2E146670]
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
       mov       rcx,2B6B5C04DC0
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
       call      qword ptr [7FFF2E1BC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E69F9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 999
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
       je        near ptr M03_L12
M03_L00:
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M03_L13
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
       jg        near ptr M03_L17
       mov       edi,ecx
       test      edi,edi
       je        near ptr M03_L14
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       xor       r14d,r14d
       xor       r15d,r15d
       test      esi,esi
       jle       short M03_L07
M03_L04:
       mov       r8d,r15d
       mov       rdx,[rbx+r8*8+10]
       test      rdx,rdx
       je        short M03_L05
       mov       r8d,[rdx+8]
       test      r8d,r8d
       jne       short M03_L06
M03_L05:
       inc       r15d
       cmp       esi,r15d
       jg        short M03_L04
       jmp       short M03_L07
M03_L06:
       mov       r13d,r8d
       mov       ecx,edi
       sub       ecx,r14d
       cmp       ecx,r13d
       jl        short M03_L10
       cmp       [rbp],bpl
       movsxd    rcx,r14d
       lea       rcx,[rbp+rcx*2+0C]
       add       rdx,0C
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFF2E035B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
       jmp       short M03_L05
M03_L07:
       cmp       r14d,edi
       jne       short M03_L11
M03_L08:
       mov       rax,rbp
M03_L09:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L10:
       mov       r14d,0FFFFFFFF
       cmp       r14d,edi
       je        short M03_L08
M03_L11:
       mov       rcx,rbx
       call      qword ptr [7FFF2DED4018]; System.Object.MemberwiseClone()
       mov       rbx,rax
       test      rbx,rbx
       jne       near ptr M03_L00
M03_L12:
       mov       ecx,1771
       mov       rdx,7FFF2DE34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF2E1466E8]
       int       3
M03_L13:
       test      esi,esi
       je        short M03_L15
       test      esi,esi
       je        short M03_L18
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M03_L16
M03_L14:
       mov       rax,2F747D30008
       jmp       short M03_L09
M03_L15:
       mov       rax,2F747D30008
M03_L16:
       jmp       short M03_L09
M03_L17:
       call      qword ptr [7FFF2E11EF40]
       int       3
M03_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 332
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
M04_L00:
       mov       rsi,[rbx+8]
M04_L00:
       mov       rsi,[rbx+8]
M04_L00:
       mov       rsi,[rbx+8]
M04_L00:
       mov       rsi,[rbx+8]
M04_L00:
       mov       rsi,[rbx+8]
M04_L00:
       mov       rsi,[rbx+8]
M04_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M04_L01
       je        short M04_L01
       je        short M04_L01
       je        short M04_L01
       je        short M04_L01
       je        short M04_L01
       je        short M04_L01
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
       jne       short M04_L03
       jne       short M04_L03
       jne       short M04_L03
       jne       short M04_L03
       jne       short M04_L03
       jne       short M04_L03
       jne       short M04_L03
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
M04_L01:
       cmp       qword ptr [rbx+8],0
M04_L01:
       cmp       qword ptr [rbx+8],0
M04_L01:
       cmp       qword ptr [rbx+8],0
M04_L01:
       cmp       qword ptr [rbx+8],0
M04_L01:
       cmp       qword ptr [rbx+8],0
M04_L01:
       cmp       qword ptr [rbx+8],0
M04_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M04_L02
       jne       short M04_L02
       jne       short M04_L02
       jne       short M04_L02
       jne       short M04_L02
       jne       short M04_L02
       jne       short M04_L02
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
M04_L02:
       mov       rcx,rbx
M04_L02:
       mov       rcx,rbx
M04_L02:
       mov       rcx,rbx
M04_L02:
       mov       rcx,rbx
M04_L02:
       mov       rcx,rbx
M04_L02:
       mov       rcx,rbx
M04_L02:
       mov       rcx,rbx
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
M04_L03:
       cmp       edi,8
M04_L03:
       cmp       edi,8
M04_L03:
       cmp       edi,8
M04_L03:
       cmp       edi,8
M04_L03:
       cmp       edi,8
M04_L03:
       cmp       edi,8
M04_L03:
       cmp       edi,8
       ja        short M04_L04
       ja        short M04_L04
       ja        short M04_L04
       ja        short M04_L04
       ja        short M04_L04
       ja        short M04_L04
       ja        short M04_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M04_L00]
       lea       rax,[M04_L00]
       lea       rax,[M04_L00]
       lea       rax,[M04_L00]
       lea       rax,[M04_L00]
       lea       rax,[M04_L00]
       lea       rax,[M04_L00]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
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
       je        short M04_L05
       je        short M04_L05
       je        short M04_L05
       je        short M04_L05
       je        short M04_L05
       je        short M04_L05
       je        short M04_L05
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
M04_L04:
       mov       rcx,[rsi+8]
M04_L04:
       mov       rcx,[rsi+8]
M04_L04:
       mov       rcx,[rsi+8]
M04_L04:
       mov       rcx,[rsi+8]
M04_L04:
       mov       rcx,[rsi+8]
M04_L04:
       mov       rcx,[rsi+8]
M04_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
M04_L05:
       mov       rcx,rbx
M04_L05:
       mov       rcx,rbx
M04_L05:
       mov       rcx,rbx
M04_L05:
       mov       rcx,rbx
M04_L05:
       mov       rcx,rbx
M04_L05:
       mov       rcx,rbx
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
; Total bytes of code 1841
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rbp,1CF4C79570C
       mov       rcx,rbp
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],0D
       lea       rcx,[rsp+40]
       call      qword ptr [7FFF2E257618]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
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
       mov       rcx,1CF4C7887F4
       mov       [rsp+40],rsi
       mov       [rsp+48],edi
       mov       [rsp+30],rcx
       mov       dword ptr [rsp+38],1
       mov       [rsp+20],rbp
       mov       dword ptr [rsp+28],0D
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       call      qword ptr [7FFF2DF66B68]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
       jmp       short M00_L03
M00_L02:
       mov       [rsp+40],rsi
       mov       [rsp+48],edi
       mov       [rsp+30],rbp
       mov       dword ptr [rsp+38],0D
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       call      qword ptr [7FFF2DF66B50]
       mov       rcx,rax
M00_L03:
       mov       edx,400
       call      qword ptr [7FFF2E3877E0]; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
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
       mov       ecx,1B53B
       mov       rdx,7FFF2DE14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF2E1266E8]
       int       3
M00_L05:
       mov       rcx,1CF4C795700
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
       call      System.String.FastAllocateString(Int32)
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
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,ebp
       lea       rcx,[r12+r8*2]
       mov       r8d,r14d
       sub       r8d,ebp
       cmp       esi,r8d
       ja        short M02_L02
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1CF4C780008
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
       call      qword ptr [7FFF2E0FE9E8]
       int       3
; Total bytes of code 240
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
       mov       [rsp+48],edx
       mov       rbx,rcx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M03_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M03_L01
       jmp       short M03_L01
M03_L00:
       xor       edx,edx
M03_L01:
       test      edx,edx
       je        short M03_L04
       cmp       [rcx],ecx
       call      qword ptr [7FFF2DF67318]; System.String.Trim()
       mov       rbx,rax
       mov       eax,[rsp+48]
       mov       byte ptr [rsp+20],1
       mov       dword ptr [rsp+24],1
       test      eax,eax
       jle       near ptr M03_L06
       xor       esi,esi
       cmp       eax,7FFFFFFF
       setle     sil
       mov       r8d,esi
       test      esi,esi
       je        short M03_L07
M03_L02:
       test      r8d,r8d
       je        near ptr M03_L08
M03_L03:
       mov       [rsp+48],eax
       lea       rdx,[rsp+48]
       mov       rcx,rbx
       call      qword ptr [7FFF2E3876A8]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32 ByRef)
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L04:
       call      qword ptr [7FFF2E415AB8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M03_L05
       call      qword ptr [7FFF2E415800]
       mov       rsi,rax
M03_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1CF4C795730
       mov       r8,rsi
       call      qword ptr [7FFF2E126670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       xor       esi,esi
       mov       r8d,esi
       test      esi,esi
       jne       short M03_L02
M03_L07:
       movzx     ecx,byte ptr [rsp+20]
       test      cl,cl
       je        short M03_L02
       lea       rcx,[rsp+20]
       call      qword ptr [7FFF2E0147B0]
       jmp       near ptr M03_L03
M03_L08:
       call      qword ptr [7FFF2E4159F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L09
       call      qword ptr [7FFF2E415818]
       mov       rbx,rax
M03_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1CF4C795758
       mov       r8,rbx
       call      qword ptr [7FFF2E01D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 326
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF2E38C1F8]; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
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
       sub       rsp,148
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       vmovdqa   xmmword ptr [rsp+rax+160],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rsp+140],rax
       mov       [rsp+1A0],r8d
       mov       rbx,rcx
       mov       esi,edx
       test      rbx,rbx
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rbx+8],0
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       dword ptr [rbx+8],0
       jne       short M01_L02
       jmp       short M01_L02
M01_L01:
       xor       ecx,ecx
M01_L02:
       test      ecx,ecx
       je        near ptr M01_L33
       cmp       dword ptr [rbx+8],0
       je        short M01_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L03
       mov       ecx,ecx
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L35
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFF2E817C00]
       test      eax,eax
       jne       near ptr M01_L35
M01_L04:
       mov       ecx,[rbx+8]
       dec       ecx
       cmp       ecx,[rbx+8]
       jae       near ptr M01_L74
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       ecx,ecx
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L35
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF2E817C00]
       test      eax,eax
       jne       near ptr M01_L35
M01_L06:
       mov       byte ptr [rsp+140],1
       mov       dword ptr [rsp+144],1
       xor       ecx,ecx
       xor       eax,eax
       cmp       esi,7FFFFFFF
       setle     al
       test      esi,esi
       cmovg     ecx,eax
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L36
M01_L07:
       test      eax,eax
       je        near ptr M01_L37
M01_L08:
       mov       edx,[rsp+1A0]
       mov       byte ptr [rsp+140],1
       mov       dword ptr [rsp+144],1
       xor       ecx,ecx
       xor       eax,eax
       cmp       edx,7FFFFFFF
       setle     al
       test      edx,edx
       cmovg     ecx,eax
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L39
M01_L09:
       test      eax,eax
       je        near ptr M01_L40
M01_L10:
       mov       [rsp+1A0],edx
       test      rbx,rbx
       je        near ptr M01_L43
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L43
       mov       rcx,rbx
       call      qword ptr [7FFF2E257AE0]; System.IO.Path.GetFullPath(System.String)
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFF2E2DE9B8]; System.IO.FileSystem.CreateDirectory(System.String, Byte[])
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+28],0FFFFFFFF
       lea       rcx,[rbp+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       cmove     rdi,rbx
       xor       ecx,ecx
       mov       [rbp+18],rcx
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+54],1
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       jl        near ptr M01_L42
       test      esi,esi
       je        near ptr M01_L44
       movsxd    rdx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L11:
       xor       ebp,ebp
       test      esi,esi
       jle       near ptr M01_L21
M01_L12:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+118],ymm0
       vmovdqu   xmmword ptr [rsp+130],xmm0
       mov       r14d,0A
       mov       r15,1E4F6DC5730
       xor       ecx,ecx
       mov       [rsp+118],rcx
       mov       rcx,1A465001DE8
       mov       r13,[rcx]
       mov       rcx,r13
       mov       edx,100
       call      qword ptr [7FFF2E221FF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+120],rax
       test      rax,rax
       je        near ptr M01_L45
       lea       r12,[rax+10]
       mov       eax,[rax+8]
M01_L13:
       mov       [rsp+130],r12
       mov       [rsp+138],eax
       xor       ecx,ecx
       mov       [rsp+128],ecx
       mov       byte ptr [rsp+12C],0
       mov       ecx,r14d
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFF2E38C4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r14,rax
       cmp       byte ptr [rsp+12C],0
       jne       near ptr M01_L46
       test      r14,r14
       je        near ptr M01_L46
       mov       r8d,[rsp+128]
       cmp       r8d,[rsp+138]
       ja        near ptr M01_L72
       mov       rcx,[rsp+130]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+138]
       sub       edx,r8d
       cmp       [r14+8],edx
       ja        near ptr M01_L46
       lea       rdx,[r14+0C]
       mov       r8d,[r14+8]
       add       r8,r8
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+128]
       add       ecx,[r14+8]
       mov       [rsp+128],ecx
M01_L14:
       lea       rcx,[rsp+118]
       mov       edx,2E
       call      qword ptr [7FFF2E79E520]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+12C],0
       jne       near ptr M01_L47
       test      r15,r15
       je        near ptr M01_L47
       mov       r8d,[rsp+128]
       cmp       r8d,[rsp+138]
       ja        near ptr M01_L72
       mov       rcx,[rsp+130]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+138]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M01_L47
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+128]
       add       ecx,[r15+8]
       mov       [rsp+128],ecx
M01_L15:
       mov       ecx,[rsp+128]
       cmp       ecx,[rsp+138]
       ja        near ptr M01_L72
       mov       rax,[rsp+130]
       mov       [rsp+90],rax
       mov       [rsp+98],ecx
       lea       rcx,[rsp+90]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r15,[rsp+120]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+118],ymm0
       vmovdqu   xmmword ptr [rsp+130],xmm0
       test      r15,r15
       je        near ptr M01_L18
       mov       ecx,[r15+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFF2DEA5120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M01_L48
M01_L16:
       xor       eax,eax
       mov       dword ptr [rsp+110],1
       cmp       [rcx+8],r14d
       jbe       short M01_L17
       mov       dword ptr [rsp+114],1
       mov       edx,10
       shlx      edx,edx,r14d
       cmp       [r15+8],edx
       jne       near ptr M01_L70
       cmp       r14d,[rcx+8]
       jae       near ptr M01_L74
       mov       edx,r14d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rsp+68],r10
       mov       r9,[r10]
       mov       [rsp+60],r9
       mov       rcx,r10
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       r10,[rsp+68]
       mov       [r10+8],ecx
       mov       rax,[rsp+60]
       test      rax,rax
       mov       [rsp+60],rax
       mov       eax,[rsp+114]
       jne       near ptr M01_L49
M01_L17:
       mov       rcx,1A4650005D0
       mov       rdx,[rcx]
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M01_L61
M01_L18:
       test      r12,r12
       je        near ptr M01_L71
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L66
       mov       r13d,[r12+8]
       test      r13d,r13d
       jne       near ptr M01_L22
       mov       r15,rbx
M01_L19:
       lea       rdx,[rsp+1A0]
       mov       rcx,r15
       call      qword ptr [7FFF2E38C090]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32 ByRef)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L68
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       cmp       edx,[rcx+8]
       jae       near ptr M01_L74
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L20:
       add       ebp,1
       jo        near ptr M01_L32
       cmp       ebp,esi
       jl        near ptr M01_L12
M01_L21:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E4F6DC0638
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.List`1<System.String>, System.Collections.Generic.List`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1E4F6DB0008
       call      qword ptr [7FFF2E67EA48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       test      rax,rax
       je        near ptr M01_L69
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,148
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
       lea       rcx,[r12+0C]
       mov       eax,r13d
       mov       edx,eax
       test      edx,edx
       jle       short M01_L23
       test      edx,edx
       je        near ptr M01_L74
       movzx     edx,word ptr [rcx]
       cmp       edx,5C
       je        near ptr M01_L66
       cmp       edx,2F
       je        near ptr M01_L66
M01_L23:
       cmp       eax,2
       jl        short M01_L24
       test      eax,eax
       je        near ptr M01_L74
       movzx     edx,word ptr [rcx]
       or        edx,20
       add       edx,0FFFFFF9F
       cmp       edx,19
       ja        short M01_L24
       cmp       eax,1
       jbe       near ptr M01_L74
       cmp       word ptr [rcx+2],3A
       je        near ptr M01_L66
M01_L24:
       lea       r15,[rbx+0C]
       mov       r14d,[rbx+8]
       add       r12,0C
       lea       ecx,[r14-1]
       cmp       ecx,r14d
       jae       near ptr M01_L74
       movzx     ecx,word ptr [r15+rcx*2]
       cmp       ecx,5C
       je        short M01_L28
       cmp       ecx,2F
       je        short M01_L28
       test      r13d,r13d
       je        near ptr M01_L74
       movzx     ecx,word ptr [r12]
       cmp       ecx,5C
       je        short M01_L27
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M01_L25:
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L30
       mov       rax,1E4F6DB87F4
       mov       [rsp+40],rax
       mov       ecx,r14d
       add       ecx,1
       jo        near ptr M01_L32
       add       ecx,r13d
       jo        near ptr M01_L32
       test      ecx,ecx
       jne       short M01_L29
       mov       r15,1E4F6DB0008
M01_L26:
       jmp       near ptr M01_L19
M01_L27:
       mov       ecx,1
       jmp       short M01_L25
M01_L28:
       mov       ecx,1
       jmp       short M01_L25
M01_L29:
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+48],rax
       lea       r10,[rax+0C]
       mov       r9d,[rax+8]
       mov       rcx,r10
       mov       r10d,r9d
       mov       [rsp+0A4],r10d
       cmp       r14d,r10d
       ja        near ptr M01_L73
       mov       r8d,r14d
       add       r8,r8
       mov       [rsp+38],rcx
       mov       rdx,r15
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,r14d
       mov       r15,[rsp+38]
       lea       r15,[r15+r8*2]
       mov       r10d,[rsp+0A4]
       sub       r10d,r14d
       mov       r14d,r10d
       cmp       r14d,1
       jb        near ptr M01_L73
       mov       rcx,[rsp+40]
       movzx     r8d,word ptr [rcx]
       mov       [r15],r8w
       add       r15,2
       mov       r8d,r14d
       sub       r8d,1
       mov       rcx,r15
       cmp       r13d,r8d
       ja        near ptr M01_L73
       mov       r8d,r13d
       add       r8,r8
       mov       rdx,r12
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r15,[rsp+48]
       jmp       near ptr M01_L26
M01_L30:
       mov       [rsp+0D8],r15
       mov       [rsp+0E0],r14d
       mov       [rsp+0C8],r12
       mov       [rsp+0D0],r13d
       mov       ecx,[rsp+0E0]
       add       ecx,[rsp+0D0]
       jo        near ptr M01_L32
       test      ecx,ecx
       je        near ptr M01_L67
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       lea       rdx,[r15+0C]
       mov       ecx,[r15+8]
       mov       [rsp+0B8],rdx
       mov       [rsp+0C0],ecx
       vmovdqu   xmm0,xmmword ptr [rsp+0B8]
       vmovdqu   xmmword ptr [rsp+80],xmm0
       lea       rdx,[rsp+80]
       lea       rcx,[rsp+0D8]
       call      qword ptr [7FFF2E01C1B0]
       lea       rcx,[rsp+0B8]
       lea       rdx,[rsp+0A8]
       mov       r8d,[rsp+0E0]
       call      qword ptr [7FFF2E01FE58]
       vmovdqu   xmm0,xmmword ptr [rsp+0A8]
       vmovdqu   xmmword ptr [rsp+80],xmm0
       lea       rdx,[rsp+80]
       lea       rcx,[rsp+0C8]
       call      qword ptr [7FFF2E01C1B0]
M01_L31:
       jmp       near ptr M01_L26
M01_L32:
       call      CORINFO_HELP_OVERFLOW
M01_L33:
       call      qword ptr [7FFF2E416358]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L34
       call      qword ptr [7FFF2E4160A0]
       mov       rbx,rax
M01_L34:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,1E4F6DB9668
       mov       r8,rbx
       call      qword ptr [7FFF2E126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L35:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF2DF673F0]
       mov       rbx,rax
       jmp       near ptr M01_L06
M01_L36:
       movzx     ecx,byte ptr [rsp+140]
       test      cl,cl
       je        near ptr M01_L07
       lea       rcx,[rsp+140]
       call      qword ptr [7FFF2E0147B0]
       mov       esi,eax
       jmp       near ptr M01_L08
M01_L37:
       call      qword ptr [7FFF2E416298]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L38
       call      qword ptr [7FFF2E4160B8]
       mov       rbx,rax
M01_L38:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,1E4F6DB4368
       mov       r8,rbx
       call      qword ptr [7FFF2E01D470]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L39:
       movzx     ecx,byte ptr [rsp+140]
       test      cl,cl
       je        near ptr M01_L09
       lea       rcx,[rsp+140]
       call      qword ptr [7FFF2E0147B0]
       mov       edx,eax
       jmp       near ptr M01_L10
M01_L40:
       call      qword ptr [7FFF2E416298]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L41
       call      qword ptr [7FFF2E4160B8]
       mov       rbx,rax
M01_L41:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1E4F6DC5700
       mov       r8,rbx
       call      qword ptr [7FFF2E01D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L42:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFF2E0FED48]
       int       3
M01_L43:
       mov       ecx,19CCD
       mov       rdx,7FFF2DE14000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF6F810]
       int       3
M01_L44:
       mov       rcx,1A465001D90
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L11
M01_L45:
       xor       r12d,r12d
       xor       eax,eax
       jmp       near ptr M01_L13
M01_L46:
       lea       rcx,[rsp+118]
       mov       rdx,r14
       call      qword ptr [7FFF2E085848]
       jmp       near ptr M01_L14
M01_L47:
       lea       rcx,[rsp+118]
       mov       rdx,r15
       call      qword ptr [7FFF2E085848]
       jmp       near ptr M01_L15
M01_L48:
       mov       rcx,r13
       call      qword ptr [7FFF2E21E910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M01_L16
M01_L49:
       mov       rcx,[r13+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M01_L74
       mov       edx,r14d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rsp+114],eax
       jne       short M01_L50
       mov       rcx,r13
       mov       edx,r14d
       call      qword ptr [7FFF2E21E898]
       mov       r10,rax
M01_L50:
       mov       rdx,[r10+8]
       mov       [rsp+58],rdx
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+0F4],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+0F4]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L51
       call      qword ptr [7FFF2E79EA30]
       mov       edx,eax
       mov       [rsp+0F8],edx
       jmp       short M01_L52
M01_L51:
       mov       edx,ecx
       sar       edx,10
       mov       [rsp+0F8],edx
M01_L52:
       mov       rcx,7FFF2DEA5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+0F8]
       xor       edx,edx
       div       dword ptr [7FFF2DEA5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L59
M01_L53:
       cmp       eax,[r8+8]
       jae       near ptr M01_L74
       mov       [rsp+100],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+50],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+0F0],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+50]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+0EC],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L55
       test      r10d,r10d
       jne       short M01_L56
       xor       edx,edx
       mov       [rax+14],edx
M01_L54:
       movsxd    rdx,r10d
       mov       r8,[rsp+60]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+0EC]
       inc       ecx
       mov       rax,[rsp+50]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+0F0],1
M01_L55:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+0F0]
       test      ecx,ecx
       je        short M01_L57
       mov       r8d,1
       jmp       short M01_L60
M01_L56:
       jmp       short M01_L54
M01_L57:
       mov       eax,[rsp+100]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+58]
       cmp       [rcx+8],r8d
       jne       short M01_L58
       xor       r8d,r8d
M01_L58:
       mov       edx,[rsp+0FC]
       inc       edx
       mov       eax,r8d
M01_L59:
       mov       r8,[rsp+58]
       mov       [rsp+0FC],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L53
       xor       r8d,r8d
M01_L60:
       mov       eax,r8d
       mov       [rsp+110],eax
       mov       eax,[rsp+114]
       jmp       near ptr M01_L17
M01_L61:
       mov       r8,rdx
       mov       edx,eax
       mov       eax,[rsp+110]
       cmp       dword ptr [r15+8],0
       mov       [rsp+114],edx
       mov       [rsp+78],r8
       mov       [rsp+110],eax
       je        near ptr M01_L18
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+10C],eax
       mov       edx,[r15+8]
       mov       [rsp+108],edx
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+78]
       mov       r8d,[rsp+10C]
       mov       r9d,[rsp+108]
       mov       edx,3
       call      qword ptr [7FFF2E017678]
       mov       eax,[rsp+114]
       test      [rsp+110],eax
       mov       [rsp+114],eax
       jne       near ptr M01_L18
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[r15+8]
       mov       rdx,[rsp+78]
       mov       [rsp+70],rdx
       mov       [rsp+104],eax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[rsp+114]
       test      r13d,r13d
       jne       short M01_L62
       mov       r14,[rsp+70]
       mov       edx,[rsp+104]
       mov       ecx,0FFFFFFFF
       jmp       short M01_L63
M01_L62:
       mov       rdx,[rsp+70]
       mov       ecx,[rsp+104]
       mov       r8d,ecx
       mov       ecx,r14d
       mov       r14,rdx
       mov       edx,r8d
M01_L63:
       mov       r8d,r15d
       mov       r9d,eax
       test      r13d,r13d
       jne       short M01_L64
       mov       eax,1
       jmp       short M01_L65
M01_L64:
       xor       eax,eax
M01_L65:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFF2E21F360]
       jmp       near ptr M01_L18
M01_L66:
       mov       r15,r12
       jmp       near ptr M01_L19
M01_L67:
       mov       r15,1E4F6DB0008
       jmp       near ptr M01_L31
M01_L68:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFF2E01E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L20
M01_L69:
       mov       ecx,14
       call      qword ptr [7FFF2E0FED00]
       int       3
M01_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E474AE0]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFF2DE14000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2DF6F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L71:
       mov       ecx,1B547
       mov       rdx,7FFF2DE14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF2E1266E8]
       int       3
M01_L72:
       call      qword ptr [7FFF2E0FE9D0]
       int       3
M01_L73:
       call      qword ptr [7FFF2E0FE9E8]
       int       3
M01_L74:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3440
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateInteger()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6B4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7FE160]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF7F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFF2E6BCC60]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
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
       call      qword ptr [7FFF2E027360]; System.Guid.NewGuid()
       mov       r8,1CC68400428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,20CFA2B4F80
       call      qword ptr [7FFF2E027180]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateNumber()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       call      qword ptr [7FFF2E3A7888]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L33
M01_L01:
       test      eax,eax
       je        near ptr M01_L34
M01_L02:
       mov       rcx,22EE0C02DC8
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L36
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L36
M01_L03:
       mov       r14,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r14,r14
       je        near ptr M01_L38
M01_L04:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFF2E1BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFF2E1BC150]; System.Text.StringBuilder.set_Capacity(Int32)
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0D8],rax
       lea       rax,[M01_L07]
       mov       [rbp-0C0],rax
       lea       rax,[rbp-0E8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L07:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L08
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L08:
       mov       rcx,[rbp-0E0]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L25
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
       ja        near ptr M01_L26
       mov       ecx,r10d
       lea       r13,[rdx+rcx*2+10]
       mov       r12d,[rax]
       test      r12d,r12d
       jl        near ptr M01_L18
       mov       eax,r12d
       mov       ecx,r12d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFF8CEC87F0
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
       mov       rdx,22EE4C00290
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
       mov       rdx,22EE4C00290
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
M01_L15:
       test      eax,eax
       je        near ptr M01_L24
       mov       ecx,[rbp-68]
       add       [r14+18],ecx
M01_L16:
       add       r15d,1
       jo        near ptr M01_L27
       cmp       r15d,ebx
       jl        near ptr M01_L05
M01_L17:
       mov       r14,[rbp-98]
       mov       rcx,r14
       call      qword ptr [7FFF2E1C9518]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L30
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L21
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L28
       jmp       short M01_L22
M01_L18:
       call      qword ptr [7FFF2E0AF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L19
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L20
M01_L19:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L20:
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
       call      qword ptr [7FFF2E805278]
       jmp       near ptr M01_L15
M01_L21:
       call      qword ptr [7FFF2E80F4B0]
       test      eax,eax
       jne       short M01_L28
M01_L22:
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       short M01_L23
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L29
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M01_L28
       jmp       short M01_L30
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L24:
       mov       ecx,[rbp-5C]
       call      qword ptr [7FFF2E0CFC90]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF2E1BC2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L16
M01_L25:
       mov       r14,[rbp-98]
       mov       ecx,eax
       call      qword ptr [7FFF2E6C4D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L26:
       call      qword ptr [7FFF2E11E9D0]
       int       3
M01_L27:
       call      CORINFO_HELP_OVERFLOW
M01_L28:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFF2DF873F0]
       mov       rsi,rax
       jmp       short M01_L30
M01_L29:
       call      qword ptr [7FFF2E80F4B0]
       test      eax,eax
       jne       short M01_L28
M01_L30:
       mov       [rbp-0A0],rsi
       mov       rcx,rsp
       call      M01_L39
       jmp       short M01_L32
M01_L31:
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
M01_L32:
       mov       rsi,[rbp-0A0]
       mov       rax,rsi
       jmp       short M01_L31
M01_L33:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L01
       lea       rcx,[rbp-40]
       call      qword ptr [7FFF2E0347B0]
       mov       ebx,eax
       jmp       near ptr M01_L02
M01_L34:
       call      qword ptr [7FFF2E4359F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L35
       call      qword ptr [7FFF2E435818]
       mov       rsi,rax
M01_L35:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,26F72BF9A30
       mov       r8,rsi
       call      qword ptr [7FFF2E03D470]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E69F6C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L37
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L03
M01_L37:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r14,r14
       jne       near ptr M01_L04
M01_L38:
       call      qword ptr [7FFF2E435A10]
       mov       ecx,9BA
       mov       rdx,7FFF2E3B0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E246438
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E3B0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E435800]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E146670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L39:
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
       mov       rcx,22EE0C02DC8
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M01_L40
       mov       rcx,[rbp-98]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rdi+8]
       cmp       edx,[rax+0C]
       jg        short M01_L44
       xor       edx,edx
       call      qword ptr [7FFF2E1BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L41
M01_L40:
       mov       r14,[rbp-98]
       mov       rdx,r14
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M01_L44
M01_L41:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L42
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-98]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L44
M01_L42:
       mov       r14,[rbp-98]
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L43
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E69F690]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L44
M01_L43:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L44:
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
; Total bytes of code 1629
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],0EB
       mov       rdx,rax
       mov       rcx,1F608115730
       cmp       [rcx],ecx
       call      qword ptr [7FFF2DEAA770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M00_L00
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryRepository+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0EB
       mov       ecx,[rsi+8]
       mov       [rsi+8],ecx
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF2E3B62C8]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       mov       rbp,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF2E79A658
       mov       [rdi+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, System.Func`2<DotNetTips.Spargine.Core.Data.Models.Country,Boolean>, Boolean ByRef)
       call      qword ptr [7FFF2E764F00]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       ecx,[rax+0B8]
       call      qword ptr [7FFF2E38C270]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
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
       call      qword ptr [7FFF2E416160]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFF2E4160B8]
       mov       rbx,rax
M00_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1F608115700
       mov       r8,rbx
       call      qword ptr [7FFF2E01D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 307
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
       je        near ptr M01_L47
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
       je        near ptr M01_L49
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
       jne       near ptr M01_L48
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
       je        near ptr M01_L49
       mov       rax,1B5760000A0
       mov       rbp,[rax]
       call      System.Enum.InternalGetCorElementType(System.Runtime.CompilerServices.MethodTable*)
       cmp       eax,1A
       jae       near ptr M01_L64
       mov       ecx,eax
       mov       rcx,[rbp+rcx*8+10]
       mov       rdi,rcx
M01_L08:
       mov       rcx,1F608100020
       cmp       rdi,rcx
       je        near ptr M01_L50
       mov       rcx,rdi
       call      qword ptr [7FFF2DEB6070]; System.Type.IsIntegerType(System.Type)
       test      eax,eax
       je        near ptr M01_L52
       mov       rcx,1B5760000A0
       mov       rbp,[rcx]
       mov       rcx,[rbx+18]
       call      System.Enum.InternalGetCorElementType(System.Runtime.CompilerServices.MethodTable*)
       cmp       eax,1A
       jae       near ptr M01_L64
       mov       ecx,eax
       mov       rbp,[rbp+rcx*8+10]
       cmp       rbp,rdi
       jne       near ptr M01_L53
       test      rbp,rbp
       je        near ptr M01_L23
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L19
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L19
M01_L09:
       mov       edi,[rax+90]
       test      edi,edi
       je        near ptr M01_L24
M01_L10:
       add       edi,0FFFFFFFC
       cmp       edi,5
       jne       near ptr M01_L22
       mov       rdx,offset MT_System.Int32
       cmp       [rsi],rdx
       je        short M01_L11
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int32
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
M01_L11:
       mov       r14d,[rsi+8]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L20
       mov       rcx,[rcx]
M01_L12:
       test      rcx,rcx
       je        short M01_L15
       mov       rax,[rcx+78]
M01_L13:
       test      rax,rax
       je        short M01_L14
       mov       rcx,offset MT_System.Enum+EnumInfo`1[[System.UInt32, System.Private.CoreLib]]
       cmp       [rax],rcx
       je        short M01_L17
M01_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF2E25CFF0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|7_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       short M01_L17
M01_L15:
       xor       eax,eax
       jmp       short M01_L13
M01_L16:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L17:
       mov       r15,[rax+8]
       cmp       byte ptr [rax+19],0
       je        near ptr M01_L54
       mov       eax,r14d
       mov       edx,[r15+8]
       cmp       rdx,rax
       seta      al
       movzx     eax,al
M01_L18:
       jmp       short M01_L16
M01_L19:
       mov       rcx,rbp
       call      qword ptr [7FFF2DEB6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L09
M01_L20:
       xor       ecx,ecx
       jmp       short M01_L12
       mov       rcx,offset MT_System.Char
       cmp       [rsi],rcx
       je        short M01_L21
       mov       rdx,rsi
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
M01_L21:
       movzx     edx,word ptr [rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FFF2E8163D0]
       jmp       short M01_L16
M01_L22:
       cmp       edi,0A
       ja        near ptr M01_L59
       mov       edx,edi
       lea       rcx,[7FFF2E6F72E8]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M01_L00]
       add       rcx,rax
       jmp       rcx
M01_L23:
       xor       edi,edi
       jmp       near ptr M01_L10
M01_L24:
       mov       rdi,rbp
       mov       rcx,rdi
       call      qword ptr [7FFF2DEB6AA8]; System.RuntimeType.get_IsActualEnum()
       test      eax,eax
       jne       near ptr M01_L28
M01_L25:
       mov       rcx,1F608106498
       cmp       rdi,rcx
       je        near ptr M01_L43
       mov       rcx,1F608104198
       cmp       rdi,rcx
       je        near ptr M01_L31
       mov       rcx,1F6081064C0
       cmp       rdi,rcx
       je        near ptr M01_L42
       mov       rcx,1F608104038
       cmp       rdi,rcx
       je        near ptr M01_L39
       mov       rcx,1F608104248
       cmp       rdi,rcx
       je        near ptr M01_L30
       mov       rcx,1F608103F48
       cmp       rdi,rcx
       je        near ptr M01_L32
       mov       rcx,1F6081064E8
       cmp       rdi,rcx
       je        near ptr M01_L38
       mov       rcx,1F608103D90
       cmp       rdi,rcx
       je        near ptr M01_L37
       mov       rcx,1F608106448
       cmp       rdi,rcx
       je        near ptr M01_L36
       mov       rcx,1F608106470
       cmp       rdi,rcx
       je        near ptr M01_L46
       mov       rcx,1F608106510
       cmp       rdi,rcx
       je        near ptr M01_L41
       mov       rcx,1F608106538
       cmp       rdi,rcx
       je        near ptr M01_L35
       mov       rcx,1F6081072F8
       cmp       rdi,rcx
       je        near ptr M01_L45
       mov       rcx,1F608103C08
       cmp       rdi,rcx
       je        near ptr M01_L44
       mov       rcx,1F608100020
       cmp       rdi,rcx
       je        near ptr M01_L34
       mov       rcx,1F6081157C0
       mov       r14d,1
       mov       eax,2
       cmp       rdi,rcx
       cmove     r14d,eax
M01_L26:
       mov       edi,r14d
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L40
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L40
M01_L27:
       mov       [rax+90],edi
       jmp       near ptr M01_L10
M01_L28:
       mov       rcx,rbp
       call      qword ptr [7FFF2DEAA728]; Precode of System.RuntimeType.GetEnumUnderlyingType()
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L33
M01_L29:
       jmp       near ptr M01_L25
M01_L30:
       mov       r14d,9
       jmp       short M01_L26
M01_L31:
       mov       r14d,6
       jmp       short M01_L26
M01_L32:
       mov       r14d,0A
       jmp       short M01_L26
M01_L33:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M01_L63
       jmp       short M01_L29
M01_L34:
       mov       r14d,12
       jmp       short M01_L26
M01_L35:
       mov       r14d,0E
       jmp       short M01_L26
M01_L36:
       mov       r14d,3
       jmp       near ptr M01_L26
M01_L37:
       mov       r14d,0C
       jmp       near ptr M01_L26
M01_L38:
       mov       r14d,0B
       jmp       near ptr M01_L26
M01_L39:
       mov       r14d,8
       jmp       near ptr M01_L26
M01_L40:
       mov       rcx,rbp
       call      qword ptr [7FFF2DEB6658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L27
M01_L41:
       mov       r14d,0D
       jmp       near ptr M01_L26
M01_L42:
       mov       r14d,7
       jmp       near ptr M01_L26
M01_L43:
       mov       r14d,5
       jmp       near ptr M01_L26
M01_L44:
       mov       r14d,10
       jmp       near ptr M01_L26
M01_L45:
       mov       r14d,0F
       jmp       near ptr M01_L26
M01_L46:
       mov       r14d,4
       jmp       near ptr M01_L26
       mov       rdx,rsi
       mov       rcx,offset MT_System.SByte
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFF2E8163B8]
       jmp       near ptr M01_L16
       mov       rdx,rsi
       mov       rcx,offset MT_System.Byte
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFF2E8163B8]
       jmp       near ptr M01_L16
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int16
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFF2E8163A0]
       jmp       near ptr M01_L16
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt16
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFF2E8163A0]
       jmp       near ptr M01_L16
M01_L47:
       mov       ecx,2E5
       mov       rdx,7FFF2DE14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF2E1266E8]
       int       3
M01_L48:
       mov       rcx,rdi
       mov       rdx,rbx
       call      System.RuntimeTypeHandle.IsEquivalentTo(System.RuntimeType, System.RuntimeType)
       test      eax,eax
       jne       near ptr M01_L05
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E44E0D0]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFF2E44DAA0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF6F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L49:
       call      qword ptr [7FFF2DEB7138]
       int       3
M01_L50:
       mov       rcx,rbx
       call      qword ptr [7FFF2DEB4918]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       mov       r8,rsi
       mov       rcx,offset MT_System.String
       cmp       [r8],rcx
       je        short M01_L51
       mov       rdx,rsi
       call      qword ptr [7FFF2DF643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L51:
       mov       rdx,rax
       mov       rcx,offset MD_System.Array.IndexOf[[System.String, System.Private.CoreLib]](System.String[], System.String)
       call      qword ptr [7FFF2E79E610]
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
M01_L52:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF2E476958]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF2E126718]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L53:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E44E130]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [7FFF2E44DAA0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF6F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L54:
       test      r15,r15
       jne       short M01_L55
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       short M01_L56
M01_L55:
       lea       rcx,[r15+10]
       mov       r8d,[r15+8]
M01_L56:
       cmp       dword ptr [r15+8],20
       jle       short M01_L57
       mov       edx,r8d
       mov       r8d,r14d
       call      qword ptr [7FFF2E25E5E0]; System.SpanHelpers.BinarySearch[[System.UInt32, System.Private.CoreLib],[System.UInt32, System.Private.CoreLib]](UInt32 ByRef, Int32, UInt32)
       jmp       short M01_L58
M01_L57:
       mov       edx,r14d
       call      qword ptr [7FFF2E25E718]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M01_L58:
       not       eax
       shr       eax,1F
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt32
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       edx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFF2E257C48]; System.Enum.IsDefinedPrimitive[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, UInt32)
       jmp       near ptr M01_L16
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int64
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFF2E8162C8]
       jmp       near ptr M01_L16
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFF2E8162C8]
       jmp       near ptr M01_L16
       mov       rdx,rsi
       mov       rcx,offset MT_System.Single
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovss    xmm1,dword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFF2E815BC0]
       jmp       near ptr M01_L16
       mov       rdx,rsi
       mov       rcx,offset MT_System.Double
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovsd    xmm1,qword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFF2E815BA8]
       jmp       near ptr M01_L16
M01_L59:
       mov       rcx,1F608104010
       cmp       rbp,rcx
       je        short M01_L61
       mov       rcx,1F608106560
       cmp       rbp,rcx
       je        short M01_L60
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E476958]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2E126718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L60:
       mov       rdx,rsi
       mov       rcx,offset MT_System.UIntPtr
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFF2E8154A0]
       jmp       short M01_L62
M01_L61:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IntPtr
       call      qword ptr [7FFF2DF64408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFF2E8154A0]
M01_L62:
       movzx     eax,al
       jmp       near ptr M01_L16
M01_L63:
       mov       rdx,rax
       call      qword ptr [7FFF2DF643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2034
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
       mov       rcx,1F6080BBFA0
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,1B576005710
       cmp       qword ptr [rbx],0
       je        short M02_L01
M02_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,1F6080BBFA0
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF2E3B62B0]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L00
M02_L02:
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
       mov       rcx,1F6080BBFA0
       call      CORINFO_HELP_MON_EXIT_STATIC
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 155
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-90],rsp
       mov       [rbp-40],rcx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        near ptr M03_L35
       test      rsi,rsi
       je        near ptr M03_L36
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M03_L33
M03_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-60],rdi
       mov       r14,[rsi+18]
       mov       rcx,7FFF2E79A658
       cmp       r14,rcx
       jne       near ptr M03_L28
       jmp       near ptr M03_L17
M03_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M03_L13
M03_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       r13,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r14,[r15+68]
       mov       ecx,[r13+8]
       mov       [r12+8],ecx
       mov       rcx,r12
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M03_L09
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M03_L10
       mov       rcx,1B5760057C8
       mov       r13,[rcx]
       mov       rcx,1B576005618
       mov       r8,[rcx]
       test      r13,r13
       je        near ptr M03_L05
M03_L03:
       test      r13,r13
       je        near ptr M03_L12
       mov       r10,[r8+8]
       mov       [rbp-78],r10
       mov       rcx,[r10+8]
       mov       [rbp-70],r8
       cmp       byte ptr [r8+15],0
       jne       near ptr M03_L14
       mov       rdx,r12
       mov       r11,7FFF2DE20A50
       call      qword ptr [r11]
       jmp       near ptr M03_L15
M03_L04:
       mov       eax,[rbp-44]
       mov       r8,[rbp-70]
       mov       [rbp-88],r8
       mov       r9,[rbp-78]
       mov       [rbp-80],r9
       mov       byte ptr [rbp-58],1
       mov       [rbp-54],eax
       mov       rdx,r12
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-50]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,[rbp-80]
       mov       r8,r12
       mov       r9,[rbp-58]
       mov       rcx,[rbp-88]
       call      qword ptr [7FFF2E337060]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M03_L16
M03_L05:
       mov       [rbp-70],r8
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1B5760057B0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF2E79A730
       mov       [r13+18],rcx
       mov       rcx,1B5760057C8
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-70]
       jmp       near ptr M03_L03
M03_L06:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       near ptr M03_L27
M03_L07:
       mov       eax,[rbp-44]
       mov       rcx,[rbp-70]
       mov       [rbp-88],rcx
       mov       rdx,[rbp-78]
       mov       [rbp-80],rdx
       mov       byte ptr [rbp-58],1
       mov       [rbp-54],eax
       mov       rdx,r12
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       edx,edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rbp-50]
       mov       [rsp+38],rdx
       mov       [rsp+20],rax
       mov       rdx,[rbp-80]
       mov       r8,r12
       mov       r9,[rbp-58]
       mov       rcx,[rbp-88]
       call      qword ptr [7FFF2E337060]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M03_L26
M03_L08:
       mov       [rbp-70],rax
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1B5760057B0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF2E79A730
       mov       [r13+18],rcx
       mov       rcx,1B5760057C8
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       jmp       near ptr M03_L22
M03_L09:
       mov       ecx,2BD
       mov       rdx,7FFF2DE14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF2E1266E8]
       int       3
M03_L10:
       call      qword ptr [7FFF2E416160]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L11
       call      qword ptr [7FFF2E4160B8]
       mov       rbx,rax
M03_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1F6081094D0
       mov       r8,rbx
       call      qword ptr [7FFF2E01D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L12:
       mov       ecx,0BB4
       mov       rdx,7FFF2E3502D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF2E576D60]
       int       3
M03_L13:
       mov       rcx,rbx
       mov       rdx,7FFF2E80B580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M03_L02
M03_L14:
       mov       rcx,r12
       mov       rax,[7FFF2E7AD2D8]
       call      qword ptr [rax+18]
M03_L15:
       mov       r10d,eax
       lea       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-78]
       mov       r8,r12
       mov       [rbp-44],r10d
       mov       r9d,r10d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFF2E336F70]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L04
M03_L16:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,r14
       mov       r8d,4
       call      qword ptr [7FFF2DF661D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       near ptr M03_L31
M03_L17:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M03_L19
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r14d,[rax+0C]
       cmp       r8d,r14d
       jae       short M03_L18
       mov       [rax+8],r8d
       jmp       near ptr M03_L01
M03_L18:
       mov       [rax+8],r14d
       jmp       near ptr M03_L34
M03_L19:
       mov       rcx,rdi
       mov       r11,7FFF2DE20A38
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M03_L34
       jmp       near ptr M03_L01
M03_L20:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M03_L23
M03_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,7FFF2E79A658
       cmp       r14,rcx
       jne       near ptr M03_L06
       mov       r13,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,[r15+68]
       mov       [rbp-68],rcx
       mov       ecx,[r13+8]
       mov       [r12+8],ecx
       mov       rcx,r12
       call      System.Object.GetType()
       test      rax,rax
       je        near ptr M03_L09
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M03_L10
       mov       rcx,1B5760057C8
       mov       r13,[rcx]
       mov       rcx,1B576005618
       mov       r8,[rcx]
       mov       rax,r8
       test      r13,r13
       je        near ptr M03_L08
M03_L22:
       test      r13,r13
       je        near ptr M03_L12
       mov       rdx,[rax+8]
       mov       r8,rdx
       mov       [rbp-78],r8
       mov       rcx,[r8+8]
       mov       [rbp-70],rax
       cmp       byte ptr [rax+15],0
       jne       short M03_L24
       mov       rdx,r12
       mov       r11,7FFF2DE20A50
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       short M03_L25
M03_L23:
       mov       rcx,rbx
       mov       rdx,7FFF2E80B580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M03_L21
M03_L24:
       mov       rcx,r12
       mov       rdx,[7FFF2E7AD2D8]
       call      qword ptr [rdx+18]
       mov       r10d,eax
M03_L25:
       mov       eax,r10d
       lea       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-78]
       mov       r8,r12
       mov       [rbp-44],eax
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFF2E336F70]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L07
M03_L26:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[rbp-68]
       mov       r8d,4
       call      qword ptr [7FFF2DF661D8]; System.String.Equals(System.String, System.String, System.StringComparison)
M03_L27:
       test      eax,eax
       jne       short M03_L31
M03_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M03_L30
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r10d,[rax+0C]
       cmp       r8d,r10d
       jae       short M03_L29
       mov       [rax+8],r8d
       jmp       near ptr M03_L20
M03_L29:
       mov       [rax+8],r10d
       jmp       short M03_L34
M03_L30:
       mov       rcx,rdi
       mov       r11,7FFF2DE20A38
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L34
       jmp       near ptr M03_L20
M03_L31:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       mov       rax,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rax
       jne       short M03_L37
M03_L32:
       mov       rax,r15
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L33:
       mov       rcx,rbx
       mov       rdx,7FFF2E80B4A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M03_L00
M03_L34:
       mov       rcx,rsp
       call      M03_L38
       nop
       mov       r9,[rbp+28]
       mov       byte ptr [r9],0
       xor       eax,eax
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L35:
       mov       ecx,10
       call      qword ptr [7FFF2E124F30]
       int       3
M03_L36:
       mov       ecx,0C
       call      qword ptr [7FFF2E124F30]
       int       3
M03_L37:
       mov       rcx,rdi
       mov       r11,7FFF2DE20A40
       call      qword ptr [r11]
       jmp       near ptr M03_L32
M03_L38:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       mov       rbp,[rcx+40]
       mov       [rsp+40],rbp
       lea       rbp,[rbp+0D0]
       cmp       qword ptr [rbp-60],0
       je        short M03_L39
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       mov       rdi,[rbp-60]
       cmp       [rdi],rcx
       je        short M03_L39
       mov       rcx,rdi
       mov       r11,7FFF2DE20A40
       call      qword ptr [r11]
M03_L39:
       nop
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
; Total bytes of code 1707
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
M04_L00:
       vmovdqa   xmmword ptr [rbp+rdx-40],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-30],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-20],xmm4
       add       rdx,30
       jne       short M04_L00
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M04_L33
M04_L01:
       test      eax,eax
       je        near ptr M04_L34
M04_L02:
       mov       rcx,1B576004DC0
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M04_L36
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M04_L36
M04_L03:
       mov       r14,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r14,r14
       je        near ptr M04_L38
M04_L04:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFF2E19C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFF2E19C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-98],r14
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M04_L17
M04_L05:
       xor       edx,edx
       mov       [rbp-4C],edx
       lea       rdi,[rbp-4C]
       mov       [rbp-0A8],rdi
M04_L06:
       mov       rdx,rdi
       mov       [rbp-58],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0D8],rax
       lea       rax,[M04_L07]
       mov       [rbp-0C0],rax
       lea       rax,[rbp-0E8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M04_L07:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M04_L08
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
M04_L08:
       mov       rcx,[rbp-0E0]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M04_L25
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-58],rax
       mov       eax,[rbp-4C]
       and       eax,0F
       cmp       eax,9
       mov       rdi,[rbp-0A8]
       ja        near ptr M04_L06
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
       ja        near ptr M04_L26
       mov       ecx,r10d
       lea       r13,[rdx+rcx*2+10]
       mov       r12d,[rax]
       test      r12d,r12d
       jl        near ptr M04_L18
       mov       eax,r12d
       mov       ecx,r12d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFF8CEC87F0
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,edi
       jg        near ptr M04_L13
       mov       [rbp-68],eax
       mov       [rbp-70],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,r12d
       cmp       eax,0A
       jb        short M04_L11
       cmp       eax,64
       jb        short M04_L10
       mov       rdx,1B576000290
       mov       rdx,[rdx]
M04_L09:
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
       jae       short M04_L09
M04_L10:
       cmp       eax,0A
       jb        short M04_L11
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,1B576000290
       mov       rdx,[rdx]
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M04_L12
M04_L11:
       add       eax,30
       mov       [rcx-2],ax
M04_L12:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       eax,1
       jmp       short M04_L14
M04_L13:
       xor       eax,eax
       mov       [rbp-68],eax
M04_L14:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M04_L15:
       test      eax,eax
       je        near ptr M04_L24
       mov       ecx,[rbp-68]
       add       [r14+18],ecx
M04_L16:
       add       r15d,1
       jo        near ptr M04_L27
       cmp       r15d,ebx
       jl        near ptr M04_L05
M04_L17:
       mov       r14,[rbp-98]
       mov       rcx,r14
       call      qword ptr [7FFF2E1A9518]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        near ptr M04_L30
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M04_L21
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M04_L28
       jmp       short M04_L22
M04_L18:
       call      qword ptr [7FFF2E08F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M04_L19
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M04_L20
M04_L19:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M04_L20:
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
       call      qword ptr [7FFF2E7E5320]
       jmp       near ptr M04_L15
M04_L21:
       call      qword ptr [7FFF2E81C0F0]
       test      eax,eax
       jne       short M04_L28
M04_L22:
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       short M04_L23
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L29
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M04_L28
       jmp       short M04_L30
M04_L23:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L24:
       mov       ecx,[rbp-5C]
       call      qword ptr [7FFF2E0AFC90]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF2E19C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M04_L16
M04_L25:
       mov       r14,[rbp-98]
       mov       ecx,eax
       call      qword ptr [7FFF2E6A4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M04_L26:
       call      qword ptr [7FFF2E0FE9D0]
       int       3
M04_L27:
       call      CORINFO_HELP_OVERFLOW
M04_L28:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFF2DF673F0]
       mov       rsi,rax
       jmp       short M04_L30
M04_L29:
       call      qword ptr [7FFF2E81C0F0]
       test      eax,eax
       jne       short M04_L28
M04_L30:
       mov       [rbp-0A0],rsi
       mov       rcx,rsp
       call      M04_L39
       jmp       short M04_L32
M04_L31:
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
M04_L32:
       mov       rsi,[rbp-0A0]
       mov       rax,rsi
       jmp       short M04_L31
M04_L33:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M04_L01
       lea       rcx,[rbp-40]
       call      qword ptr [7FFF2E0147B0]
       mov       ebx,eax
       jmp       near ptr M04_L02
M04_L34:
       call      qword ptr [7FFF2E416298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M04_L35
       call      qword ptr [7FFF2E4160B8]
       mov       rsi,rax
M04_L35:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,1F608109A30
       mov       r8,rsi
       call      qword ptr [7FFF2E01D470]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M04_L36:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E67F9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M04_L37
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M04_L03
M04_L37:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r14,r14
       jne       near ptr M04_L04
M04_L38:
       call      qword ptr [7FFF2E4162B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E226438
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E4160A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L39:
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
       mov       rcx,1B576004DC0
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M04_L40
       mov       rcx,[rbp-98]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rdi+8]
       cmp       edx,[rax+0C]
       jg        short M04_L44
       xor       edx,edx
       call      qword ptr [7FFF2E19C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M04_L41
M04_L40:
       mov       r14,[rbp-98]
       mov       rdx,r14
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M04_L44
M04_L41:
       cmp       qword ptr [rsi+20],0
       jne       short M04_L42
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-98]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M04_L44
M04_L42:
       mov       r14,[rbp-98]
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M04_L43
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E67F9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M04_L44
M04_L43:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M04_L44:
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
; Total bytes of code 1629
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileName()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       esi,0A
       mov       rcx,25D894D5700
       cmp       [rcx],ecx
       call      qword ptr [7FFF2DF67318]; System.String.Trim()
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,21CFB801DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF2E221FF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+30],rax
       test      rax,rax
       je        near ptr M00_L03
       lea       rbp,[rax+10]
       mov       r14d,[rax+8]
M00_L00:
       mov       [rsp+40],rbp
       mov       [rsp+48],r14d
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       byte ptr [rsp+3C],0
       mov       ecx,esi
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFF2E38C4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       cmp       byte ptr [rsp+3C],0
       jne       near ptr M00_L04
       test      rdx,rdx
       je        near ptr M00_L04
       mov       r8d,[rsp+38]
       cmp       r8d,[rsp+48]
       ja        near ptr M00_L05
       mov       rcx,[rsp+40]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,r8d
       mov       ebp,[rdx+8]
       cmp       ebp,eax
       ja        near ptr M00_L04
       add       rdx,0C
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,[rsp+38]
       mov       [rsp+38],ebp
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,2E
       call      qword ptr [7FFF2E79E5C8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+3C],0
       jne       near ptr M00_L06
       test      rdi,rdi
       je        near ptr M00_L06
       mov       r8d,[rsp+38]
       cmp       r8d,[rsp+48]
       ja        near ptr M00_L05
       mov       rcx,[rsp+40]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,r8d
       mov       r14d,[rdi+8]
       cmp       r14d,edx
       ja        near ptr M00_L06
       lea       rdx,[rdi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rsp+38]
       mov       [rsp+38],r14d
M00_L02:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF2E085740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rsi,rax
       call      qword ptr [7FFF2E257B28]; System.IO.Path.GetTempPath()
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFF2E257810]; System.IO.Path.Combine(System.String, System.String)
       mov       [rsp+20],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E79E5E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       near ptr M00_L00
M00_L04:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF2E085848]
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFF2E0FE9D0]
       int       3
M00_L06:
       lea       rcx,[rsp+28]
       mov       rdx,rdi
       call      qword ptr [7FFF2E085848]
       jmp       short M00_L02
; Total bytes of code 482
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
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF2E814D20]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFF2E814D20]
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
       call      qword ptr [7FFF2DF673F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,21CFB8005D0
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,7FFF2DEA5120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
       mov       ecx,[rax+8]
       cmp       ecx,ebp
       jbe       short M02_L01
       mov       ecx,ebp
       shl       rcx,4
       mov       r14,[rax+rcx+10]
       test      r14,r14
       je        short M02_L01
       xor       edx,edx
       mov       [rax+rcx+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M02_L22
M02_L00:
       mov       rax,r14
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
M02_L01:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M02_L14
       mov       edx,ebp
       mov       rcx,[rcx+rdx*8+10]
       test      rcx,rcx
       je        near ptr M02_L13
       mov       r14,[rcx+8]
       mov       rcx,7FFF2DEA5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFF2DEA5C38],0
       je        short M02_L02
       call      qword ptr [7FFF2DF6DC98]
       mov       ebx,eax
       jmp       short M02_L05
M02_L02:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ebx,[rax+0A3C]
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[rbx-1]
       mov       [rax+0A3C],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M02_L03
       call      qword ptr [7FFF2E7ED938]
       jmp       short M02_L04
M02_L03:
       mov       eax,ebx
       sar       eax,10
M02_L04:
       mov       ebx,eax
M02_L05:
       mov       rcx,7FFF2DEA5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFF2DEA5C2C]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M02_L10
M02_L06:
       cmp       ebx,[r14+8]
       jae       near ptr M02_L23
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M02_L07
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M02_L07:
       mov       rcx,r13
       call      System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       je        short M02_L08
       jmp       short M02_L11
M02_L08:
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M02_L09
       xor       ebx,ebx
M02_L09:
       inc       r15d
M02_L10:
       cmp       [r14+8],r15d
       jg        short M02_L06
       xor       r12d,r12d
M02_L11:
       mov       r14,r12
       test      r14,r14
       je        short M02_L13
       cmp       byte ptr [rdi+9D],0
       je        short M02_L12
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFF2E21F2E8]
M02_L12:
       mov       rax,r14
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
M02_L13:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M02_L17
M02_L14:
       test      ebx,ebx
       jne       short M02_L15
       mov       rcx,7FFF2DEA5120
       mov       edx,5C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,21CFB801F70
       mov       rax,[rax]
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
M02_L15:
       mov       ecx,ebx
       mov       rdx,25D894C72C0
       call      qword ptr [7FFF2E337540]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M02_L17
M02_L16:
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M02_L18
M02_L17:
       cmp       ebx,400
       jl        short M02_L16
       mov       edx,ebx
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       r14,rax
M02_L18:
       cmp       byte ptr [rdi+9D],0
       je        short M02_L21
       cmp       [r14],r14b
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFF2E21F2E8]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       mov       r9d,eax
       mov       rax,[rsi+10]
       cmp       [rax+8],ebp
       jle       short M02_L19
       mov       eax,2
       jmp       short M02_L20
M02_L19:
       mov       eax,1
M02_L20:
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],eax
       call      qword ptr [7FFF2E21F300]
M02_L21:
       mov       rax,r14
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
M02_L22:
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFF2E21F2E8]
       jmp       near ptr M02_L00
M02_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 835
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M03_L17
M03_L00:
       test      eax,eax
       je        near ptr M03_L18
M03_L01:
       mov       rcx,21CF7802DC8
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
       call      qword ptr [7FFF2E19C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFF2E19C150]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFF2E3B7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E1A9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M03_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M03_L12
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L13
M03_L08:
       mov       edx,eax
       jmp       short M03_L05
M03_L09:
       mov       rcx,r15
       call      qword ptr [7FFF2E19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M03_L06
M03_L10:
       call      CORINFO_HELP_OVERFLOW
M03_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF2DF673F0]
       jmp       short M03_L16
M03_L12:
       call      qword ptr [7FFF2E814D20]
       test      eax,eax
       jne       short M03_L11
M03_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L14
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L15
M03_L14:
       call      qword ptr [7FFF2E814D20]
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
       call      qword ptr [7FFF2E0147B0]
       mov       ebx,eax
       jmp       near ptr M03_L01
M03_L18:
       call      qword ptr [7FFF2E416298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M03_L19
       call      qword ptr [7FFF2E4160B8]
       mov       rsi,rax
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,25D894C9A30
       mov       r8,rsi
       call      qword ptr [7FFF2E01D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E67F9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E4162B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E226430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF2E4160A0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFF2E126670]
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
       mov       rcx,21CF7802DC8
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
       call      qword ptr [7FFF2E19C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E67F9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 999
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
       jmp       qword ptr [7FFF2E015B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF2E085938]
       jmp       short M05_L00
M05_L02:
       call      qword ptr [7FFF2E0FE9D0]
       int       3
M05_L03:
       movzx     edx,si
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFF2E815020]
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
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
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
       mov       rcx,21CFB801DE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFF2E222000]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M06_L00:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M06_L01:
       call      qword ptr [7FFF2E0FE9D0]
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
       mov       rax,425F00447F20
       mov       [rbp],rax
       test      [rsp],esp
       sub       rsp,210
       lea       rcx,[rsp+20]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],104
       xor       ecx,ecx
       mov       [rbp+10],ecx
       lea       rcx,[rbp+8]
       call      qword ptr [7FFF2E257B58]; System.IO.Path.GetTempPath(System.Text.ValueStringBuilder ByRef)
       lea       rcx,[rbp+8]
       call      qword ptr [7FFF2E2DD290]; System.IO.PathHelper.Normalize(System.Text.ValueStringBuilder ByRef)
       mov       rbx,rax
       mov       rdx,[rbp+8]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+8],ymm0
       test      rdx,rdx
       jne       short M07_L02
M07_L00:
       mov       rax,rbx
       mov       rcx,425F00447F20
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
       mov       rcx,21CFB801DE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFF2E222000]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       jmp       qword ptr [7FFF2E257948]; System.IO.Path.CombineInternal(System.String, System.String)
M08_L00:
       mov       ecx,1B53B
       mov       rdx,7FFF2DE14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF2E1266E8]
       int       3
M08_L01:
       mov       ecx,1B547
       mov       rdx,7FFF2DE14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF2E1266E8]
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rdx,1251D804D90
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L31
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M00_L32
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFF2DF94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L33
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       short M00_L01
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE50BC0
       call      qword ptr [r11]
       jmp       short M00_L02
M00_L01:
       mov       rcx,rax
       mov       r11,7FFF2DE50BB8
       call      qword ptr [r11]
M00_L02:
       test      eax,eax
       jle       near ptr M00_L37
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFF2E6D54D0]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L38
       mov       rcx,1251D808420
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L40
M00_L04:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L29
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1251D801E30
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
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
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, Boolean ByRef)
       call      qword ptr [7FFF2E1EC6A8]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rsi,rax
M00_L05:
       xor       edi,edi
       xor       ebp,ebp
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E3E6460]; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
       test      rax,rax
       je        near ptr M00_L15
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       near ptr M00_L16
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE50BD8
       call      qword ptr [r11]
M00_L06:
       test      eax,eax
       jle       near ptr M00_L15
       mov       rcx,rsi
       call      qword ptr [7FFF2E3E6460]; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L41
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFF2DF94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L42
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       near ptr M00_L17
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE50C00
       call      qword ptr [r11]
M00_L07:
       test      eax,eax
       jle       near ptr M00_L46
M00_L08:
       mov       rcx,r14
       call      qword ptr [7FFF2E6D54D0]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L47
       mov       rcx,1251D808430
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M00_L49
M00_L09:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r15,r15
       je        near ptr M00_L29
       xor       ecx,ecx
       mov       [rdi+10],rcx
       lea       rcx,[rdi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1251D801E30
       mov       rdx,[rcx]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
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
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.State>, Boolean ByRef)
       call      qword ptr [7FFF2E1EC6A8]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rdi,rax
M00_L10:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E5E7BA0]; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
       test      rax,rax
       je        near ptr M00_L15
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       near ptr M00_L19
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE50C18
       call      qword ptr [r11]
M00_L11:
       test      eax,eax
       jle       near ptr M00_L15
       mov       rcx,rdi
       call      qword ptr [7FFF2E5E7BA0]; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L20
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFF2DF94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L21
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       near ptr M00_L18
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE50C40
       call      qword ptr [r11]
M00_L12:
       test      eax,eax
       jle       near ptr M00_L25
M00_L13:
       mov       rcx,r14
       call      qword ptr [7FFF2E6D54D0]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L26
       mov       rcx,1251D808450
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M00_L28
M00_L14:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r15,r15
       je        near ptr M00_L29
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1251D801E30
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       r8d,1
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.City>, Int32)
       call      qword ptr [7FFF2E6D6598]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+40]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.City>, Boolean ByRef)
       call      qword ptr [7FFF2E1EC6A8]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rbp,rax
M00_L15:
       mov       [rsp+28],rsi
       mov       [rsp+30],rdi
       mov       [rsp+38],rbp
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.ValueTuple`3[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]], System.Private.CoreLib]](System.ValueTuple`3<DotNetTips.Spargine.Core.Data.Models.Country,DotNetTips.Spargine.Core.Data.Models.State,DotNetTips.Spargine.Core.Data.Models.City> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E7CE598]; BenchmarkDotNet.Engines.Consumer.Consume[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`3<System.__Canon,System.__Canon,System.__Canon> ByRef)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L16:
       mov       rcx,rax
       mov       r11,7FFF2DE50BD0
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,rax
       mov       r11,7FFF2DE50BF8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,rax
       mov       r11,7FFF2DE50C38
       call      qword ptr [r11]
       jmp       near ptr M00_L12
M00_L19:
       mov       rcx,rax
       mov       r11,7FFF2DE50C10
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L20:
       call      qword ptr [7FFF2E445A10]
       mov       ecx,43
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E256438
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E445800]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L21:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L22
       mov       rcx,rax
       mov       r11,7FFF2DE50C30
       call      qword ptr [r11]
       jmp       near ptr M00_L12
M00_L22:
       xor       ebp,ebp
       mov       rcx,r14
       mov       r11,7FFF2DE50C20
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M00_L24
M00_L23:
       add       ebp,1
       jo        near ptr M00_L30
M00_L24:
       mov       rcx,r15
       mov       r11,7FFF2DE50C28
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L23
       mov       eax,ebp
       test      eax,eax
       jg        near ptr M00_L13
M00_L25:
       xor       ebp,ebp
       jmp       near ptr M00_L15
M00_L26:
       call      qword ptr [7FFF2E445830]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L27
       call      qword ptr [7FFF2E445800]
       mov       rbx,rax
M00_L27:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,165AF780638
       mov       r8,rbx
       call      qword ptr [7FFF2E156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L28:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,1251D808448
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFF2DF94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1251D808450
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L14
M00_L29:
       mov       ecx,9
       call      qword ptr [7FFF2E154F30]
       int       3
M00_L30:
       call      CORINFO_HELP_OVERFLOW
M00_L31:
       call      qword ptr [7FFF2E347660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L00
M00_L32:
       call      qword ptr [7FFF2E445A10]
       mov       ecx,43
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E256438
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,1
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E445800]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L33:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L34
       mov       rcx,rax
       mov       r11,7FFF2DE50BB0
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L34:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFF2DE50BA0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M00_L36
M00_L35:
       add       edi,1
       jo        near ptr M00_L30
M00_L36:
       mov       rcx,rbp
       mov       r11,7FFF2DE50BA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L35
       mov       eax,edi
       test      eax,eax
       jg        near ptr M00_L03
M00_L37:
       xor       esi,esi
       jmp       near ptr M00_L05
M00_L38:
       call      qword ptr [7FFF2E445830]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L39
       call      qword ptr [7FFF2E445800]
       mov       rbx,rax
M00_L39:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,165AF780638
       mov       r8,rbx
       call      qword ptr [7FFF2E156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L40:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1251D808418
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFF2DF94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1251D808420
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L04
M00_L41:
       call      qword ptr [7FFF2E445A10]
       mov       ecx,43
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E256438
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E445800]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L42:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L43
       mov       rcx,rax
       mov       r11,7FFF2DE50BF0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L43:
       xor       edi,edi
       mov       rcx,r14
       mov       r11,7FFF2DE50BE0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M00_L45
M00_L44:
       add       edi,1
       jo        near ptr M00_L30
M00_L45:
       mov       rcx,r15
       mov       r11,7FFF2DE50BE8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L44
       mov       eax,edi
       test      eax,eax
       jg        near ptr M00_L08
M00_L46:
       xor       edi,edi
       jmp       near ptr M00_L10
M00_L47:
       call      qword ptr [7FFF2E445830]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L48
       call      qword ptr [7FFF2E445800]
       mov       rbx,rax
M00_L48:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,165AF780638
       mov       r8,rbx
       call      qword ptr [7FFF2E156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L49:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,1251D808428
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFF2DF94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1251D808430
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
; Total bytes of code 2455
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
       jmp       qword ptr [7FFF2DF94378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FFF2DF94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       je        short M02_L00
       mov       rcx,rax
       mov       r11,7FFF2DE50B58
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE50B60
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFF2DE50B50
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFF2DE50B40
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFF2DE50B48
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
       mov       rdx,7FFF2E7EE5E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E7EEBB8
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
       mov       rdx,7FFF2E7EE7D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E7EEA80
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
       mov       rdx,7FFF2E7EEA98
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
       mov       rdx,7FFF2E7EE990
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFF2DE50AA8
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
       mov       rdx,7FFF2E7EE9A8
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
       call      qword ptr [7FFF2E154F30]
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
       mov       r11,7FFF2DE50AB0
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
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2E5EC000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2E5EC000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFF2E823E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E824000
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
       mov       rdx,7FFF2E8240A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L06:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E824F10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF2E1EC4E0]
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
       mov       rdx,7FFF2E824E58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFF2E81FB58]
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
       mov       rdx,7FFF2E7E5190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rbx
       call      qword ptr [7FFF2E7CE5F8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`3<System.__Canon,System.__Canon,System.__Canon> ByRef)
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 65
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
       je        near ptr M08_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L02
       test      rbx,rbx
       je        short M08_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M08_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       call      qword ptr [7FFF2E12EF40]
       int       3
M08_L02:
       test      rbx,rbx
       je        short M08_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M08_L04
M08_L03:
       mov       rax,165AF770008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
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
       jmp       qword ptr [7FFF2E3E6CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       je        short M10_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L00:
       call      qword ptr [7FFF2DF941F8]
       int       3
; Total bytes of code 44
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
M11_L00:
       mov       rsi,[rbx+8]
M11_L00:
       mov       rsi,[rbx+8]
M11_L00:
       mov       rsi,[rbx+8]
M11_L00:
       mov       rsi,[rbx+8]
M11_L00:
       mov       rsi,[rbx+8]
M11_L00:
       mov       rsi,[rbx+8]
M11_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M11_L01
       je        short M11_L01
       je        short M11_L01
       je        short M11_L01
       je        short M11_L01
       je        short M11_L01
       je        short M11_L01
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
       jne       short M11_L03
       jne       short M11_L03
       jne       short M11_L03
       jne       short M11_L03
       jne       short M11_L03
       jne       short M11_L03
       jne       short M11_L03
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
M11_L01:
       cmp       qword ptr [rbx+8],0
M11_L01:
       cmp       qword ptr [rbx+8],0
M11_L01:
       cmp       qword ptr [rbx+8],0
M11_L01:
       cmp       qword ptr [rbx+8],0
M11_L01:
       cmp       qword ptr [rbx+8],0
M11_L01:
       cmp       qword ptr [rbx+8],0
M11_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M11_L02
       jne       short M11_L02
       jne       short M11_L02
       jne       short M11_L02
       jne       short M11_L02
       jne       short M11_L02
       jne       short M11_L02
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
M11_L02:
       mov       rcx,rbx
M11_L02:
       mov       rcx,rbx
M11_L02:
       mov       rcx,rbx
M11_L02:
       mov       rcx,rbx
M11_L02:
       mov       rcx,rbx
M11_L02:
       mov       rcx,rbx
M11_L02:
       mov       rcx,rbx
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
M11_L03:
       cmp       edi,8
M11_L03:
       cmp       edi,8
M11_L03:
       cmp       edi,8
M11_L03:
       cmp       edi,8
M11_L03:
       cmp       edi,8
M11_L03:
       cmp       edi,8
M11_L03:
       cmp       edi,8
       ja        short M11_L04
       ja        short M11_L04
       ja        short M11_L04
       ja        short M11_L04
       ja        short M11_L04
       ja        short M11_L04
       ja        short M11_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M11_L00]
       lea       rax,[M11_L00]
       lea       rax,[M11_L00]
       lea       rax,[M11_L00]
       lea       rax,[M11_L00]
       lea       rax,[M11_L00]
       lea       rax,[M11_L00]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       jmp       short M11_L01
       jmp       short M11_L01
       jmp       short M11_L01
       jmp       short M11_L01
       jmp       short M11_L01
       jmp       short M11_L01
       jmp       short M11_L01
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       jmp       short M11_L01
       jmp       short M11_L01
       jmp       short M11_L01
       jmp       short M11_L01
       jmp       short M11_L01
       jmp       short M11_L01
       jmp       short M11_L01
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
       je        short M11_L05
       je        short M11_L05
       je        short M11_L05
       je        short M11_L05
       je        short M11_L05
       je        short M11_L05
       je        short M11_L05
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
M11_L04:
       mov       rcx,[rsi+8]
M11_L04:
       mov       rcx,[rsi+8]
M11_L04:
       mov       rcx,[rsi+8]
M11_L04:
       mov       rcx,[rsi+8]
M11_L04:
       mov       rcx,[rsi+8]
M11_L04:
       mov       rcx,[rsi+8]
M11_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
M11_L05:
       mov       rcx,rbx
M11_L05:
       mov       rcx,rbx
M11_L05:
       mov       rcx,rbx
M11_L05:
       mov       rcx,rbx
M11_L05:
       mov       rcx,rbx
M11_L05:
       mov       rcx,rbx
M11_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
       jmp       near ptr M11_L01
; Total bytes of code 1841
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rdx,11C7DC04D90
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L40
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M00_L41
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L42
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M00_L01
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE20BF0
       call      qword ptr [r11]
       jmp       short M00_L02
M00_L01:
       mov       rcx,rax
       mov       r11,7FFF2DE20BE8
       call      qword ptr [r11]
M00_L02:
       test      eax,eax
       jle       near ptr M00_L46
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFF2E6A4FD8]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L47
       mov       rcx,11C7DC08420
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L49
M00_L04:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L31
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,11C7DC01E30
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
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
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, Boolean ByRef)
       call      qword ptr [7FFF2E21E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rsi,rax
M00_L05:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E3B6A18]; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
       test      rax,rax
       je        near ptr M00_L14
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       near ptr M00_L19
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE20C08
       call      qword ptr [r11]
M00_L06:
       test      eax,eax
       jle       near ptr M00_L14
       mov       rcx,rsi
       call      qword ptr [7FFF2E3B6A18]; DotNetTips.Spargine.Core.Data.Models.Country.get_States()
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L50
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L51
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M00_L21
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE20C30
       call      qword ptr [r11]
M00_L07:
       test      eax,eax
       jle       near ptr M00_L55
M00_L08:
       mov       rcx,rdi
       call      qword ptr [7FFF2E6A4FD8]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L56
       mov       rcx,11C7DC08430
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L58
M00_L09:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbp,rbp
       je        near ptr M00_L31
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,11C7DC01E30
       mov       rdx,[rcx]
       lea       rcx,[r14+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+28],0
       mov       r8d,1
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.State>, Int32)
       call      qword ptr [7FFF2E6A60A0]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.State>, Boolean ByRef)
       call      qword ptr [7FFF2E21E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rdi,rax
M00_L10:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E5BC330]; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
       test      rax,rax
       je        near ptr M00_L14
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       cmp       [rax],rcx
       jne       near ptr M00_L22
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE20C40
       call      qword ptr [r11]
M00_L11:
       test      eax,eax
       jle       near ptr M00_L14
       mov       rcx,rdi
       call      qword ptr [7FFF2E5BC330]; DotNetTips.Spargine.Core.Data.Models.State.get_Cities()
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L59
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M00_L23
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE20C68
       call      qword ptr [r11]
M00_L12:
       test      eax,eax
       jle       near ptr M00_L14
       mov       rcx,rdi
       call      qword ptr [7FFF2E6A4FD8]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L28
       mov       rcx,11C7DC08440
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L30
M00_L13:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbp,rbp
       je        near ptr M00_L31
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,11C7DC01E30
       mov       rdx,[rcx]
       lea       rcx,[r14+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+28],0
       mov       r8d,1
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.City>, Int32)
       call      qword ptr [7FFF2E6A60A0]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+40]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.City>, Boolean ByRef)
       call      qword ptr [7FFF2E21E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
M00_L14:
       mov       rdx,11C7DC04DA0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L32
       mov       rbp,[rcx+18]
M00_L15:
       test      rbp,rbp
       je        near ptr M00_L33
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M00_L20
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE20C90
       call      qword ptr [r11]
M00_L16:
       test      eax,eax
       jle       near ptr M00_L38
M00_L17:
       mov       rdx,rbp
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       mov       r8d,1
       call      qword ptr [7FFF2E6A5C80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFF2E21E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r14,rax
M00_L18:
       mov       rcx,11C7DC04DA8
       mov       rcx,[rcx]
       call      qword ptr [7FFF2E317DC8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF2E6A5AD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonData
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFF2E6A51D0]; DotNetTips.Spargine.Tester.PersonData..ctor()
       call      qword ptr [7FFF2E195B90]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+70]
       mov       r8d,1
       call      qword ptr [7FFF2E21C780]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+68],rcx
       mov       ecx,1
       mov       edx,5A
       call      qword ptr [7FFF2E38C228]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       jo        near ptr M00_L39
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+68]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFF2E21CB58]; System.TimeSpan..ctor(Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+70]
       lea       rdx,[rsp+58]
       mov       r8,[rsp+68]
       call      qword ptr [7FFF2E21C6F0]; System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovups   xmm0,[rsp+58]
       vmovups   [rbp+38],xmm0
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FFF2E38C270]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFF2E38C048]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddressWithName(System.String, System.String)
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
       call      qword ptr [7FFF2E38C270]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[rbp+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+30],rbp
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.PersonData, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.PersonData ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E79E5C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFF2DE20C00
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L20:
       mov       rcx,rax
       mov       r11,7FFF2DE20C88
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L21:
       mov       rcx,rax
       mov       r11,7FFF2DE20C28
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L22:
       mov       rcx,rax
       mov       r11,7FFF2DE20C38
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L23:
       mov       rcx,rax
       mov       r11,7FFF2DE20C60
       call      qword ptr [r11]
       jmp       near ptr M00_L12
M00_L24:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L25
       mov       rcx,rax
       mov       r11,7FFF2DE20C58
       call      qword ptr [r11]
       jmp       near ptr M00_L12
M00_L25:
       xor       ebp,ebp
       mov       rcx,rdi
       mov       r11,7FFF2DE20C48
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L27
M00_L26:
       add       ebp,1
       jo        near ptr M00_L39
M00_L27:
       mov       rcx,r14
       mov       r11,7FFF2DE20C50
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L26
       mov       eax,ebp
       jmp       near ptr M00_L12
M00_L28:
       call      qword ptr [7FFF2E4160D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L29
       call      qword ptr [7FFF2E4160A0]
       mov       rbx,rax
M00_L29:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,15D0FC20638
       mov       r8,rbx
       call      qword ptr [7FFF2E126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L30:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,11C7DC08438
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFF2DF64210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,11C7DC08440
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L31:
       mov       ecx,9
       call      qword ptr [7FFF2E124F30]
       int       3
M00_L32:
       call      qword ptr [7FFF2E317D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbp,rax
       jmp       near ptr M00_L15
M00_L33:
       call      qword ptr [7FFF2E4162B0]
       mov       ecx,43
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E226430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E4160A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L34:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L35
       mov       rcx,rax
       mov       r11,7FFF2DE20C80
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L35:
       xor       edi,edi
       mov       rcx,rbp
       mov       r11,7FFF2DE20C70
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L37
M00_L36:
       add       edi,1
       jo        short M00_L39
M00_L37:
       mov       rcx,r14
       mov       r11,7FFF2DE20C78
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L36
       mov       eax,edi
       test      eax,eax
       jg        near ptr M00_L17
M00_L38:
       xor       r14d,r14d
       jmp       near ptr M00_L18
M00_L39:
       call      CORINFO_HELP_OVERFLOW
M00_L40:
       call      qword ptr [7FFF2E317D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L00
M00_L41:
       call      qword ptr [7FFF2E4162B0]
       mov       ecx,43
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E226430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E4160A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L42:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L43
       mov       rcx,rax
       mov       r11,7FFF2DE20BE0
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L43:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFF2DE20BD0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M00_L45
M00_L44:
       add       edi,1
       jo        near ptr M00_L39
M00_L45:
       mov       rcx,rbp
       mov       r11,7FFF2DE20BD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L44
       mov       eax,edi
       test      eax,eax
       jg        near ptr M00_L03
M00_L46:
       xor       esi,esi
       jmp       near ptr M00_L05
M00_L47:
       call      qword ptr [7FFF2E4160D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L48
       call      qword ptr [7FFF2E4160A0]
       mov       rbx,rax
M00_L48:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,15D0FC20638
       mov       r8,rbx
       call      qword ptr [7FFF2E126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L49:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,11C7DC08418
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFF2DF64210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,11C7DC08420
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L04
M00_L50:
       call      qword ptr [7FFF2E4162B0]
       mov       ecx,43
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E226430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E4160A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L51:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L52
       mov       rcx,rax
       mov       r11,7FFF2DE20C20
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L52:
       xor       ebp,ebp
       mov       rcx,rdi
       mov       r11,7FFF2DE20C10
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L54
M00_L53:
       add       ebp,1
       jo        near ptr M00_L39
M00_L54:
       mov       rcx,r14
       mov       r11,7FFF2DE20C18
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L53
       mov       eax,ebp
       test      eax,eax
       jg        near ptr M00_L08
M00_L55:
       xor       edi,edi
       jmp       near ptr M00_L10
M00_L56:
       call      qword ptr [7FFF2E4160D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L57
       call      qword ptr [7FFF2E4160A0]
       mov       rbx,rax
M00_L57:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,15D0FC20638
       mov       r8,rbx
       call      qword ptr [7FFF2E126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L58:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,11C7DC08428
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFF2DF64210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,11C7DC08430
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
M00_L59:
       call      qword ptr [7FFF2E4162B0]
       mov       ecx,43
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E226430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E4160A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 3171
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
       jmp       qword ptr [7FFF2DF64378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE20B90
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFF2DE20B88
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFF2DE20B80
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFF2DE20B70
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFF2DE20B78
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
       mov       rdx,7FFF2E7BE588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E7BEB58
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
       mov       rdx,7FFF2E7BE778
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E7BEA20
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
       mov       rdx,7FFF2E7BEA38
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
       mov       rdx,7FFF2E7BE930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFF2DE20AD8
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
       mov       rdx,7FFF2E7BE948
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
       call      qword ptr [7FFF2E124F30]
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
       mov       r11,7FFF2DE20AE0
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
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.State, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2E5BC4C8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFF2E7F4DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E7F4FA8
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
       mov       rdx,7FFF2E7F5048
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L06:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E7F5EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF2E21E2B0]
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
       mov       rdx,7FFF2E7F5E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFF2E7EFD20]
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
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Core.Data.Models.City, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2E5BC4C8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFF2E69F9C8
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
       mov       rdx,7FFF2E69FA78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M07_L03:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF2E6A5D58]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFF2E6A5DA0]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L04:
       call      qword ptr [7FFF2E4162B0]
       mov       ecx,43
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E226430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E4160A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 296
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       cmp       qword ptr [rcx+8],0
       jne       short M08_L00
       mov       rax,[rcx+18]
       ret
M08_L00:
       jmp       qword ptr [7FFF2E317D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M09_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       je        short M09_L01
       mov       rcx,rax
       mov       r11,7FFF2DE20B10
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
       mov       r11,7FFF2DE20B18
       call      qword ptr [r11]
       jmp       short M09_L00
M09_L02:
       mov       rcx,rsi
       mov       rdx,7FFF2E69F5A0
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
       mov       rdx,7FFF2E69F5F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M09_L05:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFF2E6A5C80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF2E087900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF2E4162B0]
       mov       ecx,43
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E226430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E4160A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M09_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M09_L10
       mov       rcx,rax
       mov       r11,7FFF2DE20B08
       call      qword ptr [r11]
       jmp       near ptr M09_L00
M09_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFF2DE20AF8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M09_L12
M09_L11:
       add       edi,1
       jo        near ptr M09_L07
M09_L12:
       mov       rcx,rbp
       mov       r11,7FFF2DE20B00
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
       mov       rsi,15D0FC10008
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
       mov       rax,7FF804645380
       call      rax
       mov       rbx,[rbp-18]
       mov       rax,11C7DC001C8
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFF8DE2A0DC],0
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
       call      qword ptr [7FFF2E195C38]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
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
       mov       rcx,11C7DC00350
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
       mov       rcx,11C7DC00348
       cmp       r14,[rcx]
       je        near ptr M12_L13
       cmp       r14,[rbp+8]
       jne       near ptr M12_L13
M12_L01:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FFF2E6A6E98]
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
       call      qword ptr [7FFF2E6A7228]; System.TimeZoneInfo+CachedData.CreateLocal()
       mov       r14,rax
       jmp       near ptr M12_L00
M12_L05:
       test      rcx,rcx
       je        near ptr M12_L01
       mov       rdx,4000000000000000
       cmp       rcx,rdx
       jne       near ptr M12_L01
       mov       rax,11C7DC00348
       cmp       r14,[rax]
       jne       short M12_L06
       mov       rax,[r14+40]
       jmp       near ptr M12_L02
M12_L06:
       lea       r8,[rsp+38]
       lea       r9,[rsp+30]
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FFF2E6A6EE0]; System.TimeZoneInfo.GetUtcOffsetFromUtc(System.DateTime, System.TimeZoneInfo, Boolean ByRef, Boolean ByRef)
       jmp       near ptr M12_L02
M12_L07:
       test      dil,dil
       je        short M12_L08
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E44DD58]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF6F708]
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
       call      qword ptr [7FFF2E474708]
       mov       rsi,rax
       mov       ecx,1D85
       mov       rdx,7FFF2DE14000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2DF6F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M12_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1D85
       mov       rdx,7FFF2DE14000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF2E4746F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2E01D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M12_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1D85
       mov       rdx,7FFF2DE14000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF2E474AB0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF2E01D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M12_L12:
       call      qword ptr [7FFF2E194AB0]
       int       3
M12_L13:
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       short M12_L14
       mov       rcx,rbp
       call      qword ptr [7FFF2E6A7228]; System.TimeZoneInfo+CachedData.CreateLocal()
       mov       rdx,rax
M12_L14:
       mov       r8,11C7DC00350
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,11C7DC00348
       mov       r8,[r8]
       mov       rcx,rbx
       mov       r9d,2
       call      qword ptr [7FFF2E6A6A90]
       mov       rcx,rax
       lea       r8,[rsp+48]
       lea       r9,[rsp+40]
       mov       rdx,r14
       call      qword ptr [7FFF2E6A6EE0]; System.TimeZoneInfo.GetUtcOffsetFromUtc(System.DateTime, System.TimeZoneInfo, Boolean ByRef, Boolean ByRef)
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
       call      qword ptr [7FFF2E3B7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       nop
       add       rsp,28
       ret
M13_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 34
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
       call      qword ptr [7FFF2E0FEBB0]
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
       call      qword ptr [7FFF2E21C168]; System.DateTimeOffset.get_ClockDateTime()
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
       call      qword ptr [7FFF2E21C048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
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
       call      qword ptr [7FFF2E194B10]
       int       3
M15_L01:
       call      qword ptr [7FFF2E0FEBB0]
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M16_L33
M16_L01:
       test      eax,eax
       je        near ptr M16_L34
M16_L02:
       mov       rcx,11C7DC04DC0
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
       call      qword ptr [7FFF2E19C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFF2E19C150]; System.Text.StringBuilder.set_Capacity(Int32)
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0D8],rax
       lea       rax,[M16_L07]
       mov       [rbp-0C0],rax
       lea       rax,[rbp-0E8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M16_L07:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M16_L08
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rdx,7FFF8CEC87F0
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
       mov       rdx,11C7DC00290
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
       mov       rdx,11C7DC00290
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
       call      qword ptr [7FFF2E1A9518]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        near ptr M16_L30
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M16_L21
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       near ptr M16_L28
       jmp       short M16_L22
M16_L18:
       call      qword ptr [7FFF2E08F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
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
       call      qword ptr [7FFF2E7E51D0]
       jmp       near ptr M16_L15
M16_L21:
       call      qword ptr [7FFF2E814DB0]
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
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M16_L28
       jmp       short M16_L30
M16_L23:
       call      CORINFO_HELP_RNGCHKFAIL
M16_L24:
       mov       ecx,[rbp-5C]
       call      qword ptr [7FFF2E0AFC90]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF2E19C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M16_L16
M16_L25:
       mov       r14,[rbp-98]
       mov       ecx,eax
       call      qword ptr [7FFF2E6A4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M16_L26:
       call      qword ptr [7FFF2E0FE9D0]
       int       3
M16_L27:
       call      CORINFO_HELP_OVERFLOW
M16_L28:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFF2DF673F0]
       mov       rsi,rax
       jmp       short M16_L30
M16_L29:
       call      qword ptr [7FFF2E814DB0]
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
       call      qword ptr [7FFF2E0147B0]
       mov       ebx,eax
       jmp       near ptr M16_L02
M16_L34:
       call      qword ptr [7FFF2E416298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M16_L35
       call      qword ptr [7FFF2E4160B8]
       mov       rsi,rax
M16_L35:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,15D0FC19A30
       mov       r8,rsi
       call      qword ptr [7FFF2E01D470]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M16_L36:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E67F9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E4162B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E226430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E390000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E4160A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E126670]
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
       mov       rcx,11C7DC04DC0
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
       call      qword ptr [7FFF2E19C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E67F9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 1629
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddressWithName(System.String, System.String)
; 	private static string GenerateEmailAddressWithName(string firstName, string lastName) => $"{firstName.DefaultIfNullOrEmpty("FIRSTNAME")}.{lastName.DefaultIfNullOrEmpty("LASTNAME")}@{GenerateWord(5, 15, 'a', 'z')}.{GenerateDomainExtension()}";
; 	                                                                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
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
       mov       rcx,11C7DC01DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF2E221FF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+38],rax
       test      rax,rax
       je        near ptr M17_L14
       lea       rdi,[rax+10]
       mov       ebp,[rax+8]
M17_L00:
       mov       [rsp+48],rdi
       mov       [rsp+50],ebp
       xor       r8d,r8d
       mov       [rsp+40],r8d
       mov       byte ptr [rsp+44],0
       test      rbx,rbx
       je        near ptr M17_L16
       cmp       dword ptr [rbx+8],0
       je        near ptr M17_L16
       cmp       byte ptr [rsp+44],0
       jne       near ptr M17_L17
M17_L01:
       test      rbx,rbx
       je        near ptr M17_L17
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L27
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rbx+8],edx
       ja        near ptr M17_L17
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rsp+40]
       add       r8d,[rbx+8]
       mov       [rsp+40],r8d
M17_L02:
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L27
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       edx,1
       jb        near ptr M17_L18
       mov       r8,15D0FC10C54
       movzx     edx,word ptr [r8]
       mov       [rcx],dx
       mov       r8d,[rsp+40]
       inc       r8d
       mov       [rsp+40],r8d
M17_L03:
       test      rsi,rsi
       je        near ptr M17_L19
       cmp       dword ptr [rsi+8],0
       je        near ptr M17_L19
       cmp       byte ptr [rsp+44],0
       jne       near ptr M17_L20
M17_L04:
       test      rsi,rsi
       je        near ptr M17_L20
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L27
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M17_L20
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[rsi+8]
       mov       [rsp+40],ecx
M17_L05:
       mov       ecx,[rsp+40]
       cmp       ecx,[rsp+50]
       ja        near ptr M17_L27
       mov       rdx,[rsp+48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+50]
       sub       eax,ecx
       cmp       eax,1
       jb        near ptr M17_L21
       mov       rcx,15D0FC20EE4
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M17_L06:
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       r14d,5
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ecx,0F
       mov       edx,1
       mov       eax,edx
       test      edx,edx
       je        near ptr M17_L15
M17_L07:
       test      eax,eax
       je        near ptr M17_L22
M17_L08:
       mov       edx,r14d
       add       edx,1
       jo        near ptr M17_L13
       cmp       ecx,edx
       cmovge    edx,ecx
       mov       ecx,r14d
       call      qword ptr [7FFF2E3B7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFF2E38C4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r15,rax
       cmp       byte ptr [rsp+44],0
       jne       near ptr M17_L24
       test      r15,r15
       je        near ptr M17_L24
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L27
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M17_L24
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+40]
       add       edx,[r15+8]
       mov       [rsp+40],edx
M17_L09:
       mov       edx,[rsp+40]
       cmp       edx,[rsp+50]
       ja        near ptr M17_L27
       mov       rcx,[rsp+48]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+50]
       sub       eax,edx
       cmp       eax,1
       jb        near ptr M17_L25
       mov       rdx,15D0FC10C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       edx,[rsp+40]
       inc       edx
       mov       [rsp+40],edx
M17_L10:
       mov       rdx,11C7DC04D98
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M17_L26
       mov       r13,[rcx+18]
M17_L11:
       mov       edx,[r13+8]
       sub       edx,1
       jo        near ptr M17_L13
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FFF2E3B7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[r13+8]
       jae       near ptr M17_L29
       mov       r8d,eax
       mov       r12,[r13+r8*8+10]
       cmp       byte ptr [rsp+44],0
       jne       near ptr M17_L28
       test      r12,r12
       je        near ptr M17_L28
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M17_L27
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [r12+8],edx
       ja        near ptr M17_L28
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[r12+8]
       mov       [rsp+40],ecx
M17_L12:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E085740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
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
M17_L13:
       call      CORINFO_HELP_OVERFLOW
M17_L14:
       xor       edi,edi
       xor       ebp,ebp
       jmp       near ptr M17_L00
M17_L15:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M17_L07
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF2E0147B0]
       mov       ecx,eax
       jmp       near ptr M17_L08
M17_L16:
       mov       rbx,15D0FC20E88
       cmp       byte ptr [rsp+44],0
       je        near ptr M17_L01
M17_L17:
       lea       rcx,[rsp+30]
       mov       rdx,rbx
       call      qword ptr [7FFF2E085848]
       jmp       near ptr M17_L02
M17_L18:
       lea       rcx,[rsp+30]
       mov       rdx,15D0FC10C48
       call      qword ptr [7FFF2E0858F0]
       jmp       near ptr M17_L03
M17_L19:
       mov       rsi,15D0FC20EB0
       cmp       byte ptr [rsp+44],0
       je        near ptr M17_L04
M17_L20:
       lea       rcx,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FFF2E085848]
       jmp       near ptr M17_L05
M17_L21:
       lea       rcx,[rsp+30]
       mov       rdx,15D0FC20ED8
       call      qword ptr [7FFF2E0858F0]
       jmp       near ptr M17_L06
M17_L22:
       call      qword ptr [7FFF2E416298]
       mov       r15,rax
       test      r15,r15
       jne       short M17_L23
       call      qword ptr [7FFF2E4160B8]
       mov       r15,rax
M17_L23:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,15D0FC20F48
       mov       r8,r15
       call      qword ptr [7FFF2E01D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M17_L24:
       lea       rcx,[rsp+30]
       mov       rdx,r15
       call      qword ptr [7FFF2E085848]
       jmp       near ptr M17_L09
M17_L25:
       lea       rcx,[rsp+30]
       mov       rdx,15D0FC10C48
       call      qword ptr [7FFF2E0858F0]
       jmp       near ptr M17_L10
M17_L26:
       call      qword ptr [7FFF2E317D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r13,rax
       jmp       near ptr M17_L11
M17_L27:
       call      qword ptr [7FFF2E0FE9D0]
       int       3
M17_L28:
       lea       rcx,[rsp+30]
       mov       rdx,r12
       call      qword ptr [7FFF2E085848]
       jmp       near ptr M17_L12
M17_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1293
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
; 		.OrderBy(_ => GenerateRandomNumber());
; 		              ^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       edx,7FFFFFFF
       jmp       qword ptr [7FFF2E3B7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       je        short M20_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M20_L00:
       call      qword ptr [7FFF2DF641F8]
       int       3
; Total bytes of code 44
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
M21_L00:
       mov       rsi,[rbx+8]
M21_L00:
       mov       rsi,[rbx+8]
M21_L00:
       mov       rsi,[rbx+8]
M21_L00:
       mov       rsi,[rbx+8]
M21_L00:
       mov       rsi,[rbx+8]
M21_L00:
       mov       rsi,[rbx+8]
M21_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M21_L01
       je        short M21_L01
       je        short M21_L01
       je        short M21_L01
       je        short M21_L01
       je        short M21_L01
       je        short M21_L01
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
       jne       short M21_L03
       jne       short M21_L03
       jne       short M21_L03
       jne       short M21_L03
       jne       short M21_L03
       jne       short M21_L03
       jne       short M21_L03
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
M21_L01:
       cmp       qword ptr [rbx+8],0
M21_L01:
       cmp       qword ptr [rbx+8],0
M21_L01:
       cmp       qword ptr [rbx+8],0
M21_L01:
       cmp       qword ptr [rbx+8],0
M21_L01:
       cmp       qword ptr [rbx+8],0
M21_L01:
       cmp       qword ptr [rbx+8],0
M21_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M21_L02
       jne       short M21_L02
       jne       short M21_L02
       jne       short M21_L02
       jne       short M21_L02
       jne       short M21_L02
       jne       short M21_L02
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
M21_L02:
       mov       rcx,rbx
M21_L02:
       mov       rcx,rbx
M21_L02:
       mov       rcx,rbx
M21_L02:
       mov       rcx,rbx
M21_L02:
       mov       rcx,rbx
M21_L02:
       mov       rcx,rbx
M21_L02:
       mov       rcx,rbx
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
M21_L03:
       cmp       edi,8
M21_L03:
       cmp       edi,8
M21_L03:
       cmp       edi,8
M21_L03:
       cmp       edi,8
M21_L03:
       cmp       edi,8
M21_L03:
       cmp       edi,8
M21_L03:
       cmp       edi,8
       ja        short M21_L04
       ja        short M21_L04
       ja        short M21_L04
       ja        short M21_L04
       ja        short M21_L04
       ja        short M21_L04
       ja        short M21_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M21_L00]
       lea       rax,[M21_L00]
       lea       rax,[M21_L00]
       lea       rax,[M21_L00]
       lea       rax,[M21_L00]
       lea       rax,[M21_L00]
       lea       rax,[M21_L00]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       jmp       short M21_L01
       jmp       short M21_L01
       jmp       short M21_L01
       jmp       short M21_L01
       jmp       short M21_L01
       jmp       short M21_L01
       jmp       short M21_L01
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       jmp       short M21_L01
       jmp       short M21_L01
       jmp       short M21_L01
       jmp       short M21_L01
       jmp       short M21_L01
       jmp       short M21_L01
       jmp       short M21_L01
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
       je        short M21_L05
       je        short M21_L05
       je        short M21_L05
       je        short M21_L05
       je        short M21_L05
       je        short M21_L05
       je        short M21_L05
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
M21_L04:
       mov       rcx,[rsi+8]
M21_L04:
       mov       rcx,[rsi+8]
M21_L04:
       mov       rcx,[rsi+8]
M21_L04:
       mov       rcx,[rsi+8]
M21_L04:
       mov       rcx,[rsi+8]
M21_L04:
       mov       rcx,[rsi+8]
M21_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
M21_L05:
       mov       rcx,rbx
M21_L05:
       mov       rcx,rbx
M21_L05:
       mov       rcx,rbx
M21_L05:
       mov       rcx,rbx
M21_L05:
       mov       rcx,rbx
M21_L05:
       mov       rcx,rbx
M21_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
       jmp       near ptr M21_L01
; Total bytes of code 1841
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
       je        near ptr M22_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M22_L02
       test      rbx,rbx
       je        short M22_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M22_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M22_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF2E015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M22_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M22_L01:
       call      qword ptr [7FFF2E0FEF40]
       int       3
M22_L02:
       test      rbx,rbx
       je        short M22_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M22_L04
M22_L03:
       mov       rax,15D0FC10008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M22_L04:
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       rdx,1EEC5804DA0
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L06
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M00_L07
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M00_L08
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE30B88
       call      qword ptr [r11]
M00_L01:
       test      eax,eax
       jle       near ptr M00_L13
M00_L02:
       mov       rcx,rsi
       call      qword ptr [7FFF2E6B4FD8]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L14
       mov       rcx,1EEC7802460
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L16
M00_L03:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFF2E34DC68]; System.Linq.OrderedEnumerable`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rdi,rdi
       je        near ptr M00_L17
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1EEC5801E30
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       r8d,1
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Take[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       call      qword ptr [7FFF2E6B5DA0]; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+30]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFF2E22E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rsi,rax
M00_L04:
       call      qword ptr [7FFF2E39C258]; DotNetTips.Spargine.Tester.RandomData.GenerateLastName()
       mov       r9,rax
       lea       rcx,[rsp+38]
       mov       r8,rsi
       mov       rdx,offset MT_System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFF2E6B5800]; System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       vmovdqu   xmm0,xmmword ptr [rsp+38]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`2<System.String,System.String> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E7AE4F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`2<System.__Canon,System.__Canon> ByRef)
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
       call      qword ptr [7FFF2E327D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L00
M00_L07:
       call      qword ptr [7FFF2E4262B0]
       mov       ecx,43
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E4260A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L08:
       mov       rcx,rax
       mov       r11,7FFF2DE30B80
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L09:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L10
       mov       rcx,rax
       mov       r11,7FFF2DE30B78
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L10:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFF2DE30B68
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M00_L12
M00_L11:
       add       edi,1
       jo        near ptr M00_L05
M00_L12:
       mov       rcx,rbp
       mov       r11,7FFF2DE30B70
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
       call      qword ptr [7FFF2E4260D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L15
       call      qword ptr [7FFF2E4260A0]
       mov       rbx,rax
M00_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22F57510638
       mov       r8,rbx
       call      qword ptr [7FFF2E136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L16:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1EEC7802458
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFF2DF74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EEC7802460
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L17:
       mov       ecx,9
       call      qword ptr [7FFF2E134F30]
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
       jmp       qword ptr [7FFF2DF74378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE30B08
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFF2DE30B00
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFF2DE30AF8
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFF2DE30AE8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFF2DE30AF0
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
       mov       rdx,7FFF2E803680
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rbx
       mov       r8d,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF2E6B60A0]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M04_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FFF2E803630
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M04_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF2E34C810]; System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M04_L05:
       mov       ecx,10
       call      qword ptr [7FFF2E134F30]
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
       mov       rdx,7FFF2E7CE510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E7CEAE0
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
       mov       rdx,7FFF2E7CE700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L06:
       mov       rdx,rsi
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF2E7CE9A8
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
       mov       rdx,7FFF2E7CE9C0
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
       mov       rdx,7FFF2E7CE8B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M05_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFF2DE30A50
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
       mov       rdx,7FFF2E7CE8D0
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
       call      qword ptr [7FFF2E134F30]
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
       mov       r11,7FFF2DE30A58
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
       mov       rdx,1EEC5804DA8
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M06_L06
       mov       rbx,[rcx+18]
       test      rbx,rbx
       je        near ptr M06_L07
M06_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M06_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M06_L08
       mov       rcx,[rax+8]
       mov       r11,7FFF2DE30B58
       call      qword ptr [r11]
M06_L01:
       test      eax,eax
       jle       near ptr M06_L13
M06_L02:
       mov       rcx,rbx
       call      qword ptr [7FFF2E6B4FD8]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M06_L14
       mov       rcx,1EEC7802460
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M06_L16
M06_L03:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
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
       mov       rcx,1EEC5801E30
       mov       rdx,[rcx]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[System.String, System.Private.CoreLib]]
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
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFF2E22E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FFF2E327D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       test      rbx,rbx
       jne       near ptr M06_L00
M06_L07:
       call      qword ptr [7FFF2E4262B0]
       mov       ecx,43
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF2E4260A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF2E136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L08:
       mov       rcx,rax
       mov       r11,7FFF2DE30B50
       call      qword ptr [r11]
       jmp       near ptr M06_L01
M06_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFF2DF74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M06_L10
       mov       rcx,rax
       mov       r11,7FFF2DE30B48
       call      qword ptr [r11]
       jmp       near ptr M06_L01
M06_L10:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFF2DE30B38
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M06_L12
M06_L11:
       add       esi,1
       jo        near ptr M06_L05
M06_L12:
       mov       rcx,rdi
       mov       r11,7FFF2DE30B40
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
       call      qword ptr [7FFF2E4260D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L15
       call      qword ptr [7FFF2E4260A0]
       mov       rbx,rax
M06_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22F57510638
       mov       r8,rbx
       call      qword ptr [7FFF2E136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L16:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1EEC7802458
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__39`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__39_0(System.__Canon)
       call      qword ptr [7FFF2DF74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EEC7802460
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L03
M06_L17:
       mov       ecx,9
       call      qword ptr [7FFF2E134F30]
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
       mov       rdx,7FFF2E7C5070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M08_L01:
       mov       rdx,rbx
       call      qword ptr [7FFF2E7AE550]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`2<System.__Canon,System.__Canon> ByRef)
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 65
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
M09_L00:
       mov       rsi,[rbx+8]
M09_L00:
       mov       rsi,[rbx+8]
M09_L00:
       mov       rsi,[rbx+8]
M09_L00:
       mov       rsi,[rbx+8]
M09_L00:
       mov       rsi,[rbx+8]
M09_L00:
       mov       rsi,[rbx+8]
M09_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M09_L01
       je        short M09_L01
       je        short M09_L01
       je        short M09_L01
       je        short M09_L01
       je        short M09_L01
       je        short M09_L01
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
       jne       short M09_L03
       jne       short M09_L03
       jne       short M09_L03
       jne       short M09_L03
       jne       short M09_L03
       jne       short M09_L03
       jne       short M09_L03
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
M09_L01:
       cmp       qword ptr [rbx+8],0
M09_L01:
       cmp       qword ptr [rbx+8],0
M09_L01:
       cmp       qword ptr [rbx+8],0
M09_L01:
       cmp       qword ptr [rbx+8],0
M09_L01:
       cmp       qword ptr [rbx+8],0
M09_L01:
       cmp       qword ptr [rbx+8],0
M09_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M09_L02
       jne       short M09_L02
       jne       short M09_L02
       jne       short M09_L02
       jne       short M09_L02
       jne       short M09_L02
       jne       short M09_L02
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
M09_L02:
       mov       rcx,rbx
M09_L02:
       mov       rcx,rbx
M09_L02:
       mov       rcx,rbx
M09_L02:
       mov       rcx,rbx
M09_L02:
       mov       rcx,rbx
M09_L02:
       mov       rcx,rbx
M09_L02:
       mov       rcx,rbx
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
M09_L03:
       cmp       edi,8
M09_L03:
       cmp       edi,8
M09_L03:
       cmp       edi,8
M09_L03:
       cmp       edi,8
M09_L03:
       cmp       edi,8
M09_L03:
       cmp       edi,8
M09_L03:
       cmp       edi,8
       ja        short M09_L04
       ja        short M09_L04
       ja        short M09_L04
       ja        short M09_L04
       ja        short M09_L04
       ja        short M09_L04
       ja        short M09_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M09_L00]
       lea       rax,[M09_L00]
       lea       rax,[M09_L00]
       lea       rax,[M09_L00]
       lea       rax,[M09_L00]
       lea       rax,[M09_L00]
       lea       rax,[M09_L00]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       jmp       short M09_L01
       jmp       short M09_L01
       jmp       short M09_L01
       jmp       short M09_L01
       jmp       short M09_L01
       jmp       short M09_L01
       jmp       short M09_L01
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       jmp       short M09_L01
       jmp       short M09_L01
       jmp       short M09_L01
       jmp       short M09_L01
       jmp       short M09_L01
       jmp       short M09_L01
       jmp       short M09_L01
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
       je        short M09_L05
       je        short M09_L05
       je        short M09_L05
       je        short M09_L05
       je        short M09_L05
       je        short M09_L05
       je        short M09_L05
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
M09_L04:
       mov       rcx,[rsi+8]
M09_L04:
       mov       rcx,[rsi+8]
M09_L04:
       mov       rcx,[rsi+8]
M09_L04:
       mov       rcx,[rsi+8]
M09_L04:
       mov       rcx,[rsi+8]
M09_L04:
       mov       rcx,[rsi+8]
M09_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
M09_L05:
       mov       rcx,rbx
M09_L05:
       mov       rcx,rbx
M09_L05:
       mov       rcx,rbx
M09_L05:
       mov       rcx,rbx
M09_L05:
       mov       rcx,rbx
M09_L05:
       mov       rcx,rbx
M09_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
       jmp       near ptr M09_L01
; Total bytes of code 1841
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF2E025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF2E025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF2E10EF40]
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
       mov       rax,22F57500008
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
       jmp       qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2DF741F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRelativeUrl()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFF2E39C3D8]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
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
       mov       rcx,22A13804DC0
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
       call      qword ptr [7FFF2E1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-98],rax
       lea       rax,[M01_L03]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A8]
       mov       [rbx+10],rax
       mov       byte ptr [rbx+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L03:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L04
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
M01_L04:
       mov       rcx,[rbp-0A0]
       mov       [rbx+10],rcx
       test      eax,eax
       jne       near ptr M01_L16
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
       je        near ptr M01_L20
       test      eax,eax
       je        near ptr M01_L17
       cmp       edx,2
       jl        near ptr M01_L21
M01_L06:
       mov       ecx,1
       call      qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFF2E39C4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L15
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M01_L15
       lea       ecx,[rbx+1]
       test      ecx,ecx
       jl        near ptr M01_L19
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r8,[r13+0C]
       mov       rcx,26AA54E662C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r13+0E]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFF2E025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF2E025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF2E1ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFF2E1B9518]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       near ptr M01_L23
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       r13,26AA54E6620
       jmp       near ptr M01_L07
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFF2E6B4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      qword ptr [7FFF2E426298]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L18
       call      qword ptr [7FFF2E4260B8]
       mov       rbx,rax
M01_L18:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,26AA54F0F48
       mov       r8,rbx
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       call      qword ptr [7FFF2E10EF40]
       int       3
M01_L20:
       mov       edx,1
       cmp       edx,2
       jge       near ptr M01_L06
M01_L21:
       mov       edx,2
       jmp       near ptr M01_L06
M01_L22:
       mov       rcx,rsi
       mov       edx,2F
       call      qword ptr [7FFF2E1AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFF2E68FEE8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E68FA08]
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
       mov       rcx,22A13804DC0
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
       call      qword ptr [7FFF2E1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E68FF18]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L34
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFF2E68F9D8]
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateTempFile()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,400
       call      qword ptr [7FFF2E37C3F0]; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
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
       push      r15
       push      r14
       push      r13
       push      r12
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
       mov       ebx,ecx
       mov       byte ptr [rsp+50],1
       mov       dword ptr [rsp+54],400
       test      ebx,ebx
       jle       near ptr M01_L07
       xor       esi,esi
       cmp       ebx,7FFFFFFF
       setle     sil
       mov       eax,esi
       test      esi,esi
       je        near ptr M01_L08
M01_L00:
       test      eax,eax
       je        near ptr M01_L09
M01_L01:
       mov       edi,0A
       mov       rcx,234E4BC5730
       cmp       [rcx],ecx
       call      qword ptr [7FFF2DF57318]; System.String.Trim()
       mov       rbp,rax
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,1F456C01DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF2E211FF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+30],rax
       test      rax,rax
       je        near ptr M01_L11
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M01_L02:
       mov       [rsp+40],r14
       mov       [rsp+48],r15d
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       byte ptr [rsp+3C],0
       mov       ecx,edi
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFF2E37C4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r13,rax
       cmp       byte ptr [rsp+3C],0
       jne       near ptr M01_L12
       test      r13,r13
       je        near ptr M01_L12
       mov       r8d,[rsp+38]
       cmp       r8d,[rsp+48]
       ja        near ptr M01_L13
       mov       rcx,[rsp+40]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,r8d
       cmp       [r13+8],edx
       ja        near ptr M01_L12
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFF2E005B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+38]
       add       ecx,[r13+8]
       mov       [rsp+38],ecx
M01_L03:
       lea       rcx,[rsp+28]
       mov       edx,2E
       call      qword ptr [7FFF2E78E4F0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+3C],0
       jne       near ptr M01_L14
       test      rbp,rbp
       je        near ptr M01_L14
       mov       r8d,[rsp+38]
       cmp       r8d,[rsp+48]
       ja        near ptr M01_L13
       mov       rcx,[rsp+40]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,r8d
       cmp       [rbp+8],edx
       ja        near ptr M01_L14
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       add       r8,r8
       call      qword ptr [7FFF2E005B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+38]
       add       ecx,[rbp+8]
       mov       [rsp+38],ecx
M01_L04:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF2E075740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rsi,rax
       call      qword ptr [7FFF2E247B28]; System.IO.Path.GetTempPath()
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFF2E247810]; System.IO.Path.Combine(System.String, System.String)
       mov       rsi,rax
       mov       byte ptr [rsp+20],1
       mov       dword ptr [rsp+24],1
       mov       ecx,ebx
       test      ecx,ecx
       jle       near ptr M01_L15
       xor       r12d,r12d
       cmp       ecx,7FFFFFFF
       setle     r12b
       mov       eax,r12d
       test      r12d,r12d
       je        near ptr M01_L16
M01_L05:
       test      eax,eax
       je        near ptr M01_L17
M01_L06:
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFF2E37C4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r14,rax
       call      qword ptr [7FFF2E2CC000]; System.IO.File.get_UTF8NoBOM()
       mov       r15,rax
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFF2E2CC978]; System.IO.File.Validate(System.String, System.Text.Encoding)
       mov       rcx,rsi
       mov       r9,r15
       mov       r8,r14
       mov       edx,2
       call      qword ptr [7FFF2E2CC9A8]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.String, System.Text.Encoding)
       mov       rax,rsi
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
M01_L07:
       xor       esi,esi
       mov       eax,esi
       test      esi,esi
       jne       near ptr M01_L00
M01_L08:
       movzx     ecx,byte ptr [rsp+50]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       call      qword ptr [7FFF2E0047B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L09:
       call      qword ptr [7FFF2E406298]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L10
       call      qword ptr [7FFF2E4060B8]
       mov       rdi,rax
M01_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,234E4BC5700
       mov       r8,rdi
       call      qword ptr [7FFF2E00D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L11:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M01_L02
M01_L12:
       lea       rcx,[rsp+28]
       mov       rdx,r13
       call      qword ptr [7FFF2E075848]
       jmp       near ptr M01_L03
M01_L13:
       call      qword ptr [7FFF2E0EE9D0]
       int       3
M01_L14:
       lea       rcx,[rsp+28]
       mov       rdx,rbp
       call      qword ptr [7FFF2E075848]
       jmp       near ptr M01_L04
M01_L15:
       xor       r12d,r12d
       mov       eax,r12d
       test      r12d,r12d
       jne       near ptr M01_L05
M01_L16:
       movzx     edx,byte ptr [rsp+20]
       test      dl,dl
       je        near ptr M01_L05
       lea       rcx,[rsp+20]
       call      qword ptr [7FFF2E0047B0]
       mov       ecx,eax
       jmp       near ptr M01_L06
M01_L17:
       call      qword ptr [7FFF2E406298]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L18
       call      qword ptr [7FFF2E4060B8]
       mov       rbx,rax
M01_L18:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,234E4BB9A30
       mov       r8,rbx
       call      qword ptr [7FFF2E00D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 882
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF2E3E7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFF2E3BC4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rdx,247FFC04D98
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
       call      qword ptr [7FFF2E3E7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L08
       mov       r9d,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       rcx,28891CB5728
       mov       r8,28891CA0C48
       call      qword ptr [7FFF2DF96B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,28891CB5700
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       call      qword ptr [7FFF2E3BC3D8]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       [rsp+20],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E7CE5C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF2E0447B0]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFF2E446298]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFF2E4460B8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28891CB0F48
       mov       r8,rbx
       call      qword ptr [7FFF2E04D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFF2E347D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6D4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E81E1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF9F708]
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L20
M02_L00:
       test      eax,eax
       je        near ptr M02_L21
M02_L01:
       mov       rcx,247FFC04DC0
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
       call      qword ptr [7FFF2E1CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFF2E1CC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r14
       jmp       short M02_L06
M02_L04:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-48]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E6AFEE8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       jo        near ptr M02_L16
M02_L07:
       movzx     edx,si
       mov       eax,r13d
       cmp       edx,eax
       jl        near ptr M02_L14
M02_L08:
       mov       ecx,r15d
       call      qword ptr [7FFF2E3E7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        near ptr M02_L16
       mov       edx,eax
       mov       ecx,[r14+18]
       mov       eax,ecx
       mov       r8,[r14+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       near ptr M02_L15
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r14+18],ecx
M02_L09:
       add       r12d,1
       jo        near ptr M02_L16
       cmp       r12d,ebx
       jl        short M02_L07
M02_L10:
       mov       rcx,r14
       call      qword ptr [7FFF2E1D9518]; System.Text.StringBuilder.ToString()
       mov       r15,rax
       mov       esi,[r15+8]
       test      esi,esi
       je        short M02_L12
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M02_L17
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L13
M02_L11:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L18
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L13
M02_L12:
       mov       [rbp-58],r15
       jmp       short M02_L19
M02_L13:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF2DF973F0]
       mov       r15,rax
       jmp       short M02_L12
M02_L14:
       mov       edx,eax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,r14
       call      qword ptr [7FFF2E1CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M02_L09
M02_L16:
       call      CORINFO_HELP_OVERFLOW
M02_L17:
       call      qword ptr [7FFF2E81F4B0]
       test      eax,eax
       jne       short M02_L13
       jmp       short M02_L11
M02_L18:
       call      qword ptr [7FFF2E81F4B0]
       test      eax,eax
       jne       short M02_L13
       jmp       short M02_L12
M02_L19:
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
       call      qword ptr [7FFF2E0447B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L21:
       call      qword ptr [7FFF2E446298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L22
       call      qword ptr [7FFF2E4460B8]
       mov       rsi,rax
M02_L22:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,28891CA9A30
       mov       r8,rsi
       call      qword ptr [7FFF2E04D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L23:
       call      qword ptr [7FFF2E4462B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E256430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E4460A0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFF2E156670]
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
       call      qword ptr [7FFF2E6AFA08]
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
       mov       rcx,247FFC04DC0
       mov       r14,[rcx]
       mov       r15,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M02_L28
       mov       r13,[rbp-50]
       mov       rcx,[r13+8]
       mov       ecx,[rcx+8]
       add       ecx,[r13+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M02_L32
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFF2E1CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L29
M02_L28:
       mov       rdx,[rbp-50]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r13,[rbp-50]
       je        short M02_L32
M02_L29:
       cmp       qword ptr [r14+20],0
       jne       short M02_L30
       lea       rcx,[r14+20]
       mov       rdx,r13
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L32
M02_L30:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M02_L31
       mov       r14,[r14+18]
       mov       rcx,[r14+10]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E6AFF18]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M02_L32
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FFF2E6AF9D8]
       jmp       short M02_L32
M02_L31:
       add       r14,2C
       lock dec  dword ptr [r14]
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
; Total bytes of code 1078
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbp,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M03_L00
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M03_L00
       test      rdi,rdi
       je        near ptr M03_L01
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M03_L01
       test      rbp,rbp
       je        near ptr M03_L02
       mov       r13d,[rbp+8]
       test      r13d,r13d
       je        near ptr M03_L02
       test      rbx,rbx
       je        near ptr M03_L03
       cmp       dword ptr [rbx+8],0
       je        near ptr M03_L03
       mov       r12d,r14d
       mov       ecx,r15d
       add       rcx,r12
       mov       eax,r13d
       add       rcx,rax
       mov       eax,[rbx+8]
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M03_L04
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+30],rax
       cmp       [rax],al
       lea       r10,[rax+0C]
       mov       [rsp+28],r10
       mov       rcx,r10
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,[rsp+28]
       lea       rcx,[rsi+r12*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    r8,r14d
       lea       rcx,[rsi+r8*2]
       lea       rdx,[rbp+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
       movsxd    r8,r14d
       lea       rcx,[rsi+r8*2]
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdi,[rsp+30]
       mov       rax,rdi
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
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF2DF96B20]; System.String.Concat(System.String, System.String, System.String)
M03_L01:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF2DF96B20]; System.String.Concat(System.String, System.String, System.String)
M03_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF2DF96B20]; System.String.Concat(System.String, System.String, System.String)
M03_L03:
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
       jmp       qword ptr [7FFF2DF96B20]; System.String.Concat(System.String, System.String, System.String)
M03_L04:
       call      qword ptr [7FFF2E12EF40]
       int       3
; Total bytes of code 421
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF2E12EF40]
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
       mov       rax,28891CA0008
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
       mov       rcx,247FFC04DC0
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
       call      qword ptr [7FFF2E1CC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-98],rax
       lea       rax,[M05_L03]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A8]
       mov       [rbx+10],rax
       mov       byte ptr [rbx+0C],0
       mov       rax,7FF8043C3670
       call      rax
M05_L03:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M05_L04
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
M05_L04:
       mov       rcx,[rbp-0A0]
       mov       [rbx+10],rcx
       test      eax,eax
       jne       near ptr M05_L16
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
       je        near ptr M05_L20
       test      eax,eax
       je        near ptr M05_L17
       cmp       edx,2
       jl        near ptr M05_L21
M05_L06:
       mov       ecx,1
       call      qword ptr [7FFF2E3E7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFF2E3BC4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L15
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M05_L15
       lea       ecx,[rbx+1]
       test      ecx,ecx
       jl        near ptr M05_L19
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r8,[r13+0C]
       mov       rcx,28891CA662C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r13+0E]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF2E1CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFF2E1D9518]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       near ptr M05_L23
M05_L14:
       call      CORINFO_HELP_OVERFLOW
M05_L15:
       mov       r13,28891CA6620
       jmp       near ptr M05_L07
M05_L16:
       mov       ecx,eax
       call      qword ptr [7FFF2E6D4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M05_L17:
       call      qword ptr [7FFF2E446298]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L18
       call      qword ptr [7FFF2E4460B8]
       mov       rbx,rax
M05_L18:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,28891CB0F48
       mov       r8,rbx
       call      qword ptr [7FFF2E04D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M05_L19:
       call      qword ptr [7FFF2E12EF40]
       int       3
M05_L20:
       mov       edx,1
       cmp       edx,2
       jge       near ptr M05_L06
M05_L21:
       mov       edx,2
       jmp       near ptr M05_L06
M05_L22:
       mov       rcx,rsi
       mov       edx,2F
       call      qword ptr [7FFF2E1CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFF2E6AFEE8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E6AFA08]
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
       mov       rcx,247FFC04DC0
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
       call      qword ptr [7FFF2E1CC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E6AFF18]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M05_L34
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFF2E6AF9D8]
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
M07_L00:
       mov       rsi,[rbx+8]
M07_L00:
       mov       rsi,[rbx+8]
M07_L00:
       mov       rsi,[rbx+8]
M07_L00:
       mov       rsi,[rbx+8]
M07_L00:
       mov       rsi,[rbx+8]
M07_L00:
       mov       rsi,[rbx+8]
M07_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M07_L01
       je        short M07_L01
       je        short M07_L01
       je        short M07_L01
       je        short M07_L01
       je        short M07_L01
       je        short M07_L01
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
       jne       short M07_L03
       jne       short M07_L03
       jne       short M07_L03
       jne       short M07_L03
       jne       short M07_L03
       jne       short M07_L03
       jne       short M07_L03
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
M07_L01:
       cmp       qword ptr [rbx+8],0
M07_L01:
       cmp       qword ptr [rbx+8],0
M07_L01:
       cmp       qword ptr [rbx+8],0
M07_L01:
       cmp       qword ptr [rbx+8],0
M07_L01:
       cmp       qword ptr [rbx+8],0
M07_L01:
       cmp       qword ptr [rbx+8],0
M07_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M07_L02
       jne       short M07_L02
       jne       short M07_L02
       jne       short M07_L02
       jne       short M07_L02
       jne       short M07_L02
       jne       short M07_L02
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
M07_L02:
       mov       rcx,rbx
M07_L02:
       mov       rcx,rbx
M07_L02:
       mov       rcx,rbx
M07_L02:
       mov       rcx,rbx
M07_L02:
       mov       rcx,rbx
M07_L02:
       mov       rcx,rbx
M07_L02:
       mov       rcx,rbx
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
M07_L03:
       cmp       edi,8
M07_L03:
       cmp       edi,8
M07_L03:
       cmp       edi,8
M07_L03:
       cmp       edi,8
M07_L03:
       cmp       edi,8
M07_L03:
       cmp       edi,8
M07_L03:
       cmp       edi,8
       ja        short M07_L04
       ja        short M07_L04
       ja        short M07_L04
       ja        short M07_L04
       ja        short M07_L04
       ja        short M07_L04
       ja        short M07_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M07_L00]
       lea       rax,[M07_L00]
       lea       rax,[M07_L00]
       lea       rax,[M07_L00]
       lea       rax,[M07_L00]
       lea       rax,[M07_L00]
       lea       rax,[M07_L00]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       jmp       short M07_L01
       jmp       short M07_L01
       jmp       short M07_L01
       jmp       short M07_L01
       jmp       short M07_L01
       jmp       short M07_L01
       jmp       short M07_L01
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       jmp       short M07_L01
       jmp       short M07_L01
       jmp       short M07_L01
       jmp       short M07_L01
       jmp       short M07_L01
       jmp       short M07_L01
       jmp       short M07_L01
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
       je        short M07_L05
       je        short M07_L05
       je        short M07_L05
       je        short M07_L05
       je        short M07_L05
       je        short M07_L05
       je        short M07_L05
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
M07_L04:
       mov       rcx,[rsi+8]
M07_L04:
       mov       rcx,[rsi+8]
M07_L04:
       mov       rcx,[rsi+8]
M07_L04:
       mov       rcx,[rsi+8]
M07_L04:
       mov       rcx,[rsi+8]
M07_L04:
       mov       rcx,[rsi+8]
M07_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
M07_L05:
       mov       rcx,rbx
M07_L05:
       mov       rcx,rbx
M07_L05:
       mov       rcx,rbx
M07_L05:
       mov       rcx,rbx
M07_L05:
       mov       rcx,rbx
M07_L05:
       mov       rcx,rbx
M07_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
; Total bytes of code 1841
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFF2E39C4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       mov       rcx,2427B186620
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF2E0247B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFF2E426298]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFF2E4260B8]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2427B190F48
       mov       r8,rbx
       call      qword ptr [7FFF2E02D470]
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6B4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7FE1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF7F708]
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L17
M02_L00:
       test      eax,eax
       je        near ptr M02_L18
M02_L01:
       mov       rcx,201E9404DC0
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
       call      qword ptr [7FFF2E1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFF2E1AC150]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E1B9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFF2E1AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF2DF773F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFF2E7FF4B0]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFF2E7FF4B0]
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
       call      qword ptr [7FFF2E0247B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFF2E426298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFF2E4260B8]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2427B189A30
       mov       r8,rsi
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E68F9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E4262B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF2E4260A0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFF2E136670]
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
       mov       rcx,201E9404DC0
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
       call      qword ptr [7FFF2E1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E68F9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 999
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
       call      qword ptr [7FFF2E025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF2E025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF2E10EF40]
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
       mov       rax,2427B180008
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF2E3E7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFF2E3BC4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rdx,1FC48004D98
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
       call      qword ptr [7FFF2E3E7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L08
       mov       r9d,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       rcx,23CD9FC5728
       mov       r8,23CD9FB0C48
       call      qword ptr [7FFF2DF96B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,23CD9FC5700
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF2E0447B0]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFF2E446298]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M00_L06
       call      qword ptr [7FFF2E4460B8]
       mov       rdi,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,23CD9FC0F48
       mov       r8,rdi
       call      qword ptr [7FFF2E04D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFF2E347D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6D4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E81E220]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF9F708]
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L17
M02_L00:
       test      eax,eax
       je        near ptr M02_L18
M02_L01:
       mov       rcx,1FC48004DC0
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
       call      qword ptr [7FFF2E1CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFF2E1CC150]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFF2E3E7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E1D9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFF2E1CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF2DF973F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFF2E81F528]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFF2E81F528]
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
       call      qword ptr [7FFF2E0447B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFF2E446298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFF2E4460B8]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,23CD9FB9A30
       mov       r8,rsi
       call      qword ptr [7FFF2E04D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E6AF9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E4462B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E256430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF2E4460A0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFF2E156670]
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
       mov       rcx,1FC48004DC0
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
       call      qword ptr [7FFF2E1CC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E6AF9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 999
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbp,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M03_L00
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M03_L00
       test      rdi,rdi
       je        near ptr M03_L01
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M03_L01
       test      rbp,rbp
       je        near ptr M03_L02
       mov       r13d,[rbp+8]
       test      r13d,r13d
       je        near ptr M03_L02
       test      rbx,rbx
       je        near ptr M03_L03
       cmp       dword ptr [rbx+8],0
       je        near ptr M03_L03
       mov       r12d,r14d
       mov       ecx,r15d
       add       rcx,r12
       mov       eax,r13d
       add       rcx,rax
       mov       eax,[rbx+8]
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M03_L04
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+30],rax
       cmp       [rax],al
       lea       r10,[rax+0C]
       mov       [rsp+28],r10
       mov       rcx,r10
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,[rsp+28]
       lea       rcx,[rsi+r12*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    r8,r14d
       lea       rcx,[rsi+r8*2]
       lea       rdx,[rbp+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
       movsxd    r8,r14d
       lea       rcx,[rsi+r8*2]
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdi,[rsp+30]
       mov       rax,rdi
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
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF2DF96B20]; System.String.Concat(System.String, System.String, System.String)
M03_L01:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF2DF96B20]; System.String.Concat(System.String, System.String, System.String)
M03_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF2DF96B20]; System.String.Concat(System.String, System.String, System.String)
M03_L03:
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
       jmp       qword ptr [7FFF2DF96B20]; System.String.Concat(System.String, System.String, System.String)
M03_L04:
       call      qword ptr [7FFF2E12EF40]
       int       3
; Total bytes of code 421
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF2E045B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF2E12EF40]
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
       mov       rax,23CD9FB0008
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
M05_L00:
       mov       rsi,[rbx+8]
M05_L00:
       mov       rsi,[rbx+8]
M05_L00:
       mov       rsi,[rbx+8]
M05_L00:
       mov       rsi,[rbx+8]
M05_L00:
       mov       rsi,[rbx+8]
M05_L00:
       mov       rsi,[rbx+8]
M05_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M05_L01
       je        short M05_L01
       je        short M05_L01
       je        short M05_L01
       je        short M05_L01
       je        short M05_L01
       je        short M05_L01
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
       jne       short M05_L03
       jne       short M05_L03
       jne       short M05_L03
       jne       short M05_L03
       jne       short M05_L03
       jne       short M05_L03
       jne       short M05_L03
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
M05_L01:
       cmp       qword ptr [rbx+8],0
M05_L01:
       cmp       qword ptr [rbx+8],0
M05_L01:
       cmp       qword ptr [rbx+8],0
M05_L01:
       cmp       qword ptr [rbx+8],0
M05_L01:
       cmp       qword ptr [rbx+8],0
M05_L01:
       cmp       qword ptr [rbx+8],0
M05_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M05_L02
       jne       short M05_L02
       jne       short M05_L02
       jne       short M05_L02
       jne       short M05_L02
       jne       short M05_L02
       jne       short M05_L02
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
M05_L02:
       mov       rcx,rbx
M05_L02:
       mov       rcx,rbx
M05_L02:
       mov       rcx,rbx
M05_L02:
       mov       rcx,rbx
M05_L02:
       mov       rcx,rbx
M05_L02:
       mov       rcx,rbx
M05_L02:
       mov       rcx,rbx
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
M05_L03:
       cmp       edi,8
M05_L03:
       cmp       edi,8
M05_L03:
       cmp       edi,8
M05_L03:
       cmp       edi,8
M05_L03:
       cmp       edi,8
M05_L03:
       cmp       edi,8
M05_L03:
       cmp       edi,8
       ja        short M05_L04
       ja        short M05_L04
       ja        short M05_L04
       ja        short M05_L04
       ja        short M05_L04
       ja        short M05_L04
       ja        short M05_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M05_L00]
       lea       rax,[M05_L00]
       lea       rax,[M05_L00]
       lea       rax,[M05_L00]
       lea       rax,[M05_L00]
       lea       rax,[M05_L00]
       lea       rax,[M05_L00]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       jmp       short M05_L01
       jmp       short M05_L01
       jmp       short M05_L01
       jmp       short M05_L01
       jmp       short M05_L01
       jmp       short M05_L01
       jmp       short M05_L01
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       jmp       short M05_L01
       jmp       short M05_L01
       jmp       short M05_L01
       jmp       short M05_L01
       jmp       short M05_L01
       jmp       short M05_L01
       jmp       short M05_L01
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
       je        short M05_L05
       je        short M05_L05
       je        short M05_L05
       je        short M05_L05
       je        short M05_L05
       je        short M05_L05
       je        short M05_L05
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
M05_L04:
       mov       rcx,[rsi+8]
M05_L04:
       mov       rcx,[rsi+8]
M05_L04:
       mov       rcx,[rsi+8]
M05_L04:
       mov       rcx,[rsi+8]
M05_L04:
       mov       rcx,[rsi+8]
M05_L04:
       mov       rcx,[rsi+8]
M05_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
M05_L05:
       mov       rcx,rbx
M05_L05:
       mov       rcx,rbx
M05_L05:
       mov       rcx,rbx
M05_L05:
       mov       rcx,rbx
M05_L05:
       mov       rcx,rbx
M05_L05:
       mov       rcx,rbx
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
; Total bytes of code 1841
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFF2E39C4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rdx,183BE804D98
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
       call      qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L08
       mov       r9d,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       rcx,1C450795700
       mov       r8,1C450780C48
       call      qword ptr [7FFF2DF76B38]; System.String.Concat(System.String, System.String, System.String, System.String)
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
       call      qword ptr [7FFF2E0247B0]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFF2E426298]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M00_L06
       call      qword ptr [7FFF2E4260B8]
       mov       rdi,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1C450790F48
       mov       r8,rdi
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFF2E327D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6B4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7FE1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF7F708]
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M02_L17
M02_L00:
       test      eax,eax
       je        near ptr M02_L18
M02_L01:
       mov       rcx,183BE804DC0
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
       call      qword ptr [7FFF2E1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFF2E1AC150]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFF2E3C7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E1B9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFF2E1AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF2DF773F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFF2E7FF4B0]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFF2E7FF4B0]
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
       call      qword ptr [7FFF2E0247B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFF2E426298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFF2E4260B8]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,1C450789A30
       mov       r8,rsi
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E68F9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E4262B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF2E4260A0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFF2E136670]
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
       mov       rcx,183BE804DC0
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
       call      qword ptr [7FFF2E1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E68F9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 999
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbp,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M03_L00
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M03_L00
       test      rdi,rdi
       je        near ptr M03_L01
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M03_L01
       test      rbp,rbp
       je        near ptr M03_L02
       mov       r13d,[rbp+8]
       test      r13d,r13d
       je        near ptr M03_L02
       test      rbx,rbx
       je        near ptr M03_L03
       cmp       dword ptr [rbx+8],0
       je        near ptr M03_L03
       mov       r12d,r14d
       mov       ecx,r15d
       add       rcx,r12
       mov       eax,r13d
       add       rcx,rax
       mov       eax,[rbx+8]
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M03_L04
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+30],rax
       cmp       [rax],al
       lea       r10,[rax+0C]
       mov       [rsp+28],r10
       mov       rcx,r10
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFF2E025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,[rsp+28]
       lea       rcx,[rsi+r12*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFF2E025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    r8,r14d
       lea       rcx,[rsi+r8*2]
       lea       rdx,[rbp+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFF2E025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
       movsxd    r8,r14d
       lea       rcx,[rsi+r8*2]
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFF2E025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdi,[rsp+30]
       mov       rax,rdi
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
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF2DF76B20]; System.String.Concat(System.String, System.String, System.String)
M03_L01:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF2DF76B20]; System.String.Concat(System.String, System.String, System.String)
M03_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFF2DF76B20]; System.String.Concat(System.String, System.String, System.String)
M03_L03:
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
       jmp       qword ptr [7FFF2DF76B20]; System.String.Concat(System.String, System.String, System.String)
M03_L04:
       call      qword ptr [7FFF2E10EF40]
       int       3
; Total bytes of code 421
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
M04_L00:
       mov       rsi,[rbx+8]
M04_L00:
       mov       rsi,[rbx+8]
M04_L00:
       mov       rsi,[rbx+8]
M04_L00:
       mov       rsi,[rbx+8]
M04_L00:
       mov       rsi,[rbx+8]
M04_L00:
       mov       rsi,[rbx+8]
M04_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M04_L01
       je        short M04_L01
       je        short M04_L01
       je        short M04_L01
       je        short M04_L01
       je        short M04_L01
       je        short M04_L01
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
       jne       short M04_L03
       jne       short M04_L03
       jne       short M04_L03
       jne       short M04_L03
       jne       short M04_L03
       jne       short M04_L03
       jne       short M04_L03
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
M04_L01:
       cmp       qword ptr [rbx+8],0
M04_L01:
       cmp       qword ptr [rbx+8],0
M04_L01:
       cmp       qword ptr [rbx+8],0
M04_L01:
       cmp       qword ptr [rbx+8],0
M04_L01:
       cmp       qword ptr [rbx+8],0
M04_L01:
       cmp       qword ptr [rbx+8],0
M04_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M04_L02
       jne       short M04_L02
       jne       short M04_L02
       jne       short M04_L02
       jne       short M04_L02
       jne       short M04_L02
       jne       short M04_L02
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
M04_L02:
       mov       rcx,rbx
M04_L02:
       mov       rcx,rbx
M04_L02:
       mov       rcx,rbx
M04_L02:
       mov       rcx,rbx
M04_L02:
       mov       rcx,rbx
M04_L02:
       mov       rcx,rbx
M04_L02:
       mov       rcx,rbx
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
M04_L03:
       cmp       edi,8
M04_L03:
       cmp       edi,8
M04_L03:
       cmp       edi,8
M04_L03:
       cmp       edi,8
M04_L03:
       cmp       edi,8
M04_L03:
       cmp       edi,8
M04_L03:
       cmp       edi,8
       ja        short M04_L04
       ja        short M04_L04
       ja        short M04_L04
       ja        short M04_L04
       ja        short M04_L04
       ja        short M04_L04
       ja        short M04_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M04_L00]
       lea       rax,[M04_L00]
       lea       rax,[M04_L00]
       lea       rax,[M04_L00]
       lea       rax,[M04_L00]
       lea       rax,[M04_L00]
       lea       rax,[M04_L00]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
       jmp       short M04_L01
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
       je        short M04_L05
       je        short M04_L05
       je        short M04_L05
       je        short M04_L05
       je        short M04_L05
       je        short M04_L05
       je        short M04_L05
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
M04_L04:
       mov       rcx,[rsi+8]
M04_L04:
       mov       rcx,[rsi+8]
M04_L04:
       mov       rcx,[rsi+8]
M04_L04:
       mov       rcx,[rsi+8]
M04_L04:
       mov       rcx,[rsi+8]
M04_L04:
       mov       rcx,[rsi+8]
M04_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
M04_L05:
       mov       rcx,rbx
M04_L05:
       mov       rcx,rbx
M04_L05:
       mov       rcx,rbx
M04_L05:
       mov       rcx,rbx
M04_L05:
       mov       rcx,rbx
M04_L05:
       mov       rcx,rbx
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
; Total bytes of code 1841
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,1FA24804D98
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
       call      qword ptr [7FFF2E3B6CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E317660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M01_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6A4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7EE1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF6F708]
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
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
M02_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
       je        short M02_L01
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
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
       jne       short M02_L03
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
       jne       short M02_L02
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
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
M02_L02:
       mov       rcx,rbx
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
       lea       rax,[7FFF8D933CC8]
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
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
M02_L03:
       cmp       edi,8
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       ja        short M02_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       lea       rdx,[7FFF8D7B43C8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
       lea       rax,[M02_L00]
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
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       call      qword ptr [7FFF8D933C90]
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
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
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       call      qword ptr [7FFF8D933C98]
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
       jmp       short M02_L01
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
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
       je        short M02_L05
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
M02_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
       call      qword ptr [7FFF8D92B0E8]
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
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       call      qword ptr [7FFF8D933C88]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       call      qword ptr [7FFF8D916918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
       call      qword ptr [7FFF8D9395D0]
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
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       call      qword ptr [7FFF8D933CA0]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       call      qword ptr [7FFF8D933CB0]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
; Total bytes of code 1841
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF2E3BC4B0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L17
M01_L00:
       test      eax,eax
       je        near ptr M01_L18
M01_L01:
       mov       rcx,27973404DC0
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
       call      qword ptr [7FFF2E1CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFF2E1CC150]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFF2E3E7270]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E1D9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M01_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M01_L11
       jmp       short M01_L13
M01_L08:
       mov       edx,eax
       jmp       short M01_L05
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFF2E1CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF2DF973F0]
       jmp       short M01_L16
M01_L12:
       call      qword ptr [7FFF2E81F4B0]
       test      eax,eax
       jne       short M01_L11
M01_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M01_L11
       jmp       short M01_L15
M01_L14:
       call      qword ptr [7FFF2E81F4B0]
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
       call      qword ptr [7FFF2E0447B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L18:
       call      qword ptr [7FFF2E446298]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L19
       call      qword ptr [7FFF2E4460B8]
       mov       rsi,rax
M01_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2BA05279A30
       mov       r8,rsi
       call      qword ptr [7FFF2E04D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E6AF9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E4462B0]
       mov       ecx,9BA
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E256430
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E3C0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF96B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF2E4460A0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFF2E156670]
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
       mov       rcx,27973404DC0
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
       call      qword ptr [7FFF2E1CC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E6AF9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 999
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWords()
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
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       esi,0A
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       edi,5
       mov       ecx,1
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M00_L16
M00_L00:
       test      eax,eax
       je        near ptr M00_L17
M00_L01:
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       ebp,0A
       mov       ecx,1
       mov       edx,ecx
       test      ecx,ecx
       je        near ptr M00_L19
M00_L02:
       test      edx,edx
       je        near ptr M00_L20
M00_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,esi
       call      qword ptr [7FFF2E02DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r15d,r15d
       test      esi,esi
       jle       near ptr M00_L14
M00_L04:
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M00_L22
       xor       r13d,r13d
       cmp       edi,7FFFFFFF
       setle     r13b
       mov       eax,r13d
       test      r13d,r13d
       je        near ptr M00_L23
M00_L05:
       test      eax,eax
       je        near ptr M00_L32
M00_L06:
       mov       edx,ebp
       test      edx,edx
       jle       near ptr M00_L24
       xor       r12d,r12d
       cmp       ebp,7FFFFFFF
       setle     r12b
       mov       r8d,r12d
       test      r12d,r12d
       je        near ptr M00_L25
M00_L07:
       test      r8d,r8d
       je        near ptr M00_L34
M00_L08:
       test      ecx,ecx
       jle       near ptr M00_L26
       xor       r10d,r10d
       cmp       ecx,7FFFFFFF
       setle     r10b
       mov       r9d,r10d
       test      r10d,r10d
       je        near ptr M00_L27
M00_L09:
       test      r9d,r9d
       je        near ptr M00_L36
M00_L10:
       test      edx,edx
       jle       near ptr M00_L28
       xor       r11d,r11d
       cmp       edx,7FFFFFFF
       setle     r11b
       mov       eax,r11d
       test      r11d,r11d
       je        near ptr M00_L29
M00_L11:
       test      eax,eax
       je        near ptr M00_L38
       mov       eax,ecx
       add       eax,1
       jo        near ptr M00_L15
       cmp       edx,eax
       jl        near ptr M00_L30
M00_L12:
       call      qword ptr [7FFF2E3C6CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFF2E397AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rsi
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
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L15:
       call      CORINFO_HELP_OVERFLOW
M00_L16:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0247B0]
       mov       edi,eax
       jmp       near ptr M00_L01
M00_L17:
       call      qword ptr [7FFF2E4259F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L18
       call      qword ptr [7FFF2E425818]
       mov       rbx,rax
M00_L18:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24678C10F20
       mov       r8,rbx
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L19:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L02
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF2E0247B0]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L20:
       call      qword ptr [7FFF2E4259F8]
       mov       r13,rax
       test      r13,r13
       jne       short M00_L21
       call      qword ptr [7FFF2E425818]
       mov       r13,rax
M00_L21:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,24678C10F48
       mov       r8,r13
       call      qword ptr [7FFF2E02D470]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M00_L22:
       xor       r13d,r13d
       mov       eax,r13d
       test      r13d,r13d
       jne       near ptr M00_L05
M00_L23:
       mov       ecx,1
       jmp       near ptr M00_L06
M00_L24:
       xor       r12d,r12d
       mov       r8d,r12d
       test      r12d,r12d
       jne       near ptr M00_L07
M00_L25:
       mov       edx,1
       jmp       near ptr M00_L08
M00_L26:
       xor       r10d,r10d
       mov       r9d,r10d
       test      r10d,r10d
       jne       near ptr M00_L09
M00_L27:
       mov       ecx,1
       jmp       near ptr M00_L10
M00_L28:
       xor       r11d,r11d
       mov       eax,r11d
       test      r11d,r11d
       jne       near ptr M00_L11
M00_L29:
       mov       edx,1
       mov       eax,ecx
       add       eax,1
       jo        near ptr M00_L15
       cmp       edx,eax
       jge       near ptr M00_L12
M00_L30:
       mov       edx,eax
       jmp       near ptr M00_L12
M00_L31:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FFF2E02E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L13
M00_L32:
       call      qword ptr [7FFF2E4259F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L33
       call      qword ptr [7FFF2E425818]
       mov       rbx,rax
M00_L33:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24678C10F20
       mov       r8,rbx
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L34:
       call      qword ptr [7FFF2E4259F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L35
       call      qword ptr [7FFF2E425818]
       mov       rbx,rax
M00_L35:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24678C10F48
       mov       r8,rbx
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L36:
       call      qword ptr [7FFF2E4259F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L37
       call      qword ptr [7FFF2E425818]
       mov       rbx,rax
M00_L37:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24678C10F20
       mov       r8,rbx
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L38:
       call      qword ptr [7FFF2E4259F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L39
       call      qword ptr [7FFF2E425818]
       mov       rbx,rax
M00_L39:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24678C10F48
       mov       r8,rbx
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1152
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
       mov       rdx,7FFF2E62FCA8
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
       call      qword ptr [7FFF2E10ED48]
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
       mov       rdx,7FFF2E62FC98
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M02_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF8043C3670
       call      rax
M02_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF8DE2A0DC],0
       je        short M02_L02
       call      qword ptr [7FFF8DE1A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF2E6B4E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF2E7FEBF8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF7F708]
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
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M03_L17
M03_L00:
       test      eax,eax
       je        near ptr M03_L18
M03_L01:
       mov       rcx,205E8C04DC0
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
       call      qword ptr [7FFF2E1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFF2E1AC150]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFF2E3C6CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFF2E1B9518]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M03_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M03_L12
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L13
M03_L08:
       mov       edx,eax
       jmp       short M03_L05
M03_L09:
       mov       rcx,r15
       call      qword ptr [7FFF2E1AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M03_L06
M03_L10:
       call      CORINFO_HELP_OVERFLOW
M03_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF2DF773F0]
       jmp       short M03_L16
M03_L12:
       call      qword ptr [7FFF2E8240F0]
       test      eax,eax
       jne       short M03_L11
M03_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L14
       mov       rax,7FFF8CEC2E48
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L15
M03_L14:
       call      qword ptr [7FFF2E8240F0]
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
       call      qword ptr [7FFF2E0247B0]
       mov       ebx,eax
       jmp       near ptr M03_L01
M03_L18:
       call      qword ptr [7FFF2E4259F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M03_L19
       call      qword ptr [7FFF2E425818]
       mov       rsi,rax
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,24678C09A30
       mov       r8,rsi
       call      qword ptr [7FFF2E02D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFF2E68F9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF2E425A10]
       mov       ecx,9BA
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1436
       mov       rdx,7FFF2E236460
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF2E3A0000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF2DF76B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFF2E425800]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFF2E136670]
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
       mov       rcx,205E8C04DC0
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
       call      qword ptr [7FFF2E1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFF2E68F9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 999
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
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
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       lea       ebp,[rdi+1]
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFF8D934F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       movsxd    rdx,edi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       mov       r8,rsi
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFF8D913D48]; CORINFO_HELP_ARRADDR_ST
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
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
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
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
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
; Total bytes of code 1260
```

