using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife.Classes;
using System.Drawing;

namespace UnitTests
{
    [TestClass]
    public class UniverseUnitTests
    {
        [TestMethod]
        public void RetrieveCell_Existing_CorrectCellIsReturned()
        {
            var universe = new Universe();

            var position = Point.Empty;
            var cell = new Cell(position, true);
            universe.AddCell(cell);

            Assert.AreEqual(cell, universe.GetCellAtPosition(position));
        }

        [TestMethod]
        public void RetrieveCell_NonExisting_NullIsReturned()
        {
            var universe = new Universe();
            var position = Point.Empty;

            Assert.AreEqual(null, universe.GetCellAtPosition(position));
        }

        [TestMethod]
        public void AddCell_NonExisting_AddsCell()
        {
            var universe = new Universe();

            var position = Point.Empty;
            universe.AddCell(new Cell(position, true));

            Assert.AreEqual(true, universe.ContainsCellAtPosition(position));
        }

        [TestMethod]
        public void AddCell_Existing_AddsNewCell()
        {
            var universe = new Universe();

            var position = Point.Empty;
            var firstCell = new Cell(position, true);
            var secondCell = new Cell(position, true);

            universe.AddCell(firstCell);
            universe.AddCell(secondCell);

            Assert.AreEqual(secondCell, universe.GetCellAtPosition(position));
        }

        [TestMethod]
        public void GetNextCell_Existing_RetrievesAllCells()
        {
            var universe = new Universe();

            var position0 = Point.Empty;
            var position1 = new Point(1, 0);
            var position2 = new Point(2, 0);

            var cell0 = new Cell(position0, true);
            var cell1 = new Cell(position1, true);
            var cell2 = new Cell(position2, true);

            universe.AddCell(cell0);
            universe.AddCell(cell1);
            universe.AddCell(cell2);

            var retreivedCount = universe.NextCell().Count();

            Assert.AreEqual(3, retreivedCount);
        }
    }
}
