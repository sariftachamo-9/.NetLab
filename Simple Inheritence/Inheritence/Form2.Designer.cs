namespace inheritence
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            calculatorToolStripMenuItem = new ToolStripMenuItem();
            timerToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem1 = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            newFolderToolStripMenuItem = new ToolStripMenuItem();
            renameToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            renameToolStripMenuItem1 = new ToolStripMenuItem();
            gitToolStripMenuItem = new ToolStripMenuItem();
            tImerToolStripMenuItem1 = new ToolStripMenuItem();
            enableToolStripMenuItem = new ToolStripMenuItem();
            disableToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 354);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.Location = new Point(25, 142);
            button3.Name = "button3";
            button3.Size = new Size(97, 35);
            button3.TabIndex = 2;
            button3.Text = "Calculator";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(25, 77);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 1;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(25, 10);
            button1.Name = "button1";
            button1.Size = new Size(97, 40);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 100);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(273, 31);
            label1.Name = "label1";
            label1.Size = new Size(257, 37);
            label1.TabIndex = 3;
            label1.Text = "Simple Inheritence";
            label1.Click += label1_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, fileToolStripMenuItem, editToolStripMenuItem, gitToolStripMenuItem, tImerToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(799, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, registerToolStripMenuItem, calculatorToolStripMenuItem, timerToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(128, 22);
            loginToolStripMenuItem.Text = "Login";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(128, 22);
            registerToolStripMenuItem.Text = "Register";
            // 
            // calculatorToolStripMenuItem
            // 
            calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            calculatorToolStripMenuItem.Size = new Size(128, 22);
            calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // timerToolStripMenuItem
            // 
            timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            timerToolStripMenuItem.Size = new Size(128, 22);
            timerToolStripMenuItem.Text = "Timer";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem1, openToolStripMenuItem1, newFolderToolStripMenuItem, renameToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            newToolStripMenuItem1.Size = new Size(134, 22);
            newToolStripMenuItem1.Text = "New";
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(134, 22);
            openToolStripMenuItem1.Text = "Open";
            // 
            // newFolderToolStripMenuItem
            // 
            newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            newFolderToolStripMenuItem.Size = new Size(134, 22);
            newFolderToolStripMenuItem.Text = "New Folder";
            // 
            // renameToolStripMenuItem
            // 
            renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            renameToolStripMenuItem.Size = new Size(134, 22);
            renameToolStripMenuItem.Text = "Rename";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem, copyToolStripMenuItem, deleteToolStripMenuItem, renameToolStripMenuItem1 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(117, 22);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(117, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(117, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // renameToolStripMenuItem1
            // 
            renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
            renameToolStripMenuItem1.Size = new Size(117, 22);
            renameToolStripMenuItem1.Text = "Rename";
            // 
            // gitToolStripMenuItem
            // 
            gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            gitToolStripMenuItem.Size = new Size(34, 20);
            gitToolStripMenuItem.Text = "Git";
            // 
            // tImerToolStripMenuItem1
            // 
            tImerToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { enableToolStripMenuItem, disableToolStripMenuItem });
            tImerToolStripMenuItem1.Name = "tImerToolStripMenuItem1";
            tImerToolStripMenuItem1.Size = new Size(49, 20);
            tImerToolStripMenuItem1.Text = "TImer";
            // 
            // enableToolStripMenuItem
            // 
            enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            enableToolStripMenuItem.Size = new Size(112, 22);
            enableToolStripMenuItem.Text = "Enable";
            enableToolStripMenuItem.Click += enableToolStripMenuItem_Click;
            // 
            // disableToolStripMenuItem
            // 
            disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            disableToolStripMenuItem.Size = new Size(112, 22);
            disableToolStripMenuItem.Text = "Disable";
            disableToolStripMenuItem.Click += disableToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(697, 40);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 5;
            label2.Text = "Timer";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem newFolderToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem1;
        private ToolStripMenuItem gitToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem calculatorToolStripMenuItem;
        private ToolStripMenuItem timerToolStripMenuItem;
        private ToolStripMenuItem tImerToolStripMenuItem1;
        private ToolStripMenuItem enableToolStripMenuItem;
        private ToolStripMenuItem disableToolStripMenuItem;
    }
}