// <copyright file="Matcher.cs" company="None">
//    <para>
//    This program is free software: you can redistribute it and/or
//    modify it under the terms of the BSD license.</para>
//    <para>
//    This work is distributed in the hope that it will be useful, but
//    WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.</para>
//    <para>
//    See the LICENSE.txt file for more details.</para>
//    Original code as generated by Grammatica 1.6 Copyright (c) 
//    2003-2015 Per Cederberg. All rights reserved.
//    Updates Copyright (c) 2016 Jeremy Gibbons. All rights reserved
// </copyright>

namespace PerCederberg.Grammatica.Runtime.RE
{
    using System.IO;

    /// <summary>
    /// A regular expression string matcher. This class handles the
    /// matching of a specific string with a specific regular
    /// expression.It contains state information about the matching
    /// process, as for example the position of the latest match, and a
    /// number of flags that were set. This class is not thread-safe.
    /// </summary>
    public class Matcher
    {
        /// <summary>
        /// The base regular expression element.
        /// </summary>
        private Element element;

        /// <summary>
        /// The input character buffer to work with.
        /// </summary>
        private ReaderBuffer buffer;

        /// <summary>
        /// The character case ignore flag.
        /// </summary>
        private bool ignoreCase;

        /// <summary>
        /// The start of the latest match found.
        /// </summary>
        private int start;

        /// <summary>
        /// The length of the latest match found.
        /// </summary>
        private int length;

        /// <summary>
        /// The end of string reached flag. This flag is set if the end
        /// of the string was encountered during the latest match.
        /// </summary>
        private bool endOfString;

        /// <summary>
        /// Initializes a new instance of the <see cref="Matcher"/> class, with 
        /// the specified element.
        /// </summary>
        /// <param name="e">The base regular expression element</param>
        /// <param name="buffer">The input character buffer to work with</param>
        /// <param name="ignoreCase">The character case ignore flag</param>
        internal Matcher(Element e, ReaderBuffer buffer, bool ignoreCase)
        {
            this.element = e;
            this.buffer = buffer;
            this.ignoreCase = ignoreCase;
            this.start = 0;
            this.Reset();
        }

        /// <summary>
        /// Gets a value indicating whether this matcher compares 
        /// in case-insensitive mode.
        /// </summary>
        public bool IsCaseInsensitive
        {
            get
            {
                return this.ignoreCase;
            }
        }

        /// <summary>
        /// Gets the start position of the latest match. If no match
        /// has been encountered, this method returns zero(0).
        /// </summary>
        public int Start
        {
            get
            {
                return this.start;
            }
        }

        /// <summary>
        /// Gets the end position of the latest match. This is one
        /// character after the match end, i.e.the first character
        /// after the match.If no match has been encountered, this
        /// method returns the same value as start().
        /// </summary>
        public int End
        {
            get
            {
                if (this.length > 0)
                {
                    return this.start + this.length;
                }
                else
                {
                    return this.start;
                }
            }
        }

        /// <summary>
        /// Gets the length of the latest match.
        /// </summary>
        public int Length
        {
            get
            {
                return this.length;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the end of the string 
        /// was encountered during the last match attempt.
        /// This flag signals that more input may
        /// be needed in order to get a match(or a longer match).
        /// </summary>
        public bool HasReadEndOfString
        {
            get
            {
                return this.endOfString;
            }
        }

        /// <summary>
        /// Resets the information about the last match. This will
        /// clear all flags and set the match length to a negative
        /// value.This method is automatically called before starting
        /// a new match.
        /// </summary>
        public void Reset()
        {
            this.length = -1;
            this.endOfString = false;
        }

        /// <summary>
        /// Resets the information about the last match. This will
        /// clear all flags and set the match length to a negative
        /// value.
        /// </summary>
        /// <param name="str">The new string to work with</param>
        public void Reset(string str)
        {
            this.Reset(new ReaderBuffer(new StringReader(str)));
        }

        /// <summary>
        /// Resets the information about the last match. This will
        /// clear all flags and set the match length to a negative
        /// value.
        /// </summary>
        /// <param name="buffer">The character buffer to work with</param>
        public void Reset(ReaderBuffer buffer)
        {
            this.buffer = buffer;
            this.Reset();
        }

        /// <summary>
        /// Attempts to find a match starting at the beginning of the
        /// string.
        /// </summary>
        /// <returns>True if a match was found, false if not
        /// </returns>
        /// <exception cref="IOException">
        /// If an I/O error occurred while reading an input stream
        /// </exception>
        public bool MatchFromBeginning()
        {
            return this.MatchFrom(0);
        }

        /// <summary>
        /// Attempts to find a match starting at the beginning of the
        /// string.
        /// </summary>
        /// <param name="pos">The starting position for the match</param>
        /// <returns>
        /// True if a match was found, false if not
        /// </returns>
        /// <exception cref="IOException">
        /// If an I/O error occurred while reading an input stream
        /// </exception>
        public bool MatchFrom(int pos)
        {
            this.Reset();
            this.start = pos;
            this.length = this.element.Match(this, this.buffer, this.start, 0);
            return this.length >= 0;
        }

        /// <summary>
        /// Returns the latest matched string. If no string has been
        /// matched, an empty string will be returned.
        /// </summary>
        /// <returns>The latest matched string</returns>
        public override string ToString()
        {
            if (this.length <= 0)
            {
                return string.Empty;
            }
            else
            {
                return this.buffer.Substring(this.buffer.Position, this.length);
            }
        }

        /// <summary>
        /// Sets the end of string encountered flag. This method is
        /// called by the various elements analyzing the string.
        /// </summary>
        internal void SetReadEndOfString()
        {
            this.endOfString = true;
        }
    }
}
