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
using System.Diagnostics;
using Svg;
using System.Drawing.Imaging;

namespace ConversorSvgToPng
{
    public partial class Form1 : Form
    {
        private List<string> arquivosSvg = new List<string>();
        private string pastaConvertidos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Convertidos");
        private bool manterProporção = true;

        public Form1()
        {
            InitializeComponent();
            CriarPastaConvertidos();
            
            // Aplicar estilo moderno aos controles
            AplicarEstiloModerno();
        }

        private void AplicarEstiloModerno()
        {
            // Melhorar aparência do cursor nos botões
            btnConverter.MouseEnter += (s, e) => btnConverter.BackColor = Color.FromArgb(0, 140, 230);
            btnConverter.MouseLeave += (s, e) => btnConverter.BackColor = Color.FromArgb(0, 122, 204);
            
            btnAbrirPasta.MouseEnter += (s, e) => btnAbrirPasta.BackColor = Color.FromArgb(0, 180, 0);
            btnAbrirPasta.MouseLeave += (s, e) => btnAbrirPasta.BackColor = Color.FromArgb(0, 153, 0);
            
            btnLimpar.MouseEnter += (s, e) => btnLimpar.BackColor = Color.FromArgb(220, 70, 70);
            btnLimpar.MouseLeave += (s, e) => btnLimpar.BackColor = Color.FromArgb(180, 50, 50);
            
            panelDrop.MouseEnter += (s, e) => panelDrop.Cursor = Cursors.Hand;
            lblDropZone.Cursor = Cursors.Hand;
        }

        private void CriarPastaConvertidos()
        {
            if (!Directory.Exists(pastaConvertidos))
            {
                Directory.CreateDirectory(pastaConvertidos);
            }
        }

        private void panelDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                panelDrop.BackColor = Color.FromArgb(0, 122, 204);
                lblDropZone.Text = "✅ Solte os ficheiros aqui!";
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelDrop_DragLeave(object sender, EventArgs e)
        {
            panelDrop.BackColor = Color.FromArgb(45, 45, 48);
            lblDropZone.Text = "🎯 Arraste os ficheiros SVG aqui\r\nou clique para selecionar";
        }

        private void panelDrop_DragDrop(object sender, DragEventArgs e)
        {
            panelDrop.BackColor = Color.FromArgb(45, 45, 48);
            lblDropZone.Text = "🎯 Arraste os ficheiros SVG aqui\r\nou clique para selecionar";

            string[] ficheiros = (string[])e.Data.GetData(DataFormats.FileDrop);
            AdicionarArquivos(ficheiros);
        }

        private void lblDropZone_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Ficheiros SVG|*.svg";
                ofd.Multiselect = true;
                ofd.Title = "Selecione os ficheiros SVG";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    AdicionarArquivos(ofd.FileNames);
                }
            }
        }

        private void AdicionarArquivos(string[] ficheiros)
        {
            int adicionados = 0;
            
            foreach (string ficheiro in ficheiros)
            {
                if (Path.GetExtension(ficheiro).ToLower() == ".svg" && !arquivosSvg.Contains(ficheiro))
                {
                    arquivosSvg.Add(ficheiro);
                    listBoxArquivos.Items.Add(Path.GetFileName(ficheiro));
                    adicionados++;
                }
            }

            if (adicionados > 0)
            {
                lblStatus.Text = $"{adicionados} ficheiro(s) adicionado(s). Total: {arquivosSvg.Count}";
                lblStatus.ForeColor = Color.LightGreen;
                btnConverter.Enabled = true;
            }
        }

        private async void btnConverter_Click(object sender, EventArgs e)
        {
            if (arquivosSvg.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um ficheiro SVG!", "Atenção", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnConverter.Enabled = false;
            btnLimpar.Enabled = false;
            progressBar.Value = 0;
            progressBar.Maximum = arquivosSvg.Count;

            int width = (int)numWidth.Value;
            int height = (int)numHeight.Value;
            int sucesso = 0;
            int erros = 0;

            await Task.Run(() =>
            {
                for (int i = 0; i < arquivosSvg.Count; i++)
                {
                    string svgPath = arquivosSvg[i];
                    
                    try
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            lblStatus.Text = $"A converter: {Path.GetFileName(svgPath)} ({i + 1}/{arquivosSvg.Count})";
                            lblStatus.ForeColor = Color.Yellow;
                        });

                        ConverterSvgParaPng(svgPath, width, height);
                        sucesso++;

                        this.Invoke((MethodInvoker)delegate
                        {
                            progressBar.Value = i + 1;
                        });
                    }
                    catch (Exception ex)
                    {
                        erros++;
                        this.Invoke((MethodInvoker)delegate
                        {
                            lblStatus.Text = $"Erro ao converter {Path.GetFileName(svgPath)}: {ex.Message}";
                            lblStatus.ForeColor = Color.Red;
                        });
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            });

            lblStatus.Text = $"Conversão concluída! ✅ Sucesso: {sucesso} | ❌ Erros: {erros}";
            lblStatus.ForeColor = erros > 0 ? Color.Yellow : Color.LightGreen;
            
            btnConverter.Enabled = true;
            btnLimpar.Enabled = true;

            if (sucesso > 0)
            {
                var result = MessageBox.Show(
                    $"Conversão concluída!\n\n✅ {sucesso} ficheiro(s) convertido(s) com sucesso\n❌ {erros} erro(s)\n\nDeseja abrir a pasta dos convertidos?",
                    "Conversão Concluída",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    AbrirPastaConvertidos();
                }
            }
        }

        private void ConverterSvgParaPng(string svgPath, int width, int height)
        {
            // Carregar o documento SVG
            SvgDocument svgDoc = SvgDocument.Open(svgPath);

            int finalWidth = width;
            int finalHeight = height;

            // Manter proporções se a opção estiver ativada
            if (manterProporção)
            {
                float aspectRatio = svgDoc.Width.Value / svgDoc.Height.Value;
                
                if (aspectRatio > 1) // Largura maior que altura
                {
                    finalHeight = (int)(width / aspectRatio);
                }
                else // Altura maior que largura
                {
                    finalWidth = (int)(height * aspectRatio);
                }
            }

            // Criar bitmap com as dimensões especificadas
            using (Bitmap bitmap = new Bitmap(finalWidth, finalHeight))
            {
                // Renderizar o SVG no bitmap
                svgDoc.Draw(bitmap);

                // Gerar nome do arquivo PNG
                string nomeArquivo = Path.GetFileNameWithoutExtension(svgPath);
                string pngPath = Path.Combine(pastaConvertidos, $"{nomeArquivo}_{finalWidth}x{finalHeight}.png");

                // Garantir nome único
                int contador = 1;
                while (File.Exists(pngPath))
                {
                    pngPath = Path.Combine(pastaConvertidos, $"{nomeArquivo}_{finalWidth}x{finalHeight}_{contador}.png");
                    contador++;
                }

                // Salvar como PNG
                bitmap.Save(pngPath, ImageFormat.Png);
            }
        }

        private void btnAbrirPasta_Click(object sender, EventArgs e)
        {
            AbrirPastaConvertidos();
        }

        private void AbrirPastaConvertidos()
        {
            if (Directory.Exists(pastaConvertidos))
            {
                Process.Start("explorer.exe", pastaConvertidos);
            }
            else
            {
                MessageBox.Show("A pasta de convertidos ainda não existe!", "Atenção", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            arquivosSvg.Clear();
            listBoxArquivos.Items.Clear();
            progressBar.Value = 0;
            lblStatus.Text = "Lista limpa. Pronto para converter.";
            lblStatus.ForeColor = Color.LightGray;
            btnConverter.Enabled = false;
        }

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {
            if (manterProporção)
            {
                numHeight.Value = numWidth.Value;
            }
        }

        private void numHeight_ValueChanged(object sender, EventArgs e)
        {
            if (manterProporção)
            {
                numWidth.Value = numHeight.Value;
            }
        }

        private void chkMantarProporção_CheckedChanged(object sender, EventArgs e)
        {
            manterProporção = chkMantarProporção.Checked;
            
            if (manterProporção)
            {
                numHeight.Value = numWidth.Value;
            }
        }
    }
}
