//     Helpers.cs is part of PBXListener.
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
using System.Reflection;
using PBXListener.Parsers;

#endregion

namespace PBXListener
{
    internal static class Helpers
    {
        public const BindingFlags SetPropertyFlags = BindingFlags.SetProperty
                                                     | BindingFlags.Public
                                                     | BindingFlags.Instance;

        public const BindingFlags InvokeMethodFlags = BindingFlags.InvokeMethod
                                                      | BindingFlags.NonPublic
                                                      | BindingFlags.Instance;

        public static readonly Lazy<DurationParser> DurationParserLazy = new Lazy<DurationParser>();

        public static object InvokeMember(this object target, string name, BindingFlags flags, object[] args)
        {
            var type = target.GetType();
            return type.InvokeMember(name, flags, null, target, args);
        }
    }
}
