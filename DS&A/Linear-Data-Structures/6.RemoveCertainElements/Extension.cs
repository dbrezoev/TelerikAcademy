
namespace _6.RemoveCertainElements
{
   public static class Extension
    {
        public static bool OddOrEven(this int number, int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==number)
                {
                    count++;
                }
            }
            if (count%2==0)
            {
                return false;
            }
            return true;
        }
    }
}
