//     MainForm.cs is part of CountdownScreen.
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
using System.Linq;
using System.Windows.Forms;

#endregion

namespace CountdownScreen
{
    public partial class MainForm : Form
    {
        private CountdownForm _countdownForm;

        public MainForm()
        {
            InitializeComponent();

            cboScreen.DataSource = Screen.AllScreens.Select(x => $"{x.DeviceName} (Primary: {x.Primary})").ToList();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            var screenBounds = Screen.AllScreens[cboScreen.SelectedIndex].Bounds;
            var time = new TimeSpan(dtCount.Value.Hour, dtCount.Value.Minute, dtCount.Value.Second);

            _countdownForm = new CountdownForm(screenBounds, time);
            _countdownForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _countdownForm?.Close();
        }
    }
}
