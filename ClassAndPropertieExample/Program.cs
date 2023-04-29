namespace ClassAndPropertieExample;
class Program
{
    static List<User> userList = new List<User>();
    static void Main(string[] args)
    {
        bool status = true;
        while (status)
        {

            Console.WriteLine("------------- User Procces Menu-------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("---------------SelectProccess---------------");
            Console.WriteLine("1. Add User (1)");
            Console.WriteLine("2. User List (2)");
            Console.WriteLine("Select Proccess:");
            char selectProccess = Convert.ToChar(Console.ReadLine().Substring(0, 1));
            Console.Clear();
            switch (selectProccess)
            {
                case '1':
                    userList.Add(addUser());
                    break;
                case '2':
                    List();
                    break;
                case '3':
                    string dot = ".";
                    string exitProgram = "Program Kapatılıyor";
                    for (int i = 0;i< 10;i++)
                    {
                        exitProgram += dot;
                        Console.WriteLine("Program Kapatılıyor");
                        Thread.Sleep(400);
                        Console.Clear();
                    }
                    
                    status = false;

                    break;
                default:
                    Console.WriteLine("Tanımsız giriş");
                    break;
            }
            //foreach (var item in userList)
            //{
            //    Console.WriteLine("Name: "+item.Name);
            //}
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Devam Etmek için bir tuşa basınız");
            Console.ReadKey();

        }
        }
        public static User addUser()
        {
            User user = new User();
            Console.Clear();
            Console.WriteLine("------------- Add User Proccess-------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Name:   "); user.Name = Console.ReadLine();
            Console.WriteLine("Surname:   "); user.Surname = Console.ReadLine();
            Console.WriteLine("Email:   "); user.Email = Console.ReadLine();
            Console.WriteLine("Password:   "); user.password = Console.ReadLine();
            Console.WriteLine("Age:   "); user.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gender (F)(M):   "); user.Gander = Console.ReadLine().ToUpper() == "F" ? "Female" : "Male";
            return user;
        }
        public static void List()
        {

            Console.WriteLine("------------- User List---------------------");
            Console.WriteLine("--------------------------------------------");
            int i = 0;
            foreach (var item in userList)
            {
                Console.WriteLine((i++) + "Name:  " + item.Name);
            }
        }
    }




