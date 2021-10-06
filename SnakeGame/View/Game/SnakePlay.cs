using SnakeGame.View.Rules;
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
        public int size = 50; // Dimensão (altura x largura) da cobra e da comida
        public int level = 1;
        public SnakePlay()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty, null,
                grid, new object[] { true });

            // Pontos de Spawn da cobra! Ela nasce com o tamanho igual a 3 já, em 0,0; 0,1 e 0;2!
            points.Add(new Point(0, 0));
            points.Add(new Point(0, 1));
            points.Add(new Point(0, 2));
            
            SetCanvas();
            SetTarget(); // Adicionando a "comida"
            MoveSnake(points.LastOrDefault());
        }

        #region SetCanvas - Adicionando as linhas e colunas
        void SetCanvas()
        {
            grid.RowTemplate.Height = grid.Height/size;
            for (int i = 0; i < size; i++) grid.Columns.Add(i.ToString(), i.ToString());
            for (int i = 0; i < size; i++) grid.Rows.Add();
        }
        #endregion

        #region Evento Key Up (quando o usuário apertar uma tecla)
        enum Directions { Up, Down, Right, Left}
        Directions currentDirection = Directions.Right; // Right = direção inicial da cobra

        private void grid_KeyUp(object sender, KeyEventArgs e)
        {
            if (!session.Enabled) return;
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
            grid.Show();
            if(btnGame.Text == "PAUSAR O JOGO")
            {
                btnGame.Text = "INICIAR O JOGO"; // Alterando o texto para pausar o jogo
                session.Stop(); // Pausando o timer
            }

            else
            {
                btnGame.Text = "PAUSAR O JOGO"; // Alterando o texto para pausar o jogo
                session.Start(); // Iniciando o timer
            }

        }
        #endregion

        #region Timer (session)
        List<Point> points = new List<Point>(); // Propriedade Point - Para armazenar X e Y
        private void session_Tick(object sender, EventArgs e)
        {
            try
            {
                // Adicionando a direção
                var point = points.LastOrDefault();

                if (currentDirection == Directions.Left)
                {
                    point.Y--;
                }

                if (currentDirection == Directions.Right)
                {
                    point.Y++;
                }

                if (currentDirection == Directions.Up)
                {
                    point.X--;
                }

                if (currentDirection == Directions.Down)
                {
                    point.X++;
                }

                MoveSnake(point);
            }

            catch (Exception)
            {
                session.Stop();
                MessageBox.Show("FIM DO JOGO!");
                ResetGame();
            }
        }
        #endregion

        #region Resetar o jogo
        void ResetGame()
        {
            points.Clear();
            points.Add(new Point(0, 2));
            points.Add(new Point(0, 1));
            MoveSnake(points.LastOrDefault());
            points.Add(new Point(0, 0));
            btnGame.Text = "INICIAR O JOGO";
        }
        #endregion

        #region Movimentação da cobra
        void MoveSnake(Point newPoint)
        {
            // Detectar fim do jogo
            bool over = grid.Rows[newPoint.X].Cells[newPoint.Y].Style.BackColor == labelTitle.BackColor;

            // Resetando as cores
            foreach (var point in points)
            {
                grid.Rows[point.X].Cells[point.Y].Style.BackColor = grid.Rows[point.X].Cells[point.Y].Style.SelectionBackColor = Color.FromArgb(48, 36, 60);
            }

            if (grid.Rows[newPoint.X].Cells[newPoint.Y].Style.BackColor == Color.MediumSeaGreen) // MediumSeaGreen = Cor do ponto que a cobra tem que ir
            {
                labelTitle.Text = "Snake Game 1.0       Points: " + (points.Count() - 1); // adicionando a contagem de pontos na label
                SetTarget();
            }

            else
            {
                points.RemoveAt(0);
            }

            points.Add(newPoint);

            foreach (var point in points)
            {
                grid.Rows[point.X].Cells[point.Y].Style.BackColor = grid.Rows[point.X].Cells[point.Y].Style.SelectionBackColor = labelTitle.BackColor;
            }

            var p = points.LastOrDefault();
            grid.CurrentCell = grid.Rows[p.X].Cells[p.Y];

            if (over) // Caso o usuário perca
            {
                ResetGame();
            }
        }
        #endregion

        #region SetTarget (Gerar a comida da cobra)
        Random ran = new Random(); // Propriedade random para gerar de forma aleatória

        void SetTarget()
        {
            grid.Rows[ran.Next(0, size)].Cells[ran.Next(0, size)].Style.BackColor = Color.MediumSeaGreen; // MediumSeaGreen = Cor do ponto que a cobra tem que ir
        }

        #endregion

        #region Evento CellContent - Quando o usuário clica na Grid
        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid.CurrentCell = grid.Rows[0].Cells[0]; // Joga a seleção do click para 0, 0
        }
        #endregion

        #region Botão Regras
        private void btnRegras_Click(object sender, EventArgs e)
        {
            if (btnGame.Text == "PAUSAR O JOGO")
            {
                btnGame.Text = "INICIAR O JOGO"; // Alterando o texto para pausar o jogo
                session.Stop(); // Pausando o timer
            }

            grid.Hide();             // Pausando o jogo caso a pessoa clique no botão regras e o jogo esteja rodando
            openRulesForm(new RulesView());
        }
        #endregion

        #region OpenRules - Abrindo a form Regras no panel do SnakePlay
        private Form activeForm = null;
        private void openRulesForm(Form rulesForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = rulesForm;
            rulesForm.TopLevel = false;
            rulesForm.FormBorderStyle = FormBorderStyle.None;
            rulesForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(rulesForm);
            panelMain.Tag = rulesForm;
            rulesForm.BringToFront();
            rulesForm.Show();

        }
        #endregion
    }
}
