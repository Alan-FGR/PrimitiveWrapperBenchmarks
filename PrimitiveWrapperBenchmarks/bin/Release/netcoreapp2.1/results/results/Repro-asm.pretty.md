## .NET Core 2.1.7 (CoreCLR 4.6.27129.04, CoreFX 4.6.27129.04), 64bit RyuJIT
```assembly
; Repro.First()
       xor     eax,eax
       mov     edx,0FFFFFFh
       mov     ecx,1
       mov     r8d,1
       xor     r9d,r9d
M00_L00:
       add     eax,r9d
       sub     eax,ecx
       cmp     eax,ecx
       jle     M00_L01
       inc     ecx
M00_L01:
       cmp     eax,ecx
       jge     M00_L02
       dec     r8d
M00_L02:
       cmp     eax,ecx
       jne     M00_L03
       mov     r8d,5
M00_L03:
       dec     edx
       cmp     edx,r9d
       jne     M00_L04
       inc     ecx
M00_L04:
       inc     r9d
       cmp     r9d,0FFFFFFh
       jl      M00_L00
       lea     eax,[rcx+r8]
; Total bytes of code 74
```

