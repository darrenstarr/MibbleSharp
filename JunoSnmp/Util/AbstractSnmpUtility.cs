﻿// <copyright file="AbstractSnmpUtility.cs" company="None">
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
//    C# conversion Copyright (c) 2017 Jeremy Gibbons. All rights reserved
//    </para>
// </copyright>

namespace JunoSnmp.Util
{
    using JunoSnmp;

    public class AbstractSnmpUtility
    {
        protected ISession session;
        protected IPDUFactory pduFactory;

        /**
         * Creates a <code>AbstractSnmpUtility</code> instance. The created instance
         * is thread safe as long as the supplied <code>Session</code> and
         * <code>PDUFactory</code> are thread safe.
         *
         * @param snmpSession
         *    a SNMP <code>Session</code> instance.
         * @param pduFactory
         *    a <code>PDUFactory</code> instance that creates the PDU that are used
         *    by this instance.
         */
        public AbstractSnmpUtility(ISession snmpSession, IPDUFactory pduFactory)
        {
            this.session = snmpSession;
            this.pduFactory = pduFactory;
        }
    }
}
