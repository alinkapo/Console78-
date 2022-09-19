namespace Console78
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string a in myReturn())
            Console.WriteLine(a);

            int[] age = {18};
           
           foreach (int z in age)
                Console.WriteLine(z);
        }
         
       static Array myReturn()
        {
           foreach (string b in Return())
                Console.WriteLine(b);
            string[] city = {"Samara"};
            return city;
        }
        
        static Array Return()
        {
            string[] fio = {"Положай Алина Андреевна"};
            return fio;
        }
    }
}