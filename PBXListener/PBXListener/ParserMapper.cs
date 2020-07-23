//     ParserMapper.cs is part of PBXListener.
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
using System.Collections.Generic;
using System.Linq.Expressions;

#endregion

namespace PBXListener
{
    /// <summary>
    /// Defines generic parser mapper to map parser with it's corresponding property.
    /// </summary>
    /// <typeparam name="TTarget"></typeparam>
    public abstract class ParserMapper<TTarget> : IParserMapper where TTarget : class, new()
    {
        private Dictionary<string, IParser> _parsers;

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="ParserMapper{TTarget}"/> class.
        /// </summary>
        protected ParserMapper()
        {
            _parsers = new Dictionary<string, IParser>();
        }
        #endregion

        #region Parent Methods
        /// <summary>
        /// Configure mapping for specified type.
        /// </summary>
        public abstract void ConfigureMapping();

        /// <summary>
        /// Map specified parser with specified property.
        /// </summary>
        /// <typeparam name="TParser">Parser used to parse the data.</typeparam>
        /// <param name="property">Destination property to hold parsed data.</param>
        /// <remarks>The returned data type MUST match with the mapped property in your mapping class.
        /// For example, if you define an <c>int</c> inside your model class, you should return an 
        /// <c>int</c> from this function too.</remarks>
        protected void Map<TParser>(Expression<Func<TTarget, object>> property) where TParser : IParser, new()
        {
            var expr = (MemberExpression)property.Body;
            var parser = (IParser)Activator.CreateInstance(typeof(TParser));
            _parsers.Add(expr.Member.Name, parser);
        }
        #endregion

        #region Internal Methods
        internal void ClearMapping()
        {
            _parsers.Clear();
        }

        internal object Parse(string input)
        {
            var obj = Activator.CreateInstance(typeof(TTarget));
            foreach (var parser in _parsers)
            {
                obj.InvokeMember(parser.Key, Helpers.SetPropertyFlags, new[] { parser.Value.Parse(input) });
            }
            return obj;
        } 
        #endregion
    }
}
