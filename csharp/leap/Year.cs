internal class Year
{
    public static bool IsLeap(int year)
    {
        int evenBy4 = year%4;
        int evenBy100 = year % 100;
        int evenBy400 = year%400;

        if (evenBy400 == 0 && evenBy100 == 0)
        {
            return true;
        }
        else if (evenBy100 == 0)
        {
            return false;
        }
        else if (evenBy4 != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}