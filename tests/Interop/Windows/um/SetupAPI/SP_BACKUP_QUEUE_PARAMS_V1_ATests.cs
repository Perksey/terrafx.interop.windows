// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SP_BACKUP_QUEUE_PARAMS_V1_A" /> struct.</summary>
    public static unsafe class SP_BACKUP_QUEUE_PARAMS_V1_ATests
    {
        /// <summary>Validates that the <see cref="SP_BACKUP_QUEUE_PARAMS_V1_A" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SP_BACKUP_QUEUE_PARAMS_V1_A>(), Is.EqualTo(sizeof(SP_BACKUP_QUEUE_PARAMS_V1_A)));
        }

        /// <summary>Validates that the <see cref="SP_BACKUP_QUEUE_PARAMS_V1_A" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SP_BACKUP_QUEUE_PARAMS_V1_A).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SP_BACKUP_QUEUE_PARAMS_V1_A" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SP_BACKUP_QUEUE_PARAMS_V1_A), Is.EqualTo(268));
        }
    }
}
