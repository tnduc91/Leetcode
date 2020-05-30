using System.Collections.Generic;

namespace LeetCode
{
    public class TheGreatestCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
        {
            var noOfKids = candies.Length;

            var addedCandies = new int[noOfKids];
            var result = new bool[noOfKids];
            var greatest = 0;
            
            for(int i = 0; i < noOfKids; i++)
            {
                if (greatest < candies[i]) greatest = candies[i];
                addedCandies[i] = candies[i] + extraCandies;
            }

            for(int i = 0; i < noOfKids; i++)
            {
                if (addedCandies[i] >= greatest)
                    result[i] = true;
                else
                    result[i] = false;
            }

            return result;

        }
    }
}