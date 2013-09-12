using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife.Classes;
using System.Drawing;

namespace UnitTests
{
    [TestClass]
    public class UniverseRulesUnitTests
    {
        [TestMethod]
        public void AddOneCell_CellIsAlive_CellKilledOnUpdate()
        {
            var universe = new Universe();
            var universeRules = new UniverseRules(universe);

            var cell = new Cell(Point.Empty, true);
            universe.AddCell(cell);
            universeRules.UpdateUniverse();

            Assert.AreEqual(false, cell.Alive);
        }
    }
}
