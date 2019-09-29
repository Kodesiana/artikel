//     TimeSpanTest.cs is part of ManipulasiDateTimeSpan.
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
    public class TimeSpanTest : IDateTimeTest
    {
        public void PrintWelcome()
        {
            Console.WriteLine();
            Console.WriteLine("Uji coba TimeSpan...");
            Console.WriteLine("===================================");
        }

        public IEnumerable<Action> GetTestActions()
        {
            return new List<Action>
            {
                TestOperasiDateTime,
                TestOperasiTimeSpan
            };
        }

        private void TestOperasiDateTime()
        {
            Console.WriteLine();
            Console.WriteLine(">> Test selisih, tambah, dan kurang tanggal");
            DateTime date;
            var tanggal1 = new DateTime(2004, 5, 28, 18, 2, 15);
            var tanggal2 = new DateTime(2000, 5, 21, 12, 4, 22);
            
            // display value
            Console.WriteLine("Tanggal 1: " + tanggal1);
            Console.WriteLine("Tanggal 2: " + tanggal2);
            Console.WriteLine();

            // tanggal1 - tanggal2 --> selisih dua tanggal
            Console.Write("Tanggal 1 - Tanggal 2: ");
            var time = tanggal1 - tanggal2;
            Console.WriteLine(time.ToString("g")); // format: hari:jam:menit:detik

            // tanggal1 + 3 hari --> tambah 2 hari
            Console.Write("Tanggal 1 + 3 hari: ");
            date = tanggal1.Add(TimeSpan.FromDays(3)); // +3 hari
            Console.WriteLine(date.ToString());

            // tanggal1 - 5 hari --> kurang 5 hari
            Console.Write("Tanggal 1 - 5 hari: ");
            date = tanggal1.Add(TimeSpan.FromDays(-5)); // + (-5) hari --> -5 hari
            Console.WriteLine(date.ToString());
        }

        private void TestOperasiTimeSpan()
        {
            Console.WriteLine();
            Console.WriteLine(">> Test kurang dan tambah waktu");
            TimeSpan time;
            var waktu1 = new TimeSpan(0, 5, 12, 22);
            var waktu2 = new TimeSpan(0, 2, 12, 5);

            // display value
            Console.WriteLine("Waktu 1: " + waktu1);
            Console.WriteLine("Waktu 2: " + waktu2);
            Console.WriteLine();

            // kurang
            Console.Write("Waktu 1 - Waktu 2: ");
            time = waktu1 - waktu2;
            Console.WriteLine(time.ToString("g")); // format: hari:jam:menit:detik

            // tambah
            Console.Write("Waktu 1 + Waktu 2: ");
            time = waktu1 + waktu2;
            Console.WriteLine(time.ToString("g")); // format: hari:jam:menit:detik
        }
    }
}
