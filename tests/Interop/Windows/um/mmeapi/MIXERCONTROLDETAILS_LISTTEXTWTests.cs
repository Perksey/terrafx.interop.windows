// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MIXERCONTROLDETAILS_LISTTEXTW" /> struct.</summary>
    public static unsafe class MIXERCONTROLDETAILS_LISTTEXTWTests
    {
        /// <summary>Validates that the <see cref="MIXERCONTROLDETAILS_LISTTEXTW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MIXERCONTROLDETAILS_LISTTEXTW>(), Is.EqualTo(sizeof(MIXERCONTROLDETAILS_LISTTEXTW)));
        }

        /// <summary>Validates that the <see cref="MIXERCONTROLDETAILS_LISTTEXTW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MIXERCONTROLDETAILS_LISTTEXTW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MIXERCONTROLDETAILS_LISTTEXTW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MIXERCONTROLDETAILS_LISTTEXTW), Is.EqualTo(136));
        }
    }
}
