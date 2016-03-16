namespace 人脸1
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("导入考勤数据");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("导出考勤数据");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("备份数据库");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("数据管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("从设备下载记录数据");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("从设备下载记录数据");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("从设备下载记录数据");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("设备管理");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("有关设备操作", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("管理员设置");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("人员维护");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("数据库设置");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("部门表");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("设备/维护", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("时间段维护");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("人员排班");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("班次管理");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("考勤规则");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("人员排班", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            this.人脸注册 = new System.Windows.Forms.Button();
            this.面部识别 = new System.Windows.Forms.Button();
            this.指纹识别 = new System.Windows.Forms.Button();
            this.管理人员 = new System.Windows.Forms.Button();
            this.查询信息 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初始化系统IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除过期数据TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份数据库CtrlBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.导入考勤数据CtrlIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出考勤数据EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.uSB闪存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登陆系统CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤处理EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公出请假ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.忘签到CtrlKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.集体迟到早退处理CtrlLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询打印SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出勤记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.当前在岗情况CtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.统计报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.系统操作日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维护设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门管理DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员维护CtrlEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员设置AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.时间段维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班次管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员排班ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.节日维护HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤规则RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.假类设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.数据库设置OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.断开设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.从设置下载记录数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传人员信息到设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载人员信息及其指纹信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.清除设备中的记录数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.同步设置时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看人脸说明CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.检查新版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.关于考勤管理系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.人员维护 = new System.Windows.Forms.ToolStripButton();
            this.出勤记录 = new System.Windows.Forms.ToolStripButton();
            this.统计报表 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.设备维护 = new System.Windows.Forms.ToolStripButton();
            this.删除设备 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.连接设备 = new System.Windows.Forms.ToolStripButton();
            this.断开设备 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.退出系统 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.设置名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.机器号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.通信方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.波特率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.端口号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.人员数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.管理员数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.指纹数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.人脸数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.考勤记录 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.序列号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.登记号或卡号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.对比方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // 人脸注册
            // 
            this.人脸注册.BackColor = System.Drawing.Color.Transparent;
            this.人脸注册.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("人脸注册.BackgroundImage")));
            this.人脸注册.Cursor = System.Windows.Forms.Cursors.Default;
            this.人脸注册.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.人脸注册.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.人脸注册.ImageKey = "(无)";
            this.人脸注册.Location = new System.Drawing.Point(-1, 392);
            this.人脸注册.Name = "人脸注册";
            this.人脸注册.Size = new System.Drawing.Size(141, 38);
            this.人脸注册.TabIndex = 0;
            this.人脸注册.Text = "人脸注册";
            this.人脸注册.UseVisualStyleBackColor = false;
            this.人脸注册.Click += new System.EventHandler(this.button1_Click);
            // 
            // 面部识别
            // 
            this.面部识别.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.面部识别.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("面部识别.BackgroundImage")));
            this.面部识别.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.面部识别.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.面部识别.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.面部识别.Location = new System.Drawing.Point(-1, 347);
            this.面部识别.Name = "面部识别";
            this.面部识别.Size = new System.Drawing.Size(141, 39);
            this.面部识别.TabIndex = 1;
            this.面部识别.Text = "面部识别";
            this.面部识别.UseVisualStyleBackColor = false;
            this.面部识别.Click += new System.EventHandler(this.button2_Click);
            // 
            // 指纹识别
            // 
            this.指纹识别.Location = new System.Drawing.Point(0, 0);
            this.指纹识别.Name = "指纹识别";
            this.指纹识别.Size = new System.Drawing.Size(75, 23);
            this.指纹识别.TabIndex = 1;
            // 
            // 管理人员
            // 
            this.管理人员.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.管理人员.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("管理人员.BackgroundImage")));
            this.管理人员.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.管理人员.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.管理人员.Location = new System.Drawing.Point(-1, 436);
            this.管理人员.Name = "管理人员";
            this.管理人员.Size = new System.Drawing.Size(138, 43);
            this.管理人员.TabIndex = 3;
            this.管理人员.Text = "管理人员";
            this.管理人员.UseVisualStyleBackColor = false;
            this.管理人员.Click += new System.EventHandler(this.button3_Click);
            // 
            // 查询信息
            // 
            this.查询信息.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.查询信息.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("查询信息.BackgroundImage")));
            this.查询信息.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.查询信息.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.查询信息.Location = new System.Drawing.Point(0, 485);
            this.查询信息.Name = "查询信息";
            this.查询信息.Size = new System.Drawing.Size(141, 46);
            this.查询信息.TabIndex = 4;
            this.查询信息.Text = "查询信息";
            this.查询信息.UseVisualStyleBackColor = false;
            this.查询信息.Click += new System.EventHandler(this.查询信息_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据ToolStripMenuItem,
            this.考勤处理EToolStripMenuItem,
            this.查询打印SToolStripMenuItem,
            this.维护设置ToolStripMenuItem,
            this.设备管理ToolStripMenuItem,
            this.帮助HToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 26);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据ToolStripMenuItem
            // 
            this.数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初始化系统IToolStripMenuItem,
            this.清除过期数据TToolStripMenuItem,
            this.备份数据库CtrlBToolStripMenuItem,
            this.toolStripSeparator4,
            this.导入考勤数据CtrlIToolStripMenuItem,
            this.导出考勤数据EToolStripMenuItem,
            this.toolStripSeparator5,
            this.uSB闪存管理ToolStripMenuItem,
            this.重新登陆系统CToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
            this.数据ToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.数据ToolStripMenuItem.Text = "数据（&F）";
            // 
            // 初始化系统IToolStripMenuItem
            // 
            this.初始化系统IToolStripMenuItem.Name = "初始化系统IToolStripMenuItem";
            this.初始化系统IToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.初始化系统IToolStripMenuItem.Text = "初始化系统（&I）";
            this.初始化系统IToolStripMenuItem.Click += new System.EventHandler(this.初始化系统IToolStripMenuItem_Click);
            // 
            // 清除过期数据TToolStripMenuItem
            // 
            this.清除过期数据TToolStripMenuItem.Name = "清除过期数据TToolStripMenuItem";
            this.清除过期数据TToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.清除过期数据TToolStripMenuItem.Text = "清除过期数据（&T）";
            this.清除过期数据TToolStripMenuItem.Click += new System.EventHandler(this.清除过期数据TToolStripMenuItem_Click);
            // 
            // 备份数据库CtrlBToolStripMenuItem
            // 
            this.备份数据库CtrlBToolStripMenuItem.Name = "备份数据库CtrlBToolStripMenuItem";
            this.备份数据库CtrlBToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.备份数据库CtrlBToolStripMenuItem.Text = "备份数据库  Ctrl+B";
            this.备份数据库CtrlBToolStripMenuItem.Click += new System.EventHandler(this.备份数据库CtrlBToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // 导入考勤数据CtrlIToolStripMenuItem
            // 
            this.导入考勤数据CtrlIToolStripMenuItem.Name = "导入考勤数据CtrlIToolStripMenuItem";
            this.导入考勤数据CtrlIToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.导入考勤数据CtrlIToolStripMenuItem.Text = "导入考勤数据  Ctrl+I";
            this.导入考勤数据CtrlIToolStripMenuItem.Click += new System.EventHandler(this.导入考勤数据CtrlIToolStripMenuItem_Click);
            // 
            // 导出考勤数据EToolStripMenuItem
            // 
            this.导出考勤数据EToolStripMenuItem.Name = "导出考勤数据EToolStripMenuItem";
            this.导出考勤数据EToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.导出考勤数据EToolStripMenuItem.Text = "导出考勤数据（&E）";
            this.导出考勤数据EToolStripMenuItem.Click += new System.EventHandler(this.导出考勤数据EToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(184, 6);
            // 
            // uSB闪存管理ToolStripMenuItem
            // 
            this.uSB闪存管理ToolStripMenuItem.Name = "uSB闪存管理ToolStripMenuItem";
            this.uSB闪存管理ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.uSB闪存管理ToolStripMenuItem.Text = "USB闪存管理";
            this.uSB闪存管理ToolStripMenuItem.Click += new System.EventHandler(this.uSB闪存管理ToolStripMenuItem_Click);
            // 
            // 重新登陆系统CToolStripMenuItem
            // 
            this.重新登陆系统CToolStripMenuItem.Name = "重新登陆系统CToolStripMenuItem";
            this.重新登陆系统CToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.重新登陆系统CToolStripMenuItem.Text = "重新登陆系统（&C）";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // 考勤处理EToolStripMenuItem
            // 
            this.考勤处理EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.公出请假ToolStripMenuItem,
            this.忘签到CtrlKToolStripMenuItem,
            this.集体迟到早退处理CtrlLToolStripMenuItem});
            this.考勤处理EToolStripMenuItem.Name = "考勤处理EToolStripMenuItem";
            this.考勤处理EToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.考勤处理EToolStripMenuItem.Text = "考勤处理（&E）";
            // 
            // 公出请假ToolStripMenuItem
            // 
            this.公出请假ToolStripMenuItem.Name = "公出请假ToolStripMenuItem";
            this.公出请假ToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.公出请假ToolStripMenuItem.Text = "公出/请假";
            this.公出请假ToolStripMenuItem.Click += new System.EventHandler(this.公出请假ToolStripMenuItem_Click);
            // 
            // 忘签到CtrlKToolStripMenuItem
            // 
            this.忘签到CtrlKToolStripMenuItem.Name = "忘签到CtrlKToolStripMenuItem";
            this.忘签到CtrlKToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.忘签到CtrlKToolStripMenuItem.Text = "忘签到  Ctrl+K";
            this.忘签到CtrlKToolStripMenuItem.Click += new System.EventHandler(this.忘签到CtrlKToolStripMenuItem_Click);
            // 
            // 集体迟到早退处理CtrlLToolStripMenuItem
            // 
            this.集体迟到早退处理CtrlLToolStripMenuItem.Name = "集体迟到早退处理CtrlLToolStripMenuItem";
            this.集体迟到早退处理CtrlLToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.集体迟到早退处理CtrlLToolStripMenuItem.Text = "集体迟到/早退处理  Ctrl+L";
            this.集体迟到早退处理CtrlLToolStripMenuItem.Click += new System.EventHandler(this.集体迟到早退处理CtrlLToolStripMenuItem_Click);
            // 
            // 查询打印SToolStripMenuItem
            // 
            this.查询打印SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.出勤记录ToolStripMenuItem,
            this.当前在岗情况CtrlCToolStripMenuItem,
            this.toolStripSeparator6,
            this.统计报表ToolStripMenuItem,
            this.toolStripSeparator7,
            this.系统操作日志ToolStripMenuItem});
            this.查询打印SToolStripMenuItem.Name = "查询打印SToolStripMenuItem";
            this.查询打印SToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.查询打印SToolStripMenuItem.Text = "查询/打印（&S）";
            // 
            // 出勤记录ToolStripMenuItem
            // 
            this.出勤记录ToolStripMenuItem.Name = "出勤记录ToolStripMenuItem";
            this.出勤记录ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.出勤记录ToolStripMenuItem.Text = "出勤记录";
            this.出勤记录ToolStripMenuItem.Click += new System.EventHandler(this.出勤记录ToolStripMenuItem_Click);
            // 
            // 当前在岗情况CtrlCToolStripMenuItem
            // 
            this.当前在岗情况CtrlCToolStripMenuItem.Name = "当前在岗情况CtrlCToolStripMenuItem";
            this.当前在岗情况CtrlCToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.当前在岗情况CtrlCToolStripMenuItem.Text = "当前在岗情况 Ctrl+C";
            this.当前在岗情况CtrlCToolStripMenuItem.Click += new System.EventHandler(this.当前在岗情况CtrlCToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(184, 6);
            // 
            // 统计报表ToolStripMenuItem
            // 
            this.统计报表ToolStripMenuItem.Name = "统计报表ToolStripMenuItem";
            this.统计报表ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.统计报表ToolStripMenuItem.Text = "统计报表";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(184, 6);
            // 
            // 系统操作日志ToolStripMenuItem
            // 
            this.系统操作日志ToolStripMenuItem.Name = "系统操作日志ToolStripMenuItem";
            this.系统操作日志ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.系统操作日志ToolStripMenuItem.Text = "系统操作日志";
            this.系统操作日志ToolStripMenuItem.Click += new System.EventHandler(this.系统操作日志ToolStripMenuItem_Click);
            // 
            // 维护设置ToolStripMenuItem
            // 
            this.维护设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.部门管理DToolStripMenuItem,
            this.人员维护CtrlEToolStripMenuItem,
            this.管理员设置AToolStripMenuItem,
            this.toolStripSeparator8,
            this.时间段维护ToolStripMenuItem,
            this.班次管理ToolStripMenuItem,
            this.人员排班ToolStripMenuItem,
            this.toolStripSeparator9,
            this.节日维护HToolStripMenuItem,
            this.考勤规则RToolStripMenuItem,
            this.假类设置ToolStripMenuItem,
            this.toolStripSeparator10,
            this.数据库设置OToolStripMenuItem,
            this.toolStripSeparator16,
            this.系统设置ToolStripMenuItem});
            this.维护设置ToolStripMenuItem.Name = "维护设置ToolStripMenuItem";
            this.维护设置ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.维护设置ToolStripMenuItem.Text = "维护/设置（&C）";
            // 
            // 部门管理DToolStripMenuItem
            // 
            this.部门管理DToolStripMenuItem.Name = "部门管理DToolStripMenuItem";
            this.部门管理DToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.部门管理DToolStripMenuItem.Text = "部门管理（&D）";
            this.部门管理DToolStripMenuItem.Click += new System.EventHandler(this.部门管理DToolStripMenuItem_Click);
            // 
            // 人员维护CtrlEToolStripMenuItem
            // 
            this.人员维护CtrlEToolStripMenuItem.Name = "人员维护CtrlEToolStripMenuItem";
            this.人员维护CtrlEToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.人员维护CtrlEToolStripMenuItem.Text = "人员维护 Ctrl+E";
            this.人员维护CtrlEToolStripMenuItem.Click += new System.EventHandler(this.人员维护CtrlEToolStripMenuItem_Click);
            // 
            // 管理员设置AToolStripMenuItem
            // 
            this.管理员设置AToolStripMenuItem.Name = "管理员设置AToolStripMenuItem";
            this.管理员设置AToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.管理员设置AToolStripMenuItem.Text = "管理员设置（&A）";
            this.管理员设置AToolStripMenuItem.Click += new System.EventHandler(this.管理员设置AToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // 时间段维护ToolStripMenuItem
            // 
            this.时间段维护ToolStripMenuItem.Name = "时间段维护ToolStripMenuItem";
            this.时间段维护ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.时间段维护ToolStripMenuItem.Text = "时间段维护";
            this.时间段维护ToolStripMenuItem.Click += new System.EventHandler(this.时间段维护ToolStripMenuItem_Click);
            // 
            // 班次管理ToolStripMenuItem
            // 
            this.班次管理ToolStripMenuItem.Name = "班次管理ToolStripMenuItem";
            this.班次管理ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.班次管理ToolStripMenuItem.Text = "班次管理";
            this.班次管理ToolStripMenuItem.Click += new System.EventHandler(this.班次管理ToolStripMenuItem_Click);
            // 
            // 人员排班ToolStripMenuItem
            // 
            this.人员排班ToolStripMenuItem.Name = "人员排班ToolStripMenuItem";
            this.人员排班ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.人员排班ToolStripMenuItem.Text = "人员排班";
            this.人员排班ToolStripMenuItem.Click += new System.EventHandler(this.人员排班ToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(165, 6);
            // 
            // 节日维护HToolStripMenuItem
            // 
            this.节日维护HToolStripMenuItem.Name = "节日维护HToolStripMenuItem";
            this.节日维护HToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.节日维护HToolStripMenuItem.Text = "节日维护（&H）";
            this.节日维护HToolStripMenuItem.Click += new System.EventHandler(this.节日维护HToolStripMenuItem_Click);
            // 
            // 考勤规则RToolStripMenuItem
            // 
            this.考勤规则RToolStripMenuItem.Name = "考勤规则RToolStripMenuItem";
            this.考勤规则RToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.考勤规则RToolStripMenuItem.Text = "考勤规则（&R）";
            this.考勤规则RToolStripMenuItem.Click += new System.EventHandler(this.考勤规则RToolStripMenuItem_Click);
            // 
            // 假类设置ToolStripMenuItem
            // 
            this.假类设置ToolStripMenuItem.Name = "假类设置ToolStripMenuItem";
            this.假类设置ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.假类设置ToolStripMenuItem.Text = "假类设置";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(165, 6);
            // 
            // 数据库设置OToolStripMenuItem
            // 
            this.数据库设置OToolStripMenuItem.Name = "数据库设置OToolStripMenuItem";
            this.数据库设置OToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.数据库设置OToolStripMenuItem.Text = "数据库设置（&O）";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(165, 6);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 设备管理ToolStripMenuItem
            // 
            this.设备管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接设备ToolStripMenuItem,
            this.断开设置ToolStripMenuItem,
            this.toolStripSeparator11,
            this.从设置下载记录数据ToolStripMenuItem,
            this.上传人员信息到设备ToolStripMenuItem,
            this.下载人员信息及其指纹信息ToolStripMenuItem,
            this.toolStripSeparator12,
            this.清除设备中的记录数据ToolStripMenuItem,
            this.设备管理ToolStripMenuItem1,
            this.toolStripSeparator13,
            this.同步设置时间ToolStripMenuItem});
            this.设备管理ToolStripMenuItem.Name = "设备管理ToolStripMenuItem";
            this.设备管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.设备管理ToolStripMenuItem.Text = "设备管理";
            // 
            // 连接设备ToolStripMenuItem
            // 
            this.连接设备ToolStripMenuItem.Name = "连接设备ToolStripMenuItem";
            this.连接设备ToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.连接设备ToolStripMenuItem.Text = "连接设备";
            // 
            // 断开设置ToolStripMenuItem
            // 
            this.断开设置ToolStripMenuItem.Name = "断开设置ToolStripMenuItem";
            this.断开设置ToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.断开设置ToolStripMenuItem.Text = "断开设置";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(215, 6);
            // 
            // 从设置下载记录数据ToolStripMenuItem
            // 
            this.从设置下载记录数据ToolStripMenuItem.Name = "从设置下载记录数据ToolStripMenuItem";
            this.从设置下载记录数据ToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.从设置下载记录数据ToolStripMenuItem.Text = "从设置下载记录数据";
            // 
            // 上传人员信息到设备ToolStripMenuItem
            // 
            this.上传人员信息到设备ToolStripMenuItem.Name = "上传人员信息到设备ToolStripMenuItem";
            this.上传人员信息到设备ToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.上传人员信息到设备ToolStripMenuItem.Text = "上传人员信息到设备";
            // 
            // 下载人员信息及其指纹信息ToolStripMenuItem
            // 
            this.下载人员信息及其指纹信息ToolStripMenuItem.Name = "下载人员信息及其指纹信息ToolStripMenuItem";
            this.下载人员信息及其指纹信息ToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.下载人员信息及其指纹信息ToolStripMenuItem.Text = "下载人员信息及其指纹信息";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(215, 6);
            // 
            // 清除设备中的记录数据ToolStripMenuItem
            // 
            this.清除设备中的记录数据ToolStripMenuItem.Name = "清除设备中的记录数据ToolStripMenuItem";
            this.清除设备中的记录数据ToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.清除设备中的记录数据ToolStripMenuItem.Text = "清除设备中的记录数据";
            // 
            // 设备管理ToolStripMenuItem1
            // 
            this.设备管理ToolStripMenuItem1.Name = "设备管理ToolStripMenuItem1";
            this.设备管理ToolStripMenuItem1.Size = new System.Drawing.Size(218, 22);
            this.设备管理ToolStripMenuItem1.Text = "设备管理";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(215, 6);
            // 
            // 同步设置时间ToolStripMenuItem
            // 
            this.同步设置时间ToolStripMenuItem.Name = "同步设置时间ToolStripMenuItem";
            this.同步设置时间ToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.同步设置时间ToolStripMenuItem.Text = "同步设置时间";
            // 
            // 帮助HToolStripMenuItem1
            // 
            this.帮助HToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助HToolStripMenuItem,
            this.查看人脸说明CToolStripMenuItem,
            this.toolStripSeparator14,
            this.检查新版本ToolStripMenuItem,
            this.toolStripSeparator15,
            this.关于考勤管理系统ToolStripMenuItem});
            this.帮助HToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.帮助HToolStripMenuItem1.Name = "帮助HToolStripMenuItem1";
            this.帮助HToolStripMenuItem1.Size = new System.Drawing.Size(87, 22);
            this.帮助HToolStripMenuItem1.Text = "帮助（&H）";
            // 
            // 查看帮助HToolStripMenuItem
            // 
            this.查看帮助HToolStripMenuItem.Name = "查看帮助HToolStripMenuItem";
            this.查看帮助HToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.查看帮助HToolStripMenuItem.Text = "系统帮助（&H）";
            // 
            // 查看人脸说明CToolStripMenuItem
            // 
            this.查看人脸说明CToolStripMenuItem.Name = "查看人脸说明CToolStripMenuItem";
            this.查看人脸说明CToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.查看人脸说明CToolStripMenuItem.Text = "打开全部启动提示";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(185, 6);
            // 
            // 检查新版本ToolStripMenuItem
            // 
            this.检查新版本ToolStripMenuItem.Name = "检查新版本ToolStripMenuItem";
            this.检查新版本ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.检查新版本ToolStripMenuItem.Text = "检查新版本";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(185, 6);
            // 
            // 关于考勤管理系统ToolStripMenuItem
            // 
            this.关于考勤管理系统ToolStripMenuItem.Name = "关于考勤管理系统ToolStripMenuItem";
            this.关于考勤管理系统ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.关于考勤管理系统ToolStripMenuItem.Text = "关于考勤管理系统";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1135, 23);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(106, 18);
            this.toolStripStatusLabel2.Text = "系统当前时间：";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人员维护,
            this.出勤记录,
            this.统计报表,
            this.toolStripSeparator1,
            this.设备维护,
            this.删除设备,
            this.toolStripSeparator2,
            this.连接设备,
            this.断开设备,
            this.toolStripSeparator3,
            this.退出系统});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1135, 67);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 人员维护
            // 
            this.人员维护.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.人员维护.Name = "人员维护";
            this.人员维护.Size = new System.Drawing.Size(59, 64);
            this.人员维护.Text = "人员维护";
            // 
            // 出勤记录
            // 
            this.出勤记录.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.出勤记录.Name = "出勤记录";
            this.出勤记录.Size = new System.Drawing.Size(59, 64);
            this.出勤记录.Text = "出勤记录";
            // 
            // 统计报表
            // 
            this.统计报表.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.统计报表.Name = "统计报表";
            this.统计报表.Size = new System.Drawing.Size(59, 64);
            this.统计报表.Text = "统计报表";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 67);
            // 
            // 设备维护
            // 
            this.设备维护.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.设备维护.Name = "设备维护";
            this.设备维护.Size = new System.Drawing.Size(59, 64);
            this.设备维护.Text = "设备维护";
            // 
            // 删除设备
            // 
            this.删除设备.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.删除设备.Name = "删除设备";
            this.删除设备.Size = new System.Drawing.Size(59, 64);
            this.删除设备.Text = "删除设备";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 67);
            // 
            // 连接设备
            // 
            this.连接设备.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.连接设备.Name = "连接设备";
            this.连接设备.Size = new System.Drawing.Size(59, 64);
            this.连接设备.Text = "连接设备";
            // 
            // 断开设备
            // 
            this.断开设备.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.断开设备.Name = "断开设备";
            this.断开设备.Size = new System.Drawing.Size(59, 64);
            this.断开设备.Text = "断开设备";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 67);
            // 
            // 退出系统
            // 
            this.退出系统.Image = ((System.Drawing.Image)(resources.GetObject("退出系统.Image")));
            this.退出系统.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.退出系统.Name = "退出系统";
            this.退出系统.Size = new System.Drawing.Size(119, 64);
            this.退出系统.Text = "退出系统";
            this.退出系统.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.退出系统.Click += new System.EventHandler(this.退出系统_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.指纹识别);
            this.panel1.Controls.Add(this.面部识别);
            this.panel1.Controls.Add(this.人脸注册);
            this.panel1.Controls.Add(this.查询信息);
            this.panel1.Controls.Add(this.管理人员);
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 539);
            this.panel1.TabIndex = 8;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.treeView1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold);
            this.treeView1.LineColor = System.Drawing.Color.Maroon;
            this.treeView1.Location = new System.Drawing.Point(3, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "导入考勤数据";
            treeNode1.Text = "导入考勤数据";
            treeNode2.Name = "导出考勤数据";
            treeNode2.Text = "导出考勤数据";
            treeNode3.Name = "备份数据库";
            treeNode3.Text = "备份数据库";
            treeNode4.ForeColor = System.Drawing.Color.Blue;
            treeNode4.Name = "节点0";
            treeNode4.Text = "数据管理";
            treeNode5.Name = "从设备下载记录数据";
            treeNode5.Text = "从设备下载记录数据";
            treeNode6.Name = "从设备下载人员信息";
            treeNode6.Text = "从设备下载记录数据";
            treeNode7.Name = "上传人员信息到设备";
            treeNode7.Text = "从设备下载记录数据";
            treeNode8.Name = "设备管理";
            treeNode8.Text = "设备管理";
            treeNode9.ForeColor = System.Drawing.Color.Blue;
            treeNode9.Name = "有关设备操作";
            treeNode9.Text = "有关设备操作";
            treeNode10.Name = "管理员设置";
            treeNode10.Text = "管理员设置";
            treeNode11.Name = "人员维护";
            treeNode11.Text = "人员维护";
            treeNode12.Name = "数据库设置";
            treeNode12.Text = "数据库设置";
            treeNode13.Name = "部门表";
            treeNode13.Text = "部门表";
            treeNode14.ForeColor = System.Drawing.Color.Blue;
            treeNode14.Name = "设备/维护";
            treeNode14.Text = "设备/维护";
            treeNode15.Name = "时间段维护";
            treeNode15.Text = "时间段维护";
            treeNode16.Name = "人员排班";
            treeNode16.Text = "人员排班";
            treeNode17.Name = "班次管理";
            treeNode17.Text = "班次管理";
            treeNode18.Name = "考勤规则";
            treeNode18.Text = "考勤规则";
            treeNode19.ForeColor = System.Drawing.Color.Blue;
            treeNode19.Name = "人员排班";
            treeNode19.Text = "人员排班";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode9,
            treeNode14,
            treeNode19});
            this.treeView1.Size = new System.Drawing.Size(203, 329);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(125, 175);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Location = new System.Drawing.Point(236, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 29);
            this.panel2.TabIndex = 9;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(912, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 22);
            this.toolStripLabel1.Text = "我的设备列表";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Location = new System.Drawing.Point(236, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(922, 504);
            this.panel3.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(892, 498);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.设置名称,
            this.状态,
            this.机器号,
            this.通信方式,
            this.波特率,
            this.IP地址,
            this.端口号,
            this.产品类型,
            this.人员数,
            this.管理员数,
            this.指纹数,
            this.人脸数,
            this.密码数,
            this.考勤记录,
            this.序列号});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(950, 566);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 设置名称
            // 
            this.设置名称.DividerWidth = 1;
            this.设置名称.HeaderText = "设置名称";
            this.设置名称.Name = "设置名称";
            // 
            // 状态
            // 
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            // 
            // 机器号
            // 
            this.机器号.HeaderText = "机器号";
            this.机器号.Name = "机器号";
            // 
            // 通信方式
            // 
            this.通信方式.HeaderText = "通信方式";
            this.通信方式.Name = "通信方式";
            // 
            // 波特率
            // 
            this.波特率.HeaderText = "波特率";
            this.波特率.Name = "波特率";
            // 
            // IP地址
            // 
            this.IP地址.HeaderText = "IP地址";
            this.IP地址.Name = "IP地址";
            // 
            // 端口号
            // 
            this.端口号.HeaderText = "端口号";
            this.端口号.Name = "端口号";
            // 
            // 产品类型
            // 
            this.产品类型.HeaderText = "产品类型";
            this.产品类型.Name = "产品类型";
            // 
            // 人员数
            // 
            this.人员数.HeaderText = "人员数";
            this.人员数.Name = "人员数";
            // 
            // 管理员数
            // 
            this.管理员数.HeaderText = "管理员数";
            this.管理员数.Name = "管理员数";
            // 
            // 指纹数
            // 
            this.指纹数.HeaderText = "指纹数";
            this.指纹数.Name = "指纹数";
            // 
            // 人脸数
            // 
            this.人脸数.HeaderText = "人脸数";
            this.人脸数.Name = "人脸数";
            // 
            // 密码数
            // 
            this.密码数.HeaderText = "密码数";
            this.密码数.Name = "密码数";
            // 
            // 考勤记录
            // 
            this.考勤记录.HeaderText = "考勤记录";
            this.考勤记录.Name = "考勤记录";
            // 
            // 序列号
            // 
            this.序列号.HeaderText = "序列号";
            this.序列号.Name = "序列号";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView3.Location = new System.Drawing.Point(653, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(263, 530);
            this.dataGridView3.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "时间";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.登记号或卡号,
            this.姓名,
            this.时间,
            this.设备名称,
            this.对比方式});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(644, 599);
            this.dataGridView2.TabIndex = 0;
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            // 
            // 登记号或卡号
            // 
            this.登记号或卡号.HeaderText = "登记号或卡号";
            this.登记号或卡号.Name = "登记号或卡号";
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            // 
            // 时间
            // 
            this.时间.HeaderText = "时间";
            this.时间.Name = "时间";
            // 
            // 设备名称
            // 
            this.设备名称.HeaderText = "设备名称";
            this.设备名称.Name = "设备名称";
            // 
            // 对比方式
            // 
            this.对比方式.HeaderText = "对比方式";
            this.对比方式.Name = "对比方式";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1135, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "人脸管理考勤程序";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 人脸注册;
        private System.Windows.Forms.Button 面部识别;
        private System.Windows.Forms.Button 指纹识别;
        private System.Windows.Forms.Button 管理人员;
        private System.Windows.Forms.Button 查询信息;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看人脸说明CToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 初始化系统IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除过期数据TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份数据库CtrlBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入考勤数据CtrlIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出考勤数据EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSB闪存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登陆系统CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤处理EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公出请假ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 忘签到CtrlKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 集体迟到早退处理CtrlLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询打印SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出勤记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 当前在岗情况CtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统操作日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维护设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门管理DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员维护CtrlEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员设置AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 时间段维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班次管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 节日维护HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤规则RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 假类设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库设置OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 断开设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 从设置下载记录数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上传人员信息到设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载人员信息及其指纹信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除设备中的记录数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 同步设置时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查新版本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于考勤管理系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 人员维护;
        private System.Windows.Forms.ToolStripButton 出勤记录;
        private System.Windows.Forms.ToolStripButton 统计报表;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 设备维护;
        private System.Windows.Forms.ToolStripButton 删除设备;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton 连接设备;
        private System.Windows.Forms.ToolStripButton 断开设备;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton 退出系统;
        private System.Windows.Forms.Panel panel1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登记号或卡号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 对比方式;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设置名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 机器号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 通信方式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 波特率;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 端口号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 人员数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 管理员数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 指纹数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 人脸数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 考勤记录;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序列号;
        private System.Windows.Forms.ToolStripMenuItem 人员排班ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
    }

}

