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
        public static void AddHomeworks(ref List<Homeworks> homeworksList)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- Agregar Tareas ---");
            Console.ResetColor();
            Console.Write("\nIngrese el Nombre de la Tarea: ");
            string name = Console.ReadLine();
            Homeworks homework = homeworksList.Find(x => x.Name == name);
            if (homework == null)
            {
                Console.Write("\nIngrese la Descripción de la Tarea: ");
                string description = Console.ReadLine();
                Console.Write("\nIngrese el Estado de la Tarea (Pendiente/Completado):");
                string status = Console.ReadLine().ToUpper();
                if (status == "PENDIENTE" || status == "COMPLETADO")
                {
                    homeworksList.Add(new Homeworks(name, description, status));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nTarea Agregada Correctamente");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nIngrese un Estado Válido");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTarea con el Mismo Nombre");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
        public static void ShowHomeworks(ref List<Homeworks> homeworksList)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- Mostrar Tareas ---");
            Console.ResetColor();
            foreach (Homeworks homeworksPending in homeworksList)
            {
                if (homeworksPending.Status == "PENDIENTE")
                {
                    Console.WriteLine($"\nNombre: {homeworksPending.Name}");
                    Console.WriteLine($"Descripción: {homeworksPending.Description}");
                    Console.WriteLine($"Estado: {homeworksPending.Status}");
                }
            }
            foreach (Homeworks homeworksComplete in homeworksList)
            {
                if (homeworksComplete.Status == "COMPLETADO")
                {
                    Console.WriteLine($"\nNombre: {homeworksComplete.Name}");
                    Console.WriteLine($"Descripción: {homeworksComplete.Description}");
                    Console.WriteLine($"Estado: {homeworksComplete.Status}");
                }
            }
            Console.ReadKey();
        }
        public static void ChangeStatus(ref List<Homeworks> homeworksList)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- Cambiar Estado ---");
            Console.ResetColor();
            Console.Write("\nIngrese el Nombre de la Tarea: ");
            string name = Console.ReadLine();
            Homeworks homework = homeworksList.Find(x => x.Name == name);
            if (homework != null)
            {
                if (homework.Status == "PENDIENTE")
                {
                    homework.Status = "COMPLETADO";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nEstado Actualizado Correctamente");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                else if (homework.Status == "COMPLETADO")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nTarea Completada");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTarea Inexistente");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}
