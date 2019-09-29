//     CountdownForm.cs is part of CountdownScreen.
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
using System.Drawing;
using System.Windows.Forms;

#endregion

// ReSharper disable once LocalizableElement

namespace CountdownScreen
{
    public partial class CountdownForm : Form
    {
        private TimeSpan _currentCount;

        public CountdownForm(Rectangle bounds, TimeSpan value)
        {
            InitializeComponent();
            
            SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height, BoundsSpecified.Location);
            WindowState = FormWindowState.Maximized;

            _currentCount = value;
            label1.Text = $"{_currentCount.Hours:D2}:{_currentCount.Minutes:D2}:{_currentCount.Seconds:D2}";
            tmrCount.Start();
        }

        private void tmrCount_Tick(object sender, EventArgs e)
        {
            _currentCount = _currentCount - TimeSpan.FromSeconds(1);
            label1.Text = $"{_currentCount.Hours:D2}:{_currentCount.Minutes:D2}:{_currentCount.Seconds:D2}";

            if (_currentCount.TotalSeconds > 0) return;
            label1.Text = "Selesai.";
            tmrCount.Stop();
        }
    }
}
