/*
*todo: initialize project 
*todo: delete boilerplate syntax
*todo: update with alternative syuntax to display required result
*todo: let da moose get loose 
*todo: help moose speak
*todo: help moose question existence
*todo: phase 5
*todo: phase 6
*todo: phase 7
*todo: phase 8
*todo: phase 9
todo: make moose MAGICAL
todo: make array of objects for the iundex position selection 
*/


using System;

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



//^ Phase 5 below

// bool MooseAsks(string question)
// {
//     Console.Write($"{question} (Y/N): ");
//     string answer = Console.ReadLine().ToLower();

//     while (answer != "y" && answer != "n")
//     {
//         Console.Write($"{question} (Y/N): ");
//         answer = Console.ReadLine().ToLower();
//     }
//     //? can you make the answer equal a data type?
//     if (answer == "any wis")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

//^ part 7 below 


//^ phase8 & phase 9 accidentally
Main();

void Main()
{
    // Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    MooseSays("Howdy! I am the GREAT MAGIC MOOSE!");
    bool isActive = true;
    while (isActive)
    {
        MooseSays("What wish can I grant?");
        Console.Write("Input your wish here:");
        string UserAnswer = Console.ReadLine();
        if (UserAnswer == "")
        {
            isActive = false;
            return; //^this should end the program on blank entry
        }
        else
        {
            QuestionResponse(UserAnswer);
        }
    }

    // CanadaAnswer();
}

void QuestionResponse(string question)
{
    string[] answers = { "As I see it, yes", "Ask again later", "Better not tell you now", "Cannot predict now", "Concentrate and ask again", "Don't count on it", "It is certain", "It is decidedly so" };
    Random r = new Random();
    int selectNum = r.Next(0, answers.Length);
    string answer = answers[selectNum];
    MooseSays(answer);
}


//^ seasborns answer: 
// void Main()
// {

//     Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
//     Console.WriteLine("--------------------------------------------");
//     Console.WriteLine();
//     bool isActive = true;
//     while(isActive) {
//     // Let the moose speak!
//         MooseSays("Please ask a question: ");
//         string userQuestion = Console.ReadLine();
//         if(userQuestion == "") {
//             isActive = false;
//             return;
//         }
//         questionResponse(userQuestion);



//     }

// }

// void questionResponse(string question) {
//     string[] answers = {"As I see it, yes", "Ask again later", "Better not tell you now", "Cannot predict now", "Concentrate and ask again", "Don't count on it", "It is certain", "It is decidedly so"};
//     Random r = new Random();
//     int selectNum = r.Next(0, answers.Length);
//     string answer = answers[selectNum];
//     MooseSays(answer);
// }
