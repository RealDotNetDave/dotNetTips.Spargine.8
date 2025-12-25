## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.ToWords()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+128]
       call      qword ptr [7FFE00CAFD08]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
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
       je        near ptr M01_L69
       test      ebx,ebx
       jl        near ptr M01_L70
       mov       rcx,25EF1C11448
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L72
       mov       rcx,[rcx+18]
M01_L02:
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       near ptr M01_L76
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
       call      qword ptr [7FFE00F8F6C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L73
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
       call      qword ptr [7FFE009ED0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-0A0],rsi
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       test      eax,eax
       jg        near ptr M01_L62
M01_L08:
       mov       edx,10624DD3
       mov       eax,edx
       imul      ebx
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,6
       add       r15d,edx
       test      r15d,r15d
       jg        near ptr M01_L34
M01_L09:
       mov       edx,51EB851F
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,5
       add       edi,edx
       test      edi,edi
       jg        near ptr M01_L25
M01_L10:
       test      ebx,ebx
       jle       near ptr M01_L15
       mov       eax,[rsi+1C]
       add       eax,[rsi+18]
       test      eax,eax
       jg        near ptr M01_L21
M01_L11:
       mov       rcx,offset MT_System.String[]
       mov       edx,14
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r14,25EF1C114C8
       mov       r8,[r14]
       mov       rdx,29F83C349D8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C349F8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34A18
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34A38
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34A58
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34A78
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34A98
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34AB8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34AD8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34AF8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34B18
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34B38
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+68]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34B60
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+70]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34B88
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34BB0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+80]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34BD8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+88]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34C00
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34C28
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+98]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34C50
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+0A0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34C78
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[rdi+0A8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.String[]
       mov       edx,0A
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C349D8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34B18
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34CA0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34CC8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34CF0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34D10
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34D30
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34D50
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34D78
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE010BE580]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,[r14]
       mov       rdx,29F83C34DA0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       lea       rcx,[r15+58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       ebx,14
       jge       near ptr M01_L24
       cmp       ebx,14
       jae       short M01_L13
       mov       r8d,ebx
       mov       r8,[rdi+r8*8+10]
       test      r8,r8
       je        short M01_L15
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L15
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebx,[rax+r8]
       cmp       ebx,[rcx+8]
       ja        near ptr M01_L55
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L14
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       [rsi+18],ebx
       jmp       short M01_L15
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L14:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L12
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L12
M01_L15:
       mov       rcx,rsi
       call      qword ptr [7FFE009F32D8]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0
       je        short M01_L17
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L19
       cmp       ecx,100
       jae       short M01_L13
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L18
M01_L16:
       mov       ecx,[rbx+8]
       dec       ecx
       cmp       ecx,[rbx+8]
       jae       short M01_L13
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L20
       cmp       ecx,100
       jae       short M01_L13
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L18
M01_L17:
       mov       [rbp-0A8],rbx
       jmp       near ptr M01_L68
M01_L18:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE007A73F0]
       mov       rbx,rax
       jmp       short M01_L17
M01_L19:
       call      qword ptr [7FFE01125470]
       test      eax,eax
       jne       short M01_L18
       jmp       short M01_L16
M01_L20:
       call      qword ptr [7FFE01125470]
       test      eax,eax
       jne       short M01_L18
       jmp       short M01_L17
M01_L21:
       mov       rax,rsi
       mov       [rbp-78],rax
       xor       eax,eax
       mov       [rbp-70],rax
       mov       byte ptr [rbp-68],0
       call      qword ptr [7FFE010BE5C8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L57
       mov       rdi,[rbp-78]
       cmp       [rdi],dil
       test      rax,rax
       je        near ptr M01_L47
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L47
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M01_L54
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L23
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L22:
       mov       [rdi+18],r14d
       jmp       near ptr M01_L47
M01_L23:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L22
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L22
M01_L24:
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       r14d,edx
       shr       r14d,1F
       sar       edx,2
       add       r14d,edx
       cmp       r14d,0A
       jae       near ptr M01_L13
       mov       r8d,r14d
       mov       r8,[r15+r8*8+10]
       test      r8,r8
       je        near ptr M01_L29
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L29
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M01_L28
       cmp       [rcx],cl
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M01_L37
       jmp       near ptr M01_L48
M01_L25:
       mov       rax,rsi
       mov       [rbp-78],rax
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       byte ptr [rbp-68],0
       mov       ecx,edi
       call      qword ptr [7FFE00CAFD08]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L59
       mov       r15,[rbp-78]
       cmp       [r15],r15b
       test      rax,rax
       je        near ptr M01_L43
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L43
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M01_L52
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L27
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L26:
       mov       [r15+18],r14d
       jmp       near ptr M01_L43
M01_L27:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L26
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L26
M01_L28:
       mov       rcx,rsi
       call      qword ptr [7FFE009ED998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L29:
       lea       r8d,[r14+r14*4]
       add       r8d,r8d
       mov       r13d,ebx
       sub       r13d,r8d
       test      r13d,r13d
       jle       near ptr M01_L15
       mov       rax,rsi
       mov       [rbp-78],rax
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       byte ptr [rbp-68],0
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L56
       mov       r8,[rbp-78]
       mov       rcx,[r8+8]
       mov       rdx,rcx
       mov       r8d,[r8+18]
       mov       r12d,r8d
       mov       ecx,[rcx+8]
       sub       ecx,r8d
       test      rdx,rdx
       je        near ptr M01_L63
       mov       r8d,r12d
       mov       eax,ecx
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        near ptr M01_L64
       cmp       [rdx],dl
       mov       r8d,r12d
       lea       r8,[rdx+r8*2+10]
M01_L30:
       test      ecx,ecx
       je        near ptr M01_L66
       test      ecx,ecx
       je        near ptr M01_L13
       mov       word ptr [r8],2D
       mov       r8d,1
       cmp       r8d,ecx
       ja        near ptr M01_L65
       mov       rcx,[rbp-78]
       add       [rcx+18],r8d
M01_L31:
       cmp       r13d,14
       jae       near ptr M01_L13
       mov       r8d,r13d
       mov       r8,[rdi+r8*8+10]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L67
       mov       rbx,[rbp-78]
       cmp       [rbx],bl
       test      r8,r8
       je        near ptr M01_L15
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M01_L15
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M01_L49
       cmp       [rcx],cl
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L33
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L32:
       mov       [rbx+18],edi
       jmp       near ptr M01_L15
M01_L33:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L32
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L32
M01_L34:
       mov       rax,rsi
       mov       [rbp-78],rax
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       byte ptr [rbp-68],0
       mov       ecx,r15d
       call      qword ptr [7FFE00CAFD08]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L61
       mov       r14,[rbp-78]
       cmp       [r14],r14b
       test      rax,rax
       je        short M01_L39
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L39
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M01_L50
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L36
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L35:
       mov       [r14+18],edi
       jmp       short M01_L39
M01_L36:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L35
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L35
M01_L37:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L38:
       mov       [rsi+18],r15d
       jmp       near ptr M01_L29
M01_L39:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFE010BEB08]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFE010BEA30]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L60
       mov       rdi,[rbp-78]
       cmp       [rdi],dil
       test      rax,rax
       je        short M01_L42
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L42
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M01_L51
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L41
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L40:
       mov       [rdi+18],r14d
       jmp       short M01_L42
M01_L41:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L40
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L40
M01_L42:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFE010BEB08]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       imul      eax,r15d,3E8
       sub       ebx,eax
       jmp       near ptr M01_L09
M01_L43:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFE010BEB08]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFE010BE7F0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       cmp       byte ptr [rbp-68],0
       jne       near ptr M01_L58
       mov       r14,[rbp-78]
       cmp       [r14],r14b
       test      rax,rax
       je        short M01_L46
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L46
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M01_L53
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L45
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L44:
       mov       [r14+18],r15d
       jmp       short M01_L46
M01_L45:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L44
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L44
M01_L46:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFE010BEB08]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       imul      eax,edi,64
       sub       ebx,eax
       jmp       near ptr M01_L10
M01_L47:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFE010BEB08]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       jmp       near ptr M01_L11
M01_L48:
       movzx     r10d,word ptr [rdx]
       mov       [rcx],r10w
       cmp       r8d,2
       jne       near ptr M01_L38
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L38
M01_L49:
       mov       rcx,rbx
       call      qword ptr [7FFE009ED998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L15
M01_L50:
       mov       rcx,r14
       call      qword ptr [7FFE009ED998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L39
M01_L51:
       mov       rcx,rdi
       call      qword ptr [7FFE009ED998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L42
M01_L52:
       mov       rcx,r15
       call      qword ptr [7FFE009ED998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L43
M01_L53:
       mov       rcx,r14
       call      qword ptr [7FFE009ED998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L46
M01_L54:
       mov       rcx,rdi
       call      qword ptr [7FFE009ED998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L47
M01_L55:
       mov       rcx,rsi
       call      qword ptr [7FFE009ED998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L15
M01_L56:
       lea       rcx,[rbp-78]
       mov       edx,2D
       xor       r8d,r8d
       call      qword ptr [7FFE010BEB98]
       jmp       near ptr M01_L31
M01_L57:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,7FFE010E0488
       call      qword ptr [7FFE010BEBC8]
       jmp       near ptr M01_L47
M01_L58:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,7FFE010E0488
       call      qword ptr [7FFE010BEBC8]
       jmp       near ptr M01_L46
M01_L59:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,7FFE010E0488
       call      qword ptr [7FFE010BEBC8]
       jmp       near ptr M01_L43
M01_L60:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,7FFE010E0488
       call      qword ptr [7FFE010BEBC8]
       jmp       near ptr M01_L42
M01_L61:
       lea       rcx,[rbp-78]
       mov       r8,rax
       mov       rdx,7FFE010E0488
       call      qword ptr [7FFE010BEBC8]
       jmp       near ptr M01_L39
M01_L62:
       lea       rcx,[rbp-90]
       mov       r9,rsi
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFE010BE418]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
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
       call      qword ptr [7FFE00CAFD08]
       mov       rdx,rax
       lea       rcx,[rbp-78]
       call      qword ptr [7FFE010BE508]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFE010BEB08]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFE010BE850]
       mov       rdx,rax
       lea       rcx,[rbp-78]
       call      qword ptr [7FFE010BE508]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFE010BEB08]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
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
M01_L63:
       or        r12d,ecx
       jne       short M01_L64
       xor       r8d,r8d
       xor       ecx,ecx
       jmp       near ptr M01_L30
M01_L64:
       call      qword ptr [7FFE00B157E8]
       int       3
M01_L65:
       call      qword ptr [7FFE00B15F80]
       int       3
M01_L66:
       lea       rcx,[rbp-78]
       mov       edx,2D
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE010BEB68]
       jmp       near ptr M01_L31
M01_L67:
       lea       rcx,[rbp-78]
       mov       rdx,7FFE010E0488
       call      qword ptr [7FFE010BEBC8]
       jmp       near ptr M01_L15
M01_L68:
       mov       rcx,rsp
       call      M01_L77
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
M01_L69:
       call      qword ptr [7FFE010BEAF0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
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
M01_L70:
       lea       rcx,[rbp-60]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FFE00A65CF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       call      qword ptr [7FFE010BE868]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE00A65E78]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       mov       edx,20
       call      qword ptr [7FFE0108C960]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       ecx,ebx
       neg       ecx
       jns       short M01_L71
       call      qword ptr [7FFE00C5ED48]
       int       3
M01_L71:
       call      qword ptr [7FFE00CAFD08]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE00A65E78]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE00A65D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
M01_L72:
       call      qword ptr [7FFE00C24EA0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L02
M01_L73:
       cmp       qword ptr [r14+10],0
       jne       short M01_L74
       xor       edx,edx
       mov       [rbp-98],rdx
       jmp       short M01_L75
M01_L74:
       lea       rdx,[rbp-98]
       mov       rcx,rdi
       call      qword ptr [7FFE00F8F1E0]
       test      eax,eax
       jne       near ptr M01_L04
M01_L75:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L76:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L07
M01_L77:
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
       mov       rcx,25EF1C11448
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L78
       call      qword ptr [7FFE00C24EA0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M01_L79
M01_L78:
       mov       rbx,[rcx+18]
M01_L79:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rcx
       jne       near ptr M01_L84
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L80
       mov       rdi,[rbp-0A0]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L85
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE009ED0F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L81
M01_L80:
       mov       rdx,[rbp-0A0]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       mov       rdi,[rbp-0A0]
       je        short M01_L85
M01_L81:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L82
       cmp       [rbx],bl
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L85
M01_L82:
       cmp       [rbx],bl
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L83
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE00F8F6F0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L85
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFE00F8F1B0]
       jmp       short M01_L85
M01_L83:
       cmp       [rbx],bl
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M01_L85
M01_L84:
       mov       rdi,[rbp-0A0]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L85:
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
; Total bytes of code 4392
```

