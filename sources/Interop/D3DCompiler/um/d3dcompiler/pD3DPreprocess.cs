// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("HRESULT")]
    public unsafe delegate int pD3DPreprocess([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, [NativeTypeName("ID3DInclude *")] ID3DInclude* pInclude, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppCodeText, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorMsgs);
}
