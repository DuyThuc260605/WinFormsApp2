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
            menuStrip1 = new MenuStrip();
            addInvoiceToolStripMenuItem = new ToolStripMenuItem();
            managerInvoiceToolStripMenuItem = new ToolStripMenuItem();
            managerInvoices = new ManagerInvoice();
            addInvoices = new AdInvoice();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addInvoiceToolStripMenuItem, managerInvoiceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addInvoiceToolStripMenuItem
            // 
            addInvoiceToolStripMenuItem.Name = "addInvoiceToolStripMenuItem";
            addInvoiceToolStripMenuItem.Size = new Size(72, 20);
            addInvoiceToolStripMenuItem.Text = "AdInvoice";
            addInvoiceToolStripMenuItem.Click += addInvoiceToolStripMenuItem_Click;
            // 
            // managerInvoiceToolStripMenuItem
            // 
            managerInvoiceToolStripMenuItem.Name = "managerInvoiceToolStripMenuItem";
            managerInvoiceToolStripMenuItem.Size = new Size(104, 20);
            managerInvoiceToolStripMenuItem.Text = "ManagerInvoice";
            managerInvoiceToolStripMenuItem.Click += managerInvoiceToolStripMenuItem_Click;
            // 
            // managerInvoices
            // 
            managerInvoices.Location = new Point(0, 27);
            managerInvoices.Name = "managerInvoices";
            managerInvoices.Size = new Size(800, 299);
            managerInvoices.TabIndex = 1;
            // 
            // addInvoices
            // 
            addInvoices.Location = new Point(0, 27);
            addInvoices.Name = "addInvoices";
            addInvoices.Size = new Size(972, 626);
            addInvoices.TabIndex = 2;
            addInvoices.Load += adInvoice1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addInvoices);
            Controls.Add(managerInvoices);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addInvoiceToolStripMenuItem;
        private ToolStripMenuItem managerInvoiceToolStripMenuItem;
        private ManagerInvoice managerInvoices;
        private AdInvoice addInvoices;
    }
}
