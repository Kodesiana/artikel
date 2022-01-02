//     MessageReceivedEventArgs.cs is part of PBXListener.
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

using System;

#endregion

namespace PBXListener
{
    /// <summary>
    /// Contains event data with parsed message from serial.
    /// </summary>
    public class MessageReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Parsed message from serial.
        /// </summary>
        /// <remarks>This property has the same data type you specified for it's mapper.
        /// You can direct cast this property to your model type.</remarks>
        public object Message { get; internal set; }
    }
}
