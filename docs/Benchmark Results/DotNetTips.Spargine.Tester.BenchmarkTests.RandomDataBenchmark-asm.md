## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacterMinMax()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       ecx,ecx
       mov       edx,0FFFF
       call      qword ptr [7FFE48387648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       ebx,edx
       mov       edx,esi
       add       edx,1
       jo        short M01_L03
       cmp       ebx,edx
       cmovge    edx,ebx
       mov       ebx,edx
       mov       rdx,204D3404E28
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L00
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE47F7E040]
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,ebx
       call      qword ptr [7FFE484A7B40]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebx,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L02
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 173
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileNameWithPath()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       mov       edx,0A
       mov       r8,28EB28FBE48
       call      qword ptr [7FFE483B7798]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
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
; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rdi,rcx
       mov       esi,edx
       mov       rbx,r8
       xor       ecx,ecx
       mov       [rsp+28],rcx
       test      esi,esi
       jle       near ptr M01_L06
       xor       ebp,ebp
       cmp       esi,100
       setle     bpl
       mov       eax,ebp
       test      ebp,ebp
       je        near ptr M01_L07
M01_L00:
       test      eax,eax
       je        near ptr M01_L08
M01_L01:
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L10
       mov       eax,[rcx+8]
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L10
M01_L02:
       cmp       [rcx],ecx
       call      qword ptr [7FFE47FA7318]; System.String.Trim()
       mov       rbx,rax
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,24E20801DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE48261FF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+38],rax
       test      rax,rax
       je        near ptr M01_L11
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M01_L03:
       mov       [rsp+48],r14
       mov       [rsp+50],r15d
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       byte ptr [rsp+44],0
       mov       ecx,esi
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFE483B78D0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       cmp       byte ptr [rsp+44],0
       jne       near ptr M01_L12
       test      rdx,rdx
       je        near ptr M01_L12
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M01_L13
       mov       rcx,[rsp+48]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+50]
       sub       eax,r8d
       mov       ebp,[rdx+8]
       cmp       ebp,eax
       ja        near ptr M01_L12
       add       rdx,0C
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE48055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,[rsp+40]
       mov       [rsp+40],ebp
M01_L04:
       lea       rcx,[rsp+30]
       mov       edx,2E
       call      qword ptr [7FFE48414F60]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+44],0
       jne       near ptr M01_L14
       test      rbx,rbx
       je        near ptr M01_L14
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M01_L13
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       mov       r14d,[rbx+8]
       cmp       r14d,edx
       ja        near ptr M01_L14
       lea       rdx,[rbx+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFE48055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rsp+40]
       mov       [rsp+40],r14d
M01_L05:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE480C5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE48297750]; System.IO.Path.Combine(System.String, System.String)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L06:
       xor       ebp,ebp
       mov       eax,ebp
       test      ebp,ebp
       jne       near ptr M01_L00
M01_L07:
       cmp       byte ptr [rsp+28],0
       je        near ptr M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE480547B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L08:
       call      qword ptr [7FFE48534750]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L09
       call      qword ptr [7FFE48534570]
       mov       r15,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,28EB28FBE80
       mov       r8,r15
       call      qword ptr [7FFE4805D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,28EB28FBE48
       jmp       near ptr M01_L02
M01_L11:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M01_L03
M01_L12:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE480C5848]
       jmp       near ptr M01_L04
M01_L13:
       call      qword ptr [7FFE4813E9A0]
       int       3
M01_L14:
       lea       rcx,[rsp+30]
       mov       rdx,rbx
       call      qword ptr [7FFE480C5848]
       jmp       near ptr M01_L05
; Total bytes of code 637
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE483978D0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       esi,edx
       mov       edi,r8d
       mov       byte ptr [rbp-38],1
       mov       dword ptr [rbp-34],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L15
M01_L00:
       test      eax,eax
       je        near ptr M01_L16
M01_L01:
       mov       rcx,272D6802E28
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L18
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L18
M01_L02:
       mov       r15,[rbp-40]
M01_L03:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M01_L06
M01_L04:
       movzx     ecx,si
       movzx     edx,di
       call      qword ptr [7FFE48397648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M01_L08
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M01_L07
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M01_L05:
       add       r13d,1
       jo        short M01_L08
       cmp       r13d,ebx
       jl        short M01_L04
M01_L06:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE481C9430]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L12
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFE57D52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L13
       jmp       short M01_L10
M01_L07:
       mov       rcx,r15
       call      qword ptr [7FFE481BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       call      qword ptr [7FFE487254A0]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L13
M01_L10:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       mov       rax,7FFE57D52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L13
       jmp       short M01_L12
M01_L11:
       call      qword ptr [7FFE487254A0]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L13
M01_L12:
       mov       rax,rsi
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE47F873F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M01_L14:
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L20
       nop
       mov       rax,[rbp-50]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       cmp       byte ptr [rbp-38],0
       je        near ptr M01_L00
       lea       rcx,[rbp-38]
       call      qword ptr [7FFE480347B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L16:
       call      qword ptr [7FFE48514750]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L17
       call      qword ptr [7FFE48514570]
       mov       r14,rax
M01_L17:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,2B368749A30
       mov       r8,r14
       call      qword ptr [7FFE4803D470]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE484B5500]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L19
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L02
M01_L19:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L20:
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
       lea       rbp,[rbp+80]
       mov       rcx,272D6802E28
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,7FFE484B1AB8
       cmp       [rdi+18],rcx
       jne       short M01_L21
       mov       r15,[rbp-48]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L25
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE481BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L22
M01_L21:
       mov       r15,[rbp-48]
       mov       rdx,r15
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M01_L25
M01_L22:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L25
M01_L23:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L24
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE484B54D0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L25
M01_L24:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L25:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 747
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWordMinMaxLengthChar()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       mov       edx,64
       xor       r8d,r8d
       mov       r9d,0FFFF
       call      qword ptr [7FFE483A78E8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
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
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       ebx,ecx
       mov       esi,edx
       mov       edi,r8d
       mov       ebp,r9d
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        short M01_L04
M01_L00:
       test      eax,eax
       je        short M01_L05
M01_L01:
       mov       edx,esi
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       xor       ecx,ecx
       test      edx,edx
       setg      cl
       mov       r8d,ecx
       test      ecx,ecx
       je        near ptr M01_L07
M01_L02:
       test      r8d,r8d
       je        near ptr M01_L08
M01_L03:
       mov       ecx,ebx
       call      qword ptr [7FFE483A7648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       ecx,eax
       movzx     edx,di
       movzx     r8d,bp
       call      qword ptr [7FFE483A78D0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L04:
       cmp       byte ptr [rsp+30],0
       je        short M01_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE480447B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebx,eax
       jmp       short M01_L01
M01_L05:
       call      qword ptr [7FFE48524750]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L06
       call      qword ptr [7FFE48524570]
       mov       rdi,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,1B9607F7708
       mov       r8,rdi
       call      qword ptr [7FFE4804D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       byte ptr [rsp+28],0
       je        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE480447B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       edx,eax
       jmp       near ptr M01_L03
M01_L08:
       call      qword ptr [7FFE48524750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FFE48524570]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B9607F7730
       mov       r8,rbx
       call      qword ptr [7FFE4804D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 317
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWordMinMaxLength()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       mov       edx,64
       call      qword ptr [7FFE483A78B8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
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
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       ebx,ecx
       mov       esi,edx
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        short M01_L04
M01_L00:
       test      eax,eax
       je        short M01_L05
M01_L01:
       mov       edx,esi
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       xor       ecx,ecx
       test      edx,edx
       setg      cl
       mov       r10d,ecx
       test      ecx,ecx
       je        near ptr M01_L07
M01_L02:
       test      r10d,r10d
       je        near ptr M01_L08
M01_L03:
       mov       ecx,ebx
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE483A78E8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L04:
       cmp       byte ptr [rsp+30],0
       je        short M01_L00
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE480447B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebx,eax
       jmp       short M01_L01
M01_L05:
       call      qword ptr [7FFE48524750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L06
       call      qword ptr [7FFE48524570]
       mov       rbx,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28C7AF97708
       mov       r8,rbx
       call      qword ptr [7FFE4804D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       byte ptr [rsp+28],0
       je        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE480447B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       edx,eax
       jmp       near ptr M01_L03
M01_L08:
       call      qword ptr [7FFE48524750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FFE48524570]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28C7AF97730
       mov       r8,rbx
       call      qword ptr [7FFE4804D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 304
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateByteArray()
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       vmovsd    xmm0,qword ptr [7FFE487E33F8]
       call      qword ptr [7FFE48387B10]; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
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
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       vzeroupper
       vmovaps   [rsp+0B0],xmm6
       lea       rbp,[rsp+100]
       xor       ecx,ecx
       mov       [rbp-78],rcx
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-0E0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       lea       rcx,[rbp-0C8]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rax,rsp
       mov       [rbp-0A8],rax
       mov       rax,rbp
       mov       [rbp-98],rax
       mov       rax,147A5C00428
       mov       rsi,[rax]
       call      qword ptr [7FFE484A77F8]; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
       mov       rdi,rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,147A5C04E38
       mov       r8,[r8]
       mov       rcx,rdi
       mov       rdx,18837ABBE70
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdx,rax
       mov       qword ptr [r14+8],1
       mov       [rbp-60],r14
       lea       rcx,[rbp-60]
       vmovsd    xmm6,qword ptr [rbp+10]
       mov       [rbp-78],rcx
       mov       dword ptr [rbp-70],1
       mov       rcx,rsi
       lea       r8,[rbp-78]
       call      qword ptr [7FFE47F66C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       xor       eax,eax
       vucomisd  xmm6,qword ptr [7FFE487E3708]
       setae     al
       test      eax,eax
       je        near ptr M01_L11
M01_L00:
       vmulsd    xmm0,xmm6,qword ptr [7FFE487E3710]
       call      qword ptr [7FFE481BF360]; System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       [rbp-80],rsi
       mov       rdx,147A5C04E28
       mov       rax,[rdx]
       mov       [rbp-88],rax
       xor       edx,edx
       mov       [rbp-58],edx
       cmp       byte ptr [rbp-58],0
       jne       near ptr M01_L07
       lea       rdx,[rbp-58]
       mov       rcx,rax
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rdx,gs:[58]
       mov       rdx,[rdx+30]
       cmp       dword ptr [rdx+190],2
       jl        near ptr M01_L06
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M01_L06
       mov       rax,[rdx]
       add       rax,10
M01_L01:
       mov       rcx,[rax]
       mov       rdx,offset MT_System.Security.Cryptography.RandomNumberGeneratorImplementation
       cmp       [rcx],rdx
       jne       near ptr M01_L08
       lea       rdx,[rsi+10]
       mov       r8d,[rsi+8]
       test      r8d,r8d
       jle       short M01_L04
       mov       [rbp-68],rdx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0B8],rax
       lea       rax,[M01_L02]
       mov       [rbp-0A0],rax
       lea       rax,[rbp-0C8]
       mov       [rbx+10],rax
       mov       byte ptr [rbx+0C],0
       mov       rax,7FFEC93A33A0
       call      rax
M01_L02:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFEA7E31FDC],0
       je        short M01_L03
       call      qword ptr [7FFEA7E22398]; CORINFO_HELP_STOP_FOR_GC
M01_L03:
       mov       rcx,[rbp-0C0]
       mov       [rbx+10],rcx
       test      eax,eax
       jne       short M01_L05
       xor       ecx,ecx
       mov       [rbp-68],rcx
M01_L04:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       jmp       short M01_L09
M01_L05:
       mov       ecx,eax
       call      qword ptr [7FFE4864D1A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L06:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L01
M01_L07:
       call      qword ptr [7FFE47F6E040]
       int       3
M01_L08:
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       nop
M01_L09:
       cmp       byte ptr [rbp-58],0
       je        short M01_L10
       mov       rcx,[rbp-88]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L10:
       mov       rsi,[rbp-80]
       mov       rax,rsi
       vmovaps   xmm6,[rsp+0B0]
       add       rsp,0C8
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
       vxorps    xmm6,xmm6,xmm6
       jmp       near ptr M01_L00
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       vmovaps   [rsp+30],xmm6
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+100]
       cmp       byte ptr [rbp-58],0
       je        short M01_L12
       mov       rcx,[rbp-88]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L12:
       nop
       vmovaps   xmm6,[rsp+30]
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
; Total bytes of code 744
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,61
       mov       edx,7A
       call      qword ptr [7FFE483A7648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       ebx,edx
       mov       edx,esi
       add       edx,1
       jo        short M01_L03
       cmp       ebx,edx
       cmovge    edx,ebx
       mov       ebx,edx
       mov       rdx,223B9404E28
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L00
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE47F9E040]
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,ebx
       call      qword ptr [7FFE484C7B40]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebx,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L02
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 173
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCoordinate()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE483A7930]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       mov       rcx,[rsp+30]
       mov       [rsp+20],rcx
       mov       ecx,[rsp+38]
       mov       [rsp+28],ecx
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE487453C8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate ByRef)
       nop
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]]()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFE483A7648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       esi,eax
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFE483A7648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       edi,eax
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFE483A7648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rbx],esi
       mov       [rbx+4],edi
       mov       [rbx+8],eax
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDecimal()
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+58],rax
       mov       rbx,rcx
       xor       edx,edx
       mov       [rsp+30],edx
       mov       [rsp+34],edx
       mov       [rsp+38],rdx
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       qword ptr [rsp+28],3E8
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       lea       rcx,[rsp+50]
       mov       r9d,2
       call      qword ptr [7FFE483A75A0]; DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       vmovups   xmm0,[rsp+50]
       vmovups   [rsp+40],xmm0
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE487378D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       nop
       add       rsp,60
       pop       rbx
       ret
; Total bytes of code 115
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       vzeroupper
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       byte ptr [rsp+0B0],1
       xor       ecx,ecx
       mov       [rsp+0B4],ecx
       mov       ecx,r9d
       not       ecx
       shr       ecx,1F
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L04
M01_L00:
       test      eax,eax
       je        near ptr M01_L05
M01_L01:
       test      r9d,r9d
       jl        near ptr M01_L07
       xor       ebp,ebp
M01_L02:
       mov       ecx,r9d
       mov       [rsp+0A0],ebp
       xor       edx,edx
       mov       [rsp+0A4],edx
       mov       [rsp+0A8],rcx
       mov       [rsp+90],edx
       mov       [rsp+94],edx
       mov       qword ptr [rsp+98],0A
       lea       rcx,[rsp+0A0]
       lea       rdx,[rsp+90]
       call      qword ptr [7FFE487376A8]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       mov       ebp,[rsp+0A0]
       mov       r14d,[rsp+0A4]
       mov       r15,[rsp+0A8]
       vmovups   xmm0,[rbx]
       vmovups   [rsp+80],xmm0
       mov       [rsp+70],ebp
       mov       [rsp+74],r14d
       mov       [rsp+78],r15
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+70]
       call      qword ptr [7FFE487376A8]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+80]
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE480B4738]; System.Decimal.ToInt32(System.Decimal)
       mov       ebx,eax
       vmovups   xmm0,[rsi]
       vmovups   [rsp+60],xmm0
       mov       [rsp+50],ebp
       mov       [rsp+54],r14d
       mov       [rsp+58],r15
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+50]
       call      qword ptr [7FFE487376A8]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+60]
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE480B4738]; System.Decimal.ToInt32(System.Decimal)
       mov       edx,eax
       mov       ecx,ebx
       call      qword ptr [7FFE483A7648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jl        near ptr M01_L08
       xor       ebx,ebx
M01_L03:
       mov       ecx,eax
       mov       [rsp+40],ebx
       xor       edx,edx
       mov       [rsp+44],edx
       mov       [rsp+48],rcx
       mov       [rsp+30],ebp
       mov       [rsp+34],r14d
       mov       [rsp+38],r15
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       call      qword ptr [7FFE48737738]; System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+40]
       vmovups   [rdi],xmm0
       mov       rax,rdi
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       cmp       byte ptr [rsp+0B0],0
       je        near ptr M01_L00
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FFE480447B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       r9d,eax
       jmp       near ptr M01_L01
M01_L05:
       call      qword ptr [7FFE48524750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L06
       call      qword ptr [7FFE48524570]
       mov       rbx,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,3255B1ABF48
       mov       r8,rbx
       call      qword ptr [7FFE4804D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       ebp,80000000
       neg       r9d
       jmp       near ptr M01_L02
M01_L08:
       mov       ebx,80000000
       neg       eax
       jmp       near ptr M01_L03
; Total bytes of code 544
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,1AC53804E00
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L02
       mov       rsi,[rcx+18]
M00_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFE48386EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFE48316E68]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       ebx,edx
       mov       edx,esi
       add       edx,1
       jo        short M01_L03
       cmp       ebx,edx
       cmovge    edx,ebx
       mov       ebx,edx
       mov       rdx,1AC53804E28
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L00
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE47F7E040]
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,ebx
       call      qword ptr [7FFE484A7108]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebx,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L02
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 173
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
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
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
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
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
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
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
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
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
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
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
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
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
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
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
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
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
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
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
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
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
; Total bytes of code 1578
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateEmailAddress()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE48376E68]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
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
; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rcx,2236F801DB0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE48202BF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       rbx,[rax+10]
       mov       esi,[rax+8]
M01_L00:
       mov       [rsp+38],rbx
       mov       [rsp+40],esi
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       mov       ecx,5
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE48377180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rdi,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L09
       test      rdi,rdi
       je        near ptr M01_L09
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L14
       mov       rcx,[rsp+38]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+40]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr M01_L09
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [7FFE48015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[rdi+8]
       mov       [rsp+30],ecx
M01_L01:
       mov       ecx,[rsp+30]
       mov       edx,[rsp+40]
       cmp       ecx,edx
       ja        near ptr M01_L14
       mov       r8,[rsp+38]
       mov       r9d,ecx
       lea       r8,[r8+r9*2]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L10
       mov       rcx,263F96476CC
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       mov       ecx,[rsp+30]
       inc       ecx
       mov       [rsp+30],ecx
M01_L02:
       mov       ecx,5
       mov       edx,0F
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE48377180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rbp,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L11
       test      rbp,rbp
       je        near ptr M01_L11
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L14
       mov       rcx,[rsp+38]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+40]
       sub       edx,r8d
       cmp       [rbp+8],edx
       ja        near ptr M01_L11
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       add       r8,r8
       call      qword ptr [7FFE48015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+30]
       add       edx,[rbp+8]
       mov       [rsp+30],edx
M01_L03:
       mov       edx,[rsp+30]
       mov       ecx,[rsp+40]
       cmp       edx,ecx
       ja        near ptr M01_L14
       mov       rax,[rsp+38]
       mov       r8d,edx
       lea       rax,[rax+r8*2]
       sub       ecx,edx
       cmp       ecx,1
       jb        near ptr M01_L12
       mov       rdx,263F9630C54
       movzx     ecx,word ptr [rdx]
       mov       [rax],cx
       mov       edx,[rsp+30]
       inc       edx
       mov       [rsp+30],edx
M01_L04:
       mov       rdx,22367802E08
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L13
       mov       r14,[rcx+18]
M01_L05:
       mov       edx,[r14+8]
       sub       edx,1
       jo        near ptr M01_L07
       xor       ecx,ecx
       call      qword ptr [7FFE48376EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,[r14+8]
       jae       near ptr M01_L16
       mov       r8d,eax
       mov       r15,[r14+r8*8+10]
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L15
       test      r15,r15
       je        near ptr M01_L15
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L14
       mov       rcx,[rsp+38]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+40]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M01_L15
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFE48015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[r15+8]
       mov       [rsp+30],ecx
M01_L06:
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE48085740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       xor       ebx,ebx
       xor       esi,esi
       jmp       near ptr M01_L00
M01_L09:
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       call      qword ptr [7FFE48085848]
       jmp       near ptr M01_L01
M01_L10:
       lea       rcx,[rsp+20]
       mov       rdx,263F96476C0
       call      qword ptr [7FFE480858F0]
       jmp       near ptr M01_L02
M01_L11:
       lea       rcx,[rsp+20]
       mov       rdx,rbp
       call      qword ptr [7FFE48085848]
       jmp       near ptr M01_L03
M01_L12:
       lea       rcx,[rsp+20]
       mov       rdx,263F9630C48
       call      qword ptr [7FFE480858F0]
       jmp       near ptr M01_L04
M01_L13:
       call      qword ptr [7FFE48306E68]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L14:
       call      qword ptr [7FFE480FE9A0]
       int       3
M01_L15:
       lea       rcx,[rsp+20]
       mov       rdx,r15
       call      qword ptr [7FFE48085848]
       jmp       near ptr M01_L06
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 813
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+118]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L05
       mov       rbp,241600BBE54
       mov       rcx,rbp
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],0D
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE48267AE0]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
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
       mov       rcx,241600A87F4
       mov       [rsp+40],rsi
       mov       [rsp+48],edi
       mov       [rsp+30],rcx
       mov       dword ptr [rsp+38],1
       mov       [rsp+20],rbp
       mov       dword ptr [rsp+28],0D
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       call      qword ptr [7FFE47F76B68]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
       jmp       short M00_L03
M00_L02:
       mov       [rsp+40],rsi
       mov       [rsp+48],edi
       mov       [rsp+30],rbp
       mov       dword ptr [rsp+38],0D
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       call      qword ptr [7FFE47F76B50]
       mov       rcx,rax
M00_L03:
       mov       edx,400
       call      qword ptr [7FFE483875E8]; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
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
       mov       ecx,1B46F
       mov       rdx,7FFE47E24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE481366E8]
       int       3
M00_L05:
       mov       rcx,241600BBE48
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
       call      qword ptr [7FFE48025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE48025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,ebp
       lea       rcx,[r12+r8*2]
       mov       r8d,r14d
       sub       r8d,ebp
       cmp       esi,r8d
       ja        short M02_L02
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFE48025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,241600A0008
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
       call      qword ptr [7FFE4810E9B8]
       int       3
; Total bytes of code 240
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFE47F77318]; System.String.Trim()
       mov       rbx,rax
       mov       edx,esi
       mov       byte ptr [rsp+20],1
       mov       dword ptr [rsp+24],1
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
       call      qword ptr [7FFE483874B0]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L04:
       call      qword ptr [7FFE485047F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L05
       call      qword ptr [7FFE48504558]
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,241600BBE78
       mov       r8,rbx
       call      qword ptr [7FFE48136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L06:
       cmp       byte ptr [rsp+20],0
       je        short M03_L02
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE480247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       edx,eax
       jmp       short M03_L03
M03_L07:
       call      qword ptr [7FFE48504750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L08
       call      qword ptr [7FFE48504570]
       mov       rbx,rax
M03_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,241600BBEA0
       mov       r8,rbx
       call      qword ptr [7FFE4802D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 276
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFiles()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       mov       edx,2
       mov       r8d,400
       call      qword ptr [7FFE48386EB0]; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
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
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0F8
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rsp+0E0],rax
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
       je        near ptr M01_L31
       cmp       dword ptr [rbx+8],0
       je        short M01_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L03
       mov       rax,7FFE57D52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L33
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFE48794D20]
       test      eax,eax
       jne       near ptr M01_L33
M01_L04:
       mov       ecx,[rbx+8]
       dec       ecx
       cmp       ecx,[rbx+8]
       jae       near ptr M01_L70
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE57D52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L33
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE48794D20]
       test      eax,eax
       jne       near ptr M01_L33
M01_L06:
       mov       byte ptr [rsp+0F0],1
       mov       dword ptr [rsp+0F4],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L34
M01_L07:
       test      eax,eax
       je        near ptr M01_L35
M01_L08:
       mov       byte ptr [rsp+0E8],1
       mov       dword ptr [rsp+0EC],1
       xor       ecx,ecx
       test      edi,edi
       setg      cl
       mov       edx,ecx
       test      ecx,ecx
       je        near ptr M01_L37
M01_L09:
       test      edx,edx
       je        near ptr M01_L38
M01_L10:
       test      rbx,rbx
       je        near ptr M01_L41
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L41
       mov       rcx,rbx
       call      qword ptr [7FFE48267498]; System.IO.Path.GetFullPath(System.String)
       mov       rbp,rax
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFE482DD6C8]; System.IO.FileSystem.CreateDirectory(System.String, Byte[])
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
       jl        near ptr M01_L40
       test      esi,esi
       je        near ptr M01_L42
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
       vmovdqu   ymmword ptr [rsp+0C0],ymm0
       vmovdqu   xmmword ptr [rsp+0D8],xmm0
       mov       r15d,0A
       mov       r13,1F1761FBE78
       xor       ecx,ecx
       mov       [rsp+0C0],rcx
       mov       rcx,1B0E4401DA0
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFE481DC908]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0C8],rax
       test      rax,rax
       je        near ptr M01_L43
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L13:
       mov       [rsp+0D8],r10
       mov       [rsp+0E0],eax
       xor       ecx,ecx
       mov       [rsp+0D0],ecx
       mov       byte ptr [rsp+0D4],0
       mov       ecx,r15d
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFE48387168]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r15,rax
       cmp       byte ptr [rsp+0D4],0
       jne       near ptr M01_L44
       test      r15,r15
       je        near ptr M01_L44
       mov       r8d,[rsp+0D0]
       cmp       r8d,[rsp+0E0]
       ja        near ptr M01_L67
       mov       rcx,[rsp+0D8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+0E0]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M01_L44
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFE48025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+0D0]
       add       ecx,[r15+8]
       mov       [rsp+0D0],ecx
M01_L14:
       lea       rcx,[rsp+0C0]
       mov       edx,2E
       call      qword ptr [7FFE483E46D8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+0D4],0
       jne       near ptr M01_L45
       test      r13,r13
       je        near ptr M01_L45
       mov       r8d,[rsp+0D0]
       cmp       r8d,[rsp+0E0]
       ja        near ptr M01_L67
       mov       rcx,[rsp+0D8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+0E0]
       sub       edx,r8d
       cmp       [r13+8],edx
       ja        near ptr M01_L45
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFE48025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+0D0]
       add       ecx,[r13+8]
       mov       [rsp+0D0],ecx
M01_L15:
       mov       ecx,[rsp+0D0]
       cmp       ecx,[rsp+0E0]
       ja        near ptr M01_L67
       mov       rax,[rsp+0D8]
       mov       [rsp+80],rax
       mov       [rsp+88],ecx
       lea       rcx,[rsp+80]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       mov       r13,[rsp+0C8]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+0C0],ymm0
       vmovdqu   xmmword ptr [rsp+0D8],xmm0
       test      r13,r13
       je        near ptr M01_L18
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rsp+0BC],eax
       mov       rcx,7FFE47EB5120
       mov       edx,16
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M01_L46
M01_L16:
       xor       eax,eax
       mov       dword ptr [rsp+0B4],1
       mov       r10d,[rsp+0BC]
       cmp       [rcx+8],r10d
       jbe       near ptr M01_L17
       mov       dword ptr [rsp+0B8],1
       mov       edx,10
       shlx      edx,edx,r10d
       cmp       [r13+8],edx
       jne       near ptr M01_L68
       cmp       r10d,[rcx+8]
       jae       near ptr M01_L70
       mov       [rsp+0BC],r10d
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[rcx+rdx+10]
       mov       [rsp+48],r9
       mov       r11,[r9]
       mov       [rsp+40],r11
       mov       rcx,r9
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+48]
       mov       [rdx+8],ecx
       mov       rax,[rsp+40]
       test      rax,rax
       mov       [rsp+40],rax
       mov       eax,[rsp+0B8]
       mov       r10d,[rsp+0BC]
       jne       near ptr M01_L47
M01_L17:
       mov       rcx,1B0E44005D0
       mov       r9,[rcx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M01_L60
M01_L18:
       test      r15,r15
       je        near ptr M01_L69
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L65
       mov       eax,[r15+8]
       test      eax,eax
       jne       near ptr M01_L22
       mov       r13,rbx
M01_L19:
       mov       rcx,r13
       mov       edx,edi
       call      qword ptr [7FFE48386D48]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L66
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       cmp       edx,[rcx+8]
       jae       near ptr M01_L70
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M01_L20:
       add       r14d,1
       jo        near ptr M01_L30
       cmp       r14d,esi
       jl        near ptr M01_L12
M01_L21:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFE484A6A78]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,0F8
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
       test      edx,edx
       jle       short M01_L23
       test      r8d,r8d
       je        near ptr M01_L70
       movzx     r8d,word ptr [rcx]
       cmp       r8d,5C
       je        near ptr M01_L65
       cmp       r8d,2F
       je        near ptr M01_L65
M01_L23:
       cmp       edx,2
       jl        short M01_L24
       test      edx,edx
       je        near ptr M01_L70
       movzx     r8d,word ptr [rcx]
       or        r8d,20
       add       r8d,0FFFFFF9F
       cmp       r8d,19
       ja        short M01_L24
       cmp       edx,1
       jbe       near ptr M01_L70
       cmp       word ptr [rcx+2],3A
       je        near ptr M01_L65
M01_L24:
       lea       r10,[rbx+0C]
       mov       r9d,[rbx+8]
       add       r15,0C
       lea       ecx,[r9-1]
       cmp       ecx,r9d
       jae       near ptr M01_L70
       movzx     ecx,word ptr [r10+rcx*2]
       cmp       ecx,5C
       je        near ptr M01_L28
       cmp       ecx,2F
       je        short M01_L28
       test      eax,eax
       je        near ptr M01_L70
       movzx     ecx,word ptr [r15]
       cmp       ecx,5C
       je        short M01_L27
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M01_L25:
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L29
       mov       rcx,1F1761E87F4
       mov       [rsp+80],r10
       mov       [rsp+88],r9d
       mov       [rsp+70],rcx
       mov       dword ptr [rsp+78],1
       mov       [rsp+60],r15
       mov       [rsp+68],eax
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+70]
       lea       r8,[rsp+60]
       call      qword ptr [7FFE47F76B68]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r13,rax
M01_L26:
       jmp       near ptr M01_L19
M01_L27:
       mov       ecx,1
       jmp       short M01_L25
M01_L28:
       mov       ecx,1
       jmp       short M01_L25
M01_L29:
       mov       [rsp+80],r10
       mov       [rsp+88],r9d
       mov       [rsp+70],r15
       mov       [rsp+78],eax
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+70]
       call      qword ptr [7FFE47F76B50]
       mov       r13,rax
       jmp       short M01_L26
M01_L30:
       call      CORINFO_HELP_OVERFLOW
M01_L31:
       call      qword ptr [7FFE484AF6C0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L32
       call      qword ptr [7FFE484AF420]
       mov       rbx,rax
M01_L32:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,1F1761E9668
       mov       r8,rbx
       call      qword ptr [7FFE48136670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L33:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE47F773F0]
       mov       rbx,rax
       jmp       near ptr M01_L06
M01_L34:
       cmp       byte ptr [rsp+0F0],0
       je        near ptr M01_L07
       lea       rcx,[rsp+0F0]
       call      qword ptr [7FFE480247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       esi,eax
       jmp       near ptr M01_L08
M01_L35:
       call      qword ptr [7FFE484AF618]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L36
       call      qword ptr [7FFE484AF438]
       mov       rbx,rax
M01_L36:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,1F1761E4368
       mov       r8,rbx
       call      qword ptr [7FFE4802D470]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L37:
       cmp       byte ptr [rsp+0E8],0
       je        near ptr M01_L09
       lea       rcx,[rsp+0E8]
       call      qword ptr [7FFE480247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       edi,eax
       jmp       near ptr M01_L10
M01_L38:
       call      qword ptr [7FFE484AF618]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L39
       call      qword ptr [7FFE484AF438]
       mov       rbx,rax
M01_L39:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,1F1761FBE48
       mov       r8,rbx
       call      qword ptr [7FFE4802D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L40:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE4810ED18]
       int       3
M01_L41:
       mov       ecx,19C01
       mov       rdx,7FFE47E24000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE47F7F810]
       int       3
M01_L42:
       mov       rcx,1B0E4401D80
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L11
M01_L43:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L13
M01_L44:
       lea       rcx,[rsp+0C0]
       mov       rdx,r15
       call      qword ptr [7FFE48095848]
       jmp       near ptr M01_L14
M01_L45:
       lea       rcx,[rsp+0C0]
       mov       rdx,r13
       call      qword ptr [7FFE48095848]
       jmp       near ptr M01_L15
M01_L46:
       mov       rcx,r12
       call      qword ptr [7FFE481CCB40]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M01_L16
M01_L47:
       mov       rcx,[r12+10]
       cmp       r10d,[rcx+8]
       jae       near ptr M01_L70
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       mov       [rsp+0B8],eax
       jne       short M01_L49
       mov       rcx,r12
       mov       [rsp+0BC],r10d
       mov       edx,r10d
       call      qword ptr [7FFE481CCAC8]
       mov       r9,rax
M01_L48:
       mov       rdx,[r9+8]
       mov       [rsp+38],rdx
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+98],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+98]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L50
       call      qword ptr [7FFE487345D0]
       mov       edx,eax
       mov       [rsp+9C],edx
       jmp       short M01_L51
M01_L49:
       mov       [rsp+0BC],r10d
       jmp       short M01_L48
M01_L50:
       mov       edx,ecx
       sar       edx,10
       mov       [rsp+9C],edx
M01_L51:
       mov       rcx,7FFE47EB5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+9C]
       xor       edx,edx
       div       dword ptr [7FFE47EB5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L58
M01_L52:
       cmp       eax,[r8+8]
       jae       near ptr M01_L70
       mov       [rsp+0A4],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+30],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+94],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+90],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L54
       test      r10d,r10d
       jne       short M01_L55
       xor       edx,edx
       mov       [rax+14],edx
M01_L53:
       movsxd    rdx,r10d
       mov       r8,[rsp+40]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+90]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+94],1
M01_L54:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+94]
       test      ecx,ecx
       je        short M01_L56
       mov       r8d,1
       jmp       short M01_L59
M01_L55:
       jmp       short M01_L53
M01_L56:
       mov       eax,[rsp+0A4]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+38]
       cmp       [rcx+8],r8d
       jne       short M01_L57
       xor       r8d,r8d
M01_L57:
       mov       edx,[rsp+0A0]
       inc       edx
       mov       eax,r8d
M01_L58:
       mov       r8,[rsp+38]
       mov       [rsp+0A0],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L52
       xor       r8d,r8d
M01_L59:
       mov       eax,r8d
       mov       [rsp+0B4],eax
       mov       eax,[rsp+0B8]
       mov       r10d,[rsp+0BC]
       jmp       near ptr M01_L17
M01_L60:
       mov       edx,r10d
       mov       r8d,eax
       mov       r10,r9
       mov       eax,[rsp+0B4]
       cmp       dword ptr [r13+8],0
       mov       [rsp+0BC],edx
       mov       [rsp+0B8],r8d
       mov       [rsp+58],r10
       mov       [rsp+0B4],eax
       je        near ptr M01_L18
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0B0],eax
       mov       edx,[r13+8]
       mov       [rsp+0AC],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+58]
       mov       r8d,[rsp+0B0]
       mov       r9d,[rsp+0AC]
       mov       edx,3
       call      qword ptr [7FFE48027678]
       mov       eax,[rsp+0B8]
       test      [rsp+0B4],eax
       mov       [rsp+0B8],eax
       jne       near ptr M01_L18
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[r13+8]
       mov       rdx,[rsp+58]
       mov       [rsp+50],rdx
       mov       [rsp+0A8],eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rsp+0B8]
       test      r12d,r12d
       jne       short M01_L61
       mov       rcx,[rsp+50]
       mov       edx,[rsp+0A8]
       mov       r8d,0FFFFFFFF
       jmp       short M01_L62
M01_L61:
       mov       rcx,[rsp+50]
       mov       edx,[rsp+0A8]
       mov       r8d,[rsp+0BC]
M01_L62:
       mov       r9d,eax
       test      r12d,r12d
       jne       short M01_L63
       mov       eax,1
       jmp       short M01_L64
M01_L63:
       xor       eax,eax
M01_L64:
       mov       [rsp+20],r8d
       mov       [rsp+28],eax
       mov       r8d,r13d
       call      qword ptr [7FFE481CD590]
       jmp       near ptr M01_L18
M01_L65:
       mov       r13,r15
       jmp       near ptr M01_L19
M01_L66:
       mov       rcx,rbp
       mov       rdx,r13
       call      qword ptr [7FFE4802E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L20
M01_L67:
       call      qword ptr [7FFE4810E9A0]
       int       3
M01_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE484852D8]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFE47E24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE47F7F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L69:
       mov       ecx,1B47B
       mov       rdx,7FFE47E24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE481366E8]
       int       3
M01_L70:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3090
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateInteger()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFE48377648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       ebx,edx
       mov       edx,esi
       add       edx,1
       jo        short M01_L03
       cmp       ebx,edx
       cmovge    edx,ebx
       mov       ebx,edx
       mov       rdx,17E86004E28
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L00
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE47F6E040]
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,ebx
       call      qword ptr [7FFE48497B40]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebx,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L02
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 173
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE486B43A8]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE48027360]; System.Guid.NewGuid()
       mov       r8,23B28800428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,27BB258D3A0
       call      qword ptr [7FFE48027180]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateNumber()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       call      qword ptr [7FFE48377690]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
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
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       mov       rdx,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rdx-40],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-30],xmm4
       vmovdqa   xmmword ptr [rbp+rdx-20],xmm4
       add       rdx,30
       jne       short M01_L00
       mov       [rbp-40],rdx
       mov       [rbp-108],rsp
       mov       ebx,ecx
       lea       rcx,[rbp-0F8]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0D8],rcx
       mov       rcx,rbp
       mov       [rbp-0C8],rcx
       mov       byte ptr [rbp-48],1
       mov       dword ptr [rbp-44],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L39
M01_L01:
       test      eax,eax
       je        near ptr M01_L40
M01_L02:
       mov       rcx,22E64804E20
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-50],rcx
       cmp       qword ptr [rbp-50],0
       je        near ptr M01_L42
       lea       rcx,[rdi+20]
       mov       r8,[rbp-50]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-50]
       jne       near ptr M01_L42
M01_L03:
       mov       r14,[rbp-50]
M01_L04:
       xor       edx,edx
       mov       [rbp-50],rdx
       mov       [rbp-0A0],r14
       mov       rdx,22E64804E28
       mov       rax,[rdx]
       mov       [rbp-0A8],rax
       xor       edx,edx
       mov       [rbp-40],edx
       cmp       byte ptr [rbp-40],0
       jne       short M01_L05
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       xor       r15d,r15d
       jmp       near ptr M01_L18
M01_L05:
       mov       r14,[rbp-0A0]
       call      qword ptr [7FFE47F7E040]
       int       3
M01_L06:
       xor       edx,edx
       mov       [rbp-54],edx
       lea       rdi,[rbp-54]
       mov       [rbp-0B8],rdi
M01_L07:
       mov       rdx,rdi
       mov       [rbp-60],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-0E8],rax
       lea       rax,[M01_L08]
       mov       [rbp-0D0],rax
       lea       rax,[rbp-0F8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFEC93A33A0
       call      rax
M01_L08:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFEA7E31FDC],0
       je        short M01_L09
       call      qword ptr [7FFEA7E22398]; CORINFO_HELP_STOP_FOR_GC
M01_L09:
       mov       rcx,[rbp-0F0]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       near ptr M01_L23
       xor       eax,eax
       mov       [rbp-60],rax
       mov       [rbp-60],rax
       mov       eax,[rbp-54]
       and       eax,0F
       cmp       eax,8
       mov       rdi,[rbp-0B8]
       ja        near ptr M01_L07
       mov       [rbp-64],eax
       lea       rax,[rbp-64]
       mov       r14,[rbp-0A0]
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
       ja        near ptr M01_L24
       mov       ecx,r10d
       lea       r13,[rdx+rcx*2+10]
       mov       r12d,[rax]
       test      r12d,r12d
       jl        near ptr M01_L19
       mov       eax,r12d
       mov       ecx,r12d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFE57D585C8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,edi
       jg        near ptr M01_L14
       mov       [rbp-70],eax
       mov       [rbp-78],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,r12d
       cmp       eax,0A
       jb        short M01_L12
       cmp       eax,64
       jb        short M01_L11
       mov       rdx,22E64800290
       mov       rdx,[rdx]
M01_L10:
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
       jae       short M01_L10
M01_L11:
       cmp       eax,0A
       jb        short M01_L12
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,22E64800290
       mov       rdx,[rdx]
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M01_L13
M01_L12:
       add       eax,30
       mov       [rcx-2],ax
M01_L13:
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       eax,1
       jmp       short M01_L15
M01_L14:
       xor       eax,eax
       mov       [rbp-70],eax
M01_L15:
       xor       ecx,ecx
       mov       [rbp-78],rcx
       test      eax,eax
       je        near ptr M01_L22
M01_L16:
       mov       ecx,[rbp-70]
       add       [r14+18],ecx
M01_L17:
       add       r15d,1
       jo        near ptr M01_L25
M01_L18:
       cmp       r15d,ebx
       jl        near ptr M01_L06
       mov       r14,[rbp-0A0]
       jmp       near ptr M01_L29
M01_L19:
       call      qword ptr [7FFE4809F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L20
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L21
M01_L20:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L21:
       mov       ecx,r12d
       mov       [rbp-88],r8
       mov       [rbp-80],r9d
       mov       [rbp-98],r13
       mov       [rbp-90],edi
       lea       r8,[rbp-70]
       mov       [rsp+20],r8
       lea       r8,[rbp-88]
       lea       r9,[rbp-98]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE4871FEE8]
       test      eax,eax
       jne       near ptr M01_L16
M01_L22:
       mov       ecx,[rbp-64]
       call      qword ptr [7FFE480BFC90]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE48227120]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L17
M01_L23:
       mov       r14,[rbp-0A0]
       mov       ecx,eax
       call      qword ptr [7FFE486763A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L24:
       call      qword ptr [7FFE4810E9A0]
       int       3
M01_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L26:
       jmp       near ptr M01_L36
M01_L27:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE47F773F0]
       mov       rsi,rax
       jmp       near ptr M01_L36
M01_L28:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L29:
       cmp       byte ptr [rbp-40],0
       je        short M01_L30
       mov       rcx,[rbp-0A8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L30:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE481FDCA0]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       test      rsi,rsi
       je        short M01_L26
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+10],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+10]
       inc       ecx
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       cmp       ecx,edx
       jge       short M01_L31
       mov       [rbx+10],ecx
       cmp       dword ptr [rsi+8],0
       je        short M01_L36
       jmp       short M01_L32
M01_L31:
       mov       [rbx+10],edx
       jmp       near ptr M01_L26
M01_L32:
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L33
       mov       rax,7FFE57D52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L27
       jmp       short M01_L34
M01_L33:
       call      qword ptr [7FFE4875DF20]
       test      eax,eax
       jne       near ptr M01_L27
M01_L34:
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       near ptr M01_L28
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L35
       mov       rax,7FFE57D52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L27
       jmp       short M01_L36
M01_L35:
       call      qword ptr [7FFE4875DF20]
       test      eax,eax
       jne       near ptr M01_L27
M01_L36:
       mov       [rbp-0B0],rsi
       mov       rcx,rsp
       call      M01_L45
       jmp       short M01_L38
M01_L37:
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L38:
       mov       rsi,[rbp-0B0]
       mov       rax,rsi
       jmp       short M01_L37
M01_L39:
       cmp       byte ptr [rbp-48],0
       je        near ptr M01_L01
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE480247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebx,eax
       jmp       near ptr M01_L02
M01_L40:
       call      qword ptr [7FFE48504750]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L41
       call      qword ptr [7FFE48504570]
       mov       rsi,rax
M01_L41:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,26EF67D9A30
       mov       r8,rsi
       call      qword ptr [7FFE4802D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L42:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFE48495500]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L43
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L03
M01_L43:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L04
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
       lea       rbp,[rbp+130]
       cmp       byte ptr [rbp-40],0
       je        short M01_L44
       mov       rcx,[rbp-0A8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L44:
       nop
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
M01_L45:
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
       lea       rbp,[rbp+130]
       mov       rcx,22E64804E20
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,7FFE48491AB8
       cmp       [rsi+18],rcx
       jne       short M01_L46
       mov       rcx,[rbp-0A0]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rsi+8]
       cmp       edx,[rax+0C]
       jg        short M01_L50
       xor       edx,edx
       call      qword ptr [7FFE48227078]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L47
M01_L46:
       mov       r14,[rbp-0A0]
       mov       rdx,r14
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L50
M01_L47:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L48
       lea       rcx,[rbx+20]
       mov       rdx,[rbp-0A0]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L50
M01_L48:
       mov       r14,[rbp-0A0]
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L49
       mov       rcx,[rbx+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE484954D0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L50
M01_L49:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L50:
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
; Total bytes of code 1681
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePersonRecord()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFE483A76C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
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
; Total bytes of code 72
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       ebx,edx
       mov       esi,r8d
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],2
       test      ecx,ecx
       jl        short M01_L02
       xor       edi,edi
       cmp       ecx,64
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        short M01_L03
M01_L00:
       test      eax,eax
       je        short M01_L04
M01_L01:
       mov       r9d,esi
       mov       edx,ecx
       mov       r8d,ebx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       call      qword ptr [7FFE483AC348]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       rcx,rax
       call      qword ptr [7FFE483A7A80]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToPersonRecord(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       short M01_L00
M01_L03:
       cmp       byte ptr [rsp+28],0
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE480447B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ecx,eax
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FFE48524750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFE48524570]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,26B242D6F60
       mov       r8,rbx
       call      qword ptr [7FFE4804D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 192
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePersonRef()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFE4839C348]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
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
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       mov       [rsp+50],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       ebp,r9d
       mov       byte ptr [rsp+48],1
       mov       dword ptr [rsp+4C],2
       mov       eax,esi
       not       eax
       shr       eax,1F
       mov       ecx,eax
       test      eax,eax
       je        near ptr M01_L10
M01_L00:
       test      ecx,ecx
       je        near ptr M01_L11
M01_L01:
       xor       eax,eax
       mov       [rsp+40],rax
       cmp       edi,5
       jl        near ptr M01_L13
       xor       r14d,r14d
       cmp       edi,64
       setle     r14b
       mov       eax,r14d
       test      r14d,r14d
       je        near ptr M01_L14
M01_L02:
       test      eax,eax
       je        near ptr M01_L15
M01_L03:
       xor       eax,eax
       mov       [rsp+38],rax
       cmp       ebp,5
       jl        near ptr M01_L17
       xor       r15d,r15d
       cmp       ebp,32
       setle     r15b
       mov       eax,r15d
       test      r15d,r15d
       je        near ptr M01_L18
M01_L04:
       test      eax,eax
       je        near ptr M01_L19
M01_L05:
       call      qword ptr [7FFE483977C8]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFE4839C708]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L09
M01_L07:
       mov       [rsp+20],ebp
       mov       rdx,[r14+10]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFE4868E700]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE483B1168]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       vmovups   xmm0,[r14+38]
       vmovups   [rsp+28],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE483B1178]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[r14+8]
       mov       rcx,r15
       call      qword ptr [7FFE483B1188]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       mov       rdx,[r14+18]
       mov       rcx,r15
       call      qword ptr [7FFE483B1198]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       mov       rdx,[r14+20]
       mov       rcx,r15
       call      qword ptr [7FFE483B11A8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       call      qword ptr [7FFE486C6370]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE483B11B8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       mov       rdx,[r14+28]
       mov       rcx,r15
       call      qword ptr [7FFE483B11C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       mov       rdx,[r14+30]
       mov       rcx,r15
       call      qword ptr [7FFE483B11D8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       mov       rcx,rbx
       mov       rdx,7FFE486A1618
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFE486A1D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L10:
       cmp       byte ptr [rsp+48],0
       je        near ptr M01_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE480347B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FFE48514750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L12
       call      qword ptr [7FFE48514570]
       mov       rbx,rax
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,27F4F366F60
       mov       r8,rbx
       call      qword ptr [7FFE4803D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L13:
       xor       r14d,r14d
       mov       eax,r14d
       test      r14d,r14d
       jne       near ptr M01_L02
M01_L14:
       cmp       byte ptr [rsp+40],0
       je        near ptr M01_L02
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE480347B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L15:
       call      qword ptr [7FFE48514750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L16
       call      qword ptr [7FFE48514570]
       mov       rbx,rax
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,27F4F366F90
       mov       r8,rbx
       call      qword ptr [7FFE4803D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       xor       r15d,r15d
       mov       eax,r15d
       test      r15d,r15d
       jne       near ptr M01_L04
M01_L18:
       cmp       byte ptr [rsp+38],0
       je        near ptr M01_L04
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE480347B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebp,eax
       jmp       near ptr M01_L05
M01_L19:
       call      qword ptr [7FFE48514750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L20
       call      qword ptr [7FFE48514570]
       mov       rbx,rax
M01_L20:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,27F4F366FC0
       mov       r8,rbx
       call      qword ptr [7FFE4803D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 761
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRefPerson()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFE4838C348]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
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
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       mov       [rsp+50],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       ebp,r9d
       mov       byte ptr [rsp+48],1
       mov       dword ptr [rsp+4C],2
       mov       eax,esi
       not       eax
       shr       eax,1F
       mov       ecx,eax
       test      eax,eax
       je        near ptr M01_L10
M01_L00:
       test      ecx,ecx
       je        near ptr M01_L11
M01_L01:
       xor       eax,eax
       mov       [rsp+40],rax
       cmp       edi,5
       jl        near ptr M01_L13
       xor       r14d,r14d
       cmp       edi,64
       setle     r14b
       mov       eax,r14d
       test      r14d,r14d
       je        near ptr M01_L14
M01_L02:
       test      eax,eax
       je        near ptr M01_L15
M01_L03:
       xor       eax,eax
       mov       [rsp+38],rax
       cmp       ebp,5
       jl        near ptr M01_L17
       xor       r15d,r15d
       cmp       ebp,32
       setle     r15b
       mov       eax,r15d
       test      r15d,r15d
       je        near ptr M01_L18
M01_L04:
       test      eax,eax
       je        near ptr M01_L19
M01_L05:
       call      qword ptr [7FFE483877C8]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFE4838C708]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L09
M01_L07:
       mov       [rsp+20],ebp
       mov       rdx,[r14+10]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFE48677D80]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE483A1168]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       vmovups   xmm0,[r14+38]
       vmovups   [rsp+28],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE483A1178]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[r14+8]
       mov       rcx,r15
       call      qword ptr [7FFE483A1188]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       mov       rdx,[r14+18]
       mov       rcx,r15
       call      qword ptr [7FFE483A1198]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       mov       rdx,[r14+20]
       mov       rcx,r15
       call      qword ptr [7FFE483A11A8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       call      qword ptr [7FFE4867FAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE483A11B8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       mov       rdx,[r14+28]
       mov       rcx,r15
       call      qword ptr [7FFE483A11C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       mov       rdx,[r14+30]
       mov       rcx,r15
       call      qword ptr [7FFE483A11D8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       mov       rcx,rbx
       mov       rdx,7FFE4861BDF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFE4861C528
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L10:
       cmp       byte ptr [rsp+48],0
       je        near ptr M01_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE480247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FFE48504750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L12
       call      qword ptr [7FFE48504570]
       mov       rbx,rax
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,28C12FA6F60
       mov       r8,rbx
       call      qword ptr [7FFE4802D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L13:
       xor       r14d,r14d
       mov       eax,r14d
       test      r14d,r14d
       jne       near ptr M01_L02
M01_L14:
       cmp       byte ptr [rsp+40],0
       je        near ptr M01_L02
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE480247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L15:
       call      qword ptr [7FFE48504750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L16
       call      qword ptr [7FFE48504570]
       mov       rbx,rax
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28C12FA6F90
       mov       r8,rbx
       call      qword ptr [7FFE4802D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       xor       r15d,r15d
       mov       eax,r15d
       test      r15d,r15d
       jne       near ptr M01_L04
M01_L18:
       cmp       byte ptr [rsp+38],0
       je        near ptr M01_L04
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE480247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebp,eax
       jmp       near ptr M01_L05
M01_L19:
       call      qword ptr [7FFE48504750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L20
       call      qword ptr [7FFE48504570]
       mov       rbx,rax
M01_L20:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28C12FA6FC0
       mov       r8,rbx
       call      qword ptr [7FFE4802D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 761
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePersonVal()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       lea       rcx,[rsp+68]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFE4838C4E0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+68]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE48734000]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       nop
       add       rsp,0B0
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 135
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       xor       eax,eax
       mov       [rsp+90],rax
       mov       r14,rcx
       mov       ebx,edx
       mov       ebp,r8d
       mov       r15d,r9d
       mov       byte ptr [rsp+48],1
       mov       dword ptr [rsp+4C],2
       mov       eax,ebx
       not       eax
       shr       eax,1F
       mov       ecx,eax
       test      eax,eax
       je        near ptr M01_L06
M01_L00:
       test      ecx,ecx
       je        near ptr M01_L07
M01_L01:
       xor       eax,eax
       mov       [rsp+40],rax
       cmp       ebp,5
       jl        near ptr M01_L09
       xor       r13d,r13d
       cmp       ebp,64
       setle     r13b
       mov       eax,r13d
       test      r13d,r13d
       je        near ptr M01_L10
M01_L02:
       test      eax,eax
       je        near ptr M01_L11
M01_L03:
       xor       eax,eax
       mov       [rsp+38],rax
       cmp       r15d,5
       jl        near ptr M01_L13
       xor       r12d,r12d
       cmp       r15d,32
       setle     r12b
       mov       eax,r12d
       test      r12d,r12d
       je        near ptr M01_L14
M01_L04:
       test      eax,eax
       je        near ptr M01_L15
M01_L05:
       call      qword ptr [7FFE48387060]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,266DE60B828
       mov       [rax+8],rcx
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+50],rdi
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+88],xmm0
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       [rsp+60],rcx
       mov       [rsp+68],rcx
       mov       [rsp+70],rcx
       mov       [rsp+78],rcx
       mov       [rsp+80],rcx
       mov       rcx,[rsi+10]
       mov       edx,ebx
       mov       r8d,ebp
       mov       r9d,r15d
       call      qword ptr [7FFE4868E598]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE48264270]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Addresses(System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       vmovups   xmm0,[rsi+38]
       vmovups   [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE48264318]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[rsi+8]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE48264378]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_CellPhone(System.String)
       mov       rdx,[rsi+18]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE482643D8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Email(System.String)
       mov       rdx,[rsi+20]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE48264438]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_FirstName(System.String)
       call      qword ptr [7FFE4868D170]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE482644B0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Id(System.String)
       mov       rdx,[rsi+28]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE48264510]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_LastName(System.String)
       mov       rdx,[rsi+30]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE48264570]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Phone(System.String)
       mov       rdi,r14
       lea       rsi,[rsp+50]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,r14
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
M01_L06:
       cmp       byte ptr [rsp+48],0
       je        near ptr M01_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE480247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L07:
       call      qword ptr [7FFE484AF618]
       mov       r13,rax
       test      r13,r13
       jne       short M01_L08
       call      qword ptr [7FFE484AF438]
       mov       r13,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,266DE606F60
       mov       r8,r13
       call      qword ptr [7FFE4802D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L09:
       xor       r13d,r13d
       mov       eax,r13d
       test      r13d,r13d
       jne       near ptr M01_L02
M01_L10:
       cmp       byte ptr [rsp+40],0
       je        near ptr M01_L02
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE480247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebp,eax
       jmp       near ptr M01_L03
M01_L11:
       call      qword ptr [7FFE484AF618]
       mov       r12,rax
       test      r12,r12
       jne       short M01_L12
       call      qword ptr [7FFE484AF438]
       mov       r12,rax
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,266DE606F90
       mov       r8,r12
       call      qword ptr [7FFE4802D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       xor       r12d,r12d
       mov       eax,r12d
       test      r12d,r12d
       jne       near ptr M01_L04
M01_L14:
       cmp       byte ptr [rsp+38],0
       je        near ptr M01_L04
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE480247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       r15d,eax
       jmp       near ptr M01_L05
M01_L15:
       call      qword ptr [7FFE484AF618]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L16
       call      qword ptr [7FFE484AF438]
       mov       rbx,rax
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,266DE606FC0
       mov       r8,rbx
       call      qword ptr [7FFE4802D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 883
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateValPerson()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       lea       rcx,[rsp+68]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFE4839CBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+68]
       mov       ecx,9
       rep movsq
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE48725F20]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       nop
       add       rsp,0B0
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 135
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       xor       eax,eax
       mov       [rsp+90],rax
       mov       r14,rcx
       mov       ebx,edx
       mov       ebp,r8d
       mov       r15d,r9d
       mov       byte ptr [rsp+48],1
       mov       dword ptr [rsp+4C],2
       mov       eax,ebx
       not       eax
       shr       eax,1F
       mov       ecx,eax
       test      eax,eax
       je        near ptr M01_L06
M01_L00:
       test      ecx,ecx
       je        near ptr M01_L07
M01_L01:
       xor       eax,eax
       mov       [rsp+40],rax
       cmp       ebp,5
       jl        near ptr M01_L09
       xor       r13d,r13d
       cmp       ebp,64
       setle     r13b
       mov       eax,r13d
       test      r13d,r13d
       je        near ptr M01_L10
M01_L02:
       test      eax,eax
       je        near ptr M01_L11
M01_L03:
       xor       eax,eax
       mov       [rsp+38],rax
       cmp       r15d,5
       jl        near ptr M01_L13
       xor       r12d,r12d
       cmp       r15d,32
       setle     r12b
       mov       eax,r12d
       test      r12d,r12d
       je        near ptr M01_L14
M01_L04:
       test      eax,eax
       je        near ptr M01_L15
M01_L05:
       call      qword ptr [7FFE483977C8]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,23A14F9B828
       mov       [rax+8],rcx
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+50],rdi
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+88],xmm0
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       [rsp+60],rcx
       mov       [rsp+68],rcx
       mov       [rsp+70],rcx
       mov       [rsp+78],rcx
       mov       [rsp+80],rcx
       mov       rcx,[rsi+10]
       mov       edx,ebx
       mov       r8d,ebp
       mov       r9d,r15d
       call      qword ptr [7FFE486C45B8]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE482747F8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Addresses(System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>)
       vmovups   xmm0,[rsi+38]
       vmovups   [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE482748A0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_BornOn(System.DateTimeOffset)
       mov       rdx,[rsi+8]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE48274900]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_CellPhone(System.String)
       mov       rdx,[rsi+18]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE48274960]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Email(System.String)
       mov       rdx,[rsi+20]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE482749C0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_FirstName(System.String)
       call      qword ptr [7FFE4868EEC8]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE48274A38]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Id(System.String)
       mov       rdx,[rsi+28]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE48274A98]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_LastName(System.String)
       mov       rdx,[rsi+30]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFE48274AF8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]].set_Phone(System.String)
       mov       rdi,r14
       lea       rsi,[rsp+50]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,r14
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
M01_L06:
       cmp       byte ptr [rsp+48],0
       je        near ptr M01_L00
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE480347B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L07:
       call      qword ptr [7FFE48514750]
       mov       r13,rax
       test      r13,r13
       jne       short M01_L08
       call      qword ptr [7FFE48514570]
       mov       r13,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,23A14F96F60
       mov       r8,r13
       call      qword ptr [7FFE4803D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L09:
       xor       r13d,r13d
       mov       eax,r13d
       test      r13d,r13d
       jne       near ptr M01_L02
M01_L10:
       cmp       byte ptr [rsp+40],0
       je        near ptr M01_L02
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE480347B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebp,eax
       jmp       near ptr M01_L03
M01_L11:
       call      qword ptr [7FFE48514750]
       mov       r12,rax
       test      r12,r12
       jne       short M01_L12
       call      qword ptr [7FFE48514570]
       mov       r12,rax
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,23A14F96F90
       mov       r8,r12
       call      qword ptr [7FFE4803D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       xor       r12d,r12d
       mov       eax,r12d
       test      r12d,r12d
       jne       near ptr M01_L04
M01_L14:
       cmp       byte ptr [rsp+38],0
       je        near ptr M01_L04
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE480347B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       r15d,eax
       jmp       near ptr M01_L05
M01_L15:
       call      qword ptr [7FFE48514750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L16
       call      qword ptr [7FFE48514570]
       mov       rbx,rax
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23A14F96FC0
       mov       r8,rbx
       call      qword ptr [7FFE4803D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 883
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Address> ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePhoneNumber()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0EB
       xor       edx,edx
       call      qword ptr [7FFE483A7768]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumber(DotNetTips.Spargine.Tester.Data.CountryName, Boolean)
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
; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumber(DotNetTips.Spargine.Tester.Data.CountryName, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       mov       esi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       rdx,rax
       mov       rcx,26E9C18BE78
       cmp       [rcx],ecx
       call      qword ptr [7FFE47EDA770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M01_L01
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Countries+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],ebx
       mov       ecx,[rdi+8]
       mov       [rdi+8],ecx
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE484C6C88]; DotNetTips.Spargine.Tester.Data.Countries.GetCountries()
       mov       rbp,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFE48731440
       mov       [rbx+18],r9
       lea       r9,[rsp+20]
       mov       rdx,rbp
       mov       r8,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>, System.Func`2<DotNetTips.Spargine.Tester.Data.Country,Boolean>, Boolean ByRef)
       call      qword ptr [7FFE486D6658]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       test      sil,sil
       jne       short M01_L00
       mov       ecx,[rax+0B8]
       call      qword ptr [7FFE483A7690]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rbx,[rax+70]
       mov       ecx,[rax+0B8]
       call      qword ptr [7FFE483A7690]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,26E9C170C30
       call      qword ptr [7FFE47F96B20]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      qword ptr [7FFE48524618]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L02
       call      qword ptr [7FFE48524570]
       mov       rbx,rax
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,26E9C18BE48
       mov       r8,rbx
       call      qword ptr [7FFE4804D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 320
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileName()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       mov       rdx,2DF072ABE48
       call      qword ptr [7FFE483B7780]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(Int32, System.String)
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
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(Int32, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       esi,ecx
       mov       rbx,rdx
       xor       ecx,ecx
       mov       [rsp+20],rcx
       test      esi,esi
       jle       near ptr M01_L06
       xor       edi,edi
       cmp       esi,100
       setle     dil
       mov       eax,edi
       test      edi,edi
       je        near ptr M01_L07
M01_L00:
       test      eax,eax
       je        near ptr M01_L08
M01_L01:
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L10
       mov       eax,[rcx+8]
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L10
M01_L02:
       cmp       [rcx],ecx
       call      qword ptr [7FFE47FA7318]; System.String.Trim()
       mov       rbx,rax
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,29E79401DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE48261FF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+30],rax
       test      rax,rax
       je        near ptr M01_L11
       lea       rbp,[rax+10]
       mov       r14d,[rax+8]
M01_L03:
       mov       [rsp+40],rbp
       mov       [rsp+48],r14d
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       byte ptr [rsp+3C],0
       mov       ecx,esi
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFE483B78D0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       cmp       byte ptr [rsp+3C],0
       jne       near ptr M01_L12
       test      rdx,rdx
       je        near ptr M01_L12
       mov       r8d,[rsp+38]
       cmp       r8d,[rsp+48]
       ja        near ptr M01_L13
       mov       rcx,[rsp+40]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,r8d
       mov       edi,[rdx+8]
       cmp       edi,eax
       ja        near ptr M01_L12
       add       rdx,0C
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE48055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       edi,[rsp+38]
       mov       [rsp+38],edi
M01_L04:
       lea       rcx,[rsp+28]
       mov       edx,2E
       call      qword ptr [7FFE48414F60]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+3C],0
       jne       near ptr M01_L14
       test      rbx,rbx
       je        near ptr M01_L14
       mov       r8d,[rsp+38]
       cmp       r8d,[rsp+48]
       ja        near ptr M01_L13
       mov       rcx,[rsp+40]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,r8d
       mov       ebp,[rbx+8]
       cmp       ebp,edx
       ja        near ptr M01_L14
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE48055B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,[rsp+38]
       mov       [rsp+38],ebp
M01_L05:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE480C5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       call      qword ptr [7FFE48297A68]; System.IO.Path.GetTempPath()
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE48297750]; System.IO.Path.Combine(System.String, System.String)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       xor       edi,edi
       mov       eax,edi
       test      edi,edi
       jne       near ptr M01_L00
M01_L07:
       cmp       byte ptr [rsp+20],0
       je        near ptr M01_L00
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE480547B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L08:
       call      qword ptr [7FFE48534750]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L09
       call      qword ptr [7FFE48534570]
       mov       r14,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2DF072ABE80
       mov       r8,r14
       call      qword ptr [7FFE4805D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,2DF072ABE48
       jmp       near ptr M01_L02
M01_L11:
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       near ptr M01_L03
M01_L12:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE480C5848]
       jmp       near ptr M01_L04
M01_L13:
       call      qword ptr [7FFE4813E9A0]
       int       3
M01_L14:
       lea       rcx,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFE480C5848]
       jmp       near ptr M01_L05
; Total bytes of code 634
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomLocationData()
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE483A77B0]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomLocationData()
       vmovdqu   xmm0,xmmword ptr [rsp+38]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       mov       rdx,[rsp+48]
       mov       [rsp+30],rdx
       mov       rdx,[rbx+18]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,offset MD_BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`3[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester],[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.8.Tester],[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.ValueTuple`3<DotNetTips.Spargine.Tester.Data.Country,DotNetTips.Spargine.Tester.Data.State,DotNetTips.Spargine.Tester.Data.City> ByRef)
       call      qword ptr [7FFE48735410]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`3<System.__Canon,System.__Canon,System.__Canon> ByRef)
       nop
       add       rsp,50
       pop       rbx
       ret
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRandomLocationData()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rdx,295E5004DF8
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L14
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M01_L15
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE47F94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L01
       mov       rcx,[rax+8]
       mov       r11,7FFE47E50A38
       call      qword ptr [r11]
       jmp       short M01_L02
M01_L01:
       mov       rcx,rax
       mov       r11,7FFE47E50A30
       call      qword ptr [r11]
M01_L02:
       test      eax,eax
       jle       near ptr M01_L23
       mov       rcx,rsi
       call      qword ptr [7FFE486965C8]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L20
       mov       rcx,295D9001590
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L22
M01_L03:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L41
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,295E5001E20
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [rsi+10],r8d
       mov       [rsi+14],r8d
       mov       rdx,rsi
       lea       r8,[rsp+30]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>, Boolean ByRef)
       call      qword ptr [7FFE4824E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rsi,rax
M01_L04:
       xor       edi,edi
       xor       ebp,ebp
       mov       rdx,[rsi+88]
       test      rdx,rdx
       je        near ptr M01_L12
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L12
       mov       r14,[rsi+88]
       test      r14,r14
       je        near ptr M01_L24
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE47F94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L25
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L05
       mov       rcx,[rax+8]
       mov       r11,7FFE47E50A68
       call      qword ptr [r11]
       jmp       short M01_L06
M01_L05:
       mov       rcx,rax
       mov       r11,7FFE47E50A60
       call      qword ptr [r11]
M01_L06:
       test      eax,eax
       jle       near ptr M01_L32
       mov       rcx,r14
       call      qword ptr [7FFE486965C8]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L29
       mov       rcx,295D90015A0
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M01_L31
M01_L07:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.8.Tester],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r15,r15
       je        near ptr M01_L41
       xor       ecx,ecx
       mov       [rdi+10],rcx
       lea       rcx,[rdi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,295E5001E20
       mov       rdx,[rcx]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+10],r8d
       mov       [r14+14],r8d
       mov       rdx,r14
       lea       r8,[rsp+28]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>, Boolean ByRef)
       call      qword ptr [7FFE4824E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rdi,rax
M01_L08:
       mov       r14,[rdi+8]
       mov       rdx,r14
       test      rdx,rdx
       je        near ptr M01_L12
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L12
       test      r14,r14
       je        near ptr M01_L33
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE47F94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       short M01_L09
       mov       rcx,[rax+8]
       mov       r11,7FFE47E50A98
       call      qword ptr [r11]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE47E50A90
       call      qword ptr [r11]
M01_L10:
       test      eax,eax
       jle       near ptr M01_L42
       mov       rcx,r14
       call      qword ptr [7FFE486965C8]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L38
       mov       rcx,295D90015B0
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M01_L40
M01_L11:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.8.Tester],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r15,r15
       je        near ptr M01_L41
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,295E5001E20
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+10],r8d
       mov       [r14+14],r8d
       mov       rdx,r14
       lea       r8,[rsp+20]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>, Boolean ByRef)
       call      qword ptr [7FFE4824E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rbp,rax
M01_L12:
       mov       rdx,rsi
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L13:
       call      CORINFO_HELP_OVERFLOW
M01_L14:
       call      qword ptr [7FFE48337660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L15:
       call      qword ptr [7FFE48524768]
       mov       ecx,49
       mov       rdx,7FFE4838DEE0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE482562B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE47F96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE4838DEE0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE47F96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE48524558]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE48156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE47F94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L17
       mov       rcx,rax
       mov       r11,7FFE47E50A28
       call      qword ptr [r11]
       jmp       near ptr M01_L02
M01_L17:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFE47E50A18
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M01_L19
M01_L18:
       add       edi,1
       jo        near ptr M01_L13
M01_L19:
       mov       rcx,rbp
       mov       r11,7FFE47E50A20
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       eax,edi
       jmp       near ptr M01_L02
M01_L20:
       call      qword ptr [7FFE48524588]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L21
       call      qword ptr [7FFE48524558]
       mov       rbx,rax
M01_L21:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2D66B0748D0
       mov       r8,rbx
       call      qword ptr [7FFE48156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.8.Tester],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,295D9001588
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE48693BE8
       call      qword ptr [7FFE47F94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,295D9001590
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L23:
       xor       esi,esi
       jmp       near ptr M01_L04
M01_L24:
       call      qword ptr [7FFE48524768]
       mov       ecx,49
       mov       rdx,7FFE4838DEE0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE482562B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE47F96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE4838DEE0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE47F96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE48524558]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE48156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE47F94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L26
       mov       rcx,rax
       mov       r11,7FFE47E50A58
       call      qword ptr [r11]
       jmp       near ptr M01_L06
M01_L26:
       xor       edi,edi
       mov       rcx,r14
       mov       r11,7FFE47E50A48
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M01_L28
M01_L27:
       add       edi,1
       jo        near ptr M01_L13
M01_L28:
       mov       rcx,r15
       mov       r11,7FFE47E50A50
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L27
       mov       eax,edi
       jmp       near ptr M01_L06
M01_L29:
       call      qword ptr [7FFE48524588]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L30
       call      qword ptr [7FFE48524558]
       mov       rbx,rax
M01_L30:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2D66B0748D0
       mov       r8,rbx
       call      qword ptr [7FFE48156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.8.Tester],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,295D9001598
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,7FFE48693BE8
       call      qword ptr [7FFE47F94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,295D90015A0
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L07
M01_L32:
       xor       edi,edi
       jmp       near ptr M01_L08
M01_L33:
       call      qword ptr [7FFE48524768]
       mov       ecx,49
       mov       rdx,7FFE4838DEE0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE482562B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE47F96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE4838DEE0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE47F96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE48524558]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE48156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L34:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE47F94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L35
       mov       rcx,rax
       mov       r11,7FFE47E50A88
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L35:
       xor       ebp,ebp
       mov       rcx,r14
       mov       r11,7FFE47E50A78
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M01_L37
M01_L36:
       add       ebp,1
       jo        near ptr M01_L13
M01_L37:
       mov       rcx,r15
       mov       r11,7FFE47E50A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L36
       mov       eax,ebp
       jmp       near ptr M01_L10
M01_L38:
       call      qword ptr [7FFE48524588]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L39
       call      qword ptr [7FFE48524558]
       mov       rbx,rax
M01_L39:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2D66B0748D0
       mov       r8,rbx
       call      qword ptr [7FFE48156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.8.Tester],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,295D90015A8
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       r8,7FFE48693BE8
       call      qword ptr [7FFE47F94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,295D90015B0
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L11
M01_L41:
       mov       ecx,9
       call      qword ptr [7FFE48154F30]
       int       3
M01_L42:
       xor       ebp,ebp
       jmp       near ptr M01_L12
; Total bytes of code 2297
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`3<System.__Canon,System.__Canon,System.__Canon> ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomPersonData()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE483A77C8]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
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
; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE483A77B0]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomLocationData()
       mov       rbx,[rsp+48]
       mov       rdx,1C2E2004E08
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L21
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M01_L22
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE47F94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L25
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M01_L08
       mov       rcx,[rax+8]
       mov       r11,7FFE47E50AC8
       call      qword ptr [r11]
M01_L01:
       test      eax,eax
       jle       near ptr M01_L30
       mov       rcx,rsi
       call      qword ptr [7FFE486965C8]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L23
       mov       rcx,1C2E2007570
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L29
M01_L02:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L17
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1C2E2001E20
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [rsi+10],r8d
       mov       [rsi+14],r8d
       mov       rdx,rsi
       lea       r8,[rsp+40]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFE4824E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rsi,rax
M01_L03:
       mov       rdx,1C2E2004E10
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L31
       mov       rdi,[rcx+18]
M01_L04:
       test      rdi,rdi
       je        near ptr M01_L32
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE47F94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M01_L09
       mov       rcx,[rax+8]
       mov       r11,7FFE47E50AF8
       call      qword ptr [r11]
M01_L05:
       test      eax,eax
       jle       near ptr M01_L18
       mov       rcx,rdi
       call      qword ptr [7FFE486965C8]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L14
       mov       rcx,1C2E2007570
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M01_L16
M01_L06:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbp,rbp
       je        near ptr M01_L17
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1C2E2001E20
       mov       rdx,[rcx]
       lea       rcx,[r14+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+28],0
       mov       rcx,offset MT_System.Linq.OrderedPartition`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [rdi+10],r8d
       mov       [rdi+14],r8d
       mov       rdx,rdi
       lea       r8,[rsp+38]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFE4824E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rdi,rax
M01_L07:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonData
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE48696700]; DotNetTips.Spargine.Tester.PersonData..ctor()
       call      qword ptr [7FFE481C5B90]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+60]
       mov       r8d,1
       call      qword ptr [7FFE4824C780]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,5A
       call      qword ptr [7FFE483A7648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L20
       movsxd    rcx,ecx
       mov       rax,141DD76000
       imul      rcx,rax
       mov       rax,0CCCCCCCCCCCCCCC
       cmp       rcx,rax
       jg        near ptr M01_L19
       mov       rax,0F333333333333334
       cmp       rcx,rax
       jl        near ptr M01_L19
       lea       r14,[rcx+rcx*4]
       add       r14,r14
       lea       rcx,[rsp+60]
       call      qword ptr [7FFE4824C168]; System.DateTimeOffset.get_ClockDateTime()
       mov       [rsp+30],rax
       lea       rcx,[rsp+30]
       mov       rdx,r14
       call      qword ptr [7FFE481C53C8]; System.DateTime.Subtract(System.TimeSpan)
       mov       rdx,rax
       movsx     rcx,word ptr [rsp+60]
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L19
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L19
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE4824C048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovups   xmm0,[rsp+20]
       vmovups   [rbp+38],xmm0
       mov       ecx,[rbx+0B8]
       call      qword ptr [7FFE483A7690]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE483A7468]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddressWithName(System.String, System.String)
       lea       rcx,[rbp+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+0B8]
       call      qword ptr [7FFE483A7690]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[rbp+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbp
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L08:
       mov       rcx,rax
       mov       r11,7FFE47E50AC0
       call      qword ptr [r11]
       jmp       near ptr M01_L01
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE47E50AF0
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE47F94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L11
       mov       rcx,rax
       mov       r11,7FFE47E50AE8
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L11:
       xor       ebp,ebp
       mov       rcx,rdi
       mov       r11,7FFE47E50AD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M01_L13
M01_L12:
       add       ebp,1
       jo        near ptr M01_L20
M01_L13:
       mov       rcx,r14
       mov       r11,7FFE47E50AE0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L12
       mov       eax,ebp
       jmp       near ptr M01_L05
M01_L14:
       call      qword ptr [7FFE48524588]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L15
       call      qword ptr [7FFE48524558]
       mov       rbx,rax
M01_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,20373F148D0
       mov       r8,rbx
       call      qword ptr [7FFE48156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1C2E2007568
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,7FFE48693BE8
       call      qword ptr [7FFE47F94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C2E2007570
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L06
M01_L17:
       mov       ecx,9
       call      qword ptr [7FFE48154F30]
       int       3
M01_L18:
       xor       edi,edi
       jmp       near ptr M01_L07
M01_L19:
       call      qword ptr [7FFE4812EB80]
       int       3
M01_L20:
       call      CORINFO_HELP_OVERFLOW
M01_L21:
       call      qword ptr [7FFE48337660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L22:
       call      qword ptr [7FFE48524768]
       mov       ecx,49
       mov       rdx,7FFE4838DEE0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE482562B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE47F96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE4838DEE0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE47F96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE48524558]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE48156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       call      qword ptr [7FFE48524588]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L24
       call      qword ptr [7FFE48524558]
       mov       rbx,rax
M01_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,20373F148D0
       mov       r8,rbx
       call      qword ptr [7FFE48156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE47F94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L26
       mov       rcx,rax
       mov       r11,7FFE47E50AB8
       call      qword ptr [r11]
       jmp       near ptr M01_L01
M01_L26:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFE47E50AA8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M01_L28
M01_L27:
       add       edi,1
       jo        near ptr M01_L20
M01_L28:
       mov       rcx,rbp
       mov       r11,7FFE47E50AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L27
       mov       eax,edi
       jmp       near ptr M01_L01
M01_L29:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1C2E2007568
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE48693BE8
       call      qword ptr [7FFE47F94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C2E2007570
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L30:
       xor       esi,esi
       jmp       near ptr M01_L03
M01_L31:
       call      qword ptr [7FFE48337660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       near ptr M01_L04
M01_L32:
       call      qword ptr [7FFE48524768]
       mov       ecx,49
       mov       rdx,7FFE4838DEE0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE482562B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE47F96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE4838DEE0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE47F96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE48524558]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE48156670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1962
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomPersonName()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rdx,221B4802E10
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L05
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M00_L06
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE47F74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L08
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M00_L07
       mov       rcx,[rax+8]
       mov       r11,7FFE47E309F8
       call      qword ptr [r11]
M00_L01:
       test      eax,eax
       jle       near ptr M00_L16
       mov       rcx,rsi
       call      qword ptr [7FFE48684F48]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L12
       mov       rcx,221B4805598
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L14
M00_L02:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L15
       xor       ecx,ecx
       mov       [rbp+10],rcx
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,221B8801E20
       mov       rdx,[rcx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       r8d,1
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       call      qword ptr [7FFE48686730]; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       lea       r8,[rsp+30]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Boolean ByRef)
       call      qword ptr [7FFE481CDD88]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rsi,rax
M00_L03:
       mov       rcx,221B4802E18
       mov       rcx,[rcx]
       call      qword ptr [7FFE48316EF8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFE48685FE0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rsp+20],rsi
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`2<System.String,System.String> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE486FFFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`2<System.__Canon,System.__Canon> ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       call      CORINFO_HELP_OVERFLOW
M00_L05:
       call      qword ptr [7FFE48316E68]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L00
M00_L06:
       call      qword ptr [7FFE484AF630]
       mov       ecx,49
       mov       rdx,7FFE4836F060
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE48236438
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE47F76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE4836F060
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE47F76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE484AF420]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE48136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       mov       rcx,rax
       mov       r11,7FFE47E309F0
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE47F74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L09
       mov       rcx,rax
       mov       r11,7FFE47E309E8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L09:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFE47E309D8
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M00_L11
M00_L10:
       add       edi,1
       jo        near ptr M00_L04
M00_L11:
       mov       rcx,rbp
       mov       r11,7FFE47E309E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L10
       mov       eax,edi
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFE484AF450]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L13
       call      qword ptr [7FFE484AF420]
       mov       rbx,rax
M00_L13:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,262469948D0
       mov       r8,rbx
       call      qword ptr [7FFE48136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L14:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,221B4805590
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE48682568
       call      qword ptr [7FFE47F74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,221B4805598
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L15:
       mov       ecx,9
       call      qword ptr [7FFE48134F30]
       int       3
M00_L16:
       xor       esi,esi
       jmp       near ptr M00_L03
; Total bytes of code 863
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
       jmp       qword ptr [7FFE47F74378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L06
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE47F74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M02_L00
       mov       rcx,[rax+8]
       mov       r11,7FFE47E309A8
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L00:
       mov       rcx,rax
       mov       r11,7FFE47E309A0
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE47F74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       r11,7FFE47E30998
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M02_L02:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FFE47E30988
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M02_L04
M02_L03:
       add       esi,1
       jo        short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       r11,7FFE47E30990
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
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbx
       mov       rdx,7FFE4875A398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE47F74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M03_L04
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rbx
       mov       rdx,7FFE4875A588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L03:
       mov       rcx,rbp
       mov       edx,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M03_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFE4875A628
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rsi
       call      qword ptr [7FFE47F74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       short M03_L09
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M03_L07
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rbx
       mov       rdx,7FFE4875B498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE481CD368]
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L09:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L10
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rbx
       mov       rdx,7FFE4875B3E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       r9d,[rdi-1]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFE4877D350]
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
       je        near ptr M04_L19
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rbx
       mov       rdx,7FFE48754F68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE47F74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M04_L02
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M04_L02
       jmp       short M04_L03
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FFE48755538
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L03:
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
M04_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rbx
       mov       rdx,7FFE48755158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       mov       rdx,rsi
       call      qword ptr [7FFE47F74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L11
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M04_L07
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rbx
       mov       rdx,7FFE48755400
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L08:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M04_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M04_L09
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M04_L09
       jmp       short M04_L10
M04_L09:
       mov       rcx,rbx
       mov       rdx,7FFE48755418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L10:
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
M04_L11:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M04_L12
       jmp       short M04_L13
M04_L12:
       mov       rcx,rbx
       mov       rdx,7FFE48755310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FFE47E308F0
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L16
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M04_L14
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M04_L14
       jmp       short M04_L15
M04_L14:
       mov       rcx,rbx
       mov       rdx,7FFE48755328
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rsp
       call      M04_L20
       jmp       short M04_L18
M04_L16:
       mov       rcx,rsp
       call      M04_L20
       nop
M04_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L18:
       mov       rax,[rbp-30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L19:
       mov       ecx,10
       call      qword ptr [7FFE48134F30]
       int       3
M04_L20:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M04_L21
       mov       rcx,[rbp-28]
       mov       r11,7FFE47E308F8
       call      qword ptr [r11]
M04_L21:
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
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       cmp       qword ptr [rcx+8],0
       jne       short M05_L00
       mov       rax,[rcx+18]
       ret
M05_L00:
       jmp       qword ptr [7FFE48316E68]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M06_L07
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFE47F74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M06_L09
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M06_L08
       mov       rcx,[rax+8]
       mov       r11,7FFE47E30930
       call      qword ptr [r11]
M06_L00:
       test      eax,eax
       jle       short M06_L05
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M06_L01
       jmp       short M06_L02
M06_L01:
       mov       rcx,rsi
       mov       rdx,7FFE486191B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M06_L02:
       mov       rcx,[rsi+10]
       mov       rbp,[rcx+20]
       test      rbp,rbp
       je        short M06_L03
       jmp       short M06_L04
M06_L03:
       mov       rcx,rsi
       mov       rdx,7FFE48619200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M06_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFE48686310]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE48097900]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L06:
       call      CORINFO_HELP_OVERFLOW
M06_L07:
       call      qword ptr [7FFE484AF630]
       mov       ecx,49
       mov       rdx,7FFE4836F060
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE48236438
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE47F76B08]
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE4836F060
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE47F76B08]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE484AF420]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE48136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L08:
       mov       rcx,rax
       mov       r11,7FFE47E30928
       call      qword ptr [r11]
       jmp       near ptr M06_L00
M06_L09:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection`1[[System.Object, System.Private.CoreLib]]
       call      qword ptr [7FFE47F74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M06_L10
       mov       rcx,rax
       mov       r11,7FFE47E30920
       call      qword ptr [r11]
       jmp       near ptr M06_L00
M06_L10:
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFE47E30910
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       short M06_L12
M06_L11:
       add       edi,1
       jo        near ptr M06_L06
M06_L12:
       mov       rcx,rbp
       mov       r11,7FFE47E30918
       call      qword ptr [r11]
       test      eax,eax
       jne       short M06_L11
       mov       eax,edi
       jmp       near ptr M06_L00
; Total bytes of code 495
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
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rcx,rdx
       mov       rdx,7FFE48711DB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       rdx,rbx
       call      qword ptr [7FFE48734048]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`2<System.__Canon,System.__Canon> ByRef)
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
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
M08_L00:
       mov       rsi,[rbx+8]
M08_L00:
       mov       rsi,[rbx+8]
M08_L00:
       mov       rsi,[rbx+8]
M08_L00:
       mov       rsi,[rbx+8]
M08_L00:
       mov       rsi,[rbx+8]
M08_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M08_L01
       je        short M08_L01
       je        short M08_L01
       je        short M08_L01
       je        short M08_L01
       je        short M08_L01
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
       jne       short M08_L03
       jne       short M08_L03
       jne       short M08_L03
       jne       short M08_L03
       jne       short M08_L03
       jne       short M08_L03
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
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
M08_L01:
       cmp       qword ptr [rbx+8],0
M08_L01:
       cmp       qword ptr [rbx+8],0
M08_L01:
       cmp       qword ptr [rbx+8],0
M08_L01:
       cmp       qword ptr [rbx+8],0
M08_L01:
       cmp       qword ptr [rbx+8],0
M08_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M08_L02
       jne       short M08_L02
       jne       short M08_L02
       jne       short M08_L02
       jne       short M08_L02
       jne       short M08_L02
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
M08_L02:
       mov       rcx,rbx
M08_L02:
       mov       rcx,rbx
M08_L02:
       mov       rcx,rbx
M08_L02:
       mov       rcx,rbx
M08_L02:
       mov       rcx,rbx
M08_L02:
       mov       rcx,rbx
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
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
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M08_L03:
       cmp       edi,8
M08_L03:
       cmp       edi,8
M08_L03:
       cmp       edi,8
M08_L03:
       cmp       edi,8
M08_L03:
       cmp       edi,8
M08_L03:
       cmp       edi,8
       ja        short M08_L04
       ja        short M08_L04
       ja        short M08_L04
       ja        short M08_L04
       ja        short M08_L04
       ja        short M08_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M08_L00]
       lea       rax,[M08_L00]
       lea       rax,[M08_L00]
       lea       rax,[M08_L00]
       lea       rax,[M08_L00]
       lea       rax,[M08_L00]
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
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       jmp       short M08_L01
       jmp       short M08_L01
       jmp       short M08_L01
       jmp       short M08_L01
       jmp       short M08_L01
       jmp       short M08_L01
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
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       jmp       short M08_L01
       jmp       short M08_L01
       jmp       short M08_L01
       jmp       short M08_L01
       jmp       short M08_L01
       jmp       short M08_L01
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
       je        short M08_L05
       je        short M08_L05
       je        short M08_L05
       je        short M08_L05
       je        short M08_L05
       je        short M08_L05
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
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
M08_L04:
       mov       rcx,[rsi+8]
M08_L04:
       mov       rcx,[rsi+8]
M08_L04:
       mov       rcx,[rsi+8]
M08_L04:
       mov       rcx,[rsi+8]
M08_L04:
       mov       rcx,[rsi+8]
M08_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
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
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
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
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
M08_L05:
       mov       rcx,rbx
M08_L05:
       mov       rcx,rbx
M08_L05:
       mov       rcx,rbx
M08_L05:
       mov       rcx,rbx
M08_L05:
       mov       rcx,rbx
M08_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
       jmp       near ptr M08_L01
; Total bytes of code 1578
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
       je        short M09_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M09_L00
       test      rbx,rbx
       je        short M09_L01
       jmp       short M09_L02
M09_L00:
       test      rbx,rbx
       je        near ptr M09_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M09_L03
       mov       rcx,7FFE48883DDC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L01:
       mov       rcx,7FFE48883DE0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L02:
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M09_L01
       mov       r14d,edi
       lea       r15d,[r14+rbp]
       test      r15d,r15d
       jl        near ptr M09_L04
       mov       rcx,7FFE48883DE8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,r15d
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE48025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE48025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L03:
       mov       rcx,7FFE48883DD8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,26246980008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L04:
       mov       rcx,7FFE48883DE4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFE4810EF10]
       int       3
; Total bytes of code 291
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M10_L00
       mov       rcx,7FFE48769C1C
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M10_L00:
       mov       rcx,7FFE48769C18
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFE47F741F8]
       int       3
; Total bytes of code 82
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRelativeUrl()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE48377090]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
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
       mov       rcx,26D73804E20
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L19
       lea       rcx,[rbx+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L19
M01_L00:
       mov       rbx,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rbx
       xor       r14d,r14d
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFE48376EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jle       near ptr M01_L08
M01_L02:
       mov       edx,19
       mov       ecx,1
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L13
       test      eax,eax
       je        near ptr M01_L15
M01_L03:
       mov       ecx,1
       call      qword ptr [7FFE48376EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE48377168]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L12
       mov       esi,[rdi+8]
       test      esi,esi
       je        near ptr M01_L12
       lea       ecx,[rsi+1]
       test      ecx,ecx
       jl        near ptr M01_L17
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r8,[r13+0C]
       mov       rcx,2AE055B6744
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r13+0E]
       lea       rdx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFE48015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       mov       r8,[rbp-48]
       cmp       [r8],r8b
       test      r13,r13
       je        short M01_L07
       lea       rdx,[r13+0C]
       mov       r15d,[r13+8]
       test      r15d,r15d
       je        short M01_L07
       mov       r8,[rbp-48]
       mov       r8,[r8+8]
       mov       rcx,[rbp-48]
       mov       ebx,[rcx+18]
       lea       ecx,[rbx+r15]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L14
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       r15d,2
       jle       short M01_L06
       movsxd    r8,r15d
       add       r8,r8
       call      qword ptr [7FFE48015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       add       r15d,ebx
       mov       rcx,[rbp-48]
       mov       [rcx+18],r15d
       jmp       short M01_L07
M01_L06:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r15d,2
       jne       short M01_L05
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L05
M01_L07:
       add       r14d,1
       jo        short M01_L10
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFE48376EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,r14d
       jg        near ptr M01_L02
M01_L08:
       mov       rcx,[rbp-48]
       mov       ecx,[rcx+18]
       mov       eax,ecx
       mov       rdx,[rbp-48]
       mov       rdx,[rdx+8]
       cmp       [rdx+8],eax
       jbe       short M01_L11
       mov       word ptr [rdx+rax*2+10],2F
       inc       ecx
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
M01_L09:
       mov       rcx,[rbp-48]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE481A9430]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       near ptr M01_L18
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       mov       rcx,[rbp-48]
       mov       edx,2F
       call      qword ptr [7FFE4819C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L09
M01_L12:
       mov       r13,2AE055B6738
       jmp       near ptr M01_L04
M01_L13:
       mov       edx,1
       jmp       near ptr M01_L03
M01_L14:
       mov       rcx,[rbp-48]
       mov       r8d,r15d
       call      qword ptr [7FFE4819CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L07
M01_L15:
       call      qword ptr [7FFE4849F618]
       mov       r12,rax
       test      r12,r12
       jne       short M01_L16
       call      qword ptr [7FFE4849F438]
       mov       r12,rax
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2AE055C7730
       mov       r8,r12
       call      qword ptr [7FFE4801D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       call      qword ptr [7FFE480FEF10]
       int       3
M01_L18:
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
M01_L19:
       mov       rsi,[rbx+18]
       mov       rdi,[rsi+18]
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE48494FC0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L22
M01_L20:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M01_L00
M01_L21:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M01_L01
M01_L22:
       cmp       qword ptr [rdi+10],0
       jne       short M01_L23
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M01_L21
M01_L23:
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       call      qword ptr [7FFE48494AE0]
       test      eax,eax
       je        short M01_L21
       jmp       short M01_L20
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
       mov       rcx,26D73804E20
       mov       r15,[rcx]
       mov       r13,[r15+10]
       mov       rcx,7FFE48491080
       cmp       [r13+18],rcx
       jne       short M01_L25
       mov       rcx,[rbp-48]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       mov       rdx,[rbp-48]
       add       ecx,[rdx+1C]
       mov       rdx,[r13+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L29
       mov       rcx,[rbp-48]
       xor       edx,edx
       call      qword ptr [7FFE4819C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L26
M01_L25:
       mov       rdx,[rbp-48]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       je        short M01_L29
M01_L26:
       cmp       qword ptr [r15+20],0
       jne       short M01_L27
       lea       rcx,[r15+20]
       mov       rdx,[rbp-48]
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
       mov       r12,[r15+18]
       mov       rcx,[r12+10]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE48494FF0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L29
       mov       rcx,r12
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE48494AB0]
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
; Total bytes of code 1001
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateTempFile()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,400
       call      qword ptr [7FFE483770A8]; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       ebx,ecx
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],400
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        short M01_L02
M01_L00:
       test      eax,eax
       je        short M01_L03
M01_L01:
       mov       ecx,0A
       mov       rdx,242D617BE78
       call      qword ptr [7FFE48377018]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(Int32, System.String)
       mov       rsi,rax
       mov       ecx,ebx
       call      qword ptr [7FFE48377138]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rbx,rax
       call      qword ptr [7FFE482C6AA8]; System.IO.File.get_UTF8NoBOM()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE482C7420]; System.IO.File.Validate(System.String, System.Text.Encoding)
       mov       rcx,rsi
       mov       r9,rdi
       mov       r8,rbx
       mov       edx,2
       call      qword ptr [7FFE482C7450]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.String, System.Text.Encoding)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       cmp       byte ptr [rsp+28],0
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE480147B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebx,eax
       jmp       short M01_L01
M01_L03:
       call      qword ptr [7FFE4849F618]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE4849F438]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,242D617BE48
       mov       r8,rbx
       call      qword ptr [7FFE4801D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 220
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrl()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       call      qword ptr [7FFE48377108]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       rdx,rax
       mov       rcx,234D084BE48
       call      qword ptr [7FFE47F66B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       call      qword ptr [7FFE48377090]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE47F66B08]; System.String.Concat(System.String, System.String)
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
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE48377180]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rbx,rax
       mov       rdx,1F43E802E08
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L02
       mov       rsi,[rcx+18]
M01_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M01_L01
       xor       ecx,ecx
       call      qword ptr [7FFE48376EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jae       short M01_L03
       mov       r9d,eax
       mov       r9,[rsi+r9*8+10]
       mov       rdx,rbx
       mov       rcx,234D084BE70
       mov       r8,234D0830C48
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE47F66B38]; System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      qword ptr [7FFE48306E68]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 150
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
       call      qword ptr [7FFE48015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE48015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE480FEF10]
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
       mov       rax,234D0830008
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
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
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
       mov       rcx,1F43E802E28
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M03_L19
       lea       rcx,[rbx+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M03_L19
M03_L00:
       mov       rbx,[rbp-40]
M03_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rbx
       xor       r14d,r14d
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFE48376EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jle       near ptr M03_L08
M03_L02:
       mov       edx,19
       mov       ecx,1
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M03_L13
       test      eax,eax
       je        near ptr M03_L15
M03_L03:
       mov       ecx,1
       call      qword ptr [7FFE48376EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE48377168]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L12
       mov       esi,[rdi+8]
       test      esi,esi
       je        near ptr M03_L12
       lea       ecx,[rsi+1]
       test      ecx,ecx
       jl        near ptr M03_L17
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r8,[r13+0C]
       mov       rcx,234D083662C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r13+0E]
       lea       rdx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFE48015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L04:
       mov       r8,[rbp-48]
       cmp       [r8],r8b
       test      r13,r13
       je        short M03_L07
       lea       rdx,[r13+0C]
       mov       r15d,[r13+8]
       test      r15d,r15d
       je        short M03_L07
       mov       r8,[rbp-48]
       mov       r8,[r8+8]
       mov       rcx,[rbp-48]
       mov       ebx,[rcx+18]
       lea       ecx,[rbx+r15]
       cmp       ecx,[r8+8]
       ja        near ptr M03_L14
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       r15d,2
       jle       short M03_L06
       movsxd    r8,r15d
       add       r8,r8
       call      qword ptr [7FFE48015B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L05:
       add       r15d,ebx
       mov       rcx,[rbp-48]
       mov       [rcx+18],r15d
       jmp       short M03_L07
M03_L06:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r15d,2
       jne       short M03_L05
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M03_L05
M03_L07:
       add       r14d,1
       jo        short M03_L10
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFE48376EE0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,r14d
       jg        near ptr M03_L02
M03_L08:
       mov       rcx,[rbp-48]
       mov       ecx,[rcx+18]
       mov       eax,ecx
       mov       rdx,[rbp-48]
       mov       rdx,[rdx+8]
       cmp       [rdx+8],eax
       jbe       short M03_L11
       mov       word ptr [rdx+rax*2+10],2F
       inc       ecx
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
M03_L09:
       mov       rcx,[rbp-48]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE481A9430]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       near ptr M03_L18
M03_L10:
       call      CORINFO_HELP_OVERFLOW
M03_L11:
       mov       rcx,[rbp-48]
       mov       edx,2F
       call      qword ptr [7FFE4819C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M03_L09
M03_L12:
       mov       r13,234D0836620
       jmp       near ptr M03_L04
M03_L13:
       mov       edx,1
       jmp       near ptr M03_L03
M03_L14:
       mov       rcx,[rbp-48]
       mov       r8d,r15d
       call      qword ptr [7FFE4819CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M03_L07
M03_L15:
       call      qword ptr [7FFE4849F618]
       mov       r12,rax
       test      r12,r12
       jne       short M03_L16
       call      qword ptr [7FFE4849F438]
       mov       r12,rax
M03_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,234D0847730
       mov       r8,r12
       call      qword ptr [7FFE4801D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L17:
       call      qword ptr [7FFE480FEF10]
       int       3
M03_L18:
       mov       rcx,rsp
       call      M03_L24
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
M03_L19:
       mov       rsi,[rbx+18]
       mov       rdi,[rsi+18]
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE48494FC0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M03_L22
M03_L20:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M03_L00
M03_L21:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M03_L01
M03_L22:
       cmp       qword ptr [rdi+10],0
       jne       short M03_L23
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M03_L21
M03_L23:
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       call      qword ptr [7FFE48494AE0]
       test      eax,eax
       je        short M03_L21
       jmp       short M03_L20
M03_L24:
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
       mov       rcx,1F43E802E28
       mov       r15,[rcx]
       mov       r13,[r15+10]
       mov       rcx,7FFE48491080
       cmp       [r13+18],rcx
       jne       short M03_L25
       mov       rcx,[rbp-48]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       mov       rdx,[rbp-48]
       add       ecx,[rdx+1C]
       mov       rdx,[r13+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M03_L29
       mov       rcx,[rbp-48]
       xor       edx,edx
       call      qword ptr [7FFE4819C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M03_L26
M03_L25:
       mov       rdx,[rbp-48]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       je        short M03_L29
M03_L26:
       cmp       qword ptr [r15+20],0
       jne       short M03_L27
       lea       rcx,[r15+20]
       mov       rdx,[rbp-48]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M03_L29
M03_L27:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M03_L28
       mov       r12,[r15+18]
       mov       rcx,[r12+10]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE48494FF0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M03_L29
       mov       rcx,r12
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE48494AB0]
       jmp       short M03_L29
M03_L28:
       add       r15,2C
       lock dec  dword ptr [r15]
M03_L29:
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
; Total bytes of code 1001
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlFragment()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE48387840]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlFragment()
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
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlFragment()
       sub       rsp,28
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE483878E8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rdx,rax
       mov       rcx,277A5F86620
       add       rsp,28
       jmp       qword ptr [7FFE47F76B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 55
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostName()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE48387870]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       rdx,rax
       mov       rcx,2A1CC2EBE48
       call      qword ptr [7FFE47F76B08]; System.String.Concat(System.String, System.String)
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
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE483878E8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rbx,rax
       mov       rdx,2613A402E08
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L02
       mov       rsi,[rcx+18]
M01_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M01_L01
       xor       ecx,ecx
       call      qword ptr [7FFE48387648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jae       short M01_L03
       mov       r9d,eax
       mov       r9,[rsi+r9*8+10]
       mov       rdx,rbx
       mov       rcx,2A1CC2EBE70
       mov       r8,2A1CC2D0C48
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE47F76B38]; System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      qword ptr [7FFE48317660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 150
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
       call      qword ptr [7FFE48025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE48025B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE4810EF10]
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
       mov       rax,2A1CC2D0008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoProtocol()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE48377870]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
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
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFE483778E8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rbx,rax
       mov       rdx,2F645004E00
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L02
       mov       rsi,[rcx+18]
M01_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M01_L01
       xor       ecx,ecx
       call      qword ptr [7FFE48377648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jae       short M01_L03
       mov       r9d,eax
       mov       r9,[rsi+r9*8+10]
       mov       rdx,rbx
       mov       rcx,336D6DFBE48
       mov       r8,336D6DE0C48
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE47F66B38]; System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      qword ptr [7FFE48307660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 150
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,27038C04E00
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L02
       mov       rsi,[rcx+18]
M00_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M00_L01
       xor       ecx,ecx
       call      qword ptr [7FFE48377648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFE48307660]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       ebx,edx
       mov       edx,esi
       add       edx,1
       jo        short M01_L03
       cmp       ebx,edx
       cmovge    edx,ebx
       mov       ebx,edx
       mov       rdx,27038C04E28
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L00
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE47F6E040]
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,ebx
       call      qword ptr [7FFE48497B40]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebx,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L02
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L04
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 173
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
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
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
       lea       rax,[7FFE587C2C78]
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
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
       lea       rdx,[7FFE586432D8]
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
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
       call      qword ptr [7FFE587C2C40]
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
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
       call      qword ptr [7FFE587C2C48]
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
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
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
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
       call      qword ptr [7FFE587BA0A0]
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
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
       call      qword ptr [7FFE587C2C38]
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
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       call      qword ptr [7FFE587A5908]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
       call      qword ptr [7FFE587C8580]
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
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
       call      qword ptr [7FFE587C2C50]
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
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       call      qword ptr [7FFE587C2C60]
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
       jmp       near ptr M02_L01
; Total bytes of code 1578
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWord()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       call      qword ptr [7FFE483978A0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
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
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       byte ptr [rsp+20],1
       mov       dword ptr [rsp+24],1
       xor       edx,edx
       test      ecx,ecx
       setg      dl
       mov       eax,edx
       test      edx,edx
       je        short M01_L02
M01_L00:
       test      eax,eax
       je        short M01_L03
M01_L01:
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE483978D0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       cmp       byte ptr [rsp+20],0
       je        short M01_L00
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE480347B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ecx,eax
       jmp       short M01_L01
M01_L03:
       call      qword ptr [7FFE48514750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE48514570]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1AD1C759A30
       mov       r8,rbx
       call      qword ptr [7FFE4803D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 155
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWords()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,0A
       mov       edx,5
       mov       r8d,0A
       call      qword ptr [7FFE483A7900]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
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
; Total bytes of code 72
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L27
M01_L00:
       test      eax,eax
       je        near ptr M01_L28
M01_L01:
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       xor       ecx,ecx
       test      edi,edi
       setg      cl
       mov       edx,ecx
       test      ecx,ecx
       je        near ptr M01_L30
M01_L02:
       test      edx,edx
       je        near ptr M01_L31
M01_L03:
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       r8d,ecx
       test      ecx,ecx
       je        near ptr M01_L33
M01_L04:
       test      r8d,r8d
       je        near ptr M01_L34
M01_L05:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      esi,esi
       jl        near ptr M01_L36
       test      esi,esi
       je        near ptr M01_L37
       movsxd    rdx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L06:
       xor       r14d,r14d
       test      esi,esi
       jle       near ptr M01_L17
M01_L07:
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M01_L38
       mov       eax,1
       mov       r8d,eax
       test      eax,eax
       je        near ptr M01_L39
M01_L08:
       test      r8d,r8d
       je        near ptr M01_L18
M01_L09:
       mov       edx,ebx
       test      ebx,ebx
       jle       near ptr M01_L40
       mov       r10d,1
       mov       r9d,r10d
       test      r10d,r10d
       je        near ptr M01_L41
M01_L10:
       test      r9d,r9d
       je        near ptr M01_L20
M01_L11:
       test      ecx,ecx
       jle       near ptr M01_L42
       mov       r11d,1
       mov       eax,r11d
       test      r11d,r11d
       je        near ptr M01_L43
M01_L12:
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       test      edx,edx
       jle       near ptr M01_L44
       mov       eax,1
       mov       r8d,eax
       test      eax,eax
       je        near ptr M01_L45
M01_L14:
       test      r8d,r8d
       je        near ptr M01_L24
M01_L15:
       call      qword ptr [7FFE483A7648]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE483A78D0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L46
       lea       r8d,[rdx+1]
       mov       [rbp+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L16:
       add       r14d,1
       jo        near ptr M01_L26
       cmp       r14d,esi
       jl        near ptr M01_L07
M01_L17:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L18:
       call      qword ptr [7FFE48524750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L19
       call      qword ptr [7FFE48524570]
       mov       rbx,rax
M01_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2F006437708
       mov       r8,rbx
       call      qword ptr [7FFE4804D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       call      qword ptr [7FFE48524750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L21
       call      qword ptr [7FFE48524570]
       mov       rbx,rax
M01_L21:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2F006437730
       mov       r8,rbx
       call      qword ptr [7FFE4804D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       call      qword ptr [7FFE48524750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L23
       call      qword ptr [7FFE48524570]
       mov       rbx,rax
M01_L23:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2F006437708
       mov       r8,rbx
       call      qword ptr [7FFE4804D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       call      qword ptr [7FFE48524750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L25
       call      qword ptr [7FFE48524570]
       mov       rbx,rax
M01_L25:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2F006437730
       mov       r8,rbx
       call      qword ptr [7FFE4804D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L26:
       call      CORINFO_HELP_OVERFLOW
M01_L27:
       cmp       byte ptr [rsp+38],0
       je        near ptr M01_L00
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE480447B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       esi,eax
       jmp       near ptr M01_L01
M01_L28:
       call      qword ptr [7FFE48524750]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L29
       call      qword ptr [7FFE48524570]
       mov       rbx,rax
M01_L29:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2F006424368
       mov       r8,rbx
       call      qword ptr [7FFE4804D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       byte ptr [rsp+30],0
       je        near ptr M01_L02
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE480447B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L31:
       call      qword ptr [7FFE48524750]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L32
       call      qword ptr [7FFE48524570]
       mov       rsi,rax
M01_L32:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,2F006437708
       mov       r8,rsi
       call      qword ptr [7FFE4804D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L33:
       cmp       byte ptr [rsp+28],0
       je        near ptr M01_L04
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE480447B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebx,eax
       jmp       near ptr M01_L05
M01_L34:
       call      qword ptr [7FFE48524750]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L35
       call      qword ptr [7FFE48524570]
       mov       rsi,rax
M01_L35:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2F006437730
       mov       r8,rsi
       call      qword ptr [7FFE4804D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE4812ED18]
       int       3
M01_L37:
       mov       rcx,2AF78401D80
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L06
M01_L38:
       xor       eax,eax
       mov       r8d,eax
       test      eax,eax
       jne       near ptr M01_L08
M01_L39:
       mov       ecx,1
       jmp       near ptr M01_L09
M01_L40:
       xor       r10d,r10d
       mov       r9d,r10d
       test      r10d,r10d
       jne       near ptr M01_L10
M01_L41:
       mov       edx,1
       jmp       near ptr M01_L11
M01_L42:
       xor       r11d,r11d
       mov       eax,r11d
       test      r11d,r11d
       jne       near ptr M01_L12
M01_L43:
       mov       ecx,1
       jmp       near ptr M01_L13
M01_L44:
       xor       eax,eax
       mov       r8d,eax
       test      eax,eax
       jne       near ptr M01_L14
M01_L45:
       mov       edx,1
       jmp       near ptr M01_L15
M01_L46:
       mov       rcx,rbp
       mov       rdx,rax
       call      qword ptr [7FFE4804E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L16
; Total bytes of code 1226
```

