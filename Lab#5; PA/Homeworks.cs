using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5__PA
{
    public class Homeworks
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Homeworks(string name, string description, string status)
        {
            Name = name;
            Description = description;
            Status = status;
        }
        public void AddHomeworks(ref List<Homeworks> homeworksList)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- Agregar Tareas ---");
            Console.ResetColor();
            Console.Write("\nIngrese el Nombre de la Tarea: ");
            string name = Console.ReadLine();
            Console.Write("\nIngrese la Descripción de la Tarea: ");
            string description = Console.ReadLine();
            do
            {
                Console.Write("\nIngrese el Estado de la Tarea (Pendiente/Completada):");
                string status = Console.ReadLine().ToUpper();
                if (status == "PENDIENTE" || status == "COMPLETADA")
                {
                    homeworksList.Add(new Homeworks(name, description, status));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tarea Agregada Correctamente");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ingrese un Estado Válido");
                    Console.ReadKey();
                }
            } while (Status == "Pendiente" || Status == "Completado");
        }
        public void ShowHomeworks(ref List<Homeworks> homeworksList)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- Mostrar Tareas---");
            Console.ResetColor();
            foreach (Homeworks homeworksPending in homeworksList)
            {
                if (homeworksPending.Status == "PENDIENTE")
                {
                    Console.WriteLine($"Nombre: {homeworksPending.Name}");
                    Console.WriteLine($"Descripción: {homeworksPending.Description}");
                    Console.WriteLine($"Estado: {homeworksPending.Status}");
                }
            }
            foreach (Homeworks homeworksComplete in homeworksList)
            {
                if (homeworksComplete.Status == "COMPLETADO")
                {
                    Console.WriteLine($"Nombre: {homeworksComplete.Name}");
                    Console.WriteLine($"Descripción: {homeworksComplete.Description}");
                    Console.WriteLine($"Estado: {homeworksComplete.Status}");
                }
            }
            Console.ReadKey();
        }

    }
}
