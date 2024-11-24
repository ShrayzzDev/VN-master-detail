﻿
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

while (choice != "99")
{
    Console.WriteLine("Choose: ");
    Console.WriteLine("1. GetGameById");
    Console.WriteLine("2. GetNovelByOrder");
    Console.WriteLine("3. GetNovelsForUser");
    Console.WriteLine("4. GetDetailedNovel");
    Console.WriteLine("5. GetNovelsByOrderWithName");
    Console.WriteLine("6. Login");
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
            var key = Console.ReadLine();
            Console.WriteLine(key);
            var login = await uRequestor.Login(key ?? string.Empty);
            Console.WriteLine(login?.ToString());
            break;


        case "99":
            Console.WriteLine("Exiting . . .");
            break;

        default:
            Console.WriteLine("ERROR: Please retry.");
            break;
    }
}