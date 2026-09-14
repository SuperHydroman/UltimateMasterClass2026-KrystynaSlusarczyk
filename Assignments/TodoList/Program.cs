Console.WriteLine("Hello!");

bool shallExit = false;
List<string> todos = new();
const string userInputPrefix = "> ";

do
{
    ShowMenu();
    ExecuteMenuChoice();
} while (!shallExit);

// Local helper methods below
void ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    Console.Write(userInputPrefix);
}

void ExecuteMenuChoice()
{
    string? userChoice = Console.ReadLine();

    switch(userChoice?.Trim()?.ToUpperInvariant())
    {
        case "S":
            ListTodos();
            break;
        case "A":
            AddTodo();
            break;
        case "R":
            RemoveTodo();
            break;
        case "E":
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
    if (todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }
    
    Console.WriteLine("TODO list:");
    for (int i = 0; i < todos.Count; i++)
        Console.WriteLine($"{i + 1}. {todos[i]}");
}

void AddTodo()
{
    string? description;
    do
    {
        Console.WriteLine();
        Console.WriteLine("Enter the TODO description:");
        Console.Write(userInputPrefix);

        description = Console.ReadLine()?.Trim();
    } while (!IsDescriptionValid(description));
    
    todos.Add(description);
    Console.WriteLine();
    Console.WriteLine($"TODO successfully added: {description}");
}

void RemoveTodo()
{
    if (todos.Count == 0)
    {
        Console.WriteLine();
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    int index;
    do
    {
        Console.WriteLine();
        Console.WriteLine("Select the index of the TODO you want to remove:");

        ListTodos();
        
        Console.Write(userInputPrefix);
    } while (!TryReadIndex(out index)) ;
    
    string description = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine($"TODO removed: {description}");
}

bool TryReadIndex(out int index)
{
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out index))
    {
        Console.WriteLine("Please enter a valid number.");
        return false;
    }

    index -= 1; // Normalize input to list indexes
    if (index >= 0 && index < todos.Count)
        return true;
    
    Console.WriteLine("The given index is not valid.");
    return false;

}

bool IsDescriptionValid(string description)
{
    if (string.IsNullOrEmpty(description))
    {
        Console.WriteLine("The description cannot be empty.");
        return false;
    }
        
    if (todos.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        return false;
    }

    return true;
}