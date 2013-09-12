using System.Collections.Generic;
using System.Drawing;

namespace GameOfLife.Classes
{
    /// <summary>
    /// The class is responsible for defining the rules of the unvierse and updating the 
    /// life state of the cells in the universe.
    /// </summary>
    public class UniverseRules
    {
        private readonly Universe _universe;
        private readonly Dictionary<Cell, bool> _currentCellLifeState;          // Used in the update iteration to store the current life state of each cell

        public UniverseRules(Universe universe)
        {
            _universe = universe;
            _currentCellLifeState = new Dictionary<Cell, bool>();
        }

        /// <summary>
        /// Returns the life state of a cell based on the number of neighbours which are alive.
        /// </summary>
        private bool GetCellLifeState(int livingNeighbourCount)
        {
            if (livingNeighbourCount < 2 || livingNeighbourCount > 3)
            {
                return false;
            }
            return (livingNeighbourCount == 2 || livingNeighbourCount == 3);
        }

        /// <summary>
        /// This method is responsible for updating the universe by changing the life state
        /// of the cells according to the currently defined rules.
        /// </summary>
        public void UpdateUniverse()
        {
            var deadNeighbourPositions = new List<Point>();

            _currentCellLifeState.Clear();
            foreach (var cell in _universe.NextCell())
            {
                // Store the current life state of the cell. This is needed when updating the remaining cells
                _currentCellLifeState.Add(cell, cell.Alive);
                
                // Process the cell's neighbours
                var aliveNeighbourCount = 0;
                var neighbourPositions = cell.GetNeighbourPositions();
                foreach (var neighbourPosition in neighbourPositions)
                {
                    var neighbour = _universe.GetCellAtPosition(neighbourPosition);
                    if (neighbour != null)
                    {
                        // If this neighbour has been processed in an earlier iteration use the dictionary to 
                        // check its life state. If it hasn't been processed, the 'Alive' property can abe used
                        // because we know its value didn't change up to this point.
                        if ((_currentCellLifeState.ContainsKey(neighbour) && _currentCellLifeState[neighbour]) ||
                            neighbour.Alive)
                        {
                            ++aliveNeighbourCount;
                        }
                    }
                    else
                    {
                        deadNeighbourPositions.Add(neighbourPosition);
                    }
                }

                // Update the cell's life state based on the number of living neighbours
                cell.Alive = GetCellLifeState(aliveNeighbourCount);
            }
        }
    }
}
