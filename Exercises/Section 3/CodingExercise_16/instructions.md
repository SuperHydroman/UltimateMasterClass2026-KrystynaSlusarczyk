## The Triangle class
Implement the **Triangle** class according to the requirements:

1. It should contain private fields of integer type representing **base** and **height** 
2. They should be set via the constructor (**base** should be the first parameter, **height** should be the second)
3. *It should contain a **public CalculateArea** method, returning the area according to the following formula: **((base * height) / 2)**
4. It should contain a **public AsString** method, which returns a string following this pattern: **"Base is B, height is H"**, where B and H should be switched to values of base and height. So, for example, it could be "Base is 10, height is 5".

**IMPORTANT:** "base" is a reserved keyword in C#, so having a constructor parameter named "base" will not work. We learned how to bypass it in the "Naming variables & introduction to clean code" lecture.

*The area of a triangle can be a fraction of a number. For example, a triangle of base 1 and height 3 has an area equal to 1.5. We haven't learned about numeric type representing fractions yet, so just use the formula  ((Base * Height) / 2). It will trim the result to a whole number, but it is fine for now.