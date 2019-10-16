// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_BLEND_MODE : uint
    {
        D2D1_BLEND_MODE_MULTIPLY = 0,
        D2D1_BLEND_MODE_SCREEN = 1,
        D2D1_BLEND_MODE_DARKEN = 2,
        D2D1_BLEND_MODE_LIGHTEN = 3,
        D2D1_BLEND_MODE_DISSOLVE = 4,
        D2D1_BLEND_MODE_COLOR_BURN = 5,
        D2D1_BLEND_MODE_LINEAR_BURN = 6,
        D2D1_BLEND_MODE_DARKER_COLOR = 7,
        D2D1_BLEND_MODE_LIGHTER_COLOR = 8,
        D2D1_BLEND_MODE_COLOR_DODGE = 9,
        D2D1_BLEND_MODE_LINEAR_DODGE = 10,
        D2D1_BLEND_MODE_OVERLAY = 11,
        D2D1_BLEND_MODE_SOFT_LIGHT = 12,
        D2D1_BLEND_MODE_HARD_LIGHT = 13,
        D2D1_BLEND_MODE_VIVID_LIGHT = 14,
        D2D1_BLEND_MODE_LINEAR_LIGHT = 15,
        D2D1_BLEND_MODE_PIN_LIGHT = 16,
        D2D1_BLEND_MODE_HARD_MIX = 17,
        D2D1_BLEND_MODE_DIFFERENCE = 18,
        D2D1_BLEND_MODE_EXCLUSION = 19,
        D2D1_BLEND_MODE_HUE = 20,
        D2D1_BLEND_MODE_SATURATION = 21,
        D2D1_BLEND_MODE_COLOR = 22,
        D2D1_BLEND_MODE_LUMINOSITY = 23,
        D2D1_BLEND_MODE_SUBTRACT = 24,
        D2D1_BLEND_MODE_DIVISION = 25,
        D2D1_BLEND_MODE_FORCE_DWORD = 0xFFFFFFFF,
    }
}
