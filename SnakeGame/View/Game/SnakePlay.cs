using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame.View.Game
{
    public partial class SnakePlay : Form
    {
        public int size = 50;
        public int level = 1;
        public SnakePlay()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty, null,
                grid, new object[] { true });

            SetCanvas();
        }

        #region SetCanvas - Adicionando as linhas e colunas
        void SetCanvas()
        {
            grid.RowTemplate.Height = grid.Height / size;
            for (int i = 0; i < size; i++) grid.Columns.Add(i.ToString(), i.ToString());
            for (int i = 0; i < size; i++) grid.Rows.Add();
        }
        #endregion

        #region Evento Key Up (quando o usuário apertar uma tecla)
        enum Directions { Up, Down, Right, Left}
        Directions currentDirection = Directions.Left;

        private void grid_KeyUp(object sender, KeyEventArgs e)
        {
            // Teclas do teclado e suas respectivas direções no jogo
            if (e.KeyCode == Keys.Up) currentDirection = Directions.Up;
            if (e.KeyCode == Keys.Down) currentDirection = Directions.Down;
            if (e.KeyCode == Keys.Right) currentDirection = Directions.Right;
            if (e.KeyCode == Keys.Left) currentDirection = Directions.Left;

        }
        #endregion

        #region Botão Iniciar o jogo - evento click
        private void btnGame_Click(object sender, EventArgs e)
        {
            if(btnGame.Text == "PAUSAR O JOGO")
            {
                btnGame.Text = "INICIAR O JOGO"; // Alterando o texto para pausar o jogo
                session.Start(); // Iniciando o timer
            }

            else
            {
                btnGame.Text = "PAUSAR O JOGO"; // Alterando o texto para pausar o jogo
                session.Start(); // Iniciando o timer
            }

        }
        #endregion

        private void session_Tick(object sender, EventArgs e)
        {

        }

        #region Evento CellContentClick
        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
    }
}
