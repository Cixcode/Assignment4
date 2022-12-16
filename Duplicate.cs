/*This is a code to get number of duplicate files and get the one that 
 * was created first and get it sorted out*/

namespace DuplicateFilesProject
{
    public class Duplicate
    {
        //files is specify as private variable so that it wont be change outside
        private string[] files;
        //This is my constructor
        public Duplicate(string path="files.txt")
        {
            files = File.ReadAllLines(path);
        }
        public void FindDuplicate()
         /*I introduced a counter to loop through the value and check when the files are read and incremented
         The first case is reading through the files to be checked
         Then it moves to the next line and check the number of string and break when there is a space, it save the integer
         It moves to the next line and gives comparison between the two.
         In the case of the first and second example which comprises of "aaa 6 and aa 5", it gives back the integer value
           of both because they are incomparable and in their lowest state and the only file in there
           Then it goes through to the other files to be considered*/

        {
            int counter = 0;
            int all_count = Convert.ToInt32(files[counter]);
            counter ++;
            for (int i = 0; i < all_count; i++)
            {
                int counts_files = Convert.ToInt32(files[counter]);
                counter++;
                string file_name = "";
                int[] ids = {};
                for (int j= 0; j<counts_files; j++)
                {
                    string[] file = files[counter].Split(' ');
                    if (file[0] == file_name)
                    {
                        if (ids.Length == 0)
                        {
                            file_name= file[0];
                            ids = ids.Append(Convert.ToInt32(file[1])).ToArray();
                        }
                        else if (ids[ids.Length - 1] > Convert.ToInt32(file[1]))
                        {
                            ids[ids.Length - 1] = Convert.ToInt32(file[1]);
                        }
                    }
                    else
                    {
                        file_name = file[0];
                        ids = ids.Append(Convert.ToInt32(file[1])).ToArray();
                    }
                    counter++;
                }
                Array.Sort(ids);
                foreach (int id in ids)
                {
                    Console.Write("{0} ", id);
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }



    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("A program that reads and delete extra duplicate files");
            Duplicate df = new Duplicate();
            df.FindDuplicate();
        }
    }


}
