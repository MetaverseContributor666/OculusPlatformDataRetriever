namespace OculusPlatformDataRetriever
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OculusAppSecrectTxt = new System.Windows.Forms.TextBox();
            this.OculusAppIDTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oculus AppID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(49, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oculus AppSecrect:";
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDown.Location = new System.Drawing.Point(294, 280);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(263, 63);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "DownLoad";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(109, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(660, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "DownLoad Server Configuration From Oculus Platform";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OculusAppSecrectTxt
            // 
            this.OculusAppSecrectTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::OculusPlatformDataRetriever.Properties.Settings.Default, "AppSecrect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OculusAppSecrectTxt.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OculusAppSecrectTxt.Location = new System.Drawing.Point(317, 199);
            this.OculusAppSecrectTxt.Name = "OculusAppSecrectTxt";
            this.OculusAppSecrectTxt.Size = new System.Drawing.Size(479, 38);
            this.OculusAppSecrectTxt.TabIndex = 3;
            this.OculusAppSecrectTxt.Text = global::OculusPlatformDataRetriever.Properties.Settings.Default.AppSecrect;
            // 
            // OculusAppIDTxt
            // 
            this.OculusAppIDTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::OculusPlatformDataRetriever.Properties.Settings.Default, "AppID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OculusAppIDTxt.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OculusAppIDTxt.Location = new System.Drawing.Point(317, 115);
            this.OculusAppIDTxt.Name = "OculusAppIDTxt";
            this.OculusAppIDTxt.Size = new System.Drawing.Size(479, 38);
            this.OculusAppIDTxt.TabIndex = 2;
            this.OculusAppIDTxt.Text = global::OculusPlatformDataRetriever.Properties.Settings.Default.AppID;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.OculusAppSecrectTxt);
            this.Controls.Add(this.OculusAppIDTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OculusPlatformDataRetriever";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OculusAppIDTxt;
        private System.Windows.Forms.TextBox OculusAppSecrectTxt;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label label3;
    }
}

