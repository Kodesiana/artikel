//     PbxMessageMapper.cs is part of PBXListener.
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

using PBXListener.Parsers;

#endregion

namespace PBXListener
{
    /// <summary>
    /// Default message parser for Panasonic KX-T616 PBX.
    /// </summary>
    public class PbxMessageMapper : ParserMapper<PbxMessage>
    {
        /// <summary>
        /// Configures <see cref="PbxMessage"/> with it's corresponding parsers.
        /// </summary>
        public override void ConfigureMapping()
        {
            Map<DateParser>(x => x.Date);
            Map<TimeParser>(x => x.Time);
            Map<PhoneNumberParser>(x => x.DestinationNumber);
            Map<DurationParser>(x => x.Duration);
            Map<ExtensionParser>(x => x.Extension);
            Map<LineParser>(x => x.Line);
        }
    }
}
