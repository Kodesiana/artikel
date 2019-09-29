//     StandardDateTimeTest.cs is part of ManipulasiDateTimeSpan.
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
    public class StandardDateTimeTest : IDateTimeTest
    {
        public void PrintWelcome()
        {
            Console.WriteLine();
            Console.WriteLine("Uji coba Standard DateTime Format...");
            Console.WriteLine("====================================");
        }

        public IEnumerable<Action> GetTestActions()
        {
            return new List<Action>
            {
                TestAmbilDateTimeSistem,
                TestPembuatanDateTime,
                TestStandardDateTimeFormat
            };
        }

        private void TestAmbilDateTimeSistem()
        {
            Console.WriteLine();
            Console.WriteLine(">> Test ambil DateTime dari sistem");
            DateTime tanggal;

            // tanggal hari ini
            tanggal = DateTime.Today;
            Console.WriteLine(tanggal.ToString());

            // tanggal dan waktu saat ini
            tanggal = DateTime.Now;
            Console.WriteLine(tanggal.ToString());

            // tanggal dan waktu saat ini dalam zona waktu UTC
            tanggal = DateTime.UtcNow;
            Console.WriteLine(tanggal.ToString());
        }

        private void TestPembuatanDateTime()
        {
            Console.WriteLine();
            Console.WriteLine(">> Test pembuatan DateTime");
            DateTime tanggal;

            // Tanpa parameter: 1 Januari 0001 12.00
            tanggal = new DateTime(); 
            Console.WriteLine(tanggal.ToString());

            // parameter: Tahun, Bulan, Tanggal
            tanggal = new DateTime(2018, 5, 26);
            Console.WriteLine(tanggal.ToString());

            // parameter: Tahun, Bulan, Tanggal, Jam, Menit, Detik
            tanggal = new DateTime(2018, 5, 26, 21, 33, 0);
            Console.WriteLine(tanggal.ToString());
        }

        private void TestStandardDateTimeFormat()
        {
            Console.WriteLine();
            Console.WriteLine(">> Test format DateTime ke String");
            var tanggal = DateTime.Now; // pakai tanggal dan waktu saat ini

            // lihat format di bawah pada artikel
            var formats = new[]
            {
                "d", // tanggal pendek (6/15/2009)
                "D", // tanggal panjang (Monday, June 15, 2009)
                "f", // tanggal dan waktu pendek (Monday, June 15, 2009 1:45 PM)
                "F", // tanggal dan waktu panjang (Monday, June 15, 2009 1:45:30 PM)
                "g", // tanggal dan waktu umum (6/15/2009 1:45 PM)
                "G", // tanggal dan waktu lengkap (6/15/2009 1:45:30 PM)
                "t", // waktu pendek (1:45 PM)
                "T", // waktu panjang (1:45:30 PM)
                "m", // tanggal dan bulan (June 15)
                "y"  // bulan dan tahun (June, 2009)
            };
            foreach (var format in formats)
            {
                Console.WriteLine(tanggal.ToString(format));
            }
        }
    }
}
