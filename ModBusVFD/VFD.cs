using Modbus.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBusV1
{
    public class VFD
    {
        System.IO.Ports.SerialPort SerialPort;
        IModbusSerialMaster Master;
        public static int[] DataBits = new int[] { 7, 8 };
        public static int[] StepBits = new int[] { 1, 2 };
        public static int[] BaudRates = new int[] { 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000 };

        public Comunication comunication { get; set; }

        public VFD(string portName, int baudRate, int dataBit, System.IO.Ports.StopBits stopBit, System.IO.Ports.Parity parity, byte address, int readTimeout = 1000, int writeTimeout = 1000)
        {
            comunication = new Comunication
            {
                PortName = portName,
                BaudRate = baudRate,
                DataBit = dataBit,
                StopBit = stopBit,
                Parity = parity,
                Address = address,
                ReadTimeout = readTimeout,
                WriteTimeout = writeTimeout,
            };
        }

        public bool IsSerialPortOpened { get { return SerialPort != null && SerialPort.IsOpen; } }

        public void OpenSerialPort()
        {
            SerialPort = new System.IO.Ports.SerialPort(comunication.PortName, comunication.BaudRate, comunication.Parity, comunication.DataBit, comunication.StopBit);
            if (!IsSerialPortOpened) SerialPort.Open();
            Master = ModbusSerialMaster.CreateRtu(SerialPort);
            Master.Transport.ReadTimeout = 1000;
            Master.Transport.WriteTimeout = 1000;
        }

        public void CloseSerialPort()
        {
            if (IsSerialPortOpened) SerialPort.Close();

            SerialPort.Dispose();
            SerialPort = null;

            Master.Dispose();
            Master = null;
        }

        public void WriteSingleRegister(ushort registerAddress, ushort value)
        {
            if (SerialPort.IsOpen && Master != null)
                Master.WriteSingleRegister(comunication.Address, registerAddress, value);
            else
                throw new Exception("Port is closed!");
        }

        public ushort[] ReadHoldingRegisters(ushort registerAddress, ushort numberOfPoints = 1)
        {
            if (SerialPort.IsOpen && Master != null)
                return Master.ReadHoldingRegisters(comunication.Address, registerAddress, numberOfPoints);
            else
                throw new Exception("Port is closed!");
        }
    }

    public class Comunication
    {
        public int ReadTimeout { get; set; }

        public int WriteTimeout { get; set; }

        public string PortName { get; set; }

        public string SerialPort { get; set; }

        public int BaudRate { get; set; }

        public int DataBit { get; set; }

        public System.IO.Ports.StopBits StopBit { get; set; }

        public System.IO.Ports.Parity Parity { get; set; }

        public byte Address { get; set; }
    }
}
