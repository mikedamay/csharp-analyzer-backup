public static class Leap
{
    public static bool NotIsLeapYear(int year) =>
        year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
}