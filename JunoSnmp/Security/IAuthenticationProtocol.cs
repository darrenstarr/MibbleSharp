﻿// <copyright file="IAuthenticationProtocol.cs" company="None">
//    <para>
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at</para>
//    <para>
//    http://www.apache.org/licenses/LICENSE-2.0
//    </para><para>
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.</para>
//    <para>
//    Original Java code from Snmp4J Copyright (C) 2003-2016 Frank Fock and 
//    Jochen Katz (SNMP4J.org). All rights reserved.
//    </para><para>
//    C# conversion Copyright (c) 2016 Jeremy Gibbons. All rights reserved
//    </para>
// </copyright>

namespace JunoSnmp.Security
{
    using JunoSnmp.SMI;

    /// <summary>
    /// The <code>AuthenticationProtocol</code> interface defines a common 
    /// interface for all SNMP authentication protocols.
    /// </summary>
    public interface IAuthenticationProtocol : ISecurityProtocol
    {
        /// <summary>
        /// Gets the length in bytes of the digest generated by this authentication protocol.
        /// This value can be used to compute the BER encoded length of the security
        /// parameters for authentication.
        /// </summary>
        int HashLength { get; }

        /// <summary>
        /// Gets the length of the authentication code (the hashing output length) in bytes.
        /// </summary>
        int AuthenticationCodeLength { get; }
        
        /// <summary>
        /// Authenticates an outgoing message.
        /// This method fills the authentication parameters field of the
        /// given message.The parameter<code> digestOffset</code> offset is pointing
        /// inside the message buffer and must be zeroed before the authentication
        /// value is computed.
        /// </summary>
        /// <param name="authenticationKey">
        /// The authentication key to be used for authenticating the message.
        /// </param>
        /// <param name="message">
        /// The entire message for which the digest should be determined.
        /// </param>
        /// <param name="messageOffset">
        /// The offset in <code>message</code> where the message actually starts.
        /// </param>
        /// <param name="messageLength">
        /// The actual message length (may be smaller than <c>message.length</c>).
        /// </param>
        /// <param name="hash">
        /// The offset in <code>message</code> where to store the hash.
        /// </param>
        /// <returns>
        /// <c>True</c> if the message digest has been successfully computed
        /// and set, <c>false</c> otherwise.
        /// </returns>
        bool Authenticate(
            byte[] authenticationKey,
            byte[] message,
            int messageOffset,
            int messageLength,
            ByteArrayWindow hash);

        /// <summary>
        /// <para>Authenticates an incoming message.</para>
        /// <para>
        /// This method checks if the value in the authentication parameters
        /// field of the message is valid.
        /// </para><para>
        /// The following procedure is used to verify the authentication value
        /// - copy the authentication value to a temp buffer
        /// - zero the auth field
        /// - recalculate the authentication value
        /// - compare the two authentication values
        /// - write back the received authentication value
        /// </para>
        /// </summary>
        /// <param name="authenticationKey">
        /// the authentication key to be used for authenticating the message.
        /// </param>
        /// <param name="message">
        /// The entire message for which the digest should be determined.
        /// </param>
        /// <param name="messageOffset">
        /// The offset in <c>message</c> where the message actually starts.
        /// </param>
        /// <param name="messageLength">
        /// the actual message length (may be smaller than <c>message.length</c>).
        /// </param>
        /// <param name="hash">
        /// The hash of the <code>message</code>.
        /// </param>
        /// <returns>True if the message is authentic, false if not</returns>
        bool IsAuthentic(
            byte[] authenticationKey,
            byte[] message,
            int messageOffset,
            int messageLength,
            ByteArrayWindow hash);

        /// <summary>
        /// Computes the delta digest needed to remotely change an user's
        /// authentication key.The length of the old key (e.g. 16 for MD5,
        /// 20 for SHA) must match the length of the new key.
        /// </summary>
        /// <param name="oldKey">The old authentication/privacy key</param>
        /// <param name="newKey">The new authentication/privacy key</param>
        /// <param name="random">The random "seed" to be used to produce the digest</param>
        /// <returns>
        /// the byte array representing the delta for key change operations.
        /// To obtain the key change value, append this delta to the
        /// <c>random</c> array.
        /// </returns>
        byte[] ChangeDelta(byte[] oldKey, byte[] newKey, byte[] random);

        /// <summary>
        /// Generates the localized key for the given password and engine id.
        /// </summary>
        /// <param name="passwordString">The authentication pass-phrase</param>
        /// <param name="engineID">The engine ID of the authoritative engine</param>
        /// <returns>The localized authentication key</returns>
        byte[] PasswordToKey(OctetString passwordString, byte[] engineID);

        /// <summary>
        /// Generates a hash value for the given data.
        /// </summary>
        /// <param name="data">The data</param>
        /// <returns>The generated hash</returns>
        byte[] Hash(byte[] data);

        /// <summary>
        /// Generates a hash value for the given data.
        /// </summary>
        /// <param name="data">The data</param>
        /// <param name="offset">Offset into data</param>
        /// <param name="length">Length of data to hash</param>
        /// <returns>The generated hash</returns>
        byte[] Hash(byte[] data, int offset, int length);
    }
}
