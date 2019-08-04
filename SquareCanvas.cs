using System;
using System.Windows.Forms;

namespace GitHubLanguageStatistics
{
    public class SquareCanvas : Panel
    {
        public SquareCanvas()
        {
            ResizeRedraw = true;
            DoubleBuffered = true;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            if (Width != Height)
                Width = Height;
            base.OnResize(eventargs);
        }
    }
}
