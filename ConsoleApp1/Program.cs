// See https://aka.ms/new-console-template for more information
DateTime date1 = DateTime.Now;
TimeZoneInfo timeZone = TimeZoneInfo.Local;
Console.WriteLine("The time is {0:t} on {0:d} {1}",
                     date1,
                     timeZone.IsDaylightSavingTime(date1) ?
                         timeZone.DaylightName : timeZone.StandardName);
Console.ReadKey();