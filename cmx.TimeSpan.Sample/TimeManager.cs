namespace cmx.TimeSpan.Sample
{
    public class TimeManager
    {
        public bool CheckTimeSpan(System.TimeSpan now)
        {
            var start = System.TimeSpan.Parse("20:00"); // 10 PM
            var end = System.TimeSpan.Parse("08:00"); // 2 AM

            if (start <= end)
            {
                // start and stop times are in the same day
                if (now >= start && now <= end)
                {
                    // current time is between start and stop
                    return true;
                }
            }
            else
            {
                // start and stop times are in different days
                if (now >= start || now <= end)
                {
                    // current time is between start and stop
                    return true;
                }
            }

            return false;
        }
    }
}