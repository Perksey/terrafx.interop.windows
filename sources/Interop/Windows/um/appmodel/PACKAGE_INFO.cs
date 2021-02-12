// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PACKAGE_INFO
    {
        [NativeTypeName("UINT32")]
        public uint reserved;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("PWSTR")]
        public ushort* path;

        [NativeTypeName("PWSTR")]
        public ushort* packageFullName;

        [NativeTypeName("PWSTR")]
        public ushort* packageFamilyName;

        public PACKAGE_ID packageId;
    }
}
