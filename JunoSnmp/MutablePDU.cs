﻿// <copyright file="MutablePDU.cs" company="None">
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

namespace JunoSnmp
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The <c>MutablePDU</c> is a container for a <c>PDU</c> instance.
    /// </summary>
    public class MutablePDU : ISerializable
    {

        private PDU pdu;

        /// <summary>
        /// Initializes a new instance of the <see cref="MutablePDU"/> class.
        /// </summary>
        public MutablePDU()
        {
        }

        /// <summary>
        /// Gets or sets the PDU property.
        /// </summary>
        public PDU Pdu
        {
            get
            {
                return this.pdu;
            }

            set
            {
                this.pdu = value;
            }
        }

        /// <summary>
        /// Writes this object to a stream for serialization
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> object</param>
        /// <param name="context">The <see cref="StreamingContext"/></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}