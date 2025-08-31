## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_NoValidation()
       push      rbx
       sub       rsp,10
       mov       rdx,[rcx+128]
       mov       [rsp+8],rdx
       mov       rbx,[rcx+18]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 47
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation_Inlining()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+128]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF90034D518]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
M00_L00:
       mov       [rsp+20],rsi
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
; Total bytes of code 73
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
       je        near ptr M01_L05
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L00
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rcx],rax
       jne       near ptr M01_L06
       mov       eax,[rcx+10]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L01
       mov       rcx,rax
       mov       r11,7FF8FFEB0A20
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M01_L01:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FF8FFEB0A10
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M01_L03
M01_L02:
       add       esi,1
       jo        short M01_L04
M01_L03:
       mov       rcx,rbx
       mov       r11,7FF8FFEB0A18
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L06:
       mov       r11,7FF8FFEB0A28
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
; Total bytes of code 210
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+128]
       test      rsi,rsi
       je        short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF90035D518]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
M00_L00:
       mov       [rsp+20],rsi
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
; Total bytes of code 73
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
       je        near ptr M01_L05
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L00
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rcx],rax
       jne       near ptr M01_L06
       mov       eax,[rcx+10]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M01_L01
       mov       rcx,rax
       mov       r11,7FF8FFEC0A20
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M01_L01:
       xor       esi,esi
       mov       rcx,rbx
       mov       r11,7FF8FFEC0A10
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M01_L03
M01_L02:
       add       esi,1
       jo        short M01_L04
M01_L03:
       mov       rcx,rbx
       mov       r11,7FF8FFEC0A18
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L06:
       mov       r11,7FF8FFEC0A28
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
; Total bytes of code 210
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_NoValidation()
       push      rbx
       sub       rsp,10
       mov       rdx,1E8B56A4768
       mov       [rsp+8],rdx
       mov       rbx,[rcx+18]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 50
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation_Inlining()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,2861C154768
       mov       rcx,2861C154768
       cmp       [rcx],ecx
       call      qword ptr [7FF900007318]; System.String.Trim()
       mov       [rsp+20],rsi
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
; Total bytes of code 80
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
       mov       rax,7FF95DA62E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9008EFBE8]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF95DA62E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF9008EFBE8]
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
       call      qword ptr [7FF9000073F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,18B60224768
       mov       rcx,18B60224768
       cmp       [rcx],ecx
       call      qword ptr [7FF900017318]; System.String.Trim()
       mov       [rsp+20],rsi
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
; Total bytes of code 80
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
       mov       rax,7FF95DA62E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF900925440]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF95DA62E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF900925440]
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
       call      qword ptr [7FF9000173F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

