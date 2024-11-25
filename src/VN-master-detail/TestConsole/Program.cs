
using APIRequestor;
using DTO;
using DTO.Novel;
using Interfaces;
using Stub;
using Utils;

INovelRequestor nRequestor = new NovelApiRequestor();
IUserRequestor uRequestor = new UserApiRequestor();

string? choice = "";
string? value;
string key = "";
string novelId = string.Empty;

while (choice != "99")
{
    Console.WriteLine("Choose: ");
    Console.WriteLine("1. GetGameById");
    Console.WriteLine("2. GetNovelByOrder");
    Console.WriteLine("3. GetNovelsForUser");
    Console.WriteLine("4. GetDetailedNovel");
    Console.WriteLine("5. GetNovelsByOrderWithName");
    Console.WriteLine("6. Login");
    Console.WriteLine("7. AddNovelToUser");
    Console.WriteLine("8. DeleteNovelFromUser");
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
            Console.WriteLine(novels?.ToString());
            break;

        case "3":
            var userNovels = await nRequestor.GetNovelForUser(1, 10, "u287204");
            Console.WriteLine(userNovels?.ToString());
            break;

        case "4":
            Console.WriteLine("Which game ? (whithout starting v) ");
            value = "v" + Console.ReadLine();
            var novel = await nRequestor.GetDetailedNovelById(value);
            if (novel is not null)
            {
                Console.WriteLine(novel.ToString());
            }
            else
            {
                Console.WriteLine("wrog !");
            }
            break;

        case "5":
            var novelsWithName = await nRequestor.GetNovelByOrder(1, 10, Criteria.Name, "katawa");
            Console.WriteLine(novelsWithName?.ToString());
            break;

        case "6":
            Console.WriteLine("Enter your API Token");
            key = Console.ReadLine();
            Console.WriteLine(key);
            var login = await uRequestor.Login(key ?? string.Empty);
            Console.WriteLine(login?.ToString());
            break;

        case "7":
            Console.WriteLine("Enter your API Token");
            key  = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Which novel ? (without v)");
            novelId = "v" + Console.ReadLine();
            Console.WriteLine(novelId);
            if (await nRequestor.AddNovelToUserList(novelId, key))
                Console.WriteLine("Added !");
            else
                Console.WriteLine("Problem !");
            break;

        case "8":
            Console.WriteLine("Enter your API Token");
            key = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Which novel ? (without v)");
            novelId = "v" + Console.ReadLine();
            Console.WriteLine(novelId);
            if (await nRequestor.DeleteNovelFromUser(novelId, key))
                Console.WriteLine("Deleted !");
            else
                Console.WriteLine("Problem !");
            break;

        case "99":
            Console.WriteLine("Exiting . . .");
            break;

        default:
            Console.WriteLine("ERROR: Please retry.");
            break;
    }
}