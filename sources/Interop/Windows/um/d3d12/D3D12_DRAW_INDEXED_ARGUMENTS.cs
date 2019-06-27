// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct D3D12_DRAW_INDEXED_ARGUMENTS
    {
        #region Fields
        [NativeTypeName("UINT")]
        public uint IndexCountPerInstance;

        [NativeTypeName("UINT")]
        public uint InstanceCount;

        [NativeTypeName("UINT")]
        public uint StartIndexLocation;

        [NativeTypeName("INT")]
        public int BaseVertexLocation;

        [NativeTypeName("UINT")]
        public uint StartInstanceLocation;
        #endregion
    }
}
