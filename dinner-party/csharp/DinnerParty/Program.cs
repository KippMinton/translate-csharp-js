using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Dinner Party!");
Console.WriteLine("-------------");

List<Guest> guests = GetGuests();
Table table1 = MakeTable1(guests);
Table table2 = MakeTable2(guests);

DisplayTable(table1);
Console.WriteLine();
DisplayTable(table2);


void DisplayTable(Table table)
{
    Console.WriteLine(table.Title);
    foreach (Guest guest in table.GuestList)
    {
        Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
    }
}

Table MakeTable1(List<Guest> guests)
{
    Table table1 = new Table();
    table1.Title = "Table 1";
    table1.GuestList = new List<Guest>();
    
    foreach (Guest guest in guests)
    {
        List<string> Table1Occupations = table1.GuestList.Select(guest => guest.Occupation).ToList();
        if (!Table1Occupations.Contains(guest.Occupation))
        {
            table1.GuestList.Add(guest);
        }
    }

    return table1;
}

Table MakeTable2(List<Guest> guests)
{
    Table table2 = new Table();
    table2.Title = "Table 2";
    table2.GuestList = new List<Guest>();

    foreach (Guest guest in guests)
    {
        if (!table1.GuestList.Contains(guest))
        {
            table2.GuestList.Add(guest);
        }
    }

    return table2;
}


List<Guest> GetGuests()
{
    List<Guest> guests = new List<Guest>() {
        new Guest() {
            Name = "Marilyn Monroe",
            Occupation = "entertainer",
            Bio = "(1926 - 1962) American actress, singer, model"
        },
        new Guest() {
            Name = "Abraham Lincoln",
            Occupation = "politician",
            Bio = "(1809 - 1865) US President during American civil war"
        },
        new Guest() {
            Name = "Martin Luther King",
            Occupation = "activist",
            Bio = "(1929 - 1968)  American civil rights campaigner"
        },
        new Guest() {
            Name = "Rosa Parks",
            Occupation = "activist",
            Bio = "(1913 - 2005)  American civil rights activist"
        },
        new Guest() {
            Name = "Peter Sellers",
            Occupation = "entertainer",
            Bio = "(1925 - 1980) British actor and comedian"
        },
        new Guest() {
            Name = "Alan Turing",
            Occupation = "computer scientist",
            Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
        },
        new Guest() {
            Name = "Admiral Grace Hopper",
            Occupation = "computer scientist",
            Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
        },
        new Guest() {
            Name = "Indira Gandhi",
            Occupation = "politician",
            Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
        }
    };
    
    return guests;
}


public class Guest
{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public string Bio { get; set; }
}

public class Table
{
    public string Title { get; set; }
    public List<Guest> GuestList { get; set; }
}