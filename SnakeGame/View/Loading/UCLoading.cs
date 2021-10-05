using SnakeGame.View.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame.View.Loading
{
    public partial class UCLoading : UserControl
    {
        public UCLoading()
        {
            InitializeComponent();
        }

        private void UCLoading_Load(object sender, EventArgs e)
        {
            panelPurple.Size = new Size(panelPurple.Size.Width, 30);
        }

        #region Timer para transação dos panels
        int panelPurple_y = 30; int waiter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            waiter++;
            if(waiter > 150)
            {
                lblConectando.Hide();
                panelPurple_y += 6;
                panelPurple.Size = new Size(panelPurple.Size.Width, panelPurple_y);
                if (panelPurple_y > 502)
                {
                    panelWhite.Hide();
                    timer1.Enabled = false;
                }
            }
        }
        #endregion

        #region Evento click no PictureBox da cobra para abrir o jogo
        private void pictureSnake_Click(object sender, EventArgs e)
        {
            SnakePlay frmSnake = new SnakePlay();
            frmSnake.Show();
        }
        #endregion
    }
}
