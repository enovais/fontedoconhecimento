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
using System.Globalization;

namespace Cripto
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdf = new SaveFileDialog();
            sdf.Filter = "Arquivo Texto | .txt";
            sdf.ShowDialog();
            if(string.IsNullOrEmpty(sdf.FileName) == false)
            {
                try
                {
                    using (StreamWriter write = new StreamWriter(sdf.FileName, false, Encoding.UTF8))
                    {
                        write.Write(txtSaida.Text);
                        write.Flush();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(string.Format("Não foi possível salvar o seu arquivo. Erro: {0}",ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivo texto | *.txt";
            ofd.ShowDialog();
            if(string.IsNullOrEmpty(ofd.FileName) == false)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(ofd.FileName, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-BR").TextInfo.ANSICodePage)))
                    {
                        txtEntrada.Text = reader.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    
                 MessageBox.Show(string.Format("Não foi possível abrir o seu arquivo. Erro: {0}",ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonte do Conhecimento\nVersão1.0\nAPS - 2º Semestre", "Fonte do Connhecimento");
        }

        private void objetivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvimento de programa capaz de buscar um arquivo de texto externo, cifrar e salvá-lo.\nAssim como buscar um arquivo cifrado pelo próprio programa decifrando e salvando.", "Objetivo");
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0", "Versão");
        }

        private void beatrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beatris\nRa:XXXXXXXXX", "Beatris");
        }

        private void evertonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Everton\nRa:D416CD6", "Everton");
        }

        private void ítaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ítalo\nRa:XXXXXXXXX", "Ítalo");
        }

        private void rayanneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rayanne\nRa:XXXXXXXXX", "Rayanne");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = txtEntrada.Text;
            string ret = "";
            string ret2 = "";
            foreach (char c in s)
            {
                // Código numérico do caractere.
                int asc = (int)c;
                // Concatena a representação string dos 
                // números binários separados por espaço.
                ret2 = Convert.ToString(asc, 2);            
                if (ret2.Length<8)//verificador do tamanho da string já em binário (precisa ter 8bits) para que consigamos desfazer o código na decifração
                    do
                    {
                        ret2="0"+ret2;
                    }
                    while (ret2.Length<8);
                ret += ret2;
            }
            // Separa os números binários e joga o resulatado
            // num array de strings.
            string[] strBin = ret.Trim().Split(' ');       
            string[] alfa0, alfa1; // Vetores para cada código bin possível
            string bin, dig1, cifrado1, cifrado2, cifrado3; // bin para o código binário; dig1 para pegar o valor sozinho do binário
            int aux, contador; // Variável int para auxilio da função Random
            Random rnd; // Declaração da função Random
            rnd = new Random(); // Criação do vetor Random
            aux = 0; // Valor inicial do variável
            contador = 0;
            cifrado1 = null;
            cifrado2 = null;
            cifrado3 = null;
            { // Declaração dos vetores
                alfa0 = new string[20]; // alfa0 com 13 letras do alfabeto, 4 números e 3 letras com acento
                alfa1 = new string[20]; // alfa1 com 13 letras do alfabeto, 4 números e 3 letras com acento
            }
            { // Valores para alfa0
                alfa0[0] = "4";
                alfa0[1] = "D";
                alfa0[2] = "C";
                alfa0[3] = "8";
                alfa0[4] = "A";
                alfa0[5] = "F";
                alfa0[6] = "E";
                alfa0[7] = "Í";
                alfa0[8] = "B";
                alfa0[9] = "W";
                alfa0[10] = "V";
                alfa0[11] = "R";
                alfa0[12] = "7";
                alfa0[13] = "Á";
                alfa0[14] = "X";
                alfa0[15] = "3";
                alfa0[16] = "S";
                alfa0[17] = "T";
                alfa0[18] = "U";
                alfa0[19] = "Ã";
            }
            { // Valores para alfa1
                alfa1[0] = "Y";
                alfa1[1] = "N";
                alfa1[2] = "Q";
                alfa1[3] = "Z";
                alfa1[4] = "6";
                alfa1[5] = "É";
                alfa1[6] = "O";
                alfa1[7] = "M";
                alfa1[8] = "P";
                alfa1[9] = "5";
                alfa1[10] = "J";
                alfa1[11] = "À";
                alfa1[12] = "2";
                alfa1[13] = "H";
                alfa1[14] = "G";
                alfa1[15] = "L";
                alfa1[16] = "9";
                alfa1[17] = "Õ";
                alfa1[18] = "K";
                alfa1[19] = "I";
            }
            do
            {
                progressBar1.Value = 0;
                bin = ret; // Código binário de até 20 bits
                progressBar1.Maximum = bin.Length; //tamanho maximo da barra de progresso
                progressBar1.Step = 1; // valor da evolução da barra
                progressBar1.Minimum = 0; //tamanho minimo da barra                
                for (int i = 0; i < bin.Length; i++) // "Delimitador de bits"
                {
                    aux = rnd.Next(0, 19); // Atribuição do vetor rnd com base em números inteiros de 0 a 19 armazenados em aux
                    contador = contador + 1;
                    progressBar1.PerformStep();// progresso da barra toda vez que passa por aqui, pois o prg sempre retorna aqui
                    if (i < 1048575) // i tá aqui só pq faz parte da sintaxe msm
                    {                                               
                        dig1 = bin.Substring(i, 1); // Leitor do binário                                                                        
                        if (dig1 == "0") // Se o caractér for 0 será imprimido no console o vetor alfa0
                        {
                            txtSaida.Text = (alfa0[aux]); // Puxa o valor do vetor alfa0 dependendo do número atribuido a aux
                            cifrado1 = alfa0[aux];
                        }
                        else
                            if (dig1 == "1") // Se o caractér for 1 será imprimido no console o vetor alfa1
                            {
                                txtSaida.Text = (alfa1[aux]); // Puxa o valor do vetor alfa1 dependendo do número atribuido a aux
                                cifrado1 = alfa1[aux];
                            }
                            else // Caso não seja 1 ou 0 aparece a mensagem de que a cifração será interrompida
                            {
                                MessageBox.Show("Cifração Interrompida", "Erro");
                            }                        
                    }
                    else // Se dig1 n estiver entre 0 e 20 aparece a mensagem de que a cifração será interrompida
                    {
                        MessageBox.Show("\n Cifração Interrompida");
                    }

                    cifrado2 = string.Concat(cifrado2, cifrado1);
                }
                cifrado3 = cifrado2;
                cifrado2 = null;
                //MessageBox.Show("Cifração Completa");
                MessageBox.Show("Cifração Concluida com Sucesso!", "Concluido");
                txtSaida.Text = cifrado3;
            }
            while (bin.Length != contador);           
            qdcCharEntrada.Text = Convert.ToString(txtEntrada.TextLength);
            qdtCharSaida.Text = Convert.ToString(txtSaida.TextLength);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdfc = new SaveFileDialog();
            sdfc.Filter = "Arquivo Texto | .txt";
            sdfc.ShowDialog();
            if (string.IsNullOrEmpty(sdfc.FileName) == false)
            {
                try
                {
                    using (StreamWriter write = new StreamWriter(sdfc.FileName, false, Encoding.UTF8))
                    {
                        write.Write(txtSaida.Text);
                        write.Flush();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Não foi possível salvar o seu arquivo. Erro: {0}", ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdf = new SaveFileDialog();
            sdf.Filter = "Arquivo Texto | .txt";
            sdf.ShowDialog();
            if (string.IsNullOrEmpty(sdf.FileName) == false)
            {
                try
                {
                    using (StreamWriter write = new StreamWriter(sdf.FileName, false, Encoding.UTF8))
                    {
                        write.Write(txtEntrada.Text);
                        write.Flush();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Não foi possível salvar o seu arquivo. Erro: {0}", ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtEntrada.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string acumulaEntrada;//variável para receber char/char da caixa de entrada
            acumulaEntrada = "";
            bool controle = false;
            progressBar1.Value = 0;
            progressBar1.Maximum = txtEntrada.TextLength; //tamanho maximo da barra de progresso
            progressBar1.Step = 1; // valor da evolução da barraprogressBar1.Minimum = 0; //tamanho minimo da barra
            for (int i=0; i<txtEntrada.Text.Length; i++)//lê entrada de texto caracter por caracter
            { //Analisa qual caracter corresponde a qual binario
                progressBar1.PerformStep();// progresso da barra toda vez que passa por aqui, pois o prg sempre retorna aqui
                if (txtEntrada.Text[i] == '4' || txtEntrada.Text[i] == 'D' || txtEntrada.Text[i] == 'C' || txtEntrada.Text[i] == '8' || txtEntrada.Text[i] == 'A' || txtEntrada.Text[i] == 'F' || txtEntrada.Text[i] == 'E' || txtEntrada.Text[i] == 'Í' || txtEntrada.Text[i] == 'B' || txtEntrada.Text[i] == 'W' || txtEntrada.Text[i] == 'V' || txtEntrada.Text[i] == 'R' || txtEntrada.Text[i] == '7' || txtEntrada.Text[i] == 'Á' || txtEntrada.Text[i] == 'X' || txtEntrada.Text[i] == '3' || txtEntrada.Text[i] == 'S' || txtEntrada.Text[i] == 'T' || txtEntrada.Text[i] == 'U' || txtEntrada.Text[i] == 'Ã')//para bin valendo 0
                {
                    acumulaEntrada += "0"; //acumula o retorno valendo 0
                }
                else
                    if (txtEntrada.Text[i] == 'Y' || txtEntrada.Text[i] == 'N' || txtEntrada.Text[i] == 'Q' || txtEntrada.Text[i] == 'Z' || txtEntrada.Text[i] == '6' || txtEntrada.Text[i] == 'É' || txtEntrada.Text[i] == 'O' || txtEntrada.Text[i] == 'M' || txtEntrada.Text[i] == 'P' || txtEntrada.Text[i] == '5' || txtEntrada.Text[i] == 'J' || txtEntrada.Text[i] == 'À' || txtEntrada.Text[i] == '2' || txtEntrada.Text[i] == 'H' || txtEntrada.Text[i] == 'G' || txtEntrada.Text[i] == 'L' || txtEntrada.Text[i] == '9' || txtEntrada.Text[i] == 'Õ' || txtEntrada.Text[i] == 'K' || txtEntrada.Text[i] == 'I')
                    {
                        acumulaEntrada += "1"; //acumula o retorno valendo 1
                    }
                        else
                    {
                        controle = true;
                    }              
            }
            //MessageBox.Show(acumulaEntrada); //mostra o texto todo decifrado para binário
            //byte acumulabyte = Convert.ToByte(acumulaEntrada);
            if (controle != true)
            {
                List<Byte> byteList = new List<Byte>();
                progressBar1.Value = 0;
                progressBar1.Maximum = acumulaEntrada.Length; //tamanho maximo da barra de progresso
                progressBar1.Step = 8;
                for (int i = 0; i < acumulaEntrada.Length; i += 8)
                {
                    byteList.Add(Convert.ToByte(acumulaEntrada.Substring(i, 8), 2));
                    progressBar1.PerformStep();
                }
                txtSaida.Text = (Encoding.UTF7.GetString(byteList.ToArray()));
                //MessageBox.Show(Encoding.UTF7.GetString(byteList.ToArray()));
                qdcCharEntrada.Text = Convert.ToString(txtEntrada.TextLength);
                qdtCharSaida.Text = Convert.ToString(txtSaida.TextLength);
                MessageBox.Show("Decifração Concluída com Sucesso!", "Concluído");
            }
            else
            {
                MessageBox.Show("Decifração Impossível", "Erro");
                txtSaida.Text = "";
                qdtCharSaida.Text = "";
            }
            
        }
        private void txtSaida_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void qdcCharEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
