﻿// <copyright file="NullType.cs" company="None">
//    <para>
//    This work is free software; you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published
//    by the Free Software Foundation; either version 2 of the License,
//    or (at your option) any later version.</para>
//    <para>
//    This work is distributed in the hope that it will be useful, but
//    WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
//    General Public License for more details.</para>
//    <para>
//    along with this program; if not, write to the Free Software
//    Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307
//    USA</para>
//    Original Java code Copyright (c) 2004-2016 Per Cederberg. All
//    rights reserved.
//    C# conversion Copyright (c) 2016 Jeremy Gibbons. All rights reserved
// </copyright>

namespace MibbleSharp.Type
{
    using MibbleSharp.Value;
 
    /// <summary>
    /// A null MIB type
    /// </summary>
    public class NullType : MibType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullType"/> class.
        /// </summary>
        public NullType() : this(true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullType"/> class.
        /// </summary>
        /// <param name="primitive">The primitive type flag</param>
        private NullType(bool primitive) : base("NULL", primitive)
        {
        }

        /// <summary>
        /// Initializes the MIB type. This will remove all levels of
        /// indirection present, such as references to types or values. No
        /// information is lost by this operation. This method may modify
        /// this object as a side-effect, and will return the basic
        /// type.
        /// NOTE: This is an internal method that should
        /// only be called by the MIB loader.
        /// </summary>
        /// <param name="symbol">The MIB symbol containing this type</param>
        /// <param name="log">The MIB loader log</param>
        /// <returns>The basic MIB type</returns>
        public override MibType Initialize(MibSymbol symbol, MibLoaderLog log)
        {
            this.SetTag(true, MibTypeTag.Null);
            return this;
        }

        /// <summary>
        /// Creates a type reference to this type. The type reference is
        /// normally an identical type, but with the primitive flag set to
        /// false. Only certain types support being referenced, and the
        /// default implementation of this method throws an exception.
        /// NOTE: This is an internal method that should
        /// only be called by the MIB loader.
        /// </summary>
        /// <returns>The MIB type reference</returns>
        public override MibType CreateReference()
        {
            NullType type = new NullType(false);
            type.SetTag(true, this.Tag);
            return type;
        }

        /// <summary>
        /// Checks if the specified value is compatible with this type.
        /// The value is considered compatible with this type, if and only 
        /// if it is a null value
        /// </summary>
        /// <param name="value">The value to check</param>
        /// <returns>true if the value is compatible, false otherwise</returns>
        public override bool IsCompatible(MibValue value)
        {
            return value is NullValue;
        }
    }
}
