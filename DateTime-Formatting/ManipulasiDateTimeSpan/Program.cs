//     Program.cs is part of ManipulasiDateTimeSpan.
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

#endregion

namespace ManipulasiDateTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var testerList = new List<IDateTimeTest> {new StandardDateTimeTest(), new CustomDateTimeTest(), new TimeSpanTest()};

            // mulai uji
            foreach (var dateTimeTest in testerList)
            {
                dateTimeTest.PrintWelcome();
                foreach (var testAction in dateTimeTest.GetTestActions())
                {
                    testAction.Invoke();
                }
            }
            
            // Keluar
            Console.WriteLine();
            Console.Write("Uji coba selesai. Tekan ENTER untuk keluar.");
            Console.Read();
        }
    }
}
