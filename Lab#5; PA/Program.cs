using Lab_5__PA;

List <Homeworks> homeworksList = new List <Homeworks>();
int MenuHomeworks()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n--- Sistema de Control de Tareas ---");
    Console.ResetColor();
    Console.WriteLine("1. Agregar Tareas");
    Console.WriteLine("2. Mostrar Tareas");
    Console.WriteLine("3. Cambiar Estado");
    Console.WriteLine("4. Salir");
    Console.Write("\nIngrese una Opción: ");
    int optionMenuHomeworks = int.Parse(Console.ReadLine());
    return optionMenuHomeworks;
}