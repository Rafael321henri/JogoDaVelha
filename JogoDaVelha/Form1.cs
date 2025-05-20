using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        // Variavei Goblais
        string jogadaAtual = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fechar o programa
        }
        private void Jogada_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            botaoClicado.Text =jogadaAtual;
            botaoClicado.Enabled = false;
            // Trocar de X para O e de O para X:
            if (jogadaAtual == "X")
            {
                jogadaAtual = "O";
                // Trocar a cor do label:
                lblInfo.ForeColor = Color.Green;
            }
            else
            {
                jogadaAtual = "X";
                // Trocar a cor do label:
                lblInfo.ForeColor = Color.Red;
            }
            // Atualizar o label:
            lblInfo.Text = $"É a vez do {jogadaAtual}";

            // Verificar o vencedor
            VerificarVencedor();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            jogadaAtual = "X";
            lblInfo.Text = $"É a vez do {jogadaAtual}";
            lblInfo.ForeColor = Color.Red;

            // Resetar os Botões:
            btn11.Enabled = true;
            btn11.Text = "";

            btn12.Enabled = true;
            btn12.Text = "";

            btn13.Enabled = true;
            btn13.Text = "";

            btn21.Enabled = true;
            btn21.Text = "";

            btn22.Enabled = true;
            btn22.Text = "";

            btn23.Enabled = true;
            btn23.Text = "";

            btn31.Enabled = true;
            btn31.Text = "";

            btn32.Enabled = true;
            btn32.Text = "";

            btn33.Enabled = true;
            btn33.Text = "";
        }
        public void VerificarVencedor()
        {
                // Verificar linhas:
                if(btn11.Text == btn12.Text && btn12.Text == btn13.Text && btn11.Text != "")
                {
                    lblInfo.Text = $"O VENCEDOR É {btn11.Text}";
                }
                else if(btn21.Text == btn22.Text && btn22.Text == btn23.Text && btn21.Text != "")
                {
                    lblInfo.Text = $"O VENCEDOR É {btn21.Text}";
                }
                else if(btn31.Text == btn32.Text && btn32.Text == btn33.Text && btn31.Text != "")
                {
                    lblInfo.Text = $"O VENCEDOR É {btn31.Text}";
                }
                else if (btn11.Text == btn21.Text && btn21.Text == btn31.Text && btn11.Text != "")
                {
                    lblInfo.Text = $"O VENCEDOR É {btn11.Text}";
                }
                else if (btn12.Text == btn22.Text && btn22.Text == btn32.Text && btn12.Text != "")
                {
                    lblInfo.Text = $"O VENCEDOR É {btn12.Text}";
                }
                else if (btn13.Text == btn23.Text && btn23.Text == btn33.Text && btn13.Text != "")
                {
                    lblInfo.Text = $"O VENCEDOR É {btn13.Text}";
                }
                else if (btn11.Text == btn22.Text && btn22.Text == btn33.Text && btn11.Text != "")
                {
                    lblInfo.Text = $"O VENCEDOR É {btn11.Text}";
                }
                else if (btn13.Text == btn22.Text && btn22.Text == btn31.Text && btn13.Text != "")
                {
                    lblInfo.Text = $"O VENCEDOR É {btn13.Text}";
                }
                else if (!btn11.Enabled && !btn12.Enabled && !btn13.Enabled && !btn21.Enabled && !btn22.Enabled && !btn23.Enabled 
                && !btn31.Enabled && !btn32.Enabled && !btn33.Enabled)
                {
                lblInfo.Text = "Empatar";
                }
        }
    }
}
