// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct GP_LOG_PAGE_DESCRIPTOR
    {
        [NativeTypeName("WORD")]
        public ushort LogAddress;

        [NativeTypeName("WORD")]
        public ushort LogSectors;
    }
}
