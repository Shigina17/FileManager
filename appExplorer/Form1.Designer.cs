
namespace appExplorer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.screen = new System.Windows.Forms.ListView();
            this.mainFileNameLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.mainFileTypeLabe = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.Firebrick;
            this.backButton.Location = new System.Drawing.Point(13, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 32);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goButton
            // 
            this.goButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.goButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.goButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goButton.ForeColor = System.Drawing.Color.Firebrick;
            this.goButton.Location = new System.Drawing.Point(739, 5);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(85, 32);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Вперед";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(106, 8);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(626, 22);
            this.filePathTextBox.TabIndex = 2;
            // 
            // screen
            // 
            this.screen.HideSelection = false;
            this.screen.LargeImageList = this.iconList;
            this.screen.Location = new System.Drawing.Point(-2, 41);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(840, 391);
            this.screen.SmallImageList = this.iconList;
            this.screen.TabIndex = 3;
            this.screen.UseCompatibleStateImageBehavior = false;
            this.screen.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.screen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // mainFileNameLabel
            // 
            this.mainFileNameLabel.AutoSize = true;
            this.mainFileNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFileNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainFileNameLabel.Location = new System.Drawing.Point(10, 448);
            this.mainFileNameLabel.Name = "mainFileNameLabel";
            this.mainFileNameLabel.Size = new System.Drawing.Size(88, 17);
            this.mainFileNameLabel.TabIndex = 4;
            this.mainFileNameLabel.Text = "Имя файла:";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameLabel.Location = new System.Drawing.Point(103, 448);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(18, 17);
            this.fileNameLabel.TabIndex = 5;
            this.fileNameLabel.Text = "--";
            // 
            // mainFileTypeLabe
            // 
            this.mainFileTypeLabe.AutoSize = true;
            this.mainFileTypeLabe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFileTypeLabe.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainFileTypeLabe.Location = new System.Drawing.Point(516, 448);
            this.mainFileTypeLabe.Name = "mainFileTypeLabe";
            this.mainFileTypeLabe.Size = new System.Drawing.Size(83, 17);
            this.mainFileTypeLabe.TabIndex = 6;
            this.mainFileTypeLabe.Text = "Тип файла:";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileTypeLabel.Location = new System.Drawing.Point(606, 448);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(18, 17);
            this.fileTypeLabel.TabIndex = 7;
            this.fileTypeLabel.Text = "--";
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "folder.png");
            this.iconList.Images.SetKeyName(1, "folder2.png");
            this.iconList.Images.SetKeyName(2, "file.png");
            this.iconList.Images.SetKeyName(3, "doc.png");
            this.iconList.Images.SetKeyName(4, "pdf.png");
            this.iconList.Images.SetKeyName(5, "mp3.png");
            this.iconList.Images.SetKeyName(6, "mp4.png");
            this.iconList.Images.SetKeyName(7, "exe.png");
            this.iconList.Images.SetKeyName(8, "unknown.png");
            this.iconList.Images.SetKeyName(9, "png.png");
            this.iconList.Images.SetKeyName(10, "folder64.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 474);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.mainFileTypeLabe);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.mainFileNameLabel);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(853, 521);
            this.MinimumSize = new System.Drawing.Size(853, 521);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мой диск. Данные";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.ListView screen;
        private System.Windows.Forms.Label mainFileNameLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label mainFileTypeLabe;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.ImageList iconList;
    }
}

