using Lab_5__PA;

bool generalContinue = true;
List <Homeworks> homeworksList = new List <Homeworks>();
while (generalContinue)
{
    try
    {
        SwitchFirsMenu();
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nERROR!, Datos Inválidos");
        Console.ResetColor();
        Console.ReadKey();
    }
}
int MenuHomeworks()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("--- Sistema de Control de Tareas ---");
    Console.ResetColor();
    Console.WriteLine("\n1. Agregar Tareas");
    Console.WriteLine("2. Mostrar Tareas");
    Console.WriteLine("3. Cambiar Estado");
    Console.WriteLine("4. Salir");
    Console.Write("\nIngrese una Opción: ");
    int optionMenuHomeworks = int.Parse(Console.ReadLine());
    return optionMenuHomeworks;
}
bool GoOut()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nUsted está Cerrando el Programa");
    Console.ResetColor();
    generalContinue = false;
    return generalContinue;
}
void SwitchFirsMenu()
{
    switch (MenuHomeworks())
    {
        case 1:
            Homeworks.AddHomeworks(ref homeworksList);
            break;
        case 2:
            Homeworks.ShowHomeworks(ref homeworksList);
            break;
        case 3:
            Homeworks.ChangeStatus(ref homeworksList);
            break;
        case 4:
            GoOut();
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nIngrese una Opción Válida (1 - 4)");
            Console.ResetColor();
            Console.ReadKey();
            break;
    }
}
