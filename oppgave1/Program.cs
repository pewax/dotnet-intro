﻿using FellesEntiteter;

namespace oppgave1;

class Program
{
    static List<Person> allePersoner;

    static void Main(string[] args)
    {
        allePersoner = HentAllePersoner();
        var brukerId = "1";
        var tester123 = "12312312312"

        var person = HentPersonMedId(brukerId);
        // Skal printe ut
        // "Roy Roysen har personId 1"
        Console.WriteLine(person.ToString());
    }


    private static Person HentPersonMedId(string id)
    {
        // TODO: implementer denne ved å filtrere listen allePersoner med bruk av .Where og .First
        return ????
    }


    private static List<Person> HentAllePersoner()
    {
        return new List<Person>()
            {
                new Person()
                {
                    Id = "1",
                    Fornavn = "Roy",
                    Etternavn = "Roysen"
                },
                new Person()
                {
                    Id = "2",
                    Fornavn = "Ingrid",
                    Etternavn = "Ingridsen"
                }
            };
    }
}