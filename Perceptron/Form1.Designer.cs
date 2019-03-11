namespace Perceptron
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.perceptronBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.weightBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.learningBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iterationBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.positiveRadBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.negativeRadBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.valuatedPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // perceptronBtn
            // 
            this.perceptronBtn.AutoSize = true;
            this.perceptronBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.perceptronBtn.Depth = 0;
            this.perceptronBtn.Icon = null;
            this.perceptronBtn.Location = new System.Drawing.Point(484, 316);
            this.perceptronBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.perceptronBtn.Name = "perceptronBtn";
            this.perceptronBtn.Primary = true;
            this.perceptronBtn.Size = new System.Drawing.Size(108, 36);
            this.perceptronBtn.TabIndex = 1;
            this.perceptronBtn.Text = "Perceptron";
            this.perceptronBtn.UseVisualStyleBackColor = true;
            this.perceptronBtn.Click += new System.EventHandler(this.perceptronBtn_Click);
            // 
            // weightBtn
            // 
            this.weightBtn.AutoSize = true;
            this.weightBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.weightBtn.Depth = 0;
            this.weightBtn.Icon = null;
            this.weightBtn.Location = new System.Drawing.Point(472, 264);
            this.weightBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.weightBtn.Name = "weightBtn";
            this.weightBtn.Primary = true;
            this.weightBtn.Size = new System.Drawing.Size(144, 36);
            this.weightBtn.TabIndex = 0;
            this.weightBtn.Text = "Inicializar Pesos";
            this.weightBtn.UseVisualStyleBackColor = true;
            this.weightBtn.Click += new System.EventHandler(this.weightBtn_Click);
            // 
            // learningBox
            // 
            this.learningBox.BackColor = System.Drawing.Color.White;
            this.learningBox.Depth = 0;
            this.learningBox.Hint = "";
            this.learningBox.Location = new System.Drawing.Point(472, 188);
            this.learningBox.MaxLength = 32767;
            this.learningBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.learningBox.Name = "learningBox";
            this.learningBox.PasswordChar = '\0';
            this.learningBox.SelectedText = "";
            this.learningBox.SelectionLength = 0;
            this.learningBox.SelectionStart = 0;
            this.learningBox.Size = new System.Drawing.Size(197, 23);
            this.learningBox.TabIndex = 3;
            this.learningBox.TabStop = false;
            this.learningBox.Text = "Learning Rate ( η )";
            this.learningBox.UseSystemPasswordChar = false;
            this.learningBox.Click += new System.EventHandler(this.learningBox_Click);
            this.learningBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.learningBox_KeyPress);
            this.learningBox.Leave += new System.EventHandler(this.learningBox_Leave);
            // 
            // iterationBox
            // 
            this.iterationBox.BackColor = System.Drawing.Color.White;
            this.iterationBox.Depth = 0;
            this.iterationBox.Hint = "";
            this.iterationBox.Location = new System.Drawing.Point(472, 138);
            this.iterationBox.MaxLength = 32767;
            this.iterationBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.iterationBox.Name = "iterationBox";
            this.iterationBox.PasswordChar = '\0';
            this.iterationBox.SelectedText = "";
            this.iterationBox.SelectionLength = 0;
            this.iterationBox.SelectionStart = 0;
            this.iterationBox.Size = new System.Drawing.Size(197, 23);
            this.iterationBox.TabIndex = 2;
            this.iterationBox.TabStop = false;
            this.iterationBox.Text = "Num Epocas";
            this.iterationBox.UseSystemPasswordChar = false;
            this.iterationBox.Click += new System.EventHandler(this.iterationBox_Click);
            this.iterationBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iterationBox_KeyPress);
            this.iterationBox.Leave += new System.EventHandler(this.iterationBox_Leave);
            // 
            // positiveRadBtn
            // 
            this.positiveRadBtn.AutoSize = true;
            this.positiveRadBtn.Depth = 0;
            this.positiveRadBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.positiveRadBtn.Location = new System.Drawing.Point(484, 75);
            this.positiveRadBtn.Margin = new System.Windows.Forms.Padding(0);
            this.positiveRadBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.positiveRadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.positiveRadBtn.Name = "positiveRadBtn";
            this.positiveRadBtn.Ripple = true;
            this.positiveRadBtn.Size = new System.Drawing.Size(86, 30);
            this.positiveRadBtn.TabIndex = 5;
            this.positiveRadBtn.Text = "Positivos";
            this.positiveRadBtn.UseVisualStyleBackColor = true;
            // 
            // negativeRadBtn
            // 
            this.negativeRadBtn.AutoSize = true;
            this.negativeRadBtn.Depth = 0;
            this.negativeRadBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.negativeRadBtn.Location = new System.Drawing.Point(578, 75);
            this.negativeRadBtn.Margin = new System.Windows.Forms.Padding(0);
            this.negativeRadBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.negativeRadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.negativeRadBtn.Name = "negativeRadBtn";
            this.negativeRadBtn.Ripple = true;
            this.negativeRadBtn.Size = new System.Drawing.Size(91, 30);
            this.negativeRadBtn.TabIndex = 6;
            this.negativeRadBtn.Text = "Negativos";
            this.negativeRadBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(469, 414);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(147, 36);
            this.materialRaisedButton1.TabIndex = 8;
            this.materialRaisedButton1.Text = "Limpiar Pantalla";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // valuatedPanel
            // 
            this.valuatedPanel.BackColor = System.Drawing.Color.White;
            this.valuatedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valuatedPanel.Location = new System.Drawing.Point(16, 500);
            this.valuatedPanel.Name = "valuatedPanel";
            this.valuatedPanel.Size = new System.Drawing.Size(650, 167);
            this.valuatedPanel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 681);
            this.Controls.Add(this.valuatedPanel);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.negativeRadBtn);
            this.Controls.Add(this.positiveRadBtn);
            this.Controls.Add(this.iterationBox);
            this.Controls.Add(this.learningBox);
            this.Controls.Add(this.weightBtn);
            this.Controls.Add(this.perceptronBtn);
            this.Name = "Form1";
            this.Text = "Perceptron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton perceptronBtn;
        private MaterialSkin.Controls.MaterialRaisedButton weightBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField learningBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField iterationBox;
        private MaterialSkin.Controls.MaterialRadioButton positiveRadBtn;
        private MaterialSkin.Controls.MaterialRadioButton negativeRadBtn;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Panel valuatedPanel;
    }
}

