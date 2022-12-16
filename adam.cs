namespace AdamProject
{
    class Adam
    {
        private string[] files;
        public Adam(string path="adam.in")
        {
            files = File.ReadAllLines(path);
        }
        public void AllAdamSteps()
        {
            
            foreach (string file in files) {
                string[] f = file.Split('D');
                int result = Convert.ToInt32(f[0].Length);
                Console.WriteLine(result);
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A program that calculate the number of steps \n" +
                "Adam took before he fell for the first time!");
            Adam adam = new Adam();
            adam.AllAdamSteps();
            Console.ReadKey();
        }
    }
}
