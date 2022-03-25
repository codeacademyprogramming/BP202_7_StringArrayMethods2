using System;
using System.Text;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "  hello,  world    salam    ";

            MakeSentence(ref word);
            Console.WriteLine(word);

            //CreateWorkerObject();

            string sentence = "  Hello  world  ";

            Console.WriteLine("Fullname daxil edin:");
            string fullname = Console.ReadLine();

            Console.WriteLine(CheckFullName(fullname));

            Console.WriteLine(FindFirstWord(sentence));

            int[] nums = { 1, 2, 3, 4 };

            AddInt(ref nums, 55);

            Console.WriteLine("Nums:");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }

        static bool CheckFullName(string str)
        {
            MakeSentence(ref str);
            var arr = str.Split(' ');

            if (arr.Length == 2 && char.IsUpper(arr[0][0]) && char.IsUpper(arr[1][0]))
                return true;

            return false;
        }
        static void AddInt(ref int[] arr,int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
        }
        static void MakeSentence(ref string str)
        {
            StringBuilder strBuilder = new StringBuilder();

            str = str.Trim();
            bool lastIsSpace = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    strBuilder.Append(str[i]);
                    lastIsSpace = false;
                }
                else if (!lastIsSpace)
                {
                    strBuilder.Append(str[i]);
                    lastIsSpace = true;
                }
            }

            str = strBuilder.ToString();
        }
        static void CreateWorkerObject()
        {
            Console.WriteLine("Iscinin adini daxil edin:");
            string name = Console.ReadLine();

            Console.WriteLine("Iscinin soyadini daxil edin:");
            string surname = Console.ReadLine();

            Console.WriteLine("Iscinin saatliq maasini daxil edin:");
            string salaryStr = Console.ReadLine();
            double salary = Convert.ToDouble(salaryStr);


            Console.WriteLine("Iscinin yasini daxil edin:");
            string ageStr = Console.ReadLine();
            byte age = Convert.ToByte(ageStr);

            while (age < 18)
            {
                Console.WriteLine("ishlemek ucun minimum yashi 18 olmalidir \n Iscinin yasini yeniden daxil edin:");
                ageStr = Console.ReadLine();
                age = Convert.ToByte(ageStr);
            }

            Console.WriteLine("Iscinin ayliq is saatini daxil edin:");
            string hourStr = Console.ReadLine();
            int hour = Convert.ToInt32(hourStr);



            Worker worker1 = new Worker(salary, name, surname, age);
            worker1.MontlyHour = hour;

            Console.WriteLine(worker1.CalcSalary());
        }
        static bool CheckStr(string str)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    hasDigit = true;
                else if (char.IsUpper(str[i]))
                    hasUpper = true;
                else if (char.IsLower(str[i]))
                    hasLower = true;

                if (hasLower && hasUpper && hasDigit)
                    return true;
            }


            return false;
        }
        static string FindFirstWord(string str)
        {
            str = str.Trim();

            //var arr = str.Split(' ');
            //if (arr.Length > 0)
            //    return arr[0];


            int firstSpaceIndex = str.IndexOf(' ');
           
            if (firstSpaceIndex != -1)
                return str.Substring(0, str.IndexOf(' '));

            return str;

        }

    }
}
