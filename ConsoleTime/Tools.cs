namespace ConsoleTime
{
    internal class Tools
    {
        #region Udskrivning;
        private static int counter = 0;
        public static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            while (counter < array.Length)
            {
                Console.WriteLine(array[counter]);
                counter++;

            }
            return;

        }
        #endregion
    }
}
