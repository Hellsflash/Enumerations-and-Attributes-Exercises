using System;

[Class("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho, Svetlio")]
public class StartUp
{
    public static void Main()
    {

        string command = Console.ReadLine();
        while (command != "END")
        {
            Type type = typeof(StartUp);
            var attributes = type.GetCustomAttributes(false);
            foreach (ClassAttribute attribute in attributes)
            {
                ExecuteCommand(command, attribute);
            }

            command = Console.ReadLine();
        }
    }

    private static void ExecuteCommand(string command, ClassAttribute attribute)
    {
        if (command == "Author")
        {
            Console.WriteLine($"Author: {attribute.Author}");
        }
        else if (command == "Revision")
        {
            Console.WriteLine($"Revision: {attribute.Revision}");
        }
        else if (command == "Description")
        {
            Console.WriteLine($"Class description: {attribute.Description}");
        }
        else if (command == "Reviewers")
        {
            Console.WriteLine($"Reviewers: {attribute.Reviewers}");
        }
    }
}