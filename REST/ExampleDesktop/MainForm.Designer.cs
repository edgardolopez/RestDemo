namespace ExampleDesktop
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
            this.ProductId = new System.Windows.Forms.Label();
            this.ProductDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtDescriptionProductPost = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProductGet = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPut = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDescripcionPut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGetFilter = new System.Windows.Forms.Button();
            this.lblCantidadGet = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescripcionGetFilter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdmedia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductId
            // 
            this.ProductId.AutoSize = true;
            this.ProductId.Location = new System.Drawing.Point(165, 63);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(0, 13);
            this.ProductId.TabIndex = 0;
            // 
            // ProductDescription
            // 
            this.ProductDescription.AutoSize = true;
            this.ProductDescription.Location = new System.Drawing.Point(165, 88);
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.Size = new System.Drawing.Size(0, 13);
            this.ProductDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id del producto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción: ";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(75, 20);
            this.ErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.ErrorMessage.TabIndex = 4;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(276, 19);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 20);
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(276, 19);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 20);
            this.btnGet.TabIndex = 6;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Controls.Add(this.txtDescriptionProductPost);
            this.groupBox1.Controls.Add(this.btnPost);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 59);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Post";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(27, 21);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(69, 13);
            this.lblProducto.TabIndex = 7;
            this.lblProducto.Text = "Descripción: ";
            // 
            // txtDescriptionProductPost
            // 
            this.txtDescriptionProductPost.Location = new System.Drawing.Point(102, 19);
            this.txtDescriptionProductPost.Name = "txtDescriptionProductPost";
            this.txtDescriptionProductPost.Size = new System.Drawing.Size(168, 20);
            this.txtDescriptionProductPost.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnGet);
            this.groupBox2.Controls.Add(this.txtIdProductGet);
            this.groupBox2.Controls.Add(this.ProductDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ProductId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 128);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID:";
            // 
            // txtIdProductGet
            // 
            this.txtIdProductGet.Location = new System.Drawing.Point(102, 19);
            this.txtIdProductGet.Name = "txtIdProductGet";
            this.txtIdProductGet.Size = new System.Drawing.Size(168, 20);
            this.txtIdProductGet.TabIndex = 8;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(15, 445);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnPut);
            this.groupBox3.Controls.Add(this.txtIdPut);
            this.groupBox3.Controls.Add(this.txtDescripcionPut);
            this.groupBox3.Location = new System.Drawing.Point(18, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 103);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Put";
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(276, 19);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(75, 23);
            this.btnPut.TabIndex = 0;
            this.btnPut.Text = "Put";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.txtIdDelete);
            this.groupBox4.Location = new System.Drawing.Point(18, 355);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 66);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(276, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDescripcionPut
            // 
            this.txtDescripcionPut.Location = new System.Drawing.Point(93, 47);
            this.txtDescripcionPut.Name = "txtDescripcionPut";
            this.txtDescripcionPut.Size = new System.Drawing.Size(168, 20);
            this.txtDescripcionPut.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripción: ";
            // 
            // txtIdPut
            // 
            this.txtIdPut.Location = new System.Drawing.Point(93, 21);
            this.txtIdPut.Name = "txtIdPut";
            this.txtIdPut.Size = new System.Drawing.Size(168, 20);
            this.txtIdPut.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID:";
            // 
            // txtIdDelete
            // 
            this.txtIdDelete.Location = new System.Drawing.Point(93, 22);
            this.txtIdDelete.Name = "txtIdDelete";
            this.txtIdDelete.Size = new System.Drawing.Size(168, 20);
            this.txtIdDelete.TabIndex = 8;
            this.txtIdDelete.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtDescripcionGetFilter);
            this.groupBox5.Controls.Add(this.btnGetFilter);
            this.groupBox5.Controls.Add(this.lblCantidadGet);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(397, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(357, 128);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Get";
            // 
            // btnGetFilter
            // 
            this.btnGetFilter.Location = new System.Drawing.Point(276, 19);
            this.btnGetFilter.Name = "btnGetFilter";
            this.btnGetFilter.Size = new System.Drawing.Size(75, 20);
            this.btnGetFilter.TabIndex = 6;
            this.btnGetFilter.Text = "Get";
            this.btnGetFilter.UseVisualStyleBackColor = true;
            this.btnGetFilter.Click += new System.EventHandler(this.btnGetFilter_Click);
            // 
            // lblCantidadGet
            // 
            this.lblCantidadGet.AutoSize = true;
            this.lblCantidadGet.Location = new System.Drawing.Point(165, 63);
            this.lblCantidadGet.Name = "lblCantidadGet";
            this.lblCantidadGet.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadGet.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cantidad obtenida: ";
            // 
            // txtDescripcionGetFilter
            // 
            this.txtDescripcionGetFilter.Location = new System.Drawing.Point(97, 21);
            this.txtDescripcionGetFilter.Name = "txtDescripcionGetFilter";
            this.txtDescripcionGetFilter.Size = new System.Drawing.Size(168, 20);
            this.txtDescripcionGetFilter.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descripción: ";
            // 
            // btnAdmedia
            // 
            this.btnAdmedia.Location = new System.Drawing.Point(458, 219);
            this.btnAdmedia.Name = "btnAdmedia";
            this.btnAdmedia.Size = new System.Drawing.Size(87, 23);
            this.btnAdmedia.TabIndex = 12;
            this.btnAdmedia.Text = "ABM Admedia";
            this.btnAdmedia.UseVisualStyleBackColor = true;
            this.btnAdmedia.Click += new System.EventHandler(this.btnAdmedia_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 480);
            this.Controls.Add(this.btnAdmedia);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ErrorMessage);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductId;
        private System.Windows.Forms.Label ProductDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtDescriptionProductPost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProductGet;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPut;
        private System.Windows.Forms.TextBox txtDescripcionPut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdDelete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcionGetFilter;
        private System.Windows.Forms.Button btnGetFilter;
        private System.Windows.Forms.Label lblCantidadGet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdmedia;
    }
}

