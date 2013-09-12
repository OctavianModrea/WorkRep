using System.Collections.Generic;
using System.Drawing;

namespace GameOfLife.Classes
{
    /// <summary>
    /// This class represents the universe in which the cells live.
    /// </summary>
    public class Universe
    {                                   
        private readonly Dictionary<Point, Cell> _cells;            // All the cells in the universe; both alive and dead
        public int CellCount { get { return _cells.Count; } }

        public Universe()
        {
            _cells = new Dictionary<Point, Cell>();
        }

        /// <summary>
        /// Checks if a cell exists at the specified position.
        /// </summary>
        public bool ContainsCellAtPosition(Point position)
        {
            return _cells.ContainsKey(position);
        }

        /// <summary>
        /// Adds a cell to the cell list. If a cell already exists at that position,
        /// it will be reaplaced by the new one.
        /// </summary>
        public void AddCell(Cell cell)
        {
            var alreadyExists = _cells.ContainsKey(cell.Position);
            if (alreadyExists)
            {
                _cells[cell.Position] = cell;
            }
            else
            {
                _cells.Add(cell.Position, cell);  
            }
        }

        /// <summary>
        /// Returns the next available cell in the universe. This method is used to
        /// iterate through all the cells in the universe.
        /// </summary>
        public IEnumerable<Cell> NextCell()
        {
            foreach (KeyValuePair<Point, Cell> keyValuePair in _cells)
            {
                yield return keyValuePair.Value;
            }
        }

        /// <summary>
        /// Returns the cell at the specified position. If a cell at that position
        /// is not present, the method returns null.
        /// </summary>
        public Cell GetCellAtPosition(Point position)
        {
            return !ContainsCellAtPosition(position) ? null : _cells[position];
        }
    }
}
