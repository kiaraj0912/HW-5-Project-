public class LibraryMember
{
    public string MemberName { get; set; }
    public int OverdueDays;

    private static int totalFine;
    private static int memberCount = 0;

    public LibraryMember(string memberName, int overdueDays)
    {
        MemberName = memberName;
        OverdueDays = overdueDays;
        memberCount ++;

    }

    public void CalcTotalFine()
    {
        totalFine = 5 * OverdueDays;

        if (OverdueDays >= 7)
        {
            totalFine = totalFine += 10;
        }
        else if (OverdueDays < 0)
        { totalFine = 0; }

    }
    public void PrintInfo()
    {
        Console.WriteLine($"{MemberName} pays ${ totalFine} in fine total.");
        }
    public static int GetMemberCount()
        { 
        return memberCount;
    }

    }