namespace FilmCataloger
{
    partial class Greeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Greeting));
            this.butAdd = new System.Windows.Forms.Button();
            this.butView = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.pnView = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.Transparent;
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butAdd.ForeColor = System.Drawing.Color.Black;
            this.butAdd.Location = new System.Drawing.Point(26, 318);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(226, 56);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butView
            // 
            this.butView.BackColor = System.Drawing.Color.Transparent;
            this.butView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butView.ForeColor = System.Drawing.Color.Black;
            this.butView.Location = new System.Drawing.Point(283, 318);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(226, 56);
            this.butView.TabIndex = 2;
            this.butView.Text = "Просмотр/Изменить";
            this.butView.UseVisualStyleBackColor = false;
            this.butView.Click += new System.EventHandler(this.butView_Click);
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.Transparent;
            this.butSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSearch.ForeColor = System.Drawing.Color.Black;
            this.butSearch.Location = new System.Drawing.Point(545, 318);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(226, 56);
            this.butSearch.TabIndex = 4;
            this.butSearch.Text = "Поиск";
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // pnView
            // 
            this.pnView.BackColor = System.Drawing.Color.White;
            this.pnView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnView.Controls.Add(this.label1);
            this.pnView.Controls.Add(this.butExit);
            this.pnView.Controls.Add(this.butSearch);
            this.pnView.Controls.Add(this.butView);
            this.pnView.Controls.Add(this.butAdd);
            this.pnView.Controls.Add(this.pictureBox1);
            this.pnView.Location = new System.Drawing.Point(-16, -28);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(778, 545);
            this.pnView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 108);
            this.label1.TabIndex = 8;
            this.label1.Text = "МОИ ФИЛЬМЫ";
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Transparent;
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.ForeColor = System.Drawing.Color.Black;
            this.butExit.Location = new System.Drawing.Point(670, 509);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(106, 29);
            this.butExit.TabIndex = 6;
            this.butExit.Text = "Выход";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 154);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(762, 518);
            this.Controls.Add(this.pnView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Greeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильмы";
            this.Load += new System.EventHandler(this.Greeting_Load);
            this.pnView.ResumeLayout(false);
            this.pnView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butView;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Panel pnView;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

