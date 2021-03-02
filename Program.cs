using System;
MagicMooseAsks();
//function for Magic Moose to ask you a question
void MagicMooseAsks()
{
    //Magic Moose greets and asks
    Console.WriteLine("Hello, I'm Magic Moose \nI see you are troubled. Please, ask me anything.");
    //Read user's question
    string UserQuestion = Console.ReadLine();


    //if statement - if space is empty do this, else run Magic Moose Answer
    if (string.IsNullOrEmpty(UserQuestion))
    {
        MooseSays("Silence is the path to wisdom.");
    }
    else
    {
        MooseSays(MagicMooseAnswer());
    }
}
//Function for Magic Moose to answer
string MagicMooseAnswer()
{
    //Generate random number
    Random Number = new Random();
    int RandomNumber = Number.Next(0, 19);
    string Wisdom = "";

    //switch statements to have the random number correspond to a statement
    switch (RandomNumber)
    {
        case 0:
            Wisdom = "As I see it, yes.";
            break;
        case 1:
            Wisdom = "Ask again later.";
            break;
        case 2:
            Wisdom = "Better not tell you now.";
            break;
        case 3:
            Wisdom = "Cannot predict now.";
            break;
        case 4:
            Wisdom = "Concentrate and ask again.";
            break;
        case 5:
            Wisdom = "Don't count on it.";
            break;
        case 6:
            Wisdom = "It is certain.";
            break;
        case 7:
            Wisdom = "It is decidedly so.";
            break;
        case 8:
            Wisdom = "Most likely.";
            break;
        case 9:
            Wisdom = "My reply is no.";
            break;
        case 10:
            Wisdom = "My sources say no.";
            break;
        case 11:
            Wisdom = "Outlook not so good.";
            break;
        case 12:
            Wisdom = "Outlook good.";
            break;
        case 13:
            Wisdom = "Reply hazy, try again.";
            break;
        case 14:
            Wisdom = "All signs point to yes.";
            break;
        case 15:
            Wisdom = "Very doubtful.";
            break;
        case 16:
            Wisdom = "Without a doubt.";
            break;
        case 17:
            Wisdom = "Yes.";
            break;
        case 18:
            Wisdom = "Yes - definitely!";
            break;
        case 19:
            Wisdom = "You may rely on it.";
            break;
        case 20:
            Wisdom = "Silence is the path to wisdom";
            break;
    }
    return Wisdom;

}

void MooseSays(string Wisdom)
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
                       |   / \   |    {Wisdom}
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







// Main();
// void Main()
// {

//     Console.WriteLine("Welcome to the Magic Moose Simulator!");
//     Console.WriteLine("--------------------------------------------");
//     Console.WriteLine();
//     // Let the moose speak!
//     MooseSays("H I, I'M  A  M O O S E  O R A C L E");
//     //single function to ask all the questions
//     MooseQuestions("Are you enthusiastic?", "Yay!", "You should try it!");
//     MooseQuestions("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
//     MooseQuestions("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
//     MooseQuestions("Is Canada real", "That doesn't seem right.", "I knew it!");
// }
// void MooseQuestions(string question, string yes, string no)
// {
//     {
//         bool isTrue = MooseAsks(question);
//         if (isTrue)
//         {
//             MooseSays(yes);
//         }
//         else
//         {
//             MooseSays(no);
//         }
//     }
// }
// void MooseSays(string message)
// {
//     Console.WriteLine($@"
//                                        _.--^^^--,
//                                     .'          `\
//   .-^^^^^^-.                      .'              |
//  /          '.                   /            .-._/
// |             `.                |             |
//  \              \          .-._ |          _   \
//   `^^'-.         \_.-.     \   `          ( \__/
//         |             )     '=.       .,   \
//        /             (         \     /  \  /
//      /`               `\        |   /    `'
//      '..-`\        _.-. `\ _.__/   .=.
//           |  _    / \  '.-`    `-.'  /
//           \_/ |  |   './ _     _  \.'
//                '-'    | /       \ |
//                       |  .-. .-.  |
//                       \ / o| |o \ /
//                        |   / \   |    {message}
//                       / `^`   `^` \
//                      /             \
//                     | '._.'         \
//                     |  /             |
//                      \ |             |
//                       ||    _    _   /
//                       /|\  (_\  /_) /
//                       \ \'._  ` '_.'
//                        `^^` `^^^`
//     ");
// }
// bool MooseAsks(string question)
// {
//     Console.Write($"{question} (Y/N): ");
//     string answer = Console.ReadLine().ToLower();

//     while (answer != "y" && answer != "n")
//     {
//         Console.Write($"{question} (Y/N): ");
//         answer = Console.ReadLine().ToLower();
//     }
//     if (answer == "y")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }