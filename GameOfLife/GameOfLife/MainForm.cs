using System;
using System.Windows.Forms;
using GameOfLife.Classes;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        private readonly Universe _universe;
        private readonly Simulation _simulation;
        private readonly UniverseRules _universeRules;
        private readonly UniverseView _universeView;

        public MainForm()
        {
            InitializeComponent();

            _universe = new Universe();
            _simulation = new Simulation();
            _universeRules = new UniverseRules(_universe);
            _universeView = new UniverseView(_universe);

            Button_StartSimulation.Text = Resources.GUIStrings.Button_StartSimulation;
            Button_StopSimulation.Text = Resources.GUIStrings.Button_StopSimulation;
            Button_PauseSimulation.Text = Resources.GUIStrings.Button_PauseSimulation;

            _simulation.RegisterTickEventHandler(SimulationStep);
        }

        /// <summary>
        /// Used as a callback for the simulation object.
        /// </summary>
        private void SimulationStep(object sender, EventArgs e)
        {
            _universeRules.UpdateUniverse();
            DrawPanel.Refresh();
        }

        /// <summary>
        /// Called when the form needs to repaint itself.
        /// </summary>
        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            _universeView.DrawUniverseCells(e.Graphics);    
        }

        /// <summary>
        /// Different types of events.
        /// </summary>
        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _universe.AddCell(new Cell(e.Location, true));
                DrawPanel.Refresh();
            }
        }

        private void Button_StartSimulation_Click(object sender, EventArgs e)
        {
            _simulation.Start();
        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _universe.AddCell(new Cell(e.Location, true));
                DrawPanel.Refresh();
            }
        }
    }
}
