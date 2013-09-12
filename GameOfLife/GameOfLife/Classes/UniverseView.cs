using System.Drawing;

namespace GameOfLife.Classes
{
    /// <summary>
    /// This class is responsible for drawing all the cells in the universe.
    /// </summary>
    class UniverseView
    {
        private static readonly Color CellColor = Color.Blue;
        private readonly Brush _cellBrush;          

        private readonly Universe _universe;        // The universe for which the drawing will be performed

        public UniverseView(Universe universe)
        {
            _universe = universe;
            _cellBrush = new SolidBrush(CellColor);
        }

        /// <summary>
        /// Draws the cells in the universe.
        /// </summary>
        /// <param name="graphics">The graphics object used to draw the cells.</param>
        public void DrawUniverseCells(Graphics graphics)
        {
            foreach (var cell in _universe.NextCell())
            {
                cell.Draw(graphics, _cellBrush);
            }
        }
    }
}
