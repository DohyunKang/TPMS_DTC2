namespace TPMS_DTC
{
    partial class TPMS
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Start Diagnostic Session");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Stop Diagnostic Session");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Vehicle Project Name");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Ecu Identification Data Table");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("HMC/KMC Part configuration");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("VIN (Vehicle Identification Number)");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Read Sensors Id");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Manufacturer Part Information Block");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Read ECU Identification ID", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Active Fault (Current DTC)");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Historic Fault (Historical DTC)");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Read DTC By Status", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Clear all historic and active DTC information");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Active DTCS changed to Historic DTC");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Historic DTCS changed to Active DTC");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Clear Diagnostic Information", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Standard Diagnostic Mode", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode9,
            treeNode12,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Start Diagnostic Session");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("ECU Input Battery Values");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Lamp Drive Status");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Sensor Status Infromation");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("ECU Status Infromation");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Read Data By Local Identifier", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Vehicle Project Name & Wheel Size");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("ECU Identificaiton data table");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("HMC / KMC Part Configuration");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("VIN (Vehicle identification number)");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Sensor ID\'s Type 1 Learn");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Manufacture Part Information Block");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Write Data By Local Identifier", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("ECU Programming Mode", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode23,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Start Diagnostic Session");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Stop Diagnostic Session");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Vehicle Project Name");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Ecu Identification Data Table");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("HMC/KMC Part configuration");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("VIN (Vehicle Identification Number)");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Read Sensors Id");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Manufacturer Part Information Block");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Read ECU Identification ID", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Extended Diagnostic Mode", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode40});
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.FC_Set = new System.Windows.Forms.Button();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.dud_STmin_us = new System.Windows.Forms.NumericUpDown();
            this.rBtn_ms = new System.Windows.Forms.RadioButton();
            this.udStmin_ms = new System.Windows.Forms.NumericUpDown();
            this.rBtn_μs = new System.Windows.Forms.RadioButton();
            this.tb_bs = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_fc0 = new System.Windows.Forms.TextBox();
            this.tb_fc7 = new System.Windows.Forms.TextBox();
            this.tb_fc1 = new System.Windows.Forms.TextBox();
            this.tb_fc2 = new System.Windows.Forms.TextBox();
            this.tb_fc6 = new System.Windows.Forms.TextBox();
            this.tb_fc3 = new System.Windows.Forms.TextBox();
            this.tb_fc4 = new System.Windows.Forms.TextBox();
            this.tb_fc5 = new System.Windows.Forms.TextBox();
            this.FC_ID_Edit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.MessageSendButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.MSG_ID_Edit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.tbpn_DataByte = new System.Windows.Forms.TableLayoutPanel();
            this.tb_byte7 = new System.Windows.Forms.TextBox();
            this.tb_byte1 = new System.Windows.Forms.TextBox();
            this.tb_byte2 = new System.Windows.Forms.TextBox();
            this.tb_byte6 = new System.Windows.Forms.TextBox();
            this.tb_byte3 = new System.Windows.Forms.TextBox();
            this.tb_byte4 = new System.Windows.Forms.TextBox();
            this.tb_byte5 = new System.Windows.Forms.TextBox();
            this.tb_byte0 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.ServiceList = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CH1_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.LogResetButton = new System.Windows.Forms.Button();
            this.CountLav = new System.Windows.Forms.Label();
            this.CycleLav = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dud_STmin_us)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udStmin_ms)).BeginInit();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FC_ID_Edit)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSG_ID_Edit)).BeginInit();
            this.tbpn_DataByte.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.80336F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.19664F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.40263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.59737F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 659F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1902, 659);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.74658F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.25342F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(702, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.17073F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.829268F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1197, 492);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.79832F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.20168F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1191, 476);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel15, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 221);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.81752F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.18248F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1185, 252);
            this.tableLayoutPanel9.TabIndex = 4;
            this.tableLayoutPanel9.TabStop = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1179, 62);
            this.label6.TabIndex = 4;
            this.label6.Text = "Flow Control";
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.39741F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.60259F));
            this.tableLayoutPanel15.Controls.Add(this.FC_Set, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel18, 0, 0);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(1179, 125);
            this.tableLayoutPanel15.TabIndex = 4;
            this.tableLayoutPanel15.TabStop = true;
            // 
            // FC_Set
            // 
            this.FC_Set.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FC_Set.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FC_Set.Location = new System.Drawing.Point(974, 3);
            this.FC_Set.Name = "FC_Set";
            this.FC_Set.Size = new System.Drawing.Size(202, 119);
            this.FC_Set.TabIndex = 15;
            this.FC_Set.Text = "Set";
            this.FC_Set.UseVisualStyleBackColor = true;
            this.FC_Set.Click += new System.EventHandler(this.FC_Set_Click);
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Controls.Add(this.tableLayoutPanel19, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.tableLayoutPanel20, 0, 1);
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 2;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.29032F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.70968F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(965, 118);
            this.tableLayoutPanel18.TabIndex = 6;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 2;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.11157F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.88843F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 606F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel19.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel19.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.tableLayoutPanel21, 1, 1);
            this.tableLayoutPanel19.Controls.Add(this.tb_bs, 0, 1);
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 2;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(959, 66);
            this.tableLayoutPanel19.TabIndex = 4;
            this.tableLayoutPanel19.TabStop = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(262, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(694, 18);
            this.label14.TabIndex = 8;
            this.label14.Text = "ST_MIN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "BS";
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 4;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.03653F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.96347F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel21.Controls.Add(this.dud_STmin_us, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.rBtn_ms, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.udStmin_ms, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.rBtn_μs, 3, 0);
            this.tableLayoutPanel21.Location = new System.Drawing.Point(262, 21);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(592, 41);
            this.tableLayoutPanel21.TabIndex = 6;
            // 
            // dud_STmin_us
            // 
            this.dud_STmin_us.Enabled = false;
            this.dud_STmin_us.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dud_STmin_us.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.dud_STmin_us.Location = new System.Drawing.Point(301, 3);
            this.dud_STmin_us.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.dud_STmin_us.Name = "dud_STmin_us";
            this.dud_STmin_us.Size = new System.Drawing.Size(155, 30);
            this.dud_STmin_us.TabIndex = 4;
            this.dud_STmin_us.ValueChanged += new System.EventHandler(this.dud_STmin_us_ValueChanged);
            // 
            // rBtn_ms
            // 
            this.rBtn_ms.AutoSize = true;
            this.rBtn_ms.Checked = true;
            this.rBtn_ms.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_ms.Location = new System.Drawing.Point(206, 3);
            this.rBtn_ms.Name = "rBtn_ms";
            this.rBtn_ms.Size = new System.Drawing.Size(48, 26);
            this.rBtn_ms.TabIndex = 47;
            this.rBtn_ms.TabStop = true;
            this.rBtn_ms.Text = "ms";
            this.rBtn_ms.UseVisualStyleBackColor = true;
            this.rBtn_ms.CheckedChanged += new System.EventHandler(this.rBtn_ms_CheckedChanged);
            // 
            // udStmin_ms
            // 
            this.udStmin_ms.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udStmin_ms.Location = new System.Drawing.Point(3, 3);
            this.udStmin_ms.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.udStmin_ms.Name = "udStmin_ms";
            this.udStmin_ms.Size = new System.Drawing.Size(169, 30);
            this.udStmin_ms.TabIndex = 3;
            this.udStmin_ms.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udStmin_ms.ValueChanged += new System.EventHandler(this.udStmin_ms_ValueChanged);
            // 
            // rBtn_μs
            // 
            this.rBtn_μs.AutoSize = true;
            this.rBtn_μs.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_μs.Location = new System.Drawing.Point(462, 3);
            this.rBtn_μs.Name = "rBtn_μs";
            this.rBtn_μs.Size = new System.Drawing.Size(48, 26);
            this.rBtn_μs.TabIndex = 50;
            this.rBtn_μs.TabStop = true;
            this.rBtn_μs.Text = "μs";
            this.rBtn_μs.UseVisualStyleBackColor = true;
            this.rBtn_μs.CheckedChanged += new System.EventHandler(this.rBtn_μs_CheckedChanged);
            // 
            // tb_bs
            // 
            this.tb_bs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_bs.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bs.Location = new System.Drawing.Point(3, 21);
            this.tb_bs.MaxLength = 2;
            this.tb_bs.Name = "tb_bs";
            this.tb_bs.Size = new System.Drawing.Size(253, 30);
            this.tb_bs.TabIndex = 2;
            this.tb_bs.Text = "00";
            this.tb_bs.TextChanged += new System.EventHandler(this.tb_bs_TextChanged);
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 2;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.86667F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.13333F));
            this.tableLayoutPanel20.Controls.Add(this.tableLayoutPanel22, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.FC_ID_Edit, 0, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 1;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(959, 40);
            this.tableLayoutPanel20.TabIndex = 8;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 8;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel22.Controls.Add(this.tb_fc0, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.tb_fc7, 7, 0);
            this.tableLayoutPanel22.Controls.Add(this.tb_fc1, 1, 0);
            this.tableLayoutPanel22.Controls.Add(this.tb_fc2, 2, 0);
            this.tableLayoutPanel22.Controls.Add(this.tb_fc6, 6, 0);
            this.tableLayoutPanel22.Controls.Add(this.tb_fc3, 3, 0);
            this.tableLayoutPanel22.Controls.Add(this.tb_fc4, 4, 0);
            this.tableLayoutPanel22.Controls.Add(this.tb_fc5, 5, 0);
            this.tableLayoutPanel22.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel22.Location = new System.Drawing.Point(270, 3);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(686, 33);
            this.tableLayoutPanel22.TabIndex = 51;
            // 
            // tb_fc0
            // 
            this.tb_fc0.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fc0.Location = new System.Drawing.Point(3, 3);
            this.tb_fc0.MaxLength = 2;
            this.tb_fc0.Name = "tb_fc0";
            this.tb_fc0.Size = new System.Drawing.Size(35, 30);
            this.tb_fc0.TabIndex = 6;
            this.tb_fc0.Text = "30";
            this.tb_fc0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_fc7
            // 
            this.tb_fc7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fc7.Location = new System.Drawing.Point(598, 3);
            this.tb_fc7.MaxLength = 2;
            this.tb_fc7.Name = "tb_fc7";
            this.tb_fc7.Size = new System.Drawing.Size(35, 30);
            this.tb_fc7.TabIndex = 14;
            this.tb_fc7.Text = "00";
            this.tb_fc7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_fc1
            // 
            this.tb_fc1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fc1.Location = new System.Drawing.Point(88, 3);
            this.tb_fc1.MaxLength = 2;
            this.tb_fc1.Name = "tb_fc1";
            this.tb_fc1.Size = new System.Drawing.Size(35, 30);
            this.tb_fc1.TabIndex = 8;
            this.tb_fc1.Text = "00";
            this.tb_fc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_fc2
            // 
            this.tb_fc2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fc2.Location = new System.Drawing.Point(173, 3);
            this.tb_fc2.MaxLength = 2;
            this.tb_fc2.Name = "tb_fc2";
            this.tb_fc2.Size = new System.Drawing.Size(35, 30);
            this.tb_fc2.TabIndex = 9;
            this.tb_fc2.Text = "14";
            this.tb_fc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_fc6
            // 
            this.tb_fc6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fc6.Location = new System.Drawing.Point(513, 3);
            this.tb_fc6.MaxLength = 2;
            this.tb_fc6.Name = "tb_fc6";
            this.tb_fc6.Size = new System.Drawing.Size(35, 30);
            this.tb_fc6.TabIndex = 13;
            this.tb_fc6.Text = "00";
            this.tb_fc6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_fc3
            // 
            this.tb_fc3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fc3.Location = new System.Drawing.Point(258, 3);
            this.tb_fc3.MaxLength = 2;
            this.tb_fc3.Name = "tb_fc3";
            this.tb_fc3.Size = new System.Drawing.Size(35, 30);
            this.tb_fc3.TabIndex = 10;
            this.tb_fc3.Text = "00";
            this.tb_fc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_fc4
            // 
            this.tb_fc4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fc4.Location = new System.Drawing.Point(343, 3);
            this.tb_fc4.MaxLength = 2;
            this.tb_fc4.Name = "tb_fc4";
            this.tb_fc4.Size = new System.Drawing.Size(35, 30);
            this.tb_fc4.TabIndex = 11;
            this.tb_fc4.Text = "00";
            this.tb_fc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_fc5
            // 
            this.tb_fc5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fc5.Location = new System.Drawing.Point(428, 3);
            this.tb_fc5.MaxLength = 2;
            this.tb_fc5.Name = "tb_fc5";
            this.tb_fc5.Size = new System.Drawing.Size(35, 30);
            this.tb_fc5.TabIndex = 12;
            this.tb_fc5.Text = "00";
            this.tb_fc5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FC_ID_Edit
            // 
            this.FC_ID_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FC_ID_Edit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FC_ID_Edit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateHexadecimalMode(3, true);
            this.FC_ID_Edit.Location = new System.Drawing.Point(3, 3);
            this.FC_ID_Edit.Name = "FC_ID_Edit";
            this.FC_ID_Edit.Range = new NationalInstruments.UI.Range(0D, 4096D);
            this.FC_ID_Edit.Size = new System.Drawing.Size(261, 30);
            this.FC_ID_Edit.TabIndex = 5;
            this.FC_ID_Edit.Value = 2006D;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel16, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.81752F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.18248F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1185, 212);
            this.tableLayoutPanel10.TabIndex = 3;
            this.tableLayoutPanel10.TabStop = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1179, 52);
            this.label5.TabIndex = 4;
            this.label5.Text = "Message";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.27311F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.72689F));
            this.tableLayoutPanel16.Controls.Add(this.MessageSendButton, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel17, 0, 0);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(1179, 127);
            this.tableLayoutPanel16.TabIndex = 3;
            this.tableLayoutPanel16.TabStop = true;
            // 
            // MessageSendButton
            // 
            this.MessageSendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageSendButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageSendButton.Location = new System.Drawing.Point(972, 3);
            this.MessageSendButton.Name = "MessageSendButton";
            this.MessageSendButton.Size = new System.Drawing.Size(204, 121);
            this.MessageSendButton.TabIndex = 16;
            this.MessageSendButton.Text = "Send";
            this.MessageSendButton.UseVisualStyleBackColor = true;
            this.MessageSendButton.Click += new System.EventHandler(this.MessageSendButton_Click);
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.03738F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.96262F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel17.Controls.Add(this.MSG_ID_Edit, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.tbpn_DataByte, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.label13, 1, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.81752F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.18248F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(963, 121);
            this.tableLayoutPanel17.TabIndex = 3;
            this.tableLayoutPanel17.TabStop = true;
            // 
            // MSG_ID_Edit
            // 
            this.MSG_ID_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MSG_ID_Edit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSG_ID_Edit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateHexadecimalMode(3, true);
            this.MSG_ID_Edit.Location = new System.Drawing.Point(3, 33);
            this.MSG_ID_Edit.Name = "MSG_ID_Edit";
            this.MSG_ID_Edit.Range = new NationalInstruments.UI.Range(0D, 4096D);
            this.MSG_ID_Edit.Size = new System.Drawing.Size(263, 30);
            this.MSG_ID_Edit.TabIndex = 1;
            this.MSG_ID_Edit.Value = 2006D;
            // 
            // tbpn_DataByte
            // 
            this.tbpn_DataByte.ColumnCount = 8;
            this.tbpn_DataByte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbpn_DataByte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbpn_DataByte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbpn_DataByte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbpn_DataByte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbpn_DataByte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbpn_DataByte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbpn_DataByte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbpn_DataByte.Controls.Add(this.tb_byte7, 7, 0);
            this.tbpn_DataByte.Controls.Add(this.tb_byte1, 1, 0);
            this.tbpn_DataByte.Controls.Add(this.tb_byte2, 2, 0);
            this.tbpn_DataByte.Controls.Add(this.tb_byte6, 6, 0);
            this.tbpn_DataByte.Controls.Add(this.tb_byte3, 3, 0);
            this.tbpn_DataByte.Controls.Add(this.tb_byte4, 4, 0);
            this.tbpn_DataByte.Controls.Add(this.tb_byte5, 5, 0);
            this.tbpn_DataByte.Controls.Add(this.tb_byte0, 0, 0);
            this.tbpn_DataByte.Location = new System.Drawing.Point(272, 33);
            this.tbpn_DataByte.Name = "tbpn_DataByte";
            this.tbpn_DataByte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbpn_DataByte.RowCount = 1;
            this.tbpn_DataByte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpn_DataByte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbpn_DataByte.Size = new System.Drawing.Size(682, 50);
            this.tbpn_DataByte.TabIndex = 36;
            // 
            // tb_byte7
            // 
            this.tb_byte7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_byte7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_byte7.Location = new System.Drawing.Point(598, 10);
            this.tb_byte7.MaxLength = 2;
            this.tb_byte7.Name = "tb_byte7";
            this.tb_byte7.Size = new System.Drawing.Size(35, 30);
            this.tb_byte7.TabIndex = 14;
            this.tb_byte7.Text = "00";
            this.tb_byte7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_byte1
            // 
            this.tb_byte1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_byte1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_byte1.Location = new System.Drawing.Point(88, 10);
            this.tb_byte1.MaxLength = 2;
            this.tb_byte1.Name = "tb_byte1";
            this.tb_byte1.Size = new System.Drawing.Size(35, 30);
            this.tb_byte1.TabIndex = 8;
            this.tb_byte1.Text = "00";
            this.tb_byte1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_byte2
            // 
            this.tb_byte2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_byte2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_byte2.Location = new System.Drawing.Point(173, 10);
            this.tb_byte2.MaxLength = 2;
            this.tb_byte2.Name = "tb_byte2";
            this.tb_byte2.Size = new System.Drawing.Size(35, 30);
            this.tb_byte2.TabIndex = 9;
            this.tb_byte2.Text = "00";
            this.tb_byte2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_byte6
            // 
            this.tb_byte6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_byte6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_byte6.Location = new System.Drawing.Point(513, 10);
            this.tb_byte6.MaxLength = 2;
            this.tb_byte6.Name = "tb_byte6";
            this.tb_byte6.Size = new System.Drawing.Size(35, 30);
            this.tb_byte6.TabIndex = 13;
            this.tb_byte6.Text = "00";
            this.tb_byte6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_byte3
            // 
            this.tb_byte3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_byte3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_byte3.Location = new System.Drawing.Point(258, 10);
            this.tb_byte3.MaxLength = 2;
            this.tb_byte3.Name = "tb_byte3";
            this.tb_byte3.Size = new System.Drawing.Size(35, 30);
            this.tb_byte3.TabIndex = 10;
            this.tb_byte3.Text = "00";
            this.tb_byte3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_byte4
            // 
            this.tb_byte4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_byte4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_byte4.Location = new System.Drawing.Point(343, 10);
            this.tb_byte4.MaxLength = 2;
            this.tb_byte4.Name = "tb_byte4";
            this.tb_byte4.Size = new System.Drawing.Size(35, 30);
            this.tb_byte4.TabIndex = 11;
            this.tb_byte4.Text = "00";
            this.tb_byte4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_byte5
            // 
            this.tb_byte5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_byte5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_byte5.Location = new System.Drawing.Point(428, 10);
            this.tb_byte5.MaxLength = 2;
            this.tb_byte5.Name = "tb_byte5";
            this.tb_byte5.Size = new System.Drawing.Size(35, 30);
            this.tb_byte5.TabIndex = 12;
            this.tb_byte5.Text = "00";
            this.tb_byte5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_byte0
            // 
            this.tb_byte0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_byte0.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_byte0.Location = new System.Drawing.Point(3, 10);
            this.tb_byte0.MaxLength = 2;
            this.tb_byte0.Name = "tb_byte0";
            this.tb_byte0.Size = new System.Drawing.Size(35, 30);
            this.tb_byte0.TabIndex = 6;
            this.tb_byte0.Text = "00";
            this.tb_byte0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 30);
            this.label12.TabIndex = 4;
            this.label12.Text = "ID(Hex)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(272, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(688, 30);
            this.label13.TabIndex = 5;
            this.label13.Text = "DATA(Hex)";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.74658F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.25342F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.87179F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.1282F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(693, 591);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.10661F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.89339F));
            this.tableLayoutPanel8.Controls.Add(this.ServiceList, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 90);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.91075F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.08925F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(687, 493);
            this.tableLayoutPanel8.TabIndex = 2;
            this.tableLayoutPanel8.TabStop = true;
            // 
            // ServiceList
            // 
            this.ServiceList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServiceList.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceList.Location = new System.Drawing.Point(3, 41);
            this.ServiceList.Name = "ServiceList";
            treeNode1.Name = "StartDiagnostic";
            treeNode1.Text = "Start Diagnostic Session";
            treeNode2.Name = "StopDiagnostic";
            treeNode2.Text = "Stop Diagnostic Session";
            treeNode3.Name = "VehicleProject";
            treeNode3.Text = "Vehicle Project Name";
            treeNode4.Name = "EcuIdentification";
            treeNode4.Text = "Ecu Identification Data Table";
            treeNode5.Name = "HMC/KMC";
            treeNode5.Text = "HMC/KMC Part configuration";
            treeNode6.Name = "VIN";
            treeNode6.Text = "VIN (Vehicle Identification Number)";
            treeNode7.Name = "ReadSensors";
            treeNode7.Text = "Read Sensors Id";
            treeNode8.Name = "ManufacturerPart";
            treeNode8.Text = "Manufacturer Part Information Block";
            treeNode9.Name = "ReadECU";
            treeNode9.Text = "Read ECU Identification ID";
            treeNode10.Name = "ActiveFault";
            treeNode10.Text = "Active Fault (Current DTC)";
            treeNode11.Name = "HistoricFault";
            treeNode11.Text = "Historic Fault (Historical DTC)";
            treeNode12.Name = "ReadDTC";
            treeNode12.Text = "Read DTC By Status";
            treeNode13.Name = "ClearAll";
            treeNode13.Text = "Clear all historic and active DTC information";
            treeNode14.Name = "ActiveDTCS";
            treeNode14.Text = "Active DTCS changed to Historic DTC";
            treeNode15.Name = "HistoricDTCS";
            treeNode15.Text = "Historic DTCS changed to Active DTC";
            treeNode16.Name = "ClearDiagnostic";
            treeNode16.Text = "Clear Diagnostic Information";
            treeNode17.Name = "nodeStandard";
            treeNode17.Text = "Standard Diagnostic Mode";
            treeNode18.Name = "StartDiagnostic2";
            treeNode18.Text = "Start Diagnostic Session";
            treeNode19.Name = "ECUInputBattery";
            treeNode19.Text = "ECU Input Battery Values";
            treeNode20.Name = "LampDrive";
            treeNode20.Text = "Lamp Drive Status";
            treeNode21.Name = "SensorStatus";
            treeNode21.Text = "Sensor Status Infromation";
            treeNode22.Name = "ECUStatus";
            treeNode22.Text = "ECU Status Infromation";
            treeNode23.Name = "ReadData";
            treeNode23.Text = "Read Data By Local Identifier";
            treeNode24.Name = "VehicleProject&WheelSize";
            treeNode24.Text = "Vehicle Project Name & Wheel Size";
            treeNode25.Name = "ECUIdentificationData";
            treeNode25.Text = "ECU Identificaiton data table";
            treeNode26.Name = "HMC/KMCData";
            treeNode26.Text = "HMC / KMC Part Configuration";
            treeNode27.Name = "VINData";
            treeNode27.Text = "VIN (Vehicle identification number)";
            treeNode28.Name = "SensorIDType";
            treeNode28.Text = "Sensor ID\'s Type 1 Learn";
            treeNode29.Name = "ManufacturePartInfo";
            treeNode29.Text = "Manufacture Part Information Block";
            treeNode30.Name = "노드30";
            treeNode30.Text = "Write Data By Local Identifier";
            treeNode31.Name = "nodeECU";
            treeNode31.Text = "ECU Programming Mode";
            treeNode32.Name = "StartDiagnostic3";
            treeNode32.Text = "Start Diagnostic Session";
            treeNode33.Name = "StopDiagnostic2";
            treeNode33.Text = "Stop Diagnostic Session";
            treeNode34.Name = "VehicleProject2";
            treeNode34.Text = "Vehicle Project Name";
            treeNode35.Name = "EcuIdentification2";
            treeNode35.Text = "Ecu Identification Data Table";
            treeNode36.Name = "HMC/KMC2";
            treeNode36.Text = "HMC/KMC Part configuration";
            treeNode37.Name = "VIN2";
            treeNode37.Text = "VIN (Vehicle Identification Number)";
            treeNode38.Name = "ReadSensors2";
            treeNode38.Text = "Read Sensors Id";
            treeNode39.Name = "ManufacturerPart2";
            treeNode39.Text = "Manufacturer Part Information Block";
            treeNode40.Name = "ReadECU2";
            treeNode40.Text = "Read ECU Identification ID";
            treeNode41.Name = "nodeExtended";
            treeNode41.Text = "Extended Diagnostic Mode";
            this.ServiceList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode31,
            treeNode41});
            this.ServiceList.Size = new System.Drawing.Size(681, 361);
            this.ServiceList.TabIndex = 5;
            this.ServiceList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ServiceList_NodeMouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(681, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "Service Request";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.24F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.76F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 318F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.CH1_Button, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.50617F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.49383F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(687, 81);
            this.tableLayoutPanel7.TabIndex = 1;
            this.tableLayoutPanel7.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel";
            // 
            // CH1_Button
            // 
            this.CH1_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CH1_Button.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CH1_Button.Location = new System.Drawing.Point(3, 34);
            this.CH1_Button.Name = "CH1_Button";
            this.CH1_Button.Size = new System.Drawing.Size(681, 44);
            this.CH1_Button.TabIndex = 1;
            this.CH1_Button.Text = "Connect";
            this.CH1_Button.UseVisualStyleBackColor = true;
            this.CH1_Button.Click += new System.EventHandler(this.CH1_Button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.85173F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.14827F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 498);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.40263F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.59737F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1902, 569);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.10661F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.89339F));
            this.tableLayoutPanel11.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.LogListBox, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel24, 0, 2);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.913794F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0862F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1896, 563);
            this.tableLayoutPanel11.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1890, 48);
            this.label7.TabIndex = 2;
            this.label7.Text = "Log List";
            // 
            // LogListBox
            // 
            this.LogListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LogListBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.ItemHeight = 32;
            this.LogListBox.Location = new System.Drawing.Point(3, 51);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(1890, 433);
            this.LogListBox.TabIndex = 3;
            this.LogListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LogListBox_DrawItem);
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 4;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.39164F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.60836F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel24.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.LogResetButton, 3, 0);
            this.tableLayoutPanel24.Controls.Add(this.CountLav, 2, 0);
            this.tableLayoutPanel24.Controls.Add(this.CycleLav, 1, 0);
            this.tableLayoutPanel24.Location = new System.Drawing.Point(3, 490);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 1;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(1890, 44);
            this.tableLayoutPanel24.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 44);
            this.label9.TabIndex = 15;
            this.label9.Text = "ID = 593";
            // 
            // LogResetButton
            // 
            this.LogResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LogResetButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogResetButton.Location = new System.Drawing.Point(1710, 3);
            this.LogResetButton.Name = "LogResetButton";
            this.LogResetButton.Size = new System.Drawing.Size(144, 38);
            this.LogResetButton.TabIndex = 14;
            this.LogResetButton.Text = "Reset";
            this.LogResetButton.UseVisualStyleBackColor = true;
            this.LogResetButton.Click += new System.EventHandler(this.LogResetButton_Click);
            // 
            // CountLav
            // 
            this.CountLav.AutoSize = true;
            this.CountLav.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CountLav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountLav.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLav.Location = new System.Drawing.Point(910, 0);
            this.CountLav.Name = "CountLav";
            this.CountLav.Size = new System.Drawing.Size(794, 44);
            this.CountLav.TabIndex = 1;
            this.CountLav.Text = "Count :";
            // 
            // CycleLav
            // 
            this.CycleLav.AutoSize = true;
            this.CycleLav.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CycleLav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CycleLav.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CycleLav.Location = new System.Drawing.Point(151, 0);
            this.CycleLav.Name = "CycleLav";
            this.CycleLav.Size = new System.Drawing.Size(753, 44);
            this.CycleLav.TabIndex = 0;
            this.CycleLav.Text = "Cycle(ms) :";
            // 
            // TPMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TPMS";
            this.Text = "0";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dud_STmin_us)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udStmin_ms)).EndInit();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FC_ID_Edit)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSG_ID_Edit)).EndInit();
            this.tbpn_DataByte.ResumeLayout(false);
            this.tbpn_DataByte.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CH1_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TreeView ServiceList;
        private System.Windows.Forms.ListBox LogListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.Button LogResetButton;
        private System.Windows.Forms.Label CountLav;
        private System.Windows.Forms.Label CycleLav;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Button FC_Set;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.NumericUpDown dud_STmin_us;
        private System.Windows.Forms.RadioButton rBtn_ms;
        private System.Windows.Forms.NumericUpDown udStmin_ms;
        private System.Windows.Forms.RadioButton rBtn_μs;
        private System.Windows.Forms.TextBox tb_bs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.TextBox tb_fc0;
        private System.Windows.Forms.TextBox tb_fc7;
        private System.Windows.Forms.TextBox tb_fc1;
        private System.Windows.Forms.TextBox tb_fc2;
        private System.Windows.Forms.TextBox tb_fc6;
        private System.Windows.Forms.TextBox tb_fc3;
        private System.Windows.Forms.TextBox tb_fc4;
        private System.Windows.Forms.TextBox tb_fc5;
        private NationalInstruments.UI.WindowsForms.NumericEdit FC_ID_Edit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Button MessageSendButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private NationalInstruments.UI.WindowsForms.NumericEdit MSG_ID_Edit;
        private System.Windows.Forms.TableLayoutPanel tbpn_DataByte;
        private System.Windows.Forms.TextBox tb_byte7;
        private System.Windows.Forms.TextBox tb_byte1;
        private System.Windows.Forms.TextBox tb_byte2;
        private System.Windows.Forms.TextBox tb_byte6;
        private System.Windows.Forms.TextBox tb_byte3;
        private System.Windows.Forms.TextBox tb_byte4;
        private System.Windows.Forms.TextBox tb_byte5;
        private System.Windows.Forms.TextBox tb_byte0;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

