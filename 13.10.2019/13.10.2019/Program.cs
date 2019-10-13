using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;


namespace _13._10._2019
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;

            //string path = @"badtext.txt";
            //string newpath = @"normtext.txt";

            //StreamReader reader = new StreamReader(path);
            //StreamWriter writer = File.CreateText(newpath);

            //string[] words = reader.ReadToEnd().Split(' ');
            //string[] badwords = { "заеб", "заєб", "дурн", "долбо", "сук", "сучк", "бля", "хуй", "хєр", "хер" };
            //bool writed;
            //string tmp;

            //foreach(string word in words)
            //{

            //    writed = false;

            //    Console.WriteLine(word);

            //    foreach (string bad in badwords)
            //    {
            //        if(word.Contains(bad))
            //        {
            //            tmp = "";

            //            writer.Write(new string('*', word.Length) + " ");
            //            writed = true;
            //        }
            //    }

            //    if(!writed)
            //    {
            //        writer.Write(word + " ");
            //    }
            //}

            //writer.Close();



            //string path = @"text.txt";
            //string newpath = @"newline.txt";

            //StreamReader reader = new StreamReader(path);
            //StreamWriter writer = File.CreateText(newpath);

            //string[] words = reader.ReadToEnd().Split(' ');
            //string tmp;

            //foreach (string word in words)
            //{

            //     tmp = Convert.ToString(Char.ToUpper(word[0])) + word.Substring(1) + ".";
            //     Console.WriteLine(tmp);

            //     writer.WriteLine(tmp);

            //}

            //writer.Close();



            //string path = @"numbers.txt";

            //StreamReader reader = new StreamReader(path);

            //string[] words = reader.ReadToEnd().Split(' ');

            //List<int> numbers = new List<int>();

            //Regex re = new Regex(@"^[0-9]+$");

            //foreach (string word in words)
            //{
            //    if(re.IsMatch(word))
            //    {
            //        numbers.Add(Convert.ToInt32(word));
            //    }
            //}

            //Console.WriteLine(string.Join(" ", numbers));


            //string text = @"
            //1.3333
            //33 dlsklkfddf 3,33
            //sdf
            //af
            //fsdfdsfsadf 0,22
            //";

            //Regex re = new Regex(@"[0-9]{1,}(,|.)[0-9]{1,}");

            //foreach (Match word in re.Matches(text))
            //{
            //    Console.WriteLine(word);
            //}



            //string text = @"
            //1.3333
            //33 dlsklkfddf 3,33
            //sdf
            //af
            //fsdfdsfsadf 0,22
            //";

            //Regex re = new Regex(@"[0-9]{1,}(,|.)[0-9]{1,}");

            //foreach (Match word in re.Matches(text))
            //{
            //    Console.WriteLine(word);
            //}



            //string text = @"
            //1.3333
            //2001/05/23 20:12:22
            //sdf
            //fsdfds 
            //2002/01/30 21:19
            //fsdfdsfsadf 0,22
            //";

            //Regex re = new Regex(@"([0-9]{4}\/[0-9]{2}\/[0-9]{2}\s[0-9]{2}:[0-9]{2})((:[0-9]{2})?)");

            //foreach (Match word in re.Matches(text))
            //{
            //    Console.WriteLine(word);
            //}




            //string text = @"
            //1.3333
            //2001/05/23 20:12:22
            //sdf
            //1234555567
            //fsdfds 
            //    0234555567
            //2002/01/30 21:19
            //fsdfdsfsadf 0,22
            //";

            //Regex re = new Regex(@"[0][0-9]{9}");

            //foreach (Match word in re.Matches(text))
            //{
            //    Console.WriteLine(Int64.Parse(word.Value).ToString("+38 (000) 000-00-00"));
            //}

        }
    }
}