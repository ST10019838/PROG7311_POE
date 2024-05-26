namespace ST10019838_DamianDare_PROG7311_POE.Utils
{
    public class Utils
    {
        public static string ShortenString(string s)
        {


            return s.Length < 8 ? s : $"{s.Substring(0, 8)} ...";
        }
    }
}
