using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1
{
    internal class STUDENT
    {
        private int id;
        private string nameofstud;
        private string group_name;
        private int math;
        private int russkyi;
        private int fhysic;
        private int biology;
        private int deuthlang;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nameofstud
        {
            get { return nameofstud; }
            set { nameofstud = value; }
        }
        public string Groupnameofstud
        {
            get { return group_name; }
            set { group_name = value; }
        }
        public int Math
        {
            get { return math; }
            set { math = value; }
        }
        public int Russkyi
        {
            get { return russkyi; }
                        set
            {
                russkyi = value;
            }
        }

        public int Fhysic
        {
            get { return fhysic; }
            set
            {
                fhysic = value;
            }
        }
        public int Biology
        {
            get { return biology; }
            set
            {
                biology = value;
            }
        }
        public int Deuthlang
        {
            get { return deuthlang; }
            set
            {
                deuthlang = value;
            }
        }

        public STUDENT()
        {
            id = 0;
            nameofstud = string.Empty;
            group_name = string.Empty;
            math = 0;
            russkyi = 0;
            fhysic = 0;
            biology = 0;
            deuthlang = 0;
            

        }

        public STUDENT( int id,string nameofstud, string group_name, int math, int russkyi, int fhysic, int biology, int deuthlang)
        {
            Id = id;
            Nameofstud = nameofstud;
            Groupnameofstud = group_name;
            Math = math;
            Russkyi= russkyi;
            Fhysic= fhysic;
            Biology= biology;
            Deuthlang = deuthlang;
            
        }

        public void OutToScreen()
        {
            Console.WriteLine($"ID:{id}");
            Console.WriteLine($"ФИО студента: {nameofstud}");
            Console.WriteLine($"Группа: {group_name}");
            Console.WriteLine($"Математика: {math}");
            Console.WriteLine($"Русский:{russkyi}");
            Console.WriteLine($"Физика: {Fhysic}");
            Console.WriteLine($"Биология: {biology}");
            Console.WriteLine($"Немецкий: {Deuthlang}");
        }
        public void InToScreen()
        {
            Console.WriteLine("ID");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("FIO");
            Nameofstud = Console.ReadLine();
            Console.WriteLine("Группа");
            Groupnameofstud = Console.ReadLine();
            Console.WriteLine("Математика");
            Math=Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Русский язык");
            Russkyi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Физика");
            Fhysic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Биология");
            Biology = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Немецкий:");
            Deuthlang = Convert.ToInt32(Console.ReadLine());
        }
        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(this.ToString());
            }
        }
    }
}
