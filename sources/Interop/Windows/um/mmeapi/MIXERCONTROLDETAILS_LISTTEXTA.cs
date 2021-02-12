// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct MIXERCONTROLDETAILS_LISTTEXTA
    {
        [NativeTypeName("DWORD")]
        public uint dwParam1;

        [NativeTypeName("DWORD")]
        public uint dwParam2;

        [NativeTypeName("CHAR [64]")]
        public fixed sbyte szName[64];
    }
}
