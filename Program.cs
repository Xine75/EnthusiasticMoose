using System;

Main();

void Main()
{

    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();


    // Let the moose speak!
    MooseSays("H I, I'M  A  L I T T L E  D U M B");
    MooseSays("But I'm really kind, and I like your lipstick!");

    // Ask a question
    // CanadaQuestion();
    // EnthusiasticQuestion();
    // LoveCSharpQuestion();
    // SecretQuestion();

    //single function to ask all the questions

    MooseQuestions("Are you enthusiastic?", "Yay!", "You should try it!");
    MooseQuestions("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
    MooseQuestions("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
    MooseQuestions("Is Canada real", "That doesn't seem right.", "I knew it!");


}

void MooseQuestions(string question, string yes, string no)
{

    {
        bool isTrue = MooseAsks(question);
        if (isTrue)
        {
            MooseSays(yes);
        }
        else
        {
            MooseSays(no);
        }
    }
}

// {
//     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
//     if (isEnthusiastic)
//     {
//         MooseSays("Yay!");
//     }
//     else
//     {
//         MooseSays("You should try it!");
//     }
// }


// {
//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     if (doesLoveCSharp)
//     {
//         MooseSays("Good job sucking up to your instructor!");
//     }
//     else
//     {
//         MooseSays("You will...oh, yes, you will...");
//     }
// }

// {
//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     if (wantsSecret)
//     {
//         MooseSays("ME TOO!!!! I love secrets...tell me one!");
//     }
//     else
//     {
//         MooseSays("Oh, no...secrets are the best, I love to share them!");
//     }
// }



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