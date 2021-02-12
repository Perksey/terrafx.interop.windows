// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D10_USAGE;
using static TerraFX.Interop.D3D10_BIND_FLAG;

namespace TerraFX.Interop
{
    public partial struct D3D10_TEXTURE1D_DESC
    {
        public D3D10_TEXTURE1D_DESC(DXGI_FORMAT format, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint arraySize = 1, [NativeTypeName("UINT")] uint mipLevels = 0, [NativeTypeName("UINT")] uint bindFlags = (uint)D3D10_BIND_SHADER_RESOURCE, D3D10_USAGE usage = D3D10_USAGE_DEFAULT, [NativeTypeName("UINT")] uint cpuaccessFlags = 0, [NativeTypeName("UINT")] uint miscFlags = 0)
        {
            Width = width;
            MipLevels = mipLevels;
            ArraySize = arraySize;
            Format = format;
            Usage = usage;
            BindFlags = bindFlags;
            CPUAccessFlags = cpuaccessFlags;
            MiscFlags = miscFlags;
        }
    }
}
