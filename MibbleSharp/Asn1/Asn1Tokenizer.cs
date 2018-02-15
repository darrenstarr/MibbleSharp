/*
 * Asn1Tokenizer.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 *
 * This work is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published
 * by the Free Software Foundation; either version 2 of the License,
 * or (at your option) any later version.
 *
 * This work is distributed in the hope that it will be useful, but
 * WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307
 * USA
 *
 * Copyright (c) 2004-2009 Per Cederberg. All rights reserved.
 */

using System.IO;

using PerCederberg.Grammatica.Runtime;

namespace MibbleSharp.Asn1
{

    /// <remarks>A character stream tokenizer.</remarks>
    internal class Asn1Tokenizer : Tokenizer
    {

        /// <summary>Creates a new tokenizer for the specified input
        /// stream.</summary>
        ///
        /// <param name='input'>the input stream to read</param>
        ///
        /// <exception cref='ParserCreationException'>if the tokenizer
        /// couldn't be initialized correctly</exception>
        public Asn1Tokenizer(TextReader input)
            : base(input, false) {

            CreatePatterns();
        }

        /// <summary>Initializes the tokenizer by creating all the token
        /// patterns.</summary>
        ///
        /// <exception cref='ParserCreationException'>if the tokenizer
        /// couldn't be initialized correctly</exception>
        private void CreatePatterns()
        {
            TokenPattern  pattern;

            pattern = new TokenPattern((int) Asn1Constants.DOT,
                                       "DOT",
                                       TokenPattern.PatternType.STRING,
                                       ".");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.DOUBLE_DOT,
                                       "DOUBLE_DOT",
                                       TokenPattern.PatternType.STRING,
                                       "..");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.TRIPLE_DOT,
                                       "TRIPLE_DOT",
                                       TokenPattern.PatternType.STRING,
                                       "...");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.COMMA,
                                       "COMMA",
                                       TokenPattern.PatternType.STRING,
                                       ",");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.SEMI_COLON,
                                       "SEMI_COLON",
                                       TokenPattern.PatternType.STRING,
                                       ";");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.LEFT_PAREN,
                                       "LEFT_PAREN",
                                       TokenPattern.PatternType.STRING,
                                       "(");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.RIGHT_PAREN,
                                       "RIGHT_PAREN",
                                       TokenPattern.PatternType.STRING,
                                       ")");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.LEFT_BRACE,
                                       "LEFT_BRACE",
                                       TokenPattern.PatternType.STRING,
                                       "{");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.RIGHT_BRACE,
                                       "RIGHT_BRACE",
                                       TokenPattern.PatternType.STRING,
                                       "}");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.LEFT_BRACKET,
                                       "LEFT_BRACKET",
                                       TokenPattern.PatternType.STRING,
                                       "[");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.RIGHT_BRACKET,
                                       "RIGHT_BRACKET",
                                       TokenPattern.PatternType.STRING,
                                       "]");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.MINUS,
                                       "MINUS",
                                       TokenPattern.PatternType.STRING,
                                       "-");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.LESS_THAN,
                                       "LESS_THAN",
                                       TokenPattern.PatternType.STRING,
                                       "<");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.VERTICAL_BAR,
                                       "VERTICAL_BAR",
                                       TokenPattern.PatternType.STRING,
                                       "|");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.DEFINITION,
                                       "DEFINITION",
                                       TokenPattern.PatternType.STRING,
                                       "::=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.DEFINITIONS,
                                       "DEFINITIONS",
                                       TokenPattern.PatternType.STRING,
                                       "DEFINITIONS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.EXPLICIT,
                                       "EXPLICIT",
                                       TokenPattern.PatternType.STRING,
                                       "EXPLICIT");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.IMPLICIT,
                                       "IMPLICIT",
                                       TokenPattern.PatternType.STRING,
                                       "IMPLICIT");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.TAGS,
                                       "TAGS",
                                       TokenPattern.PatternType.STRING,
                                       "TAGS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.BEGIN,
                                       "BEGIN",
                                       TokenPattern.PatternType.STRING,
                                       "BEGIN");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.END,
                                       "END",
                                       TokenPattern.PatternType.STRING,
                                       "END");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.EXPORTS,
                                       "EXPORTS",
                                       TokenPattern.PatternType.STRING,
                                       "EXPORTS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.IMPORTS,
                                       "IMPORTS",
                                       TokenPattern.PatternType.STRING,
                                       "IMPORTS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.FROM,
                                       "FROM",
                                       TokenPattern.PatternType.STRING,
                                       "FROM");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.MACRO,
                                       "MACRO",
                                       TokenPattern.PatternType.STRING,
                                       "MACRO");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.INTEGER,
                                       "INTEGER",
                                       TokenPattern.PatternType.STRING,
                                       "INTEGER");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.REAL,
                                       "REAL",
                                       TokenPattern.PatternType.STRING,
                                       "REAL");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.BOOLEAN,
                                       "BOOLEAN",
                                       TokenPattern.PatternType.STRING,
                                       "BOOLEAN");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.NULL,
                                       "NULL",
                                       TokenPattern.PatternType.STRING,
                                       "NULL");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.BIT,
                                       "BIT",
                                       TokenPattern.PatternType.STRING,
                                       "BIT");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.OCTET,
                                       "OCTET",
                                       TokenPattern.PatternType.STRING,
                                       "OCTET");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.STRING,
                                       "STRING",
                                       TokenPattern.PatternType.STRING,
                                       "STRING");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.ENUMERATED,
                                       "ENUMERATED",
                                       TokenPattern.PatternType.STRING,
                                       "ENUMERATED");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.SEQUENCE,
                                       "SEQUENCE",
                                       TokenPattern.PatternType.STRING,
                                       "SEQUENCE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.SET,
                                       "SET",
                                       TokenPattern.PatternType.STRING,
                                       "SET");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.OF,
                                       "OF",
                                       TokenPattern.PatternType.STRING,
                                       "OF");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.CHOICE,
                                       "CHOICE",
                                       TokenPattern.PatternType.STRING,
                                       "CHOICE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.UNIVERSAL,
                                       "UNIVERSAL",
                                       TokenPattern.PatternType.STRING,
                                       "UNIVERSAL");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.APPLICATION,
                                       "APPLICATION",
                                       TokenPattern.PatternType.STRING,
                                       "APPLICATION");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.PRIVATE,
                                       "PRIVATE",
                                       TokenPattern.PatternType.STRING,
                                       "PRIVATE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.ANY,
                                       "ANY",
                                       TokenPattern.PatternType.STRING,
                                       "ANY");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.DEFINED,
                                       "DEFINED",
                                       TokenPattern.PatternType.STRING,
                                       "DEFINED");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.BY,
                                       "BY",
                                       TokenPattern.PatternType.STRING,
                                       "BY");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.OBJECT,
                                       "OBJECT",
                                       TokenPattern.PatternType.STRING,
                                       "OBJECT");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.IDENTIFIER,
                                       "IDENTIFIER",
                                       TokenPattern.PatternType.STRING,
                                       "IDENTIFIER");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.INCLUDES,
                                       "INCLUDES",
                                       TokenPattern.PatternType.STRING,
                                       "INCLUDES");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.MIN,
                                       "MIN",
                                       TokenPattern.PatternType.STRING,
                                       "MIN");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.MAX,
                                       "MAX",
                                       TokenPattern.PatternType.STRING,
                                       "MAX");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.SIZE,
                                       "SIZE",
                                       TokenPattern.PatternType.STRING,
                                       "SIZE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.WITH,
                                       "WITH",
                                       TokenPattern.PatternType.STRING,
                                       "WITH");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.COMPONENT,
                                       "COMPONENT",
                                       TokenPattern.PatternType.STRING,
                                       "COMPONENT");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.COMPONENTS,
                                       "COMPONENTS",
                                       TokenPattern.PatternType.STRING,
                                       "COMPONENTS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.PRESENT,
                                       "PRESENT",
                                       TokenPattern.PatternType.STRING,
                                       "PRESENT");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.ABSENT,
                                       "ABSENT",
                                       TokenPattern.PatternType.STRING,
                                       "ABSENT");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.OPTIONAL,
                                       "OPTIONAL",
                                       TokenPattern.PatternType.STRING,
                                       "OPTIONAL");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.DEFAULT,
                                       "DEFAULT",
                                       TokenPattern.PatternType.STRING,
                                       "DEFAULT");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.TRUE,
                                       "TRUE",
                                       TokenPattern.PatternType.STRING,
                                       "TRUE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.FALSE,
                                       "FALSE",
                                       TokenPattern.PatternType.STRING,
                                       "FALSE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.PLUS_INFINITY,
                                       "PLUS_INFINITY",
                                       TokenPattern.PatternType.STRING,
                                       "PLUS-INFINITY");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.MINUS_INFINITY,
                                       "MINUS_INFINITY",
                                       TokenPattern.PatternType.STRING,
                                       "MINUS-INFINITY");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.MODULE_IDENTITY,
                                       "MODULE_IDENTITY",
                                       TokenPattern.PatternType.STRING,
                                       "MODULE-IDENTITY");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.OBJECT_IDENTITY,
                                       "OBJECT_IDENTITY",
                                       TokenPattern.PatternType.STRING,
                                       "OBJECT-IDENTITY");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.OBJECT_TYPE,
                                       "OBJECT_TYPE",
                                       TokenPattern.PatternType.STRING,
                                       "OBJECT-TYPE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.NOTIFICATION_TYPE,
                                       "NOTIFICATION_TYPE",
                                       TokenPattern.PatternType.STRING,
                                       "NOTIFICATION-TYPE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.TRAP_TYPE,
                                       "TRAP_TYPE",
                                       TokenPattern.PatternType.STRING,
                                       "TRAP-TYPE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.TEXTUAL_CONVENTION,
                                       "TEXTUAL_CONVENTION",
                                       TokenPattern.PatternType.STRING,
                                       "TEXTUAL-CONVENTION");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.OBJECT_GROUP,
                                       "OBJECT_GROUP",
                                       TokenPattern.PatternType.STRING,
                                       "OBJECT-GROUP");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.NOTIFICATION_GROUP,
                                       "NOTIFICATION_GROUP",
                                       TokenPattern.PatternType.STRING,
                                       "NOTIFICATION-GROUP");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.MODULE_COMPLIANCE,
                                       "MODULE_COMPLIANCE",
                                       TokenPattern.PatternType.STRING,
                                       "MODULE-COMPLIANCE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.AGENT_CAPABILITIES,
                                       "AGENT_CAPABILITIES",
                                       TokenPattern.PatternType.STRING,
                                       "AGENT-CAPABILITIES");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.LAST_UPDATED,
                                       "LAST_UPDATED",
                                       TokenPattern.PatternType.STRING,
                                       "LAST-UPDATED");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.ORGANIZATION,
                                       "ORGANIZATION",
                                       TokenPattern.PatternType.STRING,
                                       "ORGANIZATION");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.CONTACT_INFO,
                                       "CONTACT_INFO",
                                       TokenPattern.PatternType.STRING,
                                       "CONTACT-INFO");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.DESCRIPTION,
                                       "DESCRIPTION",
                                       TokenPattern.PatternType.STRING,
                                       "DESCRIPTION");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.REVISION,
                                       "REVISION",
                                       TokenPattern.PatternType.STRING,
                                       "REVISION");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.STATUS,
                                       "STATUS",
                                       TokenPattern.PatternType.STRING,
                                       "STATUS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.REFERENCE,
                                       "REFERENCE",
                                       TokenPattern.PatternType.STRING,
                                       "REFERENCE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.SYNTAX,
                                       "SYNTAX",
                                       TokenPattern.PatternType.STRING,
                                       "SYNTAX");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.BITS,
                                       "BITS",
                                       TokenPattern.PatternType.STRING,
                                       "BITS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.UNITS,
                                       "UNITS",
                                       TokenPattern.PatternType.STRING,
                                       "UNITS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.ACCESS,
                                       "ACCESS",
                                       TokenPattern.PatternType.STRING,
                                       "ACCESS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.MAX_ACCESS,
                                       "MAX_ACCESS",
                                       TokenPattern.PatternType.STRING,
                                       "MAX-ACCESS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.MIN_ACCESS,
                                       "MIN_ACCESS",
                                       TokenPattern.PatternType.STRING,
                                       "MIN-ACCESS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.INDEX,
                                       "INDEX",
                                       TokenPattern.PatternType.STRING,
                                       "INDEX");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.AUGMENTS,
                                       "AUGMENTS",
                                       TokenPattern.PatternType.STRING,
                                       "AUGMENTS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.IMPLIED,
                                       "IMPLIED",
                                       TokenPattern.PatternType.STRING,
                                       "IMPLIED");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.DEFVAL,
                                       "DEFVAL",
                                       TokenPattern.PatternType.STRING,
                                       "DEFVAL");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.OBJECTS,
                                       "OBJECTS",
                                       TokenPattern.PatternType.STRING,
                                       "OBJECTS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.ENTERPRISE,
                                       "ENTERPRISE",
                                       TokenPattern.PatternType.STRING,
                                       "ENTERPRISE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.VARIABLES,
                                       "VARIABLES",
                                       TokenPattern.PatternType.STRING,
                                       "VARIABLES");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.DISPLAY_HINT,
                                       "DISPLAY_HINT",
                                       TokenPattern.PatternType.STRING,
                                       "DISPLAY-HINT");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.NOTIFICATIONS,
                                       "NOTIFICATIONS",
                                       TokenPattern.PatternType.STRING,
                                       "NOTIFICATIONS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.MODULE,
                                       "MODULE",
                                       TokenPattern.PatternType.STRING,
                                       "MODULE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.MANDATORY_GROUPS,
                                       "MANDATORY_GROUPS",
                                       TokenPattern.PatternType.STRING,
                                       "MANDATORY-GROUPS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.GROUP,
                                       "GROUP",
                                       TokenPattern.PatternType.STRING,
                                       "GROUP");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.WRITE_SYNTAX,
                                       "WRITE_SYNTAX",
                                       TokenPattern.PatternType.STRING,
                                       "WRITE-SYNTAX");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.PRODUCT_RELEASE,
                                       "PRODUCT_RELEASE",
                                       TokenPattern.PatternType.STRING,
                                       "PRODUCT-RELEASE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.SUPPORTS,
                                       "SUPPORTS",
                                       TokenPattern.PatternType.STRING,
                                       "SUPPORTS");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.VARIATION,
                                       "VARIATION",
                                       TokenPattern.PatternType.STRING,
                                       "VARIATION");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.CREATION_REQUIRES,
                                       "CREATION_REQUIRES",
                                       TokenPattern.PatternType.STRING,
                                       "CREATION-REQUIRES");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.BINARY_STRING,
                                       "BINARY_STRING",
                                       TokenPattern.PatternType.REGEXP,
                                       "'[0-1]*'(B|b)");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.HEXADECIMAL_STRING,
                                       "HEXADECIMAL_STRING",
                                       TokenPattern.PatternType.REGEXP,
                                       "'[0-9A-Fa-f]*'(H|h)");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.QUOTED_STRING,
                                       "QUOTED_STRING",
                                       TokenPattern.PatternType.REGEXP,
                                       "\"([^\"]|\"\")*\"");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.IDENTIFIER_STRING,
                                       "IDENTIFIER_STRING",
                                       TokenPattern.PatternType.REGEXP,
                                       "[a-zA-Z][a-zA-Z0-9-_]*");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.NUMBER_STRING,
                                       "NUMBER_STRING",
                                       TokenPattern.PatternType.REGEXP,
                                       "[0-9]+");
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.WHITESPACE,
                                       "WHITESPACE",
                                       TokenPattern.PatternType.REGEXP,
                                       "[ \\t\\n\\r\\f\\x0b\\x17\\x18\\x19\\x1a]+");
            pattern.Ignore = true;
            AddPattern(pattern);

            pattern = new TokenPattern((int) Asn1Constants.COMMENT,
                                       "COMMENT",
                                       TokenPattern.PatternType.REGEXP,
                                       "--([^\\n\\r-]|-[^\\n\\r-])*(--|-?[\\n\\r])");
            pattern.Ignore = true;
            AddPattern(pattern);
        }
    }
}
