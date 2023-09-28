namespace baithuchanh3.bai1
{
    partial class Mynameproject
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
            this.components = new System.ComponentModel.Container();
            this.lbyourname = new System.Windows.Forms.Label();
            this.lbyob = new System.Windows.Forms.Label();
            this.txtyourname = new System.Windows.Forms.TextBox();
            this.txtyob = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbyourname
            // 
            this.lbyourname.AutoSize = true;
            this.lbyourname.Location = new System.Drawing.Point(72, 31);
            this.lbyourname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbyourname.Name = "lbyourname";
            this.lbyourname.Size = new System.Drawing.Size(83, 18);
            this.lbyourname.TabIndex = 0;
            this.lbyourname.Text = "Your Name";
            // 
            // lbyob
            // 
            this.lbyob.AutoSize = true;
            this.lbyob.Location = new System.Drawing.Point(72, 102);
            this.lbyob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbyob.Name = "lbyob";
            this.lbyob.Size = new System.Drawing.Size(94, 18);
            this.lbyob.TabIndex = 1;
            this.lbyob.Text = "Year Of Birth";
            // 
            // txtyourname
            // 
            this.txtyourname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyourname.Location = new System.Drawing.Point(191, 31);
            this.txtyourname.Margin = new System.Windows.Forms.Padding(4);
            this.txtyourname.Name = "txtyourname";
            this.txtyourname.Size = new System.Drawing.Size(273, 26);
            this.txtyourname.TabIndex = 2;
            this.txtyourname.Leave += new System.EventHandler(this.txtyourname_Leave);
            // 
            // txtyob
            // 
            this.txtyob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyob.Location = new System.Drawing.Point(191, 100);
            this.txtyob.Margin = new System.Windows.Forms.Padding(4);
            this.txtyob.Name = "txtyob";
            this.txtyob.Size = new System.Drawing.Size(273, 26);
            this.txtyob.TabIndex = 3;
            this.txtyob.TextChanged += new System.EventHandler(this.txtyob_TextChanged);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(75, 164);
            this.btnshow.Margin = new System.Windows.Forms.Padding(4);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(100, 32);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(235, 164);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(100, 32);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Location = new System.Drawing.Point(393, 164);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 32);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Mynameproject
            // 
            this.AcceptButton = this.btnshow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(538, 224);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtyob);
            this.Controls.Add(this.txtyourname);
            this.Controls.Add(this.lbyob);
            this.Controls.Add(this.lbyourname);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mynameproject";
            this.Text = "My name project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mynameproject_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbyourname;
        private System.Windows.Forms.Label lbyob;
        private System.Windows.Forms.TextBox txtyourname;
        private System.Windows.Forms.TextBox txtyob;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

