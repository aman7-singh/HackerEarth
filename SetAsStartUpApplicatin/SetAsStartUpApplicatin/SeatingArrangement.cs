using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetAsStartUpApplicatin
{
    public class SeatingArrangement
    {
        public static void TestCases()
        {
            //Console.WriteLine("SeatingArrangement");
            int toatlTest = int.Parse(Console.ReadLine());
            var TestCases = new List<int>();
            for (int test = 0; test < toatlTest; test++)
            {
                TestCases.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var seatNum in TestCases)
            {
                Console.WriteLine(SeatInfo(seatNum));
            }
        }

        public static string SeatInfo(int seatNum)
        {
            if (seatNum > 0 && seatNum < 109)
            {
                int groupSize = 12;
                int group = 1 + (seatNum / groupSize);
                var seatPostion = seatNum % 12;
                if (seatPostion == 0)
                {
                    group -= 1;
                }
                var oppSeatSumm = (1 + groupSize) + (24 * (group - 1));

                var oppositeSeatNumber = oppSeatSumm - seatNum;
                var seatLocation = string.Empty;
                if (seatPostion == 1 || seatPostion == 6 || seatPostion == 7 || seatPostion == 0)
                {
                    seatLocation = "WS";
                }
                else if (seatPostion == 2 || seatPostion == 5 || seatPostion == 8 || seatPostion == 11)
                {
                    seatLocation = "MS";
                }
                else if (seatPostion == 3 || seatPostion == 4 || seatPostion == 9 || seatPostion == 10)
                {
                    seatLocation = "AS";
                }
                return $"{oppositeSeatNumber} {seatLocation}";
            }
            return string.Empty;
        }
    }
}
