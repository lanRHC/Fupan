﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Data.Common;

namespace Fupan
{
    public partial class Form2 : Form
    {
        private HImage image_cankao; // 用于存储参考图像
        private HImage image_shiwu; // 用于存储实物图像
        private double zoomFactor_cankao = 1.0;
        private double zoomFactor_shiwu = 1.0;
        private int height_cankao, width_cankao;
        private int height_shiwu, width_shiwu;
        private double currentCenterX_cankao, currentCenterY_cankao;
        private double currentCenterX_shiwu, currentCenterY_shiwu;
        private List<string[]> csvData = new List<string[]>();
        private List<string> imagePaths = new List<string>();




        public Form2()
        {
            InitializeComponent();
            InitializeTableLayoutPanel();
            InitializeHalconWindow();
            comboBox_fupan.SelectedIndexChanged += comboBox1_SelectedIndexChanged; // 处理ComboBox的SelectedIndexChanged事件
            // 绑定 SelectedIndexChanged 事件处理程序
            comboBox_defectType.SelectedIndexChanged += comboBox_defectType_SelectedIndexChanged;
            comboBox_defectType.Items.AddRange(new string[] { "芯片NG1", "芯片NG2", "芯片NG3", "芯片NG4", "芯片NG5", "芯片NG6",
                "电阻NG7", "电阻NG8", "电阻NG9","电阻NG10", "电阻NG11", "电阻NG12" }); // 添加缺陷类型
        }
        private void InitializeHalconWindow()
        {
            // 设置鼠标滚轮事件
            cankantu_show.MouseWheel += cankantu_show_MouseWheel;
            shiwutu_show.MouseWheel += shiwutu_show_MouseWheel;

        }

        //显示参考图像部分
        private void DisplayImage_cankao(string image_path)
        {
            try
            {
                //加载图像
                image_cankao = new HImage(image_path);

                //获取图像尺寸
                //int height, width;
                image_cankao.GetImageSize(out height_cankao, out width_cankao);

                // 初始化中心点
                currentCenterX_cankao = width_cankao / 2.0;
                currentCenterY_cankao = height_cankao / 2.0;

                //清除窗口中的任何旧内容
                cankantu_show.HalconWindow.ClearWindow();

                //设置显示通道
                cankantu_show.HalconWindow.SetPart(0, 0, width_cankao - 1, height_cankao - 1);

                //显示图像
                cankantu_show.HalconWindow.DispObj(image_cankao);
            }
            catch (HalconException hex)
            {
                MessageBox.Show("Error loading image:" + hex.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //显示实物图像部分
        private void DisplayImage_shiwu(string image_path)
        {
            try
            {
                //加载图像
                image_shiwu = new HImage(image_path);

                //获取图像尺寸
                //int height, width;
                image_shiwu.GetImageSize(out height_shiwu, out width_shiwu);

                // 初始化中心点
                currentCenterX_shiwu = width_shiwu / 2.0;
                currentCenterY_shiwu = height_shiwu / 2.0;

                //清除窗口中的任何旧内容
                shiwutu_show.HalconWindow.ClearWindow();

                //设置显示通道
                shiwutu_show.HalconWindow.SetPart(0, 0, width_shiwu - 1, height_shiwu - 1);

                //显示图像
                shiwutu_show.HalconWindow.DispObj(image_shiwu);
            }
            catch (HalconException hex)
            {
                MessageBox.Show("Error loading image:" + hex.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 更新显示缩放后的参考图像
        private void UpdateImageDisplay_cankao()
        {
            if (image_cankao != null)
            {
                // 清除窗口中的任何旧内容
                cankantu_show.HalconWindow.ClearWindow();
                // 计算显示部分
                int displayHeight_cankao = (int)(height_cankao * zoomFactor_cankao);
                int displayWidth_cankao = (int)(width_cankao * zoomFactor_cankao);


                // 设置显示通道
                cankantu_show.HalconWindow.SetPart(0, 0, displayWidth_cankao - 1, displayHeight_cankao - 1);

                // 显示图像
                cankantu_show.HalconWindow.DispObj(image_cankao);

            }
        }
        // 更新显示缩放后的实物图像
        private void UpdateImageDisplay_shiwu()
        {
            if (image_shiwu != null)
            {
                // 清除窗口中的任何旧内容
                shiwutu_show.HalconWindow.ClearWindow();
                // 计算显示部分
                int displayHeight_shiwu = (int)(height_shiwu * zoomFactor_shiwu);
                int displayWidth_shiwu = (int)(width_shiwu * zoomFactor_shiwu);

                // 设置显示通道
                shiwutu_show.HalconWindow.SetPart(0, 0, displayWidth_shiwu - 1, displayHeight_shiwu - 1);

                // 显示图像
                shiwutu_show.HalconWindow.DispObj(image_shiwu);

            }
        }


        //定义鼠标滚轮控制参考图像显示缩放
        private void cankantu_show_MouseWheel(object sender, MouseEventArgs e)
        {
            // 获取当前鼠标在图像中的位置
            double mouseX = currentCenterX_cankao + (e.X - cankantu_show.Width / 2) / zoomFactor_cankao;
            double mouseY = currentCenterY_cankao + (e.Y - cankantu_show.Height / 2) / zoomFactor_cankao;

            if (e.Delta > 0)
            {
                zoomFactor_cankao *= 1.1; // 放大
            }
            else
            {
                zoomFactor_cankao /= 1.1; // 缩小
            }

            // 调整中心点位置
            currentCenterX_cankao = mouseX + (currentCenterX_cankao - mouseX) / zoomFactor_cankao;
            currentCenterY_cankao = mouseY + (currentCenterY_cankao - mouseY) / zoomFactor_cankao;

            // 更新图像显示
            UpdateImageDisplay_cankao();
        }
        //定义鼠标滚轮控制实物图像显示缩放
        private void shiwutu_show_MouseWheel(object sender, MouseEventArgs e)
        {
            // 获取当前鼠标在图像中的位置
            double mouseX = currentCenterX_shiwu + (e.X - shiwutu_show.Width / 2) / zoomFactor_shiwu;
            double mouseY = currentCenterY_shiwu + (e.Y - shiwutu_show.Height / 2) / zoomFactor_shiwu;

            if (e.Delta > 0)
            {
                zoomFactor_shiwu *= 1.1; // 放大
            }
            else
            {
                zoomFactor_shiwu /= 1.1; // 缩小
            }

            // 调整中心点位置
            currentCenterX_shiwu = mouseX + (currentCenterX_shiwu - mouseX) / zoomFactor_shiwu;
            currentCenterY_shiwu = mouseY + (currentCenterY_shiwu - mouseY) / zoomFactor_shiwu;

            // 更新图像显示
            UpdateImageDisplay_shiwu();
        }


        //定义查询显示图片按钮(暂未使用）
        private void Search_Click(object sender, EventArgs e)
        {// 创建并配置 OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image files (*.bmp;*.jpg;*.png;*.tif)|*.bmp;*.jpg;*.png;*.tif|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // 如果用户选择了文件并点击了“打开”
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 获取文件路径
                    string filePath = openFileDialog.FileName;

                    // 显示图像
                    DisplayImage_cankao(filePath);
                }
            }
        }


        //初始化表格部分
        private void InitializeTableLayoutPanel()
        {
            // 清空现有内容
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            // 设置列数
            tableLayoutPanel1.ColumnCount = 9;
            //tableLayoutPanel1.RowCount = 2;

            // 根据需要调整每列的宽度比例
            float[] columnWidths = { 10F, 25F, 12F, 12F, 10F, 15F, 10F, 17F, 24F };

            // 添加列样式
            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnWidths[i]));
            }

            // 设置表头
            //string[] headers = { "CRD名称", "SN", "联板位置", "库名", "缺陷名", "缺陷类型", "复判缺陷名", "数据(数值类)", "图片地址" };
            string[] headers = { "排布4X5", "托盘SN", "开始时间", "结束时间", "CT", "NG产品数量", "用户ID", "机台名", "产品名" };

            AddRowToTableLayoutPanel(headers, true);

            // 强制刷新布局，确保所有控件都按照新的设置重新布局
            tableLayoutPanel1.PerformLayout();
        }


        //加载表头函数
        private void AddRowToTableLayoutPanel(string[] rowValues, bool isHeader = false)
        {
            int rowIndex = isHeader ? 0 : tableLayoutPanel1.RowCount++;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            for (int i = 0; i < rowValues.Length; i++)
            {
                Label label = new Label
                {
                    Text = rowValues[i] ?? string.Empty,  // 去掉多余的空格
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                    Font = isHeader ? new Font(tableLayoutPanel1.Font, FontStyle.Bold) : tableLayoutPanel1.Font,

                    Margin = new Padding(0), // 添加边距，以便于绘制边框
                    Padding = new Padding(3), // 添加边距，以便于绘制边框
                };

                tableLayoutPanel1.Controls.Add(label, i, rowIndex);
            }
        }


        //写入csv文件

        private void LoadCsvToTableLayoutPanel(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath, Encoding.GetEncoding("GB2312")))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ",",
                    BadDataFound = null,
                    MissingFieldFound = null,
                }))
                {
                    csvData.Clear();
                    comboBox_fupan.Items.Clear();
                    imagePaths.Clear(); // 清空之前的图片路径

                    // 读取并添加数据行
                    while (csv.Read())
                    {
                        var row = new string[tableLayoutPanel1.ColumnCount];
                        for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                        {
                            row[i] = csv.GetField(i)?.Trim(); // 去掉多余的空格
                        }
                        csvData.Add(row);
                        imagePaths.Add(row[tableLayoutPanel1.ColumnCount - 1]); // 保存图片地址

                        comboBox_fupan.Items.Add("Row " + csvData.Count);
                    }

                    // 默认显示第一行数据
                    if (csvData.Count > 0)
                    {
                        //AddRowToTableLayoutPanel(csvData[0], false);
                        comboBox_fupan.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading CSV file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tableLayoutPanel1.PerformLayout();
        }


        //实时更新实物图和表格行数据comboBox

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox_fupan.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < csvData.Count)
            {
                string[] selectedRow = csvData[selectedIndex];
                UpdateTableLayoutPanel(selectedRow);

                // 显示对应的图片
                string imagePath = imagePaths[selectedIndex];
                DisplayImage_shiwu(imagePath);
                UpdateImageDisplay_shiwu(); // 更新实物图像的显示

                // 设置 comboBox_defectType 的选项
                comboBox_defectType.SelectedItem = selectedRow[5];
            }
            //给每个控件增加边框
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label label)
                {
                    label.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }


        //更新表格函数

        private void UpdateTableLayoutPanel(string[] rowValues)
        {
            // 保持表头不变，仅更新表格内容部分
            int rowIndex = 1; // 从第二行开始，因为第一行是表头
            for (int i = 0; i < rowValues.Length; i++)
            {
                if (i < tableLayoutPanel1.ColumnCount)
                {
                    Label label = tableLayoutPanel1.GetControlFromPosition(i, rowIndex) as Label;
                    if (label != null)
                    {
                        label.Text = rowValues[i];
                    }
                    else
                    {
                        // 如果没有对应的控件，添加新的控件
                        label = new Label
                        {
                            Text = rowValues[i] ?? string.Empty,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Fill,
                            AutoSize = true,
                            Margin = new Padding(0),
                            Padding = new Padding(3)
                        };
                        tableLayoutPanel1.Controls.Add(label, i, rowIndex);
                    }
                }
            }
        }


        //下拉框选择显示缺陷类型
        private void comboBox_defectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 获取当前选中的缺陷类型
            string selectedDefectType = comboBox_defectType.SelectedItem?.ToString();

            // 更新第六列数据
            if (!string.IsNullOrEmpty(selectedDefectType))
            {
                UpdateDefectType(selectedDefectType);
            }
        }


        // 缺陷类型更新到表格方法
        private void UpdateDefectType(string selectedDefectType)
        {
            int selectedIndex = comboBox_fupan.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < csvData.Count)
            {
                // 更新第六列数据
                csvData[selectedIndex][5] = selectedDefectType;
                // 更新 tableLayoutPanel1 中对应的 Label
                Label defectTypeLabel = tableLayoutPanel1.GetControlFromPosition(5, 1) as Label; // 修改为 rowIndex = 1
                if (defectTypeLabel != null)
                {
                    defectTypeLabel.Text = selectedDefectType;
                }
            }
        }

        //csv数据选择读取入口
        private void Input_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    InitializeTableLayoutPanel(); // 重新初始化表格
                    LoadCsvToTableLayoutPanel(filePath); // 加载CSV文件
                }
            }
            //读取固定的一张参考图
            string img_path = "C:\\Users\\Administrator\\Desktop\\SPC执行标准-阮宏程\\图片\\2024年04月04日\\N19-NEW\\" +
                "AAN28S7925A6A30019\\R0603_R0301_6_上相机_121344_F.jpg";
            // 显示图像
            DisplayImage_cankao(img_path);
        }



    }
}