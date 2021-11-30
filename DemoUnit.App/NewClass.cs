namespace DemoUnit
{
    public class NewClass
    {
        public static string SomeMethod(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "Вы ничего не ввели";
            }
            return "Вы ввели " + str;

        }
    }
}