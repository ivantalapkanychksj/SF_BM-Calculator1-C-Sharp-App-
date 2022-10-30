using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SF_BM_Calculator
{
    public struct CalData
    {
        public InitialData _initialData;
        public MiddleData _middleData;
        public List<ResultData> _resultData;
    }
    public struct InitialData
    {
        public double n_Interval;
        public double n_oa_Span;
        public double n_Breadth;
        public double n_Thickness;
        public double n_Bearing_Left;
        public double n_Bearing_Right;
        public double n_Overhang_Left;
        public double n_Overhang_Right;
        public double n_Len_Hole;
        public double n_Height_Hole;
        public double n_Dist_Left_Hole;
        public double n_Density_Hole;
    }

    public struct MiddleData
    {
        public double d_Volume_Hole;
        public double d_UDL_Hole_Total;
        public double d_UDL_Hole;
        public double d_Total_Hole;
        public double d_dx;
        public double d_Dist_cc;
        public double d_OTM_Rt_Sup;
        public double d_R_left;
        public double d_R_right;
        public double d_R_left_pres;
        public double d_R_right_pres;
    }

    public struct ResultData
    {
        public int n_Interval;
        public double d_ix;
        public double d_Rlx;
        public double d_PointSF_x;
        public double d_Rrx;
        public double d_SF;
        public double d_Rlx_m;
        public double d_Point_BM_x;
        public double d_Rrx_m;
        public double d_BM;
    }

    public partial class Form1 : Form
    {

        public List<Control> textBox = new List<Control> ();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Add(txtInterval);
            textBox.Add(txtOaSpan);
            textBox.Add(txtBreadth);
            textBox.Add(txtThickness);
            textBox.Add(txtBearLeft);
            textBox.Add(txtBearRight);
            textBox.Add(txtOverhangLeft);
            textBox.Add(txtOverhangRight);
            textBox.Add(txtLenHole);
            textBox.Add(txtHeightHole);
            textBox.Add(txtDistLeftHole);
            textBox.Add(txtDensityHole);

            GridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void cmdEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {

            CalData _calData;
            InitialData _initData;

            if (!InputCheck())
            {
                MessageBox.Show("Please enter the basic data correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _initData = InputData();
            
            _calData = Calculate(_initData);

            int stLen = Convert.ToString(_calData._initialData.n_Interval).Length;

            SF_BM_Chart.Series["SF"].Points.Clear();
            SF_BM_Chart.Series["BM"].Points.Clear();

            for (int i = 0; i <= _calData._initialData.n_Interval; i++)
            {
                string st_Interval = Convert.ToString(i);
                
                double SF_Value = _calData._resultData[i].d_SF;
                double BM_Value = _calData._resultData[i].d_BM;

                SF_Value = Math.Floor(SF_Value * 100000) / 100000;
                BM_Value = Math.Floor(BM_Value * 100000) / 100000;
                
                GridView.Rows.Add(st_Interval, SF_Value, BM_Value);
    

                SF_BM_Chart.Series["SF"].Points.AddXY(st_Interval, SF_Value);
                SF_BM_Chart.Series["BM"].Points.AddXY(st_Interval, BM_Value);

            }

        }

        public bool InputCheck()
        {
            for(int i = 0; i < textBox.Count; i++)
            {
                if (textBox[i].Text.Length == 0)
                {
                    textBox[i].Focus();
                    return false;
                }
            }
            return true;
        }

        public InitialData InputData()
        {
            InitialData temp;

            temp.n_Interval = Convert.ToInt32(txtInterval.Text);
            temp.n_oa_Span = Convert.ToInt32(txtOaSpan.Text);
            temp.n_Breadth = Convert.ToInt32(txtBreadth.Text);
            temp.n_Thickness = Convert.ToInt32(txtThickness.Text);
            temp.n_Bearing_Left = Convert.ToInt32(txtBearLeft.Text);
            temp.n_Bearing_Right = Convert.ToInt32(txtBearRight.Text);
            temp.n_Overhang_Left = Convert.ToInt32(txtOverhangLeft.Text);
            temp.n_Overhang_Right = Convert.ToInt32(txtOverhangRight.Text);
            temp.n_Len_Hole = Convert.ToInt32(txtLenHole.Text);
            temp.n_Height_Hole = Convert.ToInt32(txtHeightHole.Text);
            temp.n_Dist_Left_Hole = Convert.ToInt32(txtDistLeftHole.Text);
            temp.n_Density_Hole = Convert.ToInt32(txtDensityHole.Text);

            return temp;

        }

        public CalData Calculate(InitialData data)
        {
            GridView.Rows.Clear();

            CalData tmpCalData;
            tmpCalData._resultData = new List<ResultData>();

            MiddleData tempMidData;
            ResultData tempResultData;

            tempMidData.d_Volume_Hole = data.n_Thickness * data.n_Len_Hole * data.n_Height_Hole / 1000000000;
            tempMidData.d_UDL_Hole_Total = data.n_Density_Hole * tempMidData.d_Volume_Hole;
            tempMidData.d_UDL_Hole = 1000 * tempMidData.d_UDL_Hole_Total / data.n_Len_Hole;
            tempMidData.d_Total_Hole = tempMidData.d_UDL_Hole * data.n_Len_Hole / 1000;
            tempMidData.d_dx = data.n_oa_Span / data.n_Interval;
            tempMidData.d_Dist_cc = data.n_oa_Span - data.n_Overhang_Left - data.n_Overhang_Right - (data.n_Bearing_Left + data.n_Bearing_Right) / 2;
            tempMidData.d_OTM_Rt_Sup = tempMidData.d_Total_Hole * (data.n_oa_Span - data.n_Dist_Left_Hole - data.n_Len_Hole / 2 - data.n_Overhang_Right - data.n_Bearing_Right / 2);
            tempMidData.d_R_left = tempMidData.d_OTM_Rt_Sup / tempMidData.d_Dist_cc;
            tempMidData.d_R_right = tempMidData.d_Total_Hole - tempMidData.d_R_left;
            tempMidData.d_R_left_pres = tempMidData.d_R_left / data.n_Bearing_Left;
            tempMidData.d_R_right_pres = tempMidData.d_R_right / data.n_Bearing_Right;

            tmpCalData._initialData = data;
            tmpCalData._middleData = tempMidData;


            for (int i = 0; i <= data.n_Interval; i++)
            {
                tempResultData.n_Interval = i;
                tempResultData.d_ix = tempResultData.n_Interval * data.n_oa_Span / data.n_Interval;
                
                if (tempResultData.d_ix < data.n_Overhang_Left)
                {
                    tempResultData.d_Rlx = 0;
                }else
                {
                    if (tempResultData.d_ix < (data.n_Overhang_Left + data.n_Bearing_Left))
                    {
                        tempResultData.d_Rlx = tempMidData.d_R_left_pres * (tempResultData.d_ix - data.n_Overhang_Left);
                    }
                    else
                    {
                        tempResultData.d_Rlx = tempMidData.d_R_left;
                    }
                }

                if (tempResultData.d_ix < data.n_Dist_Left_Hole)
                {
                    tempResultData.d_PointSF_x = 0;
                }
                else
                {
                    if (tempResultData.d_ix < (data.n_Dist_Left_Hole + data.n_Len_Hole))
                    {
                        tempResultData.d_PointSF_x = - tempMidData.d_UDL_Hole * (tempResultData.d_ix - data.n_Dist_Left_Hole) / 1000;
                    }
                    else
                    {
                        tempResultData.d_PointSF_x = - tempMidData.d_Total_Hole;
                    }
                }

                if (tempResultData.d_ix < (data.n_Overhang_Left + data.n_Bearing_Left / 2 + tempMidData.d_Dist_cc - data.n_Bearing_Right / 2))
                {
                    tempResultData.d_Rrx = 0;
                }
                else
                {
                    if (tempResultData.d_ix > (data.n_oa_Span - data.n_Overhang_Right))
                    {
                        tempResultData.d_Rrx = tempMidData.d_R_right;
                    }
                    else
                    {
                        tempResultData.d_Rrx = tempMidData.d_R_right_pres * (tempResultData.d_ix - (data.n_Overhang_Left + data.n_Bearing_Left / 2 + tempMidData.d_Dist_cc - data.n_Bearing_Right / 2));
                    }
                }

                tempResultData.d_SF = tempResultData.d_Rlx + tempResultData.d_PointSF_x + tempResultData.d_Rrx;

                if (tempResultData.d_ix < data.n_Overhang_Left)
                {
                    tempResultData.d_Rlx_m = 0;
                }
                else
                {
                    if (tempResultData.d_ix < (data.n_Overhang_Left + data.n_Bearing_Left))
                    {
                        tempResultData.d_Rlx_m = tempMidData.d_R_left_pres * Math.Pow(tempResultData.d_ix - data.n_Overhang_Left, 2) / 2000 ;
                    }
                    else
                    {
                        tempResultData.d_Rlx_m = tempMidData.d_R_left * (tempResultData.d_ix - data.n_Overhang_Left - data.n_Bearing_Left / 2)/1000;
                    }
                }

                if (tempResultData.d_ix < data.n_Dist_Left_Hole)
                {
                    tempResultData.d_Point_BM_x = 0;
                }
                else
                {
                    if (tempResultData.d_ix < (data.n_Dist_Left_Hole + data.n_Len_Hole))
                    {
                        tempResultData.d_Point_BM_x = - tempMidData.d_UDL_Hole * Math.Pow((tempResultData.d_ix - data.n_Dist_Left_Hole) / 1000, 2) / 2;
                    }
                    else
                    {
                        tempResultData.d_Point_BM_x = - tempMidData.d_Total_Hole * (tempResultData.d_ix - data.n_Dist_Left_Hole - data.n_Len_Hole / 2) / 1000;
                    }
                }

                if (tempResultData.d_ix < (data.n_Overhang_Left + data.n_Bearing_Left / 2 + tempMidData.d_Dist_cc - data.n_Bearing_Right / 2))
                {
                    tempResultData.d_Rrx_m = 0;
                }
                else
                {
                    if (tempResultData.d_ix > (data.n_oa_Span - data.n_Overhang_Right))
                    {
                        tempResultData.d_Rrx_m = tempMidData.d_R_right * (tempResultData.d_ix - data.n_oa_Span + data.n_Overhang_Right + data.n_Bearing_Right / 2) / 1000;
                    }
                    else
                    {
                        tempResultData.d_Rrx_m = tempMidData.d_R_right_pres * Math.Pow(tempResultData.d_ix - data.n_Overhang_Left - data.n_Bearing_Left / 2 - tempMidData.d_Dist_cc + data.n_Bearing_Right / 2, 2) / 2000;
                    }
                }

                tempResultData.d_BM = tempResultData.d_Rlx_m + tempResultData.d_Point_BM_x + tempResultData.d_Rrx_m;

                tmpCalData._resultData.Add(tempResultData);
            }

            return tmpCalData;
        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputMask(sender, e);
        }

        private void txtOaSpan_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputMask(sender, e);
        }

        private void txtBreadth_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputMask(sender, e);
        }

        private void txtThickness_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputMask(sender, e);
        }

        private void txtBearLeft_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputMask(sender, e);
        }

        private void txtBearRight_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputMask(sender, e);
        }

        private void txtOverhangLeft_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputMask(sender, e);
        }

        private void txtOverhangRight_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputMask(sender, e);
        }

        private void txtLenHole_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputMask(sender, e);
        }

        private void txtHeightHole_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputMask(sender, e);
        }

        private void txtDistLeftHole_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputMask(sender, e);
        }

        private void txtDensityHole_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputMask(sender, e);
        }

        public void InputMask(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                if (e.KeyChar != '-') e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).SelectionStart != 0))
            {
                e.Handled = true;
            }

        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            GridView.Rows.Clear();
            SF_BM_Chart.Series["SF"].Points.Clear();
            SF_BM_Chart.Series["BM"].Points.Clear();
            
            for (int i = 0; i < textBox.Count; i++)
            {
                textBox[i].Text = "";
            }
        }
    }
}
