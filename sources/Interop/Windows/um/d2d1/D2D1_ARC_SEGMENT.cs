// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Describes an arc that is defined as part of a path.</summary>
    public struct D2D1_ARC_SEGMENT
    {
        #region Fields
        [NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F point;

        [NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F size;

        [NativeTypeName("FLOAT")]
        public float rotationAngle;

        public D2D1_SWEEP_DIRECTION sweepDirection;

        public D2D1_ARC_SIZE arcSize;
        #endregion
    }
}
