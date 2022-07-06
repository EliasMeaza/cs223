namespace gui_ex
{
    partial class Form2
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
            this.g = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.sk = new System.Windows.Forms.Label();
            this.k = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_sku = new System.Windows.Forms.TextBox();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.g.Location = new System.Drawing.Point(177, 55);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(57, 19);
            this.g.TabIndex = 0;
            this.g.Text = "number";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(353, 59);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(31, 15);
            this.s.TabIndex = 1;
            this.s.Text = "Date";
            // 
            // sk
            // 
            this.sk.AutoSize = true;
            this.sk.Location = new System.Drawing.Point(558, 59);
            this.sk.Name = "sk";
            this.sk.Size = new System.Drawing.Size(28, 15);
            this.sk.TabIndex = 2;
            this.sk.Text = "SKU";
            // 
            // k
            // 
            this.k.AutoSize = true;
            this.k.Location = new System.Drawing.Point(170, 155);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(64, 15);
            this.k.TabIndex = 3;
            this.k.Text = "Item name";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(192, 238);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(53, 15);
            this.p.TabIndex = 4;
            this.p.Text = "Quantity";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(377, 247);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(33, 15);
            this.t.TabIndex = 5;
            this.t.Text = "price";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(170, 77);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 23);
            this.txt_number.TabIndex = 6;
            // 
            // txt_sku
            // 
            this.txt_sku.Location = new System.Drawing.Point(535, 77);
            this.txt_sku.Name = "txt_sku";
            this.txt_sku.Size = new System.Drawing.Size(100, 23);
            this.txt_sku.TabIndex = 8;
            // 
            // txt_itemname
            // 
            this.txt_itemname.Location = new System.Drawing.Point(170, 173);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(100, 23);
            this.txt_itemname.TabIndex = 9;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(192, 271);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 23);
            this.txt_quantity.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(353, 271);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 23);
            this.txt_price.TabIndex = 11;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(246, 352);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(377, 352);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(310, 77);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(200, 23);
            this.txt_date.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_itemname);
            this.Controls.Add(this.txt_sku);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.t);
            this.Controls.Add(this.p);
            this.Controls.Add(this.k);
            this.Controls.Add(this.sk);
            this.Controls.Add(this.s);
            this.Controls.Add(this.g);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label g;
        private Label s;
        private Label sk;
        private Label k;
        private Label p;
        private Label t;
        private TextBox txt_number;
        private TextBox txt_sku;
        private TextBox txt_itemname;
        private TextBox txt_quantity;
        private TextBox txt_price;
        private Button btn_add;
        private Button btn_cancel;
        private DateTimePicker txt_date;
    }
}