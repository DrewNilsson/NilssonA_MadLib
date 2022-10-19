// Andrew Nilsson
// 09-13-2022
// Mini Challenge #5 - Mad Lib
// This is a console project that will 
// Peer Review by Kenneth Fujimura - "Awesome sauce! I really liked the implementation of an array to both hold the variables and
// ...the for loop to ask the questions."


string? loop;

string?[] inputs = new string[10];
string?[] questions = new string[10];

questions[0] = "a name.";
questions[1] = "a verb.";
questions[2] = "a location.";
questions[3] = "a color.";
questions[4] = "a car.";
questions[5] = "a celebrity.";
questions[6] = "an object.";
questions[7] = "a verb.";
questions[8] = "a size.";
questions[9] = "an object.";

bool play = true;
while (play)
{
    Console.Clear();

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Please enter " + questions[i]);
        inputs[i] = Console.ReadLine();
    }

    Console.WriteLine($"{inputs[0]} was {inputs[1]} at {inputs[2]} where they came across a {inputs[3]} {inputs[4]}. "
                    + $"Inside was {inputs[5]} who threw a {inputs[6]} at {inputs[0]} then raced off. {inputs[0]} "
                    + $"{inputs[7]} after the car but they ran into a {inputs[8]} {inputs[9]}.");

    Console.WriteLine("Would you like to try again? Yes or No");
    

    bool validInput = false;
    while (!validInput)
    {
        loop = Console.ReadLine().ToLower();

        switch (loop)
        {
            case "yes":
                validInput = true;
            break;
            case "no":
                validInput = true;
                play = false;
                Console.WriteLine("Have a great day");
            break;
            default:
                Console.WriteLine("INVALID INPUT\nEnter Yes or No");
            break;
        }
    }
}