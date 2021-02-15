using ParentProject;
using osu.Framework.Graphics;
using osu.Framework.Allocation;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;
using osu.Framework.IO.Stores;

namespace ChildProject
{
    public class ChildProjectGameBase : ParentProjectGameBase
    {
        [BackgroundDependencyLoader]
        private void load()
        {
            var cResources = new NamespacedResourceStore<byte[]>(new DllResourceStore(typeof(ChildProjectGameBase).Assembly), @"Resources");
            Resources.AddStore(cResources);

            Child = new FillFlowContainer
            {
                RelativeSizeAxes = Axes.Both,
                Children = new Drawable[]
                {
                    new Sprite
                    {
                        Texture = Textures.Get("ParentTexture")
                    },
                    new Sprite
                    {
                        Texture = Textures.Get("ChildTexture")
                    }
                }
            };
        }
    }
}