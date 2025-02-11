namespace multi_telas
{
    partial class form2
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
            this.btn_primeira = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_primeira
            // 
            this.btn_primeira.BackColor = System.Drawing.Color.Transparent;
            this.btn_primeira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_primeira.ForeColor = System.Drawing.Color.Transparent;
            this.btn_primeira.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_primeira.Location = new System.Drawing.Point(715, 12);
            this.btn_primeira.Name = "btn_primeira";
            this.btn_primeira.Size = new System.Drawing.Size(73, 51);
            this.btn_primeira.TabIndex = 0;
            this.btn_primeira.Text = "Voltar";
            this.btn_primeira.UseVisualStyleBackColor = false;
            this.btn_primeira.Click += new System.EventHandler(this.btn_primeira_Click);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_primeira);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_primeira;
    }
}