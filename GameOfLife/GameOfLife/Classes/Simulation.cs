using System;
using System.Windows.Forms;

namespace GameOfLife.Classes
{
    /// <summary>
    /// This class represents the simulation which is responsible for starting, pausing, or stopping the game.
    /// </summary>
    class Simulation
    {
        public delegate void TickEventHandler(object sender, EventArgs e);
        private readonly Timer _simulationTimer;

        public Simulation()
        {
            _simulationTimer = new Timer();
        }

        /// <summary>
        /// Starts the simulation.
        /// </summary>
        public void Start()
        {
            _simulationTimer.Start();
        }

        /// <summary>
        /// Puauses the simulation.
        /// </summary>
        public void Pause()
        {
            _simulationTimer.Stop();
        }

        /// <summary>
        /// Registers a new 
        /// </summary>
        public void RegisterTickEventHandler(TickEventHandler tickEventHandler)
        {
            _simulationTimer.Tick += new EventHandler(tickEventHandler);
        }
    }
}
