// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WS_SECURITY_CONTEXT_PROPERTY_ID
    {
        WS_SECURITY_CONTEXT_PROPERTY_IDENTIFIER = 1,
        WS_SECURITY_CONTEXT_PROPERTY_USERNAME = 2,
        WS_SECURITY_CONTEXT_PROPERTY_MESSAGE_SECURITY_WINDOWS_TOKEN = 3,
        WS_SECURITY_CONTEXT_PROPERTY_SAML_ASSERTION = 4,
    }
}
