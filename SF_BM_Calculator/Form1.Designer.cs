namespace SF_BM_Calculator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtOaSpan = new System.Windows.Forms.TextBox();
            this.txtBreadth = new System.Windows.Forms.TextBox();
            this.txtThickness = new System.Windows.Forms.TextBox();
            this.txtBearLeft = new System.Windows.Forms.TextBox();
            this.txtBearRight = new System.Windows.Forms.TextBox();
            this.txtOverhangLeft = new System.Windows.Forms.TextBox();
            this.txtOverhangRight = new System.Windows.Forms.TextBox();
            this.txtLenHole = new System.Windows.Forms.TextBox();
            this.txtHeightHole = new System.Windows.Forms.TextBox();
            this.txtDistLeftHole = new System.Windows.Forms.TextBox();
            this.txtDensityHole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdEnd = new System.Windows.Forms.Button();
            this.SF_BM_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.dgNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SF_BM_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInterval
            // 
            this.txtInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterval.Location = new System.Drawing.Point(98, 24);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(88, 24);
            this.txtInterval.TabIndex = 0;
            this.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // txtOaSpan
            // 
            this.txtOaSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOaSpan.Location = new System.Drawing.Point(98, 60);
            this.txtOaSpan.Name = "txtOaSpan";
            this.txtOaSpan.Size = new System.Drawing.Size(88, 24);
            this.txtOaSpan.TabIndex = 1;
            this.txtOaSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOaSpan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOaSpan_KeyPress);
            // 
            // txtBreadth
            // 
            this.txtBreadth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreadth.Location = new System.Drawing.Point(98, 98);
            this.txtBreadth.Name = "txtBreadth";
            this.txtBreadth.Size = new System.Drawing.Size(88, 24);
            this.txtBreadth.TabIndex = 2;
            this.txtBreadth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBreadth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBreadth_KeyPress);
            // 
            // txtThickness
            // 
            this.txtThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThickness.Location = new System.Drawing.Point(98, 132);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.Size = new System.Drawing.Size(88, 24);
            this.txtThickness.TabIndex = 3;
            this.txtThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtThickness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThickness_KeyPress);
            // 
            // txtBearLeft
            // 
            this.txtBearLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBearLeft.Location = new System.Drawing.Point(357, 24);
            this.txtBearLeft.Name = "txtBearLeft";
            this.txtBearLeft.Size = new System.Drawing.Size(88, 24);
            this.txtBearLeft.TabIndex = 4;
            this.txtBearLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBearLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBearLeft_KeyPress);
            // 
            // txtBearRight
            // 
            this.txtBearRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBearRight.Location = new System.Drawing.Point(357, 60);
            this.txtBearRight.Name = "txtBearRight";
            this.txtBearRight.Size = new System.Drawing.Size(88, 24);
            this.txtBearRight.TabIndex = 5;
            this.txtBearRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBearRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBearRight_KeyPress);
            // 
            // txtOverhangLeft
            // 
            this.txtOverhangLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverhangLeft.Location = new System.Drawing.Point(357, 98);
            this.txtOverhangLeft.Name = "txtOverhangLeft";
            this.txtOverhangLeft.Size = new System.Drawing.Size(88, 24);
            this.txtOverhangLeft.TabIndex = 6;
            this.txtOverhangLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOverhangLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOverhangLeft_KeyPress);
            // 
            // txtOverhangRight
            // 
            this.txtOverhangRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverhangRight.Location = new System.Drawing.Point(357, 132);
            this.txtOverhangRight.Name = "txtOverhangRight";
            this.txtOverhangRight.Size = new System.Drawing.Size(88, 24);
            this.txtOverhangRight.TabIndex = 7;
            this.txtOverhangRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOverhangRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOverhangRight_KeyPress);
            // 
            // txtLenHole
            // 
            this.txtLenHole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLenHole.Location = new System.Drawing.Point(605, 24);
            this.txtLenHole.Name = "txtLenHole";
            this.txtLenHole.Size = new System.Drawing.Size(88, 24);
            this.txtLenHole.TabIndex = 8;
            this.txtLenHole.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLenHole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLenHole_KeyPress);
            // 
            // txtHeightHole
            // 
            this.txtHeightHole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeightHole.Location = new System.Drawing.Point(605, 60);
            this.txtHeightHole.Name = "txtHeightHole";
            this.txtHeightHole.Size = new System.Drawing.Size(88, 24);
            this.txtHeightHole.TabIndex = 9;
            this.txtHeightHole.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHeightHole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeightHole_KeyPress);
            // 
            // txtDistLeftHole
            // 
            this.txtDistLeftHole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistLeftHole.Location = new System.Drawing.Point(605, 94);
            this.txtDistLeftHole.Name = "txtDistLeftHole";
            this.txtDistLeftHole.Size = new System.Drawing.Size(88, 24);
            this.txtDistLeftHole.TabIndex = 10;
            this.txtDistLeftHole.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDistLeftHole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistLeftHole_KeyPress);
            // 
            // txtDensityHole
            // 
            this.txtDensityHole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDensityHole.Location = new System.Drawing.Point(605, 132);
            this.txtDensityHole.Name = "txtDensityHole";
            this.txtDensityHole.Size = new System.Drawing.Size(88, 24);
            this.txtDensityHole.TabIndex = 11;
            this.txtDensityHole.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDensityHole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDensityHole_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "oa_Span";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Breadth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thickness";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bearing_Left";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(256, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bearing_Right";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(252, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Overhang_Left";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(242, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Overhang_Right";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(534, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Len_Hole";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(516, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Height_Hole";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(500, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Dist_Left_Hole";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(507, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Density_Hole";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalculate.Location = new System.Drawing.Point(468, 181);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(98, 38);
            this.cmdCalculate.TabIndex = 12;
            this.cmdCalculate.Text = "&Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdEnd
            // 
            this.cmdEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnd.Location = new System.Drawing.Point(605, 181);
            this.cmdEnd.Name = "cmdEnd";
            this.cmdEnd.Size = new System.Drawing.Size(98, 38);
            this.cmdEnd.TabIndex = 13;
            this.cmdEnd.Text = "&Finish";
            this.cmdEnd.UseVisualStyleBackColor = true;
            this.cmdEnd.Click += new System.EventHandler(this.cmdEnd_Click);
            // 
            // SF_BM_Chart
            // 
            chartArea12.Name = "ChartArea1";
            this.SF_BM_Chart.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.SF_BM_Chart.Legends.Add(legend12);
            this.SF_BM_Chart.Location = new System.Drawing.Point(315, 249);
            this.SF_BM_Chart.Name = "SF_BM_Chart";
            series23.BorderWidth = 4;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Legend = "Legend1";
            series23.Name = "SF";
            series24.BorderWidth = 4;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Legend = "Legend1";
            series24.Name = "BM";
            this.SF_BM_Chart.Series.Add(series23);
            this.SF_BM_Chart.Series.Add(series24);
            this.SF_BM_Chart.Size = new System.Drawing.Size(431, 376);
            this.SF_BM_Chart.TabIndex = 14;
            this.SF_BM_Chart.Text = "chart1";
            // 
            // GridView
            // 
            this.GridView.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgNo,
            this.dgSF,
            this.dgBM});
            this.GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridView.Location = new System.Drawing.Point(52, 181);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowHeadersWidth = 20;
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(242, 444);
            this.GridView.TabIndex = 0;
            // 
            // dgNo
            // 
            this.dgNo.Frozen = true;
            this.dgNo.HeaderText = "No";
            this.dgNo.Name = "dgNo";
            this.dgNo.ReadOnly = true;
            this.dgNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgNo.Width = 40;
            // 
            // dgSF
            // 
            this.dgSF.Frozen = true;
            this.dgSF.HeaderText = "SF";
            this.dgSF.Name = "dgSF";
            this.dgSF.ReadOnly = true;
            this.dgSF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgSF.Width = 90;
            // 
            // dgBM
            // 
            this.dgBM.Frozen = true;
            this.dgBM.HeaderText = "BM";
            this.dgBM.Name = "dgBM";
            this.dgBM.ReadOnly = true;
            this.dgBM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgBM.Width = 90;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(189, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "mm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(189, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "mm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(189, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "mm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(448, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "mm";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(448, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "mm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(448, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "mm";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(448, 136);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "mm";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(696, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "mm";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(696, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "mm";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(696, 102);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 15);
            this.label23.TabIndex = 0;
            this.label23.Text = "mm";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(696, 136);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 15);
            this.label24.TabIndex = 0;
            this.label24.Text = "KN/m3";
            // 
            // cmdClear
            // 
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Location = new System.Drawing.Point(337, 181);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(97, 38);
            this.cmdClear.TabIndex = 15;
            this.cmdClear.Text = "Cl&ear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 636);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.SF_BM_Chart);
            this.Controls.Add(this.cmdEnd);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDensityHole);
            this.Controls.Add(this.txtDistLeftHole);
            this.Controls.Add(this.txtHeightHole);
            this.Controls.Add(this.txtLenHole);
            this.Controls.Add(this.txtOverhangRight);
            this.Controls.Add(this.txtOverhangLeft);
            this.Controls.Add(this.txtBearRight);
            this.Controls.Add(this.txtBearLeft);
            this.Controls.Add(this.txtThickness);
            this.Controls.Add(this.txtBreadth);
            this.Controls.Add(this.txtOaSpan);
            this.Controls.Add(this.txtInterval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "SF_BM_Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SF_BM_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TextBox txtOaSpan;
        private System.Windows.Forms.TextBox txtBreadth;
        private System.Windows.Forms.TextBox txtThickness;
        private System.Windows.Forms.TextBox txtBearLeft;
        private System.Windows.Forms.TextBox txtBearRight;
        private System.Windows.Forms.TextBox txtOverhangLeft;
        private System.Windows.Forms.TextBox txtOverhangRight;
        private System.Windows.Forms.TextBox txtLenHole;
        private System.Windows.Forms.TextBox txtHeightHole;
        private System.Windows.Forms.TextBox txtDistLeftHole;
        private System.Windows.Forms.TextBox txtDensityHole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdEnd;
        private System.Windows.Forms.DataVisualization.Charting.Chart SF_BM_Chart;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBM;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button cmdClear;
    }
}

