using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Input;
using System.Runtime.InteropServices;

namespace clicker_client
{
	class clicker
	{
		[DllImport("user32.dll")]
		public static extern int GetAsyncKeyState(int key);
		const int VK_XBUTTON2 = 0x06;
		static void Main(string[] args)
		{
			SerialPort serialPort = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);
			serialPort.Open();
			while (true)
			{
				if (GetAsyncKeyState(VK_XBUTTON2) != 0)
				{
					serialPort.WriteLine("lole");
				}
				//Console.WriteLine(serialPort.ReadLine());
				//Thread.Sleep(1000);
			}
			serialPort.Close();
		}
	}
}
