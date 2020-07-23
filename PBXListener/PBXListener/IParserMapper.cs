//     IParserMapper.cs is part of PBXListener.
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
    /// Defines generic parser mapper to map parser with it's corresponding property.
    /// </summary>
    public interface IParserMapper
    {
        /// <summary>
        /// Configure mapping for specified type.
        /// </summary>
        void ConfigureMapping();
    }
}
