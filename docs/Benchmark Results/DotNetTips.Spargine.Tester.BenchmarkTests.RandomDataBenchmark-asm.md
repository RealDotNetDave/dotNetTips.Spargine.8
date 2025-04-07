## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacterMinMax()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edx,0FFFF
       xor       ecx,ecx
       call      qword ptr [7FFC48A76CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D64E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48EAE868]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4862F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,2246C845900
       cmp       [rcx],ecx
       call      qword ptr [7FFC48607318]; System.String.Trim()
       mov       rbp,rax
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,1E3DE801DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC488D27F0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFC48A27AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rsp+40]
       mov       [rsp+40],r14d
M00_L01:
       lea       rcx,[rsp+30]
       mov       edx,2E
       call      qword ptr [7FFC48E3E4F0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
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
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r15d,[rsp+40]
       mov       [rsp+40],r15d
M00_L02:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFC48805D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48907288]; System.IO.Path.Combine(System.String, System.String)
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFC48E3E508]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFC48805E90]
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFC488B57E8]
       int       3
M00_L06:
       lea       rcx,[rsp+30]
       mov       rdx,rbp
       call      qword ptr [7FFC48805E90]
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
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFC48E8F648]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFC48E8F648]
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
       call      qword ptr [7FFC486073F0]
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
       mov       rcx,1E3DE8005D0
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,7FFC48545120
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
       mov       rcx,7FFC48545120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFC48545C38],0
       je        short M02_L02
       call      qword ptr [7FFC4860DC98]
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
       call      qword ptr [7FFC48E8D938]
       jmp       short M02_L04
M02_L03:
       mov       eax,ebx
       sar       eax,10
M02_L04:
       mov       ebx,eax
M02_L05:
       mov       rcx,7FFC48545120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFC48545C2C]
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
       call      qword ptr [7FFC488BEB80]
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
       mov       rcx,7FFC48545120
       mov       edx,5C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1E3DE801F70
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
       mov       rdx,2246C8372C0
       call      qword ptr [7FFC489D6F88]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFC488BEB80]
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
       call      qword ptr [7FFC488BEB98]
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
       call      qword ptr [7FFC488BEB80]
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
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M03_L17
M03_L00:
       test      eax,eax
       je        near ptr M03_L18
M03_L01:
       mov       rcx,1E3DA802DC8
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
       call      qword ptr [7FFC4877D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFC4877D050]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC487932D8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        near ptr M03_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M03_L12
       mov       ecx,ecx
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L13
M03_L08:
       mov       edx,eax
       jmp       short M03_L05
M03_L09:
       mov       rcx,r15
       call      qword ptr [7FFC4877D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M03_L06
M03_L10:
       call      CORINFO_HELP_OVERFLOW
M03_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC486073F0]
       jmp       short M03_L16
M03_L12:
       call      qword ptr [7FFC48E8F648]
       test      eax,eax
       jne       short M03_L11
M03_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L14
       mov       ecx,ecx
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L15
M03_L14:
       call      qword ptr [7FFC48E8F648]
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
       call      qword ptr [7FFC486B47B0]
       mov       ebx,eax
       jmp       near ptr M03_L01
M03_L18:
       call      qword ptr [7FFC48AB59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M03_L19
       call      qword ptr [7FFC48AB5818]
       mov       rsi,rax
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2246C839A30
       mov       r8,rsi
       call      qword ptr [7FFC486BD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D1F708]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48AB5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A30BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC488D6C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A30BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFC48AB5800]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFC48736718]
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
       mov       rcx,1E3DA802DC8
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
       call      qword ptr [7FFC4877D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D1F6D8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 993
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
       jmp       qword ptr [7FFC486B5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC48805F80]
       jmp       short M05_L00
M05_L02:
       call      qword ptr [7FFC488B57E8]
       int       3
M05_L03:
       movzx     edx,si
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFC48E8F948]
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
       mov       rcx,1E3DE801DE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC488D27F8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M06_L00:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M06_L01:
       call      qword ptr [7FFC488B57E8]
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
       jmp       qword ptr [7FFC489073C0]; System.IO.Path.CombineInternal(System.String, System.String)
M07_L00:
       mov       ecx,1B53B
       mov       rdx,7FFC484B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC48736790]
       int       3
M07_L01:
       mov       ecx,1B547
       mov       rdx,7FFC484B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC48736790]
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FFC48A37AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       mov       rcx,21AFF004DC0
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
       call      qword ptr [7FFC4878D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFC4878D050]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFC48A66CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC487A32D8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L14
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L11
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L15
       jmp       short M01_L12
M01_L08:
       mov       edx,eax
       jmp       short M01_L05
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFC4878D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      qword ptr [7FFC48E4E6B8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L15
M01_L12:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L13
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L15
       jmp       short M01_L14
M01_L13:
       call      qword ptr [7FFC48E4E6B8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L15
M01_L14:
       mov       rax,rsi
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFC486173F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFC486C47B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L18:
       call      qword ptr [7FFC48AC59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L19
       call      qword ptr [7FFC48AC5818]
       mov       rsi,rax
M01_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,25B91129A30
       mov       r8,rsi
       call      qword ptr [7FFC486CD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D2F708]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48AC5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A40BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC488E6C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48616B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A40BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48616B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFC48AC5800]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFC48746718]
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
       mov       rcx,21AFF004DC0
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
       call      qword ptr [7FFC4878D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D2F6D8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       xor       edx,edx
       mov       r8d,0FFFF
       call      qword ptr [7FFC48A27AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       call      qword ptr [7FFC486B47B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFC48AB59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFC48AB5818]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,231B31D0F48
       mov       r8,rbx
       call      qword ptr [7FFC486BD470]
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
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D44E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48E8E208]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4860F708]
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
       mov       rcx,1F121402DC8
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
       call      qword ptr [7FFC4877D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFC4877D050]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC487932D8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L14
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M02_L11
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L15
       jmp       short M02_L12
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFC4877D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       call      qword ptr [7FFC48E3E6B8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M02_L15
M02_L12:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L13
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L15
       jmp       short M02_L14
M02_L13:
       call      qword ptr [7FFC48E3E6B8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M02_L15
M02_L14:
       mov       rax,rsi
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFC486073F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFC486B47B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFC48AB59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFC48AB5818]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,231B31C9A30
       mov       r8,rsi
       call      qword ptr [7FFC486BD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D1FA38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48AB5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A30BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC488D6C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A30BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFC48AB5800]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFC48736718]
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
       mov       rcx,1F121402DC8
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
       call      qword ptr [7FFC4877D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D1FA08]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FFC48A66CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFC48A37AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       call      qword ptr [7FFC486C47B0]
       mov       edi,eax
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FFC48AC59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L09
       call      qword ptr [7FFC48AC5818]
       mov       rbx,rax
M00_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2AAAEE90F48
       mov       r8,rbx
       call      qword ptr [7FFC486CD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L10:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L02
       lea       rcx,[rsp+30]
       call      qword ptr [7FFC486C47B0]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFC48AC59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FFC48AC5818]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2AAAEE90F20
       mov       r8,rbx
       call      qword ptr [7FFC486CD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L13:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M00_L04
       lea       rcx,[rsp+30]
       call      qword ptr [7FFC486C47B0]
       mov       edi,eax
       jmp       near ptr M00_L05
M00_L14:
       call      qword ptr [7FFC48AC59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L15
       call      qword ptr [7FFC48AC5818]
       mov       rbx,rax
M00_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2AAAEE90F48
       mov       r8,rbx
       call      qword ptr [7FFC486CD470]
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
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-80],rax
       lea       rax,[M01_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D54E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48E9E1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4861F708]
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
       mov       rcx,26A21004DC0
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
       call      qword ptr [7FFC4878D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFC4878D050]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFC48A66CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC487A32D8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFC4878D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC486173F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFC48E9F4B0]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFC48E9F4B0]
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
       call      qword ptr [7FFC486C47B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFC48AC59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFC48AC5818]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2AAAEE89A30
       mov       r8,rsi
       call      qword ptr [7FFC486CD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D2FA38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48AC5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A40BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC488E6C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48616B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A40BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48616B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFC48AC5800]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFC48746718]
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
       mov       rcx,26A21004DC0
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
       call      qword ptr [7FFC4878D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D2FA08]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edx,7A
       mov       ecx,61
       call      qword ptr [7FFC48A86CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D74E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48EBE1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4863F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCoordinate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFC48A76CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFC48A76CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       edi,eax
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFC48A76CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       [rsp+20],esi
       mov       [rsp+24],edi
       mov       [rsp+28],eax
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFC48E5E508]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate ByRef)
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
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D64E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48EAE160]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4862F708]
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       vmovsd    xmm0,qword ptr [7FFC48D84380]
       call      System.Math.Pow(Double, Double)
       vxorps    xmm1,xmm1,xmm1
       vmovups   [rsp+0A8],xmm1
       lea       rdx,[rsp+0A8]
       call      qword ptr [7FFC48E2E8F8]; System.Decimal+DecCalc.VarDecFromR8(Double, DecCalc ByRef)
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
       call      qword ptr [7FFC48E2E8C8]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+98]
       vmovups   [rsp+28],xmm0
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC486AFED0]; System.Decimal.ToInt32(System.Decimal)
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
       call      qword ptr [7FFC48E2E8C8]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+78]
       vmovups   [rsp+28],xmm0
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC486AFED0]; System.Decimal.ToInt32(System.Decimal)
       mov       edx,r14d
       add       edx,1
       jo        short M00_L01
       cmp       eax,edx
       cmovge    edx,eax
       mov       ecx,r14d
       call      qword ptr [7FFC48A46CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC48E2E958]; System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+58]
       vmovups   [rsp+38],xmm0
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+38]
       call      qword ptr [7FFC48E2EAF0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
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
       js        near ptr M01_L16
       cmp       ecx,1C
       jg        near ptr M01_L15
M01_L01:
       cmp       ecx,51
       jae       near ptr M01_L24
       mov       eax,ecx
       mov       rdx,7FFC9C0D9F08
       vmulsd    xmm0,xmm0,qword ptr [rdx+rax*8]
M01_L02:
       vmovsd    xmm1,qword ptr [7FFC48D84A50]
       vucomisd  xmm1,xmm0
       ja        near ptr M01_L19
M01_L03:
       vroundsd  xmm0,xmm0,xmm0,4
       vcvttsd2si r10,xmm0
       test      r10,r10
       je        near ptr M01_L20
       test      ecx,ecx
       jl        near ptr M01_L10
       mov       r8d,ecx
       cmp       r8d,0E
       jg        near ptr M01_L21
M01_L04:
       test      r10b,r10b
       jne       short M01_L05
       cmp       r8d,8
       jl        short M01_L05
       mov       rdx,0ABCC77118461CEFD
       mov       rax,r10
       mul       rdx
       shr       rdx,1A
       imul      eax,edx,5F5E100
       cmp       r10d,eax
       jne       short M01_L05
       mov       r10,rdx
       add       ecx,0FFFFFFF8
       add       r8d,0FFFFFFF8
M01_L05:
       test      r10b,0F
       jne       short M01_L06
       cmp       r8d,4
       jl        short M01_L06
       mov       rdx,346DC5D63886594B
       mov       rax,r10
       mul       rdx
       shr       rdx,0B
       imul      eax,edx,2710
       cmp       r10d,eax
       jne       short M01_L06
       mov       r10,rdx
       add       ecx,0FFFFFFFC
       add       r8d,0FFFFFFFC
M01_L06:
       test      r10b,3
       jne       short M01_L07
       cmp       r8d,2
       jge       near ptr M01_L22
M01_L07:
       test      r10b,1
       jne       short M01_L08
       test      r8d,r8d
       jg        near ptr M01_L23
M01_L08:
       shl       ecx,10
       or        esi,ecx
       mov       [rbx+8],r10
M01_L09:
       mov       [rbx],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L10:
       neg       ecx
       cmp       ecx,0A
       jge       short M01_L11
       cmp       ecx,0A
       jae       near ptr M01_L24
       mov       rax,7FFC9C0DE1A8
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
       jmp       short M01_L09
M01_L11:
       lea       edx,[rcx-1]
       cmp       edx,13
       jae       near ptr M01_L24
       lea       edx,[rcx-1]
       mov       rcx,7FFC9C0E5C88
       mov       rdx,[rcx+rdx*8]
       mov       rcx,r10
       mov       r8,rbx
       call      qword ptr [7FFC48E2E730]
       jmp       short M01_L09
M01_L12:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L13:
       mov       ecx,0FB09
       mov       rdx,7FFC484A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC48AED3F8]
       mov       rcx,rax
       call      qword ptr [7FFC48724D98]
       int       3
M01_L14:
       vxorps    xmm0,xmm0,[7FFC48D84A60]
       mov       esi,80000000
       jmp       near ptr M01_L00
M01_L15:
       mov       ecx,1C
       jmp       near ptr M01_L01
M01_L16:
       cmp       ecx,0FFFFFFFF
       jne       short M01_L17
       vucomisd  xmm0,qword ptr [7FFC48D84A70]
       jb        short M01_L18
M01_L17:
       mov       edx,ecx
       neg       edx
       cmp       edx,51
       jae       near ptr M01_L24
       mov       r8,7FFC9C0D9F08
       vdivsd    xmm0,xmm0,[r8+rdx*8]
       jmp       near ptr M01_L02
M01_L18:
       xor       ecx,ecx
       vmovsd    xmm1,qword ptr [7FFC48D84A50]
       vucomisd  xmm1,xmm0
       jbe       near ptr M01_L03
M01_L19:
       cmp       ecx,1C
       jge       near ptr M01_L03
       vmulsd    xmm0,xmm0,qword ptr [7FFC48D84A78]
       inc       ecx
       jmp       near ptr M01_L03
M01_L20:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L21:
       mov       r8d,0E
       jmp       near ptr M01_L04
M01_L22:
       mov       rdx,28F5C28F5C28F5C3
       mov       rax,r10
       shr       rax,2
       mul       rdx
       shr       rdx,2
       imul      eax,edx,64
       cmp       r10d,eax
       jne       near ptr M01_L07
       mov       r10,rdx
       add       ecx,0FFFFFFFE
       add       r8d,0FFFFFFFE
       jmp       near ptr M01_L07
M01_L23:
       mov       rdx,0CCCCCCCCCCCCCCCD
       mov       rax,r10
       mul       rdx
       shr       rdx,3
       lea       eax,[rdx+rdx*4]
       add       eax,eax
       cmp       r10d,eax
       jne       near ptr M01_L08
       mov       r10,rdx
       dec       ecx
       jmp       near ptr M01_L08
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 748
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
       call      qword ptr [7FFC48E2E7F0]
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
       mov       rdx,7FFC9C0E5C88
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
       call      qword ptr [7FFC48E2E9A0]
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
       call      qword ptr [7FFC48B06C70]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48D373A8]
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
       mov       rax,7FFCED883670
       call      rax
M04_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M04_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D34E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M04_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48E7E658]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC485FF708]
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
       jne       near ptr M05_L25
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M05_L21
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
       jne       near ptr M05_L11
       test      edi,edi
       jl        near ptr M05_L13
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
       jne       near ptr M05_L16
       jmp       near ptr M05_L18
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
       mov       ebp,1
       cmp       edi,1C
       je        near ptr M05_L23
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFC48E2E838]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M05_L23
M05_L12:
       cmp       r12d,0A
       jae       near ptr M05_L40
       mov       eax,r12d
       mov       rdx,7FFC9C0DE1A8
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
       jne       near ptr M05_L20
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
       je        near ptr M05_L24
       jmp       near ptr M05_L03
M05_L13:
       mov       r13d,edi
       neg       r13d
       cmp       r13d,9
       jl        near ptr M05_L22
       mov       r12d,9
M05_L14:
       jmp       near ptr M05_L12
M05_L15:
       add       edi,0FFFFFFFE
M05_L16:
       test      cl,1
       jne       short M05_L17
       test      edi,edi
       jle       short M05_L17
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
       jne       short M05_L17
       mov       r8,r10
       mov       ecx,edx
       dec       edi
M05_L17:
       mov       [rbx+8],ecx
       mov       [rbx+0C],r8d
       shr       r8,20
       mov       [rbx+4],r8d
       jmp       near ptr M05_L10
M05_L18:
       cmp       edi,2
       jl        short M05_L16
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
       jne       near ptr M05_L16
       mov       r8,r10
       mov       ecx,edx
       jmp       near ptr M05_L15
M05_L19:
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
       call      qword ptr [7FFC48E2E820]
       mov       edi,eax
       jmp       near ptr M05_L04
M05_L20:
       mov       ecx,0FB09
       mov       rdx,7FFC484A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC48AED3F8]
       mov       rcx,rax
       call      qword ptr [7FFC48724D98]
       int       3
M05_L21:
       mov       rcx,offset MT_System.DivideByZeroException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFC48E2E9E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M05_L22:
       mov       r12d,r13d
       jmp       near ptr M05_L14
M05_L23:
       lea       r13d,[r15+r15]
       cmp       r13d,r15d
       jb        near ptr M05_L19
       cmp       r13d,r14d
       jb        near ptr M05_L04
       ja        near ptr M05_L19
       test      byte ptr [rsp+48],1
       je        near ptr M05_L04
       jmp       near ptr M05_L19
M05_L24:
       xor       r8d,r8d
       test      r15d,r15d
       setne     r8b
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFC48E2E820]
       mov       edi,eax
       jmp       near ptr M05_L04
M05_L25:
       mov       r13d,[rsi+4]
       test      r13d,r13d
       jne       short M05_L26
       mov       r13d,[rsi+0C]
M05_L26:
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
       jne       near ptr M05_L33
       xor       ecx,ecx
       mov       [rsp+50],ecx
       lea       rcx,[rsp+3C]
       mov       rdx,r13
       call      qword ptr [7FFC48E2E790]
       mov       [rsp+4C],eax
       lea       rcx,[rsp+38]
       mov       rdx,r13
       call      qword ptr [7FFC48E2E790]
       mov       [rsp+48],eax
M05_L27:
       cmp       qword ptr [rsp+38],0
       jne       short M05_L30
       test      edi,edi
       jge       near ptr M05_L04
       mov       r12d,edi
       neg       r12d
       cmp       r12d,9
       jge       short M05_L28
       jmp       short M05_L29
M05_L28:
       mov       r12d,9
M05_L29:
       jmp       short M05_L32
M05_L30:
       mov       ebp,1
       cmp       edi,1C
       je        short M05_L31
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFC48E2E838]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       r12d,eax
       test      r12d,r12d
       jne       short M05_L32
M05_L31:
       mov       rcx,[rsp+38]
       test      rcx,rcx
       jl        near ptr M05_L19
       add       rcx,rcx
       cmp       rcx,r13
       ja        near ptr M05_L19
       jne       near ptr M05_L04
       test      byte ptr [rsp+48],1
       je        near ptr M05_L04
       jmp       near ptr M05_L19
M05_L32:
       cmp       r12d,0A
       jae       near ptr M05_L40
       mov       ecx,r12d
       mov       rdx,7FFC9C0DE1A8
       mov       ecx,[rdx+rcx*4]
       mov       r14d,ecx
       add       edi,r12d
       lea       rcx,[rsp+48]
       mov       edx,r14d
       call      qword ptr [7FFC48E2E7C0]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M05_L20
       lea       rcx,[rsp+38]
       mov       edx,r14d
       call      qword ptr [7FFC48E2E7D8]
       lea       rcx,[rsp+38]
       mov       rdx,r13
       call      qword ptr [7FFC48E2E790]
       mov       edx,eax
       lea       rcx,[rsp+48]
       call      qword ptr [7FFC48E2E850]; System.Decimal+DecCalc.Add32To96(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M05_L27
       xor       r8d,r8d
       cmp       qword ptr [rsp+38],0
       setne     r8b
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFC48E2E820]
       mov       edi,eax
       jmp       near ptr M05_L04
M05_L33:
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
       call      qword ptr [7FFC48E2E7A8]
       mov       ecx,eax
       mov       [rsp+48],rcx
       xor       ecx,ecx
       mov       [rsp+50],ecx
M05_L34:
       mov       ecx,[rsp+40]
       or        rcx,[rsp+38]
       jne       short M05_L37
       test      edi,edi
       jge       near ptr M05_L04
       mov       r12d,edi
       neg       r12d
       cmp       r12d,9
       jge       short M05_L35
       jmp       short M05_L36
M05_L35:
       mov       r12d,9
M05_L36:
       jmp       near ptr M05_L39
M05_L37:
       mov       ebp,1
       cmp       edi,1C
       je        short M05_L38
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFC48E2E838]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       r12d,eax
       test      r12d,r12d
       jne       short M05_L39
M05_L38:
       cmp       dword ptr [rsp+40],0
       jl        near ptr M05_L19
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
       ja        near ptr M05_L19
       mov       ecx,[rsp+40]
       cmp       ecx,[rsp+30]
       jne       near ptr M05_L04
       mov       rcx,[rsp+38]
       cmp       rcx,[rsp+28]
       ja        near ptr M05_L19
       mov       rcx,[rsp+38]
       cmp       rcx,[rsp+28]
       jne       near ptr M05_L04
       test      byte ptr [rsp+48],1
       je        near ptr M05_L04
       jmp       near ptr M05_L19
M05_L39:
       cmp       r12d,0A
       jae       near ptr M05_L40
       mov       ecx,r12d
       mov       rdx,7FFC9C0DE1A8
       mov       r14d,[rdx+rcx*4]
       add       edi,r12d
       lea       rcx,[rsp+48]
       mov       edx,r14d
       call      qword ptr [7FFC48E2E7C0]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M05_L20
       lea       rcx,[rsp+38]
       mov       edx,r14d
       call      qword ptr [7FFC48E2E7C0]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       mov       [rsp+44],eax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FFC48E2E7A8]
       mov       edx,eax
       lea       rcx,[rsp+48]
       call      qword ptr [7FFC48E2E850]; System.Decimal+DecCalc.Add32To96(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M05_L34
       mov       r8,[rsp+38]
       or        r8,[rsp+40]
       setne     r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+48]
       mov       edx,edi
       call      qword ptr [7FFC48E2E820]
       mov       edi,eax
       jmp       near ptr M05_L04
M05_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1941
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       ret
; Total bytes of code 1
```
**Extern method**
System.Math.Pow(Double, Double)

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,1BD5A802DA0
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC489B7660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D44E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48E8E1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4860F708]
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
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
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
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
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
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
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
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
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
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
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
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
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
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
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
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
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
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
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
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
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
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
; Total bytes of code 1841
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFC48A27AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,24A0B790ED8
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFC48A27AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,24A0B780760
       mov       [rsi+28],rdx
       mov       rdx,20979802DA0
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[r14+8]
       jae       near ptr M00_L13
       mov       ecx,eax
       mov       rdx,[r14+rcx*8+10]
       lea       rcx,[rsi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      qword ptr [7FFC48606BB0]; System.String.Concat(System.String[])
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
       call      qword ptr [7FFC486B47B0]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L07:
       call      qword ptr [7FFC48AB59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFC48AB5818]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24A0B790F48
       mov       r8,rbx
       call      qword ptr [7FFC486BD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L09:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        near ptr M00_L02
       lea       rcx,[rsp+30]
       call      qword ptr [7FFC486B47B0]
       mov       ecx,eax
       jmp       near ptr M00_L03
M00_L10:
       call      qword ptr [7FFC48AB59F8]
       mov       r14,rax
       test      r14,r14
       jne       short M00_L11
       call      qword ptr [7FFC48AB5818]
       mov       r14,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,24A0B790F48
       mov       r8,r14
       call      qword ptr [7FFC486BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L12:
       call      qword ptr [7FFC489B7660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D44E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48E8E8B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4860F708]
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
       mov       rcx,20979802DC8
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
       call      qword ptr [7FFC4877D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFC4877D050]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC487932D8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFC4877D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC486073F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFC48E8FBB8]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFC48E8FBB8]
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
       call      qword ptr [7FFC486B47B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFC48AB59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFC48AB5818]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,24A0B789A30
       mov       r8,rsi
       call      qword ptr [7FFC486BD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D1FA38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48AB5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A30BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC488D6C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A30BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFC48AB5800]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFC48736718]
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
       mov       rcx,20979802DC8
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
       call      qword ptr [7FFC4877D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D1FA08]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC48554018]; System.Object.MemberwiseClone()
       mov       rbx,rax
       test      rbx,rbx
       jne       near ptr M03_L00
M03_L12:
       mov       ecx,1771
       mov       rdx,7FFC484B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC48736790]
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
       mov       rax,24A0B780008
       jmp       short M03_L09
M03_L15:
       mov       rax,24A0B780008
M03_L16:
       jmp       short M03_L09
M03_L17:
       call      qword ptr [7FFC488B5D58]
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
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
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
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
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
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
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
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
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
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
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
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
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
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
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
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
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
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
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
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
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
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
; Total bytes of code 1841
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rbp,2900C59590C
       mov       rcx,rbp
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],0D
       lea       rcx,[rsp+40]
       call      qword ptr [7FFC48907618]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
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
       mov       rcx,2900C5887F4
       mov       [rsp+40],rsi
       mov       [rsp+48],edi
       mov       [rsp+30],rcx
       mov       dword ptr [rsp+38],1
       mov       [rsp+20],rbp
       mov       dword ptr [rsp+28],0D
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       call      qword ptr [7FFC48606B68]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
       jmp       short M00_L03
M00_L02:
       mov       [rsp+40],rsi
       mov       [rsp+48],edi
       mov       [rsp+30],rbp
       mov       dword ptr [rsp+38],0D
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       call      qword ptr [7FFC48606B50]
       mov       rcx,rax
M00_L03:
       mov       edx,400
       call      qword ptr [7FFC48A277E0]; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
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
       mov       rdx,7FFC484B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC48736790]
       int       3
M00_L05:
       mov       rcx,2900C595900
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
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,ebp
       lea       rcx,[r12+r8*2]
       mov       r8d,r14d
       sub       r8d,ebp
       cmp       esi,r8d
       ja        short M02_L02
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2900C580008
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
       call      qword ptr [7FFC488B5800]
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
       mov       rbx,rcx
       mov       esi,edx
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
       call      qword ptr [7FFC48607318]; System.String.Trim()
       mov       rbx,rax
       mov       byte ptr [rsp+20],1
       mov       dword ptr [rsp+24],1
       mov       edx,esi
       xor       ecx,ecx
       test      edx,edx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        short M03_L06
M03_L02:
       test      eax,eax
       je        short M03_L07
M03_L03:
       mov       rcx,rbx
       call      qword ptr [7FFC48A276A8]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L04:
       call      qword ptr [7FFC48AB5AB8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L05
       call      qword ptr [7FFC48AB5800]
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2900C595930
       mov       r8,rbx
       call      qword ptr [7FFC48736718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L06:
       movzx     ecx,byte ptr [rsp+20]
       test      cl,cl
       je        short M03_L02
       lea       rcx,[rsp+20]
       call      qword ptr [7FFC486B47B0]
       mov       edx,eax
       jmp       short M03_L03
M03_L07:
       call      qword ptr [7FFC48AB59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L08
       call      qword ptr [7FFC48AB5818]
       mov       rbx,rax
M03_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2900C595958
       mov       r8,rbx
       call      qword ptr [7FFC486BD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 285
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FFC48A37810]; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
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
       sub       rsp,118
       vzeroupper
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rsp+110],rax
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
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
       je        near ptr M01_L32
       cmp       dword ptr [rbx+8],0
       je        short M01_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L03
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L34
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFC48EC7738]
       test      eax,eax
       jne       near ptr M01_L34
M01_L04:
       mov       ecx,[rbx+8]
       dec       ecx
       cmp       ecx,[rbx+8]
       jae       near ptr M01_L73
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L34
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFC48EC7738]
       test      eax,eax
       jne       near ptr M01_L34
M01_L06:
       mov       byte ptr [rsp+110],1
       mov       dword ptr [rsp+114],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L35
M01_L07:
       test      eax,eax
       je        near ptr M01_L36
M01_L08:
       mov       byte ptr [rsp+110],1
       mov       dword ptr [rsp+114],1
       xor       ecx,ecx
       test      edi,edi
       setg      cl
       mov       edx,ecx
       test      ecx,ecx
       je        near ptr M01_L38
M01_L09:
       test      edx,edx
       je        near ptr M01_L39
M01_L10:
       test      rbx,rbx
       je        near ptr M01_L42
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L42
       mov       rcx,rbx
       call      qword ptr [7FFC48917558]; System.IO.Path.GetFullPath(System.String)
       mov       rbp,rax
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFC4898E1C0]; System.IO.FileSystem.CreateDirectory(System.String, Byte[])
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
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      esi,esi
       jl        near ptr M01_L41
       test      esi,esi
       je        near ptr M01_L43
       movsxd    rdx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L11:
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M01_L21
M01_L12:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   xmmword ptr [rsp+100],xmm0
       mov       r15d,0A
       mov       r13,295DCD95930
       xor       ecx,ecx
       mov       [rsp+0E8],rcx
       mov       rcx,2554F001DE8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFC488E27F0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0F0],rax
       test      rax,rax
       je        near ptr M01_L44
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L13:
       mov       [rsp+100],r10
       mov       [rsp+108],eax
       xor       ecx,ecx
       mov       [rsp+0F8],ecx
       mov       byte ptr [rsp+0FC],0
       mov       ecx,r15d
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFC48A37AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r15,rax
       cmp       byte ptr [rsp+0FC],0
       jne       near ptr M01_L45
       test      r15,r15
       je        near ptr M01_L45
       mov       r8d,[rsp+0F8]
       cmp       r8d,[rsp+108]
       ja        near ptr M01_L71
       mov       rcx,[rsp+100]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+108]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M01_L45
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC486C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+0F8]
       add       ecx,[r15+8]
       mov       [rsp+0F8],ecx
M01_L14:
       lea       rcx,[rsp+0E8]
       mov       edx,2E
       call      qword ptr [7FFC48E4E5F8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+0FC],0
       jne       near ptr M01_L46
       test      r13,r13
       je        near ptr M01_L46
       mov       r8d,[rsp+0F8]
       cmp       r8d,[rsp+108]
       ja        near ptr M01_L71
       mov       rcx,[rsp+100]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+108]
       sub       edx,r8d
       cmp       [r13+8],edx
       ja        near ptr M01_L46
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFC486C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+0F8]
       add       ecx,[r13+8]
       mov       [rsp+0F8],ecx
M01_L15:
       mov       ecx,[rsp+0F8]
       cmp       ecx,[rsp+108]
       ja        near ptr M01_L71
       mov       rax,[rsp+100]
       mov       [rsp+88],rax
       mov       [rsp+90],ecx
       lea       rcx,[rsp+88]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       mov       r13,[rsp+0F0]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   xmmword ptr [rsp+100],xmm0
       test      r13,r13
       je        near ptr M01_L18
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rsp+0E4],eax
       mov       rcx,7FFC48555120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M01_L47
M01_L16:
       xor       eax,eax
       mov       dword ptr [rsp+0DC],1
       mov       r10d,[rsp+0E4]
       cmp       [rcx+8],r10d
       jbe       near ptr M01_L17
       mov       dword ptr [rsp+0E0],1
       mov       edx,10
       shlx      edx,edx,r10d
       cmp       [r13+8],edx
       jne       near ptr M01_L69
       cmp       r10d,[rcx+8]
       jae       near ptr M01_L73
       mov       [rsp+0E4],r10d
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[rcx+rdx+10]
       mov       [rsp+50],r9
       mov       r11,[r9]
       mov       [rsp+48],r11
       mov       rcx,r9
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       r9,[rsp+50]
       mov       [r9+8],ecx
       mov       rax,[rsp+48]
       test      rax,rax
       mov       [rsp+48],rax
       mov       eax,[rsp+0E0]
       mov       r10d,[rsp+0E4]
       jne       near ptr M01_L48
M01_L17:
       mov       rcx,2554F0005D0
       mov       rdx,[rcx]
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M01_L61
M01_L18:
       test      r15,r15
       je        near ptr M01_L70
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L66
       mov       eax,[r15+8]
       test      eax,eax
       jne       near ptr M01_L22
       mov       r13,rbx
M01_L19:
       mov       rcx,r13
       mov       edx,edi
       call      qword ptr [7FFC48A376A8]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L67
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       cmp       edx,[rcx+8]
       jae       near ptr M01_L73
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M01_L20:
       add       r14d,1
       jo        near ptr M01_L31
       cmp       r14d,esi
       jl        near ptr M01_L12
M01_L21:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,295DCD90638
       mov       [rsp+20],rdx
       mov       rdx,rbp
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.List`1<System.String>, System.Collections.Generic.List`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,295DCD80008
       call      qword ptr [7FFC48D2EA48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       test      rax,rax
       je        near ptr M01_L68
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,118
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
       lea       rcx,[r15+0C]
       mov       edx,eax
       mov       r8d,edx
       test      r8d,r8d
       jle       short M01_L23
       test      r8d,r8d
       je        near ptr M01_L73
       movzx     r8d,word ptr [rcx]
       cmp       r8d,5C
       je        near ptr M01_L66
       cmp       r8d,2F
       je        near ptr M01_L66
M01_L23:
       cmp       edx,2
       jl        short M01_L24
       test      edx,edx
       je        near ptr M01_L73
       movzx     r8d,word ptr [rcx]
       or        r8d,20
       add       r8d,0FFFFFF9F
       cmp       r8d,19
       ja        short M01_L24
       cmp       edx,1
       jbe       near ptr M01_L73
       cmp       word ptr [rcx+2],3A
       je        near ptr M01_L66
M01_L24:
       lea       r13,[rbx+0C]
       mov       r12d,[rbx+8]
       add       r15,0C
       lea       ecx,[r12-1]
       cmp       ecx,r12d
       jae       near ptr M01_L73
       movzx     ecx,word ptr [r13+rcx*2]
       cmp       ecx,5C
       je        short M01_L28
       cmp       ecx,2F
       je        short M01_L28
       test      eax,eax
       je        near ptr M01_L73
       movzx     ecx,word ptr [r15]
       cmp       ecx,5C
       je        short M01_L27
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M01_L25:
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L30
       mov       rdx,295DCD887F4
       mov       [rsp+30],rdx
       mov       [rsp+0A8],r15
       mov       [rsp+0B0],eax
       mov       ecx,r12d
       add       ecx,1
       jo        near ptr M01_L31
       add       ecx,[rsp+0B0]
       jo        near ptr M01_L31
       test      ecx,ecx
       jne       short M01_L29
       mov       r13,295DCD80008
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
       mov       r15,rax
       lea       r8,[r15+0C]
       mov       ecx,[r15+8]
       mov       [rsp+98],r8
       mov       [rsp+0A0],ecx
       mov       rcx,[rsp+98]
       mov       r8d,[rsp+0A0]
       cmp       r12d,r8d
       ja        near ptr M01_L72
       mov       r8d,r12d
       add       r8,r8
       mov       rdx,r13
       call      qword ptr [7FFC486C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r12d,[rsp+0A0]
       ja        near ptr M01_L71
       mov       r8,[rsp+98]
       mov       ecx,r12d
       lea       r8,[r8+rcx*2]
       mov       ecx,[rsp+0A0]
       sub       ecx,r12d
       mov       [rsp+98],r8
       mov       [rsp+0A0],ecx
       mov       rcx,[rsp+98]
       mov       r8d,[rsp+0A0]
       cmp       r8d,1
       jb        near ptr M01_L72
       mov       r8d,1
       mov       rdx,[rsp+30]
       call      qword ptr [7FFC48E956B0]; System.Buffer.Memmove[[System.Char, System.Private.CoreLib]](Char ByRef, Char ByRef, UIntPtr)
       lea       rcx,[rsp+98]
       lea       rdx,[rsp+98]
       mov       r8d,1
       call      qword ptr [7FFC486FCF30]; System.Span`1[[System.Char, System.Private.CoreLib]].Slice(Int32)
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+78],xmm0
       lea       rdx,[rsp+78]
       lea       rcx,[rsp+0A8]
       call      qword ptr [7FFC486CC1B0]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].CopyTo(System.Span`1<Char>)
       mov       r13,r15
       jmp       near ptr M01_L26
M01_L30:
       mov       [rsp+88],r13
       mov       [rsp+90],r12d
       mov       [rsp+68],r15
       mov       [rsp+70],eax
       lea       rcx,[rsp+88]
       lea       rdx,[rsp+68]
       call      qword ptr [7FFC48616B50]
       mov       r13,rax
       jmp       near ptr M01_L26
M01_L31:
       call      CORINFO_HELP_OVERFLOW
M01_L32:
       call      qword ptr [7FFC48AC5AB8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L33
       call      qword ptr [7FFC48AC5800]
       mov       rbx,rax
M01_L33:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,295DCD89668
       mov       r8,rbx
       call      qword ptr [7FFC48746718]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L34:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFC486173F0]
       mov       rbx,rax
       jmp       near ptr M01_L06
M01_L35:
       movzx     ecx,byte ptr [rsp+110]
       test      cl,cl
       je        near ptr M01_L07
       lea       rcx,[rsp+110]
       call      qword ptr [7FFC486C47B0]
       mov       esi,eax
       jmp       near ptr M01_L08
M01_L36:
       call      qword ptr [7FFC48AC59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L37
       call      qword ptr [7FFC48AC5818]
       mov       rbx,rax
M01_L37:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,295DCD83760
       mov       r8,rbx
       call      qword ptr [7FFC486CD470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L38:
       movzx     ecx,byte ptr [rsp+110]
       test      cl,cl
       je        near ptr M01_L09
       lea       rcx,[rsp+110]
       call      qword ptr [7FFC486C47B0]
       mov       edi,eax
       jmp       near ptr M01_L10
M01_L39:
       call      qword ptr [7FFC48AC59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L40
       call      qword ptr [7FFC48AC5818]
       mov       rbx,rax
M01_L40:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,295DCD95900
       mov       r8,rbx
       call      qword ptr [7FFC486CD470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L41:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFC488C5B60]
       int       3
M01_L42:
       mov       ecx,19CCD
       mov       rdx,7FFC484C4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4861F810]
       int       3
M01_L43:
       mov       rcx,2554F001D88
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L11
M01_L44:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L13
M01_L45:
       lea       rcx,[rsp+0E8]
       mov       rdx,r15
       call      qword ptr [7FFC48815E90]
       jmp       near ptr M01_L14
M01_L46:
       lea       rcx,[rsp+0E8]
       mov       rdx,r13
       call      qword ptr [7FFC48815E90]
       jmp       near ptr M01_L15
M01_L47:
       mov       rcx,r12
       call      qword ptr [7FFC488CE1A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M01_L16
M01_L48:
       mov       rcx,[r12+10]
       cmp       r10d,[rcx+8]
       jae       near ptr M01_L73
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       mov       [rsp+0E0],eax
       jne       short M01_L50
       mov       rcx,r12
       mov       [rsp+0E4],r10d
       mov       edx,r10d
       call      qword ptr [7FFC488CE130]
       mov       r9,rax
M01_L49:
       mov       rdx,[r9+8]
       mov       [rsp+40],rdx
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+0C0],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+0C0]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L51
       call      qword ptr [7FFC48E4EB08]
       mov       edx,eax
       mov       [rsp+0C4],edx
       jmp       short M01_L52
M01_L50:
       mov       [rsp+0E4],r10d
       jmp       short M01_L49
M01_L51:
       mov       edx,ecx
       sar       edx,10
       mov       [rsp+0C4],edx
M01_L52:
       mov       rcx,7FFC48555120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+0C4]
       xor       edx,edx
       div       dword ptr [7FFC48555C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L59
M01_L53:
       cmp       eax,[r8+8]
       jae       near ptr M01_L73
       mov       [rsp+0CC],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+38],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+0BC],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+38]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+0B8],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L55
       test      r10d,r10d
       jne       short M01_L56
       xor       edx,edx
       mov       [rax+14],edx
M01_L54:
       movsxd    rdx,r10d
       mov       r8,[rsp+48]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+0B8]
       inc       ecx
       mov       rax,[rsp+38]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+0BC],1
M01_L55:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+0BC]
       test      ecx,ecx
       je        short M01_L57
       mov       r8d,1
       jmp       short M01_L60
M01_L56:
       jmp       short M01_L54
M01_L57:
       mov       eax,[rsp+0CC]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+40]
       cmp       [rcx+8],r8d
       jne       short M01_L58
       xor       r8d,r8d
M01_L58:
       mov       edx,[rsp+0C8]
       inc       edx
       mov       eax,r8d
M01_L59:
       mov       r8,[rsp+40]
       mov       [rsp+0C8],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L53
       xor       r8d,r8d
M01_L60:
       mov       eax,r8d
       mov       [rsp+0DC],eax
       mov       eax,[rsp+0E0]
       mov       r10d,[rsp+0E4]
       jmp       near ptr M01_L17
M01_L61:
       mov       r8d,eax
       mov       rcx,rdx
       mov       edx,r10d
       mov       r10,rcx
       mov       eax,[rsp+0DC]
       cmp       dword ptr [r13+8],0
       mov       [rsp+0E4],edx
       mov       [rsp+0E0],r8d
       mov       [rsp+60],r10
       mov       [rsp+0DC],eax
       je        near ptr M01_L18
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0D8],eax
       mov       edx,[r13+8]
       mov       [rsp+0D4],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+60]
       mov       r8d,[rsp+0D8]
       mov       r9d,[rsp+0D4]
       mov       edx,3
       call      qword ptr [7FFC486C7678]
       mov       eax,[rsp+0E0]
       test      [rsp+0DC],eax
       mov       [rsp+0E0],eax
       jne       near ptr M01_L18
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[r13+8]
       mov       rdx,[rsp+60]
       mov       [rsp+58],rdx
       mov       [rsp+0D0],eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rsp+0E0]
       test      r12d,r12d
       jne       short M01_L62
       mov       rcx,[rsp+58]
       mov       edx,[rsp+0D0]
       mov       r8d,0FFFFFFFF
       jmp       short M01_L63
M01_L62:
       mov       rcx,[rsp+58]
       mov       edx,[rsp+0D0]
       mov       r8d,[rsp+0E4]
M01_L63:
       mov       r9d,eax
       test      r12d,r12d
       jne       short M01_L64
       mov       eax,1
       jmp       short M01_L65
M01_L64:
       xor       eax,eax
M01_L65:
       mov       [rsp+20],r8d
       mov       [rsp+28],eax
       mov       r8d,r13d
       call      qword ptr [7FFC488CEBF8]
       jmp       near ptr M01_L18
M01_L66:
       mov       r13,r15
       jmp       near ptr M01_L19
M01_L67:
       mov       rcx,rbp
       mov       rdx,r13
       call      qword ptr [7FFC486CE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L20
M01_L68:
       mov       ecx,14
       call      qword ptr [7FFC488C5B18]
       int       3
M01_L69:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48B242E8]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFC484C4000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC4861F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L70:
       mov       ecx,1B547
       mov       rdx,7FFC484C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC48746790]
       int       3
M01_L71:
       call      qword ptr [7FFC488C57E8]
       int       3
M01_L72:
       call      qword ptr [7FFC488C5800]
       int       3
M01_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3411
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateInteger()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edx,7FFFFFFF
       mov       ecx,80000000
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D44E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48E8E160]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4860F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       eax,ebx
       jmp       short M01_L03
; Total bytes of code 366
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFC48D6CC60]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
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
       call      qword ptr [7FFC486D7360]; System.Guid.NewGuid()
       mov       r8,13504000428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,13482B94F80
       call      qword ptr [7FFC486D7180]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateNumber()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       call      qword ptr [7FFC48A27888]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
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
       je        near ptr M01_L33
M01_L01:
       test      eax,eax
       je        near ptr M01_L34
M01_L02:
       mov       rcx,25CFEC02DC8
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
       call      qword ptr [7FFC4877D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFC4877D050]; System.Text.StringBuilder.set_Capacity(Int32)
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
       mov       rax,7FFCED883670
       call      rax
M01_L07:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L08
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rdx,7FFC9C0D87F8
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
       mov       rdx,25D0AC00290
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
       mov       rdx,25D0AC00290
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
       call      qword ptr [7FFC487932D8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L30
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L21
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L28
       jmp       short M01_L22
M01_L18:
       call      qword ptr [7FFC4880E370]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
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
       call      qword ptr [7FFC48E85278]
       jmp       near ptr M01_L15
M01_L21:
       call      qword ptr [7FFC48E8F4B0]
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
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L28
       jmp       short M01_L30
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L24:
       mov       ecx,[rbp-5C]
       call      qword ptr [7FFC48734300]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFC4877D1A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L16
M01_L25:
       mov       r14,[rbp-98]
       mov       ecx,eax
       call      qword ptr [7FFC48D44E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L26:
       call      qword ptr [7FFC488B57E8]
       int       3
M01_L27:
       call      CORINFO_HELP_OVERFLOW
M01_L28:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFC486073F0]
       mov       rsi,rax
       jmp       short M01_L30
M01_L29:
       call      qword ptr [7FFC48E8F4B0]
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
       call      qword ptr [7FFC486B47B0]
       mov       ebx,eax
       jmp       near ptr M01_L02
M01_L34:
       call      qword ptr [7FFC48AB59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L35
       call      qword ptr [7FFC48AB5818]
       mov       rsi,rax
M01_L35:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,29D90A69A30
       mov       r8,rsi
       call      qword ptr [7FFC486BD470]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D1FA38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48AB5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A30BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC488D6C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A30BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC48AB5800]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC48736718]
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
       mov       rcx,25CFEC02DC8
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
       call      qword ptr [7FFC4877D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D1FA08]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 1615
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,247E9E15930
       cmp       [rcx],ecx
       call      qword ptr [7FFC4857A770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M00_L00
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryRepository+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],0EB
       mov       rcx,rax
       call      qword ptr [7FFC48D75080]; DotNetTips.Spargine.Core.Extensions.GetDescription(System.Enum)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC48A85D10]; DotNetTips.Spargine.Core.Data.CountryRepository.GetCountries()
       mov       rbp,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFC48E6A580
       mov       [rsi+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Core.Data.Models.Country>, System.Func`2<DotNetTips.Spargine.Core.Data.Models.Country,Boolean>, Boolean ByRef)
       call      qword ptr [7FFC48E34F00]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       ecx,[rax+0B8]
       call      qword ptr [7FFC48A57888]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
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
       call      qword ptr [7FFC48AE58C0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFC48AE5818]
       mov       rbx,rax
M00_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,247E9E15900
       mov       r8,rbx
       call      qword ptr [7FFC486ED470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 333
```
```assembly
; System.RuntimeType.IsEnumDefined(System.Object)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
M01_L00:
       test      rsi,rsi
       je        near ptr M01_L53
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
       je        near ptr M01_L55
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
       jne       near ptr M01_L54
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
       je        near ptr M01_L55
       mov       rax,2075C0000A0
       mov       rbp,[rax]
       call      System.Enum.InternalGetCorElementType(System.Runtime.CompilerServices.MethodTable*)
       cmp       eax,1A
       jae       near ptr M01_L62
       mov       ecx,eax
       mov       rcx,[rbp+rcx*8+10]
       mov       rdi,rcx
M01_L08:
       mov       rcx,247E9E00020
       cmp       rdi,rcx
       je        near ptr M01_L56
       mov       rcx,rdi
       call      qword ptr [7FFC48586070]; System.Type.IsIntegerType(System.Type)
       test      eax,eax
       je        near ptr M01_L58
       mov       rcx,2075C0000A0
       mov       rbp,[rcx]
       mov       rcx,[rbx+18]
       call      System.Enum.InternalGetCorElementType(System.Runtime.CompilerServices.MethodTable*)
       cmp       eax,1A
       jae       near ptr M01_L62
       mov       ecx,eax
       mov       rbp,[rbp+rcx*8+10]
       cmp       rbp,rdi
       jne       near ptr M01_L59
       test      rbp,rbp
       je        near ptr M01_L24
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L18
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L18
M01_L09:
       mov       r14d,[rax+90]
       test      r14d,r14d
       je        near ptr M01_L20
M01_L10:
       add       r14d,0FFFFFFFC
       cmp       r14d,5
       jne       near ptr M01_L60
       mov       rdx,offset MT_System.Int32
       cmp       [rsi],rdx
       je        short M01_L11
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int32
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
M01_L11:
       mov       r15d,[rsi+8]
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
       mov       rcx,offset MT_System.Enum+EnumInfo`1[[System.UInt32, System.Private.CoreLib]]
       cmp       [rax],rcx
       je        short M01_L16
M01_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC4893C900]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|7_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       short M01_L16
M01_L15:
       xor       eax,eax
       jmp       short M01_L13
M01_L16:
       mov       r13,[rax+8]
       cmp       byte ptr [rax+19],0
       je        near ptr M01_L44
       mov       eax,r15d
       mov       ecx,[r13+8]
       cmp       rcx,rax
       seta      al
       movzx     eax,al
M01_L17:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rcx,rbp
       call      qword ptr [7FFC48586658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L09
M01_L19:
       xor       ecx,ecx
       jmp       short M01_L12
M01_L20:
       mov       r14,rbp
       mov       rcx,r14
       call      qword ptr [7FFC48586AA8]; System.RuntimeType.get_IsActualEnum()
       test      eax,eax
       jne       near ptr M01_L25
M01_L21:
       mov       rcx,247E9E05890
       cmp       r14,rcx
       je        near ptr M01_L40
       mov       rcx,247E9E03590
       cmp       r14,rcx
       je        near ptr M01_L28
       mov       rcx,247E9E058B8
       cmp       r14,rcx
       je        near ptr M01_L39
       mov       rcx,247E9E03430
       cmp       r14,rcx
       je        near ptr M01_L36
       mov       rcx,247E9E03640
       cmp       r14,rcx
       je        near ptr M01_L27
       mov       rcx,247E9E03340
       cmp       r14,rcx
       je        near ptr M01_L29
       mov       rcx,247E9E058E0
       cmp       r14,rcx
       je        near ptr M01_L35
       mov       rcx,247E9E03188
       cmp       r14,rcx
       je        near ptr M01_L34
       mov       rcx,247E9E05840
       cmp       r14,rcx
       je        near ptr M01_L33
       mov       rcx,247E9E05868
       cmp       r14,rcx
       je        near ptr M01_L43
       mov       rcx,247E9E05908
       cmp       r14,rcx
       je        near ptr M01_L38
       mov       rcx,247E9E05930
       cmp       r14,rcx
       je        near ptr M01_L32
       mov       rcx,247E9E067C0
       cmp       r14,rcx
       je        near ptr M01_L42
       mov       rcx,247E9E03000
       cmp       r14,rcx
       je        near ptr M01_L41
       mov       rcx,247E9E00020
       cmp       r14,rcx
       je        near ptr M01_L31
       mov       rcx,247E9E159C0
       mov       r15d,1
       mov       eax,2
       cmp       r14,rcx
       cmove     r15d,eax
M01_L22:
       mov       r14d,r15d
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L37
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L37
M01_L23:
       mov       [rax+90],r14d
       jmp       near ptr M01_L10
M01_L24:
       xor       r14d,r14d
       jmp       near ptr M01_L10
M01_L25:
       mov       rcx,rbp
       call      qword ptr [7FFC4857A728]; Precode of System.RuntimeType.GetEnumUnderlyingType()
       mov       r14,rax
       test      r14,r14
       jne       short M01_L30
M01_L26:
       jmp       near ptr M01_L21
M01_L27:
       mov       r15d,9
       jmp       short M01_L22
M01_L28:
       mov       r15d,6
       jmp       short M01_L22
M01_L29:
       mov       r15d,0A
       jmp       short M01_L22
M01_L30:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       near ptr M01_L61
       jmp       short M01_L26
M01_L31:
       mov       r15d,12
       jmp       short M01_L22
M01_L32:
       mov       r15d,0E
       jmp       near ptr M01_L22
M01_L33:
       mov       r15d,3
       jmp       near ptr M01_L22
M01_L34:
       mov       r15d,0C
       jmp       near ptr M01_L22
M01_L35:
       mov       r15d,0B
       jmp       near ptr M01_L22
M01_L36:
       mov       r15d,8
       jmp       near ptr M01_L22
M01_L37:
       mov       rcx,rbp
       call      qword ptr [7FFC48586658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L23
M01_L38:
       mov       r15d,0D
       jmp       near ptr M01_L22
M01_L39:
       mov       r15d,7
       jmp       near ptr M01_L22
M01_L40:
       mov       r15d,5
       jmp       near ptr M01_L22
M01_L41:
       mov       r15d,10
       jmp       near ptr M01_L22
M01_L42:
       mov       r15d,0F
       jmp       near ptr M01_L22
M01_L43:
       mov       r15d,4
       jmp       near ptr M01_L22
       mov       rdx,rsi
       mov       rcx,offset MT_System.SByte
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFC48EE7E28]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.Byte
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFC48EE7E28]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int16
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFC48EE7E10]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt16
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFC48EE7E10]
       jmp       near ptr M01_L17
M01_L44:
       test      r13,r13
       jne       short M01_L45
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       short M01_L46
M01_L45:
       lea       rcx,[r13+10]
       mov       r8d,[r13+8]
M01_L46:
       cmp       dword ptr [r13+8],20
       jle       short M01_L47
       mov       edx,r8d
       mov       r8d,r15d
       call      qword ptr [7FFC4893DEF0]; System.SpanHelpers.BinarySearch[[System.UInt32, System.Private.CoreLib],[System.UInt32, System.Private.CoreLib]](UInt32 ByRef, Int32, UInt32)
       jmp       short M01_L48
M01_L47:
       mov       edx,r15d
       call      qword ptr [7FFC4893E028]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M01_L48:
       not       eax
       shr       eax,1F
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt32
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       edx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFC489376C0]; System.Enum.IsDefinedPrimitive[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, UInt32)
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int64
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFC48EE7D38]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFC48EE7D38]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.Single
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovss    xmm1,dword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFC48EE7630]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.Double
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovsd    xmm1,qword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFC48EE7618]
       jmp       near ptr M01_L17
       mov       rdx,rsi
       mov       rcx,offset MT_System.Char
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFC48EE7E40]
       jmp       near ptr M01_L17
M01_L49:
       mov       rcx,247E9E03408
       cmp       rbp,rcx
       je        short M01_L51
       mov       rcx,247E9E05958
       cmp       rbp,rcx
       je        short M01_L50
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC48B46160]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48785F68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L50:
       mov       rdx,rsi
       mov       rcx,offset MT_System.UIntPtr
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFC48EE6F10]
       jmp       short M01_L52
M01_L51:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IntPtr
       call      qword ptr [7FFC48634408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFC48EE6F10]
M01_L52:
       movzx     eax,al
       jmp       near ptr M01_L17
M01_L53:
       mov       ecx,2E5
       mov       rdx,7FFC484E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC48766790]
       int       3
M01_L54:
       mov       rcx,rdi
       mov       rdx,rbx
       call      System.RuntimeTypeHandle.IsEquivalentTo(System.RuntimeType, System.RuntimeType)
       test      eax,eax
       jne       near ptr M01_L05
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC48B2DA58]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFC48B2D428]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC4863F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L55:
       call      qword ptr [7FFC48587138]
       int       3
M01_L56:
       mov       rcx,rbx
       call      qword ptr [7FFC48584918]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       mov       r8,rsi
       mov       rcx,offset MT_System.String
       cmp       [r8],rcx
       je        short M01_L57
       mov       rdx,rsi
       call      qword ptr [7FFC486343F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L57:
       mov       rdx,rax
       mov       rcx,offset MD_System.Array.IndexOf[[System.String, System.Private.CoreLib]](System.String[], System.String)
       call      qword ptr [7FFC48E6E538]
       not       eax
       shr       eax,1F
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L58:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC48B46160]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC48785F68]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L59:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFC48B2DAB8]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [7FFC48B2D428]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFC4863F708]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L60:
       cmp       r14d,0A
       ja        near ptr M01_L49
       mov       edx,r14d
       lea       rcx,[7FFC48DC6370]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M01_L00]
       add       rcx,rax
       jmp       rcx
M01_L61:
       mov       rdx,rax
       call      qword ptr [7FFC486343F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2046
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
       mov       rcx,2075C0057C8
       mov       rsi,[rcx]
       mov       rcx,2075C005618
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
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFC48A069B8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
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
       mov       r11,7FFC484F0A38
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M02_L01
M02_L04:
       call      qword ptr [7FFC48AE5A10]
       mov       ecx,13E0
       mov       rdx,7FFC48906C28
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FFC48906C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48636B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FFC48906C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48636B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFC48AE5800]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFC48766718]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M02_L05:
       mov       ecx,2BD
       mov       rdx,7FFC484E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC48766790]
       int       3
M02_L06:
       call      qword ptr [7FFC48AE58C0]
       mov       r14,rax
       test      r14,r14
       jne       short M02_L07
       call      qword ptr [7FFC48AE5818]
       mov       r14,rax
M02_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,247E9E094D0
       mov       r8,r14
       call      qword ptr [7FFC486ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       mov       rcx,offset MT_System.Func`2[[System.Enum, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2075C0057B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFC48E6A640
       call      qword ptr [7FFC48634210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2075C0057C8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M02_L00
M02_L09:
       mov       ecx,0BB4
       mov       rdx,7FFC48A20B68
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC48C46748]
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
       call      qword ptr [7FFC48A06AA8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       rcx,247E9DCE8E8
       call      CORINFO_HELP_MON_ENTER_STATIC
       mov       rbx,2075C005710
       cmp       qword ptr [rbx],0
       je        short M03_L01
M03_L00:
       mov       rbx,[rbx]
       lea       rdx,[rbp-10]
       mov       rcx,247E9DCE8E8
       call      CORINFO_HELP_MON_EXIT_STATIC
       mov       rax,rbx
       jmp       short M03_L02
M03_L01:
       call      qword ptr [7FFC48A85CF8]; DotNetTips.Spargine.Core.Data.CountryRepository.DeserializeCountries()
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
       mov       rcx,247E9DCE8E8
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
       je        near ptr M04_L19
       test      rsi,rsi
       je        near ptr M04_L20
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M04_L16
M04_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-40],rdi
       mov       r14,[rsi+18]
       mov       rcx,7FFC48E6A580
       cmp       r14,rcx
       jne       near ptr M04_L10
       jmp       short M04_L03
M04_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M04_L05
M04_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+8]
       mov       rcx,[r15+68]
       mov       r8d,4
       call      qword ptr [7FFC486361D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       near ptr M04_L14
M04_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M04_L06
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r14d,[rax+0C]
       cmp       r8d,r14d
       jae       short M04_L04
       mov       [rax+8],r8d
       jmp       short M04_L01
M04_L04:
       mov       [rax+8],r14d
       jmp       near ptr M04_L21
M04_L05:
       mov       rcx,rbx
       mov       rdx,7FFC48EDB358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M04_L02
M04_L06:
       mov       rcx,rdi
       mov       r11,7FFC484F0A40
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M04_L21
       jmp       near ptr M04_L01
M04_L07:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M04_L12
M04_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       rdx,7FFC48E6A580
       cmp       r14,rdx
       jne       near ptr M04_L15
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+8]
       mov       rcx,[r15+68]
       mov       r8d,4
       call      qword ptr [7FFC486361D8]; System.String.Equals(System.String, System.String, System.StringComparison)
M04_L09:
       test      eax,eax
       jne       short M04_L14
M04_L10:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rcx
       jne       short M04_L13
       mov       rax,rdi
       mov       r8d,[rax+8]
       inc       r8d
       mov       r13d,[rax+0C]
       cmp       r8d,r13d
       jae       short M04_L11
       mov       [rax+8],r8d
       jmp       short M04_L07
M04_L11:
       mov       [rax+8],r13d
       jmp       near ptr M04_L21
M04_L12:
       mov       rcx,rbx
       mov       rdx,7FFC48EDB358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M04_L08
M04_L13:
       mov       rcx,rdi
       mov       r11,7FFC484F0A40
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L21
       jmp       near ptr M04_L07
M04_L14:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       jmp       short M04_L17
M04_L15:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M04_L09
M04_L16:
       mov       rcx,rbx
       mov       rdx,7FFC48EDB280
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M04_L00
M04_L17:
       mov       rax,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       cmp       [rdi],rax
       jne       short M04_L22
M04_L18:
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
M04_L19:
       mov       ecx,10
       call      qword ptr [7FFC488E7A38]
       int       3
M04_L20:
       mov       ecx,0C
       call      qword ptr [7FFC488E7A38]
       int       3
M04_L21:
       mov       rcx,rsp
       call      M04_L24
       jmp       short M04_L23
M04_L22:
       mov       rcx,rdi
       mov       r11,7FFC484F0A48
       call      qword ptr [r11]
       jmp       short M04_L18
M04_L23:
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
M04_L24:
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
       je        short M04_L25
       mov       rcx,offset MT_System.SZGenericArrayEnumerator`1[[DotNetTips.Spargine.Core.Data.Models.Country, DotNetTips.Spargine.8.Core]]
       mov       rdi,[rbp-40]
       cmp       [rdi],rcx
       je        short M04_L25
       mov       rcx,rdi
       mov       r11,7FFC484F0A48
       call      qword ptr [r11]
M04_L25:
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
M05_L00:
       vmovdqa   xmmword ptr [rbp+rdx-40],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-30],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-20],xmm4
       add       rdx,30
       jne       short M05_L00
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
       je        near ptr M05_L33
M05_L01:
       test      eax,eax
       je        near ptr M05_L34
M05_L02:
       mov       rcx,2075C004DC0
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M05_L36
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M05_L36
M05_L03:
       mov       r14,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r14,r14
       je        near ptr M05_L38
M05_L04:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFC487AD0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFC487AD050]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-98],r14
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M05_L17
M05_L05:
       xor       edx,edx
       mov       [rbp-4C],edx
       lea       rdi,[rbp-4C]
       mov       [rbp-0A8],rdi
M05_L06:
       mov       rdx,rdi
       mov       [rbp-58],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0D8],rax
       lea       rax,[M05_L07]
       mov       [rbp-0C0],rax
       lea       rax,[rbp-0E8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFCED883670
       call      rax
M05_L07:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M05_L08
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
M05_L08:
       mov       rcx,[rbp-0E0]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M05_L25
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-58],rax
       mov       eax,[rbp-4C]
       and       eax,0F
       cmp       eax,9
       mov       rdi,[rbp-0A8]
       ja        near ptr M05_L06
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
       ja        near ptr M05_L26
       mov       ecx,r10d
       lea       r13,[rdx+rcx*2+10]
       mov       r12d,[rax]
       test      r12d,r12d
       jl        near ptr M05_L18
       mov       eax,r12d
       mov       ecx,r12d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFC9C0D87F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,edi
       jg        near ptr M05_L13
       mov       [rbp-68],eax
       mov       [rbp-70],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,r12d
       cmp       eax,0A
       jb        short M05_L11
       cmp       eax,64
       jb        short M05_L10
       mov       rdx,2075C000290
       mov       rdx,[rdx]
M05_L09:
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
       jae       short M05_L09
M05_L10:
       cmp       eax,0A
       jb        short M05_L11
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,2075C000290
       mov       rdx,[rdx]
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M05_L12
M05_L11:
       add       eax,30
       mov       [rcx-2],ax
M05_L12:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       eax,1
       jmp       short M05_L14
M05_L13:
       xor       eax,eax
       mov       [rbp-68],eax
M05_L14:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M05_L15:
       test      eax,eax
       je        near ptr M05_L24
       mov       ecx,[rbp-68]
       add       [r14+18],ecx
M05_L16:
       add       r15d,1
       jo        near ptr M05_L27
       cmp       r15d,ebx
       jl        near ptr M05_L05
M05_L17:
       mov       r14,[rbp-98]
       mov       rcx,r14
       call      qword ptr [7FFC487C32D8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        near ptr M05_L30
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M05_L21
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M05_L28
       jmp       short M05_L22
M05_L18:
       call      qword ptr [7FFC4883E370]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M05_L19
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M05_L20
M05_L19:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M05_L20:
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
       call      qword ptr [7FFC48EB5608]
       jmp       near ptr M05_L15
M05_L21:
       call      qword ptr [7FFC48EEC5D0]
       test      eax,eax
       jne       short M05_L28
M05_L22:
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       short M05_L23
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M05_L29
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M05_L28
       jmp       short M05_L30
M05_L23:
       call      CORINFO_HELP_RNGCHKFAIL
M05_L24:
       mov       ecx,[rbp-5C]
       call      qword ptr [7FFC48764300]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFC487AD1A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M05_L16
M05_L25:
       mov       r14,[rbp-98]
       mov       ecx,eax
       call      qword ptr [7FFC48D74E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M05_L26:
       call      qword ptr [7FFC488E57E8]
       int       3
M05_L27:
       call      CORINFO_HELP_OVERFLOW
M05_L28:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFC486373F0]
       mov       rsi,rax
       jmp       short M05_L30
M05_L29:
       call      qword ptr [7FFC48EEC5D0]
       test      eax,eax
       jne       short M05_L28
M05_L30:
       mov       [rbp-0A0],rsi
       mov       rcx,rsp
       call      M05_L39
       jmp       short M05_L32
M05_L31:
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
M05_L32:
       mov       rsi,[rbp-0A0]
       mov       rax,rsi
       jmp       short M05_L31
M05_L33:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M05_L01
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC486E47B0]
       mov       ebx,eax
       jmp       near ptr M05_L02
M05_L34:
       call      qword ptr [7FFC48AE59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M05_L35
       call      qword ptr [7FFC48AE5818]
       mov       rsi,rax
M05_L35:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,247E9E09A30
       mov       r8,rsi
       call      qword ptr [7FFC486ED470]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M05_L36:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D4FA38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M05_L37
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M05_L03
M05_L37:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r14,r14
       jne       near ptr M05_L04
M05_L38:
       call      qword ptr [7FFC48AE5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A60BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC48906C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48636B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A60BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48636B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC48AE5800]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC48766718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L39:
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
       mov       rcx,2075C004DC0
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M05_L40
       mov       rcx,[rbp-98]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rdi+8]
       cmp       edx,[rax+0C]
       jg        short M05_L44
       xor       edx,edx
       call      qword ptr [7FFC487AD0F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M05_L41
M05_L40:
       mov       r14,[rbp-98]
       mov       rdx,r14
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M05_L44
M05_L41:
       cmp       qword ptr [rsi+20],0
       jne       short M05_L42
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-98]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M05_L44
M05_L42:
       mov       r14,[rbp-98]
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M05_L43
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D4FA08]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M05_L44
M05_L43:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M05_L44:
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,29169945900
       cmp       [rcx],ecx
       call      qword ptr [7FFC48617318]; System.String.Trim()
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,250DB801DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC488E27F0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFC48A37AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       call      qword ptr [7FFC486C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,[rsp+38]
       mov       [rsp+38],ebp
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,2E
       call      qword ptr [7FFC48E4E5C8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
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
       call      qword ptr [7FFC486C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rsp+38]
       mov       [rsp+38],r14d
M00_L02:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC48815D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rsi,rax
       call      qword ptr [7FFC489175A0]; System.IO.Path.GetTempPath()
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFC48917288]; System.IO.Path.Combine(System.String, System.String)
       mov       [rsp+20],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFC48E4E5E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFC48815E90]
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFC488C57E8]
       int       3
M00_L06:
       lea       rcx,[rsp+28]
       mov       rdx,rdi
       call      qword ptr [7FFC48815E90]
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
       mov       ecx,ecx
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFC48EC4D20]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFC48EC4D20]
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
       call      qword ptr [7FFC486173F0]
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
       mov       rcx,250DB8005D0
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,7FFC48555120
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
       mov       rcx,7FFC48555120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFC48555C38],0
       je        short M02_L02
       call      qword ptr [7FFC4861DC98]
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
       call      qword ptr [7FFC48E9D938]
       jmp       short M02_L04
M02_L03:
       mov       eax,ebx
       sar       eax,10
M02_L04:
       mov       ebx,eax
M02_L05:
       mov       rcx,7FFC48555120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFC48555C2C]
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
       call      qword ptr [7FFC488CEB80]
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
       mov       rcx,7FFC48555120
       mov       edx,5C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,250DB801F70
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
       mov       rdx,291699372C0
       call      qword ptr [7FFC489E6F88]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFC488CEB80]
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
       call      qword ptr [7FFC488CEB98]
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
       call      qword ptr [7FFC488CEB80]
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
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M03_L17
M03_L00:
       test      eax,eax
       je        near ptr M03_L18
M03_L01:
       mov       rcx,250D7802DC8
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
       call      qword ptr [7FFC4878D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFC4878D050]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M03_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M03_L13
M03_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        near ptr M03_L11
M03_L05:
       mov       ecx,r12d
       call      qword ptr [7FFC48A66CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        near ptr M03_L13
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       near ptr M03_L12
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M03_L06:
       add       r13d,1
       jo        near ptr M03_L13
       cmp       r13d,ebx
       jl        short M03_L04
M03_L07:
       mov       rcx,r15
       call      qword ptr [7FFC487A32D8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M03_L09
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M03_L14
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L10
M03_L08:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L15
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L10
M03_L09:
       mov       [rbp-58],r14
       jmp       short M03_L16
M03_L10:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC486173F0]
       mov       r14,rax
       jmp       short M03_L09
M03_L11:
       mov       edx,eax
       jmp       near ptr M03_L05
M03_L12:
       mov       rcx,r15
       call      qword ptr [7FFC4878D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M03_L06
M03_L13:
       call      CORINFO_HELP_OVERFLOW
M03_L14:
       call      qword ptr [7FFC48EC4D20]
       test      eax,eax
       jne       short M03_L10
       jmp       short M03_L08
M03_L15:
       call      qword ptr [7FFC48EC4D20]
       test      eax,eax
       jne       short M03_L10
       jmp       short M03_L09
M03_L16:
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
       call      qword ptr [7FFC486C47B0]
       mov       ebx,eax
       jmp       near ptr M03_L01
M03_L18:
       call      qword ptr [7FFC48AC59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M03_L19
       call      qword ptr [7FFC48AC5818]
       mov       rsi,rax
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,29169939A30
       mov       r8,rsi
       call      qword ptr [7FFC486CD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D2FA38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48AC5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A40BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC488E6C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48616B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A40BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48616B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48AC5800]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFC48746718]
       mov       rcx,rbx
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
       mov       rcx,250D7802DC8
       mov       r14,[rcx]
       mov       r15,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M03_L24
       mov       r13,[rbp-50]
       mov       rcx,[r13+8]
       mov       ecx,[rcx+8]
       add       ecx,[r13+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M03_L28
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFC4878D0F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M03_L25
M03_L24:
       mov       rdx,[rbp-50]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r13,[rbp-50]
       je        short M03_L28
M03_L25:
       cmp       qword ptr [r14+20],0
       jne       short M03_L26
       lea       rcx,[r14+20]
       mov       rdx,r13
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M03_L28
M03_L26:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M03_L27
       mov       rcx,[r14+18]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D2FA08]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M03_L28
M03_L27:
       add       r14,2C
       lock dec  dword ptr [r14]
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
; Total bytes of code 1011
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
       jmp       qword ptr [7FFC486C5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC48815F80]
       jmp       short M05_L00
M05_L02:
       call      qword ptr [7FFC488C57E8]
       int       3
M05_L03:
       movzx     edx,si
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFC48EC5020]
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
       mov       rcx,250DB801DE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC488E27F8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M06_L00:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M06_L01:
       call      qword ptr [7FFC488C57E8]
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
       mov       rax,0BB5494B653D7
       mov       [rbp],rax
       test      [rsp],esp
       sub       rsp,210
       lea       rcx,[rsp+20]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],104
       xor       ecx,ecx
       mov       [rbp+10],ecx
       lea       rcx,[rbp+8]
       call      qword ptr [7FFC489175D0]; System.IO.Path.GetTempPath(System.Text.ValueStringBuilder ByRef)
       lea       rcx,[rbp+8]
       call      qword ptr [7FFC4898CA98]; System.IO.PathHelper.Normalize(System.Text.ValueStringBuilder ByRef)
       mov       rbx,rax
       mov       rdx,[rbp+8]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+8],ymm0
       test      rdx,rdx
       jne       short M07_L02
M07_L00:
       mov       rax,rbx
       mov       rcx,0BB5494B653D7
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
       mov       rcx,250DB801DE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC488E27F8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       jmp       qword ptr [7FFC489173C0]; System.IO.Path.CombineInternal(System.String, System.String)
M08_L00:
       mov       ecx,1B53B
       mov       rdx,7FFC484C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC48746790]
       int       3
M08_L01:
       mov       ecx,1B547
       mov       rdx,7FFC484C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC48746790]
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRelativeUrl()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFC48A579F0]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
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
       mov       rcx,1443C004DC0
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
       call      qword ptr [7FFC487AD0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       mov       rax,7FFCED883670
       call      rax
M01_L03:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L04
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48A86CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFC48A57AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       mov       rcx,184CDD35A24
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r13+0E]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFC486E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC486E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC487AD998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC487C32D8]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       near ptr M01_L23
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       r13,184CDD35A18
       jmp       near ptr M01_L07
M01_L16:
       mov       ecx,eax
       call      qword ptr [7FFC48D74E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L17:
       call      qword ptr [7FFC48AE59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L18
       call      qword ptr [7FFC48AE5818]
       mov       rbx,rax
M01_L18:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,184CDD40F48
       mov       r8,rbx
       call      qword ptr [7FFC486ED470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       call      qword ptr [7FFC488E5D58]
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
       call      qword ptr [7FFC487AD2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFC48D4FF30]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48D4FA50]
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
       mov       rcx,1443C004DC0
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
       call      qword ptr [7FFC487AD0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D4FF60]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L34
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFC48D4FA20]
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateTempFile()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,400
       call      qword ptr [7FFC48A57A08]; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
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
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L07
M01_L00:
       test      eax,eax
       je        near ptr M01_L08
M01_L01:
       mov       esi,0A
       mov       rcx,222688C5930
       cmp       [rcx],ecx
       call      qword ptr [7FFC48637318]; System.String.Trim()
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,1E1D6C01DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC489027F0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+30],rax
       test      rax,rax
       je        near ptr M01_L10
       lea       rbp,[rax+10]
       mov       r14d,[rax+8]
M01_L02:
       mov       [rsp+40],rbp
       mov       [rsp+48],r14d
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       byte ptr [rsp+3C],0
       mov       ecx,esi
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFC48A57AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r15,rax
       cmp       byte ptr [rsp+3C],0
       jne       near ptr M01_L11
       test      r15,r15
       je        near ptr M01_L11
       mov       r8d,[rsp+38]
       cmp       r8d,[rsp+48]
       ja        near ptr M01_L12
       mov       rcx,[rsp+40]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M01_L11
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC486E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+38]
       add       ecx,[r15+8]
       mov       [rsp+38],ecx
M01_L03:
       lea       rcx,[rsp+28]
       mov       edx,2E
       call      qword ptr [7FFC48E6E5C8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+3C],0
       jne       near ptr M01_L13
       test      rdi,rdi
       je        near ptr M01_L13
       mov       r8d,[rsp+38]
       cmp       r8d,[rsp+48]
       ja        near ptr M01_L12
       mov       rcx,[rsp+40]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr M01_L13
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [7FFC486E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+38]
       add       ecx,[rdi+8]
       mov       [rsp+38],ecx
M01_L04:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC48835D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbp,rax
       call      qword ptr [7FFC489375A0]; System.IO.Path.GetTempPath()
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FFC48937288]; System.IO.Path.Combine(System.String, System.String)
       mov       rbp,rax
       mov       byte ptr [rsp+20],1
       mov       dword ptr [rsp+24],1
       mov       ecx,ebx
       xor       edx,edx
       test      ecx,ecx
       setg      dl
       mov       eax,edx
       test      edx,edx
       je        near ptr M01_L14
M01_L05:
       test      eax,eax
       je        near ptr M01_L15
M01_L06:
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFC48A57AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r14,rax
       call      qword ptr [7FFC489A7780]; System.IO.File.get_UTF8NoBOM()
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFC489AC180]; System.IO.File.Validate(System.String, System.Text.Encoding)
       mov       rcx,rbp
       mov       r9,rsi
       mov       r8,r14
       mov       edx,2
       call      qword ptr [7FFC489AC1B0]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.String, System.Text.Encoding)
       mov       rax,rbp
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       movzx     ecx,byte ptr [rsp+50]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       call      qword ptr [7FFC486E47B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L08:
       call      qword ptr [7FFC48AE59F8]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L09
       call      qword ptr [7FFC48AE5818]
       mov       r15,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,222688C5900
       mov       r8,r15
       call      qword ptr [7FFC486ED470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       near ptr M01_L02
M01_L11:
       lea       rcx,[rsp+28]
       mov       rdx,r15
       call      qword ptr [7FFC48835E90]
       jmp       near ptr M01_L03
M01_L12:
       call      qword ptr [7FFC488E57E8]
       int       3
M01_L13:
       lea       rcx,[rsp+28]
       mov       rdx,rdi
       call      qword ptr [7FFC48835E90]
       jmp       near ptr M01_L04
M01_L14:
       movzx     edx,byte ptr [rsp+20]
       test      dl,dl
       je        near ptr M01_L05
       lea       rcx,[rsp+20]
       call      qword ptr [7FFC486E47B0]
       mov       ecx,eax
       jmp       near ptr M01_L06
M01_L15:
       call      qword ptr [7FFC48AE59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L16
       call      qword ptr [7FFC48AE5818]
       mov       rbx,rax
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,222688B9A30
       mov       r8,rbx
       call      qword ptr [7FFC486ED470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 817
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FFC48A76CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFC48A47AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rdx,27C60402DA0
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
       call      qword ptr [7FFC48A76CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L08
       mov       r9d,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       rcx,2BCEA445928
       mov       r8,2BCEA430760
       call      qword ptr [7FFC48626B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,2BCEA445900
       call      qword ptr [7FFC48626B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       call      qword ptr [7FFC48A479F0]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC48626B08]; System.String.Concat(System.String, System.String)
       mov       [rsp+20],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFC48E5E5C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFC486D47B0]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFC48AD59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFC48AD5818]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2BCEA440F48
       mov       r8,rbx
       call      qword ptr [7FFC486DD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFC489D7660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D64E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48EAE1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4862F708]
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
       mov       rcx,27C60402DC8
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
       call      qword ptr [7FFC4879D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFC4879D050]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r14
       jmp       short M02_L06
M02_L04:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-48]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D3FF30]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48A76CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC487B32D8]; System.Text.StringBuilder.ToString()
       mov       r15,rax
       mov       esi,[r15+8]
       test      esi,esi
       je        near ptr M02_L18
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M02_L15
       mov       ecx,ecx
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L14
       jmp       short M02_L16
M02_L11:
       mov       edx,eax
       jmp       short M02_L08
M02_L12:
       mov       rcx,r14
       call      qword ptr [7FFC4879D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L09
M02_L13:
       call      CORINFO_HELP_OVERFLOW
M02_L14:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFC486273F0]
       jmp       short M02_L19
M02_L15:
       call      qword ptr [7FFC48EAF4B0]
       test      eax,eax
       jne       short M02_L14
M02_L16:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L17
       mov       ecx,ecx
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L14
       jmp       short M02_L18
M02_L17:
       call      qword ptr [7FFC48EAF4B0]
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
       call      qword ptr [7FFC486D47B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L21:
       call      qword ptr [7FFC48AD59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L22
       call      qword ptr [7FFC48AD5818]
       mov       rsi,rax
M02_L22:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2BCEA439A30
       mov       r8,rsi
       call      qword ptr [7FFC486DD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L23:
       call      qword ptr [7FFC48AD5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A50BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC488F6C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48626B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A50BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48626B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48AD5800]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFC48756718]
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
       call      qword ptr [7FFC48D3FA50]
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
       mov       rcx,27C60402DC8
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
       call      qword ptr [7FFC4879D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D3FF60]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M02_L32
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFC48D3FA20]
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
; Total bytes of code 1046
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
       call      qword ptr [7FFC486D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,[rsp+28]
       lea       rcx,[rsi+r12*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFC486D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    r8,r14d
       lea       rcx,[rsi+r8*2]
       lea       rdx,[rbp+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFC486D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
       movsxd    r8,r14d
       lea       rcx,[rsi+r8*2]
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFC486D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFC48626B20]; System.String.Concat(System.String, System.String, System.String)
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
       jmp       qword ptr [7FFC48626B20]; System.String.Concat(System.String, System.String, System.String)
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
       jmp       qword ptr [7FFC48626B20]; System.String.Concat(System.String, System.String, System.String)
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
       jmp       qword ptr [7FFC48626B20]; System.String.Concat(System.String, System.String, System.String)
M03_L04:
       call      qword ptr [7FFC488D5D58]
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
       call      qword ptr [7FFC486D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFC486D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC488D5D58]
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
       mov       rax,2BCEA430008
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
       mov       rcx,27C60402DC8
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
       call      qword ptr [7FFC4879D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       mov       rax,7FFCED883670
       call      rax
M05_L03:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M05_L04
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48A76CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFC48A47AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L16
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M05_L16
       lea       ecx,[rbx+1]
       test      ecx,ecx
       jl        near ptr M05_L15
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r8,[r13+0C]
       mov       rcx,2BCEA435A24
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r13+0E]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFC486D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC486D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC4879D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC487B32D8]; System.Text.StringBuilder.ToString()
       mov       [rbp-60],rax
       jmp       near ptr M05_L23
M05_L14:
       call      CORINFO_HELP_OVERFLOW
M05_L15:
       call      qword ptr [7FFC488D5D58]
       int       3
M05_L16:
       mov       r13,2BCEA435A18
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
       call      qword ptr [7FFC48D64E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M05_L20:
       call      qword ptr [7FFC48AD59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L21
       call      qword ptr [7FFC48AD5818]
       mov       rbx,rax
M05_L21:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2BCEA440F48
       mov       r8,rbx
       call      qword ptr [7FFC486DD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M05_L22:
       mov       rcx,rsi
       mov       edx,2F
       call      qword ptr [7FFC4879D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFC48D3FF30]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48D3FA50]
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
       mov       rcx,27C60402DC8
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
       call      qword ptr [7FFC4879D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D3FF60]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M05_L34
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFC48D3FA20]
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
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
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
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
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
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
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
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
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
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
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
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
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
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
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
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
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
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
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
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
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
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
       jmp       near ptr M07_L01
; Total bytes of code 1841
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FFC48A86CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFC48A57AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       mov       rcx,2C5336B5A18
       call      qword ptr [7FFC48636B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFC486E47B0]
       mov       ecx,eax
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFC48AE59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFC48AE5818]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C5336C0F48
       mov       r8,rbx
       call      qword ptr [7FFC486ED470]
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
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D74E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48EBE1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4863F708]
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
       mov       rcx,284A1802DC8
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
       call      qword ptr [7FFC487AD0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFC487AD050]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFC48A86CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC487C32D8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFC487AD2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC486373F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFC48EBF4B0]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFC48EBF4B0]
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
       call      qword ptr [7FFC486E47B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFC48AE59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFC48AE5818]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2C5336B9A30
       mov       r8,rsi
       call      qword ptr [7FFC486ED470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D4FA38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48AE5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A60BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC48906C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48636B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A60BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48636B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFC48AE5800]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFC48766718]
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
       mov       rcx,284A1802DC8
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
       call      qword ptr [7FFC487AD0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D4FA08]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC486E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFC486E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC488E5D58]
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
       mov       rax,2C5336B0008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFC48A27AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rdx,278C2404D98
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L08
       mov       r9d,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       rcx,2B954275928
       mov       r8,2B954260760
       call      qword ptr [7FFC48606B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,2B954275900
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFC486B47B0]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFC48AB59F8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M00_L06
       call      qword ptr [7FFC48AB5818]
       mov       rdi,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2B954270F48
       mov       r8,rdi
       call      qword ptr [7FFC486BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFC489B7660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D44E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48E8E1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4860F708]
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
       mov       rcx,278C2404DC0
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
       call      qword ptr [7FFC4877D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFC4877D050]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC487932D8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFC4877D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC486073F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFC48E8F4B0]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFC48E8F4B0]
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
       call      qword ptr [7FFC486B47B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFC48AB59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFC48AB5818]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2B954269A30
       mov       r8,rsi
       call      qword ptr [7FFC486BD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D1FA38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48AB5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A30BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC488D6C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A30BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFC48AB5800]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFC48736718]
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
       mov       rcx,278C2404DC0
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
       call      qword ptr [7FFC4877D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D1FA08]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+28],rax
       cmp       [rax],al
       lea       r10,[rax+0C]
       mov       [rsp+20],r10
       mov       rcx,r10
       lea       rdx,[rbx+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       mov       r8,[rsp+30]
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    r8,r14d
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
       movsxd    r8,r14d
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rbp+0C]
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFC48606B20]; System.String.Concat(System.String, System.String, System.String)
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
       jmp       qword ptr [7FFC48606B20]; System.String.Concat(System.String, System.String, System.String)
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
       jmp       qword ptr [7FFC48606B20]; System.String.Concat(System.String, System.String, System.String)
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
       jmp       qword ptr [7FFC48606B20]; System.String.Concat(System.String, System.String, System.String)
M03_L04:
       call      qword ptr [7FFC488B5D58]
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC488B5D58]
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
       mov       rax,2B954260008
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
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
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
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
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
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
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
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
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
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
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
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
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
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
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
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
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
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
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
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
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
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
       jmp       near ptr M05_L01
; Total bytes of code 1841
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFC48A27AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rdx,2F21F404D98
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L08
       mov       r9d,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       rcx,332B1365900
       mov       r8,332B1350760
       call      qword ptr [7FFC48606B38]; System.String.Concat(System.String, System.String, System.String, System.String)
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
       call      qword ptr [7FFC486B47B0]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFC48AB59F8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M00_L06
       call      qword ptr [7FFC48AB5818]
       mov       rdi,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,332B1360F48
       mov       r8,rdi
       call      qword ptr [7FFC486BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L07:
       call      qword ptr [7FFC489B7660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D44E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48E8E8B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4860F708]
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
       mov       rcx,2F21F404DC0
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
       call      qword ptr [7FFC4877D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFC4877D050]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFC48A56CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC487932D8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M02_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M02_L12
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L13
M02_L08:
       mov       edx,eax
       jmp       short M02_L05
M02_L09:
       mov       rcx,r15
       call      qword ptr [7FFC4877D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M02_L06
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC486073F0]
       jmp       short M02_L16
M02_L12:
       call      qword ptr [7FFC48E8FBB8]
       test      eax,eax
       jne       short M02_L11
M02_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L14
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L11
       jmp       short M02_L15
M02_L14:
       call      qword ptr [7FFC48E8FBB8]
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
       call      qword ptr [7FFC486B47B0]
       mov       ebx,eax
       jmp       near ptr M02_L01
M02_L18:
       call      qword ptr [7FFC48AB59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L19
       call      qword ptr [7FFC48AB5818]
       mov       rsi,rax
M02_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,332B1359A30
       mov       r8,rsi
       call      qword ptr [7FFC486BD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D1FA38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48AB5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A30BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC488D6C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A30BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48606B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFC48AB5800]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFC48736718]
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
       mov       rcx,2F21F404DC0
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
       call      qword ptr [7FFC4877D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D1FA08]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,[rsp+28]
       lea       rcx,[rsi+r12*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    r8,r14d
       lea       rcx,[rsi+r8*2]
       lea       rdx,[rbp+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
       movsxd    r8,r14d
       lea       rcx,[rsi+r8*2]
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFC486B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFC48606B20]; System.String.Concat(System.String, System.String, System.String)
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
       jmp       qword ptr [7FFC48606B20]; System.String.Concat(System.String, System.String, System.String)
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
       jmp       qword ptr [7FFC48606B20]; System.String.Concat(System.String, System.String, System.String)
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
       jmp       qword ptr [7FFC48606B20]; System.String.Concat(System.String, System.String, System.String)
M03_L04:
       call      qword ptr [7FFC488B5D58]
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
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
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
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
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
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
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
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
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
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
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
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
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
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
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
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
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
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
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
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
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
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
       jmp       near ptr M04_L01
; Total bytes of code 1841
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,1D005804D98
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
       call      qword ptr [7FFC48A66CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC489C7660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rax,7FFCED883670
       call      rax
M01_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M01_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D54E28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48E9E1A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4861F708]
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
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
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
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
       lea       rax,[7FFC9CB43CC8]
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
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
       lea       rdx,[7FFC9C9C43D8]
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
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
       call      qword ptr [7FFC9CB43C90]
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
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
       call      qword ptr [7FFC9CB43C98]
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
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
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
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
       call      qword ptr [7FFC9CB3B0E8]
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
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
       call      qword ptr [7FFC9CB43C88]
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
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       call      qword ptr [7FFC9CB26918]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
       call      qword ptr [7FFC9CB495D0]
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
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
       call      qword ptr [7FFC9CB43CA0]
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
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       call      qword ptr [7FFC9CB43CB0]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
; Total bytes of code 1841
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FFC48A57AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       mov       rcx,1F481404DC0
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
       call      qword ptr [7FFC487AD0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFC487AD050]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFC48A86CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC487C32D8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M01_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L11
       jmp       short M01_L13
M01_L08:
       mov       edx,eax
       jmp       short M01_L05
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFC487AD2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC486373F0]
       jmp       short M01_L16
M01_L12:
       call      qword ptr [7FFC48EBF4B0]
       test      eax,eax
       jne       short M01_L11
M01_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L11
       jmp       short M01_L15
M01_L14:
       call      qword ptr [7FFC48EBF4B0]
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
       call      qword ptr [7FFC486E47B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L18:
       call      qword ptr [7FFC48AE59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L19
       call      qword ptr [7FFC48AE5818]
       mov       rsi,rax
M01_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2350F589A30
       mov       r8,rsi
       call      qword ptr [7FFC486ED470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D4FA38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48AE5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A60BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC48906C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC48636B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A60BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC48636B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFC48AE5800]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFC48766718]
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
       mov       rcx,1F481404DC0
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
       call      qword ptr [7FFC487AD0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D4FA08]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,esi
       call      qword ptr [7FFC486ADFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       call      qword ptr [7FFC48A46CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFC48A17AC8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       call      qword ptr [7FFC486A47B0]
       mov       edi,eax
       jmp       near ptr M00_L01
M00_L17:
       call      qword ptr [7FFC48AA59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L18
       call      qword ptr [7FFC48AA5818]
       mov       rbx,rax
M00_L18:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29F36450F20
       mov       r8,rbx
       call      qword ptr [7FFC486AD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L19:
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        near ptr M00_L02
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC486A47B0]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L20:
       call      qword ptr [7FFC48AA59F8]
       mov       r13,rax
       test      r13,r13
       jne       short M00_L21
       call      qword ptr [7FFC48AA5818]
       mov       r13,rax
M00_L21:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,29F36450F48
       mov       r8,r13
       call      qword ptr [7FFC486AD470]
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
       call      qword ptr [7FFC486AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L13
M00_L32:
       call      qword ptr [7FFC48AA59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L33
       call      qword ptr [7FFC48AA5818]
       mov       rbx,rax
M00_L33:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29F36450F20
       mov       r8,rbx
       call      qword ptr [7FFC486AD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L34:
       call      qword ptr [7FFC48AA59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L35
       call      qword ptr [7FFC48AA5818]
       mov       rbx,rax
M00_L35:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29F36450F48
       mov       r8,rbx
       call      qword ptr [7FFC486AD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L36:
       call      qword ptr [7FFC48AA59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L37
       call      qword ptr [7FFC48AA5818]
       mov       rbx,rax
M00_L37:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29F36450F20
       mov       r8,rbx
       call      qword ptr [7FFC486AD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L38:
       call      qword ptr [7FFC48AA59F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L39
       call      qword ptr [7FFC48AA5818]
       mov       rbx,rax
M00_L39:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29F36450F48
       mov       r8,rbx
       call      qword ptr [7FFC486AD470]
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
       mov       rdx,7FFC48CAEF00
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
       call      qword ptr [7FFC488A5B60]
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
       mov       rdx,7FFC48CAEEF0
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
       mov       rax,7FFCED883670
       call      rax
M02_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFCA84CA0DC],0
       je        short M02_L02
       call      qword ptr [7FFCA84BA3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFC48D34E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC48E7EBF8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC485FF708]
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
       mov       rcx,25EA4404DC0
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
       call      qword ptr [7FFC4876D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFC4876D050]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFC48A46CB8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFC487832D8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M03_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M03_L12
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L13
M03_L08:
       mov       edx,eax
       jmp       short M03_L05
M03_L09:
       mov       rcx,r15
       call      qword ptr [7FFC4876D2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M03_L06
M03_L10:
       call      CORINFO_HELP_OVERFLOW
M03_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC485F73F0]
       jmp       short M03_L16
M03_L12:
       call      qword ptr [7FFC48EA40F0]
       test      eax,eax
       jne       short M03_L11
M03_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L14
       mov       rax,7FFC9C0D2E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L11
       jmp       short M03_L15
M03_L14:
       call      qword ptr [7FFC48EA40F0]
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
       call      qword ptr [7FFC486A47B0]
       mov       ebx,eax
       jmp       near ptr M03_L01
M03_L18:
       call      qword ptr [7FFC48AA59F8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M03_L19
       call      qword ptr [7FFC48AA5818]
       mov       rsi,rax
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,29F36449A30
       mov       r8,rsi
       call      qword ptr [7FFC486AD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC48D0FA20]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFC48AA5A10]
       mov       ecx,9E8
       mov       rdx,7FFC48A20BC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FFC488C6C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC485F6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFC48A20BC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC485F6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFC48AA5800]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFC48726718]
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
       mov       rcx,25EA4404DC0
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
       call      qword ptr [7FFC4876D0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC48D0F9F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFC9CB44F50]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFC9CB23D48]; CORINFO_HELP_ARRADDR_ST
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

