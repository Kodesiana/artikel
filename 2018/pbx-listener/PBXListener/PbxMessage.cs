//     PbxMessage.cs is part of PBXListener.
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
namespace PBXListener
{
    /// <summary>
    /// Defines generic model for Panasonic KX-T616 PBX.
    /// </summary>
    public class PbxMessage
    {
        /// <summary>
        /// Date when the call is made.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Time when the call is made.
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Destination phone number.
        /// </summary>
        public string DestinationNumber { get; set; }

        /// <summary>
        /// Call duration.
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Phone extension.
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Phone line.
        /// </summary>
        public string Line { get; set; }
    }
}
