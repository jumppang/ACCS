using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Authentication;

namespace System.Net
{

    public static class SecurityProtocolTypeExtensions
    {
        public const SecurityProtocolType Tls12 = (SecurityProtocolType)SslProtocolsExtensions.Tls12;
        public const SecurityProtocolType Tls11 = (SecurityProtocolType)SslProtocolsExtensions.Tls11;
    }
}
