namespace WindowsFormsApp1
{
    partial class Formcalculadora
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
            this.buttonCE = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttoncopy = new System.Windows.Forms.Button();
            this.buttonmenos = new System.Windows.Forms.Button();
            this.buttonsoma = new System.Windows.Forms.Button();
            this.buttondivide = new System.Windows.Forms.Button();
            this.buttonMultiplica = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.buttonNum = new System.Windows.Forms.Button();
            this.buttonoito = new System.Windows.Forms.Button();
            this.buttonnove = new System.Windows.Forms.Button();
            this.buttonquatro = new System.Windows.Forms.Button();
            this.buttoncinco = new System.Windows.Forms.Button();
            this.buttonseis = new System.Windows.Forms.Button();
            this.buttonum = new System.Windows.Forms.Button();
            this.buttondois = new System.Windows.Forms.Button();
            this.buttontres = new System.Windows.Forms.Button();
            this.buttonzero = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            this.buttonvirgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.DimGray;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(6, 75);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(75, 48);
            this.buttonCE.TabIndex = 6;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(6, 4);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(313, 69);
            this.textBoxDisplay.TabIndex = 26;
            // 
            // buttoncopy
            // 
            this.buttoncopy.BackColor = System.Drawing.Color.DimGray;
            this.buttoncopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncopy.Location = new System.Drawing.Point(85, 75);
            this.buttoncopy.Name = "buttoncopy";
            this.buttoncopy.Size = new System.Drawing.Size(75, 48);
            this.buttoncopy.TabIndex = 8;
            this.buttoncopy.Text = "Copy";
            this.buttoncopy.UseVisualStyleBackColor = false;
            this.buttoncopy.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonmenos
            // 
            this.buttonmenos.BackColor = System.Drawing.Color.DimGray;
            this.buttonmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmenos.Location = new System.Drawing.Point(164, 75);
            this.buttonmenos.Name = "buttonmenos";
            this.buttonmenos.Size = new System.Drawing.Size(76, 48);
            this.buttonmenos.TabIndex = 9;
            this.buttonmenos.Text = "-";
            this.buttonmenos.UseVisualStyleBackColor = false;
            this.buttonmenos.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonsoma
            // 
            this.buttonsoma.BackColor = System.Drawing.Color.DimGray;
            this.buttonsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsoma.Location = new System.Drawing.Point(245, 75);
            this.buttonsoma.Name = "buttonsoma";
            this.buttonsoma.Size = new System.Drawing.Size(76, 48);
            this.buttonsoma.TabIndex = 10;
            this.buttonsoma.Text = "+";
            this.buttonsoma.UseVisualStyleBackColor = false;
            this.buttonsoma.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttondivide
            // 
            this.buttondivide.BackColor = System.Drawing.Color.DimGray;
            this.buttondivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondivide.Location = new System.Drawing.Point(245, 131);
            this.buttondivide.Name = "buttondivide";
            this.buttondivide.Size = new System.Drawing.Size(76, 48);
            this.buttondivide.TabIndex = 11;
            this.buttondivide.Text = "/";
            this.buttondivide.UseVisualStyleBackColor = false;
            this.buttondivide.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // buttonMultiplica
            // 
            this.buttonMultiplica.BackColor = System.Drawing.Color.DimGray;
            this.buttonMultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplica.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMultiplica.Location = new System.Drawing.Point(245, 182);
            this.buttonMultiplica.Name = "buttonMultiplica";
            this.buttonMultiplica.Size = new System.Drawing.Size(76, 48);
            this.buttonMultiplica.TabIndex = 12;
            this.buttonMultiplica.Text = "*";
            this.buttonMultiplica.UseVisualStyleBackColor = false;
            this.buttonMultiplica.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // buttonIgual
            // 
            this.buttonIgual.BackColor = System.Drawing.Color.DimGray;
            this.buttonIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIgual.Location = new System.Drawing.Point(245, 237);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(76, 104);
            this.buttonIgual.TabIndex = 13;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = false;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // buttonNum
            // 
            this.buttonNum.BackColor = System.Drawing.Color.DimGray;
            this.buttonNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum.Location = new System.Drawing.Point(6, 127);
            this.buttonNum.Name = "buttonNum";
            this.buttonNum.Size = new System.Drawing.Size(75, 50);
            this.buttonNum.TabIndex = 14;
            this.buttonNum.Text = "7";
            this.buttonNum.UseVisualStyleBackColor = false;
            this.buttonNum.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // buttonoito
            // 
            this.buttonoito.BackColor = System.Drawing.Color.DimGray;
            this.buttonoito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonoito.Location = new System.Drawing.Point(85, 127);
            this.buttonoito.Name = "buttonoito";
            this.buttonoito.Size = new System.Drawing.Size(75, 50);
            this.buttonoito.TabIndex = 15;
            this.buttonoito.Text = "8";
            this.buttonoito.UseVisualStyleBackColor = false;
            this.buttonoito.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonnove
            // 
            this.buttonnove.BackColor = System.Drawing.Color.DimGray;
            this.buttonnove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnove.Location = new System.Drawing.Point(164, 127);
            this.buttonnove.Name = "buttonnove";
            this.buttonnove.Size = new System.Drawing.Size(76, 50);
            this.buttonnove.TabIndex = 16;
            this.buttonnove.Text = "9";
            this.buttonnove.UseVisualStyleBackColor = false;
            // 
            // buttonquatro
            // 
            this.buttonquatro.BackColor = System.Drawing.Color.DimGray;
            this.buttonquatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonquatro.Location = new System.Drawing.Point(6, 182);
            this.buttonquatro.Name = "buttonquatro";
            this.buttonquatro.Size = new System.Drawing.Size(75, 49);
            this.buttonquatro.TabIndex = 17;
            this.buttonquatro.Text = "4";
            this.buttonquatro.UseVisualStyleBackColor = false;
            this.buttonquatro.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttoncinco
            // 
            this.buttoncinco.BackColor = System.Drawing.Color.DimGray;
            this.buttoncinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncinco.Location = new System.Drawing.Point(85, 182);
            this.buttoncinco.Name = "buttoncinco";
            this.buttoncinco.Size = new System.Drawing.Size(75, 49);
            this.buttoncinco.TabIndex = 18;
            this.buttoncinco.Text = "5";
            this.buttoncinco.UseVisualStyleBackColor = false;
            // 
            // buttonseis
            // 
            this.buttonseis.BackColor = System.Drawing.Color.DimGray;
            this.buttonseis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonseis.Location = new System.Drawing.Point(164, 182);
            this.buttonseis.Name = "buttonseis";
            this.buttonseis.Size = new System.Drawing.Size(76, 49);
            this.buttonseis.TabIndex = 19;
            this.buttonseis.Text = "6";
            this.buttonseis.UseVisualStyleBackColor = false;
            // 
            // buttonum
            // 
            this.buttonum.BackColor = System.Drawing.Color.DimGray;
            this.buttonum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonum.Location = new System.Drawing.Point(6, 237);
            this.buttonum.Name = "buttonum";
            this.buttonum.Size = new System.Drawing.Size(75, 51);
            this.buttonum.TabIndex = 20;
            this.buttonum.Text = "1";
            this.buttonum.UseVisualStyleBackColor = false;
            this.buttonum.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttondois
            // 
            this.buttondois.BackColor = System.Drawing.Color.DimGray;
            this.buttondois.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondois.Location = new System.Drawing.Point(85, 237);
            this.buttondois.Name = "buttondois";
            this.buttondois.Size = new System.Drawing.Size(75, 51);
            this.buttondois.TabIndex = 21;
            this.buttondois.Text = "2";
            this.buttondois.UseVisualStyleBackColor = false;
            // 
            // buttontres
            // 
            this.buttontres.BackColor = System.Drawing.Color.DimGray;
            this.buttontres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontres.Location = new System.Drawing.Point(164, 237);
            this.buttontres.Name = "buttontres";
            this.buttontres.Size = new System.Drawing.Size(75, 51);
            this.buttontres.TabIndex = 22;
            this.buttontres.Text = "3";
            this.buttontres.UseVisualStyleBackColor = false;
            // 
            // buttonzero
            // 
            this.buttonzero.BackColor = System.Drawing.Color.DimGray;
            this.buttonzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonzero.Location = new System.Drawing.Point(85, 293);
            this.buttonzero.Name = "buttonzero";
            this.buttonzero.Size = new System.Drawing.Size(75, 48);
            this.buttonzero.TabIndex = 23;
            this.buttonzero.Text = "0";
            this.buttonzero.UseVisualStyleBackColor = false;
            this.buttonzero.Click += new System.EventHandler(this.button14_Click);
            // 
            // buttondel
            // 
            this.buttondel.BackColor = System.Drawing.Color.DimGray;
            this.buttondel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondel.Location = new System.Drawing.Point(6, 293);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(75, 48);
            this.buttondel.TabIndex = 24;
            this.buttondel.Text = "Del";
            this.buttondel.UseVisualStyleBackColor = false;
            this.buttondel.Click += new System.EventHandler(this.button15_Click);
            // 
            // buttonvirgula
            // 
            this.buttonvirgula.BackColor = System.Drawing.Color.DimGray;
            this.buttonvirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonvirgula.Location = new System.Drawing.Point(164, 293);
            this.buttonvirgula.Name = "buttonvirgula";
            this.buttonvirgula.Size = new System.Drawing.Size(75, 48);
            this.buttonvirgula.TabIndex = 25;
            this.buttonvirgula.Text = ",";
            this.buttonvirgula.UseVisualStyleBackColor = false;
            // 
            // Formcalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(321, 344);
            this.Controls.Add(this.buttonvirgula);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.buttonzero);
            this.Controls.Add(this.buttontres);
            this.Controls.Add(this.buttondois);
            this.Controls.Add(this.buttonum);
            this.Controls.Add(this.buttonseis);
            this.Controls.Add(this.buttoncinco);
            this.Controls.Add(this.buttonquatro);
            this.Controls.Add(this.buttonnove);
            this.Controls.Add(this.buttonoito);
            this.Controls.Add(this.buttonNum);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.buttonMultiplica);
            this.Controls.Add(this.buttondivide);
            this.Controls.Add(this.buttonsoma);
            this.Controls.Add(this.buttonmenos);
            this.Controls.Add(this.buttoncopy);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonCE);
            this.Name = "Formcalculadora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttoncopy;
        private System.Windows.Forms.Button buttonmenos;
        private System.Windows.Forms.Button buttonsoma;
        private System.Windows.Forms.Button buttondivide;
        private System.Windows.Forms.Button buttonMultiplica;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonNum;
        private System.Windows.Forms.Button buttonoito;
        private System.Windows.Forms.Button buttonnove;
        private System.Windows.Forms.Button buttonquatro;
        private System.Windows.Forms.Button buttoncinco;
        private System.Windows.Forms.Button buttonseis;
        private System.Windows.Forms.Button buttonum;
        private System.Windows.Forms.Button buttondois;
        private System.Windows.Forms.Button buttontres;
        private System.Windows.Forms.Button buttonzero;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Button buttonvirgula;
    }
}

