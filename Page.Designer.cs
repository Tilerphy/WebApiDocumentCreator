namespace WebApiDocumentCreator
{
    partial class Page
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hasContentType = new System.Windows.Forms.CheckBox();
            this.hasResponseHeader = new System.Windows.Forms.CheckBox();
            this.hasResponseBody = new System.Windows.Forms.CheckBox();
            this.hasRequestHeader = new System.Windows.Forms.CheckBox();
            this.hasRequestData = new System.Windows.Forms.CheckBox();
            this.hasMethod = new System.Windows.Forms.CheckBox();
            this.exportTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.useTemplate = new System.Windows.Forms.CheckBox();
            this.outputTemplate = new System.Windows.Forms.RichTextBox();
            this.note = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hasContentType
            // 
            this.hasContentType.AutoSize = true;
            this.hasContentType.Checked = true;
            this.hasContentType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hasContentType.Location = new System.Drawing.Point(16, 22);
            this.hasContentType.Name = "hasContentType";
            this.hasContentType.Size = new System.Drawing.Size(90, 17);
            this.hasContentType.TabIndex = 0;
            this.hasContentType.Text = "Content-Type";
            this.hasContentType.UseVisualStyleBackColor = true;
            // 
            // hasResponseHeader
            // 
            this.hasResponseHeader.AutoSize = true;
            this.hasResponseHeader.Checked = true;
            this.hasResponseHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hasResponseHeader.Location = new System.Drawing.Point(139, 22);
            this.hasResponseHeader.Name = "hasResponseHeader";
            this.hasResponseHeader.Size = new System.Drawing.Size(112, 17);
            this.hasResponseHeader.TabIndex = 1;
            this.hasResponseHeader.Text = "Response Header";
            this.hasResponseHeader.UseVisualStyleBackColor = true;
            // 
            // hasResponseBody
            // 
            this.hasResponseBody.AutoSize = true;
            this.hasResponseBody.Checked = true;
            this.hasResponseBody.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hasResponseBody.Location = new System.Drawing.Point(264, 22);
            this.hasResponseBody.Name = "hasResponseBody";
            this.hasResponseBody.Size = new System.Drawing.Size(101, 17);
            this.hasResponseBody.TabIndex = 2;
            this.hasResponseBody.Text = "Response Body";
            this.hasResponseBody.UseVisualStyleBackColor = true;
            // 
            // hasRequestHeader
            // 
            this.hasRequestHeader.AutoSize = true;
            this.hasRequestHeader.Checked = true;
            this.hasRequestHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hasRequestHeader.Location = new System.Drawing.Point(139, 45);
            this.hasRequestHeader.Name = "hasRequestHeader";
            this.hasRequestHeader.Size = new System.Drawing.Size(104, 17);
            this.hasRequestHeader.TabIndex = 3;
            this.hasRequestHeader.Text = "Request Header";
            this.hasRequestHeader.UseVisualStyleBackColor = true;
            // 
            // hasRequestData
            // 
            this.hasRequestData.AutoSize = true;
            this.hasRequestData.Checked = true;
            this.hasRequestData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hasRequestData.Location = new System.Drawing.Point(264, 45);
            this.hasRequestData.Name = "hasRequestData";
            this.hasRequestData.Size = new System.Drawing.Size(92, 17);
            this.hasRequestData.TabIndex = 4;
            this.hasRequestData.Text = "Request Data";
            this.hasRequestData.UseVisualStyleBackColor = true;
            // 
            // hasMethod
            // 
            this.hasMethod.AutoSize = true;
            this.hasMethod.Checked = true;
            this.hasMethod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hasMethod.Location = new System.Drawing.Point(16, 45);
            this.hasMethod.Name = "hasMethod";
            this.hasMethod.Size = new System.Drawing.Size(105, 17);
            this.hasMethod.TabIndex = 5;
            this.hasMethod.Text = "Request Method";
            this.hasMethod.UseVisualStyleBackColor = true;
            // 
            // exportTo
            // 
            this.exportTo.Location = new System.Drawing.Point(86, 68);
            this.exportTo.Name = "exportTo";
            this.exportTo.Size = new System.Drawing.Size(165, 20);
            this.exportTo.TabIndex = 6;
            this.exportTo.Text = "C:\\WebApiDocument.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Export to:";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(264, 66);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(92, 23);
            this.browse.TabIndex = 8;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            // 
            // useTemplate
            // 
            this.useTemplate.AutoSize = true;
            this.useTemplate.Location = new System.Drawing.Point(16, 94);
            this.useTemplate.Name = "useTemplate";
            this.useTemplate.Size = new System.Drawing.Size(92, 17);
            this.useTemplate.TabIndex = 9;
            this.useTemplate.Text = "Use Template";
            this.useTemplate.UseVisualStyleBackColor = true;
            // 
            // outputTemplate
            // 
            this.outputTemplate.Enabled = false;
            this.outputTemplate.Location = new System.Drawing.Point(16, 117);
            this.outputTemplate.Name = "outputTemplate";
            this.outputTemplate.Size = new System.Drawing.Size(518, 194);
            this.outputTemplate.TabIndex = 10;
            this.outputTemplate.Text = "";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.Location = new System.Drawing.Point(13, 314);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(128, 13);
            this.note.TabIndex = 11;
            this.note.Text = "Support PlaceHolder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Url Method  ContentType RequestData RequestHeader  ResponseData ResponseHeader St" +
    "atusCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "RequestHeader:<headerName> ResponseHeaders:<headerName>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = " Example:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = " {url:(Url), status:(StatusCode), refer:(ResponseHeaders:Refer)}";
            // 
            // Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.note);
            this.Controls.Add(this.outputTemplate);
            this.Controls.Add(this.useTemplate);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportTo);
            this.Controls.Add(this.hasMethod);
            this.Controls.Add(this.hasRequestData);
            this.Controls.Add(this.hasRequestHeader);
            this.Controls.Add(this.hasResponseBody);
            this.Controls.Add(this.hasResponseHeader);
            this.Controls.Add(this.hasContentType);
            this.Name = "Page";
            this.Size = new System.Drawing.Size(568, 475);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox hasContentType;
        public System.Windows.Forms.CheckBox hasResponseHeader;
        public System.Windows.Forms.CheckBox hasResponseBody;
        public System.Windows.Forms.CheckBox hasRequestHeader;
        public System.Windows.Forms.CheckBox hasRequestData;
        public System.Windows.Forms.CheckBox hasMethod;
        public System.Windows.Forms.TextBox exportTo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button browse;
        public System.Windows.Forms.CheckBox useTemplate;
        public System.Windows.Forms.RichTextBox outputTemplate;
        public System.Windows.Forms.Label note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
