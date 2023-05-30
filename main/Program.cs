// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("sayiniz:");



// string? sayiniz = Console.ReadLine();
// int sayi ;
// try
// {
//     sayi = int.Parse(sayiniz);
// }
// catch (Exception error)
// {
//     Console.WriteLine("Hata: " + error.Message);
//     sayi=0;
// }

// finally
// {
//     Console.WriteLine("ISLEM TAMAMLANDI");
// }
// try
// {

//     int result = (sayi > 5) ? 0 : 5;
//     Console.WriteLine("result: " + result);

// }
// catch (System.Exception error)
// {

//     Console.WriteLine("Error:" + error.Message);
// }
int day = 3;
string dayName;

switch (day)
{
    case 1:
        dayName = "Monday";
        break;
    case 2:
        dayName = "Tuesday";
        break;
    case 3:
        dayName = "Wednesday";
        break;
    case 4:
        dayName = "Thursday";
        break;
    case 5:
        dayName = "Friday";
        break;
    case 6:
        dayName = "Saturday";
        break;
    case 7:
        dayName = "Sunday";
        break;
    default:
        dayName = "Invalid day";
        break;
}
Console.WriteLine("enter your month : ");
string? input = Console.ReadLine();
// int? month = input != null ? int.Parse(input) : null;
string monthName;
Console.WriteLine("The day is " + dayName);
string[] months = new string[12];
for (int month = 1; month <= 12; month++)
{
    if (month == 3)
        continue;
    switch (month)
    {
        case 1:
            monthName = "january";
            break;
        case 2:
            monthName = "Feb";
            break;
        case 3:
            monthName = "Mar";
            break;
        case 4:
            monthName = "Apr";
            break;
        case 5:
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
            monthName = "the month is between 5 and 12";
            break;
        default:
            monthName = "invalid month";
            break;
    }
    string season;
    switch (month)
    {
        case 12:
        case 1:
        case 2:
            season = "Winter";
            break;
        case 3:
        case 4:
        case 5:
            season = "Summer";
            break;
        case 6:
        case 7:
        case 8:
            season = "Spring";
            break;
        case 9:
        case 10:
        case 11:
            season = "Autumn";
            break;


        default:
            season = "invalid season";
            break;
    }

    Console.WriteLine("The month is " + month);
    Console.WriteLine("The month is " + monthName);
    Console.WriteLine("The seeason is " + season);
    months[month - 1] = monthName;

}
foreach (string month in months)
{
    Console.WriteLine(month);
}


int n = Convert.ToInt32(Console.ReadLine().Trim());
int? i = (n >= 2 && n <= 20) ? n : null;

