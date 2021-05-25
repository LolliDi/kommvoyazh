
namespace kommvoyazh
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
            this.vvodkolputei = new System.Windows.Forms.TextBox();
            this.sohrrazm = new System.Windows.Forms.Button();
            this.sms = new System.Windows.Forms.Label();
            this.mas = new System.Windows.Forms.DataGridView();
            this.Vvodmas = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.otvet = new System.Windows.Forms.TextBox();
            this.restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mas)).BeginInit();
            this.SuspendLayout();
            // 
            // vvodkolputei
            // 
            this.vvodkolputei.Location = new System.Drawing.Point(199, 99);
            this.vvodkolputei.Name = "vvodkolputei";
            this.vvodkolputei.Size = new System.Drawing.Size(148, 23);
            this.vvodkolputei.TabIndex = 0;
            this.vvodkolputei.TextChanged += new System.EventHandler(this.vvodkolputei_TextChanged);
            // 
            // sohrrazm
            // 
            this.sohrrazm.ForeColor = System.Drawing.Color.Black;
            this.sohrrazm.Location = new System.Drawing.Point(225, 166);
            this.sohrrazm.Name = "sohrrazm";
            this.sohrrazm.Size = new System.Drawing.Size(89, 29);
            this.sohrrazm.TabIndex = 1;
            this.sohrrazm.Text = "button1";
            this.sohrrazm.UseVisualStyleBackColor = true;
            this.sohrrazm.Click += new System.EventHandler(this.sohrrazm_Click);
            // 
            // sms
            // 
            this.sms.AutoSize = true;
            this.sms.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.sms.Location = new System.Drawing.Point(12, 292);
            this.sms.Name = "sms";
            this.sms.Size = new System.Drawing.Size(0, 15);
            this.sms.TabIndex = 2;
            // 
            // mas
            // 
            this.mas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mas.Location = new System.Drawing.Point(12, 12);
            this.mas.Name = "mas";
            this.mas.RowTemplate.Height = 25;
            this.mas.Size = new System.Drawing.Size(566, 263);
            this.mas.TabIndex = 3;
            this.mas.Visible = false;
            // 
            // Vvodmas
            // 
            this.Vvodmas.ForeColor = System.Drawing.Color.Black;
            this.Vvodmas.Location = new System.Drawing.Point(225, 274);
            this.Vvodmas.Name = "Vvodmas";
            this.Vvodmas.Size = new System.Drawing.Size(99, 36);
            this.Vvodmas.TabIndex = 4;
            this.Vvodmas.Text = "Сохранить";
            this.Vvodmas.UseVisualStyleBackColor = true;
            this.Vvodmas.Visible = false;
            this.Vvodmas.Click += new System.EventHandler(this.Vvodmas_Click);
            // 
            // next
            // 
            this.next.ForeColor = System.Drawing.Color.Black;
            this.next.Location = new System.Drawing.Point(503, 281);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 5;
            this.next.Text = "Далее";
            this.next.UseVisualStyleBackColor = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // otvet
            // 
            this.otvet.Location = new System.Drawing.Point(12, 12);
            this.otvet.Multiline = true;
            this.otvet.Name = "otvet";
            this.otvet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.otvet.Size = new System.Drawing.Size(566, 263);
            this.otvet.TabIndex = 6;
            this.otvet.Visible = false;
            // 
            // restart
            // 
            this.restart.ForeColor = System.Drawing.Color.Black;
            this.restart.Location = new System.Drawing.Point(225, 274);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(99, 36);
            this.restart.TabIndex = 7;
            this.restart.Text = "Начать заново";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 316);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.otvet);
            this.Controls.Add(this.next);
            this.Controls.Add(this.Vvodmas);
            this.Controls.Add(this.mas);
            this.Controls.Add(this.sms);
            this.Controls.Add(this.sohrrazm);
            this.Controls.Add(this.vvodkolputei);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vvodkolputei;
        private System.Windows.Forms.Button sohrrazm;
        private System.Windows.Forms.Label sms;
        private System.Windows.Forms.DataGridView mas;
        private System.Windows.Forms.Button Vvodmas;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox otvet;
        private System.Windows.Forms.Button restart;
    }
}

