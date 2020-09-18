using DesignPatterns;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SadConsole;
using System.Collections.Generic;

namespace DesignPatternsConsole
{
    public class DesenharConsole : IGraphicConsole
    {
        private const int Width = 80;
        private const int Height = 25;
        private List<Rectangle> rectangles = new List<Rectangle>();

        public DesenharConsole()
        {
            SadConsole.Game.Create(Width, Height);
        }

        public void Draw(int x, int y)
        {
            rectangles.Add(new Rectangle(x, y, 5, 5));
        }

        public void Show()
        {
            SadConsole.Game.OnInitialize = delegate ()
            {
                var _consoleScreen = SadConsole.Global.CurrentScreen;
                _consoleScreen.FillWithRandomGarbage();
                foreach (var item in rectangles)
                {
                    _consoleScreen.Fill(item, null, Color.Green, 0, SpriteEffects.None);
                }
            };
            SadConsole.Game.Instance.Run();
        }

        ~DesenharConsole()
        {
            SadConsole.Game.Instance.Dispose();
        }
    }
}