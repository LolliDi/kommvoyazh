
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(this.vvodkolputei, "vvodkolputei");
            this.vvodkolputei.Name = "vvodkolputei";
            this.vvodkolputei.TextChanged += new System.EventHandler(this.vvodkolputei_TextChanged);
            // 
            // sohrrazm
            // 
            this.sohrrazm.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.sohrrazm, "sohrrazm");
            this.sohrrazm.Name = "sohrrazm";
            this.sohrrazm.UseVisualStyleBackColor = true;
            this.sohrrazm.Click += new System.EventHandler(this.sohrrazm_Click);
            // 
            // sms
            // 
            resources.ApplyResources(this.sms, "sms");
            this.sms.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.sms.Name = "sms";
            // 
            // mas
            // 
            this.mas.AllowUserToAddRows = false;
            this.mas.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.mas, "mas");
            this.mas.Name = "mas";
            this.mas.RowTemplate.Height = 25;
            // 
            // Vvodmas
            // 
            this.Vvodmas.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.Vvodmas, "Vvodmas");
            this.Vvodmas.Name = "Vvodmas";
            this.Vvodmas.UseVisualStyleBackColor = true;
            this.Vvodmas.Click += new System.EventHandler(this.Vvodmas_Click);
            // 
            // next
            // 
            this.next.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.next, "next");
            this.next.Name = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // otvet
            // 
            resources.ApplyResources(this.otvet, "otvet");
            this.otvet.Name = "otvet";
            // 
            // restart
            // 
            this.restart.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.restart, "restart");
            this.restart.Name = "restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

