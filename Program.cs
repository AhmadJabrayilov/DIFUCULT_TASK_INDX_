using Intf_Indx_Excp.Models;
using System;

namespace Intf_Indx_Excp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = null;
            string groupno;
            int studentLimit;


            Console.WriteLine("Input Fullname");
            string usFname = Console.ReadLine();

            Console.WriteLine("input Email");
            string usEmail = Console.ReadLine();
        
            User user1 = new User(usFname,usEmail);


            


            Console.WriteLine("select");
            Console.WriteLine("1. Show info");
            Console.WriteLine("2. Create new group");
            
            int select =  int.Parse(Console.ReadLine());
            switch (select)
            {
                case  1:
                    user1.ShowInfo();
                    break;
                case 2:
                    {
                    Console.WriteLine("Create new group");
                        do
                        {
                            Console.WriteLine("input group no");
                            groupno = Console.ReadLine();

                            Console.WriteLine("input student limit ");
                            studentLimit = int.Parse(Console.ReadLine());

                            Group group1 = new Group(groupno, studentLimit);
                            
                        } while (CheckGroupNo(groupno) );

                    break;
                    }
                  
                

                default:
                    break;
            }


        }

        public static bool CheckGroupNo(string groupNo)
        {
            bool hasNumber = false;

            bool hasUpper = false;

            foreach (char item in groupNo)
            {
                if (char.IsNumber(item))
                {
                    hasNumber = true;
                }
                if (char.IsUpper(item))
                {
                    hasUpper = true;
                }
            }

            return true;
        }

        
    }
}
