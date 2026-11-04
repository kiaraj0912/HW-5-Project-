public class Program
{
    public static void Main()
    {
        LibraryMember member1 = new LibraryMember("Emma", 4);
        LibraryMember member2 = new LibraryMember("James", 10);
        member1.CalcTotalFine();
        member2.CalcTotalFine();
        member1.PrintInfo();
        member2.PrintInfo();

        Console.WriteLine(LibraryMember.GetMemberCount());
    }
    }

