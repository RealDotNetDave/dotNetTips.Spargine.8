## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.ToWords()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+128]
       call      qword ptr [7FF9004FFD08]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
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
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
; 		if (value == 0)
; 		^^^^^^^^^^^^^^^
; 			return Resources.Zero;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 		if (value < 0)
; 		^^^^^^^^^^^^^^
; 			return $"{Resources.Minus}{ControlChars.Space}{ToWords(Math.Abs(value))}";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Value.Get().Clear();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if ((value / 1000000) > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append($"{ToWords(value / 1000000)}{ControlChars.Space}{Resources.Million}{ControlChars.Space}");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				value %= 1000000;
; 				^^^^^^^^^^^^^^^^^
; 			if ((value / 1000) > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append($"{ToWords(value / 1000)}{ControlChars.Space}{Resources.Thousand}{ControlChars.Space}");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				value %= 1000;
; 				^^^^^^^^^^^^^^
; 			if ((value / 100) > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append($"{ToWords(value / 100)}{ControlChars.Space}{Resources.Hundred}{ControlChars.Space}");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				value %= 100;
; 				^^^^^^^^^^^^^
; 			if (value > 0)
; 			^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 					_ = sb.Append($"{Resources.AndLowerCase}{ControlChars.Space}");
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				var units = new[]
; 				^^^^^^^^^^^^^^^^^
; 				{
; 				 
; 				Resources.Zero,
; 				               
; 				Resources.One,
; 				              
; 				Resources.Two,
; 				              
; 				Resources.Three,
; 				                
; 				Resources.Four,
; 				               
; 				Resources.Five,
; 				               
; 				Resources.Six,
; 				              
; 				Resources.Seven,
; 				                
; 				Resources.Eight,
; 				                
; 				Resources.Nine,
; 				               
; 				Resources.Ten,
; 				              
; 				Resources.Eleven,
; 				                 
; 				Resources.Twelve,
; 				                 
; 				Resources.Thirteen,
; 				                   
; 				Resources.Fourteen,
; 				                   
; 				Resources.Fifteen,
; 				                  
; 				Resources.Sixteen,
; 				                  
; 				Resources.Seventeen,
; 				                    
; 				Resources.Eighteen,
; 				                   
; 				Resources.Nineteen
; 				                  
; 			};
; 			  
; 				var tens = new[]
; 				^^^^^^^^^^^^^^^^
; 				{
; 				 
; 				Resources.Zero,
; 				               
; 				Resources.Ten,
; 				              
; 				Resources.Twenty,
; 				                 
; 				Resources.Thirty,
; 				                 
; 				Resources.Forty,
; 				                
; 				Resources.Fifty,
; 				                
; 				Resources.Sixty,
; 				                
; 				Resources.Seventy,
; 				                  
; 				Resources.Eighty,
; 				                 
; 				Resources.Ninety
; 				                
; 			};
; 			  
; 				if (value < 20)
; 				^^^^^^^^^^^^^^^
; 					_ = sb.Append(units[value]);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					_ = sb.Append(tens[value / 10]);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					if ((value % 10) > 0)
; 					^^^^^^^^^^^^^^^^^^^^^
; 						_ = sb.Append($"{ControlChars.Dash}{units[value % 10]}");
; 						^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Value.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
M01_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-0B0],rsp
       mov       ebx,ecx
       test      ebx,ebx
       je        near ptr M01_L74
       test      ebx,ebx
       jl        near ptr M01_L75
       mov       rcx,2416D411448
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L77
       mov       rcx,[rcx+18]
M01_L02:
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       near ptr M01_L81
       mov       rcx,[rsi+20]
       mov       [rbp-98],rcx
       cmp       qword ptr [rbp-98],0
       je        short M01_L03
       lea       rcx,[rsi+20]
       mov       r8,[rbp-98]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-98]
       je        short M01_L05
M01_L03:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-98]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF9007DF6C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L78
M01_L04:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L05:
       mov       rsi,[rbp-98]
M01_L06:
       xor       ecx,ecx
       mov       [rbp-98],rcx
M01_L07:
       cmp       [rsi],sil
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF90023D0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-0A0],rsi
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       test      eax,eax
       jg        near ptr M01_L23
M01_L08:
       mov       edx,10624DD3
       mov       eax,edx
       imul      ebx
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,6
       add       r15d,edx
       test      r15d,r15d
       jg        short M01_L10
M01_L09:
       mov       edx,51EB851F
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,5
       add       edi,edx
       test      edi,edi
       jle       near ptr M01_L16
       jmp       near ptr M01_L30
M01_L10:
       mov       rax,rsi
       mov       [rbp-78],rax
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       byte ptr [rbp-68],0
       mov       ecx,r15d
       call      qword ptr [7FF9004FFD08]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L72
       mov       r14,[rbp-78]
       cmp       [r14],r14b
       test      rax,rax
       je        short M01_L12
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L12
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M01_L24
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L20
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       [r14+18],edi
M01_L12:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF90091E658]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FF90091E580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L71
       mov       rdi,[rbp-78]
       cmp       [rdi],dil
       test      rax,rax
       je        short M01_L14
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L14
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M01_L27
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L17
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L13:
       mov       [rdi+18],r14d
M01_L14:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF90091E658]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       imul      eax,r15d,3E8
       sub       ebx,eax
       jmp       near ptr M01_L09
M01_L15:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF90091E658]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       imul      eax,edi,64
       sub       ebx,eax
M01_L16:
       test      ebx,ebx
       jle       near ptr M01_L21
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       test      ecx,ecx
       jle       short M01_L19
       jmp       near ptr M01_L52
M01_L17:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L13
M01_L18:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF90091E658]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
M01_L19:
       mov       rcx,offset MT_System.String[]
       mov       edx,14
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdi,2416D4114C8
       mov       r8,[rdi]
       mov       rdx,281FF2E49D8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E49F8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4A18
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4A38
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4A58
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4A78
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4A98
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4AB8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4AD8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4AF8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4B18
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4B38
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+68]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4B60
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+70]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4B88
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4BB0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+80]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4BD8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+88]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4C00
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4C28
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+98]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4C50
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+0A0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4C78
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r14+0A8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.String[]
       mov       edx,0A
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E49D8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4B18
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4CA0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4CC8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4CF0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4D10
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4D30
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4D50
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4D78
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF90091E0D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[rdi]
       mov       rdx,281FF2E4DA0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       ebx,14
       jge       near ptr M01_L34
       jmp       near ptr M01_L50
M01_L20:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L11
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L11
M01_L21:
       mov       rcx,rsi
       call      qword ptr [7FF9002432D8]; System.Text.StringBuilder.ToString()
       mov       r13,rax
       cmp       dword ptr [r13+8],0
       je        near ptr M01_L29
       movzx     ecx,word ptr [r13+0C]
       cmp       ecx,100
       jae       near ptr M01_L25
       cmp       ecx,100
       jae       short M01_L22
       mov       ecx,ecx
       mov       rax,7FF95DA62E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L70
       jmp       near ptr M01_L26
M01_L22:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L23:
       lea       rcx,[rbp-90]
       mov       r9,rsi
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FF90091DF68]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rax,[rbp-80]
       mov       [rbp-68],rax
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,12
       add       ecx,edx
       call      qword ptr [7FF9004FFD08]
       mov       rdx,rax
       lea       rcx,[rbp-78]
       call      qword ptr [7FF90091E058]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF90091E658]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FF90091E3A0]
       mov       rdx,rax
       lea       rcx,[rbp-78]
       call      qword ptr [7FF90091E058]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF90091E658]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,12
       add       ecx,edx
       imul      ecx,0F4240
       sub       ebx,ecx
       jmp       near ptr M01_L08
M01_L24:
       mov       rcx,r14
       call      qword ptr [7FF90023D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L12
M01_L25:
       call      qword ptr [7FF900975038]
       test      eax,eax
       jne       near ptr M01_L70
M01_L26:
       mov       ecx,[r13+8]
       dec       ecx
       cmp       ecx,[r13+8]
       jae       near ptr M01_L22
       movzx     ecx,word ptr [r13+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L28
       cmp       ecx,100
       jae       near ptr M01_L22
       mov       ecx,ecx
       mov       rax,7FF95DA62E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L70
       jmp       short M01_L29
M01_L27:
       mov       rcx,rdi
       call      qword ptr [7FF90023D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L14
M01_L28:
       call      qword ptr [7FF900975038]
       test      eax,eax
       jne       near ptr M01_L70
M01_L29:
       mov       [rbp-0A8],r13
       jmp       near ptr M01_L73
M01_L30:
       mov       rdx,rsi
       mov       [rbp-78],rdx
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       byte ptr [rbp-68],0
       mov       ecx,edi
       call      qword ptr [7FF9004FFD08]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L47
       mov       r14,[rbp-78]
       cmp       [r14],r14b
       test      rax,rax
       je        short M01_L32
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L32
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M01_L39
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L37
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L31:
       mov       [r14+18],r15d
M01_L32:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FF90091E658]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FF90091E340]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L64
       mov       r13,[rbp-78]
       cmp       [r13],r13b
       test      rax,rax
       je        near ptr M01_L15
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L15
       mov       rcx,[r13+8]
       mov       eax,[r13+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M01_L49
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L35
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L33:
       mov       [r13+18],r14d
       jmp       near ptr M01_L15
M01_L34:
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,2
       add       edi,edx
       cmp       edi,0A
       jae       near ptr M01_L22
       mov       ecx,edi
       mov       r15,[r15+rcx*8+10]
       test      r15,r15
       je        near ptr M01_L44
       jmp       short M01_L36
M01_L35:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L33
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L33
M01_L36:
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       test      r8d,r8d
       je        near ptr M01_L44
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M01_L59
       cmp       [rcx],cl
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M01_L42
       jmp       near ptr M01_L56
M01_L37:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L31
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L31
M01_L38:
       cmp       r13d,14
       jae       near ptr M01_L22
       mov       ecx,r13d
       mov       r8,[r14+rcx*8+10]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L69
       jmp       short M01_L40
M01_L39:
       mov       rcx,r14
       call      qword ptr [7FF90023D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L32
M01_L40:
       mov       rbx,[rbp-78]
       cmp       [rbx],bl
       test      r8,r8
       je        near ptr M01_L21
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L21
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M01_L60
       cmp       [rcx],cl
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M01_L46
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L41:
       mov       [rbx+18],edi
       jmp       near ptr M01_L21
M01_L42:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L43:
       mov       [rsi+18],r15d
M01_L44:
       lea       ecx,[rdi+rdi*4]
       add       ecx,ecx
       mov       r13d,ebx
       sub       r13d,ecx
       test      r13d,r13d
       jle       near ptr M01_L21
       mov       rax,rsi
       mov       [rbp-78],rax
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       byte ptr [rbp-68],0
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L48
       mov       rcx,[rbp-78]
       mov       rax,[rcx+8]
       mov       rdx,rax
       mov       ecx,[rcx+18]
       mov       r12d,ecx
       mov       eax,[rax+8]
       sub       eax,ecx
       test      rdx,rdx
       je        near ptr M01_L65
       mov       ecx,r12d
       mov       r8d,eax
       add       rcx,r8
       mov       r8d,[rdx+8]
       cmp       rcx,r8
       ja        near ptr M01_L66
       cmp       [rdx],dl
       mov       ecx,r12d
       lea       rcx,[rdx+rcx*2+10]
M01_L45:
       test      eax,eax
       je        near ptr M01_L68
       test      eax,eax
       je        near ptr M01_L22
       mov       word ptr [rcx],2D
       mov       ecx,1
       cmp       ecx,eax
       ja        near ptr M01_L67
       mov       rax,[rbp-78]
       add       [rax+18],ecx
       jmp       near ptr M01_L38
M01_L46:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L41
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L41
M01_L47:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,7FF900930308
       call      qword ptr [7FF90091E718]
       jmp       near ptr M01_L32
M01_L48:
       lea       rcx,[rbp-78]
       mov       edx,2D
       xor       r8d,r8d
       call      qword ptr [7FF90091E6E8]
       jmp       near ptr M01_L38
M01_L49:
       mov       rcx,r13
       call      qword ptr [7FF90023D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L15
M01_L50:
       cmp       ebx,14
       jae       near ptr M01_L22
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       test      r8,r8
       je        near ptr M01_L21
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L21
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebx,[rax+r8]
       cmp       ebx,[rcx+8]
       ja        near ptr M01_L61
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L53
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L51:
       mov       [rsi+18],ebx
       jmp       near ptr M01_L21
M01_L52:
       mov       rdx,rsi
       mov       [rbp-78],rdx
       xor       eax,eax
       mov       [rbp-70],rax
       mov       byte ptr [rbp-68],0
       call      qword ptr [7FF90091E118]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L63
       jmp       short M01_L54
M01_L53:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L51
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L51
M01_L54:
       mov       r14,[rbp-78]
       cmp       [r14],r14b
       test      rax,rax
       je        near ptr M01_L18
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L18
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M01_L62
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L57
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L55:
       mov       [r14+18],r15d
       jmp       near ptr M01_L18
M01_L56:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L43
       jmp       short M01_L58
M01_L57:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L55
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L55
M01_L58:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M01_L43
M01_L59:
       mov       rcx,rsi
       call      qword ptr [7FF90023D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L44
M01_L60:
       mov       rcx,rbx
       call      qword ptr [7FF90023D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L21
M01_L61:
       mov       rcx,rsi
       call      qword ptr [7FF90023D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L21
M01_L62:
       mov       rcx,r14
       call      qword ptr [7FF90023D998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L18
M01_L63:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,7FF900930308
       call      qword ptr [7FF90091E718]
       jmp       near ptr M01_L18
M01_L64:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,7FF900930308
       call      qword ptr [7FF90091E718]
       jmp       near ptr M01_L15
M01_L65:
       or        r12d,eax
       jne       short M01_L66
       xor       ecx,ecx
       xor       eax,eax
       jmp       near ptr M01_L45
M01_L66:
       call      qword ptr [7FF9003657E8]
       int       3
M01_L67:
       call      qword ptr [7FF900365F80]
       int       3
M01_L68:
       lea       rcx,[rbp-78]
       mov       edx,2D
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF90091E6B8]
       jmp       near ptr M01_L38
M01_L69:
       lea       rcx,[rbp-78]
       mov       rdx,7FF900930308
       call      qword ptr [7FF90091E718]
       jmp       near ptr M01_L21
M01_L70:
       mov       rcx,r13
       mov       edx,3
       call      qword ptr [7FF8FFFF73F0]
       mov       r13,rax
       jmp       near ptr M01_L29
M01_L71:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,7FF900930308
       call      qword ptr [7FF90091E718]
       jmp       near ptr M01_L14
M01_L72:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,7FF900930308
       call      qword ptr [7FF90091E718]
       jmp       near ptr M01_L12
M01_L73:
       mov       rcx,rsp
       call      M01_L82
       nop
       mov       rax,[rbp-0A8]
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
M01_L74:
       call      qword ptr [7FF90091E640]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       nop
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
M01_L75:
       lea       rcx,[rbp-60]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FF9002B5CF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       call      qword ptr [7FF90091E3B8]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9002B5E78]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       mov       edx,20
       call      qword ptr [7FF9008DC960]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       ecx,ebx
       neg       ecx
       jns       short M01_L76
       call      qword ptr [7FF9004AED48]
       int       3
M01_L76:
       call      qword ptr [7FF9004FFD08]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9002B5E78]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9002B5D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
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
M01_L77:
       call      qword ptr [7FF900474EA0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L02
M01_L78:
       cmp       qword ptr [r14+10],0
       jne       short M01_L79
       xor       edx,edx
       mov       [rbp-98],rdx
       jmp       short M01_L80
M01_L79:
       lea       rdx,[rbp-98]
       mov       rcx,rdi
       call      qword ptr [7FF9007DF1E0]
       test      eax,eax
       jne       near ptr M01_L04
M01_L80:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L81:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L07
M01_L82:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0D0]
       mov       rcx,2416D411448
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L83
       call      qword ptr [7FF900474EA0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M01_L84
M01_L83:
       mov       rsi,[rcx+18]
M01_L84:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       near ptr M01_L89
       mov       r13,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r13+18],rcx
       jne       short M01_L85
       mov       r12,[rbp-0A0]
       mov       rcx,[r12+8]
       mov       ecx,[rcx+8]
       add       ecx,[r12+1C]
       mov       rdx,[r13+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L90
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF90023D0F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L86
M01_L85:
       mov       rdx,[rbp-0A0]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       mov       r12,[rbp-0A0]
       je        near ptr M01_L90
M01_L86:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L87
       cmp       [rsi],sil
       lea       rcx,[rsi+20]
       mov       rdx,r12
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L90
M01_L87:
       cmp       [rsi],sil
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L88
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF9007DF6F0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L90
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FF9007DF1B0]
       jmp       short M01_L90
M01_L88:
       cmp       [rsi],sil
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L90
M01_L89:
       mov       r12,[rbp-0A0]
       mov       rcx,rsi
       mov       rdx,r12
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L90:
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
; Total bytes of code 4489
```

