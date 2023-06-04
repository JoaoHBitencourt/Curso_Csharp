namespace Dependencias
{
     class Calculator
    {
        public static int Sum(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        public static void TripleOut(int origin, out int result)
        {
            result = origin * 3;
        }

        public static void TripleRef(ref int x)
        {
            x = x * 3;
        }
    }
}
