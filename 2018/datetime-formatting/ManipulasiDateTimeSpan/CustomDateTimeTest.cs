//     CustomDateTimeTest.cs is part of ManipulasiDateTimeSpan.
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
    public class CustomDateTimeTest : IDateTimeTest
    {
        public void PrintWelcome()
        {
            Console.WriteLine();
            Console.WriteLine("Uji coba Custom DateTime Format...");
            Console.WriteLine("====================================");
        }

        public IEnumerable<Action> GetTestActions()
        {
            return new List<Action>
            {
                TestFormatTanggalHari,
                TestFormatTanggalBulan,
                TestFormatWaktuDetik,
                TestFormatWaktuMenit,
                TestFormatWaktuJam
            };
        }

        private void TestFormatTanggalHari()
        {
            Console.WriteLine();
            Console.WriteLine(">> Test format tanggal (HARI)");
            var tanggal = DateTime.Now;

            // lihat format di bawah pada artikel
            var formats = new[]
            {
                "d",   // hari, 1-31
                "dd",  // hari, 01-31
                "ddd", // hari, singkatan hari (misalnya Sun, Mon)
                "dddd" // hari, kepanjangan (misalnya Sunday, Monday)
            };
            foreach (var format in formats)
            {
                // format tambahan: __ MM yyyy (__ bulan tahun)
                Console.WriteLine(tanggal.ToString(format + " MM yyyy"));
            }
        }

        private void TestFormatTanggalBulan()
        {
            Console.WriteLine();
            Console.WriteLine(">> Test format tanggal (BULAN)");
            var tanggal = DateTime.Now;

            // lihat format di bawah pada artikel
            var formats = new[]
            {
                "M",   // bulan, 1-12
                "MM",  // bulan, 01-12
                "MMM", // bulan, singkatan bulan (misalnya Jun, Dec)
                "MMMM" // bulan, kepanjangan (misalnya June, December)
            };
            foreach (var format in formats)
            {
                // format tambahan: dd __ yyyy (hari __ tahun)
                Console.WriteLine(tanggal.ToString("dd " + format + " yyyy"));
            }
        }

        private void TestFormatWaktuDetik()
        {
            Console.WriteLine();
            Console.WriteLine(">> Test format waktu (DETIK)");
            var tanggal = DateTime.Now;

            // lihat format di bawah pada artikel
            var formatDesignator = new[]
            {
                "t",   // satu karakter pertama designator (misalnya P -> PM, A -> AM)
                "tt",  // dua karakter designator (misalnya PM, AM)
            };
            var formatDetik = new[]
            {
                "s",   // detik, 1-59
                "ss",  // detik, 01-59
            };

            // saya pakai nested loop yang compact, semoga tidak bingung
            foreach (var fDesc in formatDesignator)
            foreach (var fDetik in formatDetik)
            {
                Console.WriteLine(tanggal.ToString($"hh:mm:{fDetik} {fDesc}"));
            }
        }

        private void TestFormatWaktuMenit()
        {
            Console.WriteLine();
            Console.WriteLine(">> Test format waktu (MENIT)");
            var tanggal = DateTime.Now;

            // lihat format di bawah pada artikel
            var formatDesignator = new[]
            {
                "t",   // satu karakter pertama designator (misalnya P -> PM, A -> AM)
                "tt",  // dua karakter designator (misalnya PM, AM)
            };
            var formatMenit = new[]
            {
                "m",   // menit, 1-59
                "mm",  // menit, 01-59
            };

            // saya pakai nested loop yang compact, semoga tidak bingung
            foreach (var fDesc in formatDesignator)
            foreach (var fMenit in formatMenit)
            {
                Console.WriteLine(tanggal.ToString($"hh:{fMenit}:ss {fDesc}"));
            }
        }

        private void TestFormatWaktuJam()
        {
            Console.WriteLine();
            Console.WriteLine(">> Test format waktu (JAM)");
            var tanggal = DateTime.Now;

            // lihat format di bawah pada artikel
            var formatDesignator = new[]
            {
                "t",   // satu karakter pertama designator (misalnya P -> PM, A -> AM)
                "tt",  // dua karakter designator (misalnya PM, AM)
            };
            var formatJam = new[]
            {
                "h",   // jam, 1-12
                "hh",  // jam, 01-12
                "H",   // jam, 1-24
                "HH"   // jam, 01-24
            };

            // saya pakai nested loop yang compact, semoga tidak bingung
            foreach (var fDesc in formatDesignator)
            foreach (var fJam in formatJam)
            {
                Console.WriteLine(tanggal.ToString($"{fJam}:mm:ss {fDesc}"));
            }
        }
    }
}
