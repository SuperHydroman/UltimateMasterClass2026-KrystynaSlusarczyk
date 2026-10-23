// var pizza = new Pizza();
// pizza.AddIngredient(new Mozerella());
// pizza.AddIngredient(new Cheddar());
// pizza.AddIngredient(new TomatoSauce());
//
// Console.WriteLine(pizza.Describe());

// Console.WriteLine("Variable of type Cheddar");
//
// Cheddar cheddar = new Cheddar();
// Console.WriteLine(cheddar.Name);
//
// Console.WriteLine("Variable of type Ingredient");
// Ingredient ingredient = new Cheddar();
// Console.WriteLine(ingredient.Name);
    
var ingredients = new List<Ingredient>
{
    new Cheddar(),
    new Mozerella(),
    new TomatoSauce()
};

foreach (var ingredient in ingredients)
{
    Console.WriteLine(ingredient.Name);
}

Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    
    public void AddIngredient(Ingredient ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public string Describe() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}.";
}

public class Ingredient
{
    public virtual string Name { get; } = "Some ingredient";
}

public class Cheddar : Ingredient
{
    public override string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
    public string Name => "Tomato Sauce";
    public int TomatosIn100Grams { get; }
}

public class Mozerella : Ingredient
{
    public override string Name => "Mozerella";
    public bool IsLight { get; }
}