namespace TaskMaker
{
    partial class F_Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            btn_exp = new Button();
            btn_money = new Button();
            tb_name = new TextBox();
            label3 = new Label();
            label5 = new Label();
            nud_exp = new NumericUpDown();
            nud_amount = new NumericUpDown();
            label6 = new Label();
            btn_exp_money = new Button();
            label8 = new Label();
            panel2 = new Panel();
            nud_lvlMax = new NumericUpDown();
            label15 = new Label();
            nud_lvlMin = new NumericUpDown();
            cb_knight = new CheckBox();
            cb_paladin = new CheckBox();
            cb_druid = new CheckBox();
            cb_sorcerer = new CheckBox();
            label14 = new Label();
            label7 = new Label();
            nud_repeat = new NumericUpDown();
            label13 = new Label();
            label12 = new Label();
            nud_container = new NumericUpDown();
            nud_items = new NumericUpDown();
            label1 = new Label();
            label11 = new Label();
            nud_percentMoney = new NumericUpDown();
            cb_items = new ComboBox();
            label2 = new Label();
            cb_container = new ComboBox();
            label10 = new Label();
            nud_percentExp = new NumericUpDown();
            nud_storage = new NumericUpDown();
            label9 = new Label();
            label4 = new Label();
            nud_quest = new NumericUpDown();
            panel3 = new Panel();
            lb_info = new Label();
            btn_create = new Button();
            btn_items = new Button();
            label16 = new Label();
            itemInfoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)nud_exp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_amount).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_lvlMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_lvlMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_repeat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_container).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_items).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_percentMoney).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_percentExp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_storage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_quest).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemInfoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btn_exp
            // 
            btn_exp.BackColor = Color.White;
            btn_exp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exp.ForeColor = Color.Black;
            btn_exp.Location = new Point(11, 257);
            btn_exp.Name = "btn_exp";
            btn_exp.Size = new Size(116, 23);
            btn_exp.TabIndex = 3;
            btn_exp.Text = "Make Only Exp";
            btn_exp.UseVisualStyleBackColor = false;
            btn_exp.Click += btn_exp_Click;
            // 
            // btn_money
            // 
            btn_money.BackColor = Color.White;
            btn_money.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_money.ForeColor = Color.Black;
            btn_money.Location = new Point(11, 286);
            btn_money.Name = "btn_money";
            btn_money.Size = new Size(116, 23);
            btn_money.TabIndex = 5;
            btn_money.Text = "Make Only Money";
            btn_money.UseVisualStyleBackColor = false;
            btn_money.Click += btn_money_Click;
            // 
            // tb_name
            // 
            tb_name.BackColor = Color.White;
            tb_name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tb_name.ForeColor = Color.Black;
            tb_name.Location = new Point(11, 158);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(172, 23);
            tb_name.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(11, 138);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 9;
            label3.Text = "Monster Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(189, 138);
            label5.Name = "label5";
            label5.Size = new Size(109, 17);
            label5.TabIndex = 10;
            label5.Text = "Monster Exp(x1)";
            // 
            // nud_exp
            // 
            nud_exp.BackColor = Color.White;
            nud_exp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nud_exp.ForeColor = Color.Black;
            nud_exp.Location = new Point(189, 158);
            nud_exp.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_exp.Name = "nud_exp";
            nud_exp.Size = new Size(109, 23);
            nud_exp.TabIndex = 1;
            nud_exp.TextAlign = HorizontalAlignment.Center;
            // 
            // nud_amount
            // 
            nud_amount.BackColor = Color.White;
            nud_amount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nud_amount.ForeColor = Color.Black;
            nud_amount.Location = new Point(304, 158);
            nud_amount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_amount.Name = "nud_amount";
            nud_amount.Size = new Size(97, 23);
            nud_amount.TabIndex = 2;
            nud_amount.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(304, 138);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 13;
            label6.Text = "Amount Task";
            // 
            // btn_exp_money
            // 
            btn_exp_money.BackColor = Color.White;
            btn_exp_money.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exp_money.ForeColor = Color.Black;
            btn_exp_money.Location = new Point(286, 257);
            btn_exp_money.Name = "btn_exp_money";
            btn_exp_money.Size = new Size(116, 23);
            btn_exp_money.TabIndex = 4;
            btn_exp_money.Text = "Make Exp/Money";
            btn_exp_money.UseVisualStyleBackColor = false;
            btn_exp_money.Click += btn_exp_money_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Gold;
            label8.Location = new Point(159, 288);
            label8.Name = "label8";
            label8.Size = new Size(87, 21);
            label8.TabIndex = 15;
            label8.Text = "Write Info";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(185, 0, 0, 0);
            panel2.Controls.Add(nud_lvlMax);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(nud_lvlMin);
            panel2.Controls.Add(cb_knight);
            panel2.Controls.Add(cb_paladin);
            panel2.Controls.Add(cb_druid);
            panel2.Controls.Add(cb_sorcerer);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(nud_repeat);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(nud_container);
            panel2.Controls.Add(nud_items);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(nud_percentMoney);
            panel2.Controls.Add(cb_items);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cb_container);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(nud_percentExp);
            panel2.Controls.Add(nud_storage);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(nud_quest);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btn_create);
            panel2.Controls.Add(btn_items);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(nud_amount);
            panel2.Controls.Add(btn_exp);
            panel2.Controls.Add(nud_exp);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btn_exp_money);
            panel2.Controls.Add(btn_money);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tb_name);
            panel2.Controls.Add(label16);
            panel2.Location = new Point(0, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 421);
            panel2.TabIndex = 16;
            // 
            // nud_lvlMax
            // 
            nud_lvlMax.BackColor = Color.White;
            nud_lvlMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nud_lvlMax.ForeColor = Color.Black;
            nud_lvlMax.Location = new Point(224, 219);
            nud_lvlMax.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_lvlMax.Name = "nud_lvlMax";
            nud_lvlMax.Size = new Size(57, 23);
            nud_lvlMax.TabIndex = 54;
            nud_lvlMax.TextAlign = HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Gold;
            label15.Location = new Point(12, 219);
            label15.Name = "label15";
            label15.Size = new Size(74, 17);
            label15.TabIndex = 53;
            label15.Text = "Level(Min)";
            // 
            // nud_lvlMin
            // 
            nud_lvlMin.BackColor = Color.White;
            nud_lvlMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nud_lvlMin.ForeColor = Color.Black;
            nud_lvlMin.Location = new Point(86, 219);
            nud_lvlMin.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_lvlMin.Name = "nud_lvlMin";
            nud_lvlMin.Size = new Size(57, 23);
            nud_lvlMin.TabIndex = 52;
            nud_lvlMin.TextAlign = HorizontalAlignment.Center;
            // 
            // cb_knight
            // 
            cb_knight.AutoSize = true;
            cb_knight.BackColor = Color.Transparent;
            cb_knight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cb_knight.ForeColor = Color.Gold;
            cb_knight.Location = new Point(329, 194);
            cb_knight.Name = "cb_knight";
            cb_knight.Size = new Size(63, 19);
            cb_knight.TabIndex = 51;
            cb_knight.Text = "Knight";
            cb_knight.UseVisualStyleBackColor = false;
            // 
            // cb_paladin
            // 
            cb_paladin.AutoSize = true;
            cb_paladin.BackColor = Color.Transparent;
            cb_paladin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cb_paladin.ForeColor = Color.Gold;
            cb_paladin.Location = new Point(248, 194);
            cb_paladin.Name = "cb_paladin";
            cb_paladin.Size = new Size(65, 19);
            cb_paladin.TabIndex = 50;
            cb_paladin.Text = "Paladin";
            cb_paladin.UseVisualStyleBackColor = false;
            // 
            // cb_druid
            // 
            cb_druid.AutoSize = true;
            cb_druid.BackColor = Color.Transparent;
            cb_druid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cb_druid.ForeColor = Color.Gold;
            cb_druid.Location = new Point(167, 194);
            cb_druid.Name = "cb_druid";
            cb_druid.Size = new Size(57, 19);
            cb_druid.TabIndex = 49;
            cb_druid.Text = "Druid";
            cb_druid.UseVisualStyleBackColor = false;
            // 
            // cb_sorcerer
            // 
            cb_sorcerer.AutoSize = true;
            cb_sorcerer.BackColor = Color.Transparent;
            cb_sorcerer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cb_sorcerer.ForeColor = Color.Gold;
            cb_sorcerer.Location = new Point(86, 194);
            cb_sorcerer.Name = "cb_sorcerer";
            cb_sorcerer.Size = new Size(75, 19);
            cb_sorcerer.TabIndex = 48;
            cb_sorcerer.Text = "Sorcerer";
            cb_sorcerer.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Gold;
            label14.Location = new Point(12, 194);
            label14.Name = "label14";
            label14.Size = new Size(72, 17);
            label14.TabIndex = 47;
            label14.Text = "Vocations:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(294, 219);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 46;
            label7.Text = "Repeat";
            // 
            // nud_repeat
            // 
            nud_repeat.BackColor = Color.White;
            nud_repeat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nud_repeat.ForeColor = Color.Black;
            nud_repeat.Location = new Point(345, 219);
            nud_repeat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_repeat.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_repeat.Name = "nud_repeat";
            nud_repeat.Size = new Size(57, 23);
            nud_repeat.TabIndex = 45;
            nud_repeat.TextAlign = HorizontalAlignment.Center;
            nud_repeat.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Gold;
            label13.Location = new Point(201, 88);
            label13.Name = "label13";
            label13.Size = new Size(45, 17);
            label13.TabIndex = 44;
            label13.Text = "Count";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Gold;
            label12.Location = new Point(201, 42);
            label12.Name = "label12";
            label12.Size = new Size(45, 17);
            label12.TabIndex = 43;
            label12.Text = "Count";
            // 
            // nud_container
            // 
            nud_container.BackColor = Color.White;
            nud_container.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nud_container.ForeColor = Color.Black;
            nud_container.Location = new Point(202, 62);
            nud_container.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_container.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_container.Name = "nud_container";
            nud_container.Size = new Size(74, 23);
            nud_container.TabIndex = 42;
            nud_container.TextAlign = HorizontalAlignment.Center;
            nud_container.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nud_items
            // 
            nud_items.BackColor = Color.White;
            nud_items.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nud_items.ForeColor = Color.Black;
            nud_items.Location = new Point(201, 107);
            nud_items.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_items.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_items.Name = "nud_items";
            nud_items.Size = new Size(74, 23);
            nud_items.TabIndex = 41;
            nud_items.TextAlign = HorizontalAlignment.Center;
            nud_items.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 29;
            label1.Text = "Reward Exp%";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Gold;
            label11.Location = new Point(11, 88);
            label11.Name = "label11";
            label11.Size = new Size(42, 17);
            label11.TabIndex = 40;
            label11.Text = "Items";
            // 
            // nud_percentMoney
            // 
            nud_percentMoney.BackColor = Color.White;
            nud_percentMoney.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nud_percentMoney.ForeColor = Color.Black;
            nud_percentMoney.Location = new Point(334, 17);
            nud_percentMoney.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nud_percentMoney.Name = "nud_percentMoney";
            nud_percentMoney.Size = new Size(68, 23);
            nud_percentMoney.TabIndex = 31;
            nud_percentMoney.TextAlign = HorizontalAlignment.Center;
            // 
            // cb_items
            // 
            cb_items.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_items.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_items.BackColor = Color.White;
            cb_items.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cb_items.ForeColor = Color.Black;
            cb_items.FormattingEnabled = true;
            cb_items.Location = new Point(11, 107);
            cb_items.MaxDropDownItems = 15;
            cb_items.Name = "cb_items";
            cb_items.RightToLeft = RightToLeft.No;
            cb_items.Size = new Size(185, 23);
            cb_items.TabIndex = 39;
            cb_items.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(218, 17);
            label2.Name = "label2";
            label2.Size = new Size(110, 17);
            label2.TabIndex = 32;
            label2.Text = "Reward Money%";
            // 
            // cb_container
            // 
            cb_container.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_container.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_container.BackColor = Color.White;
            cb_container.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cb_container.ForeColor = Color.Black;
            cb_container.FormattingEnabled = true;
            cb_container.Location = new Point(11, 62);
            cb_container.Name = "cb_container";
            cb_container.RightToLeft = RightToLeft.No;
            cb_container.Size = new Size(185, 23);
            cb_container.TabIndex = 37;
            cb_container.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Gold;
            label10.Location = new Point(11, 42);
            label10.Name = "label10";
            label10.Size = new Size(74, 17);
            label10.TabIndex = 38;
            label10.Text = "Containers";
            // 
            // nud_percentExp
            // 
            nud_percentExp.BackColor = Color.White;
            nud_percentExp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nud_percentExp.ForeColor = Color.Black;
            nud_percentExp.Location = new Point(102, 17);
            nud_percentExp.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nud_percentExp.Name = "nud_percentExp";
            nud_percentExp.Size = new Size(59, 23);
            nud_percentExp.TabIndex = 30;
            nud_percentExp.TextAlign = HorizontalAlignment.Center;
            // 
            // nud_storage
            // 
            nud_storage.BackColor = Color.White;
            nud_storage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nud_storage.ForeColor = Color.Black;
            nud_storage.Location = new Point(304, 63);
            nud_storage.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nud_storage.Name = "nud_storage";
            nud_storage.Size = new Size(97, 23);
            nud_storage.TabIndex = 33;
            nud_storage.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Gold;
            label9.Location = new Point(304, 88);
            label9.Name = "label9";
            label9.Size = new Size(82, 17);
            label9.TabIndex = 36;
            label9.Text = "Quest Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(304, 43);
            label4.Name = "label4";
            label4.Size = new Size(98, 17);
            label4.TabIndex = 34;
            label4.Text = "Storage / Data";
            // 
            // nud_quest
            // 
            nud_quest.BackColor = Color.White;
            nud_quest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nud_quest.ForeColor = Color.Black;
            nud_quest.Location = new Point(304, 107);
            nud_quest.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nud_quest.Name = "nud_quest";
            nud_quest.Size = new Size(97, 23);
            nud_quest.TabIndex = 35;
            nud_quest.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lb_info);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(0, 318);
            panel3.Name = "panel3";
            panel3.Size = new Size(413, 103);
            panel3.TabIndex = 0;
            // 
            // lb_info
            // 
            lb_info.AutoSize = true;
            lb_info.Dock = DockStyle.Top;
            lb_info.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_info.Location = new Point(0, 0);
            lb_info.Name = "lb_info";
            lb_info.Size = new Size(40, 21);
            lb_info.TabIndex = 0;
            lb_info.Text = "text";
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.FromArgb(90, 0, 120, 0);
            btn_create.FlatStyle = FlatStyle.Flat;
            btn_create.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_create.ForeColor = Color.White;
            btn_create.Location = new Point(159, 254);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(87, 28);
            btn_create.TabIndex = 6;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // btn_items
            // 
            btn_items.BackColor = Color.White;
            btn_items.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_items.ForeColor = Color.Black;
            btn_items.Location = new Point(285, 286);
            btn_items.Name = "btn_items";
            btn_items.Size = new Size(116, 23);
            btn_items.TabIndex = 17;
            btn_items.Text = "Make Only Items";
            btn_items.UseVisualStyleBackColor = false;
            btn_items.Click += btn_items_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Gold;
            label16.Location = new Point(149, 219);
            label16.Name = "label16";
            label16.Size = new Size(76, 17);
            label16.TabIndex = 55;
            label16.Text = "Level(Max)";
            // 
            // F_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources.OIP___Copia;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(412, 420);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "F_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Maker by RcPmG";
            ((System.ComponentModel.ISupportInitialize)nud_exp).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_amount).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_lvlMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_lvlMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_repeat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_container).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_items).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_percentMoney).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_percentExp).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_storage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_quest).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemInfoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_exp;
        private Button btn_money;
        private TextBox tb_name;
        private Label label3;
        private Label label5;
        private NumericUpDown nud_exp;
        private NumericUpDown nud_amount;
        private Label label6;
        private Button btn_exp_money;
        private Label label8;
        private Panel panel2;
        private Panel panel3;
        private Label lb_info;
        private Button btn_create;
        private BindingSource itemInfoBindingSource;
        private Button btn_items;
        private Label label13;
        private Label label12;
        private NumericUpDown nud_container;
        private NumericUpDown nud_items;
        private Label label1;
        private Label label11;
        private NumericUpDown nud_percentMoney;
        private ComboBox cb_items;
        private Label label2;
        private ComboBox cb_container;
        private Label label10;
        private NumericUpDown nud_percentExp;
        private NumericUpDown nud_storage;
        private Label label9;
        private Label label4;
        private NumericUpDown nud_quest;
        private Label label7;
        private NumericUpDown nud_repeat;
        private Label label14;
        private CheckBox cb_knight;
        private CheckBox cb_paladin;
        private CheckBox cb_druid;
        private CheckBox cb_sorcerer;
        private Label label16;
        private NumericUpDown nud_lvlMax;
        private Label label15;
        private NumericUpDown nud_lvlMin;
    }
}