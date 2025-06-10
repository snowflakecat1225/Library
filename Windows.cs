using System.Windows.Forms;

namespace Library
{
    public class Windows
    {
        public static Form UserAuth { get; set; }
        public static Form LibraristAuth { get; set; }

        public static void Init()
        {
            UserAuth = new UserAuth();
            LibraristAuth = new LibraristAuth();
        }
    }
}
