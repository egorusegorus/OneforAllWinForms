namespace OneforAllWinForms
{
    class Berechnen
    {
        public int[] arr { get; set; }
        public int summeWert { get; set; }
        public int maxWert { get; set; }
        public int minWert { get; set; }

        public int mittWert { get; set; }



        public void summ(int[] arr)
        {
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                a += arr[i];
            }
            summeWert= a;
        }

        public void avg(int[] arr)
        {
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                a += arr[i];
            }
            a= a/arr.Length;
            mittWert=a;
        }

        public void min(int[] arr)
        {
            int a = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (a > arr[i])
                { a = arr[i]; }


            }

            minWert = a;
        }
        public void max(int[] arr)
        {
            int a = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (a <= arr[i]) a = arr[i];

            }

            maxWert= a;
        }

    }

}
