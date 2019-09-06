namespace CbarService
{
    partial class MainForm
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
            this.datetime_pick = new System.Windows.Forms.DateTimePicker();
            this.btn_loadExchangeInfo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // datetime_pick
            // 
            this.datetime_pick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_pick.Location = new System.Drawing.Point(12, 12);
            this.datetime_pick.Name = "datetime_pick";
            this.datetime_pick.Size = new System.Drawing.Size(164, 20);
            this.datetime_pick.TabIndex = 0;
            // 
            // btn_loadExchangeInfo
            // 
            this.btn_loadExchangeInfo.Location = new System.Drawing.Point(194, 9);
            this.btn_loadExchangeInfo.Name = "btn_loadExchangeInfo";
            this.btn_loadExchangeInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_loadExchangeInfo.TabIndex = 1;
            this.btn_loadExchangeInfo.Text = "Load";
            this.btn_loadExchangeInfo.UseVisualStyleBackColor = true;
            this.btn_loadExchangeInfo.Click += new System.EventHandler(this.Btn_loadExchangeInfo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(738, 368);
            this.listBox1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_loadExchangeInfo);
            this.Controls.Add(this.datetime_pick);
            this.Name = "MainForm";
            this.Text = "CbarCurrency";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetime_pick;
        private System.Windows.Forms.Button btn_loadExchangeInfo;
        private System.Windows.Forms.ListBox listBox1;
    }
}

