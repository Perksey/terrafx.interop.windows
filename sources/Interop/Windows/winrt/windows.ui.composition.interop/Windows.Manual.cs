// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_ICompositionCapabilitiesInteropFactory = new Guid(0x2C9DB356, 0xE70D, 0x4642, 0x82, 0x98, 0xBC, 0x4A, 0xA5, 0xB4, 0x86, 0x5C);

        public static readonly Guid IID_ICompositionDrawingSurfaceInterop = new Guid(0xFD04E6E3, 0xFE0C, 0x4C3C, 0xAB, 0x19, 0xA0, 0x76, 0x01, 0xA5, 0x76, 0xEE);

        public static readonly Guid IID_ICompositionDrawingSurfaceInterop2 = new Guid(0x41E64AAE, 0x98C0, 0x4239, 0x8E, 0x95, 0xA3, 0x30, 0xDD, 0x6A, 0xA1, 0x8B);

        public static readonly Guid IID_ICompositionGraphicsDeviceInterop = new Guid(0xA116FF71, 0xF8BF, 0x4C8A, 0x9C, 0x98, 0x70, 0x77, 0x9A, 0x32, 0xA9, 0xC8);

        public static readonly Guid IID_ICompositorDesktopInterop = new Guid(0x29E691FA, 0x4567, 0x4DCA, 0xB3, 0x19, 0xD0, 0xF2, 0x07, 0xEB, 0x68, 0x07);

        public static readonly Guid IID_ICompositorInterop = new Guid(0x25297D5C, 0x3AD4, 0x4C9C, 0xB5, 0xCF, 0xE3, 0x6A, 0x38, 0x51, 0x23, 0x30);

        public static readonly Guid IID_IDesktopWindowContentBridgeInterop = new Guid(0x37642806, 0xF421, 0x4FD0, 0x9F, 0x82, 0x23, 0xAE, 0x7C, 0x77, 0x61, 0x82);

        public static readonly Guid IID_IDesktopWindowTargetInterop = new Guid(0x35DBF59E, 0xE3F9, 0x45B0, 0x81, 0xE7, 0xFE, 0x75, 0xF4, 0x14, 0x5D, 0xC9);

        public static readonly Guid IID_ISwapChainInterop = new Guid(0x26F496A0, 0x7F38, 0x45FB, 0x88, 0xF7, 0xFA, 0xAA, 0xBE, 0x67, 0xDD, 0x59);

        public static readonly Guid IID_IVisualInteractionSourceInterop = new Guid(0x11F62CD1, 0x2F9D, 0x42D3, 0xB0, 0x5F, 0xD6, 0x79, 0x0D, 0x9E, 0x9F, 0x8E);
    }
}
