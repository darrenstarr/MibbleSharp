﻿// <copyright file="IPrivacyProtocol.cs" company="None">
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
    /// The <c>IPrivacyProtocol</c> interface defines a common
    /// interface for all SNMP privacy protocols.
    /// </summary>
    public interface IPrivacyProtocol : ISecurityProtocol
    {
        /// <summary>
        /// Gets the minimum key size for this privacy protocol.
        /// </summary>
        int MinKeyLength { get; }

        /// <summary>
        /// Gets the maximum key size for this privacy protocol.
        /// </summary>
        int MaxKeyLength { get; }

        /// <summary>
        /// Gets the length of the decryption parameters used by this security
        /// protocol.
        /// </summary>
        int DecryptParamsLength { get; }

        /// <summary>
        /// Encrypts a message using a given encryption key, engine boots count, and
        /// engine ID.
        /// </summary>
        /// <param name="unencryptedData">
        /// The unencrypted data. This byte array may contain leading and trailing
        /// bytes that will not be encrypted.
        /// </param>
        /// <param name="offset">
        /// The offset into the <c>unencryptedData</c> where to start encryption
        /// </param>
        /// <param name="length">
        /// The length of the substring starting at <c>offset</c> to encrypt.
        /// </param>
        /// <param name="encryptionKey">The key to be used for encryption</param>
        /// <param name="engineBoots">The engine boots counter to use</param>
        /// <param name="engineTime">The engine time to use</param>
        /// <param name="decryptParams">
        /// Returns the decryption parameters needed to decrypt the data that
        /// has been encrypted by this method
        /// </param>
        /// <returns>
        /// The encrypted copy of <c>unencryptedData</c>.
        /// </returns>
        byte[] Encrypt(
            byte[] unencryptedData,
            int offset,
            int length,
            byte[] encryptionKey,
            long engineBoots,
            long engineTime,
            DecryptParams decryptParams);

        /// <summary>
        /// Decrypts a message using a given encryption key, engine boots count, and
        /// engine ID.
        /// </summary>
        /// <param name="cryptedData">
        /// The encrypted data. This byte array may contain leading and trailing
        /// bytes that will not be decrypted.
        /// </param>
        /// <param name="offset">
        /// The offset into the <c>cryptedData</c> where to start decryption
        /// </param>
        /// <param name="length">
        /// The length of the substring starting at <c>offset</c> to decrypt.
        /// </param>
        /// <param name="decryptionKey">The key to be used for decryption</param>
        /// <param name="engineBoots">The engine boots counter to use</param>
        /// <param name="engineTime">The engine time to use</param>
        /// <param name="decryptParams">Contains the decryption parameters</param>
        /// <returns>
        /// The decrypted data, or <c>null</c> if decryption failed.
        /// </returns>
        byte[] Decrypt(
            byte[] cryptedData,
            int offset,
            int length,
            byte[] decryptionKey,
            long engineBoots,
            long engineTime,
            DecryptParams decryptParams);

        /// <summary>
        /// Gets the length of a scoped PDU when encrypted with this security protocol.
        /// </summary>
        /// <param name="scopedPDULength">The length of the (unencrypted) scoped PDU</param>
        /// <returns>The length of the encrypted scoped PDU</returns>
        int GetEncryptedLength(int scopedPDULength);

        /// <summary>
        /// Extend a localized key that is too short.
        /// Some privacy protocols require a key that is longer than the key
        /// generated by the password-to-key algorithm of the authentication
        /// protocol.This function extends a short key to the required length.
        /// </summary>
        /// <param name="shortKey">
        /// The short key that was generated using <see cref="IAuthenticationProtocol.PasswordToKey"/>
        /// </param>
        /// <param name="password">The password to use for key extension</param>
        /// <param name="engineID">The SNMP Engine ID of the authoritative engine</param>
        /// <param name="authProtocol">The authentication protocol that should be used</param>
        /// <returns>The extended key or <c>shortKey</c> if no extension is needed</returns>
        byte[] ExtendShortKey(
            byte[] shortKey,
            OctetString password,
            byte[] engineID,
            IAuthenticationProtocol authProtocol);
    }
}
