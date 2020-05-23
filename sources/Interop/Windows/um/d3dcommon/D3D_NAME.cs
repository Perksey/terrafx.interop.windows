// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D_NAME
    {
        D3D_NAME_UNDEFINED = 0,
        D3D_NAME_POSITION = 1,
        D3D_NAME_CLIP_DISTANCE = 2,
        D3D_NAME_CULL_DISTANCE = 3,
        D3D_NAME_RENDER_TARGET_ARRAY_INDEX = 4,
        D3D_NAME_VIEWPORT_ARRAY_INDEX = 5,
        D3D_NAME_VERTEX_ID = 6,
        D3D_NAME_PRIMITIVE_ID = 7,
        D3D_NAME_INSTANCE_ID = 8,
        D3D_NAME_IS_FRONT_FACE = 9,
        D3D_NAME_SAMPLE_INDEX = 10,
        D3D_NAME_FINAL_QUAD_EDGE_TESSFACTOR = 11,
        D3D_NAME_FINAL_QUAD_INSIDE_TESSFACTOR = 12,
        D3D_NAME_FINAL_TRI_EDGE_TESSFACTOR = 13,
        D3D_NAME_FINAL_TRI_INSIDE_TESSFACTOR = 14,
        D3D_NAME_FINAL_LINE_DETAIL_TESSFACTOR = 15,
        D3D_NAME_FINAL_LINE_DENSITY_TESSFACTOR = 16,
        D3D_NAME_BARYCENTRICS = 23,
        D3D_NAME_SHADINGRATE = 24,
        D3D_NAME_CULLPRIMITIVE = 25,
        D3D_NAME_TARGET = 64,
        D3D_NAME_DEPTH = 65,
        D3D_NAME_COVERAGE = 66,
        D3D_NAME_DEPTH_GREATER_EQUAL = 67,
        D3D_NAME_DEPTH_LESS_EQUAL = 68,
        D3D_NAME_STENCIL_REF = 69,
        D3D_NAME_INNER_COVERAGE = 70,
        D3D10_NAME_UNDEFINED = D3D_NAME_UNDEFINED,
        D3D10_NAME_POSITION = D3D_NAME_POSITION,
        D3D10_NAME_CLIP_DISTANCE = D3D_NAME_CLIP_DISTANCE,
        D3D10_NAME_CULL_DISTANCE = D3D_NAME_CULL_DISTANCE,
        D3D10_NAME_RENDER_TARGET_ARRAY_INDEX = D3D_NAME_RENDER_TARGET_ARRAY_INDEX,
        D3D10_NAME_VIEWPORT_ARRAY_INDEX = D3D_NAME_VIEWPORT_ARRAY_INDEX,
        D3D10_NAME_VERTEX_ID = D3D_NAME_VERTEX_ID,
        D3D10_NAME_PRIMITIVE_ID = D3D_NAME_PRIMITIVE_ID,
        D3D10_NAME_INSTANCE_ID = D3D_NAME_INSTANCE_ID,
        D3D10_NAME_IS_FRONT_FACE = D3D_NAME_IS_FRONT_FACE,
        D3D10_NAME_SAMPLE_INDEX = D3D_NAME_SAMPLE_INDEX,
        D3D10_NAME_TARGET = D3D_NAME_TARGET,
        D3D10_NAME_DEPTH = D3D_NAME_DEPTH,
        D3D10_NAME_COVERAGE = D3D_NAME_COVERAGE,
        D3D11_NAME_FINAL_QUAD_EDGE_TESSFACTOR = D3D_NAME_FINAL_QUAD_EDGE_TESSFACTOR,
        D3D11_NAME_FINAL_QUAD_INSIDE_TESSFACTOR = D3D_NAME_FINAL_QUAD_INSIDE_TESSFACTOR,
        D3D11_NAME_FINAL_TRI_EDGE_TESSFACTOR = D3D_NAME_FINAL_TRI_EDGE_TESSFACTOR,
        D3D11_NAME_FINAL_TRI_INSIDE_TESSFACTOR = D3D_NAME_FINAL_TRI_INSIDE_TESSFACTOR,
        D3D11_NAME_FINAL_LINE_DETAIL_TESSFACTOR = D3D_NAME_FINAL_LINE_DETAIL_TESSFACTOR,
        D3D11_NAME_FINAL_LINE_DENSITY_TESSFACTOR = D3D_NAME_FINAL_LINE_DENSITY_TESSFACTOR,
        D3D11_NAME_DEPTH_GREATER_EQUAL = D3D_NAME_DEPTH_GREATER_EQUAL,
        D3D11_NAME_DEPTH_LESS_EQUAL = D3D_NAME_DEPTH_LESS_EQUAL,
        D3D11_NAME_STENCIL_REF = D3D_NAME_STENCIL_REF,
        D3D11_NAME_INNER_COVERAGE = D3D_NAME_INNER_COVERAGE,
        D3D12_NAME_BARYCENTRICS = D3D_NAME_BARYCENTRICS,
        D3D12_NAME_SHADINGRATE = D3D_NAME_SHADINGRATE,
        D3D12_NAME_CULLPRIMITIVE = D3D_NAME_CULLPRIMITIVE,
    }
}
