using System.Web.UI.Design.WebControls;

namespace ModBusV1
{
    public class Delta 
    {
        VFD vfd;

        public Delta(VFD vFD)
        {
            vfd = vFD;
            if (!vfd.IsSerialPortOpened) vfd.OpenSerialPort();
        }
        
        public void Stop()
        {
            vfd.WriteSingleRegister(0x2001, 0);
            vfd.WriteSingleRegister(0x2000, 1);
        }

        public void Left()
        {
            vfd.WriteSingleRegister(0x2000, 34);
        }

        public void Left(ushort speed)
        {
            vfd.WriteSingleRegister(0x2001, speed);
            vfd.WriteSingleRegister(0x2000, 34);
        }

        public void Right()
        {
            vfd.WriteSingleRegister(0x2000, 18);
        }

        public void Right(ushort speed)
        {
            vfd.WriteSingleRegister(0x2001, speed);
            vfd.WriteSingleRegister(0x2000, 18);
        }

        public void Speed(ushort speed)
        {
            vfd.WriteSingleRegister(0x2001, speed);
        }

        public ushort GetSpeed { get { return vfd.ReadHoldingRegisters(0x2102)[0]; } }
        public ushort GetAmper { get { return vfd.ReadHoldingRegisters(0x2104)[0]; } }
    }
}
