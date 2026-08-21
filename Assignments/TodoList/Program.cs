Console.WriteLine("Hello!");

bool shallExit = false;
List<string> todos = new();

do
{
    ShowMenu();
} while (!shallExit);

return;

// Local helper methods below
void ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    Console.Write("> ");
    
    string? userChoice = Console.ReadLine();

    switch(userChoice)
    {
        case "S":
        case "s":
            ListTodos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R": 
        case "r":
            RemoveTodo();
            break;
        case "E": 
        case "e":
            shallExit = true;
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Invalid choice.");
            break;
    }
}

void ListTodos()
{
    Console.WriteLine();
    if (todos.Count <= 0) 
        Console.WriteLine("No TODOs have been added yet.");
    else
    {
        Console.WriteLine("TODO list:");
        for (int i = 0; i < todos.Count; i++)
            Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}

void AddTodo()
{
    Console.WriteLine();
    string? description;
    
    do
    {
        Console.WriteLine("Enter the TODO description: ");
        Console.Write("> ");
        
        description = Console.ReadLine();

        if (string.IsNullOrEmpty(description))
            Console.WriteLine("The description cannot be empty.");
    } while (string.IsNullOrEmpty(description));


    if (todos.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        return;
    }

    todos.Add(description);
    Console.WriteLine();
    Console.WriteLine($"TODO successfully added: {description}");
}

void RemoveTodo()
{
    if (todos.Count <= 0)
    {
        Console.WriteLine();
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }
    
    string? userChoice;
    
    do
    {
        Console.WriteLine();
        Console.WriteLine("Select the index of the TODO you want to remove:");

        for (int i = 0; i < todos.Count; i++)
            Console.WriteLine($"{i + 1}. {todos[i]}");
        
        Console.Write("> ");
        userChoice = Console.ReadLine();

        Console.WriteLine();
        
        if (string.IsNullOrEmpty(userChoice))
            Console.WriteLine("Selected index cannot be empty.");
        else if (int.TryParse(userChoice, out int index))
        {
            index -= 1; // Normalize input to list indexes
            if (index < 0 || index >= todos.Count)
            {
                Console.WriteLine("The given index is not valid.");
                userChoice = "";
                continue;
            }

            string description = todos[index];
            todos.RemoveAt(index);
            Console.WriteLine($"TODO removed: {description}");
        }
        else
        {
            Console.WriteLine("Please enter a valid index number.");
        }
    } while (string.IsNullOrEmpty(userChoice));
}