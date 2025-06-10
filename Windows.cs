using System.Windows.Forms;

namespace Library
{
    public class Windows
    {
        public static Form UserAuth { get; set; }
        public static Form UserAccount { get; set; }
        public static Form LibraristAuth { get; set; }
        public static Form LibraristAccount { get; set; }


        public static void Init()
        {
            UserAuth = new UserAuth();
            UserAccount = new UserAccount();
            LibraristAuth = new LibraristAuth();
            LibraristAccount = new LibraristAccount();
        }
    }
}
