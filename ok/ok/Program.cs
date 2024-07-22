using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok
{
    class Conditioner
    {
        public int Mode = 1;
        public bool Power = false;
        public int Zhalusi = 50;
        public int Temperature = 20;
        private int MaxTemperature = 28;
        private int MinTemperature = 16;

        private void TurnOn()
        {
            Power = true;
        }

        private void TurnOff()
        {
            Power = false;
        }

        private void ChangeMode()
        {
            switch (Mode)
            {
                case 1:
                    Mode = 2; break;

                case 2:
                    Mode = 3; break;

                case 3:
                    Mode = 1; break;
            }
        }

        private void TemperatureUp()
        {
            if (Temperature > 16)
            {
                Temperature += 1;
            }
            else
            {
                Console.WriteLine("Min temperature!");
            }
        }

        private void TemperatureDown()
        {
            if (Temperature < 28)
            {
                Temperature -= 1;
            }
            else
            {
                Console.WriteLine("Max temperature!");
            }
        }

        private void ShowInfo()
        {
            string ModeT;

            switch (this.Mode)
            {
                case 1:
                    ModeT = "Abdyf"; break;
                case 2:
                    ModeT = "Grelka"; break;
                case 3:
                    ModeT = "Skvasnak"; break;
            }

            Console.WriteLine($"Mode: {ModeT}    Temperature: {Temperature}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }

    }
}
