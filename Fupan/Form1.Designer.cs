namespace Fupan
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cankantu_show = new HalconDotNet.HSmartWindowControl();
            this.shiwutu_show = new HalconDotNet.HSmartWindowControl();
            this.comboBox_fupan = new System.Windows.Forms.ComboBox();
            this.show = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new CBComponents.HeaderTableLayoutPanel();
            this.comboBox_defectType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new CBComponents.HeaderTableLayoutPanel();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1249, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cankantu_show
            // 
            this.cankantu_show.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cankantu_show.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.cankantu_show.HDoubleClickToFitContent = true;
            this.cankantu_show.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.cankantu_show.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.cankantu_show.HKeepAspectRatio = true;
            this.cankantu_show.HMoveContent = true;
            this.cankantu_show.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.cankantu_show.Location = new System.Drawing.Point(5, 257);
            this.cankantu_show.Margin = new System.Windows.Forms.Padding(0);
            this.cankantu_show.Name = "cankantu_show";
            this.cankantu_show.Size = new System.Drawing.Size(621, 338);
            this.cankantu_show.TabIndex = 3;
            this.cankantu_show.WindowSize = new System.Drawing.Size(621, 338);
            // 
            // shiwutu_show
            // 
            this.shiwutu_show.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shiwutu_show.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.shiwutu_show.HDoubleClickToFitContent = true;
            this.shiwutu_show.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.shiwutu_show.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.shiwutu_show.HKeepAspectRatio = true;
            this.shiwutu_show.HMoveContent = true;
            this.shiwutu_show.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.shiwutu_show.Location = new System.Drawing.Point(631, 257);
            this.shiwutu_show.Margin = new System.Windows.Forms.Padding(0);
            this.shiwutu_show.Name = "shiwutu_show";
            this.shiwutu_show.Size = new System.Drawing.Size(614, 338);
            this.shiwutu_show.TabIndex = 4;
            this.shiwutu_show.WindowSize = new System.Drawing.Size(614, 338);
            // 
            // comboBox_fupan
            // 
            this.comboBox_fupan.FormattingEnabled = true;
            this.comboBox_fupan.Location = new System.Drawing.Point(218, 11);
            this.comboBox_fupan.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_fupan.Name = "comboBox_fupan";
            this.comboBox_fupan.Size = new System.Drawing.Size(98, 20);
            this.comboBox_fupan.TabIndex = 0;
            this.comboBox_fupan.Text = "数据显示选择";
            this.comboBox_fupan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(11, 123);
            this.show.Margin = new System.Windows.Forms.Padding(2);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(115, 36);
            this.show.TabIndex = 8;
            this.show.Text = "参考图选择显示";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.Search_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(361, 6);
            this.Input.Margin = new System.Windows.Forms.Padding(2);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(85, 32);
            this.Input.TabIndex = 9;
            this.Input.Text = "读取数据";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 287);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(627, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "实物图";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(11, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "参考图";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(218, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.39535F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.60465F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 51);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // comboBox_defectType
            // 
            this.comboBox_defectType.FormattingEnabled = true;
            this.comboBox_defectType.Location = new System.Drawing.Point(657, 13);
            this.comboBox_defectType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_defectType.Name = "comboBox_defectType";
            this.comboBox_defectType.Size = new System.Drawing.Size(98, 20);
            this.comboBox_defectType.TabIndex = 14;
            this.comboBox_defectType.Text = "缺陷类型选择";
            this.comboBox_defectType.SelectedIndexChanged += new System.EventHandler(this.comboBox_defectType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(759, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "缺陷类型选择";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(218, 95);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(834, 131);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 597);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_defectType);
            this.Controls.Add(this.comboBox_fupan);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.show);
            this.Controls.Add(this.shiwutu_show);
            this.Controls.Add(this.cankantu_show);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private HalconDotNet.HSmartWindowControl cankantu_show;
        private HalconDotNet.HSmartWindowControl shiwutu_show;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_fupan;
        private CBComponents.HeaderTableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox_defectType;
        private System.Windows.Forms.Label label4;
        private CBComponents.HeaderTableLayoutPanel tableLayoutPanel2;
    }
}

