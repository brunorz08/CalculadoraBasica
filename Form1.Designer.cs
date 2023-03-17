namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titulo = new Label();
            text1 = new TextBox();
            numero1 = new Label();
            numero2 = new Label();
            text2 = new TextBox();
            suma = new Button();
            division = new Button();
            multiplicacion = new Button();
            resta = new Button();
            label1 = new Label();
            textresultado = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoEllipsis = true;
            titulo.BackColor = SystemColors.ActiveCaptionText;
            titulo.BorderStyle = BorderStyle.FixedSingle;
            titulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titulo.ForeColor = SystemColors.MenuHighlight;
            titulo.Location = new Point(90, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(185, 48);
            titulo.TabIndex = 0;
            titulo.Text = "CALCULADORA";
            titulo.TextAlign = ContentAlignment.TopCenter;
            titulo.Click += label1_Click;
            // 
            // text1
            // 
            text1.BackColor = Color.White;
            text1.Location = new Point(90, 168);
            text1.Name = "text1";
            text1.Size = new Size(100, 23);
            text1.TabIndex = 1;
            // 
            // numero1
            // 
            numero1.AutoEllipsis = true;
            numero1.BackColor = SystemColors.ActiveCaptionText;
            numero1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numero1.ForeColor = SystemColors.MenuHighlight;
            numero1.Location = new Point(12, 168);
            numero1.Name = "numero1";
            numero1.Size = new Size(72, 23);
            numero1.TabIndex = 2;
            numero1.Text = "Numero 1";
            // 
            // numero2
            // 
            numero2.AutoEllipsis = true;
            numero2.BackColor = SystemColors.ActiveCaptionText;
            numero2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numero2.ForeColor = SystemColors.MenuHighlight;
            numero2.Location = new Point(12, 210);
            numero2.Name = "numero2";
            numero2.Size = new Size(72, 23);
            numero2.TabIndex = 3;
            numero2.Text = "Numero 2";
            // 
            // text2
            // 
            text2.Location = new Point(90, 209);
            text2.Name = "text2";
            text2.Size = new Size(100, 23);
            text2.TabIndex = 4;
            // 
            // suma
            // 
            suma.Location = new Point(240, 168);
            suma.Name = "suma";
            suma.Size = new Size(23, 23);
            suma.TabIndex = 5;
            suma.Text = "+";
            suma.UseVisualStyleBackColor = true;
            suma.Click += suma_Click;
            // 
            // division
            // 
            division.Location = new Point(291, 210);
            division.Name = "division";
            division.Size = new Size(23, 23);
            division.TabIndex = 6;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += division_Click;
            // 
            // multiplicacion
            // 
            multiplicacion.BackColor = Color.White;
            multiplicacion.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            multiplicacion.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            multiplicacion.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            multiplicacion.ImageAlign = ContentAlignment.MiddleLeft;
            multiplicacion.Location = new Point(240, 210);
            multiplicacion.Name = "multiplicacion";
            multiplicacion.RightToLeft = RightToLeft.No;
            multiplicacion.Size = new Size(23, 23);
            multiplicacion.TabIndex = 7;
            multiplicacion.Text = "*";
            multiplicacion.UseVisualStyleBackColor = false;
            multiplicacion.Click += multiplicacion_Click;
            // 
            // resta
            // 
            resta.Location = new Point(291, 168);
            resta.Name = "resta";
            resta.Size = new Size(23, 23);
            resta.TabIndex = 8;
            resta.Text = "-";
            resta.UseVisualStyleBackColor = true;
            resta.Click += resta_Click;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 248);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 9;
            label1.Text = "Resultado";
            // 
            // textresultado
            // 
            textresultado.Location = new Point(90, 248);
            textresultado.Name = "textresultado";
            textresultado.Size = new Size(100, 23);
            textresultado.TabIndex = 10;
            textresultado.TextChanged += textresultado_TextChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(240, 248);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(354, 340);
            Controls.Add(button1);
            Controls.Add(textresultado);
            Controls.Add(label1);
            Controls.Add(resta);
            Controls.Add(multiplicacion);
            Controls.Add(division);
            Controls.Add(suma);
            Controls.Add(text2);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Controls.Add(text1);
            Controls.Add(titulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private TextBox text1;
        private Label numero1;
        private Label numero2;
        private TextBox text2;
        private Button suma;
        private Button division;
        private Button multiplicacion;
        private Button resta;
        private Label label1;
        private TextBox textresultado;
        private Button button1;
    }
}