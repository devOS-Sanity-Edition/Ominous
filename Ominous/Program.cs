namespace Ominous {
    internal static class Program {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            OminousSound.Open();
            OminousProcessCheck.RunProcessCheck();
            Application.Run(new OminousApplicationContext());
        }
    }
}