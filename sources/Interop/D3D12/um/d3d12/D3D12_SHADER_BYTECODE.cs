// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_SHADER_BYTECODE
    {
        public void* pShaderBytecode;

        [NativeTypeName("SIZE_T")]
        public UIntPtr BytecodeLength;

        public D3D12_SHADER_BYTECODE(ID3DBlob* pShaderBlob)
        {
            pShaderBytecode = pShaderBlob->GetBufferPointer();
            BytecodeLength = pShaderBlob->GetBufferSize();
        }

        public D3D12_SHADER_BYTECODE(void* _pShaderBytecode, UIntPtr bytecodeLength)
        {
            pShaderBytecode = _pShaderBytecode;
            BytecodeLength = bytecodeLength;
        }
    }
}
