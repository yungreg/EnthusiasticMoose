/*
*todo: initialize project 
*todo: delete boilerplate syntax
*todo: update with alternative syuntax to display required result
*todo: let da moose get loose 
*todo: help moose speak
todo:"n help mose question existence
*/


using System;

// &old phase code:
// Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
// Console.WriteLine("--------------------------------------------");
// Console.WriteLine();


void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

MooseSays("I\'m just stoked to be here!");

// &Phase 5 below

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// bool isTrue = MooseAsks("Is... anything real?");
// // &phase 6 additions

// if (isTrue)
// {
//     MooseSays("");
// }
// else
// {
//     MooseSays("I  K N E W  I T !!! *puts on tinfoil hat*");
// }

// & part 7 below 
void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is... anything real?");
    if (isTrue)
    {
        MooseSays("Really? That seems...unlikely. Where's the proof that we arent just projections of energy long past, like the way we see the light from the stars? where is the proof that time is even linear? YOU DON'T HAVE THESE ANSWERS, SWAY");
    }
    else
    {
        MooseSays("I  K N E W  I T !!! *puts on tinfoil hat*");
    }
}

void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }
}

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("I mean... it seems fine!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }
}

void SecretQuestion()
{
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseSays("I'm flattered that you think I'll keep it!");
    }
    else
    {
        MooseSays("That's probabaly not my business, is it?");
    }
}

// Ask some questions
CanadaQuestion();
EnthusiasticQuestion();
LoveCSharpQuestion();
SecretQuestion();