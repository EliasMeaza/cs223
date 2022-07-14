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
            this.components = new System.ComponentModel.Container();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.g.Location = new System.Drawing.Point(40, 77);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(57, 19);
            this.g.TabIndex = 0;
            this.g.Text = "number";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(40, 125);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(31, 15);
            this.s.TabIndex = 1;
            this.s.Text = "Date";
            // 
            // sk
            // 
            this.sk.AutoSize = true;
            this.sk.Location = new System.Drawing.Point(40, 211);
            this.sk.Name = "sk";
            this.sk.Size = new System.Drawing.Size(28, 15);
            this.sk.TabIndex = 2;
            this.sk.Text = "SKU";
            // 
            // k
            // 
            this.k.AutoSize = true;
            this.k.Location = new System.Drawing.Point(40, 168);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(64, 15);
            this.k.TabIndex = 3;
            this.k.Text = "Item name";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(44, 247);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(53, 15);
            this.p.TabIndex = 4;
            this.p.Text = "Quantity";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(44, 292);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(33, 15);
            this.t.TabIndex = 5;
            this.t.Text = "price";
            // 
            // txt_number
            // 
            this.txt_number.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_number.Location = new System.Drawing.Point(134, 77);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 23);
            this.txt_number.TabIndex = 6;
            this.txt_number.TextChanged += new System.EventHandler(this.txt_number_TextChanged);
            // 
            // txt_sku
            // 
            this.txt_sku.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_sku.Location = new System.Drawing.Point(134, 203);
            this.txt_sku.Name = "txt_sku";
            this.txt_sku.Size = new System.Drawing.Size(100, 23);
            this.txt_sku.TabIndex = 8;
            // 
            // txt_itemname
            // 
            this.txt_itemname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_itemname.Location = new System.Drawing.Point(134, 168);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(100, 23);
            this.txt_itemname.TabIndex = 9;
            // 
            // txt_quantity
            // 
            this.txt_quantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_quantity.Location = new System.Drawing.Point(134, 247);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 23);
            this.txt_quantity.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_price.Location = new System.Drawing.Point(134, 289);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 23);
            this.txt_price.TabIndex = 11;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.Location = new System.Drawing.Point(246, 352);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Location = new System.Drawing.Point(377, 352);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_date
            // 
            this.txt_date.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.txt_date.Location = new System.Drawing.Point(134, 125);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(200, 23);
            this.txt_date.TabIndex = 14;
            this.txt_date.Value = new System.DateTime(2022, 7, 9, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(405, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(383, 291);
            this.dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(544, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "     List ";
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(771, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
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
        private DataGridView dataGridView1;
        private Label label1;
        private ErrorProvider error1;
        private Label label2;
    }
}