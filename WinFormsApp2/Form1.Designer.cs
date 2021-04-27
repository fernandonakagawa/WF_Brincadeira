
namespace WinFormsApp2
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
            this.btOk = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbDigite = new System.Windows.Forms.Label();
            this.cbMostrar = new System.Windows.Forms.CheckBox();
            this.lbContador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(276, 174);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(158, 49);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(276, 117);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.PasswordChar = '*';
            this.tbNome.Size = new System.Drawing.Size(158, 23);
            this.tbNome.TabIndex = 1;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // lbDigite
            // 
            this.lbDigite.AutoSize = true;
            this.lbDigite.Location = new System.Drawing.Point(276, 79);
            this.lbDigite.Name = "lbDigite";
            this.lbDigite.Size = new System.Drawing.Size(106, 15);
            this.lbDigite.TabIndex = 2;
            this.lbDigite.Text = "Digite o seu nome:";
            // 
            // cbMostrar
            // 
            this.cbMostrar.AutoSize = true;
            this.cbMostrar.Location = new System.Drawing.Point(516, 120);
            this.cbMostrar.Name = "cbMostrar";
            this.cbMostrar.Size = new System.Drawing.Size(103, 19);
            this.cbMostrar.TabIndex = 3;
            this.cbMostrar.Text = "Mostrar Nome";
            this.cbMostrar.UseVisualStyleBackColor = true;
            this.cbMostrar.CheckedChanged += new System.EventHandler(this.cbMostrar_CheckedChanged);
            // 
            // lbContador
            // 
            this.lbContador.AutoSize = true;
            this.lbContador.Location = new System.Drawing.Point(440, 121);
            this.lbContador.Name = "lbContador";
            this.lbContador.Size = new System.Drawing.Size(13, 15);
            this.lbContador.TabIndex = 4;
            this.lbContador.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(734, 414);
            this.Controls.Add(this.lbContador);
            this.Controls.Add(this.cbMostrar);
            this.Controls.Add(this.lbDigite);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btOk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbDigite;
        private System.Windows.Forms.CheckBox cbMostrar;
        private System.Windows.Forms.Label lbContador;
    }
}

