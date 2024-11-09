
using APIRequestor;
using DTO;
using DTO.Novel;
using Interfaces;
using Stub;
using Utils;

INovelRequestor nRequestor = new NovelApiRequestor();

string? choice = "";
string? value;

while (choice != "99")
{
    Console.WriteLine("Choose: ");
    Console.WriteLine("1. GetGameById");
    Console.WriteLine("");
    Console.WriteLine("99. Close");
    Console.WriteLine("----------------------");
    choice = Console.ReadLine();
    switch(choice)
    {
        case "1":
            Console.WriteLine("Which game ? (whithout starting v) ");
            value = "v" + Console.ReadLine();
            var idGame = await nRequestor.GetNovelById(value);
            if (idGame is not null)
            {
                Console.WriteLine(idGame.ToString());
            }
            break;

        case "2":
            var novels = await nRequestor.GetNovelByOrder(1, 10, Criteria.Stars);
            novels?.ToString();
            break;

        case "99":
            Console.WriteLine("Exiting . . .");
            break;

        default:
            Console.WriteLine("ERROR: Please retry.");
            break;
    }
}