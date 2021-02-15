using System;
using System.Linq;
using osu.Framework;
using osu.Framework.Platform;

namespace ChildProject.Desktop
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            bool useOsuTK = args.Contains(@"--tk");

            using (GameHost host = Host.GetSuitableHost(@"ChildProject", useOsuTK: useOsuTK))
            using (Game game = new ChildProjectGameBase())
                host.Run(game);
        }
    }
}
