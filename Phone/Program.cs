using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.DigitPressed(10);
            phone.DigitPressed(20);
            phone.DigitPressed(30);

            phone.CallButton();
            System.Threading.Thread.Sleep(1000);
            phone.ConnectionEstablished();
            phone.ToggleMute();
            phone.ToggleMute();
            phone.ToggleSpeaker();
            phone.ToggleSpeaker();
            System.Threading.Thread.Sleep(1000);
            phone.CallButton();
            phone.Disconnected();
        }
    }
}
