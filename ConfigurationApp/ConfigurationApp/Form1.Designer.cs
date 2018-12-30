namespace ConfigurationApp
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRawJson = new System.Windows.Forms.TextBox();
            this.btnPrepJson = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUploadExcel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_UploadPurohita = new System.Windows.Forms.Button();
            this.btnYaagnikam = new System.Windows.Forms.Button();
            this.btnAshramamItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter The RAW Json Here :";
            // 
            // txtRawJson
            // 
            this.txtRawJson.Location = new System.Drawing.Point(236, 30);
            this.txtRawJson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRawJson.Multiline = true;
            this.txtRawJson.Name = "txtRawJson";
            this.txtRawJson.Size = new System.Drawing.Size(1138, 116);
            this.txtRawJson.TabIndex = 1;
            this.txtRawJson.TextChanged += new System.EventHandler(this.txtRawJson_TextChanged);
            // 
            // btnPrepJson
            // 
            this.btnPrepJson.Location = new System.Drawing.Point(1179, 175);
            this.btnPrepJson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrepJson.Name = "btnPrepJson";
            this.btnPrepJson.Size = new System.Drawing.Size(195, 41);
            this.btnPrepJson.TabIndex = 2;
            this.btnPrepJson.Text = "Prepare My JSON";
            this.btnPrepJson.UseVisualStyleBackColor = true;
            this.btnPrepJson.Click += new System.EventHandler(this.btnPrepJson_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnUploadExcel
            // 
            this.btnUploadExcel.Location = new System.Drawing.Point(236, 188);
            this.btnUploadExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUploadExcel.Name = "btnUploadExcel";
            this.btnUploadExcel.Size = new System.Drawing.Size(163, 28);
            this.btnUploadExcel.TabIndex = 3;
            this.btnUploadExcel.Text = "Upload Directory Excel";
            this.btnUploadExcel.UseVisualStyleBackColor = true;
            this.btnUploadExcel.Click += new System.EventHandler(this.btnUploadExcel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(236, 251);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1138, 333);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_UploadPurohita
            // 
            this.btn_UploadPurohita.Location = new System.Drawing.Point(836, 188);
            this.btn_UploadPurohita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_UploadPurohita.Name = "btn_UploadPurohita";
            this.btn_UploadPurohita.Size = new System.Drawing.Size(158, 28);
            this.btn_UploadPurohita.TabIndex = 6;
            this.btn_UploadPurohita.Text = "Upload Aparam Excel";
            this.btn_UploadPurohita.UseVisualStyleBackColor = true;
            this.btn_UploadPurohita.Click += new System.EventHandler(this.btn_UploadPurohita_Click);
            // 
            // btnYaagnikam
            // 
            this.btnYaagnikam.Location = new System.Drawing.Point(1013, 188);
            this.btnYaagnikam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYaagnikam.Name = "btnYaagnikam";
            this.btnYaagnikam.Size = new System.Drawing.Size(158, 28);
            this.btnYaagnikam.TabIndex = 7;
            this.btnYaagnikam.Text = "Upload Yaagnikam Excel";
            this.btnYaagnikam.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnYaagnikam.UseVisualStyleBackColor = true;
            this.btnYaagnikam.Click += new System.EventHandler(this.btnYaagnikam_Click);
            // 
            // btnAshramamItems
            // 
            this.btnAshramamItems.Location = new System.Drawing.Point(407, 188);
            this.btnAshramamItems.Name = "btnAshramamItems";
            this.btnAshramamItems.Size = new System.Drawing.Size(163, 27);
            this.btnAshramamItems.TabIndex = 8;
            this.btnAshramamItems.Text = "Upload Ashram Items";
            this.btnAshramamItems.UseVisualStyleBackColor = true;
            this.btnAshramamItems.Click += new System.EventHandler(this.btnAshramamItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 630);
            this.Controls.Add(this.btnAshramamItems);
            this.Controls.Add(this.btnYaagnikam);
            this.Controls.Add(this.btn_UploadPurohita);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnUploadExcel);
            this.Controls.Add(this.btnPrepJson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRawJson);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRawJson;
        private System.Windows.Forms.Button btnPrepJson;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUploadExcel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btn_UploadPurohita;
        private System.Windows.Forms.Button btnYaagnikam;
        private System.Windows.Forms.Button btnAshramamItems;
    }
}

