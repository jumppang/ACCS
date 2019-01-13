using System;
using System.Collections.Generic;
using System.Text;

namespace System.Security.Authentication
{
    public static class SslProtocolsExtensions
    {
        public const SslProtocols Tls12 = (SslProtocols)0x00000C0;
        public const SslProtocols Tls11 = (SslProtocols)0x0000030;
    }
}
