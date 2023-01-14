using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    

namespace Note
{
    public partial class Bloco : Form
    {
        private OpenFileDialog abrirDaialogo;
        private SaveFileDialog salvarDialogo;
        private FontDialog fonteDialogo;

        public Bloco()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fonteDialogo = new FontDialog();
        }

        private void CriarNovo() //Novo
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    this.Text = "Sem título";
                    this.richTextBox1.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Arquivo vazio.", "Alert..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void AbrirArquivo()
        {
            try
            {
                abrirDaialogo = new OpenFileDialog();

                if(abrirDaialogo.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Text = File.ReadAllText(abrirDaialogo.FileName);
                    this.Text = abrirDaialogo.FileName;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                abrirDaialogo = null;
            }
        }

        private void SalvarArquivo()
        {
            try
            {
                salvarDialogo = new SaveFileDialog();

                salvarDialogo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (salvarDialogo.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(salvarDialogo.FileName, this.richTextBox1.Text);
                    this.Text = salvarDialogo.FileName;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                
            }
        }



        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarNovo();
        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o sistema?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
               
            }
            else
            {
                this.Close();
            }

        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
              if (fonteDialogo.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Font = fonteDialogo.Font;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void selecionarCorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
