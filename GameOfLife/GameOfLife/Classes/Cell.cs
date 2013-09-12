using System.Collections.Generic;
using System.Drawing;

namespace GameOfLife.Classes
{
    /// <summary>
    /// This class represents a cell which lives in the Universe.
    /// </summary>
    public class Cell
    {
        public Point Position { get; private set; }             // The position in the universe
        public bool Alive { get; set; }                         // Alive or dead?

        private readonly List<Point> _neighbourPositions;       // The list of neighbour positions 

        public Cell(Point position, bool alive)
        {
            Position = position;
            Alive = alive;

            _neighbourPositions = new List<Point>
            {
                // Top row
                new Point(Position.X - 1, Position.Y - 1),
                new Point(Position.X, Position.Y - 1),
                new Point(Position.X + 1, Position.Y - 1),

                // Middle row
                new Point(Position.X - 1, Position.Y),
                new Point(Position.X + 1, Position.Y),

                // Bottom row
                new Point(Position.X - 1, Position.Y + 1),
                new Point(Position.X, Position.Y + 1),
                new Point(Position.X + 1, Position.Y + 1),
            };
        }

        /// <summary>
        /// Instructs the cell to draw itself with the specified brush. Dead cells do
        /// not draw themselves.
        /// </summary>
        public void Draw(Graphics graphics, Brush brush)
        {
            if (graphics == null || !Alive) return;
            graphics.FillRectangle(brush, Position.X, Position.Y, 1, 1);   
        }

        /// <summary>
        /// Returns the positions of the cell's neighbours.
        /// </summary>
        public List<Point> GetNeighbourPositions()
        {
           return new List<Point>(_neighbourPositions);  
        }
    }
}
