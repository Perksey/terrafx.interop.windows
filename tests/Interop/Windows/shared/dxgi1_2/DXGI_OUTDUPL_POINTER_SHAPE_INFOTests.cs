// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_OUTDUPL_POINTER_SHAPE_INFO" /> struct.</summary>
    public static unsafe class DXGI_OUTDUPL_POINTER_SHAPE_INFOTests
    {
        /// <summary>Validates that the <see cref="DXGI_OUTDUPL_POINTER_SHAPE_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_OUTDUPL_POINTER_SHAPE_INFO>(), Is.EqualTo(sizeof(DXGI_OUTDUPL_POINTER_SHAPE_INFO)));
        }

        /// <summary>Validates that the <see cref="DXGI_OUTDUPL_POINTER_SHAPE_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_OUTDUPL_POINTER_SHAPE_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DXGI_OUTDUPL_POINTER_SHAPE_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DXGI_OUTDUPL_POINTER_SHAPE_INFO), Is.EqualTo(24));
        }
    }
}
