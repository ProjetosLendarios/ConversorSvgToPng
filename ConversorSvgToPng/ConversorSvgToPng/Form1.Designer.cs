namespace ConversorSvgToPng
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDrop = new System.Windows.Forms.Panel();
            this.lblDropZone = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnAbrirPasta = new System.Windows.Forms.Button();
            this.listBoxArquivos = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.chkMantarProporção = new System.Windows.Forms.CheckBox();
            this.panelDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDrop
            // 
            this.panelDrop.AllowDrop = true;
            this.panelDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrop.Controls.Add(this.lblDropZone);
            this.panelDrop.Location = new System.Drawing.Point(20, 20);
            this.panelDrop.Name = "panelDrop";
            this.panelDrop.Size = new System.Drawing.Size(560, 150);
            this.panelDrop.TabIndex = 0;
            this.panelDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDrop_DragDrop);
            this.panelDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrop_DragEnter);
            this.panelDrop.DragLeave += new System.EventHandler(this.panelDrop_DragLeave);
            // 
            // lblDropZone
            // 
            this.lblDropZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDropZone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropZone.ForeColor = System.Drawing.Color.White;
            this.lblDropZone.Location = new System.Drawing.Point(0, 0);
            this.lblDropZone.Name = "lblDropZone";
            this.lblDropZone.Size = new System.Drawing.Size(558, 148);
            this.lblDropZone.TabIndex = 0;
            this.lblDropZone.Text = "🎯 Arraste os ficheiros SVG aqui\r\nou clique para selecionar";
            this.lblDropZone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDropZone.Click += new System.EventHandler(this.lblDropZone_Click);
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.ForeColor = System.Drawing.Color.White;
            this.lblTamanho.Location = new System.Drawing.Point(20, 190);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(150, 19);
            this.lblTamanho.TabIndex = 1;
            this.lblTamanho.Text = "Tamanho de conversão:";
            // 
            // numWidth
            // 
            this.numWidth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numWidth.Location = new System.Drawing.Point(180, 188);
            this.numWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(80, 25);
            this.numWidth.TabIndex = 2;
            this.numWidth.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(270, 190);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 19);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "×";
            // 
            // numHeight
            // 
            this.numHeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numHeight.Location = new System.Drawing.Point(294, 188);
            this.numHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(80, 25);
            this.numHeight.TabIndex = 4;
            this.numHeight.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numHeight.ValueChanged += new System.EventHandler(this.numHeight_ValueChanged);
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConverter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverter.Enabled = false;
            this.btnConverter.FlatAppearance.BorderSize = 0;
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConverter.ForeColor = System.Drawing.Color.White;
            this.btnConverter.Location = new System.Drawing.Point(180, 225);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(120, 35);
            this.btnConverter.TabIndex = 5;
            this.btnConverter.Text = "🚀 Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnAbrirPasta
            // 
            this.btnAbrirPasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnAbrirPasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirPasta.FlatAppearance.BorderSize = 0;
            this.btnAbrirPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirPasta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAbrirPasta.ForeColor = System.Drawing.Color.White;
            this.btnAbrirPasta.Location = new System.Drawing.Point(310, 225);
            this.btnAbrirPasta.Name = "btnAbrirPasta";
            this.btnAbrirPasta.Size = new System.Drawing.Size(140, 35);
            this.btnAbrirPasta.TabIndex = 6;
            this.btnAbrirPasta.Text = "📁 Abrir Pasta";
            this.btnAbrirPasta.UseVisualStyleBackColor = false;
            this.btnAbrirPasta.Click += new System.EventHandler(this.btnAbrirPasta_Click);
            // 
            // listBoxArquivos
            // 
            this.listBoxArquivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listBoxArquivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxArquivos.Font = new System.Drawing.Font("Consolas", 9F);
            this.listBoxArquivos.ForeColor = System.Drawing.Color.White;
            this.listBoxArquivos.FormattingEnabled = true;
            this.listBoxArquivos.ItemHeight = 14;
            this.listBoxArquivos.Location = new System.Drawing.Point(20, 270);
            this.listBoxArquivos.Name = "listBoxArquivos";
            this.listBoxArquivos.Size = new System.Drawing.Size(560, 142);
            this.listBoxArquivos.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.LightGray;
            this.lblStatus.Location = new System.Drawing.Point(20, 420);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(560, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Pronto para converter";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 445);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(560, 23);
            this.progressBar.TabIndex = 9;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(460, 225);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 35);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "🗑️ Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // chkMantarProporção
            // 
            this.chkMantarProporção.AutoSize = true;
            this.chkMantarProporção.Checked = true;
            this.chkMantarProporção.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMantarProporção.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkMantarProporção.ForeColor = System.Drawing.Color.White;
            this.chkMantarProporção.Location = new System.Drawing.Point(390, 190);
            this.chkMantarProporção.Name = "chkMantarProporção";
            this.chkMantarProporção.Size = new System.Drawing.Size(128, 19);
            this.chkMantarProporção.TabIndex = 11;
            this.chkMantarProporção.Text = "Manter proporções";
            this.chkMantarProporção.UseVisualStyleBackColor = true;
            this.chkMantarProporção.CheckedChanged += new System.EventHandler(this.chkMantarProporção_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.chkMantarProporção);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.listBoxArquivos);
            this.Controls.Add(this.btnAbrirPasta);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.panelDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor SVG para PNG";
            this.panelDrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDrop;
        private System.Windows.Forms.Label lblDropZone;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnAbrirPasta;
        private System.Windows.Forms.ListBox listBoxArquivos;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.CheckBox chkMantarProporção;
    }
}

