using System;
using System.Text.RegularExpressions;

namespace Homework_for_30._01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 
            Car car1 = new Car("Bmw", "M8", 3500, 80, 20);
            car1.AddFuel(60);
            Console.WriteLine(car1.CurrentFuel);
            #endregion


            #region Task2 

            Student[] students = new Student[3];
            string option;
            do
            {
                Console.WriteLine("1.Butun telebelere bax");
                Console.WriteLine("2.Telebeler uzre axtaris et");
                Console.WriteLine("3.Telebe elave et");
                Console.WriteLine("0.Menudan cix");

                Console.WriteLine("Secim edin");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        if (students.Length == 0)
                        {
                            Console.WriteLine("Telebe yoxdur");
                        }
                        else
                        {
                            for (int i = 0; i < students.Length; i++)
                            {
                                Console.WriteLine($"FullName : {students[i].FullName},GropuNo : {students[i].GroupNo}");

                            }
                        }
                        break;


                    case "2":
                        Console.WriteLine("Axtardiginiz telebeninin adini ve ya groupno'sunu daxil edin");
                        string GetInfo = Console.ReadLine();
                        if (students.Length == 0)
                        {
                            Console.WriteLine("Telebe yoxdur");
                        }
                        else
                        {
                            int count = 0;
                            for (int i = 0; i < students.Length; i++)
                            {
                                if (students[i].FullName.Contains(GetInfo) || students[i].GroupNo.Contains(GetInfo))
                                {
                                    Console.WriteLine($"FullName : {students[i].FullName}");
                                    count++;
                                }
                            }
                            if (count == 0)
                            {
                                Console.WriteLine("Axtardiginiz ad ve ya grupno'suna gore telebe yoxdur");
                            }
                        }
                        break;

                    case "3":
                        string fullName;
                        bool isAlright = true;
                        do
                        {
                            if (isAlright == false)
                            {
                                Console.WriteLine("Zehmet olmasa adinizin ve soyadinizin bas herflerini boyuk yazin");

                            }
                            Console.Write("Telebenin ad ve soyadini daxil edin : ");
                            fullName = Console.ReadLine();
                            isAlright = false;

                        } while (CorrectFullname(fullName) == false);
                        bool isOk = true;
                        string groupNo;
                        do
                        {
                            if (isOk == false)
                            {
                                Console.WriteLine("Uzunluq 4 olmalidir.(Qrup nomresi boyuk herfle baslamali ve 3 reqemle davam etmelidir)");
                            }
                            Console.Write("Telebenin qrup nomresini daxil edin : ");
                            groupNo = Console.ReadLine();
                            isOk = false;
                        } while (CorrectGroup(groupNo) == false);

                        Student student = new Student()
                        {
                            FullName = fullName,
                            GroupNo = groupNo
                        };

                        Array.Resize(ref students, students.Length + 1);
                        for (int i = 0; i < students.Length; i++)
                        {

                            students[students.Length - 1] = student;
                        }
                        break;


                    case "0":
                        Console.WriteLine("Menudan cixmaq isteyirsiniz? \nBeli\nXeyr");
                        var belixeyir = Console.ReadLine();
                        option = belixeyir;
                        break;

                    default:
                        Console.WriteLine("Zehmet olmasa duzgun secimi edin");
                        break;
                }


            } while (option != "Beli");
            #endregion
        }



        static bool CorrectName(string str)
        {
            if (!char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsLower(str[i]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CorrectGroup(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            if (str.Length < 5)
            {
                if (!char.IsUpper(str[0]))
                {
                    return false;
                }
                for (int i = 1; i < str.Length; i++)
                {
                    if (!char.IsDigit(str[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }



        static bool CorrectFullname(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            else
            {
                var nameAndSurname = str.Split(' ');
                var noSpaceNameAndSurname = new string[0];
                int j = 0;
                for (int i = 0; i < nameAndSurname.Length; i++)
                {
                    if (nameAndSurname[i] != "")
                    {
                        Array.Resize(ref noSpaceNameAndSurname, noSpaceNameAndSurname.Length + 1);
                        noSpaceNameAndSurname[j] = nameAndSurname[i];
                        j++;
                    }
                }
                if (noSpaceNameAndSurname.Length <= 3)
                {
                    int count = 0;
                    for (int i = 0; i < noSpaceNameAndSurname.Length; i++)
                    {
                        if (CorrectName(noSpaceNameAndSurname[i]))
                        {
                            count++;
                        }
                    }
                    if (noSpaceNameAndSurname.Length == count)
                    {
                        return true;
                    }


                    return false;

                }
                return false;
            }



        }


    }

}