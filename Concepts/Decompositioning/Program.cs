using Decompositioning;
using Decompositioning.Exercise_8;

var exercises = new List<Exercise>
{
    new Exercise_1(),
    new Exercise_2(),
    new Exercise_3(),
    new Exercise_3_CorrectSolution(),
    new Exercise_4(),
    new Exercise_5(),
    new Exercise_6(),
    new Exercise_7(),
    new Exercise_8(),
};

foreach (Exercise exercise in exercises)
{
    exercise.Run();
}

Console.ReadKey();