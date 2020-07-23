//     LineParser.cs is part of PBXListener.
//     Copyright (C) 2018  Fahmi Noor Fiqri
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <https://www.gnu.org/licenses/>.
#region

using System.Text.RegularExpressions;

#endregion

namespace PBXListener.Parsers
{
    /// <summary>
    /// Serial line parser.
    /// </summary>
    /// <remarks>This implementation is tested on Panasonic KX-T616 model.</remarks>
    public class LineParser : IParser
    {
        /// <summary>
        /// Parse specified input to match phone's line pattern.
        /// </summary>
        /// <param name="input">Full transmission data (single-line) from serial.</param>
        /// <returns>Parsed data portion with correct data type with result object.</returns>
        /// <remarks>
        /// <para>The returned data type MUST match with the mapped property in your mapping class.
        /// For example, if you define an <c>int</c> inside your model class, you should return an 
        /// <c>int</c> from this function too.</para>
        /// <para>You usually want to just parse and return the output. You don't have to check if
        /// the specified data is exist in the input because the EOF is already checked in the first place.
        /// If you really need the checking, it is okay.</para>
        /// </remarks>
        public object Parse(string input)
        {
            return Regex.Match(input, "\\s[0-9]{2}\\s").Value.Trim();
        }
    }
}
