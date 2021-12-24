
namespace choinka
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.buttonDrzewo = new System.Windows.Forms.Button();
            this.buttonPrezent = new System.Windows.Forms.Button();
            this.buttonGwiazda = new System.Windows.Forms.Button();
            this.buttonBombki = new System.Windows.Forms.Button();
            this.buttonLancuchy = new System.Windows.Forms.Button();
            this.buttonSwiatelka = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(536, 426);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // buttonDrzewo
            // 
            this.buttonDrzewo.Location = new System.Drawing.Point(599, 30);
            this.buttonDrzewo.Name = "buttonDrzewo";
            this.buttonDrzewo.Size = new System.Drawing.Size(75, 23);
            this.buttonDrzewo.TabIndex = 1;
            this.buttonDrzewo.Text = "Drzewo";
            this.buttonDrzewo.UseVisualStyleBackColor = true;
            this.buttonDrzewo.Click += new System.EventHandler(this.buttonDrzewo_Click);
            // 
            // buttonPrezent
            // 
            this.buttonPrezent.Location = new System.Drawing.Point(599, 112);
            this.buttonPrezent.Name = "buttonPrezent";
            this.buttonPrezent.Size = new System.Drawing.Size(75, 23);
            this.buttonPrezent.TabIndex = 2;
            this.buttonPrezent.Text = "Prezent";
            this.buttonPrezent.UseVisualStyleBackColor = true;
            this.buttonPrezent.Click += new System.EventHandler(this.buttonPrezent_Click);
            // 
            // buttonGwiazda
            // 
            this.buttonGwiazda.Location = new System.Drawing.Point(599, 168);
            this.buttonGwiazda.Name = "buttonGwiazda";
            this.buttonGwiazda.Size = new System.Drawing.Size(75, 23);
            this.buttonGwiazda.TabIndex = 3;
            this.buttonGwiazda.Text = "Gwiazda";
            this.buttonGwiazda.UseVisualStyleBackColor = true;
            this.buttonGwiazda.Click += new System.EventHandler(this.buttonGwiazda_Click);
            // 
            // buttonBombki
            // 
            this.buttonBombki.Location = new System.Drawing.Point(599, 221);
            this.buttonBombki.Name = "buttonBombki";
            this.buttonBombki.Size = new System.Drawing.Size(75, 23);
            this.buttonBombki.TabIndex = 4;
            this.buttonBombki.Text = "Bombki";
            this.buttonBombki.UseVisualStyleBackColor = true;
            this.buttonBombki.Click += new System.EventHandler(this.buttonBombki_Click_1);
            // 
            // buttonLancuchy
            // 
            this.buttonLancuchy.Location = new System.Drawing.Point(599, 70);
            this.buttonLancuchy.Name = "buttonLancuchy";
            this.buttonLancuchy.Size = new System.Drawing.Size(75, 23);
            this.buttonLancuchy.TabIndex = 5;
            this.buttonLancuchy.Text = "Lancuchy";
            this.buttonLancuchy.UseVisualStyleBackColor = true;
            this.buttonLancuchy.Click += new System.EventHandler(this.buttonLancuchy_Click);
            // 
            // buttonSwiatelka
            // 
            this.buttonSwiatelka.Location = new System.Drawing.Point(599, 273);
            this.buttonSwiatelka.Name = "buttonSwiatelka";
            this.buttonSwiatelka.Size = new System.Drawing.Size(75, 23);
            this.buttonSwiatelka.TabIndex = 6;
            this.buttonSwiatelka.Text = "Swiatelka";
            this.buttonSwiatelka.UseVisualStyleBackColor = true;
            this.buttonSwiatelka.Click += new System.EventHandler(this.buttonSwiatelka_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(599, 378);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonUsun.TabIndex = 7;
            this.buttonUsun.Text = "Usun";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(583, 322);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 452);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonSwiatelka);
            this.Controls.Add(this.buttonLancuchy);
            this.Controls.Add(this.buttonBombki);
            this.Controls.Add(this.buttonGwiazda);
            this.Controls.Add(this.buttonPrezent);
            this.Controls.Add(this.buttonDrzewo);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Choinka";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonDrzewo;
        private System.Windows.Forms.Button buttonPrezent;
        private System.Windows.Forms.Button buttonGwiazda;
        private System.Windows.Forms.Button buttonBombki;
        private System.Windows.Forms.Button buttonLancuchy;
        private System.Windows.Forms.Button buttonSwiatelka;
        private System.Windows.Forms.Button buttonUsun;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

