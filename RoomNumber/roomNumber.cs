using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomNumber
{
    public class roomNumber
    {        
        public int numberOfSets(int roomNumber)
        {
            int[] digitCount = new int[10];
            //int maxCount = 0;
            int sixNineCount = 0;

            //loop through each digit of the number
            while (roomNumber > 0)
            {
                int digit = roomNumber % 10;
                if(digit == 6 || digit == 9)
                {
                    sixNineCount++;
                }
                else
                {
                    digitCount[digit]++;
                }
                roomNumber /= 10;
            }
            
            // get the maximum count of other digits
            int maxOtherCount = digitCount.Max();
            // get the maximum count of 6 and 9 digits
            int maxSixNineCount = (sixNineCount + 1) / 2;

            return Math.Max(maxOtherCount, maxSixNineCount);
        }
        

    }
}
