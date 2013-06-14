namespace BogoSort
{
    partial class Form1
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
            this.txbInput = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbxUnsorted = new System.Windows.Forms.ListBox();
            this.lbxSorted = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(138, 57);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(126, 20);
            this.txbInput.TabIndex = 12;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(138, 141);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(126, 23);
            this.btnSort.TabIndex = 11;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(138, 112);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(126, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbxUnsorted
            // 
            this.lbxUnsorted.FormattingEnabled = true;
            this.lbxUnsorted.Location = new System.Drawing.Point(12, 12);
            this.lbxUnsorted.Name = "lbxUnsorted";
            this.lbxUnsorted.Size = new System.Drawing.Size(120, 264);
            this.lbxUnsorted.TabIndex = 8;
            // 
            // lbxSorted
            // 
            this.lbxSorted.FormattingEnabled = true;
            this.lbxSorted.Location = new System.Drawing.Point(270, 12);
            this.lbxSorted.Name = "lbxSorted";
            this.lbxSorted.Size = new System.Drawing.Size(120, 264);
            this.lbxSorted.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 289);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxUnsorted);
            this.Controls.Add(this.lbxSorted);
            this.Name = "Form1";
            this.Text = "Bogo Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxUnsorted;
        private System.Windows.Forms.ListBox lbxSorted;
    }
}

