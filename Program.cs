namespace BiggestSmallestNum
{
    public class Program
    {
        public static int Big(int[] arr)         //method to find biggest element in array
        {
            int big = arr[0];
            for (int i = 0; i < arr.Length; i++)       // getting elements array
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > big)
                {
                    big = arr[i];
                } 
            }
            return big;
        }
        public static int Small(int[] arr)     //method to find small element in array
        {
            int small = arr[0];
            for (int i = 0; i < arr.Length; i++)    // getting array elements
            {
                if (arr[i] < small)
                {
                    small = arr[i];
                }
              
            }return small;
        }
        static void Main(string[] args) //main method 
        {
            Console.WriteLine("enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int bigvalue = Big(arr);
            Console.WriteLine("biggest value is:"+bigvalue);
            int smallvalue = Small(arr);
            Console.WriteLine("smallest value is:"+smallvalue);

        }
    }
}
