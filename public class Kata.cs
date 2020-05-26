public class Kata
{
  public static string AverageString(string str)
  {
            string[] Astr = str.Split(' ');
            var total = 0;

            foreach (var Bstr in Astr)
            {
                switch (Bstr)
                {

                    case "zero":
                        total = total + 0;
                        break;
                    case "one":
                        total = total + 1;
                        break;
                    case "two":
                        total = total + 2;
                        break;
                    case "three":
                        total = total + 3;
                        break;
                    case "four":
                        total = total + 4;
                        break;
                    case "five":
                        total = total + 5;
                        break;
                    case "six":
                        total = total + 6;
                        break;
                    case "seven":
                        total = total + 7;
                        break;
                    case "eight":
                        total = total + 8;
                        break;
                    case "nine":
                        total = total + 9;
                        break;
                }

            }

            var num = (total / Astr.Length);

            if (num > 9 || Astr[0].Equals(""))
            {
               return "n/a";
            }
            else
            {
                switch (num)
                {

                    case 0:
                        return "zero";

                    case 1:
                        return "one";

                    case 2:
                        return "two";

                    case 3:
                        return "three";

                    case 4:
                        return "four";

                    case 5:
                        return "five";

                    case 6:
                        return "six";

                    case 7:
                        return "seven";

                    case 8:
                        return "eight";

                    case 9:
                        return "nine";
                    default:
                        return "n/a";

                }

            }
  }
}
