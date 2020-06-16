namespace KataTest.Kata_No._3_Band_name_generator
{
    public class Kata3
    {
        public static string BandNameGenerator(string str)
        {
            if (str.Substring(0, 1).Equals(str.Substring(str.Length - 1, 1)))
            {
                return str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1) + str.Substring(1, str.Length - 1);
            }
            else
            {
                return "The" + " " + str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1);
            }

        }
    }
}