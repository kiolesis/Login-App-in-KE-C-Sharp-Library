using KE = Engine;
using System;

// (c) Kiolesis
// Aplikacja stworzona przy pomocy biblioteki KE C#.
// Ta aplikacja jest tylko przykładem użycia tej biblioteki.
namespace LoginPanel
{
    internal class Program
    {
        public static string login = "";
        public static string pass = "";
        static void Main(string[] args)
        {
        menu:
            KE.Console_Code.Clear();
            KE.Write.Text("Kiolesis Program.");
            KE.Write.Text("");
            KE.Write.Text("1) Utwórz konto");
            KE.Write.Text("2) Zaloguj się");
            string xyz = Console.ReadLine();
            if (xyz == "1")
            {
                string loginn = KE.Password.Login("Kiolesis Program");
                string passs = KE.Password.Pass("Kiolesis Program");
                KE.Write.Text("Dziękuję za utworzenie konta! Wciśnij dowolny przycisk.");
                Console.ReadKey();
                goto menu;
            }
            if (xyz == "2")
            {
                string a = KE.Password.EnterLogin();
                string b = KE.Password.EnterPassword();

                // Poprawne dane
                // login = User
                //  pass = Password
                bool succeed = KE.Password.Verify(a, b, login, pass);
                if (succeed == true)
                {
                    goto xd;
                }
                else
                {
                    goto menu;
                }
            xd:
                KE.Write.Text("Zalogowano!");
                KE.Pause.Hide();
            }
        }
    }
}
