using ComputerResourcesService.Classes;
using ComputerResourcesService.Concrete;
using LibreHardwareMonitor.Hardware;
using System;
using System.Linq;
using System.Threading;

namespace ComputerResourcesService
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer
            {
                IsCpuEnabled = true,
                IsGpuEnabled = false,
                IsMemoryEnabled = false,
                IsMotherboardEnabled = false,
                IsControllerEnabled = false,
                IsNetworkEnabled = false,
                IsStorageEnabled = false
            };

            computer.Open();
            computer.Accept(new UpdateVisitor());
            try
            {
                var cpu_total_sensor = computer.Hardware[0].Sensors.First(s => s.Name == "CPU Total");
                while (true)
                {
                    LoadCPU loadCPU_info = new LoadCPU(cpu_total_sensor.Value);
                    Console.WriteLine($"{loadCPU_info.GetParamName()}: {loadCPU_info.GetValue()}");

                    //PacketsSender.Send(packet);
                    cpu_total_sensor.Hardware.Update();
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            finally
            {
                computer.Close();
            }

        }
    }
}
