using System.IO.Ports;

namespace LED_Controller_Core
{
    //class for work with COM Ports
    public class COMPort
    {
        public string[] PortNames = SerialPort.GetPortNames(); 
        public string PortName { get; set; }
        public const int PortSpeed = 9600;
        public bool IsPortOpen = false;
    }
}
