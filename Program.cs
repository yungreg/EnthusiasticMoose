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

bool isTrue = MooseAsks("Is... anything real?");
// &phase 6 additions

if (isTrue)
{
    MooseSays("Really? That seems...unlikely. Where's the proof that we arent just projections of energy long past, like the way we see the light from the stars? where is the proof that time is even linear? YOU DON'T HAVE THESE ANSWERS, SWAY");
}
else
{
    MooseSays("I  K N E W  I T !!! *puts on tinfoil hat*");
}