//     PbxSerialPort.cs is part of PBXListener.
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
using System.ComponentModel;
using System.IO.Ports;
using System.Text;

#endregion

namespace PBXListener
{
    /// <summary>
    /// <see cref="SerialPort"/> wrapper for PBX communication.
    /// </summary>
    public class PbxSerialPort
    {
        private readonly StringBuilder _buffer;
        /// <summary>
        /// Gets the underlying <see cref="SerialPort"/> used to communicate with the PBX.
        /// </summary>
        public readonly SerialPort BasePort;

        /// <summary>
        /// Indicates that data has been received through a port represented. 
        /// </summary>
        public event EventHandler<MessageReceivedEventArgs> MessageReceived;

        #region Properties
        /// <summary>
        /// Gets or sets the port for communications, including but not limited to all available COM ports.
        /// </summary>
        public string PortName
        {
            get => BasePort.PortName;
            set => BasePort.PortName = value;
        }

        /// <summary>
        /// Gets or sets the serial baud rate.
        /// </summary>
        public int BaudRate
        {
            get => BasePort.BaudRate;
            set => BasePort.BaudRate = value;
        }

        /// <summary>
        /// Gets or sets the standard length of data bits per byte.
        /// </summary>
        public int DataBits
        {
            get => BasePort.DataBits;
            set => BasePort.DataBits = value;
        }

        /// <summary>
        /// Gets or sets a value that enables the Data Terminal Ready (DTR) signal during serial communication.
        /// </summary>
        public bool DtrEnable
        {
            get => BasePort.DtrEnable;
            set => BasePort.DtrEnable = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the Request to Send (RTS) signal is enabled 
        /// during serial communication.
        /// </summary>
        public bool RtsEnable
        {
            get => BasePort.RtsEnable;
            set => BasePort.RtsEnable = value;
        }

        /// <summary>
        /// Gets or sets the parity-checking protocol.
        /// </summary>
        public Parity Parity
        {
            get => BasePort.Parity;
            set => BasePort.Parity = value;
        }

        /// <summary>
        /// Gets or sets the handshaking protocol for serial port transmission of data using a 
        /// value from <see cref="System.IO.Ports.Handshake"/>.
        /// </summary>
        public Handshake Handshake
        {
            get => BasePort.Handshake;
            set => BasePort.Handshake = value;
        }

        /// <summary>
        /// Gets or sets the byte encoding for pre- and post-transmission conversion of text.
        /// </summary>
        [Browsable(false)] public Encoding Encoding
        {
            get => BasePort.Encoding;
            set => BasePort.Encoding = value;
        }

        /// <summary>
        /// Gets a value indicating the open or closed status of the serial.
        /// </summary>
        [Browsable(false)] public bool IsOpen => BasePort.IsOpen;

        /// <summary>
        /// Gets or sets the mapper class for current serial instance.
        /// </summary>
        [Browsable(false)] public IParserMapper Mapper { get; set; }

        /// <summary>
        /// Gets or sets EOF marker for serial transmission.
        /// </summary>
        /// <remarks>This property is used to check if the end-of-transmission is reached and the
        /// available data is ready to be processed. This function is necessary becuause of serial 
        /// communication behavior that may send data in chunks. This function is used to make sure the
        /// received data is complete and can be parsed through parsers.</remarks>
        [Browsable(false)] public Func<string, bool> EofMarker { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="PbxSerialPort"/> class.
        /// </summary>
        public PbxSerialPort()
        {
            BasePort = new SerialPort
            {
                BaudRate = 9600,
                DataBits = 8,
                DtrEnable = true,
                RtsEnable = true,
                Parity = Parity.None,
                Handshake = Handshake.XOnXOff
            };
            BasePort.DataReceived += BasePortDataReceived;
            _buffer = new StringBuilder();

            Mapper = new PbxMessageMapper();
            EofMarker = x => Helpers.DurationParserLazy.Value.Parse(x) != null;
        }
        #endregion

        #region Event Subscriber
        private void BasePortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            _buffer.Append(BasePort.ReadExisting());

            if (!EofMarker(_buffer.ToString())) return;
            OnMessageReceived(new MessageReceivedEventArgs { Message = OnParse(_buffer.ToString()) });
            _buffer.Clear();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Opens a new serial port connection and start data receive.
        /// </summary>
        public void Open()
        {
            Mapper.InvokeMember("ClearMapping", Helpers.InvokeMethodFlags, null);
            OnConnect(BasePort);
        }

        /// <summary>
        /// Closes the port connection.
        /// </summary>
        public void Close()
        {
            BasePort.Close();
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// Invoked when a connection is going to be made.
        /// </summary>
        /// <param name="port">The <see cref="SerialPort"/> object used to create new connection.</param>
        /// <remarks>You can change other inaccessible properties for the <see cref="SerialPort"/> object
        /// before opening new connection.</remarks>
        protected virtual void OnConnect(SerialPort port)
        {
            port.Open();
        }

        /// <summary>
        /// Invoked when a complete data is received and about to be parsed.
        /// </summary>
        /// <param name="buffer">Full transmission data.</param>
        /// <returns>Parsed object to be sent through <see cref="MessageReceived"/> event.</returns>
        protected virtual object OnParse(string buffer)
        {
            return Mapper.InvokeMember("Parse", Helpers.InvokeMethodFlags, new object[] {buffer});
        }

        /// <summary>
        /// Invoked when new message is parsed and ready to broadcast.
        /// </summary>
        /// <param name="e">Message body.</param>
        protected virtual void OnMessageReceived(MessageReceivedEventArgs e)
        {
            MessageReceived?.Invoke(this, e);
        } 
        #endregion
    }
}
