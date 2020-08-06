using System;

namespace Proffy.ApplicationService.Utils
{
    public class ConvertHours
    {
        public static int ToMinute(string time)
        {
            var trim = time.Split(':');
           return(Convert.ToInt32(trim[0]) * 60) + Convert.ToInt32(trim[1]);
        }
    }
}
