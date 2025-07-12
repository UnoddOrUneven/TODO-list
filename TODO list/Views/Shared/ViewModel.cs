using System.Drawing;

namespace TODO_list.Views.Shared
{
    public class ViewModel
    {
        private static readonly Random _rand = new Random();
        public static Color GetRandomColor()
        {
            Color[] colors = { Color.Red, Color.AliceBlue, Color.Bisque };
            int r = _rand.Next(colors.Length);
            return colors[r];
        }


    }
}
