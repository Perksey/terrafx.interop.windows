// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="GROUP_RELATIONSHIP" /> struct.</summary>
    public static unsafe class GROUP_RELATIONSHIPTests
    {
        /// <summary>Validates that the <see cref="GROUP_RELATIONSHIP" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<GROUP_RELATIONSHIP>(), Is.EqualTo(sizeof(GROUP_RELATIONSHIP)));
        }

        /// <summary>Validates that the <see cref="GROUP_RELATIONSHIP" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(GROUP_RELATIONSHIP).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="GROUP_RELATIONSHIP" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(GROUP_RELATIONSHIP), Is.EqualTo(72));
            }
            else
            {
                Assert.That(sizeof(GROUP_RELATIONSHIP), Is.EqualTo(68));
            }
        }
    }
}
