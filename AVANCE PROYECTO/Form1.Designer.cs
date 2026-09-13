namespace AVANCE_PROYECTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbltitulo = new Label();
            btniniciar = new Button();
            label1 = new Label();
            picimagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picimagen).BeginInit();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Thistle;
            lbltitulo.Font = new Font("Broadway", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = SystemColors.ActiveCaptionText;
            lbltitulo.Location = new Point(16, 26);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(381, 31);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "THE BOOKWORM SOCIETY";
            // 
            // btniniciar
            // 
            btniniciar.BackColor = Color.WhiteSmoke;
            btniniciar.Font = new Font("Britannic Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btniniciar.ForeColor = Color.Black;
            btniniciar.Location = new Point(137, 298);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(138, 33);
            btniniciar.TabIndex = 1;
            btniniciar.Text = "INICIAR";
            btniniciar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Lucida Calligraphy", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(30, 382);
            label1.Name = "label1";
            label1.Size = new Size(367, 19);
            label1.TabIndex = 2;
            label1.Text = "Tus libros, tus reseñas, tu historia de lectura.";
            label1.Click += label1_Click;
            // 
            // picimagen
            // 
            picimagen.BackgroundImageLayout = ImageLayout.Stretch;
            picimagen.BorderStyle = BorderStyle.FixedSingle;
            picimagen.Image = (Image)resources.GetObject("picimagen.Image");
            picimagen.InitialImage = (Image)resources.GetObject("picimagen.InitialImage");
            picimagen.Location = new Point(137, 77);
            picimagen.Name = "picimagen";
            picimagen.Size = new Size(138, 176);
            picimagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picimagen.TabIndex = 3;
            picimagen.TabStop = false;
            picimagen.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(416, 445);
            Controls.Add(picimagen);
            Controls.Add(label1);
            Controls.Add(btniniciar);
            Controls.Add(lbltitulo);
            Name = "Form1";
            Text = "Mis libros";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picimagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Button btniniciar;
        private Label label1;
        private PictureBox picimagen;
    }
}
