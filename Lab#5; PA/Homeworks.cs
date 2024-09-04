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
        public Homeworks(string name, string description)
        {
            Name = name;
            Description = description;
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
            homeworksList.Add(new Homeworks(name, description));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tarea Agregada Correctamente");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
