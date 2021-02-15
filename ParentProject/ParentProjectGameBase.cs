using osu.Framework;
using osu.Framework.Allocation;
using osu.Framework.IO.Stores;

namespace ParentProject
{
    public class ParentProjectGameBase : Game
    {
        [BackgroundDependencyLoader]
        private void load()
        {
            var pResources = new NamespacedResourceStore<byte[]>(new DllResourceStore(typeof(ParentProjectGameBase).Assembly), @"Resources");
            Resources.AddStore(pResources);
        }
    }
}