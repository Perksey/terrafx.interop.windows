// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DOCINFOA
    {
        public int cbSize;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszDocName;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszOutput;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszDatatype;

        [NativeTypeName("DWORD")]
        public uint fwType;
    }
}
