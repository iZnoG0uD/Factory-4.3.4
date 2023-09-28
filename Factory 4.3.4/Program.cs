namespace Factory_4._3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string SecondName, string Login, int CountLogin,
                bool isPet, double Age, string[] FavoritColors) User;

            byte i = 0;

            do
            {
                Console.Write("\tВведите Ваше имя: ");
                User.Name = Console.ReadLine();

                Console.Write("\tВведите Вашу фамилию: ");
                User.SecondName = Console.ReadLine();

                Console.Write("\tВведите логин: ");
                User.Login = Console.ReadLine();

                User.CountLogin = User.Login.Length;

                Console.WriteLine("Есть ли у Вас домашнее животное? Ответ \"ДА\" " +
                    "или \"НЕТ\"");
                if (Console.ReadLine() == "ДА")
                    User.isPet = true;
                else User.isPet = false;

                Console.Write("Введите Ваш возраст: ");
                User.Age = Convert.ToDouble(Console.ReadLine());

                User.FavoritColors = new string[3];
                Console.Write("Введите Ваши три любимых цвета: \n");
                User.FavoritColors[0] = Console.ReadLine();
                User.FavoritColors[1] = Console.ReadLine();
                User.FavoritColors[2] = Console.ReadLine();
            } while (i < 3);

            Console.ReadKey();
        }
    }
}