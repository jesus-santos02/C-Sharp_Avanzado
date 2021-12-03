using System;
using System.Diagnostics;
using System.Linq;

namespace AppDomain01
{
    class Program
    {
        static void Main(string[] args)
        {
            int pid = 4620;
            ListarProcesos();
            //IniciarProceso();
            ObtenerProcesoPorId(pid);
            GetModuleByProcessId(pid);
        }

        public static void ListarProcesos()
        {
            var procesos = from proc in Process.GetProcesses()
                            orderby proc.Id select proc;

            foreach (var proceso in procesos)
            {
                System.Console.WriteLine($"PID: {proceso.Id}, Nombre: {proceso.ProcessName}");
            }
            System.Console.WriteLine($"---------");
        }

        public static void IniciarProceso()
        {
            Process proc = null;

            try
            {
                Process.Start("notepad.exe");
            }
            catch (InvalidOperationException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            Console.Write("Oprime la tecla de Enter");
            Console.ReadLine();

            try
            {
                proc.Kill();
            }
            catch (InvalidOperationException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        public static void ObtenerProcesoPorId(int pid)
        {
            Process proceso = null;

            try
            {
                proceso = Process.GetProcessById(pid);
                System.Console.WriteLine($"PID: {proceso.Id}, Nombre: {proceso.ProcessName}");

                //Obtenemos la lista de los hilos en el proceso
                ProcessThreadCollection hilos = proceso.Threads;

                foreach (ProcessThread hilo in hilos)
                {
                    System.Console.WriteLine
                        ($"ID del hilo: {hilo.Id} - Inicio: {hilo.StartTime} - Prioridad:{hilo.PriorityLevel}");
                }
            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            System.Console.WriteLine($"---------");
        }

        public static void GetModuleByProcessId(int pid)        
        {
            //Un modulo es un .dll o .exe alojado en un proceso
            //Un modulo de 32bits no puede acceder a un modulo de 64bits, configurar correctamente
            Process proceso = Process.GetProcessById(pid);

            ProcessModuleCollection modulos = proceso.Modules;

            foreach (ProcessModule modulo in modulos)
            {
                System.Console.WriteLine($"Modulo: {modulo.ModuleName}");
            }
            System.Console.WriteLine($"---------");
        }

    }
    
}
